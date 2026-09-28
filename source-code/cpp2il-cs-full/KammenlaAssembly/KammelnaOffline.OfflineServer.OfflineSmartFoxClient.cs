using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot;
using KammelnaOffline.Baloot.Tutorial;
using KammelnaOffline.Common;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

namespace KammelnaOffline.OfflineServer;

public class OfflineSmartFoxClient : SmartFoxClient
{
	private readonly Queue<KeyValuePair<string, ISFSObject>> events;

	private OfflineRoom Room
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			OfflineRoom offlineRoom = (OfflineRoom)base.LastJoinedRoom;
			if (offlineRoom != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 3240;
				object obj2 = obj;
				nint num = (nint)offlineRoom;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<KammelnaOffline.OfflineServer.OfflineRoom>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<KammelnaOffline.OfflineServer.OfflineRoom>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (OfflineRoom)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return offlineRoom;
		}
	}

	public OfflineSmartFoxClient(Games game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0088: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_0187: Expected O, but got I4
		//IL_01bb: Expected O, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_024a: Expected I, but got O
		//IL_025a: Expected O, but got I
		//IL_0295: Expected O, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 3968;
		object obj2 = (nint)0 + (nint)704;
		object obj3 = typeof(MemberAchievementClanFeedData) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A53D54");
		object obj4 = this + 208;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineRoom offlineRoom = default(OfflineRoom);
		offlineRoom..ctor();
		base.LastJoinedRoom = offlineRoom;
		OfflineGameController gameController = GetGameController(game);
		Room room = base.LastJoinedRoom;
		if (room != null)
		{
			object obj6 = obj3;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X9_v14 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X1_v18+130]");
			bool flag = num2 < 0;
			object obj7 = !flag;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X9_v14 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X1_v18+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v16-8]");
				if (0 == (nint)obj6)
				{
					goto IL_010c;
				}
			}
			throw new InvalidCastException();
		}
		goto IL_010c;
		IL_0329:
		throw new InvalidCastException();
		IL_02d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj11 = default(object);
		object obj10 = obj11;
		goto IL_03e3;
		IL_03e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v18] (should have been resolved before IL gen)");
		User user = default(User);
		base.MySelf = user;
		return;
		IL_010c:
		if (gameController != null)
		{
			object obj12 = gameController + 112;
			obj12 = room;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Room room2 = base.LastJoinedRoom;
			if (room2 != null)
			{
				object obj13 = obj3;
				nint num4 = (nint)room2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X1_v12+130]");
				bool flag2 = num5 < 0;
				object obj14 = !flag2;
				object obj15 = ~obj14;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X1_v12+130]");
					object obj16 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v13-8]");
					if (0 == (nint)obj13)
					{
						object obj17 = room2 + 24;
						obj17 = gameController;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Room room3 = base.LastJoinedRoom;
						if (room3 == null)
						{
							goto IL_031b;
						}
						object obj18 = typeof(RegisteredWaitHandle) + 1376;
						nint num7 = (nint)room3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02d6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
						object obj20 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v10-8]");
							if (0 == (nint)obj18)
							{
								break;
							}
							obj20 += 16;
							obj19--;
							if ((nint)obj19 != 1)
							{
								continue;
							}
							goto IL_02d6;
						}
						object obj21 = obj20 + 27;
						object obj22 = num7 + obj21;
						obj10 = obj22 + 312;
						goto IL_03e3;
					}
				}
				goto IL_0329;
			}
		}
		goto IL_031b;
		IL_031b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0329;
	}

	public OfflineSmartFoxClient(TutorialType tutorialType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0377: Expected O, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_007f: Expected I, but got O
		//IL_00a8: Expected O, but got I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0148: Expected I, but got O
		//IL_0171: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_023c: Expected I, but got O
		//IL_024c: Expected O, but got I
		//IL_01a5: Expected O, but got I
		//IL_0287: Expected O, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 3968;
		object obj2 = (nint)0 + (nint)704;
		object obj3 = typeof(MemberAchievementClanFeedData) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A53D54");
		object obj4 = this + 208;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineRoom offlineRoom = default(OfflineRoom);
		offlineRoom..ctor(tutorialType);
		base.LastJoinedRoom = offlineRoom;
		Room room = base.LastJoinedRoom;
		bool flag = room == null;
		object obj6 = 0;
		if (!flag)
		{
			obj6 = obj3;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X1_v9+130]");
			bool flag2 = num2 < 0;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X1_v9+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v23-8]");
				if (0 == (nint)obj6)
				{
					goto IL_0103;
				}
			}
			throw new InvalidCastException();
		}
		goto IL_0103;
		IL_01cc:
		TutorialGameController tutorialGameController = default(TutorialGameController);
		object obj10 = tutorialGameController + 112;
		Room room2;
		obj10 = room2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = room + 24;
		obj11 = tutorialGameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Room room3 = base.LastJoinedRoom;
		object obj12 = typeof(RegisteredWaitHandle) + 1376;
		nint num4 = (nint)room3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X10_v9-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_02c8;
		}
		object obj15 = obj14 + 27;
		object obj16 = num4 + obj15;
		object obj17 = obj16 + 312;
		goto IL_03d0;
		IL_02c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj18 = default(object);
		obj17 = obj18;
		goto IL_03d0;
		IL_03d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X8_v16] (should have been resolved before IL gen)");
		User user = default(User);
		base.MySelf = user;
		return;
		IL_0103:
		object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		tutorialGameController..ctor(tutorialType);
		room2 = base.LastJoinedRoom;
		if (room2 != null)
		{
			object obj20 = obj3;
			nint num5 = (nint)room2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v13 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X1_v20+130]");
			bool flag3 = num6 < 0;
			object obj21 = !flag3;
			object obj22 = ~obj21;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v13 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X1_v20+130]");
				object obj23 = num7 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X9_v15-8]");
				if (0 == (nint)obj20)
				{
					goto IL_01cc;
				}
			}
			throw new InvalidCastException();
		}
		goto IL_01cc;
	}

	public OfflineSmartFoxClient(GameReplay gameReplay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_007f: Expected I, but got O
		//IL_00a8: Expected O, but got I4
		//IL_0129: Expected I, but got O
		//IL_0152: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_0186: Expected O, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_020b: Expected O, but got I4
		//IL_024f: Expected O, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0297: Expected O, but got I4
		object obj = typeof(List<Tween>) + 3968;
		object obj2 = (nint)0 + (nint)704;
		object obj3 = typeof(MemberAchievementClanFeedData) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A53D54");
		object obj4 = this + 208;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflineRoom offlineRoom = default(OfflineRoom);
		offlineRoom..ctor(gameReplay);
		base.LastJoinedRoom = offlineRoom;
		Room room = base.LastJoinedRoom;
		if (room == null)
		{
			goto IL_0103;
		}
		object obj6 = obj3;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X1_v18+130]");
		bool flag = num2 < 0;
		object obj7 = !flag;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X1_v18+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v21-8]");
			if (0 == (nint)obj6)
			{
				goto IL_0103;
			}
		}
		goto IL_02fb;
		IL_0103:
		IRoomExtension replayGameController = GetReplayGameController((OfflineRoom)room, gameReplay);
		Room room2 = base.LastJoinedRoom;
		object obj10 = obj3;
		nint num4 = (nint)room2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X1_v12+130]");
		bool flag2 = num5 < 0;
		object obj11 = !flag2;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X1_v12+130]");
			object obj13 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v12-8]");
			if (0 == (nint)obj10)
			{
				object obj14 = typeof(UsageHint) + 72;
				object obj15 = room2 + 24;
				obj15 = replayGameController;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v24+E4]");
				bool flag3 = (nint)0 == 0;
				object obj17 = !flag3;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string userDbId = UserInfo.UserDbId;
				int num7 = int.Parse(userDbId);
				object obj18 = (nint)0 + (nint)3232;
				object obj19 = typeof(MemberAchievementClanFeedData) + 3264;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
				object obj20 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v31+E4]");
				bool flag4 = (nint)0 == 0;
				object obj21 = !flag4;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string userDbId2 = UserInfo.UserDbId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				OfflineUser offlineUser = default(OfflineUser);
				offlineUser..ctor(0, userDbId2);
				bool <IsPlayer>k__BackingField = default(bool);
				offlineUser.<IsPlayer>k__BackingField = <IsPlayer>k__BackingField;
				base.MySelf = offlineUser;
				return;
			}
		}
		goto IL_02fb;
		IL_02fb:
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	public override void Send(string command, ISFSObject param, Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "placementId" + 112;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v6-8]");
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
			goto IL_00bd;
		}
		object obj5 = obj4 + 35;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0129;
		IL_00bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0129;
		IL_0129:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X0_v4] (should have been resolved before IL gen)");
		KeyValuePair<object, object> keyValuePair = new KeyValuePair<object, object>(command, param);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A543BC");
	}

	public override void ProcessEvents()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00a3: Expected I, but got O
		//IL_00cc: Expected O, but got I4
		//IL_0100: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		if (!Enumerable.Any((IEnumerable<KeyValuePair<object, object>>)events))
		{
			return;
		}
		object obj = (nint)0 + (nint)712;
		object obj2 = typeof(MemberAchievementClanFeedData) + 3240;
		object obj3 = typeof(System.IOAsyncCallback) + 928;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A54568");
			Room room = base.LastJoinedRoom;
			object obj4 = obj2;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X1_v8+130]");
			bool flag = num2 < 0;
			object obj5 = !flag;
			object obj6 = ~obj5;
			if (obj6 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X1_v8+130]");
			object obj7 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12-8]");
			if (0 != (nint)obj4)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v15 (Sfs2X.Entities.Room)+18]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v15+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_003e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v15+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v8-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_003e;
			}
			object obj12 = obj11 + 2;
			object obj13 = obj9 + obj12;
			object obj14 = obj13 + 312;
			goto IL_004d;
			IL_004d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v347 @ X0_v18] (should have been resolved before IL gen)");
			if (Enumerable.Any((IEnumerable<KeyValuePair<object, object>>)events))
			{
				continue;
			}
			return;
			IL_003e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_004d;
		}
		throw new InvalidCastException();
	}

	private static OfflineGameController GetGameController(Games game)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_001f: Expected O, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		if (game != Games.Tarneeb)
		{
			bool flag = game == Games.Baloot;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1992;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				BalootGameController balootGameController = default(BalootGameController);
				balootGameController..ctor();
				return balootGameController;
			}
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = "fetch_products" + 2352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj6 = (nint)0 + (nint)1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (OfflineGameController)(object)new OutOfMemoryException();
		}
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj10 = default(object);
		object obj9 = obj10 + 64;
		object obj11 = default(object);
		obj9 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10..ctor();
		return (OfflineGameController)obj10;
	}

	private static IRoomExtension GetReplayGameController(OfflineRoom room, GameReplay gameReplay)
	{
		//IL_0024: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I
		bool flag = gameReplay.<Games>k__BackingField == Games.Baloot;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameReplayController gameReplayController = default(GameReplayController);
			gameReplayController..ctor(room, gameReplay);
			return gameReplayController;
		}
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = "fetch_products" + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		ex..ctor(paramName, gameReplay, null);
		object obj5 = (nint)0 + (nint)1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (IRoomExtension)new OutOfMemoryException();
	}
}
