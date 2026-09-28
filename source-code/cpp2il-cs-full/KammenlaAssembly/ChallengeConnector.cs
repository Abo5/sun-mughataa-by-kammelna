using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public abstract class ChallengeConnector : MonoBehaviour
{
	public ChallengeEventsChannel _events;

	public abstract void SendChallengeInvite(int userId, FriendlyChallengeRoomConfig conf);

	public abstract void SendChallengeAccept(int challengerId);

	public abstract void SendChallengeDecline(int challengerId);

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012e: Expected I, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0050: Expected I, but got O
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a2: Expected I, but got O
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00f4: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Il2CppClass<ChallengeConnector>)+1C0]");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)0);
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2056;
		_events.OnInviteError += (Action<FriendlyChallengeInviteError>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5 (Il2CppClass<ChallengeConnector>)+1D0]");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)0);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		_events.OnResponseError += (Action<FriendlyChallengeResponseError>)(object)action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v6 (Il2CppClass<ChallengeConnector>)+1E0]");
		Action<bool> action3 = default(Action<bool>);
		action3..ctor((object)this, (IntPtr)0);
		object obj4 = typeof(SqlSingle[]) + 2376;
		_events.OnChallengeCancelled += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7 (Il2CppClass<ChallengeConnector>)+1F0]");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)0);
		_events.OnChallengeWithdrawn += action4;
	}

	public abstract void GetUsersFriendlyChallenges(long userId);

	protected abstract void InviteFailed(FriendlyChallengeInviteError error);

	protected abstract void ResponseFailed(FriendlyChallengeResponseError error);

	protected abstract void ChallengeCancelled(bool isCancelledByCreator);

	protected abstract void ChallengeWithdrawn();
}
