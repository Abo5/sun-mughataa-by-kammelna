using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot;
using KammelnaOffline.OfflineServer;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Variables;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

namespace KammelnaOffline.Common;

public abstract class OfflineGameController : IRoomExtension
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Suit, Suit> <>9__42_0;

		public static Func<Suit, List<Card>> <>9__42_1;

		public static Func<OfflinePlayer, int> <>9__48_0;

		public static Func<Card, bool> <>9__49_0;

		public static Func<int, int, int> <>9__51_0;

		public static Func<int, bool> <>9__51_1;

		public static Func<OfflinePlayer, int> <>9__63_0;

		public static Func<OfflinePlayer, int> <>9__63_1;

		public static Func<ISFSArray, int, ISFSArray> <>9__63_2;

		public static Func<Card, int> <>9__64_0;

		public static Func<Card, Suit> <>9__65_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Suit <StartRound>b__42_0(Suit s)
		{
			return s;
		}

		internal List<Card> <StartRound>b__42_1(Suit _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			return (List<Card>)(object)list;
		}

		internal int <PlayCard>b__48_0(OfflinePlayer player)
		{
			//IL_004c: Expected I4, but got O
			if (player != null)
			{
				List<Card> <Cards>k__BackingField = player.<Cards>k__BackingField;
				if (player.<Cards>k__BackingField != null)
				{
					return <Cards>k__BackingField._size;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <OnPlayCard>b__49_0(Card c)
		{
			bool flag = c == null;
			return !flag;
		}

		internal int <Bid>b__51_0(int state, int player)
		{
			//IL_002d: Expected I4, but got I8
			if (state == 3)
			{
				return -1;
			}
			return player + 1;
		}

		internal bool <Bid>b__51_1(int player)
		{
			//IL_000e: Expected O, but got I4
			object obj = player + 1;
			bool flag = obj == null;
			return !flag;
		}

		internal int <BuildRoundState>b__63_0(OfflinePlayer player)
		{
			//IL_004c: Expected I4, but got O
			if (player != null)
			{
				List<Card> <Cards>k__BackingField = player.<Cards>k__BackingField;
				if (player.<Cards>k__BackingField != null)
				{
					return <Cards>k__BackingField._size;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <BuildRoundState>b__63_1(OfflinePlayer _)
		{
			return 0;
		}

		internal ISFSArray <BuildRoundState>b__63_2(ISFSArray array, int element)
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
			if (array != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 960;
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
				object obj4 = obj3 + 14;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0139;
			}
			return (ISFSArray)new NullReferenceException();
			IL_0139:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X0_v3] (should have been resolved before IL gen)");
			return array;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0139;
		}

		internal int <CardsToInt>b__64_0(Card card)
		{
			//IL_0039: Expected I4, but got I8
			return card?.AsInt() ?? (-1);
		}

		internal Suit <SortCards>b__65_0(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}
	}

	private sealed class <>c__DisplayClass67_0
	{
		public SFSArray array;

		internal void <ShowSawa>b__0(OfflinePlayer player)
		{
			int[] val = CardsToInt(player.<Cards>k__BackingField);
			array.AddIntArray(val);
		}
	}

	private sealed class <>c__DisplayClass68_0
	{
		public SFSArray array;

		internal void <ShowKasho>b__0(OfflinePlayer player)
		{
			int[] val = CardsToInt(player.<Cards>k__BackingField);
			array.AddIntArray(val);
		}
	}

	private sealed class <>c__DisplayClass71_0
	{
		public OfflineGameController <>4__this;

		public int[] biddingStates;

		internal void <DoNextBidding>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0022: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00d1: Expected O, but got I
			//IL_027f: Expected O, but got I4
			//IL_029b: Expected O, but got I4
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected O, but got Unknown
			//IL_0242: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			//IL_02e7: Expected I, but got O
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected O, but got Unknown
			//IL_01a6: Expected O, but got I4
			//IL_01af: Expected O, but got I4
			int[] array = biddingStates;
			if (biddingStates != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj2 = 0;
				object obj11;
				do
				{
					if ((nint)obj2 >= array.Length)
					{
						return;
					}
					OfflineGameController offlineGameController = <>4__this;
					if (<>4__this == null)
					{
						break;
					}
					OfflinePlayer[] players = offlineGameController.Players;
					if (offlineGameController.Players == null)
					{
						break;
					}
					bool flag = (nint)obj2 < players.Length;
					object obj3 = !flag;
					string text2;
					string value;
					if (obj3 == null)
					{
						object obj4 = (object)offlineGameController.Players + obj2;
						OfflineGameController offlineGameController2 = <>4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v9+20]");
						AIAgent playerAi = offlineGameController2.GetPlayerAi((OfflinePlayer)0);
						if (playerAi != null)
						{
							int[] array2 = biddingStates;
							if (biddingStates == null)
							{
								break;
							}
							bool flag2 = (nint)obj2 < array2.Length;
							object obj5 = !flag2;
							if (obj5 != null)
							{
								goto IL_030d;
							}
							object obj6 = (object)biddingStates + obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v16+20]");
							int num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v16+20]");
							string text = playerAi.Bid(0);
							object obj7 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v14+E4]");
							bool flag3 = (nint)0 == 0;
							object obj8 = !flag3;
							object obj9 = 0;
							text2 = text;
							value = text;
							if (obj8 == null)
							{
								goto IL_01cd;
							}
						}
						else
						{
							object obj7 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v14+E4]");
							bool flag4 = (nint)0 == 0;
							object obj10 = !flag4;
							value = null;
							if (obj10 == null)
							{
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v9+20]");
								int num = 0;
								text2 = null;
								goto IL_01cd;
							}
						}
						goto IL_01e4;
					}
					goto IL_030d;
					IL_01cd:
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value = text2;
					goto IL_01e4;
					IL_01e4:
					if (StringsExtensions.IsNullOrEmpty(value))
					{
						obj2++;
						array = biddingStates;
						bool flag5 = biddingStates == null;
						obj11 = !flag5;
						continue;
					}
					OfflineGameController offlineGameController3 = <>4__this;
					if (<>4__this != null)
					{
						nint num2 = (nint)offlineGameController3;
						object obj12 = obj2 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v202 @ X8_v12 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+268] (should have been resolved before IL gen)");
					}
					break;
				}
				while (obj11 != null);
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_030d;
			IL_030d:
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass73_0
	{
		public OfflinePlayer player;

		internal bool <GetPlayerAi>b__0(AIAgent agent)
		{
			//IL_0087: Expected I4, but got O
			//IL_0065: Expected O, but got I4
			if (agent != null)
			{
				int playerIndex = agent.PlayerIndex;
				OfflinePlayer offlinePlayer = player;
				if (player != null)
				{
					object obj = playerIndex - offlinePlayer.PlayerIndex;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int Dealer;

	private int <Mover>k__BackingField;

	public int MoveNumber;

	public int RoundBidder;

	public bool FirstPlayer;

	private CardGameStage.CardGameStages <GameStatus>k__BackingField;

	protected int Team1Score;

	protected int Team2Score;

	protected int Team1TotalScore;

	protected int Team2TotalScore;

	public int[] Bidders;

	public Card[] PlayedCards;

	public Dictionary<Suit, List<Card>> AllPlayedCards;

	protected int[] TeamEatings;

	protected BiddingManager BiddingManager;

	protected PlayingManager PlayingManager;

	protected List<Card> Deck;

	private OfflineRoom <Room>k__BackingField;

	public OfflinePlayer[] Players;

	private AIAgent[] AiAgents;

	public ISFSObject LastAction;

	private ISFSObject <RoundState>k__BackingField;

	public int Mover
	{
		get
		{
			return <Mover>k__BackingField;
		}
		private set
		{
			<Mover>k__BackingField = value;
		}
	}

	public CardGameStage.CardGameStages GameStatus
	{
		get
		{
			return <GameStatus>k__BackingField;
		}
		set
		{
			<GameStatus>k__BackingField = value;
		}
	}

	public OfflineRoom Room
	{
		get
		{
			return <Room>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ISFSObject RoundState
	{
		get
		{
			return <RoundState>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 144;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void SetMover(int mover)
	{
		<Mover>k__BackingField = mover;
	}

	protected void SetAiAgents(AIAgent[] aiAgents)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 128;
		obj = aiAgents;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void OnExtensionRequest(string command, ISFSObject param)
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void OnGameUpdated(string command, ISFSObject param)
	{
		//IL_06e6: Expected O, but got I4
		//IL_06f8: Expected O, but got I8
		//IL_0712: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0134: Expected O, but got I8
		//IL_014e: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0690: Expected I, but got O
		//IL_06a0: Expected O, but got I
		//IL_06b0: Expected O, but got I
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0603: Expected I, but got O
		//IL_0613: Expected O, but got I
		//IL_0623: Expected O, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_0521: Expected I, but got O
		//IL_0531: Expected O, but got I
		//IL_0541: Expected O, but got I
		//IL_0597: Expected I, but got O
		//IL_05a7: Expected O, but got I
		//IL_05b7: Expected O, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_045f: Expected I, but got O
		//IL_046f: Expected O, but got I
		//IL_047f: Expected O, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_021c: Expected O, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_03f3: Expected I, but got O
		//IL_0403: Expected O, but got I
		//IL_0413: Expected O, but got I
		//IL_0387: Expected I, but got O
		//IL_0397: Expected O, but got I
		//IL_03a7: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(command);
		bool flag = (int)num < 3081015398L;
		object obj = !flag;
		object obj2 = (int)num - 3081015398L;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			bool flag3 = (int)num < 1490607949;
			object obj5 = !flag3;
			object obj6 = num - 1490607949;
			bool flag4 = obj6 == null;
			object obj7 = !flag4;
			object obj8 = obj5 & obj7;
			if (obj8 != null)
			{
				if ((int)num != 3081015398L)
				{
					switch (num)
					{
					case 2013181507u:
					{
						object obj9 = "___# Content push apply failed [{0}]: {1}" + 2704;
						if (command == (string)obj9)
						{
							ShowKasho(param);
						}
						return;
					}
					case 1515710731u:
						break;
					default:
						return;
					}
					goto IL_0489;
				}
				goto IL_062d;
			}
			if (num != 341869253)
			{
				switch (num)
				{
				case 1490607949u:
				{
					object obj10 = "___# Content push apply failed [{0}]: {1}" + 2712;
					if (command == (string)obj10)
					{
						ShowSawa(param);
					}
					return;
				}
				case 959184137u:
					break;
				default:
					return;
				}
				goto IL_03b1;
			}
		}
		else
		{
			bool flag5 = (int)num < 3381950720L;
			object obj11 = !flag5;
			object obj12 = (int)num - 3381950720L;
			bool flag6 = obj12 == null;
			object obj13 = !flag6;
			object obj14 = obj11 & obj13;
			if (obj14 == null)
			{
				object obj15 = typeof(DigitalContDownFormat) | 0xBC180000L;
				if ((int)num != (nint)obj15)
				{
					if ((int)num == 3215461789L)
					{
						goto IL_041d;
					}
					if ((int)num == 3381950720L)
					{
						object obj16 = "___# Content push apply failed [{0}]: {1}" + 2688;
						bool flag7 = command == (string)obj16;
						bool flag8 = !flag7;
						object obj17 = !flag8;
						if (obj17 == null)
						{
							return;
						}
						goto IL_045a;
					}
					return;
				}
				goto IL_05c1;
			}
			if ((int)num == 4271641068L)
			{
				object obj18 = "placementId" + 3704;
				if (command == (string)obj18)
				{
					nint num2 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v12 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1B8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v12 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1C0]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v380 @ X2_v3 (should have been resolved before IL gen)");
				}
				return;
			}
			if ((int)num != 4097439172L)
			{
				if ((int)num == 3601518325L)
				{
					object obj21 = "fetch_products" + 2432;
					if (command == (string)obj21)
					{
						SetRoomVariable(param);
						nint num3 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v23 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1C8]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v23 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1D0]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v374 @ X2_v8 (should have been resolved before IL gen)");
						goto IL_03b1;
					}
					return;
				}
				return;
			}
			object obj24 = "___# Content push apply failed [{0}]: {1}" + 2656;
			if (!(command == (string)obj24))
			{
				return;
			}
			string biddingFromSfsParam = GetBiddingFromSfsParam(param);
			nint num4 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v18 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+268]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v18 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+270]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v354 @ X4_v1 (should have been resolved before IL gen)");
		}
		object obj27 = "placementId" + 3792;
		if (command == (string)obj27)
		{
			SetRoomVariable(param);
			nint num5 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v57 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1F8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v57 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+200]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v378 @ X2_v19 (should have been resolved before IL gen)");
			goto IL_05c1;
		}
		return;
		IL_05c1:
		object obj30 = "___# Content push apply failed [{0}]: {1}" + 2664;
		if (command == (string)obj30)
		{
			nint num6 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v28 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+248]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v28 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+250]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v361 @ X3_v2 (should have been resolved before IL gen)");
			goto IL_062d;
		}
		return;
		IL_062d:
		object obj33 = "___# Content push apply failed [{0}]: {1}" + 2648;
		bool flag9 = command == (string)obj33;
		return;
		IL_045a:
		nint num7 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v32 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+328]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v32 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+330]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v359 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_0489;
		IL_0489:
		object obj36 = "___# Content push apply failed [{0}]: {1}" + 2680;
		if (command == (string)obj36)
		{
			EatCard(param);
		}
		return;
		IL_03b1:
		object obj37 = "___# Content push apply failed [{0}]: {1}" + 2640;
		if (command == (string)obj37)
		{
			nint num8 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v62 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+228]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v62 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+230]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v375 @ X2_v21 (should have been resolved before IL gen)");
			goto IL_041d;
		}
		return;
		IL_041d:
		object obj40 = "___# Content push apply failed [{0}]: {1}" + 2696;
		if (command == (string)obj40)
		{
			goto IL_045a;
		}
	}

	private void SetRoomVariable(ISFSObject param)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0165: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_06e6: Expected I, but got O
		//IL_06f6: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0751: Expected I, but got O
		//IL_0761: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		//IL_07d0: Expected I, but got O
		//IL_07e0: Expected O, but got I
		//IL_02d8: Expected O, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_036c: Expected O, but got I
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0435: Expected O, but got I
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0455: Expected O, but got I
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_04a3: Expected O, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0553: Expected O, but got I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_0616: Expected O, but got I
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		object obj3 = "placementId" + 1792;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X10_v31-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00d0;
		}
		object obj6 = obj5 + 14;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v63] (should have been resolved before IL gen)");
		goto IL_0149;
		IL_01f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06d4;
		IL_06d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X0_v7] (should have been resolved before IL gen)");
		nint num2 = (nint)sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0285;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		object obj11;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X10_v21-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0285;
		}
		object obj12 = obj10 + 14;
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		goto IL_073f;
		IL_073f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v494 @ X0_v10] (should have been resolved before IL gen)");
		nint num3 = (nint)sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0319;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v16-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0319;
		}
		object obj17 = obj16 + 14;
		object obj18 = num3 + obj17;
		object obj19 = obj18 + 312;
		goto IL_07aa;
		IL_07aa:
		object obj20 = typeof(MemberAchievementClanFeedData) + 3248;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v13] (should have been resolved before IL gen)");
		nint num4 = (nint)sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X10_v11-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_03ad;
		}
		object obj23 = obj22 + 14;
		object obj24 = num4 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0829;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v60] (should have been resolved before IL gen)");
		bool flag = sFSArray == null;
		object obj26 = !flag;
		if (obj26 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0149;
		IL_0149:
		obj11 = typeof(System.IOAsyncCallback) + 960;
		nint num5 = (nint)sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01f1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X10_v26-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_01f1;
		}
		object obj29 = obj28 + 14;
		object obj30 = num5 + obj29;
		object obj31 = obj30 + 312;
		goto IL_06d4;
		IL_03ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0829;
		IL_0829:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v653 @ X0_v16] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = default(object);
		obj32..ctor();
		object obj33 = obj32 + 24;
		obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 6;
		object obj34 = obj32 + 32;
		obj34 = sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj35 = typeof(Queue<string>) + 824;
		object obj36 = (nint)0 + (nint)2152;
		object obj37 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj38 = (nint)0 + (nint)4072;
		object obj39 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		<Room>k__BackingField.SetVariable((RoomVariable)obj32);
		object obj40 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v28+E4]");
		bool flag2 = (nint)0 == 0;
		object obj41 = !flag2;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag3 = list._size < items.Length;
		object obj42 = !flag3;
		if (obj42 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj43 = items + list._size;
			object obj44 = obj43 + 32;
			obj44 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize(obj3);
		}
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2848;
		object obj45 = (nint)0 + (nint)4088;
		object key2 = "rightCtrl" + 280;
		object obj46 = typeof(RegisteredWaitHandle) + 2008;
		object type = (nint)0 + (nint)2000;
		dictionary.Add(key, list);
		dictionary.Add(key2, <Room>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)type, (Dictionary<string, object>)(object)dictionary);
		SFS sFS = default(SFS);
		sFS.SFS_OnRoomVariableUpdate(sFSEvent);
		return;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_073f;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07aa;
	}

	protected virtual void OnGameRestart()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void OnGameStart()
	{
		//IL_000b: Expected I, but got O
		//IL_001b: Expected O, but got I
		//IL_002b: Expected O, but got I
		SetupPlayers();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void InitializeGame()
	{
		//IL_005d: Expected I, but got O
		//IL_006d: Expected O, but got I
		//IL_007d: Expected O, but got I
		DiscardOfflineGame();
		OfflinePlayer[] players = Players;
		int dealer = UnityEngine.Random.Range(1, players.Length);
		Dealer = dealer;
		Team1TotalScore = 0;
		<Room>k__BackingField.UpdateScore(0, 0);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v50 @ X2_v4 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void StartRound()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_035b: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0595: Expected O, but got I
		//IL_059d: Expected I, but got O
		//IL_05ae: Expected I, but got O
		//IL_05cc: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_03ba: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_03e4: Expected I, but got O
		//IL_038b: Expected O, but got I
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I
		//IL_04bc: Expected I, but got O
		//IL_04da: Expected O, but got I
		//IL_027c: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_02c5: Unsupported input type for neg.
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected I4, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0561: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
		Team1Score = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = this + 80;
		Func<System.Int32Enum, System.Int32Enum> func = default(Func<System.Int32Enum, System.Int32Enum>);
		obj3 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<Suit> all = SuitMethods.GetAll();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+E4]");
		object obj5;
		Func<System.Int32Enum, System.Int32Enum> func2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+8]");
			func2 = (Func<System.Int32Enum, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_00a7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+8]");
			func2 = (Func<System.Int32Enum, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_00a7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+B8]");
			obj5 = 0;
		}
		goto IL_056b;
		IL_040a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj11;
		object obj10 = obj11;
		nint num2;
		nint num = num2;
		Func<System.Int32Enum, System.Int32Enum> func4;
		Func<System.Int32Enum, System.Int32Enum> func3 = func4;
		Func<System.Int32Enum, System.Int32Enum> func5;
		func2 = func5;
		goto IL_00fc;
		IL_00fc:
		object obj12 = (nint)0 + (nint)1712;
		object obj13 = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v34+10]");
		Func<System.Int32Enum, object> elementSelector = (Func<System.Int32Enum, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v34+10]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v40+B8]");
				obj14 = 0;
			}
			object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)4024;
			Func<System.Int32Enum, object> func6 = default(Func<System.Int32Enum, object>);
			func6..ctor(obj14, (IntPtr)obj19);
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v39+B8]");
			object obj21 = (nint)0 + (nint)16;
			obj21 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			elementSelector = func6;
		}
		Dictionary<System.Int32Enum, object> dictionary = Enumerable.ToDictionary((IEnumerable<System.Int32Enum>)all, func2, elementSelector);
		object obj22 = this + 72;
		obj22 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj23 = this + 64;
		object obj24 = default(object);
		obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayingManager playingManager = CreatePlayingManager();
		object obj25 = this + 96;
		obj25 = playingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj26 = obj25;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X8_v20+1A8] (should have been resolved before IL gen)");
		object obj28 = -Dealer;
		object obj29 = obj28 & 3;
		int num3 = Dealer & 3;
		if (0 >= Dealer)
		{
			num3 = 0 - obj29;
		}
		int dealer = num3 + 1;
		Dealer = dealer;
		<GameStatus>k__BackingField = CardGameStage.CardGameStages.Bidding;
		BiddingManager biddingManager = CreateBiddingManager();
		object obj30 = this + 88;
		obj30 = biddingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		OnStartRound();
		BuildRoundState();
		SendRoundStart();
		UpdatePlayersCard();
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v299 @ X8_v30 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+2B8] (should have been resolved before IL gen)");
		goto IL_056b;
		IL_00a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		func3 = func;
		obj11 = obj10;
		num2 = num;
		func4 = func;
		object obj31 = obj4;
		func5 = func2;
		if (!flag6)
		{
			goto IL_00fc;
		}
		goto IL_040a;
		IL_056b:
		object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)4016;
		num = (nint)obj33;
		Func<System.Int32Enum, System.Int32Enum> func7 = default(Func<System.Int32Enum, System.Int32Enum>);
		func7..ctor(obj5, (IntPtr)obj33);
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+B8]");
		object obj35 = (nint)0 + (nint)8;
		obj35 = func7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj36 = !flag7;
		obj10 = 0;
		func3 = func7;
		func2 = func7;
		obj11 = 0;
		num2 = (nint)obj33;
		func4 = func7;
		obj31 = obj4;
		func5 = func7;
		if (obj36 != null)
		{
			goto IL_00fc;
		}
		goto IL_040a;
	}

	protected virtual void ResumeLastGame()
	{
		//IL_0068: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_0088: Expected O, but got I
		SetupPlayers();
		OfflineGameState offlineGame = OfflineUserInfo.OfflineGame;
		Team1TotalScore = offlineGame.Team1Score;
		Team2TotalScore = offlineGame.Team2Score;
		Dealer = offlineGame.Dealer;
		<Room>k__BackingField.UpdateScore(offlineGame.Team1Score, offlineGame.Team2Score);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void SetupPlayers()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0022: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		//IL_017a: Expected I, but got O
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_0035: Expected I, but got O
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_00d3: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_015c: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 120;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		object obj5 = 32;
		object obj6 = 0;
		int num3 = default(int);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		while (true)
		{
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X23_v5+18]");
			int num4;
			if ((nint)obj7 < 0)
			{
				nint num = (nint)this;
				int num2 = obj6 + 1;
				OfflinePlayer offlinePlayer = CreatePlayer(num2);
				bool flag = offlinePlayer == null;
				num3 = num2;
				if (!flag)
				{
					object obj8 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v12+40]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v12+40]");
					num4 = 0;
					if (flag2)
					{
						break;
					}
				}
				object obj9 = num2 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X23_v5+18]");
				bool flag3 = (nint)obj9 < 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					object obj11 = obj4 + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj4 = obj2;
					obj5 += 8;
					obj6 = obj9 + 1;
					bool flag4 = obj2 == null;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
			}
			else
			{
				nint num5 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+218]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+220]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v163 @ X2_v2 (should have been resolved before IL gen)");
			}
			ex = new IndexOutOfRangeException();
			num4 = num3;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	protected virtual void SetupAi()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_00ac: Expected I, but got O
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0168: Expected O, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		object obj = (nint)0 + (nint)640;
		IEnumerable<object> source = Enumerable.Skip((IEnumerable<object>)Players, 1);
		List<object> list = Enumerable.ToList(source);
		object obj2 = typeof(TypeConverter<ushort, char>) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = this + 128;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		object obj6 = typeof(SqlSingle[]) + 2032;
		object obj7 = 32;
		int num = 0;
		object obj10 = default(object);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X27_v5+18]");
			if ((nint)num2 < (nint)0)
			{
				object obj8 = (nint)0 + (nint)1184;
				object obj9 = list.get_Item(num);
				nint num3 = (nint)this;
				AbstractAiLogic abstractAiLogic = CreateAiLogic();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj10..ctor();
				object obj11 = obj10 + 16;
				obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj12 = obj10 + 24;
				obj12 = abstractAiLogic;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj13 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				if (ex == null)
				{
					break;
				}
				int num4 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X27_v5+18]");
				bool flag = (nint)num4 < (nint)0;
				object obj14 = !flag;
				if (obj14 == null)
				{
					object obj15 = obj5 + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num++;
					obj5 = obj3;
					obj7 += 8;
					bool flag2 = obj3 == null;
					object obj16 = !flag2;
					if (obj16 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				ex = new IndexOutOfRangeException();
				break;
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	protected virtual void AcceptNextMove()
	{
		//IL_0037: Expected I, but got O
		//IL_0051: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_00d3: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_008d: Expected O, but got I4
		if (<GameStatus>k__BackingField == CardGameStage.CardGameStages.MoveNextRequired)
		{
			OnEndRound();
			bool flag = IsGameOver();
			nint num = (nint)this;
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				object obj3 = 568;
			}
			else
			{
				object obj3 = 488;
			}
			object obj4 = !flag2;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				object obj6 = 576;
			}
			else
			{
				object obj6 = 496;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+v85 @ X9_v4]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+v75 @ X10_v3]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	protected virtual void OnEndGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected I4, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_012a: Expected I, but got O
		//IL_013a: Expected O, but got I
		//IL_014a: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object key = "utf-32" + 1520;
		object obj2 = Team1TotalScore - Team2TotalScore;
		bool flag = (nint)obj2 < 0;
		bool flag2 = obj2 == null;
		int num = Team1TotalScore ^ Team2TotalScore;
		int num2 = Team1TotalScore ^ obj2;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag4;
		object obj4 = obj3 | flag2;
		object obj5 = ~obj4;
		int val = ((obj5 != null) ? 1 : (1 + 1));
		sFSObject.PutInt((string)key, val);
		SendEndGame(sFSObject);
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+308]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+310]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void PlayCard(ISFSObject param)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0eea: Expected O, but got I4
		//IL_0ef2: Expected I, but got O
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_01e5: Expected I, but got O
		//IL_0217: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_023f: Expected I, but got O
		//IL_0272: Expected O, but got I4
		//IL_027a: Expected I, but got O
		//IL_0299: Expected O, but got I
		//IL_02a1: Expected I, but got O
		//IL_02b6: Expected O, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_04d2: Expected O, but got I4
		//IL_0f70: Expected O, but got I
		//IL_0f80: Expected O, but got I
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected O, but got Unknown
		//IL_0fb1: Expected O, but got I4
		//IL_0fba: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_055a: Expected O, but got I
		//IL_0562: Expected I, but got O
		//IL_0581: Expected O, but got I
		//IL_0519: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected O, but got Unknown
		//IL_0ff2: Expected O, but got I
		//IL_1003: Expected I, but got O
		//IL_1021: Expected O, but got I
		//IL_1044: Expected O, but got I4
		//IL_05c2: Expected I, but got O
		//IL_05d2: Expected O, but got I
		//IL_0549: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0386: Expected O, but got I4
		//IL_1085: Expected O, but got I
		//IL_108d: Expected I, but got O
		//IL_060d: Expected O, but got I
		//IL_03ad: Expected O, but got I
		//IL_03cb: Expected O, but got I4
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_03f8: Expected I, but got O
		//IL_0408: Expected O, but got I
		//IL_06c9: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_0f41: Expected O, but got I
		//IL_0f49: Expected I, but got O
		//IL_0443: Expected O, but got I
		//IL_0711: Expected O, but got I
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_0746: Expected O, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0777: Expected O, but got I
		//IL_07ee: Expected O, but got I4
		//IL_0870: Expected O, but got I
		//IL_0880: Expected O, but got I
		//IL_08a5: Expected O, but got I
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_08fa: Expected O, but got I
		//IL_0902: Expected I, but got O
		//IL_0936: Expected O, but got I4
		//IL_0962: Expected O, but got I
		//IL_0977: Expected O, but got I
		//IL_099b: Expected O, but got I4
		//IL_09d2: Expected O, but got I4
		//IL_0a55: Expected O, but got I
		//IL_0a65: Expected O, but got I
		//IL_09f6: Expected O, but got I
		//IL_0a18: Expected O, but got I
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0ac0: Expected I, but got O
		//IL_0ad0: Expected O, but got I
		//IL_0b07: Expected O, but got I4
		//IL_0b22: Expected O, but got I4
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Expected O, but got Unknown
		//IL_0bbb: Expected I, but got O
		//IL_0bcb: Expected O, but got I
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Expected O, but got Unknown
		//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected O, but got Unknown
		//IL_0c06: Expected O, but got I
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected O, but got Unknown
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected O, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected O, but got Unknown
		//IL_0cf0: Expected O, but got I
		//IL_0d10: Expected O, but got I4
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Expected O, but got Unknown
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Expected O, but got Unknown
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected O, but got Unknown
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0d5d: Expected O, but got I
		//IL_114e: Expected I, but got O
		//IL_115e: Expected O, but got I
		//IL_117d: Expected I, but got O
		//IL_118d: Expected O, but got I
		//IL_119d: Expected O, but got I
		//IL_0d98: Expected O, but got I
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected O, but got Unknown
		//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected O, but got Unknown
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Expected O, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		if (<GameStatus>k__BackingField != CardGameStage.CardGameStages.Playing)
		{
			return;
		}
		bool flag = param == null;
		ISFSObject iSFSObject = param;
		if (flag)
		{
			goto IL_0e16;
		}
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "placementId" + 112;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X10_v38-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00e1;
		}
		object obj5 = obj4 + 14;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0e8e;
		IL_0e32:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_106d:
		object obj9 = default(object);
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X0_v67+8]");
		object obj10 = 0;
		int[] array;
		nint num2 = (nint)array;
		object obj11;
		iSFSObject = (ISFSObject)obj11;
		ISFSObject iSFSObject2 = <RoundState>k__BackingField;
		goto IL_11a7;
		IL_0f29:
		object obj12 = default(object);
		obj8 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v83+8]");
		obj10 = 0;
		int[] array2;
		num2 = (nint)array2;
		object obj13;
		iSFSObject = (ISFSObject)obj13;
		iSFSObject2 = <RoundState>k__BackingField;
		goto IL_11a7;
		IL_0e24:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0e32;
		IL_064e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_106d;
		IL_0e16:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0e24;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0e8e;
		IL_0e8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v530 @ X0_v10] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if ((nint)obj14 != <Mover>k__BackingField)
		{
			return;
		}
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2400;
		object obj15 = (nint)0 + (nint)2000;
		string stringRepresentation = SFSExtensions.Get(param, (string)varName, (string)obj15);
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Card card = CardUtils.FromString(stringRepresentation);
		OfflinePlayer[] players = Players;
		bool flag3 = Players == null;
		obj10 = 0;
		num2 = (nint)obj15;
		iSFSObject = null;
		if (!flag3)
		{
			object obj19 = <Mover>k__BackingField - 1;
			bool flag4 = (nint)obj19 < players.Length;
			object obj20 = !flag4;
			obj10 = 0;
			num2 = (nint)obj15;
			iSFSObject = null;
			if (obj20 != null)
			{
				goto IL_0e24;
			}
			object obj21 = (object)Players + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v22+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v22+20]");
			bool flag5 = (nint)0 == 0;
			obj10 = 0;
			num2 = (nint)obj15;
			iSFSObject = null;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v23+18]");
				bool flag6 = (nint)0 == 0;
				obj10 = 0;
				num2 = (nint)obj15;
				iSFSObject = null;
				if (!flag6)
				{
					object obj23 = (nint)0 + (nint)2704;
					num2 = (nint)obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v23+18]");
					bool flag7 = ((List<object>)0).Remove(card);
					ISFSObject iSFSObject3 = <RoundState>k__BackingField;
					IEnumerable<object> players2 = Players;
					if (<Mover>k__BackingField == 1)
					{
						bool flag8 = Players == null;
						obj10 = 0;
						iSFSObject = (ISFSObject)card;
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v5 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
							bool flag9 = (nint)0 == 0;
							obj10 = 0;
							iSFSObject = (ISFSObject)card;
							if (flag9)
							{
								goto IL_0e24;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v5 (System.Collections.Generic.IEnumerable`1<System.Object>)+20]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v5 (System.Collections.Generic.IEnumerable`1<System.Object>)+20]");
							bool flag10 = (nint)0 == 0;
							obj10 = 0;
							iSFSObject = (ISFSObject)card;
							if (!flag10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v87+18]");
								array2 = CardsToInt((IEnumerable<Card>)0);
								bool flag11 = <RoundState>k__BackingField == null;
								obj10 = 0;
								iSFSObject = (ISFSObject)card;
								if (!flag11)
								{
									obj13 = "not" + 3720;
									nint num3 = (nint)iSFSObject3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v90 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v90 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0484;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v90 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
									object obj26 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X10_v33-8]");
										if (0 == (nint)obj)
										{
											break;
										}
										obj26 += 16;
										obj25--;
										if ((nint)obj25 != 1)
										{
											continue;
										}
										goto IL_0484;
									}
									object obj27 = obj26 + 44;
									object obj28 = num3 + obj27;
									obj12 = obj28 + 312;
									goto IL_0f29;
								}
							}
						}
					}
					else
					{
						object obj29 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
						object obj30 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v62+E4]");
						bool flag12 = (nint)0 == 0;
						object obj31 = !flag12;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj30 = obj29;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v62+B8]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v78+18]");
						Func<object, int> selector = (Func<object, int>)0;
						obj11 = "not" + 3728;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v78+18]");
						bool flag13 = (nint)0 == 0;
						object obj33 = !flag13;
						obj10 = 0;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v62+E4]");
							bool flag14 = (nint)0 == 0;
							object obj34 = !flag14;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj35 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v84+B8]");
								obj32 = 0;
							}
							object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2632;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj37 = (nint)0 + (nint)4000;
							Func<object, int> func = default(Func<object, int>);
							func..ctor(obj32, (IntPtr)obj37);
							object obj38 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v83+B8]");
							object obj39 = (nint)0 + (nint)24;
							obj39 = func;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							selector = func;
							obj10 = 0;
						}
						object obj40 = (nint)0 + (nint)3744;
						num2 = (nint)obj40;
						IEnumerable<int> source = Enumerable.Select(Players, selector);
						object obj41 = (nint)0 + (nint)1320;
						iSFSObject = (ISFSObject)obj41;
						array = Enumerable.ToArray(source);
						if (<RoundState>k__BackingField != null)
						{
							nint num4 = (nint)iSFSObject3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v74 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v74 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_064e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v74 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
							object obj43 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X10_v27-8]");
								if (0 == (nint)obj)
								{
									break;
								}
								obj43 += 16;
								obj42--;
								if ((nint)obj42 != 1)
								{
									continue;
								}
								goto IL_064e;
							}
							object obj44 = obj43 + 44;
							object obj45 = num4 + obj44;
							obj9 = obj45 + 312;
							goto IL_106d;
						}
					}
				}
			}
		}
		goto IL_0e16;
		IL_0484:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0f29;
		IL_11a7:
		SFSObject sFSObject = default(SFSObject);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v817 @ X8_v27 (should have been resolved before IL gen)");
			OfflinePlayer[] players3 = Players;
			if (Players == null)
			{
				break;
			}
			object obj46 = <Mover>k__BackingField - 1;
			bool flag15 = (nint)obj46 < players3.Length;
			object obj47 = !flag15;
			if (obj47 == null)
			{
				object obj48 = (object)Players + obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v29+20]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v29+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v30+28]");
				List<object> list = (List<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v30+28]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj50 = (nint)0 + (nint)2648;
				object obj51 = obj50;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items == null)
				{
					break;
				}
				bool flag16 = list._size < items.Length;
				object obj52 = !flag16;
				if (obj52 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj53 = list._items + list._size;
					object obj54 = obj53 + 32;
					obj54 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					iSFSObject = (ISFSObject)card;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v31+20]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v64+C0]");
					object obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v65+70]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v30+28]");
					((List<object>)0).AddWithResize((object)card);
					iSFSObject = (ISFSObject)card;
				}
				if (card == null || AllPlayedCards == null)
				{
					break;
				}
				object obj57 = (nint)0 + (nint)1992;
				num2 = (nint)obj57;
				object obj58 = ((Dictionary<System.Int32Enum, object>)(object)AllPlayedCards).get_Item((System.Int32Enum)card.<Suit>k__BackingField);
				bool flag17 = obj58 == null;
				iSFSObject = (ISFSObject)card.<Suit>k__BackingField;
				if (flag17)
				{
					break;
				}
				object obj59 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+1C]");
				object obj60 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+10]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+10]");
				bool flag18 = (nint)0 == 0;
				iSFSObject = (ISFSObject)card.<Suit>k__BackingField;
				if (flag18)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+18]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v18+18]");
				bool flag19 = num5 < 0;
				object obj62 = !flag19;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+18]");
					object obj63 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+10]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24 (System.Object)+18]");
					object obj64 = num6 + 0;
					object obj65 = obj64 + 32;
					obj65 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					iSFSObject = (ISFSObject)card;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v35+20]");
					object obj66 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v61+C0]");
					object obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v62+70]");
					num2 = 0;
					((List<object>)obj58).AddWithResize((object)card);
					iSFSObject = (ISFSObject)card;
				}
				Card[] playedCards = PlayedCards;
				if (PlayedCards == null)
				{
					break;
				}
				nint num7 = (nint)playedCards;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v37 (Il2CppClass<Card[]>)+40]");
				iSFSObject = (ISFSObject)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				if (ex == null)
				{
					goto IL_0e32;
				}
				object obj68 = <Mover>k__BackingField - 1;
				bool flag20 = (nint)obj68 < playedCards.Length;
				object obj69 = !flag20;
				if (obj69 == null)
				{
					object obj70 = (object)PlayedCards + obj68;
					object obj71 = obj70 + 32;
					obj71 = card;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ISFSObject iSFSObject4 = <RoundState>k__BackingField;
					int[] array3 = CardsToInt(PlayedCards);
					bool flag21 = <RoundState>k__BackingField == null;
					iSFSObject = (ISFSObject)card;
					if (flag21)
					{
						break;
					}
					object obj72 = "placementId" + 104;
					nint num8 = (nint)iSFSObject4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v41 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					object obj73 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v41 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0c47;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v41 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
					object obj74 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X10_v21-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj74 += 16;
						obj73--;
						if ((nint)obj73 != 1)
						{
							continue;
						}
						goto IL_0c47;
					}
					object obj75 = obj74 + 44;
					object obj76 = num8 + obj75;
					object obj77 = obj76 + 312;
					goto IL_10c8;
				}
			}
			goto IL_0e24;
			IL_113f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1007 @ X0_v42] (should have been resolved before IL gen)");
			nint num9 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v57 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+260]");
			object obj78 = 0;
			OnPlayCard(card, <Mover>k__BackingField, param);
			UpdatePlayersCard();
			nint num10 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v58 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+2B8]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v58 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+2C0]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v361 @ X2_v20 (should have been resolved before IL gen)");
			continue;
			IL_0dd9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_113f;
			IL_10c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v916 @ X0_v33] (should have been resolved before IL gen)");
			object obj81 = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			object obj82 = this + 136;
			obj82 = sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key = "___# Content push apply failed [{0}]: {1}" + 3152;
			object val = "___# Content push apply failed [{0}]: {1}" + 2664;
			SFSExtensions.Put((ISFSObject)obj82, (string)key, (string)val);
			object obj83 = "alignContent" + 680;
			object obj84 = obj82;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X23_v9-74]");
			SFSExtensions.Put((ISFSObject)obj84, (string)obj83, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X23_v9+8]");
			object obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X23_v9+8]");
			bool flag22 = (nint)0 == 0;
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X23_v9-74]");
			num2 = 0;
			iSFSObject = (ISFSObject)obj83;
			if (flag22)
			{
				break;
			}
			object obj86 = "java.io.FileOutputStream" + 1184;
			object obj87 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v54+12E]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v54+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v54+B0]");
				object obj89 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X10_v16-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj89 += 16;
					obj88--;
					if ((nint)obj88 != 1)
					{
						continue;
					}
					goto IL_0dd9;
				}
				object obj90 = obj89 + 50;
				object obj91 = obj87 + obj90;
				object obj92 = obj91 + 312;
				goto IL_113f;
			}
			goto IL_0dd9;
			IL_0c47:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_10c8;
		}
		goto IL_0e16;
	}

	protected virtual void OnPlayCard(Card card, int playerIndex, ISFSObject param)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02cc: Expected I, but got O
		//IL_02dc: Expected O, but got I
		//IL_0214: Expected O, but got I4
		//IL_0317: Expected O, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_050b: Expected O, but got I
		//IL_051c: Expected I, but got O
		//IL_053a: Expected O, but got I
		//IL_03a6: Expected O, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_03ef: Unsupported input type for neg.
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected I4, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0418: Expected I, but got O
		//IL_0428: Expected O, but got I
		//IL_061a: Expected O, but got I
		//IL_0463: Expected O, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8048]");
		object obj3 = (nint)0 & (nint)1;
		Card[] playedCards;
		Card[] playedCards2;
		object obj4;
		if (obj3 != null)
		{
			playedCards = PlayedCards;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			playedCards2 = PlayedCards;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			playedCards = PlayedCards;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			playedCards2 = PlayedCards;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v21+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v23+20]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v23+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = playedCards2;
		object obj10 = obj7;
		IEnumerable<object> source = playedCards2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_0358:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_058d;
		IL_0249:
		int num = Enumerable.Count(source, predicate);
		object obj11 = num - 1;
		bool firstMove = obj11 == null;
		IEnumerable<Card> playableCards = GetPlayableCards(firstMove);
		ISFSObject iSFSObject = <RoundState>k__BackingField;
		int[] array = CardsToInt(playableCards);
		object obj12 = typeof(System.IOAsyncCallback) + 976;
		object obj13 = "placementId" + 520;
		nint num2 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0358;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X10_v12-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0358;
		}
		object obj16 = obj15 + 44;
		object obj17 = num2 + obj16;
		object obj18 = obj17 + 312;
		goto IL_058d;
		IL_0602:
		object obj20 = default(object);
		object obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v12+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v268 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0099:
		obj10 = (nint)0 + (nint)3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v21+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v23+20]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v23+20]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		source = playedCards;
		if (obj22 == null)
		{
			obj7 = obj10;
			enumerable = playedCards;
			goto IL_01f2;
		}
		goto IL_0249;
		IL_058d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v357 @ X0_v9] (should have been resolved before IL gen)");
		if (num == 4)
		{
			return;
		}
		object obj23 = -<Mover>k__BackingField;
		object obj24 = obj23 & 3;
		int num3 = <Mover>k__BackingField & 3;
		if (0 >= <Mover>k__BackingField)
		{
			num3 = 0 - obj24;
		}
		int num4 = num3 + 1;
		<Mover>k__BackingField = num4;
		ISFSObject iSFSObject2 = <RoundState>k__BackingField;
		object obj25 = "m_StencilDeferredPS" + 2456;
		object obj26 = obj25;
		nint num5 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04a4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X10_v7-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_04a4;
		}
		object obj29 = obj28 + 35;
		object obj30 = num5 + obj29;
		obj20 = obj30 + 312;
		goto IL_0602;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj31 = !flag5;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj32 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v29+B8]");
			obj8 = 0;
		}
		object obj33 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)3992;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj8, (IntPtr)obj34);
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v28+B8]");
		object obj36 = (nint)0 + (nint)32;
		obj36 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		obj10 = obj7;
		source = enumerable;
		goto IL_0249;
		IL_04a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0602;
	}

	protected void UpdatePlayersCard()
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0369: Expected O, but got I4
		//IL_03a6: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_027e: Expected I, but got O
		//IL_028e: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0148: Expected I, but got O
		//IL_0158: Expected O, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I4
		//IL_0193: Expected O, but got I
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8049]");
		object obj = 0;
		object obj2 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		OfflinePlayer[] players = Players;
		object obj12;
		if (Players != null)
		{
			object obj3 = Players + 32;
			obj = players.Length;
			if (sFSArray != null)
			{
				if ((nint)obj < 1)
				{
					goto IL_022a;
				}
				object obj4 = typeof(System.IOAsyncCallback) + 960;
				object obj5 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X23_v3+v98 @ X24_v6*8]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X23_v3+v98 @ X24_v6*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v4+18]");
					int[] array = CardsToInt((IEnumerable<Card>)0);
					nint num = (nint)sFSArray;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00a1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSArray>)+B0]");
					object obj7 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X10_v15-8]");
						if (0 == (nint)obj4)
						{
							break;
						}
						obj7 += 16;
						obj6--;
						if ((nint)obj6 != 1)
						{
							continue;
						}
						goto IL_00a1;
					}
					object obj8 = obj7 + 23;
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					goto IL_00b0;
					IL_00a1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_00b0;
					IL_00b0:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X0_v20] (should have been resolved before IL gen)");
					obj5++;
					obj = players.Length;
					if ((nint)obj5 < players.Length)
					{
						continue;
					}
					goto IL_022a;
				}
			}
			else
			{
				if (players.Length < 1)
				{
					goto IL_022a;
				}
				obj = obj3;
				bool flag = obj3 == null;
				object obj11 = !flag;
				obj12 = obj3;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v3+18]");
					int[] array2 = CardsToInt((IEnumerable<Card>)0);
					throw new NullReferenceException();
				}
			}
		}
		goto IL_0381;
		IL_043b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v366 @ X0_v11] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_022a:
		ISFSObject iSFSObject = <RoundState>k__BackingField;
		if (<RoundState>k__BackingField == null)
		{
			goto IL_0381;
		}
		object obj13 = typeof(System.IOAsyncCallback) + 976;
		object obj14 = "alignContent" + 696;
		nint num2 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_030a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X10_v8-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_030a;
		}
		object obj17 = obj16 + 49;
		object obj18 = num2 + obj17;
		object obj19 = obj18 + 312;
		goto IL_043b;
		IL_0381:
		obj12 = obj;
		throw new NullReferenceException();
		IL_030a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_043b;
	}

	protected virtual void Bid(int bidderIndex, string bid)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_01a0: Expected O, but got I
		//IL_0754: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_02a9: Expected O, but got I
		//IL_02b9: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_02fb: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_080e: Expected O, but got I
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0222: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_0254: Expected O, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07bc: Expected O, but got I
		//IL_07cd: Expected I, but got O
		//IL_07eb: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0385: Expected O, but got I
		//IL_032b: Expected O, but got I4
		//IL_0200: Expected O, but got I
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected O, but got Unknown
		//IL_0879: Expected O, but got I
		//IL_088a: Expected I, but got O
		//IL_08a8: Expected O, but got I
		//IL_0282: Expected O, but got I
		//IL_035b: Expected O, but got I
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0410: Expected I, but got O
		//IL_0420: Expected O, but got I
		//IL_04ca: Expected O, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_045b: Expected O, but got I
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0597: Expected I, but got O
		//IL_05a7: Expected O, but got I
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0916: Expected I, but got O
		//IL_0926: Expected O, but got I
		//IL_05e2: Expected O, but got I
		//IL_0665: Expected I, but got O
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_06fc: Expected O, but got I
		//IL_070c: Expected O, but got I
		//IL_0694: Expected O, but got I
		//IL_06a4: Expected O, but got I
		//IL_06d7: Expected O, but got I
		//IL_06e7: Expected O, but got I
		if (<GameStatus>k__BackingField != CardGameStage.CardGameStages.Bidding)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj2 = this + 136;
		obj2 = sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X23_v3-30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X23_v3-30]");
		if ((nint)0 == 0)
		{
			goto IL_0711;
		}
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ X8_v8+178] (should have been resolved before IL gen)");
		object obj5 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v54+E4]");
		object obj7;
		Func<int, int, int> selector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v54+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v53+28]");
			selector = (Func<int, int, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v53+28]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v53+28]");
				Func<int, int, int> func = (Func<int, int, int>)0;
				goto IL_01ae;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v54+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v53+28]");
			Func<int, int, int> func = (Func<int, int, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v53+28]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v53+28]");
			selector = (Func<int, int, int>)0;
			if (obj9 == null)
			{
				goto IL_01ae;
			}
		}
		goto IL_0748;
		IL_049c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v484 @ X0_v38] (should have been resolved before IL gen)");
		IEnumerable<int> enumerable = default(IEnumerable<int>);
		bool flag3 = enumerable == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_052d;
		}
		goto IL_0711;
		IL_0907:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v569 @ X0_v25] (should have been resolved before IL gen)");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v33 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+280]");
		object obj11 = 0;
		bool flag4 = OnBid(bidderIndex, bid);
		SendGameState();
		int[] bidders = Bidders;
		if (Bidders != null)
		{
			nint num2 = (nint)this;
			if (bidders.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v36 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+348]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v36 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+350]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v141 @ X3_v11 (should have been resolved before IL gen)");
			}
			if (flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v36 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+288]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v36 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+290]");
				object obj15 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v36 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1E8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v36 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+1F0]");
				object obj15 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X2_v13 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
		goto IL_0711;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		object obj18;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+B8]");
			obj18 = 0;
		}
		object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)3952;
		Func<int, bool> func2 = default(Func<int, bool>);
		func2..ctor(obj18, (IntPtr)obj20);
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v47+B8]");
		object obj22 = (nint)0 + (nint)48;
		obj22 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<int> enumerable2;
		IEnumerable<int> source = enumerable2;
		Func<int, bool> predicate = func2;
		goto IL_0802;
		IL_052d:
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1440;
		ISFSObject obj23 = <RoundState>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v11 (System.Collections.Generic.IEnumerable`1<System.Int32>)+20]");
		SFSExtensions.Put(obj23, (string)key, 0);
		ISFSObject iSFSObject = <RoundState>k__BackingField;
		if (<RoundState>k__BackingField == null)
		{
			goto IL_0711;
		}
		object obj24 = "alignContent" + 3552;
		nint num3 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v30 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v30 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0623;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v30 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj26 = (nint)0 + (nint)8;
		object obj27;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X10_v8-8]");
			if (0 == (nint)obj27)
			{
				break;
			}
			obj26 += 16;
			obj25--;
			if ((nint)obj25 != 1)
			{
				continue;
			}
			goto IL_0623;
		}
		object obj28 = obj26 + 44;
		object obj29 = num3 + obj28;
		object obj30 = obj29 + 312;
		goto IL_0907;
		IL_0623:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0907;
		IL_01ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v54+E4]");
		bool flag6 = (nint)0 == 0;
		object obj31 = !flag6;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj32 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v59+B8]");
			obj7 = 0;
		}
		object obj33 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)3944;
		Func<int, int, int> func3 = default(Func<int, int, int>);
		func3..ctor(obj7, (IntPtr)obj34);
		object obj35 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v58+B8]");
		object obj36 = (nint)0 + (nint)40;
		obj36 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func3;
		goto IL_0748;
		IL_0802:
		object obj37 = (nint)0 + (nint)3520;
		IEnumerable<int> source2 = Enumerable.Where(source, predicate);
		int[] array = Enumerable.ToArray(source2);
		object obj38 = this + 56;
		obj38 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X23_v9+20]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X23_v9+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v19+10]");
			RoundBidder = 0;
			ISFSObject iSFSObject2 = <RoundState>k__BackingField;
			if (<RoundState>k__BackingField != null)
			{
				obj27 = typeof(System.IOAsyncCallback) + 976;
				object obj40 = "java.io.FileOutputStream" + 1184;
				nint num4 = (nint)iSFSObject2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_049c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj42 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v13-8]");
					if (0 == (nint)obj27)
					{
						break;
					}
					obj42 += 16;
					obj41--;
					if ((nint)obj41 != 1)
					{
						continue;
					}
					goto IL_049c;
				}
				object obj43 = obj42 + 50;
				object obj44 = num4 + obj43;
				object obj45 = obj44 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ X0_v41] (should have been resolved before IL gen)");
				if (enumerable != null)
				{
					goto IL_052d;
				}
			}
		}
		goto IL_0711;
		IL_0711:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0748:
		object obj46 = (nint)0 + (nint)3472;
		IEnumerable<int> enumerable3 = Enumerable.Select(enumerable, selector);
		object obj47 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v42+30]");
			predicate = (Func<int, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v42+30]");
			bool flag7 = (nint)0 == 0;
			object obj48 = !flag7;
			source = enumerable3;
			if (obj48 == null)
			{
				enumerable2 = enumerable3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v42+30]");
				Func<int, bool> func4 = (Func<int, bool>)0;
				goto IL_0309;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj47 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v42+30]");
			Func<int, bool> func4 = (Func<int, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v42+30]");
			bool flag8 = (nint)0 == 0;
			object obj49 = !flag8;
			enumerable2 = enumerable3;
			source = enumerable3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v42+30]");
			predicate = (Func<int, bool>)0;
			if (obj49 == null)
			{
				goto IL_0309;
			}
		}
		goto IL_0802;
	}

	protected virtual bool OnBid(int bidderIndex, string bid)
	{
		return true;
	}

	protected virtual void OnEndBidding()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d5: Expected I, but got O
		//IL_02e5: Expected O, but got I
		//IL_0320: Expected O, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0441: Expected O, but got I
		//IL_0449: Expected I, but got O
		//IL_0459: Expected O, but got I
		//IL_0494: Expected O, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0529: Expected I, but got O
		//IL_0539: Expected O, but got I
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_0574: Expected O, but got I
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0609: Expected I, but got O
		//IL_0619: Expected O, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_0654: Expected O, but got I
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_06e9: Expected I, but got O
		//IL_06f9: Expected O, but got I
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_09cb: Expected I, but got O
		//IL_0734: Expected O, but got I
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		ISFSObject iSFSObject = <RoundState>k__BackingField;
		object obj;
		BiddingManager biddingManager;
		object obj8;
		if (<RoundState>k__BackingField != null)
		{
			obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "java.io.FileOutputStream" + 1184;
			nint num = (nint)iSFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v37-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 2;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v54+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v326 @ X0_v54] (should have been resolved before IL gen)");
			biddingManager = BiddingManager;
			if (BiddingManager != null)
			{
				goto IL_0185;
			}
		}
		goto IL_07b2;
		IL_09b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v739 @ X0_v29] (should have been resolved before IL gen)");
		SendGameState();
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v381 @ X8_v42 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+358] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_07b2:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_095f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v672 @ X0_v26] (should have been resolved before IL gen)");
		ISFSObject iSFSObject2 = <RoundState>k__BackingField;
		if (<RoundState>k__BackingField == null)
		{
			goto IL_07b2;
		}
		object obj9 = "placementId" + 2304;
		nint num3 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0775;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v38 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X10_v12-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0775;
		}
		object obj12 = obj11 + 35;
		object obj13 = num3 + obj12;
		object obj14 = obj13 + 312;
		goto IL_09b6;
		IL_0361:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0838;
		IL_0695:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_095f;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v51+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ X0_v51] (should have been resolved before IL gen)");
		biddingManager = BiddingManager;
		bool flag = BiddingManager == null;
		object obj15 = !flag;
		if (obj15 != null)
		{
			goto IL_0185;
		}
		goto IL_07b2;
		IL_0185:
		RoundBidder = biddingManager.<Bidder>k__BackingField;
		OfflinePlayer[] players = Players;
		if (Players != null && players[0] != null)
		{
			object cards = players[0] + 24;
			List<Card> list = SortCards((List<Card>)cards);
			cards = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			OfflinePlayer[] players2 = Players;
			if (Players != null)
			{
				OfflinePlayer offlinePlayer = players2[0];
				if (players2[0] != null)
				{
					ISFSObject iSFSObject3 = <RoundState>k__BackingField;
					int[] array = CardsToInt(offlinePlayer.<Cards>k__BackingField);
					if (<RoundState>k__BackingField != null)
					{
						object obj16 = "not" + 3720;
						nint num4 = (nint)iSFSObject3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0361;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X10_v32-8]");
							if (0 == (nint)obj)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_0361;
						}
						object obj19 = obj18 + 44;
						object obj20 = num4 + obj19;
						object obj21 = obj20 + 312;
						goto IL_0838;
					}
				}
			}
		}
		goto IL_07b2;
		IL_0838:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X0_v13] (should have been resolved before IL gen)");
		OfflinePlayer[] players3 = Players;
		object fldHandle;
		if (Players != null)
		{
			OfflinePlayer offlinePlayer2 = players3[0];
			if (players3[0] != null)
			{
				ISFSObject iSFSObject4 = <RoundState>k__BackingField;
				int[] array2 = CardsToInt(offlinePlayer2.<Cards>k__BackingField);
				if (<RoundState>k__BackingField != null)
				{
					object obj22 = "placementId" + 520;
					object obj23 = typeof(TypeConverter<ushort, char>) + 3048;
					fldHandle = (nint)0 + (nint)1784;
					nint num5 = (nint)iSFSObject4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_04d5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
					object obj25 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X10_v27-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj25 += 16;
						obj24--;
						if ((nint)obj24 != 1)
						{
							continue;
						}
						goto IL_04d5;
					}
					object obj26 = obj25 + 44;
					object obj27 = num5 + obj26;
					object obj28 = obj27 + 312;
					goto IL_088f;
				}
			}
		}
		goto IL_07b2;
		IL_04d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_088f;
		IL_088f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v18] (should have been resolved before IL gen)");
		ISFSObject iSFSObject5 = <RoundState>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array3 = default(Array);
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)fldHandle);
		if (<RoundState>k__BackingField == null)
		{
			goto IL_07b2;
		}
		object obj29 = "not" + 3728;
		nint num6 = (nint)iSFSObject5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X10_v22-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_05b5;
		}
		object obj32 = obj31 + 44;
		object obj33 = num6 + obj32;
		object obj34 = obj33 + 312;
		goto IL_08fd;
		IL_0775:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09b6;
		IL_05b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08fd;
		IL_08fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v606 @ X0_v23] (should have been resolved before IL gen)");
		<GameStatus>k__BackingField = CardGameStage.CardGameStages.Playing;
		ISFSObject iSFSObject6 = <RoundState>k__BackingField;
		if (<RoundState>k__BackingField == null)
		{
			goto IL_07b2;
		}
		object obj35 = "fetch_products" + 1824;
		nint num7 = (nint)iSFSObject6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0695;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v33 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v17-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj37 += 16;
			obj36--;
			if ((nint)obj36 != 1)
			{
				continue;
			}
			goto IL_0695;
		}
		object obj38 = obj37 + 35;
		object obj39 = num7 + obj38;
		object obj40 = obj39 + 312;
		goto IL_095f;
	}

	protected void EatCard(ISFSObject param)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0057: Expected I, but got O
		//IL_0067: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0219: Expected O, but got I
		//IL_0254: Expected O, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e9: Expected I, but got O
		//IL_02f9: Expected O, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0334: Expected O, but got I
		//IL_03c0: Expected O, but got I4
		//IL_03db: Expected O, but got I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_040e: Expected O, but got I
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_053a: Expected I, but got O
		//IL_054a: Expected O, but got I
		//IL_0585: Expected O, but got I
		//IL_060c: Expected I, but got O
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		if (<GameStatus>k__BackingField != CardGameStage.CardGameStages.WaitingForEating)
		{
			return;
		}
		int eatingPlayer = GetEatingPlayer();
		if (param == null)
		{
			goto IL_0616;
		}
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "placementId" + 112;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X10_v27-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00e3;
		}
		object obj5 = obj4 + 14;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0671;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_074b;
		IL_074b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v28] (should have been resolved before IL gen)");
		int[] teamEatings = TeamEatings;
		int playerTeam;
		if (TeamEatings != null)
		{
			object obj8 = playerTeam - 1;
			bool flag = (nint)obj8 < teamEatings.Length;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_0624;
			}
			object obj10 = (object)TeamEatings + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v33+20]");
			object obj11 = (nint)0 + (nint)1;
			if (!OnEatCard(eatingPlayer, playerTeam))
			{
				return;
			}
			int val = ++MoveNumber;
			object key = "m_StencilDeferredPS" + 2168;
			SFSExtensions.Put(<RoundState>k__BackingField, (string)key, val);
			<GameStatus>k__BackingField = CardGameStage.CardGameStages.Playing;
			object key2 = "fetch_products" + 1824;
			SFSExtensions.Put(<RoundState>k__BackingField, (string)key2, 2);
			object obj12 = typeof(TypeConverter<ushort, char>) + 1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj13 = this + 64;
			object obj14 = default(object);
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ISFSObject iSFSObject = <RoundState>k__BackingField;
			int[] array = CardsToInt((IEnumerable<Card>)obj13);
			if (<RoundState>k__BackingField != null)
			{
				object obj15 = "placementId" + 104;
				nint num2 = (nint)iSFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v45 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v45 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05c6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v45 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X10_v12-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_05c6;
				}
				object obj18 = obj17 + 44;
				object obj19 = num2 + obj18;
				object obj20 = obj19 + 312;
				goto IL_07a2;
			}
		}
		goto IL_0616;
		IL_0624:
		throw new IndexOutOfRangeException();
		IL_05c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07a2;
		IL_0295:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06d8;
		IL_07a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v671 @ X0_v41] (should have been resolved before IL gen)");
		SendGameState();
		PlayingManager playingManager = PlayingManager;
		if (PlayingManager != null)
		{
			nint num3 = (nint)playingManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v312 @ X8_v49 (Il2CppClass<KammelnaOffline.Common.PlayingManager>)+188] (should have been resolved before IL gen)");
		}
		goto IL_0616;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0671;
		IL_0671:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X0_v9] (should have been resolved before IL gen)");
		playerTeam = BalootUtils.GetPlayerTeam(eatingPlayer);
		int num4 = default(int);
		int playerTeam2 = BalootUtils.GetPlayerTeam(num4);
		if (playerTeam2 != playerTeam)
		{
			return;
		}
		object obj21 = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj22 = this + 136;
		obj22 = sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object key3 = "___# Content push apply failed [{0}]: {1}" + 3152;
		object val2 = "___# Content push apply failed [{0}]: {1}" + 2680;
		SFSExtensions.Put((ISFSObject)obj22, (string)key3, (string)val2);
		object key4 = "alignContent" + 680;
		SFSExtensions.Put((ISFSObject)obj22, (string)key4, num4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X23_v6+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X23_v6+8]");
		if ((nint)0 == 0)
		{
			goto IL_0616;
		}
		object obj24 = "java.io.FileOutputStream" + 1184;
		object obj25 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v23+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v23+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0295;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v23+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X10_v22-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_0295;
		}
		object obj28 = obj27 + 50;
		object obj29 = obj25 + obj28;
		object obj30 = obj29 + 312;
		goto IL_06d8;
		IL_06d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v508 @ X0_v22] (should have been resolved before IL gen)");
		ISFSObject iSFSObject2 = <RoundState>k__BackingField;
		IEnumerable<Card> playableCards = GetPlayableCards(firstMove: true);
		int[] array2 = CardsToInt(playableCards);
		if (<RoundState>k__BackingField == null)
		{
			goto IL_0616;
		}
		object obj31 = "placementId" + 520;
		nint num5 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0375;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v17-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_0375;
		}
		object obj34 = obj33 + 44;
		object obj35 = num5 + obj34;
		object obj36 = obj35 + 312;
		goto IL_074b;
		IL_0616:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0624;
	}

	protected virtual bool OnEatCard(int playerWillEat, int eaterTeam)
	{
		return true;
	}

	protected virtual void SendRoundStart()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2008;
		object cmd = "setMimeType" + 3704;
		object obj2 = typeof(Queue<string>) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, <RoundState>k__BackingField);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
	}

	public virtual void SendGameState()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2008;
		object cmd = "fetch_products" + 2456;
		object obj2 = typeof(Queue<string>) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, <RoundState>k__BackingField);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
	}

	protected virtual void SendEndRound(ISFSObject endRoundState)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0137: Expected O, but got I
		//IL_0067: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2008;
		object cmd = "destinationTimeZone" + 2656;
		object obj2 = typeof(Queue<string>) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, endRoundState);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
	}

	protected virtual void SendEndGame(SFSObject endGameState)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0137: Expected O, but got I
		//IL_0067: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2008;
		object cmd = "destinationTimeZone" + 1656;
		object obj2 = typeof(Queue<string>) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, endGameState);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
	}

	protected abstract void OnStartRound();

	protected virtual void DiscardOfflineGame()
	{
		OfflineUserInfo.DiscardGame();
	}

	protected virtual void UpdateOfflineGameStats()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0024: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_0212: Expected O, but got I4
		CachedUserInfoModel currentGameUserModel = OfflineUserInfo.CurrentGameUserModel;
		object obj2 = default(object);
		object obj3;
		if (currentGameUserModel != null)
		{
			bool flag = currentGameUserModel.GameStatistics == null;
			object obj = !flag;
			obj2 = currentGameUserModel;
			obj3 = currentGameUserModel.GameStatistics;
			if (obj != null)
			{
				goto IL_0080;
			}
		}
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj2..ctor();
		obj3 = obj2;
		goto IL_0080;
		IL_00fc:
		object obj5 = typeof(MemberAchievementClanFeedData) + 3272;
		CachedUserInfoModel currentGameUserModel2;
		object obj6 = currentGameUserModel2 + 96;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		OfflineUserInfo.CurrentGameUserModel = currentGameUserModel2;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v16+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X8_v18+18] (should have been resolved before IL gen)");
		}
		OfflineUserInfo.DiscardGame();
		return;
		IL_00ee:
		currentGameUserModel2 = OfflineUserInfo.CurrentGameUserModel;
		goto IL_00fc;
		IL_0080:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X19_v3 (System.Object)+10]");
		object obj10 = (nint)0 + (nint)1;
		if (Team1TotalScore <= Team2TotalScore)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8076]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00ee;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X19_v3 (System.Object)+14]");
			object obj12 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8076]");
			object obj13 = (nint)0 & (nint)1;
			bool flag2 = obj13 == null;
			object obj14 = !flag2;
			if (obj14 != null)
			{
				goto IL_00ee;
			}
		}
		_ = 1;
		currentGameUserModel2 = OfflineUserInfo.CurrentGameUserModel;
		bool flag3 = currentGameUserModel2 == null;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fc;
	}

	protected virtual void BuildRoundState()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected O, but got Unknown
		//IL_0ec6: Expected O, but got I
		//IL_0f04: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_13a9: Expected O, but got I
		//IL_13ca: Expected O, but got I
		//IL_13f4: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0260: Expected I, but got O
		//IL_0270: Expected O, but got I
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f63: Expected O, but got Unknown
		//IL_0f79: Expected O, but got I
		//IL_0f8a: Expected I, but got O
		//IL_0f8a: Expected O, but got I
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Expected O, but got Unknown
		//IL_0fa6: Expected I, but got O
		//IL_0fbc: Expected O, but got I
		//IL_024b: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_1026: Expected I, but got O
		//IL_02ab: Expected O, but got I
		//IL_0376: Expected I, but got O
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_03d6: Expected I, but got O
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_040a: Expected I, but got O
		//IL_041a: Expected O, but got I
		//IL_10a3: Expected I, but got O
		//IL_0455: Expected O, but got I
		//IL_0528: Expected I, but got O
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_057d: Expected I, but got O
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05cf: Expected I, but got O
		//IL_05df: Expected O, but got I
		//IL_10dd: Expected I, but got O
		//IL_061a: Expected O, but got I
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_06ff: Expected I, but got O
		//IL_070f: Expected O, but got I
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_1155: Expected I, but got O
		//IL_075e: Expected O, but got I
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_0815: Expected O, but got I
		//IL_082b: Expected O, but got I
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_086a: Unsupported input type for neg.
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected O, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_1197: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Expected I, but got Unknown
		//IL_11bb: Expected O, but got I
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_08a2: Expected I, but got O
		//IL_08b2: Expected O, but got I
		//IL_120c: Expected I, but got O
		//IL_08ed: Expected O, but got I
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected O, but got Unknown
		//IL_0aa8: Expected O, but got I
		//IL_0ab8: Expected O, but got I
		//IL_0adb: Expected O, but got I4
		//IL_0ae4: Expected O, but got I4
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		//IL_0a1b: Expected O, but got I
		//IL_0a2b: Expected O, but got I
		//IL_0a4d: Expected O, but got I4
		//IL_0a56: Expected O, but got I4
		//IL_0b1c: Expected O, but got I4
		//IL_0d05: Expected O, but got I
		//IL_0d25: Expected O, but got I
		//IL_0d47: Expected O, but got I4
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Expected O, but got Unknown
		//IL_1274: Expected O, but got I
		//IL_1285: Expected I, but got O
		//IL_12a3: Expected O, but got I
		//IL_12be: Expected O, but got I4
		//IL_0bb5: Expected O, but got I
		//IL_0bd5: Expected O, but got I
		//IL_0b4c: Expected O, but got I
		//IL_0d87: Expected O, but got I4
		//IL_0c4c: Expected I, but got O
		//IL_0c5c: Expected O, but got I
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Expected O, but got Unknown
		//IL_1343: Expected O, but got I
		//IL_1354: Expected I, but got O
		//IL_1354: Expected O, but got I
		//IL_1363: Unknown result type (might be due to invalid IL or missing references)
		//IL_1368: Expected O, but got Unknown
		//IL_1370: Expected I, but got O
		//IL_1386: Expected O, but got I
		//IL_0e07: Expected O, but got I4
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Expected O, but got Unknown
		//IL_130f: Expected O, but got I
		//IL_0c97: Expected O, but got I
		//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected O, but got Unknown
		//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Expected O, but got Unknown
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected O, but got Unknown
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8051]");
		nint num = 0;
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		IEnumerable<int> enumerable = (IEnumerable<int>)(this + 144);
		enumerable = (IEnumerable<int>)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		SFSObject sFSObject2 = default(SFSObject);
		bool flag = sFSObject2 == null;
		SFSObject sFSObject3 = sFSObject;
		object obj3;
		object obj5;
		object obj8;
		if (!flag)
		{
			_ = 6;
			enumerable = enumerable;
			bool flag2 = enumerable == null;
			num = 6;
			sFSObject3 = sFSObject2;
			if (!flag2)
			{
				obj3 = typeof(System.IOAsyncCallback) + 976;
				object obj4 = "setMimeType" + 3784;
				obj5 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_017b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32>>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X10_v44-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj8 = obj7 + 16;
					obj6--;
					bool flag3 = (nint)obj6 != 1;
					obj7 = obj8;
					if (flag3)
					{
						continue;
					}
					goto IL_017b;
				}
				object obj9 = obj7 + 44;
				object obj10 = num2 + obj9;
				object obj11 = obj10 + 312;
				obj8 = obj7;
				goto IL_0ea7;
			}
		}
		goto IL_0e15;
		IL_0ff7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ X0_v25] (should have been resolved before IL gen)");
		OfflinePlayer[] players = Players;
		bool flag4 = Players == null;
		num = (nint)Players;
		int[] array;
		object key;
		if (!flag4)
		{
			OfflinePlayer offlinePlayer = players[0];
			bool flag5 = players[0] == null;
			num = (nint)players[0];
			if (!flag5)
			{
				sFSObject3 = (SFSObject)<RoundState>k__BackingField;
				List<Card> cards = SortCards(offlinePlayer.<Cards>k__BackingField);
				array = CardsToInt(cards);
				bool flag6 = <RoundState>k__BackingField == null;
				num = (nint)players[0];
				if (!flag6)
				{
					object obj12 = "not" + 3720;
					key = "startPosition" + 1504;
					nint num3 = (nint)sFSObject3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_049e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
					object obj14 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X10_v34-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj8 = obj14 + 16;
						obj13--;
						bool flag7 = (nint)obj13 != 1;
						obj14 = obj8;
						if (flag7)
						{
							continue;
						}
						goto IL_049e;
					}
					object obj15 = obj14 + 44;
					object obj16 = num3 + obj15;
					object obj17 = obj16 + 312;
					obj8 = obj14;
					goto IL_1058;
				}
			}
		}
		goto IL_0e15;
		IL_1204:
		object obj18 = default(object);
		num = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1044 @ X0_v52] (should have been resolved before IL gen)");
		object key2;
		SFSExtensions.Put(<RoundState>k__BackingField, (string)key2, Dealer);
		object obj20;
		object obj22;
		Func<object, int> selector;
		object obj25;
		object obj24;
		object obj21;
		if (BiddingManager != null)
		{
			object key3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1440;
			IEnumerable<int> source = BiddingManager.StartBidding();
			int val = Enumerable.First(source);
			SFSExtensions.Put(<RoundState>k__BackingField, (string)key3, val);
			sFSObject3 = (SFSObject)<RoundState>k__BackingField;
			object obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v85+E4]");
			if ((nint)0 != 0)
			{
				obj21 = typeof(RegisteredWaitHandle) + 1888;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v85+B8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v74+40]");
				selector = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v74+40]");
				bool flag8 = (nint)0 == 0;
				object obj23 = !flag8;
				obj24 = 0;
				if (obj23 == null)
				{
					obj25 = obj21;
					goto IL_0afa;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj20;
				obj25 = typeof(RegisteredWaitHandle) + 1888;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v85+B8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v74+40]");
				selector = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v74+40]");
				bool flag9 = (nint)0 == 0;
				object obj26 = !flag9;
				obj24 = 0;
				obj21 = obj25;
				if (obj26 == null)
				{
					goto IL_0afa;
				}
			}
			goto IL_0b51;
		}
		goto IL_0e15;
		IL_0cd8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_12f7;
		IL_0663:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_10d5;
		IL_10d5:
		object obj27 = default(object);
		num = (nint)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v886 @ X0_v37] (should have been resolved before IL gen)");
		object key4;
		SFSExtensions.Put(<RoundState>k__BackingField, (string)key4, 0);
		object key5;
		SFSExtensions.Put(<RoundState>k__BackingField, (string)key5, (int)<GameStatus>k__BackingField);
		object key6;
		SFSExtensions.Put(<RoundState>k__BackingField, (string)key6, 2);
		sFSObject3 = (SFSObject)<RoundState>k__BackingField;
		int[] array2 = CardsToInt(PlayedCards);
		bool flag10 = <RoundState>k__BackingField == null;
		int[] array3;
		enumerable = array3;
		if (flag10)
		{
			goto IL_0e15;
		}
		object obj28 = "placementId" + 104;
		nint num4 = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj29 = 0;
		obj20 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X10_v24-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj8 = obj30 + 16;
			obj29--;
			bool flag11 = (nint)obj29 != 1;
			obj30 = obj8;
			if (flag11)
			{
				continue;
			}
			goto IL_07a7;
		}
		object obj31 = obj30 + 44;
		object obj32 = num4 + obj31;
		object obj33 = obj32 + 312;
		obj8 = obj30;
		goto IL_114d;
		IL_0c44:
		num = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0cd8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v10-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj8 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_0cd8;
		}
		object obj35 = obj8 + 49;
		object obj36 = num + obj35;
		object obj37 = obj36 + 312;
		goto IL_12f7;
		IL_017b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ea7;
		IL_0ea7:
		object obj38 = "not" + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v16+8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v578 @ X0_v16] (should have been resolved before IL gen)");
		sFSObject3 = (SFSObject)<RoundState>k__BackingField;
		object obj40 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj41 = !flag12;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj40 = obj5;
		}
		object obj42 = (nint)0 + (nint)3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v20+B8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+38]");
		Func<object, int> selector2 = (Func<object, int>)0;
		enumerable = (IEnumerable<int>)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+38]");
		bool flag13 = (nint)0 == 0;
		object obj43 = !flag13;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v20+E4]");
			bool flag14 = (nint)0 == 0;
			object obj44 = !flag14;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj45 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
				object obj46 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v101+B8]");
				num = 0;
			}
			object obj47 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj48 = (nint)0 + (nint)3960;
			Func<object, int> func = default(Func<object, int>);
			func..ctor((object)num, (IntPtr)obj48);
			object obj49 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
			num = (nint)obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B8]");
			object obj50 = (nint)0 + (nint)56;
			obj50 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj39 = 0;
			selector2 = func;
		}
		IEnumerable<int> source2 = Enumerable.Select(Players, selector2);
		int[] array4 = Enumerable.ToArray(source2);
		if (sFSObject3 == null)
		{
			goto IL_0e15;
		}
		nint num5 = (nint)sFSObject3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj52 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v39-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj8 = obj52 + 16;
			obj51--;
			bool flag15 = (nint)obj51 != 1;
			obj52 = obj8;
			if (flag15)
			{
				continue;
			}
			goto IL_02f4;
		}
		object obj53 = obj52 + 44;
		object obj54 = num5 + obj53;
		object obj55 = obj54 + 312;
		obj8 = obj52;
		goto IL_0ff7;
		IL_0afa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v85+E4]");
		bool flag16 = (nint)0 == 0;
		object obj56 = !flag16;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj57 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X8_v80+B8]");
			obj22 = 0;
		}
		object obj58 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj59 = (nint)0 + (nint)3968;
		Func<object, int> func2 = default(Func<object, int>);
		func2..ctor(obj22, (IntPtr)obj59);
		object obj60 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X8_v79+B8]");
		object obj61 = (nint)0 + (nint)64;
		obj61 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj24 = 0;
		selector = func2;
		obj21 = obj25;
		goto IL_0b51;
		IL_1319:
		object obj62 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj63 = (nint)0 + (nint)3976;
		Func<object, int, object> func3 = default(Func<object, int, object>);
		nint num6;
		func3..ctor((object)num6, (IntPtr)obj63);
		object obj64 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
		num = (nint)obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B8]");
		object obj65 = (nint)0 + (nint)72;
		obj65 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj67;
		object obj66 = obj67;
		IEnumerable<int> source3;
		SFSArray sFSArray = default(SFSArray);
		object obj68 = Enumerable.Aggregate(source3, sFSArray, func3);
		bool flag17 = sFSObject3 == null;
		object obj69 = !flag17;
		if (obj69 != null)
		{
			goto IL_0c44;
		}
		goto IL_0e15;
		IL_049e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1058;
		IL_0b51:
		source3 = Enumerable.Select(Players, selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		sFSArray..ctor();
		object obj70 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v67+E4]");
		object obj71;
		Func<object, int, object> func4;
		if ((nint)0 != 0)
		{
			obj71 = (nint)0 + (nint)1784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v67+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+48]");
			func4 = (Func<object, int, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+48]");
			bool flag18 = (nint)0 == 0;
			obj67 = obj71;
			num6 = num;
			if (!flag18)
			{
				goto IL_0c0a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj70 = obj20;
			obj71 = (nint)0 + (nint)1784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v67+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+48]");
			func4 = (Func<object, int, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+48]");
			bool flag19 = (nint)0 == 0;
			object obj72 = !flag19;
			obj67 = obj71;
			num6 = num;
			if (obj72 != null)
			{
				goto IL_0c0a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v67+E4]");
		bool flag20 = (nint)0 == 0;
		object obj73 = !flag20;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj74 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
			object obj75 = obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X8_v66+B8]");
			num6 = 0;
		}
		goto IL_1319;
		IL_1058:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X0_v31] (should have been resolved before IL gen)");
		SFSExtensions.Put(<RoundState>k__BackingField, (string)key, val: false);
		OfflinePlayer[] players2 = Players;
		bool flag21 = Players == null;
		enumerable = array;
		num = (nint)Players;
		if (!flag21)
		{
			OfflinePlayer offlinePlayer2 = players2[0];
			bool flag22 = players2[0] == null;
			enumerable = array;
			num = (nint)players2[0];
			if (!flag22)
			{
				sFSObject3 = (SFSObject)<RoundState>k__BackingField;
				array3 = CardsToInt(offlinePlayer2.<Cards>k__BackingField);
				bool flag23 = <RoundState>k__BackingField == null;
				enumerable = array;
				num = (nint)players2[0];
				if (!flag23)
				{
					object obj76 = "placementId" + 520;
					key4 = "utf-32" + 1200;
					key5 = "fetch_products" + 1824;
					key6 = "getSecondRescanTask" + 1808;
					nint num7 = (nint)sFSObject3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0663;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
					object obj78 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X10_v29-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj8 = obj78 + 16;
						obj77--;
						bool flag24 = (nint)obj77 != 1;
						obj78 = obj8;
						if (flag24)
						{
							continue;
						}
						goto IL_0663;
					}
					object obj79 = obj78 + 44;
					object obj80 = num7 + obj79;
					obj27 = obj80 + 312;
					obj8 = obj78;
					goto IL_10d5;
				}
			}
		}
		goto IL_0e15;
		IL_0e15:
		throw new NullReferenceException();
		IL_0936:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1204;
		IL_12f7:
		object obj81 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v8+8]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v463 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_1319;
		IL_07a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_114d;
		IL_114d:
		num = (nint)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v966 @ X0_v45] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj83 = default(object);
		bool flag25 = obj83 == null;
		enumerable = array2;
		if (!flag25)
		{
			enumerable = (IEnumerable<int>)(this + 56);
			enumerable = (IEnumerable<int>)obj83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v5 (System.Collections.Generic.IEnumerable`1<System.Int32>)-28]");
			object obj84 = (nint)0 & (nint)3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v5 (System.Collections.Generic.IEnumerable`1<System.Int32>)-28]");
			object obj85 = -0;
			object obj86 = obj85 & 3;
			object obj87 = ((0 >= (nint)obj85) ? ((object)(0 - obj86)) : obj84);
			num = (nint)(obj87 + 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v5 (System.Collections.Generic.IEnumerable`1<System.Int32>)+58]");
			sFSObject3 = (SFSObject)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v5 (System.Collections.Generic.IEnumerable`1<System.Int32>)+58]");
			if ((nint)0 != 0)
			{
				object obj88 = "alignContent" + 3552;
				key2 = "com.unity.services.authentication.profile" + 3432;
				enumerable = enumerable;
				nint num8 = (nint)sFSObject3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v48 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				object obj89 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v48 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0936;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v48 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
				object obj90 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X10_v19-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj8 = obj90 + 16;
					obj89--;
					bool flag26 = (nint)obj89 != 1;
					obj90 = obj8;
					if (flag26)
					{
						continue;
					}
					goto IL_0936;
				}
				object obj91 = obj90 + 44;
				object obj92 = num8 + obj91;
				obj18 = obj92 + 312;
				obj8 = obj90;
				goto IL_1204;
			}
		}
		goto IL_0e15;
		IL_0c0a:
		obj66 = obj71;
		obj68 = Enumerable.Aggregate(source3, sFSArray, func4);
		if (sFSObject3 != null)
		{
			goto IL_0c44;
		}
		goto IL_0e15;
		IL_02f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ff7;
	}

	public static int[] CardsToInt(IEnumerable<Card> cards)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_0193: Expected I, but got O
		//IL_01b1: Expected O, but got I
		//IL_00ba: Expected O, but got I
		if (cards != null)
		{
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+50]");
			Func<object, int> selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+50]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)3984;
				Func<object, int> func = default(Func<object, int>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)80;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<int> source = Enumerable.Select(cards, selector);
			return Enumerable.ToArray(source);
		}
		return null;
	}

	protected List<Card> SortCards(List<Card> cards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0176: Expected O, but got I
		//IL_0187: Expected I, but got O
		//IL_01a5: Expected O, but got I
		//IL_00c8: Expected I, but got O
		//IL_0082: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1496;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)2056;
		object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+58]");
		Func<object, System.Int32Enum> keySelector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+58]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v14+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)4008;
			Func<object, System.Int32Enum> func = default(Func<object, System.Int32Enum>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v13+B8]");
			object obj13 = (nint)0 + (nint)88;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func;
		}
		IOrderedEnumerable<object> source = Enumerable.OrderBy(cards, keySelector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		if (this != null)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6 (Il2CppClass<KammelnaOffline.Common.OfflineGameController>)+3B0]");
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor((object)this, (IntPtr)0);
			IOrderedEnumerable<object> source2 = Enumerable.ThenBy(source, func2);
			return (List<Card>)(object)Enumerable.ToList(source2);
		}
		return (List<Card>)(object)new NullReferenceException();
	}

	public int CompareCards(Card card1, Card card2)
	{
		int offlineValue = GetOfflineValue(card2);
		int offlineValue2 = GetOfflineValue(card1);
		return offlineValue - offlineValue2;
	}

	private void ShowSawa(ISFSObject param)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00bb: Expected I, but got O
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0112: Expected I, but got O
		//IL_0122: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0206: Expected I, but got O
		//IL_0216: Expected O, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0438: Expected O, but got I4
		//IL_0251: Expected O, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0452: Expected O, but got I
		//IL_0462: Expected O, but got I
		//IL_0481: Expected O, but got I
		//IL_031d: Expected O, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1504;
		object obj2 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass67_0 <>c__DisplayClass67_ = default(<>c__DisplayClass67_0);
		<>c__DisplayClass67_..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2864;
		object obj4 = (nint)0 + (nint)4032;
		object obj5 = (nint)0 + (nint)2224;
		object obj6 = typeof(RegisteredWaitHandle) + 2040;
		object obj7 = <>c__DisplayClass67_ + 16;
		obj7 = sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass67_, (IntPtr)obj4);
		ArraysExtensions.ForEach(Players, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj8 = typeof(System.IOAsyncCallback) + 976;
		object key = "placementId" + 112;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X10_v12-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_019e;
		}
		object obj11 = obj10 + 14;
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		goto IL_039d;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_039d;
		IL_039d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ X0_v15] (should have been resolved before IL gen)");
		int val = default(int);
		SFSExtensions.Put(sFSObject, (string)key, val);
		object obj14 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2424;
		object obj15 = typeof(RegisteredWaitHandle) + 2008;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0292;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v7-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_0292;
		}
		object obj18 = obj17 + 49;
		object obj19 = num2 + obj18;
		object obj20 = obj19 + 312;
		goto IL_03e1;
		IL_03e1:
		object cmd = "rightCtrl" + 1032;
		object obj21 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v19] (should have been resolved before IL gen)");
		object obj22 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v23+E4]");
		bool flag = (nint)0 == 0;
		object obj23 = !flag;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj15;
		}
		object obj24 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v23+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v13+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, sFSObject);
		object obj26 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v27+E4]");
		bool flag2 = (nint)0 == 0;
		object obj27 = !flag2;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
		return;
		IL_0292:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03e1;
	}

	private void ShowKasho(ISFSObject param)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00bb: Expected I, but got O
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0112: Expected I, but got O
		//IL_0122: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0206: Expected I, but got O
		//IL_0216: Expected O, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0438: Expected O, but got I4
		//IL_0251: Expected O, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0452: Expected O, but got I
		//IL_0462: Expected O, but got I
		//IL_0481: Expected O, but got I
		//IL_031d: Expected O, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1512;
		object obj2 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass68_0 <>c__DisplayClass68_ = default(<>c__DisplayClass68_0);
		<>c__DisplayClass68_..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray = default(SFSArray);
		sFSArray..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2864;
		object obj4 = (nint)0 + (nint)4040;
		object obj5 = (nint)0 + (nint)2224;
		object obj6 = typeof(RegisteredWaitHandle) + 2040;
		object obj7 = <>c__DisplayClass68_ + 16;
		obj7 = sFSArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass68_, (IntPtr)obj4);
		ArraysExtensions.ForEach(Players, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj8 = typeof(System.IOAsyncCallback) + 976;
		object key = "placementId" + 112;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X10_v12-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_019e;
		}
		object obj11 = obj10 + 14;
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		goto IL_039d;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_039d;
		IL_039d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ X0_v15] (should have been resolved before IL gen)");
		int val = default(int);
		SFSExtensions.Put(sFSObject, (string)key, val);
		object obj14 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2424;
		object obj15 = typeof(RegisteredWaitHandle) + 2008;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0292;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v7-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_0292;
		}
		object obj18 = obj17 + 49;
		object obj19 = num2 + obj18;
		object obj20 = obj19 + 312;
		goto IL_03e1;
		IL_03e1:
		object cmd = "java.io.FileOutputStream" + 552;
		object obj21 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v19] (should have been resolved before IL gen)");
		object obj22 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v23+E4]");
		bool flag = (nint)0 == 0;
		object obj23 = !flag;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj15;
		}
		object obj24 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v23+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v13+D8]");
		SFSEvent sFSEvent = default(SFSEvent);
		sFSEvent..ctor((string)0);
		SFSExtensions.PutCommand(sFSEvent, (string)cmd);
		SFSExtensions.PutResponseParams(sFSEvent, sFSObject);
		object obj26 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v27+E4]");
		bool flag2 = (nint)0 == 0;
		object obj27 = !flag2;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SFS sFS = default(SFS);
		sFS.SFS_OnExtensionResponse(sFSEvent);
		return;
		IL_0292:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03e1;
	}

	protected virtual void CatchCheating(ISFSObject sfsObject)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public virtual void Play(int playerIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0081: Expected O, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f9: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		OfflinePlayer[] players = Players;
		if (Players != null)
		{
			object obj = playerIndex - 1;
			bool flag = (nint)obj < players.Length;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_01d0;
			}
			object obj3 = (object)Players + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+20]");
			AIAgent playerAi = GetPlayerAi((OfflinePlayer)0);
			if (playerAi != null)
			{
				(string, ISFSObject) playerAction = playerAi.GetPlayerAction();
				OfflineRoom offlineRoom = <Room>k__BackingField;
				if (<Room>k__BackingField != null)
				{
					IRoomExtension roomExtension = offlineRoom.RoomExtension;
					if (offlineRoom.RoomExtension != null)
					{
						object obj4 = typeof(System.IOAsyncCallback) + 928;
						nint num = (nint)roomExtension;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v9 (Il2CppClass<KammelnaOffline.OfflineServer.IRoomExtension>)+12E]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v9 (Il2CppClass<KammelnaOffline.OfflineServer.IRoomExtension>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0185;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v9 (Il2CppClass<KammelnaOffline.OfflineServer.IRoomExtension>)+B0]");
						object obj6 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X10_v8-8]");
							if (0 == (nint)obj4)
							{
								break;
							}
							obj6 += 16;
							obj5--;
							if ((nint)obj5 != 1)
							{
								continue;
							}
							goto IL_0185;
						}
						object obj7 = obj6 + 2;
						object obj8 = num + obj7;
						object obj9 = obj8 + 312;
						goto IL_022a;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01d0;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_022a;
		IL_01d0:
		throw new IndexOutOfRangeException();
		IL_022a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v227 @ X0_v8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void DoNextBidding(int[] biddingStates)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		//IL_00d9: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass71_0 <>c__DisplayClass71_ = default(<>c__DisplayClass71_0);
		<>c__DisplayClass71_..ctor();
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)4048;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = <>c__DisplayClass71_ + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass71_ + 24;
		obj6 = biddingStates;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(<>c__DisplayClass71_, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.7f, action);
	}

	protected virtual void StartPlaying()
	{
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		PlayingManager.CopyCards();
		PlayingManager playingManager = PlayingManager;
		nint num = (nint)playingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3 (Il2CppClass<KammelnaOffline.Common.PlayingManager>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3 (Il2CppClass<KammelnaOffline.Common.PlayingManager>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected AIAgent GetPlayerAi(OfflinePlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass73_0 <>c__DisplayClass73_ = default(<>c__DisplayClass73_0);
		<>c__DisplayClass73_..ctor();
		if (<>c__DisplayClass73_ != null)
		{
			object obj2 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 4024;
			object obj3 = (nint)0 + (nint)4056;
			object obj4 = <>c__DisplayClass73_ + 16;
			obj4 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>c__DisplayClass73_, (IntPtr)obj3);
			return (AIAgent)Enumerable.FirstOrDefault(AiAgents, func);
		}
		return (AIAgent)(object)new NullReferenceException();
	}

	protected abstract OfflinePlayer CreatePlayer(int index);

	protected abstract AbstractAiLogic CreateAiLogic();

	protected abstract PlayingManager CreatePlayingManager();

	protected abstract BiddingManager CreateBiddingManager();

	protected abstract int CardValue(Card card);

	public abstract int GetOfflineValue(Card card);

	protected abstract bool IsGameOver();

	protected abstract void OnEndRound();

	protected abstract int GetEatingPlayer();

	protected abstract List<Card> GetPlayableCards(bool firstMove);

	protected abstract string GetBiddingFromSfsParam(ISFSObject param);

	protected OfflineGameController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 64;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
