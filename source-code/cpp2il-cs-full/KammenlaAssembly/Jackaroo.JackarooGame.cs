using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace Jackaroo;

public class JackarooGame : CardGame
{
	private const string BOARD = "brd";

	private const string BOARD2 = "brd2";

	private const string DEAL_PHASE = "jdp";

	private const string JACKAROO_ACTION = "a";

	private const string PIECE_POSITION1 = "p1";

	private const string PIECE_POSITION2 = "p2";

	private JackarooLastActionInfo <LastAction>k__BackingField;

	private JackarooLastActionInfo <PreviousLastAction>k__BackingField;

	private JackarooScores _scores;

	private JackarooCardUtils _cardUtils;

	private JackarooPlayer[] <JackarooPlayers>k__BackingField;

	private int <DealPhase>k__BackingField;

	private bool <UpdatedThisTurn>k__BackingField;

	private ISFSArray _board;

	private readonly int[][] _p;

	private static readonly Dictionary<JackarooActions, GameAction> <SpecialJackarooActions>k__BackingField;

	private const JackarooActions ACE_Choices = (JackarooActions)131120;

	private const JackarooActions MoveChoices = (JackarooActions)48;

	private const JackarooActions Splits = (JackarooActions)4032;

	private const JackarooServerActions SeverSplits = JackarooServerActions.BURN_MY_CARD;

	public new JackarooLastActionInfo LastAction
	{
		get
		{
			return <LastAction>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<LastAction>k__BackingField = value;
			object obj = this + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private JackarooLastActionInfo PreviousLastAction
	{
		get
		{
			return <PreviousLastAction>k__BackingField;
		}
		set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<PreviousLastAction>k__BackingField = value;
			object obj = this + 376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsNewLastAction
	{
		get
		{
			//IL_0165: Expected I4, but got O
			//IL_0087: Expected O, but got I4
			//IL_0132: Expected O, but got I4
			JackarooLastActionInfo jackarooLastActionInfo = <LastAction>k__BackingField;
			if (<LastAction>k__BackingField != null)
			{
				JackarooLastActionInfo jackarooLastActionInfo2 = <PreviousLastAction>k__BackingField;
				if (<PreviousLastAction>k__BackingField != null)
				{
					bool flag = ((LastActionInfo)jackarooLastActionInfo).<Action>k__BackingField != ((LastActionInfo)jackarooLastActionInfo2).<Action>k__BackingField;
					bool flag2 = !flag;
					object obj = !flag2;
					if (obj == null && object.Equals(jackarooLastActionInfo.<Card>k__BackingField, jackarooLastActionInfo2.<Card>k__BackingField) && jackarooLastActionInfo.<JackarooAction>k__BackingField == jackarooLastActionInfo2.<JackarooAction>k__BackingField && jackarooLastActionInfo.<P1>k__BackingField == jackarooLastActionInfo2.<P1>k__BackingField)
					{
						object obj2 = jackarooLastActionInfo.<P2>k__BackingField - jackarooLastActionInfo2.<P2>k__BackingField;
						bool flag3 = obj2 == null;
						return !flag3;
					}
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override IGameScores GameScores => _scores;

	public override ICardUtils GameCardUtils => _cardUtils;

	public JackarooPlayer[] JackarooPlayers
	{
		get
		{
			return <JackarooPlayers>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<JackarooPlayers>k__BackingField = value;
			object obj = this + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int DealPhase
	{
		get
		{
			return <DealPhase>k__BackingField;
		}
		private set
		{
			<DealPhase>k__BackingField = value;
		}
	}

	public bool UpdatedThisTurn
	{
		get
		{
			return <UpdatedThisTurn>k__BackingField;
		}
		private set
		{
			<UpdatedThisTurn>k__BackingField = value;
		}
	}

	public int Team1P1Score
	{
		get
		{
			//IL_0088: Expected I4, but got O
			CardGamePlayer myPlayer = base.MyPlayer;
			if (myPlayer != null)
			{
				CardGamePlayer myPlayer2 = base.MyPlayer;
				if (myPlayer2 != null)
				{
					return GetPlayerScore(((KPlayer)myPlayer2).<Index>k__BackingField);
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return GetPlayerScore(1);
		}
	}

	public int Team1P2Score
	{
		get
		{
			//IL_00b2: Expected I4, but got O
			CardGamePlayer myPlayer = base.MyPlayer;
			if (myPlayer != null)
			{
				CardGamePlayer myPlayer2 = base.MyPlayer;
				if (myPlayer2 != null)
				{
					CardGamePlayer teammate = myPlayer2.Teammate;
					if (teammate != null)
					{
						return GetPlayerScore(((KPlayer)teammate).<Index>k__BackingField);
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return GetPlayerScore(3);
		}
	}

	public int Team2P1Score
	{
		get
		{
			//IL_00a9: Expected I4, but got O
			CardGamePlayer myPlayer = base.MyPlayer;
			if (myPlayer != null)
			{
				CardGamePlayer myPlayer2 = base.MyPlayer;
				if (myPlayer2 != null)
				{
					int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(((KPlayer)myPlayer2).<Index>k__BackingField, 1, 1, 5);
					return GetPlayerScore(rotatedNextIndex);
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return GetPlayerScore(2);
		}
	}

	public int Team2P2Score
	{
		get
		{
			//IL_00a9: Expected I4, but got O
			CardGamePlayer myPlayer = base.MyPlayer;
			if (myPlayer != null)
			{
				CardGamePlayer myPlayer2 = base.MyPlayer;
				if (myPlayer2 != null)
				{
					int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(((KPlayer)myPlayer2).<Index>k__BackingField, 3, 1, 5);
					return GetPlayerScore(rotatedNextIndex);
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return GetPlayerScore(4);
		}
	}

	private int Team1P1
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 744;
			Room room = base.Room;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	private int Team1P2
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 752;
			Room room = base.Room;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	private int Team2P1
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 768;
			Room room = base.Room;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	private int Team2P2
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 776;
			Room room = base.Room;
			return SFSExtensions.GetVariable(room, (string)varName, 0);
		}
	}

	public int[][] P => _p;

	public int GetNextToMyPlayerIndex
	{
		get
		{
			//IL_0052: Expected I4, but got O
			CardGamePlayer myPlayer = base.MyPlayer;
			JackarooPlayer nextPlayer = GetNextPlayer(myPlayer);
			if (nextPlayer != null)
			{
				return ((KPlayer)nextPlayer).<Index>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public JackarooPlayer GetNextToMyPlayer
	{
		get
		{
			CardGamePlayer myPlayer = base.MyPlayer;
			return GetNextPlayer(myPlayer);
		}
	}

	public static Dictionary<JackarooActions, GameAction> SpecialJackarooActions
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0102: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7FA9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			return (Dictionary<JackarooActions, GameAction>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (Dictionary<JackarooActions, GameAction>)0;
		}
	}

	protected override LastActionInfo ParseLastActionInfo(ISFSObject lastActionParams)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0167: Expected O, but got I
		//IL_0192: Expected O, but got I4
		LastActionInfo lastActionInfo = base.ParseLastActionInfo(lastActionParams);
		Card card;
		if (lastActionInfo != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 232;
			int num = lastActionInfo.<ActionPlayer>k__BackingField - 1;
			bool flag = lastActionInfo.<ActionPlayer>k__BackingField < 1;
			object obj2 = 0;
			ISFSObject iSFSObject = lastActionParams;
			if (!flag)
			{
				List<Card> list = base.<PlayedCards>k__BackingField;
				bool flag2 = base.<PlayedCards>k__BackingField == null;
				obj2 = 0;
				iSFSObject = lastActionParams;
				if (!flag2)
				{
					object obj3 = (nint)0 + (nint)3136;
					obj2 = obj3;
					int? num2 = list._size;
					object obj4 = default(object);
					bool flag3 = lastActionInfo.<ActionPlayer>k__BackingField > (nint)obj4;
					card = null;
					iSFSObject = (ISFSObject)list._size;
					if (!flag3)
					{
						object obj5 = (??)num2 & 1;
						bool flag4 = obj5 == null;
						card = null;
						iSFSObject = (ISFSObject)list._size;
						if (!flag4)
						{
							bool flag5 = base.<PlayedCards>k__BackingField == null;
							iSFSObject = (ISFSObject)list._size;
							if (flag5)
							{
								goto IL_0197;
							}
							object obj6 = (nint)0 + (nint)2760;
							obj2 = obj6;
							object obj7 = ((List<object>)(object)base.<PlayedCards>k__BackingField).get_Item(num);
							card = (Card)obj7;
							iSFSObject = (ISFSObject)num;
						}
					}
					goto IL_01e0;
				}
			}
			goto IL_0197;
		}
		goto IL_01db;
		IL_01db:
		return lastActionInfo;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JackarooLastActionInfo jackarooLastActionInfo = default(JackarooLastActionInfo);
		jackarooLastActionInfo..ctor(lastActionParams, card);
		<LastAction>k__BackingField = jackarooLastActionInfo;
		object obj8 = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		lastActionInfo = <LastAction>k__BackingField;
		goto IL_01db;
		IL_0197:
		card = null;
		goto IL_01e0;
	}

	public void EnableUpdatedThisTurn()
	{
		<UpdatedThisTurn>k__BackingField = true;
	}

	public void DisableUpdatedThisTurn()
	{
		<UpdatedThisTurn>k__BackingField = false;
	}

	protected override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0057: Expected I, but got O
		//IL_0067: Expected O, but got I
		//IL_0089: Expected O, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0119: Expected I, but got O
		//IL_0129: Expected O, but got I
		//IL_014b: Expected O, but got I4
		//IL_016d: Expected O, but got I8
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01ed: Expected I, but got O
		//IL_01fd: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_0259: Expected O, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02ef: Expected I, but got O
		//IL_02ff: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0343: Expected O, but got I8
		//IL_036c: Expected O, but got I
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_0531: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3184;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGamePlayer cardGamePlayer = default(CardGamePlayer);
		cardGamePlayer..ctor(this);
		object obj3 = cardGamePlayer + 112;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		KPlayer[] array = default(KPlayer[]);
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4 (Il2CppClass<KPlayer[]>)+40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj5 = default(object);
		bool flag = obj5 == null;
		object obj6 = 0;
		if (flag)
		{
			goto IL_04b7;
		}
		if (array.Length != 0)
		{
			object obj7 = array + 32;
			obj7 = cardGamePlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			CardGamePlayer cardGamePlayer2 = default(CardGamePlayer);
			cardGamePlayer2..ctor(this);
			object obj8 = cardGamePlayer2 + 112;
			obj8 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8 (Il2CppClass<KPlayer[]>)+40]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = obj5 == null;
			obj6 = 0;
			if (flag2)
			{
				goto IL_04b7;
			}
			object obj9 = array.Length & 0xFFFFFFFEL;
			if (obj9 != null)
			{
				object obj10 = array + 40;
				obj10 = cardGamePlayer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				CardGamePlayer cardGamePlayer3 = default(CardGamePlayer);
				cardGamePlayer3..ctor(this);
				object obj11 = cardGamePlayer3 + 112;
				obj11 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v10 (Il2CppClass<KPlayer[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = obj5 == null;
				obj6 = 0;
				if (flag3)
				{
					goto IL_04b7;
				}
				bool flag4 = array.Length < 2;
				object obj12 = !flag4;
				object obj13 = array.Length - 2;
				bool flag5 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag5;
				if (obj15 == null)
				{
					object obj16 = array + 48;
					obj16 = cardGamePlayer3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					CardGamePlayer cardGamePlayer4 = default(CardGamePlayer);
					cardGamePlayer4..ctor(this);
					object obj17 = cardGamePlayer4 + 112;
					obj17 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v12 (Il2CppClass<KPlayer[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = obj5 == null;
					obj6 = 0;
					if (flag6)
					{
						goto IL_04b7;
					}
					object obj18 = array.Length & 0xFFFFFFFCL;
					if (obj18 != null)
					{
						object obj19 = (nint)0 + (nint)1984;
						object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 312;
						object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 160;
						object obj22 = array + 56;
						obj22 = cardGamePlayer4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						players = array;
						object obj23 = this + 256;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCBBAC");
						IEnumerable<object> source = default(IEnumerable<object>);
						object[] array2 = Enumerable.ToArray(source);
						<JackarooPlayers>k__BackingField = (JackarooPlayer[])array2;
						object obj24 = this + 400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						CardGameScores cardGameScores = default(CardGameScores);
						cardGameScores..ctor();
						_scores = (JackarooScores)cardGameScores;
						object obj25 = this + 384;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj26 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
						object obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v65+E4]");
						bool flag7 = (nint)0 == 0;
						object obj28 = !flag7;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						CardUtils cardUtils = default(CardUtils);
						cardUtils..ctor((CardGame)this);
						_cardUtils = (JackarooCardUtils)cardUtils;
						object obj29 = this + 392;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						base.Init();
						return;
					}
				}
			}
		}
		goto IL_04cf;
		IL_04b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_04cf;
		IL_04cf:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private int GetPlayerScore(int playerIndex)
	{
		//IL_01b7: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0101: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_027c: Expected O, but got I
		//IL_0069: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0299: Expected I4, but got O
		object obj2;
		KGame kGame;
		object varName;
		object obj;
		if (playerIndex <= 2)
		{
			if (playerIndex != 1)
			{
				if (playerIndex != 2)
				{
					goto IL_0224;
				}
				obj = 152993792 + 92;
				obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 768;
				object obj3 = obj & 1;
				if (obj3 == null)
				{
					goto IL_0209;
				}
				kGame = this;
				varName = obj2;
			}
			else
			{
				obj = 152993792 + 90;
				obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 744;
				object obj4 = obj & 1;
				if (obj4 == null)
				{
					goto IL_0209;
				}
				kGame = this;
				varName = obj2;
			}
		}
		else if (playerIndex != 3)
		{
			if (playerIndex != 4)
			{
				goto IL_0224;
			}
			obj = 152993792 + 93;
			obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 776;
			object obj5 = obj & 1;
			if (obj5 == null)
			{
				goto IL_0209;
			}
			kGame = this;
			varName = obj2;
		}
		else
		{
			obj = 152993792 + 91;
			obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 752;
			object obj6 = obj & 1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			kGame = this;
			varName = obj2;
			if (obj7 == null)
			{
				goto IL_0209;
			}
		}
		goto IL_0299;
		IL_0299:
		Room room = kGame.Room;
		return SFSExtensions.GetVariable(room, (string)varName, 0);
		IL_0209:
		obj = 1;
		kGame = this;
		varName = obj2;
		goto IL_0299;
		IL_0224:
		int num = default(int);
		string message = num.ToString();
		object obj8 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		ex..ctor(message);
		object obj9 = (nint)0 + (nint)688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}

	public override int[] GetScores()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_01cc: Expected O, but got I8
		//IL_030e: Expected O, but got I4
		//IL_031e: Expected O, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_017c: Expected O, but got I8
		//IL_0196: Expected O, but got I4
		//IL_0450: Expected O, but got I8
		//IL_046a: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		//IL_03f9: Expected O, but got I8
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		CardGamePlayer myPlayer = base.MyPlayer;
		int playerScore;
		int[] array = default(int[]);
		if (myPlayer != null)
		{
			CardGamePlayer myPlayer2 = base.MyPlayer;
			if (myPlayer2 != null)
			{
				playerScore = GetPlayerScore(((KPlayer)myPlayer2).<Index>k__BackingField);
				bool flag = array == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_00ac;
				}
			}
		}
		else
		{
			playerScore = GetPlayerScore(1);
			if (array != null)
			{
				goto IL_00ac;
			}
		}
		goto IL_0486;
		IL_0486:
		return (int[])(object)new NullReferenceException();
		IL_0416:
		int playerScore2;
		array[3] = playerScore2;
		return array;
		IL_0351:
		int playerScore3;
		array[2] = playerScore3;
		CardGamePlayer myPlayer3 = base.MyPlayer;
		if (myPlayer3 != null)
		{
			CardGamePlayer myPlayer4 = base.MyPlayer;
			if (myPlayer4 == null)
			{
				goto IL_0486;
			}
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(((KPlayer)myPlayer4).<Index>k__BackingField, 3, 1, 5);
			playerScore2 = GetPlayerScore(rotatedNextIndex);
			object obj3 = array.Length & 0xFFFFFFFCL;
			if (obj3 != null)
			{
				goto IL_0416;
			}
		}
		else
		{
			playerScore2 = GetPlayerScore(4);
			object obj4 = array.Length & 0xFFFFFFFCL;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_0416;
			}
		}
		goto IL_0478;
		IL_00ac:
		int playerScore4;
		if (array.Length != 0)
		{
			array[0] = playerScore;
			CardGamePlayer myPlayer5 = base.MyPlayer;
			if (myPlayer5 != null)
			{
				CardGamePlayer myPlayer6 = base.MyPlayer;
				if (myPlayer6 != null)
				{
					CardGamePlayer teammate = myPlayer6.Teammate;
					if (teammate != null)
					{
						playerScore4 = GetPlayerScore(((KPlayer)teammate).<Index>k__BackingField);
						object obj6 = array.Length & 0xFFFFFFFEL;
						bool flag3 = obj6 == null;
						object obj7 = !flag3;
						if (obj7 != null)
						{
							goto IL_01e9;
						}
						goto IL_0478;
					}
				}
				goto IL_0486;
			}
			playerScore4 = GetPlayerScore(3);
			object obj8 = array.Length & 0xFFFFFFFEL;
			if (obj8 != null)
			{
				goto IL_01e9;
			}
		}
		goto IL_0478;
		IL_01e9:
		array[1] = playerScore4;
		CardGamePlayer myPlayer7 = base.MyPlayer;
		if (myPlayer7 != null)
		{
			CardGamePlayer myPlayer8 = base.MyPlayer;
			if (myPlayer8 == null)
			{
				goto IL_0486;
			}
			int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex(((KPlayer)myPlayer8).<Index>k__BackingField, 1, 1, 5);
			playerScore3 = GetPlayerScore(rotatedNextIndex2);
			bool flag4 = array.Length < 2;
			object obj9 = !flag4;
			object obj10 = array.Length - 2;
			bool flag5 = obj10 == null;
			object obj11 = !flag5;
			object obj12 = obj9 & obj11;
			if (obj12 != null)
			{
				goto IL_0351;
			}
		}
		else
		{
			playerScore3 = GetPlayerScore(2);
			bool flag6 = array.Length < 2;
			object obj13 = !flag6;
			object obj14 = array.Length - 2;
			bool flag7 = obj14 == null;
			object obj15 = ~obj13;
			object obj16 = obj15 | flag7;
			if (obj16 == null)
			{
				goto IL_0351;
			}
		}
		goto IL_0478;
		IL_0478:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0486;
	}

	protected override void UpdateGameState(ISFSObject gameState)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_002a: Expected I4, but got I8
		object varName = "java.io.FileOutputStream" + 288;
		<PreviousLastAction>k__BackingField = <LastAction>k__BackingField;
		object obj = this + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<Card> list = CardGame.AssignPlayedCards(gameState);
		base.<PlayedCards>k__BackingField = list;
		object obj2 = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = SFSExtensions.Get(gameState, (string)varName, -1);
		<DealPhase>k__BackingField = num;
		base.UpdateGameState(gameState);
		GetServerBoardMarbles(gameState);
	}

	private void GetServerBoardMarbles(ISFSObject gameState)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0142: Expected I, but got O
		//IL_0152: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_027c: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1360;
		nint num = (nint)gameState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		object obj5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 = obj4 + 16;
			obj3--;
			bool flag = (nint)obj3 != 1;
			obj4 = obj5;
			if (flag)
			{
				continue;
			}
			goto IL_00c4;
		}
		object obj6 = obj4 + 28;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		obj5 = obj4;
		goto IL_02c2;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02c2;
		IL_02c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X0_v5] (should have been resolved before IL gen)");
		ISFSArray board = default(ISFSArray);
		_board = board;
		object obj9 = this + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int[][] p = _p;
		object obj10 = typeof(System.IOAsyncCallback) + 960;
		object obj11 = 0;
		object obj20 = default(object);
		while (true)
		{
			if ((nint)obj11 >= p.Length)
			{
				return;
			}
			ISFSArray board2 = _board;
			nint num2 = (nint)board2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X10_v9-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj5 = obj13 + 16;
				obj12--;
				bool flag2 = (nint)obj12 != 1;
				obj13 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_01d6;
			}
			object obj14 = obj13 + 45;
			object obj15 = num2 + obj14;
			object obj16 = obj15 + 312;
			obj5 = obj13;
			goto IL_031e;
			IL_01d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_031e;
			IL_031e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v11] (should have been resolved before IL gen)");
			bool flag3 = (nint)obj11 < p.Length;
			object obj17 = !flag3;
			if (obj17 != null)
			{
				break;
			}
			object obj18 = (object)p + obj11;
			object obj19 = obj18 + 32;
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11++;
			p = _p;
			bool flag4 = _p == null;
			object obj21 = !flag4;
			if (obj21 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	protected override void OnPlayCard(ISFSObject response)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		object varName = "destinationTimeZone" + 2696;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = SFSExtensions.Get(response, (string)varName, (string)null);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		object obj4 = "October" + 528;
		object obj5 = typeof(DataRelation) + 856;
		object obj6 = typeof(RegisteredWaitHandle) + 3136;
		string message = (string)obj4 + text;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Debug.LogError(message);
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = 0;
			if (!flag3)
			{
				goto IL_014b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.LogError(message);
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			object obj9 = 0;
			if (obj10 != null)
			{
				goto IL_014b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_014b;
		IL_014b:
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
	}

	protected override void EndGame(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 200;
		base.EndGame(data);
		Room room = base.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JackarooEndScores jackarooEndScores = default(JackarooEndScores);
		jackarooEndScores..ctor(data, gameType);
		InvokeOnCardGameEnd(jackarooEndScores);
		TrackEndGame(jackarooEndScores);
	}

	public void SendToSfs(CardGamePlayer player, JackarooServerMove jackarooMove, int? emoteItemId = null)
	{
		//IL_000a: Expected I, but got O
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c8: Expected I, but got O
		//IL_00d8: Expected O, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03de: Expected I, but got O
		//IL_03ee: Expected O, but got I
		//IL_0113: Expected O, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_047f: Expected O, but got I4
		//IL_01a7: Expected O, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_027b: Expected I, but got O
		//IL_028b: Expected O, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_02c6: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		nint num = (nint)this;
		CardGamePlayer player2 = default(CardGamePlayer);
		if (!base.CanPlayCard(player2, jackarooMove.<Card>k__BackingField))
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		string val = jackarooMove.<Card>k__BackingField.ToString();
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2400;
		SFSExtensions.Put(sFSObject, (string)key, val);
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		object obj3 = "___# Content push apply failed [{0}]: {1}" + 2608;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0154;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v19-8]");
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
			goto IL_0154;
		}
		object obj6 = obj5 + 35;
		object obj7 = num2 + obj6;
		object obj8 = obj7 + 312;
		goto IL_03bd;
		IL_01e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0437;
		IL_0437:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ X0_v14] (should have been resolved before IL gen)");
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = jackarooMove.<Action>k__BackingField & JackarooServerActions.BURN_MY_CARD;
		if (obj12 == null)
		{
			goto IL_048d;
		}
		object obj13 = "not" + 2936;
		nint num3 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0307;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v34 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X10_v9-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0307;
		}
		object obj16 = obj15 + 35;
		object obj17 = num3 + obj16;
		object obj18 = obj17 + 312;
		goto IL_04dc;
		IL_0307:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04dc;
		IL_04dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v498 @ X0_v25] (should have been resolved before IL gen)");
		goto IL_048d;
		IL_048d:
		object obj19 = (??)emoteItemId & 1;
		if (obj19 != null)
		{
			int? num4 = default(int?);
			int value = num4.Value;
			object key2 = "fetch_products" + 2336;
			SFSExtensions.Put(sFSObject, (string)key2, value);
		}
		object command = "___# Content push apply failed [{0}]: {1}" + 2664;
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
		return;
		IL_0154:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03bd;
		IL_03bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v289 @ X0_v11] (should have been resolved before IL gen)");
		object obj20 = "not" + 2928;
		nint num5 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01e8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X10_v14-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_01e8;
		}
		object obj23 = obj22 + 35;
		object obj24 = num5 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0437;
	}

	public void ThrowCard(CardGamePlayer player, Card card)
	{
		//IL_0086: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		nint num = (nint)this;
		CardGamePlayer player2 = default(CardGamePlayer);
		if (base.CanPlayCard(player2, card))
		{
			object obj = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSObject sFSObject = default(SFSObject);
			sFSObject..ctor();
			string val = card.ToString();
			object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2400;
			SFSExtensions.Put(sFSObject, (string)key, val);
			object command = "___# Content push apply failed [{0}]: {1}" + 2672;
			SFS.SendRoomExtensionRequest((string)command, sFSObject);
		}
	}

	public int GetNextPlayerIndex(KPlayer player)
	{
		//IL_0043: Expected I4, but got O
		JackarooPlayer nextPlayer = GetNextPlayer(player);
		if (nextPlayer != null)
		{
			return ((KPlayer)nextPlayer).<Index>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public JackarooPlayer GetNextPlayer(KPlayer player)
	{
		//IL_00a9: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		if (player != null)
		{
			List<KPlayer> list = base.Players;
			if (list != null)
			{
				int max = list._size + 1;
				int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(player.<Index>k__BackingField, 1, 1, max);
				int rotatedPlayerIndex = GetRotatedPlayerIndex(rotatedNextIndex);
				JackarooPlayer[] array = <JackarooPlayers>k__BackingField;
				if (<JackarooPlayers>k__BackingField != null)
				{
					object obj = rotatedPlayerIndex - 1;
					bool flag = (nint)obj < array.Length;
					object obj2 = !flag;
					if (obj2 == null)
					{
						object obj3 = (object)<JackarooPlayers>k__BackingField + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
						return (JackarooPlayer)0;
					}
					goto IL_00fc;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00fc;
		IL_00fc:
		return (JackarooPlayer)(object)new IndexOutOfRangeException();
	}

	public static bool IsASplit(JackarooActions jackarooAction)
	{
		//IL_000e: Expected O, but got I4
		object obj = jackarooAction & (JackarooActions)4032;
		bool flag = obj == null;
		return !flag;
	}

	public static bool NeedsP2(JackarooServerActions action)
	{
		//IL_000e: Expected O, but got I4
		object obj = action & JackarooServerActions.BURN_MY_CARD;
		bool flag = obj == null;
		return !flag;
	}

	public static GameAction? ToGameActionId(int gameActionItemId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E805E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E805F]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00cc;
		}
		goto IL_01ed;
		IL_012b:
		StoreItem storeItem;
		System.Int32Enum? int32Enum = (System.Int32Enum)storeItem.<GameAction>k__BackingField;
		GameAction? result = (GameAction?)int32Enum;
		goto IL_027c;
		IL_00f9:
		storeItem = Store.GetStoreItem(gameActionItemId);
		bool flag3 = storeItem == null;
		result = (GameAction?)storeItem;
		if (!flag3)
		{
			goto IL_012b;
		}
		goto IL_027c;
		IL_027c:
		return result;
		IL_007d:
		obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E805F]");
		object obj10 = (nint)0 & (nint)1;
		bool flag4 = obj10 == null;
		obj9 = obj6;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01ed;
		IL_01ed:
		_ = 1;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_00f9;
		}
		goto IL_022b;
		IL_00cc:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00f9;
		}
		goto IL_022b;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		storeItem = Store.GetStoreItem(gameActionItemId);
		bool flag6 = storeItem == null;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			goto IL_012b;
		}
		result = (GameAction?)storeItem;
		goto IL_027c;
	}

	private static StoreItem GetStoreItem(int gameActionItemId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E805F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Store.GetStoreItem(gameActionItemId);
		IL_007d:
		return Store.GetStoreItem(gameActionItemId);
	}

	public int? ToGameActionItemId(GameAction gameAction)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8060]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8061]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00cc;
		}
		goto IL_01ed;
		IL_012b:
		StoreItem storeItem;
		int? num = storeItem.<id>k__BackingField;
		int? result = num;
		goto IL_027c;
		IL_00f9:
		storeItem = Store.GetStoreItem(gameAction);
		bool flag3 = storeItem == null;
		result = (int?)storeItem;
		if (!flag3)
		{
			goto IL_012b;
		}
		goto IL_027c;
		IL_027c:
		return result;
		IL_007d:
		obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8061]");
		object obj10 = (nint)0 & (nint)1;
		bool flag4 = obj10 == null;
		obj9 = obj6;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01ed;
		IL_01ed:
		_ = 1;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_00f9;
		}
		goto IL_022b;
		IL_00cc:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00f9;
		}
		goto IL_022b;
		IL_022b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		storeItem = Store.GetStoreItem(gameAction);
		bool flag6 = storeItem == null;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			goto IL_012b;
		}
		result = (int?)storeItem;
		goto IL_027c;
	}

	private static StoreItem GetStoreItem(GameAction gameAction)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8061]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Store.GetStoreItem(gameAction);
		IL_007d:
		return Store.GetStoreItem(gameAction);
	}

	public JackarooGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Expected I4, but got I8
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1504;
		<DealPhase>k__BackingField = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[][] p = default(int[][]);
		_p = p;
		object obj2 = this + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static JackarooGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, System.Int32Enum> dictionary = default(Dictionary<System.Int32Enum, System.Int32Enum>);
		dictionary..ctor();
		object obj2 = (nint)0 + (nint)3880;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		dictionary.Add((System.Int32Enum)131072, (System.Int32Enum)102);
		dictionary.Add((System.Int32Enum)8, (System.Int32Enum)101);
		object obj4 = obj3;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
