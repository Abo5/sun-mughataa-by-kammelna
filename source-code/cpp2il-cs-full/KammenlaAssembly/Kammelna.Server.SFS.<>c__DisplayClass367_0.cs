using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using KammelnaOffline;
using KammelnaOffline.Baloot.Tutorial;
using KammelnaOffline.OfflineServer;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using ReportEnums;
using Server.Models;
using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Managers;
using Sfs2X.Entities.Variables;
using Sfs2X.Logging;
using Sfs2X.Requests;
using Sfs2X.Util;
using UI.Popups.Chat;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using Util;

namespace Kammelna.Server;

public class SFS : Singleton<SFS>
{
	public delegate void SFSInvitationDelegate(User user, int roomId, string passWord, long tournamentId);

	private delegate void SendSfsRequestDelegate(GameObject go, string command, ISFSObject param = null, bool keepListening = false, Action<ISFSObject> callback = null);

	public delegate void TournamentParticipateError(string error, int conflictTournamentId, string conflictTournamentName, DateTime conflictTournamentTime);

	public delegate void TournamentError(string error);

	public delegate void TournamentParticipateSuccess(int seat);

	public delegate void TournamentSeatsSuccess(Dictionary<int, int> tournamentSeats);

	public delegate void MassWinnersListSuccess(List<MassEventWinner> winners);

	public delegate void MassStagesListSuccess(List<MassRuntimeStageSummery> winners);

	public delegate void CurrencyBombClaim(bool success, string errorMessage);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, bool> <>9__247_0;

		public static Func<Room, bool> <>9__249_0;

		public static Func<Room, bool> <>9__249_1;

		public static Func<Room, bool> <>9__251_0;

		public static Func<Room, bool> <>9__253_0;

		public static Func<Room, bool> <>9__253_1;

		public static Action<bool> <>9__298_0;

		public static Func<Vector2, double> <>9__358_0;

		public static Func<Vector2, double> <>9__358_1;

		public static Func<Vector2, double> <>9__367_0;

		public static Func<Vector2, double> <>9__367_1;

		public static Action <>9__382_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_Lobby>b__247_0(Room r)
		{
			return SFSKammelnaRoomExtensions.IsLobby(r);
		}

		internal bool <get_TournamentRooms>b__249_0(Room room)
		{
			//IL_02e7: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0064: Expected I, but got O
			//IL_0074: Expected O, but got I
			//IL_010a: Expected I, but got O
			//IL_00af: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_014d: Expected I, but got O
			//IL_015d: Expected O, but got I
			//IL_01fb: Expected O, but got I
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected O, but got Unknown
			//IL_0236: Expected I, but got O
			//IL_025a: Expected O, but got I4
			//IL_0198: Expected O, but got I
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Expected O, but got Unknown
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected O, but got Unknown
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02bc: Expected O, but got I
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83A8]");
			nint num = 0;
			object obj3 = default(object);
			object obj5 = default(object);
			object obj18 = default(object);
			while (true)
			{
				SmartFoxClient client = Client;
				bool flag = client == null;
				IRoomManager roomManager = (IRoomManager)152993792;
				if (flag)
				{
					break;
				}
				IRoomManager roomManager2 = client.RoomManager;
				bool flag2 = room == null;
				roomManager = (IRoomManager)152993792;
				if (flag2)
				{
					break;
				}
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num2 = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				object obj4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v12-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag3 = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag3)
					{
						continue;
					}
					goto IL_00f8;
				}
				goto IL_0205;
				IL_00f8:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ X0_v15] (should have been resolved before IL gen)");
				if (roomManager2 == null)
				{
					break;
				}
				goto IL_0131;
				IL_0131:
				object obj6 = typeof(System.IOAsyncCallback) + 936;
				num = (nint)roomManager2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v9-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj4 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_01d9;
					}
					object obj8 = obj4 + 7;
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v5+8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v153 @ X3_v1 (should have been resolved before IL gen)");
					continue;
				}
				goto IL_01d9;
				IL_0205:
				object obj13 = obj3 + 3;
				object obj14 = num2 + obj13;
				object obj15 = obj14 + 312;
				num = (nint)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X0_v18] (should have been resolved before IL gen)");
				bool flag4 = roomManager2 == null;
				object obj16 = !flag4;
				obj4 = obj3;
				if (obj16 == null)
				{
					break;
				}
				goto IL_0131;
				IL_01d9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v12+8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v172 @ X3_v2 (should have been resolved before IL gen)");
				goto IL_0205;
			}
			throw new NullReferenceException();
		}

		internal bool <get_TournamentRooms>b__249_1(Room r)
		{
			return SFSKammelnaRoomExtensions.IsTournamentHub(r);
		}

		internal bool <get_TournamentMatchesRoomsList>b__251_0(Room r)
		{
			//IL_02ac: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00db: Expected O, but got I4
			//IL_006c: Expected O, but got I
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected O, but got Unknown
			//IL_0195: Expected I, but got O
			//IL_01a5: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_01e0: Expected O, but got I
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Expected O, but got Unknown
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected O, but got Unknown
			//IL_0294: Expected O, but got I
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			object obj;
			if (r != null)
			{
				obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X10_v11-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = obj3 + 6;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ X0_v18] (should have been resolved before IL gen)");
				object obj7 = default(object);
				if (obj7 != null)
				{
					goto IL_013e;
				}
				goto IL_024d;
			}
			goto IL_029e;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ X0_v15] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_013e;
			}
			goto IL_024d;
			IL_013e:
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(r);
			if (!GameTypeExtensions.IsTournament(gameType))
			{
				goto IL_024d;
			}
			object obj10 = "not" + 4000;
			object obj11 = obj10;
			nint num2 = (nint)r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0221;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_0221;
			}
			object obj14 = obj13 + 35;
			object obj15 = num2 + obj14;
			object obj16 = obj15 + 312;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v12+8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v2 (should have been resolved before IL gen)");
			goto IL_029e;
			IL_029e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_024d:
			return false;
			IL_0221:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = default(object);
			object obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v10+8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v125 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_024d;
		}

		internal bool <get_MassTournamentRooms>b__253_0(Room room)
		{
			//IL_02e7: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0064: Expected I, but got O
			//IL_0074: Expected O, but got I
			//IL_010a: Expected I, but got O
			//IL_00af: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_014d: Expected I, but got O
			//IL_015d: Expected O, but got I
			//IL_01fb: Expected O, but got I
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected O, but got Unknown
			//IL_0236: Expected I, but got O
			//IL_025a: Expected O, but got I4
			//IL_0198: Expected O, but got I
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Expected O, but got Unknown
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected O, but got Unknown
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02bc: Expected O, but got I
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83AA]");
			nint num = 0;
			object obj3 = default(object);
			object obj5 = default(object);
			object obj18 = default(object);
			while (true)
			{
				SmartFoxClient client = Client;
				bool flag = client == null;
				IRoomManager roomManager = (IRoomManager)152993792;
				if (flag)
				{
					break;
				}
				IRoomManager roomManager2 = client.RoomManager;
				bool flag2 = room == null;
				roomManager = (IRoomManager)152993792;
				if (flag2)
				{
					break;
				}
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num2 = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				object obj4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v12-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag3 = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag3)
					{
						continue;
					}
					goto IL_00f8;
				}
				goto IL_0205;
				IL_00f8:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ X0_v15] (should have been resolved before IL gen)");
				if (roomManager2 == null)
				{
					break;
				}
				goto IL_0131;
				IL_0131:
				object obj6 = typeof(System.IOAsyncCallback) + 936;
				num = (nint)roomManager2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v9-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj4 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_01d9;
					}
					object obj8 = obj4 + 7;
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v5+8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v153 @ X3_v1 (should have been resolved before IL gen)");
					continue;
				}
				goto IL_01d9;
				IL_0205:
				object obj13 = obj3 + 3;
				object obj14 = num2 + obj13;
				object obj15 = obj14 + 312;
				num = (nint)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X0_v18] (should have been resolved before IL gen)");
				bool flag4 = roomManager2 == null;
				object obj16 = !flag4;
				obj4 = obj3;
				if (obj16 == null)
				{
					break;
				}
				goto IL_0131;
				IL_01d9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v12+8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v172 @ X3_v2 (should have been resolved before IL gen)");
				goto IL_0205;
			}
			throw new NullReferenceException();
		}

		internal bool <get_MassTournamentRooms>b__253_1(Room r)
		{
			return SFSKammelnaRoomExtensions.IsMassTournament(r);
		}

		internal void <SFS_OnExtensionResponse>b__298_0(bool result)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_018a: Expected O, but got I
			//IL_01a4: Expected O, but got I4
			//IL_00bd: Expected O, but got I
			//IL_01e2: Expected O, but got I4
			//IL_011f: Expected O, but got I
			//IL_012f: Expected O, but got I
			//IL_013f: Expected O, but got I
			//IL_014f: Expected O, but got I
			//IL_015f: Expected O, but got I
			if (!result)
			{
				return;
			}
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7+28]");
			if ((nint)0 == 0)
			{
				return;
			}
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
				object obj7 = (nint)0 & (nint)1;
				if (obj7 != null)
				{
					goto IL_00da;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
				object obj8 = (nint)0 & (nint)1;
				bool flag = obj8 == null;
				object obj9 = !flag;
				if (obj9 != null)
				{
					goto IL_00da;
				}
			}
			_ = 1;
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			object obj12 = obj10;
			if (obj11 != null)
			{
				goto IL_010f;
			}
			goto IL_01f8;
			IL_01f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj5;
			goto IL_010f;
			IL_00da:
			obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			obj12 = obj10;
			if (!flag3)
			{
				goto IL_010f;
			}
			goto IL_01f8;
			IL_010f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v15+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X19_v4+18]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X19_v4+40]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X19_v4+28]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X3_v1 (should have been resolved before IL gen)");
		}

		internal double <ParticipateTournament>b__358_0(Vector2 v)
		{
			double result = default(double);
			return result;
		}

		internal double <ParticipateTournament>b__358_1(Vector2 v)
		{
			double result = default(double);
			return result;
		}

		internal double <SendClaimCurrencyBomb>b__367_0(Vector2 v)
		{
			double result = default(double);
			return result;
		}

		internal double <SendClaimCurrencyBomb>b__367_1(Vector2 v)
		{
			double result = default(double);
			return result;
		}

		internal void <SetupSubscriptionExpiryCallback>b__382_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00af: Expected O, but got I4
			object obj = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83AC]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UserInfo.WasSubscribedLastSession = false;
			return;
			IL_0074:
			UserInfo.WasSubscribedLastSession = false;
		}
	}

	private sealed class <>c__DisplayClass254_0
	{
		public string clanGroupTag;

		internal bool <ClanGameRooms>b__0(Room r)
		{
			//IL_0235: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00f2: Expected I, but got O
			//IL_0102: Expected O, but got I
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_013d: Expected O, but got I
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected O, but got Unknown
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_0214: Expected O, but got I4
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			object obj;
			if (r != null)
			{
				obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v12-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = obj3 + 3;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0276;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0276;
			IL_01ab:
			bool flag = SFSKammelnaRoomExtensions.IsTournamentHub(r);
			bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			goto IL_02ac;
			IL_0276:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v3] (should have been resolved before IL gen)");
			string text = default(string);
			flag2 = text == clanGroupTag;
			if (flag2)
			{
				nint num2 = (nint)r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_017e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj8 += 16;
					obj7--;
					if ((nint)obj7 != 1)
					{
						continue;
					}
					goto IL_017e;
				}
				object obj9 = obj8 + 6;
				object obj10 = num2 + obj9;
				object obj11 = obj10 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X0_v16] (should have been resolved before IL gen)");
				bool flag3 = !flag2;
				object obj12 = !flag3;
				if (obj12 != null)
				{
					goto IL_01ab;
				}
			}
			goto IL_02ac;
			IL_02ac:
			return flag2;
			IL_017e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ X0_v13] (should have been resolved before IL gen)");
			if (flag2)
			{
				goto IL_01ab;
			}
			goto IL_02ac;
		}
	}

	private sealed class <>c__DisplayClass294_0
	{
		public SFS <>4__this;

		public bool shouldRelogin;

		internal void <SFS_OnConnectionLost>b__0()
		{
			<>4__this.CreateNewClient();
			if (shouldRelogin)
			{
				Relogin();
			}
		}
	}

	private sealed class <>c__DisplayClass329_0<T> where T : GameRoomData
	{
		public Action<List<T>, string> callback;

		internal unsafe void <LoadRoomsList>b__0(ISFSObject data)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_0200: Expected O, but got Ref
			//IL_007b: Expected O, but got I
			//IL_00f5: Expected I, but got O
			//IL_0105: Expected O, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01dd: Expected O, but got I4
			//IL_0335: Expected O, but got I
			//IL_034b: Expected O, but got I
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			//IL_0373: Expected O, but got I4
			//IL_0140: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected O, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected O, but got Unknown
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected O, but got Unknown
			//IL_02a3: Expected O, but got I
			//IL_02b3: Expected O, but got I
			//IL_02c3: Expected O, but got I
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "rightCtrl" + 200;
			nint num = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			goto IL_02cd;
			IL_00ed:
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0181;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_0181;
			}
			object obj7 = obj6 + 28;
			object obj8 = num2 + obj7;
			object obj9 = obj8 + 312;
			goto IL_0315;
			IL_02cd:
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X10_v13-8]");
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
				goto IL_00bc;
			}
			object obj10 = obj4 + 1;
			object obj11 = num + obj10;
			object obj12 = obj11 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ X0_v27] (should have been resolved before IL gen)");
			object obj13 = default(object);
			bool flag = obj13 == null;
			object obj14 = !flag;
			if (obj14 != null)
			{
				goto IL_00ed;
			}
			goto IL_01eb;
			IL_0315:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v359 @ X0_v10] (should have been resolved before IL gen)");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16 (Il2CppRgctx<Kammelna.Server.SFS+<>c__DisplayClass329_0`1>)+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16 (Il2CppRgctx<Kammelna.Server.SFS+<>c__DisplayClass329_0`1>)+8]");
			object obj16 = (nint)0 + (nint)309;
			object obj17 = obj16 & 1;
			bool flag2 = obj17 == null;
			object obj18 = !flag2;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint method = 0;
			Func<object, object> func = default(Func<object, object>);
			func..ctor((object)null, (IntPtr)method);
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
			Action<List<T>, string> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v23 (System.Action`2<System.Collections.Generic.List`1<T>, System.String>)+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v23 (System.Action`2<System.Collections.Generic.List`1<T>, System.String>)+40]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v23 (System.Action`2<System.Collections.Generic.List`1<T>, System.String>)+28]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v205 @ X4_v1 (should have been resolved before IL gen)");
			goto IL_02cd;
			IL_0181:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0315;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X0_v24] (should have been resolved before IL gen)");
			object obj22 = default(object);
			if (obj22 != null)
			{
				goto IL_00ed;
			}
			goto IL_01eb;
			IL_01eb:
			Action<List<T>, string> action2 = callback;
			object obj23 = default(object);
			string text = ((Enum)(&obj23)).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ X19_v3 (System.Action`2<System.Collections.Generic.List`1<T>, System.String>)+18] (should have been resolved before IL gen)");
		}
	}

	private sealed class <>c__DisplayClass344_0
	{
		public Action<string> onError;

		public Action useCacheCallback;

		public Action<UsersListModel> successCallback;

		internal void <GetOnlineUsersList>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_007b: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_0171: Expected O, but got I4
			//IL_0216: Expected O, but got I
			//IL_0226: Expected O, but got I
			//IL_0236: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X0_v18] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_017f;
			IL_00ed:
			object defaultValue = (nint)0 + (nint)2000;
			string arg = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			Actions.SafeInvoke((Action<object>)onError, arg);
			return;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X0_v15] (should have been resolved before IL gen)");
			object obj9 = default(object);
			if (obj9 != null)
			{
				goto IL_00ed;
			}
			goto IL_017f;
			IL_017f:
			object varName2 = "setMimeType" + 3816;
			int num2 = SFSExtensions.Get(response, (string)varName2, 0);
			if (num2 == 304)
			{
				Actions.SafeInvoke(useCacheCallback);
				return;
			}
			Action<UsersListModel> action = successCallback;
			if (successCallback != null)
			{
				UsersListModel usersListModel = UsersListModel.FromSfsObject(response);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v2 (System.Action`1<UsersListModel>)+18]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v2 (System.Action`1<UsersListModel>)+40]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v2 (System.Action`1<UsersListModel>)+28]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v142 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass346_0
	{
		public int userDbId;

		internal bool <CheckIsOnline>b__0(FriendProfile f)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (f != null)
			{
				object obj = f.UserID - userDbId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass358_0
	{
		public TournamentParticipateError onError;

		public TournamentsEventsChannel eventsChannel;

		public TournamentParticipateSuccess onSuccess;

		public int joinCost;

		public TicketRecord ticketRecord;

		public TournamentData data;

		internal unsafe void <ParticipateTournament>b__2(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_023e: Expected I, but got O
			//IL_024e: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected O, but got Unknown
			//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Expected O, but got Unknown
			//IL_0612: Expected I4, but got I8
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_062a: Expected O, but got Unknown
			//IL_0654: Expected O, but got I4
			//IL_0289: Expected O, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			//IL_016b: Expected O, but got I4
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			//IL_0219: Expected O, but got I4
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Expected O, but got Unknown
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected O, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Expected O, but got Unknown
			//IL_0369: Expected O, but got I
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Expected O, but got Unknown
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected O, but got Unknown
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected O, but got Unknown
			//IL_054c: Expected O, but got I4
			//IL_0574: Expected O, but got Ref
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Expected O, but got Unknown
			//IL_03d1: Expected O, but got I
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Expected I4, but got Unknown
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Expected O, but got Unknown
			//IL_0480: Expected O, but got I4
			//IL_04d7: Expected F8, but got I4
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v14-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X0_v61] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_0227;
			IL_0227:
			object obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 568;
			nint num2 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ca;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_02ca;
			}
			object obj12 = obj11 + 14;
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			goto IL_05e3;
			IL_05e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v441 @ X0_v5] (should have been resolved before IL gen)");
			object varName2 = "setMimeType" + 3176;
			int seat = SFSExtensions.Get(response, (string)varName2, -1);
			object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj17 = !flag2;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int roomId = default(int);
			SfsTournamentConnector.SetSeat(roomId, seat, eventsChannel);
			TournamentParticipateSuccess tournamentParticipateSuccess = onSuccess;
			bool flag3 = onSuccess == null;
			TournamentsEventsChannel tournamentsEventsChannel = eventsChannel;
			if (!flag3)
			{
				tournamentsEventsChannel = (TournamentsEventsChannel)(nint)((Delegate)tournamentParticipateSuccess).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v491.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			bool flag4 = joinCost < 1;
			ResourceCurrency resourceCurrency = ResourceCurrency.None;
			string text = (string)(object)tournamentsEventsChannel;
			if (!flag4)
			{
				TicketRecord ticketRecord = this.ticketRecord;
				bool flag5 = this.ticketRecord == null;
				int num3 = 0;
				if (!flag5)
				{
					int <RemainingCount>k__BackingField = ticketRecord.<RemainingCount>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v35 (System.Int32)+18]");
					object obj18 = -ticketRecord.<RemainingCount>k__BackingField;
					int num4 = obj18 + 1;
					num3 = num4;
				}
				TournamentLists.OfficialTournamentSubWallData offiTourSubWallData = TournamentLists.OffiTourSubWallData;
				TournamentLists.OfficialTournamentSubWallData officialTournamentSubWallData = offiTourSubWallData.<Clone>$();
				TournamentLists.OfficialTournamentSubWallData offiTourSubWallData2 = TournamentLists.OffiTourSubWallData;
				int <NonSubBuys>k__BackingField = offiTourSubWallData2.<NonSubBuys>k__BackingField + 1;
				officialTournamentSubWallData.<NonSubBuys>k__BackingField = <NonSubBuys>k__BackingField;
				TournamentLists.OffiTourSubWallData = officialTournamentSubWallData;
				string name = num3.ToString();
				object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v32+E4]");
				bool flag6 = (nint)0 == 0;
				object obj21 = !flag6;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text2 = Tracker.BuildItemId(ResourceItemId.TournamentJoin, name);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, text2, joinCost, ResourceCurrency.Aces);
				resourceCurrency = ResourceCurrency.Aces;
				text = text2;
			}
			TournamentData tournamentData = data;
			ITrackEvent trackEvent = TrackerLibrary.TournamentJoined(tournamentData.<Type>k__BackingField);
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v22+E4]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			DateTime? defaultValue = default(DateTime?);
			string type = ((Enum)(&defaultValue)).ToString();
			object action = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3136;
			FirebaseTrack.Event((string)action, type);
			return;
			IL_02ca:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_05e3;
			IL_00ed:
			object defaultValue2 = (nint)0 + (nint)2000;
			string text3 = SFSExtensions.Get(response, (string)varName, (string)defaultValue2);
			object varName3 = "https://www.kammelna.com/Home/Terms" + 328;
			int num5 = SFSExtensions.Get(response, (string)varName3, 0);
			object varName4 = "startPosition" + 2392;
			string text4 = SFSExtensions.Get(response, (string)varName4, (string)defaultValue2);
			defaultValue = (DateTime)0;
			object varName5 = "startPosition" + 2400;
			DateTime? dateTime = SFSExtensions.Get(response, (string)varName5, defaultValue);
			TournamentParticipateError tournamentParticipateError = onError;
			if (onError != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v277.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v58] (should have been resolved before IL gen)");
			object obj25 = default(object);
			if (obj25 != null)
			{
				goto IL_00ed;
			}
			goto IL_0227;
		}
	}

	private sealed class <>c__DisplayClass359_0
	{
		public TournamentError onError;

		public TournamentsEventsChannel eventsChannel;

		public TournamentParticipateSuccess onSuccess;

		internal void <ForfeitTournament>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_01da: Expected I, but got O
			//IL_01ea: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0381: Expected O, but got Unknown
			//IL_0397: Expected I4, but got I8
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_03d9: Expected O, but got I4
			//IL_0225: Expected O, but got I
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01b5: Expected O, but got I4
			//IL_0122: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v13-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			goto IL_0168;
			IL_0168:
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ X0_v26] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
			IL_01c3:
			object obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 568;
			nint num2 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0266;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_0266;
			}
			object obj12 = obj11 + 14;
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			goto IL_0368;
			IL_0266:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0368;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X0_v23] (should have been resolved before IL gen)");
			object obj15 = default(object);
			if (obj15 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
			IL_00ed:
			TournamentError tournamentError = onError;
			if (onError != null)
			{
				object defaultValue = (nint)0 + (nint)2000;
				string text = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
				IntPtr invoke_impl = ((Delegate)tournamentError).invoke_impl;
				IntPtr method_code = ((Delegate)tournamentError).method_code;
				IntPtr method = ((Delegate)tournamentError).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X3_v6 (System.IntPtr) (should have been resolved before IL gen)");
				goto IL_0168;
			}
			return;
			IL_0368:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X0_v5] (should have been resolved before IL gen)");
			object varName2 = "setMimeType" + 3176;
			int seat = SFSExtensions.Get(response, (string)varName2, -1);
			object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj18 = !flag2;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int roomId = default(int);
			SfsTournamentConnector.SetSeat(roomId, seat, eventsChannel);
			TournamentParticipateSuccess tournamentParticipateSuccess = onSuccess;
			if (onSuccess != null)
			{
				IntPtr invoke_impl2 = ((Delegate)tournamentParticipateSuccess).invoke_impl;
				IntPtr method_code2 = ((Delegate)tournamentParticipateSuccess).method_code;
				IntPtr method2 = ((Delegate)tournamentParticipateSuccess).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v149 @ X3_v4 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass360_0
	{
		public TournamentSeatsSuccess onSuccess;

		internal void <GetMyTournaments>b__0(ISFSObject response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0045: Expected I, but got O
			//IL_0055: Expected O, but got I
			//IL_0117: Expected O, but got I4
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected O, but got Unknown
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected O, but got Unknown
			//IL_01d6: Expected O, but got I
			//IL_01f6: Expected O, but got I
			//IL_0216: Expected O, but got I4
			//IL_022f: Expected O, but got I4
			//IL_0090: Expected O, but got I
			//IL_036b: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_041d: Expected O, but got I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_048c: Expected I, but got O
			//IL_049c: Expected O, but got I
			//IL_03a6: Expected O, but got I
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Expected O, but got Unknown
			//IL_030d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Expected O, but got Unknown
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Expected O, but got Unknown
			//IL_072c: Expected I4, but got I8
			//IL_04d7: Expected O, but got I
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Expected O, but got Unknown
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Expected O, but got Unknown
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Expected O, but got Unknown
			//IL_05a4: Expected O, but got I
			//IL_05c6: Expected O, but got I4
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Expected O, but got Unknown
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Expected O, but got Unknown
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053d: Expected O, but got Unknown
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Expected O, but got Unknown
			//IL_0553: Unknown result type (might be due to invalid IL or missing references)
			//IL_0558: Expected O, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected O, but got Unknown
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected O, but got Unknown
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<int, int> dictionary = default(Dictionary<int, int>);
			dictionary..ctor();
			object obj2 = typeof(System.IOAsyncCallback) + 976;
			object obj3 = "getSecondRescanTask" + 1712;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			object obj6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X10_v26-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj6 = obj5 + 16;
				obj4--;
				bool flag = (nint)obj4 != 1;
				obj5 = obj6;
				if (flag)
				{
					continue;
				}
				goto IL_00d9;
			}
			object obj7 = obj5 + 28;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v40+8]");
			int num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X0_v40] (should have been resolved before IL gen)");
			<>c__DisplayClass360_0 <>c__DisplayClass360_ = this;
			obj6 = obj5;
			goto IL_0184;
			IL_0353:
			object obj11 = default(object);
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v13+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v13+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03ef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v13+B0]");
			object obj13 = (nint)0 + (nint)8;
			object obj14;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v15-8]");
				if (0 == (nint)obj14)
				{
					break;
				}
				obj6 = obj13 + 16;
				obj12--;
				bool flag2 = (nint)obj12 != 1;
				obj13 = obj6;
				if (flag2)
				{
					continue;
				}
				goto IL_03ef;
			}
			object obj15 = obj13 + 51;
			object obj16 = obj10 + obj15;
			object obj17 = obj16 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v559 @ X0_v24] (should have been resolved before IL gen)");
			obj6 = obj13;
			goto IL_0470;
			IL_03ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v542 @ X0_v21] (should have been resolved before IL gen)");
			ISFSObject iSFSObject = default(ISFSObject);
			bool flag3 = iSFSObject == null;
			object obj18 = !flag3;
			if (obj18 != null)
			{
				goto IL_0470;
			}
			goto IL_065a;
			IL_05f9:
			TournamentSeatsSuccess tournamentSeatsSuccess = <>c__DisplayClass360_.onSuccess;
			if (<>c__DisplayClass360_.onSuccess != null)
			{
				IntPtr invoke_impl = ((Delegate)tournamentSeatsSuccess).invoke_impl;
				IntPtr method_code = ((Delegate)tournamentSeatsSuccess).method_code;
				IntPtr method = ((Delegate)tournamentSeatsSuccess).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v267 @ X3_v3 (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
			IL_0470:
			object obj19 = typeof(System.IOAsyncCallback) + 976;
			nint num3 = (nint)iSFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0520;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj21 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X10_v10-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				obj6 = obj21 + 16;
				obj20--;
				bool flag4 = (nint)obj20 != 1;
				obj21 = obj6;
				if (flag4)
				{
					continue;
				}
				goto IL_0520;
			}
			object obj22 = obj21 + 14;
			object obj23 = num3 + obj22;
			object obj24 = obj23 + 312;
			obj6 = obj21;
			goto IL_070c;
			IL_00d9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v37+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ X0_v37] (should have been resolved before IL gen)");
			bool flag5 = obj11 == null;
			object obj25 = !flag5;
			<>c__DisplayClass360_ = this;
			if (obj25 != null)
			{
				goto IL_0184;
			}
			goto IL_065a;
			IL_0184:
			object obj26 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			obj14 = typeof(System.IOAsyncCallback) + 960;
			object obj27 = "tournament_participate_warning_body_with_tickets_warning_daily" + 568;
			object varName = "setMimeType" + 3176;
			object obj28 = (nint)0 + (nint)952;
			object obj29 = obj26;
			object obj30 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v27+12E]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v27+12E]");
			bool flag6 = (nint)0 == 0;
			object obj32 = 0;
			object obj34 = default(object);
			object obj33 = obj34;
			object obj35 = obj26;
			object obj36 = 0;
			if (!flag6)
			{
				goto IL_023d;
			}
			goto IL_02b4;
			IL_023d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v27+B0]");
			object obj37 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v21-8]");
				if (0 == (nint)obj29)
				{
					break;
				}
				obj6 = obj37 + 16;
				obj31--;
				bool flag7 = (nint)obj31 != 1;
				obj33 = obj28;
				obj35 = obj29;
				obj36 = obj32;
				obj37 = obj6;
				if (flag7)
				{
					continue;
				}
				goto IL_02b4;
			}
			object obj38 = obj37 + 1;
			object obj39 = obj30 + obj38;
			object obj40 = obj39 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v485 @ X0_v33] (should have been resolved before IL gen)");
			object obj41 = default(object);
			bool flag8 = obj32 >= obj41;
			obj33 = obj28;
			obj6 = obj37;
			obj36 = obj32;
			if (!flag8)
			{
				goto IL_0353;
			}
			goto IL_05f9;
			IL_070c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ X0_v11] (should have been resolved before IL gen)");
			int num4 = SFSExtensions.Get(iSFSObject, (string)varName, -1);
			int key = default(int);
			dictionary.set_Item(key, num4);
			obj32 = obj36 + 1;
			obj29 = obj26;
			obj30 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v27+12E]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v27+12E]");
			bool flag9 = (nint)0 == 0;
			object obj42 = !flag9;
			num2 = num4;
			if (obj42 != null)
			{
				goto IL_023d;
			}
			obj33 = obj28;
			obj35 = obj26;
			obj36 = obj32;
			goto IL_02b4;
			IL_0520:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_070c;
			IL_065a:
			throw new NullReferenceException();
			IL_02b4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v29] (should have been resolved before IL gen)");
			object obj43 = default(object);
			if (obj36 < obj43)
			{
				goto IL_0353;
			}
			goto IL_05f9;
		}
	}

	private sealed class <>c__DisplayClass363_0
	{
		public TournamentParticipateError onError;

		public TournamentParticipateSuccess onSuccess;

		internal void <ParticipateMassTournament>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_01e8: Expected I4, but got I8
			//IL_007b: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01b5: Expected O, but got I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			goto IL_0168;
			IL_00ed:
			object defaultValue = (nint)0 + (nint)2000;
			string text = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			TournamentParticipateError tournamentParticipateError = onError;
			if (onError != null)
			{
				IntPtr invoke_impl = ((Delegate)tournamentParticipateError).invoke_impl;
				IntPtr method_code = ((Delegate)tournamentParticipateError).method_code;
				IntPtr method = ((Delegate)tournamentParticipateError).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v143 @ X6_v1 (System.IntPtr) (should have been resolved before IL gen)");
				goto IL_0168;
			}
			return;
			IL_0168:
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X0_v16] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
			IL_01c3:
			object varName2 = "setMimeType" + 3176;
			int num2 = SFSExtensions.Get(response, (string)varName2, -1);
			TournamentParticipateSuccess tournamentParticipateSuccess = onSuccess;
			if (onSuccess != null)
			{
				IntPtr invoke_impl2 = ((Delegate)tournamentParticipateSuccess).invoke_impl;
				IntPtr method_code2 = ((Delegate)tournamentParticipateSuccess).method_code;
				IntPtr method2 = ((Delegate)tournamentParticipateSuccess).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v146 @ X3_v3 (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X0_v13] (should have been resolved before IL gen)");
			object obj9 = default(object);
			if (obj9 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
		}
	}

	private sealed class <>c__DisplayClass364_0
	{
		public TournamentError onError;

		public MassWinnersListSuccess onSuccess;

		internal void <GetMassWinnersList>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_01da: Expected I, but got O
			//IL_01ea: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected O, but got Unknown
			//IL_0354: Expected O, but got I
			//IL_0362: Expected I, but got O
			//IL_036e: Expected O, but got I
			//IL_0225: Expected O, but got I
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01b5: Expected O, but got I4
			//IL_02c9: Expected O, but got I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v14-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			goto IL_0168;
			IL_01c3:
			object obj4 = "com.unity.services.authentication.profile" + 2776;
			nint num2 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0266;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_0266;
			}
			object obj7 = obj6 + 28;
			object obj8 = num2 + obj7;
			object obj9 = obj8 + 312;
			goto IL_0320;
			IL_0320:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v368 @ X0_v5] (should have been resolved before IL gen)");
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3088;
			Func<object, object> func = default(Func<object, object>);
			func..ctor((object)null, (IntPtr)obj11);
			object obj12 = (nint)0 + (nint)472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
			TournamentError tournamentError = (TournamentError)(object)onSuccess;
			bool flag = onSuccess == null;
			object obj13 = !flag;
			if (obj13 == null)
			{
				return;
			}
			goto IL_0137;
			IL_0266:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0320;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X0_v21] (should have been resolved before IL gen)");
			object obj14 = default(object);
			if (obj14 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
			IL_00ed:
			object defaultValue = (nint)0 + (nint)2000;
			string text = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			tournamentError = onError;
			if (onError != null)
			{
				goto IL_0137;
			}
			return;
			IL_0137:
			IntPtr invoke_impl = ((Delegate)tournamentError).invoke_impl;
			IntPtr method_code = ((Delegate)tournamentError).method_code;
			IntPtr method = ((Delegate)tournamentError).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v145 @ X3_v4 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_0168;
			IL_0168:
			object obj15 = obj3 + 1;
			object obj16 = num + obj15;
			object obj17 = obj16 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X0_v24] (should have been resolved before IL gen)");
			object obj18 = default(object);
			bool flag2 = obj18 == null;
			object obj19 = !flag2;
			if (obj19 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
		}
	}

	private sealed class <>c__DisplayClass365_0
	{
		public TournamentError onError;

		public MassStagesListSuccess onSuccess;

		internal void <GetMassTournamentStagesSummery>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_01da: Expected I, but got O
			//IL_01ea: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected O, but got Unknown
			//IL_0354: Expected O, but got I
			//IL_0362: Expected I, but got O
			//IL_036e: Expected O, but got I
			//IL_0225: Expected O, but got I
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01b5: Expected O, but got I4
			//IL_02c9: Expected O, but got I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v14-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			goto IL_0168;
			IL_01c3:
			object obj4 = "m_StencilDeferredPS" + 2648;
			nint num2 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0266;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_0266;
			}
			object obj7 = obj6 + 28;
			object obj8 = num2 + obj7;
			object obj9 = obj8 + 312;
			goto IL_0320;
			IL_0320:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v368 @ X0_v5] (should have been resolved before IL gen)");
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3272;
			Func<object, object> func = default(Func<object, object>);
			func..ctor((object)null, (IntPtr)obj11);
			object obj12 = (nint)0 + (nint)480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
			TournamentError tournamentError = (TournamentError)(object)onSuccess;
			bool flag = onSuccess == null;
			object obj13 = !flag;
			if (obj13 == null)
			{
				return;
			}
			goto IL_0137;
			IL_0266:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0320;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X0_v21] (should have been resolved before IL gen)");
			object obj14 = default(object);
			if (obj14 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
			IL_00ed:
			object defaultValue = (nint)0 + (nint)2000;
			string text = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			tournamentError = onError;
			if (onError != null)
			{
				goto IL_0137;
			}
			return;
			IL_0137:
			IntPtr invoke_impl = ((Delegate)tournamentError).invoke_impl;
			IntPtr method_code = ((Delegate)tournamentError).method_code;
			IntPtr method = ((Delegate)tournamentError).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v145 @ X3_v4 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_0168;
			IL_0168:
			object obj15 = obj3 + 1;
			object obj16 = num + obj15;
			object obj17 = obj16 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X0_v24] (should have been resolved before IL gen)");
			object obj18 = default(object);
			bool flag2 = obj18 == null;
			object obj19 = !flag2;
			if (obj19 != null)
			{
				goto IL_00ed;
			}
			goto IL_01c3;
		}
	}

	private sealed class <>c__DisplayClass367_0
	{
		public CurrencyBombClaim callback;

		internal void <SendClaimCurrencyBomb>b__2(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_003f: Expected I, but got O
			//IL_004f: Expected O, but got I
			//IL_0177: Expected O, but got I4
			//IL_0187: Expected O, but got I
			//IL_0197: Expected O, but got I
			//IL_008a: Expected O, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "startPosition" + 1328;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X10_v5-8]");
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
				goto IL_00cb;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_015e;
			IL_00cb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_015e;
			IL_015e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ X0_v3] (should have been resolved before IL gen)");
			object obj8 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v9+90]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v10+B8]");
			object defaultValue = 0;
			string text = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			CurrencyBombClaim currencyBombClaim = callback;
			if (callback != null)
			{
				IntPtr invoke_impl = ((Delegate)currencyBombClaim).invoke_impl;
				IntPtr method_code = ((Delegate)currencyBombClaim).method_code;
				IntPtr method = ((Delegate)currencyBombClaim).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v132 @ X4_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass368_0
	{
		public Action<string> onError;

		public Action useCacheCallback;

		public Action<RecentGiftBombsModel> successCallback;

		internal void <GetRecentGiftBombs>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_007b: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_0171: Expected O, but got I4
			//IL_0216: Expected O, but got I
			//IL_0226: Expected O, but got I
			//IL_0236: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X0_v18] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_017f;
			IL_00ed:
			object defaultValue = (nint)0 + (nint)2000;
			string arg = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			Actions.SafeInvoke((Action<object>)onError, arg);
			return;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X0_v15] (should have been resolved before IL gen)");
			object obj9 = default(object);
			if (obj9 != null)
			{
				goto IL_00ed;
			}
			goto IL_017f;
			IL_017f:
			object varName2 = "setMimeType" + 3816;
			int num2 = SFSExtensions.Get(response, (string)varName2, 0);
			if (num2 == 304)
			{
				Actions.SafeInvoke(useCacheCallback);
				return;
			}
			Action<RecentGiftBombsModel> action = successCallback;
			if (successCallback != null)
			{
				RecentGiftBombsModel recentGiftBombsModel = RecentGiftBombsModel.FromSfsObject(response);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v2 (System.Action`1<Server.Models.RecentGiftBombsModel>)+18]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v2 (System.Action`1<Server.Models.RecentGiftBombsModel>)+40]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v2 (System.Action`1<Server.Models.RecentGiftBombsModel>)+28]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v142 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass371_0
	{
		public Action onSuccess;

		public Action<string> onError;

		internal void <SendStopFindMatch>b__0(ISFSObject data)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_003b: Expected O, but got I
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			object varName = "startPosition" + 1328;
			if (SFSExtensions.Get(data, (string)varName, defaultValue: false))
			{
				Actions.SafeInvoke(onSuccess);
				return;
			}
			object varName2 = "destinationTimeZone" + 2696;
			object defaultValue = (nint)0 + (nint)2000;
			object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2304;
			string text = SFSExtensions.Get(data, (string)varName2, (string)defaultValue);
			if (text == (string)obj)
			{
				string arg = SFSExtensions.Get(data, (string)varName2, (string)defaultValue);
				Actions.SafeInvoke((Action<object>)onError, arg);
			}
		}
	}

	public const string SubscriptionStatus = "st";

	public const string VerifiedStatus = "iv";

	public const string FreeSubscriptionDays = "fsd";

	public const string SubscriptionDays = "sd";

	public const string SubscriptionExpiresAt = "sea";

	public const string UserName = "n";

	public const string Email = "e";

	public const string UserCode = "uc";

	public const string IsNew = "isNew";

	public const string Points = "pts";

	public const string TournamentPoints = "tpts";

	public const string TourneyJoinDiscount = "td";

	public const string UserPermissions = "pe";

	public const string ChatInk = "in";

	public const string HasTrophyCelebration = "htc";

	public const string AvatarDate = "ad";

	public const string RegistrationDate = "rt";

	public const string PlayingCondition = "pc";

	public const string MuteStatus = "ms";

	public const string MutedUntil = "mu";

	public const string JoinRankedGamePrice = "jp";

	public const string JoinsAllowed = "ja";

	public const string MaxFreeJoins = "mja";

	public const string MiniGameTrials = "mg_t";

	public const string WinningSteak = "str";

	public const string FacebookID = "s_f";

	public const string TwitterID = "s_t";

	public const string TwitterUserID = "s_ti";

	public const string GoogleID = "s_g";

	public const string AppleID = "s_a";

	public const string ActiveGameTitle = "agt";

	public const string ActiveTitleLevel = "atl";

	public const string TicketsRecords = "tr";

	public const string MonthliesEligibility = "mte";

	public const string UserLikes = "lk";

	public const string UserAchievements = "achp";

	public const string ClanID = "clid";

	public const string ClanName = "cn";

	public const string ClanTier = "ctr";

	public const string ClanTitle = "crt";

	public const string ClanPermissions = "clpr";

	public const string ClanSubscriptionStatus = "css";

	public const string ClanOwner = "cow";

	public const string Aces = "aces";

	public const string ActiveRoom = "r";

	public const string ActiveCard = "c";

	public const string ActivePattern = "ptn";

	public const string FeaturedSlotLevel = "fsl";

	public const string FeaturedSlotAchievement = "fsa";

	public const string OwnedCards = "ocs";

	public const string OwnedRooms = "ors";

	public const string PaidRooms = "hprs";

	public const string OwnedGifts = "ogs";

	public const string OwnedPatterns = "ops";

	public const string FTLevel = "ft_lvl";

	public const string FTStage = "ft_s";

	public const string FTTopStage = "ft_ts";

	public const string FTRoundsWon = "ft_rw";

	public const string FTRoundsLost = "ft_rl";

	public const string NumberOfFTStarted = "fts_std";

	public const string NumberOfFTWon = "fts_w";

	public const string FTTicketsOwned = "ft_t";

	public const string FTNextTicketTime = "ft_nt";

	public const string FTMaximumTicketsAllowed = "mt";

	public const string Cheating = "ch";

	public const string GameType = "gt";

	public const string Private = "pr";

	public const string Password = "password";

	public const string RankLimit = "r";

	public const string OriginalOwner = "ORO";

	public const string RoomOwner = "O";

	public const string Timer = "timer";

	public const string Team1Score = "t1Score";

	public const string Team2Score = "t2Score";

	public const string RoomTheme = "rTheme";

	public const string RoomCardback = "cb";

	public const string PlayersInfo = "pinfo";

	public const string PLAYER_VOICES = "pv";

	public const string ChatEnabled = "ce";

	public const string VoiceChatEnabled = "vc";

	public const string VoiceChatEnabledForSpectators = "vcs";

	public const string RoomMessage = "rm";

	public const string RoomSportTeamID = "rst";

	public const string AdCampaignID = "rad";

	public const string TutorialType = "Tut_type";

	public const string IsReplay = "i_r";

	public const string TEAM1_PLAYER1_SCORE = "ts1p1";

	public const string TEAM1_PLAYER2_SCORE = "ts1p2";

	public const string TEAM2_PLAYER1_SCORE = "ts2p1";

	public const string TEAM2_PLAYER2_SCORE = "ts2p2";

	public const string TournamentMatch = "trm";

	public const string TournamentScore1 = "w1";

	public const string TournamentScore2 = "w2";

	public const string TournamentBestOf = "bo";

	public const string Watchers = "ws";

	public const string TournamentInfo = "i";

	public const string MassTournamentInfo = "mi";

	public const string Matches = "m";

	public const string ActiveTournamentsCount = "atc";

	public const string ParticipantsCount = "pn";

	public const string OnlineUsersCount = "ouc";

	public const string CurrentRound = "crd";

	public const string ParticipantsChooseTeam = "apct";

	public const string TournamentShuffleTeams = "sfl";

	public const string TournamentQueue = "q";

	public const string TournamentStatus = "stat";

	public const string TournamentRoundTimer = "rt";

	public const string TournamentChatEnabled = "wsc";

	public const string TournamentPassword = "pwd";

	public const string MassMaxStageDelay = "msd";

	public const string MassActiveStage = "ast";

	public const string MassPlayWindow = "apw";

	public const string MassStageFilterValue = "afv";

	public const string ActiveClusterStartTime = "acst";

	public const string MassLatestRooms = "arl";

	public const string MassActiveRoomsCount = "arc";

	public const string FriendlyChallengeLevel = "fclv";

	public const string ActiveBombInfo = "ab";

	public const string ClicksPeriod = "clp";

	public const string MaxAllowedClicksPerPeriod = "mc";

	public const string DeleteCredentials = "dc";

	public const string CommittedClicks = "cc";

	public const string LastRequestUpdate = "lru";

	public const string JackarooCustomRules = "jcr";

	public const string VivoxMuteStatus = "mm";

	private const int ShortLagDelay = 3;

	private const int LongLagDelay = 45;

	public const string ClanInfo = "cin";

	private SmartFoxClient client;

	private readonly VariableBinder binder;

	private bool intentionalDisconnect;

	private bool switchingServer;

	private User lastLoggedInUser;

	private static int <Latency>k__BackingField;

	private static DateTime <LastSFSSignalTime>k__BackingField;

	private static bool IsConnectionBroken;

	private static bool IsLagMonitorInitialized;

	private static DateTime LastPongTime;

	private DateTime _lastSubscriptionChange;

	private Coroutine _expiryCheckerCoroutine;

	private static SmartFoxClient Client
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0101: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_014a: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
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
				object obj4 = (nint)0 + (nint)2152;
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
			return (SmartFoxClient)0;
			IL_0158:
			return (SmartFoxClient)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
		}
	}

	public static VariableBinder Binder
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0101: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_014a: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8324]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
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
				object obj4 = (nint)0 + (nint)2152;
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+28]");
			return (VariableBinder)0;
			IL_0158:
			return (VariableBinder)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
		}
	}

	public static bool IsConnected
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0119: Expected O, but got I
			//IL_0143: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01ab: Expected I4, but got O
			//IL_018c: Expected O, but got I4
			//IL_00fe: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8391]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_019a;
			IL_01b0:
			bool result;
			return result;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			result = false;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
				return ((SmartFox)0).IsConnected;
			}
			goto IL_01b0;
			IL_019a:
			NullReferenceException ex = new NullReferenceException();
			result = (byte)(int)ex != 0;
			goto IL_01b0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_019a;
		}
	}

	public static bool IsLoggedIn
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_013b: Expected O, but got I
			//IL_0165: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01ca: Expected I4, but got O
			//IL_01ae: Expected O, but got I4
			//IL_00fe: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8325]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
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
				object obj4 = (nint)0 + (nint)2152;
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_01bc;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
			bool result = false;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
				User mySelf = ((SmartFox)0).MySelf;
				bool flag5 = mySelf == null;
				bool flag6 = !flag5;
				result = flag6;
			}
			return result;
			IL_01bc:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_01bc;
		}
	}

	public static string CurrentZone
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0119: Expected O, but got I
			//IL_0143: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_00df: Expected O, but got I
			//IL_018c: Expected O, but got I4
			//IL_00fe: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8326]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_019a;
			IL_01b0:
			string result;
			return result;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			result = (string)0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
				return ((SmartFox)0).CurrentZone;
			}
			goto IL_01b0;
			IL_019a:
			NullReferenceException ex = new NullReferenceException();
			result = (string)(object)ex;
			goto IL_01b0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_019a;
		}
	}

	public static User MySelf
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_018e: Expected O, but got I
			//IL_027e: Expected O, but got I4
			//IL_01d9: Expected O, but got I4
			//IL_02cf: Expected O, but got I
			//IL_0253: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8327]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v18+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_02cf;
			IL_02cf:
			return (User)new NullReferenceException();
			IL_0158:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
				User mySelf = ((SmartFox)0).MySelf;
				object obj9 = obj2;
				if (mySelf != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+E4]");
					bool flag4 = (nint)0 == 0;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					object obj11 = default(object);
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v14+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v14+20]");
							return ((SmartFox)0).MySelf;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					object obj13 = default(object);
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v9+38]");
						return (User)0;
					}
				}
			}
			goto IL_02cf;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag6 = obj8 == null;
			object obj14 = !flag6;
			if (obj14 != null)
			{
				goto IL_0158;
			}
			goto IL_02cf;
		}
	}

	public static Room LastJoinedRoom
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0186: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8328]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
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
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_018f;
			IL_018f:
			return (Room)new NullReferenceException();
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
				return ((SmartFox)0).LastJoinedRoom;
			}
			goto IL_018f;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_0150;
			}
			goto IL_018f;
		}
	}

	public static bool IsInLobby
	{
		get
		{
			Room lastJoinedRoom = LastJoinedRoom;
			return SFSKammelnaRoomExtensions.IsLobby(lastJoinedRoom);
		}
	}

	public static Room Lobby
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_019a: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0262: Expected O, but got I
			//IL_0272: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_01d7: Expected O, but got I
			//IL_01e7: Expected O, but got I
			//IL_01f7: Expected O, but got I
			//IL_0219: Expected O, but got I4
			//IL_02cc: Expected O, but got I4
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected O, but got Unknown
			//IL_034f: Expected O, but got I
			//IL_0360: Expected I, but got O
			//IL_037e: Expected O, but got I
			//IL_02fc: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8329]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
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
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_0317;
			IL_02aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj11;
			object obj12;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+B8]");
				obj12 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1112;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj12, (IntPtr)obj14);
			object obj15 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v12+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18;
			object obj17 = obj18;
			Func<object, bool> predicate = func;
			goto IL_0301;
			IL_0317:
			return (Room)new NullReferenceException();
			IL_0301:
			List<Room> roomList;
			return (Room)Enumerable.FirstOrDefault(roomList, predicate);
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = obj8 == null;
			object obj19 = !flag4;
			if (obj19 != null)
			{
				goto IL_0150;
			}
			goto IL_0317;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
			if ((nint)0 != 0)
			{
				obj11 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
				roomList = ((SmartFox)0).RoomList;
				object obj20 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					obj17 = (nint)0 + (nint)1168;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+8]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						obj18 = obj17;
						goto IL_02aa;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj11;
					obj18 = (nint)0 + (nint)1168;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+8]");
					bool flag6 = (nint)0 == 0;
					object obj22 = !flag6;
					obj17 = obj18;
					if (obj22 == null)
					{
						goto IL_02aa;
					}
				}
				goto IL_0301;
			}
			goto IL_0317;
		}
	}

	public static IEnumerable<Room> TournamentRooms
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_019a: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0262: Expected O, but got I
			//IL_0272: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_01d7: Expected O, but got I
			//IL_01e7: Expected O, but got I
			//IL_01f7: Expected O, but got I
			//IL_0219: Expected O, but got I4
			//IL_03b6: Expected O, but got I
			//IL_03c6: Expected O, but got I
			//IL_03e8: Expected O, but got I4
			//IL_02cc: Expected O, but got I4
			//IL_034f: Expected O, but got I
			//IL_035f: Expected O, but got I
			//IL_0381: Expected O, but got I4
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Expected O, but got Unknown
			//IL_049b: Expected O, but got I
			//IL_04ac: Expected I, but got O
			//IL_04ca: Expected O, but got I
			//IL_0418: Expected O, but got I4
			//IL_02fc: Expected O, but got I
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Expected O, but got Unknown
			//IL_051b: Expected O, but got I
			//IL_052c: Expected I, but got O
			//IL_054a: Expected O, but got I
			//IL_0448: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E832A]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v34+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v34+E4]");
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
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_0463;
			IL_02aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj11;
			object obj12;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v26+B8]");
				obj12 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1144;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj12, (IntPtr)obj14);
			object obj15 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v25+B8]");
			object obj16 = (nint)0 + (nint)16;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18;
			object obj17 = obj18;
			Func<object, bool> predicate = func;
			goto IL_0301;
			IL_044d:
			IEnumerable<object> source;
			Func<object, bool> predicate2;
			return (IEnumerable<Room>)Enumerable.Where(source, predicate2);
			IL_0463:
			return (IEnumerable<Room>)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = obj8 == null;
			object obj19 = !flag4;
			if (obj19 != null)
			{
				goto IL_0150;
			}
			goto IL_0463;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
			List<Room> roomList;
			if ((nint)0 != 0)
			{
				obj11 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
				roomList = ((SmartFox)0).RoomList;
				object obj20 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					obj17 = (nint)0 + (nint)3736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+10]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+10]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						obj18 = obj17;
						goto IL_02aa;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj11;
					obj18 = (nint)0 + (nint)3736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+10]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+10]");
					bool flag6 = (nint)0 == 0;
					object obj22 = !flag6;
					obj17 = obj18;
					if (obj22 == null)
					{
						goto IL_02aa;
					}
				}
				goto IL_0301;
			}
			goto IL_0463;
			IL_03f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			object obj25;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v15+B8]");
				obj25 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)1152;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj25, (IntPtr)obj27);
			object obj28 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14+B8]");
			object obj29 = (nint)0 + (nint)24;
			obj29 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate2 = func2;
			goto IL_044d;
			IL_0301:
			source = Enumerable.Where(roomList, predicate);
			object obj30 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+B8]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
				predicate2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
				bool flag8 = (nint)0 == 0;
				object obj31 = !flag8;
				if (obj31 == null)
				{
					goto IL_03f6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+B8]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
				predicate2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
				bool flag9 = (nint)0 == 0;
				object obj32 = !flag9;
				if (obj32 == null)
				{
					goto IL_03f6;
				}
			}
			goto IL_044d;
		}
	}

	public static IEnumerable<Room> TournamentMatchesRoomsList
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_019a: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0262: Expected O, but got I
			//IL_0272: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_01d7: Expected O, but got I
			//IL_01e7: Expected O, but got I
			//IL_01f7: Expected O, but got I
			//IL_0219: Expected O, but got I4
			//IL_02cc: Expected O, but got I4
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected O, but got Unknown
			//IL_034f: Expected O, but got I
			//IL_0360: Expected I, but got O
			//IL_037e: Expected O, but got I
			//IL_02fc: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E832B]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
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
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_0317;
			IL_02aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj11;
			object obj12;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+B8]");
				obj12 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1136;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj12, (IntPtr)obj14);
			object obj15 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v12+B8]");
			object obj16 = (nint)0 + (nint)32;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18;
			object obj17 = obj18;
			Func<object, bool> predicate = func;
			goto IL_0301;
			IL_0317:
			return (IEnumerable<Room>)new NullReferenceException();
			IL_0301:
			List<Room> roomList;
			return (IEnumerable<Room>)Enumerable.Where(roomList, predicate);
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = obj8 == null;
			object obj19 = !flag4;
			if (obj19 != null)
			{
				goto IL_0150;
			}
			goto IL_0317;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
			if ((nint)0 != 0)
			{
				obj11 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
				roomList = ((SmartFox)0).RoomList;
				object obj20 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					obj17 = (nint)0 + (nint)3736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+20]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+20]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						obj18 = obj17;
						goto IL_02aa;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj11;
					obj18 = (nint)0 + (nint)3736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+20]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7+20]");
					bool flag6 = (nint)0 == 0;
					object obj22 = !flag6;
					obj17 = obj18;
					if (obj22 == null)
					{
						goto IL_02aa;
					}
				}
				goto IL_0301;
			}
			goto IL_0317;
		}
	}

	public static IEnumerable<Room> MassTournamentRooms
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_019a: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0262: Expected O, but got I
			//IL_0272: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_01d7: Expected O, but got I
			//IL_01e7: Expected O, but got I
			//IL_01f7: Expected O, but got I
			//IL_0219: Expected O, but got I4
			//IL_03b6: Expected O, but got I
			//IL_03c6: Expected O, but got I
			//IL_03e8: Expected O, but got I4
			//IL_02cc: Expected O, but got I4
			//IL_034f: Expected O, but got I
			//IL_035f: Expected O, but got I
			//IL_0381: Expected O, but got I4
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Expected O, but got Unknown
			//IL_049b: Expected O, but got I
			//IL_04ac: Expected I, but got O
			//IL_04ca: Expected O, but got I
			//IL_0418: Expected O, but got I4
			//IL_02fc: Expected O, but got I
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0505: Expected O, but got Unknown
			//IL_051b: Expected O, but got I
			//IL_052c: Expected I, but got O
			//IL_054a: Expected O, but got I
			//IL_0448: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E832C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v34+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v34+E4]");
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
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_0463;
			IL_02aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj11;
			object obj12;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v26+B8]");
				obj12 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1120;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj12, (IntPtr)obj14);
			object obj15 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v25+B8]");
			object obj16 = (nint)0 + (nint)40;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18;
			object obj17 = obj18;
			Func<object, bool> predicate = func;
			goto IL_0301;
			IL_044d:
			IEnumerable<object> source;
			Func<object, bool> predicate2;
			return (IEnumerable<Room>)Enumerable.Where(source, predicate2);
			IL_0463:
			return (IEnumerable<Room>)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = obj8 == null;
			object obj19 = !flag4;
			if (obj19 != null)
			{
				goto IL_0150;
			}
			goto IL_0463;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
			List<Room> roomList;
			if ((nint)0 != 0)
			{
				obj11 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+20]");
				roomList = ((SmartFox)0).RoomList;
				object obj20 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					obj17 = (nint)0 + (nint)3736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+28]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+28]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						obj18 = obj17;
						goto IL_02aa;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj11;
					obj18 = (nint)0 + (nint)3736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+28]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20+28]");
					bool flag6 = (nint)0 == 0;
					object obj22 = !flag6;
					obj17 = obj18;
					if (obj22 == null)
					{
						goto IL_02aa;
					}
				}
				goto IL_0301;
			}
			goto IL_0463;
			IL_03f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			object obj25;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v15+B8]");
				obj25 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)1128;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj25, (IntPtr)obj27);
			object obj28 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v14+B8]");
			object obj29 = (nint)0 + (nint)48;
			obj29 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate2 = func2;
			goto IL_044d;
			IL_0301:
			source = Enumerable.Where(roomList, predicate);
			object obj30 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+B8]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+30]");
				predicate2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+30]");
				bool flag8 = (nint)0 == 0;
				object obj31 = !flag8;
				if (obj31 == null)
				{
					goto IL_03f6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14+B8]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+30]");
				predicate2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+30]");
				bool flag9 = (nint)0 == 0;
				object obj32 = !flag9;
				if (obj32 == null)
				{
					goto IL_03f6;
				}
			}
			goto IL_044d;
		}
	}

	public static int Latency
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+100]");
			return 0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
		}
	}

	public static DateTime LastSFSSignalTime
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_003e: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+108]");
			return (DateTime)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
		}
	}

	public static ConnectionSpeed ConnectionSpeed
	{
		get
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_018c: Expected O, but got I
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_012d: Expected O, but got I
			//IL_0157: Expected O, but got I4
			//IL_002a: Expected O, but got I
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00d6: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+B8]");
			object obj3 = 0;
			object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj5 = (nint)0 + (nint)1568;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6+100]");
			object obj8 = (nint)1251 - (nint)0;
			object obj9 = obj8 * 274877907;
			object obj10 = obj9 >> 36;
			object obj11 = obj10 + obj10;
			object obj12 = ~obj11;
			object obj13 = obj11 & obj12;
			object obj14 = obj13 - 4;
			bool flag2 = (nint)obj14 < 0;
			object obj15 = obj13 ^ 4;
			object obj16 = obj13 ^ obj14;
			object obj17 = obj15 & obj16;
			bool flag3 = (nint)obj17 < 0;
			bool flag4 = flag2 == flag3;
			object obj18 = !flag4;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				object obj20 = obj13;
			}
			else
			{
				object obj20 = 4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D712E8");
			ConnectionSpeed result = default(ConnectionSpeed);
			return result;
		}
	}

	public static List<Room> RoomList
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0186: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8334]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
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
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_018f;
			IL_018f:
			return (List<Room>)(object)new NullReferenceException();
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
				return ((SmartFox)0).RoomList;
			}
			goto IL_018f;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_0150;
			}
			goto IL_018f;
		}
	}

	public static event EventListenerDelegate OnExtensionResponse
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(DataRelation) + 3728;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(DataRelation) + 3728;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<BaseEvent> OnLogin
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<LoginError> OnLoginError
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event EventListenerDelegate OnLogoutNotReliable
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(DataRelation) + 3728;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(DataRelation) + 3728;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action OnLogout
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<MaintenanceInfo> OnMaintenanceNotice
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2600;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+28]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2600;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+28]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<int> OnPingPong
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+30]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+30]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Room> OnRoomCreated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+38]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+38]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Room> OnJoinRoom
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+40]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+40]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Room> OnJoinGameRoom
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+48]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+48]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Room, string> OnJoinRoomFailed
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+50]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+50]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Room> OnRoomRemoved
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+58]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)88;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+58]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)88;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnOfflineGameStarted
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+60]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+60]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<bool> OnReturnedFromOffline
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+68]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+68]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnGameSwitchedOffline
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+70]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)112;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+70]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)112;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action OnConnectionStuck
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+78]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)120;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+78]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)120;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action OnForcedDisconnect
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+80]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)128;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+80]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)128;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action OnKickedToLogin
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+88]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)136;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+88]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)136;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<Room> OnRoomNameChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+90]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+90]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<string> OnRoomGroupSubscribe
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+98]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+98]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<string> OnRoomGroupUnsubscribe
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ChatMessageData> OnPublicMessage
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<User> OnUserJoinRoom
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+B0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+B0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<User> OnUserLeaveRoom
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+B8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+B8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<ChatMessageData> OnAdminMessage
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+C0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+C0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<User, List<string>> OnUserVariableUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 784;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+C8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 784;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+C8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<Room, List<string>> OnRoomVariableUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 640;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+D0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)208;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 640;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+D0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)208;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<List<string>> OnMyUserVariableUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+D8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+D8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<bool, string> OnConnection
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 280;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 280;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<string> OnConnectionLost
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)232;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)232;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<string> OnServerSwitch
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+F0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)240;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+F0]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)240;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnPersonalAvatarUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+F8]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)248;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 1880;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+F8]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)248;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static IEnumerable<Room> ClanGameRooms(string clanGroupTag)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0142: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass254_0 <>c__DisplayClass254_ = default(<>c__DisplayClass254_0);
		<>c__DisplayClass254_..ctor();
		if (<>c__DisplayClass254_ != null)
		{
			object obj2 = typeof(Queue<string>) + 824;
			object obj3 = (nint)0 + (nint)2152;
			object obj4 = <>c__DisplayClass254_ + 16;
			obj4 = clanGroupTag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj7 = default(object);
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v12+20]");
				if ((nint)0 != 0)
				{
					object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
					object obj9 = (nint)0 + (nint)1160;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v12+20]");
					List<Room> roomList = ((SmartFox)0).RoomList;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)<>c__DisplayClass254_, (IntPtr)obj9);
					return (IEnumerable<Room>)Enumerable.Where(roomList, func);
				}
			}
		}
		return (IEnumerable<Room>)new NullReferenceException();
	}

	protected SFS()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007f: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 824;
		object obj2 = (nint)0 + (nint)2144;
		object obj3 = typeof(UsageHint) + 672;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		VariableBinder variableBinder = default(VariableBinder);
		variableBinder..ctor();
		object obj6 = this + 40;
		obj6 = variableBinder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CreateNewClient();
	}

	private void CreateNewClient()
	{
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Expected O, but got Unknown
		//IL_00e2: Expected I, but got O
		//IL_00fc: Expected O, but got I4
		//IL_0104: Expected I4, but got O
		//IL_0e73: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_014b: Expected I4, but got O
		//IL_0154: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_018f: Expected I4, but got O
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I
		//IL_0202: Expected O, but got I4
		//IL_0ef6: Expected O, but got I
		//IL_0f0e: Expected I, but got O
		//IL_0f26: Expected O, but got I4
		//IL_0f2e: Expected I4, but got O
		//IL_0233: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_028b: Expected I, but got O
		//IL_02a5: Expected O, but got I4
		//IL_02ad: Expected I4, but got O
		//IL_02cc: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_0309: Expected O, but got I
		//IL_0326: Expected I, but got O
		//IL_0340: Expected O, but got I4
		//IL_0348: Expected I4, but got O
		//IL_0367: Expected O, but got I
		//IL_0382: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_03c1: Expected I, but got O
		//IL_03db: Expected O, but got I4
		//IL_03e3: Expected I4, but got O
		//IL_0402: Expected O, but got I
		//IL_041d: Expected O, but got I
		//IL_043f: Expected O, but got I
		//IL_045c: Expected I, but got O
		//IL_0476: Expected O, but got I4
		//IL_047e: Expected I4, but got O
		//IL_049d: Expected O, but got I
		//IL_04b8: Expected O, but got I
		//IL_04da: Expected O, but got I
		//IL_04f7: Expected I, but got O
		//IL_0511: Expected O, but got I4
		//IL_0519: Expected I4, but got O
		//IL_0538: Expected O, but got I
		//IL_0553: Expected O, but got I
		//IL_0575: Expected O, but got I
		//IL_0592: Expected I, but got O
		//IL_05ac: Expected O, but got I4
		//IL_05b4: Expected I4, but got O
		//IL_05d3: Expected O, but got I
		//IL_05ee: Expected O, but got I
		//IL_0610: Expected O, but got I
		//IL_062d: Expected I, but got O
		//IL_0647: Expected O, but got I4
		//IL_064f: Expected I4, but got O
		//IL_066e: Expected O, but got I
		//IL_0689: Expected O, but got I
		//IL_06ab: Expected O, but got I
		//IL_06c8: Expected I, but got O
		//IL_06e2: Expected O, but got I4
		//IL_06ea: Expected I4, but got O
		//IL_0709: Expected O, but got I
		//IL_0724: Expected O, but got I
		//IL_0746: Expected O, but got I
		//IL_0763: Expected I, but got O
		//IL_077d: Expected O, but got I4
		//IL_0785: Expected I4, but got O
		//IL_07a4: Expected O, but got I
		//IL_07bf: Expected O, but got I
		//IL_07e1: Expected O, but got I
		//IL_07fe: Expected I, but got O
		//IL_0818: Expected O, but got I4
		//IL_0820: Expected I4, but got O
		//IL_083f: Expected O, but got I
		//IL_085a: Expected O, but got I
		//IL_087c: Expected O, but got I
		//IL_0899: Expected I, but got O
		//IL_08b3: Expected O, but got I4
		//IL_08bb: Expected I4, but got O
		//IL_08da: Expected O, but got I
		//IL_08f5: Expected O, but got I
		//IL_0917: Expected O, but got I
		//IL_0934: Expected I, but got O
		//IL_094e: Expected O, but got I4
		//IL_0956: Expected I4, but got O
		//IL_0975: Expected O, but got I
		//IL_0990: Expected O, but got I
		//IL_09b2: Expected O, but got I
		//IL_09cf: Expected I, but got O
		//IL_09e9: Expected O, but got I4
		//IL_09f1: Expected I4, but got O
		//IL_0a10: Expected O, but got I
		//IL_0a2b: Expected O, but got I
		//IL_0a4d: Expected O, but got I
		//IL_0a6a: Expected I, but got O
		//IL_0a84: Expected O, but got I4
		//IL_0a8c: Expected I4, but got O
		//IL_0aab: Expected O, but got I
		//IL_0ac6: Expected O, but got I
		//IL_0ae8: Expected O, but got I
		//IL_0b05: Expected I, but got O
		//IL_0b1f: Expected O, but got I4
		//IL_0b27: Expected I4, but got O
		//IL_0b46: Expected O, but got I
		//IL_0b61: Expected O, but got I
		//IL_0b83: Expected O, but got I
		//IL_0ba0: Expected I, but got O
		//IL_0bba: Expected O, but got I4
		//IL_0bc2: Expected I4, but got O
		//IL_0be1: Expected O, but got I
		//IL_0bfc: Expected O, but got I
		//IL_0c1e: Expected O, but got I
		//IL_0c3b: Expected I, but got O
		//IL_0c55: Expected O, but got I4
		//IL_0c5d: Expected I4, but got O
		//IL_0c7c: Expected O, but got I
		//IL_0c97: Expected O, but got I
		//IL_0cb9: Expected O, but got I
		//IL_0cd6: Expected I, but got O
		//IL_0cf0: Expected O, but got I4
		//IL_0cf8: Expected I4, but got O
		//IL_0d26: Expected O, but got I
		//IL_0d48: Expected O, but got I
		//IL_0d65: Expected I, but got O
		//IL_0d7f: Expected O, but got I4
		//IL_0d87: Expected I4, but got O
		//IL_0db5: Expected O, but got I
		SmartFox smartFox = (SmartFox)(this + 32);
		if (smartFox != null)
		{
			smartFox.RemoveAllEventListeners();
			if (smartFox != null)
			{
				smartFox.HandleClientDisconnection(null, triggerEvent: false);
				object obj = 0;
				bool flag = false;
			}
		}
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate2 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate3 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate4 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate5 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate6 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate7 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate8 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate9 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate10 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate11 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate12 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate13 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate14 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate15 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate16 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate17 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate18 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate19 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate20 = default(EventListenerDelegate);
		EventListenerDelegate eventListenerDelegate21 = default(EventListenerDelegate);
		object obj48 = default(object);
		object obj49 = default(object);
		NullReferenceException ex3 = default(NullReferenceException);
		while (true)
		{
			SmartFoxClient smartFoxClient = GetClient();
			smartFox = smartFoxClient;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = smartFox == null;
			SmartFoxClient smartFoxClient2 = smartFoxClient;
			bool flag;
			if (!flag2)
			{
				object obj2 = typeof(DataRelation) + 3728;
				object obj3 = (nint)0 + (nint)3832;
				smartFox.Debug = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				eventListenerDelegate..ctor(this, (IntPtr)obj3);
				bool flag3 = client == null;
				object obj = 0;
				flag = (byte)(int)obj3 != 0;
				smartFoxClient2 = (SmartFoxClient)(object)this;
				if (!flag3)
				{
					client.AddLogListener(LogLevel.DEBUG, eventListenerDelegate);
					bool flag4 = smartFox == null;
					obj = 0;
					flag = (byte)(int)eventListenerDelegate != 0;
					smartFoxClient2 = (SmartFoxClient)100;
					if (!flag4)
					{
						Sfs2X.Logging.Logger log = smartFox.Log;
						bool flag5 = log == null;
						obj = 0;
						flag = (byte)(int)eventListenerDelegate != 0;
						smartFoxClient2 = null;
						if (!flag5)
						{
							obj3 = typeof(RegisteredWaitHandle) + 2008;
							object obj4 = (nint)0 + (nint)3872;
							log.LoggingLevel = LogLevel.WARN;
							smartFox = smartFox;
							object obj5 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v31+E4]");
							bool flag6 = (nint)0 == 0;
							object obj6 = !flag6;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj5 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v31+B8]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							eventListenerDelegate2..ctor(this, (IntPtr)obj4);
							bool flag7 = smartFox == null;
							obj = 0;
							flag = (byte)(int)obj4 != 0;
							smartFoxClient2 = (SmartFoxClient)(object)this;
							if (!flag7)
							{
								obj4 = (nint)0 + (nint)3880;
								SmartFox smartFox2 = smartFox;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v9+198]");
								smartFox2.AddEventListener((string)0, eventListenerDelegate2);
								smartFox = client;
								object obj8 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v10+B8]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								eventListenerDelegate3..ctor(this, (IntPtr)obj4);
								bool flag8 = client == null;
								obj = 0;
								flag = (byte)(int)obj4 != 0;
								smartFoxClient2 = (SmartFoxClient)(object)this;
								if (!flag8)
								{
									obj4 = (nint)0 + (nint)3912;
									SmartFoxClient smartFoxClient3 = client;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v11+D8]");
									smartFoxClient3.AddEventListener((string)0, eventListenerDelegate3);
									smartFox = client;
									object obj10 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v12+B8]");
									object obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									eventListenerDelegate4..ctor(this, (IntPtr)obj4);
									bool flag9 = client == null;
									obj = 0;
									flag = (byte)(int)obj4 != 0;
									smartFoxClient2 = (SmartFoxClient)(object)this;
									if (!flag9)
									{
										obj4 = (nint)0 + (nint)3896;
										SmartFoxClient smartFoxClient4 = client;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v13+68]");
										smartFoxClient4.AddEventListener((string)0, eventListenerDelegate4);
										smartFox = client;
										object obj12 = obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v14+B8]");
										object obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										eventListenerDelegate5..ctor(this, (IntPtr)obj4);
										bool flag10 = client == null;
										obj = 0;
										flag = (byte)(int)obj4 != 0;
										smartFoxClient2 = (SmartFoxClient)(object)this;
										if (!flag10)
										{
											obj4 = (nint)0 + (nint)3904;
											SmartFoxClient smartFoxClient5 = client;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v15+58]");
											smartFoxClient5.AddEventListener((string)0, eventListenerDelegate5);
											smartFox = client;
											object obj14 = obj3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v16+B8]");
											object obj15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											eventListenerDelegate6..ctor(this, (IntPtr)obj4);
											bool flag11 = client == null;
											obj = 0;
											flag = (byte)(int)obj4 != 0;
											smartFoxClient2 = (SmartFoxClient)(object)this;
											if (!flag11)
											{
												obj4 = (nint)0 + (nint)3976;
												SmartFoxClient smartFoxClient6 = client;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v17+60]");
												smartFoxClient6.AddEventListener((string)0, eventListenerDelegate6);
												smartFox = client;
												object obj16 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v18+B8]");
												object obj17 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												eventListenerDelegate7..ctor(this, (IntPtr)obj4);
												bool flag12 = client == null;
												obj = 0;
												flag = (byte)(int)obj4 != 0;
												smartFoxClient2 = (SmartFoxClient)(object)this;
												if (!flag12)
												{
													obj4 = (nint)0 + (nint)3864;
													SmartFoxClient smartFoxClient7 = client;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v19+10]");
													smartFoxClient7.AddEventListener((string)0, eventListenerDelegate7);
													smartFox = client;
													object obj18 = obj3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v20+B8]");
													object obj19 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													eventListenerDelegate8..ctor(this, (IntPtr)obj4);
													bool flag13 = client == null;
													obj = 0;
													flag = (byte)(int)obj4 != 0;
													smartFoxClient2 = (SmartFoxClient)(object)this;
													if (!flag13)
													{
														obj4 = (nint)0 + (nint)3920;
														SmartFoxClient smartFoxClient8 = client;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v21+28]");
														smartFoxClient8.AddEventListener((string)0, eventListenerDelegate8);
														smartFox = client;
														object obj20 = obj3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v22+B8]");
														object obj21 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														eventListenerDelegate9..ctor(this, (IntPtr)obj4);
														bool flag14 = client == null;
														obj = 0;
														flag = (byte)(int)obj4 != 0;
														smartFoxClient2 = (SmartFoxClient)(object)this;
														if (!flag14)
														{
															obj4 = (nint)0 + (nint)3928;
															SmartFoxClient smartFoxClient9 = client;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v23+18]");
															smartFoxClient9.AddEventListener((string)0, eventListenerDelegate9);
															smartFox = client;
															object obj22 = obj3;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v24+B8]");
															object obj23 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															eventListenerDelegate10..ctor(this, (IntPtr)obj4);
															bool flag15 = client == null;
															obj = 0;
															flag = (byte)(int)obj4 != 0;
															smartFoxClient2 = (SmartFoxClient)(object)this;
															if (!flag15)
															{
																obj4 = (nint)0 + (nint)3888;
																SmartFoxClient smartFoxClient10 = client;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v25+70]");
																smartFoxClient10.AddEventListener((string)0, eventListenerDelegate10);
																smartFox = client;
																object obj24 = obj3;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v26+B8]");
																object obj25 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																eventListenerDelegate11..ctor(this, (IntPtr)obj4);
																bool flag16 = client == null;
																obj = 0;
																flag = (byte)(int)obj4 != 0;
																smartFoxClient2 = (SmartFoxClient)(object)this;
																if (!flag16)
																{
																	obj4 = (nint)0 + (nint)3960;
																	SmartFoxClient smartFoxClient11 = client;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v27+88]");
																	smartFoxClient11.AddEventListener((string)0, eventListenerDelegate11);
																	smartFox = client;
																	object obj26 = obj3;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v28+B8]");
																	object obj27 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																	eventListenerDelegate12..ctor(this, (IntPtr)obj4);
																	bool flag17 = client == null;
																	obj = 0;
																	flag = (byte)(int)obj4 != 0;
																	smartFoxClient2 = (SmartFoxClient)(object)this;
																	if (!flag17)
																	{
																		obj4 = (nint)0 + (nint)3952;
																		SmartFoxClient smartFoxClient12 = client;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v29+78]");
																		smartFoxClient12.AddEventListener((string)0, eventListenerDelegate12);
																		smartFox = client;
																		object obj28 = obj3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v30+B8]");
																		object obj29 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																		eventListenerDelegate13..ctor(this, (IntPtr)obj4);
																		bool flag18 = client == null;
																		obj = 0;
																		flag = (byte)(int)obj4 != 0;
																		smartFoxClient2 = (SmartFoxClient)(object)this;
																		if (!flag18)
																		{
																			obj4 = (nint)0 + (nint)3936;
																			SmartFoxClient smartFoxClient13 = client;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v31+130]");
																			smartFoxClient13.AddEventListener((string)0, eventListenerDelegate13);
																			smartFox = client;
																			object obj30 = obj3;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v32+B8]");
																			object obj31 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																			eventListenerDelegate14..ctor(this, (IntPtr)obj4);
																			bool flag19 = client == null;
																			obj = 0;
																			flag = (byte)(int)obj4 != 0;
																			smartFoxClient2 = (SmartFoxClient)(object)this;
																			if (!flag19)
																			{
																				obj4 = (nint)0 + (nint)3944;
																				SmartFoxClient smartFoxClient14 = client;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v33+F0]");
																				smartFoxClient14.AddEventListener((string)0, eventListenerDelegate14);
																				smartFox = client;
																				object obj32 = obj3;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v34+B8]");
																				object obj33 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																				eventListenerDelegate15..ctor(this, (IntPtr)obj4);
																				bool flag20 = client == null;
																				obj = 0;
																				flag = (byte)(int)obj4 != 0;
																				smartFoxClient2 = (SmartFoxClient)(object)this;
																				if (!flag20)
																				{
																					obj4 = (nint)0 + (nint)3984;
																					SmartFoxClient smartFoxClient15 = client;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v35+F8]");
																					smartFoxClient15.AddEventListener((string)0, eventListenerDelegate15);
																					smartFox = client;
																					object obj34 = obj3;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v36+B8]");
																					object obj35 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																					eventListenerDelegate16..ctor(this, (IntPtr)obj4);
																					bool flag21 = client == null;
																					obj = 0;
																					flag = (byte)(int)obj4 != 0;
																					smartFoxClient2 = (SmartFoxClient)(object)this;
																					if (!flag21)
																					{
																						obj4 = (nint)0 + (nint)3992;
																						SmartFoxClient smartFoxClient16 = client;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v37+98]");
																						smartFoxClient16.AddEventListener((string)0, eventListenerDelegate16);
																						smartFox = client;
																						object obj36 = obj3;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v38+B8]");
																						object obj37 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																						eventListenerDelegate17..ctor(this, (IntPtr)obj4);
																						bool flag22 = client == null;
																						obj = 0;
																						flag = (byte)(int)obj4 != 0;
																						smartFoxClient2 = (SmartFoxClient)(object)this;
																						if (!flag22)
																						{
																							obj4 = (nint)0 + (nint)4000;
																							SmartFoxClient smartFoxClient17 = client;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v39+A0]");
																							smartFoxClient17.AddEventListener((string)0, eventListenerDelegate17);
																							smartFox = client;
																							object obj38 = obj3;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v40+B8]");
																							object obj39 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																							eventListenerDelegate18..ctor(this, (IntPtr)obj4);
																							bool flag23 = client == null;
																							obj = 0;
																							flag = (byte)(int)obj4 != 0;
																							smartFoxClient2 = (SmartFoxClient)(object)this;
																							if (!flag23)
																							{
																								obj4 = (nint)0 + (nint)3968;
																								SmartFoxClient smartFoxClient18 = client;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v41+E8]");
																								smartFoxClient18.AddEventListener((string)0, eventListenerDelegate18);
																								smartFox = client;
																								object obj40 = obj3;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v42+B8]");
																								object obj41 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								eventListenerDelegate19..ctor(this, (IntPtr)obj4);
																								bool flag24 = client == null;
																								obj = 0;
																								flag = (byte)(int)obj4 != 0;
																								smartFoxClient2 = (SmartFoxClient)(object)this;
																								if (!flag24)
																								{
																									obj4 = (nint)0 + (nint)3856;
																									SmartFoxClient smartFoxClient19 = client;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v43+E0]");
																									smartFoxClient19.AddEventListener((string)0, eventListenerDelegate19);
																									smartFox = client;
																									object obj42 = obj3;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v44+B8]");
																									object obj43 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																									eventListenerDelegate20..ctor(this, (IntPtr)obj4);
																									bool flag25 = client == null;
																									obj = 0;
																									flag = (byte)(int)obj4 != 0;
																									smartFoxClient2 = (SmartFoxClient)(object)this;
																									if (!flag25)
																									{
																										SmartFoxClient smartFoxClient20 = client;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v45+C8]");
																										smartFoxClient20.AddEventListener((string)0, eventListenerDelegate20);
																										smartFox = client;
																										object obj44 = obj3;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v46+B8]");
																										object obj45 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																										eventListenerDelegate21..ctor(this, (IntPtr)obj4);
																										bool flag26 = client == null;
																										obj = 0;
																										flag = (byte)(int)obj4 != 0;
																										smartFoxClient2 = (SmartFoxClient)(object)this;
																										if (!flag26)
																										{
																											SmartFoxClient smartFoxClient21 = client;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v47+C0]");
																											smartFoxClient21.AddEventListener((string)0, eventListenerDelegate21);
																											return;
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			bool flag27 = (nint)smartFoxClient2 != 1;
			NullReferenceException ex2 = ex;
			if (flag27)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj46 = typeof(DataRelation) + 3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj47 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
			if (obj49 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
			object obj50 = obj48;
			smartFoxClient2 = (SmartFoxClient)(139026432 + 4064);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			ex2 = ex3;
			flag = false;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private static SmartFoxClient GetClient()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0100: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8336]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 744;
		RuntimePlatform platform = Application.platform;
		bool flag2 = platform == RuntimePlatform.WebGLPlayer;
		object obj7 = obj6;
		if (flag2)
		{
			goto IL_00c2;
		}
		goto IL_0201;
		IL_00c2:
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ServerEnvironment environment = Config.Environment;
		bool flag4 = EnvironmentExtensions.IsDevelopment(environment);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SmartFoxClient smartFoxClient = default(SmartFoxClient);
		if (flag4)
		{
			smartFoxClient..ctor(UseWebSocket.WS_BIN);
			return smartFoxClient;
		}
		smartFoxClient..ctor(UseWebSocket.WSS_BIN);
		return smartFoxClient;
		IL_0201:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SmartFoxClient smartFoxClient2 = default(SmartFoxClient);
		smartFoxClient2..ctor();
		return smartFoxClient2;
		IL_007d:
		obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 744;
		RuntimePlatform platform2 = Application.platform;
		bool flag5 = platform2 != RuntimePlatform.WebGLPlayer;
		obj7 = obj6;
		if (!flag5)
		{
			goto IL_00c2;
		}
		goto IL_0201;
	}

	public static void SwitchToOffline()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(MemberAchievementClanFeedData) + 3256;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineSmartFoxClient offlineSmartFoxClient = default(OfflineSmartFoxClient);
		offlineSmartFoxClient..ctor(currentGame);
		ConfigureOffline(offlineSmartFoxClient);
	}

	public static void GoToTutorial(TutorialType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineSmartFoxClient offlineSmartFoxClient = default(OfflineSmartFoxClient);
		offlineSmartFoxClient..ctor(type);
		ConfigureOffline(offlineSmartFoxClient);
	}

	public static void GoToReplay(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineSmartFoxClient offlineSmartFoxClient = default(OfflineSmartFoxClient);
		offlineSmartFoxClient..ctor(gameReplay);
		ConfigureOffline(offlineSmartFoxClient);
	}

	private static void ConfigureOffline(SmartFoxClient offlineClient)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_022e: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02da: Expected O, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_035a: Expected O, but got I
		//IL_03b4: Expected O, but got I4
		//IL_0431: Expected O, but got I
		//IL_0441: Expected O, but got I
		//IL_0451: Expected O, but got I
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I4
		//IL_0560: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0580: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_0627: Expected O, but got I4
		//IL_069c: Expected O, but got I
		//IL_06ac: Expected O, but got I
		//IL_06bc: Expected O, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_0717: Expected O, but got I
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_0785: Expected O, but got I4
		//IL_084a: Expected O, but got I
		//IL_085a: Expected O, but got I
		//IL_086a: Expected O, but got I
		//IL_08a1: Expected O, but got I4
		//IL_08b9: Expected O, but got I
		//IL_08f7: Expected O, but got I4
		//IL_090d: Expected O, but got I
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected O, but got Unknown
		//IL_080f: Expected O, but got I4
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected O, but got Unknown
		//IL_0aed: Expected O, but got I4
		//IL_0987: Expected O, but got I
		//IL_099d: Expected O, but got I
		//IL_09d9: Expected O, but got I4
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a3a: Expected O, but got I
		//IL_0a4a: Expected O, but got I
		//IL_0a7f: Expected O, but got I
		//IL_0a8f: Expected O, but got I
		//IL_0a9f: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8392]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v72+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj3 = obj5;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00d4;
		}
		goto IL_01c5;
		IL_0aa9:
		_ = 1;
		object obj12 = typeof(Queue<string>) + 856;
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v40+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		object obj16 = obj13;
		object obj17 = obj12;
		if (obj15 != null)
		{
			goto IL_097b;
		}
		goto IL_0b0b;
		IL_08ee:
		object obj18 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CD]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 == null)
		{
			goto IL_0aa9;
		}
		obj12 = typeof(Queue<string>) + 856;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v40+E4]");
		bool flag5 = (nint)0 == 0;
		obj16 = obj13;
		obj17 = obj12;
		if (!flag5)
		{
			goto IL_097b;
		}
		goto IL_0b0b;
		IL_08cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj21;
		object obj20 = obj21;
		SFSConfig sFSConfig2;
		SFSConfig sFSConfig = sFSConfig2;
		goto IL_08ee;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v72+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00d4;
		}
		goto IL_01c5;
		IL_01c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj8 = obj11;
		obj3 = obj5;
		goto IL_01f3;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj22 = default(object);
		bool flag7 = obj22 == null;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01f3;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v3+20]");
		((SmartFox)0).Disconnect();
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v5+E4]");
		bool flag8 = (nint)0 == 0;
		object obj25 = !flag8;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj26 = typeof(RegisteredWaitHandle) + 1960;
		object obj28 = default(object);
		object obj27 = obj28 + 32;
		obj27 = offlineClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSConfig sFSConfig3 = default(SFSConfig);
		sFSConfig3..ctor();
		object obj29 = "not" + 1032;
		object obj30 = typeof(List<AdaptivePerformanceScaler>) + 1160;
		object obj31 = (nint)0 + (nint)2520;
		object obj32 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2080;
		object obj33 = sFSConfig3 + 16;
		obj33 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = default(object);
		obj34..ctor();
		_ = 0;
		object obj35 = (nint)0 + (nint)2528;
		object obj36 = obj35;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag9 = list._size < items.Length;
		object obj37 = !flag9;
		if (obj37 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj38 = items + list._size;
			object obj39 = obj38 + 32;
			obj39 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj40 = obj34;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v7+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v41+C0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v42+70]");
			obj20 = 0;
			list.AddWithResize(obj34);
			object obj40 = obj34;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj43 = default(object);
		obj43..ctor();
		_ = 1;
		object obj44 = obj35;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag10 = list._size < items2.Length;
		object obj45 = !flag10;
		if (obj45 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj46 = items2 + list._size;
			object obj47 = obj46 + 32;
			obj47 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj48 = obj43;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v10+20]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v38+C0]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v39+70]");
			obj20 = 0;
			list.AddWithResize(obj43);
			object obj48 = obj43;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = default(object);
		obj51..ctor();
		_ = 2;
		object obj52 = obj35;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		object obj53 = typeof(List<AdaptivePerformanceScaler>) + 3136;
		bool flag11 = list._size < items3.Length;
		object obj54 = !flag11;
		if (obj54 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj55 = items3 + list._size;
			object obj56 = obj55 + 32;
			obj56 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v13+20]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v35+C0]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v36+70]");
			obj20 = 0;
			list.AddWithResize(obj51);
		}
		object obj59 = sFSConfig3 + 64;
		obj59 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj60 = (nint)0 + (nint)424;
		object obj61 = obj60;
		int version4 = list2._version + 1;
		list2._version = version4;
		object[] items4 = list2._items;
		obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		bool flag12 = list2._size < items4.Length;
		object obj62 = !flag12;
		if (obj62 == null)
		{
			int size4 = list2._size + 1;
			list2._size = size4;
			object obj63 = items4 + list2._size;
			object obj64 = obj63 + 32;
			obj64 = sFSConfig3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj65 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v51+E4]");
			bool flag13 = (nint)0 == 0;
			object obj66 = !flag13;
			sFSConfig = sFSConfig3;
			if (obj66 == null)
			{
				obj21 = obj20;
				sFSConfig2 = sFSConfig3;
				goto IL_08cf;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v17+20]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v30+C0]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v31+70]");
			obj21 = 0;
			list2.AddWithResize((object)sFSConfig3);
			object obj65 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v51+E4]");
			bool flag14 = (nint)0 == 0;
			object obj69 = !flag14;
			sFSConfig2 = sFSConfig3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v31+70]");
			obj20 = 0;
			sFSConfig = sFSConfig3;
			if (obj69 == null)
			{
				goto IL_08cf;
			}
		}
		goto IL_08ee;
		IL_0b0b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj14;
		obj12 = obj17;
		goto IL_097b;
		IL_097b:
		object obj70 = (nint)0 + (nint)2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v40+B8]");
		object obj71 = (nint)0 + (nint)8;
		obj71 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj72 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v44+E4]");
		bool flag15 = (nint)0 == 0;
		object obj73 = !flag15;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj74 = typeof(RegisteredWaitHandle) + 1880;
		SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
		sfsConnectionManager.GoOffline();
		object obj75 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v25+B8]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v26+60]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v26+60]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v27+18]");
			object obj78 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v27+40]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v27+28]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v264 @ X2_v6 (should have been resolved before IL gen)");
			goto IL_0aa9;
		}
	}

	public static void BackFromOffline()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0217: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0289: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_04b0: Expected O, but got I
		//IL_04c0: Expected O, but got I
		//IL_04d0: Expected O, but got I
		//IL_02bd: Expected O, but got I
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0408: Expected O, but got I4
		//IL_0455: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_0493: Expected O, but got I4
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8393]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj3 = obj5;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00d4;
		}
		goto IL_01c5;
		IL_034e:
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v7+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+68]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+68]");
		if ((nint)0 != 0)
		{
			object obj16 = 0;
			goto IL_04a0;
		}
		return;
		IL_04a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v4+18]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v4+40]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v4+28]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v257 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_01f3:
		obj13 = typeof(RegisteredWaitHandle) + 1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v3+20]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			object obj21 = typeof(MemberAchievementClanFeedData) + 3256;
			object obj22 = obj21;
			object obj23 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v6+130]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+130]");
			bool flag4 = num < 0;
			object obj24 = !flag4;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v6+C8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+130]");
				object obj26 = num2 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X9_v8-8]");
				if (0 == (nint)obj22)
				{
					object obj27 = typeof(RegisteredWaitHandle) + 3136;
					object obj28 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v8+E4]");
					if ((nint)0 != 0)
					{
						Scenes previousScene = ScreenManager.PreviousScene;
						if (previousScene == Scenes.Tutorial)
						{
							goto IL_034e;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Scenes previousScene2 = ScreenManager.PreviousScene;
						if (previousScene2 == Scenes.Tutorial)
						{
							goto IL_034e;
						}
					}
					object obj29 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v10+E4]");
					bool flag5 = (nint)0 == 0;
					object obj30 = !flag5;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SFS sFS = default(SFS);
					sFS.CreateNewClient();
					object obj31 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v17+B8]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18+68]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18+68]");
					if ((nint)0 != 0)
					{
						object obj16 = 1;
						goto IL_04a0;
					}
					return;
				}
			}
		}
		goto IL_034e;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00d4;
		}
		goto IL_01c5;
		IL_01c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj8 = obj11;
		obj3 = obj5;
		goto IL_01f3;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj33 = default(object);
		bool flag7 = obj33 == null;
		object obj34 = !flag7;
		if (obj34 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01f3;
	}

	public static void Connect()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_020c: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_0275: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8394]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01ce:
		object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SFSConfig currentSFS = Config.CurrentSFS;
		SFSConfig currentSFS2 = Config.CurrentSFS;
		int platformPort = currentSFS2.PlatformPort;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+20]");
		((SmartFox)0).Connect(currentSFS.<IP>k__BackingField, platformPort);
		return;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj15 = default(object);
		bool flag5 = obj15 == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ce;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag6)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
	}

	public static void SwitchGame(Games game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_045d: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		//IL_01e3: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_038f: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_03d4: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_03f4: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I4
		//IL_02f6: Expected O, but got I
		//IL_032a: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Preferences.CurrentGame = game;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (Config.Validate())
			{
				goto IL_0092;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = Config.Validate();
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				goto IL_0092;
			}
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			Preferences.CurrentGame = currentGame;
			return;
		}
		goto IL_03fe;
		IL_0123:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag4 = obj8 == null;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_023c;
		IL_0092:
		object obj10 = 152993792;
		object obj11 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8391]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			object obj13 = (nint)0 + (nint)2152;
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v35+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = obj13;
			if (!flag5)
			{
				goto IL_0123;
			}
		}
		else
		{
			_ = 1;
			object obj13 = (nint)0 + (nint)2152;
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v35+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			object obj15 = obj13;
			if (obj16 != null)
			{
				goto IL_0123;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_023c;
		IL_023c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+20]");
			if (((SmartFox)0).IsConnected)
			{
				object obj17 = typeof(Queue<string>) + 856;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v24+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj20 = (nint)0 + (nint)2216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v28+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string serverID = Config.ServerID;
				SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
				sfsConnectionManager.SwitchServerAndReloadScene(serverID);
				return;
			}
		}
		object obj23 = typeof(RegisteredWaitHandle) + 1880;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v11+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12+70]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12+70]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+18]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+40]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+28]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v147 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_03fe;
		}
		return;
		IL_03fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.CurrentGame = currentGame;
	}

	public static void SwitchServer(string serverID)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01dc: Expected O, but got I
		//IL_0206: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0136: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_024f: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E833A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj11 = typeof(RegisteredWaitHandle) + 1880;
		_ = 1;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID2 = default(string);
		Config.ServerID = serverID2;
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+F0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+F0]");
		if ((nint)0 != 0)
		{
			object obj17 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v25+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string serverID3 = Config.ServerID;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ X19_v2+18] (should have been resolved before IL gen)");
		}
		Disconnect();
	}

	public static void Disconnect()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_016b: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_0233: Expected O, but got I
		//IL_02e4: Expected O, but got I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_01fa: Expected O, but got I
		//IL_0424: Expected O, but got I4
		//IL_0341: Expected O, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0485: Expected O, but got I
		//IL_0495: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_04ca: Expected O, but got I
		//IL_04da: Expected O, but got I
		//IL_04ea: Expected O, but got I
		//IL_0525: Expected O, but got I4
		//IL_03e7: Expected O, but got I4
		//IL_055d: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8396]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v54+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v54+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_054c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v17+20]");
		((SmartFox)0).Disconnect();
		return;
		IL_03c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_054c;
		}
		goto IL_055e;
		IL_027d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = default(object);
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_030b;
		}
		goto IL_055e;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = default(object);
		bool flag5 = obj12 == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_0140;
		}
		goto IL_055e;
		IL_0140:
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+31]");
		object obj14 = (nint)0 & (nint)1;
		bool flag6 = obj14 == null;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			object obj16 = typeof(Queue<string>) + 856;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v49+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = (nint)0 + (nint)2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
			sfsConnectionManager.OnLogout();
			BaseEvent baseEvent = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8391]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				goto IL_027d;
			}
		}
		else
		{
			_ = 1;
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v34+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 != null)
			{
				goto IL_027d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_030b;
		IL_055e:
		throw new NullReferenceException();
		IL_030b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v7+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v7+20]");
			bool isConnected = ((SmartFox)0).IsConnected;
			bool flag9 = !isConnected;
			BaseEvent baseEvent = null;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
				object obj23 = (nint)0 & (nint)1;
				if (obj23 != null)
				{
					object obj24 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+E4]");
					if ((nint)0 != 0)
					{
						goto IL_03c3;
					}
				}
				else
				{
					_ = 1;
					object obj24 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+E4]");
					bool flag10 = (nint)0 == 0;
					object obj25 = !flag10;
					if (obj25 != null)
					{
						goto IL_03c3;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				goto IL_054c;
			}
		}
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v10+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj28 = typeof(RegisteredWaitHandle) + 1880;
		SFS sFS = default(SFS);
		sFS.CreateNewClient();
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v10+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v11+78]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v11+78]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v12+18]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v12+40]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v12+28]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public static void DiscardClient()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_012f: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E833B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2152;
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
			object obj4 = (nint)0 + (nint)2152;
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
		SFS sFS = default(SFS);
		bool flag3 = (object)sFS == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		sFS.CreateNewClient();
	}

	public static void ReestablishConnection()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0130: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E833C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2152;
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
			object obj4 = (nint)0 + (nint)2152;
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
		SFS sFS = default(SFS);
		bool flag3 = (object)sFS == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		sFS.SFS_OnConnectionLost(null);
	}

	public static void ResetEnvironment()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0242: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_02a9: Expected I4, but got O
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0409: Expected O, but got I
		//IL_0419: Expected O, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I4
		//IL_044e: Expected O, but got I
		//IL_045e: Expected O, but got I
		//IL_046e: Expected O, but got I
		//IL_031e: Expected O, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_03a8: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		object obj2 = typeof(RegisteredWaitHandle) + 40;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
		UserInfo.ClearAllCachedModels();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		RemoteAssetsCacher.ResetEnvironment();
		OfflineUserInfo.DiscardGame();
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
		TabsUI.ClearLastTabs();
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		SfsTournamentConnector.OnLogout();
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			GiftBombManager.OnLogout();
			object obj16 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01ca;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			GiftBombManager.OnLogout();
			object obj16 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_01ca;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isPlaying = Application.isPlaying;
		bool flag6 = !isPlaying;
		bool flag7 = isPlaying;
		if (!flag6)
		{
			goto IL_0289;
		}
		goto IL_03d8;
		IL_03d8:
		object obj18 = typeof(RegisteredWaitHandle) + 1880;
		ForcedDisconnect();
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v9+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10+20]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v11+18]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v11+40]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v11+28]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X2_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0289:
		User mySelf = MySelf;
		bool flag8 = mySelf == null;
		flag7 = (byte)(int)mySelf != 0;
		if (!flag8)
		{
			object obj25 = typeof(Queue<string>) + 720;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v20+E4]");
			bool flag9 = (nint)0 == 0;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj28 = (nint)0 + (nint)1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ChatHandler chatHandler = default(ChatHandler);
			chatHandler.Clear();
			User mySelf2 = MySelf;
			if (SFSKammelnaUserExtensions.IsSocialConnected(mySelf2))
			{
				object obj29 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v27+E4]");
				bool flag10 = (nint)0 == 0;
				object obj31 = !flag10;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SocialUtilities.ClearSessions();
				flag7 = false;
			}
		}
		goto IL_03d8;
		IL_01ca:
		isPlaying = Application.isPlaying;
		bool flag11 = !isPlaying;
		object obj32 = !flag11;
		if (obj32 != null)
		{
			goto IL_0289;
		}
		flag7 = isPlaying;
		goto IL_03d8;
	}

	public static void ForcedDisconnect()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_01fb: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_01a7: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8397]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_01b1;
		}
		object obj3 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj4 = (nint)0 & (nint)1;
		bool flag = obj4 == null;
		object obj5 = obj3;
		if (!flag)
		{
			goto IL_008b;
		}
		goto IL_0211;
		IL_01b1:
		_ = 1;
		obj3 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		obj5 = obj3;
		if (obj7 != null)
		{
			goto IL_008b;
		}
		goto IL_0211;
		IL_008b:
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = obj8;
		if (!flag3)
		{
			goto IL_00cc;
		}
		goto IL_0263;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00db;
		IL_00db:
		object obj11 = typeof(RegisteredWaitHandle) + 1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v19+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v19+20]");
			((SmartFox)0).Disconnect();
		}
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+80]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+80]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+18]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+40]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+28]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_01b1;
		}
		return;
		IL_0263:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj18 = default(object);
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00db;
		IL_0211:
		_ = 1;
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		obj10 = obj8;
		if (obj20 != null)
		{
			goto IL_00cc;
		}
		goto IL_0263;
	}

	public static void DisconnectWithoutRetrying()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_015c: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			object obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			((SmartFox)0).Disconnect();
		}
	}

	private static void ReconnectIfNeeded()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_0170: Expected O, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_0230: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E833E]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+30]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null || !Authentication.CanLogin())
		{
			return;
		}
		object obj10 = typeof(RegisteredWaitHandle) + 1880;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+110]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 == null)
		{
			_ = 1;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SFS sFS = default(SFS);
			sFS.CreateNewClient();
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj16 = default(object);
		bool flag5 = obj16 == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void FixedUpdate()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		SmartFoxClient smartFoxClient = client;
		nint num = (nint)smartFoxClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<SmartFoxClient>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<SmartFoxClient>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		//IL_001a: Expected O, but got I4
		bool flag = !pauseStatus;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		User mySelf = client.MySelf;
		if (mySelf != null)
		{
			Room lastJoinedRoom = client.LastJoinedRoom;
			bool flag2 = lastJoinedRoom == null;
			mySelf = (User)lastJoinedRoom;
			if (!flag2)
			{
				return;
			}
		}
		ReconnectIfNeeded();
	}

	private void SFS_OnLogout(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 1880;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v51 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private unsafe void SFS_OnSFSConnection(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_06e4: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_070a: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_009f: Expected I, but got O
		//IL_00af: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_01ed: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029a: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_0340: Expected O, but got I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_036f: Expected O, but got Ref
		//IL_0387: Expected O, but got I
		//IL_038f: Expected O, but got Ref
		//IL_0554: Expected O, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_059a: Expected O, but got I4
		//IL_02e5: Expected O, but got I
		//IL_0485: Expected O, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_04d8: Expected O, but got I
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_050a: Expected O, but got I4
		//IL_0512: Expected O, but got Ref
		//IL_052a: Expected O, but got I
		//IL_0532: Expected O, but got Ref
		//IL_065a: Expected O, but got I
		//IL_066a: Expected O, but got I
		//IL_03d2: Expected O, but got I
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+B8]");
		object obj6 = 0;
		object obj7;
		object obj14 = default(object);
		object obj13;
		if (evt != null)
		{
			IDictionary<string, object> dictionary = evt.Params;
			if (dictionary != null)
			{
				obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				object obj8 = "startPosition" + 1328;
				nint num = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v13 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v13 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v13 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v18-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj10 += 16;
					obj9--;
					if ((nint)obj9 != 1)
					{
						continue;
					}
					goto IL_012b;
				}
				object obj11 = num + obj10;
				object obj12 = obj11 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v46+8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X8_v46] (should have been resolved before IL gen)");
				if (obj14 != null)
				{
					goto IL_01ce;
				}
			}
		}
		goto IL_069a;
		IL_0548:
		object obj15 = (nint)0 + (nint)2000;
		object obj16 = obj15;
		object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v26+E4]");
		bool flag2 = (nint)0 == 0;
		object obj19 = !flag2;
		object obj20 = obj15;
		if (obj19 != null)
		{
			goto IL_0462;
		}
		goto IL_05b0;
		IL_06a8:
		throw new InvalidCastException();
		IL_0326:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v37+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v482 @ X0_v37] (should have been resolved before IL gen)");
		object obj23 = default(object);
		object obj22 = obj23 & 1;
		bool flag3 = obj22 == null;
		object obj25 = default(object);
		object obj24 = (object)(&obj25);
		object obj27;
		object obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v37+8]");
		object obj28 = 0;
		object obj29 = (object)(&obj25);
		object obj30 = obj27;
		if (!flag3)
		{
			goto IL_03a5;
		}
		goto IL_0548;
		IL_03a5:
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X22_v8+90]");
			obj26 = 0;
			object obj31 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X22_v8+90]");
			if (obj31 != null)
			{
				throw new InvalidCastException();
			}
		}
		object obj32 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		obj18 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v26+E4]");
		bool flag4 = (nint)0 == 0;
		obj16 = obj25;
		obj28 = obj21;
		obj29 = obj24;
		obj30 = obj26;
		obj20 = obj25;
		if (!flag4)
		{
			goto IL_0462;
		}
		goto IL_05b0;
		IL_0462:
		GameConfiguration currentGameConfiguration = Config.CurrentGameConfiguration;
		bool flag5 = currentGameConfiguration == null;
		object obj33 = !flag5;
		if (obj33 != null)
		{
			goto IL_05ed;
		}
		goto IL_069a;
		IL_05ed:
		if (currentGameConfiguration.<UseSSL>k__BackingField)
		{
			if (client != null)
			{
				client.InitCrypto();
				return;
			}
			goto IL_069a;
		}
		object obj34 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v23+B8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v24+E0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v24+E0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v408 @ X8_v25+18] (should have been resolved before IL gen)");
		}
		return;
		IL_05b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		currentGameConfiguration = Config.CurrentGameConfiguration;
		bool flag6 = currentGameConfiguration == null;
		obj16 = obj20;
		if (!flag6)
		{
			goto IL_05ed;
		}
		goto IL_069a;
		IL_069a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06a8;
		IL_012b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v41+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v347 @ X0_v41] (should have been resolved before IL gen)");
		bool flag7 = obj14 == null;
		object obj37 = !flag7;
		if (obj37 != null)
		{
			goto IL_01ce;
		}
		goto IL_069a;
		IL_01ce:
		object obj38 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X22_v8+28]");
		object obj39 = 0;
		object obj40 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v15+40]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X1_v7+40]");
		if (num2 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			object obj42 = default(object);
			object obj41 = obj42 & 1;
			if (obj41 != null)
			{
				IDictionary<string, object> dictionary2 = evt.Params;
				if (dictionary2 != null)
				{
					obj27 = "destinationTimeZone" + 2712;
					nint num3 = (nint)dictionary2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v20 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v20 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0326;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v20 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
					object obj44 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X10_v13-8]");
						if (0 == (nint)obj7)
						{
							break;
						}
						obj44 += 16;
						obj43--;
						if ((nint)obj43 != 1)
						{
							continue;
						}
						goto IL_0326;
					}
					object obj45 = obj44 + 7;
					object obj46 = num3 + obj45;
					object obj47 = obj46 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v43+8]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X8_v43] (should have been resolved before IL gen)");
					object obj49 = default(object);
					object obj48 = obj49 & 1;
					bool flag8 = obj48 == null;
					object obj50 = !flag8;
					obj24 = (object)(&obj25);
					obj26 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v43+8]");
					obj28 = 0;
					obj29 = (object)(&obj25);
					obj30 = obj27;
					if (obj50 != null)
					{
						goto IL_03a5;
					}
					goto IL_0548;
				}
				goto IL_069a;
			}
			CreateNewClient();
			return;
		}
		goto IL_06a8;
	}

	private void InitCrypto(bool success, string errorMessage)
	{
		client.InitCrypto();
	}

	private void SFS_OnCryptoInit(BaseEvent evt)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0225: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_016a: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_029b: Expected I, but got O
		//IL_02ab: Expected O, but got I
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_047a: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0450: Expected O, but got I4
		//IL_03ab: Expected I, but got O
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		object obj;
		object obj5 = default(object);
		object obj9 = default(object);
		object obj8;
		if (evt != null)
		{
			IDictionary<string, object> dictionary = evt.Params;
			if (dictionary != null)
			{
				obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				object obj2 = "startPosition" + 1328;
				nint num = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v7 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v7 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ee;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v7 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v17-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 = obj4 + 16;
					obj3--;
					bool flag = (nint)obj3 != 1;
					obj4 = obj5;
					if (flag)
					{
						continue;
					}
					goto IL_00ee;
				}
				object obj6 = num + obj4;
				object obj7 = obj6 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v30+8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X8_v30] (should have been resolved before IL gen)");
				bool flag2 = obj9 == null;
				obj5 = obj4;
				if (!flag2)
				{
					goto IL_0199;
				}
			}
		}
		goto IL_0487;
		IL_037e:
		object obj10 = default(object);
		bool flag3 = obj10 == null;
		object obj11 = obj10;
		nint num2;
		bool flag5;
		bool flag6;
		object obj12;
		if (!flag3)
		{
			num2 = (nint)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X23_v4+90]");
			bool flag4 = obj10 == null;
			obj11 = obj10;
			if (!flag4)
			{
				InvalidCastException ex = new InvalidCastException();
				flag5 = flag6;
				obj12 = obj5;
				goto IL_03f5;
			}
		}
		goto IL_050b;
		IL_046e:
		object obj13 = (nint)0 + (nint)2000;
		obj11 = obj13;
		goto IL_050b;
		IL_050b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ X22_v3+18] (should have been resolved before IL gen)");
		return;
		IL_03f5:
		object obj14 = obj12 + 7;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ X8_v24] (should have been resolved before IL gen)");
		object obj18 = default(object);
		object obj17 = obj18 & 1;
		bool flag7 = obj17 == null;
		object obj19 = !flag7;
		flag6 = flag5;
		obj5 = obj12;
		if (obj19 != null)
		{
			goto IL_037e;
		}
		goto IL_046e;
		IL_0495:
		throw new InvalidCastException();
		IL_0487:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0495;
		IL_00ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v25+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v206 @ X0_v25] (should have been resolved before IL gen)");
		bool flag8 = obj9 == null;
		object obj20 = !flag8;
		if (obj20 != null)
		{
			goto IL_0199;
		}
		goto IL_0487;
		IL_0199:
		object obj21 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X23_v4+28]");
		object obj22 = 0;
		object obj23 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v9+40]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v6+40]");
		flag6 = num3 != 0;
		if (!flag6)
		{
			object obj24 = typeof(RegisteredWaitHandle) + 1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v11+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12+E0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12+E0]");
			if ((nint)0 == 0)
			{
				return;
			}
			IDictionary<string, object> dictionary2 = evt.Params;
			if (dictionary2 != null)
			{
				object obj28 = "destinationTimeZone" + 2712;
				num2 = (nint)dictionary2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_033f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				obj12 = (nint)0 + (nint)8;
				flag5 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X10_v7-8]");
					bool flag9 = 0 == (nint)obj;
					InvalidCastException ex = (InvalidCastException)dictionary2;
					if (flag9)
					{
						break;
					}
					obj5 = obj12 + 16;
					obj29--;
					flag6 = (nint)obj29 != 1;
					flag5 = flag6;
					obj12 = obj5;
					if (flag6)
					{
						continue;
					}
					goto IL_033f;
				}
				goto IL_03f5;
			}
			goto IL_0487;
		}
		goto IL_0495;
		IL_033f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v22] (should have been resolved before IL gen)");
		object obj31 = default(object);
		object obj30 = obj31 & 1;
		if (obj30 != null)
		{
			goto IL_037e;
		}
		goto IL_046e;
	}

	private void SFS_OnConnectionLost(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03ea: Expected O, but got I
		//IL_03fa: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00e6: Expected I, but got O
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0129: Expected O, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01ee: Expected I, but got O
		//IL_01fe: Expected O, but got I
		//IL_0294: Expected O, but got I
		//IL_02b8: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_0387: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0314: Expected O, but got I
		//IL_033d: Expected O, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass294_0 <>c__DisplayClass294_ = default(<>c__DisplayClass294_0);
		<>c__DisplayClass294_..ctor();
		object obj2 = <>c__DisplayClass294_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (intentionalDisconnect)
		{
			intentionalDisconnect = false;
			<>c__DisplayClass294_.shouldRelogin = switchingServer;
			bool flag = client == null;
			SFS sFS = this;
			if (!flag)
			{
				client.RemoveAllEventListeners();
				sFS = null;
			}
			object obj3 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)1168;
			Action action = default(Action);
			action..ctor(<>c__DisplayClass294_, (IntPtr)obj4);
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForMainThread(action);
			return;
		}
		CreateNewClient();
		object obj8 = (nint)0 + (nint)2000;
		object obj9 = obj8;
		object obj17;
		object obj19;
		if (evt != null)
		{
			IDictionary<string, object> dictionary = evt.Params;
			if (dictionary != null)
			{
				IDictionary<string, object> dictionary2 = evt.Params;
				object obj10 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				object obj11 = "placementId" + 2520;
				nint num = (nint)dictionary2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_027a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v7-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj13 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_027a;
				}
				object obj14 = obj13 + 7;
				object obj15 = num + obj14;
				object obj16 = obj15 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v25+8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v302 @ X8_v25] (should have been resolved before IL gen)");
				object obj18 = default(object);
				bool flag3 = obj18 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v25+8]");
				obj19 = 0;
				if (!flag3)
				{
					goto IL_034b;
				}
			}
		}
		goto IL_03be;
		IL_03be:
		object obj20 = typeof(RegisteredWaitHandle) + 1880;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v11+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v12+E8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v12+E8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X8_v13+18] (should have been resolved before IL gen)");
		}
		return;
		IL_027a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v22+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v22] (should have been resolved before IL gen)");
		object obj24 = default(object);
		bool flag4 = obj24 == null;
		object obj25 = !flag4;
		if (obj25 != null)
		{
			goto IL_034b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v22+8]");
		obj19 = 0;
		goto IL_03be;
		IL_034b:
		object obj26 = default(object);
		bool flag5 = obj26 == null;
		obj19 = obj17;
		obj9 = obj26;
		if (!flag5)
		{
			object obj27 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v21+90]");
			bool flag6 = obj26 != null;
			obj19 = obj17;
			obj9 = obj26;
			if (flag6)
			{
				throw new InvalidCastException();
			}
		}
		goto IL_03be;
	}

	private static void Relogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_0093: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_015a: Expected O, but got I
		object obj = typeof(Queue<string>) + 856;
		object obj2 = (nint)0 + (nint)2216;
		bool flag = Authentication.CanLogin();
		object obj3 = obj;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
			sfsConnectionManager.LoginIfNotSpamming();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SfsConnectionManager sfsConnectionManager2 = default(SfsConnectionManager);
		sfsConnectionManager2.OnLogout();
		object obj6 = typeof(RegisteredWaitHandle) + 1880;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+88]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+88]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v84 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	private void SFS_OnLogin(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_00bc: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+B8]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+8]");
		Actions.SafeInvoke((Action<object>)0, evt);
		BindSubscriptionStatus();
		SetupSubscriptionExpiryCallback();
	}

	private void SFS_OnLoginError(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00a7: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_005d: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3072;
		object obj2 = typeof(RegisteredWaitHandle) + 1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LoginError loginError = default(LoginError);
		loginError..ctor(evt);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void SFS_OnExtensionResponse(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_07e6: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_080c: Expected O, but got I
		//IL_0845: Expected O, but got I4
		//IL_0853: Expected O, but got I4
		//IL_086d: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_012e: Expected O, but got I8
		//IL_0148: Expected O, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0628: Expected O, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0467: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_065d: Expected O, but got I
		//IL_066d: Expected O, but got I
		//IL_067d: Expected O, but got I
		//IL_06aa: Expected O, but got I
		//IL_06ba: Expected O, but got I
		//IL_06dc: Expected O, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_057b: Expected O, but got I
		//IL_058b: Expected O, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_036a: Expected I4, but got I8
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_070c: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_0912: Expected O, but got I
		//IL_091a: Expected I, but got O
		//IL_092b: Expected I, but got O
		//IL_0949: Expected O, but got I
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0223: Expected O, but got I4
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_077f: Expected O, but got I4
		//IL_073c: Expected O, but got I
		//IL_08a0: Expected O, but got I
		//IL_08b0: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+B8]");
		object obj6 = 0;
		string command = SFSExtensions.GetCommand(evt);
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(command);
		bool flag2 = (int)num < 1328665827;
		object obj7 = !flag2;
		object obj8 = num - 1328665827;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		object obj10 = obj7 & obj9;
		Action<bool> action;
		Action<bool> action3;
		object obj41;
		nint num2;
		if (obj10 == null)
		{
			if (num != 216856171)
			{
				if (num != 1240321477)
				{
					if (num == 1328665827)
					{
						object obj11 = "java.io.FileOutputStream" + 3664;
						if (command == (string)obj11)
						{
							object serverID = ", stale={0}" + 3424;
							SwitchServer((string)serverID);
						}
					}
				}
				else
				{
					object obj12 = "setMimeType" + 1712;
					if (command == (string)obj12)
					{
						goto IL_0338;
					}
				}
			}
			else
			{
				object obj13 = "placementId" + 3000;
				if (command == (string)obj13)
				{
					ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
					object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v78+E4]");
					bool flag4 = (nint)0 == 0;
					object obj16 = !flag4;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Config.SetServerExtraConfigs(responseParams);
				}
			}
		}
		else
		{
			bool flag5 = (int)num < 2729695477L;
			object obj17 = !flag5;
			object obj18 = (int)num - 2729695477L;
			bool flag6 = obj18 == null;
			object obj19 = !flag6;
			object obj20 = obj17 & obj19;
			if (obj20 == null)
			{
				if ((int)num != 2722888107L)
				{
					if ((int)num == 2729695477L)
					{
						object obj21 = "alignContent" + 528;
						if (command == (string)obj21)
						{
							object obj22 = typeof(Queue<string>) + 856;
							object obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v57+E4]");
							bool flag7 = (nint)0 == 0;
							object obj24 = !flag7;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj25 = (nint)0 + (nint)2216;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
							sfsConnectionManager.ForceDisconnectAndSwitchServer();
						}
					}
				}
				else
				{
					object obj26 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3080;
					if (command == (string)obj26)
					{
						ISFSObject responseParams2 = SFSExtensions.GetResponseParams(evt);
						((SFS)responseParams2).SFS_OnPublicMessage(responseParams2);
					}
				}
			}
			else if ((int)num != 3975081856L)
			{
				if ((int)num == 2895963265L)
				{
					object obj27 = "java.io.FileOutputStream" + 336;
					bool flag8 = command == (string)obj27;
					bool flag9 = !flag8;
					object obj28 = !flag9;
					if (obj28 != null)
					{
						goto IL_0338;
					}
				}
			}
			else
			{
				object obj29 = "m_StencilDeferredPS" + 256;
				string text = (string)obj29;
				if (command == (string)obj29)
				{
					object obj30 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
					object obj31 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v34+E4]");
					object obj32;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v34+B8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v37+38]");
						action = (Action<bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v37+38]");
						if ((nint)0 != 0)
						{
							goto IL_05b0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj31 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v34+B8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v37+38]");
						action = (Action<bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v37+38]");
						bool flag10 = (nint)0 == 0;
						object obj33 = !flag10;
						if (obj33 != null)
						{
							goto IL_05b0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v34+E4]");
					bool flag11 = (nint)0 == 0;
					object obj34 = !flag11;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj35 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v46+B8]");
						obj32 = 0;
					}
					object obj36 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj37 = (nint)0 + (nint)1080;
					num2 = (nint)obj37;
					Action<bool> action2 = default(Action<bool>);
					action2..ctor(obj32, (IntPtr)obj37);
					object obj38 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v42+B8]");
					object obj39 = (nint)0 + (nint)56;
					obj39 = action2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj40 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
					obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v32+E4]");
					bool flag12 = (nint)0 == 0;
					object obj42 = !flag12;
					action = action2;
					text = (string)(object)action2;
					action3 = action2;
					if (obj42 != null)
					{
						goto IL_0602;
					}
					goto IL_07a5;
				}
			}
		}
		goto IL_0610;
		IL_05b0:
		object obj43 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		obj41 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v32+E4]");
		bool flag13 = (nint)0 == 0;
		num2 = 0;
		action3 = action;
		if (!flag13)
		{
			goto IL_0602;
		}
		goto IL_07a5;
		IL_07a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action3;
		goto IL_0602;
		IL_0338:
		ISFSObject responseParams3 = SFSExtensions.GetResponseParams(evt);
		object varName = "rightCtrl" + 360;
		int id = SFSExtensions.Get(responseParams3, (string)varName, -1);
		Room roomById = client.GetRoomById(id);
		ISFSObject responseParams4 = SFSExtensions.GetResponseParams(evt);
		object varName2 = "destinationTimeZone" + 2696;
		object defaultValue = "UInt16" + 3176;
		string text2 = SFSExtensions.Get(responseParams4, (string)varName2, (string)defaultValue);
		object obj44 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v24+B8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v25+50]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v25+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X8_v26+18] (should have been resolved before IL gen)");
		}
		goto IL_0610;
		IL_0602:
		Config.LoadServersConfig(action);
		goto IL_0610;
		IL_0610:
		object obj47 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v12+B8]");
		object obj48 = 0;
		object obj49 = obj48;
		if (obj48 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v14+18]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v14+40]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v14+28]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v345 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	private unsafe void SFS_OnPingPong(BaseEvent evt)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0a59: Expected O, but got I
		//IL_0a88: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_024f: Expected O, but got I
		//IL_033a: Expected O, but got I4
		//IL_0378: Expected O, but got I
		//IL_038d: Expected O, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03d4: Expected O, but got I4
		//IL_02c9: Expected O, but got I4
		//IL_0ac9: Expected O, but got I4
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_045b: Expected O, but got I4
		//IL_0464: Expected O, but got I4
		//IL_047d: Expected O, but got I4
		//IL_0502: Expected O, but got I
		//IL_0aef: Expected O, but got I
		//IL_0b04: Expected O, but got I
		//IL_0b24: Expected O, but got I4
		//IL_0d13: Expected O, but got I
		//IL_0d2d: Expected O, but got I4
		//IL_052a: Expected O, but got I
		//IL_054c: Expected O, but got I
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_069d: Expected O, but got I
		//IL_0bad: Expected O, but got I
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05c7: Expected I, but got O
		//IL_05d7: Expected O, but got I
		//IL_0782: Expected O, but got I4
		//IL_0666: Expected O, but got I4
		//IL_0b66: Expected O, but got I
		//IL_0b8a: Expected O, but got I4
		//IL_0612: Expected O, but got I
		//IL_0806: Expected O, but got I
		//IL_081c: Expected O, but got I
		//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected O, but got Unknown
		//IL_0c04: Expected O, but got I
		//IL_0c1e: Expected O, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_08cd: Expected O, but got I4
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_088a: Expected O, but got I4
		//IL_0950: Expected O, but got I
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_09a9: Expected O, but got I4
		//IL_0c69: Expected O, but got Ref
		//IL_0c8a: Expected O, but got I
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0ce1: Expected O, but got I4
		object obj8 = default(object);
		object obj7;
		if (evt != null)
		{
			IDictionary<string, object> dictionary = evt.Params;
			if (dictionary != null)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				object obj2 = "java.io.FileOutputStream" + 1080;
				nint num = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v7 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v7 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00e6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v7 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v16-8]");
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
					goto IL_00e6;
				}
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v83+8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ X8_v83] (should have been resolved before IL gen)");
				if (obj8 != null)
				{
					goto IL_0189;
				}
			}
		}
		goto IL_09eb;
		IL_09f9:
		throw new InvalidCastException();
		IL_0653:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = 6;
		object obj11 = default(object);
		object obj10 = obj11;
		goto IL_0b56;
		IL_07cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v28+20]");
		object obj14;
		object obj16 = default(object);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v28+20]");
			((SmartFox)0).EnableLagMonitor(enabled: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 != null)
			{
				object obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v52+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0866;
				}
			}
			else
			{
				_ = 1;
				object obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v52+E4]");
				bool flag = (nint)0 == 0;
				object obj15 = !flag;
				if (obj15 != null)
				{
					goto IL_0866;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj16 != null)
			{
				goto IL_0911;
			}
		}
		goto IL_09eb;
		IL_0866:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 != null)
		{
			goto IL_0911;
		}
		goto IL_09eb;
		IL_0ba1:
		object obj18 = (nint)0 + (nint)2152;
		object obj19 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v27+E4]");
		object obj20 = default(object);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = obj20 == null;
			object obj21 = !flag3;
			if (obj21 != null)
			{
				goto IL_07cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj20 != null)
			{
				goto IL_07cb;
			}
		}
		goto IL_09eb;
		IL_09eb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_09f9;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v118+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ X0_v118] (should have been resolved before IL gen)");
		bool flag4 = obj8 == null;
		object obj22 = !flag4;
		if (obj22 != null)
		{
			goto IL_0189;
		}
		goto IL_09eb;
		IL_0189:
		object obj23 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X22_v4+48]");
		object obj24 = 0;
		object obj25 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v9+40]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v6+40]");
		if (num2 != 0)
		{
			goto IL_09f9;
		}
		object obj26 = typeof(RegisteredWaitHandle) + 1880;
		object obj27 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
		object obj28 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v13+B8]");
		object obj29 = 0;
		object obj30 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj31 = !flag5;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj32 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v14+118]");
		string text;
		object obj36;
		object obj37;
		double num3;
		object obj39;
		object obj38 = default(object);
		double num4 = default(double);
		if ((DateTime)0 == (DateTime)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "WhiteSmoke" + 3504;
			object obj33 = default(object);
			text = string.Format((string)format, obj33);
			object obj34 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v67+E4]");
			bool flag6 = (nint)0 == 0;
			object obj35 = !flag6;
			obj9 = null;
			obj36 = text;
			if (obj35 == null)
			{
				obj37 = obj38;
				num3 = num4;
				obj39 = null;
				object obj40 = obj33;
				goto IL_04a3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj41 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v96+E4]");
			bool flag7 = (nint)0 == 0;
			object obj42 = !flag7;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object obj43 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v69+B8]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v70+118]");
			TimeSpan timeSpan = now - (DateTime)0;
			object obj45 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v101+E4]");
			bool flag8 = (nint)0 == 0;
			object obj47 = !flag8;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			num3 = timeSpan2.TotalSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format2 = "WhiteSmoke" + 3512;
			object obj48 = default(object);
			object obj49 = default(object);
			text = string.Format((string)format2, obj48, obj49);
			object obj34 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v67+E4]");
			bool flag9 = (nint)0 == 0;
			object obj50 = !flag9;
			obj37 = 0;
			obj39 = obj49;
			object obj40 = obj48;
			obj38 = 0;
			num4 = num3;
			obj9 = obj49;
			obj36 = text;
			if (obj50 == null)
			{
				goto IL_04a3;
			}
		}
		goto IL_0a96;
		IL_04a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj38 = obj37;
		num4 = num3;
		obj9 = obj39;
		obj36 = text;
		goto IL_0a96;
		IL_0911:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X0_v30+20]");
		int interval;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X0_v30+20]");
			((SmartFox)0).EnableLagMonitor(enabled: true, interval);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format3 = "WhiteSmoke" + 3496;
			object arg = default(object);
			string text2 = string.Format((string)format3, arg);
			object obj51 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v32+E4]");
			bool flag10 = (nint)0 == 0;
			object obj52 = !flag10;
			object obj53 = text2;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = text2;
			}
			KLogger.Log(obj53);
			ConnectionSpeed connectionSpeed = ConnectionSpeed;
			double num5 = default(double);
			string connectionLevel = ((Enum)(&num5)).ToString();
			object obj54 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v38+B8]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v39+100]");
			ITrackEvent trackEvent = TrackerLibrary.DevPingPongFirstReading(connectionLevel, 0);
			object obj56 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj57 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v42+E4]");
			bool flag11 = (nint)0 == 0;
			object obj58 = !flag11;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			return;
		}
		goto IL_09eb;
		IL_0a96:
		KLogger.Log(obj36);
		object obj59 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v16+E4]");
		bool flag12 = (nint)0 == 0;
		object obj60 = !flag12;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		object obj61 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v18+B8]");
		object obj62 = 0;
		DateTime now3 = DateTime.Now;
		object obj63 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v22+B8]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v24+30]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v24+30]");
		bool flag13 = (nint)0 == 0;
		object obj66 = 0;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v9+28]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X9_v9+18] (should have been resolved before IL gen)");
			object obj67 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v64+B8]");
			obj64 = 0;
			object obj68 = default(object);
			obj66 = obj68;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v24+111]");
		object obj69 = (nint)0 & (nint)1;
		bool flag14 = obj69 == null;
		object obj70 = !flag14;
		if (obj70 != null)
		{
			return;
		}
		_ = 1;
		Room lastJoinedRoom = LastJoinedRoom;
		if (lastJoinedRoom != null)
		{
			Room lastJoinedRoom2 = LastJoinedRoom;
			if (lastJoinedRoom2 == null)
			{
				goto IL_09eb;
			}
			object obj71 = typeof(RegisteredWaitHandle) + 1376;
			nint num6 = (nint)lastJoinedRoom2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v56 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v56 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0653;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v56 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj73 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X10_v11-8]");
				if (0 == (nint)obj71)
				{
					break;
				}
				obj73 += 16;
				obj72--;
				if ((nint)obj72 != 1)
				{
					continue;
				}
				goto IL_0653;
			}
			object obj74 = obj73 + 6;
			object obj75 = num6 + obj74;
			obj10 = obj75 + 312;
			goto IL_0b56;
		}
		object obj76 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj77 = (nint)0 & (nint)1;
		bool flag15 = obj77 == null;
		int num7 = 45;
		if (flag15)
		{
			goto IL_0733;
		}
		obj14 = obj76;
		object obj78 = obj9;
		object obj79 = obj66;
		interval = 45;
		goto IL_0ba1;
		IL_0733:
		_ = 1;
		obj14 = obj76;
		obj78 = obj9;
		obj79 = obj66;
		interval = num7;
		goto IL_0ba1;
		IL_0b56:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v57+8]");
		obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v710 @ X8_v57] (should have been resolved before IL gen)");
		object obj80 = default(object);
		bool flag16 = obj80 == null;
		object obj81 = !flag16;
		object obj82 = ~obj81;
		num7 = ((obj82 != null) ? 45 : 3);
		obj76 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj83 = (nint)0 & (nint)1;
		bool flag17 = obj83 == null;
		object obj84 = !flag17;
		obj14 = obj76;
		obj78 = obj9;
		obj79 = obj66;
		interval = num7;
		if (obj84 == null)
		{
			goto IL_0733;
		}
		goto IL_0ba1;
	}

	private void SFS_OnRoomCreated(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_023b: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02df: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+38]");
		if ((nint)0 == 0)
		{
			return;
		}
		IDictionary<string, object> dictionary = evt.Params;
		object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj9 = "rightCtrl" + 280;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X10_v8-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v19+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ X8_v19] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		if (obj16 != null)
		{
			goto IL_0154;
		}
		goto IL_0203;
		IL_0154:
		object obj17 = typeof(RegisteredWaitHandle) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj18 = default(object);
		bool flag3 = obj18 == null;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			throw new InvalidCastException();
		}
		goto IL_02bf;
		IL_0203:
		object obj20 = 0;
		goto IL_02bf;
		IL_02bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v5+18]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v5+40]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v5+28]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v19] (should have been resolved before IL gen)");
		if (obj15 != null)
		{
			goto IL_0154;
		}
		goto IL_0203;
	}

	private void SFS_OnJoinRoom(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a34: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0a5a: Expected O, but got I
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected O, but got Unknown
		//IL_0a81: Expected O, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0328: Expected I, but got O
		//IL_0338: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		//IL_0084: Expected O, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_0373: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_0529: Expected I, but got O
		//IL_0539: Expected O, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04c0: Expected O, but got I
		//IL_04e4: Expected O, but got I4
		//IL_01db: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0183: Expected O, but got I
		//IL_05cb: Expected O, but got I
		//IL_045e: Expected O, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0742: Expected O, but got I
		//IL_0758: Expected O, but got I
		//IL_0574: Expected O, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0853: Expected I, but got O
		//IL_0863: Expected O, but got I
		//IL_0617: Expected I, but got O
		//IL_0627: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0792: Expected I, but got O
		//IL_07a2: Expected O, but got I
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_06f0: Expected O, but got I
		//IL_0714: Expected O, but got I4
		//IL_0c87: Expected O, but got I4
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_089e: Expected O, but got I
		//IL_0b5d: Expected O, but got I4
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected O, but got Unknown
		//IL_0bc9: Expected O, but got I4
		//IL_0662: Expected O, but got I
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0d43: Expected O, but got I4
		//IL_0c1c: Expected O, but got I4
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected O, but got Unknown
		//IL_07dd: Expected O, but got I
		//IL_0cd6: Expected O, but got I
		//IL_0ceb: Expected O, but got I
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected O, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09e2: Expected O, but got I
		//IL_09f7: Expected O, but got I
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+B8]");
		object obj6 = 0;
		object obj7 = this + 56;
		bool flag2 = obj7 == null;
		IntPtr intPtr = default(IntPtr);
		User user = (User)(nint)intPtr;
		object obj8;
		object obj13;
		if (!flag2)
		{
			User mySelf = MySelf;
			obj8 = typeof(UsageHint) + 8;
			nint num = (nint)mySelf;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v69 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v69 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0100;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v69 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X10_v49-8]");
				if (0 == (nint)obj8)
				{
					break;
				}
				obj10 += 16;
				obj9--;
				if ((nint)obj9 != 1)
				{
					continue;
				}
				goto IL_0100;
			}
			object obj11 = num + obj10;
			object obj12 = obj11 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X8_v78] (should have been resolved before IL gen)");
			obj13 = obj7;
			user = (User)(nint)intPtr;
			goto IL_0188;
		}
		goto IL_02cb;
		IL_04fa:
		SmartFox smartFox = client;
		object obj14 = null;
		goto IL_050e;
		IL_03b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = typeof(RegisteredWaitHandle) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v75+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v75] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag3 = obj17 == null;
		object obj18 = obj15;
		if (!flag3)
		{
			goto IL_0411;
		}
		goto IL_04fa;
		IL_0411:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj19 = default(object);
		if (obj19 != null)
		{
			smartFox = client;
			bool flag4 = client == null;
			object obj20 = !flag4;
			obj18 = obj15;
			obj14 = obj19;
			if (obj20 != null)
			{
				goto IL_050e;
			}
			goto IL_09f8;
		}
		throw new InvalidCastException();
		IL_05fa:
		client.EnableLagMonitor(enabled: true, 3);
		nint num2 = (nint)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v47 (Il2CppClass<System.Object>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v47 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06a3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v47 (Il2CppClass<System.Object>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X10_v25-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_06a3;
		}
		object obj23 = obj22 + 1;
		object obj24 = num2 + obj23;
		object obj25 = obj24 + 312;
		int num3 = 3;
		goto IL_0b44;
		IL_09ca:
		object obj26 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X8_v18+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v19+40]");
		Actions.SafeInvoke((Action<object>)0, obj14);
		return;
		IL_050e:
		smartFox.EnableLagMonitor(enabled: false);
		nint num4 = (nint)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v16 (Il2CppClass<System.Object>)+12E]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v16 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v16 (Il2CppClass<System.Object>)+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v30-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj29 += 16;
			obj28--;
			if ((nint)obj28 != 1)
			{
				continue;
			}
			goto IL_05b5;
		}
		object obj30 = obj29 + 6;
		object obj31 = num4 + obj30;
		object obj32 = obj31 + 312;
		object obj33 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v727 @ X0_v67] (should have been resolved before IL gen)");
		object obj34 = default(object);
		bool flag5 = obj34 == null;
		object obj35 = !flag5;
		object obj36 = obj33;
		if (obj35 != null)
		{
			goto IL_05fa;
		}
		goto IL_072a;
		IL_0cf0:
		object format;
		object arg;
		object arg2;
		string text = string.Format((string)format, arg, arg2);
		object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X8_v27+E4]");
		bool flag6 = (nint)0 == 0;
		object obj39 = !flag6;
		object obj40 = text;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj40 = text;
		}
		KLogger.Log(obj40);
		obj33 = obj36;
		goto IL_09ca;
		IL_0100:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X0_v91] (should have been resolved before IL gen)");
		obj13 = obj7;
		bool flag7 = obj7 == null;
		object obj41 = !flag7;
		user = null;
		if (obj41 != null)
		{
			goto IL_0188;
		}
		goto IL_09f8;
		IL_0188:
		object obj42 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v71+12E]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v71+12E]");
		if ((nint)0 == 0)
		{
			goto IL_021c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v71+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v44-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj44 += 16;
			obj43--;
			if ((nint)obj43 != 1)
			{
				continue;
			}
			goto IL_021c;
		}
		object obj45 = obj42 + obj44;
		object obj46 = obj45 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v636 @ X0_v88] (should have been resolved before IL gen)");
		object obj47 = default(object);
		VariableBinder variableBinder = default(VariableBinder);
		if (obj47 != variableBinder)
		{
			goto IL_029c;
		}
		goto IL_02cb;
		IL_0c6e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1005 @ X0_v30] (should have been resolved before IL gen)");
		object obj48 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		format = "WhiteSmoke" + 3488;
		object obj49 = default(object);
		arg2 = obj49;
		object obj50 = default(object);
		arg = obj50;
		goto IL_0cf0;
		IL_09f8:
		throw new NullReferenceException();
		IL_08df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		int num5 = 1;
		goto IL_0c6e;
		IL_06a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 1;
		goto IL_0b44;
		IL_021c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v553 @ X0_v85] (should have been resolved before IL gen)");
		if (obj47 != variableBinder)
		{
			goto IL_029c;
		}
		user = null;
		goto IL_02cb;
		IL_029c:
		User mySelf2 = MySelf;
		user = (User)obj7;
		binder.ReWire(mySelf2, (User)obj7);
		goto IL_02cb;
		IL_0c03:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v973 @ X0_v38] (should have been resolved before IL gen)");
		object obj51 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		format = "WhiteSmoke" + 3480;
		object obj52 = default(object);
		arg2 = obj52;
		object obj53 = default(object);
		arg = obj53;
		goto IL_0cf0;
		IL_02cb:
		User mySelf3 = MySelf;
		obj7 = mySelf3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IDictionary<string, object> dictionary = evt.Params;
		object obj54 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj55 = "rightCtrl" + 280;
		nint num6 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v14 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v14 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v14 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj57 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X10_v37-8]");
			if (0 == (nint)obj54)
			{
				break;
			}
			obj57 += 16;
			obj56--;
			if ((nint)obj56 != 1)
			{
				continue;
			}
			goto IL_03b4;
		}
		object obj58 = num6 + obj57;
		obj15 = typeof(RegisteredWaitHandle) + 1376;
		object obj59 = obj58 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v68+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v645 @ X8_v68] (should have been resolved before IL gen)");
		bool flag8 = obj17 == null;
		object obj60 = !flag8;
		obj18 = obj15;
		if (obj60 != null)
		{
			goto IL_0411;
		}
		goto IL_04fa;
		IL_05b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj33 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v694 @ X0_v64] (should have been resolved before IL gen)");
		object obj61 = default(object);
		bool flag9 = obj61 == null;
		obj36 = obj33;
		if (!flag9)
		{
			goto IL_05fa;
		}
		goto IL_072a;
		IL_072a:
		object obj62 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v21+B8]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v22+111]");
		object obj64 = (nint)0 & (nint)1;
		int num8;
		if (obj64 != null)
		{
			client.EnableLagMonitor(enabled: true, 45);
			nint num7 = (nint)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v37 (Il2CppClass<System.Object>)+12E]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v37 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_081e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v37 (Il2CppClass<System.Object>)+B0]");
			object obj66 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X10_v18-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj66 += 16;
				obj65--;
				if ((nint)obj65 != 1)
				{
					continue;
				}
				goto IL_081e;
			}
			object obj67 = obj66 + 1;
			object obj68 = num7 + obj67;
			object obj69 = obj68 + 312;
			num8 = 45;
			goto IL_0c03;
		}
		client.EnableLagMonitor(enabled: true, 3);
		nint num9 = (nint)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v28 (Il2CppClass<System.Object>)+12E]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v28 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v28 (Il2CppClass<System.Object>)+B0]");
		object obj71 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X10_v12-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj71 += 16;
			obj70--;
			if ((nint)obj70 != 1)
			{
				continue;
			}
			goto IL_08df;
		}
		object obj72 = obj71 + 1;
		object obj73 = num9 + obj72;
		object obj74 = obj73 + 312;
		num5 = 3;
		goto IL_0c6e;
		IL_081e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num8 = 1;
		goto IL_0c03;
		IL_0b44:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v892 @ X0_v48] (should have been resolved before IL gen)");
		object obj75 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format2 = "WhiteSmoke" + 3472;
		object arg3 = default(object);
		object arg4 = default(object);
		string text2 = string.Format((string)format2, arg3, arg4);
		object obj76 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj77 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v57+E4]");
		bool flag10 = (nint)0 == 0;
		object obj78 = !flag10;
		object obj79 = text2;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj79 = text2;
		}
		KLogger.Log(obj79);
		object obj80 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v58+B8]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v59+48]");
		Actions.SafeInvoke((Action<object>)0, obj14);
		goto IL_09ca;
	}

	private void SFS_OnJoinRoomFailed(Room room, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 1880;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+50]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void SFS_OnRoomRemoved(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_09bd: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_09e3: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0141: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0381: Expected O, but got I
		//IL_039b: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_03ed: Expected O, but got I
		//IL_0417: Expected O, but got I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0305: Expected O, but got I
		//IL_0329: Expected O, but got I4
		//IL_0341: Expected O, but got I
		//IL_02b3: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_04ac: Expected O, but got I
		//IL_04cd: Expected O, but got I
		//IL_0577: Expected O, but got I4
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05d0: Expected I, but got O
		//IL_05e0: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_0676: Expected O, but got I
		//IL_069a: Expected O, but got I4
		//IL_07b5: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_0866: Expected O, but got I4
		//IL_06c8: Expected O, but got I
		//IL_06d8: Expected O, but got I
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_0823: Expected O, but got I4
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected O, but got Unknown
		//IL_0770: Expected O, but got I
		//IL_089e: Expected O, but got I
		//IL_070d: Expected O, but got I
		//IL_071d: Expected O, but got I
		//IL_072d: Expected O, but got I
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_08af: Expected I, but got O
		//IL_08bf: Expected O, but got I
		//IL_0a9f: Expected O, but got I
		//IL_0aaf: Expected O, but got I
		//IL_0ad1: Expected O, but got I4
		//IL_08fa: Expected O, but got I
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected O, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "rightCtrl" + 280;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X10_v34-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj11 = num + obj10;
		object obj12 = typeof(RegisteredWaitHandle) + 1376;
		object obj13 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v58+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X8_v58] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v58+8]");
		object obj18 = 0;
		object obj19 = obj8;
		if (obj16 != null)
		{
			goto IL_0188;
		}
		goto IL_0357;
		IL_05b4:
		object obj20 = typeof(System.IOAsyncCallback) + 936;
		IRoomManager roomManager;
		nint num2 = (nint)roomManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_065c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X10_v18-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_065c;
		}
		goto IL_0737;
		IL_0549:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v611 @ X0_v53] (should have been resolved before IL gen)");
		bool flag3 = roomManager == null;
		object obj23 = !flag3;
		if (obj23 != null)
		{
			goto IL_05b4;
		}
		goto IL_0981;
		IL_088d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v20+20]");
		IRoomManager roomManager2 = ((SmartFox)0).RoomManager;
		nint num3 = (nint)roomManager2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_093b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X10_v11-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_093b;
		}
		object obj26 = obj25 + 21;
		object obj27 = num3 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0a7d;
		IL_07ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj29 = default(object);
		bool flag4 = obj29 == null;
		object obj30 = !flag4;
		if (obj30 != null)
		{
			goto IL_088d;
		}
		goto IL_0981;
		IL_0a7d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v859 @ X8_v22] (should have been resolved before IL gen)");
		object obj31 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v23+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v24+58]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v24+58]");
		bool flag5 = (nint)0 == 0;
		object obj34 = !flag5;
		if (obj34 == null)
		{
			return;
		}
		goto IL_06fd;
		IL_0981:
		throw new NullReferenceException();
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = typeof(RegisteredWaitHandle) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v79+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v79] (should have been resolved before IL gen)");
		bool flag6 = obj15 == null;
		obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v79+8]");
		obj18 = 0;
		obj19 = obj8;
		if (!flag6)
		{
			goto IL_0188;
		}
		goto IL_0357;
		IL_0357:
		object obj35 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj36 = (nint)0 & (nint)1;
		bool flag7 = obj36 == null;
		object obj37 = !flag7;
		object obj38 = 0;
		object obj39 = obj35;
		obj12 = obj17;
		obj14 = obj18;
		object obj40 = obj19;
		object obj41 = 0;
		if (obj37 != null)
		{
			goto IL_022e;
		}
		goto IL_03db;
		IL_0188:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj42 = default(object);
		if (obj42 != null)
		{
			obj35 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj43 = (nint)0 & (nint)1;
			bool flag8 = obj43 == null;
			obj17 = obj12;
			obj18 = obj14;
			obj19 = obj12;
			obj38 = obj42;
			obj39 = obj35;
			obj40 = obj12;
			obj41 = obj42;
			if (!flag8)
			{
				goto IL_022e;
			}
			goto IL_03db;
		}
		throw new InvalidCastException();
		IL_06b0:
		object obj44 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v36+B8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v37+58]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v37+58]");
		if ((nint)0 != 0)
		{
			goto IL_06fd;
		}
		return;
		IL_065c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v46+8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v679 @ X0_v46] (should have been resolved before IL gen)");
		object obj47 = default(object);
		bool flag9 = obj47 == null;
		object obj48 = !flag9;
		object obj50 = default(object);
		object obj49 = obj50;
		if (obj48 == null)
		{
			goto IL_06b0;
		}
		goto IL_079f;
		IL_03db:
		_ = 1;
		object obj51 = (nint)0 + (nint)2152;
		object obj52 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v59+E4]");
		bool flag10 = (nint)0 == 0;
		object obj53 = !flag10;
		obj35 = obj39;
		obj17 = obj12;
		obj18 = obj14;
		obj38 = obj41;
		object obj54 = obj51;
		obj19 = obj40;
		if (obj53 != null)
		{
			goto IL_028f;
		}
		goto IL_0455;
		IL_022e:
		obj51 = (nint)0 + (nint)2152;
		obj52 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v59+E4]");
		bool flag11 = (nint)0 == 0;
		obj54 = obj51;
		obj39 = obj35;
		obj12 = obj17;
		obj14 = obj18;
		obj41 = obj38;
		if (!flag11)
		{
			goto IL_028f;
		}
		goto IL_0455;
		IL_0455:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj51 = obj54;
		obj35 = obj39;
		obj17 = obj12;
		obj18 = obj14;
		obj38 = obj41;
		goto IL_049b;
		IL_028f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj55 = default(object);
		bool flag12 = obj55 == null;
		object obj56 = !flag12;
		if (obj56 != null)
		{
			goto IL_049b;
		}
		goto IL_0981;
		IL_049b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v14+20]");
		roomManager = ((SmartFox)0).RoomManager;
		object obj57 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v14+12E]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0549;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v14+B0]");
		object obj59 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v23-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj59 += 16;
			obj58--;
			if ((nint)obj58 != 1)
			{
				continue;
			}
			goto IL_0549;
		}
		object obj60 = obj57 + obj59;
		object obj61 = obj60 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v627 @ X0_v56] (should have been resolved before IL gen)");
		goto IL_05b4;
		IL_06fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v34+18]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v34+40]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v34+28]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v364 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0737;
		IL_0737:
		object obj65 = obj22 + 13;
		object obj66 = num2 + obj65;
		object obj67 = obj66 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v49+8]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v712 @ X0_v49] (should have been resolved before IL gen)");
		bool flag13 = obj47 == null;
		obj49 = obj50;
		if (flag13)
		{
			goto IL_06b0;
		}
		goto IL_079f;
		IL_079f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj68 = (nint)0 & (nint)1;
		if (obj68 != null)
		{
			object obj69 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				goto IL_07ff;
			}
		}
		else
		{
			_ = 1;
			object obj69 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v27+E4]");
			bool flag14 = (nint)0 == 0;
			object obj70 = !flag14;
			if (obj70 != null)
			{
				goto IL_07ff;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_088d;
		IL_093b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj71 = default(object);
		obj28 = obj71;
		goto IL_0a7d;
	}

	private void SFS_OnRoomNameChanged(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_023b: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02df: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+90]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+90]");
		if ((nint)0 == 0)
		{
			return;
		}
		IDictionary<string, object> dictionary = evt.Params;
		object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj9 = "rightCtrl" + 280;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X10_v8-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v19+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ X8_v19] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		if (obj16 != null)
		{
			goto IL_0154;
		}
		goto IL_0203;
		IL_0154:
		object obj17 = typeof(RegisteredWaitHandle) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj18 = default(object);
		bool flag3 = obj18 == null;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			throw new InvalidCastException();
		}
		goto IL_02bf;
		IL_0203:
		object obj20 = 0;
		goto IL_02bf;
		IL_02bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v5+18]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v5+40]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v5+28]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v19] (should have been resolved before IL gen)");
		if (obj15 != null)
		{
			goto IL_0154;
		}
		goto IL_0203;
	}

	private void SFS_OnRoomGroupSubscribe(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0bd7: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0bfd: Expected O, but got I
		//IL_0abc: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a0: Expected I, but got O
		//IL_00b0: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_020e: Expected O, but got I
		//IL_023d: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_028d: Expected I, but got O
		//IL_029d: Expected O, but got I
		//IL_0b60: Expected O, but got I
		//IL_0357: Expected O, but got I4
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_03e0: Expected I, but got O
		//IL_03f1: Expected O, but got I
		//IL_041a: Expected O, but got I4
		//IL_02d8: Expected O, but got I
		//IL_0c8d: Expected O, but got I
		//IL_0c9d: Expected O, but got I
		//IL_044e: Expected O, but got I
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_04ba: Expected O, but got I
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04da: Expected O, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0d1e: Expected O, but got I4
		//IL_05be: Expected O, but got I
		//IL_05f7: Expected O, but got I
		//IL_06be: Expected I, but got O
		//IL_0d7d: Expected O, but got I
		//IL_0632: Expected O, but got I
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected O, but got Unknown
		//IL_0703: Expected I, but got O
		//IL_0713: Expected O, but got I
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0e09: Expected O, but got I4
		//IL_074e: Expected O, but got I
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0e51: Expected O, but got I4
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_0866: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_08a5: Expected O, but got I4
		//IL_08ae: Expected O, but got I4
		//IL_08cd: Expected O, but got I
		//IL_08de: Expected I, but got O
		//IL_08ee: Expected O, but got I
		//IL_0eaf: Expected O, but got I
		//IL_0929: Expected O, but got I
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+B8]");
		object obj6 = 0;
		object obj7;
		DateTime dateTime2;
		DateTime dateTime3;
		nint num2;
		if (evt != null)
		{
			IDictionary<string, object> dictionary = evt.Params;
			if (dictionary != null)
			{
				obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				object obj8 = "getSecondRescanTask" + 2000;
				nint num = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v22 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X10_v38-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj10 += 16;
					obj9--;
					if ((nint)obj9 != 1)
					{
						continue;
					}
					goto IL_012c;
				}
				object obj11 = num + obj10;
				object obj12 = obj11 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v69+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ X8_v69] (should have been resolved before IL gen)");
				DateTime dateTime = default(DateTime);
				bool flag2 = (object)dateTime == null;
				dateTime2 = dateTime;
				dateTime3 = dateTime;
				if (!flag2)
				{
					goto IL_01ef;
				}
				goto IL_024b;
			}
		}
		goto IL_0aaa;
		IL_0ac1:
		throw new NullReferenceException();
		IL_01ef:
		object obj13 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v65+90]");
		BaseEvent baseEvent = (BaseEvent)0;
		ulong dateData = dateTime2._dateData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v65+90]");
		bool flag3 = dateData != 0;
		dateTime3 = dateTime2;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		if (!flag3)
		{
			goto IL_024b;
		}
		InvalidCastException ex = new InvalidCastException();
		bool flag4 = (nint)baseEvent != 1;
		InvalidCastException ex2 = ex;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj14 = (nint)0 + (nint)760;
			baseEvent = (BaseEvent)obj14;
			enumerator.Dispose();
			object obj15 = default(object);
			if (obj15 == null)
			{
				goto IL_09e4;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj15;
			ex2 = (InvalidCastException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C8F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_03bc:
		object obj16 = typeof(List<AdaptivePerformanceScaler>) + 3072;
		object obj17 = obj16;
		List<object> list = default(List<object>);
		nint num3 = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v30+130]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v13 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+130]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v30+130]");
		bool flag5 = num4 < 0;
		object obj19 = !flag5;
		object obj20 = ~obj19;
		nint num7;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X9_v13 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+C8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v30+130]");
			object obj21 = num5 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X9_v15-8]");
			object obj22 = 0 - obj17;
			bool flag6 = obj22 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X9_v15-8]");
			bool flag7 = 0 != (nint)obj17;
			if (!flag7)
			{
				List<object>.Enumerator enumerator3 = list.GetEnumerator();
				object obj23 = (nint)0 + (nint)768;
				object obj24 = typeof(Queue<string>) + 824;
				object obj25 = (nint)0 + (nint)2152;
				object obj26 = typeof(RegisteredWaitHandle) + 1376;
				object obj27 = typeof(System.IOAsyncCallback) + 936;
				object obj29 = default(object);
				object obj28 = obj29;
				object obj32 = default(object);
				object obj33 = default(object);
				object obj39 = default(object);
				object obj43 = default(object);
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				object obj54 = default(object);
				List<object>.Enumerator enumerator5;
				while (true)
				{
					BaseEvent baseEvent2 = (BaseEvent)obj23;
					if (!enumerator4.MoveNext())
					{
						break;
					}
					object obj30 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v44+E4]");
					bool flag8 = (nint)0 == 0;
					object obj31 = !flag8;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					IRoomManager roomManager;
					nint num6;
					if (obj32 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v47+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v47+20]");
							roomManager = ((SmartFox)0).RoomManager;
							if (obj33 != null)
							{
								object obj34 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v42+12E]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v42+12E]");
								if ((nint)0 == 0)
								{
									goto IL_06af;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v42+B0]");
								object obj36 = (nint)0 + (nint)8;
								bool flag9 = flag7;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X10_v27-8]");
									obj22 = 0 - obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X10_v27-8]");
									if (0 == (nint)obj26)
									{
										break;
									}
									obj18 = obj36 + 16;
									obj35--;
									obj22 = obj35 - 1;
									flag6 = obj22 == null;
									flag7 = (nint)obj35 != 1;
									flag9 = flag7;
									obj36 = obj18;
									if (flag7)
									{
										continue;
									}
									goto IL_06af;
								}
								object obj37 = obj34 + obj36;
								object obj38 = obj37 + 312;
								num6 = num7;
								flag7 = flag9;
								obj18 = obj36;
								goto IL_0d6d;
							}
							throw new NullReferenceException();
						}
					}
					throw new NullReferenceException();
					IL_0e9f:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v52+8]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v795 @ X8_v52] (should have been resolved before IL gen)");
					num7 = 1;
					continue;
					IL_0de5:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v946 @ X0_v57] (should have been resolved before IL gen)");
					bool flag10 = obj39 == null;
					object obj40 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v57+8]");
					num7 = 0;
					if (obj40 != null)
					{
						continue;
					}
					object obj41 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X0_v61+E4]");
					bool flag11 = (nint)0 == 0;
					object obj42 = !flag11;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					bool flag12 = obj43 == null;
					obj29 = obj28;
					enumerator4 = enumerator2;
					enumerator5 = enumerator2;
					enumerator2 = (List<object>.Enumerator)0;
					object obj48;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v64+20]");
						bool flag13 = (nint)0 == 0;
						obj29 = obj28;
						enumerator4 = (List<object>.Enumerator)0;
						enumerator5 = (List<object>.Enumerator)0;
						enumerator2 = (List<object>.Enumerator)0;
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v64+20]");
							IRoomManager roomManager2 = ((SmartFox)0).RoomManager;
							nint num8 = (nint)roomManager2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v51 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
							object obj44 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v51 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_09a6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v51 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
							object obj45 = (nint)0 + (nint)8;
							bool flag14 = flag7;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X10_v17-8]");
								obj22 = 0 - obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X10_v17-8]");
								if (0 == (nint)obj27)
								{
									break;
								}
								obj18 = obj45 + 16;
								obj44--;
								obj22 = obj44 - 1;
								flag6 = obj22 == null;
								flag7 = (nint)obj44 != 1;
								flag14 = flag7;
								obj45 = obj18;
								if (flag7)
								{
									continue;
								}
								goto IL_09a6;
							}
							object obj46 = obj45 + 1;
							object obj47 = num8 + obj46;
							obj48 = obj47 + 312;
							flag7 = flag14;
							obj18 = obj45;
							goto IL_0e9f;
						}
					}
					goto IL_0ac1;
					IL_07cb:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_0de5;
					IL_0d6d:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v53+8]");
					baseEvent2 = (BaseEvent)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v882 @ X0_v53] (should have been resolved before IL gen)");
					if (roomManager != null)
					{
						nint num9 = (nint)roomManager;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v45 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v45 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_07cb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v45 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
						object obj50 = (nint)0 + (nint)8;
						bool flag15 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X10_v22-8]");
							obj22 = 0 - obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X10_v22-8]");
							if (0 == (nint)obj27)
							{
								break;
							}
							obj18 = obj50 + 16;
							obj49--;
							obj22 = obj49 - 1;
							flag6 = obj22 == null;
							flag7 = (nint)obj49 != 1;
							flag15 = flag7;
							obj50 = obj18;
							if (flag7)
							{
								continue;
							}
							goto IL_07cb;
						}
						object obj51 = obj50 + 13;
						object obj52 = num9 + obj51;
						object obj53 = obj52 + 312;
						flag7 = flag15;
						obj18 = obj50;
						goto IL_0de5;
					}
					throw new NullReferenceException();
					IL_06af:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num6 = unchecked((nint)null);
					goto IL_0d6d;
					IL_09a6:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj48 = obj54;
					goto IL_0e9f;
				}
				enumerator4.Dispose();
				obj29 = obj28;
				enumerator5 = enumerator2;
				dateTime2 = dateTime3;
				goto IL_09e4;
			}
		}
		goto IL_0c75;
		IL_09e4:
		obj4 = typeof(RegisteredWaitHandle) + 1880;
		dateTime3 = dateTime2;
		goto IL_0c75;
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v88+8]");
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v534 @ X0_v88] (should have been resolved before IL gen)");
		bool flag16 = list == null;
		object obj55 = !flag16;
		if (obj55 != null)
		{
			goto IL_03bc;
		}
		goto IL_0c75;
		IL_0aaa:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_0ac1;
		IL_024b:
		IDictionary<string, object> dictionary2 = evt.Params;
		if (dictionary2 == null)
		{
			goto IL_0aaa;
		}
		object obj56 = "m_StencilDeferredPS" + 3520;
		nint num10 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v26 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v26 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0319;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v26 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj58 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X10_v32-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj58 += 16;
			obj57--;
			if ((nint)obj57 != 1)
			{
				continue;
			}
			goto IL_0319;
		}
		object obj59 = num10 + obj58;
		object obj60 = obj59 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v62+8]");
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v570 @ X8_v62] (should have been resolved before IL gen)");
		if (list != null)
		{
			goto IL_03bc;
		}
		goto IL_0c75;
		IL_0c75:
		object obj61 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v9+B8]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v10+98]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v10+98]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v714 @ X8_v11+18] (should have been resolved before IL gen)");
		}
		return;
		IL_012c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v93+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v93] (should have been resolved before IL gen)");
		DateTime dateTime4 = default(DateTime);
		bool flag17 = (object)dateTime4 == null;
		object obj64 = !flag17;
		dateTime2 = dateTime4;
		if (obj64 != null)
		{
			goto IL_01ef;
		}
		dateTime3 = dateTime4;
		goto IL_024b;
	}

	private void SFS_OnRoomGroupUnsubscribe(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0295: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_0259: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "getSecondRescanTask" + 2000;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v11 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v7-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X8_v17] (should have been resolved before IL gen)");
		object obj13 = default(object);
		bool flag2 = obj13 == null;
		object obj14 = obj13;
		if (!flag2)
		{
			goto IL_01a6;
		}
		goto IL_01dc;
		IL_01a6:
		object obj15 = 153100288 + 1024;
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X9_v11+90]");
		if (obj16 == null)
		{
			goto IL_01dc;
		}
		throw new InvalidCastException();
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X0_v17] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag3 = obj17 == null;
		object obj18 = !flag3;
		obj14 = obj17;
		if (obj18 != null)
		{
			goto IL_01a6;
		}
		goto IL_01dc;
		IL_01dc:
		object obj19 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X9_v6+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X9_v7+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X9_v7+A0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v8+18]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v8+40]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v8+28]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v181 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void Offline_SFS_OnUserJoinRoom(BaseEvent evt)
	{
		SFS_OnUserJoinRoom(evt);
	}

	private void SFS_OnUserJoinRoom(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		object obj9 = typeof(UsageHint) + 8;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0127;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v5-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0127;
		}
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		goto IL_0217;
		IL_0217:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X8_v11] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v12+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v13+B0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v13+B0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+18]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+40]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+28]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0127:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj20 = default(object);
		obj13 = obj20;
		goto IL_0217;
	}

	public void Offline_SFS_OnUserLeaveRoom(BaseEvent evt)
	{
		SFS_OnUserLeaveRoom(evt);
	}

	private void SFS_OnUserLeaveRoom(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		object obj9 = typeof(UsageHint) + 8;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0127;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v5-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0127;
		}
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		goto IL_0217;
		IL_0217:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X8_v11] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v12+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v13+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v13+B8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+18]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+40]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+28]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0127:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj20 = default(object);
		obj13 = obj20;
		goto IL_0217;
	}

	private void SFS_OnUserVariableUpdate(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0444: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_046a: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01da: Expected I, but got O
		//IL_0203: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_0237: Expected O, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a3: Expected I, but got O
		//IL_02b3: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_04cc: Expected O, but got I
		//IL_0500: Expected O, but got I
		//IL_0510: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_039e: Expected O, but got I
		//IL_03ae: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0599: Expected O, but got I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_03e3: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2848;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X10_v15-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X8_v39] (should have been resolved before IL gen)");
		List<string> list = default(List<string>);
		bool flag2 = list == null;
		List<string> list2 = list;
		List<string> list3 = list;
		if (!flag2)
		{
			goto IL_01b6;
		}
		goto IL_0266;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v34] (should have been resolved before IL gen)");
		List<string> list4 = default(List<string>);
		bool flag3 = list4 == null;
		object obj13 = !flag3;
		list2 = list4;
		if (obj13 != null)
		{
			goto IL_01b6;
		}
		list3 = list4;
		goto IL_0266;
		IL_032f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = default(object);
		object obj14 = obj15;
		goto IL_04bc;
		IL_01b6:
		object obj16 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		object obj17 = obj16;
		nint num2 = (nint)list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v33 (Il2CppClass<System.Collections.Generic.List`1<System.String>>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X1_v16+130]");
		bool flag4 = num3 < 0;
		object obj18 = !flag4;
		object obj19 = ~obj18;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v33 (Il2CppClass<System.Collections.Generic.List`1<System.String>>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X1_v16+130]");
			object obj20 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v35-8]");
			bool flag5 = 0 != (nint)obj17;
			list3 = list2;
			if (!flag5)
			{
				goto IL_0266;
			}
		}
		throw new InvalidCastException();
		IL_04bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v17+8]");
		List<string> list5 = (List<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v445 @ X8_v17] (should have been resolved before IL gen)");
		object obj21;
		List<string> list6 = (List<string>)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj22 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v18+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v19+C8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v19+C8]");
		List<string> list7 = default(List<string>);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X8_v20+18] (should have been resolved before IL gen)");
			list5 = list3;
			list6 = list7;
		}
		User mySelf = MySelf;
		if (list7 == mySelf)
		{
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v21+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v22+D8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v22+D8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v23+28]");
				list5 = (List<string>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v465 @ X8_v23+18] (should have been resolved before IL gen)");
				list6 = list3;
			}
			object obj28 = typeof(UsageHint) + 72;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj30 = !flag6;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UserInfo.UpdateFastTrackRecord(list3);
		}
		return;
		IL_0266:
		IDictionary<string, object> dictionary2 = evt.Params;
		object obj31 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		obj21 = typeof(UsageHint) + 8;
		nint num5 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_032f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X10_v8-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_032f;
		}
		object obj34 = num5 + obj33;
		obj14 = obj34 + 312;
		goto IL_04bc;
	}

	public void SFS_OnRoomVariableUpdate(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_03f3: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d8: Expected I, but got O
		//IL_02e8: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_0479: Expected O, but got I
		//IL_0489: Expected O, but got I
		//IL_0323: Expected O, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2848;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v15-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v337 @ X8_v32] (should have been resolved before IL gen)");
		object obj13 = default(object);
		bool flag2 = obj13 == null;
		object obj14 = obj13;
		if (!flag2)
		{
			goto IL_01a6;
		}
		goto IL_024e;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v24] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag3 = obj15 == null;
		object obj16 = !flag3;
		obj14 = obj15;
		if (obj16 != null)
		{
			goto IL_01a6;
		}
		goto IL_024e;
		IL_0364:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj18 = default(object);
		object obj17 = obj18;
		goto IL_0445;
		IL_01a6:
		object obj19 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		object obj20 = obj19;
		object obj21 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v26+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X1_v12+130]");
		bool flag4 = num2 < 0;
		object obj22 = !flag4;
		object obj23 = ~obj22;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v26+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X1_v12+130]");
			object obj24 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v28-8]");
			if (0 == (nint)obj20)
			{
				goto IL_024e;
			}
		}
		throw new InvalidCastException();
		IL_0445:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X8_v19] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X22_v5+18]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X22_v5+40]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X22_v5+28]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v244 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_024e:
		object obj28 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v14+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v15+D0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v15+D0]");
		if ((nint)0 == 0)
		{
			return;
		}
		IDictionary<string, object> dictionary2 = evt.Params;
		object obj31 = "rightCtrl" + 280;
		object obj32 = typeof(RegisteredWaitHandle) + 1376;
		nint num4 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0364;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj34 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v8-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj34 += 16;
			obj33--;
			if ((nint)obj33 != 1)
			{
				continue;
			}
			goto IL_0364;
		}
		object obj35 = num4 + obj34;
		obj17 = obj35 + 312;
		goto IL_0445;
	}

	private void SFS_OnPublicMessage(ISFSObject param)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0180: Expected I, but got O
		//IL_0190: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_0402: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0299: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0372: Expected O, but got I
		//IL_0396: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_030e: Expected O, but got I
		//IL_031e: Expected O, but got I
		//IL_032e: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v13-8]");
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
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X0_v25] (should have been resolved before IL gen)");
		object obj9 = default(object);
		object obj8 = obj9 & 1;
		bool flag = obj8 == null;
		object obj10 = !flag;
		if (obj10 == null)
		{
			goto IL_0169;
		}
		return;
		IL_0169:
		object obj11 = "rightCtrl" + 768;
		nint num2 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_020c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_020c;
		}
		object obj14 = obj13 + 29;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v18+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X0_v18] (should have been resolved before IL gen)");
		object obj18 = default(object);
		bool flag2 = obj18 == null;
		object obj19 = !flag2;
		object obj20 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v18+8]");
		object obj21 = 0;
		object obj22 = obj11;
		if (obj19 != null)
		{
			goto IL_026d;
		}
		goto IL_03c4;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v15+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ X0_v15] (should have been resolved before IL gen)");
		object obj23 = default(object);
		bool flag3 = obj23 == null;
		obj20 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v15+8]");
		obj21 = 0;
		obj22 = obj11;
		if (!flag3)
		{
			goto IL_026d;
		}
		goto IL_03c4;
		IL_03c4:
		object obj24 = typeof(DataRelation) + 856;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "___# Content push apply failed [{0}]: {1}" + 704;
		Debug.LogError(message);
		return;
		IL_026d:
		object obj27 = typeof(RegisteredWaitHandle) + 1880;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v20+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v21+A8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v21+A8]");
		if ((nint)0 != 0)
		{
			object obj31 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ChatMessageData chatMessageData = default(ChatMessageData);
			chatMessageData..ctor(param);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X21_v6+18]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X21_v6+40]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X21_v6+28]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v144 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X0_v22] (should have been resolved before IL gen)");
		object obj36 = default(object);
		object obj35 = obj36 & 1;
		if (obj35 != null)
		{
			return;
		}
		goto IL_0169;
	}

	private void SFS_OnAdminMessage(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_034b: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0371: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		//IL_041d: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ba: Expected O, but got I
		//IL_02ee: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0264: Expected O, but got I
		//IL_0274: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_030c: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1880;
		DateTime now = DateTime.Now;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+B8]");
		object obj6 = 0;
		IDictionary<string, object> dictionary = evt.Params;
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj8 = "m_StencilDeferredPS" + 1272;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0127;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X10_v6-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0127;
		}
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X8_v23] (should have been resolved before IL gen)");
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v19+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		object obj17;
		string text = default(string);
		string text2 = default(string);
		object obj18;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+8]");
			obj17 = 0;
			obj18 = obj8;
			text = text2;
			goto IL_01a3;
		}
		goto IL_039f;
		IL_0127:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v23+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X0_v23] (should have been resolved before IL gen)");
		obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		obj18 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v23+8]");
		obj14 = 0;
		text2 = text;
		if (obj19 == null)
		{
			goto IL_01a3;
		}
		goto IL_039f;
		IL_039f:
		object obj20 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		object userName = "Added Tournament Prizes And Features" + 208;
		if (text2 != null)
		{
			object obj21 = 153100288 + 1024;
			string text3 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v17+90]");
			if (text3 != null)
			{
				text2 = null;
			}
		}
		string message = LocalizationUtil.Localize(text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor(message, null, (string)userName, (DateTime?)(object)0, global::ChatInk.Clean, isVerified: true);
		object obj22 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v13+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v14+C0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v14+C0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v15+18]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v15+40]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v15+28]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v130 @ X3_v2 (should have been resolved before IL gen)");
		}
		return;
		IL_01a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj14 = obj17;
		text2 = text;
		goto IL_039f;
	}

	private void OnDebugMessage(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object value = "Drop Menu Toggle" + 920;
		object obj = "WhiteSmoke" + 3464;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		bool flag = message.StartsWith((string)value, StringComparison.Ordinal);
		string obj3 = (string)obj + message;
		object obj4 = obj2;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
			if ((nint)0 != 0)
			{
				KLogger.LogError(obj3);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.LogError(obj3);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
			if ((nint)0 != 0)
			{
				KLogger.Log(obj3);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.Log(obj3);
		}
	}

	public static void SendRoomExtensionRequest(string command, ISFSObject param = null)
	{
		//IL_0016: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_01fa: Expected O, but got I
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_0300: Expected O, but got I
		//IL_031a: Expected O, but got I4
		//IL_022d: Expected O, but got I
		//IL_0362: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_03a2: Expected O, but got I
		//IL_03c3: Expected O, but got I
		//IL_03d3: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E839D]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = (nint)0 + (nint)2152;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v27+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj2 = obj4;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00cb;
		}
		goto IL_01bc;
		IL_0378:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0391;
		IL_025a:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0287;
		}
		goto IL_0378;
		IL_0287:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = default(object);
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_0391;
		}
		goto IL_03dd;
		IL_0082:
		obj7 = (nint)0 + (nint)2152;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v27+E4]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		obj4 = obj2;
		if (!flag5)
		{
			goto IL_00cb;
		}
		goto IL_01bc;
		IL_01bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj7 = obj10;
		obj2 = obj4;
		goto IL_01ea;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj14 = default(object);
		bool flag6 = obj14 == null;
		object obj15 = !flag6;
		if (obj15 != null)
		{
			goto IL_01ea;
		}
		goto IL_03dd;
		IL_01ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v3+20]");
		object obj16 = 0;
		ISFSObject iSFSObject2;
		ISFSObject iSFSObject = default(ISFSObject);
		if (iSFSObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj17 = (nint)0 & (nint)1;
			bool flag7 = obj17 == null;
			iSFSObject2 = iSFSObject;
			SFSObject sFSObject = (SFSObject)iSFSObject;
			if (!flag7)
			{
				goto IL_025a;
			}
		}
		else
		{
			object obj18 = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSObject sFSObject2 = default(SFSObject);
			sFSObject2..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj19 = (nint)0 & (nint)1;
			bool flag8 = obj19 == null;
			object obj20 = !flag8;
			iSFSObject = null;
			iSFSObject2 = null;
			if (obj20 != null)
			{
				goto IL_025a;
			}
		}
		_ = 1;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v8+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		iSFSObject = iSFSObject2;
		if (obj21 != null)
		{
			goto IL_0287;
		}
		goto IL_0378;
		IL_03dd:
		throw new NullReferenceException();
		IL_0391:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v4+20]");
		Room lastJoinedRoom = ((SmartFox)0).LastJoinedRoom;
		object obj22 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v5+198]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v5+1A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v175 @ X5_v1 (should have been resolved before IL gen)");
		goto IL_03dd;
	}

	public static void SendZoneExtensionRequest(string command, ISFSObject param = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_027b: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E839E]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01ce:
		object obj12 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 64;
		ISFSObject iSFSObject = default(ISFSObject);
		bool flag4 = iSFSObject == null;
		object obj13 = !flag4;
		SFSObject parameters = (SFSObject)iSFSObject;
		if (obj13 == null)
		{
			object obj14 = typeof(RegisteredWaitHandle) + 2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSObject sFSObject = default(SFSObject);
			sFSObject..ctor();
			parameters = sFSObject;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ExtensionRequest extensionRequest = default(ExtensionRequest);
		extensionRequest..ctor(command, parameters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+20]");
		((SmartFox)0).Send(extensionRequest);
		return;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj15 = default(object);
		bool flag5 = obj15 == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ce;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag6)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
	}

	public static void Login(string authToken, RequestJoinRoomInfo joinRoomRequest = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_06ac: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_0521: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_0702: Expected O, but got I4
		//IL_0720: Expected O, but got I
		//IL_0739: Expected O, but got I
		//IL_076a: Expected O, but got I4
		//IL_02eb: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0315: Expected O, but got I
		//IL_03bc: Expected O, but got I
		//IL_03e6: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01df: Expected O, but got I4
		//IL_0397: Expected O, but got I4
		//IL_033e: Expected O, but got I
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0438: Expected O, but got I4
		//IL_0448: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_0482: Expected O, but got I4
		//IL_05b5: Expected O, but got I4
		//IL_05be: Expected O, but got I4
		//IL_05c6: Expected O, but got I4
		//IL_05cf: Expected O, but got I4
		//IL_05d7: Expected O, but got I4
		//IL_0222: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_0287: Expected O, but got I4
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_0500: Expected O, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02dd: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object key = "placementId" + 40;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object key2 = "utf-32" + 168;
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
		Platform platform = KUtil.GetPlatform();
		SFSExtensions.Put(sFSObject, (string)key, (int)platform);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string version = Application.version;
		SFSExtensions.Put(sFSObject, (string)key2, version);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F6]");
			object obj10 = (nint)0 & (nint)1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				goto IL_014f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F6]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 == null)
			{
				goto IL_014f;
			}
		}
		goto IL_06ba;
		IL_0373:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj13 = default(object);
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0415;
		IL_06ba:
		object key3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2368;
		object obj15 = "alignContent" + 3016;
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v17+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8+10]");
		SFSExtensions.Put(sFSObject, (string)key3, (string)0);
		string text = (string)obj15;
		SFSExtensions.Put(sFSObject, (string)obj15, authToken);
		bool flag6 = joinRoomRequest == null;
		object obj19 = 0;
		string text2 = authToken;
		string <Password>k__BackingField;
		if (!flag6)
		{
			object obj20 = "rightCtrl" + 360;
			object obj21 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text3 = (string)obj20;
			SFSExtensions.Put(sFSObject, (string)obj20, joinRoomRequest.<RoomId>k__BackingField);
			object obj22 = (??)joinRoomRequest.<Seat>k__BackingField & 1;
			bool flag7 = obj22 == null;
			object obj23 = !flag7;
			object obj25;
			string text4;
			string <Password>k__BackingField2;
			if (obj23 == null)
			{
				<Password>k__BackingField = joinRoomRequest.<Password>k__BackingField;
				object obj24 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v49+E4]");
				bool flag8 = (nint)0 == 0;
				obj19 = 0;
				text2 = (string)joinRoomRequest.<RoomId>k__BackingField;
				obj25 = 0;
				text4 = (string)joinRoomRequest.<RoomId>k__BackingField;
				<Password>k__BackingField2 = joinRoomRequest.<Password>k__BackingField;
				if (!flag8)
				{
					goto IL_0260;
				}
			}
			else
			{
				int? num = default(int?);
				int value = num.Value;
				object obj26 = "rightCtrl" + 1552;
				text3 = (string)obj26;
				SFSExtensions.Put(sFSObject, (string)obj26, value);
				<Password>k__BackingField = joinRoomRequest.<Password>k__BackingField;
				object obj24 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v49+E4]");
				bool flag9 = (nint)0 == 0;
				object obj27 = !flag9;
				obj19 = 0;
				text2 = (string)value;
				obj25 = 0;
				text4 = (string)value;
				<Password>k__BackingField2 = joinRoomRequest.<Password>k__BackingField;
				if (obj27 != null)
				{
					goto IL_0260;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!StringsExtensions.IsNullOrEmpty(<Password>k__BackingField2))
			{
				goto IL_029a;
			}
			obj19 = obj25;
			text2 = text4;
			text = null;
		}
		goto IL_02e2;
		IL_0260:
		bool flag10 = StringsExtensions.IsNullOrEmpty(<Password>k__BackingField);
		bool flag11 = !flag10;
		object obj28 = !flag11;
		text = null;
		if (obj28 == null)
		{
			goto IL_029a;
		}
		goto IL_02e2;
		IL_029a:
		text2 = joinRoomRequest.<Password>k__BackingField;
		object obj29 = "rightCtrl" + 400;
		text = (string)obj29;
		SFSExtensions.Put(sFSObject, (string)obj29, joinRoomRequest.<Password>k__BackingField);
		obj19 = 0;
		goto IL_02e2;
		IL_02e2:
		object obj30 = 152993792;
		object obj31 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
		object obj32 = (nint)0 & (nint)1;
		if (obj32 != null)
		{
			object obj33 = (nint)0 + (nint)2152;
			object obj34 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v32+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = obj33;
			if (!flag12)
			{
				goto IL_0373;
			}
		}
		else
		{
			_ = 1;
			object obj33 = (nint)0 + (nint)2152;
			object obj34 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v32+E4]");
			bool flag13 = (nint)0 == 0;
			object obj36 = !flag13;
			object obj35 = obj33;
			if (obj36 != null)
			{
				goto IL_0373;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0415;
		IL_0415:
		object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj38 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X9_v3+90]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v4+B8]");
		object userName = 0;
		object obj40 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v24+E4]");
		bool flag14 = (nint)0 == 0;
		object obj41 = !flag14;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameConfiguration currentGameConfiguration = Config.CurrentGameConfiguration;
		object obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LoginRequest loginRequest = default(LoginRequest);
		loginRequest..ctor((string)userName, null, currentGameConfiguration.<Zone>k__BackingField, sFSObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v23+20]");
		((SmartFox)0).Send(loginRequest);
		return;
		IL_014f:
		_ = 1;
		goto IL_06ba;
	}

	public static void Logout()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_0322: Expected O, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0387: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_060b: Expected O, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_055e: Expected O, but got I
		//IL_056e: Expected O, but got I
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_0511: Expected O, but got I4
		//IL_05a3: Expected O, but got I
		//IL_05b3: Expected O, but got I
		//IL_05c3: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8351]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v54+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v54+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_05cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TabsUI.ClearLastTabs();
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v25+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0486;
		}
		goto IL_0619;
		IL_0619:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0486;
		IL_0486:
		object obj11 = typeof(RegisteredWaitHandle) + 1880;
		SfsTournamentConnector.OnLogout();
		User mySelf = MySelf;
		if (SFSKammelnaUserExtensions.IsSocialConnected(mySelf))
		{
			object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v36+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SocialUtilities.ClearSessions();
			bool flag5 = false;
		}
		Disconnect();
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v17+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v18+20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v18+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v19+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v19+40]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v19+28]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v149 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_05cd;
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj21 = default(object);
		bool flag6 = obj21 == null;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
		IL_0140:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+48]");
		if ((nint)0 != 0)
		{
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v46+E4]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v51+48]");
			MonoBehaviour monoBehaviour = default(MonoBehaviour);
			monoBehaviour.StopCoroutine((Coroutine)0);
		}
		object key = "October" + 3392;
		object key2 = "SetRoomVariables request error" + 1456;
		object key3 = "ThisIsFakeReceiptData" + 2744;
		object key4 = "m_StencilDeferredPS" + 1824;
		object reason = "LAK" + 2416;
		object obj25 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		object obj26 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Prefs.DeleteKey((string)key);
		Prefs.DeleteKey((string)key2);
		Prefs.DeleteKey((string)key3);
		Prefs.DeleteKey((string)key4);
		Authentication.Clear((string)reason);
		object obj27 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj28 = !flag8;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj29 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		ReferralHandler.ClearReferralPreferences(complete: true);
		MonthlyTournamentEligibility.ClearLastSavedEligibility();
		object obj30 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj32 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Store.ResetModels();
		object obj33 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj35 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3752;
		PredictAndWinManager.OnLogout();
		object obj36 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v20+E4]");
		bool flag11 = (nint)0 == 0;
		object obj37 = !flag11;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		FriendsManager.Logout();
		OfflineUserInfo.DiscardGame();
		object obj38 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v24+E4]");
		if ((nint)0 == 0)
		{
			goto IL_05cd;
		}
		TabsUI.ClearLastTabs();
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v25+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0486;
		}
		goto IL_0619;
	}

	public unsafe static void CreateRoom(string roomName = null, string password = null, int rankLimit = 0, int timer = 10, bool cheatingAllowed = true, bool isVoiceRoom = false, bool voiceForSpectators = false, int jackarooCutstomRules = 0, int tvUserId = 0, int clanId = 0, string testDeckCsv = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0028: Expected O, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0154: Expected I4, but got I8
		//IL_016c: Expected O, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_0271: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_021e: Expected O, but got I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(RegisteredWaitHandle) + 2040;
		object obj4 = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object key = "m_StencilDeferredPS" + 2872;
		string val = (string)((roomName != null) ? roomName : obj4);
		SFSExtensions.Put(sFSObject, (string)key, val);
		object key2 = "not" + 3560;
		string val2 = (string)((password != null) ? password : obj4);
		SFSExtensions.Put(sFSObject, (string)key2, val2);
		object key3 = "placementId" + 2064;
		SFSExtensions.Put(sFSObject, (string)key3, rankLimit);
		object key4 = "startPosition" + 3280;
		SFSExtensions.Put(sFSObject, (string)key4, timer);
		object key5 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		bool val3;
		if (cheatingAllowed)
		{
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			bool flag2 = GameExtensions.SupportsCheating(currentGame);
			val3 = flag2;
		}
		else
		{
			val3 = false;
		}
		SFSExtensions.Put(sFSObject, (string)key5, val3);
		object key6 = "utf-32" + 344;
		SFSExtensions.Put(sFSObject, (string)key6, isVoiceRoom);
		object key7 = "utf-32" + 360;
		SFSExtensions.Put(sFSObject, (string)key7, voiceForSpectators);
		object key8 = "java.io.FileOutputStream" + 280;
		SFSExtensions.Put(sFSObject, (string)key8, jackarooCutstomRules);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		int num = 0;
		bool flag3 = num == 0;
		object obj8 = 0;
		int num2 = jackarooCutstomRules;
		if (!flag3)
		{
			object key9 = "getSecondRescanTask" + 2056;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
			SFSExtensions.Put(sFSObject, (string)key9, 0);
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
			num2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+14]");
		if ((nint)0 >= (nint)1)
		{
			object key10 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3632;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+14]");
			SFSExtensions.Put(sFSObject, (string)key10, 0);
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+14]");
			num2 = 0;
		}
		object command = "com.unity.services.authentication.profile" + 1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		bool flag4 = string.IsNullOrEmpty((string)0);
		bool flag5 = !flag4;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				bool isProduction = Config.IsProduction;
				bool flag6 = !isProduction;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					goto IL_02f3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!Config.IsProduction)
				{
					goto IL_02f3;
				}
			}
		}
		goto IL_0321;
		IL_0321:
		SendZoneExtensionRequest((string)command, sFSObject);
		return;
		IL_02f3:
		object key11 = "startPosition" + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		SFSExtensions.Put(sFSObject, (string)key11, (string)0);
		goto IL_0321;
	}

	public static void TvGameCreationCheck(GameObject lifecycle, int tvUserId, Action<ISFSObject> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3128;
		object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 896;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, tvUserId);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, sFSObject, keepListening: false, callback);
	}

	public static void TvGameCreationClaim(GameObject lifecycle, int tvUserId, Action<ISFSObject> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3392;
		object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 896;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, tvUserId);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, sFSObject, keepListening: false, callback);
	}

	public static void TvGameCreationUnclaim(int tvUserId)
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
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "tournament_participate_warning_body_with_tickets_warning_daily" + 1568;
		object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 896;
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, tvUserId);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void JoinLobby()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "java.io.FileOutputStream" + 328;
		SendZoneExtensionRequest((string)command);
	}

	public static bool IsSubscribedToGroup(RoomGroup roomGroup)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_0365: Expected I4, but got O
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0235: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_028e: Expected I, but got O
		//IL_029e: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83A0]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_0357:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0389:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v250 @ X0_v9] (should have been resolved before IL gen)");
		bool result = default(bool);
		return result;
		IL_031a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0389;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = default(object);
		if (obj12 != null)
		{
			goto IL_01eb;
		}
		goto IL_0357;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = obj12 == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_01eb;
		}
		goto IL_0357;
		IL_01eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			object obj14 = typeof(RegisteredWaitHandle) + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v3+20]");
			IRoomManager roomManager = ((SmartFox)0).RoomManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			if (roomManager != null)
			{
				object obj15 = typeof(System.IOAsyncCallback) + 936;
				nint num = (nint)roomManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_031a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X10_v5-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_031a;
				}
				object obj18 = obj17 + 7;
				object obj19 = num + obj18;
				object obj20 = obj19 + 312;
				goto IL_0389;
			}
		}
		goto IL_0357;
	}

	public static bool IsSubscribedToGroup(string groupTag)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_036f: Expected I4, but got O
		//IL_0221: Expected O, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_025e: Expected I, but got O
		//IL_026e: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83A1]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_02ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj13 = default(object);
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v6+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0316;
		IL_0361:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0316:
		object obj16 = default(object);
		object obj15 = obj16 + 7;
		nint num;
		object obj17 = num + obj15;
		object obj18 = obj17 + 312;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v9+8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v127 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_0361;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj21 = default(object);
		if (obj21 != null)
		{
			goto IL_01eb;
		}
		goto IL_0361;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = obj21 == null;
		object obj22 = !flag5;
		if (obj22 != null)
		{
			goto IL_01eb;
		}
		goto IL_0361;
		IL_01eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+20]");
			IRoomManager roomManager = ((SmartFox)0).RoomManager;
			if (roomManager != null)
			{
				object obj23 = typeof(System.IOAsyncCallback) + 936;
				num = (nint)roomManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ea;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IRoomManager>)+B0]");
				obj16 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v4-8]");
					if (0 == (nint)obj23)
					{
						break;
					}
					obj16 += 16;
					obj24--;
					if ((nint)obj24 != 1)
					{
						continue;
					}
					goto IL_02ea;
				}
				goto IL_0316;
			}
		}
		goto IL_0361;
	}

	public static void JoinRoomGroup(RoomGroup roomGroup)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (!IsSubscribedToGroup(roomGroup))
		{
			object obj = "placementId" + 4016;
			object obj2 = (nint)0 + (nint)3488;
			object command = "java.io.FileOutputStream" + 376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30254F4");
			ISFSObject param = default(ISFSObject);
			SendZoneExtensionRequest((string)command, param);
		}
	}

	public static void JoinGameRoom(int roomId, int seatIndex, string password)
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
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "rightCtrl" + 360;
		object key2 = "rightCtrl" + 1552;
		object key3 = "not" + 3560;
		object command = "java.io.FileOutputStream" + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, roomId);
		SFSExtensions.Put(sFSObject, (string)key2, seatIndex);
		SFSExtensions.Put(sFSObject, (string)key3, password);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public unsafe static void LoadRoomsList<T>(GameObject lifecycle, RoomsFilterModel filterModel, Action<List<T>, string> callback) where T : GameRoomData
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		((<>c__DisplayClass329_0<T>)obj4)..ctor();
		object obj5 = obj4 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag2 = filterModel == null;
		Action<List<T>, string> action = callback;
		ISFSObject param = (ISFSObject)filterModel;
		if (!flag2)
		{
			ISFSObject iSFSObject = filterModel.ToSfsObject();
			action = null;
			param = iSFSObject;
		}
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass329_0<T>.<LoadRoomsList>b__0));
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object command = "rightCtrl" + 200;
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, param, keepListening: false, action2);
	}

	public static void SendChatMessage(string message, string messageTag = "")
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
		object key = "m_StencilDeferredPS" + 2616;
		object key2 = "startPosition" + 2256;
		object command = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, message);
		SFSExtensions.Put(sFSObject, (string)key2, messageTag);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void AnnounceBeggarBan(string message, long userId)
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
		object key = "m_StencilDeferredPS" + 2616;
		object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
		object command = "___# Content push apply failed [{0}]: {1}" + 2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, message);
		SFSExtensions.Put(sFSObject, (string)key2, userId);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendRefreshStatus()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "rightCtrl" + 600;
		SendZoneExtensionRequest((string)command);
	}

	public static void SendRefreshUserLikes(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
		object command = "rightCtrl" + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, userId);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendRefreshBanStatus(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
		object command = "placementId" + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, userId);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendRefreshInventory()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "placementId" + 4032;
		SendZoneExtensionRequest((string)command);
	}

	public static void SendNotifyNameChanged()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "not" + 216;
		SendZoneExtensionRequest((string)command);
	}

	public static void NotifyAvatarUpdated(bool hasAvatar = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1880;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+F8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ X8_v5+18] (should have been resolved before IL gen)");
		}
		object command = "rightCtrl" + 600;
		SendZoneExtensionRequest((string)command);
	}

	public static void SendVariablesUpdate(List<UserVariable> vars)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_0213: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83A4]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01ce:
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SetUserVariablesRequest setUserVariablesRequest = default(SetUserVariablesRequest);
		setUserVariablesRequest..ctor(vars);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+20]");
		((SmartFox)0).Send(setUserVariablesRequest);
		return;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj13 = default(object);
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ce;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_01ce;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag5)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
	}

	public static void SendEnableLocationBasedSubscription(double lat, double lng)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_020d: Expected I, but got O
		//IL_021d: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		object obj3 = "java.io.FileOutputStream" + 1256;
		object obj4 = "java.io.FileOutputStream" + 3256;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v11-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00df;
		}
		object obj7 = obj6 + 38;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_01ec;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01ec;
		IL_01ec:
		object command = "java.io.FileOutputStream" + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X0_v5] (should have been resolved before IL gen)");
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0173;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X10_v6-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0173;
		}
		object obj12 = obj11 + 38;
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		goto IL_0266;
		IL_0266:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v288 @ X0_v8] (should have been resolved before IL gen)");
		SendZoneExtensionRequest((string)command, sFSObject);
		return;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0266;
	}

	public static void GetMainRoomOnlineUsersList(GameObject lifecycle, long lastUpdate, Action<UsersListModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0134: Expected I, but got O
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0184: Expected I, but got O
		//IL_010c: Expected O, but got I4
		//IL_00f8: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2400;
		object obj2 = (nint)0 + (nint)3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v3 (System.IntPtr)+8]");
		SendSfsRequestDelegate sendSfsRequestDelegate = default(SendSfsRequestDelegate);
		((Delegate)sendSfsRequestDelegate).method_ptr = (IntPtr)0;
		((Delegate)sendSfsRequestDelegate).method = method;
		object obj3 = sendSfsRequestDelegate + 32;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)sendSfsRequestDelegate).method_code = (IntPtr)sendSfsRequestDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj4 = default(object);
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v3 (System.IntPtr)+52]");
			if ((nint)0 == 5)
			{
				nint invoke_impl = 35900584;
				((Delegate)sendSfsRequestDelegate).invoke_impl = invoke_impl;
			}
			else
			{
				((Delegate)sendSfsRequestDelegate).invoke_impl = ((Delegate)sendSfsRequestDelegate).method_ptr;
				((Delegate)sendSfsRequestDelegate).method_code = (IntPtr)((Delegate)sendSfsRequestDelegate).m_target;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v3 (System.IntPtr)+52]");
			if ((nint)0 != 4)
			{
				object obj5 = 134782976 + 1449;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
				throw new OutOfMemoryException();
			}
			nint invoke_impl2 = 35900536;
			((Delegate)sendSfsRequestDelegate).invoke_impl = invoke_impl2;
		}
		nint extra_arg = 35900404;
		((Delegate)sendSfsRequestDelegate).extra_arg = extra_arg;
		GetOnlineUsersList(sendSfsRequestDelegate, lifecycle, lastUpdate, successCallback, useCacheCallback, onError);
	}

	public static void GetCurrentRoomOnlineUsersList(GameObject lifecycle, long lastUpdate, Action<UsersListModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0134: Expected I, but got O
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0184: Expected I, but got O
		//IL_010c: Expected O, but got I4
		//IL_00f8: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2400;
		object obj2 = (nint)0 + (nint)3504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v3 (System.IntPtr)+8]");
		SendSfsRequestDelegate sendSfsRequestDelegate = default(SendSfsRequestDelegate);
		((Delegate)sendSfsRequestDelegate).method_ptr = (IntPtr)0;
		((Delegate)sendSfsRequestDelegate).method = method;
		object obj3 = sendSfsRequestDelegate + 32;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)sendSfsRequestDelegate).method_code = (IntPtr)sendSfsRequestDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj4 = default(object);
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v3 (System.IntPtr)+52]");
			if ((nint)0 == 5)
			{
				nint invoke_impl = 35900584;
				((Delegate)sendSfsRequestDelegate).invoke_impl = invoke_impl;
			}
			else
			{
				((Delegate)sendSfsRequestDelegate).invoke_impl = ((Delegate)sendSfsRequestDelegate).method_ptr;
				((Delegate)sendSfsRequestDelegate).method_code = (IntPtr)((Delegate)sendSfsRequestDelegate).m_target;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X25_v3 (System.IntPtr)+52]");
			if ((nint)0 != 4)
			{
				object obj5 = 134782976 + 1449;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
				throw new OutOfMemoryException();
			}
			nint invoke_impl2 = 35900536;
			((Delegate)sendSfsRequestDelegate).invoke_impl = invoke_impl2;
		}
		nint extra_arg = 35900404;
		((Delegate)sendSfsRequestDelegate).extra_arg = extra_arg;
		GetOnlineUsersList(sendSfsRequestDelegate, lifecycle, lastUpdate, successCallback, useCacheCallback, onError);
	}

	public static void SendPinMessage(string message)
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_008a: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		Room lastJoinedRoom = LastJoinedRoom;
		object key;
		object key2;
		object command;
		SFSObject sFSObject = default(SFSObject);
		if (lastJoinedRoom != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 2040;
			object obj2 = typeof(RegisteredWaitHandle) + 1376;
			key = "rightCtrl" + 360;
			key2 = "not" + 4024;
			command = "not" + 3712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			nint num = (nint)lastJoinedRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0106;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v5-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_0106;
			}
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_01d8;
		}
		object obj7 = typeof(MemberAchievementClanFeedData) + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NullReferenceException ex = default(NullReferenceException);
		ex..ctor();
		object obj8 = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_01d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ X0_v14] (should have been resolved before IL gen)");
		int val = default(int);
		SFSExtensions.Put(sFSObject, (string)key, val);
		string val2 = default(string);
		SFSExtensions.Put(sFSObject, (string)key2, val2);
		SendZoneExtensionRequest((string)command, sFSObject);
		return;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01d8;
	}

	private static void GetOnlineUsersList(SendSfsRequestDelegate sendSfsRequest, GameObject lifecycle, long lastUpdate, Action<UsersListModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_010a: Expected I, but got O
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2288;
		<>c__DisplayClass344_0 <>c__DisplayClass344_ = default(<>c__DisplayClass344_0);
		SFSObject sFSObject = default(SFSObject);
		Action<object> action = default(Action<object>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass344_..ctor();
			object obj2 = typeof(RegisteredWaitHandle) + 2040;
			object key = "java.io.FileOutputStream" + 3592;
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj4 = (nint)0 + (nint)1176;
			object obj5 = <>c__DisplayClass344_ + 16;
			obj5 = onError;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = <>c__DisplayClass344_ + 24;
			obj6 = useCacheCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = <>c__DisplayClass344_ + 32;
			obj7 = successCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			sFSObject..ctor();
			SFSExtensions.Put(sFSObject, (string)key, lastUpdate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor((object)<>c__DisplayClass344_, (IntPtr)obj4);
			object obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1448;
			object obj9 = obj8;
			IntPtr invoke_impl = ((Delegate)sendSfsRequest).invoke_impl;
			IntPtr method_code = ((Delegate)sendSfsRequest).method_code;
			IntPtr method = ((Delegate)sendSfsRequest).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v129 @ X7_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static User GetOnlineUser(string userDbId)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_0221: Expected O, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_025e: Expected I, but got O
		//IL_026e: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83A5]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2152;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_02ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj13 = default(object);
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v6+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0316;
		IL_0361:
		return (User)new NullReferenceException();
		IL_0316:
		object obj16 = default(object);
		object obj15 = obj16 + 3;
		nint num;
		object obj17 = num + obj15;
		object obj18 = obj17 + 312;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v9+8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v127 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_0361;
		IL_008b:
		obj8 = (nint)0 + (nint)2152;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00cc;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj21 = default(object);
		if (obj21 != null)
		{
			goto IL_01eb;
		}
		goto IL_0361;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = obj21 == null;
		object obj22 = !flag5;
		if (obj22 != null)
		{
			goto IL_01eb;
		}
		goto IL_0361;
		IL_01eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+20]");
			IUserManager userManager = ((SmartFox)0).UserManager;
			if (userManager != null)
			{
				object obj23 = typeof(System.IOAsyncCallback) + 1984;
				num = (nint)userManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IUserManager>)+12E]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IUserManager>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ea;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Managers.IUserManager>)+B0]");
				obj16 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v4-8]");
					if (0 == (nint)obj23)
					{
						break;
					}
					obj16 += 16;
					obj24--;
					if ((nint)obj24 != 1)
					{
						continue;
					}
					goto IL_02ea;
				}
				goto IL_0316;
			}
		}
		goto IL_0361;
	}

	public unsafe static bool CheckIsOnline(int userDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_06c3: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024b: Expected I, but got O
		//IL_025b: Expected O, but got I
		//IL_02f1: Expected O, but got I
		//IL_0315: Expected O, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03e4: Expected O, but got I
		//IL_0296: Expected O, but got I
		//IL_047a: Expected O, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04ac: Expected O, but got I4
		//IL_0333: Expected O, but got I
		//IL_041f: Expected O, but got I
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0587: Expected O, but got I4
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_0379: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_04c3: Expected O, but got I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0501: Expected O, but got I
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_0533: Expected O, but got I4
		//IL_05dc: Expected O, but got I
		//IL_05ed: Expected I, but got O
		//IL_05f9: Expected O, but got I
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0629: Expected O, but got I4
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_06a7: Expected I8, but got I4
		//IL_0686: Expected I8, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass346_0 <>c__DisplayClass346_ = default(<>c__DisplayClass346_0);
		<>c__DisplayClass346_..ctor();
		int num;
		object obj9 = default(object);
		if (<>c__DisplayClass346_ != null)
		{
			num = <>c__DisplayClass346_ + 16;
			((int*)num)->m_value = userDbId;
			string userDbId2 = ((int*)num)->ToString();
			User onlineUser = GetOnlineUser(userDbId2);
			if (onlineUser != null)
			{
				goto IL_0070;
			}
			object obj2 = 152993792;
			object obj3 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8390]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				object obj5 = (nint)0 + (nint)2152;
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v42+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = obj5;
				if (!flag)
				{
					goto IL_0107;
				}
			}
			else
			{
				_ = 1;
				object obj5 = (nint)0 + (nint)2152;
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v42+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj7 = obj5;
				if (obj8 != null)
				{
					goto IL_0107;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj9 != null)
			{
				goto IL_01c6;
			}
		}
		goto IL_06b5;
		IL_03b8:
		object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3544;
		object obj12 = default(object);
		object obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v25+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v25+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0460;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v25+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v6-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0460;
		}
		object obj15 = obj14 + 5;
		object obj16 = obj11 + obj15;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v28+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X8_v28] (should have been resolved before IL gen)");
		object obj19 = default(object);
		object obj18 = obj19 & 1;
		bool flag3 = obj18 == null;
		object obj20 = !flag3;
		object obj22;
		object obj21 = obj22;
		if (obj20 != null)
		{
			goto IL_0070;
		}
		goto IL_0549;
		IL_0460:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v31+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ X0_v31] (should have been resolved before IL gen)");
		object obj24 = default(object);
		object obj23 = obj24 & 1;
		bool flag4 = obj23 == null;
		object obj25 = !flag4;
		if (obj25 != null)
		{
			goto IL_0070;
		}
		obj21 = 5;
		goto IL_0549;
		IL_06b5:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0070:
		return true;
		IL_0549:
		object obj26 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj28 = !flag5;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> onlineFriendsList = FriendsManager.OnlineFriendsList;
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)1184;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass346_, (IntPtr)obj30);
		object obj31 = (nint)0 + (nint)2568;
		bool flag6 = Enumerable.Any(onlineFriendsList, func);
		bool flag7 = !flag6;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			object obj33 = typeof(System.Buffers.Text.ParserHelpers) + 1680;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v23+E4]");
			if ((nint)0 != 0)
			{
				return PresenceManager.IsOnline(((int*)num)->m_value);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return PresenceManager.IsOnline(((int*)num)->m_value);
		}
		goto IL_0070;
		IL_0107:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = obj9 == null;
		object obj35 = !flag8;
		if (obj35 != null)
		{
			goto IL_01c6;
		}
		goto IL_06b5;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v9+20]");
		string text2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v9+20]");
			IBuddyManager buddyManager = ((SmartFox)0).BuddyManager;
			text2 = ((int*)num)->ToString();
			if (buddyManager != null)
			{
				object obj36 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1296;
				nint num2 = (nint)buddyManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Managers.IBuddyManager>)+12E]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Managers.IBuddyManager>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02d7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Managers.IBuddyManager>)+B0]");
				object obj38 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v11-8]");
					if (0 == (nint)obj36)
					{
						break;
					}
					obj38 += 16;
					obj37--;
					if ((nint)obj37 != 1)
					{
						continue;
					}
					goto IL_02d7;
				}
				object obj39 = obj38 + 7;
				object obj40 = num2 + obj39;
				object obj41 = obj40 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v39+8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v342 @ X0_v39] (should have been resolved before IL gen)");
				bool flag9 = obj12 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v39+8]");
				obj21 = 0;
				text = text2;
				if (!flag9)
				{
					goto IL_03b8;
				}
				goto IL_0549;
			}
		}
		goto IL_06b5;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v36+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ X0_v36] (should have been resolved before IL gen)");
		bool flag10 = obj12 == null;
		object obj42 = !flag10;
		if (obj42 != null)
		{
			goto IL_03b8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v36+8]");
		obj21 = 0;
		text = text2;
		goto IL_0549;
	}

	public static void JoinTournamentRoom(TournamentData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object key = "rightCtrl" + 360;
		object command = "java.io.FileOutputStream" + 344;
		object obj = typeof(UsageHint) + 72;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, data.<RoomId>k__BackingField);
		SendZoneExtensionRequest((string)command, param);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.LastJoinedTournamentRoomId = data.<RoomId>k__BackingField;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.LastJoinedTournamentRoomId = data.<RoomId>k__BackingField;
	}

	public static void JoinSpawnerTournament(int spawnerId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "setMimeType" + 2432;
		object command = "java.io.FileOutputStream" + 432;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, spawnerId);
		SendZoneExtensionRequest((string)command, param);
	}

	public static void SendTournamentRoomLoaded()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "startPosition" + 3392;
		SendRoomExtensionRequest((string)command);
	}

	public static void WatchTournamentMatch(int matchId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "m_StencilDeferredPS" + 1496;
		object command = "utf-32" + 1544;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, matchId);
		SendRoomExtensionRequest((string)command, param);
	}

	public static void SendLoadTournamentRequest(long tournamentId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "startPosition" + 3152;
		object command = "java.io.FileOutputStream" + 1936;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, tournamentId);
		SendZoneExtensionRequest((string)command, param);
	}

	public static void ParticipateTournament(GameObject lifecycle, TournamentsEventsChannel eventsChannel, TournamentData data, string password, List<Vector2> captchaSolution, TournamentParticipateError onError, TournamentParticipateSuccess onSuccess)
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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_022e: Expected O, but got I4
		//IL_0161: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0298: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_02b2: Expected O, but got I4
		//IL_02ba: Expected I4, but got O
		//IL_03a7: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03f0: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_0321: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_036a: Expected O, but got I4
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07ba: Expected O, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_049e: Expected I, but got O
		//IL_04ae: Expected O, but got I
		//IL_0428: Expected O, but got I4
		//IL_0813: Expected O, but got I4
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		//IL_0921: Expected O, but got I
		//IL_0932: Expected I, but got O
		//IL_0950: Expected O, but got I
		//IL_096b: Expected O, but got I4
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_09b4: Expected O, but got I
		//IL_04e9: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected O, but got Unknown
		//IL_060d: Expected O, but got I
		//IL_061d: Expected O, but got I
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0656: Expected O, but got I4
		//IL_0666: Expected O, but got I
		//IL_0870: Expected I, but got O
		//IL_089a: Expected O, but got I4
		//IL_0a11: Expected I, but got O
		//IL_0a21: Expected O, but got I
		//IL_0577: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_05c0: Expected O, but got I4
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_069e: Expected O, but got I4
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_0aea: Expected O, but got I
		//IL_0afc: Expected I4, but got O
		//IL_0708: Expected O, but got I
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Expected O, but got Unknown
		//IL_0a70: Expected O, but got I
		//IL_0a81: Expected I, but got O
		//IL_0a9f: Expected O, but got I
		//IL_05de: Expected O, but got I
		//IL_06dd: Expected O, but got I4
		//IL_06ce: Expected O, but got I
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected O, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass358_0 <>c__DisplayClass358_ = default(<>c__DisplayClass358_0);
		<>c__DisplayClass358_..ctor();
		object obj2 = typeof(RegisteredWaitHandle) + 2040;
		object obj3 = <>c__DisplayClass358_ + 16;
		obj3 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = <>c__DisplayClass358_ + 24;
		obj4 = eventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = <>c__DisplayClass358_ + 32;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass358_ + 56;
		obj6 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj7 = obj6;
		object key = "rightCtrl" + 360;
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+30]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+30]");
		SFSExtensions.Put(sFSObject, (string)key, 0);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v20+E4]");
		object obj10;
		object obj11;
		if ((nint)0 != 0)
		{
			obj10 = (nint)0 + (nint)2848;
			bool flag = StringsExtensions.IsNullOrEmpty(password);
			bool flag2 = !flag;
			obj11 = obj10;
			if (!flag2)
			{
				goto IL_0193;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = (nint)0 + (nint)2848;
			bool flag3 = StringsExtensions.IsNullOrEmpty(password);
			bool flag4 = !flag3;
			object obj12 = !flag4;
			obj11 = obj10;
			if (obj12 != null)
			{
				goto IL_0193;
			}
		}
		object key2 = "not" + 3560;
		SFSExtensions.Put(sFSObject, (string)key2, password);
		object obj13 = obj11;
		bool flag5 = ArraysExtensions.IsNullOrEmpty(captchaSolution);
		bool flag6 = !flag5;
		object obj14 = !flag6;
		object obj15 = 0;
		string text = password;
		object obj16 = 0;
		num = (int)password;
		GameObject go = lifecycle;
		if (obj14 == null)
		{
			goto IL_02d0;
		}
		goto IL_08ea;
		IL_067c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v61+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		object obj19;
		object obj20;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v29+B8]");
			obj20 = 0;
		}
		object obj21 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)1072;
		Func<Vector2, double> func = default(Func<Vector2, double>);
		func..ctor(obj20, (IntPtr)obj22);
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v28+B8]");
		object obj24 = (nint)0 + (nint)72;
		obj24 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = 0;
		Func<Vector2, double> selector = func;
		object obj27;
		object obj26 = obj27;
		goto IL_09eb;
		IL_08ea:
		object obj28 = obj6;
		object obj29 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj30 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj31 = (nint)0 + (nint)1192;
		object obj32 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		User mySelf = MySelf;
		int tournamentJoiningDiscount = SFSKammelnaUserExtensions.GetTournamentJoiningDiscount(mySelf);
		object obj33 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj34 = !flag8;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object command = "placementId" + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+94]");
		int val = (int)(-tournamentJoiningDiscount);
		int joinCost = Math.Max(0, val);
		<>c__DisplayClass358_.joinCost = joinCost;
		User mySelf2 = MySelf;
		TicketRecord tickets = SFSKammelnaUserExtensions.GetTickets(mySelf2, TicketType.OfficialTournament);
		object obj35 = <>c__DisplayClass358_ + 48;
		obj35 = tickets;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass358_, (IntPtr)obj31);
		object obj36 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v34+E4]");
		bool flag9 = (nint)0 == 0;
		object obj37 = !flag9;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(go, (string)command, sFSObject, keepListening: false, action);
		return;
		IL_045d:
		Func<Vector2, double> selector2;
		IEnumerable<double> source = Enumerable.Select(captchaSolution, selector2);
		double[] array = Enumerable.ToArray(source);
		object obj38 = typeof(System.IOAsyncCallback) + 976;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_052a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj40 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X10_v13-8]");
			if (0 == (nint)obj38)
			{
				break;
			}
			obj40 += 16;
			obj39--;
			if ((nint)obj39 != 1)
			{
				continue;
			}
			goto IL_052a;
		}
		object obj41 = obj40 + 47;
		object obj42 = num2 + obj41;
		object obj43 = obj42 + 312;
		goto IL_09a4;
		IL_0193:
		obj13 = obj10;
		flag5 = ArraysExtensions.IsNullOrEmpty(captchaSolution);
		bool flag10 = !flag5;
		obj15 = 0;
		text = (string)num;
		if (flag10)
		{
			goto IL_02d0;
		}
		obj16 = 0;
		go = lifecycle;
		goto IL_08ea;
		IL_02d0:
		obj19 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
		object obj44 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v74+E4]");
		object obj45;
		object obj49;
		object obj47;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v74+B8]");
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v35+40]");
			selector2 = (Func<Vector2, double>)0;
			object obj46 = "com.unity.services.authentication.profile" + 2720;
			obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v35+40]");
			bool flag11 = (nint)0 == 0;
			object obj48 = !flag11;
			if (obj48 == null)
			{
				obj49 = obj46;
				goto IL_0406;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj44 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v74+B8]");
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v35+40]");
			selector2 = (Func<Vector2, double>)0;
			object obj50 = "com.unity.services.authentication.profile" + 2720;
			obj49 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v35+40]");
			bool flag12 = (nint)0 == 0;
			object obj51 = !flag12;
			obj47 = obj50;
			if (obj51 == null)
			{
				goto IL_0406;
			}
		}
		goto IL_045d;
		IL_052a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09a4;
		IL_0ada:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v55+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v679 @ X0_v55] (should have been resolved before IL gen)");
		double[] array2;
		num = (int)array2;
		go = lifecycle;
		goto IL_08ea;
		IL_09a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v47+8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v538 @ X0_v47] (should have been resolved before IL gen)");
		object obj52 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v61+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v61+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v23+48]");
			selector = (Func<Vector2, double>)0;
			object obj53 = "com.unity.services.authentication.profile" + 2728;
			obj26 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v23+48]");
			bool flag13 = (nint)0 == 0;
			object obj54 = !flag13;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v23+48]");
				Func<Vector2, double> func2 = (Func<Vector2, double>)0;
				obj27 = obj53;
				goto IL_067c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj52 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v61+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v23+48]");
			Func<Vector2, double> func2 = (Func<Vector2, double>)0;
			object obj55 = "com.unity.services.authentication.profile" + 2728;
			obj27 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v23+48]");
			bool flag14 = (nint)0 == 0;
			object obj56 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v23+48]");
			selector = (Func<Vector2, double>)0;
			obj26 = obj55;
			if (obj56 == null)
			{
				goto IL_067c;
			}
		}
		goto IL_09eb;
		IL_0406:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v74+E4]");
		bool flag15 = (nint)0 == 0;
		object obj57 = !flag15;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj58 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v41+B8]");
			obj45 = 0;
		}
		object obj59 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj60 = (nint)0 + (nint)1064;
		Func<Vector2, double> func3 = default(Func<Vector2, double>);
		func3..ctor(obj45, (IntPtr)obj60);
		object obj61 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v40+B8]");
		object obj62 = (nint)0 + (nint)64;
		obj62 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj15 = 0;
		selector2 = func3;
		obj47 = obj49;
		goto IL_045d;
		IL_0749:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ada;
		IL_09eb:
		IEnumerable<double> source2 = Enumerable.Select(captchaSolution, selector);
		array2 = Enumerable.ToArray(source2);
		nint num3 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0749;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj64 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X10_v8-8]");
			if (0 == (nint)obj38)
			{
				break;
			}
			obj64 += 16;
			obj63--;
			if ((nint)obj63 != 1)
			{
				continue;
			}
			goto IL_0749;
		}
		object obj65 = obj64 + 47;
		object obj66 = num3 + obj65;
		object obj67 = obj66 + 312;
		goto IL_0ada;
	}

	public static void ForfeitTournament(GameObject lifecycle, TournamentsEventsChannel eventsChannel, TournamentData data, TournamentError onError, TournamentParticipateSuccess onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_0135: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass359_0 <>c__DisplayClass359_ = default(<>c__DisplayClass359_0);
		<>c__DisplayClass359_..ctor();
		object obj2 = <>c__DisplayClass359_ + 16;
		obj2 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <>c__DisplayClass359_ + 24;
		obj3 = eventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = <>c__DisplayClass359_ + 32;
		obj4 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object key = "rightCtrl" + 360;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj6 = (nint)0 + (nint)1200;
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "java.io.FileOutputStream" + 3512;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, data.<RoomId>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass359_, (IntPtr)obj6);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, param, keepListening: false, action);
	}

	public static void GetMyTournaments(GameObject lifecycle, TournamentSeatsSuccess onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_009c: Expected I, but got O
		//IL_00c6: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass360_0 <>c__DisplayClass360_ = default(<>c__DisplayClass360_0);
		<>c__DisplayClass360_..ctor();
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj3 = (nint)0 + (nint)1208;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "getSecondRescanTask" + 1712;
		object obj5 = <>c__DisplayClass360_ + 16;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass360_, (IntPtr)obj3);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, null, keepListening: false, action);
	}

	public static void SendEnableTournamentWatchersChat(bool enable)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "destinationTimeZone" + 2264;
		object command = "destinationTimeZone" + 3152;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, enable);
		SendRoomExtensionRequest((string)command, param);
	}

	public static void JoinMassTournamentRoom(MassTournamentInfo data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object key = "rightCtrl" + 360;
		object command = "java.io.FileOutputStream" + 344;
		object obj = typeof(UsageHint) + 72;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, data.<RoomId>k__BackingField);
		SendZoneExtensionRequest((string)command, param);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.LastJoinedMassTournamentRoomId = data.<RoomId>k__BackingField;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.LastJoinedMassTournamentRoomId = data.<RoomId>k__BackingField;
	}

	public static void ParticipateMassTournament(GameObject lifecycle, MassTournamentInfo data, string code, TournamentParticipateError onError, TournamentParticipateSuccess onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01a0: Expected I, but got O
		//IL_01cf: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0169: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass363_0 <>c__DisplayClass363_ = default(<>c__DisplayClass363_0);
		<>c__DisplayClass363_..ctor();
		object obj2 = typeof(RegisteredWaitHandle) + 2040;
		object obj3 = <>c__DisplayClass363_ + 16;
		obj3 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = <>c__DisplayClass363_ + 24;
		obj4 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object key = "rightCtrl" + 360;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj6 = (nint)0 + (nint)1216;
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		SFSExtensions.Put(sFSObject, (string)key, data.<RoomId>k__BackingField);
		bool flag = string.IsNullOrWhiteSpace(code);
		bool flag2 = !flag;
		object obj8 = !flag2;
		object obj9 = 0;
		string text = (string)data.<RoomId>k__BackingField;
		string text2 = null;
		if (obj8 == null)
		{
			object obj10 = "placementId" + 2840;
			text2 = (string)obj10;
			SFSExtensions.Put(sFSObject, (string)obj10, code);
			obj9 = 0;
			text = code;
		}
		object command = "placementId" + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass363_, (IntPtr)obj6);
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, sFSObject, keepListening: false, action);
	}

	public static void GetMassWinnersList(GameObject lifecycle, TournamentError onError, MassWinnersListSuccess onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass364_0 <>c__DisplayClass364_ = default(<>c__DisplayClass364_0);
		<>c__DisplayClass364_..ctor();
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj3 = (nint)0 + (nint)1224;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 1424;
		object obj5 = <>c__DisplayClass364_ + 16;
		obj5 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass364_ + 24;
		obj6 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass364_, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(lifecycle, (string)command, null, keepListening: false, action);
	}

	public static void GetMassTournamentStagesSummery(GameObject lifecycle, TournamentError onError, MassStagesListSuccess onSuccess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00eb: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass365_0 <>c__DisplayClass365_ = default(<>c__DisplayClass365_0);
		<>c__DisplayClass365_..ctor();
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj3 = (nint)0 + (nint)1232;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2648;
		object obj5 = <>c__DisplayClass365_ + 16;
		obj5 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass365_ + 24;
		obj6 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass365_, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(lifecycle, (string)command, null, keepListening: false, action);
	}

	public static void SendClaimCurrencyBomb(GameObject lifecycle, long bombId, List<Vector2> captchaSolution, CurrencyBombClaim callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_0483: Expected O, but got I
		//IL_0493: Expected O, but got I
		//IL_04b5: Expected O, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0166: Expected I, but got O
		//IL_0176: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04ed: Expected O, but got I
		//IL_04fe: Expected I, but got O
		//IL_051c: Expected O, but got I
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_057e: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_0122: Expected O, but got I
		//IL_02c6: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_0300: Expected O, but got I4
		//IL_0310: Expected O, but got I
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05d5: Expected O, but got I
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_060f: Expected I, but got O
		//IL_061f: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_024f: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0348: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_070c: Expected I, but got O
		//IL_0736: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_066e: Expected O, but got I
		//IL_067f: Expected I, but got O
		//IL_069d: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_0386: Expected O, but got I4
		//IL_0378: Expected O, but got I
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass367_0 <>c__DisplayClass367_ = default(<>c__DisplayClass367_0);
		<>c__DisplayClass367_..ctor();
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 240;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
		object obj3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1888;
		object obj4 = <>c__DisplayClass367_ + 16;
		CurrencyBombClaim currencyBombClaim = default(CurrencyBombClaim);
		obj4 = currencyBombClaim;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ISFSObject iSFSObject = SfsObjectUtil.FromOneValue((string)key, bombId);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v12+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+50]");
		Func<Vector2, double> selector = (Func<Vector2, double>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+50]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v35+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)1088;
			Func<Vector2, double> func = default(Func<Vector2, double>);
			func..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v34+B8]");
			object obj14 = (nint)0 + (nint)80;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<double> source = Enumerable.Select(captchaSolution, selector);
		double[] array = Enumerable.ToArray(source);
		object obj15 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01f2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v11-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_01f2;
		}
		object obj18 = obj17 + 47;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		goto IL_055f;
		IL_0326:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v37+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		object obj23;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v24+B8]");
			obj23 = 0;
		}
		object obj24 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)1096;
		Func<Vector2, double> func2 = default(Func<Vector2, double>);
		func2..ctor(obj23, (IntPtr)obj25);
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v23+B8]");
		object obj27 = (nint)0 + (nint)88;
		obj27 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj28 = 0;
		Func<Vector2, double> selector2 = func2;
		object obj30;
		object obj29 = obj30;
		goto IL_05b5;
		IL_03f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06d8;
		IL_06d8:
		object command = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v486 @ X0_v25] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		object obj31;
		action..ctor((object)<>c__DisplayClass367_, (IntPtr)obj31);
		object obj33;
		object obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v30+E4]");
		bool flag5 = (nint)0 == 0;
		object obj34 = !flag5;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, iSFSObject, keepListening: false, action);
		return;
		IL_055f:
		object obj35 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v17+8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v346 @ X0_v17] (should have been resolved before IL gen)");
		object obj36 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v37+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v18+58]");
			selector2 = (Func<Vector2, double>)0;
			obj29 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v18+58]");
			bool flag6 = (nint)0 == 0;
			object obj37 = !flag6;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v18+58]");
				Func<Vector2, double> func3 = (Func<Vector2, double>)0;
				obj30 = obj35;
				goto IL_0326;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v18+58]");
			Func<Vector2, double> func3 = (Func<Vector2, double>)0;
			obj30 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v18+58]");
			bool flag7 = (nint)0 == 0;
			object obj38 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v18+58]");
			selector2 = (Func<Vector2, double>)0;
			obj29 = obj35;
			if (obj38 == null)
			{
				goto IL_0326;
			}
		}
		goto IL_05b5;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_055f;
		IL_05b5:
		object obj39 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		obj31 = (nint)0 + (nint)1240;
		obj33 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		IEnumerable<double> source2 = Enumerable.Select(captchaSolution, selector2);
		double[] array2 = Enumerable.ToArray(source2);
		nint num2 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03f2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj41 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X10_v6-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj41 += 16;
			obj40--;
			if ((nint)obj40 != 1)
			{
				continue;
			}
			goto IL_03f2;
		}
		object obj42 = obj41 + 47;
		object obj43 = num2 + obj42;
		object obj44 = obj43 + 312;
		goto IL_06d8;
	}

	public static void GetRecentGiftBombs(GameObject lifecycle, long etag, Action<RecentGiftBombsModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_010a: Expected I, but got O
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass368_0 <>c__DisplayClass368_ = default(<>c__DisplayClass368_0);
		<>c__DisplayClass368_..ctor();
		object obj2 = typeof(RegisteredWaitHandle) + 2040;
		object key = "destinationTimeZone" + 1040;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj4 = (nint)0 + (nint)1248;
		object obj5 = <>c__DisplayClass368_ + 16;
		obj5 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass368_ + 24;
		obj6 = useCacheCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = <>c__DisplayClass368_ + 32;
		obj7 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, etag);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass368_, (IntPtr)obj4);
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object command = "placementId" + 2344;
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, sFSObject, keepListening: false, action);
	}

	public static void SendChatPinnedAvatarParticle(ChatPinnedAvatarParticle particle)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = "com.unity.services.authentication.profile" + 1744;
		object obj3 = (nint)0 + (nint)384;
		object command = "com.unity.services.authentication.profile" + 1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301FBB0");
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendFindMatch(GameType gameType, bool skipAd = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = "getSecondRescanTask" + 2104;
		object obj3 = (nint)0 + (nint)400;
		object key = "clear_mass_tournaments" + 264;
		object val = "fetch_products" + 272;
		object command = "m_StencilDeferredPS" + 2136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301FBB0");
		if (skipAd)
		{
			object key2 = "setMimeType" + 2776;
			SFSExtensions.Put(sFSObject, (string)key2, val: true);
		}
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendStopFindMatch(GameObject lifecycle, Action onSuccess, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00f0: Expected I, but got O
		//IL_011a: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass371_0 <>c__DisplayClass371_ = default(<>c__DisplayClass371_0);
		<>c__DisplayClass371_..ctor();
		object key = "clear_mass_tournaments" + 264;
		object value = "java.io.FileOutputStream" + 2040;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj3 = (nint)0 + (nint)1256;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2136;
		object obj5 = <>c__DisplayClass371_ + 16;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = <>c__DisplayClass371_ + 24;
		obj6 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, (string)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass371_, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(lifecycle, (string)command, param, keepListening: false, action);
	}

	public static void SendIAmAutoClicker(int clicksPeriod, int maxAllowedClicksPerPeriod, int clicksCommitted, bool deleteCredentials)
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
		object key = "clear_mass_tournaments" + 216;
		object key2 = "m_StencilDeferredPS" + 944;
		object key3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2512;
		object key4 = "com.unity.services.authentication.profile" + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, clicksPeriod);
		SFSExtensions.Put(sFSObject, (string)key2, maxAllowedClicksPerPeriod);
		SFSExtensions.Put(sFSObject, (string)key3, clicksCommitted);
		SFSExtensions.Put(sFSObject, (string)key4, deleteCredentials);
		object command = "alignContent" + 3424;
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void RankedMatch(bool skipAd = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object action = "Picking audio files is not supported on iOS" + 376;
		object type = (nint)0 + (nint)2000;
		FirebaseTrack.Event((string)action, (string)type);
		SendFindMatch(global::GameType.Ranked, skipAd);
	}

	public static void FriendlyMatch()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object action = "Picking audio files is not supported on iOS" + 368;
		object type = (nint)0 + (nint)2000;
		FirebaseTrack.Event((string)action, (string)type);
		SendFindMatch(global::GameType.Friendly);
	}

	public static void SendControlChat(int roomId, bool isChatEnabled)
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
		object key = "rightCtrl" + 360;
		object key2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3088;
		object command = "com.unity.services.authentication.profile" + 1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, roomId);
		SFSExtensions.Put(sFSObject, (string)key2, isChatEnabled);
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendChangeRoomName(string newName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "rightCtrl" + 240;
		object command = "placementId" + 2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, newName);
		SendRoomExtensionRequest((string)command, sFSObject);
	}

	public static void SendDeleteRoom()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "placementId" + 2368;
		object command = "placementId" + 2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, val: true);
		SendRoomExtensionRequest((string)command, sFSObject);
	}

	public static void SendLockedRoomRequest(LockedRoomRequestSubCommand subCommand)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = "clear_mass_tournaments" + 264;
		object obj3 = (nint)0 + (nint)408;
		object command = "java.io.FileOutputStream" + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301FBB0");
		SendZoneExtensionRequest((string)command, sFSObject);
	}

	private void BindSubscriptionStatus()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0102: Expected I, but got O
		//IL_01a3: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E837D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)2152;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
		UnityEngine.Component component = default(UnityEngine.Component);
		bool flag3 = (object)component == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)3824;
		object varName = "setMimeType" + 3808;
		GameObject go = component.gameObject;
		User mySelf = MySelf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		VariableBinderExtensions.Bind(go, mySelf, (string)varName, action);
	}

	private void SetupSubscriptionExpiryCallback()
	{
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Expected O, but got Unknown
		//IL_0a84: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_01c3: Expected I, but got O
		//IL_01d3: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected I, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_0271: Expected O, but got I
		//IL_029a: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_020e: Expected O, but got I
		//IL_053e: Expected O, but got I4
		//IL_04f6: Expected O, but got I4
		//IL_04ff: Expected O, but got I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02cc: Expected I, but got O
		//IL_02dc: Expected O, but got I
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_058a: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected I, but got Unknown
		//IL_03b1: Expected O, but got I
		//IL_03d5: Expected O, but got I4
		//IL_03e5: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_061f: Expected O, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0699: Expected O, but got I4
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_084e: Expected O, but got I
		//IL_085e: Expected O, but got I
		//IL_0880: Expected O, but got I4
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_0765: Expected O, but got I
		//IL_0775: Expected O, but got I
		//IL_08b0: Expected O, but got I4
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0ae4: Expected O, but got I
		//IL_0aec: Expected I, but got O
		//IL_0afd: Expected I, but got O
		//IL_0b1b: Expected O, but got I
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected O, but got Unknown
		//IL_0923: Expected O, but got I4
		//IL_092c: Expected O, but got I4
		//IL_0945: Expected O, but got I4
		//IL_0955: Expected I, but got O
		//IL_08e0: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E837E]");
		nint num = 0;
		User mySelf = MySelf;
		object obj;
		object obj5 = default(object);
		object obj9 = default(object);
		object obj8;
		if (mySelf != null)
		{
			obj = typeof(UsageHint) + 8;
			object obj2 = "rightCtrl" + 1480;
			nint num2 = (nint)mySelf;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v42 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v42 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v42 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X10_v20-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj4 + 16;
				obj3--;
				bool flag = (nint)obj3 != 1;
				obj4 = obj5;
				if (flag)
				{
					continue;
				}
				goto IL_00d4;
			}
			object obj6 = obj4 + 24;
			object obj7 = num2 + obj6;
			num = (nint)(obj7 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = obj9 == null;
			obj5 = obj4;
			if (!flag2)
			{
				goto IL_0195;
			}
			return;
		}
		goto IL_03fb;
		IL_0973:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11;
		object obj10 = obj11;
		double num4;
		double num3 = num4;
		nint num6;
		nint num5 = num6;
		Action action2;
		Action action = action2;
		goto IL_0803;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v73 (Il2CppClass<System.NullReferenceException>)+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ X0_v73 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag3 = ex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v73 (Il2CppClass<System.NullReferenceException>)+8]");
		obj8 = 0;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag3)
		{
			goto IL_02b0;
		}
		goto IL_03fb;
		IL_03fb:
		ex = new NullReferenceException();
		goto IL_0409;
		IL_02b0:
		object obj13 = typeof(UsageHint) + 664;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0358;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v12-8]");
			bool flag4 = 0 == (nint)obj13;
			obj8 = obj12;
			if (flag4)
			{
				break;
			}
			obj5 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0358;
		}
		goto IL_0409;
		IL_079a:
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v34+E4]");
		bool flag5 = (nint)0 == 0;
		double totalSeconds;
		num3 = totalSeconds;
		obj11 = obj10;
		num4 = totalSeconds;
		num6 = num5;
		action2 = action;
		if (!flag5)
		{
			goto IL_0803;
		}
		goto IL_0973;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v77 (Il2CppClass<System.NullReferenceException>)+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X0_v77 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag6 = obj9 == null;
		object obj17 = !flag6;
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		if (obj17 == null)
		{
			return;
		}
		goto IL_0195;
		IL_0195:
		User mySelf2 = MySelf;
		if (mySelf2 != null)
		{
			nint num7 = (nint)mySelf2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v44 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v44 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0257;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v44 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X10_v15-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj19 + 16;
				obj18--;
				bool flag7 = (nint)obj18 != 1;
				obj19 = obj5;
				if (flag7)
				{
					continue;
				}
				goto IL_0257;
			}
			object obj20 = obj19 + 21;
			object obj21 = num7 + obj20;
			num = (nint)(obj21 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = ex == null;
			object obj22 = !flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+8]");
			obj8 = 0;
			obj5 = obj19;
			if (obj22 != null)
			{
				goto IL_02b0;
			}
		}
		goto IL_03fb;
		IL_0358:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 5;
		object obj24 = default(object);
		object obj23 = obj24;
		goto IL_0a3c;
		IL_0a3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X8_v3] (should have been resolved before IL gen)");
		object obj25 = typeof(DataRelation) + 768;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj27 = !flag9;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long num8 = default(long);
		long seconds = ((num8 != 9218868437227405312L) ? num8 : (-9223372036854775808L));
		DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(seconds);
		DateTimeOffset dateTimeOffset2 = default(DateTimeOffset);
		DateTime dateTime = dateTimeOffset2.DateTime;
		User mySelf3 = MySelf;
		bool flag10 = SFSKammelnaUserExtensions.IsSubscribedUsingDate(mySelf3);
		object obj28 = typeof(UsageHint) + 72;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.WasSubscribedLastSession = flag10;
			bool flag11 = !flag10;
			object obj30 = !flag11;
			object obj31 = 0;
			if (obj30 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UserInfo.WasSubscribedLastSession = flag10;
			bool flag12 = !flag10;
			object obj31 = 0;
			if (flag12)
			{
				return;
			}
		}
		object obj32 = typeof(DataRelation) + 712;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v15+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime3 = default(DateTime);
		DateTime dateTime2 = dateTime3.AddDays(1.0);
		if (!(dateTime < dateTime2))
		{
			return;
		}
		object obj35 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v23+E4]");
		bool flag14 = (nint)0 == 0;
		object obj36 = !flag14;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan = dateTime - now2;
		object obj37 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v29+E4]");
		bool flag15 = (nint)0 == 0;
		object obj39 = !flag15;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		totalSeconds = timeSpan2.TotalSeconds;
		object obj40 = this + 72;
		Coroutine coroutine = (Coroutine)obj40;
		bool flag16 = obj40 == null;
		num5 = 0;
		if (!flag16)
		{
			StopCoroutine((Coroutine)obj40);
			num5 = 0;
		}
		object obj41 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2264;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v36+E4]");
		object obj43;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v36+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v19+60]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v19+60]");
			if ((nint)0 != 0)
			{
				goto IL_079a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v36+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v19+60]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v19+60]");
			bool flag17 = (nint)0 == 0;
			object obj44 = !flag17;
			if (obj44 != null)
			{
				goto IL_079a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v36+E4]");
		bool flag18 = (nint)0 == 0;
		object obj45 = !flag18;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj46 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v28+B8]");
			obj43 = 0;
		}
		object obj47 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)1104;
		num5 = (nint)obj48;
		Action action3 = default(Action);
		action3..ctor(obj43, (IntPtr)obj48);
		object obj49 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v24+B8]");
		object obj50 = (nint)0 + (nint)96;
		obj50 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj51 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		obj16 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v34+E4]");
		bool flag19 = (nint)0 == 0;
		object obj52 = !flag19;
		obj10 = 0;
		num3 = totalSeconds;
		action = action3;
		obj11 = 0;
		num4 = totalSeconds;
		num6 = (nint)obj48;
		coroutine = (Coroutine)(object)action3;
		action2 = action3;
		if (obj52 != null)
		{
			goto IL_0803;
		}
		goto IL_0973;
		IL_0409:
		object obj53 = obj5 + 5;
		object obj54 = num + obj53;
		obj23 = obj54 + 312;
		goto IL_0a3c;
		IL_0803:
		Coroutine coroutine2 = CoroutineDummy.WaitForSecondsPermanently((float)num3, action);
		obj40 = coroutine2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static void SetVivoxMicStatus(bool isMute)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "https://www.kammelna.com/Home/Terms" + 3368;
		object command = "m_StencilDeferredPS" + 2112;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, isMute);
		SendRoomExtensionRequest((string)command, param);
	}

	public static void RefreshClanMembership(long userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
		object command = "placementId" + 2360;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, userId);
		SendZoneExtensionRequest((string)command, param);
	}

	private void <CreateNewClient>b__271_0(BaseEvent evt)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		IDictionary<string, object> dictionary = evt.Params;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj2 = "m_StencilDeferredPS" + 1272;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v6-8]");
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
			goto IL_00ce;
		}
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v11+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ X8_v11] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag = obj8 == null;
		object obj9 = !flag;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f7;
		IL_00f7:
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X8_v8+168] (should have been resolved before IL gen)");
		SFS sFS = default(SFS);
		sFS.OnDebugMessage((string)(object)sFS);
		return;
		IL_00ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v8+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ X0_v8] (should have been resolved before IL gen)");
		goto IL_00f7;
	}

	private void <BindSubscriptionStatus>b__381_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_043c: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_0090: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_01ce: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_03e1: Expected O, but got I4
		//IL_0206: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I4
		//IL_0339: Expected O, but got I4
		//IL_0342: Expected O, but got I4
		//IL_039a: Expected O, but got I4
		//IL_0469: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object propertyName = "SubscribeGroup request Error" + 8;
		object obj4 = typeof(DataRelation) + 712;
		Tracker.UpdateDimensions();
		User mySelf = MySelf;
		bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(mySelf);
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+28]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = default(bool);
		string propertyText = flag4.ToString();
		FirebaseTrack.UserProperty((string)propertyName, propertyText);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v12+E4]");
		object obj11;
		DateTime dateTime2;
		if ((nint)0 != 0)
		{
			bool flag5 = _lastSubscriptionChange != (DateTime)0;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			object obj10 = 0;
			DateTime dateTime = (DateTime)0;
			if (obj9 != null)
			{
				goto IL_01dc;
			}
			obj11 = 0;
			dateTime2 = (DateTime)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = _lastSubscriptionChange != (DateTime)0;
			bool flag8 = !flag7;
			object obj10 = 0;
			DateTime dateTime = (DateTime)0;
			obj11 = 0;
			dateTime2 = (DateTime)0;
			if (!flag8)
			{
				goto IL_01dc;
			}
		}
		goto IL_03b7;
		IL_03b7:
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		_lastSubscriptionChange = now;
		return;
		IL_01dc:
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		DateTime dateTime4 = default(DateTime);
		DateTime dateTime3 = dateTime4.AddSeconds(-8.000000000465661);
		bool flag11 = _lastSubscriptionChange < dateTime3;
		bool flag12 = !flag11;
		double num = -8.000000000465661;
		obj11 = 0;
		dateTime2 = dateTime3;
		if (!flag12)
		{
			object obj16 = typeof(UsageHint) + 72;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v28+E4]");
			bool flag13 = (nint)0 == 0;
			object obj18 = !flag13;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool wasSubscribedLastSession = UserInfo.WasSubscribedLastSession;
			User mySelf2 = MySelf;
			bool flag14 = SFSKammelnaUserExtensions.IsSubscribed(mySelf2);
			bool flag15 = wasSubscribedLastSession == flag14;
			num = -8.000000000465661;
			obj11 = 0;
			dateTime2 = (DateTime)1;
			if (!flag15)
			{
				User mySelf3 = MySelf;
				bool wasSubscribedLastSession2 = SFSKammelnaUserExtensions.IsSubscribed(mySelf3);
				object obj19 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v12+E4]");
				bool flag16 = (nint)0 == 0;
				object obj20 = !flag16;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UserInfo.WasSubscribedLastSession = wasSubscribedLastSession2;
				num = -8.000000000465661;
				obj11 = 0;
				dateTime2 = (DateTime)0;
			}
		}
		goto IL_03b7;
	}
}
