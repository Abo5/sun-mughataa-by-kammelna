using System;
using Cpp2ILInjected;

[Serializable]
public class RoomParameters
{
	public string roomName;

	public string password;

	public bool isCheatingEnabled;

	public bool isVoiceRoom;

	public int playSpeed;

	public int minRank;

	public bool isVoiceChatEnabledForSpectators;

	public int jackarooCustomRules;

	public int tvUserId;

	public int clanId;

	public string testDeckCsv;

	public RoomParameters()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E90]");
		playSpeed = 0;
		base..ctor();
	}
}
