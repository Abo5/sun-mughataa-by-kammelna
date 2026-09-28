using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities.Data;

public static class GameLobbyRequest
{
	public const string Command = "lobby";

	private const string SubCommand = "cmd";

	private const string JoinTeam = "jt";

	private const string JoinSpectators = "js";

	private const string StartGame = "sg";

	private const string Kick = "k";

	public const string Team1Players = "t1ps";

	public const string Team2Players = "t2ps";

	public const string Spectators = "specs";

	public const string Error = "error";

	private const string TeamID = "tid";

	private const string PlayerID = "pid";

	public static void SendStartGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "setMimeType" + 1792;
		object command = "java.io.FileOutputStream" + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public static void SendJoinTeam(int playerId, int teamId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "not" + 3984;
		object key2 = "startPosition" + 3152;
		object key3 = "clear_mass_tournaments" + 264;
		object val = "java.io.FileOutputStream" + 440;
		object command = "java.io.FileOutputStream" + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, playerId);
		SFSExtensions.Put(sFSObject, (string)key2, teamId);
		SFSExtensions.Put(sFSObject, (string)key3, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public static void SendJoinSpectators(int playerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "not" + 3984;
		object key2 = "clear_mass_tournaments" + 264;
		object val = "java.io.FileOutputStream" + 384;
		object command = "java.io.FileOutputStream" + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, playerId);
		SFSExtensions.Put(sFSObject, (string)key2, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public static void SendKick(int playerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "not" + 3984;
		object key2 = "clear_mass_tournaments" + 264;
		object val = "java.io.FileOutputStream" + 464;
		object command = "java.io.FileOutputStream" + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, playerId);
		SFSExtensions.Put(sFSObject, (string)key2, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}
}
