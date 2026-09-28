using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;

public abstract class CardGame : KGame
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Card, bool> <>9__47_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_CardsOnFloor>b__47_0(Card c)
		{
			bool flag = c == null;
			return !flag;
		}
	}

	public const string CARD = "card";

	public const string PROJECTS = "prj";

	public const string RankReport = "rank_report";

	public const string GAME_STAGE = "gStg";

	public const string ACCEPTED_NEXT_PLAYERS = "anp";

	public const string PLAYED_CARDS = "played_cards";

	public const string CURRENT_Suit = "current_suit";

	public const string TRUMP_Suit = "ts";

	public const string ROUND_BIDDER = "rb";

	public const string MOVE_NUMBER = "mn";

	public const string DEALER = "dealer";

	public const string BIDDERS = "b";

	public const string SAWA_ALLOWED = "sw";

	private const string ORDERED_PLAYED_CARDS = "opc";

	private const string ORDERED_PLAY_INDEX = "opi";

	private Suit <CurrentSuit>k__BackingField;

	private Suit <TrumpSuit>k__BackingField;

	private readonly CardGameStage <Stage>k__BackingField;

	private List<int> <Bidders>k__BackingField;

	private List<int> <AcceptedNextPlayers>k__BackingField;

	private List<Card> <PlayedCards>k__BackingField;

	private List<Card> <OrderedPlayedCards>k__BackingField;

	private List<int> <OrderedPlayIndex>k__BackingField;

	private int <RoundBidder>k__BackingField;

	private int <MoveNumber>k__BackingField;

	private int <Dealer>k__BackingField;

	private bool <SawaAllowed>k__BackingField;

	private Action<CardGameEndScores> m_OnCardGameEnd;

	private Action<CardGameStage.CardGameStages, CardGameStage.CardGameStages, ISFSObject> m_OnStageChanged;

	public Suit CurrentSuit
	{
		get
		{
			return <CurrentSuit>k__BackingField;
		}
		private set
		{
			<CurrentSuit>k__BackingField = value;
		}
	}

	public Suit TrumpSuit
	{
		get
		{
			return <TrumpSuit>k__BackingField;
		}
		private set
		{
			<TrumpSuit>k__BackingField = value;
		}
	}

	public CardGameStage Stage => <Stage>k__BackingField;

	public List<int> Bidders
	{
		get
		{
			return <Bidders>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<Bidders>k__BackingField = value;
			object obj = this + 296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<int> AcceptedNextPlayers
	{
		get
		{
			return <AcceptedNextPlayers>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<AcceptedNextPlayers>k__BackingField = value;
			object obj = this + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> PlayedCards
	{
		get
		{
			return <PlayedCards>k__BackingField;
		}
		protected set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<PlayedCards>k__BackingField = value;
			object obj = this + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> OrderedPlayedCards
	{
		get
		{
			return <OrderedPlayedCards>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<OrderedPlayedCards>k__BackingField = value;
			object obj = this + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<int> OrderedPlayIndex
	{
		get
		{
			return <OrderedPlayIndex>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<OrderedPlayIndex>k__BackingField = value;
			object obj = this + 328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> CardsOnFloor
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
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3944;
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
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)2408;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> source = Enumerable.Where(<PlayedCards>k__BackingField, predicate);
			return (List<Card>)(object)Enumerable.ToList(source);
		}
	}

	public int RoundBidder
	{
		get
		{
			return <RoundBidder>k__BackingField;
		}
		private set
		{
			<RoundBidder>k__BackingField = value;
		}
	}

	public int MoveNumber
	{
		get
		{
			return <MoveNumber>k__BackingField;
		}
		private set
		{
			<MoveNumber>k__BackingField = value;
		}
	}

	public int Dealer
	{
		get
		{
			return <Dealer>k__BackingField;
		}
		private set
		{
			<Dealer>k__BackingField = value;
		}
	}

	public bool SawaAllowed
	{
		get
		{
			return <SawaAllowed>k__BackingField;
		}
		private set
		{
			<SawaAllowed>k__BackingField = value;
		}
	}

	public abstract ICardUtils GameCardUtils { get; }

	public new CardGameLastActionInfo LastAction
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			CardGameLastActionInfo cardGameLastActionInfo = (CardGameLastActionInfo)base.<LastAction>k__BackingField;
			if (base.<LastAction>k__BackingField != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 344;
				object obj2 = obj;
				nint num = (nint)cardGameLastActionInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGameLastActionInfo>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<CardGameLastActionInfo>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (CardGameLastActionInfo)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (CardGameLastActionInfo)base.<LastAction>k__BackingField;
		}
	}

	public int MyTeamIndex
	{
		get
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			object obj = base.<MySeatIndex>k__BackingField - 1;
			bool flag = (nint)obj < 3;
			object obj2 = !flag;
			object obj3 = obj - 3;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 118730752 + 3184;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X9_v2+v2 @ X8_v2*4]");
				return 0;
			}
			return 0;
		}
	}

	public int MyOpponentIndex
	{
		get
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			object obj = base.<MySeatIndex>k__BackingField - 1;
			bool flag = (nint)obj < 3;
			object obj2 = !flag;
			object obj3 = obj - 3;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 119877632 + 1712;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X9_v2+v2 @ X8_v2*4]");
				return 0;
			}
			return 0;
		}
	}

	public CardGamePlayer MyTeammate
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(base.<MySeatIndex>k__BackingField, 2, 1, 5);
			CardGamePlayer playerByIndex = (CardGamePlayer)GetPlayerByIndex(rotatedNextIndex);
			if (playerByIndex != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
				object obj2 = obj;
				nint num = (nint)playerByIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<CardGamePlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X1_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X1_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (CardGamePlayer)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return playerByIndex;
		}
	}

	public new CardGamePlayer MyPlayer
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			CardGamePlayer myPlayer = (CardGamePlayer)base.MyPlayer;
			if (myPlayer != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
				object obj2 = obj;
				nint num = (nint)myPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<CardGamePlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<CardGamePlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (CardGamePlayer)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return myPlayer;
		}
	}

	public event Action<CardGameEndScores> OnCardGameEnd
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
			Delegate obj2 = this.m_OnCardGameEnd;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 352;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
			Delegate obj2 = this.m_OnCardGameEnd;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 352;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<CardGameStage.CardGameStages, CardGameStage.CardGameStages, ISFSObject> OnStageChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1000;
			Delegate obj2 = this.m_OnStageChanged;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 1000;
			Delegate obj2 = this.m_OnStageChanged;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
	}

	protected override void UpdateGameState(ISFSObject gameState)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460320");
	}

	protected static List<Card> AssignPlayedCards(ISFSObject gameState)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_0147: Expected I, but got O
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj2;
		List<Card> list = default(List<Card>);
		List<Card> result;
		object obj8;
		object obj10;
		if (gameState != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			obj2 = "placementId" + 104;
			nint num = (nint)gameState;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v6-8]");
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
			object obj5 = obj4 + 23;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v14+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X0_v14] (should have been resolved before IL gen)");
			bool flag = list == null;
			object obj9 = !flag;
			obj10 = obj2;
			result = list;
			if (obj9 != null)
			{
				goto IL_010d;
			}
			goto IL_01ef;
		}
		return (List<Card>)(object)new NullReferenceException();
		IL_01ef:
		return result;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v11+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ X0_v11] (should have been resolved before IL gen)");
		bool flag2 = list == null;
		obj10 = obj2;
		result = list;
		if (!flag2)
		{
			goto IL_010d;
		}
		goto IL_01ef;
		IL_010d:
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1848;
		object obj12 = (nint)0 + (nint)3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, object> func = default(Func<int, object>);
		func..ctor((object)null, (IntPtr)obj12);
		IEnumerable<object> source = Enumerable.Select((IEnumerable<int>)list, func);
		return (List<Card>)(object)Enumerable.ToList(source);
	}

	private void CheckStageChanged(CardGameStage.CardGameStages newStage, ISFSObject gameState)
	{
		CardGameStage cardGameStage = <Stage>k__BackingField;
		if (cardGameStage.<CurrentStage>k__BackingField != newStage)
		{
			Action<CardGameStage.CardGameStages, CardGameStage.CardGameStages, ISFSObject> onStageChanged = this.OnStageChanged;
			if (this.OnStageChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v36 @ X8_v3 (System.Action`3<CardGameStage+CardGameStages, CardGameStage+CardGameStages, Sfs2X.Entities.Data.ISFSObject>)+18] (should have been resolved before IL gen)");
			}
		}
	}

	protected override void Init()
	{
		base.Init();
	}

	protected override void SeatPlayer(int seatIndex)
	{
		//IL_0023: Expected O, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I4, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_007e: Unsupported input type for neg.
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected I4, but got Unknown
		//IL_00d8: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I4, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_015a: Unsupported input type for neg.
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected I4, but got Unknown
		//IL_01da: Expected O, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected I4, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_028e: Expected O, but got I4
		//IL_0235: Unsupported input type for neg.
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected I4, but got Unknown
		//IL_02b5: Expected O, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected I4, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0310: Unsupported input type for neg.
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected I4, but got Unknown
		base.<MySeatIndex>k__BackingField = seatIndex;
		List<KPlayer> list = base.Players;
		int index;
		if (base.IsSpectator)
		{
			index = 0;
		}
		else
		{
			object obj = 5 - base.<MySeatIndex>k__BackingField;
			int num = obj & 3;
			object obj2 = 0 - obj;
			object obj3 = obj2 & 3;
			index = ((0 >= (nint)obj2) ? (0 - obj3) : num);
		}
		object obj4 = ((List<object>)(object)list).get_Item(index);
		_ = 1;
		List<KPlayer> list2 = base.Players;
		bool isSpectator = base.IsSpectator;
		bool flag = !isSpectator;
		object obj5 = !flag;
		int index2 = 1;
		if (obj5 == null)
		{
			object obj6 = 6 - base.<MySeatIndex>k__BackingField;
			int num2 = obj6 & 3;
			object obj7 = 0 - obj6;
			object obj8 = obj7 & 3;
			index2 = ((0 >= (nint)obj7) ? (0 - obj8) : num2);
		}
		object obj9 = ((List<object>)(object)list2).get_Item(index2);
		_ = 2;
		List<KPlayer> list3 = base.Players;
		bool isSpectator2 = base.IsSpectator;
		bool flag2 = !isSpectator2;
		object obj10 = !flag2;
		int index3 = 2;
		if (obj10 == null)
		{
			object obj11 = 7 - base.<MySeatIndex>k__BackingField;
			int num3 = obj11 & 3;
			object obj12 = 0 - obj11;
			object obj13 = obj12 & 3;
			index3 = ((0 >= (nint)obj12) ? (0 - obj13) : num3);
		}
		object obj14 = ((List<object>)(object)list3).get_Item(index3);
		_ = 3;
		List<KPlayer> list4 = base.Players;
		bool isSpectator3 = base.IsSpectator;
		bool flag3 = !isSpectator3;
		object obj15 = !flag3;
		int index4 = 3;
		if (obj15 == null)
		{
			object obj16 = 8 - base.<MySeatIndex>k__BackingField;
			int num4 = obj16 & 3;
			object obj17 = 0 - obj16;
			object obj18 = obj17 & 3;
			index4 = ((0 >= (nint)obj17) ? (0 - obj18) : num4);
		}
		object obj19 = ((List<object>)(object)list4).get_Item(index4);
		_ = 4;
		base.SeatPlayer(seatIndex);
	}

	protected void InvokeOnCardGameEnd(CardGameEndScores report)
	{
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		Action<CardGameEndScores> onCardGameEnd = this.OnCardGameEnd;
		if (this.OnCardGameEnd != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<CardGameEndScores>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<CardGameEndScores>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<CardGameEndScores>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void TrackEndGame(CardGameEndScores report)
	{
		//IL_0020: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		Room room = base.Room;
		int teamScore = SFSKammelnaRoomExtensions.GetTeamScore(room, 1);
		Room room2 = base.Room;
		int teamScore2 = SFSKammelnaRoomExtensions.GetTeamScore(room2, 2);
		object obj = 146599936;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF144]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = report == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0094;
		IL_0094:
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1008;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 936;
		int num = teamScore - teamScore2;
		int pointsDifference = ((teamScore >= teamScore2) ? num : (-num));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		FirebaseTrack.FinishGame(pointsDifference, friendlyName, report.<BalancedGame>k__BackingField, friendlyName2);
	}

	protected override void OnGameCancelled(ISFSObject data)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002b: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004b: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_009b: Expected O, but got I4
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e8: Expected I, but got O
		//IL_00f8: Expected O, but got I
		//IL_0601: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected I, but got Unknown
		//IL_027d: Expected I, but got O
		//IL_028d: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_035a: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_03f8: Expected O, but got I
		//IL_0429: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02ef: Expected I, but got O
		//IL_02ff: Expected O, but got I
		//IL_0447: Expected I, but got O
		//IL_0457: Expected O, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_04e6: Expected O, but got I4
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected I, but got Unknown
		//IL_052c: Expected O, but got I
		//IL_0550: Expected O, but got I4
		//IL_0560: Expected O, but got I
		//IL_0492: Expected O, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A8E]");
		nint num = 0;
		object obj = "placementId" + 2520;
		object obj2 = (nint)0 + (nint)80;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3304;
		object buttonText = "Network Authentication Required" + 3128;
		base.OnGameCancelled(data);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(action, (string)buttonText);
		bool flag = popupWindowBuilderNeedsTitle == null;
		object obj5 = 0;
		if (flag)
		{
			goto IL_056e;
		}
		object obj6 = typeof(System.IOAsyncCallback) + 392;
		object obj7 = "fetch_products" + 2464;
		object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2056;
		nint num2 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_017c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		object obj11 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X10_v25-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj11 = obj10 + 16;
			obj9--;
			bool flag2 = (nint)obj9 != 1;
			obj10 = obj11;
			if (flag2)
			{
				continue;
			}
			goto IL_017c;
		}
		object obj12 = num2 + obj10;
		num = (nint)(obj12 + 312);
		obj11 = obj10;
		goto IL_05f1;
		IL_057c:
		object obj13 = obj11 + 9;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		goto IL_06b3;
		IL_056e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_057c;
		IL_026b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj16 = default(object);
		num = (nint)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v28+8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v426 @ X0_v28] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag3 = obj17 == null;
		object obj18 = !flag3;
		object obj19 = obj11;
		if (obj18 != null)
		{
			goto IL_032e;
		}
		goto IL_056e;
		IL_032e:
		object obj20 = typeof(System.IOAsyncCallback) + 368;
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v16+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03de;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v16+B0]");
		obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X10_v17-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj19 = obj11 + 16;
			obj22--;
			bool flag4 = (nint)obj22 != 1;
			obj11 = obj19;
			if (flag4)
			{
				continue;
			}
			goto IL_03de;
		}
		object obj23 = obj11 + 3;
		object obj24 = obj21 + obj23;
		num = (nint)(obj24 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag5 = ex == null;
		object obj26 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj5 = 0;
		if (obj26 != null)
		{
			goto IL_043f;
		}
		goto IL_056e;
		IL_04d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj5 = 9;
		object obj27 = default(object);
		obj15 = obj27;
		goto IL_06b3;
		IL_017c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_05f1;
		IL_05f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj28 = default(object);
		if (obj28 != null)
		{
			object obj29 = typeof(System.IOAsyncCallback) + 384;
			object obj30 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v14+12E]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v14+12E]");
			if ((nint)0 == 0)
			{
				goto IL_026b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v14+B0]");
			obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X10_v12-8]");
				if (0 == (nint)obj29)
				{
					break;
				}
				obj11 = obj19 + 16;
				obj31--;
				bool flag6 = (nint)obj31 != 1;
				obj19 = obj11;
				if (flag6)
				{
					continue;
				}
				goto IL_026b;
			}
			object obj32 = obj30 + obj19;
			object obj33 = obj32 + 312;
			num = (nint)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v31+8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v31] (should have been resolved before IL gen)");
			bool flag7 = obj17 == null;
			obj11 = obj19;
			if (!flag7)
			{
				goto IL_032e;
			}
		}
		goto IL_056e;
		IL_03de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v23 (Il2CppClass<System.NullReferenceException>)+8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v481 @ X0_v23 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag8 = ex == null;
		obj11 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v23 (Il2CppClass<System.NullReferenceException>)+8]");
		obj5 = 0;
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		if (!flag8)
		{
			goto IL_043f;
		}
		goto IL_056e;
		IL_043f:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X10_v17-8]");
			bool flag9 = 0 == (nint)obj20;
			obj5 = obj25;
			if (flag9)
			{
				break;
			}
			obj11 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_04d3;
		}
		goto IL_057c;
		IL_06b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ X8_v3] (should have been resolved before IL gen)");
	}

	public void SendBidding(ISFSObject response)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2656;
		ISFSObject param = default(ISFSObject);
		SFS.SendRoomExtensionRequest((string)command, param);
	}

	public void SendSawa(int? gameActionItemId = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0057: Expected I, but got O
		//IL_0067: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj2 = (??)gameActionItemId & 1;
		if (obj2 == null)
		{
			goto IL_015e;
		}
		int? num = default(int?);
		int value = num.Value;
		object obj3 = typeof(System.IOAsyncCallback) + 976;
		object obj4 = "fetch_products" + 2336;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X10_v6-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00e3;
		}
		object obj7 = obj6 + 35;
		object obj8 = num2 + obj7;
		object obj9 = obj8 + 312;
		goto IL_019f;
		IL_019f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ X0_v9] (should have been resolved before IL gen)");
		goto IL_015e;
		IL_015e:
		object command = "___# Content push apply failed [{0}]: {1}" + 2712;
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
		return;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_019f;
	}

	public void SendKasho()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2704;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public virtual void PlayCard(CardGamePlayer player, Card card, int? gameActionItemId = null)
	{
		//IL_0196: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c7: Expected I, but got O
		//IL_00d7: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		nint num = (nint)this;
		CardGamePlayer player2 = default(CardGamePlayer);
		if (!CanPlayCard(player2, card))
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		string val = card.ToString();
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2400;
		SFSExtensions.Put(sFSObject, (string)key, val);
		object obj2 = (??)gameActionItemId & 1;
		if (obj2 == null)
		{
			goto IL_01c1;
		}
		int? num2 = default(int?);
		int value = num2.Value;
		object obj3 = typeof(System.IOAsyncCallback) + 976;
		object obj4 = "fetch_products" + 2336;
		nint num3 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0153;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X10_v7-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_0153;
		}
		object obj7 = obj6 + 35;
		object obj8 = num3 + obj7;
		object obj9 = obj8 + 312;
		goto IL_0206;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0206;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v288 @ X0_v15] (should have been resolved before IL gen)");
		goto IL_01c1;
		IL_01c1:
		object command = "___# Content push apply failed [{0}]: {1}" + 2664;
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	protected virtual bool CanPlayCard(CardGamePlayer player, Card card)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94601D0");
		bool result = default(bool);
		return result;
	}

	public virtual bool SpecialPlayAllowed(Card card)
	{
		return false;
	}

	public void SendAcceptNext()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2640;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public void SendEatCards()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2680;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public void SendCatch(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2688;
		ISFSObject param = default(ISFSObject);
		SFS.SendRoomExtensionRequest((string)command, param);
	}

	public void SendCatchDetails(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "___# Content push apply failed [{0}]: {1}" + 2696;
		ISFSObject param = default(ISFSObject);
		SFS.SendRoomExtensionRequest((string)command, param);
	}

	public static void SendLiveCatch(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "java.io.FileOutputStream" + 2856;
		SFS.SendRoomExtensionRequest((string)command, data);
	}

	public void SendCatchClose()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object command = "___# Content push apply failed [{0}]: {1}" + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public int GetPlayerTeam(int seatIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		object obj = seatIndex - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 118730752 + 3184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*4]");
			return 0;
		}
		return 0;
	}

	public int GetPlayerTeam(KPlayer player)
	{
		//IL_00bd: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		if (player != null)
		{
			object obj = player.<Index>k__BackingField - 1;
			bool flag = (nint)obj < 3;
			object obj2 = !flag;
			object obj3 = obj - 3;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 118730752 + 3184;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v2+v3 @ X8_v2*4]");
				return 0;
			}
			return 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public int GetOpponentTeam(int seatIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		object obj = seatIndex - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119877632 + 1712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*4]");
			return 0;
		}
		return 0;
	}

	public int GetRotatedPlayerIndex(int playerIndex)
	{
		//IL_0024: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b2: Unsupported input type for neg.
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		bool isSpectator = base.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		int result = playerIndex;
		if (obj == null)
		{
			object obj2 = playerIndex - base.<MySeatIndex>k__BackingField;
			object obj3 = obj2 + 4;
			object obj4 = obj3 & 3;
			object obj5 = 0 - obj3;
			object obj6 = obj5 & 3;
			object obj7 = ((0 >= (nint)obj5) ? ((object)(0 - obj6)) : obj4);
			result = obj7 + 1;
		}
		return result;
	}

	public int GetNextPlayerIndex(int playerIndex, int offset = 1)
	{
		return IntegerExtensions.GetRotatedNextIndex(playerIndex, offset, 1, 5);
	}

	protected CardGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		<Stage>k__BackingField = (CardGameStage)obj2;
		object obj3 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
