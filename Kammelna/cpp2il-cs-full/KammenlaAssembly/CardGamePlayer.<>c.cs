using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Sfs2X.Entities.Data;
using UnityEngine.TextCore;

public abstract class CardGamePlayer : KPlayer
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<Card> <>9__54_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_CanCardsBeShown>b__54_0(Card c)
		{
			bool flag = c == null;
			return !flag;
		}
	}

	public const string PLAYER_CARDS = "pcs";

	public const string ALL_PLAYERS_CARDS = "apcs";

	public const string NUM_OF_PLAYERS_CARDS = "pcsCount";

	public const string PLAYABLE_CARDS = "ppcs";

	public const string BIDDING_STATE = "bs";

	public const string HAS_KASHO_STATE = "hks";

	public const string CAN_KASHO_STATE = "cks";

	private Card <PlayedCard>k__BackingField;

	private List<Card> <PlayableCards>k__BackingField;

	private int <BiddingState>k__BackingField;

	private bool <HasKasho>k__BackingField;

	private bool <CanKasho>k__BackingField;

	private List<Card> <Cards>k__BackingField;

	private List<Suit> <SuitOrder>k__BackingField;

	private bool _showCards;

	public Card PlayedCard
	{
		get
		{
			return <PlayedCard>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> PlayableCards
	{
		get
		{
			return <PlayableCards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int BiddingState
	{
		get
		{
			return <BiddingState>k__BackingField;
		}
		private set
		{
			<BiddingState>k__BackingField = value;
		}
	}

	public bool HasKasho
	{
		get
		{
			return <HasKasho>k__BackingField;
		}
		private set
		{
			<HasKasho>k__BackingField = value;
		}
	}

	public bool CanKasho
	{
		get
		{
			return <CanKasho>k__BackingField;
		}
		private set
		{
			<CanKasho>k__BackingField = value;
		}
	}

	public List<Card> Cards
	{
		get
		{
			return <Cards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Suit> SuitOrder
	{
		get
		{
			return <SuitOrder>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool PlayedThisTurn
	{
		get
		{
			bool flag = <PlayedCard>k__BackingField == null;
			return !flag;
		}
	}

	public bool IsBidder
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_00d5: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_0049: Expected O, but got I
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_0136: Expected I, but got O
			//IL_015f: Expected O, but got I4
			//IL_021c: Expected I4, but got O
			//IL_0193: Expected O, but got I
			//IL_01f7: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADA]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					goto IL_0066;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0066;
				}
			}
			_ = 1;
			KGame kGame = base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField != null)
			{
				goto IL_0112;
			}
			goto IL_020e;
			IL_020e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0112:
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj6 = obj5;
			nint num = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v2+130]");
			bool flag2 = num2 < 0;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v2+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9-8]");
				if (0 == (nint)obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (KGame)+128]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (KGame)+128]");
						return ((List<int>)0).Contains(base.<Index>k__BackingField);
					}
					goto IL_020e;
				}
			}
			InvalidCastException ex2 = new InvalidCastException();
			goto IL_020e;
			IL_0066:
			kGame = base.<Game>k__BackingField;
			bool flag3 = (object)base.<Game>k__BackingField == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_0112;
			}
			goto IL_020e;
		}
	}

	public bool IsRoundBidder
	{
		get
		{
			//IL_00f4: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00c4: Expected O, but got I
			KGame kGame = base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)kGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (KGame)+150]");
						object obj6 = -base.<Index>k__BackingField;
						return obj6 == null;
					}
				}
				InvalidCastException ex = new InvalidCastException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
	}

	public bool IsDealer
	{
		get
		{
			//IL_00f4: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00c4: Expected O, but got I
			KGame kGame = base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)kGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<KGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (KGame)+158]");
						object obj6 = -base.<Index>k__BackingField;
						return obj6 == null;
					}
				}
				InvalidCastException ex = new InvalidCastException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
	}

	public override bool CanPlay
	{
		get
		{
			//IL_0024: Expected O, but got I4
			bool canPlay = base.CanPlay;
			bool flag = !canPlay;
			object obj = !flag;
			if (obj != null || IsBidder)
			{
				return true;
			}
			return ShouldAcceptNext;
		}
	}

	public bool CanPlayCard
	{
		get
		{
			//IL_0153: Expected I4, but got O
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_004c: Expected I, but got O
			//IL_0075: Expected O, but got I4
			//IL_00a9: Expected O, but got I
			//IL_00e0: Expected O, but got I
			//IL_011b: Expected O, but got I
			bool flag = base.CanPlay;
			if (flag)
			{
				KGame kGame = base.<Game>k__BackingField;
				if ((object)base.<Game>k__BackingField != null)
				{
					object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
					object obj2 = obj;
					nint num = (nint)kGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7 (Il2CppClass<KGame>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X1_v4+130]");
					bool flag2 = num2 < 0;
					object obj3 = !flag2;
					object obj4 = ~obj3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7 (Il2CppClass<KGame>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X1_v4+130]");
						object obj5 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v10-8]");
						if (0 == (nint)obj2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4 (KGame)+120]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4 (KGame)+120]");
							if ((nint)0 == 0)
							{
								goto IL_0145;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12+10]");
							object obj7 = -2;
							bool flag3 = obj7 == null;
							flag = flag3;
							goto IL_0153;
						}
					}
					InvalidCastException ex = new InvalidCastException();
				}
				goto IL_0145;
			}
			goto IL_0153;
			IL_0145:
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
			IL_0153:
			return flag;
		}
	}

	public bool ShouldAcceptNext
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_00d5: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_0049: Expected O, but got I
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_0136: Expected I, but got O
			//IL_015f: Expected O, but got I4
			//IL_028d: Expected I4, but got O
			//IL_0193: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_0254: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADB]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					goto IL_0066;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0066;
				}
			}
			_ = 1;
			KGame kGame = base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField != null)
			{
				goto IL_0112;
			}
			goto IL_0271;
			IL_0271:
			NullReferenceException ex = new NullReferenceException();
			goto IL_027f;
			IL_027f:
			InvalidCastException ex2 = new InvalidCastException();
			return (byte)(int)ex2 != 0;
			IL_0112:
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj6 = obj5;
			nint num = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v3+130]");
			bool flag2 = num2 < 0;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v3+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9-8]");
				if (0 == (nint)obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5 (KGame)+120]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5 (KGame)+120]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+10]");
						if ((nint)0 != 5)
						{
							return false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5 (KGame)+130]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5 (KGame)+130]");
							bool flag3 = ((List<int>)0).Contains(base.<Index>k__BackingField);
							return (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
						}
					}
					goto IL_0271;
				}
			}
			goto IL_027f;
			IL_0066:
			kGame = base.<Game>k__BackingField;
			bool flag4 = (object)base.<Game>k__BackingField == null;
			object obj11 = !flag4;
			if (obj11 != null)
			{
				goto IL_0112;
			}
			goto IL_0271;
		}
	}

	public bool CanEat
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0032: Expected I, but got O
			//IL_005b: Expected O, but got I4
			//IL_008f: Expected O, but got I
			//IL_00c6: Expected O, but got I
			//IL_015c: Expected O, but got I
			//IL_0176: Expected O, but got I4
			//IL_019f: Expected I, but got O
			//IL_01c8: Expected O, but got I4
			//IL_0309: Expected I4, but got O
			//IL_01fc: Expected O, but got I
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected O, but got Unknown
			//IL_024c: Expected I, but got O
			//IL_0275: Expected O, but got I4
			//IL_02a9: Expected O, but got I
			object obj = 152993792;
			KGame kGame = base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField == null)
			{
				goto IL_02e2;
			}
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj3 = obj2;
			nint num = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v4+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v4+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v8-8]");
				if (0 == (nint)obj3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2 (KGame)+120]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2 (KGame)+120]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v10+10]");
						if ((nint)0 != 3)
						{
							return false;
						}
						if (base.IsMover)
						{
							return true;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1+ADD]");
						object obj8 = (nint)0 & (nint)1;
						bool flag2 = obj8 == null;
						object obj9 = !flag2;
						if (obj9 == null)
						{
							_ = 1;
						}
						KGame kGame2 = base.<Game>k__BackingField;
						if ((object)base.<Game>k__BackingField != null)
						{
							object obj10 = obj2;
							nint num4 = (nint)kGame2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14 (Il2CppClass<KGame>)+130]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X1_v6+130]");
							bool flag3 = num5 < 0;
							object obj11 = !flag3;
							object obj12 = ~obj11;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14 (Il2CppClass<KGame>)+C8]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X1_v6+130]");
								object obj13 = num6 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v16-8]");
								if (0 == (nint)obj10)
								{
									int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(kGame2.<MySeatIndex>k__BackingField, 2, 1, 5);
									KPlayer playerByIndex = base.<Game>k__BackingField.GetPlayerByIndex(rotatedNextIndex);
									if (playerByIndex == null)
									{
										goto IL_02e2;
									}
									object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
									object obj15 = obj14;
									nint num7 = (nint)playerByIndex;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v22 (Il2CppClass<KPlayer>)+130]");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X1_v9+130]");
									bool flag4 = num8 < 0;
									object obj16 = !flag4;
									object obj17 = ~obj16;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v22 (Il2CppClass<KPlayer>)+C8]");
										nint num9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X1_v9+130]");
										object obj18 = num9 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v24-8]");
										if (0 == (nint)obj15)
										{
											return playerByIndex.IsMover;
										}
									}
									goto IL_02f0;
								}
							}
							InvalidCastException ex = new InvalidCastException();
							return (byte)(int)ex != 0;
						}
					}
					goto IL_02e2;
				}
			}
			goto IL_02f0;
			IL_02e2:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_02f0;
			IL_02f0:
			throw new InvalidCastException();
		}
	}

	public bool IsIdleBlocked
	{
		get
		{
			//IL_0155: Expected I4, but got O
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0061: Expected I, but got O
			//IL_008a: Expected O, but got I4
			//IL_00be: Expected O, but got I
			//IL_0125: Expected O, but got I4
			SeatStatus seatStatus = base.SeatStatus;
			bool flag;
			if (seatStatus == SeatStatus.IdleBlocked)
			{
				flag = true;
				goto IL_017e;
			}
			KGame kGame = base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)kGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7 (Il2CppClass<KGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X1_v4+130]");
				bool flag2 = num2 < 0;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7 (Il2CppClass<KGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X1_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10-8]");
					if (0 == (nint)obj2)
					{
						flag = base.<Game>k__BackingField.IsFastTrackGame;
						if (flag)
						{
							SeatStatus seatStatus2 = base.SeatStatus;
							object obj6 = seatStatus2 - 1;
							return obj6 == null;
						}
						goto IL_017e;
					}
				}
				InvalidCastException ex = new InvalidCastException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
			IL_017e:
			return flag;
		}
	}

	public bool CanCardsBeShown
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00d3: Expected O, but got I
			//IL_00e3: Expected O, but got I
			//IL_00f3: Expected O, but got I
			//IL_0115: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_014d: Expected O, but got I4
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01e3: Expected O, but got I
			//IL_01f4: Expected I, but got O
			//IL_0212: Expected O, but got I
			//IL_017d: Expected O, but got I
			object obj;
			object obj4;
			Predicate<object> match;
			object obj6;
			object obj3;
			if (<Cards>k__BackingField != null)
			{
				obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3968;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)2680;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					match = (Predicate<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_012b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)2680;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					match = (Predicate<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_012b;
					}
				}
				goto IL_0182;
			}
			return false;
			IL_0182:
			return ((List<object>)(object)<Cards>k__BackingField).Exists(match);
			IL_012b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(List<Tween>) + 3120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2448;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v11+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			match = predicate;
			goto IL_0182;
		}
	}

	public bool AreCardsShown
	{
		get
		{
			if (CanCardsBeShown)
			{
				return _showCards;
			}
			return false;
		}
	}

	public CardGamePlayer Teammate
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0240: Expected O, but got I
			//IL_025a: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00a2: Expected I, but got O
			//IL_00cb: Expected O, but got I4
			//IL_0294: Expected O, but got I4
			//IL_00ff: Expected O, but got I
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			//IL_019b: Expected I, but got O
			//IL_01c4: Expected O, but got I4
			//IL_01f8: Expected O, but got I
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADC]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_006f;
				}
			}
			_ = 1;
			KGame kGame = base.<Game>k__BackingField;
			bool flag2 = (object)base.<Game>k__BackingField == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_007e;
			IL_007e:
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj8 = obj7;
			nint num = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v12 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X1_v3+130]");
			bool flag3 = num2 < 0;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			CardGamePlayer playerByIndex;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v12 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X1_v3+130]");
				object obj11 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v14-8]");
				if (0 == (nint)obj8)
				{
					int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(base.<Index>k__BackingField, 2, 1, 5);
					playerByIndex = (CardGamePlayer)kGame.GetPlayerByIndex(rotatedNextIndex);
					if (playerByIndex == null)
					{
						goto IL_021f;
					}
					object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
					object obj13 = obj12;
					nint num4 = (nint)playerByIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v19 (Il2CppClass<CardGamePlayer>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X1_v7+130]");
					bool flag4 = num5 < 0;
					object obj14 = !flag4;
					object obj15 = ~obj14;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v19 (Il2CppClass<CardGamePlayer>)+C8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X1_v7+130]");
						object obj16 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v21-8]");
						if (0 == (nint)obj13)
						{
							goto IL_021f;
						}
					}
				}
			}
			return (CardGamePlayer)(object)new InvalidCastException();
			IL_006f:
			kGame = base.<Game>k__BackingField;
			goto IL_007e;
			IL_021f:
			return playerByIndex;
		}
	}

	protected new CardGame Game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			CardGame cardGame = (CardGame)base.<Game>k__BackingField;
			if ((object)base.<Game>k__BackingField != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (CardGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (CardGame)base.<Game>k__BackingField;
		}
	}

	public void ShowCards()
	{
		_showCards = true;
	}

	public void HideCards()
	{
		_showCards = false;
	}

	public CardGamePlayer(CardGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+B8]");
		object obj3 = 0;
		object obj4 = this + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_showCards = true;
		base..ctor(game);
	}

	protected override void UpdatePlayerState(ISFSObject response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94604C4");
	}

	private void AssignSortedCards(List<Card> newCards)
	{
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0140: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_00c0: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_021d: Expected I, but got O
		//IL_0246: Expected O, but got I4
		//IL_027a: Expected O, but got I
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_0308: Expected O, but got I
		//IL_0451: Expected O, but got I
		//IL_0343: Expected O, but got I
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj2 = this + 88;
		List<Card> list = default(List<Card>);
		List<Card> list2;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)obj2))
		{
			obj2 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list2 = (List<Card>)obj2;
			goto IL_0116;
		}
		object obj3 = obj2;
		if (obj2 != null)
		{
			obj2 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list2 = (List<Card>)obj2;
			if (obj2 != null)
			{
				int size = list2._size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v22+18]");
				if ((nint)size > (nint)0)
				{
					goto IL_0116;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					goto IL_00dd;
				}
				goto IL_01ca;
			}
		}
		goto IL_03bb;
		IL_01ca:
		_ = 1;
		KGame kGame = base.<Game>k__BackingField;
		if ((object)base.<Game>k__BackingField != null)
		{
			goto IL_01f9;
		}
		goto IL_03bb;
		IL_01f9:
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj6 = obj5;
		nint num = (nint)kGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v8 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X1_v5+130]");
		bool flag = num2 < 0;
		object obj7 = !flag;
		object obj8 = ~obj7;
		object obj16;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v8 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X1_v5+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v4-8]");
			if (0 == (nint)obj6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ X8_v8 (Il2CppClass<KGame>)+2E8] (should have been resolved before IL gen)");
				object obj10 = default(object);
				if (obj10 == null)
				{
					goto IL_03bb;
				}
				object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1392;
				List<Card> list3 = <Cards>k__BackingField;
				List<Suit> list4 = <SuitOrder>k__BackingField;
				object obj12 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v11+12E]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v11+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0384;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v11+B0]");
				object obj14 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v9-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj14 += 16;
					obj13--;
					if ((nint)obj13 != 1)
					{
						continue;
					}
					goto IL_0384;
				}
				object obj15 = obj12 + obj14;
				obj16 = obj15 + 312;
				goto IL_0439;
			}
		}
		goto IL_03c9;
		IL_0439:
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v12+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v246 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0384:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj19 = default(object);
		obj16 = obj19;
		goto IL_0439;
		IL_00dd:
		kGame = base.<Game>k__BackingField;
		bool flag2 = (object)base.<Game>k__BackingField == null;
		object obj20 = !flag2;
		if (obj20 != null)
		{
			goto IL_01f9;
		}
		goto IL_03bb;
		IL_0116:
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj22 = !flag3;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<Suit> suitOrder = CardUtils.GetSuitOrder(list2);
		object obj23 = this + 96;
		obj23 = suitOrder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
		object obj24 = (nint)0 & (nint)1;
		bool flag4 = obj24 == null;
		object obj25 = !flag4;
		if (obj25 != null)
		{
			goto IL_00dd;
		}
		goto IL_01ca;
		IL_03c9:
		throw new InvalidCastException();
		IL_03bb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03c9;
	}
}
