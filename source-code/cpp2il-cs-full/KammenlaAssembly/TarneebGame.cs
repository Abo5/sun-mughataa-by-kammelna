using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;

public class TarneebGame : CardGame
{
	private static readonly string HIGHEST_BID;

	private static readonly string BIDDING_STAGE;

	private static readonly string EATING_COUNT;

	private int <HighestBid>k__BackingField;

	private TarneebBiddingStage <BiddingStage>k__BackingField;

	private int[] <EatingCounts>k__BackingField;

	private TarneebScores _scores;

	private TarneebCardUtils _cardUtils;

	public int HighestBid
	{
		get
		{
			return <HighestBid>k__BackingField;
		}
		private set
		{
			<HighestBid>k__BackingField = value;
		}
	}

	public TarneebBiddingStage BiddingStage
	{
		get
		{
			return <BiddingStage>k__BackingField;
		}
		private set
		{
			<BiddingStage>k__BackingField = value;
		}
	}

	public int[] EatingCounts
	{
		get
		{
			return <EatingCounts>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<EatingCounts>k__BackingField = value;
			object obj = this + 376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override IGameScores GameScores => _scores;

	public override ICardUtils GameCardUtils => _cardUtils;

	protected override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I4
		//IL_0057: Expected I, but got O
		//IL_0067: Expected O, but got I
		//IL_0089: Expected O, but got I4
		//IL_0099: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0196: Expected O, but got I8
		//IL_01ae: Expected O, but got I4
		//IL_0132: Expected I, but got O
		//IL_0142: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_0174: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_028b: Expected O, but got I4
		//IL_029b: Expected O, but got I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c9: Expected O, but got I4
		//IL_021f: Expected I, but got O
		//IL_022f: Expected O, but got I
		//IL_0251: Expected O, but got I4
		//IL_0261: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_039e: Expected O, but got I8
		//IL_03b6: Expected O, but got I4
		//IL_033a: Expected I, but got O
		//IL_034a: Expected O, but got I
		//IL_036c: Expected O, but got I4
		//IL_037c: Expected O, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_0555: Expected O, but got I4
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 160;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGamePlayer cardGamePlayer = default(CardGamePlayer);
		cardGamePlayer..ctor(this);
		bool flag = cardGamePlayer == null;
		CardGame cardGame = this;
		KPlayer[] array = default(KPlayer[]);
		object obj3;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		CardGame cardGame2;
		if (!flag)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v21 (Il2CppClass<KPlayer[]>)+40]");
			cardGame = (CardGame)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = ex == null;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v21 (Il2CppClass<KPlayer[]>)+40]");
			cardGame2 = (CardGame)0;
			if (flag2)
			{
				goto IL_04e9;
			}
		}
		bool flag3 = array.Length == 0;
		obj3 = 0;
		if (!flag3)
		{
			object obj4 = array + 32;
			obj4 = cardGamePlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			CardGamePlayer cardGamePlayer2 = default(CardGamePlayer);
			cardGamePlayer2..ctor(this);
			bool flag4 = cardGamePlayer2 == null;
			cardGame = this;
			if (!flag4)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v20 (Il2CppClass<KPlayer[]>)+40]");
				cardGame = (CardGame)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v20 (Il2CppClass<KPlayer[]>)+40]");
				cardGame2 = (CardGame)0;
				if (flag5)
				{
					goto IL_04e9;
				}
			}
			object obj5 = array.Length & 0xFFFFFFFEL;
			bool flag6 = obj5 == null;
			obj3 = 0;
			if (!flag6)
			{
				object obj6 = array + 40;
				obj6 = cardGamePlayer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				CardGamePlayer cardGamePlayer3 = default(CardGamePlayer);
				cardGamePlayer3..ctor(this);
				bool flag7 = cardGamePlayer3 == null;
				cardGame = this;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19 (Il2CppClass<KPlayer[]>)+40]");
					cardGame = (CardGame)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19 (Il2CppClass<KPlayer[]>)+40]");
					cardGame2 = (CardGame)0;
					if (flag8)
					{
						goto IL_04e9;
					}
				}
				bool flag9 = array.Length < 2;
				object obj7 = !flag9;
				object obj8 = array.Length - 2;
				bool flag10 = obj8 == null;
				object obj9 = ~obj7;
				object obj10 = obj9 | flag10;
				obj3 = 0;
				if (obj10 == null)
				{
					object obj11 = array + 48;
					obj11 = cardGamePlayer3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					CardGamePlayer cardGamePlayer4 = default(CardGamePlayer);
					cardGamePlayer4..ctor(this);
					bool flag11 = cardGamePlayer4 == null;
					cardGame = this;
					if (!flag11)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v18 (Il2CppClass<KPlayer[]>)+40]");
						cardGame = (CardGame)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = ex == null;
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v18 (Il2CppClass<KPlayer[]>)+40]");
						cardGame2 = (CardGame)0;
						if (flag12)
						{
							goto IL_04e9;
						}
					}
					object obj12 = array.Length & 0xFFFFFFFCL;
					bool flag13 = obj12 == null;
					obj3 = 0;
					if (!flag13)
					{
						object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3896;
						object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3840;
						object obj15 = array + 56;
						obj15 = cardGamePlayer4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						players = array;
						object obj16 = this + 256;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						CardGameScores cardGameScores = default(CardGameScores);
						cardGameScores..ctor();
						_scores = (TarneebScores)cardGameScores;
						object obj17 = this + 384;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v44+E4]");
						bool flag14 = (nint)0 == 0;
						object obj20 = !flag14;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						CardUtils cardUtils = default(CardUtils);
						cardUtils..ctor((CardGame)this);
						_cardUtils = (TarneebCardUtils)cardUtils;
						object obj21 = this + 392;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						base.Init();
						return;
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		cardGame2 = cardGame;
		goto IL_04e9;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
	}

	protected override void EndGame(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 336;
		base.EndGame(data);
		Room room = base.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameEndScores cardGameEndScores = default(CardGameEndScores);
		cardGameEndScores..ctor(data, gameType);
		InvokeOnCardGameEnd(cardGameEndScores);
		TrackEndGame(cardGameEndScores);
	}

	protected override void UpdateGameState(ISFSObject gameState)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		//IL_00e4: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		object obj2 = (nint)0 + (nint)176;
		object obj3 = typeof(TypeConverter<ushort, char>) + 3048;
		base.UpdateGameState(gameState);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		TarneebBiddingStage tarneebBiddingStage = default(TarneebBiddingStage);
		<BiddingStage>k__BackingField = tarneebBiddingStage;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+B8]");
		object varName = 0;
		int num = SFSExtensions.Get(gameState, (string)varName, 0);
		<HighestBid>k__BackingField = num;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+10]");
		int[] defaultValue = default(int[]);
		int[] array = SFSExtensions.Get(gameState, (string)0, defaultValue);
		<EatingCounts>k__BackingField = array;
		object obj10 = this + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override int[] GetScores()
	{
		return null;
	}

	static TarneebGame()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_00bf: Expected O, but got I
		object obj = "getSecondRescanTask" + 2528;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		object obj3 = "alignContent" + 3568;
		object obj4 = "destinationTimeZone" + 1592;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+B8]");
		object obj6 = 0;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+B8]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+B8]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
