using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models.Products;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine.TextCore;

namespace Server.Models;

public static class CachedModels
{
	public const string AchievementsKey = "Cached_Achievements_Model";

	public const string AppAnnouncementsKey = "Cached_AppAnnouncements";

	public const string HintsKey = "Cached_Hints_Model";

	public const string LogoElementsKey = "Cached_ClanLogoElements";

	public const string MassEventsKey = "Cached_Mass_Events_Model";

	public const string NotificationsKey = "Cached_Notifications_Model";

	public const string PersonalStatsConfigsKey = "Cached_PersonalStatsConfigs";

	public const string PredictionSeasonKey = "Cached_PredictionSeason_Model";

	public const string PredictionSeasonRewardsKey = "Cached_Prediction_Season_Rewards_Model";

	public const string ReferralRewardsKey = "Cached_ReferralRewards";

	public const string REMOTE_CONFIG_KEY = "Cached_RemoteConfig";

	public const string ServersKey = "Cached_Servers_Model";

	public const string SportTeamsKey = "Cached_Sport_Teams_Model";

	public const string StoreHomePageKey = "Cached_StoreHomePage";

	public const string StoreItemsKey = "Cached_StoreItems";

	public const string StoreProfileGiftsKey = "Cached_StoreProfileGifts";

	public const string StoreProductsKey = "Cached_StoreProducts";

	public const string StoreItemGroupsKey = "Cached_StoreItemGroups";

	public const string UpcomingMatchesKey = "Cached_PredictAndWin_Match_Model";

	private static readonly Dictionary<string, ICachedModel> Models;

	public static CachedModel<List<GameAchievementViewModel>> Achievements
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 552;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<GameAchievementViewModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<GameAchievementViewModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<AppAnnouncementModel>> AppAnnouncements
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<AppAnnouncementModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<AppAnnouncementModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<UserReferralRewardModel>> ReferralRewards
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<UserReferralRewardModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<UserReferralRewardModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<MatchPredictionModel>> UpcomingPredictionsModel
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 608;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<MatchPredictionModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<MatchPredictionModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<RemoteConfigModel> RemoteConfig
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<RemoteConfigModel>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<RemoteConfigModel>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<SportTeam>> SportTeams
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 632;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<SportTeam>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<SportTeam>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<StoreHomePageViewModel> StoreHomePage
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 640;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<StoreHomePageViewModel>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<StoreHomePageViewModel>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<StoreItem>> StoreItems
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 664;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<StoreItem>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<StoreItem>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<ProfileGiftModel>> StoreProfileGifts
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<ProfileGiftModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<ProfileGiftModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<ProductViewModel>> StoreProducts
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 672;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<ProductViewModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<ProductViewModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<ItemGroup>> StoreItemGroups
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 656;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<ItemGroup>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<ItemGroup>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<MassEventModel>> MassEvents
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<MassEventModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<MassEventModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<Notification>> Notifications
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 592;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<Notification>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<Notification>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<InGameHintModel>> Hints
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 576;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<InGameHintModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<InGameHintModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<PersonalReportTypeConfig>> PersonalStatsConfigs
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 600;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<PersonalReportTypeConfig>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<PersonalReportTypeConfig>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<List<ClanLogoElementViewModel>> LogoElements
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object key = "COORDINATE_TYPE_GCJ_02" + 568;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return (CachedModel<List<ClanLogoElementViewModel>>)(object)GetModel<object>((string)key);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return (CachedModel<List<ClanLogoElementViewModel>>)(object)GetModel<object>((string)key);
		}
	}

	public static CachedModel<T> GetModel<T>(string key)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_03aa: Expected O, but got I
		//IL_0091: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_01d1: Expected O, but got I4
		//IL_043c: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_03d7: Expected O, but got I
		//IL_03f0: Expected O, but got I
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0418: Expected O, but got I4
		//IL_0202: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_028a: Expected I, but got O
		//IL_02b3: Expected O, but got I4
		//IL_0181: Expected O, but got I
		//IL_02e7: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v31+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		object obj4 = obj;
		object obj5 = obj2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v1+B8]");
		object obj6 = 0;
		CachedModel<T> cachedModel;
		if (obj6 != null)
		{
			object obj7 = (nint)0 + (nint)2840;
			object obj8 = obj7;
			bool flag2 = ((Dictionary<object, object>)obj6).ContainsKey((object)key);
			bool flag3 = !flag2;
			object obj9 = !flag3;
			object obj10 = key;
			if (obj9 == null)
			{
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v20+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v20+B8]");
				object obj13 = 0;
				bool gameSpecific = IsGameSpecific(key);
				object obj14 = (nint)0 + (nint)309;
				object obj15 = obj14 & 1;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				nint num = 0;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = default(object);
				((CachedModel<T>)obj17)..ctor(key, gameSpecific);
				if (obj13 == null)
				{
					goto IL_037e;
				}
				object obj18 = (nint)0 + (nint)2864;
				((Dictionary<object, object>)obj13).set_Item((object)key, obj17);
				obj10 = key;
				obj8 = obj17;
			}
			object obj19 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v10+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v10+B8]");
			object obj21 = 0;
			if (obj21 != null)
			{
				object obj22 = (nint)0 + (nint)2848;
				object obj23 = ((Dictionary<object, object>)obj21).get_Item((object)key);
				object obj24 = (nint)0 + (nint)309;
				object obj25 = obj24 & 1;
				bool flag7 = obj25 == null;
				object obj26 = !flag7;
				nint num2 = 0;
				cachedModel = (CachedModel<T>)obj23;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					IntPtr intPtr = default(IntPtr);
					num2 = intPtr;
					cachedModel = (CachedModel<T>)obj23;
				}
				if (cachedModel == null)
				{
					goto IL_030e;
				}
				nint num3 = (nint)cachedModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v17 (Il2CppClass<Server.Models.CachedModel`1<T>>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X1_v7 (Il2CppClass<Server.Models.CachedModel`1<T>>)+130]");
				bool flag8 = num4 < 0;
				object obj27 = !flag8;
				object obj28 = ~obj27;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v17 (Il2CppClass<Server.Models.CachedModel`1<T>>)+C8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X1_v7 (Il2CppClass<Server.Models.CachedModel`1<T>>)+130]");
					object obj29 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v19-8]");
					if (0 == num2)
					{
						goto IL_030e;
					}
				}
				goto IL_038c;
			}
		}
		goto IL_037e;
		IL_038c:
		return (CachedModel<T>)(object)new InvalidCastException();
		IL_030e:
		return cachedModel;
		IL_037e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_038c;
	}

	public static DateTime? GetServerLastUpdate(string key)
	{
		//IL_109a: Expected O, but got I4
		//IL_10a8: Expected O, but got I4
		//IL_10c2: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		//IL_01fd: Expected O, but got I8
		//IL_0217: Expected O, but got I4
		//IL_0532: Expected O, but got I4
		//IL_0544: Expected O, but got I8
		//IL_055e: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Expected O, but got Unknown
		//IL_0f95: Expected O, but got I4
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected O, but got Unknown
		//IL_0c7d: Expected O, but got I4
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Expected O, but got Unknown
		//IL_0d85: Expected O, but got I4
		//IL_070f: Expected O, but got I4
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Expected O, but got Unknown
		//IL_0e8d: Expected O, but got I4
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0b75: Expected O, but got I4
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected O, but got Unknown
		//IL_0fe1: Expected O, but got I4
		//IL_05b9: Expected O, but got I4
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected O, but got Unknown
		//IL_0cc9: Expected O, but got I4
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_0965: Expected O, but got I4
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0dd1: Expected O, but got I4
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected O, but got Unknown
		//IL_0a6d: Expected O, but got I4
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_0755: Expected O, but got I4
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaf: Expected O, but got Unknown
		//IL_0ed9: Expected O, but got I4
		//IL_0293: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected O, but got Unknown
		//IL_0bc1: Expected O, but got I4
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_085d: Expected O, but got I4
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05ff: Expected O, but got I4
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected O, but got Unknown
		//IL_09b1: Expected O, but got I4
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected O, but got Unknown
		//IL_0ab9: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_07a1: Expected O, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I4
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0444: Expected O, but got I4
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_08a9: Expected O, but got I4
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_064b: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0325: Expected O, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0490: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(key);
		bool flag = (int)num < 2133889786;
		object obj = !flag;
		object obj2 = num - 2133889786;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		DateTime? result;
		DateTime value;
		if (obj4 == null)
		{
			bool flag3 = (int)num < 711207341;
			object obj5 = !flag3;
			object obj6 = num - 711207341;
			bool flag4 = obj6 == null;
			object obj7 = !flag4;
			object obj8 = obj5 & obj7;
			if (obj8 == null)
			{
				if (num != 157893733)
				{
					if (num != 314079924)
					{
						bool flag5 = num != 711207341;
						result = (DateTime?)(object)0;
						if (!flag5)
						{
							object obj9 = "COORDINATE_TYPE_GCJ_02" + 680;
							bool flag6 = key == (string)obj9;
							bool flag7 = !flag6;
							result = (DateTime?)(object)0;
							if (!flag7)
							{
								object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
								object obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v96+E4]");
								bool flag8 = (nint)0 == 0;
								object obj12 = !flag8;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								SFSConfig currentSFS = Config.CurrentSFS;
								if (currentSFS != null)
								{
									LastRequestUpdateModel <LastRequestUpdates>k__BackingField = currentSFS.<LastRequestUpdates>k__BackingField;
									if (currentSFS.<LastRequestUpdates>k__BackingField != null)
									{
										value = <LastRequestUpdates>k__BackingField.<StoreProfileGiftsRequestUpdate>k__BackingField;
										goto IL_10e2;
									}
								}
								goto IL_1065;
							}
						}
					}
					else
					{
						object obj13 = "COORDINATE_TYPE_GCJ_02" + 608;
						bool flag9 = key == (string)obj13;
						bool flag10 = !flag9;
						result = (DateTime?)(object)0;
						if (!flag10)
						{
							object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
							object obj15 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v89+E4]");
							bool flag11 = (nint)0 == 0;
							object obj16 = !flag11;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SFSConfig currentSFS2 = Config.CurrentSFS;
							if (currentSFS2 != null)
							{
								LastRequestUpdateModel <LastRequestUpdates>k__BackingField2 = currentSFS2.<LastRequestUpdates>k__BackingField;
								if (currentSFS2.<LastRequestUpdates>k__BackingField != null)
								{
									value = <LastRequestUpdates>k__BackingField2.<UpcomingPredictionsRequestUpdate>k__BackingField;
									goto IL_10e2;
								}
							}
							goto IL_1065;
						}
					}
				}
				else
				{
					object obj17 = "COORDINATE_TYPE_GCJ_02" + 560;
					bool flag12 = key == (string)obj17;
					bool flag13 = !flag12;
					result = (DateTime?)(object)0;
					if (!flag13)
					{
						object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v82+E4]");
						bool flag14 = (nint)0 == 0;
						object obj20 = !flag14;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SFSConfig currentSFS3 = Config.CurrentSFS;
						if (currentSFS3 != null)
						{
							LastRequestUpdateModel <LastRequestUpdates>k__BackingField3 = currentSFS3.<LastRequestUpdates>k__BackingField;
							if (currentSFS3.<LastRequestUpdates>k__BackingField != null)
							{
								value = <LastRequestUpdates>k__BackingField3.<AppAnnouncementsRequestUpdate>k__BackingField;
								goto IL_10e2;
							}
						}
						goto IL_1065;
					}
				}
			}
			else if (num != 744675084)
			{
				if (num != 2032873490)
				{
					bool flag15 = num != 2133889786;
					result = (DateTime?)(object)0;
					if (!flag15)
					{
						object obj21 = "COORDINATE_TYPE_GCJ_02" + 592;
						bool flag16 = key == (string)obj21;
						bool flag17 = !flag16;
						result = (DateTime?)(object)0;
						if (!flag17)
						{
							object obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
							object obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v75+E4]");
							bool flag18 = (nint)0 == 0;
							object obj24 = !flag18;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SFSConfig currentSFS4 = Config.CurrentSFS;
							if (currentSFS4 != null)
							{
								LastRequestUpdateModel <LastRequestUpdates>k__BackingField4 = currentSFS4.<LastRequestUpdates>k__BackingField;
								if (currentSFS4.<LastRequestUpdates>k__BackingField != null)
								{
									value = <LastRequestUpdates>k__BackingField4.<NotificationsRequestUpdate>k__BackingField;
									goto IL_10e2;
								}
							}
							goto IL_1065;
						}
					}
				}
				else
				{
					object obj25 = "COORDINATE_TYPE_GCJ_02" + 584;
					bool flag19 = key == (string)obj25;
					bool flag20 = !flag19;
					result = (DateTime?)(object)0;
					if (!flag20)
					{
						object obj26 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
						object obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v68+E4]");
						bool flag21 = (nint)0 == 0;
						object obj28 = !flag21;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SFSConfig currentSFS5 = Config.CurrentSFS;
						if (currentSFS5 != null)
						{
							LastRequestUpdateModel <LastRequestUpdates>k__BackingField5 = currentSFS5.<LastRequestUpdates>k__BackingField;
							if (currentSFS5.<LastRequestUpdates>k__BackingField != null)
							{
								value = <LastRequestUpdates>k__BackingField5.<MassEventsRequestUpdate>k__BackingField;
								goto IL_10e2;
							}
						}
						goto IL_1065;
					}
				}
			}
			else
			{
				object obj29 = "COORDINATE_TYPE_GCJ_02" + 576;
				bool flag22 = key == (string)obj29;
				bool flag23 = !flag22;
				result = (DateTime?)(object)0;
				if (!flag23)
				{
					object obj30 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
					object obj31 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v61+E4]");
					bool flag24 = (nint)0 == 0;
					object obj32 = !flag24;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					SFSConfig currentSFS6 = Config.CurrentSFS;
					if (currentSFS6 != null)
					{
						LastRequestUpdateModel <LastRequestUpdates>k__BackingField6 = currentSFS6.<LastRequestUpdates>k__BackingField;
						if (currentSFS6.<LastRequestUpdates>k__BackingField != null)
						{
							value = <LastRequestUpdates>k__BackingField6.<HintsRequestUpdate>k__BackingField;
							goto IL_10e2;
						}
					}
					goto IL_1065;
				}
			}
		}
		else
		{
			bool flag25 = (int)num < 3573212805L;
			object obj33 = !flag25;
			object obj34 = (int)num - 3573212805L;
			bool flag26 = obj34 == null;
			object obj35 = !flag26;
			object obj36 = obj33 & obj35;
			if (obj36 == null)
			{
				if ((int)num != 2870107325L)
				{
					if ((int)num != 3292512910L)
					{
						bool flag27 = (int)num != 3573212805L;
						result = (DateTime?)(object)0;
						if (!flag27)
						{
							object obj37 = "COORDINATE_TYPE_GCJ_02" + 640;
							bool flag28 = key == (string)obj37;
							bool flag29 = !flag28;
							result = (DateTime?)(object)0;
							if (!flag29)
							{
								object obj38 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
								object obj39 = obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v54+E4]");
								bool flag30 = (nint)0 == 0;
								object obj40 = !flag30;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								SFSConfig currentSFS7 = Config.CurrentSFS;
								if (currentSFS7 != null)
								{
									LastRequestUpdateModel <LastRequestUpdates>k__BackingField7 = currentSFS7.<LastRequestUpdates>k__BackingField;
									if (currentSFS7.<LastRequestUpdates>k__BackingField != null)
									{
										value = <LastRequestUpdates>k__BackingField7.<StoreHomeRequestUpdate>k__BackingField;
										goto IL_10e2;
									}
								}
								goto IL_1065;
							}
						}
					}
					else
					{
						object obj41 = "COORDINATE_TYPE_GCJ_02" + 568;
						bool flag31 = key == (string)obj41;
						bool flag32 = !flag31;
						result = (DateTime?)(object)0;
						if (!flag32)
						{
							object obj42 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
							object obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v47+E4]");
							bool flag33 = (nint)0 == 0;
							object obj44 = !flag33;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SFSConfig currentSFS8 = Config.CurrentSFS;
							if (currentSFS8 != null)
							{
								LastRequestUpdateModel <LastRequestUpdates>k__BackingField8 = currentSFS8.<LastRequestUpdates>k__BackingField;
								if (currentSFS8.<LastRequestUpdates>k__BackingField != null)
								{
									value = <LastRequestUpdates>k__BackingField8.<LogoElementsRequestUpdate>k__BackingField;
									goto IL_10e2;
								}
							}
							goto IL_1065;
						}
					}
				}
				else
				{
					object obj45 = "COORDINATE_TYPE_GCJ_02" + 672;
					bool flag34 = key == (string)obj45;
					bool flag35 = !flag34;
					result = (DateTime?)(object)0;
					if (!flag35)
					{
						object obj46 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
						object obj47 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v40+E4]");
						bool flag36 = (nint)0 == 0;
						object obj48 = !flag36;
						if (obj48 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SFSConfig currentSFS9 = Config.CurrentSFS;
						if (currentSFS9 != null)
						{
							LastRequestUpdateModel <LastRequestUpdates>k__BackingField9 = currentSFS9.<LastRequestUpdates>k__BackingField;
							if (currentSFS9.<LastRequestUpdates>k__BackingField != null)
							{
								value = <LastRequestUpdates>k__BackingField9.<StoreProductsRequestUpdate>k__BackingField;
								goto IL_10e2;
							}
						}
						goto IL_1065;
					}
				}
			}
			else
			{
				bool flag37 = (int)num < 4099337954L;
				object obj49 = !flag37;
				object obj50 = (int)num - 4099337954L;
				bool flag38 = obj50 == null;
				object obj51 = !flag38;
				object obj52 = obj49 & obj51;
				if (obj52 == null)
				{
					if ((int)num != 3676781375L)
					{
						bool flag39 = (int)num != 4099337954L;
						result = (DateTime?)(object)0;
						if (!flag39)
						{
							object obj53 = "COORDINATE_TYPE_GCJ_02" + 552;
							bool flag40 = key == (string)obj53;
							bool flag41 = !flag40;
							result = (DateTime?)(object)0;
							if (!flag41)
							{
								object obj54 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
								object obj55 = obj54;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v33+E4]");
								bool flag42 = (nint)0 == 0;
								object obj56 = !flag42;
								if (obj56 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								SFSConfig currentSFS10 = Config.CurrentSFS;
								if (currentSFS10 != null)
								{
									LastRequestUpdateModel <LastRequestUpdates>k__BackingField10 = currentSFS10.<LastRequestUpdates>k__BackingField;
									if (currentSFS10.<LastRequestUpdates>k__BackingField != null)
									{
										value = <LastRequestUpdates>k__BackingField10.<AchievementsRequestUpdate>k__BackingField;
										goto IL_10e2;
									}
								}
								goto IL_1065;
							}
						}
					}
					else
					{
						object obj57 = "COORDINATE_TYPE_GCJ_02" + 664;
						bool flag43 = key == (string)obj57;
						bool flag44 = !flag43;
						result = (DateTime?)(object)0;
						if (!flag44)
						{
							object obj58 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
							object obj59 = obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v26+E4]");
							bool flag45 = (nint)0 == 0;
							object obj60 = !flag45;
							if (obj60 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SFSConfig currentSFS11 = Config.CurrentSFS;
							if (currentSFS11 != null)
							{
								LastRequestUpdateModel <LastRequestUpdates>k__BackingField11 = currentSFS11.<LastRequestUpdates>k__BackingField;
								if (currentSFS11.<LastRequestUpdates>k__BackingField != null)
								{
									value = <LastRequestUpdates>k__BackingField11.<StoreItemsRequestUpdate>k__BackingField;
									goto IL_10e2;
								}
							}
							goto IL_1065;
						}
					}
				}
				else if ((int)num != 4181618956L)
				{
					bool flag46 = (int)num != 4188605582L;
					result = (DateTime?)(object)0;
					if (!flag46)
					{
						object obj61 = "COORDINATE_TYPE_GCJ_02" + 656;
						bool flag47 = key == (string)obj61;
						bool flag48 = !flag47;
						result = (DateTime?)(object)0;
						if (!flag48)
						{
							object obj62 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
							object obj63 = obj62;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v19+E4]");
							bool flag49 = (nint)0 == 0;
							object obj64 = !flag49;
							if (obj64 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SFSConfig currentSFS12 = Config.CurrentSFS;
							if (currentSFS12 != null)
							{
								LastRequestUpdateModel <LastRequestUpdates>k__BackingField12 = currentSFS12.<LastRequestUpdates>k__BackingField;
								if (currentSFS12.<LastRequestUpdates>k__BackingField != null)
								{
									value = <LastRequestUpdates>k__BackingField12.<StoreItemGroupsRequestUpdate>k__BackingField;
									goto IL_10e2;
								}
							}
							goto IL_1065;
						}
					}
				}
				else
				{
					object obj65 = "COORDINATE_TYPE_GCJ_02" + 624;
					bool flag50 = key == (string)obj65;
					bool flag51 = !flag50;
					result = (DateTime?)(object)0;
					if (!flag51)
					{
						object obj66 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
						object obj67 = obj66;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v12+E4]");
						bool flag52 = (nint)0 == 0;
						object obj68 = !flag52;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SFSConfig currentSFS13 = Config.CurrentSFS;
						if (currentSFS13 != null)
						{
							LastRequestUpdateModel <LastRequestUpdates>k__BackingField13 = currentSFS13.<LastRequestUpdates>k__BackingField;
							if (currentSFS13.<LastRequestUpdates>k__BackingField != null)
							{
								value = <LastRequestUpdates>k__BackingField13.<RemoteConfigRequestUpdate>k__BackingField;
								goto IL_10e2;
							}
						}
						goto IL_1065;
					}
				}
			}
		}
		goto IL_10dd;
		IL_1065:
		return (DateTime?)new NullReferenceException();
		IL_10e2:
		DateTime? dateTime = value;
		result = dateTime;
		goto IL_10dd;
		IL_10dd:
		return result;
	}

	private static bool IsGameSpecific(string key)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		object obj = "COORDINATE_TYPE_GCJ_02" + 600;
		bool flag = key == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			object obj3 = "COORDINATE_TYPE_GCJ_02" + 640;
			if (!(key == (string)obj3))
			{
				object obj4 = "COORDINATE_TYPE_GCJ_02" + 624;
				return key == (string)obj4;
			}
		}
		return true;
	}

	public static void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_00b0: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_0182: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_023c: Expected O, but got I
		//IL_0396: Expected O, but got I4
		//IL_02a1: Expected O, but got I
		//IL_02dc: Expected O, but got I
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B5D]");
		object obj2 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		Dictionary<object, object>.ValueCollection.Enumerator enumerator;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v56+E4]");
			bool flag = (nint)0 == 0;
			obj4 = 0;
			enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
			object obj5 = obj3;
			obj6 = 0;
			enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v56+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj4 = 0;
			enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
			object obj5 = obj3;
			obj6 = 0;
			enumerator = (Dictionary<object, object>.ValueCollection.Enumerator)0;
			if (obj7 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v32+B8]");
		object obj9 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj9;
		bool flag3 = obj9 == null;
		obj4 = obj6;
		Dictionary<object, object>.ValueCollection.Enumerator enumerator2 = enumerator;
		object obj10 = 152989696;
		if (!flag3)
		{
			goto IL_01c0;
		}
		goto IL_0431;
		IL_0431:
		NullReferenceException ex = new NullReferenceException();
		object obj11 = default(object);
		bool flag4 = (nint)obj11 != 1;
		NullReferenceException ex2 = ex;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj11 = obj10;
			enumerator2.Dispose();
			object obj12 = default(object);
			if (obj12 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj13 = obj12;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B11C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_01c0:
		object obj14 = (nint)0 + (nint)2856;
		obj11 = obj14;
		Dictionary<object, object>.ValueCollection values = dictionary.Values;
		bool flag5 = values == null;
		enumerator2 = enumerator;
		obj10 = 152989696;
		if (!flag5)
		{
			object obj15 = (nint)0 + (nint)2736;
			object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1344;
			obj10 = (nint)0 + (nint)2728;
			Dictionary<object, object>.ValueCollection.Enumerator enumerator3 = values.GetEnumerator();
			while (true)
			{
				obj11 = obj15;
				if (enumerator.MoveNext())
				{
					if (obj4 == null)
					{
						break;
					}
					object obj17 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11+12E]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11+B0]");
						object obj19 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v8-8]");
							object obj20 = 0 - obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v8-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj19 += 16;
							obj18--;
							obj20 = obj18 - 1;
							bool flag6 = obj20 == null;
							if ((nint)obj18 != 1)
							{
								continue;
							}
							goto IL_024e;
						}
						object obj21 = obj19 + 9;
						object obj22 = obj17 + obj21;
						object obj23 = obj22 + 312;
						goto IL_025d;
					}
					goto IL_024e;
				}
				enumerator.Dispose();
				return;
				IL_024e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_025d;
				IL_025d:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X0_v25] (should have been resolved before IL gen)");
			}
			NullReferenceException ex4 = new NullReferenceException();
			object obj13 = 0;
			enumerator2 = enumerator;
		}
		goto IL_0431;
		IL_00a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v56+B8]");
		object obj24 = 0;
		dictionary = (Dictionary<object, object>)obj24;
		bool flag7 = obj24 == null;
		object obj25 = !flag7;
		if (obj25 != null)
		{
			goto IL_01c0;
		}
		enumerator2 = enumerator;
		obj10 = 152989696;
		goto IL_0431;
	}

	public static void ClearLastUpdates(DateTime? epoch = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_005d: Expected O, but got I4
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_0cac: Expected O, but got I
		//IL_0cd6: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected O, but got Unknown
		//IL_0cff: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_02c3: Expected O, but got I8
		//IL_026a: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Expected O, but got Unknown
		//IL_0d47: Expected O, but got I
		//IL_0334: Expected O, but got I4
		//IL_0421: Expected O, but got I4
		//IL_0437: Expected O, but got I
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected O, but got Unknown
		//IL_0d8f: Expected O, but got I
		//IL_04be: Expected O, but got I4
		//IL_05a3: Expected O, but got I8
		//IL_054a: Expected O, but got I
		//IL_057b: Expected O, but got I
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected O, but got Unknown
		//IL_0dd7: Expected O, but got I
		//IL_0614: Expected O, but got I4
		//IL_0701: Expected O, but got I4
		//IL_0717: Expected O, but got I
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got Unknown
		//IL_06a0: Expected O, but got I
		//IL_06d1: Expected O, but got I
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected O, but got Unknown
		//IL_0e1f: Expected O, but got I
		//IL_079e: Expected O, but got I4
		//IL_088b: Expected O, but got I4
		//IL_08a1: Expected O, but got I
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_082a: Expected O, but got I
		//IL_085b: Expected O, but got I
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected O, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Expected O, but got Unknown
		//IL_0e67: Expected O, but got I
		//IL_0928: Expected O, but got I4
		//IL_0a15: Expected O, but got I4
		//IL_0a2b: Expected O, but got I
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_09b4: Expected O, but got I
		//IL_09e5: Expected O, but got I
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected O, but got Unknown
		//IL_0ac8: Expected O, but got I4
		//IL_0b33: Expected O, but got I
		//IL_0b70: Expected O, but got I
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_0bab: Expected O, but got I
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected O, but got Unknown
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected O, but got Unknown
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected O, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 2800;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B96]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				goto IL_006b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B96]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 == null)
			{
				goto IL_006b;
			}
		}
		goto IL_0c91;
		IL_03a8:
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v57+40]");
		CachedModel<object> cachedModel = (CachedModel<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		bool flag2 = ex == null;
		CachedModel<object> cachedModel3;
		CachedModel<object> cachedModel2 = cachedModel3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v57+40]");
		CachedModel<object> cachedModel4 = (CachedModel<object>)0;
		if (!flag2)
		{
			goto IL_03ff;
		}
		goto IL_0c44;
		IL_0c44:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_006b:
		_ = 1;
		goto IL_0c91;
		IL_0c91:
		object key = "COORDINATE_TYPE_GCJ_02" + 560;
		object obj9 = (nint)0 + (nint)2024;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		cachedModel = (CachedModel<object>)obj9;
		CachedModel<object> model = GetModel<object>((string)key);
		if (obj8 == null)
		{
			goto IL_0c20;
		}
		if (model != null)
		{
			object obj12 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v61+40]");
			cachedModel = (CachedModel<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag4 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v61+40]");
			cachedModel4 = (CachedModel<object>)0;
			if (flag4)
			{
				goto IL_0c44;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		CachedModel<object> cachedModel5;
		CachedModel<object> cachedModel6;
		if ((nint)0 != 0)
		{
			object obj13 = obj8 + 32;
			obj13 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key2 = "COORDINATE_TYPE_GCJ_02" + 592;
			object obj14 = (nint)0 + (nint)2080;
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				cachedModel = (CachedModel<object>)obj14;
				CachedModel<object> model2 = GetModel<object>((string)key2);
				bool flag5 = model2 == null;
				object obj16 = !flag5;
				cachedModel5 = model2;
				if (obj16 != null)
				{
					goto IL_0252;
				}
				cachedModel6 = model2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				cachedModel = (CachedModel<object>)obj14;
				CachedModel<object> model3 = GetModel<object>((string)key2);
				bool flag6 = model3 == null;
				cachedModel5 = model3;
				cachedModel6 = model3;
				if (!flag6)
				{
					goto IL_0252;
				}
			}
			goto IL_02a9;
		}
		goto IL_0c2e;
		IL_03ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		bool flag7 = (nint)0 < (nint)2;
		object obj17 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		object obj18 = -2;
		bool flag8 = obj18 == null;
		object obj19 = ~obj17;
		object obj20 = obj19 | flag8;
		CachedModel<object> cachedModel7;
		CachedModel<object> cachedModel8;
		if (obj20 == null)
		{
			object obj21 = obj8 + 48;
			obj21 = cachedModel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key3 = "COORDINATE_TYPE_GCJ_02" + 664;
			object obj22 = (nint)0 + (nint)2120;
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				cachedModel = (CachedModel<object>)obj22;
				CachedModel<object> model4 = GetModel<object>((string)key3);
				bool flag9 = model4 == null;
				object obj24 = !flag9;
				cachedModel7 = model4;
				if (obj24 != null)
				{
					goto IL_0532;
				}
				cachedModel8 = model4;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				cachedModel = (CachedModel<object>)obj22;
				CachedModel<object> model5 = GetModel<object>((string)key3);
				bool flag10 = model5 == null;
				cachedModel7 = model5;
				cachedModel8 = model5;
				if (!flag10)
				{
					goto IL_0532;
				}
			}
			goto IL_0589;
		}
		goto IL_0c2e;
		IL_09f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		bool flag11 = (nint)0 < (nint)6;
		object obj25 = !flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		object obj26 = -6;
		bool flag12 = obj26 == null;
		object obj27 = ~obj25;
		object obj28 = obj27 | flag12;
		CachedModel<object> cachedModel9;
		if (obj28 == null)
		{
			object obj29 = obj8 + 80;
			obj29 = cachedModel9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X24_v7-38]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			object obj30 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1344;
			cachedModel = cachedModel9;
			object obj31 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+v163 @ X24_v11*8]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X22_v10+v163 @ X24_v11*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v44+12E]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v44+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0acd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v44+B0]");
				object obj35 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v10-8]");
					if (0 == (nint)obj30)
					{
						break;
					}
					obj35 += 16;
					obj34--;
					if ((nint)obj34 != 1)
					{
						continue;
					}
					goto IL_0acd;
				}
				object obj36 = obj35 + 10;
				object obj37 = obj33 + obj36;
				object obj38 = obj37 + 312;
				goto IL_0adc;
				IL_0acd:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_0adc;
				IL_0adc:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v775 @ X0_v58] (should have been resolved before IL gen)");
				obj31++;
				object obj39 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
				bool flag13 = (nint)obj39 >= 0;
				cachedModel = (CachedModel<object>)epoch;
				if (!flag13)
				{
					continue;
				}
				return;
			}
			goto IL_0c20;
		}
		goto IL_0c2e;
		IL_06df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		bool flag14 = (nint)0 < (nint)4;
		object obj40 = !flag14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		object obj41 = -4;
		bool flag15 = obj41 == null;
		object obj42 = ~obj40;
		object obj43 = obj42 | flag15;
		CachedModel<object> cachedModel10;
		CachedModel<object> cachedModel11;
		CachedModel<object> cachedModel12;
		if (obj43 == null)
		{
			object obj44 = obj8 + 64;
			obj44 = cachedModel10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key4 = "COORDINATE_TYPE_GCJ_02" + 672;
			object obj45 = (nint)0 + (nint)2096;
			object obj46 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v45+E4]");
			if ((nint)0 != 0)
			{
				cachedModel = (CachedModel<object>)obj45;
				CachedModel<object> model6 = GetModel<object>((string)key4);
				bool flag16 = model6 == null;
				object obj47 = !flag16;
				cachedModel11 = model6;
				if (obj47 != null)
				{
					goto IL_0812;
				}
				cachedModel12 = model6;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				cachedModel = (CachedModel<object>)obj45;
				CachedModel<object> model7 = GetModel<object>((string)key4);
				bool flag17 = model7 == null;
				cachedModel11 = model7;
				cachedModel12 = model7;
				if (!flag17)
				{
					goto IL_0812;
				}
			}
			goto IL_0869;
		}
		goto IL_0c2e;
		IL_0c2e:
		ex = new IndexOutOfRangeException();
		cachedModel4 = cachedModel;
		goto IL_0c44;
		IL_099c:
		object obj48 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v49+40]");
		cachedModel = (CachedModel<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag18 = ex == null;
		CachedModel<object> cachedModel13;
		cachedModel9 = cachedModel13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v49+40]");
		cachedModel4 = (CachedModel<object>)0;
		if (!flag18)
		{
			goto IL_09f3;
		}
		goto IL_0c44;
		IL_0532:
		object obj49 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v55+40]");
		cachedModel = (CachedModel<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag19 = ex == null;
		cachedModel8 = cachedModel7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v55+40]");
		cachedModel4 = (CachedModel<object>)0;
		if (!flag19)
		{
			goto IL_0589;
		}
		goto IL_0c44;
		IL_0589:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		object obj50 = 0 & 0xFFFFFFFCL;
		CachedModel<object> cachedModel14;
		if (obj50 != null)
		{
			object obj51 = obj8 + 56;
			obj51 = cachedModel8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key5 = "COORDINATE_TYPE_GCJ_02" + 680;
			object obj52 = (nint)0 + (nint)2104;
			object obj53 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v39+E4]");
			if ((nint)0 != 0)
			{
				cachedModel = (CachedModel<object>)obj52;
				CachedModel<object> model8 = GetModel<object>((string)key5);
				bool flag20 = model8 == null;
				object obj54 = !flag20;
				cachedModel14 = model8;
				if (obj54 != null)
				{
					goto IL_0688;
				}
				cachedModel10 = model8;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				cachedModel = (CachedModel<object>)obj52;
				CachedModel<object> model9 = GetModel<object>((string)key5);
				bool flag21 = model9 == null;
				cachedModel14 = model9;
				cachedModel10 = model9;
				if (!flag21)
				{
					goto IL_0688;
				}
			}
			goto IL_06df;
		}
		goto IL_0c2e;
		IL_0c20:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0c2e;
		IL_0252:
		object obj55 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v59+40]");
		cachedModel = (CachedModel<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag22 = ex == null;
		cachedModel6 = cachedModel5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v59+40]");
		cachedModel4 = (CachedModel<object>)0;
		if (!flag22)
		{
			goto IL_02a9;
		}
		goto IL_0c44;
		IL_0812:
		object obj56 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v51+40]");
		cachedModel = (CachedModel<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag23 = ex == null;
		cachedModel12 = cachedModel11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v51+40]");
		cachedModel4 = (CachedModel<object>)0;
		if (!flag23)
		{
			goto IL_0869;
		}
		goto IL_0c44;
		IL_02a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		object obj57 = 0 & 0xFFFFFFFEL;
		if (obj57 != null)
		{
			object obj58 = obj8 + 40;
			obj58 = cachedModel6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key6 = "COORDINATE_TYPE_GCJ_02" + 640;
			object obj59 = (nint)0 + (nint)2144;
			object obj60 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				cachedModel = (CachedModel<object>)obj59;
				CachedModel<object> model10 = GetModel<object>((string)key6);
				bool flag24 = model10 == null;
				object obj61 = !flag24;
				cachedModel3 = model10;
				if (obj61 != null)
				{
					goto IL_03a8;
				}
				cachedModel2 = model10;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				cachedModel = (CachedModel<object>)obj59;
				CachedModel<object> model11 = GetModel<object>((string)key6);
				bool flag25 = model11 == null;
				cachedModel3 = model11;
				cachedModel2 = model11;
				if (!flag25)
				{
					goto IL_03a8;
				}
			}
			goto IL_03ff;
		}
		goto IL_0c2e;
		IL_0869:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		bool flag26 = (nint)0 < (nint)5;
		object obj62 = !flag26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		object obj63 = -5;
		bool flag27 = obj63 == null;
		object obj64 = ~obj62;
		object obj65 = obj64 | flag27;
		if (obj65 == null)
		{
			object obj66 = obj8 + 72;
			obj66 = cachedModel12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object key7 = "COORDINATE_TYPE_GCJ_02" + 656;
			object obj67 = (nint)0 + (nint)2056;
			object obj68 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v51+E4]");
			if ((nint)0 != 0)
			{
				cachedModel = (CachedModel<object>)obj67;
				CachedModel<object> model12 = GetModel<object>((string)key7);
				bool flag28 = model12 == null;
				object obj69 = !flag28;
				cachedModel13 = model12;
				if (obj69 != null)
				{
					goto IL_099c;
				}
				cachedModel9 = model12;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				cachedModel = (CachedModel<object>)obj67;
				CachedModel<object> model13 = GetModel<object>((string)key7);
				bool flag29 = model13 == null;
				cachedModel13 = model13;
				cachedModel9 = model13;
				if (!flag29)
				{
					goto IL_099c;
				}
			}
			goto IL_09f3;
		}
		goto IL_0c2e;
		IL_0688:
		object obj70 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v53+40]");
		cachedModel = (CachedModel<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag30 = ex == null;
		cachedModel10 = cachedModel14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v53+40]");
		cachedModel4 = (CachedModel<object>)0;
		if (!flag30)
		{
			goto IL_06df;
		}
		goto IL_0c44;
	}

	static CachedModels()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2416;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
