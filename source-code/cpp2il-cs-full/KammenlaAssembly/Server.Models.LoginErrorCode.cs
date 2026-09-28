namespace Server.Models;

public enum LoginErrorCode
{
	UnknownError = -1,
	IncorrectInfo = 1,
	Kicked = 2,
	LoggedToDifferentServer = 3,
	Restricted = 4,
	Banned = 5,
	NewUser = 7,
	Lockdown = 8,
	InvalidVersion = 9,
	InvalidToken = 10,
	TokenExpired = 11,
	ResetPasswordRequired = 12
}
