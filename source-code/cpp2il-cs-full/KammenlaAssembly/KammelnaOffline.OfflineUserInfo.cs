using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine.InputSystem.XR;

namespace KammelnaOffline;

public static class OfflineUserInfo
{
	private const string KeyState = "OfflineState";

	private static string CurrentGameUser
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c4: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8072]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame = Preferences.CurrentGame;
			return GetUserKey(currentGame);
			IL_0074:
			Games currentGame2 = Preferences.CurrentGame;
			return GetUserKey(currentGame2);
		}
	}

	public static bool IsCached
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007f: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			string userKey = GetUserKey(currentGame);
			return Prefs.HasKey(userKey);
		}
	}

	public static bool CanResume
	{
		get
		{
			//IL_006a: Expected I4, but got O
			OfflineGameState offlineGame = OfflineGame;
			if (offlineGame != null)
			{
				OfflineGameState offlineGame2 = OfflineGame;
				if (offlineGame2 != null)
				{
					return offlineGame2.Valid;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public static CachedUserInfoModel CurrentGameUserModel
	{
		get
		{
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_014c: Expected O, but got I
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			//IL_018a: Expected O, but got I4
			//IL_0020: Expected O, but got I
			//IL_00e8: Expected O, but got I4
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object defaultValue = (nint)0 + (nint)2000;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)1096;
			Games currentGame = Preferences.CurrentGame;
			string userKey = GetUserKey(currentGame);
			string text = Prefs.GetString(userKey, (string)defaultValue);
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
			CachedUserInfoModel cachedUserInfoModel = default(CachedUserInfoModel);
			if ((nint)0 != 0)
			{
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
				if (cachedUserInfoModel != null)
				{
					goto IL_00a8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
				bool flag2 = cachedUserInfoModel == null;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					goto IL_00a8;
				}
			}
			object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = default(object);
			obj10..ctor();
			return (CachedUserInfoModel)obj10;
			IL_00a8:
			return cachedUserInfoModel;
		}
		private set
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected O, but got Unknown
			//IL_0186: Expected O, but got I
			//IL_01a0: Expected O, but got I4
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected O, but got Unknown
			//IL_01fa: Expected O, but got I4
			//IL_0119: Expected O, but got I4
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8074]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8072]");
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
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8072]");
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
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj11 = obj8;
			if (obj10 != null)
			{
				goto IL_00d4;
			}
			goto IL_0210;
			IL_00d4:
			Games currentGame = Preferences.CurrentGame;
			string userKey = GetUserKey(currentGame);
			object obj12 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string value2 = JsonMapper.ToJson(value);
			Prefs.SetString(userKey, value2);
			return;
			IL_0210:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj11;
			goto IL_00d4;
			IL_008b:
			obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v1+E4]");
			bool flag5 = (nint)0 == 0;
			obj11 = obj8;
			if (!flag5)
			{
				goto IL_00d4;
			}
			goto IL_0210;
		}
	}

	public static CachedUserInfoModel BalootUserModel => UserModel(Games.Baloot);

	public static CachedUserInfoModel TarneebUserModel => UserModel(Games.Tarneeb);

	public static CachedUserInfoModel JackarooUserModel => UserModel(Games.Jackaroo);

	public static OfflineGameState OfflineGame
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_006d: Expected O, but got I
			object key = "October" + 80;
			object defaultValue = (nint)0 + (nint)2000;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object obj2 = (nint)0 + (nint)1104;
			string text = Prefs.GetString((string)key, (string)defaultValue);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
				OfflineGameState result = default(OfflineGameState);
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
			OfflineGameState result2 = default(OfflineGameState);
			return result2;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0081: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object key = "October" + 80;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string value2 = JsonMapper.ToJson(value);
			Prefs.SetString((string)key, value2);
		}
	}

	public static event Action OnStateUpdate
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 3272;
			object obj2 = typeof(SqlSingle[]) + 2376;
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
			object obj = typeof(MemberAchievementClanFeedData) + 3272;
			object obj2 = typeof(SqlSingle[]) + 2376;
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

	private unsafe static string GetUserKey(Games game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_003b: Expected O, but got Ref
		object obj = typeof(UsageHint) + 72;
		object obj2 = "October" + 96;
		object obj3 = "[{0}]:{1}" + 912;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string userDbId = UserInfo.UserDbId;
		object obj6 = default(object);
		string text = ((Enum)(&obj6)).ToString();
		return (string)obj2 + userDbId + (string)obj3 + text;
	}

	public static CachedUserInfoModel UserModel(Games game)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		object defaultValue = (nint)0 + (nint)2000;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object obj2 = (nint)0 + (nint)1096;
		Games game2 = default(Games);
		string userKey = GetUserKey(game2);
		string text = Prefs.GetString(userKey, (string)defaultValue);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
			CachedUserInfoModel result = default(CachedUserInfoModel);
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
		CachedUserInfoModel result2 = default(CachedUserInfoModel);
		return result2;
	}

	public static void Update(User user)
	{
		CachedUserInfoModel currentGameUserModel = CreateModelFromUser(user);
		CurrentGameUserModel = currentGameUserModel;
	}

	public static void Update(GameStatisticsModel gameModel)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_00b4: Expected O, but got I
		CachedUserInfoModel currentGameUserModel = CurrentGameUserModel;
		object obj = typeof(MemberAchievementClanFeedData) + 3272;
		object obj2 = currentGameUserModel + 96;
		GameStatisticsModel gameStatisticsModel = default(GameStatisticsModel);
		obj2 = gameStatisticsModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CurrentGameUserModel = currentGameUserModel;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	private static CachedUserInfoModel CreateModelFromUser(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_025b: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		string dbId = SFSKammelnaUserExtensions.GetDbId(user);
		object obj10;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = dbId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string userName = SFSKammelnaUserExtensions.GetUserName(user);
			object obj4 = obj2 + 24;
			obj4 = userName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string title = SFSKammelnaUserExtensions.GetTitle(user);
			object obj5 = obj2 + 32;
			obj5 = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int titleLevel = SFSKammelnaUserExtensions.GetTitleLevel(user);
			int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
			if (rank != null)
			{
				_ = rank.<Points>k__BackingField;
				int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(user);
				PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(user);
				if (rank2 != null)
				{
					object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					_ = rank2.<IsNew>k__BackingField;
					DateTime? avatarDate = SFSKammelnaUserExtensions.GetAvatarDate(user);
					_ = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v32+E4]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Games currentGame = Preferences.CurrentGame;
					SubscriptionStatus subscriptionStatus = SFSKammelnaUserExtensions.GetSubscriptionStatus(user);
					bool flag2 = SFSKammelnaUserExtensions.IsVerified(user);
					CachedUserInfoModel currentGameUserModel = CurrentGameUserModel;
					if (currentGameUserModel != null)
					{
						bool flag3 = currentGameUserModel.GameStatistics == null;
						object obj9 = !flag3;
						obj10 = currentGameUserModel.GameStatistics;
						if (obj9 != null)
						{
							goto IL_02aa;
						}
					}
					object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = default(object);
					obj12..ctor();
					obj10 = obj12;
					goto IL_02aa;
				}
			}
		}
		return (CachedUserInfoModel)(object)new NullReferenceException();
		IL_02aa:
		object obj13 = obj2 + 96;
		obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (CachedUserInfoModel)obj2;
	}

	public static void SaveGame(int team1Score, int team2Score, int dealer)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		int num = default(int);
		if (num <= 151 && team2Score < 152)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 3232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			_ = 1;
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object key = "October" + 80;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string value = JsonMapper.ToJson(obj2);
			Prefs.SetString((string)key, value);
		}
		else
		{
			DiscardGame();
		}
	}

	public static void DiscardGame()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I
		//IL_0204: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8078]");
		object obj2 = (nint)0 & (nint)1;
		OfflineGameState offlineGameState;
		if (obj2 != null)
		{
			OfflineGameState offlineGame = OfflineGame;
			bool flag = offlineGame == null;
			offlineGameState = offlineGame;
			if (!flag)
			{
				goto IL_006a;
			}
		}
		else
		{
			_ = 1;
			OfflineGameState offlineGame2 = OfflineGame;
			bool flag2 = offlineGame2 == null;
			object obj3 = !flag2;
			offlineGameState = offlineGame2;
			if (obj3 != null)
			{
				goto IL_006a;
			}
		}
		object obj4 = typeof(MemberAchievementClanFeedData) + 3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8075]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		object obj9 = 0;
		offlineGameState = (OfflineGameState)obj5;
		object obj10 = 0;
		object obj11 = obj6;
		object obj12 = obj5;
		if (obj8 != null)
		{
			goto IL_00d7;
		}
		goto IL_023c;
		IL_0123:
		string value = JsonMapper.ToJson(offlineGameState);
		object obj13;
		Prefs.SetString((string)obj13, value);
		return;
		IL_02a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14;
		obj13 = obj14;
		OfflineGameState offlineGameState2;
		offlineGameState = offlineGameState2;
		goto IL_0123;
		IL_00d7:
		obj13 = "October" + 80;
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		obj14 = obj13;
		offlineGameState2 = offlineGameState;
		if (!flag4)
		{
			goto IL_0123;
		}
		goto IL_02a9;
		IL_006a:
		offlineGameState.Valid = false;
		obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8075]");
		object obj16 = (nint)0 & (nint)1;
		bool flag5 = obj16 == null;
		obj10 = obj9;
		obj11 = obj6;
		obj12 = offlineGameState;
		if (!flag5)
		{
			goto IL_00d7;
		}
		goto IL_023c;
		IL_023c:
		_ = 1;
		obj13 = "October" + 80;
		obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		offlineGameState = (OfflineGameState)obj12;
		obj9 = obj10;
		obj14 = obj13;
		offlineGameState2 = (OfflineGameState)obj12;
		if (obj17 != null)
		{
			goto IL_0123;
		}
		goto IL_02a9;
	}

	public static void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2200;
		CachedUserInfoModel currentGameUserModel = CurrentGameUserModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = currentGameUserModel + 96;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CurrentGameUserModel = currentGameUserModel;
	}
}
