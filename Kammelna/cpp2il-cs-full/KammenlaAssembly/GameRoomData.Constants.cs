using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class GameRoomData
{
	private static class Constants
	{
		public const string Id = "i";

		public const string OwnerId = "o";

		public const string Name = "n";

		public const string RoomTheme = "b";

		public const string TeamScore1 = "s1";

		public const string TeamScore2 = "s2";

		public const string Players = "p";

		public const string GameType = "t";

		public const string RankLimit = "r";

		public const string CheatingAllowed = "c";

		public const string Speed = "s";

		public const string HasPassword = "l";

		public const string VoiceChat = "v";
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, bool> <>9__22_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <GetJoinableSeats>b__22_0(PlayerInfo p)
		{
			//IL_0043: Expected I4, but got O
			if (p != null)
			{
				return (byte)(p.<DBID>k__BackingField >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int Id;

	public string GroupId;

	public int OwnerId;

	public string Name;

	public int RoomThemeId;

	public int TeamScore1;

	public int TeamScore2;

	public PlayerInfo[] Players;

	public GameType GameType;

	public PlayerRank.Ranks RankLimit;

	public bool IsCheatingAllowed;

	public int Timer;

	public bool IsPasswordProtected;

	public bool IsVoiceChatEnabled;

	public IThemeColorProfile Color;

	public bool HasTheme
	{
		get
		{
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = RoomThemeId < 0;
			bool flag2 = RoomThemeId == 0;
			int num = RoomThemeId ^ RoomThemeId;
			int num2 = RoomThemeId & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public GameRoomData(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014a: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_0194: Expected I, but got O
		//IL_01a4: Expected O, but got I
		//IL_03d7: Expected I, but got O
		//IL_01df: Expected O, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		object varName = "https://www.kammelna.com/Home/Terms" + 136;
		object varName2 = "not" + 632;
		object varName3 = "m_StencilDeferredPS" + 2848;
		object defaultValue = (nint)0 + (nint)2000;
		object varName4 = "alignContent" + 3552;
		object varName5 = "rightCtrl" + 800;
		object varName6 = "rightCtrl" + 824;
		base..ctor();
		int id = SFSExtensions.Get(data, (string)varName, 0);
		Id = id;
		int ownerId = SFSExtensions.Get(data, (string)varName2, 0);
		OwnerId = ownerId;
		string text = SFSExtensions.Get(data, (string)varName3, (string)defaultValue);
		object obj = this + 40;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = SFSExtensions.Get(data, (string)varName4, 0);
		int num2 = SFSExtensions.Get(data, (string)varName5, 0);
		int num3 = SFSExtensions.Get(data, (string)varName6, 0);
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		object obj3 = "not" + 2920;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1664;
		object obj5 = (nint)0 + (nint)560;
		object obj6 = (nint)0 + (nint)448;
		object obj7 = "startPosition" + 2136;
		object obj8 = (nint)0 + (nint)88;
		object obj9 = "placementId" + 2064;
		object obj10 = (nint)0 + (nint)264;
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0220;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0220;
		}
		object obj13 = (object)(num4 + (object)(obj12 + 28)) + 312;
		goto IL_03b5;
		IL_0220:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03b5;
		IL_03b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ X0_v18] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301FE48");
		object obj14 = this + 64;
		object obj15 = default(object);
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		bool flag = SFSExtensions.Get(data, "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976, defaultValue: false);
		int num5 = SFSExtensions.Get(data, "rightCtrl" + 768, 0);
		bool flag2 = SFSExtensions.Get(data, "java.io.FileOutputStream" + 1008, defaultValue: false);
		bool flag3 = SFSExtensions.Get(data, "utf-32" + 168, defaultValue: false);
	}

	public GameRoomData(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00bc: Expected I, but got O
		//IL_03f8: Expected I, but got O
		//IL_0408: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0492: Expected I, but got O
		//IL_04a2: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0194: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_02ca: Expected I, but got O
		//IL_02da: Expected O, but got I
		//IL_0369: Expected O, but got I4
		//IL_0315: Expected O, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03a0: Expected O, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v23-8]");
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
		object obj4 = (object)(num + obj3) + 312;
		goto IL_03dc;
		IL_0564:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v457 @ X0_v38] (should have been resolved before IL gen)");
		bool isPasswordProtected = default(bool);
		IsPasswordProtected = isPasswordProtected;
		bool isVoiceChatEnabled = SFSKammelnaRoomExtensions.IsVoiceChatEnabled(room);
		IsVoiceChatEnabled = isVoiceChatEnabled;
		if (RoomThemeId >= 1)
		{
			GenerateColorTheme();
		}
		return;
		IL_0356:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj5 = 10;
		goto IL_0564;
		IL_0138:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num2 = 3;
		goto IL_0451;
		IL_04eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v349 @ X0_v14] (should have been resolved before IL gen)");
		object obj6 = this + 40;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int roomThemeID = SFSKammelnaRoomExtensions.GetRoomThemeID(room);
		RoomThemeId = roomThemeID;
		int teamScore = SFSKammelnaRoomExtensions.GetTeamScore(room, 1);
		TeamScore1 = teamScore;
		TeamScore2 = SFSKammelnaRoomExtensions.GetTeamScore(room, 2);
		PlayerInfo[] playersInfo = SFSKammelnaRoomExtensions.GetPlayersInfo(room);
		object obj8 = this + 64;
		obj8 = playersInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		PlayerRank.Ranks rankLimit = SFSKammelnaRoomExtensions.GetRankLimit(room);
		bool flag = SFSKammelnaRoomExtensions.IsCheatingAllowed(room);
		int timeoutInterval = SFSKammelnaRoomExtensions.GetTimeoutInterval(room);
		nint num3 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0356;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0356;
		}
		object obj11 = (object)(num3 + (object)(obj10 + 10)) + 312;
		obj5 = 0;
		goto IL_0564;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = unchecked((nint)null);
		goto IL_03dc;
		IL_03dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ X0_v4] (should have been resolved before IL gen)");
		int id = default(int);
		Id = id;
		nint num4 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0138;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X10_v18-8]");
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
			goto IL_0138;
		}
		object obj14 = (object)(num4 + (object)(obj13 + 3)) + 312;
		goto IL_0451;
		IL_0451:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ X0_v7] (should have been resolved before IL gen)");
		object obj15 = this + 24;
		object obj16 = default(object);
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int roomOwnerId = SFSKammelnaRoomExtensions.GetRoomOwnerId(room);
		nint num5 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_01d5;
		}
		object obj19 = (object)(num5 + (object)(obj18 + 1)) + 312;
		goto IL_04eb;
		IL_01d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 1;
		goto IL_04eb;
	}

	public static T FromSfsObject<T>(ISFSObject data) where T : GameRoomData
	{
		//IL_0019: Expected O, but got I4
		//IL_0029: Expected O, but got I
		//IL_004b: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00f6: Expected I, but got O
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_0320: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v19+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v34+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = num;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num2);
		object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag2 = array == null;
		IntPtr intPtr = default(IntPtr);
		nint num3 = intPtr;
		if (!flag2)
		{
			if (data != null)
			{
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				InvalidCastException ex = default(InvalidCastException);
				if (ex == null)
				{
					goto IL_02eb;
				}
			}
			bool flag3 = array.Length == 0;
			num3 = intPtr;
			if (flag3)
			{
				goto IL_02ca;
			}
			object obj5 = array + 32;
			obj5 = data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = Activator.CreateInstance(typeFromHandle, array);
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			num3 = 0;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr2 = default(IntPtr);
				num3 = intPtr2;
			}
			bool flag5 = obj6 == null;
			object obj10 = 0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				GameRoomData gameRoomData = default(GameRoomData);
				bool flag6 = gameRoomData == null;
				obj10 = 0;
				if (!flag6)
				{
					if (gameRoomData.HasTheme)
					{
						gameRoomData.GenerateColorTheme();
					}
					return (T)gameRoomData;
				}
				InvalidCastException ex = new InvalidCastException();
				nint num5 = num3;
				goto IL_02eb;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02ca;
		IL_02ca:
		throw new IndexOutOfRangeException();
		IL_02eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (T)(object)new OutOfMemoryException();
	}

	public int GetFirstJoinableSeatForTeam(int teamIndex)
	{
		//IL_02f9: Expected I4, but got O
		//IL_00e9: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0163: Expected I4, but got I8
		//IL_023c: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		bool[] joinableSeats = GetJoinableSeats();
		if (teamIndex != 2)
		{
			if (teamIndex != 1)
			{
				return -1;
			}
			if (joinableSeats != null)
			{
				if (joinableSeats.Length != 0)
				{
					if (joinableSeats[0])
					{
						return 1;
					}
					bool flag = joinableSeats.Length < 2;
					object obj = !flag;
					object obj2 = joinableSeats.Length - 2;
					bool flag2 = obj2 == null;
					object obj3 = ~obj;
					object obj4 = obj3 | flag2;
					if (obj4 == null)
					{
						object obj5 = 34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X0_v1 (System.Boolean[])+v192 @ X9_v7]");
						bool flag3 = (nint)0 == 0;
						object obj6 = !flag3;
						object obj7 = ~obj6;
						if (obj7 == null)
						{
							return 3;
						}
						return -1;
					}
				}
				goto IL_02dd;
			}
		}
		else if (joinableSeats != null)
		{
			bool flag4 = joinableSeats.Length < 1;
			object obj8 = !flag4;
			object obj9 = joinableSeats.Length - 1;
			bool flag5 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag5;
			if (obj11 == null)
			{
				if (joinableSeats[1])
				{
					return 2;
				}
				bool flag6 = joinableSeats.Length < 3;
				object obj12 = !flag6;
				object obj13 = joinableSeats.Length - 3;
				bool flag7 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag7;
				if (obj15 == null)
				{
					object obj16 = 35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X0_v1 (System.Boolean[])+v190 @ X9_v4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					object obj18 = ~obj17;
					if (obj18 == null)
					{
						return 4;
					}
					return -1;
				}
			}
			goto IL_02dd;
		}
		goto IL_02eb;
		IL_02eb:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_02dd:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_02eb;
	}

	private bool[] GetJoinableSeats()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0124: Expected I, but got O
		//IL_0142: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 88;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
		Func<object, bool> selector = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)1880;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
			object obj11 = (nint)0 + (nint)8;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<bool> source = Enumerable.Select(Players, selector);
		return Enumerable.ToArray(source);
	}

	private void GenerateColorTheme()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71F1]");
		object obj3 = (nint)0 & (nint)1;
		int roomThemeId;
		int roomThemeId2;
		if (obj3 != null)
		{
			roomThemeId = RoomThemeId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			roomThemeId2 = RoomThemeId;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			roomThemeId = RoomThemeId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			roomThemeId2 = RoomThemeId;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		StoreItem storeItem = Store.GetStoreItem(roomThemeId2);
		bool flag3 = storeItem == null;
		object obj6 = 0;
		if (flag3)
		{
			return;
		}
		goto IL_0164;
		IL_0164:
		object obj7 = (??)storeItem.<Color>k__BackingField & 1;
		if (obj7 != null)
		{
			object obj8 = typeof(RegisteredWaitHandle) + 1792;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RuntimeThemeColorProfile runtimeThemeColorProfile = default(RuntimeThemeColorProfile);
			runtimeThemeColorProfile..ctor();
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ThemeColorPalette themeColorPalette = default(ThemeColorPalette);
			themeColorPalette..ctor();
			Color? color = default(Color?);
			Color value = color.Value;
			themeColorPalette.PrimaryColor = (Color)storeItem.<Color>k__BackingField;
			object obj10 = runtimeThemeColorProfile + 16;
			obj10 = themeColorPalette;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj11 = this + 96;
			obj11 = runtimeThemeColorProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		return;
		IL_0091:
		storeItem = Store.GetStoreItem(roomThemeId);
		bool flag4 = storeItem == null;
		object obj12 = !flag4;
		obj6 = 0;
		if (obj12 == null)
		{
			return;
		}
		goto IL_0164;
	}
}
