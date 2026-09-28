using Cpp2ILInjected;
using UnityEngine;

public class ClanRateLimitConfig : ScriptableObject
{
	private bool _joinRequestLimiterEnabled = true;

	private int _joinRequestLimit;

	private int _joinRequestWindowMinutes;

	public bool JoinRequestLimiterEnabled => _joinRequestLimiterEnabled;

	public int JoinRequestLimit => _joinRequestLimit;

	public int JoinRequestWindowMinutes => _joinRequestWindowMinutes;

	public ClanRateLimitConfig()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535E8]");
		_joinRequestLimit = 0;
		base..ctor();
	}
}
