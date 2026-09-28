using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;

[Serializable]
public class PredictionsCurrentLeaderboardSource : JsonLeaderboardSource
{
	private sealed class <>c__DisplayClass9_0
	{
		public Action<LeaderBoardPlayer> callback;

		internal void <GetMyRanking>b__0(KammelnaResponseModel<SeasonalPredictionRanking> response)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62A6]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
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
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				SeasonalPredictionRanking <Model>k__BackingField = response.<Model>k__BackingField;
				leaderBoardPlayer.LastPoints = <Model>k__BackingField.points;
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

	public override string Name => "Picking audio files is not supported on iOS" + 1288;

	public override string Title => "Picking audio files is not supported on iOS" + 1240;

	public override bool IsLive => false;

	public override bool IsGameDependent => false;

	protected override string GetWebPath()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return "java.io.FileOutputStream" + 1984;
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
		//IL_0079: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 616;
		object obj4 = (nint)0 + (nint)1744;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetMyPredictionRanking(action);
	}
}
