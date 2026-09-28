using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using Util;

[Serializable]
public class TournamentCurrentMonthLeaderboardSource : SfsLeaderboardSource
{
	private sealed class <>c__DisplayClass15_0
	{
		public Action<LeaderBoardPlayer> callback;

		internal void <GetMyRanking>b__0(PlayerProfileModel profile)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62C1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_0133;
			IL_0133:
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			LeaderBoardPlayer leaderBoardPlayer = default(LeaderBoardPlayer);
			leaderBoardPlayer..ctor(localUser);
			TournamentRankingModel <tournamentRanking>k__BackingField = profile.<tournamentRanking>k__BackingField;
			if (profile.<tournamentRanking>k__BackingField != null)
			{
				leaderBoardPlayer.LastPoints = <tournamentRanking>k__BackingField.<currentMonthPoints>k__BackingField;
				leaderBoardPlayer.SecondLastRank = <tournamentRanking>k__BackingField.<lastMonthRank>k__BackingField;
				leaderBoardPlayer.RankTier = (int)<tournamentRanking>k__BackingField.<currentRankTier>k__BackingField;
			}
			Actions.SafeInvoke((Action<object>)callback, leaderBoardPlayer);
			return;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0133;
		}
	}

	private readonly ISFSObject <ExtraParams>k__BackingField;

	public override string Name => "ThisIsFakeReceiptData" + 1480;

	public override string Title => "ThisIsFakeReceiptData" + 1456;

	public override bool IsLive => true;

	public override bool IsGameDependent => true;

	protected override bool IsAvailableForCurrentGame
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			return currentGame == Games.Baloot;
		}
	}

	protected override string SfsCommand => "m_StencilDeferredPS" + 2696;

	protected override ISFSObject ExtraParams => <ExtraParams>k__BackingField;

	public override void GetMyRanking(Action<LeaderBoardPlayer> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003e: Expected I, but got O
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_0172: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_008f: Expected O, but got I
		//IL_00a0: Expected I, but got O
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		if (IsAvailableForCurrentGame)
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)3824;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestMyProfile(action);
			return;
		}
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LeaderBoardPlayer leaderBoardPlayer = default(LeaderBoardPlayer);
		leaderBoardPlayer..ctor(localUser);
		Actions.SafeInvoke((Action<object>)obj3, leaderBoardPlayer);
	}

	public TournamentCurrentMonthLeaderboardSource()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ISFSObject iSFSObject = SfsObjectUtil.FromOneValue("tournament_participate_warning_body_with_tickets_warning_daily" + 960, 0);
		object obj = this + 16;
		obj = iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((BaseLeaderboardSource)this)..ctor();
	}
}
