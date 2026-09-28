using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public abstract class TournamentViewConnector : MonoBehaviour
{
	public static TournamentViewConnector Instance;

	public readonly OneShotEvent ReadyState;

	private Room Room
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EEC]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
			IL_00b8:
			return sessionModel.CurrentRoom;
			IL_015d:
			return (Room)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_000b: Expected I, but got O
		//IL_001b: Expected O, but got I
		//IL_002b: Expected O, but got I
		Init();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<TournamentViewConnector>)+1B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<TournamentViewConnector>)+1C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnDestroy()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<TournamentViewConnector>)+1C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<TournamentViewConnector>)+1D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public abstract void Init();

	public abstract TournamentData GetTournamentData();

	public abstract List<MatchData> GetMatches();

	public abstract void OnJoinRoom(TournamentData data);

	protected virtual void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_0046: Expected I, but got O
		object obj = typeof(Queue<string>) + 840;
		object obj2 = (nint)0 + (nint)2184;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5 (Il2CppClass<TournamentViewConnector>)+1D0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		ScreenManager screenManager = default(ScreenManager);
		screenManager.OnDisableSceneRequested += action;
	}

	protected virtual void UnregisterEvents()
	{
	}

	public abstract void CheckParticipationStatus(Action<int> callback);

	public void ClickMatch(MatchData m)
	{
		SFS.WatchTournamentMatch(m.<ID>k__BackingField);
	}

	public abstract void ForceStart(Action<bool> callback);

	public abstract void BanPlayer(int dbId);

	protected TournamentViewConnector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj2 = this + 32;
		obj2 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
