using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class TournamentData
{
	private static class Constants
	{
		public const string TournamentID = "id";

		public const string ClusterID = "cid";

		public const string ParentMasEventId = "mei";

		public const string RoomID = "rid";

		public const string RoomGroup = "rg";

		public const string CreatorInfo = "ci";

		public const string Organizer = "o";

		public const string Prize1 = "p1";

		public const string Prize2 = "p2";

		public const string Prize3 = "p3";

		public const string JoiningCost = "jc";

		public const string Instant = "ii";

		public const string AvailabilityDate = "ad";

		public const string TimerToStart = "t";

		public const string Seats = "s";

		public const string MaxAllowedSeats = "mas";

		public const string WinningBestOf = "bo";

		public const string WinningBestOfFinal = "fbo";

		public const string TournamentName = "tn";

		public const string Cheating = "ca";

		public const string MinRank = "r";

		public const string Speed = "tmr";

		public const string TourneyType = "tt";

		public const string TourneySubType = "tst";

		public const string Hidden = "hd";

		public const string PasswordProtected = "pr";

		public const string IsForChampions = "ic";

		public const string PrizeTypeKey = "pt";

		public const string Cluster = "cl";

		public const string ClusterSize = "cz";

		public const string TournamentAddon = "ao";

		public const string SpawnerId = "si";
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ISFSObject, TournamentAddonModel> <>9__125_0;

		public static Func<TournamentAddonModel, TournamentAddonType> <>9__125_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TournamentAddonModel <.ctor>b__125_0(ISFSObject o)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentAddonCreationModel tournamentAddonCreationModel = default(TournamentAddonCreationModel);
			tournamentAddonCreationModel..ctor(o);
			if (tournamentAddonCreationModel != null)
			{
				return tournamentAddonCreationModel.GetAddonModel();
			}
			return (TournamentAddonModel)(object)new NullReferenceException();
		}

		internal TournamentAddonType <.ctor>b__125_1(TournamentAddonModel model)
		{
			//IL_005d: Expected I4, but got O
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (model != null)
			{
				nint num = (nint)model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<TournamentAddonModel>)+188]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<TournamentAddonModel>)+190]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (TournamentAddonType)ex;
		}
	}

	private readonly int? <TournamentId>k__BackingField;

	private readonly int? <ClusterID>k__BackingField;

	private readonly long? <ParentMassEventId>k__BackingField;

	private readonly int <RoomId>k__BackingField;

	private readonly string <RoomGroup>k__BackingField;

	public Dictionary<TournamentAddonType, TournamentAddonModel> Addons;

	private readonly string <Name>k__BackingField;

	private readonly PlayerInfo <Creator>k__BackingField;

	private readonly string <OrganizerName>k__BackingField;

	private readonly TournamentType <Type>k__BackingField;

	private readonly TournamentSubType? <SubType>k__BackingField;

	private readonly int <Size>k__BackingField;

	private readonly int <MaxAllowedSize>k__BackingField;

	private readonly int <BestOf>k__BackingField;

	private readonly int <FinalBestOf>k__BackingField;

	private readonly TournamentPrizeType <PrizeType>k__BackingField;

	private readonly int <FirstPrize>k__BackingField;

	private readonly int? <SecondPrize>k__BackingField;

	private readonly int? <ThirdPrize>k__BackingField;

	private readonly int <JoiningPrice>k__BackingField;

	private readonly bool <IsInstant>k__BackingField;

	private readonly DateTime <AvailabilityTime>k__BackingField;

	private readonly DateTime <StartingTime>k__BackingField;

	private readonly bool <CheatingAllowed>k__BackingField;

	private readonly PlayerRank.Ranks <RankLimit>k__BackingField;

	private readonly int <Timer>k__BackingField;

	private readonly bool <IsHidden>k__BackingField;

	private readonly bool <IsProtected>k__BackingField;

	private readonly bool <IsChampions>k__BackingField;

	private readonly string <ImageLink>k__BackingField;

	private readonly bool <IsCluster>k__BackingField;

	private readonly int? <ClusterCapacity>k__BackingField;

	private readonly int? <SpawnerId>k__BackingField;

	public int? TournamentId => <TournamentId>k__BackingField;

	public int? ClusterID => <ClusterID>k__BackingField;

	public long? ParentMassEventId => <ParentMassEventId>k__BackingField;

	public int RoomId => <RoomId>k__BackingField;

	public string RoomGroup => <RoomGroup>k__BackingField;

	public CardbackTournamentAddon TournamentAddonsCardback
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			CardbackTournamentAddon result = default(CardbackTournamentAddon);
			return result;
		}
	}

	public RoomThemeTournamentAddon TournamentAddonsRoomTheme
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			RoomThemeTournamentAddon result = default(RoomThemeTournamentAddon);
			return result;
		}
	}

	public VoiceChatTournamentAddon TournamentAddonsVoiceChat
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			VoiceChatTournamentAddon result = default(VoiceChatTournamentAddon);
			return result;
		}
	}

	public MessageTournamentAddon TournamentAddonsMessage
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			MessageTournamentAddon result = default(MessageTournamentAddon);
			return result;
		}
	}

	public TitleRestrictionTournamentAddon TournamentAddonsTitleRestriction
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			TitleRestrictionTournamentAddon result = default(TitleRestrictionTournamentAddon);
			return result;
		}
	}

	public ChampionshipTournamentAddon TournamentAddonsChampionship
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			ChampionshipTournamentAddon result = default(ChampionshipTournamentAddon);
			return result;
		}
	}

	public SportTeamsCelebrationTournamentAddon TournamentAddonsSportTeamsCelebration
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			SportTeamsCelebrationTournamentAddon result = default(SportTeamsCelebrationTournamentAddon);
			return result;
		}
	}

	public string Name => <Name>k__BackingField;

	public PlayerInfo Creator => <Creator>k__BackingField;

	public string OrganizerName => <OrganizerName>k__BackingField;

	public TournamentType Type => <Type>k__BackingField;

	public TournamentSubType? SubType => <SubType>k__BackingField;

	public int Size => <Size>k__BackingField;

	public int MaxAllowedSize => <MaxAllowedSize>k__BackingField;

	public int AllowedSeats => <Size>k__BackingField << 1;

	public int BestOf => <BestOf>k__BackingField;

	public int FinalBestOf => <FinalBestOf>k__BackingField;

	public int WiningValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009d: Expected O, but got I4
			//IL_005f: Expected I4, but got I8
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			object obj4 = default(object);
			if ((nint)obj4 == 2139095040)
			{
				return -2147483648;
			}
			return <BestOf>k__BackingField;
		}
	}

	public int FinalWiningValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009d: Expected O, but got I4
			//IL_005f: Expected I4, but got I8
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			object obj4 = default(object);
			if ((nint)obj4 == 2139095040)
			{
				return -2147483648;
			}
			return <FinalBestOf>k__BackingField;
		}
	}

	public TournamentPrizeType PrizeType => <PrizeType>k__BackingField;

	public int FirstPrize => <FirstPrize>k__BackingField;

	public int? SecondPrize => <SecondPrize>k__BackingField;

	public int? ThirdPrize => <ThirdPrize>k__BackingField;

	public int TotalPrize
	{
		get
		{
			//IL_001c: Expected O, but got I
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected I4, but got Unknown
			int num = <FirstPrize>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentData)+88]");
			object obj = (nint)num + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentData)+90]");
			return obj + 0;
		}
	}

	public int JoiningPrice => <JoiningPrice>k__BackingField;

	public bool IsInstant => <IsInstant>k__BackingField;

	public DateTime AvailabilityTime => <AvailabilityTime>k__BackingField;

	public DateTime StartingTime => <StartingTime>k__BackingField;

	public bool CheatingAllowed => <CheatingAllowed>k__BackingField;

	public PlayerRank.Ranks RankLimit => <RankLimit>k__BackingField;

	public int Timer => <Timer>k__BackingField;

	public bool IsHidden => <IsHidden>k__BackingField;

	public bool IsProtected => <IsProtected>k__BackingField;

	public bool IsChampions => <IsChampions>k__BackingField;

	public string ImageLink => <ImageLink>k__BackingField;

	public bool IsCluster => <IsCluster>k__BackingField;

	public int? ClusterCapacity => <ClusterCapacity>k__BackingField;

	public int? SpawnerId => <SpawnerId>k__BackingField;

	public bool IsMassFinal
	{
		get
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected I4, but got Unknown
			if (<Type>k__BackingField == TournamentType.Mass)
			{
				return (byte)((??)<SubType>k__BackingField & 1) != 0;
			}
			return false;
		}
	}

	public unsafe int? GetPrize(PrizeLevel level)
	{
		//IL_009c: Expected O, but got I4
		//IL_0110: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected I4, but got Unknown
		//IL_012f: Expected O, but got Ref
		//IL_003d: Expected O, but got I4
		//IL_00ef: Expected native int or pointer, but got O
		//IL_005f: Expected O, but got Ref
		int? result;
		if (level <= PrizeLevel.First)
		{
			int value;
			int? num;
			int? result2 = default(int?);
			if (level != PrizeLevel.Total)
			{
				bool flag = level != PrizeLevel.First;
				result = (int?)(object)0;
				if (flag)
				{
					goto IL_00e2;
				}
				value = <FirstPrize>k__BackingField;
				num = (int?)(object)(&result2);
			}
			else
			{
				int num2 = <FirstPrize>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentData)+88]");
				object obj = (nint)num2 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentData)+90]");
				value = obj + 0;
				num = (int?)(object)(&result2);
			}
			*(int?*)(nint)num = value;
			return result2;
		}
		if (level != PrizeLevel.Second)
		{
			bool flag2 = level != PrizeLevel.Third;
			result = (int?)(object)0;
			if (!flag2)
			{
				result = <ThirdPrize>k__BackingField;
			}
			goto IL_00e2;
		}
		return <SecondPrize>k__BackingField;
		IL_00e2:
		return result;
	}

	public unsafe TournamentData(int ID, string name, int creatorId, int size, int prize1, int prize2, int prize3, long timeToStartStamp = 0L, string imageLink = "")
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0028: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_0177: Expected F8, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3104;
		object obj4 = (nint)0 + (nint)3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj5 = this + 64;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		<TournamentId>k__BackingField = ID;
		<RoomId>k__BackingField = ID;
		object obj6 = this + 72;
		obj6 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(creatorId, (string)((nint)0 + (nint)2000));
		object obj8 = this + 80;
		obj8 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int? num = prize2;
		int? num2 = prize3;
		object obj9 = typeof(DataRelation) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v18+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		DateTime dateTime = DateTimeUtil.FromTimeStamp(0.0);
		object obj10 = this + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public TournamentData(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj2 = this + 64;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		<RoomId>k__BackingField = roomId;
	}

	public TournamentData(ISFSObject obj)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_18d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18de: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0050: Expected I, but got O
		//IL_0060: Expected O, but got I
		//IL_193d: Expected O, but got I4
		//IL_009b: Expected O, but got I
		//IL_1971: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0222: Expected I, but got O
		//IL_0232: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0135: Expected I, but got O
		//IL_0145: Expected O, but got I
		//IL_1a18: Expected O, but got I4
		//IL_026d: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_1a4c: Expected O, but got I4
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03f4: Expected I, but got O
		//IL_0404: Expected O, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0307: Expected I, but got O
		//IL_0317: Expected O, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_1af3: Expected O, but got I4
		//IL_043f: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b18: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_057d: Expected O, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_05ee: Expected O, but got I
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_04d9: Expected I, but got O
		//IL_04e9: Expected O, but got I
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_069d: Expected I, but got O
		//IL_06ad: Expected O, but got I
		//IL_0524: Expected O, but got I
		//IL_1bb2: Expected O, but got I
		//IL_1bd6: Expected O, but got I4
		//IL_06e8: Expected O, but got I
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected O, but got Unknown
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected O, but got Unknown
		//IL_0875: Expected O, but got I
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_0782: Expected I, but got O
		//IL_0792: Expected O, but got I
		//IL_08f7: Expected I, but got O
		//IL_0907: Expected O, but got I
		//IL_1c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c56: Expected O, but got Unknown
		//IL_1c76: Expected O, but got I4
		//IL_07cd: Expected O, but got I
		//IL_0a4e: Expected O, but got I4
		//IL_0942: Expected O, but got I
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected O, but got Unknown
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected O, but got Unknown
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected O, but got Unknown
		//IL_0aaa: Expected O, but got I
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected O, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected O, but got Unknown
		//IL_09c0: Expected O, but got I
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected O, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected O, but got Unknown
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected O, but got Unknown
		//IL_0a37: Expected O, but got I4
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Expected O, but got Unknown
		//IL_0bbd: Expected I, but got O
		//IL_0bcd: Expected O, but got I
		//IL_1cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce2: Expected O, but got Unknown
		//IL_0c08: Expected O, but got I
		//IL_0d4b: Expected O, but got I4
		//IL_0d63: Expected I, but got O
		//IL_0d73: Expected O, but got I
		//IL_0d93: Expected O, but got I4
		//IL_0d9c: Expected O, but got I4
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected O, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected O, but got Unknown
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected O, but got Unknown
		//IL_1d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3c: Expected O, but got Unknown
		//IL_1d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4b: Expected O, but got Unknown
		//IL_1d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5a: Expected O, but got Unknown
		//IL_0dd0: Expected O, but got I
		//IL_0cd1: Expected I, but got O
		//IL_0ce1: Expected O, but got I
		//IL_0d03: Expected O, but got I4
		//IL_0d0c: Expected O, but got I4
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected O, but got Unknown
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected O, but got Unknown
		//IL_0eb5: Expected O, but got I4
		//IL_1d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d90: Expected O, but got Unknown
		//IL_1df4: Expected O, but got I4
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected O, but got Unknown
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Expected O, but got Unknown
		//IL_0d2b: Expected O, but got I4
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected O, but got Unknown
		//IL_0ee2: Expected O, but got I4
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Expected O, but got Unknown
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected O, but got Unknown
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Expected O, but got Unknown
		//IL_1e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1b: Expected O, but got Unknown
		//IL_1e27: Expected O, but got I
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e36: Expected O, but got Unknown
		//IL_1e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e45: Expected O, but got Unknown
		//IL_1e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e54: Expected O, but got Unknown
		//IL_1e78: Expected O, but got I4
		//IL_1e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8a: Expected O, but got Unknown
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Expected O, but got Unknown
		//IL_0f96: Expected O, but got I4
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected O, but got Unknown
		//IL_0f2e: Expected O, but got I4
		//IL_1f35: Expected O, but got I
		//IL_1f45: Expected O, but got I
		//IL_1eb7: Expected O, but got I
		//IL_1ec7: Expected O, but got I
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected O, but got Unknown
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected O, but got Unknown
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected O, but got Unknown
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected O, but got Unknown
		//IL_1098: Expected I, but got O
		//IL_10a8: Expected O, but got I
		//IL_1f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7d: Expected O, but got Unknown
		//IL_10e3: Expected O, but got I
		//IL_1226: Expected O, but got I4
		//IL_123e: Expected I, but got O
		//IL_124e: Expected O, but got I
		//IL_126e: Expected O, but got I4
		//IL_1277: Expected O, but got I4
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1141: Expected O, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_114e: Expected O, but got Unknown
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Expected O, but got Unknown
		//IL_1fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd7: Expected O, but got Unknown
		//IL_12ab: Expected O, but got I
		//IL_11ac: Expected I, but got O
		//IL_11bc: Expected O, but got I
		//IL_11de: Expected O, but got I4
		//IL_11e7: Expected O, but got I4
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Expected O, but got Unknown
		//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected O, but got Unknown
		//IL_1416: Expected O, but got I4
		//IL_142e: Expected I, but got O
		//IL_143e: Expected O, but got I
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Expected O, but got Unknown
		//IL_1329: Unknown result type (might be due to invalid IL or missing references)
		//IL_132e: Expected O, but got Unknown
		//IL_1337: Unknown result type (might be due to invalid IL or missing references)
		//IL_133c: Expected O, but got Unknown
		//IL_1206: Expected O, but got I4
		//IL_2031: Unknown result type (might be due to invalid IL or missing references)
		//IL_2036: Expected O, but got Unknown
		//IL_2046: Expected O, but got I
		//IL_2059: Unknown result type (might be due to invalid IL or missing references)
		//IL_205e: Expected O, but got Unknown
		//IL_1491: Expected O, but got I
		//IL_139c: Expected I, but got O
		//IL_13ac: Expected O, but got I
		//IL_13ce: Expected O, but got I4
		//IL_13d7: Expected O, but got I4
		//IL_12b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Expected O, but got Unknown
		//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Expected O, but got Unknown
		//IL_15e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ee: Expected O, but got Unknown
		//IL_1630: Expected O, but got I4
		//IL_153f: Expected I, but got O
		//IL_154f: Expected O, but got I
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Expected O, but got Unknown
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1514: Expected O, but got Unknown
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected O, but got Unknown
		//IL_13f6: Expected O, but got I4
		//IL_212d: Expected O, but got I
		//IL_213d: Expected O, but got I
		//IL_214d: Expected O, but got I
		//IL_216f: Expected O, but got I4
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a4: Expected O, but got Unknown
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Expected O, but got Unknown
		//IL_1656: Expected O, but got I
		//IL_165f: Expected O, but got I4
		//IL_20af: Expected O, but got I
		//IL_20e3: Expected O, but got I4
		//IL_2103: Expected O, but got I
		//IL_158a: Expected O, but got I
		//IL_17d4: Expected O, but got I
		//IL_17e4: Expected O, but got I
		//IL_17f4: Expected O, but got I
		//IL_1816: Expected O, but got I4
		//IL_1836: Expected O, but got I
		//IL_16eb: Expected O, but got I4
		//IL_1739: Expected O, but got I
		//IL_1749: Expected O, but got I
		//IL_1759: Expected O, but got I
		//IL_177b: Expected O, but got I4
		//IL_218c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2191: Expected O, but got Unknown
		//IL_21a7: Expected O, but got I
		//IL_21b8: Expected I, but got O
		//IL_21d6: Expected O, but got I
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected O, but got Unknown
		//IL_168a: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Expected O, but got Unknown
		//IL_1698: Unknown result type (might be due to invalid IL or missing references)
		//IL_169d: Expected O, but got Unknown
		//IL_186e: Expected O, but got I4
		//IL_171b: Expected O, but got I
		//IL_1598: Unknown result type (might be due to invalid IL or missing references)
		//IL_159d: Expected O, but got Unknown
		//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ab: Expected O, but got Unknown
		//IL_2220: Unknown result type (might be due to invalid IL or missing references)
		//IL_2225: Expected O, but got Unknown
		//IL_223b: Expected O, but got I
		//IL_224c: Expected I, but got O
		//IL_226a: Expected O, but got I
		//IL_17a9: Expected O, but got I
		//IL_189e: Expected O, but got I
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj3 = this + 64;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj4 = typeof(System.IOAsyncCallback) + 976;
		object obj5 = "https://www.kammelna.com/Home/Terms" + 328;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00dc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X10_v98-8]");
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
			goto IL_00dc;
		}
		object obj8 = (object)(num + (object)(obj7 + 1)) + 312;
		goto IL_1919;
		IL_0dba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v107 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		object obj10;
		object obj11;
		object obj13;
		object obj16;
		object obj12;
		object obj15;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1607 @ X10_v42-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj9 += 16;
			obj11--;
			bool flag = (nint)obj11 != 1;
			obj12 = obj13;
			object obj14 = obj10;
			obj15 = obj16;
			if (flag)
			{
				continue;
			}
			goto IL_0e29;
		}
		nint num2;
		object obj17 = (object)(num2 + (object)(obj9 + 1)) + 312;
		obj12 = obj13;
		obj15 = obj16;
		goto IL_1d2d;
		IL_0e29:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1d2d;
		IL_1124:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1f6e;
		IL_15cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_209f;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1919;
		IL_1919:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v409 @ X0_v9] (should have been resolved before IL gen)");
		object obj18 = default(object);
		bool flag2 = obj18 == null;
		object obj19 = !flag2;
		object obj20 = ~obj19;
		TournamentData tournamentData = ((obj20 != null) ? null : this);
		bool flag3 = obj18 == null;
		TournamentData tournamentData2 = this;
		int? num3 = (int?)(object)0;
		if (flag3)
		{
			goto IL_01fe;
		}
		nint num4 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v149 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v149 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v149 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v93-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_01c1;
		}
		object obj23 = (object)(num4 + (object)(obj22 + 14)) + 312;
		goto IL_19a3;
		IL_1304:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1fc8;
		IL_0983:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1275 @ X0_v186] (should have been resolved before IL gen)");
		object obj24 = default(object);
		if (obj24 != null)
		{
			goto IL_09b4;
		}
		goto IL_0a45;
		IL_1fc8:
		object obj25 = "alignContent" + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1989 @ X0_v93] (should have been resolved before IL gen)");
		object obj26 = default(object);
		object obj27;
		object obj28;
		object obj29;
		object obj30;
		object obj31;
		object obj33;
		nint num6;
		object obj34;
		object obj36;
		if (obj26 != null)
		{
			<SpawnerId>k__BackingField = SFSExtensions.Get(obj, (string)obj27, 0);
			obj28 = obj29;
			obj30 = obj25;
			nint num5 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ X8_v87 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ X8_v87 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj32 = (nint)0 != 0;
			obj33 = 0;
			num6 = num5;
			if (obj32 != null)
			{
				goto IL_147b;
			}
			obj34 = 0;
			object obj35 = obj29;
			obj36 = obj25;
		}
		else
		{
			<SpawnerId>k__BackingField = (int?)(object)0;
			obj28 = obj29;
			obj30 = obj25;
			num6 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2029 @ X8_v80 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2029 @ X8_v80 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			bool flag4 = (nint)0 == 0;
			obj34 = obj33;
			object obj35 = obj29;
			obj36 = obj25;
			if (!flag4)
			{
				goto IL_147b;
			}
		}
		goto IL_14ea;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1b59;
		IL_1b59:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v961 @ X0_v204] (should have been resolved before IL gen)");
		long value = default(long);
		long? num7 = value;
		long? num8 = num7;
		goto IL_05b5;
		IL_05b5:
		object varName = "placementId" + 4048;
		object varName2 = "placementId" + 3944;
		object varName3 = "startPosition" + 3448;
		object defaultValue = (nint)0 + (nint)2000;
		object obj37 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3288;
		TournamentData tournamentData3;
		tournamentData3.<ParentMassEventId>k__BackingField = num8;
		<RoomId>k__BackingField = SFSExtensions.Get(obj, (string)varName, 0);
		string text = SFSExtensions.Get(obj, (string)varName2, (string)null);
		object obj38 = this + 56;
		obj38 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text2 = SFSExtensions.Get(obj, (string)varName3, (string)defaultValue);
		object obj39 = this + 72;
		obj39 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num9 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0729;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj41 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X10_v65-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj41 += 16;
			obj40--;
			if ((nint)obj40 != 1)
			{
				continue;
			}
			goto IL_0729;
		}
		object obj42 = (object)(num9 + (object)(obj41 + 1)) + 312;
		goto IL_1ba2;
		IL_0a45:
		System.Int32Enum? int32Enum = (System.Int32Enum?)(object)0;
		goto IL_0a53;
		IL_209f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X0_v132+8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2209 @ X0_v132] (should have been resolved before IL gen)");
		object obj45;
		object obj44 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2254 @ X0_v126+E4]");
		bool flag5 = (nint)0 == 0;
		object obj46 = !flag5;
		object obj47 = obj25;
		SFSArray sFSArray2 = default(SFSArray);
		SFSArray sFSArray = sFSArray2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X0_v132+8]");
		object obj48 = 0;
		object obj49 = obj44;
		SFSArray sFSArray3 = sFSArray2;
		if (obj46 == null)
		{
			goto IL_16a2;
		}
		goto IL_2121;
		IL_01c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_19a3;
		IL_19a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v564 @ X0_v224] (should have been resolved before IL gen)");
		int value2 = default(int);
		int? num10 = value2;
		tournamentData2 = tournamentData;
		num3 = num10;
		goto IL_01fe;
		IL_01fe:
		object obj50 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3296;
		tournamentData2.<TournamentId>k__BackingField = num3;
		nint num11 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02ae;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj52 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v87-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj52 += 16;
			obj51--;
			if ((nint)obj51 != 1)
			{
				continue;
			}
			goto IL_02ae;
		}
		object obj53 = (object)(num11 + (object)(obj52 + 1)) + 312;
		goto IL_19f4;
		IL_09b4:
		object obj54 = (nint)0 + (nint)216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		System.Int32Enum value3 = default(System.Int32Enum);
		int32Enum = value3;
		goto IL_0a53;
		IL_0a53:
		object varName4 = "rightCtrl" + 768;
		object varName5 = "m_StencilDeferredPS" + 520;
		object varName6 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 680;
		object varName7 = "destinationTimeZone" + 3896;
		object obj55 = "placementId" + 1504;
		object obj56 = (nint)0 + (nint)200;
		object varName8 = "not" + 2928;
		object varName9 = "not" + 2936;
		<SubType>k__BackingField = (TournamentSubType?)int32Enum;
		<MaxAllowedSize>k__BackingField = SFSExtensions.Get(obj, (string)varName5, (<Size>k__BackingField = SFSExtensions.Get(obj, (string)varName4, 0)) << 1);
		<FinalBestOf>k__BackingField = SFSExtensions.Get(obj, (string)varName7, <BestOf>k__BackingField = SFSExtensions.Get(obj, (string)varName6, 0));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		TournamentPrizeType tournamentPrizeType = default(TournamentPrizeType);
		<PrizeType>k__BackingField = tournamentPrizeType;
		<FirstPrize>k__BackingField = SFSExtensions.Get(obj, (string)varName8, 0);
		object obj57 = typeof(System.IOAsyncCallback) + 976;
		nint num12 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c49;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj59 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X10_v47-8]");
			if (0 == (nint)obj57)
			{
				break;
			}
			obj59 += 16;
			obj58--;
			if ((nint)obj58 != 1)
			{
				continue;
			}
			goto IL_0c49;
		}
		object obj60 = (object)(num12 + (object)(obj59 + 1)) + 312;
		goto IL_1cd3;
		IL_147b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2029 @ X8_v80 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj61 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2082 @ X10_v27-8]");
			if (0 == (nint)obj28)
			{
				break;
			}
			obj61 += 16;
			obj31--;
			bool flag6 = (nint)obj31 != 1;
			obj34 = obj33;
			object obj35 = obj28;
			obj36 = obj30;
			if (flag6)
			{
				continue;
			}
			goto IL_14ea;
		}
		object obj62 = (object)(num6 + (object)(obj61 + 1)) + 312;
		obj34 = obj33;
		obj36 = obj30;
		goto IL_2022;
		IL_16a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj49 = obj45;
		obj48 = obj43;
		sFSArray3 = sFSArray;
		goto IL_2121;
		IL_02ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_19f4;
		IL_19f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v616 @ X0_v13] (should have been resolved before IL gen)");
		object obj63 = default(object);
		bool flag7 = obj63 == null;
		object obj64 = !flag7;
		object obj65 = ~obj64;
		TournamentData tournamentData4 = ((obj65 != null) ? null : this);
		bool flag8 = obj63 == null;
		TournamentData tournamentData5 = this;
		int? num13 = (int?)(object)0;
		if (flag8)
		{
			goto IL_03d0;
		}
		nint num14 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v141 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v141 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0393;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v141 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj67 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X10_v82-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj67 += 16;
			obj66--;
			if ((nint)obj66 != 1)
			{
				continue;
			}
			goto IL_0393;
		}
		object obj68 = (object)(num14 + (object)(obj67 + 14)) + 312;
		goto IL_1a7e;
		IL_1f6e:
		obj27 = "setMimeType" + 2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1866 @ X0_v90] (should have been resolved before IL gen)");
		object obj69 = default(object);
		object varName10;
		object obj70;
		object obj71;
		object obj72;
		object obj74;
		nint num16;
		object obj76;
		if (obj69 != null)
		{
			<ClusterCapacity>k__BackingField = SFSExtensions.Get(obj, (string)varName10, 0);
			obj70 = obj29;
			obj71 = obj27;
			nint num15 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1907 @ X8_v96 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1907 @ X8_v96 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj73 = (nint)0 != 0;
			obj74 = 0;
			num16 = num15;
			if (obj73 != null)
			{
				goto IL_1295;
			}
			obj33 = 0;
			object obj75 = obj29;
			obj76 = obj27;
		}
		else
		{
			<ClusterCapacity>k__BackingField = (int?)(object)0;
			obj70 = obj29;
			obj71 = obj27;
			num16 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X8_v89 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X8_v89 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			bool flag9 = (nint)0 == 0;
			obj74 = 0;
			obj33 = 0;
			object obj75 = obj29;
			obj76 = obj27;
			if (!flag9)
			{
				goto IL_1295;
			}
		}
		goto IL_1304;
		IL_1ba2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X0_v33+8]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1081 @ X0_v33] (should have been resolved before IL gen)");
		object obj78 = default(object);
		bool flag10 = obj78 == null;
		object obj79 = !flag10;
		object obj80 = ~obj79;
		TournamentData tournamentData6 = ((obj80 != null) ? null : this);
		bool flag11 = obj78 == null;
		TournamentData tournamentData7 = this;
		PlayerInfo playerInfo = null;
		if (flag11)
		{
			goto IL_084b;
		}
		nint num17 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v127 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v127 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_080e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v127 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj82 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X10_v60-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj82 += 16;
			obj81--;
			if ((nint)obj81 != 1)
			{
				continue;
			}
			goto IL_080e;
		}
		object obj83 = (object)(num17 + (object)(obj82 + 29)) + 312;
		goto IL_1c38;
		IL_0729:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1ba2;
		IL_1295:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X8_v89 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj84 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X10_v32-8]");
			if (0 == (nint)obj70)
			{
				break;
			}
			obj84 += 16;
			obj72--;
			bool flag12 = (nint)obj72 != 1;
			obj33 = obj74;
			object obj75 = obj70;
			obj76 = obj71;
			if (flag12)
			{
				continue;
			}
			goto IL_1304;
		}
		object obj85 = (object)(num16 + (object)(obj84 + 1)) + 312;
		obj33 = obj74;
		obj76 = obj71;
		goto IL_1fc8;
		IL_184c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2335 @ X0_v109+E4]");
		object obj87;
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj86 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2349 @ X8_v58+B8]");
			obj87 = 0;
		}
		object obj88 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj89 = (nint)0 + (nint)3840;
		Func<object, System.Int32Enum> func = default(Func<object, System.Int32Enum>);
		func..ctor(obj87, (IntPtr)obj89);
		object obj90 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2323 @ X8_v57+B8]");
		object obj91 = (nint)0 + (nint)16;
		obj91 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> enumerable;
		IEnumerable<object> source = enumerable;
		Func<object, System.Int32Enum> keySelector = func;
		object obj93;
		object obj92 = obj93;
		goto IL_21ed;
		IL_21ed:
		Dictionary<System.Int32Enum, object> dictionary2 = Enumerable.ToDictionary(source, keySelector);
		obj3 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0c49:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1cd3;
		IL_2121:
		object obj94 = (nint)0 + (nint)520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2238 @ X0_v99+B8]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2280 @ X8_v62+8]");
		Func<object, object> func2 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2280 @ X8_v62+8]");
		bool flag13 = (nint)0 == 0;
		object obj96 = !flag13;
		if (obj96 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2238 @ X0_v99+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj97 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2290 @ X8_v68+B8]");
				obj95 = 0;
			}
			object obj98 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj99 = (nint)0 + (nint)3832;
			Func<object, object> func3 = default(Func<object, object>);
			func3..ctor(obj95, (IntPtr)obj99);
			object obj100 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2272 @ X8_v67+B8]");
			object obj101 = (nint)0 + (nint)8;
			obj101 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func2 = func3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		object obj102 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2335 @ X0_v109+E4]");
		IEnumerable<object> enumerable2 = default(IEnumerable<object>);
		if ((nint)0 != 0)
		{
			obj92 = (nint)0 + (nint)1600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2335 @ X0_v109+B8]");
			obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ X8_v52+10]");
			keySelector = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ X8_v52+10]");
			object obj103 = (nint)0 != 0;
			source = enumerable2;
			if (obj103 == null)
			{
				enumerable = enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ X8_v52+10]");
				Func<object, System.Int32Enum> func4 = (Func<object, System.Int32Enum>)0;
				obj93 = obj92;
				goto IL_184c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj102 = obj45;
			obj93 = (nint)0 + (nint)1600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2335 @ X0_v109+B8]");
			obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ X8_v52+10]");
			Func<object, System.Int32Enum> func4 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ X8_v52+10]");
			object obj104 = (nint)0 != 0;
			enumerable = enumerable2;
			source = enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ X8_v52+10]");
			keySelector = (Func<object, System.Int32Enum>)0;
			obj92 = obj93;
			if (obj104 == null)
			{
				goto IL_184c;
			}
		}
		goto IL_21ed;
		IL_0393:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1a7e;
		IL_1a7e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v771 @ X0_v214] (should have been resolved before IL gen)");
		int value4 = default(int);
		num10 = value4;
		tournamentData5 = tournamentData4;
		num13 = num10;
		goto IL_03d0;
		IL_03d0:
		object obj105 = "m_StencilDeferredPS" + 1176;
		tournamentData5.<ClusterID>k__BackingField = num13;
		nint num18 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0480;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj107 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X10_v76-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj107 += 16;
			obj106--;
			if ((nint)obj106 != 1)
			{
				continue;
			}
			goto IL_0480;
		}
		object obj108 = (object)(num18 + (object)(obj107 + 1)) + 312;
		goto IL_1acf;
		IL_1cd3:
		object obj109 = "not" + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1516 @ X0_v59] (should have been resolved before IL gen)");
		object obj110 = default(object);
		if (obj110 != null)
		{
			<SecondPrize>k__BackingField = SFSExtensions.Get(obj, (string)varName9, 0);
			obj10 = obj57;
			obj16 = obj109;
			nint num19 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ X8_v114 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ X8_v114 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj111 = (nint)0 != 0;
			obj13 = 0;
			num2 = num19;
			if (obj111 != null)
			{
				goto IL_0dba;
			}
			obj12 = 0;
			object obj14 = obj57;
			obj15 = obj109;
		}
		else
		{
			<SecondPrize>k__BackingField = (int?)(object)0;
			obj10 = obj57;
			obj16 = obj109;
			num2 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v107 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v107 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			bool flag14 = (nint)0 == 0;
			obj13 = 0;
			obj12 = 0;
			object obj14 = obj57;
			obj15 = obj109;
			if (!flag14)
			{
				goto IL_0dba;
			}
		}
		goto IL_0e29;
		IL_1d2d:
		object varName11 = "java.io.FileOutputStream" + 272;
		object varName12 = "https://www.kammelna.com/Home/Terms" + 592;
		object obj112 = "___# Content push apply failed [{0}]: {1}" + 3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1639 @ X0_v62] (should have been resolved before IL gen)");
		object obj113 = default(object);
		int? num20 = (int?)((obj113 == null) ? ((object)0) : new int?(SFSExtensions.Get(obj, (string)obj109, 0)));
		object obj114 = "startPosition" + 2136;
		<ThirdPrize>k__BackingField = num20;
		int num21 = SFSExtensions.Get(obj, (string)varName11, 0);
		<JoiningPrice>k__BackingField = num21;
		bool flag15 = SFSExtensions.Get(obj, (string)varName12, defaultValue: false);
		<IsInstant>k__BackingField = flag15;
		string text3 = (string)obj112;
		DateTime? dateTime = SFSExtensions.Get(obj, (string)obj112, (DateTime?)(object)0);
		if ((object)((object)((??)dateTime & 1) != null) == null)
		{
			object obj115 = typeof(DataRelation) + 712;
			object obj116 = obj115;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1706 @ X0_v163+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj116 = obj115;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1706 @ X0_v163+B8]");
			object obj117 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1710 @ X8_v101+10]");
			text3 = (string)0;
		}
		object varName13 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2048;
		object obj118 = "placementId" + 2064;
		object obj119 = (nint)0 + (nint)264;
		object varName14 = "startPosition" + 3432;
		object varName15 = "getSecondRescanTask" + 2544;
		object varName16 = "placementId" + 528;
		<AvailabilityTime>k__BackingField = (DateTime)text3;
		string text4 = (string)obj114;
		DateTime? dateTime2 = SFSExtensions.Get(obj, (string)obj114, (DateTime?)(object)0);
		object obj120 = (??)dateTime2 & 1;
		if (obj120 == null)
		{
			object obj121 = typeof(DataRelation) + 712;
			object obj122 = obj121;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1744 @ X0_v159+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj122 = obj121;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1744 @ X0_v159+B8]");
			object obj123 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X8_v99+10]");
			text4 = (string)0;
		}
		<StartingTime>k__BackingField = (DateTime)text4;
		bool flag16 = SFSExtensions.Get(obj, (string)varName13, defaultValue: false);
		<CheatingAllowed>k__BackingField = flag16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		PlayerRank.Ranks ranks = default(PlayerRank.Ranks);
		<RankLimit>k__BackingField = ranks;
		int num22 = SFSExtensions.Get(obj, (string)varName14, 10);
		<Timer>k__BackingField = num22;
		<IsHidden>k__BackingField = SFSExtensions.Get(obj, (string)varName15, defaultValue: false);
		<IsProtected>k__BackingField = SFSExtensions.Get(obj, (string)varName16, defaultValue: false);
		<IsChampions>k__BackingField = SFSExtensions.Get(obj, "https://www.kammelna.com/Home/Terms" + 280, defaultValue: false);
		<IsCluster>k__BackingField = SFSExtensions.Get(obj, "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3384, defaultValue: false);
		obj29 = typeof(System.IOAsyncCallback) + 976;
		varName10 = "com.unity.services.authentication.profile" + 2768;
		nint num23 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1124;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj125 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1837 @ X10_v37-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			obj125 += 16;
			obj124--;
			if ((nint)obj124 != 1)
			{
				continue;
			}
			goto IL_1124;
		}
		object obj126 = (object)(num23 + (object)(obj125 + 1)) + 312;
		goto IL_1f6e;
		IL_14ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_2022;
		IL_2022:
		obj45 = typeof(SkeletonBinary.SkeletonInput) + 3536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v96+8]");
		obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2113 @ X0_v96] (should have been resolved before IL gen)");
		object obj128 = default(object);
		object obj127 = obj128 & 1;
		if (obj127 != null)
		{
			nint num24 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2128 @ X8_v74 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj129 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2128 @ X8_v74 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_15cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2128 @ X8_v74 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj130 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ X10_v22-8]");
				if (0 == (nint)obj29)
				{
					break;
				}
				obj130 += 16;
				obj129--;
				if ((nint)obj129 != 1)
				{
					continue;
				}
				goto IL_15cb;
			}
			object obj131 = (object)(num24 + (object)(obj130 + 28)) + 312;
			goto IL_209f;
		}
		object obj132 = typeof(RegisteredWaitHandle) + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSArray sFSArray4 = default(SFSArray);
		sFSArray4..ctor();
		obj49 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2238 @ X0_v99+E4]");
		object obj133 = (nint)0 != 0;
		sFSArray3 = sFSArray4;
		if (obj133 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v96+8]");
			obj43 = 0;
			obj47 = 0;
			obj44 = obj49;
			sFSArray = sFSArray4;
			goto IL_16a2;
		}
		goto IL_2121;
		IL_0480:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1acf;
		IL_1acf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v823 @ X0_v17] (should have been resolved before IL gen)");
		object obj134 = default(object);
		bool flag17 = obj134 == null;
		object obj135 = !flag17;
		object obj136 = ~obj135;
		tournamentData3 = ((obj136 != null) ? null : this);
		object obj137 = obj134 & 1;
		if (obj137 != null)
		{
			nint num25 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v134 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj138 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v134 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0565;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v134 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj139 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X10_v71-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj139 += 16;
				obj138--;
				if ((nint)obj138 != 1)
				{
					continue;
				}
				goto IL_0565;
			}
			object obj140 = (object)(num25 + (object)(obj139 + 15)) + 312;
			goto IL_1b59;
		}
		num8 = (long?)(object)0;
		tournamentData3 = this;
		goto IL_05b5;
		IL_084b:
		object varName17 = "not" + 632;
		object obj141 = "tournament_participate_warning_body_with_tickets_warning_daily" + 792;
		object obj142 = (nint)0 + (nint)224;
		object obj143 = "tournament_participate_warning_body_with_tickets_warning_daily" + 784;
		object obj144 = tournamentData7 + 80;
		obj144 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text5 = SFSExtensions.Get(obj, (string)varName17, (string)defaultValue);
		object obj145 = this + 88;
		obj145 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		nint num26 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0983;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj147 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ X10_v54-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj147 += 16;
			obj146--;
			if ((nint)obj146 != 1)
			{
				continue;
			}
			goto IL_0983;
		}
		object obj148 = (object)(num26 + (object)(obj147 + 1)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1313 @ X0_v189] (should have been resolved before IL gen)");
		object obj149 = default(object);
		if ((object)(obj149 != null) != null)
		{
			goto IL_09b4;
		}
		goto IL_0a45;
		IL_1c38:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1214 @ X0_v192] (should have been resolved before IL gen)");
		object obj150 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo2 = default(PlayerInfo);
		ISFSObject data = default(ISFSObject);
		playerInfo2..ctor(data);
		obj77 = 0;
		tournamentData7 = tournamentData6;
		playerInfo = playerInfo2;
		goto IL_084b;
		IL_080e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1c38;
	}

	public bool CanParticipate(User user)
	{
		//IL_008f: Expected O, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected I4, but got Unknown
		//IL_0332: Expected I4, but got O
		//IL_0113: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_01fc: Expected O, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0245: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		bool result;
		if (<Type>k__BackingField == TournamentType.OfficialMonthly)
		{
			int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(user);
			bool flag = tournamentPoints < 0;
			bool flag2 = tournamentPoints == 0;
			int num = tournamentPoints ^ tournamentPoints;
			int num2 = tournamentPoints & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool flag5 = (byte)((flag4 & obj) ? 1 : 0) != 0;
			result = flag5;
			goto IL_0380;
		}
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		PlayerInfo playerInfo = <Creator>k__BackingField;
		int num3;
		PlayerRank rank;
		if (<Creator>k__BackingField != null)
		{
			num3 = playerInfo.<DBID>k__BackingField;
			rank = SFSKammelnaUserExtensions.GetRank(user);
			bool flag6 = rank == null;
			object obj2 = !flag6;
			if (obj2 != null)
			{
				goto IL_0159;
			}
		}
		else
		{
			rank = SFSKammelnaUserExtensions.GetRank(user);
			bool flag7 = rank == null;
			num3 = 0;
			if (!flag7)
			{
				goto IL_0159;
			}
		}
		goto IL_0324;
		IL_0380:
		return result;
		IL_0318:
		return true;
		IL_01c5:
		object obj3 = rank.<Rank>k__BackingField - <RankLimit>k__BackingField;
		bool flag8 = (nint)obj3 < 0;
		object obj4 = rank.<Rank>k__BackingField ^ <RankLimit>k__BackingField;
		object obj5 = rank.<Rank>k__BackingField ^ obj3;
		object obj6 = obj4 & obj5;
		bool flag9 = (nint)obj6 < 0;
		bool flag10 = flag8 == flag9;
		bool flag11;
		object obj7 = flag10 && flag11;
		if ((nint)obj7 == 1)
		{
			PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(user);
			if (rank2 == null)
			{
				goto IL_0324;
			}
			if (!rank2.<IsNew>k__BackingField)
			{
				goto IL_0318;
			}
			bool flag12 = SFSKammelnaUserExtensions.IsSubscribed(user);
			bool flag13 = !flag12;
			object obj8 = !flag13;
			result = true;
			if (obj8 == null)
			{
				bool flag14 = <Type>k__BackingField == TournamentType.Public;
				return !flag14;
			}
			goto IL_0380;
		}
		return false;
		IL_0159:
		object obj9 = (nint)0 + (nint)464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
		object obj10 = default(object);
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
			TitleRestrictionTournamentAddon titleRestrictionTournamentAddon = default(TitleRestrictionTournamentAddon);
			if (titleRestrictionTournamentAddon == null)
			{
				goto IL_0324;
			}
			flag11 = titleRestrictionTournamentAddon.IsEligible();
			if (intDbId != num3)
			{
				goto IL_01c5;
			}
		}
		else
		{
			bool flag15 = intDbId == num3;
			flag11 = true;
			if (!flag15)
			{
				goto IL_01c5;
			}
		}
		goto IL_0318;
		IL_0324:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool IsSeasonalFinals()
	{
		//IL_0021: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected I4, but got Unknown
		if (<IsCluster>k__BackingField)
		{
			bool flag = <Type>k__BackingField == TournamentType.Public;
			object obj = !flag;
			if (obj == null && TournamentAddonListExtensions.HasAddonOfType<T>(Addons) && TournamentAddonListExtensions.HasAddonOfType<T>(Addons))
			{
				object obj2 = (??)<SpawnerId>k__BackingField ^ 1;
				return (byte)(obj2 & 1) != 0;
			}
		}
		return false;
	}
}
