using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Util;

public static class TournamentParticipationUtil
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<OnlyForSubscribersReq> <>9__14_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ProcessParticipateError>b__14_0(OnlyForSubscribersReq req)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0073: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
			object obj2 = typeof(MemberAchievementClanFeedData) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			OnlyForSubscribersPopup.Show(TrackingFeature.Tournament, req.featureIcon, req.featureText, null, req.featureBottomObject, friendlyName);
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public TournamentData data;

		public GameObject gameObject;

		public TournamentsEventsChannel eventsChannel;

		public string tournamentPassword;

		public List<Vector2> captchaSolution;

		public SFS.TournamentParticipateError errorCallback;

		public SFS.TournamentParticipateSuccess successCallback;

		internal void <Participate>g__ParticipationError|0(string error, int conflictId, string name, DateTime time)
		{
			ProcessParticipateError(error, conflictId, name, time, data, gameObject, eventsChannel, tournamentPassword, captchaSolution);
			SFS.TournamentParticipateError tournamentParticipateError = errorCallback;
			if (errorCallback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v39.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void <Participate>g__ProcessParticipationSuccess|1(int seat)
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			//IL_009d: Expected O, but got I
			//IL_0112: Expected O, but got I4
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01d3: Expected O, but got I4
			SFS.TournamentParticipateSuccess tournamentParticipateSuccess = successCallback;
			if (successCallback != null)
			{
				IntPtr invoke_impl = ((Delegate)tournamentParticipateSuccess).invoke_impl;
				IntPtr method_code = ((Delegate)tournamentParticipateSuccess).method_code;
				IntPtr method = ((Delegate)tournamentParticipateSuccess).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v52 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			TournamentData tournamentData;
			if (SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom))
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				Room currentRoom2 = sessionModel2.CurrentRoom;
				TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom2);
				tournamentData = data;
				if (tournamentInfo.<RoomId>k__BackingField == tournamentData.<RoomId>k__BackingField)
				{
					object obj7 = typeof(RegisteredWaitHandle) + 3136;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v19+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
					return;
				}
			}
			else
			{
				tournamentData = data;
			}
			SFS.JoinTournamentRoom(tournamentData);
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public SFS.TournamentError errorCallback;

		internal void <Forfeit>g__ParticipationError|0(string error)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ab: Expected O, but got I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_0107: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			string text = GatMessageForError(error);
			object obj2 = obj;
			SFS.TournamentError tournamentError;
			if (text != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError(text);
				tournamentError = errorCallback;
				if (errorCallback == null)
				{
					return;
				}
				goto IL_0058;
			}
			goto IL_0089;
			IL_0058:
			IntPtr invoke_impl = ((Delegate)tournamentError).invoke_impl;
			IntPtr method_code = ((Delegate)tournamentError).method_code;
			IntPtr method = ((Delegate)tournamentError).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v84 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_0089;
			IL_0089:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Index = {0} position = {1}" + 1736;
			PopupWindow.ShowError((string)message);
			tournamentError = errorCallback;
			bool flag3 = errorCallback == null;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				return;
			}
			goto IL_0058;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public GameObject gameObject;

		public TournamentsEventsChannel eventsChannel;

		public TournamentData data;

		public string tournamentPassword;

		public List<Vector2> captchaSolution;

		internal void <ProcessParticipateError>b__1()
		{
			Participate(gameObject, eventsChannel, data, tournamentPassword, captchaSolution);
		}
	}

	private const string RankTooLow = "rank_too_low";

	private const string TimeConflict = "time_conflict";

	private const string WrongPassword = "wrong_password";

	private const string NoEnoughTickets = "no_enough_tickets";

	private const string NoEnoughAces = "not_enough_aces";

	private const string OverQualified = "over_qualified";

	private const string TournamentBanned = "tournament_banned";

	private const string ForfeitNotAllowed = "forfeit_not_allowed";

	private const string RegistrationClosed = "reg_closed";

	private const string TournamentRoomNotFound = "room_not_found";

	private const string TournamentNotEnoughAces = "not_enough_aces";

	private const string NotEnoughTournamentPoints = "not_enough_points";

	public static void Participate(GameObject gameObject, TournamentsEventsChannel eventsChannel, TournamentData data, string tournamentPassword, List<Vector2> captchaSolution, SFS.TournamentParticipateSuccess successCallback = null, SFS.TournamentParticipateError errorCallback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_0148: Expected I, but got O
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0177: Expected O, but got I
		//IL_0188: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2416;
		object obj4 = obj2 + 16;
		obj4 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = eventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 40;
		obj7 = tournamentPassword;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 48;
		obj8 = captchaSolution;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2 + 56;
		obj9 = errorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj2 + 64;
		obj10 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)152;
		SFS.TournamentParticipateError tournamentParticipateError = default(SFS.TournamentParticipateError);
		tournamentParticipateError..ctor(obj2, (IntPtr)obj11);
		object obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)160;
		SFS.TournamentParticipateSuccess tournamentParticipateSuccess = default(SFS.TournamentParticipateSuccess);
		tournamentParticipateSuccess..ctor(obj2, (IntPtr)obj13);
		SFS.ParticipateTournament((GameObject)obj5, (TournamentsEventsChannel)obj6, (TournamentData)obj4, (string)obj7, (List<Vector2>)obj8, tournamentParticipateError, tournamentParticipateSuccess);
	}

	public static void Forfeit(TournamentData data, GameObject gameObject, TournamentsEventsChannel eventsChannel, SFS.TournamentParticipateSuccess successCallback = null, SFS.TournamentError errorCallback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2408;
		object obj4 = (nint)0 + (nint)168;
		object obj5 = obj2 + 16;
		obj5 = errorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentError tournamentError = default(SFS.TournamentError);
		tournamentError..ctor(obj2, (IntPtr)obj4);
		SFS.ForfeitTournament(gameObject, eventsChannel, data, tournamentError, successCallback);
	}

	private unsafe static void ProcessParticipateError(string error, int conflictId, string name, DateTime time, TournamentData data, GameObject gameObject, TournamentsEventsChannel eventsChannel, string tournamentPassword, List<Vector2> captchaSolution)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_06a6: Expected O, but got I4
		//IL_06b6: Expected O, but got I
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected O, but got Unknown
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0ad9: Expected O, but got I4
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected O, but got Unknown
		//IL_08ca: Expected O, but got I
		//IL_08db: Expected I, but got O
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected O, but got Unknown
		//IL_0a66: Expected O, but got I4
		//IL_0919: Expected O, but got I
		//IL_0919: Expected O, but got I
		//IL_0919: Expected O, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0794: Expected O, but got I4
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected O, but got Unknown
		//IL_0958: Expected O, but got I4
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected O, but got Unknown
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected O, but got Unknown
		//IL_07bd: Expected O, but got I
		//IL_0e54: Expected O, but got I
		//IL_0e64: Expected O, but got I
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Expected O, but got Unknown
		//IL_0e95: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_0d15: Expected O, but got I4
		//IL_09e0: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_0b4f: Expected O, but got I4
		//IL_099f: Expected O, but got I4
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_0846: Expected O, but got I4
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Expected O, but got Unknown
		//IL_0ecd: Expected O, but got I
		//IL_0ede: Expected I, but got O
		//IL_0efc: Expected O, but got I
		//IL_0e35: Expected I8, but got I
		//IL_09cf: Expected O, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0310: Expected O, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected O, but got Unknown
		//IL_0de9: Expected O, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_0402: Expected O, but got I4
		//IL_0410: Expected O, but got I4
		//IL_0436: Expected O, but got I4
		//IL_04bb: Expected O, but got I4
		//IL_044c: Expected I, but got O
		//IL_045c: Expected O, but got I
		//IL_047e: Expected O, but got I4
		//IL_0493: Expected O, but got I
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_0533: Expected O, but got I4
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_056a: Expected I, but got O
		//IL_057a: Expected O, but got I
		//IL_0610: Expected O, but got I
		//IL_0634: Expected O, but got I4
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected O, but got Unknown
		//IL_0c29: Expected O, but got I
		//IL_05b5: Expected O, but got I
		//IL_0cb8: Expected O, but got I4
		//IL_064b: Expected O, but got I4
		//IL_065b: Expected O, but got I
		//IL_0c64: Expected O, but got I
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected O, but got Unknown
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0bb5: Expected O, but got I
		//IL_0bd7: Expected O, but got I4
		//IL_0be7: Expected O, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected O, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected O, but got Unknown
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Expected O, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(SkeletonBinary.SkeletonInput) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		bool flag = obj4 == null;
		string text = null;
		LocalizableText localizableText;
		object obj50 = default(object);
		object obj59;
		string message;
		DateTime dateTime2 = default(DateTime);
		string text3 = default(string);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text6;
		if (!flag)
		{
			object obj5 = obj4 + 16;
			obj5 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj4 + 24;
			obj6 = eventsChannel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj4 + 32;
			obj7 = data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj4 + 40;
			obj8 = tournamentPassword;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj4 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj7 == null)
			{
				object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
				string text2 = (string)0;
				if (obj12 == null)
				{
					goto IL_06c4;
				}
				goto IL_06d3;
			}
			object obj13 = "m_StencilDeferredPS" + 3840;
			text = (string)obj13;
			if (error == (string)obj13)
			{
				object obj14 = obj7;
				bool flag3 = obj7 == null;
				text3 = null;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v49+60]");
					if ((nint)0 == 0)
					{
						object obj15 = typeof(SkeletonBinary.SkeletonInput) + 3744;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v68+E4]");
						bool flag4 = (nint)0 == 0;
						object obj17 = !flag4;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj16 = obj15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v68+B8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v56+8]");
						Action<object> action = (Action<object>)0;
						object obj19 = "Picking audio files is not supported on iOS" + 2784;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v56+8]");
						bool flag5 = (nint)0 == 0;
						object obj20 = !flag5;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v68+E4]");
							bool flag6 = (nint)0 == 0;
							object obj21 = !flag6;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj22 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v62+B8]");
								obj18 = 0;
							}
							object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2896;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj24 = (nint)0 + (nint)144;
							Action<object> action2 = default(Action<object>);
							action2..ctor(obj18, (IntPtr)obj24);
							object obj25 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v61+B8]");
							object obj26 = (nint)0 + (nint)8;
							obj26 = action2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							action = action2;
						}
						object obj27 = (nint)0 + (nint)3384;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3ABAC");
						return;
					}
					object obj28 = typeof(Queue<string>) + 848;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v80+E4]");
					bool flag7 = (nint)0 == 0;
					object obj30 = !flag7;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj31 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					bool flag8 = (object)sessionModel == null;
					text3 = null;
					if (!flag8)
					{
						User localUser = sessionModel.LocalUser;
						object obj32 = obj7;
						bool flag9 = obj7 == null;
						text3 = null;
						text = null;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v69+60]");
							TicketRecord tournamentTickets = SFSKammelnaUserExtensions.GetTournamentTickets(localUser, TournamentType.Public);
							if (tournamentTickets == null)
							{
								return;
							}
							object obj33 = (??)tournamentTickets.<NextTicketTime>k__BackingField & 1;
							if (obj33 == null)
							{
								return;
							}
							object obj34 = (nint)0 + (nint)2296;
							DateTime? dateTime = default(DateTime?);
							DateTime value = dateTime.Value;
							object obj35 = typeof(DataRelation) + 712;
							object obj36 = obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v88+E4]");
							bool flag10 = (nint)0 == 0;
							object obj37 = !flag10;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							DateTime now = DateTime.Now;
							TimeSpan timeSpan = value - now;
							object obj38 = typeof(DataRelation) + 824;
							object obj39 = obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v78+E4]");
							bool flag11 = (nint)0 == 0;
							object obj40 = !flag11;
							if (obj40 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string durationText = DateTimeUtil.GetDurationText(timeSpan);
							object obj41 = "Network Authentication Required" + 3128;
							text = (string)obj41;
							PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)obj41);
							bool flag12 = popupWindowBuilder == null;
							dateTime2 = (DateTime)0;
							text3 = null;
							if (!flag12)
							{
								object title = "Drop Menu Toggle" + 3600;
								IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)title);
								object obj42 = typeof(TypeConverter<ushort, char>) + 3400;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object[] array = default(object[]);
								bool flag13 = array == null;
								dateTime2 = (DateTime)0;
								text3 = null;
								text = (string)1;
								if (!flag13)
								{
									bool flag14 = durationText == null;
									string text4 = (string)1;
									if (!flag14)
									{
										nint num = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v103 (Il2CppClass<System.Object[]>)+40]");
										text4 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag15 = ex == null;
										dateTime2 = (DateTime)0;
										text3 = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v103 (Il2CppClass<System.Object[]>)+40]");
										text = (string)0;
										if (flag15)
										{
											goto IL_0d49;
										}
									}
									bool flag16 = array.Length == 0;
									dateTime2 = (DateTime)0;
									text3 = null;
									text = text4;
									if (flag16)
									{
										goto IL_0d3b;
									}
									object obj43 = array + 32;
									obj43 = durationText;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object text5 = "startPosition" + 4064;
									localizableText = TextMeshProExtensions.LocalizeWith((string)text5, array);
									bool flag17 = popupWindowBuilderNeedsBody == null;
									dateTime2 = (DateTime)0;
									text3 = null;
									text = (string)(object)array;
									if (!flag17)
									{
										object obj44 = typeof(System.IOAsyncCallback) + 384;
										nint num2 = (nint)popupWindowBuilderNeedsBody;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v91 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v91 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_05f6;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v91 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
										object obj46 = (nint)0 + (nint)8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v15-8]");
											if (0 == (nint)obj44)
											{
												break;
											}
											obj46 += 16;
											obj45--;
											if ((nint)obj45 != 1)
											{
												continue;
											}
											goto IL_05f6;
										}
										object obj47 = obj46 + 1;
										object obj48 = num2 + obj47;
										object obj49 = obj48 + 312;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v116+8]");
										text6 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v803 @ X0_v116] (should have been resolved before IL gen)");
										bool flag18 = obj50 == null;
										dateTime2 = (DateTime)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v116+8]");
										text3 = (string)0;
										text = (string)(object)localizableText;
										if (!flag18)
										{
											goto IL_0bfd;
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				object obj51 = "not" + 88;
				text = (string)obj51;
				if (!(error == (string)obj51))
				{
					object obj52 = "startPosition" + 3232;
					if (error == (string)obj52)
					{
						object obj53 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj54 = (nint)0 + (nint)176;
						Action action3 = default(Action);
						action3..ctor(obj4, (IntPtr)obj54);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+10]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+18]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+20]");
						TournamentPopupUtil.ShowConflictPopup((GameObject)num3, (TournamentsEventsChannel)num4, (TournamentData)0, conflictId, text3, dateTime2, action3);
						return;
					}
					object obj55 = "not" + 2824;
					if (error == (string)obj55)
					{
						object obj56 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
						object obj57 = obj56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v49+E4]");
						bool flag19 = (nint)0 == 0;
						object obj58 = !flag19;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						obj59 = "October" + 1592;
						goto IL_0f1b;
					}
					object obj60 = "tournament_participate_warning_body_with_tickets_warning_daily" + 4024;
					string text2 = (string)obj60;
					bool flag20 = error == (string)obj60;
					bool flag21 = !flag20;
					object obj61 = !flag21;
					if (obj61 != null)
					{
						return;
					}
					string text7 = GatMessageForError(error);
					object obj62 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
					object obj11 = obj62;
					if (text7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v29+E4]");
						bool flag22 = (nint)0 == 0;
						object obj63 = !flag22;
						string text8 = text7;
						if (obj63 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							text8 = text7;
						}
						message = text8;
						goto IL_0f68;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v29+E4]");
					bool flag23 = (nint)0 == 0;
					object obj64 = !flag23;
					if (obj64 == null)
					{
						text3 = null;
						goto IL_06c4;
					}
					goto IL_06d3;
				}
				object obj65 = obj7;
				bool flag24 = obj7 == null;
				text3 = null;
				if (!flag24)
				{
					object obj66 = typeof(Queue<string>) + 848;
					object obj67 = obj66;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v55+E4]");
					bool flag25 = (nint)0 == 0;
					object obj68 = !flag25;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj69 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					bool flag26 = (object)sessionModel2 == null;
					text3 = null;
					if (!flag26)
					{
						User localUser2 = sessionModel2.LocalUser;
						int aces = SFSKammelnaUserExtensions.GetAces(localUser2);
						object obj70 = typeof(MemberAchievementClanFeedData) + 2608;
						object obj71 = obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v47+E4]");
						bool flag27 = (nint)0 == 0;
						object obj72 = !flag27;
						if (obj72 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v39+94]");
						long remaining = -aces;
						NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.Tournament);
						return;
					}
				}
			}
		}
		goto IL_0d2d;
		IL_06d3:
		obj59 = "Index = {0} position = {1}" + 1736;
		goto IL_0f1b;
		IL_0f68:
		PopupWindow.ShowError(message);
		return;
		IL_0d49:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_05f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v113+8]");
		text6 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v786 @ X0_v113] (should have been resolved before IL gen)");
		bool flag28 = obj50 == null;
		object obj73 = !flag28;
		if (obj73 != null)
		{
			goto IL_0bfd;
		}
		dateTime2 = (DateTime)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v113+8]");
		text3 = (string)0;
		text = (string)(object)localizableText;
		goto IL_0d2d;
		IL_0f1b:
		message = (string)obj59;
		goto IL_0f68;
		IL_0d3b:
		ex = new IndexOutOfRangeException();
		goto IL_0d49;
		IL_0bfd:
		object obj74 = typeof(System.IOAsyncCallback) + 368;
		object obj75 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v95+12E]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v95+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ca5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v95+B0]");
		object obj77 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X10_v10-8]");
			if (0 == (nint)obj74)
			{
				break;
			}
			obj77 += 16;
			obj76--;
			if ((nint)obj76 != 1)
			{
				continue;
			}
			goto IL_0ca5;
		}
		object obj78 = obj77 + 9;
		object obj79 = obj75 + obj78;
		object obj80 = obj79 + 312;
		goto IL_0f59;
		IL_0f59:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v666 @ X8_v96] (should have been resolved before IL gen)");
		return;
		IL_0ca5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text6 = (string)9;
		object obj81 = default(object);
		obj80 = obj81;
		goto IL_0f59;
		IL_0d2d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d3b;
		IL_06c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_06d3;
	}

	private static string GatMessageForError(string error)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		object obj = "startPosition" + 3936;
		string text = default(string);
		if (text == (string)obj)
		{
			return "WhiteSmoke" + 1920;
		}
		object obj2 = "rightCtrl" + 464;
		if (text == (string)obj2)
		{
			return "tournament_participate_warning_body_with_tickets_warning_daily" + 88;
		}
		object obj3 = "not" + 112;
		bool flag = text == (string)obj3;
		object result = "not" + 128;
		bool flag2 = !flag;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
		}
		return (string)result;
	}
}
