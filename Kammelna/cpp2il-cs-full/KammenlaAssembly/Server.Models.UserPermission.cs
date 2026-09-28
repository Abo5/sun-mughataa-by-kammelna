namespace Server.Models;

public enum UserPermission
{
	AccessSwagger = 1,
	RunServerCommands = 2,
	ManageTournaments = 4,
	ResetBeggarCurrency = 8,
	AccessPrivateInfo = 16,
	HaveChatColor = 32,
	KickAndMutePlayers = 64,
	EditPlayerInfo = 128,
	ManageGameRooms = 256,
	AccessHiddenTournaments = 512,
	EnterLockedServers = 65536,
	SeeBroadcasterView = 1024,
	IgnoreGameInvites = 2048,
	CreateTournamentsWithNoPrize = 4096,
	CreateVisiblePrivateTournaments = 8192,
	ForceFriend = 16384,
	PinMessage = 32768,
	ManageMassTournament = 131072
}
