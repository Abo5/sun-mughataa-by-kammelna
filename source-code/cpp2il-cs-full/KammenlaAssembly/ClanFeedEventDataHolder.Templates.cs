using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;

public class ClanFeedEventDataHolder : IListViewItemData<int>
{
	public static class Templates
	{
		public const string Announcement = "Announcement Feed Strip";

		public const string Join = "Join Feed strip";

		public const string Leave = "Leave Feed strip";

		public const string RankUp = "Member rank up Feed strip";

		public const string Achievement = "Achievement Feed strip";

		public const string Donation = "Donation Feed strip";

		public const string VaultSupportRequest = "Vault Support Request Feed strip";

		public const string PrivateTournamentResult = "Private Tournament Result Feed strip";

		public const string FriendlyChallengeResult = "Friendly Challenge Result Feed strip";

		public const string Vote = "Vote Event";

		public const string LiveTournament = "Tournament Clan Strip Card";

		public const string LiveGame = "Live Game Clan Strip Card";

		public const string ClanCreated = "Clan Created Event";

		public const string MembersMilestone = "Members Milestone Event";

		public const string ClanUpgraded = "Clan Upgraded Event";

		public const string ClanUpgradedCallToAction = "Clan Upgraded Event Call to Action";

		public const string ClanUpgradedEmblem = "Clan Upgraded Emblem Event";

		public const string SeasonChampion = "Season Champion Event";

		public const string MonthlyTournamentWin = "Monthly Tournament Win Event";

		public const string LeaderboardRank = "Leaderboard Rank Event";
	}

	private readonly int <index>k__BackingField;

	private ClanFeedModel <Model>k__BackingField;

	private readonly Room <TournamentRoom>k__BackingField;

	private readonly Room <GameRoom>k__BackingField;

	private readonly DateTime <SortDate>k__BackingField;

	public int index => <index>k__BackingField;

	public ClanFeedModel Model
	{
		get
		{
			return <Model>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Room TournamentRoom => <TournamentRoom>k__BackingField;

	public Room GameRoom => <GameRoom>k__BackingField;

	public bool IsLiveTournament
	{
		get
		{
			bool flag = <TournamentRoom>k__BackingField == null;
			return !flag;
		}
	}

	public bool IsLiveGame
	{
		get
		{
			bool flag = <GameRoom>k__BackingField == null;
			return !flag;
		}
	}

	public int LiveRoomId
	{
		get
		{
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_01de: Expected I4, but got I8
			//IL_0015: Expected I, but got O
			//IL_0025: Expected O, but got I
			//IL_00df: Expected I, but got O
			//IL_00ef: Expected O, but got I
			//IL_018d: Expected O, but got I
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01ca: Expected O, but got I
			//IL_0060: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			object obj = typeof(RegisteredWaitHandle) + 1376;
			Room room = <TournamentRoom>k__BackingField;
			nint num = default(nint);
			object obj4 = default(object);
			if (<TournamentRoom>k__BackingField != null)
			{
				object obj2 = obj;
				num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_016b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v1-8]");
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
					goto IL_016b;
				}
			}
			else
			{
				room = <GameRoom>k__BackingField;
				if (<GameRoom>k__BackingField == null)
				{
					goto IL_01d4;
				}
				object obj2 = obj;
				nint num2 = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_016b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v1-8]");
					bool flag = 0 == (nint)obj2;
					num = num2;
					if (flag)
					{
						break;
					}
					obj4 += 16;
					obj5--;
					if ((nint)obj5 != 1)
					{
						continue;
					}
					goto IL_016b;
				}
			}
			goto IL_0197;
			IL_01d4:
			return -1;
			IL_016b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj7 = default(object);
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v134 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0197;
			IL_0197:
			object obj9 = num + obj4;
			object obj10 = obj9 + 312;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v2+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_01d4;
		}
	}

	public DateTime SortDate => <SortDate>k__BackingField;

	public long SortId
	{
		get
		{
			ClanFeedModel clanFeedModel = <Model>k__BackingField;
			if (<Model>k__BackingField != null)
			{
				return clanFeedModel.Id;
			}
			return 9223372036854775807L;
		}
	}

	public string template
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_00a1: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			//IL_00f8: Expected O, but got I4
			//IL_010e: Expected O, but got I
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected O, but got Unknown
			if (<TournamentRoom>k__BackingField != null)
			{
				return "ThisIsFakeReceiptData" + 1248;
			}
			if (<GameRoom>k__BackingField != null)
			{
				return "LAK" + 1928;
			}
			ClanFeedModel clanFeedModel = <Model>k__BackingField;
			if (<Model>k__BackingField != null)
			{
				ClanFeedType type = clanFeedModel.Type;
				bool flag = clanFeedModel.Type < ClanFeedType.MemberRankedTopLeaderboard;
				object obj = !flag;
				object obj2 = clanFeedModel.Type - 14;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				object obj4 = obj & obj3;
				if (obj4 == null)
				{
					object obj5 = 119877632 + 1528;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v2+v114 @ X8_v6 (Kammelna.Server.Models.Clans.ClanFeedType)]");
					object obj6 = (nint)86886444 + (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X10_v2 (should have been resolved before IL gen)");
				}
				if (clanFeedModel.Type == ClanFeedType.ClanUpgradedCallToAction)
				{
					return "Cannot populate JSON object onto type '{0}'." + 2920;
				}
				return "Added Tournament Prizes And Features" + 1680;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public ClanFeedEventDataHolder(int index, ClanFeedModel model)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005c: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		object obj = this + 24;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (model != null)
		{
			<SortDate>k__BackingField = (DateTime)(model + 96);
			return;
		}
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+B8]");
		object obj4 = (nint)0 + (nint)16;
		<SortDate>k__BackingField = (DateTime)obj4;
	}

	private ClanFeedEventDataHolder(int index, DateTime sortDate, Room tournamentRoom, Room gameRoom)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		<index>k__BackingField = index;
		<SortDate>k__BackingField = sortDate;
		object obj = this + 32;
		obj = tournamentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 40;
		obj2 = gameRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static ClanFeedEventDataHolder LiveTournament(int index, Room room, DateTime sortDate)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0030: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 32;
		obj3 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (ClanFeedEventDataHolder)obj2;
	}

	public static ClanFeedEventDataHolder LiveGame(int index, Room room, DateTime sortDate)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 32;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (ClanFeedEventDataHolder)obj2;
	}

	public void UpdateModel(ClanFeedModel model)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (model != null)
		{
			object obj = this + 24;
			obj = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private string LiveActivityTemplate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0067: Expected I, but got O
		//IL_0090: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		ClanFeedModel clanFeedModel = <Model>k__BackingField;
		if (<Model>k__BackingField != null)
		{
			object result = "Added Tournament Prizes And Features" + 1680;
			ClanFeedData data = clanFeedModel.Data;
			if (clanFeedModel.Data != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2352;
				object obj2 = obj;
				nint num = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X11_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X10_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X11_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X10_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X11_v4-8]");
					if (0 == (nint)obj2)
					{
						object obj6 = "Picking audio files is not supported on iOS" + 1880;
						object obj7 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1456;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
						if ((nint)0 == 1)
						{
							result = obj7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
						if ((nint)0 == 0)
						{
							result = obj6;
						}
						return (string)result;
					}
				}
			}
			return (string)result;
		}
		return (string)(object)new NullReferenceException();
	}
}
