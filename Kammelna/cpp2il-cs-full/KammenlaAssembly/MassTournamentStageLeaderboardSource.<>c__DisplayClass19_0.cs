using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using Util;

public class MassTournamentStageLeaderboardSource : SfsLeaderboardSource
{
	private sealed class <>c__DisplayClass19_0
	{
		public LeaderBoardPlayer player;

		public Action<LeaderBoardPlayer> callback;

		internal void <GetMyRanking>b__0(ISFSObject result)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			object varName = "java.io.FileOutputStream" + 3424;
			LeaderBoardPlayer leaderBoardPlayer = player;
			int lastPoints = SFSExtensions.Get(result, (string)varName, 0);
			object varName2 = "java.io.FileOutputStream" + 3440;
			leaderBoardPlayer.LastPoints = lastPoints;
			LeaderBoardPlayer leaderBoardPlayer2 = player;
			int lastRank = SFSExtensions.Get(result, (string)varName2, 0);
			object varName3 = "startPosition" + 2416;
			leaderBoardPlayer2.LastRank = lastRank;
			LeaderBoardPlayer leaderBoardPlayer3 = player;
			int rankTier = SFSExtensions.Get(result, (string)varName3, 0);
			leaderBoardPlayer3.RankTier = rankTier;
			Actions.SafeInvoke((Action<object>)callback, player);
		}
	}

	private readonly MassTournamentServerConnector _connector;

	private readonly int _stageId;

	private readonly ISFSObject <ExtraParams>k__BackingField;

	public override string Name
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0024: Expected O, but got I4
			object format = "LAK" + 3928;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			return string.Format((string)format, arg);
		}
	}

	public override string Title => "ThisIsFakeReceiptData" + 1456;

	public override bool IsLive => true;

	public override bool IsGameDependent => true;

	protected override bool IsRoomLevel => true;

	protected override string SfsCommand => "m_StencilDeferredPS" + 2088;

	protected override ISFSObject ExtraParams => <ExtraParams>k__BackingField;

	public MassTournamentStageLeaderboardSource(MassTournamentServerConnector connector, int stageId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object key = "startPosition" + 328;
		((BaseLeaderboardSource)this)..ctor();
		object obj = this + 16;
		obj = connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_stageId = stageId;
		ISFSObject iSFSObject = SfsObjectUtil.FromOneValue((string)key, stageId);
		object obj2 = this + 32;
		obj2 = iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override string GetCacheFilePath()
	{
		return null;
	}

	public override void GetMyRanking(Action<LeaderBoardPlayer> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0158: Expected O, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01aa: Expected I, but got O
		//IL_01d4: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 24;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		object key = "startPosition" + 328;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LeaderBoardPlayer leaderBoardPlayer = default(LeaderBoardPlayer);
		leaderBoardPlayer..ctor(localUser);
		object obj9 = obj2 + 16;
		obj9 = leaderBoardPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, _stageId);
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj11 = (nint)0 + (nint)1024;
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2480;
		GameObject gameObject = _connector.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(gameObject, (string)command, param, keepListening: false, action);
	}
}
