public static class SFSCommands
{
	public static class ManageMass
	{
		public const string COMMAND = "mme";

		public const string ACTION = "act";

		public const int ACTION_EXTEND_STAGE = 1;

		public const int ACTION_MANAGE_CLUSTER = 2;

		public const int ACTION_FIND_TOURNAMENT = 3;

		public const int ACTION_GET_PLAYER_INFO = 4;

		public const int ACTION_ADD_TRIES = 5;

		public const int ACTION_ADD_PLAYER_POINTS = 6;

		public const string PARAM_EXTENSION_MINUTES = "em";

		public const string PARAM_CLUSTER_ACTION = "ca";

		public const int CLUSTER_ACTION_ENTER = 1;

		public const int CLUSTER_ACTION_FORCE_START = 2;

		public const int CLUSTER_ACTION_CANCEL = 3;

		public const string PARAM_TOURNAMENT_NAME = "tn";

		public const string PARAM_TRIES_TO_ADD = "tta";

		public const string UPDATED_TICKETS = "utkt";

		public const string PARAM_POINTS_TO_ADD = "pta";

		public const string UPDATED_POINTS = "msp";
	}

	public static class Clans
	{
		public const string REFRESH_CLAN_MEMBERSHIP = "rcm";

		public const string CLAN_CHAT_MUTE_CHANGED = "ccmc";

		public const string CLAN_CHAT_MUTE_CLAN_ID = "clid";

		public const string CLAN_CHAT_MUTE_UNTIL = "mu";

		public const string CLAN_CHAT_MUTE_REASON = "r";
	}

	public static class FriendlyChallenge
	{
		public const string InviteCommand = "fci";

		public const string ResponseCommand = "fcr";

		public const string StatusCommand = "fcsta";

		public const string ChatAnnouncementCommand = "fcca";

		public const string CancelChallengeCommand = "fccncl";

		public const string ChallengerId = "fcci";

		public const string DefenderId = "fcdi";

		public const string AcceptChallenge = "acpt";
	}

	public const string CreateRoom = "create_room";

	public const string TEST_DECK = "td";

	public const string JoinRoom = "join_room";

	public const string JoinLobby = "join_lobby";

	public const string JoinRoomGroup = "jrg";

	public const string RoomGroupType = "rgt";

	public const string Chat = "chat";

	public const string AnnounceBeggarBan = "abb";

	public const string MutePlayerInGame = "mute_player_in_game";

	public const string BanPlayerFromGame = "ban_player_from_game";

	public const string Forfeit = "forfeit";

	public const string RefreshStatus = "rs";

	public const string RefreshBanStatus = "rbs";

	public const string RefreshLikes = "rlk";

	public const string EnableFreePlayByLocation = "loc";

	public const string SetSeat = "set_seat";

	public const string RefreshInventory = "ri";

	public const string ChangeNickName = "notify_name_changed";

	public const string ControlRoom = "rc";

	public const string Maintenance = "maintenance";

	public const string ReloadConfigs = "reloadConfigs";

	public const string ServerLockDown = "announceLockDown";

	public const string LeaveZone = "lz";

	public const string MatchMaker = "mmkr";

	public const string LockedRoom = "lkr";

	public const string ChatPinnedAvatarEmit = "cpae";

	public const string MonthlyTournamentLeaderboard = "mtlb";

	public const string PinMsg = "pcmd";

	public const string AutoClicker = "auto_clicker";

	public const string GameIdVariable = "gid";

	public const string Platform = "platform";

	public const string Version = "v";

	public const string AuthToken = "at";

	public const string ClientCapabilities = "caps";

	public const string SubCommand = "cmd";

	public const string FindMatch = "find_match";

	public const string LeaveQueue = "leave";

	public const string SkipAd = "sk";

	public const string MatchMakerCannotLeaveQueue = "cannot_leave_queue";

	public const string ChatMessage = "msg";

	public const string PinMessage = "pmsg";

	public const string ChatMessageTag = "tag";

	public const string ChatMessageInk = "i";

	public const string ChatDisable = "disable_chat";

	public const string ControlChat = "control_chat";

	public const string ChatTimestamp = "t";

	public const string Sender = "s";

	public const string PinInformation = "pinmsg";

	public const string ROOM_LIST = "rl";

	public const string PASSWORD = "password";

	public const string ROOM_PASSWORD = "roomPassword";

	public const string SEAT_INDEX = "seat";

	public const string ROOM_ID = "roomId";

	public const string ROOM_NAME = "name";

	public const string RANK_LIMIT = "r";

	public const string ROOM_TIMER = "timer";

	public const string CHEATING_ALLOWED = "ch";

	public const string GAME_SPECTATOR = "gs";

	public const string CLAN_ID = "clan_id";

	public const string ChatBuffer = "chat_buffer";

	public const string Duration = "duration";

	public const string MutePlayerID = "mute_player_id";

	public const string BanPlayerID = "ban_player_id";

	public const string RoomName = "rn";

	public const string DeleteRoom = "rd";

	public const string Error = "error";

	public const string Reason = "reason";

	public const string Comment = "comment";

	public const string Success = "success";

	public const string Status = "sta";

	public const string UserID = "uid";

	public const string ETag = "e";

	public const string SubscribersOnlyError = "subscribers_only";

	public const int NotModified = 304;

	public const string JoinTournamentRoom = "join_tournament_room";

	public const string JoinSpawnerTournament = "jst";

	public const string SpawnerId = "si";

	public const string StartTournament = "stt";

	public const string LoadTournament = "ldt";

	public const string WatchTournamentMatch = "wm";

	public const string TournamentRoomLoaded = "tl";

	public const string TournamentEnableWatchersChat = "ewc";

	public const string BanPlayerFromTournament = "ban_player";

	public const string GetMyTournaments = "gmt";

	public const string ParticipateInTournament = "pt";

	public const string ForfeitTournament = "lt";

	public const string TournamentCaptchaX = "cx";

	public const string TournamentCaptchaY = "cy";

	public const string TournamentId = "tid";

	public const string TournamentBanPlayerId = "player_id";

	public const string MatchId = "mid";

	public const string TournamentRoomId = "tri";

	public const string SeatNumber = "sn";

	public const string TournamentEnableChat = "enbl";

	public const string TournamentPassword = "password";

	public const string LeaderboardData = "d";

	public const string TournamentLeaderboardType = "ty";

	public const string TournamentLeaderboardTitle = "ltt";

	public const string TournamentMonthlyWinners = "mws";

	public const string TournamentConflictId = "id";

	public const string TournamentConflictName = "tcn";

	public const string TournamentConflictTime = "tct";

	public const string MassTournamentLeaderboard = "mlb";

	public const string MassTournamentLeaderboardStage = "stg";

	public const string MassTournamentStageRanking = "mprn";

	public const string MassTournamentWinners = "mew";

	public const string MassTournamentWinnersPlace = "plc";

	public const string MassTournamentWinnersDate = "pdt";

	public const string MassTournamentWinnerInfo = "wi";

	public const string MassTournamentStagesSummery = "mss";

	public const string MassTournamentStagePlayersCount = "spc";

	public const string SendChatPinnedAvatarParticle = "cpap";

	public const string ClaimCurrencyComb = "ccbv";

	public const string GetCurrencyBombLeaderboard = "cbl";

	public const string GetRecentCurrencyBombs = "rcbs";

	public const string BombId = "bi";

	public const string BombCaptchaX = "bx";

	public const string BombCaptchaY = "by";

	public const string CurrencyBombLeaderboardType = "lbt";

	public const string SetVivoxMicMute = "mm";

	public const string VivoxMicIsMute = "ism";

	public const string UserLockedError = "user_locked";

	public const string TvGameCreation = "tv_game_creation";

	public const string TvGameCreationCheck = "check";

	public const string TvGameCreationClaim = "claim";

	public const string TvGameCreationUnclaim = "unclaim";

	public const string TvUserId = "tv_id";

	public const string TvGameCreationClaimed = "claimed";
}
