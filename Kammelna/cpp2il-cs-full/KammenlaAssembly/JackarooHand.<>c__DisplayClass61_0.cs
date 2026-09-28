using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Jackaroo;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class JackarooHand : Hand
{
	private enum JackarooPlayingStage
	{
		None,
		SelectingMarble,
		SelectingAction,
		SelectingMarbleAndAction,
		SelectingFromPicker
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<JackarooMove, bool> <>9__42_0;

		public static Func<JackarooMove, bool> <>9__51_0;

		public static Func<JackarooMove, bool> <>9__56_0;

		public static Func<JackarooMove, bool> <>9__56_1;

		public static Func<JackarooMove, bool> <>9__56_2;

		public static Func<JackarooMove, bool> <>9__56_3;

		public static Func<JackarooMove, bool> <>9__60_1;

		public static Func<JackarooMove, bool> <>9__60_2;

		public static Func<GameCard, bool> <>9__68_0;

		public static Func<GameCard, Card> <>9__68_1;

		public static Func<Card, bool> <>9__68_2;

		public static Func<JackarooMove, bool> <>9__72_0;

		public static Func<JackarooMove, Card> <>9__72_1;

		public static Func<JackarooMove, Card> <>9__79_0;

		public static Func<GameCard, bool> <>9__81_0;

		public static Func<GameCard, Card> <>9__81_1;

		public static Func<JackarooMove, bool> <>9__81_2;

		public static Func<GameCard, bool> <>9__101_2;

		public static Func<StoreItem, int> <>9__104_1;

		public static Func<KeyValuePair<JackarooActions, StoreItem>, JackarooActions> <>9__110_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ShowTipsAndHighlights>b__42_0(JackarooMove move)
		{
			//IL_005d: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 16384;
				bool flag = obj == null;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ShouldPlayQueenAsTwoStates>b__51_0(JackarooMove move)
		{
			//IL_00a4: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 262144;
				bool flag = obj == null;
				object obj2 = !flag;
				object obj3 = ~obj2;
				if (obj3 == null)
				{
					object obj4 = move.<Action>k__BackingField - 65536;
					return obj4 == null;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleMarblePlay>b__56_0(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 65536;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleMarblePlay>b__56_1(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 262144;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleMarblePlay>b__56_2(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 32768;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HandleMarblePlay>b__56_3(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 8192;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <PlayTen>b__60_1(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 32768;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <PlayTen>b__60_2(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <DidHandChanged>b__68_0(GameCard gc)
		{
			//IL_0067: Expected I4, but got O
			if ((object)gc != null)
			{
				GameObject gameObject = gc.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <DidHandChanged>b__68_1(GameCard gc)
		{
			if ((object)gc != null)
			{
				return ((UiCard)gc).card;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal bool <DidHandChanged>b__68_2(Card gc)
		{
			bool flag = gc == null;
			return !flag;
		}

		internal bool <GetAllowedMoves>b__72_0(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 16384;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <GetAllowedMoves>b__72_1(JackarooMove jackarooAction)
		{
			if (jackarooAction != null)
			{
				return jackarooAction.<Card>k__BackingField;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal Card <ShowHandCards>b__79_0(JackarooMove jackarooAction)
		{
			if (jackarooAction != null)
			{
				return jackarooAction.<Card>k__BackingField;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal bool <ShowActualHandCards>b__81_0(GameCard card)
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

		internal Card <ShowActualHandCards>b__81_1(GameCard card)
		{
			if ((object)card != null)
			{
				return ((UiCard)card).card;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal bool <ShowActualHandCards>b__81_2(JackarooMove move)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (move != null)
			{
				object obj = move.<Action>k__BackingField - 16384;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UpdatePriceTag>b__101_2(GameCard card)
		{
			//IL_00b6: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			//IL_0056: Expected O, but got I8
			//IL_0061: Expected O, but got I4
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			if ((object)card != null)
			{
				object obj = card.<CardStatus>k__BackingField - 1;
				bool flag = obj == null;
				object obj2 = (long)card.<CardStatus>k__BackingField & 0xFFFFFFFEL;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					object obj5 = obj2 - 2;
					return obj5 == null;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <ApplyFireMode>b__104_1(StoreItem item)
		{
			//IL_0035: Expected I4, but got O
			if (item != null)
			{
				return item.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal JackarooActions <GetCardAllowedSpecialMoves>b__110_0(KeyValuePair<JackarooActions, StoreItem> pair)
		{
			//IL_000a: Expected I4, but got O
			return (JackarooActions)pair;
		}
	}

	private sealed class <>c__DisplayClass101_0
	{
		public JackarooHand <>4__this;

		public List<JackarooMove> specialAllowedMoves;

		internal bool <UpdatePriceTag>b__0(JackarooMove move)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00cb: Expected I4, but got O
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_0082: Expected O, but got I
			//IL_008e: Expected O, but got I
			//IL_00a9: Expected I, but got O
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = obj2 + 16;
				obj3 = move;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				JackarooHand jackarooHand = <>4__this;
				if ((object)<>4__this != null)
				{
					object obj4 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3488;
					object obj5 = (nint)0 + (nint)2040;
					object obj6 = (nint)0 + (nint)2448;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<KeyValuePair<System.Int32Enum, object>, bool> func = default(Func<KeyValuePair<System.Int32Enum, object>, bool>);
					func..ctor(obj2, (IntPtr)obj5);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D79FE0");
					bool result = default(bool);
					return result;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <UpdatePriceTag>b__1(GameCard gameCard)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00f0: Expected I4, but got O
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I
			//IL_00bf: Expected I, but got O
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = obj2 + 16;
				obj3 = gameCard;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj4 = obj3;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+28]");
					if ((nint)0 != 0)
					{
						object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
						object obj6 = (nint)0 + (nint)2048;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor(obj2, (IntPtr)obj6);
						return Enumerable.Any(specialAllowedMoves, func);
					}
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass101_1
	{
		public JackarooMove move;

		internal bool <UpdatePriceTag>b__3(KeyValuePair<JackarooActions, StoreItem> specialAction)
		{
			//IL_0039: Expected I4, but got O
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			JackarooMove jackarooMove = move;
			if (move != null)
			{
				object obj = jackarooMove.<Action>k__BackingField - specialAction;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass101_2
	{
		public GameCard gameCard;

		internal bool <UpdatePriceTag>b__4(JackarooMove move)
		{
			//IL_0095: Expected I4, but got O
			//IL_007d: Expected I, but got O
			if (move != null)
			{
				GameCard gameCard = this.gameCard;
				if ((object)this.gameCard != null)
				{
					Card <Card>k__BackingField = move.<Card>k__BackingField;
					if (move.<Card>k__BackingField != null)
					{
						nint num = (nint)<Card>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v33 @ X8_v3 (Il2CppClass<Card>)+138] (should have been resolved before IL gen)");
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass104_0
	{
		public GameCard specialGameCard;

		internal bool <ApplyFireMode>b__0(JackarooMove move)
		{
			//IL_0095: Expected I4, but got O
			//IL_007d: Expected I, but got O
			if (move != null)
			{
				GameCard gameCard = specialGameCard;
				if ((object)specialGameCard != null)
				{
					Card <Card>k__BackingField = move.<Card>k__BackingField;
					if (move.<Card>k__BackingField != null)
					{
						nint num = (nint)<Card>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v33 @ X8_v3 (Il2CppClass<Card>)+138] (should have been resolved before IL gen)");
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass110_0
	{
		public List<JackarooActions> cardActions;

		public Card card;

		public List<JackarooActions> cardSpecialActions;

		internal bool <GetCardAllowedSpecialMoves>b__1(JackarooActions action)
		{
			//IL_002c: Expected I4, but got O
			if (cardActions != null)
			{
				return ((List<System.Int32Enum>)(object)cardActions).Contains((System.Int32Enum)action);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCardAllowedSpecialMoves>b__2(JackarooMove move)
		{
			//IL_006c: Expected I4, but got O
			//IL_0054: Expected I, but got O
			if (move != null)
			{
				Card <Card>k__BackingField = move.<Card>k__BackingField;
				if (move.<Card>k__BackingField != null)
				{
					nint num = (nint)<Card>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v30 @ X9_v1 (Il2CppClass<Card>)+138] (should have been resolved before IL gen)");
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCardAllowedSpecialMoves>b__3(JackarooMove move)
		{
			//IL_0050: Expected I4, but got O
			if (move != null && cardSpecialActions != null)
			{
				return ((List<System.Int32Enum>)(object)cardSpecialActions).Contains((System.Int32Enum)move.<Action>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass50_0
	{
		public Card card;

		internal bool <TryPlayCard>b__0(GameCard gc)
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

	private sealed class <>c__DisplayClass52_0
	{
		public GameCard gameCard;

		internal void <SetCardPreplayAndOthersDimmed>b__0(GameCard playerCard)
		{
			if (!object.Equals(playerCard, gameCard))
			{
				playerCard.IsDimmed = true;
				playerCard.IsFireActive = false;
			}
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public JackarooHand <>4__this;

		public bool playCard;
	}

	private sealed class <>c__DisplayClass56_1
	{
		public JackarooMove move;

		public <>c__DisplayClass56_0 CS$<>8__locals1;

		internal void <HandleMarblePlay>b__4()
		{
			//IL_004c: Expected O, but got I4
			<>c__DisplayClass56_0 cS$<>8__locals = CS$<>8__locals1;
			JackarooHand <>4__this = cS$<>8__locals.<>4__this;
			cS$<>8__locals.<>4__this.DoPlayMove(move, <>4__this._selectedMovesByCard, cS$<>8__locals.playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass59_0
	{
		public Card clickedCard;

		public JackarooHand <>4__this;

		public JackarooMove move;

		public bool playCard;

		internal bool <PlayQueenBurnOrSteel>b__0(JackarooMove move)
		{
			//IL_0048: Expected I4, but got O
			if (move != null)
			{
				return object.Equals(move.<Card>k__BackingField, clickedCard);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <PlayQueenBurnOrSteel>b__1()
		{
			//IL_0034: Expected O, but got I4
			JackarooHand jackarooHand = <>4__this;
			<>4__this.DoPlayMove(move, jackarooHand._selectedMovesByCard, playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass60_0
	{
		public JackarooHand <>4__this;

		public bool playCard;

		internal void <PlayTen>g__SetupMovesMarbles|0(List<JackarooMove> moves)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0070: Expected I, but got O
			//IL_00a1: Expected I, but got O
			//IL_00e3: Expected O, but got I4
			//IL_0118: Expected O, but got I
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_014c: Expected O, but got I
			//IL_0158: Expected O, but got I
			//IL_035d: Expected O, but got I4
			//IL_0366: Expected O, but got I4
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected O, but got Unknown
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_0228: Expected O, but got I
			//IL_0268: Expected I, but got O
			//IL_0305: Expected I, but got O
			//IL_02a7: Expected O, but got I
			bool flag = (object)<>4__this == null;
			string text = (string)(object)moves;
			object obj7 = default(object);
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			if (!flag)
			{
				JackarooCardGameVisualControls jackarooGameVisualControls = <>4__this.JackarooGameVisualControls;
				bool flag2 = (object)jackarooGameVisualControls == null;
				text = null;
				if (!flag2)
				{
					object obj = "SERVICE_DISABLED" + 2600;
					text = (string)obj;
					jackarooGameVisualControls.ShowActionTipPanel((string)obj);
					bool flag3 = (object)<>4__this == null;
					nint num = unchecked((nint)null);
					if (!flag3)
					{
						JackarooBoardMono boardMono = <>4__this.boardMono;
						bool flag4 = (object)boardMono == null;
						num = unchecked((nint)null);
						text = null;
						if (!flag4)
						{
							boardMono.HighlightMoves(moves);
							bool flag5 = moves == null;
							object obj2 = 0;
							bool flag6 = true;
							num = 1;
							text = (string)(object)moves;
							if (!flag5)
							{
								object obj3 = (nint)0 + (nint)2800;
								object obj4 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 664;
								object obj5 = typeof(SqlSingle[]) + 2376;
								object obj6 = (nint)0 + (nint)2136;
								obj7 = (nint)0 + (nint)2792;
								List<object>.Enumerator enumerator = ((List<object>)(object)moves).GetEnumerator();
								flag6 = true;
								bool flag7 = true;
								List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
								object obj8 = default(object);
								string text2 = default(string);
								Action action = default(Action);
								while (true)
								{
									if (enumerator2.MoveNext())
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj8..ctor();
										if (obj8 != null)
										{
											object obj9 = obj8 + 24;
											obj9 = this;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj10 = obj8 + 16;
											obj10 = text2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj11 = obj10;
											if (obj10 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+20]");
												object obj12 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+20]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													action..ctor(obj8, (IntPtr)obj6);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+18]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+18]");
														((JackarooMarbleMono)0).SetupSelect(action);
														flag6 = false;
														flag7 = false;
														continue;
													}
													NullReferenceException ex = new NullReferenceException();
													flag6 = false;
													num = (nint)obj6;
													text = (string)obj8;
													break;
												}
												NullReferenceException ex2 = new NullReferenceException();
												num = (flag7 ? 1 : 0);
												text = text2;
												break;
											}
											NullReferenceException ex3 = new NullReferenceException();
											num = (flag7 ? 1 : 0);
											text = text2;
											break;
										}
										NullReferenceException ex4 = new NullReferenceException();
										num = (flag7 ? 1 : 0);
										text = null;
										break;
									}
									enumerator2.Dispose();
									return;
								}
								List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
								enumerator3 = enumerator4;
								enumerator4 = (List<object>.Enumerator)0;
								obj2 = 0;
							}
						}
					}
				}
			}
			NullReferenceException ex5 = new NullReferenceException();
			bool flag8 = (nint)text != 1;
			OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				text = (string)obj7;
				enumerator3.Dispose();
				object obj13 = default(object);
				if (obj13 == null)
				{
					return;
				}
				ex6 = new OutOfMemoryException();
				List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	private sealed class <>c__DisplayClass60_1
	{
		public JackarooMove burnMove;

		public List<JackarooMove> moves;

		public <>c__DisplayClass60_0 CS$<>8__locals1;

		internal void <PlayTen>b__3(JackarooActions action)
		{
			//IL_014a: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			<>c__DisplayClass60_0 cS$<>8__locals = CS$<>8__locals1;
			JackarooCardGameVisualControls jackarooGameVisualControls = cS$<>8__locals.<>4__this.JackarooGameVisualControls;
			jackarooGameVisualControls.HideActionTip();
			switch (action)
			{
			case JackarooActions.BURN_OTHER_CARD:
			{
				<>c__DisplayClass60_0 cS$<>8__locals4 = CS$<>8__locals1;
				JackarooHand <>4__this2 = cS$<>8__locals4.<>4__this;
				cS$<>8__locals4.<>4__this.DoPlayMove(burnMove, <>4__this2._selectedMovesByCard, cS$<>8__locals4.playCard, (GameAction?)(object)0);
				break;
			}
			case JackarooActions.MOVE:
			{
				List<JackarooMove> list = moves;
				<>c__DisplayClass60_0 cS$<>8__locals2 = CS$<>8__locals1;
				if (list._size == 1)
				{
					object move = ((List<object>)(object)list).get_Item(0);
					<>c__DisplayClass60_0 cS$<>8__locals3 = CS$<>8__locals1;
					JackarooHand <>4__this = cS$<>8__locals3.<>4__this;
					cS$<>8__locals2.<>4__this.DoPlayMove((JackarooMove)move, <>4__this._selectedMovesByCard, cS$<>8__locals3.playCard, (GameAction?)(object)0);
				}
				else
				{
					CS$<>8__locals1.<PlayTen>g__SetupMovesMarbles|0(list);
				}
				break;
			}
			}
		}
	}

	private sealed class <>c__DisplayClass60_2
	{
		public JackarooMove move;

		public <>c__DisplayClass60_0 CS$<>8__locals2;

		internal void <PlayTen>b__4()
		{
			//IL_004c: Expected O, but got I4
			<>c__DisplayClass60_0 cS$<>8__locals = CS$<>8__locals2;
			JackarooHand <>4__this = cS$<>8__locals.<>4__this;
			cS$<>8__locals.<>4__this.DoPlayMove(move, <>4__this._selectedMovesByCard, cS$<>8__locals.playCard, (GameAction?)(object)0);
			<>c__DisplayClass60_0 cS$<>8__locals2 = CS$<>8__locals2;
			JackarooCardGameVisualControls jackarooGameVisualControls = cS$<>8__locals2.<>4__this.JackarooGameVisualControls;
			jackarooGameVisualControls.HideActionsOptionsPanel();
		}
	}

	private sealed class <>c__DisplayClass61_0
	{
		public JackarooHand <>4__this;

		public bool playCard;

		public Func<JackarooMove, bool> <>9__2;

		internal bool <PlaySeven>b__2(JackarooMove jackarooMove)
		{
			//IL_007f: Expected I4, but got O
			if (jackarooMove != null)
			{
				JackarooHand jackarooHand = <>4__this;
				if ((object)<>4__this != null)
				{
					object obj = (object)jackarooMove.<Marble1>k__BackingField - (object)jackarooHand._selectedMarble1;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <PlaySeven>g__OnOptionSelected|0(JackarooActions action)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_08de: Expected O, but got I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_005f: Expected O, but got I4
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0092: Expected O, but got I
			//IL_009e: Expected O, but got I
			//IL_00aa: Expected O, but got I
			//IL_00c5: Expected I, but got O
			//IL_084b: Expected O, but got I
			//IL_00d2: Expected I, but got O
			//IL_011a: Expected O, but got I4
			//IL_023a: Expected O, but got I4
			//IL_016c: Expected O, but got I
			//IL_0174: Expected I, but got O
			//IL_01aa: Expected O, but got I4
			//IL_0286: Expected O, but got I4
			//IL_01e0: Expected O, but got I4
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Expected O, but got Unknown
			//IL_02d8: Expected O, but got I4
			//IL_02e6: Expected I, but got O
			//IL_021f: Expected O, but got I4
			//IL_0323: Expected O, but got I4
			//IL_0331: Expected I, but got O
			//IL_0367: Expected O, but got I4
			//IL_0375: Expected I, but got O
			//IL_03a3: Expected O, but got I
			//IL_03ab: Expected I, but got O
			//IL_03da: Expected O, but got I4
			//IL_042c: Expected O, but got I
			//IL_043b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0440: Expected O, but got Unknown
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Expected O, but got Unknown
			//IL_0460: Expected O, but got I
			//IL_07f9: Expected O, but got I4
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Expected O, but got Unknown
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Expected O, but got Unknown
			//IL_0545: Expected O, but got I
			//IL_0589: Expected O, but got I
			//IL_05e5: Expected O, but got I
			//IL_07bb: Expected O, but got I
			//IL_0662: Expected I, but got O
			//IL_07da: Expected I, but got O
			//IL_069c: Expected O, but got I
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			bool flag = obj2 == null;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
			<>c__DisplayClass61_0 <>c__DisplayClass61_ = null;
			if (!flag)
			{
				object obj3 = obj2 + 24;
				obj3 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				JackarooHand jackarooHand = <>4__this;
				bool flag2 = (object)<>4__this == null;
				enumerator = (List<object>.Enumerator)0;
				<>c__DisplayClass61_ = this;
				if (!flag2)
				{
					object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
					object obj5 = (nint)0 + (nint)2176;
					object obj6 = (nint)0 + (nint)3536;
					object obj7 = (nint)0 + (nint)2256;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj5);
					nint num = (nint)obj6;
					IEnumerable<object> source = Enumerable.Where(jackarooHand._selectedMovesByCard, func);
					<>c__DisplayClass61_ = (<>c__DisplayClass61_0)obj7;
					List<object> list = Enumerable.ToList(source);
					bool flag3 = list == null;
					enumerator = (List<object>.Enumerator)0;
					bool flag4 = false;
					if (!flag3)
					{
						JackarooHand jackarooHand2 = <>4__this;
						if (list._size == 1)
						{
							object obj8 = (nint)0 + (nint)2360;
							num = (nint)obj8;
							object move = list.get_Item(0);
							JackarooHand jackarooHand3 = <>4__this;
							bool flag5 = (object)<>4__this == null;
							enumerator = (List<object>.Enumerator)0;
							flag4 = false;
							<>c__DisplayClass61_ = null;
							if (!flag5)
							{
								bool flag6 = (object)<>4__this == null;
								enumerator = (List<object>.Enumerator)0;
								flag4 = false;
								<>c__DisplayClass61_ = null;
								if (!flag6)
								{
									<>4__this.DoPlayMove((JackarooMove)move, jackarooHand3._selectedMovesByCard, playCard, (GameAction?)(object)0);
									return;
								}
							}
						}
						else
						{
							bool flag7 = (object)<>4__this == null;
							enumerator = (List<object>.Enumerator)0;
							flag4 = false;
							if (!flag7)
							{
								jackarooHand2.<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
								JackarooCardGameVisualControls jackarooGameVisualControls = <>4__this.JackarooGameVisualControls;
								bool flag8 = (object)jackarooGameVisualControls == null;
								enumerator = (List<object>.Enumerator)0;
								flag4 = false;
								<>c__DisplayClass61_ = null;
								if (!flag8)
								{
									object obj9 = "SERVICE_DISABLED" + 2608;
									jackarooGameVisualControls.ShowActionTipPanel((string)obj9);
									bool flag9 = (object)<>4__this == null;
									enumerator = (List<object>.Enumerator)0;
									flag4 = false;
									num = unchecked((nint)null);
									<>c__DisplayClass61_ = (<>c__DisplayClass61_0)obj9;
									if (!flag9)
									{
										JackarooBoardMono boardMono = <>4__this.boardMono;
										bool flag10 = (object)boardMono == null;
										enumerator = (List<object>.Enumerator)0;
										flag4 = false;
										num = unchecked((nint)null);
										<>c__DisplayClass61_ = null;
										if (!flag10)
										{
											boardMono.HideHighlights();
											bool flag11 = (object)<>4__this == null;
											enumerator = (List<object>.Enumerator)0;
											flag4 = false;
											num = unchecked((nint)null);
											<>c__DisplayClass61_ = null;
											if (!flag11)
											{
												JackarooBoardMono boardMono2 = <>4__this.boardMono;
												object obj10 = (nint)0 + (nint)2360;
												num = (nint)obj10;
												object move2 = list.get_Item(0);
												bool flag12 = (object)boardMono2 == null;
												enumerator = (List<object>.Enumerator)0;
												flag4 = false;
												<>c__DisplayClass61_ = null;
												if (!flag12)
												{
													boardMono2.HighlightMove((JackarooMove)move2, highlightGuarded: true);
													List<object>.Enumerator enumerator2 = list.GetEnumerator();
													object obj11 = (nint)0 + (nint)2800;
													object obj12 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 704;
													object obj13 = typeof(SqlSingle[]) + 2376;
													object obj14 = (nint)0 + (nint)2184;
													flag4 = false;
													bool flag13 = true;
													List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
													object obj15 = default(object);
													<>c__DisplayClass61_0 <>c__DisplayClass61_2 = default(<>c__DisplayClass61_0);
													Action action2 = default(Action);
													while (true)
													{
														if (enumerator3.MoveNext())
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															obj15..ctor();
															if (obj15 != null)
															{
																object obj16 = obj15 + 24;
																obj16 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																object obj17 = obj15 + 16;
																obj17 = <>c__DisplayClass61_2;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																object obj18 = obj17;
																if (obj17 != null)
																{
																	if ((object)<>4__this != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v24+30]");
																		object obj19 = 0;
																		JackarooBoardMono boardMono3 = <>4__this.boardMono;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v24+30]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X23_v8+20]");
																			object obj20 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X23_v8+20]");
																			if ((nint)0 != 0)
																			{
																				if ((object)boardMono3 != null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v25+18]");
																					boardMono3.HighlightFirstNode((JackarooNodeMono)0);
																					if ((object)<>4__this != null)
																					{
																						JackarooBoardMono boardMono4 = <>4__this.boardMono;
																						if ((object)boardMono4 != null)
																						{
																							boardMono4.HighlightMove2((JackarooMove)obj17, animateFirstNode: true);
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																							action2..ctor(obj15, (IntPtr)obj14);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X23_v8+18]");
																							if ((nint)0 != 0)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X23_v8+18]");
																								((JackarooMarbleMono)0).SetupSelect(action2);
																								flag4 = false;
																								flag13 = false;
																								continue;
																							}
																							NullReferenceException ex = new NullReferenceException();
																							flag4 = false;
																							num = (nint)obj14;
																							<>c__DisplayClass61_ = (<>c__DisplayClass61_0)obj15;
																							break;
																						}
																						NullReferenceException ex2 = new NullReferenceException();
																						flag4 = false;
																						num = 1;
																						<>c__DisplayClass61_ = null;
																						break;
																					}
																					NullReferenceException ex3 = new NullReferenceException();
																					flag4 = false;
																					num = 1;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v25+18]");
																					<>c__DisplayClass61_ = (<>c__DisplayClass61_0)0;
																					break;
																				}
																				NullReferenceException ex4 = new NullReferenceException();
																				num = (flag13 ? 1 : 0);
																				<>c__DisplayClass61_ = null;
																				break;
																			}
																			NullReferenceException ex5 = new NullReferenceException();
																			num = (flag13 ? 1 : 0);
																			<>c__DisplayClass61_ = null;
																			break;
																		}
																		NullReferenceException ex6 = new NullReferenceException();
																		num = (flag13 ? 1 : 0);
																		<>c__DisplayClass61_ = null;
																		break;
																	}
																	NullReferenceException ex7 = new NullReferenceException();
																	num = (flag13 ? 1 : 0);
																	<>c__DisplayClass61_ = <>c__DisplayClass61_2;
																	break;
																}
																NullReferenceException ex8 = new NullReferenceException();
																num = (flag13 ? 1 : 0);
																<>c__DisplayClass61_ = <>c__DisplayClass61_2;
																break;
															}
															NullReferenceException ex9 = new NullReferenceException();
															num = (flag13 ? 1 : 0);
															<>c__DisplayClass61_ = null;
															break;
														}
														enumerator3.Dispose();
														return;
													}
													List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
													enumerator = enumerator4;
													enumerator4 = (List<object>.Enumerator)0;
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
			NullReferenceException ex10 = new NullReferenceException();
			bool flag14 = (nint)<>c__DisplayClass61_ != 1;
			OutOfMemoryException ex11 = (OutOfMemoryException)(object)ex10;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj21 = (nint)0 + (nint)2792;
				<>c__DisplayClass61_ = (<>c__DisplayClass61_0)obj21;
				enumerator.Dispose();
				object obj22 = default(object);
				if (obj22 == null)
				{
					return;
				}
				ex11 = new OutOfMemoryException();
				List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj22;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	private sealed class <>c__DisplayClass61_1
	{
		public JackarooMove move;

		public <>c__DisplayClass61_0 CS$<>8__locals1;

		internal void <PlaySeven>g__OnMarbleSelected|1()
		{
			//IL_12c2: Expected O, but got I4
			//IL_0f3b: Expected O, but got I
			//IL_0029: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_007c: Expected I, but got O
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00cf: Expected O, but got I4
			//IL_1236: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_010d: Expected O, but got I4
			//IL_0127: Expected O, but got I
			//IL_0133: Expected O, but got I
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0165: Expected O, but got I4
			//IL_01e2: Expected I4, but got O
			//IL_01f7: Expected O, but got I
			//IL_0203: Expected I, but got O
			//IL_022d: Expected O, but got I4
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected O, but got Unknown
			//IL_019d: Expected O, but got I
			//IL_01b0: Expected I, but got O
			//IL_03a0: Expected O, but got I4
			//IL_0284: Expected O, but got I4
			//IL_03cb: Expected O, but got I4
			//IL_029e: Expected O, but got I
			//IL_02a6: Expected I4, but got O
			//IL_02dc: Expected O, but got I4
			//IL_02e1: Expected I, but got O
			//IL_0403: Expected O, but got I4
			//IL_0408: Expected I, but got O
			//IL_0319: Expected O, but got I4
			//IL_031e: Expected I, but got O
			//IL_0443: Expected O, but got I4
			//IL_0448: Expected I, but got O
			//IL_0349: Expected O, but got I4
			//IL_034e: Expected I, but got O
			//IL_0473: Expected O, but got I4
			//IL_0478: Expected I, but got O
			//IL_0385: Expected O, but got I4
			//IL_04b0: Expected O, but got I4
			//IL_04b5: Expected I, but got O
			//IL_04f0: Expected O, but got I4
			//IL_04f5: Expected I, but got O
			//IL_0520: Expected O, but got I4
			//IL_0525: Expected I, but got O
			//IL_0569: Expected O, but got I4
			//IL_056e: Expected I, but got O
			//IL_05a6: Expected O, but got I4
			//IL_05ab: Expected I, but got O
			//IL_05e3: Expected O, but got I4
			//IL_05e8: Expected I, but got O
			//IL_0620: Expected O, but got I4
			//IL_0625: Expected I, but got O
			//IL_064b: Expected O, but got I4
			//IL_0650: Expected I, but got O
			//IL_0699: Expected O, but got I4
			//IL_06b8: Expected I, but got O
			//IL_06e3: Expected O, but got I4
			//IL_0702: Expected I, but got O
			//IL_073a: Expected O, but got I4
			//IL_0751: Expected I, but got O
			//IL_078d: Expected O, but got I
			//IL_0ccb: Expected O, but got I4
			//IL_0cd0: Expected I, but got O
			//IL_0f62: Expected O, but got I4
			//IL_08d7: Expected O, but got I4
			//IL_08dc: Expected I, but got O
			//IL_0d18: Expected O, but got I4
			//IL_0d1d: Expected I, but got O
			//IL_0f91: Expected O, but got I4
			//IL_0924: Expected O, but got I4
			//IL_0929: Expected I, but got O
			//IL_0829: Expected O, but got I4
			//IL_082e: Expected I, but got O
			//IL_0d73: Expected O, but got I4
			//IL_0d78: Expected I, but got O
			//IL_097f: Expected O, but got I4
			//IL_0984: Expected I, but got O
			//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d95: Expected O, but got Unknown
			//IL_0dd6: Expected O, but got I4
			//IL_0de7: Expected I, but got O
			//IL_099c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a1: Expected O, but got Unknown
			//IL_0e22: Expected O, but got I4
			//IL_0e33: Expected I, but got O
			//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d4: Expected O, but got Unknown
			//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e8: Expected O, but got Unknown
			//IL_09f4: Expected O, but got I
			//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e67: Expected O, but got Unknown
			//IL_0e82: Expected O, but got I
			//IL_0e95: Expected I, but got O
			//IL_0ebd: Expected O, but got I4
			//IL_0ece: Expected I4, but got O
			//IL_0ed8: Expected I, but got O
			//IL_1093: Expected O, but got I4
			//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a45: Expected O, but got Unknown
			//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a62: Expected O, but got Unknown
			//IL_10bf: Expected O, but got I4
			//IL_0fec: Expected O, but got I4
			//IL_101b: Expected O, but got I4
			//IL_0af9: Expected O, but got I
			//IL_0fc0: Expected O, but got I4
			//IL_0b40: Expected O, but got I
			//IL_10ee: Expected O, but got I4
			//IL_111a: Expected O, but got I4
			//IL_0b9c: Expected O, but got I
			//IL_104a: Expected O, but got I4
			//IL_106c: Expected O, but got I
			//IL_1146: Expected O, but got I4
			//IL_1168: Expected O, but got I
			//IL_118f: Expected O, but got I4
			//IL_0c3f: Expected I, but got O
			//IL_0c50: Expected I, but got O
			//IL_11cd: Expected O, but got I4
			//IL_0c8a: Expected O, but got I
			<>c__DisplayClass61_0 cS$<>8__locals = CS$<>8__locals1;
			bool flag = CS$<>8__locals1 == null;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
			nint num = default(nint);
			bool flag8 = default(bool);
			NullReferenceException ex;
			List<object>.Enumerator enumerator6;
			object obj12;
			List<object>.Enumerator enumerator4;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			nint num2;
			if (!flag)
			{
				JackarooMove jackarooMove = move;
				bool flag2 = move == null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag2)
				{
					JackarooHand <>4__this = cS$<>8__locals.<>4__this;
					bool flag3 = (object)cS$<>8__locals.<>4__this == null;
					enumerator = (List<object>.Enumerator)0;
					if (!flag3)
					{
						num = (nint)jackarooMove.<Marble1>k__BackingField;
						<>4__this._selectedMarble1 = jackarooMove.<Marble1>k__BackingField;
						object obj = cS$<>8__locals.<>4__this + 264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object cS$<>8__locals2 = CS$<>8__locals1;
						bool flag4 = CS$<>8__locals1 == null;
						enumerator = (List<object>.Enumerator)0;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X20_v7 (System.Object)+10]");
							object obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X20_v7 (System.Object)+10]");
							bool flag5 = (nint)0 == 0;
							enumerator = (List<object>.Enumerator)0;
							if (!flag5)
							{
								object obj3 = (nint)0 + (nint)3536;
								object obj4 = (nint)0 + (nint)2256;
								object obj5 = CS$<>8__locals1 + 32;
								Func<object, bool> predicate = (Func<object, bool>)obj5;
								bool flag6 = obj5 == null;
								object obj6 = !flag6;
								if (obj6 == null)
								{
									object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj8 = (nint)0 + (nint)2144;
									Func<object, bool> func = default(Func<object, bool>);
									func..ctor((object)CS$<>8__locals1, (IntPtr)obj8);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag7 = false;
									predicate = func;
								}
								flag8 = (byte)(int)obj3 != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v11+110]");
								IEnumerable<object> source = Enumerable.Where((IEnumerable<object>)0, predicate);
								num = (nint)obj4;
								List<object> list = Enumerable.ToList(source);
								bool flag9 = list == null;
								enumerator = (List<object>.Enumerator)0;
								if (!flag9)
								{
									<>c__DisplayClass61_0 cS$<>8__locals3 = CS$<>8__locals1;
									if (list._size == 1)
									{
										bool flag10 = CS$<>8__locals1 == null;
										enumerator = (List<object>.Enumerator)0;
										if (!flag10)
										{
											object obj9 = (nint)0 + (nint)2360;
											flag8 = (byte)(int)obj9 != 0;
											object obj10 = list.get_Item(0);
											<>c__DisplayClass61_0 cS$<>8__locals4 = CS$<>8__locals1;
											bool flag11 = CS$<>8__locals1 == null;
											enumerator = (List<object>.Enumerator)0;
											num = unchecked((nint)null);
											if (!flag11)
											{
												JackarooHand <>4__this2 = cS$<>8__locals4.<>4__this;
												bool flag12 = (object)cS$<>8__locals4.<>4__this == null;
												enumerator = (List<object>.Enumerator)0;
												num = unchecked((nint)null);
												if (!flag12)
												{
													bool flag13 = (object)cS$<>8__locals3.<>4__this == null;
													enumerator = (List<object>.Enumerator)0;
													num = unchecked((nint)null);
													if (!flag13)
													{
														cS$<>8__locals3.<>4__this.DoPlayMove((JackarooMove)obj10, <>4__this2._selectedMovesByCard, cS$<>8__locals4.playCard, (GameAction?)(object)0);
														return;
													}
												}
											}
										}
									}
									else
									{
										bool flag14 = CS$<>8__locals1 == null;
										enumerator = (List<object>.Enumerator)0;
										if (!flag14)
										{
											bool flag15 = (object)cS$<>8__locals3.<>4__this == null;
											enumerator = (List<object>.Enumerator)0;
											if (!flag15)
											{
												JackarooCardGameVisualControls jackarooGameVisualControls = cS$<>8__locals3.<>4__this.JackarooGameVisualControls;
												bool flag16 = (object)jackarooGameVisualControls == null;
												enumerator = (List<object>.Enumerator)0;
												num = unchecked((nint)null);
												if (!flag16)
												{
													jackarooGameVisualControls.HideActionTip();
													<>c__DisplayClass61_0 cS$<>8__locals5 = CS$<>8__locals1;
													bool flag17 = CS$<>8__locals1 == null;
													enumerator = (List<object>.Enumerator)0;
													num = unchecked((nint)null);
													if (!flag17)
													{
														bool flag18 = (object)cS$<>8__locals5.<>4__this == null;
														enumerator = (List<object>.Enumerator)0;
														num = unchecked((nint)null);
														if (!flag18)
														{
															JackarooBoardMono boardMono = cS$<>8__locals5.<>4__this.boardMono;
															bool flag19 = (object)boardMono == null;
															enumerator = (List<object>.Enumerator)0;
															num = unchecked((nint)null);
															if (!flag19)
															{
																boardMono.HideHighlights();
																<>c__DisplayClass61_0 cS$<>8__locals6 = CS$<>8__locals1;
																bool flag20 = CS$<>8__locals1 == null;
																enumerator = (List<object>.Enumerator)0;
																num = unchecked((nint)null);
																if (!flag20)
																{
																	bool flag21 = (object)cS$<>8__locals6.<>4__this == null;
																	enumerator = (List<object>.Enumerator)0;
																	num = unchecked((nint)null);
																	if (!flag21)
																	{
																		JackarooBoardMono boardMono2 = cS$<>8__locals6.<>4__this.boardMono;
																		<>c__DisplayClass61_0 cS$<>8__locals7 = CS$<>8__locals1;
																		bool flag22 = CS$<>8__locals1 == null;
																		enumerator = (List<object>.Enumerator)0;
																		num = unchecked((nint)null);
																		if (!flag22)
																		{
																			JackarooHand <>4__this3 = cS$<>8__locals7.<>4__this;
																			bool flag23 = (object)cS$<>8__locals7.<>4__this == null;
																			enumerator = (List<object>.Enumerator)0;
																			num = unchecked((nint)null);
																			if (!flag23)
																			{
																				JackarooMarble selectedMarble = <>4__this3._selectedMarble1;
																				bool flag24 = <>4__this3._selectedMarble1 == null;
																				enumerator = (List<object>.Enumerator)0;
																				num = unchecked((nint)null);
																				if (!flag24)
																				{
																					JackarooNode <Node>k__BackingField = selectedMarble.<Node>k__BackingField;
																					bool flag25 = selectedMarble.<Node>k__BackingField == null;
																					enumerator = (List<object>.Enumerator)0;
																					num = unchecked((nint)null);
																					if (!flag25)
																					{
																						bool flag26 = (object)boardMono2 == null;
																						enumerator = (List<object>.Enumerator)0;
																						num = unchecked((nint)null);
																						if (!flag26)
																						{
																							boardMono2.HighlightFirstNode(<Node>k__BackingField.<NodeMono>k__BackingField, animate: false);
																							<>c__DisplayClass61_0 cS$<>8__locals8 = CS$<>8__locals1;
																							bool flag27 = CS$<>8__locals1 == null;
																							enumerator = (List<object>.Enumerator)0;
																							bool flag7 = false;
																							flag8 = false;
																							num = (nint)<Node>k__BackingField.<NodeMono>k__BackingField;
																							if (!flag27)
																							{
																								bool flag28 = (object)cS$<>8__locals8.<>4__this == null;
																								enumerator = (List<object>.Enumerator)0;
																								flag7 = false;
																								flag8 = false;
																								num = (nint)<Node>k__BackingField.<NodeMono>k__BackingField;
																								if (!flag28)
																								{
																									JackarooBoardMono boardMono3 = cS$<>8__locals8.<>4__this.boardMono;
																									bool flag29 = (object)boardMono3 == null;
																									enumerator = (List<object>.Enumerator)0;
																									flag7 = false;
																									flag8 = false;
																									num = unchecked((nint)null);
																									if (!flag29)
																									{
																										boardMono3.HighlightGuardedMarbles(move);
																										List<object>.Enumerator enumerator2 = list.GetEnumerator();
																										object obj11 = (nint)0 + (nint)2800;
																										flag7 = false;
																										flag8 = false;
																										object obj13 = default(object);
																										while (true)
																										{
																											obj12 = obj11;
																											if (!enumerator.MoveNext())
																											{
																												break;
																											}
																											<>c__DisplayClass61_0 cS$<>8__locals9 = CS$<>8__locals1;
																											if (CS$<>8__locals1 == null)
																											{
																												goto IL_0f40;
																											}
																											if ((object)cS$<>8__locals9.<>4__this != null)
																											{
																												JackarooBoardMono boardMono4 = cS$<>8__locals9.<>4__this.boardMono;
																												bool flag30 = (object)boardMono4 == null;
																												enumerator = enumerator3;
																												enumerator4 = enumerator3;
																												enumerator3 = (List<object>.Enumerator)0;
																												num = unchecked((nint)null);
																												if (!flag30)
																												{
																													boardMono4.HighlightMove((JackarooMove)obj13);
																													flag7 = false;
																													flag8 = false;
																													continue;
																												}
																												goto IL_0f1a;
																											}
																											goto IL_0f6f;
																										}
																										enumerator.Dispose();
																										bool flag31 = JackarooActionsExtensions.AllSameSplit1Move((List<JackarooMove>)(object)list);
																										<>c__DisplayClass61_0 cS$<>8__locals10 = CS$<>8__locals1;
																										if (flag31)
																										{
																											bool flag32 = CS$<>8__locals1 == null;
																											enumerator = enumerator3;
																											enumerator4 = enumerator3;
																											enumerator3 = (List<object>.Enumerator)0;
																											num = unchecked((nint)null);
																											if (!flag32)
																											{
																												JackarooHand <>4__this4 = cS$<>8__locals10.<>4__this;
																												bool flag33 = (object)cS$<>8__locals10.<>4__this == null;
																												enumerator = enumerator3;
																												enumerator4 = enumerator3;
																												enumerator3 = (List<object>.Enumerator)0;
																												num = unchecked((nint)null);
																												if (!flag33)
																												{
																													<>4__this4.<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
																													JackarooCardGameVisualControls jackarooGameVisualControls2 = cS$<>8__locals10.<>4__this.JackarooGameVisualControls;
																													bool flag34 = (object)jackarooGameVisualControls2 == null;
																													enumerator = enumerator3;
																													enumerator4 = enumerator3;
																													enumerator3 = (List<object>.Enumerator)0;
																													num = unchecked((nint)null);
																													if (!flag34)
																													{
																														object tip = "SERVICE_DISABLED" + 2608;
																														jackarooGameVisualControls2.ShowActionTipPanel((string)tip);
																														List<object>.Enumerator enumerator5 = list.GetEnumerator();
																														object obj14 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 688;
																														object obj15 = typeof(SqlSingle[]) + 2376;
																														object obj16 = (nint)0 + (nint)2168;
																														num2 = 0;
																														object obj17 = default(object);
																														Action action = default(Action);
																														while (true)
																														{
																															if (enumerator.MoveNext())
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																obj17..ctor();
																																if (obj17 != null)
																																{
																																	object obj18 = obj17 + 24;
																																	obj18 = this;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	object obj19 = obj17 + 16;
																																	obj19 = obj13;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	object obj20 = obj19;
																																	if (obj19 != null)
																																	{
																																		<>c__DisplayClass61_0 cS$<>8__locals11 = CS$<>8__locals1;
																																		if (CS$<>8__locals1 != null)
																																		{
																																			if ((object)cS$<>8__locals11.<>4__this != null)
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v45+30]");
																																				object obj21 = 0;
																																				JackarooBoardMono boardMono5 = cS$<>8__locals11.<>4__this.boardMono;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v45+30]");
																																				if ((nint)0 != 0)
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X22_v12+20]");
																																					object obj22 = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X22_v12+20]");
																																					if ((nint)0 != 0)
																																					{
																																						if ((object)boardMono5 != null)
																																						{
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v46+18]");
																																							boardMono5.HighlightFirstNode((JackarooNodeMono)0);
																																							<>c__DisplayClass61_0 cS$<>8__locals12 = CS$<>8__locals1;
																																							if (CS$<>8__locals1 != null)
																																							{
																																								if ((object)cS$<>8__locals12.<>4__this != null)
																																								{
																																									JackarooBoardMono boardMono6 = cS$<>8__locals12.<>4__this.boardMono;
																																									if ((object)boardMono6 != null)
																																									{
																																										boardMono6.HighlightMove2((JackarooMove)obj19, animateFirstNode: true);
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																										num2 = (nint)obj16;
																																										action..ctor(obj17, (IntPtr)obj16);
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X22_v12+18]");
																																										if ((nint)0 != 0)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X22_v12+18]");
																																											((JackarooMarbleMono)0).SetupSelect(action);
																																											flag7 = false;
																																											num2 = 0;
																																											continue;
																																										}
																																										ex = new NullReferenceException();
																																										enumerator6 = enumerator3;
																																										enumerator4 = enumerator3;
																																										enumerator3 = (List<object>.Enumerator)0;
																																										flag7 = false;
																																										obj12 = obj17;
																																										break;
																																									}
																																									ex = new NullReferenceException();
																																									enumerator6 = enumerator3;
																																									enumerator4 = enumerator3;
																																									enumerator3 = (List<object>.Enumerator)0;
																																									flag7 = false;
																																									num2 = 1;
																																									obj12 = null;
																																									break;
																																								}
																																								ex = new NullReferenceException();
																																								enumerator6 = enumerator3;
																																								enumerator4 = enumerator3;
																																								enumerator3 = (List<object>.Enumerator)0;
																																								flag7 = false;
																																								num2 = 1;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v46+18]");
																																								obj12 = 0;
																																								break;
																																							}
																																							ex = new NullReferenceException();
																																							enumerator6 = enumerator3;
																																							enumerator4 = enumerator3;
																																							enumerator3 = (List<object>.Enumerator)0;
																																							flag7 = false;
																																							num2 = 1;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v46+18]");
																																							obj12 = 0;
																																							break;
																																						}
																																						ex = new NullReferenceException();
																																						enumerator6 = enumerator3;
																																						enumerator4 = enumerator3;
																																						enumerator3 = (List<object>.Enumerator)0;
																																						obj12 = null;
																																						break;
																																					}
																																					ex = new NullReferenceException();
																																					enumerator6 = enumerator3;
																																					enumerator4 = enumerator3;
																																					enumerator3 = (List<object>.Enumerator)0;
																																					obj12 = null;
																																					break;
																																				}
																																				ex = new NullReferenceException();
																																				enumerator6 = enumerator3;
																																				enumerator4 = enumerator3;
																																				enumerator3 = (List<object>.Enumerator)0;
																																				obj12 = null;
																																				break;
																																			}
																																			ex = new NullReferenceException();
																																			enumerator6 = enumerator3;
																																			enumerator4 = enumerator3;
																																			enumerator3 = (List<object>.Enumerator)0;
																																			obj12 = obj13;
																																			break;
																																		}
																																		ex = new NullReferenceException();
																																		enumerator6 = enumerator3;
																																		enumerator4 = enumerator3;
																																		enumerator3 = (List<object>.Enumerator)0;
																																		obj12 = obj13;
																																		break;
																																	}
																																	ex = new NullReferenceException();
																																	enumerator6 = enumerator3;
																																	enumerator4 = enumerator3;
																																	enumerator3 = (List<object>.Enumerator)0;
																																	obj12 = obj13;
																																	break;
																																}
																																ex = new NullReferenceException();
																																enumerator6 = enumerator3;
																																enumerator4 = enumerator3;
																																enumerator3 = (List<object>.Enumerator)0;
																																obj12 = null;
																																break;
																															}
																															enumerator.Dispose();
																															return;
																														}
																														goto IL_11e9;
																													}
																												}
																											}
																										}
																										else
																										{
																											bool flag35 = CS$<>8__locals1 == null;
																											enumerator = enumerator3;
																											enumerator4 = enumerator3;
																											enumerator3 = (List<object>.Enumerator)0;
																											num = unchecked((nint)null);
																											if (!flag35)
																											{
																												JackarooHand <>4__this5 = cS$<>8__locals10.<>4__this;
																												bool flag36 = (object)cS$<>8__locals10.<>4__this == null;
																												enumerator = enumerator3;
																												enumerator4 = enumerator3;
																												enumerator3 = (List<object>.Enumerator)0;
																												num = unchecked((nint)null);
																												if (!flag36)
																												{
																													<>4__this5.<playingStage>k__BackingField = JackarooPlayingStage.SelectingAction;
																													JackarooCardGameVisualControls jackarooGameVisualControls3 = cS$<>8__locals10.<>4__this.JackarooGameVisualControls;
																													bool flag37 = (object)jackarooGameVisualControls3 == null;
																													enumerator = enumerator3;
																													enumerator4 = enumerator3;
																													enumerator3 = (List<object>.Enumerator)0;
																													num = unchecked((nint)null);
																													if (!flag37)
																													{
																														object obj23 = "SERVICE_DISABLED" + 2560;
																														jackarooGameVisualControls3.ShowActionTipPanel((string)obj23);
																														<>c__DisplayClass61_0 cS$<>8__locals13 = CS$<>8__locals1;
																														bool flag38 = CS$<>8__locals1 == null;
																														enumerator = enumerator3;
																														enumerator4 = enumerator3;
																														enumerator3 = (List<object>.Enumerator)0;
																														flag8 = false;
																														num = (nint)obj23;
																														if (!flag38)
																														{
																															bool flag39 = (object)cS$<>8__locals13.<>4__this == null;
																															enumerator = enumerator3;
																															enumerator4 = enumerator3;
																															enumerator3 = (List<object>.Enumerator)0;
																															flag8 = false;
																															num = (nint)obj23;
																															if (!flag39)
																															{
																																JackarooCardGameVisualControls jackarooGameVisualControls4 = cS$<>8__locals13.<>4__this.JackarooGameVisualControls;
																																object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2440;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																object obj25 = (nint)0 + (nint)2152;
																																Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
																																action2..ctor((object)CS$<>8__locals1, (IntPtr)obj25);
																																bool flag40 = (object)jackarooGameVisualControls4 == null;
																																enumerator = enumerator3;
																																enumerator4 = enumerator3;
																																enumerator3 = (List<object>.Enumerator)0;
																																flag7 = false;
																																flag8 = (byte)(int)obj25 != 0;
																																num = (nint)CS$<>8__locals1;
																																if (!flag40)
																																{
																																	jackarooGameVisualControls4.ShowActionsOptionsPanel((List<JackarooMove>)(object)list, (Action<JackarooActions>)(object)action2);
																																	return;
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
											}
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0f1a;
			IL_0f1a:
			ex = new NullReferenceException();
			enumerator6 = enumerator;
			num2 = (flag8 ? 1 : 0);
			obj12 = num;
			goto IL_11e9;
			IL_0f6f:
			ex = new NullReferenceException();
			enumerator6 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			num2 = (flag8 ? 1 : 0);
			goto IL_11e9;
			IL_11e9:
			bool flag41 = (nint)obj12 != 1;
			OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex;
			if (!flag41)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj26 = (nint)0 + (nint)2792;
				obj12 = obj26;
				enumerator6.Dispose();
				object obj27 = default(object);
				if (obj27 == null)
				{
					return;
				}
				ex3 = new OutOfMemoryException();
				enumerator3 = (List<object>.Enumerator)obj27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0f40:
			ex = new NullReferenceException();
			enumerator6 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			num2 = (flag8 ? 1 : 0);
			goto IL_11e9;
		}
	}

	private sealed class <>c__DisplayClass61_2
	{
		public JackarooMove jackarooMove;

		public <>c__DisplayClass61_1 CS$<>8__locals2;

		internal void <PlaySeven>b__3()
		{
			//IL_005e: Expected O, but got I4
			<>c__DisplayClass61_1 cS$<>8__locals = CS$<>8__locals2;
			<>c__DisplayClass61_0 cS$<>8__locals2 = cS$<>8__locals.CS$<>8__locals1;
			JackarooHand <>4__this = cS$<>8__locals2.<>4__this;
			cS$<>8__locals2.<>4__this.DoPlayMove(jackarooMove, <>4__this._selectedMovesByCard, cS$<>8__locals2.playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass61_3
	{
		public JackarooActions action;

		public <>c__DisplayClass61_0 CS$<>8__locals3;

		internal bool <PlaySeven>b__4(JackarooMove jackarooMove)
		{
			//IL_00d7: Expected I4, but got O
			//IL_00b5: Expected O, but got I4
			if (jackarooMove != null)
			{
				<>c__DisplayClass61_0 cS$<>8__locals = CS$<>8__locals3;
				if (CS$<>8__locals3 != null)
				{
					JackarooHand <>4__this = cS$<>8__locals.<>4__this;
					if ((object)cS$<>8__locals.<>4__this != null)
					{
						if (jackarooMove.<Marble1>k__BackingField != <>4__this._selectedMarble1)
						{
							return false;
						}
						object obj = jackarooMove.<Action>k__BackingField - action;
						return obj == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass61_4
	{
		public JackarooMove move;

		public <>c__DisplayClass61_3 CS$<>8__locals4;

		internal void <PlaySeven>b__5()
		{
			//IL_005e: Expected O, but got I4
			<>c__DisplayClass61_3 cS$<>8__locals = CS$<>8__locals4;
			<>c__DisplayClass61_0 cS$<>8__locals2 = cS$<>8__locals.CS$<>8__locals3;
			JackarooHand <>4__this = cS$<>8__locals2.<>4__this;
			cS$<>8__locals2.<>4__this.DoPlayMove(move, <>4__this._selectedMovesByCard, cS$<>8__locals2.playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass62_0
	{
		public JackarooHand <>4__this;

		public bool playCard;

		public Func<JackarooMove, bool> <>9__2;

		internal bool <PlayAce>b__2(JackarooMove jackarooMove)
		{
			//IL_007f: Expected I4, but got O
			if (jackarooMove != null)
			{
				JackarooHand jackarooHand = <>4__this;
				if ((object)<>4__this != null)
				{
					object obj = (object)jackarooMove.<Marble1>k__BackingField - (object)jackarooHand._selectedMarble1;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <PlayAce>g__OnSelectedAction|0(JackarooActions action)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_006a: Expected O, but got I
			//IL_0087: Expected I, but got O
			//IL_00f9: Expected O, but got I4
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			JackarooHand jackarooHand = <>4__this;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
			object obj5 = (nint)0 + (nint)2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			IEnumerable<object> source = Enumerable.Where(jackarooHand._selectedMovesByCard, func);
			List<object> list = Enumerable.ToList(source);
			object move = list.get_Item(0);
			JackarooHand jackarooHand2 = <>4__this;
			<>4__this.DoPlayMove((JackarooMove)move, jackarooHand2._selectedMovesByCard, playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass62_1
	{
		public JackarooMove move;

		public <>c__DisplayClass62_0 CS$<>8__locals1;

		internal void <PlayAce>g__OnSelectAction|1()
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_0104: Expected O, but got I4
			//IL_0183: Expected O, but got I
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_013c: Expected O, but got I
			//IL_014d: Expected I, but got O
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected O, but got Unknown
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Expected O, but got Unknown
			//IL_0225: Expected O, but got I4
			//IL_02c4: Expected O, but got I
			//IL_02d7: Expected I, but got O
			<>c__DisplayClass62_0 cS$<>8__locals = CS$<>8__locals1;
			JackarooMove jackarooMove = move;
			JackarooHand <>4__this = cS$<>8__locals.<>4__this;
			<>4__this._selectedMarble1 = jackarooMove.<Marble1>k__BackingField;
			object obj = <>4__this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass62_0 cS$<>8__locals2 = CS$<>8__locals1;
			JackarooCardGameVisualControls jackarooGameVisualControls = cS$<>8__locals2.<>4__this.JackarooGameVisualControls;
			jackarooGameVisualControls.HideActionTip();
			<>c__DisplayClass62_0 cS$<>8__locals3 = CS$<>8__locals1;
			JackarooBoardMono boardMono = cS$<>8__locals3.<>4__this.boardMono;
			boardMono.HideHighlights();
			object cS$<>8__locals4 = CS$<>8__locals1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X20_v3 (System.Object)+10]");
			object obj2 = 0;
			object obj3 = cS$<>8__locals4 + 32;
			Func<object, bool> predicate = (Func<object, bool>)obj3;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)2192;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(cS$<>8__locals4, (IntPtr)obj6);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v7+110]");
			IEnumerable<object> source = Enumerable.Where((IEnumerable<object>)0, predicate);
			List<object> list = Enumerable.ToList(source);
			<>c__DisplayClass62_0 cS$<>8__locals5 = CS$<>8__locals1;
			if (list._size == 1)
			{
				object obj7 = list.get_Item(0);
				<>c__DisplayClass62_0 cS$<>8__locals6 = CS$<>8__locals1;
				JackarooHand <>4__this2 = cS$<>8__locals6.<>4__this;
				cS$<>8__locals5.<>4__this.DoPlayMove((JackarooMove)obj7, <>4__this2._selectedMovesByCard, cS$<>8__locals6.playCard, (GameAction?)(object)0);
				return;
			}
			JackarooHand <>4__this3 = cS$<>8__locals5.<>4__this;
			<>4__this3.<playingStage>k__BackingField = JackarooPlayingStage.SelectingAction;
			JackarooCardGameVisualControls jackarooGameVisualControls2 = <>4__this3.JackarooGameVisualControls;
			object tip = "SERVICE_DISABLED" + 2560;
			jackarooGameVisualControls2.ShowActionTipPanel((string)tip);
			<>c__DisplayClass62_0 cS$<>8__locals7 = CS$<>8__locals1;
			JackarooCardGameVisualControls jackarooGameVisualControls3 = cS$<>8__locals7.<>4__this.JackarooGameVisualControls;
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)2200;
			Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
			action..ctor((object)CS$<>8__locals1, (IntPtr)obj9);
			jackarooGameVisualControls3.ShowActionsOptionsPanel((List<JackarooMove>)(object)list, (Action<JackarooActions>)(object)action);
			<>c__DisplayClass62_0 cS$<>8__locals8 = CS$<>8__locals1;
			JackarooBoardMono boardMono2 = cS$<>8__locals8.<>4__this.boardMono;
			boardMono2.HighlightMoves((List<JackarooMove>)(object)list);
		}
	}

	private sealed class <>c__DisplayClass62_2
	{
		public JackarooActions action;

		public <>c__DisplayClass62_0 CS$<>8__locals2;

		internal bool <PlayAce>b__3(JackarooMove jackarooMove)
		{
			//IL_00d7: Expected I4, but got O
			//IL_00b5: Expected O, but got I4
			if (jackarooMove != null)
			{
				<>c__DisplayClass62_0 cS$<>8__locals = CS$<>8__locals2;
				if (CS$<>8__locals2 != null)
				{
					JackarooHand <>4__this = cS$<>8__locals.<>4__this;
					if ((object)cS$<>8__locals.<>4__this != null)
					{
						if (jackarooMove.<Marble1>k__BackingField != <>4__this._selectedMarble1)
						{
							return false;
						}
						object obj = jackarooMove.<Action>k__BackingField - action;
						return obj == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public JackarooHand <>4__this;

		public bool playCard;

		public Func<JackarooMove, bool> <>9__2;

		internal bool <PlayJack>b__2(JackarooMove jackarooMove)
		{
			//IL_007f: Expected I4, but got O
			if (jackarooMove != null)
			{
				JackarooHand jackarooHand = <>4__this;
				if ((object)<>4__this != null)
				{
					object obj = (object)jackarooMove.<Marble1>k__BackingField - (object)jackarooHand._selectedMarble1;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass63_1
	{
		public JackarooMove move;

		public <>c__DisplayClass63_0 CS$<>8__locals1;

		internal void <PlayJack>b__0()
		{
			//IL_004c: Expected O, but got I4
			<>c__DisplayClass63_0 cS$<>8__locals = CS$<>8__locals1;
			JackarooHand <>4__this = cS$<>8__locals.<>4__this;
			cS$<>8__locals.<>4__this.DoPlayMove(move, <>4__this._selectedMovesByCard, cS$<>8__locals.playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass63_2
	{
		public JackarooMarble marble1;

		public <>c__DisplayClass63_1 CS$<>8__locals2;

		internal void <PlayJack>b__1()
		{
			//IL_12c7: Expected O, but got I4
			//IL_0fdd: Expected O, but got I
			//IL_002f: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_007f: Expected I, but got O
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00cf: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			//IL_013f: Expected O, but got I4
			//IL_016a: Expected O, but got I4
			//IL_0185: Expected O, but got I
			//IL_0191: Expected O, but got I
			//IL_019d: Expected O, but got I
			//IL_01a9: Expected O, but got I
			//IL_12dd: Expected I, but got O
			//IL_026e: Expected I, but got O
			//IL_02ab: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_100c: Expected O, but got I4
			//IL_1014: Expected O, but got I
			//IL_01ed: Expected O, but got I
			//IL_032e: Expected O, but got I4
			//IL_1043: Expected O, but got I4
			//IL_104b: Expected O, but got I
			//IL_0242: Expected O, but got I4
			//IL_0376: Expected O, but got I4
			//IL_037b: Expected I, but got O
			//IL_0261: Expected O, but got I
			//IL_03c6: Expected O, but got I4
			//IL_03cb: Expected I, but got O
			//IL_0413: Expected O, but got I4
			//IL_0418: Expected I, but got O
			//IL_0453: Expected O, but got I4
			//IL_0458: Expected I, but got O
			//IL_04ac: Expected O, but got I4
			//IL_04b1: Expected I, but got O
			//IL_04f9: Expected O, but got I4
			//IL_04fe: Expected I, but got O
			//IL_0534: Expected O, but got I4
			//IL_0539: Expected I, but got O
			//IL_0582: Expected O, but got I4
			//IL_05a4: Expected O, but got I4
			//IL_05b1: Expected I, but got O
			//IL_05e9: Expected O, but got I4
			//IL_060b: Expected O, but got I4
			//IL_0618: Expected I, but got O
			//IL_0643: Expected O, but got I4
			//IL_0665: Expected O, but got I4
			//IL_0672: Expected I, but got O
			//IL_06b6: Expected O, but got I4
			//IL_06d8: Expected O, but got I4
			//IL_06dd: Expected I, but got O
			//IL_0703: Expected O, but got I4
			//IL_0725: Expected O, but got I4
			//IL_072a: Expected I, but got O
			//IL_076e: Expected O, but got I4
			//IL_0790: Expected O, but got I4
			//IL_079d: Expected I, but got O
			//IL_07d5: Expected O, but got I4
			//IL_07f7: Expected O, but got I4
			//IL_0804: Expected I, but got O
			//IL_0822: Expected O, but got I
			//IL_0842: Expected O, but got I4
			//IL_0864: Expected O, but got I4
			//IL_0871: Expected I, but got O
			//IL_088d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0892: Expected O, but got Unknown
			//IL_08b4: Expected O, but got I4
			//IL_08bd: Expected O, but got I4
			//IL_093d: Expected I4, but got O
			//IL_0952: Expected O, but got I
			//IL_095e: Expected I, but got O
			//IL_0998: Expected O, but got I4
			//IL_08da: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Expected O, but got Unknown
			//IL_08f5: Expected O, but got I
			//IL_090b: Expected I, but got O
			//IL_0930: Expected O, but got I4
			//IL_0bf4: Expected O, but got I4
			//IL_09ff: Expected O, but got I4
			//IL_0c3c: Expected O, but got I4
			//IL_0a47: Expected O, but got I4
			//IL_0c84: Expected O, but got I4
			//IL_0a61: Expected O, but got I
			//IL_0a69: Expected I4, but got O
			//IL_0aaf: Expected O, but got I4
			//IL_0ab4: Expected I, but got O
			//IL_0cda: Expected O, but got I4
			//IL_0cdf: Expected I, but got O
			//IL_0afc: Expected O, but got I4
			//IL_0b01: Expected I, but got O
			//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfc: Expected O, but got Unknown
			//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2f: Expected O, but got Unknown
			//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d43: Expected O, but got Unknown
			//IL_0d4f: Expected O, but got I
			//IL_0b49: Expected O, but got I4
			//IL_0b4e: Expected I, but got O
			//IL_0b89: Expected O, but got I4
			//IL_0b8e: Expected I, but got O
			//IL_0bc5: Expected O, but got I4
			//IL_112b: Expected O, but got I4
			//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da0: Expected O, but got Unknown
			//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dbd: Expected O, but got Unknown
			//IL_1157: Expected O, but got I4
			//IL_10a1: Expected O, but got I4
			//IL_10d0: Expected O, but got I4
			//IL_1072: Expected O, but got I4
			//IL_0e83: Expected O, but got I
			//IL_1186: Expected O, but got I4
			//IL_0eca: Expected O, but got I
			//IL_11b2: Expected O, but got I4
			//IL_10ff: Expected O, but got I4
			//IL_0f26: Expected O, but got I
			//IL_0f3d: Expected I, but got O
			//IL_0f4e: Expected I, but got O
			//IL_11ce: Expected O, but got I4
			//IL_11e7: Expected O, but got I4
			//IL_0f88: Expected O, but got I
			//IL_0f91: Expected O, but got I4
			<>c__DisplayClass63_1 cS$<>8__locals = CS$<>8__locals2;
			bool flag = CS$<>8__locals2 == null;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
			nint num = default(nint);
			object obj5 = default(object);
			bool flag20 = default(bool);
			NullReferenceException ex;
			List<object>.Enumerator enumerator6;
			object obj24;
			nint num2;
			List<object>.Enumerator enumerator4;
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			if (!flag)
			{
				<>c__DisplayClass63_0 cS$<>8__locals2 = cS$<>8__locals.CS$<>8__locals1;
				bool flag2 = cS$<>8__locals.CS$<>8__locals1 == null;
				enumerator = (List<object>.Enumerator)0;
				if (!flag2)
				{
					JackarooHand <>4__this = cS$<>8__locals2.<>4__this;
					bool flag3 = (object)cS$<>8__locals2.<>4__this == null;
					enumerator = (List<object>.Enumerator)0;
					if (!flag3)
					{
						num = (nint)marble1;
						<>4__this._selectedMarble1 = marble1;
						object obj = cS$<>8__locals2.<>4__this + 264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						<>c__DisplayClass63_1 cS$<>8__locals3 = CS$<>8__locals2;
						bool flag4 = CS$<>8__locals2 == null;
						enumerator = (List<object>.Enumerator)0;
						if (!flag4)
						{
							<>c__DisplayClass63_0 cS$<>8__locals4 = cS$<>8__locals3.CS$<>8__locals1;
							bool flag5 = cS$<>8__locals3.CS$<>8__locals1 == null;
							enumerator = (List<object>.Enumerator)0;
							if (!flag5)
							{
								JackarooHand <>4__this2 = cS$<>8__locals4.<>4__this;
								bool flag6 = (object)cS$<>8__locals4.<>4__this == null;
								enumerator = (List<object>.Enumerator)0;
								if (!flag6)
								{
									bool flag7 = <>4__this2._selectedMovesByCard == null;
									enumerator = (List<object>.Enumerator)0;
									if (!flag7)
									{
										object obj2 = (nint)0 + (nint)2800;
										object obj3 = (nint)0 + (nint)3536;
										object obj4 = (nint)0 + (nint)2256;
										obj5 = (nint)0 + (nint)2792;
										List<object>.Enumerator enumerator2 = ((List<object>)(object)<>4__this2._selectedMovesByCard).GetEnumerator();
										object obj6 = default(object);
										while (true)
										{
											num = (nint)obj2;
											if (!enumerator.MoveNext())
											{
												break;
											}
											if (obj6 == null)
											{
												goto IL_0fe2;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ stack_-88 (System.Object)+20]");
											object obj7 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ stack_-88 (System.Object)+20]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v50+18]");
												bool flag8 = (nint)0 == 0;
												enumerator = enumerator3;
												enumerator4 = enumerator3;
												enumerator3 = (List<object>.Enumerator)0;
												if (!flag8)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v50+18]");
													((JackarooMarbleMono)0).Reset();
													continue;
												}
												goto IL_0fbc;
											}
											goto IL_1019;
										}
										num = (nint)obj5;
										enumerator.Dispose();
										<>c__DisplayClass63_1 cS$<>8__locals5 = CS$<>8__locals2;
										bool flag9 = CS$<>8__locals2 == null;
										enumerator = enumerator3;
										enumerator4 = enumerator3;
										enumerator3 = (List<object>.Enumerator)0;
										if (!flag9)
										{
											<>c__DisplayClass63_0 cS$<>8__locals6 = cS$<>8__locals5.CS$<>8__locals1;
											bool flag10 = cS$<>8__locals5.CS$<>8__locals1 == null;
											enumerator = enumerator3;
											enumerator4 = enumerator3;
											enumerator3 = (List<object>.Enumerator)0;
											if (!flag10)
											{
												bool flag11 = (object)cS$<>8__locals6.<>4__this == null;
												enumerator = enumerator3;
												enumerator4 = enumerator3;
												enumerator3 = (List<object>.Enumerator)0;
												if (!flag11)
												{
													JackarooBoardMono boardMono = cS$<>8__locals6.<>4__this.boardMono;
													bool flag12 = (object)boardMono == null;
													enumerator = enumerator3;
													enumerator4 = enumerator3;
													enumerator3 = (List<object>.Enumerator)0;
													num = unchecked((nint)null);
													if (!flag12)
													{
														boardMono.HideHighlights();
														<>c__DisplayClass63_1 cS$<>8__locals7 = CS$<>8__locals2;
														bool flag13 = CS$<>8__locals2 == null;
														enumerator = enumerator3;
														enumerator4 = enumerator3;
														enumerator3 = (List<object>.Enumerator)0;
														num = unchecked((nint)null);
														if (!flag13)
														{
															<>c__DisplayClass63_0 cS$<>8__locals8 = cS$<>8__locals7.CS$<>8__locals1;
															bool flag14 = cS$<>8__locals7.CS$<>8__locals1 == null;
															enumerator = enumerator3;
															enumerator4 = enumerator3;
															enumerator3 = (List<object>.Enumerator)0;
															num = unchecked((nint)null);
															if (!flag14)
															{
																bool flag15 = (object)cS$<>8__locals8.<>4__this == null;
																enumerator = enumerator3;
																enumerator4 = enumerator3;
																enumerator3 = (List<object>.Enumerator)0;
																num = unchecked((nint)null);
																if (!flag15)
																{
																	JackarooBoardMono boardMono2 = cS$<>8__locals8.<>4__this.boardMono;
																	JackarooMarble jackarooMarble = marble1;
																	bool flag16 = marble1 == null;
																	enumerator = enumerator3;
																	enumerator4 = enumerator3;
																	enumerator3 = (List<object>.Enumerator)0;
																	num = unchecked((nint)null);
																	if (!flag16)
																	{
																		JackarooNode <Node>k__BackingField = jackarooMarble.<Node>k__BackingField;
																		bool flag17 = jackarooMarble.<Node>k__BackingField == null;
																		enumerator = enumerator3;
																		enumerator4 = enumerator3;
																		enumerator3 = (List<object>.Enumerator)0;
																		num = unchecked((nint)null);
																		if (!flag17)
																		{
																			bool flag18 = (object)boardMono2 == null;
																			enumerator = enumerator3;
																			enumerator4 = enumerator3;
																			enumerator3 = (List<object>.Enumerator)0;
																			num = unchecked((nint)null);
																			if (!flag18)
																			{
																				boardMono2.HighlightFirstNode(<Node>k__BackingField.<NodeMono>k__BackingField, animate: false);
																				<>c__DisplayClass63_1 cS$<>8__locals9 = CS$<>8__locals2;
																				bool flag19 = CS$<>8__locals2 == null;
																				object obj8 = 0;
																				flag20 = false;
																				enumerator = enumerator3;
																				enumerator4 = enumerator3;
																				enumerator3 = (List<object>.Enumerator)0;
																				num = (nint)<Node>k__BackingField.<NodeMono>k__BackingField;
																				if (!flag19)
																				{
																					<>c__DisplayClass63_0 cS$<>8__locals10 = cS$<>8__locals9.CS$<>8__locals1;
																					bool flag21 = cS$<>8__locals9.CS$<>8__locals1 == null;
																					obj8 = 0;
																					flag20 = false;
																					enumerator = enumerator3;
																					enumerator4 = enumerator3;
																					enumerator3 = (List<object>.Enumerator)0;
																					num = (nint)<Node>k__BackingField.<NodeMono>k__BackingField;
																					if (!flag21)
																					{
																						bool flag22 = (object)cS$<>8__locals10.<>4__this == null;
																						obj8 = 0;
																						flag20 = false;
																						enumerator = enumerator3;
																						enumerator4 = enumerator3;
																						enumerator3 = (List<object>.Enumerator)0;
																						num = (nint)<Node>k__BackingField.<NodeMono>k__BackingField;
																						if (!flag22)
																						{
																							JackarooBoardMono boardMono3 = cS$<>8__locals10.<>4__this.boardMono;
																							<>c__DisplayClass63_1 cS$<>8__locals11 = CS$<>8__locals2;
																							bool flag23 = CS$<>8__locals2 == null;
																							obj8 = 0;
																							flag20 = false;
																							enumerator = enumerator3;
																							enumerator4 = enumerator3;
																							enumerator3 = (List<object>.Enumerator)0;
																							num = unchecked((nint)null);
																							if (!flag23)
																							{
																								bool flag24 = (object)boardMono3 == null;
																								obj8 = 0;
																								flag20 = false;
																								enumerator = enumerator3;
																								enumerator4 = enumerator3;
																								enumerator3 = (List<object>.Enumerator)0;
																								num = unchecked((nint)null);
																								if (!flag24)
																								{
																									boardMono3.HighlightGuardedMarbles(cS$<>8__locals11.move);
																									<>c__DisplayClass63_1 cS$<>8__locals12 = CS$<>8__locals2;
																									bool flag25 = CS$<>8__locals2 == null;
																									obj8 = 0;
																									flag20 = false;
																									enumerator = enumerator3;
																									enumerator4 = enumerator3;
																									enumerator3 = (List<object>.Enumerator)0;
																									num = (nint)cS$<>8__locals11.move;
																									if (!flag25)
																									{
																										object cS$<>8__locals13 = cS$<>8__locals12.CS$<>8__locals1;
																										bool flag26 = cS$<>8__locals12.CS$<>8__locals1 == null;
																										obj8 = 0;
																										flag20 = false;
																										enumerator = enumerator3;
																										enumerator4 = enumerator3;
																										enumerator3 = (List<object>.Enumerator)0;
																										num = (nint)cS$<>8__locals11.move;
																										if (!flag26)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v6 (System.Object)+10]");
																											object obj9 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v6 (System.Object)+10]");
																											bool flag27 = (nint)0 == 0;
																											obj8 = 0;
																											flag20 = false;
																											enumerator = enumerator3;
																											enumerator4 = enumerator3;
																											enumerator3 = (List<object>.Enumerator)0;
																											num = (nint)cS$<>8__locals11.move;
																											if (!flag27)
																											{
																												object obj10 = cS$<>8__locals12.CS$<>8__locals1 + 32;
																												Func<object, bool> predicate = (Func<object, bool>)obj10;
																												bool flag28 = obj10 == null;
																												object obj11 = !flag28;
																												obj8 = 0;
																												if (obj11 == null)
																												{
																													object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																													object obj13 = (nint)0 + (nint)2224;
																													Func<object, bool> func = default(Func<object, bool>);
																													func..ctor((object)cS$<>8__locals12.CS$<>8__locals1, (IntPtr)obj13);
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																													predicate = func;
																													obj8 = 0;
																												}
																												flag20 = (byte)(int)obj3 != 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v27+110]");
																												IEnumerable<object> source = Enumerable.Where((IEnumerable<object>)0, predicate);
																												num = (nint)obj4;
																												List<object> list = Enumerable.ToList(source);
																												bool flag29 = list == null;
																												enumerator = enumerator3;
																												enumerator4 = enumerator3;
																												enumerator3 = (List<object>.Enumerator)0;
																												if (!flag29)
																												{
																													<>c__DisplayClass63_1 cS$<>8__locals14 = CS$<>8__locals2;
																													if (list._size == 1)
																													{
																														bool flag30 = CS$<>8__locals2 == null;
																														enumerator = enumerator3;
																														enumerator4 = enumerator3;
																														enumerator3 = (List<object>.Enumerator)0;
																														if (!flag30)
																														{
																															<>c__DisplayClass63_0 cS$<>8__locals15 = cS$<>8__locals14.CS$<>8__locals1;
																															bool flag31 = cS$<>8__locals14.CS$<>8__locals1 == null;
																															enumerator = enumerator3;
																															enumerator4 = enumerator3;
																															enumerator3 = (List<object>.Enumerator)0;
																															if (!flag31)
																															{
																																object obj14 = (nint)0 + (nint)2360;
																																flag20 = (byte)(int)obj14 != 0;
																																object move = list.get_Item(0);
																																<>c__DisplayClass63_1 cS$<>8__locals16 = CS$<>8__locals2;
																																bool flag32 = CS$<>8__locals2 == null;
																																enumerator = enumerator3;
																																enumerator4 = enumerator3;
																																enumerator3 = (List<object>.Enumerator)0;
																																num = unchecked((nint)null);
																																if (!flag32)
																																{
																																	<>c__DisplayClass63_0 cS$<>8__locals17 = cS$<>8__locals16.CS$<>8__locals1;
																																	bool flag33 = cS$<>8__locals16.CS$<>8__locals1 == null;
																																	enumerator = enumerator3;
																																	enumerator4 = enumerator3;
																																	enumerator3 = (List<object>.Enumerator)0;
																																	num = unchecked((nint)null);
																																	if (!flag33)
																																	{
																																		JackarooHand <>4__this3 = cS$<>8__locals17.<>4__this;
																																		bool flag34 = (object)cS$<>8__locals17.<>4__this == null;
																																		enumerator = enumerator3;
																																		enumerator4 = enumerator3;
																																		enumerator3 = (List<object>.Enumerator)0;
																																		num = unchecked((nint)null);
																																		if (!flag34)
																																		{
																																			bool flag35 = (object)cS$<>8__locals15.<>4__this == null;
																																			enumerator = enumerator3;
																																			enumerator4 = enumerator3;
																																			enumerator3 = (List<object>.Enumerator)0;
																																			num = unchecked((nint)null);
																																			if (!flag35)
																																			{
																																				cS$<>8__locals15.<>4__this.DoPlayMove((JackarooMove)move, <>4__this3._selectedMovesByCard, cS$<>8__locals17.playCard, (GameAction?)(object)0);
																																				return;
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																													else
																													{
																														bool flag36 = CS$<>8__locals2 == null;
																														enumerator = enumerator3;
																														enumerator4 = enumerator3;
																														enumerator3 = (List<object>.Enumerator)0;
																														if (!flag36)
																														{
																															<>c__DisplayClass63_0 cS$<>8__locals18 = cS$<>8__locals14.CS$<>8__locals1;
																															bool flag37 = cS$<>8__locals14.CS$<>8__locals1 == null;
																															enumerator = enumerator3;
																															enumerator4 = enumerator3;
																															enumerator3 = (List<object>.Enumerator)0;
																															if (!flag37)
																															{
																																JackarooHand <>4__this4 = cS$<>8__locals18.<>4__this;
																																bool flag38 = (object)cS$<>8__locals18.<>4__this == null;
																																enumerator = enumerator3;
																																enumerator4 = enumerator3;
																																enumerator3 = (List<object>.Enumerator)0;
																																if (!flag38)
																																{
																																	<>4__this4.<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
																																	JackarooCardGameVisualControls jackarooGameVisualControls = cS$<>8__locals18.<>4__this.JackarooGameVisualControls;
																																	bool flag39 = (object)jackarooGameVisualControls == null;
																																	enumerator = enumerator3;
																																	enumerator4 = enumerator3;
																																	enumerator3 = (List<object>.Enumerator)0;
																																	num = unchecked((nint)null);
																																	if (!flag39)
																																	{
																																		object tip = "SERVICE_DISABLED" + 2608;
																																		jackarooGameVisualControls.ShowActionTipPanel((string)tip);
																																		List<object>.Enumerator enumerator5 = list.GetEnumerator();
																																		object obj15 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 760;
																																		object obj16 = typeof(SqlSingle[]) + 2376;
																																		object obj17 = (nint)0 + (nint)2248;
																																		num2 = 0;
																																		object obj18 = default(object);
																																		Action action = default(Action);
																																		while (true)
																																		{
																																			if (enumerator.MoveNext())
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																				obj18..ctor();
																																				if (obj18 != null)
																																				{
																																					object obj19 = obj18 + 24;
																																					obj19 = this;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																					object obj20 = obj18 + 16;
																																					obj20 = obj6;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																					object obj21 = obj20;
																																					if (obj20 != null)
																																					{
																																						<>c__DisplayClass63_1 cS$<>8__locals19 = CS$<>8__locals2;
																																						if (CS$<>8__locals2 != null)
																																						{
																																							<>c__DisplayClass63_0 cS$<>8__locals20 = cS$<>8__locals19.CS$<>8__locals1;
																																							if (cS$<>8__locals19.CS$<>8__locals1 != null)
																																							{
																																								if ((object)cS$<>8__locals20.<>4__this != null)
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v38+30]");
																																									object obj22 = 0;
																																									JackarooBoardMono boardMono4 = cS$<>8__locals20.<>4__this.boardMono;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v38+30]");
																																									if ((nint)0 != 0)
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X21_v10+20]");
																																										object obj23 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X21_v10+20]");
																																										if ((nint)0 != 0)
																																										{
																																											if ((object)boardMono4 != null)
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v39+18]");
																																												boardMono4.HighlightFirstNode((JackarooNodeMono)0);
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																												num2 = (nint)obj17;
																																												action..ctor(obj18, (IntPtr)obj17);
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X21_v10+18]");
																																												if ((nint)0 != 0)
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X21_v10+18]");
																																													((JackarooMarbleMono)0).SetupSelect(action);
																																													obj8 = 0;
																																													num2 = 0;
																																													continue;
																																												}
																																												ex = new NullReferenceException();
																																												obj8 = 0;
																																												enumerator6 = enumerator3;
																																												enumerator4 = enumerator3;
																																												enumerator3 = (List<object>.Enumerator)0;
																																												obj24 = obj18;
																																												break;
																																											}
																																											ex = new NullReferenceException();
																																											enumerator6 = enumerator3;
																																											enumerator4 = enumerator3;
																																											enumerator3 = (List<object>.Enumerator)0;
																																											obj24 = null;
																																											break;
																																										}
																																										ex = new NullReferenceException();
																																										enumerator6 = enumerator3;
																																										enumerator4 = enumerator3;
																																										enumerator3 = (List<object>.Enumerator)0;
																																										obj24 = null;
																																										break;
																																									}
																																									ex = new NullReferenceException();
																																									enumerator6 = enumerator3;
																																									enumerator4 = enumerator3;
																																									enumerator3 = (List<object>.Enumerator)0;
																																									obj24 = null;
																																									break;
																																								}
																																								ex = new NullReferenceException();
																																								enumerator6 = enumerator3;
																																								enumerator4 = enumerator3;
																																								enumerator3 = (List<object>.Enumerator)0;
																																								obj24 = obj6;
																																								break;
																																							}
																																							ex = new NullReferenceException();
																																							enumerator6 = enumerator3;
																																							enumerator4 = enumerator3;
																																							enumerator3 = (List<object>.Enumerator)0;
																																							obj24 = obj6;
																																							break;
																																						}
																																						ex = new NullReferenceException();
																																						enumerator6 = enumerator3;
																																						enumerator4 = enumerator3;
																																						enumerator3 = (List<object>.Enumerator)0;
																																						obj24 = obj6;
																																						break;
																																					}
																																					ex = new NullReferenceException();
																																					enumerator6 = enumerator3;
																																					enumerator4 = enumerator3;
																																					enumerator3 = (List<object>.Enumerator)0;
																																					obj24 = obj6;
																																					break;
																																				}
																																				ex = new NullReferenceException();
																																				enumerator6 = enumerator3;
																																				enumerator4 = enumerator3;
																																				enumerator3 = (List<object>.Enumerator)0;
																																				obj24 = null;
																																				break;
																																			}
																																			enumerator.Dispose();
																																			return;
																																		}
																																		goto IL_11fa;
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
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0fbc;
			IL_0fe2:
			ex = new NullReferenceException();
			num2 = (flag20 ? 1 : 0);
			enumerator6 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			obj24 = num;
			goto IL_11fa;
			IL_0fbc:
			ex = new NullReferenceException();
			num2 = (flag20 ? 1 : 0);
			enumerator6 = enumerator;
			obj24 = num;
			goto IL_11fa;
			IL_11fa:
			bool flag40 = (nint)obj24 != 1;
			OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex;
			if (!flag40)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj24 = obj5;
				enumerator6.Dispose();
				object obj25 = default(object);
				if (obj25 == null)
				{
					return;
				}
				ex3 = new OutOfMemoryException();
				enumerator3 = (List<object>.Enumerator)obj25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_1019:
			ex = new NullReferenceException();
			num2 = (flag20 ? 1 : 0);
			enumerator6 = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			obj24 = num;
			goto IL_11fa;
		}
	}

	private sealed class <>c__DisplayClass63_3
	{
		public JackarooMove jackarooMove;

		public <>c__DisplayClass63_2 CS$<>8__locals3;

		internal void <PlayJack>b__3()
		{
			//IL_0070: Expected O, but got I4
			<>c__DisplayClass63_2 cS$<>8__locals = CS$<>8__locals3;
			<>c__DisplayClass63_1 cS$<>8__locals2 = cS$<>8__locals.CS$<>8__locals2;
			<>c__DisplayClass63_0 cS$<>8__locals3 = cS$<>8__locals2.CS$<>8__locals1;
			JackarooHand <>4__this = cS$<>8__locals3.<>4__this;
			cS$<>8__locals3.<>4__this.DoPlayMove(jackarooMove, <>4__this._selectedMovesByCard, cS$<>8__locals3.playCard, (GameAction?)(object)0);
		}
	}

	private sealed class <>c__DisplayClass67_0
	{
		public Card cardToBurn;

		public JackarooPlayer nextPlayer;

		public JackarooHand <>4__this;

		internal void <OnGameStatusUpdate>b__2()
		{
			//IL_0034: Expected I4, but got I8
			System.Int32Enum? gameAction = (System.Int32Enum)(-1);
			<>4__this.DoPlayCard(cardToBurn, (GameAction?)gameAction, nextPlayer);
		}
	}

	private sealed class <>c__DisplayClass67_1
	{
		public Card stolenCard;

		public JackarooHand <>4__this;

		internal void <OnGameStatusUpdate>b__3()
		{
			//IL_00e3: Expected O, but got I
			//IL_00fd: Expected O, but got I4
			//IL_0139: Expected I4, but got I8
			//IL_0127: Expected I4, but got I8
			if ((object)<>4__this != null)
			{
				<>4__this.GetAllowedMoves();
				if ((object)<>4__this != null)
				{
					IEnumerable<JackarooMove> allowedMovesForCard = <>4__this.GetAllowedMovesForCard(stolenCard);
					object[] array = Enumerable.ToArray((IEnumerable<object>)allowedMovesForCard);
					if (array != null)
					{
						if (array.Length == 0)
						{
							return;
						}
						object obj = array[0];
						if (array[0] != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7 (System.Object)+18]");
							object obj2 = -16384;
							bool flag = obj2 == null;
							object obj3 = !flag;
							object obj4 = ~obj3;
							System.Int32Enum value = (System.Int32Enum)((obj4 != null) ? 4294967293L : (4294967293L + 1));
							System.Int32Enum? gameAction = value;
							if ((object)<>4__this != null)
							{
								<>4__this.DoPlayCard(stolenCard, (GameAction?)gameAction);
								if ((object)<>4__this != null)
								{
									IReadOnlyList<JackarooMove> allowedMoves = <>4__this.AllowedMoves;
									<>4__this.HandleMarblePlay(allowedMoves, playCard: false, stolenCard, (GameAction?)gameAction);
									return;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass73_0
	{
		public Card card;

		internal bool <GetAllowedMovesForCard>b__0(JackarooMove move)
		{
			//IL_0048: Expected I4, but got O
			if (move != null)
			{
				return object.Equals(move.<Card>k__BackingField, card);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass76_0
	{
		public Card card;

		public JackarooHand <>4__this;

		internal bool <DoPlayCard>b__0(GameCard gc)
		{
			//IL_0091: Expected I4, but got O
			//IL_0074: Expected I, but got O
			if ((object)gc != null)
			{
				bool isActiveAndEnabled = gc.isActiveAndEnabled;
				if (isActiveAndEnabled)
				{
					Card card = this.card;
					if (this.card == null)
					{
						goto IL_0083;
					}
					nint num = (nint)card;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v52 @ X8_v1 (Il2CppClass<Card>)+138] (should have been resolved before IL gen)");
				}
				return isActiveAndEnabled;
			}
			goto IL_0083;
			IL_0083:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <DoPlayCard>b__1()
		{
			<>4__this.ShowHandCards(card);
		}
	}

	private sealed class <>c__DisplayClass77_0
	{
		public Card exceptCard;

		internal bool <ShowHandCards>b__0(Card c)
		{
			bool flag = object.Equals(c, exceptCard);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private sealed class <>c__DisplayClass78_0
	{
		public Card exceptCard;

		internal bool <ShowHandCards>b__0(Card c)
		{
			bool flag = object.Equals(c, exceptCard);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private sealed class <WaitForBoardIe>d__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public JackarooHand <>4__this;

		public float delay;

		public Action action;

		private int <generation>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitForBoardIe>d__71(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_019e: Expected I4, but got I8
			//IL_02a6: Expected I4, but got O
			//IL_009f: Expected I4, but got I8
			//IL_0040: Expected O, but got I4
			//IL_005d: Expected I4, but got I8
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected O, but got Unknown
			//IL_0179: Expected O, but got I4
			//IL_0226: Invalid comparison between F4 and I4
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			JackarooHand jackarooHand = <>4__this;
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_02cf;
					}
					<>1__state = -1;
					if ((object)<>4__this != null)
					{
						<generation>5__2 = jackarooHand._playGeneration;
						goto IL_00be;
					}
				}
				else
				{
					<>1__state = -1;
					if ((object)<>4__this != null)
					{
						goto IL_00be;
					}
				}
			}
			else
			{
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					goto IL_01bd;
				}
			}
			goto IL_0298;
			IL_0298:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_02cf:
			return false;
			IL_01bd:
			if (<generation>5__2 == jackarooHand._playGeneration)
			{
				Action action = this.action;
				if (this.action == null)
				{
					goto IL_0298;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v144.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			goto IL_02cf;
			IL_00be:
			JackarooBoardMono boardMono = <>4__this.boardMono;
			if ((object)boardMono != null)
			{
				if (boardMono.<Initialized>k__BackingField)
				{
					JackarooBoardMono boardMono2 = <>4__this.boardMono;
					if ((object)boardMono2 == null)
					{
						goto IL_0298;
					}
					if (!boardMono2.ShouldWait)
					{
						if (delay > 0f)
						{
							object obj2 = typeof(UsageHint) + 1640;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							WaitForSeconds waitForSeconds = default(WaitForSeconds);
							waitForSeconds..ctor(delay);
							object obj3 = this + 24;
							obj3 = waitForSeconds;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 2;
							return true;
						}
						goto IL_01bd;
					}
				}
				object obj4 = this + 24;
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return true;
			}
			goto IL_0298;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)2312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private JackarooPlayingStage <playingStage>k__BackingField;

	private bool _awaitingPlayConfirmation;

	private const string SelectMarbleToMove = "SelectMarbleToMove";

	private const string SelectOtherMarbleToMove = "SelectOtherMarbleToMove";

	private const string SelectActionToPlay = "SelectActionToPlay";

	private const string SelectCardToBurn = "SelectCardToBurn";

	private const string SelectCardToSteal = "SelectCardToSteal";

	private const string NoMovesSelectCardToBurn = "NoMovesSelectCardToBurn";

	private JackarooMove _selectedJackarooMove;

	private float _checkRadius;

	private float _yFireModeOffset;

	private bool _isDealAnimating;

	private readonly Collider[] _colliders;

	private bool _wasStealing;

	private JackarooMarble _selectedMarble1;

	private readonly List<JackarooMove> _selectedMovesByCard;

	private List<JackarooMove> _allowedMoves;

	private int _playGeneration;

	private Card _playedCard;

	private readonly Dictionary<JackarooActions, StoreItem> _specialJackarooActions;

	private readonly Dictionary<GameAction, StoreItem> _specialGameActions;

	private readonly List<JackarooMarbleMono> _specialMarbles;

	private readonly List<StoreItem> _specialItems;

	private JackarooGame JackarooGame
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_007f: Expected O, but got I
			CardGame cardGame = game;
			if ((object)game != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X10_v4-8]");
					if (0 == (nint)obj2)
					{
						return (JackarooGame)game;
					}
					return null;
				}
			}
			return null;
		}
	}

	private JackarooCardGameVisualControls JackarooGameVisualControls
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_007f: Expected O, but got I
			CardGameVisualControls cardGameVisualControls = gameVisualControls;
			if ((object)gameVisualControls != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
				object obj2 = obj;
				nint num = (nint)cardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X10_v4-8]");
					if (0 == (nint)obj2)
					{
						return (JackarooCardGameVisualControls)gameVisualControls;
					}
					return null;
				}
			}
			return null;
		}
	}

	private JackarooBoardMono boardMono
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00ba: Expected O, but got I
			CardGameVisualControls cardGameVisualControls = gameVisualControls;
			if ((object)gameVisualControls != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
				object obj2 = obj;
				nint num = (nint)cardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v4-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (CardGameVisualControls)+148]");
						return (JackarooBoardMono)0;
					}
				}
			}
			return (JackarooBoardMono)(object)new NullReferenceException();
		}
	}

	private JackarooLastActionInfo LastActionInfo
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00ba: Expected O, but got I
			CardGame cardGame = game;
			if ((object)game != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X10_v2 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v4-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (CardGame)+170]");
						return (JackarooLastActionInfo)0;
					}
				}
			}
			return (JackarooLastActionInfo)(object)new NullReferenceException();
		}
	}

	protected override float SwipeOffset => 10f;

	private JackarooPlayingStage playingStage
	{
		get
		{
			return <playingStage>k__BackingField;
		}
		set
		{
			<playingStage>k__BackingField = value;
		}
	}

	private float SqrRadius => _checkRadius * _checkRadius;

	private IReadOnlyList<JackarooMove> AllowedMoves
	{
		get
		{
			if (_allowedMoves != null)
			{
				return (IReadOnlyList<JackarooMove>)((List<object>)(object)_allowedMoves).AsReadOnly();
			}
			return (IReadOnlyList<JackarooMove>)new NullReferenceException();
		}
	}

	private IReadOnlyDictionary<JackarooActions, StoreItem> SpecialJackarooActions => _specialJackarooActions;

	private IReadOnlyDictionary<GameAction, StoreItem> SpecialGameActions => _specialGameActions;

	private void DoPlayMove(JackarooMove move, List<JackarooMove> movesToReset, bool playCard, GameAction? gameAction = null)
	{
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I
		//IL_02e8: Expected O, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_031e: Expected O, but got I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0034: Expected I, but got O
		//IL_0044: Expected O, but got I
		//IL_03e0: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0125: Expected I, but got O
		//IL_0135: Expected O, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0429: Expected I, but got O
		//IL_0452: Expected O, but got I4
		//IL_007f: Expected O, but got I
		//IL_0368: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_0486: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_04c6: Expected O, but got I
		//IL_0658: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_061f: Expected O, but got I4
		//IL_063d: Expected O, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		object obj = (??)gameAction & 1;
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		if (obj != null)
		{
			System.Int32Enum value = int32Enum.Value;
			Dictionary<GameAction, StoreItem> specialGameActions = _specialGameActions;
			object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2328;
			nint num = (nint)specialGameActions;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v44 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v44 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v44 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X10_v18-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00c0;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_057f;
		}
		object obj8 = this + 104;
		bool flag = (nint)obj8 != 1;
		GameAction? gameAction2 = gameAction;
		if (flag)
		{
			goto IL_02b8;
		}
		Dictionary<JackarooActions, StoreItem> specialJackarooActions = _specialJackarooActions;
		object obj9 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2336;
		nint num2 = (nint)specialJackarooActions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v26 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v26 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v26 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X10_v12-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_01b1;
		}
		object obj12 = obj11 + 1;
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		goto IL_05d3;
		IL_02b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8000]");
		object obj15 = (nint)0 & (nint)1;
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		GameAction? emote;
		if (obj16 == null)
		{
			object obj17 = (??)gameAction2 & 1;
			bool flag3 = obj17 == null;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				GameAction? gameActionForAction = GetGameActionForAction(move.<Action>k__BackingField);
				SendToSFS(move, gameActionForAction);
				bool flag4 = !playCard;
				object obj19 = !flag4;
				gameAction2 = gameActionForAction;
				if (obj19 != null)
				{
					goto IL_03ba;
				}
				emote = gameActionForAction;
				goto IL_06c0;
			}
		}
		SendToSFS(move, gameAction2);
		bool flag5 = !playCard;
		emote = gameAction2;
		if (!flag5)
		{
			goto IL_03ba;
		}
		goto IL_06c0;
		IL_057f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v484 @ X0_v50] (should have been resolved before IL gen)");
		gameAction2 = (GameAction?)int32Enum;
		StoreItem storeItem2 = default(StoreItem);
		StoreItem storeItem = storeItem2;
		goto IL_0679;
		IL_0679:
		object obj20 = this + 104;
		if ((nint)obj20 == 1 && storeItem != null)
		{
			int num3 = StorePricing.EffectivePrice(storeItem);
			bool flag6 = ((JackarooHand)num3).CanAffordSpecialPlay(num3);
			bool flag7 = !flag6;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				object message = "not" + 88;
				gameEventsChannel.TriggerDisplayMessage((string)message);
				gameAction2 = (GameAction?)(object)0;
			}
		}
		goto IL_02b8;
		IL_03ba:
		Card card = _playedCard;
		bool flag8 = _playedCard == null;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			card = move.<Card>k__BackingField;
		}
		DoPlayCard(card, gameAction2);
		emote = gameAction2;
		goto IL_06c0;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_057f;
		IL_06c0:
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		object obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj24 = obj23;
		nint num4 = (nint)cardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X10_v4 (Il2CppClass<CardGameVisualControls>)+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X9_v6+130]");
		bool flag9 = num5 < 0;
		object obj25 = !flag9;
		object obj26 = ~obj25;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X10_v4 (Il2CppClass<CardGameVisualControls>)+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X9_v6+130]");
			object obj27 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X10_v6-8]");
			if (0 == (nint)obj24)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v16 (CardGameVisualControls)+148]");
				((JackarooBoardMono)0).PlayJackarooMove(move, emote);
				gameEventsChannel.TriggerHideDismissibleBlocker();
				ResetPlay(movesToReset);
				return;
			}
		}
		throw new NullReferenceException();
		IL_01b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05d3;
		IL_05d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X0_v29] (should have been resolved before IL gen)");
		bool flag10 = storeItem2 == null;
		gameAction2 = gameAction;
		if (flag10)
		{
			goto IL_02b8;
		}
		int num7 = StorePricing.EffectivePrice(storeItem2);
		if (((JackarooHand)num7).CanAffordSpecialPlay(num7))
		{
			System.Int32Enum? int32Enum2 = (System.Int32Enum)storeItem2.<GameAction>k__BackingField;
			gameAction2 = (GameAction?)int32Enum2;
			storeItem = storeItem2;
		}
		else
		{
			object message2 = "not" + 88;
			gameEventsChannel.TriggerDisplayMessage((string)message2);
			gameAction2 = gameAction;
			storeItem = storeItem2;
		}
		goto IL_0679;
	}

	private static void ResetMoves(List<JackarooMove> movesToReset)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_005d: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_00c1: Expected O, but got I4
		//IL_0131: Expected O, but got I
		if (movesToReset == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)2800;
		object obj2 = (nint)0 + (nint)2792;
		List<object>.Enumerator enumerator = ((List<object>)(object)movesToReset).GetEnumerator();
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object obj4 = default(object);
		NullReferenceException ex;
		object obj3;
		while (true)
		{
			obj3 = obj;
			if (enumerator2.MoveNext())
			{
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ stack_-58+20]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ stack_-58+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v11+18]");
						if ((nint)0 == 0)
						{
							ex = new NullReferenceException();
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v11+18]");
						((JackarooMarbleMono)0).Reset();
						obj3 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ stack_-58+30]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ stack_-58+30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v12+18]");
						if ((nint)0 == 0)
						{
							ex = new NullReferenceException();
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v12+18]");
						((JackarooMarbleMono)0).Reset();
					}
					continue;
				}
				ex = new NullReferenceException();
				break;
			}
			enumerator2.Dispose();
			return;
		}
		bool flag = (nint)obj3 != 1;
		List<object>.Enumerator enumerator3 = (List<object>.Enumerator)0;
		NullReferenceException ex2 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj2;
			enumerator2.Dispose();
			object obj7 = default(object);
			if (obj7 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj7;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void SendToSFS(JackarooMove move, GameAction? gameAction = null)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_011c: Expected I, but got O
		//IL_0145: Expected O, but got I4
		//IL_0179: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01df: Expected O, but got I4
		//IL_020d: Expected O, but got I8
		//IL_0227: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_0379: Expected I, but got O
		//IL_03a2: Expected O, but got I4
		//IL_03d6: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026c: Expected I, but got O
		//IL_027c: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD3]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD1]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD1]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		goto IL_00f8;
		IL_0415:
		throw new NullReferenceException();
		IL_045e:
		JackarooGame jackarooGame = (JackarooGame)game;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj6 = obj5;
		nint num = (nint)jackarooGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v6 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		JackarooServerMove jackarooMove;
		int? emoteItemId;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v6 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X9_v8-8]");
			if (0 == (nint)obj6)
			{
				jackarooGame.SendToSfs(player, jackarooMove, emoteItemId);
				return;
			}
		}
		goto IL_0415;
		IL_044f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ X0_v17] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ stack_-38_v4+10]");
		emoteItemId = 0;
		goto IL_045e;
		IL_0066:
		cardGameVisualControls = gameVisualControls;
		bool flag3 = (object)gameVisualControls == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_00f8;
		}
		goto IL_0415;
		IL_00f8:
		object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj12 = obj11;
		nint num4 = (nint)cardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v4+130]");
		bool flag4 = num5 < 0;
		object obj13 = !flag4;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v4+130]");
			object obj15 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X10_v4-8]");
			if (0 == (nint)obj12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v3 (CardGameVisualControls)+148]");
				jackarooMove = ((JackarooBoardMono)0).ToJackarooServerMove(move);
				object obj16 = (??)gameAction & 1;
				bool flag5 = obj16 == null;
				emoteItemId = (int?)(object)0;
				if (!flag5)
				{
					System.Int32Enum? int32Enum = default(System.Int32Enum?);
					System.Int32Enum value = int32Enum.Value;
					object obj17 = (long)value & 0x80000000L;
					bool flag6 = obj17 == null;
					object obj18 = !flag6;
					emoteItemId = (int?)(object)0;
					if (obj18 == null)
					{
						System.Int32Enum value2 = int32Enum.Value;
						Dictionary<GameAction, StoreItem> specialGameActions = _specialGameActions;
						object obj19 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2328;
						nint num7 = (nint)specialGameActions;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v15 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+12E]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v15 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02f8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v15 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+B0]");
						object obj21 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X10_v12-8]");
							if (0 == (nint)obj19)
							{
								break;
							}
							obj21 += 16;
							obj20--;
							if ((nint)obj20 != 1)
							{
								continue;
							}
							goto IL_02f8;
						}
						object obj22 = obj21 + 1;
						object obj23 = num7 + obj22;
						object obj24 = obj23 + 312;
						goto IL_044f;
					}
				}
				goto IL_045e;
			}
		}
		goto IL_0415;
		IL_02f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_044f;
	}

	private void ResetPlay(List<JackarooMove> movesToReset)
	{
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Expected O, but got I4
		//IL_023b: Expected O, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0278: Expected O, but got I
		//IL_001b: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00da: Expected I, but got O
		//IL_0103: Expected O, but got I4
		//IL_0137: Expected O, but got I
		//IL_017c: Expected I, but got O
		//IL_01a5: Expected O, but got I4
		//IL_01d9: Expected O, but got I
		object obj = this + 64;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v3+E0]");
		object obj2 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		object obj3 = obj + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v3+D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+1C]");
		object obj5 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+18]");
			Array.Clear((Array)num, 0, 0);
		}
		<playingStage>k__BackingField = JackarooPlayingStage.None;
		playedCardThisTurn = false;
		_awaitingPlayConfirmation = true;
		gameEventsChannel.TriggerDeactivateFireMode();
		ResetMoves(movesToReset);
		JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj7 = obj6;
		nint num2 = (nint)jackarooCardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v4 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v10+130]");
		bool flag = num3 < 0;
		object obj8 = !flag;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v4 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v10+130]");
			object obj10 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X9_v6-8]");
			if (0 == (nint)obj7)
			{
				jackarooCardGameVisualControls.HideActionTip();
				JackarooCardGameVisualControls jackarooCardGameVisualControls2 = (JackarooCardGameVisualControls)gameVisualControls;
				object obj11 = obj6;
				nint num5 = (nint)jackarooCardGameVisualControls2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v8 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+130]");
				bool flag2 = num6 < 0;
				object obj12 = !flag2;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v8 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+130]");
					object obj14 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X9_v10-8]");
					if (0 == (nint)obj11)
					{
						jackarooCardGameVisualControls2.HideTipsPanel();
						return;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void MoveMarbles(JackarooMove move, GameAction? gameAction = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00c6: Expected O, but got I
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj2 = obj;
		nint num = (nint)cardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v4+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v4+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X10_v4-8]");
			if (0 == (nint)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (CardGameVisualControls)+148]");
				JackarooMove move2 = default(JackarooMove);
				GameAction? emote = default(GameAction?);
				((JackarooBoardMono)0).PlayJackarooMove(move2, emote);
				return;
			}
		}
		throw new NullReferenceException();
	}

	protected override void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00e1: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)776;
		base.RegisterEventListeners();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)768;
		gameEventsChannel.OnGamePerspectiveChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)760;
		gameEventsChannel.OnDealBatchStarted += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		gameEventsChannel.OnDealBatchComplete += action3;
	}

	protected override void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00e1: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)776;
		base.UnRegisterEventListeners();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)768;
		gameEventsChannel.OnGamePerspectiveChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)760;
		gameEventsChannel.OnDealBatchStarted -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		gameEventsChannel.OnDealBatchComplete -= action3;
	}

	private void OnDealBatchStarted()
	{
		_isDealAnimating = true;
	}

	private void OnDealBatchComplete()
	{
		//IL_0010: Expected I, but got O
		//IL_0020: Expected O, but got I
		//IL_0030: Expected O, but got I
		_isDealAnimating = false;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ X8_v1 (Il2CppClass<JackarooHand>)+258]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ X8_v1 (Il2CppClass<JackarooHand>)+260]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void OnGameInitialized()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_015f: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_012f: Expected F4, but got I4
		base.OnGameInitialized();
		gameEventsChannel.TriggerDisableFireModeButton();
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPerspectiveTopDown = Preferences.IsPerspectiveTopDown;
		bool flag2 = ScreenUtility.CheckCurrentAspectRatio(ScreenUtility.AspectRatio.HD);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null || ScreenUtility.CheckCurrentAspectRatio(ScreenUtility.AspectRatio.SD))
		{
			Transform target = base.transform;
			int num = ShortcutExtensions.DOKill(target);
			Transform target2 = base.transform;
			bool flag4 = !isPerspectiveTopDown;
			object obj5 = !flag4;
			object obj6 = ~obj5;
			float endValue = ((obj6 != null) ? 0f : (-25f));
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target2, endValue, 0.2f);
		}
	}

	protected override void Update()
	{
		CardGame cardGame = game;
		CardGamePlayer cardGamePlayer = player;
		if (((KGame)cardGame).<Mover>k__BackingField == ((KPlayer)cardGamePlayer).<Index>k__BackingField && <playingStage>k__BackingField != JackarooPlayingStage.SelectingAction)
		{
			base.Update();
			if (InputUtil.PointerPressedThisFrame)
			{
				SelectMarble();
			}
		}
	}

	protected override void OnMouseButton()
	{
		//IL_0317: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_013d: Expected I, but got O
		//IL_0166: Expected O, but got I4
		//IL_019a: Expected O, but got I
		//IL_01d2: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_0224: Expected O, but got I4
		//IL_024d: Expected I, but got O
		//IL_0276: Expected O, but got I4
		//IL_02aa: Expected O, but got I
		//IL_02e2: Expected O, but got I
		bool flag = <playingStage>k__BackingField == JackarooPlayingStage.None;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		base.OnMouseButton();
		if (!_cardChanged)
		{
			return;
		}
		bool flag2 = !playedCardThisTurn;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = base.<CardHit>k__BackingField != null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(base.<CardHit>k__BackingField != null))
			{
				return;
			}
		}
		object obj6 = 152993792;
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj8 = obj7;
		nint num = (nint)cardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v3+130]");
		bool flag5 = num2 < 0;
		object obj9 = !flag5;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v3+130]");
			object obj11 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X10_v5-8]");
			if (0 == (nint)obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v12 (CardGameVisualControls)+148]");
				if (((JackarooBoardMono)0).ShouldWait)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X20_v5+BD1]");
				object obj12 = (nint)0 & (nint)1;
				bool flag6 = obj12 == null;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					_ = 1;
				}
				CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
				object obj14 = obj7;
				nint num4 = (nint)cardGameVisualControls2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X10_v7 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v4+130]");
				bool flag7 = num5 < 0;
				object obj15 = !flag7;
				object obj16 = ~obj15;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X10_v7 (Il2CppClass<CardGameVisualControls>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v4+130]");
					object obj17 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X10_v9-8]");
					if (0 == (nint)obj14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v16 (CardGameVisualControls)+148]");
						((JackarooBoardMono)0).HideHighlights();
						ShowTipsAndHighlights(base.<CardHit>k__BackingField);
						return;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void OnGamePerspectiveChanged(bool isPerspectiveTopDown)
	{
		//IL_002d: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00de: Expected F4, but got I4
		bool flag = ScreenUtility.CheckCurrentAspectRatio(ScreenUtility.AspectRatio.HD);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null || ScreenUtility.CheckCurrentAspectRatio(ScreenUtility.AspectRatio.SD))
		{
			Transform target = base.transform;
			int num = ShortcutExtensions.DOKill(target);
			Transform target2 = base.transform;
			bool flag3 = !isPerspectiveTopDown;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			float endValue = ((obj3 != null) ? 0f : (-25f));
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target2, endValue, 0.2f);
		}
	}

	private void MoveHandIfRequired(bool isPerspectiveTopDown)
	{
		//IL_002d: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00de: Expected F4, but got I4
		bool flag = ScreenUtility.CheckCurrentAspectRatio(ScreenUtility.AspectRatio.HD);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null || ScreenUtility.CheckCurrentAspectRatio(ScreenUtility.AspectRatio.SD))
		{
			Transform target = base.transform;
			int num = ShortcutExtensions.DOKill(target);
			Transform target2 = base.transform;
			bool flag3 = !isPerspectiveTopDown;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			float endValue = ((obj3 != null) ? 0f : (-25f));
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target2, endValue, 0.2f);
		}
	}

	private unsafe void ShowTipsAndHighlights(GameCard card)
	{
		//IL_0016: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_0043: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0071: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_03f9: Expected O, but got I
		//IL_0409: Expected O, but got I
		//IL_0419: Expected O, but got I
		//IL_043b: Expected O, but got I4
		//IL_046b: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0281: Expected I, but got O
		//IL_02b5: Expected I, but got O
		//IL_0203: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_024b: Expected O, but got I4
		//IL_026b: Expected O, but got I
		//IL_0555: Expected O, but got I
		//IL_056b: Expected O, but got I
		//IL_0585: Expected O, but got I4
		//IL_04ab: Expected O, but got I4
		//IL_12d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d9: Expected O, but got Unknown
		//IL_12ef: Expected O, but got I
		//IL_1300: Expected I, but got O
		//IL_131e: Expected O, but got I
		//IL_0640: Expected O, but got I4
		//IL_04e8: Expected I, but got O
		//IL_050f: Expected O, but got I4
		//IL_052f: Expected I, but got O
		//IL_04db: Expected O, but got I
		//IL_0396: Expected O, but got I4
		//IL_0fa6: Expected O, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02ec: Expected I, but got O
		//IL_02f4: Expected I, but got O
		//IL_0304: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_033d: Expected O, but got I4
		//IL_035a: Expected O, but got I
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06b5: Expected I, but got O
		//IL_06c5: Expected O, but got I
		//IL_0efc: Expected O, but got I
		//IL_0f2d: Expected O, but got I4
		//IL_0f42: Expected O, but got I
		//IL_078f: Expected I, but got O
		//IL_079f: Expected O, but got I
		//IL_07c3: Expected O, but got I4
		//IL_07cd: Expected O, but got I4
		//IL_07d2: Expected I, but got O
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected O, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected O, but got Unknown
		//IL_0fd7: Expected O, but got I
		//IL_0fed: Expected I4, but got O
		//IL_0ffd: Expected O, but got I
		//IL_1013: Expected O, but got I
		//IL_1042: Expected I, but got O
		//IL_105d: Expected O, but got I4
		//IL_0982: Expected I, but got O
		//IL_07f2: Expected O, but got I4
		//IL_07ff: Expected I, but got O
		//IL_080f: Expected O, but got Ref
		//IL_137c: Expected O, but got I
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_0a61: Expected I, but got O
		//IL_0821: Expected O, but got I
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_0837: Expected I, but got O
		//IL_0847: Expected O, but got I
		//IL_086a: Expected O, but got I4
		//IL_088c: Expected O, but got I4
		//IL_089c: Expected O, but got I
		//IL_08b4: Expected O, but got Ref
		//IL_108e: Expected I, but got O
		//IL_1424: Expected O, but got I
		//IL_1437: Unknown result type (might be due to invalid IL or missing references)
		//IL_143c: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0dcb: Expected O, but got I4
		//IL_0ddd: Expected O, but got I4
		//IL_13cc: Expected O, but got I
		//IL_13de: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Expected O, but got Unknown
		//IL_0a7b: Expected O, but got I
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_152b: Expected O, but got I4
		//IL_1193: Expected O, but got I4
		//IL_0a0e: Expected O, but got I
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected O, but got Unknown
		//IL_0dfe: Expected I, but got O
		//IL_0ac3: Expected I, but got O
		//IL_0ea9: Expected I, but got O
		//IL_0baa: Expected I, but got O
		//IL_156d: Expected O, but got I
		//IL_14c1: Expected O, but got I
		//IL_1123: Expected O, but got I4
		//IL_1469: Expected O, but got I
		//IL_147b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Expected O, but got Unknown
		//IL_0ec3: Expected O, but got I
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Expected O, but got Unknown
		//IL_0bc4: Expected O, but got I
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Expected O, but got Unknown
		//IL_115b: Expected O, but got I4
		//IL_0b4f: Expected O, but got I
		//IL_0c48: Expected I, but got O
		//IL_095b: Expected O, but got I4
		//IL_10cc: Expected I, but got O
		//IL_10d5: Expected O, but got I4
		//IL_0c63: Expected I, but got O
		//IL_0c6b: Expected I, but got O
		//IL_0c7b: Expected O, but got I
		//IL_0ca4: Expected O, but got I4
		//IL_0cd8: Expected O, but got I
		//IL_0cff: Expected O, but got I
		//IL_11c2: Expected O, but got I
		//IL_11d7: Expected I, but got O
		//IL_11e0: Expected O, but got I4
		//IL_0d7e: Expected O, but got I
		//IL_0d87: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD6]");
		object obj = (nint)0 & (nint)1;
		object obj3;
		Card card2;
		object obj4;
		CardGameVisualControls cardGameVisualControls;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
			cardGameVisualControls = (CardGameVisualControls)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			obj3 = 152993792;
			card2 = null;
			obj4 = 152993792;
			card2 = null;
			if (!flag)
			{
				goto IL_0092;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
			cardGameVisualControls = (CardGameVisualControls)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj3 = 152993792;
			card2 = null;
			obj4 = 152993792;
			card2 = null;
			if (obj6 != null)
			{
				goto IL_0092;
			}
		}
		_ = 1;
		List<object> allowedMoves = (List<object>)(object)_allowedMoves;
		bool flag3 = _allowedMoves == null;
		obj3 = obj4;
		GameCard gameCard = card;
		cardGameVisualControls = (CardGameVisualControls)1;
		ReadOnlyCollection<object> readOnlyCollection = (ReadOnlyCollection<object>)152993792;
		if (!flag3)
		{
			goto IL_019d;
		}
		goto IL_1289;
		IL_0f96:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E5]");
		cardGameVisualControls = (CardGameVisualControls)0;
		ReadOnlyCollection<object> readOnlyCollection2;
		bool flag4 = readOnlyCollection2 == null;
		object obj8;
		object obj7 = obj8;
		object obj10;
		object obj9 = obj10;
		nint num2;
		nint num = num2;
		IntPtr intPtr;
		nint num3 = intPtr;
		obj4 = obj3;
		readOnlyCollection = readOnlyCollection2;
		if (flag4)
		{
			goto IL_1289;
		}
		object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v60+B8]");
		object obj13 = 0;
		((JackarooCardGameVisualControls)(object)readOnlyCollection2).ShowTipsPanel(((UiCard)card).card, (JackarooAllowedRules)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X23_v6+BE3]");
		cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X23_v6+BE3]");
		object obj14 = (nint)0 & (nint)1;
		bool flag5 = obj14 == null;
		obj7 = obj8;
		obj9 = obj10;
		num = num2;
		nint num4 = (nint)obj13;
		ReadOnlyCollection<object> readOnlyCollection3 = null;
		Func<object, bool> func = (Func<object, bool>)(object)((UiCard)card).card;
		object obj15 = 146685952;
		if (flag5)
		{
			goto IL_05e6;
		}
		bool flag7 = default(bool);
		bool flag6 = flag7;
		object obj17 = default(object);
		object obj16 = obj17;
		num3 = intPtr;
		nint num5 = (nint)obj13;
		ReadOnlyCollection<object> readOnlyCollection4 = null;
		gameCard = (GameCard)(object)((UiCard)card).card;
		readOnlyCollection = readOnlyCollection2;
		goto IL_1335;
		IL_1131:
		NullReferenceException ex = new NullReferenceException();
		object obj19;
		object obj18 = obj19;
		nint num6;
		num = num6;
		nint num7 = num5;
		object obj20 = 1;
		ReadOnlyCollection<object> readOnlyCollection5;
		readOnlyCollection4 = readOnlyCollection5;
		goto IL_11fb;
		IL_11fb:
		num5 = num7;
		goto IL_1289;
		IL_0092:
		allowedMoves = (List<object>)(object)_allowedMoves;
		bool flag8 = _allowedMoves == null;
		object obj21 = !flag8;
		if (obj21 != null)
		{
			goto IL_019d;
		}
		gameCard = card;
		readOnlyCollection = (ReadOnlyCollection<object>)152993792;
		goto IL_1289;
		IL_019d:
		obj15 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
		object obj22 = (nint)0 + (nint)2328;
		ReadOnlyCollection<object> readOnlyCollection6 = allowedMoves.AsReadOnly();
		object obj23 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v65+E4]");
		object obj24;
		object obj25;
		if ((nint)0 != 0)
		{
			obj20 = (nint)0 + (nint)2640;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v65+B8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v43+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v43+8]");
			bool flag9 = (nint)0 == 0;
			readOnlyCollection4 = readOnlyCollection6;
			readOnlyCollection2 = (ReadOnlyCollection<object>)152993792;
			obj25 = obj20;
			readOnlyCollection3 = readOnlyCollection6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v43+8]");
			Func<object, bool> func2 = (Func<object, bool>)0;
			if (!flag9)
			{
				goto IL_0279;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj15;
			obj20 = (nint)0 + (nint)2640;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v65+B8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v43+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v43+8]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			readOnlyCollection4 = readOnlyCollection6;
			readOnlyCollection2 = readOnlyCollection6;
			obj25 = obj20;
			readOnlyCollection3 = readOnlyCollection6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v43+8]");
			Func<object, bool> func2 = (Func<object, bool>)0;
			if (obj26 != null)
			{
				goto IL_0279;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v65+E4]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v65+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v49+B8]");
			obj24 = 0;
		}
		readOnlyCollection2 = (ReadOnlyCollection<object>)obj24;
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)2008;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj24, (IntPtr)obj30);
		object obj31 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v48+B8]");
		object obj32 = (nint)0 + (nint)8;
		obj32 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num5 = (nint)obj25;
		bool flag12 = Enumerable.Any(readOnlyCollection3, func3);
		bool flag13 = !flag12;
		object obj33 = !flag13;
		readOnlyCollection4 = readOnlyCollection3;
		gameCard = (GameCard)(object)func3;
		intPtr = num3;
		num4 = (nint)obj25;
		func = func3;
		if (obj33 != null)
		{
			goto IL_1294;
		}
		goto IL_0545;
		IL_1335:
		bool flag14 = _allowedMoves == null;
		obj7 = obj8;
		num = num2;
		obj4 = obj3;
		bool flag17 = default(bool);
		Card card3 = default(Card);
		object obj38;
		if (!flag14)
		{
			gameCard = (GameCard)obj22;
			ReadOnlyCollection<object> readOnlyCollection7 = ((List<object>)(object)_allowedMoves).AsReadOnly();
			bool flag15 = readOnlyCollection7 == null;
			obj7 = obj8;
			num = num2;
			obj4 = obj3;
			if (!flag15)
			{
				object obj34 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3432;
				nint num8 = (nint)readOnlyCollection7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v17 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+12E]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v17 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_077d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v17 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+B0]");
				num = (nint)0 + (nint)8;
				bool flag16 = flag17;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)-8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)-8]");
					obj16 = 0 - obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)-8]");
					if (0 == (nint)obj34)
					{
						break;
					}
					num2 = num + 16;
					obj35--;
					obj16 = obj35 - 1;
					flag6 = obj16 == null;
					flag17 = (nint)obj35 != 1;
					flag16 = flag17;
					num = num2;
					if (flag17)
					{
						continue;
					}
					goto IL_077d;
				}
				object obj36 = num8 + num;
				object obj37 = obj36 + 312;
				num3 = (nint)obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v36+8]");
				gameCard = (GameCard)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v778 @ X8_v36] (should have been resolved before IL gen)");
				bool flag18 = card3 == null;
				obj38 = 0;
				flag17 = flag16;
				num2 = num;
				card2 = card3;
				obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)-8]");
				obj7 = 0;
				num7 = num5;
				card2 = card3;
				cardGameVisualControls = (CardGameVisualControls)(&card2);
				if (!flag18)
				{
					goto IL_08c2;
				}
				goto IL_10eb;
			}
		}
		goto IL_1289;
		IL_10f9:
		NullReferenceException ex2 = new NullReferenceException();
		obj18 = obj19;
		num = num6;
		num7 = num5;
		obj20 = 1;
		readOnlyCollection4 = readOnlyCollection5;
		goto IL_11fb;
		IL_05e6:
		_ = 1;
		flag6 = flag7;
		obj16 = obj17;
		obj8 = obj7;
		obj10 = obj9;
		num2 = num;
		num3 = intPtr;
		num5 = num4;
		readOnlyCollection4 = readOnlyCollection3;
		gameCard = (GameCard)(object)func;
		cardGameVisualControls = (CardGameVisualControls)1;
		readOnlyCollection = readOnlyCollection2;
		goto IL_1335;
		IL_10eb:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_11fb;
		IL_11a1:
		NullReferenceException ex4 = new NullReferenceException();
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v21-8]");
		num = 0;
		num7 = unchecked((nint)null);
		obj20 = 1;
		readOnlyCollection4 = readOnlyCollection5;
		gameCard = (GameCard)(object)((UiCard)card).card;
		goto IL_11fb;
		IL_0279:
		num5 = (nint)obj20;
		bool flag19 = Enumerable.Any(readOnlyCollection4, func);
		bool flag20 = !flag19;
		gameCard = (GameCard)(object)func;
		intPtr = num3;
		num4 = (nint)obj20;
		readOnlyCollection3 = readOnlyCollection4;
		if (flag20)
		{
			goto IL_0545;
		}
		goto IL_1294;
		IL_0545:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
		cardGameVisualControls = (CardGameVisualControls)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
		object obj39 = (nint)0 & (nint)1;
		bool flag21 = obj39 == null;
		object obj40 = !flag21;
		flag6 = flag7;
		obj16 = obj17;
		obj8 = obj7;
		obj10 = obj9;
		num2 = num;
		num3 = intPtr;
		num5 = num4;
		readOnlyCollection4 = readOnlyCollection3;
		gameCard = (GameCard)(object)func;
		readOnlyCollection = readOnlyCollection2;
		if (obj40 == null)
		{
			goto IL_05e6;
		}
		goto IL_1335;
		IL_1294:
		cardGameVisualControls = gameVisualControls;
		if ((object)gameVisualControls != null)
		{
			object obj41 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
			num3 = (nint)obj41;
			num = (nint)cardGameVisualControls;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+130]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+130]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
			bool flag22 = num9 < 0;
			object obj42 = !flag22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+130]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
			obj17 = num10 - 0;
			flag7 = obj17 == null;
			if (obj42 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+C8]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
				object obj43 = num11 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v44-8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v44-8]");
				bool flag23 = 0 < num3;
				obj42 = !flag23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v44-8]");
				obj17 = -num3;
				flag7 = obj17 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v44-8]");
				readOnlyCollection2 = (ReadOnlyCollection<object>)(object)((0 != num3) ? null : gameVisualControls);
				bool flag24 = (object)card == null;
				obj8 = obj7;
				obj10 = obj9;
				intPtr = num3;
				num = num2;
				obj4 = obj3;
				readOnlyCollection = readOnlyCollection2;
				if (!flag24)
				{
					goto IL_0f96;
				}
				goto IL_1289;
			}
		}
		bool flag25 = (object)card == null;
		object obj44 = !flag25;
		bool flag27 = default(bool);
		bool flag26 = flag27;
		obj8 = obj7;
		obj10 = obj9;
		num2 = num;
		intPtr = num3;
		readOnlyCollection2 = null;
		if (obj44 != null)
		{
			goto IL_0f96;
		}
		readOnlyCollection = null;
		goto IL_1289;
		IL_10ae:
		NullReferenceException ex5 = new NullReferenceException();
		obj18 = obj19;
		num = num6;
		num7 = unchecked((nint)null);
		obj20 = 1;
		readOnlyCollection4 = readOnlyCollection5;
		object obj45;
		gameCard = (GameCard)obj45;
		goto IL_11fb;
		IL_1289:
		throw new NullReferenceException();
		IL_08c2:
		obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj22 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 840;
		readOnlyCollection = (ReadOnlyCollection<object>)(typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152);
		obj19 = obj18;
		Card card4 = card3;
		readOnlyCollection5 = readOnlyCollection4;
		object obj47 = default(object);
		object obj48 = default(object);
		JackarooMove jackarooMove = default(JackarooMove);
		object obj53 = default(object);
		object obj60 = default(object);
		while (true)
		{
			nint num12 = (nint)card4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v22 (Il2CppClass<Card>)+12E]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v22 (Il2CppClass<Card>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a52;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v22 (Il2CppClass<Card>)+B0]");
			nint num13 = (nint)0 + (nint)8;
			bool flag28 = flag17;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X10_v32 (Il2CppClass<CardGameVisualControls>)-8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X10_v32 (Il2CppClass<CardGameVisualControls>)-8]");
				obj16 = 0 - obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X10_v32 (Il2CppClass<CardGameVisualControls>)-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				num2 = num13 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v22 (Il2CppClass<Card>)+12E]");
				num3 = -1;
				obj16 = num3 - 1;
				flag6 = obj16 == null;
				flag17 = num3 != 1;
				flag28 = flag17;
				num13 = num2;
				if (flag17)
				{
					continue;
				}
				goto IL_0a52;
			}
			num3 = num13;
			object obj46 = num12 + num13;
			obj47 = obj46 + 312;
			flag17 = flag28;
			num2 = num13;
			goto IL_140c;
			IL_091b:
			bool flag29 = card2 == null;
			card4 = card2;
			obj18 = obj19;
			obj7 = obj8;
			num = num2;
			num7 = num5;
			obj20 = 1;
			readOnlyCollection4 = readOnlyCollection5;
			gameCard = (GameCard)obj45;
			if (!flag29)
			{
				continue;
			}
			goto IL_10eb;
			IL_0b93:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = num2;
			num5 = unchecked((nint)null);
			goto IL_14a9;
			IL_14a9:
			cardGameVisualControls = (CardGameVisualControls)obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X0_v36+8]");
			gameCard = (GameCard)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1053 @ X0_v36] (should have been resolved before IL gen)");
			if (jackarooMove == null)
			{
				goto IL_10f9;
			}
			if ((object)card != null)
			{
				obj45 = ((UiCard)card).card;
				bool flag30 = object.Equals(jackarooMove.<Card>k__BackingField, ((UiCard)card).card);
				bool flag31 = !flag30;
				num2 = num6;
				num5 = unchecked((nint)null);
				if (flag31)
				{
					goto IL_091b;
				}
				cardGameVisualControls = gameVisualControls;
				if ((object)gameVisualControls != null)
				{
					num3 = (nint)readOnlyCollection;
					num6 = (nint)cardGameVisualControls;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X10_v18 (Il2CppClass<CardGameVisualControls>)+130]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
					bool flag32 = num14 < 0;
					object obj49 = !flag32;
					object obj50 = ~obj49;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X10_v18 (Il2CppClass<CardGameVisualControls>)+C8]");
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v21 (Il2CppClass<System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>>)+130]");
						object obj51 = num15 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v21-8]");
						num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v21-8]");
						obj16 = -num3;
						flag6 = obj16 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v21-8]");
						flag17 = 0 != num3;
						if (!flag17)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v30 (CardGameVisualControls)+148]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v30 (CardGameVisualControls)+148]");
								((JackarooBoardMono)0).HighlightMove(jackarooMove, highlightGuarded: true);
								obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v21-8]");
								num2 = 0;
								num5 = 1;
								readOnlyCollection5 = null;
								obj45 = jackarooMove;
								goto IL_091b;
							}
							goto IL_11a1;
						}
					}
				}
				goto IL_10ae;
			}
			goto IL_1131;
			IL_0a52:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = unchecked((nint)null);
			goto IL_140c;
			IL_140c:
			cardGameVisualControls = (CardGameVisualControls)obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v32+8]");
			gameCard = (GameCard)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v991 @ X0_v32] (should have been resolved before IL gen)");
			object obj52 = obj53 & 1;
			if (obj52 != null)
			{
				if (card2 == null)
				{
					break;
				}
				nint num16 = (nint)card2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v25 (Il2CppClass<Card>)+12E]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v25 (Il2CppClass<Card>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0b93;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v25 (Il2CppClass<Card>)+B0]");
				nint num17 = (nint)0 + (nint)8;
				bool flag33 = flag17;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X10_v27 (Il2CppClass<CardGameVisualControls>)-8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X10_v27 (Il2CppClass<CardGameVisualControls>)-8]");
					obj16 = 0 - obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X10_v27 (Il2CppClass<CardGameVisualControls>)-8]");
					if (0 == (nint)obj22)
					{
						break;
					}
					num2 = num17 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v25 (Il2CppClass<Card>)+12E]");
					num3 = -1;
					obj16 = num3 - 1;
					flag6 = obj16 == null;
					flag17 = num3 != 1;
					flag33 = flag17;
					num17 = num2;
					if (flag17)
					{
						continue;
					}
					goto IL_0b93;
				}
				num3 = num17;
				object obj54 = num16 + num17;
				obj48 = obj54 + 312;
				flag17 = flag33;
				num6 = num17;
				goto IL_14a9;
			}
			obj18 = obj19;
			num = num2;
			obj20 = 1;
			readOnlyCollection4 = readOnlyCollection5;
			object obj55 = 0;
			while (true)
			{
				if (card2 == null)
				{
					goto IL_1511;
				}
				object obj56 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num18 = (nint)card2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v6 (Il2CppClass<Card>)+12E]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v6 (Il2CppClass<Card>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0e9a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v6 (Il2CppClass<Card>)+B0]");
				nint num19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X10_v7 (Il2CppClass<CardGameVisualControls>)-8]");
					if (0 == (nint)obj56)
					{
						break;
					}
					num = num19 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v6 (Il2CppClass<Card>)+12E]");
					num3 = -1;
					bool flag34 = num3 != 1;
					num19 = num;
					if (flag34)
					{
						continue;
					}
					goto IL_0e9a;
				}
				num3 = num19;
				object obj57 = num18 + num19;
				object obj58 = obj57 + 312;
				num = num19;
				goto IL_155d;
				IL_1511:
				bool flag35 = obj55 == null;
				object obj59 = !flag35;
				if (obj59 == null)
				{
					return;
				}
				OutOfMemoryException ex6 = new OutOfMemoryException();
				if ((nint)gameCard != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj55 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj38 = obj60;
				continue;
				IL_0e9a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num5 = unchecked((nint)null);
				goto IL_155d;
				IL_155d:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v3+8]");
				gameCard = (GameCard)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v772 @ X0_v3] (should have been resolved before IL gen)");
				goto IL_1511;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		NullReferenceException ex7 = new NullReferenceException();
		obj18 = obj19;
		num = num2;
		num7 = num5;
		obj20 = 1;
		readOnlyCollection4 = readOnlyCollection5;
		goto IL_11fb;
		IL_077d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj61 = default(object);
		num3 = (nint)obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v56+8]");
		gameCard = (GameCard)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v713 @ X0_v56] (should have been resolved before IL gen)");
		bool flag36 = card3 == null;
		object obj62 = !flag36;
		obj38 = 0;
		num5 = unchecked((nint)null);
		card2 = card3;
		if (obj62 != null)
		{
			goto IL_08c2;
		}
		obj38 = 0;
		num = num2;
		num7 = unchecked((nint)null);
		card2 = card3;
		cardGameVisualControls = (CardGameVisualControls)(&card2);
		goto IL_10eb;
	}

	private unsafe void SelectMarble()
	{
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected O, but got Unknown
		//IL_0c37: Expected O, but got I4
		//IL_0c51: Expected O, but got I4
		//IL_0c73: Expected O, but got I4
		//IL_0015: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_00c1: Expected O, but got Ref
		//IL_026e: Expected O, but got Ref
		//IL_02c1: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0330: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_03e4: Expected O, but got I
		//IL_0517: Expected F4, but got I4
		//IL_0525: Expected O, but got I4
		//IL_044f: Expected F4, but got I4
		//IL_045d: Expected O, but got I4
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_055d: Expected O, but got I
		//IL_057f: Expected O, but got I
		//IL_0588: Expected O, but got I4
		//IL_0645: Expected O, but got I4
		//IL_0705: Expected O, but got I
		//IL_0728: Expected O, but got I4
		//IL_0731: Expected O, but got I4
		//IL_073f: Expected O, but got I4
		//IL_06a1: Expected O, but got I
		//IL_06bf: Expected O, but got I4
		//IL_06c8: Expected O, but got I4
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_06e4: Expected O, but got I4
		//IL_0806: Expected O, but got I
		//IL_0829: Expected O, but got I4
		//IL_0832: Expected O, but got I4
		//IL_0843: Expected O, but got I4
		//IL_079c: Expected O, but got I
		//IL_07ba: Expected O, but got I4
		//IL_07c3: Expected O, but got I4
		//IL_07e2: Expected O, but got I4
		//IL_0887: Expected O, but got I
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected O, but got Unknown
		//IL_0cd5: Expected O, but got I
		//IL_0ce3: Expected I, but got O
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected O, but got Unknown
		//IL_0b2d: Expected I, but got O
		//IL_0b56: Expected O, but got I4
		//IL_0b99: Expected O, but got I
		//IL_0992: Expected O, but got I4
		//IL_099b: Expected O, but got I4
		//IL_09a9: Expected O, but got I4
		//IL_0931: Expected O, but got I4
		//IL_093a: Expected O, but got I4
		//IL_0956: Expected O, but got I4
		//IL_0a4b: Expected O, but got I4
		//IL_059d: Expected O, but got I
		//IL_05ad: Expected O, but got I
		//IL_05bd: Expected O, but got I
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 400;
		object obj2 = <playingStage>k__BackingField - 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		object obj4 = ~obj3;
		bool flag2;
		if (obj4 == null)
		{
			object obj5 = <playingStage>k__BackingField - 3;
			flag2 = obj5 == null;
		}
		else
		{
			flag2 = true;
		}
		object obj6 = !flag2;
		Ray ray3 = default(Ray);
		RaycastHit hitInfo;
		object obj10;
		UnityEngine.Object obj12 = default(UnityEngine.Object);
		int num;
		if (obj6 == null)
		{
			Vector2 pointerPosition = InputUtil.PointerPosition;
			Ray ray = CameraInputExtensions.ScreenPointToRayThroughRenderTexture(_mainCamera, (Vector3)0);
			Ray ray2 = default(Ray);
			_ray = ray2;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v31+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Physics.Raycast((Ray)(&ray3), out hitInfo, 2000f))
			{
				return;
			}
			Transform transform = hitInfo.transform;
			if ((object)transform != null)
			{
				Transform parent = transform.parent;
				if ((object)parent != null)
				{
					object obj9 = (nint)0 + (nint)3896;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					obj10 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v39+E4]");
					if ((nint)0 != 0)
					{
						bool flag4 = obj12 == null;
						bool flag5 = !flag4;
						object obj13 = 0;
						if (!flag5)
						{
							return;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag6 = obj12 == null;
						bool flag7 = !flag6;
						object obj14 = !flag7;
						object obj13 = 0;
						if (obj14 != null)
						{
							return;
						}
					}
					if ((object)obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v38 (UnityEngine.Object)+30]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v38 (UnityEngine.Object)+30]");
							Vector3 position = ((Transform)0).position;
							object obj15 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v43+E4]");
							if ((nint)0 != 0)
							{
								num = Physics.OverlapSphereNonAlloc((Vector3)_colliders, 2000f, null);
								bool flag8 = num >= 2;
								float checkRadius = _checkRadius;
								float num2 = 1.1572347E+09f;
								Collider[] array = null;
								object obj16 = 0;
								if (flag8)
								{
									goto IL_0533;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num = Physics.OverlapSphereNonAlloc((Vector3)_colliders, 2000f, null);
								bool flag9 = num < 2;
								float checkRadius = _checkRadius;
								float num2 = 1.1572347E+09f;
								Collider[] array = null;
								object obj16 = 0;
								if (!flag9)
								{
									goto IL_0533;
								}
							}
							goto IL_0b6e;
						}
					}
				}
			}
		}
		else
		{
			if (<playingStage>k__BackingField != JackarooPlayingStage.SelectingFromPicker)
			{
				return;
			}
			Vector2 pointerPosition2 = InputUtil.PointerPosition;
			Ray ray4 = CameraInputExtensions.ScreenPointToRayThroughRenderTexture(_mainCamera, (Vector3)0);
			Ray ray5 = default(Ray);
			_ray = ray5;
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v11+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Physics.Raycast((Ray)(&ray3), out var hitInfo2, 2000f))
			{
				return;
			}
			Collider collider = hitInfo2.collider;
			if ((object)collider != null)
			{
				object obj19 = (nint)0 + (nint)3904;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v18+E4]");
				UnityEngine.Object obj22 = default(UnityEngine.Object);
				if ((nint)0 != 0)
				{
					bool flag11 = obj22 != null;
					bool flag12 = !flag11;
					object obj23 = !flag12;
					if (obj23 == null)
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (!(obj22 != null))
					{
						return;
					}
				}
				if ((object)obj22 != null)
				{
					((JackarooZoomInPickerOption)obj22).SelectOption();
					return;
				}
			}
		}
		goto IL_0bfe;
		IL_0cab:
		object obj24 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)736;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj25);
		JackarooCardGameVisualControls jackarooCardGameVisualControls;
		List<object> list = default(List<object>);
		if ((object)jackarooCardGameVisualControls != null)
		{
			jackarooCardGameVisualControls.ShowPickerPanel((JackarooMarbleMono)obj12, (List<JackarooMarbleMono>)(object)list, action);
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingFromPicker;
			return;
		}
		goto IL_0bfe;
		IL_0c0c:
		throw new IndexOutOfRangeException();
		IL_0533:
		object obj26 = typeof(List<AdaptivePerformanceScaler>) + 1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2248;
		object obj28 = obj27;
		list..ctor();
		object obj29 = (nint)0 + (nint)2256;
		object obj30 = 0;
		UnityEngine.Object obj42 = default(UnityEngine.Object);
		while (true)
		{
			Collider[] colliders = _colliders;
			if (_colliders == null)
			{
				break;
			}
			bool flag13 = (nint)obj30 < colliders.Length;
			object obj31 = !flag13;
			if (obj31 == null)
			{
				object obj32 = (object)_colliders + obj30;
				object obj33 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v50+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v31+20]");
					bool flag14 = (UnityEngine.Object)0 == null;
					bool flag15 = !flag14;
					object obj34 = !flag15;
					object obj13 = 0;
					obj28 = null;
					if (obj34 != null)
					{
						goto IL_05d7;
					}
					object obj35 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v31+20]");
					bool flag16 = (UnityEngine.Object)0 == null;
					bool flag17 = !flag16;
					object obj36 = !flag17;
					object obj13 = 0;
					obj28 = null;
					object obj35 = 0;
					if (obj36 != null)
					{
						goto IL_05d7;
					}
				}
				Collider collider2 = hitInfo.collider;
				object obj37 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X0_v54+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v31+20]");
					bool flag18 = (UnityEngine.Object)0 == collider2;
					bool flag19 = !flag18;
					object obj38 = !flag19;
					object obj13 = 0;
					obj28 = collider2;
					if (obj38 != null)
					{
						goto IL_05d7;
					}
					object obj39 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v31+20]");
					bool flag20 = (UnityEngine.Object)0 == collider2;
					bool flag21 = !flag20;
					object obj40 = !flag21;
					object obj13 = 0;
					obj28 = collider2;
					object obj39 = 0;
					if (obj40 != null)
					{
						goto IL_05d7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v31+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v31+20]");
				Transform transform2 = ((Component)0).transform;
				if ((object)transform2 == null)
				{
					break;
				}
				Transform parent2 = transform2.parent;
				if ((object)parent2 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj41 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v60+E4]");
				object obj44;
				if ((nint)0 != 0)
				{
					bool flag22 = obj42 == null;
					bool flag23 = !flag22;
					object obj43 = !flag23;
					object obj13 = 0;
					obj28 = null;
					if (obj43 != null)
					{
						goto IL_05d7;
					}
					obj44 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag24 = obj42 == null;
					bool flag25 = !flag24;
					object obj45 = !flag25;
					object obj13 = 0;
					obj28 = null;
					obj44 = 0;
					if (obj45 != null)
					{
						goto IL_05d7;
					}
				}
				if (list == null)
				{
					break;
				}
				object obj46 = obj29;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items == null)
				{
					break;
				}
				bool flag26 = list._size < items.Length;
				object obj47 = !flag26;
				if (obj47 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v35+20]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v37+C0]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v38+70]");
					object obj13 = 0;
					list.AddWithResize((object)obj42);
					obj28 = obj42;
				}
				else
				{
					int size = list._size + 1;
					list._size = size;
					object obj50 = list._items + list._size;
					object obj51 = obj50 + 32;
					obj51 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj13 = obj44;
					obj28 = obj42;
				}
				goto IL_05d7;
			}
			goto IL_0c0c;
			IL_05d7:
			obj30++;
			if (num != (nint)obj30)
			{
				continue;
			}
			goto IL_0ac5;
		}
		goto IL_0bfe;
		IL_0ac5:
		if (list == null)
		{
			goto IL_0bfe;
		}
		if (list._size < 1)
		{
			goto IL_0b6e;
		}
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		if ((object)gameVisualControls != null)
		{
			object obj52 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
			object obj53 = obj52;
			nint num3 = (nint)cardGameVisualControls;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X10_v10 (Il2CppClass<CardGameVisualControls>)+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X9_v15+130]");
			bool flag27 = num4 < 0;
			object obj54 = !flag27;
			if (obj54 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X10_v10 (Il2CppClass<CardGameVisualControls>)+C8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X9_v15+130]");
				object obj55 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X10_v12-8]");
				jackarooCardGameVisualControls = (JackarooCardGameVisualControls)((0 != (nint)obj53) ? null : gameVisualControls);
				goto IL_0cab;
			}
		}
		jackarooCardGameVisualControls = null;
		goto IL_0cab;
		IL_0bfe:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0c0c;
		IL_0b6e:
		((JackarooMarbleMono)obj12).SelectMarble();
	}

	protected override void OnMouseButtonUp()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_010d: Expected I, but got O
		//IL_0136: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_01b7: Expected I, but got O
		//IL_01e0: Expected O, but got I4
		//IL_0214: Expected O, but got I
		if (!CanClickGoThrough())
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = base.<CardHit>k__BackingField == null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				goto IL_007a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(base.<CardHit>k__BackingField == null))
			{
				goto IL_007a;
			}
		}
		bool flag3 = <playingStage>k__BackingField == JackarooPlayingStage.None;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			CardGameVisualControls cardGameVisualControls = gameVisualControls;
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
			object obj6 = obj5;
			nint num = (nint)cardGameVisualControls;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X9_v2+130]");
			bool flag4 = num2 < 0;
			object obj7 = !flag4;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X9_v2+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X10_v4-8]");
				if (0 == (nint)obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v9 (CardGameVisualControls)+148]");
					((JackarooBoardMono)0).HideHighlights();
					JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
					object obj10 = obj5;
					nint num4 = (nint)jackarooCardGameVisualControls;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X9_v3 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v13+130]");
					bool flag5 = num5 < 0;
					object obj11 = !flag5;
					object obj12 = ~obj11;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X9_v3 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v13+130]");
						object obj13 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X9_v5-8]");
						if (0 == (nint)obj10)
						{
							jackarooCardGameVisualControls.HideTipsPanel();
							base.OnMouseButtonUp();
							return;
						}
					}
				}
			}
			throw new NullReferenceException();
		}
		goto IL_007a;
		IL_007a:
		base.OnMouseButtonUp();
	}

	protected override void OnTouchUp(GameCard gameCard)
	{
		if (<playingStage>k__BackingField == JackarooPlayingStage.None)
		{
			base.OnTouchUp(gameCard);
		}
	}

	protected override void OnCardClicked(GameCard clickedGameCard)
	{
		OnCardClicked(((UiCard)clickedGameCard).card);
	}

	private void OnCardClicked(Card clickedCard)
	{
		//IL_01e2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		//IL_00e1: Expected O, but got I
		bool flag = !_awaitingPlayConfirmation;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		IEnumerable<JackarooMove> allowedMovesForCard = GetAllowedMovesForCard(clickedCard);
		object[] array = Enumerable.ToArray((IEnumerable<object>)allowedMovesForCard);
		bool flag3;
		GameAction? gameAction2;
		if (array.Length == 1)
		{
			object obj2 = array[0];
			GameAction? gameAction;
			if (base._isFireModeActive)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12 (System.Object)+18]");
				gameAction = GetFireModeGameActionForAction(JackarooActions.NONE);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12 (System.Object)+18]");
				gameAction = GetGameActionForAction(JackarooActions.NONE);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12 (System.Object)+18]");
			object obj3 = -262144;
			bool flag2 = obj3 == null;
			flag3 = flag2;
			gameAction2 = gameAction;
		}
		else
		{
			flag3 = false;
			gameAction2 = (GameAction?)(object)0;
		}
		JackarooMove[] cardAllowedSpecialMoves = GetCardAllowedSpecialMoves(clickedCard);
		object obj4 = array.Length - 1;
		bool oneMove = obj4 == null;
		bool flag4 = cardAllowedSpecialMoves.Length == 0;
		bool hasSpecialMove = !flag4;
		bool flag5 = TryPlayCard(clickedCard, clickedByUser: true, oneMove, hasSpecialMove, gameAction2);
		ReadOnlyCollection<object> allowedMoves = ((List<object>)(object)_allowedMoves).AsReadOnly();
		bool playCard = (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
		HandleMarblePlay((IReadOnlyList<JackarooMove>)allowedMoves, playCard, clickedCard, gameAction2);
		if (flag3)
		{
			_wasStealing = true;
		}
	}

	public bool TryPlayCard(Card card, bool clickedByUser, bool oneMove, bool hasSpecialMove, GameAction? gameAction = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_05a3: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_0145: Expected O, but got I4
		//IL_0186: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0248: Expected I, but got O
		//IL_0271: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_036c: Expected O, but got I
		//IL_048c: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_042b: Expected O, but got I
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj7;
		object obj8;
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
			object obj4 = (nint)0 + (nint)2088;
			object obj5 = (nint)0 + (nint)824;
			object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
			obj7 = obj2 + 16;
			obj7 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			obj8 = Enumerable.FirstOrDefault(gameCardsSprite, func);
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				if (!((UnityEngine.Object)obj8 == null))
				{
					goto IL_0153;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = (UnityEngine.Object)obj8 == null;
				bool flag2 = !flag;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					goto IL_0153;
				}
			}
			goto IL_0307;
		}
		goto IL_0595;
		IL_02f4:
		((GameCard)obj8).SetStatus(CardStatus.Preplay);
		goto IL_0307;
		IL_0307:
		bool flag3 = false;
		goto IL_05fc;
		IL_0595:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0153:
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v11 (System.Object)+68]");
			object obj11 = (nint)0 & (nint)1;
			bool flag4 = obj11 == null;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				goto IL_0307;
			}
			if (player != null)
			{
				if (player.CanPlayCard)
				{
					bool flag5 = !playedCardThisTurn;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						CardGameVisualControls cardGameVisualControls = gameVisualControls;
						if ((object)gameVisualControls != null)
						{
							object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
							object obj15 = obj14;
							nint num = (nint)cardGameVisualControls;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v5 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+130]");
							bool flag6 = num2 < 0;
							object obj16 = !flag6;
							object obj17 = ~obj16;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v5 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+130]");
								object obj18 = num3 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X9_v7-8]");
								if (0 == (nint)obj15)
								{
									if (gameVisualControls.IsTooEarlyToPlayCard())
									{
										goto IL_02f4;
									}
									CardGamePlayer cardGamePlayer = player;
									if (player != null && cardGamePlayer.<PlayableCards>k__BackingField != null)
									{
										object obj19 = (nint)0 + (nint)2672;
										flag3 = ((List<object>)(object)cardGamePlayer.<PlayableCards>k__BackingField).Contains(obj7);
										if (flag3)
										{
											if (!oneMove || ShouldPlayQueenAsTwoStates((Card)obj7))
											{
												if (hasSpecialMove && base._isFireModeActive)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v11 (System.Object)+28]");
													_playedCard = (Card)0;
													object obj20 = this + 296;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													playedCardThisTurn = true;
													SetCardPreplayAndOthersDimmed((GameCard)obj8, gameCardsSprite);
													goto IL_0307;
												}
												DisableFireMode();
												DisableFireModeButton();
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v11 (System.Object)+28]");
												DoPlayCard((Card)0, gameAction);
												JackarooLastActionInfo lastActionInfo = LastActionInfo;
												if (lastActionInfo == null)
												{
													goto IL_0595;
												}
												object obj21 = "___# Content push apply failed [{0}]: {1}" + 2672;
												if (((LastActionInfo)lastActionInfo).<Action>k__BackingField != (string)obj21)
												{
													JackarooGame jackarooGame = JackarooGame;
													if ((object)jackarooGame == null)
													{
														goto IL_0595;
													}
													jackarooGame.ThrowCard(player, (Card)obj7);
												}
												bool flag7 = !clickedByUser;
												flag3 = true;
												if (!flag7)
												{
													IsCardBeingAnimated = true;
													flag3 = true;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v11 (System.Object)+28]");
												DoPlayCard((Card)0, gameAction);
												flag3 = true;
											}
										}
										goto IL_05fc;
									}
								}
							}
						}
						goto IL_0595;
					}
				}
				goto IL_02f4;
			}
		}
		goto IL_0595;
		IL_05fc:
		return flag3;
	}

	public bool ShouldPlayQueenAsTwoStates(Card card)
	{
		//IL_035d: Expected I4, but got O
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		//IL_009d: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0268: Expected O, but got I
		//IL_0278: Expected O, but got I
		//IL_029a: Expected O, but got I4
		//IL_02aa: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01dc: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_02da: Expected O, but got I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I
		//IL_03de: Expected I, but got O
		//IL_03fc: Expected O, but got I
		//IL_033b: Expected O, but got I4
		//IL_030a: Expected O, but got I
		Card card2 = default(Card);
		object[] source;
		Func<object, bool> predicate;
		if (card2 != null)
		{
			if (card2.<Rank>k__BackingField != Rank.QUEEN)
			{
				goto IL_0349;
			}
			IEnumerable<JackarooMove> allowedMovesForCard = GetAllowedMovesForCard(card2);
			source = Enumerable.ToArray((IEnumerable<object>)allowedMovesForCard);
			JackarooGame jackarooGame = (JackarooGame)game;
			if ((object)game != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)jackarooGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v3 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v3 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v5-8]");
					if (0 == (nint)obj2)
					{
						JackarooPlayer nextPlayer = ((JackarooGame)game).GetNextPlayer((KPlayer)player);
						if (nextPlayer != null)
						{
							List<Card> <Cards>k__BackingField = ((CardGamePlayer)nextPlayer).<Cards>k__BackingField;
							if (((CardGamePlayer)nextPlayer).<Cards>k__BackingField != null)
							{
								if (<Cards>k__BackingField._size >= 2)
								{
									object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
									object obj7 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+E4]");
									object obj8;
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+B8]");
										obj8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
										predicate = (Func<object, bool>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
										bool flag2 = (nint)0 == 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
										Func<object, bool> func = (Func<object, bool>)0;
										if (!flag2)
										{
											goto IL_0211;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj7 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+B8]");
										obj8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
										predicate = (Func<object, bool>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
										bool flag3 = (nint)0 == 0;
										object obj9 = !flag3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+10]");
										Func<object, bool> func = (Func<object, bool>)0;
										if (obj9 != null)
										{
											goto IL_0211;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+E4]");
									bool flag4 = (nint)0 == 0;
									object obj10 = !flag4;
									if (obj10 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj11 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v25+B8]");
										obj8 = 0;
									}
									object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj13 = (nint)0 + (nint)1968;
									Func<object, bool> func2 = default(Func<object, bool>);
									func2..ctor(obj8, (IntPtr)obj13);
									object obj14 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v22+B8]");
									object obj15 = (nint)0 + (nint)16;
									obj15 = func2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag5 = Enumerable.Any(source, func2);
									bool flag6 = !flag5;
									object obj16 = !flag6;
									if (obj16 != null)
									{
										goto IL_0240;
									}
								}
								goto IL_0349;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0240:
		return true;
		IL_0211:
		if (Enumerable.Any(source, predicate))
		{
			goto IL_0240;
		}
		goto IL_0349;
		IL_0349:
		return false;
	}

	private static void SetCardPreplayAndOthersDimmed(GameCard gameCard, GameCard[] allGameCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_008d: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = gameCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj5 = (nint)0 + (nint)2096;
		((GameCard)obj3).SetStatus(CardStatus.Preplay);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		ArraysExtensions.ForEach(allGameCards, action);
	}

	protected new bool CanAffordSpecialPlay(int virtualPrice)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_0178: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01dd: Expected I4, but got O
		//IL_01c1: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I4, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BAB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01cf;
		IL_00b8:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj9 = aces - virtualPrice;
		bool flag4 = (nint)obj9 < 0;
		int num = aces ^ virtualPrice;
		int num2 = aces ^ obj9;
		int num3 = num & num2;
		bool flag5 = num3 < 0;
		return flag4 == flag5;
		IL_01cf:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_01cf;
	}

	private void HandleMarblePlay(IReadOnlyList<JackarooMove> allowedMoves, bool playCard, Card clickedCard, GameAction? gameAction = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_13f7: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0064: Expected I, but got O
		//IL_008d: Expected O, but got I4
		//IL_149d: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_027d: Expected I, but got O
		//IL_028d: Expected O, but got I
		//IL_0323: Expected O, but got I
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03d6: Expected I, but got O
		//IL_03e6: Expected O, but got I
		//IL_02c8: Expected O, but got I
		//IL_04a0: Expected O, but got I4
		//IL_0421: Expected O, but got I
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0383: Expected O, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0887: Expected I, but got O
		//IL_0897: Expected O, but got I
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_08d2: Expected O, but got I
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d2: Expected O, but got Unknown
		//IL_13db: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e0: Expected O, but got Unknown
		//IL_0657: Expected O, but got I
		//IL_065f: Expected I4, but got O
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_06d8: Expected O, but got I
		//IL_06e0: Expected I4, but got O
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0944: Expected O, but got I
		//IL_0954: Expected O, but got I
		//IL_0976: Expected O, but got I4
		//IL_0d38: Expected O, but got I
		//IL_0d48: Expected O, but got I
		//IL_0d6a: Expected O, but got I4
		//IL_0d7a: Expected O, but got I
		//IL_09e7: Expected O, but got I
		//IL_083a: Expected O, but got I
		//IL_084a: Expected O, but got I
		//IL_086c: Expected O, but got I4
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected O, but got Unknown
		//IL_0ee4: Expected O, but got I4
		//IL_0cc2: Expected O, but got I
		//IL_0ced: Expected I4, but got O
		//IL_0c71: Expected O, but got I
		//IL_0c81: Expected O, but got I
		//IL_0ca8: Expected O, but got I
		//IL_09a6: Expected O, but got I4
		//IL_17d8: Expected O, but got I
		//IL_17e8: Expected O, but got I
		//IL_180a: Expected O, but got I4
		//IL_0daa: Expected O, but got I4
		//IL_0b1b: Expected O, but got I
		//IL_0b2b: Expected O, but got I
		//IL_0b4d: Expected O, but got I4
		//IL_0b5d: Expected O, but got I
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_165f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Expected O, but got Unknown
		//IL_167a: Expected O, but got I
		//IL_168b: Expected I, but got O
		//IL_16a9: Expected O, but got I
		//IL_0f6c: Expected O, but got I
		//IL_0f74: Expected I4, but got O
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_176c: Expected O, but got Unknown
		//IL_1782: Expected O, but got I
		//IL_1793: Expected I, but got O
		//IL_17b1: Expected O, but got I
		//IL_0ab1: Expected I4, but got O
		//IL_0a64: Expected O, but got I
		//IL_0a74: Expected O, but got I
		//IL_0a9b: Expected O, but got I
		//IL_09d6: Expected O, but got I
		//IL_0f2b: Expected O, but got I4
		//IL_0deb: Expected O, but got I
		//IL_0e19: Expected O, but got I4
		//IL_0e26: Expected I4, but got O
		//IL_0dda: Expected O, but got I
		//IL_0b8d: Expected O, but got I4
		//IL_1827: Unknown result type (might be due to invalid IL or missing references)
		//IL_182c: Expected O, but got Unknown
		//IL_1842: Expected O, but got I
		//IL_1853: Expected I, but got O
		//IL_1871: Expected O, but got I
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		//IL_1712: Expected O, but got I
		//IL_1723: Expected I, but got O
		//IL_1741: Expected O, but got I
		//IL_0f5b: Expected O, but got I
		//IL_0fdb: Expected I, but got O
		//IL_1004: Expected O, but got I4
		//IL_0bca: Expected I4, but got O
		//IL_0bf3: Expected O, but got I4
		//IL_0bbd: Expected O, but got I
		//IL_1038: Expected O, but got I
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Expected O, but got Unknown
		//IL_1092: Expected I, but got O
		//IL_10bb: Expected O, but got I4
		//IL_1100: Expected O, but got I
		//IL_118f: Expected O, but got I
		//IL_11a9: Expected O, but got I4
		//IL_11b2: Expected O, but got I4
		//IL_11ef: Expected O, but got I
		//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Expected O, but got Unknown
		//IL_1212: Unknown result type (might be due to invalid IL or missing references)
		//IL_1217: Expected O, but got Unknown
		//IL_1223: Expected O, but got I
		//IL_122c: Expected O, but got I4
		//IL_127a: Expected O, but got I4
		//IL_1283: Expected O, but got I4
		//IL_129f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a4: Expected O, but got Unknown
		//IL_12bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c4: Expected O, but got Unknown
		//IL_1434: Expected O, but got I4
		//IL_143d: Expected O, but got I4
		//IL_1310: Expected O, but got I
		//IL_1375: Expected I, but got O
		//IL_138f: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		Card card = clickedCard;
		JackarooHand jackarooHand = null;
		object obj4;
		bool size;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			CardGameVisualControls cardGameVisualControls = gameVisualControls;
			bool flag2 = (object)gameVisualControls == null;
			card = clickedCard;
			jackarooHand = this;
			if (!flag2)
			{
				obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
				object obj5 = obj4;
				nint num = (nint)cardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v5 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X9_v5+130]");
				bool flag3 = num2 < 0;
				object obj6 = !flag3;
				object obj7 = ~obj6;
				card = clickedCard;
				jackarooHand = this;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v5 (Il2CppClass<CardGameVisualControls>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X9_v5+130]");
					object obj8 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X10_v7-8]");
					bool flag4 = 0 != (nint)obj5;
					card = clickedCard;
					jackarooHand = this;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v12 (CardGameVisualControls)+148]");
						bool flag5 = (nint)0 == 0;
						card = clickedCard;
						jackarooHand = this;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v12 (CardGameVisualControls)+148]");
							((JackarooBoardMono)0).HideHighlights();
							List<JackarooMove> selectedMovesByCard = _selectedMovesByCard;
							bool flag6 = _selectedMovesByCard == null;
							card = clickedCard;
							jackarooHand = null;
							if (!flag6)
							{
								int version = selectedMovesByCard._version + 1;
								selectedMovesByCard._size = 0;
								selectedMovesByCard._version = version;
								bool flag7 = selectedMovesByCard._size < 1;
								card = clickedCard;
								if (!flag7)
								{
									Array.Clear(selectedMovesByCard._items, 0, selectedMovesByCard._size);
									card = null;
								}
								_selectedMarble1 = null;
								object obj9 = this + 264;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (clickedCard == null)
								{
									return;
								}
								bool flag8 = allowedMoves == null;
								size = (byte)selectedMovesByCard._size != 0;
								jackarooHand = null;
								if (!flag8)
								{
									object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2256;
									nint num4 = (nint)allowedMoves;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v16 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+12E]");
									object obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v16 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0309;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v16 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+B0]");
									object obj12 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X10_v32-8]");
										if (0 == (nint)obj10)
										{
											break;
										}
										obj12 += 16;
										obj11--;
										if ((nint)obj11 != 1)
										{
											continue;
										}
										goto IL_0309;
									}
									object obj13 = num4 + obj12;
									object obj14 = obj13 + 312;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v162+8]");
									jackarooHand = (JackarooHand)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v863 @ X0_v162] (should have been resolved before IL gen)");
									object obj15 = default(object);
									bool flag9 = (nint)obj15 != 1;
									size = (byte)selectedMovesByCard._size != 0;
									if (!flag9)
									{
										goto IL_03ba;
									}
									goto IL_05a6;
								}
							}
						}
					}
				}
			}
		}
		goto IL_13e5;
		IL_0c0e:
		Rank <Rank>k__BackingField = clickedCard.<Rank>k__BackingField;
		goto IL_15db;
		IL_1945:
		IEnumerable<object> enumerable;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		JackarooHand jackarooHand2 = default(JackarooHand);
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		GameAction? gameAction2 = default(GameAction?);
		if (<Rank>k__BackingField != Rank.ACE)
		{
			if (<Rank>k__BackingField != Rank.JACK)
			{
				bool flag10 = <Rank>k__BackingField != Rank.SEVEN;
				jackarooHand = (JackarooHand)enumerable;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
					PlaySeven(playCard: false);
					return;
				}
			}
			else
			{
				object obj16 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ X0_v67+E4]");
				bool flag11 = (nint)0 == 0;
				object obj18 = !flag11;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ X0_v67+B8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v53+30]");
				Func<object, bool> func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v53+30]");
				bool flag12 = (nint)0 == 0;
				object obj20 = !flag12;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ X0_v67+E4]");
					bool flag13 = (nint)0 == 0;
					object obj21 = !flag13;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj22 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v59+B8]");
						obj19 = 0;
					}
					object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj24 = (nint)0 + (nint)1944;
					Func<object, bool> func2 = default(Func<object, bool>);
					func2..ctor(obj19, (IntPtr)obj24);
					object obj25 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X8_v58+B8]");
					object obj26 = (nint)0 + (nint)48;
					obj26 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					card = null;
					func = func2;
				}
				object obj27 = (nint)0 + (nint)2640;
				size = (byte)(int)obj27 != 0;
				bool flag14 = Enumerable.Any(_selectedMovesByCard, func);
				bool flag15 = !flag14;
				jackarooHand = (JackarooHand)(object)func;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
					PlayJack(playCard: false);
					return;
				}
			}
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
			JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
			if ((object)gameVisualControls != null)
			{
				object obj28 = obj4;
				nint num5 = (nint)jackarooCardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v14 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v31+130]");
				bool flag16 = num6 < 0;
				object obj29 = !flag16;
				object obj30 = ~obj29;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v14 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v31+130]");
					object obj31 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v16-8]");
					if (0 == (nint)obj28)
					{
						object obj32 = "SERVICE_DISABLED" + 2600;
						((JackarooCardGameVisualControls)gameVisualControls).ShowActionTipPanel((string)obj32);
						CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
						bool flag17 = (object)gameVisualControls == null;
						size = false;
						jackarooHand = (JackarooHand)obj32;
						if (!flag17)
						{
							object obj33 = obj4;
							nint num8 = (nint)cardGameVisualControls2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v12 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v18+130]");
							bool flag18 = num9 < 0;
							object obj34 = !flag18;
							object obj35 = ~obj34;
							size = false;
							jackarooHand = (JackarooHand)obj32;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v12 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v18+130]");
								object obj36 = num10 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ X10_v14-8]");
								bool flag19 = 0 != (nint)obj33;
								size = false;
								jackarooHand = (JackarooHand)obj32;
								if (!flag19)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v36 (CardGameVisualControls)+148]");
									bool flag20 = (nint)0 == 0;
									size = false;
									jackarooHand = (JackarooHand)obj32;
									if (!flag20)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v36 (CardGameVisualControls)+148]");
										((JackarooBoardMono)0).HighlightMoves(_selectedMovesByCard);
										bool flag21 = _selectedMovesByCard == null;
										gameAction2 = (GameAction?)(object)0;
										card = (Card)1;
										size = true;
										jackarooHand = (JackarooHand)(object)_selectedMovesByCard;
										if (!flag21)
										{
											List<object>.Enumerator enumerator = ((List<object>)(object)_selectedMovesByCard).GetEnumerator();
											object obj37 = (nint)0 + (nint)2800;
											object obj38 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 632;
											object obj39 = typeof(SqlSingle[]) + 2376;
											object obj40 = (nint)0 + (nint)2104;
											card = (Card)1;
											size = true;
											object obj41 = default(object);
											Action action = default(Action);
											while (true)
											{
												if (enumerator2.MoveNext())
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													obj41..ctor();
													bool flag22 = obj41 == null;
													enumerator2 = enumerator3;
													enumerator4 = enumerator3;
													enumerator3 = (List<object>.Enumerator)0;
													gameAction2 = (GameAction?)(object)0;
													jackarooHand = null;
													if (flag22)
													{
														break;
													}
													object obj42 = obj41 + 24;
													obj42 = obj2;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj43 = obj41 + 16;
													obj43 = jackarooHand2;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj44 = obj43;
													if (obj43 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v45+20]");
														object obj45 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v45+20]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ X8_v46+18]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																action..ctor(obj41, (IntPtr)obj40);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ X8_v46+18]");
																((JackarooMarbleMono)0).SetupSelect(action);
																card = null;
																size = false;
															}
														}
														continue;
													}
													goto IL_1412;
												}
												enumerator2.Dispose();
												return;
											}
											goto IL_13fc;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_13e5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
		PlayAce(playCard: false);
		return;
		IL_15db:
		Func<object, bool> func3;
		if (<Rank>k__BackingField == Rank.TEN)
		{
			object obj46 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v84+E4]");
			object obj48;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v84+B8]");
				obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X8_v65+28]");
				func3 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X8_v65+28]");
				bool flag23 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X8_v65+28]");
				Func<object, bool> func4 = (Func<object, bool>)0;
				if (!flag23)
				{
					goto IL_0cb6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v84+B8]");
				obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X8_v65+28]");
				func3 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X8_v65+28]");
				bool flag24 = (nint)0 == 0;
				object obj49 = !flag24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X8_v65+28]");
				Func<object, bool> func4 = (Func<object, bool>)0;
				if (obj49 != null)
				{
					goto IL_0cb6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v84+E4]");
			bool flag25 = (nint)0 == 0;
			object obj50 = !flag25;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj51 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X8_v73+B8]");
				obj48 = 0;
			}
			object obj52 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj53 = (nint)0 + (nint)1936;
			Func<object, bool> func5 = default(Func<object, bool>);
			func5..ctor(obj48, (IntPtr)obj53);
			object obj54 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ X8_v70+B8]");
			object obj55 = (nint)0 + (nint)40;
			obj55 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj56 = (nint)0 + (nint)2640;
			bool flag26 = Enumerable.Any(_selectedMovesByCard, func5);
			bool flag27 = !flag26;
			object obj57 = !flag27;
			card = null;
			size = (byte)(int)obj56 != 0;
			enumerable = (IEnumerable<object>)(object)func5;
			if (obj57 != null)
			{
				goto IL_0d03;
			}
			goto IL_0e3c;
		}
		goto IL_1945;
		IL_1450:
		bool flag28 = (nint)jackarooHand != 1;
		NullReferenceException ex2;
		NullReferenceException ex = ex2;
		List<object>.Enumerator enumerator5;
		if (!flag28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj58 = (nint)0 + (nint)2792;
			jackarooHand = (JackarooHand)obj58;
			enumerator5.Dispose();
			object obj59 = default(object);
			if (obj59 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj59;
			ex = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0913:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_161f;
		IL_161f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1107 @ X0_v144] (should have been resolved before IL gen)");
		List<JackarooMove> selectedMovesByCard2 = _selectedMovesByCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
		bool playCard2 = false;
		JackarooMove jackarooMove = default(JackarooMove);
		JackarooMove move = jackarooMove;
		goto IL_15c4;
		IL_1412:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		gameAction2 = (GameAction?)(object)0;
		jackarooHand = jackarooHand2;
		goto IL_1450;
		IL_15c4:
		DoPlayMove(move, selectedMovesByCard2, playCard2, gameAction2);
		return;
		IL_05a6:
		CardGamePlayer cardGamePlayer = player;
		if (player != null)
		{
			List<Card> <Cards>k__BackingField = cardGamePlayer.<Cards>k__BackingField;
			if (cardGamePlayer.<Cards>k__BackingField != null)
			{
				bool flag29 = <Cards>k__BackingField._size == 1;
				IEnumerable<JackarooMove> enumerable2 = allowedMoves;
				if (!flag29)
				{
					IEnumerable<JackarooMove> allowedMovesForCard = GetAllowedMovesForCard(clickedCard);
					jackarooHand = (JackarooHand)(object)clickedCard;
					enumerable2 = allowedMovesForCard;
				}
				if (_selectedMovesByCard != null)
				{
					object obj60 = (nint)0 + (nint)2320;
					size = (byte)(int)obj60 != 0;
					((List<object>)(object)_selectedMovesByCard).AddRange((IEnumerable<object>)enumerable2);
					List<object> selectedMovesByCard3 = (List<object>)(object)_selectedMovesByCard;
					bool flag30 = _selectedMovesByCard == null;
					jackarooHand = (JackarooHand)enumerable2;
					if (!flag30)
					{
						bool flag31 = selectedMovesByCard3._size != 1;
						enumerable = enumerable2;
						if (!flag31)
						{
							object obj61 = (nint)0 + (nint)2360;
							size = (byte)(int)obj61 != 0;
							object obj62 = ((List<object>)(object)_selectedMovesByCard).get_Item(0);
							bool flag32 = obj62 == null;
							jackarooHand = null;
							if (flag32)
							{
								goto IL_13e5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v135 (System.Object)+18]");
							bool flag33 = (nint)0 == 262144;
							enumerable = null;
							if (!flag33)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v135 (System.Object)+18]");
								if ((nint)0 == 65536)
								{
									bool flag34 = DoesNextPlayerHasOneCard();
									bool flag35 = !flag34;
									enumerable = null;
									if (flag35)
									{
										goto IL_07b7;
									}
								}
								selectedMovesByCard2 = _selectedMovesByCard;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
								playCard2 = false;
								move = (JackarooMove)obj62;
								goto IL_15c4;
							}
						}
						goto IL_07b7;
					}
				}
			}
		}
		goto IL_13e5;
		IL_0984:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X0_v125+E4]");
		bool flag36 = (nint)0 == 0;
		object obj63 = !flag36;
		object obj65;
		object obj66;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj64 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1294 @ X8_v111+B8]");
			obj66 = 0;
		}
		object obj67 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj68 = (nint)0 + (nint)1920;
		Func<object, bool> func6 = default(Func<object, bool>);
		func6..ctor(obj66, (IntPtr)obj68);
		object obj69 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X8_v110+B8]");
		object obj70 = (nint)0 + (nint)24;
		obj70 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		card = null;
		Func<object, bool> predicate = func6;
		goto IL_09db;
		IL_0d03:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
		PlayTen(playCard: false);
		return;
		IL_09db:
		object obj71 = (nint)0 + (nint)2640;
		object obj72;
		if (Enumerable.Any(_selectedMovesByCard, predicate))
		{
			obj72 = "SERVICE_DISABLED" + 2576;
			goto IL_16cd;
		}
		object obj73 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X0_v109+E4]");
		object obj74;
		Func<object, bool> func7;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X0_v109+B8]");
			obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v88+20]");
			func7 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v88+20]");
			bool flag37 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v88+20]");
			Func<object, bool> func8 = (Func<object, bool>)0;
			if (!flag37)
			{
				goto IL_0aa9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj73 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X0_v109+B8]");
			obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v88+20]");
			func7 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v88+20]");
			bool flag38 = (nint)0 == 0;
			object obj75 = !flag38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v88+20]");
			Func<object, bool> func8 = (Func<object, bool>)0;
			if (obj75 != null)
			{
				goto IL_0aa9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X0_v109+E4]");
		bool flag39 = (nint)0 == 0;
		object obj76 = !flag39;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj77 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v94+B8]");
			obj74 = 0;
		}
		object obj78 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj79 = (nint)0 + (nint)1928;
		Func<object, bool> func9 = default(Func<object, bool>);
		func9..ctor(obj74, (IntPtr)obj79);
		object obj80 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ X8_v93+B8]");
		object obj81 = (nint)0 + (nint)32;
		obj81 = func9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		size = (byte)(int)obj71 != 0;
		bool flag40 = Enumerable.Any(_selectedMovesByCard, func9);
		bool flag41 = !flag40;
		object obj82 = !flag41;
		card = null;
		enumerable = (IEnumerable<object>)(object)func9;
		if (obj82 != null)
		{
			goto IL_0ae5;
		}
		goto IL_0c0e;
		IL_16cd:
		object selectCardToSteal = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
		PlayQueenBurnOrSteel(clickedCard, (string)selectCardToSteal, playCard: false);
		return;
		IL_13e5:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		goto IL_13fc;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v159+8]");
		jackarooHand = (JackarooHand)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v819 @ X0_v159] (should have been resolved before IL gen)");
		object obj83 = default(object);
		if ((nint)obj83 == 1)
		{
			goto IL_03ba;
		}
		size = false;
		goto IL_05a6;
		IL_03ba:
		object obj84 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2480;
		nint num11 = (nint)allowedMoves;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X8_v119 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+12E]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X8_v119 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0462;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X8_v119 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+B0]");
		object obj86 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v27-8]");
			if (0 == (nint)obj84)
			{
				break;
			}
			obj86 += 16;
			obj85--;
			if ((nint)obj85 != 1)
			{
				continue;
			}
			goto IL_0462;
		}
		object obj87 = num11 + obj86;
		object obj88 = obj87 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v155+8]");
		bool flag42 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v968 @ X0_v155] (should have been resolved before IL gen)");
		object obj89 = default(object);
		bool flag43 = obj89 == null;
		JackarooHand jackarooHand3 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v155+8]");
		size = false;
		jackarooHand = null;
		if (!flag43)
		{
			goto IL_0539;
		}
		goto IL_13e5;
		IL_0e3c:
		<Rank>k__BackingField = clickedCard.<Rank>k__BackingField;
		goto IL_1945;
		IL_0cb6:
		object obj90 = (nint)0 + (nint)2640;
		bool flag44 = Enumerable.Any(_selectedMovesByCard, func3);
		bool flag45 = !flag44;
		size = (byte)(int)obj90 != 0;
		enumerable = (IEnumerable<object>)(object)func3;
		if (!flag45)
		{
			goto IL_0d03;
		}
		goto IL_0e3c;
		IL_13fc:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator2;
		goto IL_1450;
		IL_0ae5:
		obj72 = "SERVICE_DISABLED" + 2584;
		goto IL_16cd;
		IL_0462:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X0_v152+8]");
		flag42 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v945 @ X0_v152] (should have been resolved before IL gen)");
		bool flag46 = obj89 == null;
		object obj91 = !flag46;
		jackarooHand3 = null;
		if (obj91 != null)
		{
			goto IL_0539;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X0_v152+8]");
		size = false;
		jackarooHand = null;
		goto IL_13e5;
		IL_0539:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v143+18]");
		bool flag47 = (nint)0 == 65536;
		size = flag42;
		jackarooHand = jackarooHand3;
		if (!flag47)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v143+18]");
			bool flag48 = (nint)0 != 262144;
			size = flag42;
			jackarooHand = jackarooHand3;
			if (flag48)
			{
				nint num12 = (nint)allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v122 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+12E]");
				object obj92 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v122 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0913;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v122 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMove>>)+B0]");
				object obj93 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X10_v22-8]");
					if (0 == (nint)obj84)
					{
						break;
					}
					obj93 += 16;
					obj92--;
					if ((nint)obj92 != 1)
					{
						continue;
					}
					goto IL_0913;
				}
				object obj94 = num12 + obj93;
				object obj95 = obj94 + 312;
				goto IL_161f;
			}
		}
		goto IL_05a6;
		IL_0aa9:
		size = (byte)(int)obj71 != 0;
		bool flag49 = Enumerable.Any(_selectedMovesByCard, func7);
		bool flag50 = !flag49;
		enumerable = (IEnumerable<object>)(object)func7;
		if (!flag50)
		{
			goto IL_0ae5;
		}
		goto IL_0c0e;
		IL_07b7:
		<Rank>k__BackingField = clickedCard.<Rank>k__BackingField;
		if (clickedCard.<Rank>k__BackingField == Rank.QUEEN)
		{
			obj65 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			object obj96 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X0_v125+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X0_v125+B8]");
				obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X8_v105+18]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X8_v105+18]");
				bool flag51 = (nint)0 == 0;
				object obj97 = !flag51;
				if (obj97 == null)
				{
					goto IL_0984;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj96 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X0_v125+B8]");
				obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X8_v105+18]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X8_v105+18]");
				bool flag52 = (nint)0 == 0;
				object obj98 = !flag52;
				if (obj98 == null)
				{
					goto IL_0984;
				}
			}
			goto IL_09db;
		}
		goto IL_15db;
	}

	private static bool ShouldPlayOneMove(JackarooMove allowedMove)
	{
		//IL_00a4: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		if (allowedMove != null)
		{
			object obj = allowedMove.<Action>k__BackingField - 65536;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = allowedMove.<Action>k__BackingField - 262144;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			return !flag2;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool DoesNextPlayerHasOneCard()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_014b: Expected I, but got O
		//IL_015e: Expected I, but got O
		//IL_011b: Expected O, but got I4
		JackarooGame jackarooGame = (JackarooGame)game;
		NullReferenceException ex;
		if ((object)game != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
			object obj2 = obj;
			nint num = (nint)jackarooGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v3 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v9+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v3 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v9+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v5-8]");
				if (0 == (nint)obj2)
				{
					JackarooPlayer getNextToMyPlayer = ((JackarooGame)game).GetNextToMyPlayer;
					if (getNextToMyPlayer != null)
					{
						List<Card> <Cards>k__BackingField = ((CardGamePlayer)getNextToMyPlayer).<Cards>k__BackingField;
						if (((CardGamePlayer)getNextToMyPlayer).<Cards>k__BackingField != null)
						{
							object obj6 = <Cards>k__BackingField._size - 1;
							return obj6 == null;
						}
						ex = new NullReferenceException();
						nint num4 = unchecked((nint)null);
					}
					else
					{
						ex = new NullReferenceException();
						nint num4 = unchecked((nint)null);
					}
					goto IL_0163;
				}
			}
		}
		ex = new NullReferenceException();
		goto IL_0163;
		IL_0163:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result = default(bool);
		return result;
	}

	private void PlayQueenBurnOrSteel(Card clickedCard, string selectCardToSteal, bool playCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0094: Expected I, but got O
		//IL_00bd: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0138: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0173: Expected I, but got O
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		//IL_0227: Expected O, but got I4
		//IL_01c0: Expected I, but got O
		//IL_01e9: Expected O, but got I4
		//IL_048d: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0276: Expected I, but got O
		//IL_029f: Expected O, but got I4
		//IL_05d9: Expected O, but got I
		//IL_02d3: Expected O, but got I
		//IL_033b: Expected I, but got O
		//IL_0364: Expected O, but got I4
		//IL_0398: Expected O, but got I
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_040e: Expected O, but got I
		//IL_0429: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		JackarooCardGameVisualControls jackarooCardGameVisualControls2;
		JackarooCardGameVisualControls jackarooCardGameVisualControls3;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = clickedCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingAction;
			JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
			if ((object)gameVisualControls != null)
			{
				obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
				object obj6 = obj5;
				nint num = (nint)jackarooCardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X9_v3 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v8+130]");
				bool flag = num2 < 0;
				object obj7 = !flag;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X9_v3 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v8+130]");
					object obj9 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v5-8]");
					if (0 == (nint)obj6)
					{
						object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
						object obj11 = (nint)0 + (nint)2112;
						object obj12 = (nint)0 + (nint)184;
						((JackarooCardGameVisualControls)gameVisualControls).ShowActionTipPanel(selectCardToSteal);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor(obj2, (IntPtr)obj11);
						object obj13 = Enumerable.First(_selectedMovesByCard, func);
						object obj14 = obj2 + 32;
						obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						CardGameVisualControls cardGameVisualControls = gameVisualControls;
						if ((object)gameVisualControls != null)
						{
							object obj15 = obj5;
							nint num4 = (nint)cardGameVisualControls;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X10_v12 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X9_v18+130]");
							bool flag2 = num5 < 0;
							object obj16 = !flag2;
							if (obj16 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X10_v12 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X9_v18+130]");
								object obj17 = num6 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X10_v14-8]");
								jackarooCardGameVisualControls2 = (JackarooCardGameVisualControls)((0 != (nint)obj15) ? null : gameVisualControls);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD0]");
								object obj18 = (nint)0 & (nint)1;
								if (obj18 == null)
								{
									goto IL_023f;
								}
								jackarooCardGameVisualControls3 = jackarooCardGameVisualControls2;
								goto IL_0571;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD0]");
						object obj19 = (nint)0 & (nint)1;
						bool flag3 = obj19 == null;
						object obj20 = !flag3;
						jackarooCardGameVisualControls2 = null;
						jackarooCardGameVisualControls3 = null;
						if (obj20 == null)
						{
							goto IL_023f;
						}
						goto IL_0571;
					}
				}
			}
		}
		goto IL_04da;
		IL_0571:
		JackarooGame jackarooGame = (JackarooGame)game;
		if ((object)game != null)
		{
			object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
			object obj22 = obj21;
			nint num7 = (nint)jackarooGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X9_v8 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v15+130]");
			bool flag4 = num8 < 0;
			object obj23 = !flag4;
			object obj24 = ~obj23;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X9_v8 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v15+130]");
				object obj25 = num9 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X9_v10-8]");
				if (0 == (nint)obj22)
				{
					JackarooPlayer getNextToMyPlayer = ((JackarooGame)game).GetNextToMyPlayer;
					if (getNextToMyPlayer != null)
					{
						CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
						if ((object)gameVisualControls != null)
						{
							object obj26 = obj5;
							nint num10 = (nint)cardGameVisualControls2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v6 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v12+130]");
							bool flag5 = num11 < 0;
							object obj27 = !flag5;
							object obj28 = ~obj27;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v6 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v12+130]");
								object obj29 = num12 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X10_v8-8]");
								if (0 == (nint)obj26)
								{
									Userbox[] allUserboxes = ((KGameVisualControls)cardGameVisualControls2).allUserboxes;
									if (((KGameVisualControls)cardGameVisualControls2).allUserboxes != null)
									{
										object obj30 = typeof(SqlSingle[]) + 2376;
										object obj31 = (nint)0 + (nint)2120;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										Action action = default(Action);
										action..ctor(obj2, (IntPtr)obj31);
										if ((object)jackarooCardGameVisualControls3 != null)
										{
											jackarooCardGameVisualControls3.ShowBurnOtherCardPanel(((CardGamePlayer)getNextToMyPlayer).<Cards>k__BackingField, allUserboxes[1], action);
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_04da;
		IL_023f:
		_ = 1;
		jackarooCardGameVisualControls3 = jackarooCardGameVisualControls2;
		goto IL_0571;
		IL_04da:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void PlayTen(bool playCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_0196: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		//IL_0229: Expected O, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_011f: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_0305: Expected O, but got I
		//IL_0315: Expected O, but got I
		//IL_0337: Expected O, but got I4
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_07ff: Expected O, but got I
		//IL_0810: Expected I, but got O
		//IL_082e: Expected O, but got I
		//IL_0849: Expected O, but got I4
		//IL_03a8: Expected O, but got I
		//IL_029e: Expected O, but got I
		//IL_02ae: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_0218: Expected O, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_0367: Expected O, but got I4
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected O, but got Unknown
		//IL_0880: Expected O, but got I
		//IL_0891: Expected I, but got O
		//IL_08af: Expected O, but got I
		//IL_08d2: Expected O, but got I4
		//IL_0397: Expected O, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0447: Expected I, but got O
		//IL_0470: Expected O, but got I4
		//IL_04a4: Expected O, but got I
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04fc: Expected I, but got O
		//IL_0525: Expected O, but got I4
		//IL_0559: Expected O, but got I
		//IL_059f: Expected O, but got I
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_0625: Expected O, but got I4
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0948: Expected O, but got I
		//IL_0959: Expected I, but got O
		//IL_06f8: Expected I, but got O
		//IL_0721: Expected O, but got I4
		//IL_0756: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass60_0 <>c__DisplayClass60_ = default(<>c__DisplayClass60_0);
		<>c__DisplayClass60_..ctor();
		object obj2 = <>c__DisplayClass60_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<JackarooMove> moves;
		if (JackarooActionsExtensions.AllSameAction(_selectedMovesByCard))
		{
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
			moves = _selectedMovesByCard;
			goto IL_07c7;
		}
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass60_1 <>c__DisplayClass60_2 = default(<>c__DisplayClass60_1);
		<>c__DisplayClass60_2..ctor();
		object obj4 = <>c__DisplayClass60_2 + 32;
		obj4 = <>c__DisplayClass60_;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v65+E4]");
		object obj7;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v65+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v63+38]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v63+38]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				goto IL_01c6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v65+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v63+38]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v63+38]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				goto IL_01c6;
			}
		}
		goto IL_021d;
		IL_091e:
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2128;
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)<>c__DisplayClass60_2, (IntPtr)obj11);
		JackarooCardGameVisualControls jackarooCardGameVisualControls;
		List<object> list = default(List<object>);
		jackarooCardGameVisualControls.ShowActionsOptionsPanel((List<JackarooMove>)(object)list, (Action<JackarooActions>)(object)action);
		return;
		IL_0345:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v55+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		object obj14;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v58+B8]");
			obj14 = 0;
		}
		object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1960;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj14, (IntPtr)obj16);
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v57+B8]");
		object obj18 = (nint)0 + (nint)64;
		obj18 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, bool> predicate2 = func;
		object obj19 = 0;
		goto IL_039c;
		IL_039c:
		object obj20 = (nint)0 + (nint)3536;
		IEnumerable<object> source = Enumerable.Where(_selectedMovesByCard, predicate2);
		List<object> list2 = Enumerable.ToList(source);
		object obj21 = <>c__DisplayClass60_2 + 24;
		obj21 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X23_v7-8]");
		object obj35;
		if ((nint)0 != 0)
		{
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarbleAndAction;
			JackarooCardGameVisualControls jackarooCardGameVisualControls2 = (JackarooCardGameVisualControls)gameVisualControls;
			object obj22 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
			object obj23 = obj22;
			nint num = (nint)jackarooCardGameVisualControls2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X9_v5 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v22+130]");
			bool flag4 = num2 < 0;
			object obj24 = !flag4;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X9_v5 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v22+130]");
				object obj26 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v7-8]");
				if (0 == (nint)obj23)
				{
					object tip = "SERVICE_DISABLED" + 2560;
					jackarooCardGameVisualControls2.ShowActionTipPanel((string)tip);
					CardGameVisualControls cardGameVisualControls = gameVisualControls;
					object obj27 = obj22;
					nint num4 = (nint)cardGameVisualControls;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X9_v9+130]");
					bool flag5 = num5 < 0;
					object obj28 = !flag5;
					object obj29 = ~obj28;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v3 (Il2CppClass<CardGameVisualControls>)+C8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X9_v9+130]");
						object obj30 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X10_v5-8]");
						if (0 == (nint)obj27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v27 (CardGameVisualControls)+148]");
							((JackarooBoardMono)0).HighlightMoves((List<JackarooMove>)obj21);
							object obj31 = typeof(List<AdaptivePerformanceScaler>) + 1960;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							list..ctor();
							int version = list._version + 1;
							list._version = version;
							object[] items = list._items;
							bool flag6 = list._size < items.Length;
							object obj32 = !flag6;
							if (obj32 == null)
							{
								int size = list._size + 1;
								list._size = size;
								object obj33 = items + list._size;
								object obj34 = obj33 + 32;
								obj34 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								list.AddWithResize(obj35);
							}
							list.AddRange((IEnumerable<object>)obj21);
							((<>c__DisplayClass60_0)obj4).<PlayTen>g__SetupMovesMarbles|0((List<JackarooMove>)obj21);
							CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
							if ((object)gameVisualControls != null)
							{
								object obj36 = obj22;
								nint num7 = (nint)cardGameVisualControls2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X10_v10 (Il2CppClass<CardGameVisualControls>)+130]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v15+130]");
								bool flag7 = num8 < 0;
								object obj37 = !flag7;
								if (obj37 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X10_v10 (Il2CppClass<CardGameVisualControls>)+C8]");
									nint num9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v15+130]");
									object obj38 = num9 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X10_v12-8]");
									jackarooCardGameVisualControls = (JackarooCardGameVisualControls)((0 != (nint)obj36) ? null : gameVisualControls);
									goto IL_091e;
								}
							}
							jackarooCardGameVisualControls = null;
							goto IL_091e;
						}
					}
				}
			}
			throw new NullReferenceException();
		}
		<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
		<>c__DisplayClass60_ = (<>c__DisplayClass60_0)obj4;
		moves = (List<JackarooMove>)obj21;
		goto IL_07c7;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v65+E4]");
		bool flag8 = (nint)0 == 0;
		object obj39 = !flag8;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj40 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v69+B8]");
			obj7 = 0;
		}
		object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)1952;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj7, (IntPtr)obj42);
		object obj43 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v68+B8]");
		object obj44 = (nint)0 + (nint)56;
		obj44 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = 0;
		predicate = func2;
		goto IL_021d;
		IL_07c7:
		<>c__DisplayClass60_.<PlayTen>g__SetupMovesMarbles|0(moves);
		return;
		IL_021d:
		object obj45 = (nint)0 + (nint)968;
		object obj46 = Enumerable.FirstOrDefault(_selectedMovesByCard, predicate);
		obj35 = <>c__DisplayClass60_2 + 16;
		obj35 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj47 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v55+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v55+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v52+40]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v52+40]");
			bool flag9 = (nint)0 == 0;
			object obj48 = !flag9;
			if (obj48 == null)
			{
				goto IL_0345;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj47 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v55+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v52+40]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v52+40]");
			bool flag10 = (nint)0 == 0;
			object obj49 = !flag10;
			if (obj49 == null)
			{
				goto IL_0345;
			}
		}
		goto IL_039c;
	}

	private void PlaySeven(bool playCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006f: Expected I, but got O
		//IL_0098: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0604: Expected I, but got O
		//IL_0130: Expected I, but got O
		//IL_0159: Expected O, but got I4
		//IL_0167: Expected I, but got O
		//IL_019a: Expected O, but got I
		//IL_01b8: Expected I, but got O
		//IL_01ea: Expected I, but got O
		//IL_0221: Expected O, but got I
		//IL_023b: Expected O, but got I4
		//IL_0272: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		//IL_02b2: Expected O, but got I
		//IL_04bc: Expected O, but got I4
		//IL_04c5: Expected O, but got I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0387: Expected O, but got I
		//IL_03c7: Expected I, but got O
		//IL_0464: Expected I, but got O
		//IL_0406: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass61_0 <>c__DisplayClass61_ = default(<>c__DisplayClass61_0);
		<>c__DisplayClass61_..ctor();
		bool flag = <>c__DisplayClass61_ == null;
		JackarooHand jackarooHand = null;
		object obj18 = default(object);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj2 = <>c__DisplayClass61_ + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
			JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
			bool flag2 = (object)gameVisualControls == null;
			jackarooHand = this;
			if (!flag2)
			{
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
				object obj4 = obj3;
				nint num = (nint)jackarooCardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X9_v3 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v6+130]");
				bool flag3 = num2 < 0;
				object obj5 = !flag3;
				object obj6 = ~obj5;
				jackarooHand = this;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X9_v3 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v6+130]");
					object obj7 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v5-8]");
					bool flag4 = 0 != (nint)obj4;
					jackarooHand = this;
					if (!flag4)
					{
						object obj8 = "SERVICE_DISABLED" + 2600;
						((JackarooCardGameVisualControls)gameVisualControls).ShowActionTipPanel((string)obj8);
						CardGameVisualControls cardGameVisualControls = gameVisualControls;
						bool flag5 = (object)gameVisualControls == null;
						nint num4 = unchecked((nint)null);
						jackarooHand = (JackarooHand)obj8;
						if (!flag5)
						{
							object obj9 = obj3;
							nint num5 = (nint)cardGameVisualControls;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X10_v4 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v7+130]");
							bool flag6 = num6 < 0;
							object obj10 = !flag6;
							object obj11 = ~obj10;
							num4 = unchecked((nint)null);
							jackarooHand = (JackarooHand)obj8;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X10_v4 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v7+130]");
								object obj12 = num7 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X10_v6-8]");
								bool flag7 = 0 != (nint)obj9;
								num4 = unchecked((nint)null);
								jackarooHand = (JackarooHand)obj8;
								if (!flag7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v11 (CardGameVisualControls)+148]");
									bool flag8 = (nint)0 == 0;
									num4 = unchecked((nint)null);
									jackarooHand = (JackarooHand)obj8;
									if (!flag8)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v11 (CardGameVisualControls)+148]");
										((JackarooBoardMono)0).HighlightMoves(_selectedMovesByCard);
										bool flag9 = _selectedMovesByCard == null;
										object obj13 = 0;
										bool flag10 = true;
										num4 = 1;
										jackarooHand = (JackarooHand)(object)_selectedMovesByCard;
										if (!flag9)
										{
											object obj14 = (nint)0 + (nint)2800;
											object obj15 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 680;
											object obj16 = typeof(SqlSingle[]) + 2376;
											object obj17 = (nint)0 + (nint)2160;
											obj18 = (nint)0 + (nint)2792;
											List<object>.Enumerator enumerator = ((List<object>)(object)_selectedMovesByCard).GetEnumerator();
											flag10 = true;
											bool flag11 = true;
											List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
											<>c__DisplayClass61_1 <>c__DisplayClass61_2 = default(<>c__DisplayClass61_1);
											JackarooHand jackarooHand2 = default(JackarooHand);
											Action action = default(Action);
											while (true)
											{
												if (enumerator2.MoveNext())
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													<>c__DisplayClass61_2..ctor();
													if (<>c__DisplayClass61_2 != null)
													{
														object obj19 = <>c__DisplayClass61_2 + 24;
														obj19 = <>c__DisplayClass61_;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														object obj20 = <>c__DisplayClass61_2 + 16;
														obj20 = jackarooHand2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														object obj21 = obj20;
														if (obj20 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v19+20]");
															object obj22 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v19+20]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																action..ctor(<>c__DisplayClass61_2, (IntPtr)obj17);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v20+18]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v20+18]");
																	((JackarooMarbleMono)0).SetupSelect(action);
																	flag10 = false;
																	flag11 = false;
																	continue;
																}
																NullReferenceException ex = new NullReferenceException();
																flag10 = false;
																num4 = (nint)obj17;
																jackarooHand = (JackarooHand)(object)<>c__DisplayClass61_2;
																break;
															}
															NullReferenceException ex2 = new NullReferenceException();
															num4 = (flag11 ? 1 : 0);
															jackarooHand = jackarooHand2;
															break;
														}
														NullReferenceException ex3 = new NullReferenceException();
														num4 = (flag11 ? 1 : 0);
														jackarooHand = jackarooHand2;
														break;
													}
													NullReferenceException ex4 = new NullReferenceException();
													num4 = (flag11 ? 1 : 0);
													jackarooHand = null;
													break;
												}
												enumerator2.Dispose();
												return;
											}
											List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
											enumerator3 = enumerator4;
											enumerator4 = (List<object>.Enumerator)0;
											obj13 = 0;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex5 = new NullReferenceException();
		bool flag12 = (nint)jackarooHand != 1;
		OutOfMemoryException ex6 = (OutOfMemoryException)(object)ex5;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			jackarooHand = (JackarooHand)obj18;
			enumerator3.Dispose();
			object obj23 = default(object);
			if (obj23 == null)
			{
				return;
			}
			ex6 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void PlayAce(bool playCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I4
		//IL_0aac: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f0: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_0cab: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_060e: Expected I, but got O
		//IL_0637: Expected O, but got I4
		//IL_0649: Expected O, but got I4
		//IL_0247: Expected O, but got I4
		//IL_068b: Expected O, but got I
		//IL_06ad: Expected O, but got I4
		//IL_0278: Expected O, but got I
		//IL_0280: Expected I, but got O
		//IL_02ac: Expected O, but got I4
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_070a: Expected O, but got I4
		//IL_0718: Expected I, but got O
		//IL_02d8: Expected O, but got I
		//IL_02ea: Expected O, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0b80: Expected O, but got I4
		//IL_074a: Expected O, but got I
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected O, but got Unknown
		//IL_077e: Expected O, but got I
		//IL_078c: Expected I, but got O
		//IL_0314: Expected I, but got O
		//IL_033d: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_0383: Expected O, but got I
		//IL_03a5: Expected O, but got I4
		//IL_0a0e: Expected O, but got I4
		//IL_0a17: Expected O, but got I4
		//IL_03e0: Expected O, but got I4
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected O, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_0421: Expected O, but got I4
		//IL_0a43: Expected O, but got I4
		//IL_0a4c: Expected O, but got I4
		//IL_0840: Expected O, but got I
		//IL_0870: Expected O, but got I4
		//IL_0879: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		//IL_08aa: Expected I, but got O
		//IL_048e: Expected O, but got I
		//IL_0bbb: Expected O, but got I4
		//IL_0bc9: Expected I, but got O
		//IL_09b3: Expected O, but got I4
		//IL_09bc: Expected O, but got I4
		//IL_09c5: Expected O, but got I4
		//IL_09ce: Expected O, but got I4
		//IL_09df: Expected I, but got O
		//IL_08e9: Expected O, but got I
		//IL_08f7: Expected I, but got O
		//IL_04ae: Expected I, but got O
		//IL_04d7: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_04f7: Expected I, but got O
		//IL_052f: Expected O, but got I
		//IL_0551: Expected O, but got I4
		//IL_055f: Expected I, but got O
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected O, but got Unknown
		//IL_0c37: Expected O, but got I
		//IL_0c48: Expected I, but got O
		//IL_0c60: Expected O, but got I4
		//IL_0c71: Expected I, but got O
		//IL_05ad: Expected I, but got O
		//IL_05d6: Expected O, but got I4
		//IL_0929: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass62_0 <>c__DisplayClass62_ = default(<>c__DisplayClass62_0);
		<>c__DisplayClass62_..ctor();
		bool flag = <>c__DisplayClass62_ == null;
		JackarooHand jackarooHand = null;
		JackarooCardGameVisualControls jackarooCardGameVisualControls2;
		object obj32;
		<>c__DisplayClass62_1 <>c__DisplayClass62_2 = default(<>c__DisplayClass62_1);
		JackarooHand jackarooHand2 = default(JackarooHand);
		NullReferenceException ex;
		List<object>.Enumerator enumerator5;
		bool flag11;
		nint num4;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		object obj9;
		if (!flag)
		{
			object obj2 = <>c__DisplayClass62_ + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			List<object> selectedMovesByCard = (List<object>)(object)_selectedMovesByCard;
			bool flag2 = _selectedMovesByCard == null;
			jackarooHand = this;
			if (!flag2)
			{
				if (selectedMovesByCard._size == 1)
				{
					object move = ((List<object>)(object)_selectedMovesByCard).get_Item(0);
					DoPlayMove((JackarooMove)move, _selectedMovesByCard, <>c__DisplayClass62_.playCard, (GameAction?)(object)0);
					return;
				}
				CardGameVisualControls cardGameVisualControls = gameVisualControls;
				bool flag3 = (object)gameVisualControls == null;
				jackarooHand = this;
				if (!flag3)
				{
					object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
					object obj4 = obj3;
					nint num = (nint)cardGameVisualControls;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v5 (Il2CppClass<CardGameVisualControls>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v5+130]");
					bool flag4 = num2 < 0;
					object obj5 = !flag4;
					object obj6 = ~obj5;
					jackarooHand = this;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v5 (Il2CppClass<CardGameVisualControls>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v5+130]");
						object obj7 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v7-8]");
						bool flag5 = 0 != (nint)obj4;
						jackarooHand = this;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v13 (CardGameVisualControls)+148]");
							bool flag6 = (nint)0 == 0;
							jackarooHand = this;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v13 (CardGameVisualControls)+148]");
								((JackarooBoardMono)0).HighlightMoves(_selectedMovesByCard);
								bool flag7 = JackarooActionsExtensions.AllSameMarble1(_selectedMovesByCard);
								bool flag8 = JackarooActionsExtensions.AllSameAction(_selectedMovesByCard);
								if (flag7)
								{
									bool flag9 = !flag8;
									object obj8 = !flag9;
									if (obj8 == null)
									{
										bool flag10 = _selectedMovesByCard == null;
										obj9 = 0;
										flag11 = true;
										num4 = 1;
										jackarooHand = null;
										if (!flag10)
										{
											object obj10 = (nint)0 + (nint)2360;
											num4 = (nint)obj10;
											object obj11 = ((List<object>)(object)_selectedMovesByCard).get_Item(0);
											bool flag12 = obj11 == null;
											obj9 = 0;
											flag11 = true;
											jackarooHand = null;
											if (!flag12)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v56 (System.Object)+20]");
												jackarooHand = (JackarooHand)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v56 (System.Object)+20]");
												_selectedMarble1 = (JackarooMarble)0;
												object obj12 = this + 264;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
												bool flag13 = (object)gameVisualControls == null;
												obj9 = 0;
												flag11 = true;
												if (!flag13)
												{
													object obj13 = obj3;
													nint num5 = (nint)cardGameVisualControls2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v10 (Il2CppClass<CardGameVisualControls>)+130]");
													nint num6 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v10+130]");
													bool flag14 = num6 < 0;
													object obj14 = !flag14;
													object obj15 = ~obj14;
													obj9 = 0;
													flag11 = true;
													if (obj15 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v10 (Il2CppClass<CardGameVisualControls>)+C8]");
														nint num7 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v10+130]");
														object obj16 = num7 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X10_v12-8]");
														bool flag15 = 0 != (nint)obj13;
														obj9 = 0;
														flag11 = true;
														if (!flag15)
														{
															JackarooMarble selectedMarble = _selectedMarble1;
															bool flag16 = _selectedMarble1 == null;
															obj9 = 0;
															flag11 = true;
															if (!flag16)
															{
																JackarooNode <Node>k__BackingField = selectedMarble.<Node>k__BackingField;
																bool flag17 = selectedMarble.<Node>k__BackingField == null;
																obj9 = 0;
																flag11 = true;
																if (!flag17)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v34 (CardGameVisualControls)+148]");
																	bool flag18 = (nint)0 == 0;
																	obj9 = 0;
																	flag11 = true;
																	if (!flag18)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v34 (CardGameVisualControls)+148]");
																		((JackarooBoardMono)0).HighlightFirstNode(<Node>k__BackingField.<NodeMono>k__BackingField, animate: false);
																		<playingStage>k__BackingField = JackarooPlayingStage.SelectingAction;
																		JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
																		bool flag19 = (object)gameVisualControls == null;
																		obj9 = 0;
																		flag11 = false;
																		num4 = unchecked((nint)null);
																		jackarooHand = (JackarooHand)(object)<Node>k__BackingField.<NodeMono>k__BackingField;
																		if (!flag19)
																		{
																			object obj17 = obj3;
																			nint num8 = (nint)jackarooCardGameVisualControls;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v13 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
																			nint num9 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v38+130]");
																			bool flag20 = num9 < 0;
																			object obj18 = !flag20;
																			object obj19 = ~obj18;
																			obj9 = 0;
																			flag11 = false;
																			num4 = unchecked((nint)null);
																			jackarooHand = (JackarooHand)(object)<Node>k__BackingField.<NodeMono>k__BackingField;
																			if (obj19 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v13 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
																				nint num10 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v38+130]");
																				object obj20 = num10 + 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X9_v15-8]");
																				bool flag21 = 0 != (nint)obj17;
																				obj9 = 0;
																				flag11 = false;
																				num4 = unchecked((nint)null);
																				jackarooHand = (JackarooHand)(object)<Node>k__BackingField.<NodeMono>k__BackingField;
																				if (!flag21)
																				{
																					object tip = "SERVICE_DISABLED" + 2560;
																					((JackarooCardGameVisualControls)gameVisualControls).ShowActionTipPanel((string)tip);
																					CardGameVisualControls cardGameVisualControls3 = gameVisualControls;
																					if ((object)gameVisualControls != null)
																					{
																						object obj21 = obj3;
																						nint num11 = (nint)cardGameVisualControls3;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v17 (Il2CppClass<CardGameVisualControls>)+130]");
																						nint num12 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X9_v19+130]");
																						bool flag22 = num12 < 0;
																						object obj22 = !flag22;
																						if (obj22 != null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v17 (Il2CppClass<CardGameVisualControls>)+C8]");
																							nint num13 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X9_v19+130]");
																							object obj23 = num13 + 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X10_v19-8]");
																							jackarooCardGameVisualControls2 = (JackarooCardGameVisualControls)((0 != (nint)obj21) ? null : gameVisualControls);
																							goto IL_0c0d;
																						}
																					}
																					jackarooCardGameVisualControls2 = null;
																					goto IL_0c0d;
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
										goto IL_097d;
									}
								}
								<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
								JackarooCardGameVisualControls jackarooCardGameVisualControls3 = (JackarooCardGameVisualControls)gameVisualControls;
								bool flag23 = (object)gameVisualControls == null;
								obj9 = 0;
								flag11 = true;
								num4 = 1;
								jackarooHand = null;
								if (!flag23)
								{
									object obj24 = obj3;
									nint num14 = (nint)jackarooCardGameVisualControls3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v6 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
									nint num15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v16+130]");
									bool flag24 = num15 < 0;
									object obj25 = !flag24;
									object obj26 = ~obj25;
									obj9 = 0;
									flag11 = true;
									num4 = 1;
									jackarooHand = null;
									if (obj26 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v6 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v16+130]");
										object obj27 = num16 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X9_v8-8]");
										bool flag25 = 0 != (nint)obj24;
										obj9 = 0;
										flag11 = true;
										num4 = 1;
										jackarooHand = null;
										if (!flag25)
										{
											object obj28 = "SERVICE_DISABLED" + 2600;
											((JackarooCardGameVisualControls)gameVisualControls).ShowActionTipPanel((string)obj28);
											bool flag26 = _selectedMovesByCard == null;
											obj9 = 0;
											flag11 = true;
											num4 = unchecked((nint)null);
											jackarooHand = (JackarooHand)obj28;
											if (!flag26)
											{
												List<object>.Enumerator enumerator = ((List<object>)(object)_selectedMovesByCard).GetEnumerator();
												object obj29 = (nint)0 + (nint)2800;
												object obj30 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 720;
												object obj31 = typeof(SqlSingle[]) + 2376;
												obj32 = (nint)0 + (nint)2208;
												flag11 = true;
												num4 = unchecked((nint)null);
												List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
												Action action = default(Action);
												while (true)
												{
													if (enumerator2.MoveNext())
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														<>c__DisplayClass62_2..ctor();
														if (<>c__DisplayClass62_2 == null)
														{
															break;
														}
														object obj33 = <>c__DisplayClass62_2 + 24;
														obj33 = <>c__DisplayClass62_;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														object obj34 = <>c__DisplayClass62_2 + 16;
														obj34 = jackarooHand2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														object obj35 = obj34;
														if (obj34 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v27+20]");
															object obj36 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v27+20]");
															bool flag27 = (nint)0 == 0;
															enumerator2 = enumerator3;
															enumerator4 = enumerator3;
															enumerator3 = (List<object>.Enumerator)0;
															obj9 = 0;
															jackarooHand = jackarooHand2;
															if (flag27)
															{
																goto IL_098b;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															action..ctor(<>c__DisplayClass62_2, (IntPtr)obj32);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v28+18]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v28+18]");
																((JackarooMarbleMono)0).SetupSelect(action);
																flag11 = false;
																num4 = unchecked((nint)null);
																continue;
															}
															goto IL_09a1;
														}
														goto IL_0a21;
													}
													enumerator2.Dispose();
													return;
												}
												ex = new NullReferenceException();
												enumerator5 = enumerator3;
												enumerator4 = enumerator3;
												enumerator3 = (List<object>.Enumerator)0;
												obj9 = 0;
												jackarooHand = null;
												goto IL_0a5f;
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
		goto IL_097d;
		IL_0c0d:
		object obj37 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)2200;
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)<>c__DisplayClass62_, (IntPtr)obj38);
		bool flag28 = (object)jackarooCardGameVisualControls2 == null;
		obj9 = 0;
		flag11 = false;
		num4 = (nint)obj38;
		jackarooHand = (JackarooHand)(object)<>c__DisplayClass62_;
		if (!flag28)
		{
			jackarooCardGameVisualControls2.ShowActionsOptionsPanel(_selectedMovesByCard, (Action<JackarooActions>)(object)action2);
			return;
		}
		goto IL_097d;
		IL_0a5f:
		bool flag29 = (nint)jackarooHand != 1;
		NullReferenceException ex2 = ex;
		if (!flag29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj39 = (nint)0 + (nint)2792;
			jackarooHand = (JackarooHand)obj39;
			enumerator5.Dispose();
			object obj40 = default(object);
			if (obj40 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj40;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_098b:
		ex = new NullReferenceException();
		enumerator5 = enumerator3;
		goto IL_0a5f;
		IL_097d:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_098b;
		IL_09a1:
		ex = new NullReferenceException();
		enumerator5 = (List<object>.Enumerator)0;
		enumerator4 = (List<object>.Enumerator)0;
		enumerator3 = (List<object>.Enumerator)0;
		obj9 = 0;
		flag11 = false;
		num4 = (nint)obj32;
		jackarooHand = (JackarooHand)(object)<>c__DisplayClass62_2;
		goto IL_0a5f;
		IL_0a21:
		ex = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		obj9 = 0;
		jackarooHand = jackarooHand2;
		goto IL_0a5f;
	}

	private void PlayJack(bool playCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0deb: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0d58: Expected O, but got I
		//IL_0d60: Expected I4, but got O
		//IL_0ef5: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_03bb: Expected I, but got O
		//IL_03e4: Expected O, but got I4
		//IL_03f6: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00cc: Expected I, but got O
		//IL_00f8: Expected O, but got I4
		//IL_042a: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0e34: Expected O, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0eb6: Expected O, but got I4
		//IL_0ebb: Expected I, but got O
		//IL_0ec3: Expected I4, but got O
		//IL_015b: Expected I, but got O
		//IL_0184: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_0484: Expected O, but got I
		//IL_0498: Expected I, but got O
		//IL_01c1: Expected O, but got I
		//IL_01e3: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_024d: Expected O, but got I4
		//IL_0d06: Expected O, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051c: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_02a8: Expected O, but got I
		//IL_0e66: Expected O, but got I4
		//IL_0e6f: Expected O, but got I4
		//IL_0e74: Expected I, but got O
		//IL_0e81: Expected I4, but got O
		//IL_0540: Expected I, but got O
		//IL_0569: Expected O, but got I4
		//IL_02bd: Expected I, but got O
		//IL_02e6: Expected O, but got I4
		//IL_02f8: Expected O, but got I4
		//IL_0301: Expected O, but got I4
		//IL_0306: Expected I, but got O
		//IL_0313: Expected I4, but got O
		//IL_059d: Expected O, but got I
		//IL_033e: Expected O, but got I
		//IL_0360: Expected O, but got I4
		//IL_0369: Expected O, but got I4
		//IL_036e: Expected I, but got O
		//IL_037b: Expected I4, but got O
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03a1: Expected O, but got I4
		//IL_05fe: Expected O, but got I
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0bda: Expected I, but got O
		//IL_0c62: Expected I, but got O
		//IL_0c6a: Expected I4, but got O
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected O, but got Unknown
		//IL_0650: Expected O, but got I
		//IL_0c11: Expected I, but got O
		//IL_0c19: Expected I4, but got O
		//IL_08b5: Expected O, but got I
		//IL_0b45: Expected I, but got O
		//IL_0b4d: Expected I4, but got O
		//IL_0ca4: Expected I, but got O
		//IL_0cac: Expected I4, but got O
		//IL_0665: Expected I, but got O
		//IL_068e: Expected O, but got I4
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected O, but got Unknown
		//IL_0908: Expected O, but got I
		//IL_06c2: Expected O, but got I
		//IL_0b32: Expected I, but got O
		//IL_0927: Expected I, but got O
		//IL_0950: Expected O, but got I4
		//IL_0c47: Expected I, but got O
		//IL_0c4f: Expected I4, but got O
		//IL_0984: Expected O, but got I
		//IL_071e: Expected O, but got I
		//IL_0c2c: Expected I, but got O
		//IL_0c34: Expected I4, but got O
		//IL_0bc7: Expected I, but got O
		//IL_0bf6: Expected I, but got O
		//IL_0bfe: Expected I4, but got O
		//IL_09e0: Expected O, but got I
		//IL_078a: Expected O, but got I
		//IL_078a: Expected O, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_0b8d: Expected I, but got O
		//IL_07b9: Expected O, but got I
		//IL_07ca: Expected I, but got O
		//IL_0c81: Expected O, but got I4
		//IL_0c89: Expected I, but got O
		//IL_0c91: Expected I4, but got O
		//IL_0cef: Expected I, but got O
		//IL_0804: Expected O, but got I
		//IL_080d: Expected O, but got I4
		//IL_0812: Expected I, but got O
		//IL_0a4c: Expected O, but got I
		//IL_0a4c: Expected O, but got I
		//IL_0cc3: Expected O, but got I4
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Expected O, but got Unknown
		//IL_0a9b: Expected O, but got I
		//IL_0aac: Expected I, but got O
		//IL_0ba4: Expected O, but got I4
		//IL_0bac: Expected I, but got O
		//IL_0bb4: Expected I4, but got O
		//IL_0aeb: Expected O, but got I
		//IL_0af4: Expected O, but got I4
		//IL_0af9: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass63_0 <>c__DisplayClass63_ = default(<>c__DisplayClass63_0);
		<>c__DisplayClass63_..ctor();
		bool flag = <>c__DisplayClass63_ == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		int num = 0;
		bool flag2;
		object obj3;
		JackarooCardGameVisualControls jackarooCardGameVisualControls;
		object obj16;
		nint num2;
		if (!flag)
		{
			object obj2 = <>c__DisplayClass63_ + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
			flag2 = JackarooActionsExtensions.AllSameMarble1(_selectedMovesByCard);
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
			if (flag2)
			{
				bool flag3 = _selectedMovesByCard == null;
				enumerator = (List<object>.Enumerator)0;
				num = 0;
				if (!flag3)
				{
					object obj4 = (nint)0 + (nint)2360;
					num2 = (nint)obj4;
					object obj5 = ((List<object>)(object)_selectedMovesByCard).get_Item(0);
					bool flag4 = obj5 == null;
					enumerator = (List<object>.Enumerator)0;
					num = 0;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v85 (System.Object)+20]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v85 (System.Object)+20]");
						_selectedMarble1 = (JackarooMarble)0;
						object obj6 = this + 264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						CardGameVisualControls cardGameVisualControls = gameVisualControls;
						bool flag5 = (object)gameVisualControls == null;
						enumerator = (List<object>.Enumerator)0;
						if (!flag5)
						{
							object obj7 = obj3;
							nint num3 = (nint)cardGameVisualControls;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v22 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X9_v19+130]");
							bool flag6 = num4 < 0;
							object obj8 = !flag6;
							object obj9 = ~obj8;
							enumerator = (List<object>.Enumerator)0;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v22 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X9_v19+130]");
								object obj10 = num5 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X10_v24-8]");
								bool flag7 = 0 != (nint)obj7;
								enumerator = (List<object>.Enumerator)0;
								if (!flag7)
								{
									JackarooMarble selectedMarble = _selectedMarble1;
									bool flag8 = _selectedMarble1 == null;
									enumerator = (List<object>.Enumerator)0;
									if (!flag8)
									{
										JackarooNode <Node>k__BackingField = selectedMarble.<Node>k__BackingField;
										bool flag9 = selectedMarble.<Node>k__BackingField == null;
										enumerator = (List<object>.Enumerator)0;
										if (!flag9)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v51 (CardGameVisualControls)+148]");
											bool flag10 = (nint)0 == 0;
											enumerator = (List<object>.Enumerator)0;
											if (!flag10)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v51 (CardGameVisualControls)+148]");
												((JackarooBoardMono)0).HighlightFirstNode(<Node>k__BackingField.<NodeMono>k__BackingField, animate: false);
												jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
												bool flag11 = (object)gameVisualControls == null;
												enumerator = (List<object>.Enumerator)0;
												object obj11 = 0;
												num2 = unchecked((nint)null);
												num = (int)<Node>k__BackingField.<NodeMono>k__BackingField;
												if (!flag11)
												{
													object obj12 = obj3;
													nint num6 = (nint)jackarooCardGameVisualControls;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v22 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
													nint num7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v54+130]");
													bool flag12 = num7 < 0;
													object obj13 = !flag12;
													object obj14 = ~obj13;
													enumerator = (List<object>.Enumerator)0;
													obj11 = 0;
													num2 = unchecked((nint)null);
													num = (int)<Node>k__BackingField.<NodeMono>k__BackingField;
													if (obj14 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v22 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
														nint num8 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v54+130]");
														object obj15 = num8 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X9_v24-8]");
														bool flag13 = 0 != (nint)obj12;
														enumerator = (List<object>.Enumerator)0;
														obj11 = 0;
														num2 = unchecked((nint)null);
														num = (int)<Node>k__BackingField.<NodeMono>k__BackingField;
														if (!flag13)
														{
															obj16 = "SERVICE_DISABLED" + 2608;
															obj11 = 0;
															goto IL_0e8f;
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
				jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
				bool flag14 = (object)gameVisualControls == null;
				enumerator = (List<object>.Enumerator)0;
				num = 0;
				if (!flag14)
				{
					object obj17 = obj3;
					nint num9 = (nint)jackarooCardGameVisualControls;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X9_v15 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v43+130]");
					bool flag15 = num10 < 0;
					object obj18 = !flag15;
					object obj19 = ~obj18;
					enumerator = (List<object>.Enumerator)0;
					num = 0;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X9_v15 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v43+130]");
						object obj20 = num11 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X9_v17-8]");
						bool flag16 = 0 != (nint)obj17;
						enumerator = (List<object>.Enumerator)0;
						num = 0;
						if (!flag16)
						{
							obj16 = "SERVICE_DISABLED" + 2600;
							goto IL_0e8f;
						}
					}
				}
			}
		}
		goto IL_0e02;
		IL_0e8f:
		jackarooCardGameVisualControls.ShowActionTipPanel((string)obj16);
		bool flag17 = _selectedMovesByCard == null;
		enumerator = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		num = (int)obj16;
		if (!flag17)
		{
			object obj21 = (nint)0 + (nint)2800;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)_selectedMovesByCard).GetEnumerator();
			num2 = unchecked((nint)null);
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			<>c__DisplayClass63_1 <>c__DisplayClass63_2 = default(<>c__DisplayClass63_1);
			int num12 = default(int);
			Action action = default(Action);
			<>c__DisplayClass63_2 <>c__DisplayClass63_3 = default(<>c__DisplayClass63_2);
			Action action2 = default(Action);
			while (true)
			{
				if (enumerator3.MoveNext())
				{
					object obj22 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 744;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					<>c__DisplayClass63_2..ctor();
					if (<>c__DisplayClass63_2 != null)
					{
						object obj23 = <>c__DisplayClass63_2 + 24;
						obj23 = <>c__DisplayClass63_;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj24 = <>c__DisplayClass63_2 + 16;
						obj24 = num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						CardGameVisualControls cardGameVisualControls2 = gameVisualControls;
						if ((object)gameVisualControls != null)
						{
							object obj25 = obj3;
							nint num13 = (nint)cardGameVisualControls2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X10_v7 (Il2CppClass<CardGameVisualControls>)+130]");
							nint num14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X9_v7+130]");
							bool flag18 = num14 < 0;
							object obj26 = !flag18;
							object obj27 = ~obj26;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X10_v7 (Il2CppClass<CardGameVisualControls>)+C8]");
								nint num15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X9_v7+130]");
								object obj28 = num15 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v9-8]");
								if (0 == (nint)obj25)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v22 (CardGameVisualControls)+148]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v22 (CardGameVisualControls)+148]");
										((JackarooBoardMono)0).HighlightGuardedMarbles((JackarooMove)obj24);
										if (flag2)
										{
											object obj29 = obj24;
											if (obj24 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v34+30]");
												object obj30 = 0;
												CardGameVisualControls cardGameVisualControls3 = gameVisualControls;
												if ((object)gameVisualControls != null)
												{
													object obj31 = obj3;
													nint num16 = (nint)cardGameVisualControls3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X10_v17 (Il2CppClass<CardGameVisualControls>)+130]");
													nint num17 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X9_v13+130]");
													bool flag19 = num17 < 0;
													object obj32 = !flag19;
													object obj33 = ~obj32;
													if (obj33 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X10_v17 (Il2CppClass<CardGameVisualControls>)+C8]");
														nint num18 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X9_v13+130]");
														object obj34 = num18 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v19-8]");
														if (0 == (nint)obj31)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v34+30]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X24_v9+20]");
																object obj35 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X24_v9+20]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v36 (CardGameVisualControls)+148]");
																	if ((nint)0 != 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v36 (CardGameVisualControls)+148]");
																		nint num19 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X9_v14+18]");
																		((JackarooBoardMono)num19).HighlightFirstNode((JackarooNodeMono)0);
																		object obj36 = typeof(SqlSingle[]) + 2376;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																		object obj37 = (nint)0 + (nint)2232;
																		action..ctor(<>c__DisplayClass63_2, (IntPtr)obj37);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X24_v9+18]");
																		object obj11;
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X24_v9+18]");
																			((JackarooMarbleMono)0).SetupSelect(action);
																			obj11 = 0;
																			num2 = unchecked((nint)null);
																			continue;
																		}
																		NullReferenceException ex = new NullReferenceException();
																		obj11 = 0;
																		num2 = (nint)obj37;
																		num = (int)<>c__DisplayClass63_2;
																		break;
																	}
																	NullReferenceException ex2 = new NullReferenceException();
																	num2 = unchecked((nint)null);
																	num = (int)obj24;
																	break;
																}
																NullReferenceException ex3 = new NullReferenceException();
																num2 = unchecked((nint)null);
																num = (int)obj24;
																break;
															}
															NullReferenceException ex4 = new NullReferenceException();
															num2 = unchecked((nint)null);
															num = (int)obj24;
															break;
														}
													}
												}
												NullReferenceException ex5 = new NullReferenceException();
												num2 = unchecked((nint)null);
												num = (int)obj24;
											}
											else
											{
												NullReferenceException ex6 = new NullReferenceException();
												num2 = unchecked((nint)null);
												num = (int)obj24;
											}
											break;
										}
										object obj38 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 752;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										<>c__DisplayClass63_3..ctor();
										if (<>c__DisplayClass63_3 != null)
										{
											object obj39 = <>c__DisplayClass63_3 + 24;
											obj39 = <>c__DisplayClass63_2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj40 = obj39;
											if (obj39 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v25+10]");
												object obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v25+10]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v26+20]");
													num = 0;
													object obj42 = <>c__DisplayClass63_3 + 16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v26+20]");
													obj42 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													CardGameVisualControls cardGameVisualControls4 = gameVisualControls;
													if ((object)gameVisualControls != null)
													{
														object obj43 = obj3;
														nint num20 = (nint)cardGameVisualControls4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X10_v12 (Il2CppClass<CardGameVisualControls>)+130]");
														nint num21 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X9_v9+130]");
														bool flag20 = num21 < 0;
														object obj44 = !flag20;
														object obj45 = ~obj44;
														if (obj45 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X10_v12 (Il2CppClass<CardGameVisualControls>)+C8]");
															nint num22 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X9_v9+130]");
															object obj46 = num22 + 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X10_v14-8]");
															if (0 == (nint)obj43)
															{
																object obj47 = obj42;
																if (obj42 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X9_v10+20]");
																	object obj48 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X9_v10+20]");
																	if ((nint)0 != 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v28 (CardGameVisualControls)+148]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v28 (CardGameVisualControls)+148]");
																			nint num23 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X9_v11+18]");
																			((JackarooBoardMono)num23).HighlightFirstNode((JackarooNodeMono)0);
																			object obj49 = obj42;
																			object obj11;
																			if (obj42 != null)
																			{
																				object obj50 = typeof(SqlSingle[]) + 2376;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																				object obj51 = (nint)0 + (nint)2240;
																				action2..ctor(<>c__DisplayClass63_3, (IntPtr)obj51);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v29+18]");
																				if ((nint)0 != 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v29+18]");
																					((JackarooMarbleMono)0).SetupSelect(action2);
																					obj11 = 0;
																					num2 = unchecked((nint)null);
																					continue;
																				}
																				NullReferenceException ex7 = new NullReferenceException();
																				obj11 = 0;
																				num2 = (nint)obj51;
																				num = (int)<>c__DisplayClass63_3;
																				break;
																			}
																			NullReferenceException ex8 = new NullReferenceException();
																			obj11 = 0;
																			num2 = 1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X9_v11+18]");
																			num = 0;
																			break;
																		}
																		NullReferenceException ex9 = new NullReferenceException();
																		num2 = unchecked((nint)null);
																		break;
																	}
																	NullReferenceException ex10 = new NullReferenceException();
																	num2 = unchecked((nint)null);
																	break;
																}
																NullReferenceException ex11 = new NullReferenceException();
																num2 = unchecked((nint)null);
																break;
															}
														}
													}
													NullReferenceException ex12 = new NullReferenceException();
													num2 = unchecked((nint)null);
												}
												else
												{
													NullReferenceException ex13 = new NullReferenceException();
													num2 = unchecked((nint)null);
													num = (int)<>c__DisplayClass63_2;
												}
											}
											else
											{
												NullReferenceException ex14 = new NullReferenceException();
												num2 = unchecked((nint)null);
												num = (int)<>c__DisplayClass63_2;
											}
										}
										else
										{
											NullReferenceException ex15 = new NullReferenceException();
											num2 = unchecked((nint)null);
											num = 0;
										}
									}
									else
									{
										NullReferenceException ex16 = new NullReferenceException();
										num = num12;
									}
									break;
								}
							}
						}
						NullReferenceException ex17 = new NullReferenceException();
						num = num12;
					}
					else
					{
						NullReferenceException ex18 = new NullReferenceException();
						num = 0;
					}
					break;
				}
				enumerator3.Dispose();
				return;
			}
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		goto IL_0e02;
		IL_0e02:
		NullReferenceException ex19 = new NullReferenceException();
		bool flag21 = num != 1;
		OutOfMemoryException ex20 = (OutOfMemoryException)(object)ex19;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj52 = (nint)0 + (nint)2792;
			num = (int)obj52;
			enumerator.Dispose();
			object obj53 = default(object);
			if (obj53 == null)
			{
				return;
			}
			ex20 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj53;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	protected override void OnGameStatusUpdate()
	{
		//IL_1504: Expected O, but got I
		//IL_026a: Expected I4, but got O
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_006d: Expected O, but got I4
		//IL_02e9: Expected I4, but got O
		//IL_00a1: Expected O, but got I
		//IL_0387: Expected O, but got I4
		//IL_042d: Expected O, but got I4
		//IL_039a: Expected I, but got O
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_0b60: Expected I, but got O
		//IL_0b89: Expected O, but got I4
		//IL_06b6: Expected O, but got I
		//IL_06d0: Expected O, but got I4
		//IL_045f: Expected O, but got I
		//IL_0467: Expected I4, but got O
		//IL_0bbd: Expected O, but got I
		//IL_0702: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_01e9: Expected I, but got O
		//IL_01f7: Expected I, but got O
		//IL_0bf4: Expected O, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04c6: Expected I, but got O
		//IL_04ef: Expected O, but got I4
		//IL_0c35: Expected O, but got I
		//IL_0c3d: Expected I4, but got O
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_077c: Expected I, but got O
		//IL_07a5: Expected O, but got I4
		//IL_0523: Expected O, but got I
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected O, but got Unknown
		//IL_07d9: Expected O, but got I
		//IL_055a: Expected O, but got I
		//IL_059b: Expected O, but got I
		//IL_05a3: Expected I4, but got O
		//IL_0cd1: Expected I, but got O
		//IL_0cfa: Expected O, but got I4
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_0d2e: Expected O, but got I
		//IL_1096: Expected O, but got I4
		//IL_0d65: Expected O, but got I
		//IL_1154: Expected O, but got I
		//IL_116e: Expected O, but got I4
		//IL_1125: Expected O, but got I4
		//IL_10e2: Expected O, but got I
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected O, but got Unknown
		//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Expected O, but got Unknown
		//IL_11b5: Expected I, but got O
		//IL_11de: Expected O, but got I4
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_0dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcc: Expected O, but got Unknown
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected O, but got Unknown
		//IL_1212: Expected O, but got I
		//IL_0df0: Expected I, but got O
		//IL_0e19: Expected O, but got I4
		//IL_098e: Expected I, but got O
		//IL_09b7: Expected O, but got I4
		//IL_0e4d: Expected O, but got I
		//IL_09eb: Expected O, but got I
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected O, but got Unknown
		//IL_0a1e: Expected O, but got I
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0aba: Expected O, but got I4
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1411: Expected O, but got Unknown
		//IL_1427: Expected O, but got I
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected O, but got Unknown
		//IL_0b0d: Expected O, but got I
		//IL_0b1e: Expected I, but got O
		//IL_0f19: Expected I4, but got I8
		//IL_0f33: Expected O, but got I4
		//IL_1609: Expected I, but got O
		//IL_12f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f6: Expected O, but got Unknown
		//IL_1328: Expected O, but got I4
		//IL_0f71: Expected O, but got I
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected O, but got Unknown
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e: Expected O, but got Unknown
		//IL_1491: Expected O, but got I4
		//IL_137e: Expected I, but got O
		//IL_138e: Expected O, but got I
		//IL_13c0: Expected O, but got I4
		//IL_14b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b8: Expected O, but got Unknown
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bf: Expected O, but got Unknown
		//IL_15df: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e4: Expected O, but got Unknown
		//IL_14d3: Expected O, but got I
		//IL_13ea: Expected O, but got I4
		//IL_13f8: Expected O, but got I4
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected O, but got Unknown
		//IL_0fd3: Expected O, but got I
		//IL_0fe4: Expected I, but got O
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Expected O, but got Unknown
		//IL_1027: Expected O, but got I4
		bool flag = DidHandChanged();
		bool flag2 = !flag;
		IntPtr intPtr = default(IntPtr);
		Action action = (Action)(nint)intPtr;
		if (flag2)
		{
			goto IL_0221;
		}
		playedCardThisTurn = false;
		_awaitingPlayConfirmation = false;
		JackarooGame jackarooGame = (JackarooGame)game;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj2 = obj;
		nint num = (nint)jackarooGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X9_v55 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v138+130]");
		bool flag3 = num2 < 0;
		object obj3 = !flag3;
		object obj4 = ~obj3;
		nint num4 = default(nint);
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X9_v55 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v138+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X9_v57-8]");
			if (0 == (nint)obj2)
			{
				jackarooGame.DisableUpdatedThisTurn();
				List<JackarooMove> allowedMoves = _allowedMoves;
				int version = allowedMoves._version + 1;
				allowedMoves._size = 0;
				allowedMoves._version = version;
				bool flag4 = allowedMoves._size < 1;
				action = null;
				if (!flag4)
				{
					Array.Clear(allowedMoves._items, 0, allowedMoves._size);
					CardGamePlayer cardGamePlayer = null;
					action = null;
				}
				CardGamePlayer cardGamePlayer2 = player;
				KGame <Game>k__BackingField = ((KPlayer)cardGamePlayer2).<Game>k__BackingField;
				bool flag5 = <Game>k__BackingField.<Mover>k__BackingField != ((KPlayer)cardGamePlayer2).<Index>k__BackingField;
				num4 = allowedMoves._size;
				if (!flag5)
				{
					object obj6 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj7 = (nint)0 + (nint)752;
					num4 = (nint)obj7;
					Action action2 = default(Action);
					action2..ctor(this, (IntPtr)obj7);
					WaitForBoard(action2);
					CardGamePlayer cardGamePlayer = null;
					action = action2;
				}
				goto IL_0221;
			}
		}
		goto IL_14e0;
		IL_1191:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj9 = obj8;
		JackarooCardGameVisualControls jackarooCardGameVisualControls;
		nint num5 = (nint)jackarooCardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v30 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v68+130]");
		bool flag6 = num6 < 0;
		object obj10 = !flag6;
		object obj11 = ~obj10;
		object obj19;
		Action action3;
		Action action4 = default(Action);
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v30 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v68+130]");
			object obj12 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ X9_v32-8]");
			if (0 == (nint)obj9)
			{
				jackarooCardGameVisualControls.HideActionTip();
				CardGamePlayer cardGamePlayer3 = player;
				KGame <Game>k__BackingField2 = ((KPlayer)cardGamePlayer3).<Game>k__BackingField;
				if (<Game>k__BackingField2.<Mover>k__BackingField != ((KPlayer)cardGamePlayer3).<Index>k__BackingField)
				{
					return;
				}
				JackarooLastActionInfo lastActionInfo = LastActionInfo;
				CardGamePlayer cardGamePlayer4 = player;
				bool flag7 = ((LastActionInfo)lastActionInfo).<ActionPlayer>k__BackingField != ((KPlayer)cardGamePlayer4).<Index>k__BackingField;
				string text = null;
				if (!flag7)
				{
					JackarooLastActionInfo lastActionInfo2 = LastActionInfo;
					object obj13 = "___# Content push apply failed [{0}]: {1}" + 2672;
					text = (string)obj13;
					bool flag8 = ((LastActionInfo)lastActionInfo2).<Action>k__BackingField == (string)obj13;
					bool flag9 = !flag8;
					object obj14 = 0;
					if (!flag9)
					{
						Card playedCard = _playedCard;
						JackarooLastActionInfo lastActionInfo3 = LastActionInfo;
						if (_playedCard != null)
						{
							Card <Card>k__BackingField = lastActionInfo3.<Card>k__BackingField;
							nint num8 = (nint)playedCard;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X8_v88 (Il2CppClass<Card>)+140]");
							GameAction? gameAction = (GameAction?)(object)0;
							bool flag10 = _playedCard.Equals(lastActionInfo3.<Card>k__BackingField);
							bool flag11 = !flag10;
							object obj15 = !flag11;
							if (obj15 == null)
							{
								<Card>k__BackingField = _playedCard;
								DoPlayCard(_playedCard, (GameAction?)(object)0);
								CardGamePlayer cardGamePlayer = null;
								gameAction = (GameAction?)(object)0;
							}
						}
						else
						{
							object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Card card = default(Card);
							card..ctor(lastActionInfo3.<Card>k__BackingField);
							_playedCard = card;
							object obj17 = this + 296;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							GameAction? gameAction = (GameAction?)(object)0;
							Card <Card>k__BackingField = card;
						}
						DisableFireMode();
						object obj18 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj19 = (nint)0 + (nint)720;
						action3 = action4;
						goto IL_15fb;
					}
				}
				object obj20 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj19 = (nint)0 + (nint)728;
				action3 = action4;
				goto IL_15fb;
			}
		}
		goto IL_14e0;
		IL_0643:
		CardGamePlayer cardGamePlayer5;
		KGame <Game>k__BackingField3 = ((KPlayer)cardGamePlayer5).<Game>k__BackingField;
		int? num21;
		int num19;
		int num20;
		if (<Game>k__BackingField3.<Mover>k__BackingField == ((KPlayer)cardGamePlayer5).<Index>k__BackingField)
		{
			if (((KPlayer)cardGamePlayer5).<User>k__BackingField == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BCF]");
			object obj21 = (nint)0 & (nint)1;
			bool flag12 = obj21 == null;
			object obj22 = !flag12;
			if (obj22 == null)
			{
				_ = 1;
				<Game>k__BackingField3 = ((KPlayer)cardGamePlayer5).<Game>k__BackingField;
			}
			object obj23 = (nint)0 + (nint)880;
			int index = ((KPlayer)cardGamePlayer5).<Index>k__BackingField - 1;
			object obj14 = obj23;
			System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)<Game>k__BackingField3.<SeatStatuses>k__BackingField).get_Item(index);
			if (int32Enum != (System.Int32Enum)6)
			{
				return;
			}
			JackarooGame jackarooGame2 = (JackarooGame)game;
			object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
			object obj25 = obj24;
			nint num9 = (nint)jackarooGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X9_v23 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v59+130]");
			bool flag13 = num10 < 0;
			object obj26 = !flag13;
			object obj27 = ~obj26;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X9_v23 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v59+130]");
				object obj28 = num11 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X9_v25-8]");
				if (0 == (nint)obj25)
				{
					JackarooLastActionInfo <LastAction>k__BackingField = jackarooGame2.<LastAction>k__BackingField;
					if (jackarooGame2.<LastAction>k__BackingField == null)
					{
						return;
					}
					if (((LastActionInfo)<LastAction>k__BackingField).<ActionPlayer>k__BackingField != 0)
					{
						CardGamePlayer cardGamePlayer6 = player;
						if (((LastActionInfo)<LastAction>k__BackingField).<ActionPlayer>k__BackingField != ((KPlayer)cardGamePlayer6).<Index>k__BackingField)
						{
							KGame <Game>k__BackingField4 = ((KPlayer)cardGamePlayer6).<Game>k__BackingField;
							if (<Game>k__BackingField4.<Mover>k__BackingField != ((KPlayer)cardGamePlayer6).<Index>k__BackingField)
							{
								return;
							}
						}
					}
					if (<LastAction>k__BackingField.<JackarooAction>k__BackingField == JackarooActions.STEAL)
					{
						CardGamePlayer cardGamePlayer7 = player;
						KGame <Game>k__BackingField5 = ((KPlayer)cardGamePlayer7).<Game>k__BackingField;
						if (<Game>k__BackingField5.<Mover>k__BackingField == ((KPlayer)cardGamePlayer7).<Index>k__BackingField)
						{
							object obj29 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 776;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							<>c__DisplayClass67_1 <>c__DisplayClass67_ = default(<>c__DisplayClass67_1);
							<>c__DisplayClass67_..ctor();
							object obj30 = <>c__DisplayClass67_ + 24;
							obj30 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							CardGame cardGame = game;
							object obj31 = obj24;
							nint num12 = (nint)cardGame;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X10_v20 (Il2CppClass<CardGame>)+130]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X9_v45+130]");
							bool flag14 = num13 < 0;
							object obj32 = !flag14;
							object obj33 = ~obj32;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X10_v20 (Il2CppClass<CardGame>)+C8]");
								nint num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X9_v45+130]");
								object obj34 = num14 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X10_v22-8]");
								if (0 == (nint)obj31)
								{
									object obj35 = (nint)0 + (nint)1784;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC8C54");
									Card card2 = default(Card);
									if (card2 != null)
									{
										Card card3 = CardUtilExtensions.Clone(card2);
										object obj36 = <>c__DisplayClass67_ + 16;
										obj36 = card3;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Card card4 = (Card)obj36;
										_playedCard = (Card)obj36;
										object obj37 = this + 296;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag15 = !_isDealAnimating;
										object obj38 = !flag15;
										if (obj38 == null)
										{
											card4 = _playedCard;
											ShowHandCards(_playedCard);
										}
										object obj39 = typeof(SqlSingle[]) + 2376;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj40 = (nint)0 + (nint)2264;
										Action action5 = default(Action);
										action5..ctor(<>c__DisplayClass67_, (IntPtr)obj40);
										WaitForBoard(action5);
									}
									return;
								}
							}
							goto IL_14e0;
						}
					}
					bool flag16 = !jackarooGame2.<UpdatedThisTurn>k__BackingField;
					object obj41 = !flag16;
					if (obj41 != null)
					{
						return;
					}
					jackarooGame2.EnableUpdatedThisTurn();
					if (_isDealAnimating)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD1]");
						object obj42 = (nint)0 & (nint)1;
						if (obj42 != null)
						{
							goto IL_10ff;
						}
					}
					else
					{
						ShowHandCards();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BD1]");
						object obj43 = (nint)0 & (nint)1;
						bool flag17 = obj43 == null;
						object obj44 = !flag17;
						if (obj44 != null)
						{
							goto IL_10ff;
						}
					}
					_ = 1;
					jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
					goto IL_1191;
				}
			}
		}
		else
		{
			CardGame cardGame2 = game;
			object obj45 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
			object obj46 = obj45;
			nint num15 = (nint)cardGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X10_v5 (Il2CppClass<CardGame>)+130]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X9_v10+130]");
			bool flag18 = num16 < 0;
			object obj47 = !flag18;
			object obj48 = ~obj47;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X10_v5 (Il2CppClass<CardGame>)+C8]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X9_v10+130]");
				object obj49 = num17 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X10_v7-8]");
				if (0 == (nint)obj46)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v17 (CardGame)+170]");
					int? num18 = (int?)(object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v17 (CardGame)+170]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v19 (System.Nullable`1<System.Int32>)+10]");
						num19 = 0;
						object obj50 = (nint)0 + (nint)3136;
						num20 = (int)obj50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v19 (System.Nullable`1<System.Int32>)+10]");
						num21 = 0;
						num18 = num21;
					}
					CardGamePlayer cardGamePlayer8 = player;
					object obj51 = (object?)num18 >> 32;
					if (((KPlayer)cardGamePlayer8).<Index>k__BackingField == (nint)obj51)
					{
						object obj52 = (??)num18 & 1;
						if (obj52 != null)
						{
							CardGame cardGame3 = game;
							object obj53 = obj45;
							nint num22 = (nint)cardGame3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X10_v11 (Il2CppClass<CardGame>)+130]");
							nint num23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X9_v14+130]");
							bool flag19 = num23 < 0;
							object obj54 = !flag19;
							object obj55 = ~obj54;
							if (obj55 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X10_v11 (Il2CppClass<CardGame>)+C8]");
								nint num24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X9_v14+130]");
								object obj56 = num24 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X10_v13-8]");
								if (0 == (nint)obj53)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v23 (CardGame)+170]");
									object obj57 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v24+38]");
									if ((nint)0 != 65536)
									{
										goto IL_105b;
									}
									object obj58 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 768;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									<>c__DisplayClass67_0 <>c__DisplayClass67_2 = default(<>c__DisplayClass67_0);
									<>c__DisplayClass67_2..ctor();
									object obj59 = <>c__DisplayClass67_2 + 32;
									obj59 = this;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									JackarooGame jackarooGame3 = (JackarooGame)game;
									object obj60 = obj45;
									nint num25 = (nint)jackarooGame3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X9_v15 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
									nint num26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v30+130]");
									bool flag20 = num26 < 0;
									object obj61 = !flag20;
									object obj62 = ~obj61;
									if (obj62 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X9_v15 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
										nint num27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v30+130]");
										object obj63 = num27 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X9_v17-8]");
										if (0 == (nint)obj60)
										{
											JackarooPlayer getNextToMyPlayer = jackarooGame3.GetNextToMyPlayer;
											object obj64 = <>c__DisplayClass67_2 + 24;
											obj64 = getNextToMyPlayer;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj65 = obj64;
											CardGame cardGame4 = game;
											List<object> <PlayedCards>k__BackingField = (List<object>)(object)cardGame4.<PlayedCards>k__BackingField;
											if (cardGame4.<PlayedCards>k__BackingField == null)
											{
												return;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v31+10]");
											int num28 = (int)(-1);
											int num29 = (int)(num28 & 0x80000000L);
											bool flag21 = num29 == 0;
											object obj66 = !flag21;
											if (obj66 != null || num28 >= <PlayedCards>k__BackingField._size)
											{
												return;
											}
											object obj67 = (nint)0 + (nint)2760;
											object obj68 = ((List<object>)(object)cardGame4.<PlayedCards>k__BackingField).get_Item(num28);
											if (obj68 != null)
											{
												object obj69 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												Card card5 = default(Card);
												card5..ctor((Card)obj68);
												object obj70 = <>c__DisplayClass67_2 + 16;
												obj70 = card5;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj71 = typeof(SqlSingle[]) + 2376;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj72 = (nint)0 + (nint)2256;
												Action action6 = default(Action);
												action6..ctor(<>c__DisplayClass67_2, (IntPtr)obj72);
												object obj73 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
												object obj74 = obj73;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X0_v35+E4]");
												bool flag22 = (nint)0 == 0;
												object obj75 = !flag22;
												if (obj75 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action6);
											}
											return;
										}
									}
								}
							}
							goto IL_14e0;
						}
					}
					goto IL_105b;
				}
			}
		}
		goto IL_14e0;
		IL_14e0:
		throw new NullReferenceException();
		IL_105b:
		_wasStealing = false;
		gameEventsChannel.TriggerDisableFireModeButton();
		return;
		IL_15fb:
		action4..ctor(this, (IntPtr)obj19);
		WaitForBoard(action3);
		return;
		IL_10ff:
		jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
		bool flag23 = (object)gameVisualControls == null;
		object obj76 = !flag23;
		if (obj76 != null)
		{
			goto IL_1191;
		}
		goto IL_14e0;
		IL_0221:
		cardGamePlayer5 = player;
		KGame <Game>k__BackingField6 = ((KPlayer)cardGamePlayer5).<Game>k__BackingField;
		bool flag24 = <Game>k__BackingField6.<Mover>k__BackingField == ((KPlayer)cardGamePlayer5).<Index>k__BackingField;
		num20 = (int)num4;
		num19 = (int)action;
		if (!flag24)
		{
			_awaitingPlayConfirmation = false;
			List<JackarooMove> allowedMoves2 = _allowedMoves;
			num20 = allowedMoves2._size;
			int version2 = allowedMoves2._version + 1;
			allowedMoves2._size = 0;
			allowedMoves2._version = version2;
			bool flag25 = allowedMoves2._size < 1;
			num19 = (int)action;
			if (!flag25)
			{
				Array.Clear(allowedMoves2._items, 0, allowedMoves2._size);
				cardGamePlayer5 = player;
				CardGamePlayer cardGamePlayer = null;
				num19 = 0;
			}
		}
		KGame <Game>k__BackingField7 = ((KPlayer)cardGamePlayer5).<Game>k__BackingField;
		if (<Game>k__BackingField7.<MySeatIndex>k__BackingField == ((KPlayer)cardGamePlayer5).<Index>k__BackingField)
		{
			bool flag26 = !_isDealAnimating;
			object obj77 = !flag26;
			if (obj77 == null)
			{
				nint num30 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v132 (Il2CppClass<JackarooHand>)+260]");
				num19 = 0;
				ShowHandCards();
				cardGamePlayer5 = player;
			}
		}
		KGame <Game>k__BackingField8 = ((KPlayer)cardGamePlayer5).<Game>k__BackingField;
		if (<Game>k__BackingField8.<MySeatIndex>k__BackingField == ((KPlayer)cardGamePlayer5).<Index>k__BackingField)
		{
			bool isSpectator = game.IsSpectator;
			cardGamePlayer5 = player;
			bool flag27 = !isSpectator;
			object obj78 = !flag27;
			if (obj78 == null)
			{
				KGame <Game>k__BackingField9 = ((KPlayer)cardGamePlayer5).<Game>k__BackingField;
				num19 = ((KPlayer)cardGamePlayer5).<Index>k__BackingField - 1;
				object obj79 = (nint)0 + (nint)880;
				num20 = (int)obj79;
				System.Int32Enum int32Enum2 = ((List<System.Int32Enum>)(object)<Game>k__BackingField9.<SeatStatuses>k__BackingField).get_Item(num19);
				if (int32Enum2 == (System.Int32Enum)2)
				{
					CardGame cardGame5 = game;
					object obj80 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
					object obj81 = obj80;
					nint num31 = (nint)cardGame5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X10_v27 (Il2CppClass<CardGame>)+130]");
					nint num32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X9_v50+130]");
					bool flag28 = num32 < 0;
					object obj82 = !flag28;
					object obj83 = ~obj82;
					if (obj83 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X10_v27 (Il2CppClass<CardGame>)+C8]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X9_v50+130]");
						object obj84 = num33 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X10_v29-8]");
						if (0 == (nint)obj81)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v123 (CardGame)+170]");
							int? num34 = (int?)(object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v123 (CardGame)+170]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v125 (System.Nullable`1<System.Int32>)+10]");
								num19 = 0;
								object obj85 = (nint)0 + (nint)3136;
								num20 = (int)obj85;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v125 (System.Nullable`1<System.Int32>)+10]");
								num21 = 0;
								num34 = num21;
							}
							cardGamePlayer5 = player;
							object obj86 = (object?)num34 >> 32;
							if (((KPlayer)cardGamePlayer5).<Index>k__BackingField == (nint)obj86)
							{
								object obj87 = (??)num34 & 1;
								if (obj87 != null)
								{
									ResetPlay(_allowedMoves);
									return;
								}
							}
							goto IL_0643;
						}
					}
					goto IL_14e0;
				}
				cardGamePlayer5 = player;
			}
		}
		goto IL_0643;
	}

	private bool DidHandChanged()
	{
		//IL_0622: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_005f: Expected O, but got I
		//IL_006f: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_0250: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_0270: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_033a: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0675: Expected O, but got I
		//IL_0686: Expected I, but got O
		//IL_06a4: Expected O, but got I
		//IL_06bf: Expected O, but got I4
		//IL_0769: Expected O, but got I
		//IL_077a: Expected O, but got I
		//IL_078a: Expected O, but got I
		//IL_07ac: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_0184: Expected O, but got I
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_06fe: Expected O, but got I
		//IL_070f: Expected I, but got O
		//IL_072d: Expected O, but got I
		//IL_0748: Expected O, but got I4
		//IL_0381: Expected O, but got I4
		//IL_02fa: Expected O, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_07e4: Expected O, but got I
		//IL_07f5: Expected I, but got O
		//IL_0813: Expected O, but got I
		//IL_082e: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		//IL_0486: Expected O, but got I4
		//IL_05b7: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		CardGamePlayer cardGamePlayer = player;
		object obj;
		object obj4;
		Func<object, bool> predicate;
		object obj6;
		object obj3;
		if (player != null)
		{
			obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			IEnumerable<object> <Cards>k__BackingField = cardGamePlayer.<Cards>k__BackingField;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v51+E4]");
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3448;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v51+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v40+48]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v40+48]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0132;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)3448;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v51+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v40+48]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v40+48]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0132;
				}
			}
			goto IL_0189;
		}
		goto IL_0614;
		IL_0189:
		IEnumerable<object> source = Enumerable.Where(gameCardsSprite, predicate);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v41+E4]");
		object obj10;
		Func<object, object> selector;
		object obj12;
		object obj9;
		if ((nint)0 != 0)
		{
			obj9 = (nint)0 + (nint)3328;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v41+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+50]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+50]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				obj12 = obj9;
				goto IL_02a8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
			obj12 = (nint)0 + (nint)3328;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v41+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+50]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+50]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			obj9 = obj12;
			if (obj13 == null)
			{
				goto IL_02a8;
			}
		}
		goto IL_02ff;
		IL_0508:
		List<object> list;
		if (cardGamePlayer.<Cards>k__BackingField == null || list == null)
		{
			goto IL_0614;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag7;
		if ((nint)0 == list._size)
		{
			IEnumerable<object> source2 = Enumerable.Except(cardGamePlayer.<Cards>k__BackingField, list);
			bool flag5 = Enumerable.Any(source2);
			bool flag6 = !flag5;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				IEnumerable<object> source3 = Enumerable.Except(list, cardGamePlayer.<Cards>k__BackingField);
				flag7 = Enumerable.Any(source3);
				if (!flag7)
				{
					goto IL_083b;
				}
			}
		}
		flag7 = true;
		goto IL_083b;
		IL_02ff:
		IEnumerable<object> source4 = Enumerable.Select(source, selector);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		object obj17 = (nint)0 + (nint)3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v13+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v20+58]");
		Func<object, bool> predicate2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v20+58]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		object obj26;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v13+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v26+B8]");
				obj18 = 0;
			}
			object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)1888;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj18, (IntPtr)obj23);
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v25+B8]");
			object obj25 = (nint)0 + (nint)88;
			obj25 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj26 = 0;
			predicate2 = func;
		}
		IEnumerable<object> source5 = Enumerable.Where(source4, predicate2);
		list = Enumerable.ToList(source5);
		if (_playedCard == null)
		{
			goto IL_0508;
		}
		if (list != null)
		{
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag11 = list._size < items.Length;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj28 = list._items + list._size;
					object obj29 = obj28 + 32;
					obj29 = _playedCard;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					list.AddWithResize((object)_playedCard);
				}
				goto IL_0508;
			}
		}
		goto IL_0614;
		IL_083b:
		return flag7;
		IL_0132:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v51+E4]");
		bool flag12 = (nint)0 == 0;
		object obj30 = !flag12;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v46+B8]");
			obj4 = 0;
		}
		object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)1872;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj4, (IntPtr)obj33);
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v45+B8]");
		object obj35 = (nint)0 + (nint)72;
		obj35 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj26 = 0;
		predicate = func2;
		obj3 = obj6;
		goto IL_0189;
		IL_0614:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v41+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v35+B8]");
			obj10 = 0;
		}
		object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)1880;
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor(obj10, (IntPtr)obj39);
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v34+B8]");
		object obj41 = (nint)0 + (nint)80;
		obj41 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj26 = 0;
		selector = func3;
		obj9 = obj12;
		goto IL_02ff;
	}

	private void WaitForBoard(Action action, float delay = -1f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<WaitForBoardIe>d__71 <WaitForBoardIe>d__ = default(<WaitForBoardIe>d__71);
		<WaitForBoardIe>d__..ctor(0);
		object obj2 = <WaitForBoardIe>d__ + 32;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <WaitForBoardIe>d__ + 48;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<WaitForBoardIe>d__.delay = delay;
		Coroutine coroutine = StartCoroutine(<WaitForBoardIe>d__);
	}

	private IEnumerator WaitForBoardIe(Action action, float delay = -1f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<WaitForBoardIe>d__71 <WaitForBoardIe>d__ = default(<WaitForBoardIe>d__71);
		<WaitForBoardIe>d__..ctor(0);
		if (<WaitForBoardIe>d__ != null)
		{
			object obj2 = <WaitForBoardIe>d__ + 32;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = <WaitForBoardIe>d__ + 48;
			obj3 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<WaitForBoardIe>d__.delay = delay;
			return <WaitForBoardIe>d__;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private unsafe void GetAllowedMoves()
	{
		//IL_01c0: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_01d3: Expected I, but got O
		//IL_01e3: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_0eec: Expected I, but got O
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0247: Expected I, but got O
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006e: Expected I, but got O
		//IL_0097: Expected O, but got I4
		//IL_00a5: Expected I, but got O
		//IL_0276: Expected I, but got O
		//IL_00d0: Expected O, but got I
		//IL_00ee: Expected I, but got O
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_015d: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_04bd: Expected I, but got O
		//IL_0300: Expected I, but got O
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_019f: Expected I, but got O
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04eb: Expected I, but got O
		//IL_0514: Expected O, but got I4
		//IL_03d5: Expected O, but got I
		//IL_03dd: Expected I4, but got O
		//IL_03f2: Expected I, but got O
		//IL_0548: Expected O, but got I
		//IL_0585: Expected O, but got I
		//IL_059f: Expected O, but got I4
		//IL_05c8: Expected I, but got O
		//IL_05f1: Expected O, but got I4
		//IL_0625: Expected O, but got I
		//IL_0681: Expected O, but got I
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Ref, but got Unknown
		//IL_06b1: Expected O, but got I
		//IL_06b1: Expected O, but got I
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_0f8f: Expected O, but got I4
		//IL_0f97: Expected I4, but got O
		//IL_0f9f: Expected I, but got O
		//IL_06ea: Expected O, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_0924: Expected O, but got I
		//IL_0934: Expected O, but got I
		//IL_0956: Expected O, but got I4
		//IL_096e: Expected O, but got I
		//IL_07a3: Expected O, but got I
		//IL_07ab: Expected I4, but got O
		//IL_07d2: Expected O, but got I4
		//IL_07e2: Expected I4, but got O
		//IL_07ea: Expected I, but got O
		//IL_074a: Expected O, but got I
		//IL_075a: Expected O, but got I
		//IL_0789: Expected O, but got I
		//IL_0a5d: Expected O, but got I
		//IL_0a77: Expected O, but got I4
		//IL_099e: Expected O, but got I4
		//IL_1071: Expected O, but got I4
		//IL_080e: Expected O, but got I
		//IL_0828: Expected O, but got I4
		//IL_0840: Expected I, but got O
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Expected O, but got Unknown
		//IL_1007: Expected O, but got I
		//IL_1018: Expected I, but got O
		//IL_1036: Expected O, but got I
		//IL_0fc7: Expected O, but got I4
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected O, but got Unknown
		//IL_09f3: Expected O, but got I
		//IL_09fb: Expected I4, but got O
		//IL_0a31: Expected I4, but got O
		//IL_0a39: Expected I, but got O
		//IL_09ce: Expected O, but got I
		//IL_0aa0: Expected I, but got O
		//IL_0ac9: Expected O, but got I4
		//IL_0adb: Expected O, but got I4
		//IL_086c: Expected I, but got O
		//IL_0b0e: Expected O, but got I
		//IL_0b30: Expected O, but got I4
		//IL_0d17: Expected O, but got I
		//IL_0d27: Expected O, but got I
		//IL_0d49: Expected O, but got I4
		//IL_0dba: Expected O, but got I
		//IL_0dc2: Expected I4, but got O
		//IL_08bd: Expected O, but got I
		//IL_08cd: Expected O, but got I
		//IL_08ef: Expected O, but got I4
		//IL_0b56: Expected O, but got I
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0df2: Expected O, but got I
		//IL_0dfa: Expected I, but got O
		//IL_0d79: Expected O, but got I4
		//IL_0e4b: Expected O, but got I4
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected O, but got Unknown
		//IL_10b6: Expected O, but got I
		//IL_10c7: Expected I, but got O
		//IL_10e5: Expected O, but got I
		//IL_112d: Expected O, but got I4
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected O, but got Unknown
		//IL_0da9: Expected O, but got I
		//IL_0bde: Expected I, but got O
		//IL_0c07: Expected O, but got I4
		//IL_0c19: Expected O, but got I4
		//IL_0c4c: Expected O, but got I
		//IL_0c6e: Expected O, but got I4
		//IL_0ca9: Expected O, but got I
		//IL_0cf0: Expected I, but got O
		object obj5 = default(object);
		string text;
		int num6;
		int num7;
		nint num2;
		if (player != null)
		{
			if (!player.AreCardsShown)
			{
				bool flag = !_isDealAnimating;
				object obj = !flag;
				if (obj == null)
				{
					nint num = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v8 (Il2CppClass<JackarooHand>)+258]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v8 (Il2CppClass<JackarooHand>)+260]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v435 @ X2_v5 (should have been resolved before IL gen)");
					goto IL_01fd;
				}
				return;
			}
			_awaitingPlayConfirmation = false;
			object obj4 = 152993792;
			CardGame cardGame = game;
			bool flag2 = (object)game == null;
			num2 = unchecked((nint)null);
			if (!flag2)
			{
				obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj6 = obj5;
				nint num3 = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v5 (Il2CppClass<CardGame>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v5+130]");
				bool flag3 = num4 < 0;
				object obj7 = !flag3;
				object obj8 = ~obj7;
				num2 = unchecked((nint)null);
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v5 (Il2CppClass<CardGame>)+C8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v5+130]");
					object obj9 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X10_v7-8]");
					bool flag4 = 0 != (nint)obj6;
					num2 = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v11 (CardGame)+170]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v11 (CardGame)+170]");
						if ((nint)0 == 0)
						{
							goto IL_01fd;
						}
						object obj11 = "___# Content push apply failed [{0}]: {1}" + 2672;
						text = (string)obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v12+18]");
						bool flag5 = (string)0 == (string)obj11;
						bool flag6 = !flag5;
						object obj12 = !flag6;
						num6 = 0;
						if (obj12 != null)
						{
							goto IL_0255;
						}
						num7 = 0;
						num2 = (nint)obj11;
						goto IL_03ff;
					}
				}
			}
		}
		goto IL_0e7b;
		IL_0797:
		object obj13 = (nint)0 + (nint)1904;
		int num8 = (int)obj13;
		IEnumerable<object> source;
		Func<object, bool> func;
		bool flag7 = Enumerable.All(source, func);
		bool flag8 = !flag7;
		object obj14 = !flag8;
		JackarooLastActionInfo jackarooLastActionInfo2;
		JackarooLastActionInfo jackarooLastActionInfo = jackarooLastActionInfo2;
		num7 = (int)obj13;
		num2 = (nint)func;
		if (obj14 == null)
		{
			goto IL_07f8;
		}
		goto IL_0a47;
		IL_03ff:
		CardGamePlayer cardGamePlayer = player;
		if (player == null)
		{
			goto IL_0e7b;
		}
		IReadOnlyCollection<Card> readOnlyCollection = cardGamePlayer.<Cards>k__BackingField;
		goto IL_0efa;
		IL_0fad:
		bool flag9 = _allowedMoves == null;
		object obj15 = 0;
		jackarooLastActionInfo2 = jackarooLastActionInfo;
		ReadOnlyCollection<object> source2;
		object obj17;
		object obj18;
		Func<object, object> selector;
		if (!flag9)
		{
			source2 = ((List<object>)(object)_allowedMoves).AsReadOnly();
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v35+B8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v36+68]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v36+68]");
				bool flag10 = (nint)0 == 0;
				object obj19 = !flag10;
				if (obj19 == null)
				{
					goto IL_0d57;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v35+B8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v36+68]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v36+68]");
				bool flag11 = (nint)0 == 0;
				object obj20 = !flag11;
				if (obj20 == null)
				{
					goto IL_0d57;
				}
			}
			goto IL_0dae;
		}
		goto IL_0e7b;
		IL_0e97:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0a47:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X22_v7+BD0]");
		object obj21 = (nint)0 & (nint)1;
		bool flag12 = obj21 == null;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			_ = 1;
		}
		CardGame cardGame2 = game;
		bool flag13 = (object)game == null;
		obj15 = 0;
		jackarooLastActionInfo2 = jackarooLastActionInfo;
		object obj31;
		if (!flag13)
		{
			object obj23 = obj5;
			nint num9 = (nint)cardGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v19 (Il2CppClass<CardGame>)+130]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15+130]");
			bool flag14 = num10 < 0;
			object obj24 = !flag14;
			object obj25 = ~obj24;
			obj15 = 0;
			jackarooLastActionInfo2 = jackarooLastActionInfo;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v19 (Il2CppClass<CardGame>)+C8]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15+130]");
				object obj26 = num11 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X10_v21-8]");
				bool flag15 = 0 != (nint)obj23;
				obj15 = 0;
				jackarooLastActionInfo2 = jackarooLastActionInfo;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v49 (CardGame)+170]");
					object obj27 = 0;
					object obj28 = "Network Authentication Required" + 1344;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v49 (CardGame)+170]");
					if ((nint)0 != 0)
					{
						object obj29 = "SERVICE_DISABLED" + 2576;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X9_v16+38]");
						if ((nint)0 == 32768)
						{
							obj28 = obj29;
						}
					}
					JackarooCardGameVisualControls jackarooCardGameVisualControls = (JackarooCardGameVisualControls)gameVisualControls;
					bool flag16 = (object)gameVisualControls == null;
					obj15 = 0;
					jackarooLastActionInfo2 = jackarooLastActionInfo;
					if (!flag16)
					{
						object obj30 = obj31;
						nint num12 = (nint)jackarooCardGameVisualControls;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v18 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+130]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v55+130]");
						bool flag17 = num13 < 0;
						object obj32 = !flag17;
						object obj33 = ~obj32;
						obj15 = 0;
						jackarooLastActionInfo2 = jackarooLastActionInfo;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v18 (Il2CppClass<Jackaroo.JackarooCardGameVisualControls>)+C8]");
							nint num14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v55+130]");
							object obj34 = num14 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X9_v20-8]");
							bool flag18 = 0 != (nint)obj30;
							obj15 = 0;
							jackarooLastActionInfo2 = jackarooLastActionInfo;
							if (!flag18)
							{
								((JackarooCardGameVisualControls)gameVisualControls).ShowActionTipPanel((string)obj28);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
								object obj35 = (nint)0 & (nint)1;
								bool flag19 = obj35 == null;
								jackarooLastActionInfo2 = jackarooLastActionInfo;
								num8 = 0;
								func = (Func<object, bool>)obj28;
								if (flag19)
								{
									goto IL_084e;
								}
								num7 = 0;
								num2 = (nint)obj28;
								goto IL_0fad;
							}
						}
					}
				}
			}
		}
		goto IL_0e7b;
		IL_0efa:
		List<JackarooMove> allowedMoves = _allowedMoves;
		if (_allowedMoves != null)
		{
			num7 = allowedMoves._size;
			int version = allowedMoves._version + 1;
			allowedMoves._size = 0;
			allowedMoves._version = version;
			if (allowedMoves._size >= 1)
			{
				Array.Clear(allowedMoves._items, 0, allowedMoves._size);
				jackarooLastActionInfo2 = null;
				num2 = unchecked((nint)null);
			}
			CardGameVisualControls cardGameVisualControls = gameVisualControls;
			if ((object)gameVisualControls != null)
			{
				obj31 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
				object obj36 = obj31;
				nint num15 = (nint)cardGameVisualControls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X10_v9 (Il2CppClass<CardGameVisualControls>)+130]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v8+130]");
				bool flag20 = num16 < 0;
				object obj37 = !flag20;
				object obj38 = ~obj37;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X10_v9 (Il2CppClass<CardGameVisualControls>)+C8]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v8+130]");
					object obj39 = num17 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X10_v11-8]");
					if (0 == (nint)obj36)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X22_v7+BD0]");
						object obj40 = (nint)0 & (nint)1;
						bool flag21 = obj40 == null;
						object obj41 = !flag21;
						if (obj41 == null)
						{
							_ = 1;
						}
						CardGame cardGame3 = game;
						if ((object)game != null)
						{
							object obj42 = obj5;
							nint num18 = (nint)cardGame3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X10_v13 (Il2CppClass<CardGame>)+130]");
							nint num19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v9+130]");
							bool flag22 = num19 < 0;
							object obj43 = !flag22;
							object obj44 = ~obj43;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X10_v13 (Il2CppClass<CardGame>)+C8]");
								nint num20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v9+130]");
								object obj45 = num20 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X10_v15-8]");
								if (0 == (nint)obj42)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v17 (CardGameVisualControls)+148]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v20 (CardGame)+170]");
										jackarooLastActionInfo2 = (JackarooLastActionInfo)0;
										ref List<JackarooMove> allowedJackarooMoves = ref *(List<JackarooMove>*)(this + 280);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v17 (CardGameVisualControls)+148]");
										nint num21 = 0;
										IReadOnlyCollection<Card> cards = readOnlyCollection;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v20 (CardGame)+170]");
										List<JackarooMove> list = (_allowedMoves = ((JackarooBoardMono)num21).GetAllowedJackarooMoves(ref allowedJackarooMoves, cards, (JackarooLastActionInfo)0));
										object obj46 = this + 280;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag23 = _allowedMoves == null;
										obj15 = 0;
										num7 = (int)readOnlyCollection;
										num2 = (nint)list;
										if (!flag23)
										{
											object obj47 = (nint)0 + (nint)2328;
											ReadOnlyCollection<object> readOnlyCollection2 = ((List<object>)(object)_allowedMoves).AsReadOnly();
											obj17 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
											object obj48 = obj17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v61+E4]");
											object obj49;
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v61+B8]");
												obj49 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v24+60]");
												func = (Func<object, bool>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v24+60]");
												bool flag24 = (nint)0 == 0;
												source = readOnlyCollection2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v24+60]");
												Func<object, bool> func2 = (Func<object, bool>)0;
												if (!flag24)
												{
													goto IL_0797;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj48 = obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v61+B8]");
												obj49 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v24+60]");
												func = (Func<object, bool>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v24+60]");
												bool flag25 = (nint)0 == 0;
												object obj50 = !flag25;
												source = readOnlyCollection2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v24+60]");
												Func<object, bool> func2 = (Func<object, bool>)0;
												if (obj50 != null)
												{
													goto IL_0797;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v61+E4]");
											bool flag26 = (nint)0 == 0;
											object obj51 = !flag26;
											if (obj51 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												object obj52 = obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v70+B8]");
												obj49 = 0;
											}
											object obj53 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj54 = (nint)0 + (nint)1896;
											Func<object, bool> func3 = default(Func<object, bool>);
											func3..ctor(obj49, (IntPtr)obj54);
											object obj55 = obj17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v67+B8]");
											object obj56 = (nint)0 + (nint)96;
											obj56 = func3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
											object obj57 = (nint)0 + (nint)1904;
											num8 = (int)obj57;
											bool flag27 = Enumerable.All(readOnlyCollection2, func3);
											bool flag28 = !flag27;
											jackarooLastActionInfo2 = null;
											func = func3;
											jackarooLastActionInfo = null;
											num7 = (int)obj57;
											num2 = (nint)func3;
											if (flag28)
											{
												goto IL_07f8;
											}
											goto IL_0a47;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0e7b;
		IL_0dae:
		object obj58 = (nint)0 + (nint)3624;
		num7 = (int)obj58;
		IEnumerable<object> source3 = Enumerable.Select(source2, selector);
		IEnumerable<object> source4 = Enumerable.Distinct(source3);
		object obj59 = (nint)0 + (nint)1896;
		num2 = (nint)obj59;
		List<object> playableCards = Enumerable.ToList(source4);
		if (_isDealAnimating)
		{
			return;
		}
		CardGamePlayer cardGamePlayer2 = player;
		bool flag29 = player == null;
		obj15 = 0;
		jackarooLastActionInfo2 = jackarooLastActionInfo;
		if (!flag29)
		{
			ShowHandCards(cardGamePlayer2.<Cards>k__BackingField, _playedCard, (ICollection<Card>)playableCards);
			return;
		}
		goto IL_0e7b;
		IL_01fd:
		object obj60 = "___# Content push apply failed [{0}]: {1}" + 2672;
		text = (string)obj60;
		bool flag30 = null == (string)obj60;
		bool flag31 = !flag30;
		num6 = 0;
		num7 = 0;
		num2 = (nint)obj60;
		if (!flag31)
		{
			goto IL_0255;
		}
		goto IL_03ff;
		IL_0d57:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v35+E4]");
		bool flag32 = (nint)0 == 0;
		object obj61 = !flag32;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj62 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v42+B8]");
			obj18 = 0;
		}
		object obj63 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj64 = (nint)0 + (nint)1904;
		Func<object, object> func4 = default(Func<object, object>);
		func4..ctor(obj18, (IntPtr)obj64);
		object obj65 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v41+B8]");
		object obj66 = (nint)0 + (nint)104;
		obj66 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		jackarooLastActionInfo = null;
		selector = func4;
		goto IL_0dae;
		IL_0255:
		bool flag33 = _playedCard == null;
		num7 = num6;
		num2 = (nint)text;
		if (flag33)
		{
			goto IL_03ff;
		}
		object obj67 = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		bool flag34 = enumerable == null;
		num7 = num6;
		num2 = 1;
		if (flag34)
		{
			goto IL_0e7b;
		}
		bool flag35 = _playedCard == null;
		nint num22 = 1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag35)
		{
			nint num23 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v94 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag36 = ex == null;
			num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v94 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			num2 = 0;
			if (flag36)
			{
				goto IL_0e97;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v89 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag37 = (nint)0 == 0;
		num7 = num6;
		num2 = num22;
		if (flag37)
		{
			goto IL_0e89;
		}
		object obj68 = enumerable + 32;
		obj68 = _playedCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj69 = typeof(List<AdaptivePerformanceScaler>) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj70 = (nint)0 + (nint)2640;
		num7 = (int)obj70;
		List<object> list2 = default(List<object>);
		list2..ctor(enumerable);
		num2 = (nint)enumerable;
		readOnlyCollection = (IReadOnlyCollection<Card>)list2;
		goto IL_0efa;
		IL_07f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
		object obj71 = (nint)0 & (nint)1;
		bool flag38 = obj71 == null;
		object obj72 = !flag38;
		jackarooLastActionInfo = jackarooLastActionInfo2;
		num7 = num8;
		num2 = (nint)func;
		if (obj72 == null)
		{
			goto IL_084e;
		}
		goto IL_0fad;
		IL_0e89:
		ex = new IndexOutOfRangeException();
		goto IL_0e97;
		IL_084e:
		_ = 1;
		jackarooLastActionInfo = jackarooLastActionInfo2;
		num7 = num8;
		num2 = (nint)func;
		goto IL_0fad;
		IL_0e7b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0e89;
	}

	private IEnumerable<JackarooMove> GetAllowedMovesForCard(Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass73_0 <>c__DisplayClass73_ = default(<>c__DisplayClass73_0);
		<>c__DisplayClass73_..ctor();
		if (<>c__DisplayClass73_ != null)
		{
			object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
			object obj3 = (nint)0 + (nint)2272;
			object obj4 = <>c__DisplayClass73_ + 16;
			obj4 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>c__DisplayClass73_, (IntPtr)obj3);
			return (IEnumerable<JackarooMove>)Enumerable.Where(_allowedMoves, func);
		}
		return (IEnumerable<JackarooMove>)new NullReferenceException();
	}

	private bool TryAffordItem(int price)
	{
		//IL_007d: Expected O, but got I4
		//IL_0055: Expected I4, but got O
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		int virtualPrice = default(int);
		bool flag = CanAffordSpecialPlay(virtualPrice);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			if ((object)gameEventsChannel == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			object message = "not" + 88;
			gameEventsChannel.TriggerDisplayMessage((string)message);
		}
		return flag;
	}

	protected void DoPlayCard(Card card, GameAction? gameAction = null, CardGamePlayer playerToPlay = null)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460224");
	}

	private void ShowHandCards(Card exceptCard)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00a7: Expected I, but got O
		//IL_00ec: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_0281: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_0137: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0164: Expected O, but got I
		//IL_031b: Expected O, but got I
		//IL_032b: Expected O, but got I
		//IL_0341: Expected O, but got I
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I4
		//IL_01a7: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_0205: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_037c: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass77_0 <>c__DisplayClass77_ = default(<>c__DisplayClass77_0);
		<>c__DisplayClass77_..ctor();
		object obj2 = <>c__DisplayClass77_ + 16;
		obj2 = exceptCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CardGamePlayer cardGamePlayer = player;
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		object obj4 = (nint)0 + (nint)2296;
		object obj5 = (nint)0 + (nint)3280;
		object obj6 = (nint)0 + (nint)1896;
		object obj7 = (nint)0 + (nint)2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass77_, (IntPtr)obj4);
		IEnumerable<object> source = Enumerable.Where(cardGamePlayer.<Cards>k__BackingField, func);
		List<object> allCards = Enumerable.ToList(source);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X21_v3+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X21_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v5+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v5+10]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag = obj12 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v5+10]");
			object obj13 = 0;
			if (!flag)
			{
				goto IL_0172;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X21_v3+38]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+10]");
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag2 = obj16 == null;
			object obj17 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+10]");
			object obj13 = 0;
			if (obj17 != null)
			{
				goto IL_0172;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 != null)
		{
			goto IL_0197;
		}
		goto IL_0301;
		IL_0213:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0222;
		IL_0197:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X21_v3+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v19+10]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v19+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag4 = obj22 == null;
		object obj23 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v19+10]");
		object obj24 = 0;
		if (obj23 == null)
		{
			goto IL_0213;
		}
		goto IL_0222;
		IL_0222:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v22+B8]");
		object playableCards = 0;
		ShowActualHandCards((List<Card>)(object)allCards, (ICollection<Card>)playableCards);
		return;
		IL_0172:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0197;
		}
		goto IL_0301;
		IL_0301:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X21_v3+38]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v7+10]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v7+10]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		if (obj27 == null)
		{
			goto IL_0213;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v7+10]");
		obj24 = 0;
		goto IL_0222;
	}

	private void ShowHandCards(List<Card> allCards, Card exceptCard, ICollection<Card> playableCards = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_0396: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_024d: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_028b: Expected O, but got I4
		//IL_029b: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_02fd: Expected O, but got I
		//IL_030d: Expected O, but got I
		//IL_0323: Expected O, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01b8: Expected O, but got I4
		//IL_01c8: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_035e: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass78_0 <>c__DisplayClass78_ = default(<>c__DisplayClass78_0);
		<>c__DisplayClass78_..ctor();
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		object obj3 = (nint)0 + (nint)2304;
		object obj4 = <>c__DisplayClass78_ + 16;
		obj4 = exceptCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = playableCards == null;
		object obj5 = !flag;
		ICollection<Card> playableCards2 = playableCards;
		if (obj5 == null)
		{
			object obj6 = (nint)0 + (nint)2960;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v4+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v4+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+10]");
				object obj10 = (nint)0 + (nint)309;
				object obj11 = obj10 & 1;
				bool flag2 = obj11 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+10]");
				object obj12 = 0;
				if (!flag2)
				{
					goto IL_0135;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v4+38]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+10]");
				object obj14 = (nint)0 + (nint)309;
				object obj15 = obj14 & 1;
				bool flag3 = obj15 == null;
				object obj16 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+10]");
				object obj12 = 0;
				if (obj16 != null)
				{
					goto IL_0135;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 != null)
			{
				goto IL_015a;
			}
			goto IL_02e3;
		}
		goto IL_037b;
		IL_037b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass78_, (IntPtr)obj3);
		IEnumerable<object> source = Enumerable.Where(allCards, func);
		List<object> allCards2 = Enumerable.ToList(source);
		ShowActualHandCards((List<Card>)(object)allCards2, playableCards2);
		return;
		IL_01e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v23+B8]");
		object obj18 = 0;
		playableCards2 = (ICollection<Card>)obj18;
		goto IL_037b;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_01e5;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v4+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+10]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag5 = obj22 == null;
		object obj23 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+10]");
		object obj24 = 0;
		if (obj23 == null)
		{
			goto IL_01d6;
		}
		goto IL_01e5;
		IL_0135:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			goto IL_015a;
		}
		goto IL_02e3;
		IL_02e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v4+38]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+10]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+10]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		if (obj27 == null)
		{
			goto IL_01d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+10]");
		obj24 = 0;
		goto IL_01e5;
	}

	protected override void ShowHandCards()
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_048f: Expected O, but got I
		//IL_04a0: Expected O, but got I
		//IL_04b0: Expected O, but got I
		//IL_04d2: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_050a: Expected O, but got I
		//IL_051b: Expected I, but got O
		//IL_0539: Expected O, but got I
		//IL_0202: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0362: Expected O, but got I4
		//IL_0287: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_0429: Expected O, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I
		object obj2;
		ICollection<Card> collection;
		if (player.AreCardsShown)
		{
			CardGamePlayer cardGamePlayer = player;
			KGame <Game>k__BackingField = ((KPlayer)cardGamePlayer).<Game>k__BackingField;
			if (<Game>k__BackingField.<Mover>k__BackingField != ((KPlayer)cardGamePlayer).<Index>k__BackingField || playedCardThisTurn)
			{
				ShowHandCards(_playedCard);
				if (_playedCard != null)
				{
					CardGamePlayer cardGamePlayer2 = player;
					object obj = (nint)0 + (nint)2672;
					collection = (ICollection<Card>)obj;
					if (((List<object>)(object)cardGamePlayer2.<Cards>k__BackingField).Contains((object)_playedCard))
					{
						return;
					}
					obj2 = this + 296;
					obj2 = 0;
					goto IL_0550;
				}
				return;
			}
		}
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
		object obj4 = (nint)0 + (nint)2328;
		ReadOnlyCollection<object> readOnlyCollection = ((List<object>)(object)_allowedMoves).AsReadOnly();
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		ReadOnlyCollection<object> source = readOnlyCollection;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
			source = readOnlyCollection;
		}
		object obj7 = (nint)0 + (nint)3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v12+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v26+70]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v26+70]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v32+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2000;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v31+B8]");
			object obj15 = (nint)0 + (nint)112;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		collection = (ICollection<Card>)obj7;
		IEnumerable<object> source2 = Enumerable.Select(source, selector);
		List<object> list = Enumerable.ToList(source2);
		CardGamePlayer cardGamePlayer3 = player;
		KGame <Game>k__BackingField2 = ((KPlayer)cardGamePlayer3).<Game>k__BackingField;
		if (<Game>k__BackingField2.<MySeatIndex>k__BackingField == ((KPlayer)cardGamePlayer3).<Index>k__BackingField && ((KPlayer)cardGamePlayer3).<User>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BCF]");
			object obj16 = (nint)0 & (nint)1;
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				_ = 1;
				<Game>k__BackingField2 = ((KPlayer)cardGamePlayer3).<Game>k__BackingField;
			}
			object obj18 = (nint)0 + (nint)880;
			int index = ((KPlayer)cardGamePlayer3).<Index>k__BackingField - 1;
			collection = (ICollection<Card>)obj18;
			System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)<Game>k__BackingField2.<SeatStatuses>k__BackingField).get_Item(index);
			cardGamePlayer3 = player;
			if (int32Enum == (System.Int32Enum)6)
			{
				ShowActualHandCards(cardGamePlayer3.<Cards>k__BackingField, (ICollection<Card>)list);
				collection = (ICollection<Card>)list;
				goto IL_046c;
			}
		}
		if (cardGamePlayer3.CanCardsBeShown)
		{
			goto IL_0391;
		}
		Room room = game.Room;
		if (SFSKammelnaRoomExtensions.GetIsReplay(room))
		{
			bool areCardsShown = player.AreCardsShown;
			bool flag5 = !areCardsShown;
			object obj19 = !flag5;
			if (obj19 != null)
			{
				goto IL_0391;
			}
		}
		CardGamePlayer cardGamePlayer4 = player;
		List<Card> <Cards>k__BackingField = cardGamePlayer4.<Cards>k__BackingField;
		ShowHandCardsBacks(<Cards>k__BackingField._size);
		goto IL_046c;
		IL_046c:
		obj2 = this + 296;
		_playedCard = null;
		goto IL_0550;
		IL_0550:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0391:
		CardGamePlayer cardGamePlayer5 = player;
		ShowActualHandCards(cardGamePlayer5.<Cards>k__BackingField, cardGamePlayer5.<Cards>k__BackingField);
		collection = cardGamePlayer5.<Cards>k__BackingField;
		goto IL_046c;
	}

	private void ShowHandCardsBacks(int cardsCount)
	{
		//IL_01d4: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_001b: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected I4, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected I4, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		AnimateFlipCardsToTheirBack();
		GameCard[] array = gameCardsSprite;
		bool flag = gameCardsSprite == null;
		object obj = 152993792;
		if (!flag)
		{
			obj = (nint)0 + (nint)1224;
			object obj2 = 0;
			GameCard[] array2 = gameCardsSprite;
			object obj6;
			do
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
				if (!flag4)
				{
					array = (GameCard[])(object)((object)array2 + obj2);
					bool flag5 = (object)array[0] == null;
					obj5 = obj2;
					if (flag5)
					{
						break;
					}
					GameObject gameObject = array[0].gameObject;
					bool flag6 = (object)gameObject == null;
					obj5 = obj2;
					if (flag6)
					{
						break;
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
					obj6 = !flag8;
					obj2 = obj5;
					array2 = gameCardsSprite;
					continue;
				}
				if (_organizer == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389544");
				return;
			}
			while (obj6 != null);
		}
		throw new NullReferenceException();
	}

	private void ShowActualHandCards(List<Card> allCards, ICollection<Card> playableCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_0d5c: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_0dfa: Expected O, but got I
		//IL_0e0a: Expected O, but got I
		//IL_0e1a: Expected O, but got I
		//IL_0e3c: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_1060: Expected I, but got O
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0d9c: Expected O, but got I
		//IL_0dad: Expected I, but got O
		//IL_0dcb: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_0315: Expected I4, but got O
		//IL_01c5: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0230: Expected I4, but got O
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected O, but got Unknown
		//IL_0e8c: Expected O, but got I
		//IL_0e9d: Expected I, but got O
		//IL_0ebb: Expected O, but got I
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0a7b: Expected I4, but got O
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_060d: Expected O, but got I
		//IL_0616: Expected O, but got I4
		//IL_0359: Expected O, but got I
		//IL_0369: Expected I, but got O
		//IL_0371: Expected I4, but got O
		//IL_0ac8: Expected I4, but got O
		//IL_0b61: Expected O, but got I
		//IL_0b69: Expected I4, but got O
		//IL_06d4: Expected O, but got I
		//IL_0295: Expected I4, but got O
		//IL_0701: Expected I, but got O
		//IL_0716: Expected O, but got I
		//IL_072b: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_03af: Expected O, but got I4
		//IL_02c0: Expected I, but got O
		//IL_02d0: Expected I4, but got O
		//IL_0ef1: Expected I4, but got O
		//IL_03db: Expected I, but got O
		//IL_03e8: Expected I4, but got O
		//IL_0c99: Expected O, but got I
		//IL_0cbe: Invalid comparison between F4 and I4
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		//IL_0902: Expected I, but got O
		//IL_0430: Expected I, but got O
		//IL_0438: Expected I4, but got O
		//IL_07a2: Expected O, but got I
		//IL_092e: Expected I, but got O
		//IL_07c0: Expected O, but got I
		//IL_07d0: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_0f83: Expected I, but got O
		//IL_04af: Expected I, but got O
		//IL_04b7: Expected I4, but got O
		//IL_07e1: Expected O, but got I
		//IL_097a: Expected O, but got I
		//IL_0992: Expected O, but got I
		//IL_09a2: Expected O, but got I
		//IL_09c4: Expected O, but got I4
		//IL_09ec: Expected O, but got I
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0526: Expected O, but got I4
		//IL_052b: Expected I, but got O
		//IL_054e: Expected I, but got O
		//IL_0fc8: Expected O, but got I
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Expected O, but got Unknown
		//IL_0ff4: Expected I, but got O
		//IL_1009: Expected I, but got O
		//IL_0830: Expected O, but got I
		//IL_0840: Expected O, but got I
		//IL_0862: Expected O, but got I4
		//IL_0a1c: Expected O, but got I4
		//IL_062b: Expected I4, but got O
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_0655: Expected O, but got I
		//IL_0666: Expected I, but got O
		//IL_0898: Expected O, but got I
		//IL_0689: Expected O, but got I
		//IL_06a7: Expected O, but got I
		//IL_0a4c: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
		AnimateFlipCards();
		IEnumerable<object> source = gameCardsSprite;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v69+E4]");
		object obj4;
		Func<object, bool> predicate;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v69+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v59+78]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v59+78]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v59+78]");
				Func<object, bool> func = (Func<object, bool>)0;
				obj6 = obj3;
				goto IL_0118;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v69+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v59+78]");
			Func<object, bool> func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v59+78]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v59+78]");
			predicate = (Func<object, bool>)0;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0118;
			}
		}
		goto IL_0d21;
		IL_05f3:
		GameCard[] array;
		object obj8 = array + 32;
		IEnumerable<object> enumerable = (IEnumerable<object>)((nint)0 + (nint)2672);
		object obj9 = 0;
		object obj10 = obj8;
		nint num;
		List<Card> list2;
		bool flag5;
		CardStatus cardStatus;
		ICollection<Card> collection;
		JackarooHand jackarooHand;
		IEnumerable<object> enumerable2;
		object obj16;
		IEnumerable<object> enumerable3;
		nint num2;
		bool flag12;
		CardStatus cardStatus2;
		GameCard[] array2;
		JackarooHand jackarooHand2;
		List<Card> list3;
		ICollection<Card> collection2;
		Func<object, bool> func3 = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X20_v12+v235 @ X28_v5*8]");
			Component component = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X20_v12+v235 @ X28_v5*8]");
			if ((nint)0 == 0)
			{
				break;
			}
			num = (nint)enumerable;
			List<Card> list = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X23_v8 (UnityEngine.Component)+28]");
			bool flag3 = ((List<object>)(object)list).Contains((object)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X20_v12+v235 @ X28_v5*8]");
			GameObject gameObject = ((Component)0).gameObject;
			object obj13;
			Func<object, bool> predicate2;
			ReadOnlyCollection<object> readOnlyCollection2;
			if (flag3)
			{
				bool flag4 = (object)gameObject == null;
				flag5 = flag3;
				cardStatus = CardStatus.InHand;
				if (flag4)
				{
					break;
				}
				gameObject.SetActive(value: true);
				ICollection<Card> playableCards2 = collection;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X20_v12+v235 @ X28_v5*8]");
				bool flag6 = ShouldDimCard(playableCards2, (GameCard)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X20_v12+v235 @ X28_v5*8]");
				((GameCard)0).IsDimmed = flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BE3]");
				array = (GameCard[])0;
				bool flag7 = jackarooHand._allowedMoves == null;
				num = unchecked((nint)null);
				flag5 = flag3;
				cardStatus = (flag6 ? CardStatus.Prepared : CardStatus.InHand);
				if (flag7)
				{
					break;
				}
				object obj11 = (nint)0 + (nint)2328;
				ReadOnlyCollection<object> readOnlyCollection = ((List<object>)(object)jackarooHand._allowedMoves).AsReadOnly();
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v36+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v36+B8]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32+88]");
					predicate2 = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32+88]");
					bool flag8 = (nint)0 == 0;
					object obj14 = !flag8;
					enumerable2 = readOnlyCollection;
					flag5 = flag3;
					if (obj14 == null)
					{
						readOnlyCollection2 = readOnlyCollection;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32+88]");
						Func<object, bool> func2 = (Func<object, bool>)0;
						goto IL_09fa;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					enumerable = (IEnumerable<object>)((nint)0 + (nint)2672);
					obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v36+B8]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32+88]");
					Func<object, bool> func2 = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32+88]");
					bool flag9 = (nint)0 == 0;
					object obj15 = !flag9;
					readOnlyCollection2 = readOnlyCollection;
					enumerable2 = readOnlyCollection;
					flag5 = flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32+88]");
					predicate2 = (Func<object, bool>)0;
					if (obj15 == null)
					{
						goto IL_09fa;
					}
				}
				goto IL_0fa1;
			}
			bool flag10 = (object)gameObject == null;
			flag5 = flag3;
			cardStatus = CardStatus.InHand;
			if (flag10)
			{
				break;
			}
			gameObject.SetActive(value: false);
			array = (GameCard[])obj16;
			obj9++;
			bool flag11 = obj9 < obj16;
			num = unchecked((nint)null);
			flag5 = flag3;
			cardStatus = CardStatus.InHand;
			if (flag11)
			{
				continue;
			}
			enumerable3 = enumerable2;
			num2 = unchecked((nint)null);
			flag12 = flag3;
			cardStatus2 = CardStatus.InHand;
			array2 = (GameCard[])obj16;
			jackarooHand2 = jackarooHand;
			list3 = list2;
			collection2 = collection;
			goto IL_0af3;
			IL_0fa1:
			bool flag13 = Enumerable.All(enumerable2, predicate2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X20_v12+v235 @ X28_v5*8]");
			((GameCard)0).IsHighlightedForDiscard = flag13;
			array = (GameCard[])obj16;
			obj9++;
			bool flag14 = obj9 >= obj16;
			num = unchecked((nint)null);
			cardStatus = (flag13 ? CardStatus.Prepared : CardStatus.InHand);
			enumerable3 = enumerable2;
			num2 = unchecked((nint)null);
			flag12 = flag5;
			cardStatus2 = (flag13 ? CardStatus.Prepared : CardStatus.InHand);
			array2 = (GameCard[])obj16;
			jackarooHand2 = jackarooHand;
			list3 = list2;
			collection2 = collection;
			if (!flag14)
			{
				continue;
			}
			goto IL_0af3;
			IL_09fa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v36+E4]");
			bool flag15 = (nint)0 == 0;
			object obj17 = !flag15;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v30+B8]");
				obj13 = 0;
			}
			flag5 = (byte)(int)obj13 != 0;
			object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)1992;
			func3..ctor(obj13, (IntPtr)obj20);
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v37+B8]");
			object obj22 = (nint)0 + (nint)136;
			obj22 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			enumerable = (IEnumerable<object>)((nint)0 + (nint)2672);
			enumerable2 = readOnlyCollection2;
			predicate2 = func3;
			obj10 = obj8;
			goto IL_0fa1;
		}
		goto IL_0577;
		IL_0577:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0585;
		IL_0af3:
		bool flag16 = jackarooHand2._organizer == null;
		enumerable2 = enumerable3;
		num = num2;
		flag5 = flag12;
		cardStatus = cardStatus2;
		array = array2;
		jackarooHand = jackarooHand2;
		list2 = list3;
		collection = collection2;
		if (!flag16)
		{
			object obj23 = (nint)0 + (nint)1224;
			cardStatus = (CardStatus)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389544");
			array = (GameCard[])(object)jackarooHand2.player;
			bool flag17 = jackarooHand2.player == null;
			enumerable2 = enumerable3;
			num = num2;
			flag5 = flag12;
			jackarooHand = jackarooHand2;
			list2 = list3;
			collection = collection2;
			if (!flag17)
			{
				GameCard gameCard = array[2];
				bool flag18 = (object)array[2] == null;
				enumerable2 = enumerable3;
				num = num2;
				flag5 = flag12;
				jackarooHand = jackarooHand2;
				list2 = list3;
				collection = collection2;
				if (!flag18)
				{
					bool flag19 = jackarooHand2._organizer == null;
					enumerable2 = enumerable3;
					num = num2;
					flag5 = flag12;
					jackarooHand = jackarooHand2;
					list2 = list3;
					collection = collection2;
					if (!flag19)
					{
						object obj24 = (nint)0 + (nint)1216;
						float num3 = ((UiCard)gameCard)._cardPositionY;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v17 (GameCard[])+10]");
						float num4 = num3 - 0f;
						bool flag20 = num4 == 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389E04");
						return;
					}
				}
			}
		}
		goto IL_0577;
		IL_0118:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v69+E4]");
		bool flag21 = (nint)0 == 0;
		object obj25 = !flag21;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v65+B8]");
			obj4 = 0;
		}
		object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)1976;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj4, (IntPtr)obj28);
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v64+B8]");
		object obj30 = (nint)0 + (nint)120;
		obj30 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func4;
		obj3 = obj6;
		goto IL_0d21;
		IL_0585:
		obj16 = array + 24;
		bool flag22 = array.Length < 1;
		enumerable3 = enumerable2;
		num2 = num;
		flag12 = flag5;
		cardStatus2 = cardStatus;
		array2 = array;
		jackarooHand2 = jackarooHand;
		list3 = list2;
		collection2 = collection;
		if (!flag22)
		{
			goto IL_05f3;
		}
		goto IL_0af3;
		IL_0cdd:
		throw new NullReferenceException();
		IL_0d21:
		IEnumerable<object> enumerable4 = Enumerable.Where(source, predicate);
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v8+E4]");
		bool flag23 = (nint)0 == 0;
		object obj32 = !flag23;
		enumerable2 = enumerable4;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj;
			enumerable2 = enumerable4;
		}
		flag5 = (byte)((nuint)0u + (nuint)3328u) != 0;
		object obj33 = (nint)0 + (nint)448;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v8+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v50+80]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v50+80]");
		bool flag24 = (nint)0 == 0;
		object obj35 = !flag24;
		Func<object, object> func5 = (Func<object, object>)obj4;
		collection = playableCards;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v8+E4]");
			bool flag25 = (nint)0 == 0;
			object obj36 = !flag25;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj37 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v56+B8]");
				obj34 = 0;
			}
			source = (IEnumerable<object>)obj34;
			object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj39 = (nint)0 + (nint)1984;
			Func<object, object> func6 = default(Func<object, object>);
			func6..ctor(obj34, (IntPtr)obj39);
			object obj40 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v55+B8]");
			object obj41 = (nint)0 + (nint)128;
			obj41 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func5 = func6;
			selector = func6;
			collection = playableCards;
		}
		IEnumerable<object> enumerable5 = Enumerable.Select(enumerable2, selector);
		num = (nint)obj33;
		bool flag26 = Enumerable.SequenceEqual(allCards, enumerable5);
		array = gameCardsSprite;
		if (flag26)
		{
			bool flag27 = gameCardsSprite == null;
			cardStatus = (CardStatus)enumerable5;
			jackarooHand = this;
			list2 = allCards;
			if (!flag27)
			{
				obj16 = gameCardsSprite + 24;
				if (allCards == null)
				{
					goto IL_0a96;
				}
				bool flag28 = array.Length >= 1;
				cardStatus = (CardStatus)enumerable5;
				jackarooHand = this;
				list2 = allCards;
				if (flag28)
				{
					goto IL_05f3;
				}
				enumerable3 = enumerable2;
				num2 = (nint)obj33;
				flag12 = flag5;
				cardStatus2 = (CardStatus)enumerable5;
				array2 = gameCardsSprite;
				jackarooHand2 = this;
				list3 = allCards;
				collection2 = collection;
				goto IL_0af3;
			}
		}
		else
		{
			bool flag29 = gameCardsSprite == null;
			UiCard uiCard = (UiCard)(object)func5;
			cardStatus = (CardStatus)enumerable5;
			jackarooHand = this;
			list2 = allCards;
			if (!flag29)
			{
				if (allCards != null)
				{
					obj33 = (nint)0 + (nint)2760;
					UiCard uiCard2 = (UiCard)(object)func5;
					nint num5 = (nint)obj33;
					CardStatus cardStatus3 = (CardStatus)enumerable5;
					IEnumerable<object> enumerable6 = null;
					GameCard[] array3 = gameCardsSprite;
					while (true)
					{
						bool flag30 = (nint)enumerable6 >= array3.Length;
						uiCard = uiCard2;
						num = num5;
						cardStatus = cardStatus3;
						source = enumerable6;
						array = array3;
						jackarooHand = this;
						list2 = allCards;
						if (flag30)
						{
							break;
						}
						object obj42 = (object)array3 + (object)enumerable6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v44+20]");
						uiCard = (UiCard)0;
						array = (GameCard[])allCards._size;
						Card card;
						if ((nint)enumerable6 < allCards._size)
						{
							num5 = (nint)obj33;
							object obj43 = ((List<object>)(object)allCards).get_Item((int)enumerable6);
							card = (Card)obj43;
						}
						else
						{
							card = null;
						}
						bool flag31 = (object)uiCard == null;
						num = num5;
						cardStatus = (CardStatus)card;
						source = enumerable6;
						jackarooHand = this;
						list2 = allCards;
						if (!flag31)
						{
							uiCard.Card = card;
							array = gameCardsSprite;
							bool flag32 = gameCardsSprite == null;
							num = unchecked((nint)null);
							cardStatus = (CardStatus)card;
							source = enumerable6;
							jackarooHand = this;
							list2 = allCards;
							if (!flag32)
							{
								bool flag33 = (nint)enumerable6 < array.Length;
								object obj44 = !flag33;
								if (obj44 != null)
								{
									goto IL_0ccf;
								}
								array = (GameCard[])(object)((object)array + (object)enumerable6);
								bool flag34 = (object)array[0] == null;
								num = unchecked((nint)null);
								cardStatus = (CardStatus)card;
								source = enumerable6;
								jackarooHand = this;
								list2 = allCards;
								if (!flag34)
								{
									array[0].SetStatus(CardStatus.InHand);
									source = (IEnumerable<object>)(enumerable6 + 1);
									array = gameCardsSprite;
									bool flag35 = gameCardsSprite == null;
									object obj45 = !flag35;
									num = unchecked((nint)null);
									cardStatus = CardStatus.InHand;
									jackarooHand = this;
									list2 = allCards;
									uiCard2 = uiCard;
									num5 = unchecked((nint)null);
									cardStatus3 = CardStatus.InHand;
									enumerable6 = source;
									array3 = gameCardsSprite;
									if (obj45 != null)
									{
										continue;
									}
								}
							}
						}
						goto IL_0577;
					}
					goto IL_0585;
				}
				obj16 = gameCardsSprite + 24;
				bool flag36 = (nint)obj16 >= 1;
				cardStatus = (CardStatus)enumerable5;
				jackarooHand = this;
				list2 = allCards;
				if (!flag36)
				{
					goto IL_0a96;
				}
			}
		}
		goto IL_0577;
		IL_0a96:
		bool flag37 = (nint)obj16 >= 1;
		enumerable3 = enumerable2;
		num2 = num;
		flag12 = flag5;
		cardStatus2 = (CardStatus)enumerable5;
		array2 = array;
		jackarooHand2 = this;
		list3 = allCards;
		collection2 = collection;
		if (!flag37)
		{
			goto IL_0af3;
		}
		goto IL_0cdd;
		IL_0ccf:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0cdd;
	}

	private static bool ShouldDimCard(ICollection<Card> playableCards, GameCard gameCard)
	{
		//IL_0115: Expected I4, but got O
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003e: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected I4, but got Unknown
		//IL_0089: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		if ((object)gameCard != null && playableCards != null)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1936;
			nint num = (nint)playableCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<Card>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<Card>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ca;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<Card>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v5-8]");
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
				goto IL_00ca;
			}
			object obj4 = obj3 + 4;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0156;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0156;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v167 @ X0_v3] (should have been resolved before IL gen)");
		object obj7 = default(object);
		return (byte)(obj7 ^ 1) != 0;
	}

	public override void DoPendingAction()
	{
	}

	private void GameStateHandleFireMode()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003e: Expected I, but got O
		CardGamePlayer cardGamePlayer = player;
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		object obj2 = (nint)0 + (nint)744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj2);
		if (Enumerable.Any(cardGamePlayer.<Cards>k__BackingField, func))
		{
			gameEventsChannel.TriggerEnableFireModeButton();
		}
		else
		{
			gameEventsChannel.TriggerDisableFireModeButton();
		}
	}

	private void EnableFireMode()
	{
		gameEventsChannel.TriggerActivateFirMode();
	}

	private void DisableFireMode()
	{
		gameEventsChannel.TriggerDeactivateFireMode();
	}

	private void EnableFireModeButton()
	{
		gameEventsChannel.TriggerEnableFireModeButton();
	}

	private void DisableFireModeButton()
	{
		gameEventsChannel.TriggerDisableFireModeButton();
	}

	protected override void OnActivateFireMode()
	{
		//IL_0010: Expected I, but got O
		//IL_0020: Expected O, but got I
		//IL_0030: Expected O, but got I
		base.IsFireModeActive = true;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v1 (Il2CppClass<JackarooHand>)+288]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v1 (Il2CppClass<JackarooHand>)+290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v15 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void OnDeactivateFireMode()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		base.IsFireModeActive = false;
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X22_v4+v37 @ X21_v5*8]");
				((GameCard)0).IsFireActive = false;
			}
			while ((nint)obj2 < array.Length);
		}
		DisablePriceTags();
	}

	private void DisablePriceTags()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00cb: Expected I, but got O
		//IL_00f4: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_0160: Expected O, but got I
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X23_v4+v66 @ X22_v5*8]");
				((GameCard)0).IsFireActive = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X23_v4+v66 @ X22_v5*8]");
				((GameCard)0).HidePriceTag();
			}
			while ((nint)obj2 < array.Length);
		}
		CardGameVisualControls cardGameVisualControls = gameVisualControls;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 152;
		object obj4 = obj3;
		nint num = (nint)cardGameVisualControls;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v4+130]");
		bool flag = num2 < 0;
		object obj5 = !flag;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X10_v2 (Il2CppClass<CardGameVisualControls>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v4+130]");
			object obj7 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v4-8]");
			if (0 == (nint)obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6 (CardGameVisualControls)+148]");
				((JackarooBoardMono)0).HidePMarblesPriceTags();
				return;
			}
		}
		throw new NullReferenceException();
	}

	private StoreItem GetItemStoreForAction(JackarooActions action)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Dictionary<JackarooActions, StoreItem> specialJackarooActions = _specialJackarooActions;
		if (_specialJackarooActions != null)
		{
			object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2336;
			nint num = (nint)specialJackarooActions;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v5-8]");
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
				goto IL_00ad;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0145;
		}
		return (StoreItem)(object)new NullReferenceException();
		IL_0145:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v3] (should have been resolved before IL gen)");
		StoreItem result = default(StoreItem);
		return result;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0145;
	}

	private StoreItem GetItemStoreForGameAction(GameAction gameAction)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Dictionary<GameAction, StoreItem> specialGameActions = _specialGameActions;
		if (_specialGameActions != null)
		{
			object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2328;
			nint num = (nint)specialGameActions;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<GameAction, StoreItem>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v5-8]");
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
				goto IL_00ad;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0145;
		}
		return (StoreItem)(object)new NullReferenceException();
		IL_0145:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X0_v3] (should have been resolved before IL gen)");
		StoreItem result = default(StoreItem);
		return result;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0145;
	}

	protected override void FetchSpecialPlayFromStore()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0061: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)712;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		gameEventsChannel.TriggerHideFireModeButton();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Store.CallWhenLoaded(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Store.CallWhenLoaded(action);
	}

	protected override void UpdatePriceTag()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_021f: Expected O, but got I
		//IL_0230: Expected I, but got O
		//IL_0241: Expected O, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0293: Expected O, but got I
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I
		//IL_02f9: Expected I, but got O
		//IL_030a: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_0363: Expected O, but got I4
		//IL_038a: Expected I4, but got O
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015f: Expected O, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_07ed: Expected O, but got I
		//IL_04e3: Expected O, but got I
		//IL_04f3: Expected O, but got I
		//IL_0515: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I4
		//IL_058f: Expected O, but got I
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_0473: Expected O, but got I
		//IL_0483: Expected O, but got I
		//IL_04a5: Expected O, but got I4
		//IL_04ae: Expected O, but got I4
		//IL_083a: Expected O, but got I4
		//IL_0185: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_054e: Expected O, but got I4
		//IL_06fb: Expected O, but got I4
		//IL_0607: Expected O, but got I4
		//IL_0866: Expected O, but got I
		//IL_0877: Expected I, but got O
		//IL_0895: Expected O, but got I
		//IL_08b0: Expected O, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03e0: Expected O, but got I
		//IL_03f9: Expected O, but got I4
		//IL_040b: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_0900: Expected O, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_065c: Expected O, but got I
		//IL_057e: Expected O, but got I
		//IL_0710: Expected I, but got O
		//IL_0720: Expected O, but got I
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_06c5: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		Card card = null;
		object obj8;
		object obj6 = default(object);
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			DisablePriceTags();
			if (!base._isFireModeActive)
			{
				return;
			}
			card = _playedCard;
			bool flag2 = _playedCard == null;
			object playedCard = _playedCard;
			if (flag2)
			{
				goto IL_01f5;
			}
			JackarooMove[] cardAllowedSpecialMoves = GetCardAllowedSpecialMoves(_playedCard);
			if (cardAllowedSpecialMoves != null)
			{
				bool flag3 = cardAllowedSpecialMoves.Length == 0;
				playedCard = _playedCard;
				if (flag3)
				{
					goto IL_01f5;
				}
				GameCard[] array = gameCardsSprite;
				if (gameCardsSprite != null)
				{
					bool flag4 = array.Length < 1;
					playedCard = _playedCard;
					if (flag4)
					{
						goto IL_01f5;
					}
					object obj4 = gameCardsSprite + 32;
					object obj5 = obj6;
					object obj7 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X24_v11+v96 @ X23_v12*8]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X24_v11+v96 @ X23_v12*8]");
						bool flag5 = (nint)0 == 0;
						obj6 = obj5;
						if (flag5)
						{
							break;
						}
						playedCard = _playedCard;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v8 (System.Object)+28]");
						bool flag6 = object.Equals(0, _playedCard);
						bool flag7 = !flag6;
						object obj9 = !flag7;
						if (obj9 == null)
						{
							obj7++;
							bool flag8 = (nint)obj7 < array.Length;
							obj6 = 0;
							obj5 = 0;
							card = _playedCard;
							if (flag8)
							{
								continue;
							}
							goto IL_01f5;
						}
						goto IL_06e0;
					}
				}
			}
		}
		goto IL_077b;
		IL_0789:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		throw new IndexOutOfRangeException();
		IL_06e0:
		IEnumerable<JackarooMove> allowedMovesForCard = GetAllowedMovesForCard(_playedCard);
		obj6 = 0;
		IEnumerable<object> source = allowedMovesForCard;
		goto IL_08bd;
		IL_08bd:
		List<object> allowedMovesForCards = Enumerable.ToList(source);
		object obj10 = typeof(TypeConverter<ushort, char>) + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		GameCard[] array2 = default(GameCard[]);
		bool flag9 = array2 == null;
		card = (Card)1;
		if (flag9)
		{
			goto IL_077b;
		}
		nint num = (nint)array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v11 (Il2CppClass<GameCard[]>)+40]");
		card = (Card)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		NullReferenceException ex2 = default(NullReferenceException);
		if (ex2 != null)
		{
			object obj11 = array2 + 32;
			obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ApplyFireMode((List<JackarooMove>)(object)allowedMovesForCards, array2);
			return;
		}
		goto IL_0789;
		IL_01f5:
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)2024;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)3536;
		IEnumerable<object> source2 = Enumerable.Where(_allowedMoves, func);
		List<object> list = Enumerable.ToList(source2);
		object obj15 = obj2 + 24;
		obj15 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = (nint)0 + (nint)2232;
		if (!Enumerable.Any((IEnumerable<object>)obj15))
		{
			return;
		}
		object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)2032;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj2, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)3448;
		obj6 = obj19;
		IEnumerable<object> source3 = Enumerable.Where(gameCardsSprite, func2);
		object obj20 = (nint)0 + (nint)1280;
		card = (Card)obj20;
		object[] array3 = Enumerable.ToArray(source3);
		bool flag10 = array3 == null;
		object obj21 = 0;
		if (!flag10)
		{
			bool flag11 = array3.Length < 1;
			bool flag12 = (byte)(int)obj20 != 0;
			if (flag11)
			{
				goto IL_0422;
			}
			object obj22 = array3 + 32;
			object obj23 = obj19;
			object obj24 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v18+v203 @ X21_v19*8]");
				bool flag13 = (nint)0 == 0;
				obj21 = 0;
				obj6 = obj23;
				if (flag13)
				{
					break;
				}
				obj24++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v18+v203 @ X21_v19*8]");
				((GameCard)0).IsFireActive = true;
				bool flag14 = (nint)obj24 < array3.Length;
				obj6 = 0;
				flag12 = true;
				obj23 = 0;
				card = (Card)1;
				if (flag14)
				{
					continue;
				}
				goto IL_0422;
			}
		}
		goto IL_077b;
		IL_077b:
		ex2 = new NullReferenceException();
		goto IL_0789;
		IL_0422:
		object obj25 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v57+E4]");
		object obj27;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v57+B8]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v40+90]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v40+90]");
			bool flag15 = (nint)0 == 0;
			object obj28 = !flag15;
			obj21 = 0;
			if (obj28 == null)
			{
				goto IL_052c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v57+B8]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v40+90]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v40+90]");
			bool flag16 = (nint)0 == 0;
			object obj29 = !flag16;
			obj21 = 0;
			if (obj29 == null)
			{
				goto IL_052c;
			}
		}
		goto IL_0583;
		IL_0583:
		object obj30 = (nint)0 + (nint)824;
		object obj31 = Enumerable.FirstOrDefault(gameCardsSprite, predicate);
		object obj32 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v46+E4]");
		if ((nint)0 != 0)
		{
			bool flag17 = (UnityEngine.Object)obj31 != null;
			bool flag18 = !flag17;
			object obj34 = !flag18;
			if (obj34 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!((UnityEngine.Object)obj31 != null))
			{
				return;
			}
		}
		object obj35 = (nint)0 + (nint)3200;
		obj6 = obj35;
		if (Enumerable.Contains(array3, obj31))
		{
			bool flag19 = obj31 == null;
			card = (Card)obj31;
			if (flag19)
			{
				goto IL_077b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v45 (System.Object)+28]");
			IEnumerable<JackarooMove> allowedMovesForCard2 = GetAllowedMovesForCard((Card)0);
			source = allowedMovesForCard2;
			obj8 = obj31;
			goto IL_08bd;
		}
		return;
		IL_052c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v57+E4]");
		bool flag20 = (nint)0 == 0;
		object obj36 = !flag20;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v44+B8]");
			obj27 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj38 = (nint)0 + (nint)2016;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj27, (IntPtr)obj38);
		object obj39 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v43+B8]");
		object obj40 = (nint)0 + (nint)144;
		obj40 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj21 = 0;
		predicate = func3;
		goto IL_0583;
	}

	private unsafe void ApplyFireMode(List<JackarooMove> allowedMovesForCards, GameCard[] specialGameCards)
	{
		//IL_1728: Expected I4, but got O
		//IL_1730: Expected I4, but got O
		//IL_005c: Expected I4, but got O
		//IL_008b: Expected I, but got O
		//IL_0140: Expected I, but got O
		//IL_0196: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0337: Expected O, but got I
		//IL_0348: Expected I, but got O
		//IL_0354: Expected O, but got I
		//IL_035c: Expected I4, but got O
		//IL_037e: Expected O, but got I
		//IL_0386: Expected I4, but got O
		//IL_03a7: Expected I, but got O
		//IL_04ef: Expected I, but got O
		//IL_0407: Expected I, but got O
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_053c: Expected O, but got I4
		//IL_0549: Expected I, but got O
		//IL_0551: Expected I4, but got O
		//IL_0559: Expected I4, but got O
		//IL_0cba: Expected O, but got I
		//IL_0644: Expected O, but got I
		//IL_175e: Expected I, but got O
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected O, but got Unknown
		//IL_0d94: Expected O, but got I
		//IL_0da4: Expected O, but got I
		//IL_0dc6: Expected O, but got I4
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0436: Expected I, but got O
		//IL_0446: Expected O, but got I
		//IL_0e5b: Expected O, but got I
		//IL_0e63: Expected I4, but got O
		//IL_0e79: Expected O, but got I
		//IL_0e81: Expected I4, but got O
		//IL_0d2d: Expected O, but got I
		//IL_0d3d: Expected O, but got I
		//IL_0d5f: Expected O, but got I4
		//IL_0de4: Expected O, but got I
		//IL_0e06: Expected O, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06ba: Expected I, but got O
		//IL_06ca: Expected O, but got I
		//IL_18dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e2: Expected O, but got Unknown
		//IL_18f8: Expected O, but got I
		//IL_1909: Expected I, but got O
		//IL_1918: Unknown result type (might be due to invalid IL or missing references)
		//IL_191d: Expected O, but got Unknown
		//IL_193b: Expected O, but got I
		//IL_195a: Expected I, but got O
		//IL_177c: Expected O, but got I
		//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0e4a: Expected O, but got I
		//IL_153a: Expected O, but got I4
		//IL_1542: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected O, but got Unknown
		//IL_1550: Unknown result type (might be due to invalid IL or missing references)
		//IL_1555: Expected O, but got Unknown
		//IL_198d: Expected O, but got I
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_185e: Expected O, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_14bf: Expected O, but got I4
		//IL_0778: Expected O, but got I4
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_19c3: Expected O, but got I
		//IL_19cb: Expected I4, but got O
		//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edf: Expected O, but got Unknown
		//IL_0ef1: Expected I4, but got O
		//IL_072e: Expected O, but got I
		//IL_1597: Expected O, but got I4
		//IL_0869: Expected O, but got I4
		//IL_0869: Expected O, but got I
		//IL_0893: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_08a5: Expected O, but got I4
		//IL_1640: Expected I4, but got O
		//IL_166e: Expected O, but got I4
		//IL_0f5e: Expected I4, but got O
		//IL_08f8: Expected O, but got I4
		//IL_0901: Expected O, but got I4
		//IL_090a: Expected O, but got I4
		//IL_16b6: Expected O, but got I4
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Expected O, but got Unknown
		//IL_1275: Expected O, but got I
		//IL_127d: Expected I4, but got O
		//IL_1022: Expected O, but got I4
		//IL_1697: Expected O, but got I4
		//IL_0945: Expected O, but got I
		//IL_0997: Expected O, but got I4
		//IL_09a0: Expected O, but got I4
		//IL_09a9: Expected O, but got I4
		//IL_1604: Expected O, but got I4
		//IL_1040: Expected I4, but got O
		//IL_0a00: Expected O, but got I4
		//IL_13d2: Expected I4, but got O
		//IL_13eb: Expected O, but got I
		//IL_1401: Expected O, but got I4
		//IL_0a8b: Expected O, but got I
		//IL_0a9b: Expected O, but got I
		//IL_0ac2: Expected O, but got I
		//IL_14a1: Expected O, but got I4
		//IL_0aeb: Expected O, but got I4
		//IL_0af4: Expected O, but got I4
		//IL_0afd: Expected O, but got I4
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected O, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected O, but got Unknown
		//IL_0a63: Expected O, but got I
		//IL_1418: Expected O, but got I4
		//IL_13bc: Expected O, but got I
		//IL_13c5: Expected O, but got I4
		//IL_196b: Expected O, but got I
		//IL_1973: Expected I4, but got O
		//IL_1305: Expected I4, but got O
		//IL_1330: Expected O, but got I4
		//IL_15dd: Expected O, but got I4
		//IL_0b2f: Expected O, but got I
		//IL_0b81: Expected O, but got I4
		//IL_0b8a: Expected O, but got I4
		//IL_0b93: Expected O, but got I4
		//IL_1623: Expected O, but got I4
		//IL_10e2: Expected O, but got I
		//IL_10ea: Expected I4, but got O
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Expected O, but got Unknown
		//IL_15b6: Expected O, but got I4
		//IL_15be: Expected I4, but got O
		//IL_0bd0: Expected O, but got I4
		//IL_0bf0: Expected O, but got I4
		//IL_114f: Expected I4, but got O
		//IL_056e: Expected O, but got I
		//IL_057e: Expected O, but got I
		//IL_05a6: Expected O, but got I4
		//IL_05af: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_05c0: Expected I4, but got O
		//IL_13a3: Expected I, but got O
		//IL_13ab: Expected I4, but got O
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected O, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected O, but got Unknown
		//IL_0c5e: Expected O, but got I4
		//IL_0c67: Expected O, but got I4
		//IL_0c70: Expected O, but got I4
		//IL_0c78: Expected I4, but got O
		//IL_118e: Expected O, but got I
		//IL_11b4: Expected O, but got I4
		//IL_0f7b: Expected O, but got I
		//IL_0f8b: Expected O, but got I
		//IL_0fb0: Expected I4, but got O
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f9: Expected O, but got Unknown
		//IL_1202: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected O, but got Unknown
		//IL_1221: Expected I4, but got O
		List<JackarooMarbleMono> specialMarbles = _specialMarbles;
		bool flag = _specialMarbles == null;
		int num = (int)allowedMovesForCards;
		int num2 = (int)specialGameCards;
		object obj;
		object obj2;
		object obj3;
		object[] array;
		object obj4;
		List<object>.Enumerator enumerator;
		List<object>.Enumerator enumerator2;
		object obj12;
		object obj13;
		object[] array2;
		StoreItem storeItem = default(StoreItem);
		object obj17 = default(object);
		int num6 = default(int);
		nint num3;
		if (!flag)
		{
			num2 = specialMarbles._size;
			int version = specialMarbles._version + 1;
			specialMarbles._size = 0;
			specialMarbles._version = version;
			bool flag2 = specialMarbles._size < 1;
			num = (int)allowedMovesForCards;
			if (!flag2)
			{
				Array.Clear(specialMarbles._items, 0, specialMarbles._size);
				num3 = unchecked((nint)null);
				num = 0;
			}
			List<StoreItem> specialItems = _specialItems;
			if (_specialItems != null)
			{
				num2 = specialItems._size;
				int version2 = specialItems._version + 1;
				specialItems._size = 0;
				specialItems._version = version2;
				if (specialItems._size >= 1)
				{
					Array.Clear(specialItems._items, 0, specialItems._size);
					num3 = unchecked((nint)null);
					num = 0;
				}
				if (specialGameCards != null)
				{
					if (specialGameCards.Length < 1)
					{
						return;
					}
					obj = (nint)0 + (nint)2248;
					obj2 = (nint)0 + (nint)2944;
					obj3 = (nint)0 + (nint)2776;
					array = (object[])(specialGameCards + 32);
					obj4 = (nint)0 + (nint)560;
					enumerator = (List<object>.Enumerator)0;
					enumerator2 = (List<object>.Enumerator)0;
					object obj5 = 0;
					object obj7 = default(object);
					Func<object, bool> func = default(Func<object, bool>);
					while (true)
					{
						object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 592;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj7..ctor();
						bool flag3 = (nint)obj5 < specialGameCards.Length;
						object obj8 = !flag3;
						num = 0;
						if (obj8 != null)
						{
							break;
						}
						bool flag4 = obj7 == null;
						num = 0;
						object obj9;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v11 (System.Object[])+v187 @ stack_-D8_v6*8]");
							num = 0;
							obj9 = obj7 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v11 (System.Object[])+v187 @ stack_-D8_v6*8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							if (obj9 != null)
							{
								((GameCard)obj9).IsFireActive = true;
								object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj11 = (nint)0 + (nint)2056;
								func..ctor(obj7, (IntPtr)obj11);
								obj12 = (nint)0 + (nint)3536;
								num2 = (int)obj12;
								IEnumerable<object> source = Enumerable.Where(allowedMovesForCards, func);
								obj13 = (nint)0 + (nint)1344;
								num = (int)obj13;
								array2 = Enumerable.ToArray(source);
								bool flag5 = array2 == null;
								num3 = unchecked((nint)null);
								if (!flag5)
								{
									if (array2.Length != 1)
									{
										goto IL_04d9;
									}
									object obj14 = array2[0];
									bool flag6 = array2[0] == null;
									num3 = unchecked((nint)null);
									if (!flag6)
									{
										Dictionary<JackarooActions, StoreItem> specialJackarooActions = _specialJackarooActions;
										bool flag7 = _specialJackarooActions == null;
										num3 = unchecked((nint)null);
										if (!flag7)
										{
											object obj15 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2336;
											nint num4 = (nint)specialJackarooActions;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v130 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
											object obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v130 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_04ca;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v130 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+B0]");
											int num5 = (int)((nint)0 + (nint)8);
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X10_v29 (System.Int32)-8]");
												obj17 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X10_v29 (System.Int32)-8]");
												if (0 == (nint)obj15)
												{
													break;
												}
												num6 = num5 + 16;
												obj16--;
												bool flag8 = (nint)obj16 != 1;
												num5 = num6;
												if (flag8)
												{
													continue;
												}
												goto IL_04ca;
											}
											object obj18 = ((int*)num5)->m_value + 1;
											object obj19 = num4 + obj18;
											object obj20 = obj19 + 312;
											num6 = num5;
											goto IL_17a0;
										}
									}
								}
							}
						}
						goto IL_16d8;
						IL_04ca:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						goto IL_17a0;
						IL_17a0:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v119+8]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1104 @ X0_v119] (should have been resolved before IL gen)");
						int num7 = StorePricing.EffectivePrice(storeItem);
						bool flag9 = obj9 == null;
						num = 0;
						num2 = (int)(&storeItem);
						if (!flag9)
						{
							((GameCard)obj9).ShowPriceTag(num7);
							num = num7;
							num2 = 0;
							object obj21 = obj5 + 1;
							bool flag10 = (nint)obj21 >= specialGameCards.Length;
							obj5 = obj21;
							if (!flag10)
							{
								continue;
							}
							return;
						}
						goto IL_16d8;
					}
					goto IL_16e6;
				}
			}
		}
		goto IL_16d8;
		IL_0e4f:
		object obj22 = (nint)0 + (nint)1936;
		num2 = (int)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C94D6C");
		object obj23 = (nint)0 + (nint)2720;
		num = (int)obj23;
		IEnumerable<object> source2 = default(IEnumerable<object>);
		List<object> list = Enumerable.ToList(source2);
		if (list == null)
		{
			goto IL_16d8;
		}
		List<object>.Enumerator enumerator3 = list.GetEnumerator();
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator4 = enumerator5;
		object obj24 = (nint)0 + (nint)1800;
		int num8;
		object[] array3;
		object obj28;
		object obj30;
		object obj43;
		object obj38;
		IndexOutOfRangeException ex2;
		if (enumerator2.MoveNext())
		{
			object obj25 = typeof(List<AdaptivePerformanceScaler>) + 1952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (int)obj;
			List<object> list2 = default(List<object>);
			list2..ctor();
			List<object> specialItems2 = (List<object>)(object)_specialItems;
			if (_specialItems == null)
			{
				goto IL_1585;
			}
			StoreItem storeItem2 = default(StoreItem);
			if (storeItem2 != null)
			{
				num8 = 0;
				int num9 = num;
				int num10 = (int)array3;
				int num11 = num2;
				while (true)
				{
					bool flag11 = num8 >= specialItems2._size;
					num = num9;
					array3 = (object[])num10;
					num2 = num11;
					if (flag11)
					{
						break;
					}
					num2 = (int)obj2;
					object obj26 = specialItems2.get_Item(num8);
					bool flag12 = obj26 == null;
					num = num8;
					if (!flag12)
					{
						num10 = storeItem2.<id>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X0_v73 (System.Object)+10]");
						bool flag13 = (nint)0 != storeItem2.<id>k__BackingField;
						num9 = num8;
						if (flag13)
						{
							goto IL_0fb5;
						}
						if (_specialMarbles != null)
						{
							object obj27 = (nint)0 + (nint)2296;
							num2 = (int)obj27;
							obj28 = ((List<object>)(object)_specialMarbles).get_Item(num8);
							if (list2 != null)
							{
								object obj29 = obj30;
								int version3 = list2._version + 1;
								list2._version = version3;
								num10 = (int)list2._items;
								if (list2._items != null)
								{
									num6 = list2._size;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ X9_v19 (System.Int32)+18]");
									obj17 = 0;
									int size = list2._size;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ X9_v19 (System.Int32)+18]");
									bool flag14 = (nint)size < (nint)0;
									object obj31 = !flag14;
									if (obj31 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ X8_v74+20]");
										object obj32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X8_v76+C0]");
										object obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1422 @ X8_v77+70]");
										num2 = 0;
										list2.AddWithResize(obj28);
										num9 = (int)obj28;
									}
									else
									{
										int size2 = list2._size + 1;
										list2._size = size2;
										object obj34 = list2._items + list2._size;
										object obj35 = obj34 + 32;
										obj35 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										num9 = (int)obj28;
									}
									goto IL_0fb5;
								}
							}
							goto IL_15a4;
						}
						goto IL_15cb;
					}
					goto IL_1685;
					IL_0fb5:
					num8++;
					specialItems2 = (List<object>)(object)_specialItems;
					bool flag15 = _specialItems == null;
					num11 = num2;
					num = num9;
					if (!flag15)
					{
						continue;
					}
					goto IL_1585;
				}
			}
			else if (specialItems2._size >= 1)
			{
				num2 = (int)obj2;
				object obj36 = ((List<object>)(object)_specialItems).get_Item(0);
				bool flag16 = obj36 == null;
				object obj37 = !flag16;
				num = 0;
				if (obj37 == null)
				{
					goto IL_1685;
				}
				NullReferenceException ex = new NullReferenceException();
				obj38 = 0;
				num = 0;
				ex2 = (IndexOutOfRangeException)(object)ex;
				goto IL_16f4;
			}
			object obj39 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj40 = (nint)0 + (nint)544;
			num = (int)obj40;
			HashSet<object> hashSet = default(HashSet<object>);
			hashSet..ctor();
			if (list2 != null)
			{
				List<object>.Enumerator enumerator6 = list2.GetEnumerator();
				List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
				if (hashSet != null)
				{
					List<object> list3 = default(List<object>);
					while (enumerator.MoveNext())
					{
						num2 = (int)obj4;
						bool flag17 = hashSet.Contains(storeItem2);
						bool flag18 = !flag17;
						object obj41 = !flag18;
						if (obj41 == null)
						{
							object obj42 = typeof(List<AdaptivePerformanceScaler>) + 1952;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							list3..ctor();
							CollectNearbyMarbles((JackarooMarbleMono)(object)storeItem2, (List<JackarooMarbleMono>)(object)list2, (HashSet<JackarooMarbleMono>)(object)hashSet, (List<JackarooMarbleMono>)(object)list3);
							GroupFireModeLabelForGroup((List<JackarooMarbleMono>)(object)list3, storeItem2);
							List<object> list4 = list3;
							num3 = (nint)hashSet;
							num2 = (int)storeItem2;
						}
					}
					obj30 = (nint)0 + (nint)2256;
					obj43 = 11;
				}
				else
				{
					num = (int)obj3;
					bool flag19 = enumerator.MoveNext();
					obj30 = (nint)0 + (nint)2256;
					bool flag20 = !flag19;
					object obj44 = !flag20;
					if (obj44 != null)
					{
						NullReferenceException ex3 = new NullReferenceException();
						obj38 = 0;
						enumerator4 = enumerator7;
						ex2 = (IndexOutOfRangeException)(object)ex3;
						goto IL_16f4;
					}
					obj43 = 11;
				}
				object obj45 = (nint)0 + (nint)2768;
				num = (int)obj45;
				enumerator.Dispose();
				OutOfMemoryException ex4 = new OutOfMemoryException();
				obj38 = 0;
				enumerator4 = enumerator7;
				ex2 = (IndexOutOfRangeException)(object)ex4;
			}
			else
			{
				NullReferenceException ex5 = new NullReferenceException();
				obj38 = 0;
				ex2 = (IndexOutOfRangeException)(object)ex5;
			}
			goto IL_16f4;
		}
		obj43 = 5;
		object obj46 = (nint)0 + (nint)1792;
		num = (int)obj46;
		enumerator2.Dispose();
		throw new OutOfMemoryException();
		IL_04d9:
		bool flag21 = array2.Length < 1;
		num3 = unchecked((nint)null);
		array3 = array;
		if (flag21)
		{
			goto IL_0c85;
		}
		object obj47 = array2 + 32;
		object obj48 = obj17;
		object obj50 = default(object);
		object obj49 = obj50;
		object obj52 = default(object);
		object obj51 = obj52;
		List<object>.Enumerator enumerator8 = enumerator4;
		object obj53 = 0;
		int num12 = num6;
		nint num13 = unchecked((nint)null);
		int num14 = (int)obj13;
		int num15 = (int)obj12;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v94+v144 @ X26_v20*8]");
			List<object> list4 = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v94+v144 @ X26_v20*8]");
			bool flag22 = (nint)0 == 0;
			obj50 = obj49;
			obj52 = obj51;
			enumerator4 = enumerator8;
			num3 = num13;
			num = num14;
			num2 = num15;
			if (flag22)
			{
				break;
			}
			Dictionary<JackarooActions, StoreItem> specialJackarooActions2 = _specialJackarooActions;
			bool flag23 = _specialJackarooActions == null;
			obj50 = obj49;
			obj52 = obj51;
			enumerator4 = enumerator8;
			num3 = num13;
			num = num14;
			num2 = num15;
			if (flag23)
			{
				break;
			}
			object obj54 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2336;
			nint num16 = (nint)specialJackarooActions2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v102 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
			array3 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v102 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0756;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v102 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+B0]");
			int num17 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X10_v23 (System.Int32)-8]");
				obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X10_v23 (System.Int32)-8]");
				if (0 == (nint)obj54)
				{
					break;
				}
				num12 = num17 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v102 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
				array3 = (object[])(-1);
				bool flag24 = (nint)array3 != 1;
				num17 = num12;
				if (flag24)
				{
					continue;
				}
				goto IL_0756;
			}
			array3 = (object[])(((int*)num17)->m_value + 1);
			object obj55 = num16 + array3;
			object obj56 = obj55 + 312;
			num12 = num17;
			goto IL_1882;
			IL_1882:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X0_v96+8]");
			num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1189 @ X0_v96] (should have been resolved before IL gen)");
			bool flag25 = storeItem == null;
			num14 = list4._size;
			num15 = (int)(&storeItem);
			if (!flag25)
			{
				object syncRoot = list4._syncRoot;
				bool flag26 = list4._syncRoot == null;
				num14 = list4._size;
				num15 = (int)(&storeItem);
				if (!flag26)
				{
					int num18 = StorePricing.EffectivePrice(storeItem);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v105 (System.Object)+18]");
					bool flag27 = (nint)0 == 0;
					obj50 = obj49;
					obj52 = obj51;
					enumerator4 = enumerator8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X0_v96+8]");
					num3 = 0;
					num = 0;
					num2 = (int)(&storeItem);
					if (flag27)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v105 (System.Object)+18]");
					((JackarooMarbleMono)0).ShowFireMode(num18, (Vector3)0);
					object syncRoot2 = list4._syncRoot;
					bool flag28 = list4._syncRoot == null;
					obj50 = 0;
					obj52 = 0;
					enumerator4 = (List<object>.Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X0_v96+8]");
					num3 = 0;
					num = num18;
					num2 = 0;
					if (flag28)
					{
						break;
					}
					List<object> specialMarbles2 = (List<object>)(object)_specialMarbles;
					bool flag29 = _specialMarbles == null;
					obj50 = 0;
					obj52 = 0;
					enumerator4 = (List<object>.Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X0_v96+8]");
					num3 = 0;
					num = num18;
					num2 = 0;
					if (flag29)
					{
						break;
					}
					object obj57 = (nint)0 + (nint)2256;
					object obj58 = obj57;
					int version4 = specialMarbles2._version + 1;
					specialMarbles2._version = version4;
					object[] items = specialMarbles2._items;
					bool flag30 = specialMarbles2._items == null;
					obj50 = 0;
					obj52 = 0;
					enumerator4 = (List<object>.Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X0_v96+8]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v106 (System.Object)+18]");
					num = 0;
					num2 = 0;
					if (flag30)
					{
						break;
					}
					bool flag31 = specialMarbles2._size < items.Length;
					object obj59 = !flag31;
					if (obj59 == null)
					{
						int size3 = specialMarbles2._size + 1;
						specialMarbles2._size = size3;
						object obj60 = specialMarbles2._items + specialMarbles2._size;
						object obj61 = obj60 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v106 (System.Object)+18]");
						obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						num2 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v109+20]");
						object obj62 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v117+C0]");
						object obj63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X8_v118+70]");
						num2 = 0;
						List<JackarooMarbleMono> specialMarbles3 = _specialMarbles;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v106 (System.Object)+18]");
						((List<object>)(object)specialMarbles3).AddWithResize((object)0);
					}
					List<object> specialItems3 = (List<object>)(object)_specialItems;
					bool flag32 = _specialItems == null;
					obj50 = 0;
					obj52 = 0;
					enumerator4 = (List<object>.Enumerator)0;
					num3 = num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v106 (System.Object)+18]");
					num = 0;
					if (flag32)
					{
						break;
					}
					object obj64 = (nint)0 + (nint)2872;
					object obj65 = obj64;
					int version5 = specialItems3._version + 1;
					specialItems3._version = version5;
					array3 = specialItems3._items;
					bool flag33 = specialItems3._items == null;
					obj50 = 0;
					obj52 = 0;
					enumerator4 = (List<object>.Enumerator)0;
					num3 = num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v106 (System.Object)+18]");
					num = 0;
					if (flag33)
					{
						break;
					}
					num12 = specialItems3._size;
					obj48 = array3.Length;
					bool flag34 = specialItems3._size < array3.Length;
					object obj66 = !flag34;
					if (obj66 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v113+20]");
						object obj67 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ X8_v115+C0]");
						object obj68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X8_v116+70]");
						num15 = 0;
						((List<object>)(object)_specialItems).AddWithResize((object)storeItem);
						obj49 = 0;
						obj51 = 0;
						enumerator8 = (List<object>.Enumerator)0;
						num14 = (int)storeItem;
					}
					else
					{
						int size4 = specialItems3._size + 1;
						specialItems3._size = size4;
						object obj69 = specialItems3._items + specialItems3._size;
						object obj70 = obj69 + 32;
						obj70 = storeItem;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj49 = 0;
						obj51 = 0;
						enumerator8 = (List<object>.Enumerator)0;
						num14 = (int)storeItem;
						num15 = num2;
					}
				}
			}
			obj53++;
			bool flag35 = (nint)obj53 >= array2.Length;
			obj17 = obj48;
			obj50 = obj49;
			obj52 = obj51;
			enumerator4 = enumerator8;
			num6 = num12;
			num3 = num13;
			num = num14;
			num2 = num15;
			if (!flag35)
			{
				continue;
			}
			goto IL_0c85;
			IL_0756:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_1882;
		}
		goto IL_16d8;
		IL_16d8:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_16e6;
		IL_0dd4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v84+E4]");
		array3 = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v84+E4]");
		bool flag36 = (nint)0 == 0;
		object obj71 = !flag36;
		object obj74;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj72 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			object obj73 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X8_v90+B8]");
			obj74 = 0;
		}
		object obj75 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj76 = (nint)0 + (nint)1864;
		Func<object, int> func2 = default(Func<object, int>);
		func2..ctor(obj74, (IntPtr)obj76);
		object obj77 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
		object obj78 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X8_v87+B8]");
		object obj79 = (nint)0 + (nint)152;
		obj79 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, int> func3 = func2;
		num3 = unchecked((nint)null);
		goto IL_0e4f;
		IL_15a4:
		NullReferenceException ex7 = new NullReferenceException();
		obj38 = 0;
		num = (int)obj28;
		ex2 = (IndexOutOfRangeException)(object)ex7;
		goto IL_16f4;
		IL_15cb:
		NullReferenceException ex8 = new NullReferenceException();
		obj38 = 0;
		num = num8;
		ex2 = (IndexOutOfRangeException)(object)ex8;
		goto IL_16f4;
		IL_1585:
		NullReferenceException ex9 = new NullReferenceException();
		obj38 = 0;
		ex2 = (IndexOutOfRangeException)(object)ex9;
		goto IL_16f4;
		IL_16f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238594");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_16e6:
		ex2 = new IndexOutOfRangeException();
		goto IL_16f4;
		IL_0c85:
		List<JackarooMarbleMono> specialMarbles4 = _specialMarbles;
		if (_specialMarbles != null)
		{
			obj30 = (nint)0 + (nint)2256;
			if (specialMarbles4._size < 2)
			{
				return;
			}
			object obj80 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			object obj81 = obj80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v84+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v84+B8]");
				obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v80+98]");
				func3 = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v80+98]");
				bool flag37 = (nint)0 == 0;
				object obj82 = !flag37;
				if (obj82 == null)
				{
					goto IL_0dd4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj81 = obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v84+B8]");
				obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v80+98]");
				func3 = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v80+98]");
				bool flag38 = (nint)0 == 0;
				object obj83 = !flag38;
				if (obj83 == null)
				{
					goto IL_0dd4;
				}
			}
			goto IL_0e4f;
		}
		goto IL_16d8;
		IL_1685:
		NullReferenceException ex10 = new NullReferenceException();
		obj38 = 0;
		ex2 = (IndexOutOfRangeException)(object)ex10;
		goto IL_16f4;
	}

	private void CollectNearbyMarbles(JackarooMarbleMono current, List<JackarooMarbleMono> candidates, HashSet<JackarooMarbleMono> visited, List<JackarooMarbleMono> group)
	{
		//IL_0577: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_005b: Expected O, but got I4
		//IL_0512: Expected O, but got I
		//IL_007d: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0187: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_03fe: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_0436: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_04c0: Expected O, but got I4
		//IL_02f4: Expected O, but got I
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0381: Invalid comparison between O and F4
		//IL_0392: Expected O, but got I4
		//IL_03aa: Invalid comparison between F4 and I4
		//IL_03bb: Expected O, but got I4
		HashSet<JackarooMarbleMono> hashSet = default(HashSet<JackarooMarbleMono>);
		bool flag = hashSet == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj = current;
		List<JackarooMarbleMono> list = candidates;
		object obj11 = default(object);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator3;
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)552;
			list = (List<JackarooMarbleMono>)obj2;
			if (!((HashSet<object>)(object)hashSet).Add((object)current))
			{
				return;
			}
			List<JackarooMarbleMono> list2 = default(List<JackarooMarbleMono>);
			bool flag2 = list2 == null;
			enumerator = (List<object>.Enumerator)0;
			obj = current;
			if (!flag2)
			{
				object obj3 = (nint)0 + (nint)2256;
				object obj4 = obj3;
				int version = list2._version + 1;
				list2._version = version;
				JackarooMarbleMono[] items = list2._items;
				bool flag3 = list2._items == null;
				enumerator = (List<object>.Enumerator)0;
				obj = current;
				if (!flag3)
				{
					bool flag4 = list2._size < items.Length;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						int size = list2._size + 1;
						list2._size = size;
						object obj6 = list2._items + list2._size;
						object obj7 = obj6 + 32;
						obj7 = current;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj = current;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v12+20]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v21+C0]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v22+70]");
						list = (List<JackarooMarbleMono>)0;
						((List<object>)(object)list2).AddWithResize((object)current);
						obj = current;
					}
					bool flag5 = candidates == null;
					enumerator = (List<object>.Enumerator)0;
					if (!flag5)
					{
						List<object>.Enumerator enumerator2 = ((List<object>)(object)candidates).GetEnumerator();
						List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
						if ((object)current != null)
						{
							object obj10 = (nint)0 + (nint)560;
							enumerator3 = enumerator4;
							float num2 = default(float);
							object obj14 = default(object);
							while (enumerator5.MoveNext())
							{
								list = (List<JackarooMarbleMono>)obj10;
								bool flag6 = ((HashSet<object>)(object)hashSet).Contains(obj11);
								bool flag7 = !flag6;
								object obj12 = !flag7;
								if (obj12 != null)
								{
									continue;
								}
								if ((object)current.<Transform>k__BackingField == null)
								{
									goto IL_0472;
								}
								Vector3 position = current.<Transform>k__BackingField.position;
								if (obj11 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ stack_-98 (System.Object)+30]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ stack_-98 (System.Object)+30]");
										Vector3 position2 = ((Transform)0).position;
										object obj13 = (object)enumerator3 - (object)enumerator3;
										float num = num2 - num2;
										obj14 -= obj14;
										object obj15 = obj13 * obj13;
										float num3 = num * num;
										float num4 = (float)obj15 + num3;
										object obj16 = obj14 * obj14;
										enumerator3 = (List<object>.Enumerator)(obj16 + num4);
										num2 = _checkRadius * _checkRadius;
										bool flag8 = enumerator3 < (object)num2;
										object obj17 = !flag8;
										float num5 = (float)enumerator3 - num2;
										bool flag9 = num5 == 0f;
										object obj18 = !flag9;
										object obj19 = obj17 & obj18;
										if (obj19 == null)
										{
											CollectNearbyMarbles((JackarooMarbleMono)obj11, candidates, hashSet, list2);
										}
										continue;
									}
									goto IL_0488;
								}
								goto IL_049b;
							}
						}
						else
						{
							object obj20 = (nint)0 + (nint)560;
							while (enumerator5.MoveNext())
							{
								list = (List<JackarooMarbleMono>)obj20;
								bool flag10 = ((HashSet<object>)(object)hashSet).Contains(obj11);
								bool flag11 = !flag10;
								object obj21 = !flag11;
								if (obj21 != null)
								{
									continue;
								}
								goto IL_0444;
							}
						}
						enumerator5.Dispose();
						return;
					}
				}
			}
		}
		goto IL_0595;
		IL_04ae:
		enumerator = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_0595;
		IL_0472:
		NullReferenceException ex = new NullReferenceException();
		obj = obj11;
		goto IL_04ae;
		IL_049b:
		NullReferenceException ex2 = new NullReferenceException();
		obj = null;
		goto IL_04ae;
		IL_0488:
		NullReferenceException ex3 = new NullReferenceException();
		obj = null;
		goto IL_04ae;
		IL_0595:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag12 = (nint)obj != 1;
		NullReferenceException ex5 = ex4;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj22 = (nint)0 + (nint)2768;
			obj = obj22;
			enumerator.Dispose();
			object obj23 = default(object);
			if (obj23 == null)
			{
				return;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj23;
			ex5 = (NullReferenceException)(object)ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0444:
		NullReferenceException ex7 = new NullReferenceException();
		enumerator3 = enumerator4;
		obj = obj11;
		goto IL_04ae;
	}

	private void GroupFireModeLabelForGroup(List<JackarooMarbleMono> group, StoreItem item)
	{
		//IL_0456: Expected O, but got I4
		//IL_045e: Expected I4, but got O
		//IL_0013: Expected O, but got I
		//IL_001f: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_004d: Expected O, but got I8
		//IL_047c: Expected I4, but got O
		//IL_01a5: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_03c5: Expected I4, but got O
		//IL_033b: Expected O, but got I4
		//IL_0232: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		bool flag = group == null;
		StoreItem storeItem = item;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		int num = (int)group;
		List<JackarooMarbleMono> list = group;
		object obj2 = default(object);
		object obj3 = default(object);
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2776;
			obj2 = (nint)0 + (nint)2296;
			obj3 = (nint)0 + (nint)2768;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)group).GetEnumerator();
			storeItem = item;
			object obj4 = 4286578688L;
			JackarooMarbleMono jackarooMarbleMono = default(JackarooMarbleMono);
			object obj5 = default(object);
			while (true)
			{
				num = (int)obj;
				if (!enumerator.MoveNext())
				{
					break;
				}
				if ((object)jackarooMarbleMono == null)
				{
					goto IL_02e2;
				}
				jackarooMarbleMono.HideFireMode(onlyLabel: true);
				if ((object)jackarooMarbleMono.<Transform>k__BackingField == null)
				{
					goto IL_0313;
				}
				Vector3 position = jackarooMarbleMono.<Transform>k__BackingField.position;
				if ((object)jackarooMarbleMono.<Transform>k__BackingField == null)
				{
					goto IL_02a3;
				}
				Vector3 position2 = jackarooMarbleMono.<Transform>k__BackingField.position;
				bool flag2 = obj5 <= obj4;
				storeItem = null;
				if (flag2)
				{
					continue;
				}
				bool flag3 = (object)jackarooMarbleMono.<Transform>k__BackingField == null;
				storeItem = null;
				enumerator = enumerator3;
				enumerator4 = enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				num = 0;
				list = group;
				if (!flag3)
				{
					Vector3 position3 = jackarooMarbleMono.<Transform>k__BackingField.position;
					storeItem = null;
					obj4 = obj5;
					continue;
				}
				goto IL_0360;
			}
			enumerator.Dispose();
			enumerator = enumerator3;
			enumerator4 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
			list = group;
			goto IL_01b3;
		}
		goto IL_0352;
		IL_037c:
		bool flag4 = num != 1;
		NullReferenceException ex2;
		OutOfMemoryException ex = (OutOfMemoryException)(object)ex2;
		List<object>.Enumerator enumerator5;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj3;
			enumerator5.Dispose();
			object obj6 = default(object);
			bool flag5 = obj6 == null;
			enumerator = enumerator5;
			enumerator3 = (List<object>.Enumerator)obj6;
			if (flag5)
			{
				goto IL_01b3;
			}
			ex = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_02a3:
		ex2 = new NullReferenceException();
		storeItem = null;
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		num = 0;
		list = group;
		goto IL_037c;
		IL_0360:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator;
		goto IL_037c;
		IL_01b3:
		storeItem = (StoreItem)obj2;
		object obj7 = ((List<object>)(object)list).get_Item(0);
		bool flag6 = obj7 == null;
		num = 0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v20 (System.Object)+30]");
			bool flag7 = (nint)0 == 0;
			num = 0;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v20 (System.Object)+30]");
				Vector3 position4 = ((Transform)0).position;
				storeItem = (StoreItem)obj2;
				object obj8 = ((List<object>)(object)list).get_Item(0);
				int fireModePrice = StorePricing.EffectivePrice(item);
				bool flag8 = obj8 == null;
				num = 0;
				list = (List<JackarooMarbleMono>)obj8;
				if (!flag8)
				{
					((JackarooMarbleMono)obj8).ShowFireMode(fireModePrice, (Vector3)0);
					return;
				}
			}
		}
		goto IL_0352;
		IL_02e2:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		list = group;
		goto IL_037c;
		IL_0352:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0360;
		IL_0313:
		ex2 = new NullReferenceException();
		storeItem = null;
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		num = 1;
		list = group;
		goto IL_037c;
	}

	private GameAction? GetFireModeGameActionForAction(JackarooActions action)
	{
		//IL_0016: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_0059: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c5: Expected I, but got O
		//IL_00d5: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0263: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BED]");
		object obj = (nint)0 & (nint)1;
		nint num;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BEA]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BEA]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BEA]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BEA]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0076;
			}
		}
		_ = 1;
		Dictionary<JackarooActions, StoreItem> specialJackarooActions = _specialJackarooActions;
		bool flag2 = _specialJackarooActions == null;
		object obj5 = !flag2;
		num = 1;
		Dictionary<JackarooActions, StoreItem> specialJackarooActions2 = _specialJackarooActions;
		if (obj5 != null)
		{
			goto IL_00a9;
		}
		goto IL_0201;
		IL_028f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X0_v1] (should have been resolved before IL gen)");
		object obj6 = default(object);
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-38_v2+84]");
			System.Int32Enum? result = (System.Int32Enum)0;
			return (GameAction?)result;
		}
		return (GameAction?)(object)0;
		IL_0151:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_028f;
		IL_00a9:
		object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2336;
		num = (nint)specialJackarooActions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0151;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<Jackaroo.JackarooActions, StoreItem>>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X10_v2-8]");
			bool flag3 = 0 == (nint)obj7;
			specialJackarooActions2 = specialJackarooActions;
			if (flag3)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0151;
		}
		object obj10 = obj9 + 1;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		specialJackarooActions = specialJackarooActions2;
		goto IL_028f;
		IL_0076:
		specialJackarooActions = _specialJackarooActions;
		bool flag4 = _specialJackarooActions == null;
		specialJackarooActions2 = _specialJackarooActions;
		if (!flag4)
		{
			goto IL_00a9;
		}
		goto IL_0201;
		IL_0201:
		throw new NullReferenceException();
	}

	private GameAction? GetGameActionForAction(JackarooActions action)
	{
		//IL_0196: Expected I4, but got I8
		//IL_01b3: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_0184: Expected I4, but got I8
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004e: Expected I, but got O
		//IL_0077: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_01a8: Expected I4, but got I8
		System.Int32Enum value;
		if (action != JackarooActions.BURN_MY_CARD)
		{
			if (action == JackarooActions.STEAL)
			{
				JackarooGame jackarooGame = (JackarooGame)game;
				if ((object)game != null)
				{
					object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
					object obj2 = obj;
					nint num = (nint)jackarooGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X9_v6 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+130]");
					bool flag = num2 < 0;
					object obj3 = !flag;
					object obj4 = ~obj3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X9_v6 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+130]");
						object obj5 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v8-8]");
						if (0 == (nint)obj2)
						{
							JackarooPlayer getNextToMyPlayer = ((JackarooGame)game).GetNextToMyPlayer;
							if (getNextToMyPlayer != null)
							{
								List<Card> <Cards>k__BackingField = ((CardGamePlayer)getNextToMyPlayer).<Cards>k__BackingField;
								if (((CardGamePlayer)getNextToMyPlayer).<Cards>k__BackingField != null)
								{
									if (<Cards>k__BackingField._size != 0)
									{
										goto IL_014f;
									}
									value = (System.Int32Enum)(-3);
									goto IL_0207;
								}
							}
						}
					}
				}
				return (GameAction?)new NullReferenceException();
			}
			goto IL_014f;
		}
		value = (System.Int32Enum)(-1);
		goto IL_0207;
		IL_01ad:
		return (GameAction?)(object)0;
		IL_014f:
		bool flag2 = !_wasStealing;
		System.Int32Enum? int32Enum = (System.Int32Enum?)(object)0;
		if (flag2)
		{
			goto IL_01ad;
		}
		value = (System.Int32Enum)(-2);
		goto IL_0207;
		IL_0207:
		int32Enum = value;
		goto IL_01ad;
	}

	private bool DoesCardHasAllowedSpecialMove(Card card)
	{
		//IL_005a: Expected I4, but got O
		JackarooMove[] cardAllowedSpecialMoves = GetCardAllowedSpecialMoves(card);
		if (cardAllowedSpecialMoves != null)
		{
			bool flag = cardAllowedSpecialMoves.Length == 0;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private JackarooMove[] GetCardAllowedSpecialMoves(Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_0580: Expected O, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05a0: Expected O, but got I
		//IL_05ac: Expected O, but got I
		//IL_05bd: Expected O, but got I
		//IL_05cd: Expected O, but got I
		//IL_05ef: Expected O, but got I4
		//IL_0691: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_0141: Expected I, but got O
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0627: Expected O, but got I
		//IL_0638: Expected I, but got O
		//IL_0656: Expected O, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_0293: Expected O, but got I
		//IL_02ab: Expected O, but got I
		//IL_0410: Expected O, but got I
		//IL_0420: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_045e: Expected O, but got I4
		//IL_046e: Expected O, but got I
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_01ff: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_0227: Expected I, but got O
		//IL_02e0: Expected O, but got I
		//IL_02f6: Expected O, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_04d0: Expected O, but got I
		//IL_04e0: Expected O, but got I
		//IL_04f6: Expected O, but got I
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I4
		//IL_025f: Expected I, but got O
		//IL_0366: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_038c: Expected O, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03b4: Expected O, but got I4
		//IL_03c4: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_0531: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 560;
			object obj4 = obj2 + 24;
			obj4 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
			}
			object obj7 = (nint)0 + (nint)2760;
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2064;
			object obj9 = (nint)0 + (nint)2064;
			object obj10 = (nint)0 + (nint)3528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v32+A0]");
			Func<KeyValuePair<System.Int32Enum, object>, System.Int32Enum> selector = (Func<KeyValuePair<System.Int32Enum, object>, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v32+A0]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj14 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v38+B8]");
					obj11 = 0;
				}
				object obj15 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj16 = (nint)0 + (nint)1912;
				Func<KeyValuePair<System.Int32Enum, object>, System.Int32Enum> func = default(Func<KeyValuePair<System.Int32Enum, object>, System.Int32Enum>);
				func..ctor(obj11, (IntPtr)obj16);
				object obj17 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v37+B8]");
				object obj18 = (nint)0 + (nint)160;
				obj18 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<System.Int32Enum> source = Enumerable.Select((IEnumerable<KeyValuePair<System.Int32Enum, object>>)_specialJackarooActions, selector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+18]");
			JackarooActions jackarooActions = JackarooCardsMapper.GetJackarooActions((Card)0);
			List<JackarooActions> list = JackarooActionsExtensions.ToList(jackarooActions);
			object obj19 = obj2 + 16;
			obj19 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<System.Int32Enum, bool> func2 = default(Func<System.Int32Enum, bool>);
			func2..ctor(obj2, (IntPtr)obj9);
			IEnumerable<System.Int32Enum> source2 = Enumerable.Where(source, func2);
			List<System.Int32Enum> list2 = Enumerable.ToList(source2);
			object obj20 = obj2 + 32;
			obj20 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj21 = obj20;
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+18]");
				if ((nint)0 != 0)
				{
					object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2096;
					object obj23 = (nint)0 + (nint)2072;
					object obj24 = (nint)0 + (nint)3536;
					object obj25 = (nint)0 + (nint)2080;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func3 = default(Func<object, bool>);
					func3..ctor(obj2, (IntPtr)obj23);
					IEnumerable<object> source3 = Enumerable.Where(_allowedMoves, func3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func4 = default(Func<object, bool>);
					func4..ctor(obj2, (IntPtr)obj25);
					IEnumerable<object> source4 = Enumerable.Where(source3, func4);
					return (JackarooMove[])Enumerable.ToArray(source4);
				}
				object obj26 = (nint)0 + (nint)3184;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X19_v2+38]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X19_v2+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v11+10]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v11+10]");
					object obj30 = (nint)0 + (nint)309;
					object obj31 = obj30 & 1;
					bool flag4 = obj31 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v11+10]");
					object obj32 = 0;
					if (!flag4)
					{
						goto IL_0331;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X19_v2+38]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+10]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+10]");
					object obj34 = (nint)0 + (nint)309;
					object obj35 = obj34 & 1;
					bool flag5 = obj35 == null;
					object obj36 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v18+10]");
					object obj32 = 0;
					if (obj36 != null)
					{
						goto IL_0331;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v27+E4]");
				bool flag6 = (nint)0 == 0;
				object obj37 = !flag6;
				if (obj37 != null)
				{
					goto IL_0356;
				}
				goto IL_04b6;
			}
		}
		return (JackarooMove[])(object)new NullReferenceException();
		IL_04b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X19_v2+38]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13+10]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13+10]");
		object obj40 = (nint)0 + (nint)309;
		object obj41 = obj40 & 1;
		if (obj41 == null)
		{
			goto IL_03d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13+10]");
		object obj42 = 0;
		goto IL_03e1;
		IL_0331:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0356;
		}
		goto IL_04b6;
		IL_03d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_03e1;
		IL_03e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v35+B8]");
		return (JackarooMove[])0;
		IL_0356:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X19_v2+38]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v25+10]");
		obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v25+10]");
		object obj44 = (nint)0 + (nint)309;
		object obj45 = obj44 & 1;
		bool flag7 = obj45 == null;
		object obj46 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v25+10]");
		obj42 = 0;
		if (obj46 == null)
		{
			goto IL_03d2;
		}
		goto IL_03e1;
	}

	public JackarooHand()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_01ea: Expected F4, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1968;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1960;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1728;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 600;
		object obj5 = typeof(List<AdaptivePerformanceScaler>) + 1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253720]");
		_checkRadius = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj6 = this + 248;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		_selectedMovesByCard = (List<JackarooMove>)(object)list;
		object obj8 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		_allowedMoves = (List<JackarooMove>)(object)list2;
		object obj9 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		_specialJackarooActions = (Dictionary<JackarooActions, StoreItem>)(object)dictionary;
		object obj10 = this + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary2 = default(Dictionary<System.Int32Enum, object>);
		dictionary2..ctor();
		_specialGameActions = (Dictionary<GameAction, StoreItem>)(object)dictionary2;
		object obj11 = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		_specialMarbles = (List<JackarooMarbleMono>)(object)list3;
		object obj12 = this + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = typeof(List<AdaptivePerformanceScaler>) + 3592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor();
		_specialItems = (List<StoreItem>)(object)list4;
		object obj14 = this + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <SelectMarble>b__44_0()
	{
		<playingStage>k__BackingField = JackarooPlayingStage.SelectingMarble;
	}

	private void <OnGameStatusUpdate>b__67_0()
	{
		//IL_0046: Expected O, but got I4
		GetAllowedMoves();
		base.CardClicked(_playedCard, clickedByUser: true);
		ReadOnlyCollection<object> allowedMoves = ((List<object>)(object)_allowedMoves).AsReadOnly();
		HandleMarblePlay((IReadOnlyList<JackarooMove>)allowedMoves, playCard: false, _playedCard, (GameAction?)(object)0);
	}

	private void <OnGameStatusUpdate>b__67_1()
	{
		GetAllowedMoves();
		GameStateHandleFireMode();
	}

	private unsafe void <FetchSpecialPlayFromStore>b__100_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_0248: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_0303: Expected O, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_0344: Expected O, but got Ref
		//IL_02d0: Expected O, but got I
		//IL_04fb: Expected I, but got O
		//IL_051e: Expected O, but got I4
		//IL_0527: Expected O, but got I4
		//IL_0530: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_035a: Expected I, but got O
		//IL_0383: Expected O, but got I
		//IL_03a5: Expected O, but got I4
		//IL_03e6: Expected O, but got Ref
		//IL_0425: Expected O, but got Ref
		//IL_0437: Expected O, but got I4
		//IL_043c: Expected I, but got O
		//IL_0455: Expected O, but got I4
		//IL_045e: Expected O, but got I4
		//IL_05b2: Expected I, but got O
		//IL_078c: Expected I, but got O
		//IL_0478: Expected O, but got I
		//IL_0480: Expected I, but got O
		//IL_05ee: Expected I, but got O
		//IL_073e: Expected O, but got I4
		//IL_0757: Expected O, but got I4
		//IL_0760: Expected O, but got I4
		//IL_04ba: Expected I, but got O
		//IL_0611: Expected O, but got I4
		//IL_065a: Expected I, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BBA]");
		object obj2 = (nint)0 & (nint)1;
		System.Int32Enum value;
		Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator enumerator;
		Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator enumerator2;
		KeyValuePair<System.Int32Enum, System.Int32Enum> keyValuePair;
		Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator enumerator3;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			keyValuePair = (KeyValuePair<System.Int32Enum, System.Int32Enum>)0;
			value = (System.Int32Enum)0;
			enumerator = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			enumerator2 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			keyValuePair = (KeyValuePair<System.Int32Enum, System.Int32Enum>)0;
			value = (System.Int32Enum)0;
			enumerator = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			enumerator3 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			if (!flag)
			{
				goto IL_00be;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			keyValuePair = (KeyValuePair<System.Int32Enum, System.Int32Enum>)0;
			value = (System.Int32Enum)0;
			enumerator = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			enumerator2 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			keyValuePair = (KeyValuePair<System.Int32Enum, System.Int32Enum>)0;
			value = (System.Int32Enum)0;
			enumerator = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			enumerator3 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			if (obj4 != null)
			{
				goto IL_00be;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4602]");
		object obj5 = (nint)0 & (nint)1;
		bool flag3 = obj5 == null;
		object obj6 = !flag3;
		enumerator2 = enumerator3;
		if (obj6 != null)
		{
			goto IL_00fc;
		}
		goto IL_0260;
		IL_06ed:
		NullReferenceException ex = new NullReferenceException();
		nint num = default(nint);
		System.Int32Enum int32Enum = (System.Int32Enum)num;
		Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator enumerator4 = enumerator;
		goto IL_0813;
		IL_06df:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06ed;
		IL_0813:
		bool flag4 = int32Enum != (System.Int32Enum)1;
		num = (nint)int32Enum;
		NullReferenceException ex3 = ex;
		StoreItem storeItem = default(StoreItem);
		StoreItem storeItem2;
		StoreItem storeItem3 = default(StoreItem);
		Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator enumerator5;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)storeItem;
			enumerator4.Dispose();
			object obj7 = default(object);
			bool flag5 = obj7 == null;
			enumerator5 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)obj7;
			storeItem2 = storeItem3;
			enumerator = enumerator4;
			if (flag5)
			{
				goto IL_0535;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator5 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)obj7;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223ECB8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4602]");
		object obj8 = (nint)0 & (nint)1;
		bool flag6 = obj8 == null;
		enumerator3 = enumerator2;
		if (!flag6)
		{
			goto IL_00fc;
		}
		goto IL_0260;
		IL_0260:
		_ = 1;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v80+E4]");
		bool flag7 = (nint)0 == 0;
		object obj10 = !flag7;
		enumerator2 = enumerator3;
		object obj11 = obj9;
		if (obj10 != null)
		{
			goto IL_0139;
		}
		goto IL_02ae;
		IL_00fc:
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v80+E4]");
		bool flag8 = (nint)0 == 0;
		obj11 = obj9;
		enumerator3 = enumerator2;
		if (!flag8)
		{
			goto IL_0139;
		}
		goto IL_02ae;
		IL_02ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v40+B8]");
		CardGamePlayer cardGamePlayer = (CardGamePlayer)0;
		Dictionary<System.Int32Enum, System.Int32Enum> dictionary = (Dictionary<System.Int32Enum, System.Int32Enum>)(object)cardGamePlayer;
		if (cardGamePlayer != null)
		{
			goto IL_02f5;
		}
		goto IL_06df;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v80+B8]");
		cardGamePlayer = (CardGamePlayer)0;
		dictionary = (Dictionary<System.Int32Enum, System.Int32Enum>)(object)cardGamePlayer;
		bool flag9 = cardGamePlayer == null;
		object obj13 = !flag9;
		if (obj13 != null)
		{
			goto IL_02f5;
		}
		enumerator3 = enumerator2;
		goto IL_06df;
		IL_02f5:
		object obj14 = (nint)0 + (nint)2408;
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj16 = (nint)0 + (nint)2664;
		storeItem2 = (StoreItem)((nint)0 + (nint)2152);
		Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator enumerator6 = dictionary.GetEnumerator();
		cardGamePlayer = (CardGamePlayer)(&enumerator);
		System.Int32Enum int32Enum2 = (System.Int32Enum)0;
		System.Int32Enum key;
		StoreItem storeItem4;
		KeyValuePair<System.Int32Enum, System.Int32Enum> keyValuePair2 = default(KeyValuePair<System.Int32Enum, System.Int32Enum>);
		System.Int32Enum int32Enum3 = default(System.Int32Enum);
		object obj19;
		KeyValuePair<System.Int32Enum, System.Int32Enum> keyValuePair3;
		while (enumerator.MoveNext())
		{
			nint num2 = (nint)obj14;
			keyValuePair.Deconstruct(out key, out value);
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v30+E4]");
			cardGamePlayer = (CardGamePlayer)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v30+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			storeItem4 = Store.GetStoreItem((GameAction)value);
			bool flag11 = storeItem4 == null;
			obj19 = (object)(&value);
			keyValuePair = keyValuePair2;
			if (flag11)
			{
				continue;
			}
			bool flag12 = _specialJackarooActions == null;
			int32Enum3 = int32Enum2;
			storeItem = storeItem2;
			obj19 = (object)(&value);
			keyValuePair3 = keyValuePair2;
			enumerator5 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			num = unchecked((nint)null);
			storeItem3 = storeItem4;
			keyValuePair = keyValuePair2;
			enumerator = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			enumerator3 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
			if (flag12)
			{
				goto IL_06ed;
			}
			cardGamePlayer = (CardGamePlayer)((nint)0 + (nint)3904);
			num2 = (nint)cardGamePlayer;
			((Dictionary<System.Int32Enum, object>)(object)_specialJackarooActions).Add(key, (object)storeItem4);
			if (_specialGameActions != null)
			{
				num2 = (nint)obj16;
				((Dictionary<System.Int32Enum, object>)(object)_specialGameActions).Add(value, (object)storeItem4);
				storeItem = storeItem2;
				obj19 = storeItem4;
				keyValuePair = keyValuePair2;
				int32Enum2 = (System.Int32Enum)1;
				continue;
			}
			goto IL_070b;
		}
		num = (nint)storeItem2;
		enumerator.Dispose();
		int32Enum3 = int32Enum2;
		keyValuePair3 = keyValuePair2;
		enumerator5 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
		enumerator = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
		enumerator3 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
		goto IL_0535;
		IL_0535:
		object obj20 = int32Enum3 & (System.Int32Enum)1;
		if (obj20 != null)
		{
			bool flag13 = (object)gameEventsChannel == null;
			storeItem3 = storeItem2;
			if (!flag13)
			{
				gameEventsChannel.TriggerShowFireModeButton();
				cardGamePlayer = player;
				bool flag14 = player == null;
				num = unchecked((nint)null);
				storeItem3 = storeItem2;
				if (!flag14)
				{
					KGame <Game>k__BackingField = ((KPlayer)cardGamePlayer).<Game>k__BackingField;
					bool flag15 = (object)((KPlayer)cardGamePlayer).<Game>k__BackingField == null;
					num = unchecked((nint)null);
					storeItem3 = storeItem2;
					if (!flag15)
					{
						<Game>k__BackingField = (KGame)<Game>k__BackingField.<Mover>k__BackingField;
						if (<Game>k__BackingField.<Mover>k__BackingField != ((KPlayer)cardGamePlayer).<Index>k__BackingField)
						{
							return;
						}
						List<JackarooMove> allowedMoves = _allowedMoves;
						bool flag16 = _allowedMoves == null;
						num = unchecked((nint)null);
						storeItem3 = storeItem2;
						cardGamePlayer = (CardGamePlayer)(object)_allowedMoves;
						if (!flag16)
						{
							if (allowedMoves._size >= 1)
							{
								GameStateHandleFireMode();
							}
							return;
						}
					}
				}
			}
		}
		else
		{
			bool flag17 = (object)gameEventsChannel == null;
			storeItem3 = storeItem2;
			if (!flag17)
			{
				gameEventsChannel.TriggerHideFireModeButton();
				return;
			}
		}
		goto IL_06df;
		IL_070b:
		ex = new NullReferenceException();
		int32Enum3 = int32Enum2;
		storeItem = storeItem2;
		obj19 = storeItem4;
		keyValuePair3 = keyValuePair2;
		enumerator5 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
		int32Enum = key;
		storeItem3 = storeItem4;
		enumerator4 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
		enumerator3 = (Dictionary<System.Int32Enum, System.Int32Enum>.Enumerator)0;
		goto IL_0813;
	}
}
