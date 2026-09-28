using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class TournamentRequests : MonoBehaviour
{
	[Serializable]
	public struct QueuePlayer
	{
		public string dbId;

		public int seat;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Room> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <PrintTournamentRooms>b__6_0(Room r)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0035: Expected I, but got O
			//IL_0045: Expected O, but got I
			//IL_00db: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_015d: Expected O, but got I
			//IL_0191: Expected O, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			object obj = typeof(RegisteredWaitHandle) + 1376;
			object obj2 = typeof(DataRelation) + 856;
			nint num = (nint)r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00c1;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v12+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v12] (should have been resolved before IL gen)");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			object obj11 = default(object);
			object message = obj11;
			if (obj10 != null)
			{
				goto IL_011a;
			}
			goto IL_01a7;
			IL_011a:
			Debug.Log(obj11);
			return;
			IL_00c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v9+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X0_v9] (should have been resolved before IL gen)");
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			message = obj11;
			if (!flag2)
			{
				goto IL_011a;
			}
			goto IL_01a7;
			IL_01a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
		}
	}

	public void JoinTournamentRoom(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentData tournamentData = default(TournamentData);
		tournamentData..ctor(roomId);
		SFS.JoinTournamentRoom(tournamentData);
	}

	public void StartTournament()
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
		object val = "rightCtrl" + 768;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void RunTournament()
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
		object val = "placementId" + 2064;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void PauseTournament()
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
		object val = "not" + 2920;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void JoinTournament()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "java.io.FileOutputStream" + 440;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public void LeaveTournament()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "java.io.FileOutputStream" + 3512;
		SFS.SendRoomExtensionRequest((string)command);
	}

	public void PrintTournamentRooms()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_018c: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_027b: Expected O, but got I
		//IL_028c: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_023e: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3896;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71DF]");
		object obj3 = (nint)0 & (nint)1;
		IEnumerable<Room> enumerable;
		IEnumerable<Room> enumerable2;
		object obj4;
		if (obj3 != null)
		{
			IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			enumerable = tournamentRooms;
			object obj5 = obj4;
			enumerable2 = tournamentRooms;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			IEnumerable<Room> tournamentRooms2 = SFS.TournamentRooms;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			enumerable = tournamentRooms2;
			object obj5 = obj4;
			enumerable2 = tournamentRooms2;
			if (obj6 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		enumerable = enumerable2;
		if (obj9 == null)
		{
			goto IL_01ec;
		}
		goto IL_0243;
		IL_01ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)352;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		obj10 = obj7;
		enumerable = enumerable2;
		goto IL_0243;
		IL_0243:
		ArraysExtensions.ForEach(enumerable, action);
		return;
		IL_009e:
		obj10 = (nint)0 + (nint)2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable2 = enumerable;
			goto IL_01ec;
		}
		goto IL_0243;
	}

	public void LoadTournamentRoom(int tournamentId)
	{
		//IL_0009: Expected I8, but got I4
		SFS.SendLoadTournamentRequest(tournamentId);
	}

	public void FinishTournamentRound(int matchId, int winnerIndex, int score1, int score2)
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
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "java.io.FileOutputStream" + 3672;
		object key2 = "utf-32" + 1096;
		object key3 = "rightCtrl" + 800;
		object key4 = "rightCtrl" + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, matchId);
		SFSExtensions.Put(sFSObject, (string)key2, winnerIndex);
		SFSExtensions.Put(sFSObject, (string)key3, score1);
		SFSExtensions.Put(sFSObject, (string)key4, score2);
		object command = "startPosition" + 2624;
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	public void RestQueue()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		object key = "clear_mass_tournaments" + 264;
		object value = "placementId" + 3520;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, (string)value);
		SFS.SendRoomExtensionRequest((string)command, param);
	}

	public void FillQueue()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		object key = "clear_mass_tournaments" + 264;
		object value = "fetch_products" + 208;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 832;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, (string)value);
		SFS.SendRoomExtensionRequest((string)command, param);
	}
}
