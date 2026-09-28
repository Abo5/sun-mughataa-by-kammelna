using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ClanChatBox : BaseChatbox
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, bool> <>9__16_0;

		public static Func<Room, int> <>9__16_1;

		public static Func<Room, GameRoomData> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SyncTournamentCards>b__16_0(Room room)
		{
			//IL_00f8: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
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
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v5-8]");
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
				goto IL_0139;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0139:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X0_v3] (should have been resolved before IL gen)");
			string clanChatTag = ClanChatTag;
			string text = default(string);
			return text == clanChatTag;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0139;
		}

		internal int <SyncTournamentCards>b__16_1(Room room)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}

		internal GameRoomData <SyncClanGameCards>b__17_0(Room r)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameRoomData gameRoomData = default(GameRoomData);
			gameRoomData..ctor(r);
			return gameRoomData;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public Room room;

		internal bool <OnClanRoomRemoved>b__0(ChatMessageData message)
		{
			//IL_00ea: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			Room room = this.room;
			if (this.room != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)room;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
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
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				goto IL_0137;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0137:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X0_v3] (should have been resolved before IL gen)");
			int roomId = default(int);
			return IsCardForRoom(message, roomId);
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0137;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public List<int> liveIds;

		internal bool <SyncTournamentCards>b__2(ChatMessageData message)
		{
			//IL_0199: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0050: Expected I, but got O
			//IL_0060: Expected O, but got I
			//IL_009b: Expected O, but got I
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected O, but got Unknown
			//IL_017d: Expected O, but got I4
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			if (message != null)
			{
				Room <TournamentRoom>k__BackingField = message.<TournamentRoom>k__BackingField;
				if (message.<TournamentRoom>k__BackingField == null)
				{
					return false;
				}
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)<TournamentRoom>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00dc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v6-8]");
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
					goto IL_00dc;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v13] (should have been resolved before IL gen)");
				bool flag = liveIds == null;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_010f;
				}
			}
			goto IL_018b;
			IL_010f:
			int item = default(int);
			bool flag2 = liveIds.Contains(item);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			IL_018b:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X0_v10] (should have been resolved before IL gen)");
			if (liveIds != null)
			{
				goto IL_010f;
			}
			goto IL_018b;
		}
	}

	private sealed class <>c__DisplayClass16_1
	{
		public Room hub;

		internal bool <SyncTournamentCards>b__3(ChatMessageData message)
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0060: Expected I, but got O
			//IL_0070: Expected O, but got I
			//IL_0106: Expected I, but got O
			//IL_0130: Expected I, but got O
			//IL_0135: Expected I, but got O
			//IL_00ab: Expected O, but got I
			//IL_0155: Expected I, but got O
			//IL_0165: Expected O, but got I
			//IL_01f0: Expected I, but got O
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected O, but got Unknown
			//IL_022e: Expected I, but got O
			//IL_025e: Expected O, but got I4
			//IL_01a0: Expected O, but got I
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E874B]");
			nint num = 0;
			bool flag = message == null;
			<>c__DisplayClass16_1 <>c__DisplayClass16_ = this;
			ChatMessageData chatMessageData = message;
			object obj;
			<>c__DisplayClass16_1 <>c__DisplayClass16_2;
			nint num3;
			object obj4;
			nint num4 = default(nint);
			if (!flag)
			{
				chatMessageData = (ChatMessageData)message.<TournamentRoom>k__BackingField;
				if (message.<TournamentRoom>k__BackingField == null)
				{
					return false;
				}
				obj = typeof(RegisteredWaitHandle) + 1376;
				nint num2 = (nint)chatMessageData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8 (Il2CppClass<ChatMessageData>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8 (Il2CppClass<ChatMessageData>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8 (Il2CppClass<ChatMessageData>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag2 = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag2)
					{
						continue;
					}
					goto IL_00f4;
				}
				object obj5 = num2 + obj3;
				object obj6 = obj5 + 312;
				num = (nint)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v18] (should have been resolved before IL gen)");
				<>c__DisplayClass16_2 = (<>c__DisplayClass16_1)(object)hub;
				bool flag3 = hub == null;
				object obj7 = !flag3;
				num3 = num4;
				obj4 = obj3;
				<>c__DisplayClass16_ = (<>c__DisplayClass16_1)(object)hub;
				if (obj7 != null)
				{
					goto IL_014d;
				}
			}
			goto IL_0286;
			IL_033b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X0_v2] (should have been resolved before IL gen)");
			object obj9 = default(object);
			object obj8 = (object)chatMessageData - obj9;
			return obj8 == null;
			IL_00f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj10 = default(object);
			num = (nint)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ X0_v15] (should have been resolved before IL gen)");
			<>c__DisplayClass16_2 = (<>c__DisplayClass16_1)(object)hub;
			bool flag4 = hub == null;
			num3 = unchecked((nint)null);
			num4 = unchecked((nint)null);
			<>c__DisplayClass16_ = (<>c__DisplayClass16_1)(object)hub;
			if (!flag4)
			{
				goto IL_014d;
			}
			goto IL_0286;
			IL_01e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			<>c__DisplayClass16_ = <>c__DisplayClass16_2;
			ChatMessageData chatMessageData2 = default(ChatMessageData);
			chatMessageData = chatMessageData2;
			goto IL_033b;
			IL_0286:
			throw new NullReferenceException();
			IL_014d:
			num = (nint)<>c__DisplayClass16_2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5 (Il2CppClass<ClanChatBox+<>c__DisplayClass16_1>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5 (Il2CppClass<ClanChatBox+<>c__DisplayClass16_1>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5 (Il2CppClass<ClanChatBox+<>c__DisplayClass16_1>)+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v10-8]");
				bool flag5 = 0 == (nint)obj;
				num4 = num3;
				<>c__DisplayClass16_ = <>c__DisplayClass16_2;
				chatMessageData = chatMessageData2;
				if (flag5)
				{
					break;
				}
				obj4 += 16;
				obj11--;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_01e1;
			}
			object obj12 = num + obj4;
			object obj13 = obj12 + 312;
			goto IL_033b;
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public List<GameRoomData> clanGames;

		internal bool <SyncClanGameCards>b__1(ChatMessageData message)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00f0: Expected I4, but got O
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I
			//IL_00bf: Expected I, but got O
			object obj = typeof(CardUtils.<>c) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = obj2 + 16;
				obj3 = message;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj4 = obj3;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+68]");
					if ((nint)0 != 0)
					{
						object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1392;
						object obj6 = (nint)0 + (nint)3440;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor(obj2, (IntPtr)obj6);
						return Enumerable.All(clanGames, func);
					}
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass17_1
	{
		public ChatMessageData message;

		internal bool <SyncClanGameCards>b__2(GameRoomData room)
		{
			//IL_00b9: Expected I4, but got O
			//IL_008c: Expected O, but got I4
			if (room != null)
			{
				ChatMessageData chatMessageData = message;
				if (message != null)
				{
					GameRoomData <RoomData>k__BackingField = chatMessageData.<RoomData>k__BackingField;
					if (chatMessageData.<RoomData>k__BackingField != null)
					{
						object obj = room.Id - <RoomData>k__BackingField.Id;
						bool flag = obj == null;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass17_2
	{
		public ChatMessageData message;

		internal bool <SyncClanGameCards>b__3(GameRoomData room)
		{
			//IL_00ae: Expected I4, but got O
			//IL_008c: Expected O, but got I4
			if (room != null)
			{
				ChatMessageData chatMessageData = message;
				if (message != null)
				{
					GameRoomData <RoomData>k__BackingField = chatMessageData.<RoomData>k__BackingField;
					if (chatMessageData.<RoomData>k__BackingField != null)
					{
						object obj = room.Id - <RoomData>k__BackingField.Id;
						return obj == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass17_3
	{
		public GameRoomData game;

		internal bool <SyncClanGameCards>b__4(ChatMessageData message)
		{
			//IL_00b4: Expected I4, but got O
			//IL_008c: Expected O, but got I4
			if (message != null)
			{
				GameRoomData <RoomData>k__BackingField = message.<RoomData>k__BackingField;
				if (message.<RoomData>k__BackingField == null)
				{
					return false;
				}
				GameRoomData gameRoomData = game;
				if (game != null)
				{
					object obj = <RoomData>k__BackingField.Id - gameRoomData.Id;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool isSubChat;

	private Sprite mutedIcon;

	private static bool HasClan
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
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_025a: Expected I4, but got O
			//IL_0225: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86C8]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
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
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_024c;
			IL_024c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			User localUser = sessionModel.LocalUser;
			bool flag4 = localUser == null;
			bool result = (byte)(int)localUser != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_024c;
				}
				User localUser2 = sessionModel2.LocalUser;
				int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
				object obj10 = clanId + 1;
				bool flag6 = obj10 == null;
				bool flag7 = !flag6;
				result = flag7;
			}
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag8 = (object)sessionModel == null;
			object obj11 = !flag8;
			if (obj11 != null)
			{
				goto IL_0158;
			}
			goto IL_024c;
		}
	}

	private static string ClanChatTag
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00fb: Expected O, but got I
			//IL_0125: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_016e: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86C9]");
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
			goto IL_017c;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			return ClanUtils.GetClanChatTag(clanId);
			IL_017c:
			return (string)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_017c;
		}
	}

	private static bool CanWrite
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00fd: Expected O, but got I
			//IL_0127: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_018c: Expected I4, but got O
			//IL_0170: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86CA]");
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
			goto IL_017e;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			MuteStatus muteStatus = SFSKammelnaUserExtensions.GetMuteStatus(localUser);
			return muteStatus == MuteStatus.None;
			IL_017e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_017e;
		}
	}

	private void OnEnable()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0065: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_007d: Expected O, but got I
		//IL_0099: Expected O, but got I4
		//IL_00c5: Expected I, but got O
		//IL_0106: Expected I, but got O
		//IL_012c: Expected I, but got O
		//IL_0157: Expected I, but got O
		//IL_017d: Expected I, but got O
		//IL_01a8: Expected I, but got O
		if (HasClan)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = (nint)0 + (nint)824;
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			object obj5 = (nint)0 + (nint)800;
			object obj6 = (nint)0 + (nint)816;
			object obj7 = (nint)0 + (nint)808;
			object obj8 = (nint)0 + (nint)792;
			bool flag = !isSubChat;
			object obj9 = !flag;
			if (obj9 == null)
			{
				ChatHandler.ClanChatActive = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4 (Il2CppClass<ClanChatBox>)+1B0]");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)0);
			ChatHandler.OnMessage += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj3);
			ChatHandler.OnGroupChange += action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action3 = default(Action<object>);
			action3..ctor((object)this, (IntPtr)obj5);
			SFS.OnRoomCreated += action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action4 = default(Action<object>);
			action4..ctor((object)this, (IntPtr)obj6);
			SFS.OnRoomCreated += action4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action5 = default(Action<object>);
			action5..ctor((object)this, (IntPtr)obj7);
			SFS.OnRoomRemoved += action5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action6 = default(Action<object>);
			action6..ctor((object)this, (IntPtr)obj8);
			SFS.OnRoomGroupSubscribe += action6;
			string clanChatTag = ClanChatTag;
			List<ChatMessageData> messages = ChatHandler.GetMessages(clanChatTag);
			SetMessages(messages);
			SyncTournamentCards();
			SyncClanGameCards();
		}
	}

	private void OnDisable()
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0169: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_0023: Expected I, but got O
		//IL_0064: Expected I, but got O
		//IL_008a: Expected I, but got O
		//IL_00b5: Expected I, but got O
		//IL_00db: Expected I, but got O
		//IL_0106: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj3 = (nint)0 + (nint)824;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj5 = (nint)0 + (nint)800;
		object obj6 = (nint)0 + (nint)816;
		object obj7 = (nint)0 + (nint)808;
		object obj8 = (nint)0 + (nint)792;
		bool flag = !isSubChat;
		object obj9 = !flag;
		if (obj9 == null)
		{
			ChatHandler.ClanChatActive = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (Il2CppClass<ClanChatBox>)+1B0]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		ChatHandler.OnMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		ChatHandler.OnGroupChange -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		SFS.OnRoomCreated -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj6);
		SFS.OnRoomCreated -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj7);
		SFS.OnRoomRemoved -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj8);
		SFS.OnRoomGroupSubscribe -= action6;
	}

	private void OnGroupChanged(string groupTag)
	{
		if (HasClan)
		{
			string clanChatTag = ClanChatTag;
			if (!(groupTag != clanChatTag))
			{
				string clanChatTag2 = ClanChatTag;
				List<ChatMessageData> messages = ChatHandler.GetMessages(clanChatTag2);
				SetMessages(messages);
			}
		}
	}

	private void OnClanGroupSubscribed(string groupTag)
	{
		//IL_0068: Expected O, but got I4
		if (HasClan)
		{
			string clanChatTag = ClanChatTag;
			bool flag = groupTag != clanChatTag;
			if (!flag)
			{
				((ClanChatBox)flag).SyncTournamentCards();
				SyncClanGameCards();
			}
		}
	}

	private void OnClanRoomCreated(Room room)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003a: Expected I, but got O
		//IL_004a: Expected O, but got I
		//IL_0232: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		bool hasClan = HasClan;
		if (room == null || !hasClan)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X10_v6-8]");
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
			goto IL_00c6;
		}
		object obj4 = obj3 + 3;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_01f4;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01f4;
		IL_01f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v4] (should have been resolved before IL gen)");
		string clanChatTag = ClanChatTag;
		string text = default(string);
		bool flag = text != clanChatTag;
		bool flag2 = !flag;
		object obj7 = !flag2;
		if (obj7 == null && !SFSKammelnaRoomExtensions.IsTournamentHub(room))
		{
			string clanChatTag2 = ClanChatTag;
			object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameRoomData gameRoomData = default(GameRoomData);
			gameRoomData..ctor(room);
			object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ChatMessageData chatMessageData = default(ChatMessageData);
			chatMessageData..ctor(gameRoomData);
			ChatHandler.InjectMessage(clanChatTag2, chatMessageData);
		}
	}

	private void OnClanTournamentCreated(Room room)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003a: Expected I, but got O
		//IL_004a: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		bool hasClan = HasClan;
		if (room == null || !hasClan)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v6-8]");
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
			goto IL_00c6;
		}
		object obj4 = obj3 + 3;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_01c0;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01c0;
		IL_01c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ X0_v4] (should have been resolved before IL gen)");
		string clanChatTag = ClanChatTag;
		string text = default(string);
		bool flag = text != clanChatTag;
		bool flag2 = !flag;
		object obj7 = !flag2;
		if (obj7 == null && SFSKammelnaRoomExtensions.IsTournamentHub(room))
		{
			string clanChatTag2 = ClanChatTag;
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ChatMessageData chatMessageData = default(ChatMessageData);
			chatMessageData..ctor(room);
			ChatHandler.InjectMessage(clanChatTag2, chatMessageData);
		}
	}

	private void OnClanRoomRemoved(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_017c: Expected O, but got I
		//IL_018d: Expected I, but got O
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass14_0 <>c__DisplayClass14_ = default(<>c__DisplayClass14_0);
		<>c__DisplayClass14_..ctor();
		object obj2 = <>c__DisplayClass14_ + 16;
		obj2 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj2;
		if (obj2 == null)
		{
			return;
		}
		object obj4 = typeof(RegisteredWaitHandle) + 1376;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0106;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X10_v6-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_0106;
		}
		object obj8 = obj7 + 3;
		object obj9 = obj5 + obj8;
		object obj10 = obj9 + 312;
		goto IL_0206;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X0_v8] (should have been resolved before IL gen)");
		string clanChatTag = ClanChatTag;
		string text = default(string);
		if (!(text != clanChatTag))
		{
			string clanChatTag2 = ClanChatTag;
			object obj11 = typeof(List<Tween>) + 3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3408;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor((object)<>c__DisplayClass14_, (IntPtr)obj12);
			ChatHandler.RemoveMessages(clanChatTag2, predicate);
			string clanChatTag3 = ClanChatTag;
			List<ChatMessageData> messages = ChatHandler.GetMessages(clanChatTag3);
			SetMessages(messages);
		}
		return;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0206;
	}

	private static bool IsCardForRoom(ChatMessageData message, int roomId)
	{
		//IL_0178: Expected I4, but got O
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a9: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		if (message != null)
		{
			GameRoomData <RoomData>k__BackingField = message.<RoomData>k__BackingField;
			if (message.<RoomData>k__BackingField != null && <RoomData>k__BackingField.Id == roomId)
			{
				return true;
			}
			Room <TournamentRoom>k__BackingField = message.<TournamentRoom>k__BackingField;
			if (message.<TournamentRoom>k__BackingField != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)<TournamentRoom>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0135;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X10_v5-8]");
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
					goto IL_0135;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				goto IL_01b9;
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ X0_v4] (should have been resolved before IL gen)");
		object obj7 = default(object);
		object obj6 = obj7 - roomId;
		return obj6 == null;
		IL_0135:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01b9;
	}

	private void SyncTournamentCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_054e: Expected O, but got I
		//IL_055a: Expected O, but got I
		//IL_056a: Expected O, but got I
		//IL_057a: Expected O, but got I
		//IL_059c: Expected O, but got I4
		//IL_0783: Expected O, but got I4
		//IL_0626: Expected O, but got I
		//IL_0632: Expected O, but got I
		//IL_0642: Expected O, but got I
		//IL_0652: Expected O, but got I
		//IL_0674: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_0188: Expected I4, but got O
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05d4: Expected O, but got I
		//IL_05e5: Expected I, but got O
		//IL_0603: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_00de: Expected O, but got I
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_06ac: Expected O, but got I
		//IL_06bd: Expected I, but got O
		//IL_06db: Expected O, but got I
		//IL_06fe: Expected O, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0229: Expected I, but got O
		//IL_04b9: Expected O, but got I
		//IL_04c1: Expected I4, but got O
		//IL_0273: Expected O, but got I4
		//IL_027c: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		//IL_02a9: Expected O, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02dd: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0313: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_045e: Expected O, but got I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0396: Expected I, but got O
		//IL_03ce: Expected O, but got I4
		//IL_03d7: Expected O, but got I4
		//IL_0425: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 536;
		object obj2 = typeof(CardUtils.<>c) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass16_0 <>c__DisplayClass16_ = default(<>c__DisplayClass16_0);
		<>c__DisplayClass16_..ctor();
		IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		IEnumerable<Room> source = tournamentRooms;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			source = tournamentRooms;
		}
		object obj5 = (nint)0 + (nint)3736;
		object obj6 = (nint)0 + (nint)2624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v30+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v30+8]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3392;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v35+B8]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj15 = 0;
			predicate = func;
		}
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		List<object> list = Enumerable.ToList(source2);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj2;
		}
		object obj18 = (nint)0 + (nint)3960;
		object obj19 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v13+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v22+10]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v22+10]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v28+B8]");
				obj20 = 0;
			}
			object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)3400;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj20, (IntPtr)obj25);
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v27+B8]");
			object obj27 = (nint)0 + (nint)16;
			obj27 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func2;
			object obj15 = 0;
		}
		object obj28 = obj18;
		IEnumerable<int> source3 = Enumerable.Select(list, selector);
		bool flag7 = (byte)(int)obj19 != 0;
		List<int> list2 = Enumerable.ToList(source3);
		bool flag8 = <>c__DisplayClass16_ == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		if (!flag8)
		{
			object obj29 = typeof(List<Tween>) + 3128;
			object obj30 = (nint)0 + (nint)3416;
			object obj31 = <>c__DisplayClass16_ + 16;
			obj31 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string clanChatTag = ClanChatTag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate2 = default(Predicate<object>);
			predicate2..ctor((object)<>c__DisplayClass16_, (IntPtr)obj30);
			ChatHandler.RemoveMessages(clanChatTag, predicate2);
			string clanChatTag2 = ClanChatTag;
			List<ChatMessageData> messages = ChatHandler.GetMessages(clanChatTag2);
			bool flag9 = list == null;
			enumerator = (List<object>.Enumerator)0;
			object obj15 = 0;
			obj28 = 0;
			flag7 = false;
			if (!flag9)
			{
				object obj32 = (nint)0 + (nint)768;
				object obj33 = typeof(CardUtils.<>c) + 544;
				object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 568;
				object obj35 = (nint)0 + (nint)3424;
				object obj36 = (nint)0 + (nint)2520;
				object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
				List<object>.Enumerator enumerator2 = list.GetEnumerator();
				obj15 = 0;
				obj28 = 0;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				<>c__DisplayClass16_1 <>c__DisplayClass16_2 = default(<>c__DisplayClass16_1);
				object obj39 = default(object);
				Func<object, bool> func3 = default(Func<object, bool>);
				ChatMessageData chatMessageData = default(ChatMessageData);
				while (true)
				{
					if (enumerator3.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						<>c__DisplayClass16_2..ctor();
						if (<>c__DisplayClass16_2 == null)
						{
							break;
						}
						object obj38 = <>c__DisplayClass16_2 + 16;
						obj38 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func3..ctor((object)<>c__DisplayClass16_2, (IntPtr)obj35);
						obj28 = obj36;
						bool flag10 = Enumerable.Any(messages, func3);
						bool flag11 = !flag10;
						object obj40 = !flag11;
						obj15 = 0;
						if (obj40 == null)
						{
							string clanChatTag3 = ClanChatTag;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							chatMessageData..ctor((Room)obj38);
							ChatHandler.InjectMessage(clanChatTag3, chatMessageData);
							obj15 = 0;
							obj28 = 0;
						}
						continue;
					}
					enumerator3.Dispose();
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				enumerator = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				flag7 = false;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag12 = !flag7;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj41 = (nint)0 + (nint)760;
			flag7 = (byte)(int)obj41 != 0;
			enumerator.Dispose();
			object obj42 = default(object);
			if (obj42 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj42;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C8F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void SyncClanGameCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_076c: Expected O, but got I
		//IL_0778: Expected O, but got I
		//IL_0788: Expected O, but got I
		//IL_0798: Expected O, but got I
		//IL_07ba: Expected O, but got I4
		//IL_08f2: Expected I4, but got O
		//IL_0917: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_07f2: Expected O, but got I
		//IL_0803: Expected I, but got O
		//IL_0821: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_06d7: Expected O, but got I
		//IL_06df: Expected I4, but got O
		//IL_01fe: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_019a: Expected O, but got I
		//IL_01ab: Expected I, but got O
		//IL_01c1: Expected O, but got I4
		//IL_022b: Expected O, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025f: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_0281: Expected O, but got I4
		//IL_03d5: Expected O, but got I
		//IL_03dd: Expected I4, but got O
		//IL_03f2: Expected O, but got I
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0426: Expected O, but got I
		//IL_0432: Expected O, but got I
		//IL_08b2: Expected O, but got I4
		//IL_08c3: Expected O, but got I4
		//IL_05fc: Expected O, but got I4
		//IL_060d: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d1: Expected O, but got I4
		//IL_062d: Expected O, but got I4
		//IL_063e: Expected O, but got I4
		//IL_05d4: Expected O, but got I4
		//IL_0340: Expected I, but got O
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_0367: Expected I4, but got O
		//IL_0370: Expected O, but got I4
		//IL_04bf: Expected I, but got O
		//IL_04f7: Expected O, but got I4
		//IL_0500: Expected O, but got I4
		//IL_065d: Expected O, but got I4
		//IL_066e: Expected O, but got I4
		//IL_0677: Expected O, but got I4
		//IL_067f: Expected I4, but got O
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I4
		//IL_0582: Expected O, but got I4
		//IL_058b: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 552;
		object obj2 = typeof(CardUtils.<>c) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass17_0 <>c__DisplayClass17_ = default(<>c__DisplayClass17_0);
		<>c__DisplayClass17_..ctor();
		string clanChatTag = ClanChatTag;
		IEnumerable<Room> enumerable = SFS.ClanGameRooms(clanChatTag);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		IEnumerable<Room> source = enumerable;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			source = enumerable;
		}
		object obj5 = (nint)0 + (nint)3952;
		object obj6 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v38+18]");
		Func<object, object> func = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v38+18]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object obj15;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v44+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3384;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v43+B8]");
			object obj14 = (nint)0 + (nint)24;
			obj14 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj15 = 0;
			func = func2;
		}
		object obj16 = obj5;
		IEnumerable<object> source2 = Enumerable.Select(source, func);
		bool flag4 = (byte)(int)obj6 != 0;
		List<object> list = Enumerable.ToList(source2);
		bool flag5 = <>c__DisplayClass17_ == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		List<ChatMessageData> messages;
		bool flag9 = default(bool);
		object obj26;
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		if (!flag5)
		{
			func = (Func<object, object>)(<>c__DisplayClass17_ + 16);
			func = (Func<object, object>)(object)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string clanChatTag2 = ClanChatTag;
			bool flag6 = SFS.IsSubscribedToGroup(clanChatTag2);
			bool flag7 = !flag6;
			string text = (string)flag6;
			if (!flag7)
			{
				text = ClanChatTag;
				object obj17 = typeof(List<Tween>) + 3128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = (nint)0 + (nint)3432;
				Predicate<object> predicate = default(Predicate<object>);
				predicate..ctor((object)<>c__DisplayClass17_, (IntPtr)obj18);
				ChatHandler.RemoveMessages(text, predicate);
				obj15 = 0;
			}
			string clanChatTag3 = ClanChatTag;
			messages = ChatHandler.GetMessages(clanChatTag3);
			bool flag8 = messages == null;
			enumerator = (List<object>.Enumerator)0;
			obj16 = 0;
			flag4 = false;
			if (!flag8)
			{
				object obj19 = (nint)0 + (nint)3920;
				object obj20 = typeof(CardUtils.<>c) + 568;
				object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1392;
				object obj22 = (nint)0 + (nint)3448;
				object obj23 = (nint)0 + (nint)840;
				List<object>.Enumerator enumerator2 = ((List<object>)(object)messages).GetEnumerator();
				obj16 = 0;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				<>c__DisplayClass17_2 <>c__DisplayClass17_2 = default(<>c__DisplayClass17_2);
				Func<object, bool> func3 = default(Func<object, bool>);
				while (enumerator3.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					<>c__DisplayClass17_2..ctor();
					if (<>c__DisplayClass17_2 == null)
					{
						goto IL_05ea;
					}
					object obj24 = <>c__DisplayClass17_2 + 16;
					obj24 = flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj25 = obj24;
					if (obj24 == null)
					{
						goto IL_061b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v31+68]");
					if ((nint)0 == 0)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					func3..ctor((object)<>c__DisplayClass17_2, (IntPtr)obj22);
					obj16 = obj23;
					obj26 = Enumerable.FirstOrDefault((IEnumerable<object>)(object)func, func3);
					bool flag10 = (byte)(int)(~obj26) != 0;
					obj15 = 0;
					if (flag10)
					{
						continue;
					}
					if (obj24 != null)
					{
						object obj27 = obj24 + 104;
						obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj15 = 0;
						continue;
					}
					goto IL_064b;
				}
				object obj28 = (nint)0 + (nint)3912;
				flag4 = (byte)(int)obj28 != 0;
				enumerator3.Dispose();
				object obj29 = (nint)0 + (nint)1072;
				object obj30 = typeof(CardUtils.<>c) + 576;
				object obj31 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 568;
				object obj32 = (nint)0 + (nint)3456;
				object obj33 = (nint)0 + (nint)2520;
				bool flag11 = func == null;
				enumerator = (List<object>.Enumerator)0;
				enumerator4 = enumerator5;
				enumerator5 = (List<object>.Enumerator)0;
				if (!flag11)
				{
					List<object>.Enumerator enumerator6 = ((List<object>)(object)func).GetEnumerator();
					List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
					<>c__DisplayClass17_3 <>c__DisplayClass17_3 = default(<>c__DisplayClass17_3);
					Func<object, bool> func4 = default(Func<object, bool>);
					ChatMessageData chatMessageData = default(ChatMessageData);
					while (enumerator7.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						<>c__DisplayClass17_3..ctor();
						if (<>c__DisplayClass17_3 != null)
						{
							object obj34 = <>c__DisplayClass17_3 + 16;
							obj34 = flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							func4..ctor((object)<>c__DisplayClass17_3, (IntPtr)obj32);
							obj16 = obj33;
							bool flag12 = Enumerable.Any(messages, func4);
							bool flag13 = !flag12;
							object obj35 = !flag13;
							obj15 = 0;
							if (obj35 == null)
							{
								string clanChatTag4 = ClanChatTag;
								object obj36 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								chatMessageData..ctor((GameRoomData)obj34);
								ChatHandler.InjectMessage(clanChatTag4, chatMessageData);
								string clanChatTag5 = ClanChatTag;
								messages = ChatHandler.GetMessages(clanChatTag5);
								obj15 = 0;
								obj16 = 0;
							}
							continue;
						}
						goto IL_05b2;
					}
					enumerator7.Dispose();
					func = (Func<object, object>)(object)messages;
					goto IL_05a7;
				}
			}
		}
		goto IL_0838;
		IL_05ea:
		NullReferenceException ex = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		flag4 = false;
		goto IL_0838;
		IL_0838:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag14 = !flag4;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj37 = (nint)0 + (nint)1064;
			flag4 = (byte)(int)obj37 != 0;
			enumerator.Dispose();
			object obj38 = default(object);
			if (obj38 == null)
			{
				goto IL_05a7;
			}
			ex3 = new OutOfMemoryException();
			enumerator5 = (List<object>.Enumerator)obj38;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DC24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_064b:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		obj15 = 0;
		flag4 = (byte)(int)obj26 != 0;
		goto IL_0838;
		IL_061b:
		NullReferenceException ex5 = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		flag4 = flag9;
		goto IL_0838;
		IL_05b2:
		NullReferenceException ex6 = new NullReferenceException();
		enumerator = enumerator5;
		enumerator4 = enumerator5;
		enumerator5 = (List<object>.Enumerator)0;
		flag4 = false;
		func = (Func<object, object>)(object)messages;
		goto IL_0838;
		IL_05a7:
		SetMessages((List<ChatMessageData>)(object)func);
	}

	private void UpdateMuteBlocker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		bool canWrite = CanWrite;
		string muteReason = ChatHandler.MuteReason;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		DateTime? mutedUntil = SFSKammelnaUserExtensions.GetMutedUntil(localUser);
		UpdateChatState(canWrite, muteReason, mutedIcon, mutedUntil);
	}

	protected override void Init()
	{
		base.Init();
		if (HasClan)
		{
			UpdateMuteBlocker();
		}
	}

	protected override void RegisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0125: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00fd: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)832;
		object varName = "setMimeType" + 3808;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "m_StencilDeferredPS" + 2520;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go2, localUser2, (string)varName2, action2);
	}

	protected override void UnregisterSFSSceneCallbacks()
	{
	}

	protected override void AddMessage(ChatMessageData messageData)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		if (HasClan)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+B8]");
			object obj3 = 0;
			string clanChatTag = ClanChatTag;
			if (!((string)obj3 != clanChatTag))
			{
				base.AddMessage(messageData);
			}
		}
	}

	protected override void SendChatMessage(string message)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_0119: Expected I, but got O
		//IL_0035: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		if (HasClan)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7+B8]");
			object obj4 = 0;
			string clanChatTag = ClanChatTag;
			bool flag = (string)obj4 != clanChatTag;
			bool flag2 = !flag;
			nint num = unchecked((nint)null);
			if (!flag2)
			{
				string clanChatTag2 = ClanChatTag;
				ChatHandler.ActiveGroup = clanChatTag2;
				num = unchecked((nint)null);
			}
		}
		ChatHandler.SendChat(message);
		ITrackEvent trackEvent = TrackerLibrary.ClanChatMessageSent();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}
}
