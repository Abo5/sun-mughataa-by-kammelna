using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Purchasing.Telemetry;

public class PlayerProfile : MonoBehaviour
{
	private enum TrophyTabSection
	{
		Titles,
		Achievements,
		Trophies
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserAchievementModel, bool> <>9__51_0;

		public static Action<RotatingLoadingIndicator> <>9__55_0;

		public static Action<RotatingLoadingIndicator> <>9__56_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Populate>b__51_0(UserAchievementModel a)
		{
			//IL_00d4: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0089: Expected I4, but got O
			//IL_00aa: Expected O, but got I4
			if (a != null)
			{
				object obj = typeof(SqlSingle[]) + 2360;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GameAchievementViewModel achievement = AchievementsManager.GetAchievement(a.<gameAchievementId>k__BackingField);
				bool flag2 = achievement == null;
				bool result = (byte)(int)achievement != 0;
				if (!flag2)
				{
					object obj4 = achievement.<type>k__BackingField - 2;
					bool flag3 = obj4 == null;
					result = flag3;
				}
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <StopLoading>b__55_0(RotatingLoadingIndicator obj)
		{
			obj.FinishLoading();
		}

		internal void <StartLoading>b__56_0(RotatingLoadingIndicator obj)
		{
			obj.StartLoading();
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public string userDbID;

		public Action<PlayerProfile> callBack;

		internal void <ShowDetailProfile>b__0(PlayerProfile instance)
		{
			//IL_0048: Expected O, but got I
			//IL_0058: Expected O, but got I
			//IL_0068: Expected O, but got I
			instance.Show(userDbID);
			Action<PlayerProfile> action = callBack;
			if (callBack != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v1 (System.Action`1<PlayerProfile>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v1 (System.Action`1<PlayerProfile>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v1 (System.Action`1<PlayerProfile>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v34 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public Action<EditProfilePopup> callBack;

		internal void <ShowEditProfile>b__0(EditProfilePopup instance)
		{
			//IL_0042: Expected O, but got I
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			instance.Initialize();
			Action<EditProfilePopup> action = callBack;
			if (callBack != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v1 (System.Action`1<EditProfilePopup>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v1 (System.Action`1<EditProfilePopup>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v1 (System.Action`1<EditProfilePopup>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v34 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public ProfileGiftsSendersDisplayer instance;

		public PlayerProfile <>4__this;

		internal void <ShowProfileGiftsSendersDisplayer>b__1(KammelnaResponseModel<ProfileGiftsSenderModel[]> a)
		{
			instance.Populate(a.<Model>k__BackingField, <>4__this);
		}
	}

	private static readonly AddressReference<PlayerProfile> Address;

	private static readonly AddressReference<PlayerProfile> TabletAddress;

	private string activeUserDbId;

	private TextMeshProUGUI profileID;

	private TextMeshProUGUI profileEmail;

	private TextMeshProUGUI profileAces;

	private TextMeshProUGUI profileLastName;

	private TextMeshProUGUI profileKickCount;

	private TextMeshProUGUI profileMuteCount;

	private RegistrationDateText registrationDate;

	private SlideAnimationHelper popup;

	private PlayerProfileControls profileInfo;

	private PlayerStatistics playerStatistics;

	private AchievementsSelection achievementsSelection;

	private AchievementsSelection titleSelection;

	private AchievementsSelection trophySelection;

	private Transform acesChangeInfo;

	private ProfileGiftsControls profileGiftsControls;

	private ChallengesHistoryPanel challengesHistoryPanel;

	private ObjectToggler myProfileToggler;

	private ObjectToggler kickAndMuteToggler;

	private ObjectToggler editProfileToggler;

	private ObjectToggler privateInfoToggler;

	private ObjectToggler muteBeggarToggler;

	private List<CanvasGroup> blockerGroups;

	private List<RotatingLoadingIndicator> loadingIndicators;

	private TabsUI trophyTabs;

	private AssetReferenceGameObject editProfilePopup;

	private AssetReferenceGameObject sendProfileGiftPopup;

	private AssetReferenceGameObject profileGiftsSendersDisplayer;

	private PopupUI optionsPopup;

	private AcesChangeEntry acesChangeEntryPrefab;

	private ProfileGiftsSendersDisplayer _activeGiftsSendersDisplayer;

	public bool IsMyProfile
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0147: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01be: Expected I4, but got O
			//IL_019a: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7800]");
			object obj3 = (nint)0 & (nint)1;
			string text;
			string text2;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				text = activeUserDbId;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				text2 = activeUserDbId;
				if (!flag)
				{
					goto IL_00a5;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				text = activeUserDbId;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				text2 = activeUserDbId;
				if (obj7 != null)
				{
					goto IL_00a5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			text = text2;
			if (obj8 != null)
			{
				goto IL_00cc;
			}
			goto IL_01b0;
			IL_00cc:
			User localUser = sessionModel.LocalUser;
			string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
			return text == dbId;
			IL_01b0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00cc;
			}
			goto IL_01b0;
		}
	}

	private static AddressReference<PlayerProfile> GetAddress()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_003b: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0105: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1040;
		bool isTablet = ScreenUtility.IsTablet;
		object obj2 = obj;
		if (isTablet)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v9+B8]");
			return (AddressReference<PlayerProfile>)((nint)0 + (nint)8);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v9+B8]");
			return (AddressReference<PlayerProfile>)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+B8]");
		return (AddressReference<PlayerProfile>)0;
	}

	public static void ShowDetailProfile(string userDbID, TrackingPlacement placement, Action<PlayerProfile> callBack = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_013e: Expected I8, but got I4
		//IL_0382: Expected O, but got I
		//IL_039c: Expected O, but got I4
		//IL_0290: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_0252: Expected O, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0338: Expected O, but got I
		//IL_0430: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0641: Expected O, but got I
		//IL_02df: Expected O, but got I4
		//IL_03d6: Expected O, but got I
		//IL_03f0: Expected O, but got I4
		//IL_0400: Expected O, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_0608: Expected O, but got I4
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_067a: Expected O, but got I
		//IL_068b: Expected I, but got O
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06c9: Expected O, but got I4
		//IL_062c: Expected O, but got I
		//IL_0470: Expected O, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04b8: Expected O, but got I4
		//IL_04e1: Expected O, but got I
		//IL_0524: Expected O, but got I
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_057c: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj5 = obj2 + 16;
		obj5 = userDbID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = callBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1040;
		int num = Convert.ToInt32((string)obj5);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = FriendsManager.IsBlocked(num);
		object obj12 = obj9;
		object obj13;
		object obj16;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E788B]");
				object obj14 = (nint)0 & (nint)1;
				bool flag4 = obj14 == null;
				object obj15 = !flag4;
				obj16 = obj13;
				if (obj15 == null)
				{
					goto IL_01e2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E788B]");
				object obj17 = (nint)0 & (nint)1;
				if (obj17 == null)
				{
					goto IL_01e2;
				}
				obj16 = obj13;
			}
			goto IL_05b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7889]");
			object obj18 = (nint)0 & (nint)1;
			if (obj18 != null)
			{
				goto IL_026f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7889]");
			object obj19 = (nint)0 & (nint)1;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 != null)
			{
				goto IL_026f;
			}
		}
		_ = 1;
		bool isTablet = ScreenUtility.IsTablet;
		object obj21 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v54+E4]");
		object obj22 = 0;
		bool flag6 = !isTablet;
		object obj23 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v54+E4]");
		object obj24 = 0;
		object obj25 = obj21;
		if (obj23 != null)
		{
			goto IL_02c5;
		}
		goto IL_0416;
		IL_0650:
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)784;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj27);
		object obj28 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v23+E4]");
		bool flag7 = (nint)0 == 0;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj31 = (nint)0 + (nint)2224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		object obj32 = typeof(Queue<string>) + 848;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj34 = !flag8;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj35 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
		bool isMine = (string)0 == dbId;
		ITrackEvent trackEvent = TrackerLibrary.ProfileFullProfileViewed(isMine, placement);
		object obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj38 = !flag9;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		return;
		IL_05b1:
		object title = "Unsupported map type" + 608;
		object message = "Cannot populate JSON object onto type '{0}'." + 1160;
		object buttonText = "Network Authentication Required" + 3128;
		object obj39 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v62+E4]");
		bool flag10 = (nint)0 == 0;
		object obj40 = !flag10;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
		return;
		IL_0416:
		bool flag11 = obj24 == null;
		object obj41 = !flag11;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v42+B8]");
		object obj42 = 0;
		goto IL_0650;
		IL_026f:
		bool isTablet2 = ScreenUtility.IsTablet;
		obj21 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v54+E4]");
		obj22 = 0;
		bool flag12 = !isTablet2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v54+E4]");
		obj24 = 0;
		obj25 = obj21;
		if (!flag12)
		{
			goto IL_02c5;
		}
		goto IL_0416;
		IL_02c5:
		bool flag13 = obj22 == null;
		object obj43 = !flag13;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v54+B8]");
		obj42 = (nint)0 + (nint)8;
		goto IL_0650;
		IL_01e2:
		_ = 1;
		obj16 = obj13;
		goto IL_05b1;
	}

	public void Route(RoutingCommand command, string commandParam)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		PlayerProfileNavigator playerProfileNavigator = default(PlayerProfileNavigator);
		playerProfileNavigator.OnRoute(command, commandParam);
	}

	public static void ShowBannedUserError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "Unsupported map type" + 608;
		object message = "Cannot populate JSON object onto type '{0}'." + 1160;
		object buttonText = "Network Authentication Required" + 3128;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
	}

	public void ShowUserActions()
	{
		Transform transform = optionsPopup.transform;
		UIExtensions.AttachToCanvas(transform, CanvasLayer.SecondaryCanvas);
		optionsPopup.PopFromCenter(1f);
	}

	public void ShowEditProfile(Action<EditProfilePopup> callBack)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Expected I, but got O
		//IL_00d2: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1872;
		object obj4 = (nint)0 + (nint)792;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2048;
		object obj7 = obj2 + 16;
		obj7 = callBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80E14");
	}

	public void ShowSendProfileGift()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1344;
		object obj2 = (nint)0 + (nint)1008;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)1856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80D84");
	}

	public void ShowProfileGiftsSendersDisplayer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00b9: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3200;
		object obj2 = (nint)0 + (nint)1000;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2288;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80E14");
	}

	public void ShowEditProfile()
	{
		ShowEditProfile(null);
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_0135: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)1032;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj5 = (nint)0 + (nint)1040;
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnUserBlocked += action2;
	}

	private void OnPlayerProfileLoaded(PlayerProfileModel model)
	{
		long num = default(long);
		string text = num.ToString();
		if (text == activeUserDbId)
		{
			Populate(model);
		}
	}

	private void OnUserBlocked(int dbId)
	{
		int num = default(int);
		string text = num.ToString();
		if (text == activeUserDbId)
		{
			popup.SlideOut();
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_0135: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)1032;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj5 = (nint)0 + (nint)1040;
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnUserBlocked -= action2;
	}

	private void Show(string dbId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_023d: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7807]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object activeGiftsSendersDisplayer;
		UnityEngine.Object activeGiftsSendersDisplayer2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			activeGiftsSendersDisplayer = _activeGiftsSendersDisplayer;
			activeGiftsSendersDisplayer2 = _activeGiftsSendersDisplayer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			activeGiftsSendersDisplayer = _activeGiftsSendersDisplayer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			activeGiftsSendersDisplayer2 = _activeGiftsSendersDisplayer;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = activeGiftsSendersDisplayer2;
		bool flag4 = !flag3;
		object obj6 = 0;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01ea;
		IL_0287:
		ChallengesHistoryPanel challengesHistoryPanel;
		int idForCurrentlyShownUser;
		challengesHistoryPanel._idForCurrentlyShownUser = idForCurrentlyShownUser;
		popup.SlideIn();
		InitDetailProfile(dbId);
		return;
		IL_0120:
		idForCurrentlyShownUser = Convert.ToInt32(dbId);
		bool flag5 = (object)challengesHistoryPanel == null;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0287;
		IL_025e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		idForCurrentlyShownUser = Convert.ToInt32(dbId);
		ChallengesHistoryPanel challengesHistoryPanel2;
		challengesHistoryPanel = challengesHistoryPanel2;
		goto IL_0287;
		IL_0091:
		bool flag6 = activeGiftsSendersDisplayer;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		obj6 = 0;
		if (obj8 == null)
		{
			goto IL_00cb;
		}
		goto IL_01ea;
		IL_01ea:
		_activeGiftsSendersDisplayer.Hide();
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		challengesHistoryPanel = this.challengesHistoryPanel;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		obj6 = 0;
		challengesHistoryPanel2 = this.challengesHistoryPanel;
		if (obj11 != null)
		{
			goto IL_0120;
		}
		goto IL_025e;
		IL_00cb:
		object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		challengesHistoryPanel = this.challengesHistoryPanel;
		obj10 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
		bool flag9 = (nint)0 == 0;
		challengesHistoryPanel2 = this.challengesHistoryPanel;
		if (!flag9)
		{
			goto IL_0120;
		}
		goto IL_025e;
	}

	private void InitDetailProfile(string userDbID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0067: Expected I, but got O
		//IL_0084: Expected I, but got O
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)1048;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
		object obj4 = (nint)0 + (nint)1056;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj6 = this + 32;
		string text = default(string);
		obj6 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StartLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile((string)obj6, action, (Action<KammelnaError>)(object)action2);
	}

	private void Populate(PlayerProfileModel profileModel)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0174: Expected I4, but got O
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03cb: Expected O, but got I
		//IL_0404: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0243: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_01d3: Expected O, but got I
		//IL_01e3: Expected O, but got I
		//IL_0205: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_02ae: Expected O, but got I4
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_0692: Expected O, but got I
		//IL_06a3: Expected I, but got O
		//IL_06c1: Expected O, but got I
		//IL_06dc: Expected O, but got I4
		//IL_0704: Expected O, but got I4
		//IL_02de: Expected O, but got I
		//IL_052d: Expected O, but got I4
		//IL_05c3: Expected O, but got I4
		profileInfo.Populate(profileModel);
		PlayerInfo playerInfo = ((PlayerProfile)(object)profileInfo).PlayerInfoFromProfileModel(profileModel);
		object obj = challengesHistoryPanel + 96;
		obj = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = challengesHistoryPanel.gameObject;
		if (gameObject.activeSelf)
		{
			challengesHistoryPanel.RequestChallengeData();
		}
		playerStatistics.Populate(profileModel);
		bool isMyProfile = IsMyProfile;
		achievementsSelection.Populate(profileModel.<gameAchievements>k__BackingField, isMyProfile);
		bool isMyProfile2 = IsMyProfile;
		titleSelection.Populate(profileModel.<gameAchievements>k__BackingField, isMyProfile2);
		bool isMyProfile3 = IsMyProfile;
		trophySelection.Populate(profileModel.<gameAchievements>k__BackingField, isMyProfile3);
		profileGiftsControls.Populate(profileModel);
		bool isMyProfile4 = IsMyProfile;
		bool flag = !isMyProfile4;
		object obj2 = !flag;
		object obj3 = 0;
		int num = (int)profileModel;
		object obj4;
		object obj6;
		Func<object, bool> predicate;
		if (obj2 == null)
		{
			obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2464;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v78+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v78+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+8]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = 0;
				if (obj7 == null)
				{
					goto IL_028c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v78+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+8]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				obj3 = 0;
				if (obj8 == null)
				{
					goto IL_028c;
				}
			}
			goto IL_02e3;
		}
		goto IL_039c;
		IL_039c:
		bool isMyProfile5 = IsMyProfile;
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		myProfileToggler.ToggleManual(isMyProfile5);
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v29+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool isON = SFSKammelnaUserExtensions.Can(localUser, UserPermission.KickAndMutePlayers);
		kickAndMuteToggler.ToggleManual(isON);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		bool isON2 = SFSKammelnaUserExtensions.Can(localUser2, UserPermission.EditPlayerInfo);
		editProfileToggler.ToggleManual(isON2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		bool isON3;
		if (SFSKammelnaUserExtensions.Can(localUser3, UserPermission.AccessPrivateInfo))
		{
			isON3 = true;
		}
		else
		{
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v62+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel4 = default(SessionModel);
			User localUser4 = sessionModel4.LocalUser;
			bool flag6 = SFSKammelnaUserExtensions.Can(localUser4, UserPermission.ResetBeggarCurrency);
			isON3 = flag6;
		}
		privateInfoToggler.ToggleManual(isON3);
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v47+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		User localUser5 = sessionModel5.LocalUser;
		bool isON4 = SFSKammelnaUserExtensions.Can(localUser5, UserPermission.ResetBeggarCurrency);
		muteBeggarToggler.ToggleManual(isON4);
		GameObject gameObject2 = registrationDate.gameObject;
		bool isMyProfile6 = IsMyProfile;
		gameObject2.SetActive(isMyProfile6);
		PopulatePrivateInfo(profileModel);
		StopLoading();
		return;
		IL_02e3:
		bool flag8 = Enumerable.Any(profileModel.<gameAchievements>k__BackingField, predicate);
		TabsUI tabsUI = trophyTabs;
		if (flag8)
		{
			tabsUI.defaultTab = 2;
			num = 2;
		}
		else
		{
			int activeTabIndex = trophyTabs.ActiveTabIndex;
			bool flag9 = activeTabIndex != 2;
			num = 0;
			if (flag9)
			{
				goto IL_039c;
			}
			tabsUI = trophyTabs;
			tabsUI.defaultTab = 1;
			num = 1;
		}
		tabsUI.Activate(num);
		obj3 = 0;
		goto IL_039c;
		IL_028c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v78+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v24+B8]");
			obj6 = 0;
		}
		object obj19 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)760;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj6, (IntPtr)obj20);
		object obj21 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v23+B8]");
		object obj22 = (nint)0 + (nint)8;
		obj22 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = 0;
		predicate = func;
		goto IL_02e3;
	}

	private PlayerInfo PlayerInfoFromProfileModel(PlayerProfileModel profileModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Expected I4, but got I8
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor();
		if (profileModel != null && playerInfo != null)
		{
			playerInfo.<DBID>k__BackingField = (int)profileModel.<userDbId>k__BackingField;
			object obj2 = playerInfo + 24;
			obj2 = profileModel.<userName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			playerInfo.<AvatarDate>k__BackingField = profileModel.<avatarDate>k__BackingField;
			playerInfo.<ActiveCardBack>k__BackingField = profileModel.<activeCardback>k__BackingField;
			return playerInfo;
		}
		return (PlayerInfo)(object)new NullReferenceException();
	}

	private void PopulatePrivateInfo(PlayerProfileModel profile)
	{
		//IL_0032: Expected O, but got I4
		//IL_0042: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_005a: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00f4: Expected I, but got O
		//IL_0140: Expected I, but got O
		//IL_0192: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_035b: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0399: Expected O, but got I4
		//IL_03a9: Expected O, but got I
		//IL_01ee: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0231: Expected O, but got I
		//IL_040b: Expected O, but got I
		//IL_041b: Expected O, but got I
		//IL_0431: Expected O, but got I
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_0459: Expected O, but got I4
		//IL_0469: Expected O, but got I
		//IL_03e3: Expected O, but got I4
		//IL_02e5: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_0319: Expected I, but got O
		//IL_0274: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_029a: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I
		//IL_0491: Expected O, but got I
		//IL_032c: Expected I, but got O
		//IL_04b7: Expected I, but got O
		//IL_04c4: Expected I, but got O
		//IL_0540: Expected I, but got O
		//IL_05ce: Expected I, but got O
		//IL_066a: Expected I, but got O
		//IL_06f8: Expected I, but got O
		//IL_0739: Expected I, but got O
		//IL_074f: Expected I, but got O
		//IL_07dd: Expected I, but got O
		//IL_086a: Expected O, but got I
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected O, but got Unknown
		//IL_088a: Expected O, but got I
		//IL_0896: Expected O, but got I
		//IL_08d7: Expected O, but got I4
		//IL_08fc: Expected I, but got O
		//IL_0954: Expected O, but got I4
		TextMeshProUGUI textMeshProUGUI = profileLastName;
		bool flag = (object)profileLastName == null;
		GameObject[] array = (GameObject[])(object)profile;
		TextMeshProUGUI textMeshProUGUI3 = default(TextMeshProUGUI);
		Transform transform;
		nint num2;
		if (!flag)
		{
			TextMeshProUGUI textMeshProUGUI2 = profileEmail;
			textMeshProUGUI3 = profileAces;
			TextMeshProUGUI textMeshProUGUI4 = profileID;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+90]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+B8]");
			object obj3 = 0;
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			num2 = 0;
			profileLastName.text = (string)obj3;
			bool flag2 = (object)profileEmail == null;
			array = (GameObject[])obj3;
			if (!flag2)
			{
				nint num3 = (nint)textMeshProUGUI2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				num2 = 0;
				profileEmail.text = (string)obj3;
				bool flag3 = (object)textMeshProUGUI3 == null;
				array = (GameObject[])obj3;
				if (!flag3)
				{
					nint num4 = (nint)textMeshProUGUI3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v11 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
					num2 = 0;
					textMeshProUGUI3.text = (string)obj3;
					bool flag4 = (object)profileID == null;
					array = (GameObject[])obj3;
					if (!flag4)
					{
						nint num5 = (nint)textMeshProUGUI4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
						num2 = 0;
						profileID.text = (string)obj3;
						bool flag5 = (object)acesChangeInfo == null;
						array = (GameObject[])obj3;
						if (!flag5)
						{
							object obj4 = (nint)0 + (nint)3120;
							transform = acesChangeInfo.transform;
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v7+38]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v7+38]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v13+10]");
								object obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v13+10]");
								object obj8 = (nint)0 + (nint)309;
								object obj9 = obj8 & 1;
								bool flag6 = obj9 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v13+10]");
								object obj10 = 0;
								if (!flag6)
								{
									goto IL_023f;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v7+38]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v44+10]");
								object obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v44+10]");
								object obj12 = (nint)0 + (nint)309;
								object obj13 = obj12 & 1;
								bool flag7 = obj13 == null;
								object obj14 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v44+10]");
								object obj10 = 0;
								if (obj14 != null)
								{
									goto IL_023f;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v62+E4]");
							bool flag8 = (nint)0 == 0;
							object obj15 = !flag8;
							if (obj15 != null)
							{
								goto IL_0264;
							}
							goto IL_03f1;
						}
					}
				}
			}
		}
		goto IL_0a22;
		IL_02d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v70+B8]");
		object obj16 = 0;
		array = (GameObject[])obj16;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])obj16);
		bool flag9 = profile == null;
		object obj17 = !flag9;
		nint num6 = unchecked((nint)null);
		if (obj17 != null)
		{
			goto IL_04d2;
		}
		num2 = unchecked((nint)null);
		goto IL_0a22;
		IL_023f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v62+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0264;
		}
		goto IL_03f1;
		IL_03f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v7+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v39+10]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v39+10]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag10 = obj21 == null;
		object obj22 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v39+10]");
		object obj23 = 0;
		if (obj22 != null)
		{
			goto IL_02d5;
		}
		goto IL_0477;
		IL_0264:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X22_v7+38]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v50+10]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v50+10]");
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag11 = obj26 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v50+10]");
		obj23 = 0;
		if (!flag11)
		{
			goto IL_02d5;
		}
		goto IL_0477;
		IL_0477:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v60+B8]");
		object obj27 = 0;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])obj27);
		bool flag12 = profile == null;
		num6 = unchecked((nint)null);
		array = (GameObject[])obj27;
		num2 = unchecked((nint)null);
		if (!flag12)
		{
			goto IL_04d2;
		}
		goto IL_0a22;
		IL_0a22:
		NullReferenceException ex = new NullReferenceException();
		bool flag13 = (nint)array != 1;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			array = (GameObject[])(object)textMeshProUGUI3;
			enumerator.Dispose();
			object obj28 = default(object);
			if (obj28 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj29 = obj28;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A38C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_04d2:
		if (profile.<PrivateInfo>k__BackingField == null)
		{
			return;
		}
		TextMeshProUGUI textMeshProUGUI5 = profileID;
		long num7 = default(long);
		string text = num7.ToString();
		bool flag14 = (object)profileID == null;
		array = null;
		num2 = num6;
		if (!flag14)
		{
			nint num8 = (nint)textMeshProUGUI5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v17 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			num2 = 0;
			profileID.text = text;
			bool flag15 = profile.<PrivateInfo>k__BackingField == null;
			array = (GameObject[])(object)text;
			if (!flag15)
			{
				TextMeshProUGUI textMeshProUGUI6 = profileAces;
				string text2 = num7.ToString();
				bool flag16 = (object)profileAces == null;
				array = null;
				if (!flag16)
				{
					nint num9 = (nint)textMeshProUGUI6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v20 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
					num2 = 0;
					profileAces.text = text2;
					PrivateUserInfo <PrivateInfo>k__BackingField = profile.<PrivateInfo>k__BackingField;
					bool flag17 = profile.<PrivateInfo>k__BackingField == null;
					array = (GameObject[])(object)text2;
					if (!flag17)
					{
						TextMeshProUGUI textMeshProUGUI7 = profileEmail;
						bool flag18 = (object)profileEmail == null;
						array = (GameObject[])(object)text2;
						if (!flag18)
						{
							array = (GameObject[])(object)<PrivateInfo>k__BackingField.<Email>k__BackingField;
							nint num10 = (nint)textMeshProUGUI7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
							num2 = 0;
							profileEmail.text = <PrivateInfo>k__BackingField.<Email>k__BackingField;
							PrivateUserInfo <PrivateInfo>k__BackingField2 = profile.<PrivateInfo>k__BackingField;
							if (profile.<PrivateInfo>k__BackingField != null)
							{
								TextMeshProExtensions.FixArabic(profileLastName, <PrivateInfo>k__BackingField2.<LastName>k__BackingField);
								bool flag19 = profile.<PrivateInfo>k__BackingField == null;
								array = (GameObject[])(object)<PrivateInfo>k__BackingField2.<LastName>k__BackingField;
								num2 = unchecked((nint)null);
								if (!flag19)
								{
									TextMeshProUGUI textMeshProUGUI8 = profileKickCount;
									int num11 = default(int);
									string text3 = num11.ToString();
									bool flag20 = (object)profileKickCount == null;
									array = null;
									num2 = unchecked((nint)null);
									if (!flag20)
									{
										nint num12 = (nint)textMeshProUGUI8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v26 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
										num2 = 0;
										profileKickCount.text = text3;
										bool flag21 = profile.<PrivateInfo>k__BackingField == null;
										array = (GameObject[])(object)text3;
										if (!flag21)
										{
											TextMeshProUGUI textMeshProUGUI9 = profileMuteCount;
											string text4 = num11.ToString();
											bool flag22 = (object)profileMuteCount == null;
											array = null;
											if (!flag22)
											{
												nint num13 = (nint)textMeshProUGUI9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v29 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
												num2 = 0;
												profileMuteCount.text = text4;
												PrivateUserInfo <PrivateInfo>k__BackingField3 = profile.<PrivateInfo>k__BackingField;
												bool flag23 = profile.<PrivateInfo>k__BackingField == null;
												array = (GameObject[])(object)text4;
												if (!flag23)
												{
													bool flag24 = <PrivateInfo>k__BackingField3.<AcesHistory>k__BackingField == null;
													array = (GameObject[])(object)text4;
													if (!flag24)
													{
														object obj30 = (nint)0 + (nint)3088;
														object obj31 = typeof(MemberAchievementClanFeedData) + 2976;
														object obj32 = (nint)0 + (nint)440;
														textMeshProUGUI3 = (TextMeshProUGUI)((nint)0 + (nint)3080);
														List<object>.Enumerator enumerator2 = ((List<object>)(object)<PrivateInfo>k__BackingField3.<AcesHistory>k__BackingField).GetEnumerator();
														AcesChangeEntry acesChangeEntry = default(AcesChangeEntry);
														while (true)
														{
															if (enumerator.MoveNext())
															{
																object obj33 = obj31;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v53+E4]");
																bool flag25 = (nint)0 == 0;
																object obj34 = !flag25;
																if (obj34 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																num2 = (nint)obj32;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
																if ((object)acesChangeEntry == null)
																{
																	break;
																}
																acesChangeEntry.Populate(null);
																continue;
															}
															enumerator.Dispose();
															return;
														}
														NullReferenceException ex4 = new NullReferenceException();
														object obj29 = 0;
														array = (GameObject[])(object)acesChangeInfo;
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
		goto IL_0a22;
	}

	private void ShowError(KammelnaError error)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.SlideOut();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName);
		ITrackEvent trackEvent = TrackerLibrary.ProfileFullProfileLoadError();
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void StopLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01e1: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_0221: Expected I, but got O
		//IL_023f: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_018b: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
		object obj2 = (nint)0 + (nint)1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2568;
		object obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2464;
		((List<object>)(object)blockerGroups).ForEach(action);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+E4]");
		object obj6;
		Action<object> action2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				goto IL_00c6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+10]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00c6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)776;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v13+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = loadingIndicators == null;
		object obj14 = !flag3;
		action2 = action3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		((List<object>)(object)loadingIndicators).ForEach(action2);
	}

	private void StartLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01e1: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_0221: Expected I, but got O
		//IL_023f: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_018b: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
		object obj2 = (nint)0 + (nint)1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2568;
		object obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2464;
		((List<object>)(object)blockerGroups).ForEach(action);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+E4]");
		object obj6;
		Action<object> action2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+18]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+18]");
			if ((nint)0 != 0)
			{
				goto IL_00c6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+18]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v8+18]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00c6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)768;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v13+B8]");
		object obj13 = (nint)0 + (nint)24;
		obj13 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = loadingIndicators == null;
		object obj14 = !flag3;
		action2 = action3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		((List<object>)(object)loadingIndicators).ForEach(action2);
	}

	private static void MakeVisible(CanvasGroup canvas)
	{
		int num = ShortcutExtensions.DOKill(canvas);
		GameObject gameObject = canvas.gameObject;
		gameObject.SetActive(value: true);
		canvas.alpha = 1f;
	}

	private static void AnimateHide(CanvasGroup canvas)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2480;
		int num = ShortcutExtensions.DOKill(canvas);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvas, 0f, 0.3f);
		TweenCallback tweenCallback = TweenHelpers.Disable(canvas);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	static PlayerProfile()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		object obj = "Picking audio files is not supported on iOS" + 496;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3120;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1040;
		object obj4 = "Picking audio files is not supported on iOS" + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj5 = obj3;
		object obj7 = default(object);
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+B8]");
		object obj9 = (nint)0 + (nint)8;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <ShowSendProfileGift>b__42_0(BuyProfileGiftHandler instance)
	{
		instance.SetTargetUserId(activeUserDbId, profileGiftsControls);
	}

	private void <ShowProfileGiftsSendersDisplayer>b__43_0(ProfileGiftsSendersDisplayer instance)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		//IL_0124: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 464;
		object obj5 = (nint)0 + (nint)800;
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 16;
		obj7 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_activeGiftsSendersDisplayer = (ProfileGiftsSendersDisplayer)obj7;
		object obj8 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long userId = Convert.ToInt64(activeUserDbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		KammelnaRequests.GetUserProfileGiftsSenders(userId, action);
	}
}
