using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;

[Serializable]
public class RankedOverallLeaderboardSource : JsonLeaderboardSource
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Comparison<LeaderBoardPlayer> <>9__9_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe int <Load>b__9_1(LeaderBoardPlayer p1, LeaderBoardPlayer p2)
		{
			//IL_0071: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected I4, but got Unknown
			if (p2 != null && p1 != null)
			{
				int num = p2 + 56;
				return ((int*)num)->CompareTo(p1.Points);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass10_0
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62B2]");
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
				leaderBoardPlayer.LastRank = <ranking>k__BackingField.<overallRank>k__BackingField;
				leaderBoardPlayer.IsOverall = true;
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

	private sealed class <>c__DisplayClass9_0
	{
		public Action<LeaderboardModel> successCallback;

		internal void <Load>b__0(LeaderboardModel model)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0123: Expected O, but got I
			//IL_0133: Expected O, but got I
			//IL_0155: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_0079: Expected O, but got I
			//IL_0089: Expected O, but got I
			//IL_0186: Expected O, but got I4
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Expected O, but got Unknown
			//IL_02d9: Expected O, but got I
			//IL_02ea: Expected I, but got O
			//IL_0308: Expected O, but got I
			//IL_01b6: Expected O, but got I
			//IL_0212: Expected O, but got I4
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected I4, but got Unknown
			//IL_0285: Expected O, but got I4
			Comparison<object> comparison;
			List<object> <PlayersList>k__BackingField;
			if (model.<PlayersList>k__BackingField != null)
			{
				object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4072;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v13+E4]");
				object obj3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v13+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
					comparison = (Comparison<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
					if ((nint)0 != 0)
					{
						goto IL_00af;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v13+B8]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
					comparison = (Comparison<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 != null)
					{
						goto IL_00af;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+B8]");
					obj3 = 0;
				}
				object obj7 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3392;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)3136;
				Comparison<object> comparison2 = default(Comparison<object>);
				comparison2..ctor(obj3, (IntPtr)obj8);
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v18+B8]");
				object obj10 = (nint)0 + (nint)8;
				obj10 = comparison2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				((List<object>)(object)model.<PlayersList>k__BackingField).Sort(comparison2);
				<PlayersList>k__BackingField = (List<object>)(object)model.<PlayersList>k__BackingField;
				goto IL_01df;
			}
			goto IL_029e;
			IL_029e:
			Actions.SafeInvoke((Action<object>)successCallback, model);
			return;
			IL_01df:
			int num = 0;
			while (num < <PlayersList>k__BackingField._size)
			{
				object obj11 = <PlayersList>k__BackingField.get_Item(num);
				object obj12 = num + 1;
				int num2 = obj12 - 1;
				object obj13 = ((List<object>)(object)model.<PlayersList>k__BackingField).get_Item(num2);
				_ = 1;
				<PlayersList>k__BackingField = (List<object>)(object)model.<PlayersList>k__BackingField;
				num = num2 + 1;
				bool flag3 = model.<PlayersList>k__BackingField == null;
				object obj14 = !flag3;
				if (obj14 != null)
				{
					continue;
				}
				goto IL_0293;
			}
			goto IL_029e;
			IL_00af:
			((List<object>)(object)model.<PlayersList>k__BackingField).Sort(comparison);
			bool flag4 = model.<PlayersList>k__BackingField == null;
			object obj15 = !flag4;
			<PlayersList>k__BackingField = (List<object>)(object)model.<PlayersList>k__BackingField;
			if (obj15 != null)
			{
				goto IL_01df;
			}
			goto IL_0293;
			IL_0293:
			throw new NullReferenceException();
		}
	}

	public override string Name => "October" + 1536;

	public override string Title => "Picking audio files is not supported on iOS" + 3904;

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
		object format = "java.io.FileOutputStream" + 2008;
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

	public override void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
		object obj4 = (nint)0 + (nint)3152;
		object obj5 = obj2 + 16;
		obj5 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		base.Load(lifecycle, (Action<LeaderboardModel>)action, useCacheCallback, onError);
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
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 4080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj4 = (nint)0 + (nint)3144;
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
