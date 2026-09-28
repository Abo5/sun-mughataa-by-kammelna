using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;

[Serializable]
public class RankedMonthlyLeaderboardSource : JsonLeaderboardSource
{
	private sealed class <>c__DisplayClass9_0
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62AB]");
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
			PlayerRankingModel <ranking>k__BackingField = profile.<ranking>k__BackingField;
			if (profile.<ranking>k__BackingField != null)
			{
				leaderBoardPlayer.LastPoints = <ranking>k__BackingField.<lastMonthPoints>k__BackingField;
				leaderBoardPlayer.SecondLastRank = <ranking>k__BackingField.<secondLastMonthRank>k__BackingField;
				leaderBoardPlayer.IsOverall = false;
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

	public override string Name => "Material with texture name \"" + 2496;

	public override string Title => "Material with texture name \"" + 2480;

	public override bool IsLive => false;

	public override bool IsGameDependent => true;

	protected override string GetWebPath()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object format = "java.io.FileOutputStream" + 1992;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	public override void GetMyRanking(Action<LeaderBoardPlayer> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_00b7: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj4 = (nint)0 + (nint)3128;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestMyProfile(action);
	}
}
