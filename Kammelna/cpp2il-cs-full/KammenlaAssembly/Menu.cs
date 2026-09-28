using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline;
using Newtonsoft.Json.Linq.JsonPath;
using ReportEnums;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class Menu : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<CreateGamePopup> <>9__23_0;

		public static Action<CreateGamePopup> <>9__24_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OnCreateRoomClick>b__23_0(CreateGamePopup popup)
		{
			popup.Popup(isVoiceChatVersion: false);
		}

		internal void <OnCreateVoiceRoomClick>b__24_0(CreateGamePopup popup)
		{
			popup.Popup(isVoiceChatVersion: true);
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public bool skipAd;

		internal void <PlayRanked>b__3()
		{
			SFS.RankedMatch(skipAd);
		}
	}

	private GameObject BuyGoldenCards;

	private GameObject SubscribeNow;

	private RankedPlayManager playButton;

	private GameObject FTOpen;

	private GameObject FTClose;

	private DateTimeText TimeTillFTOpens;

	private GameObject GoToFastTrack;

	private ComponentReference<CreateGamePopup> createGameloaderRef;

	private AssetReferenceGameObject notEnoughAcesToPlayRankedRef;

	private ComponentReference<NotificationPopUp> notificationPopUp;

	private HintsPopup HintsPopup;

	private Image miniGameButtonImage;

	private Sprite _defaultMiniGameButtonSprite;

	private GenericSoundAlbum soundAlbum;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0367: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_01a4: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_01eb: Expected I, but got O
		//IL_0215: Expected O, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0261: Expected I, but got O
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0286: Expected O, but got I
		//IL_02c9: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj2 = (nint)0 + (nint)1096;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1088;
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoomFailed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action2;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = miniGameButtonImage;
			bool flag3 = !flag2;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_0162;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)miniGameButtonImage)
			{
				goto IL_0162;
			}
		}
		goto IL_0198;
		IL_0162:
		Image image = miniGameButtonImage;
		object obj11 = this + 128;
		obj11 = image.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0198;
		IL_0198:
		object obj12 = (nint)0 + (nint)1072;
		object obj13 = typeof(RegisteredWaitHandle) + 3136;
		object obj14 = (nint)0 + (nint)1080;
		GameObject popup = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj12);
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action3, persistent: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj14);
		object obj17 = typeof(Queue<string>) + 848;
		object obj18 = (nint)0 + (nint)2200;
		HintsPopup.OnMatchMakingCancel += action4;
		SplashAnimation.SwitchToScene();
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v25+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool isInLobby = sessionModel.IsInLobby;
		bool flag6 = !isInLobby;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			SFS.JoinLobby();
		}
		InitializePushNotificationReminder();
	}

	private void OnBackButtonClicked()
	{
		ExitPopup.Show();
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0247: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		//IL_02b5: Expected O, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I4
		//IL_03c6: Expected O, but got I4
		//IL_02ed: Expected O, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0326: Expected O, but got I
		//IL_0334: Expected I, but got O
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_034e: Expected O, but got I
		//IL_0379: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B1]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v53+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v53+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_01a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_026e;
		}
		goto IL_0484;
		IL_026e:
		User localUser = sessionModel.LocalUser;
		bool flag4 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
		bool flag5 = !flag4;
		object obj8 = !flag5;
		object obj9 = 0;
		bool flag6 = true;
		if (obj8 == null)
		{
			SubscribeNow.SetActive(value: true);
			object obj10 = (nint)0 + (nint)1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)1104;
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(this, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v35+50]");
			((UnityEvent)0).AddListener(unityAction);
			object obj14 = default(object);
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v18+180]");
			flag6 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X8_v18+178] (should have been resolved before IL gen)");
			obj9 = 0;
		}
		UpdateFTStatus();
		ApplyMiniGameButtonImage();
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		int newCount = MenuWinSection.ActivePrizesCount();
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Prizes, newCount);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		OfflineUserInfo.Update(localUser2);
		Prefs.Save();
		ITrackEvent trackEvent = TrackerLibrary.MainMenuViewed();
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0484:
		throw new NullReferenceException();
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag9 = (object)sessionModel3 == null;
		object obj22 = !flag9;
		if (obj22 != null)
		{
			goto IL_0137;
		}
		goto IL_0484;
		IL_0137:
		User localUser3 = sessionModel3.LocalUser;
		if (SFSKammelnaUserExtensions.GetAces(localUser3) != 0)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v41+E4]");
			bool flag10 = (nint)0 == 0;
			object obj24 = 0;
			if (!flag10)
			{
				goto IL_01a9;
			}
		}
		else
		{
			object obj25 = (nint)0 + (nint)1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			object obj27 = default(object);
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v22+180]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v220 @ X8_v22+178] (should have been resolved before IL gen)");
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v41+E4]");
			bool flag11 = (nint)0 == 0;
			object obj28 = !flag11;
			if (obj28 != null)
			{
				goto IL_01a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_026e;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj2 = (nint)0 + (nint)1096;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1088;
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoomFailed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action2;
	}

	private void OnSubscribeNowAnimationComplete()
	{
		Transform transform = SubscribeNow.transform;
		transform.SetAsLastSibling();
	}

	private void UpdateFTStatus()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62E0]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject fTOpen;
		if (obj3 != null)
		{
			gameObject = FTOpen;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			fTOpen = FTOpen;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			gameObject = FTOpen;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			fTOpen = FTOpen;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig fTServerForCurrentGame = Config.FTServerForCurrentGame;
		gameObject = fTOpen;
		goto IL_013e;
		IL_013e:
		bool flag3 = fTServerForCurrentGame == null;
		bool active = !flag3;
		gameObject.SetActive(active);
		FTClose.SetActive(value: false);
		return;
		IL_0091:
		fTServerForCurrentGame = Config.FTServerForCurrentGame;
		bool flag4 = (object)gameObject == null;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013e;
	}

	private void UpdateMiniGame()
	{
		ApplyMiniGameButtonImage();
	}

	private void ApplyMiniGameButtonImage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0442: Expected O, but got I4
		//IL_0473: Expected O, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_04b4: Expected O, but got I
		//IL_04c2: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62E1]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v40+E4]");
			bool flag = (nint)0 == 0;
			obj5 = miniGameButtonImage;
			obj6 = miniGameButtonImage;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = miniGameButtonImage;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = miniGameButtonImage;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_020b:
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02c6;
		IL_02c6:
		VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
		SFSConfig sFSConfig;
		if (sFSConfig != null)
		{
			object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				bool flag6 = StringsExtensions.IsNullOrEmpty(<Visuals>k__BackingField.<MiniGameButtonImage>k__BackingField);
				bool flag7 = !flag6;
				obj10 = null;
				if (!flag7)
				{
					goto IL_0366;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag8 = StringsExtensions.IsNullOrEmpty(<Visuals>k__BackingField.<MiniGameButtonImage>k__BackingField);
				bool flag9 = !flag8;
				object obj14 = !flag9;
				obj10 = null;
				if (obj14 != null)
				{
					goto IL_0366;
				}
			}
			LastRequestUpdateModel <LastRequestUpdates>k__BackingField = sFSConfig.<LastRequestUpdates>k__BackingField;
			object obj15 = (nint)0 + (nint)2264;
			DateTime? timestamp = <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField;
			object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)1032;
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj17);
			UIExtensions.LoadImage(miniGameButtonImage, <Visuals>k__BackingField.<MiniGameButtonImage>k__BackingField, <Visuals>k__BackingField.<MiniGameButtonImage>k__BackingField, setNative: false, storeLocally: true, timestamp);
			return;
		}
		goto IL_0366;
		IL_0366:
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!(_defaultMiniGameButtonSprite != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(_defaultMiniGameButtonSprite != null))
			{
				return;
			}
		}
		miniGameButtonImage.sprite = _defaultMiniGameButtonSprite;
		return;
		IL_0091:
		bool flag10 = obj5 == null;
		bool flag11 = !flag10;
		obj9 = 0;
		obj10 = null;
		if (!flag11)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj20 = typeof(RegisteredWaitHandle) + 56;
		object obj21 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v2+E4]");
		SFSConfig sFSConfig2;
		if ((nint)0 != 0)
		{
			SFSConfig currentSFS = Config.CurrentSFS;
			object obj22 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v26+E4]");
			bool flag12 = (nint)0 == 0;
			sFSConfig = currentSFS;
			sFSConfig2 = currentSFS;
			if (!flag12)
			{
				goto IL_020b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SFSConfig currentSFS2 = Config.CurrentSFS;
			object obj22 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v26+E4]");
			bool flag13 = (nint)0 == 0;
			object obj23 = !flag13;
			sFSConfig = currentSFS2;
			sFSConfig2 = currentSFS2;
			if (obj23 != null)
			{
				goto IL_020b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		sFSConfig = sFSConfig2;
		goto IL_02c6;
	}

	private void LoadGame(bool isWaitingForAd, bool isDisableCancelButton, Action matchMethod)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		//IL_0097: Expected O, but got I4
		RankedPlayManager rankedPlayManager = playButton;
		rankedPlayManager.playButton.interactable = false;
		HintsPopup.Open(isWaitingForAd, isDisableCancelButton);
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.AnimateTransitionOut(matchMethod);
	}

	public void OnCreateRoomClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62E2]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<CreateGamePopup> componentReference2;
		object obj4;
		ComponentReference<CreateGamePopup> componentReference;
		if (obj3 != null)
		{
			componentReference = createGameloaderRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = createGameloaderRef;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = createGameloaderRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = createGameloaderRef;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2016;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1336;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2016;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OnCreateVoiceRoomClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62E3]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<CreateGamePopup> componentReference2;
		object obj4;
		ComponentReference<CreateGamePopup> componentReference;
		if (obj3 != null)
		{
			componentReference = createGameloaderRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = createGameloaderRef;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = createGameloaderRef;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = createGameloaderRef;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2016;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1344;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)16;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2016;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OnButtonFastTrackMenuClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0269: Expected O, but got I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_021d: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_034b: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62E4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig fTServerForCurrentGame = Config.FTServerForCurrentGame;
		bool flag2 = fTServerForCurrentGame == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a3;
		}
		goto IL_022b;
		IL_00a3:
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj8 = typeof(Queue<string>) + 856;
		GoToFastTrack.SetActive(value: false);
		ITrackEvent trackEvent = TrackerLibrary.MenuFastTrackClicked();
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = (nint)0 + (nint)2216;
		Tracker.DesignEvent(trackEvent);
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v36+E4]");
		SfsConnectionManager sfsConnectionManager;
		SfsConnectionManager sfsConnectionManager3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v39+E4]");
			bool flag4 = (nint)0 == 0;
			SfsConnectionManager sfsConnectionManager2 = default(SfsConnectionManager);
			sfsConnectionManager = sfsConnectionManager2;
			sfsConnectionManager3 = sfsConnectionManager2;
			if (!flag4)
			{
				goto IL_0177;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v39+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			SfsConnectionManager sfsConnectionManager4 = default(SfsConnectionManager);
			sfsConnectionManager = sfsConnectionManager4;
			sfsConnectionManager3 = sfsConnectionManager4;
			if (obj14 != null)
			{
				goto IL_0177;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig fTServerForCurrentGame2 = Config.FTServerForCurrentGame;
		sfsConnectionManager = sfsConnectionManager3;
		goto IL_0325;
		IL_0325:
		sfsConnectionManager.SwitchServerAndReloadScene(fTServerForCurrentGame2.<ID>k__BackingField);
		return;
		IL_0177:
		fTServerForCurrentGame2 = Config.FTServerForCurrentGame;
		bool flag6 = fTServerForCurrentGame2 == null;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0325;
		IL_007d:
		SFSConfig fTServerForCurrentGame3 = Config.FTServerForCurrentGame;
		if (fTServerForCurrentGame3 != null)
		{
			goto IL_00a3;
		}
		goto IL_022b;
		IL_022b:
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = "___# Content push apply failed [{0}]: {1}" + 1232;
		KLogger.LogWarning(obj19);
	}

	public void OnButtonPlayClick()
	{
		//IL_01a0: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_0128: Expected I, but got O
		ConnectionSpeed connectionSpeed = SFS.ConnectionSpeed;
		bool flag = connectionSpeed == ConnectionSpeed.Slow;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1392;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+B8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v13+8]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					goto IL_0089;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v15+B8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+8]");
				object obj8 = (nint)0 & (nint)1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					goto IL_0089;
				}
			}
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)1040;
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj11);
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				PoorConnectionPopup.ShowPoorConnectionPopup(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PoorConnectionPopup.ShowPoorConnectionPopup(action);
			return;
		}
		goto IL_0089;
		IL_0089:
		PlayRanked();
	}

	public void OnButtonCancelMatchingClick()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		RankedPlayManager rankedPlayManager = playButton;
		object obj = typeof(RegisteredWaitHandle) + 3136;
		rankedPlayManager.playButton.interactable = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			ScreenManager.AnimateTransitionIn();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AnimateTransitionIn();
	}

	public void OnButtonFriendlyMatchClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3840;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		LoadGame(isWaitingForAd: false, isDisableCancelButton: false, action);
		ITrackEvent trackEvent = TrackerLibrary.MenuFriendlyClicked();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnJoinRoomFailed(Room arg1, string arg2)
	{
		RankedPlayManager rankedPlayManager = playButton;
		rankedPlayManager.playButton.interactable = true;
	}

	private void PlaySound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void OnConfigChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		int newCount = MenuWinSection.ActivePrizesCount();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Prizes, newCount);
		ApplyMiniGameButtonImage();
	}

	private void PlayRanked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_033a: Expected O, but got I
		//IL_034c: Expected I, but got O
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0398: Expected I, but got O
		//IL_00af: Expected I, but got O
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03c7: Expected O, but got I
		//IL_03f5: Expected I, but got O
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0441: Expected I, but got O
		//IL_011a: Expected I, but got O
		//IL_04a9: Expected I, but got O
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04f5: Expected I, but got O
		//IL_01a9: Expected I, but got O
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I
		//IL_020f: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02dc: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 16;
		object obj2 = (nint)0 + (nint)1048;
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 32;
		object obj4 = (nint)0 + (nint)1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v3 (System.IntPtr)+8]");
		RankedPlayManager.PlayRankedGameCallback playRankedGameCallback = default(RankedPlayManager.PlayRankedGameCallback);
		((Delegate)playRankedGameCallback).method_ptr = (IntPtr)0;
		((Delegate)playRankedGameCallback).method = method;
		object obj5 = playRankedGameCallback + 32;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)playRankedGameCallback).method_code = (IntPtr)playRankedGameCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj6 = default(object);
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v3 (System.IntPtr)+52]");
			if ((nint)0 == 1)
			{
				nint invoke_impl = 35879896;
				((Delegate)playRankedGameCallback).invoke_impl = invoke_impl;
				goto IL_03a7;
			}
		}
		((Delegate)playRankedGameCallback).invoke_impl = ((Delegate)playRankedGameCallback).method_ptr;
		((Delegate)playRankedGameCallback).method_code = (IntPtr)((Delegate)playRankedGameCallback).m_target;
		goto IL_03a7;
		IL_047b:
		nint extra_arg = 35879724;
		RankedPlayManager.PlayRankedGameShowAdLoading playRankedGameShowAdLoading = default(RankedPlayManager.PlayRankedGameShowAdLoading);
		((Delegate)playRankedGameShowAdLoading).extra_arg = extra_arg;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7;
		nint method2 = (nint)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X24_v4 (System.IntPtr)+8]");
		RankedPlayManager.PlayRankedGameErrorCallback playRankedGameErrorCallback = default(RankedPlayManager.PlayRankedGameErrorCallback);
		((Delegate)playRankedGameErrorCallback).method_ptr = (IntPtr)0;
		((Delegate)playRankedGameErrorCallback).method = method2;
		object obj8 = playRankedGameErrorCallback + 32;
		obj8 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)playRankedGameErrorCallback).method_code = (IntPtr)playRankedGameErrorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj9 = default(object);
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X24_v4 (System.IntPtr)+52]");
			if ((nint)0 == 1)
			{
				nint invoke_impl2 = 35880008;
				((Delegate)playRankedGameErrorCallback).invoke_impl = invoke_impl2;
				goto IL_0450;
			}
		}
		((Delegate)playRankedGameErrorCallback).invoke_impl = ((Delegate)playRankedGameErrorCallback).method_ptr;
		((Delegate)playRankedGameErrorCallback).method_code = (IntPtr)((Delegate)playRankedGameErrorCallback).m_target;
		goto IL_0450;
		IL_03a7:
		object obj10 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 24;
		obj7 = (nint)0 + (nint)1064;
		nint extra_arg2 = 35879812;
		((Delegate)playRankedGameCallback).extra_arg = extra_arg2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method3 = (nint)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X23_v3 (System.IntPtr)+8]");
		((Delegate)playRankedGameShowAdLoading).method_ptr = (IntPtr)0;
		((Delegate)playRankedGameShowAdLoading).method = method3;
		object obj11 = playRankedGameShowAdLoading + 32;
		obj11 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)playRankedGameShowAdLoading).method_code = (IntPtr)playRankedGameShowAdLoading;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj12 = default(object);
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X23_v3 (System.IntPtr)+52]");
			if ((nint)0 == 0)
			{
				nint invoke_impl3 = 35879792;
				((Delegate)playRankedGameShowAdLoading).invoke_impl = invoke_impl3;
				goto IL_047b;
			}
		}
		((Delegate)playRankedGameShowAdLoading).invoke_impl = ((Delegate)playRankedGameShowAdLoading).method_ptr;
		((Delegate)playRankedGameShowAdLoading).method_code = (IntPtr)((Delegate)playRankedGameShowAdLoading).m_target;
		goto IL_047b;
		IL_0450:
		nint extra_arg3 = 35879924;
		((Delegate)playRankedGameErrorCallback).extra_arg = extra_arg3;
		object obj13 = typeof(Queue<string>) + 848;
		object obj14 = (nint)0 + (nint)2200;
		playButton.PlayRanked(playRankedGameCallback, playRankedGameShowAdLoading, playRankedGameErrorCallback);
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v23+E4]");
		bool flag = (nint)0 == 0;
		object obj16 = !flag;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool isSub = SFSKammelnaUserExtensions.IsSubscribed(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int joinsAllowed = SFSKammelnaUserExtensions.GetJoinsAllowed(localUser2);
		ITrackEvent trackEvent = TrackerLibrary.MenuRankedClicked(isSub, joinsAllowed);
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj19 = !flag2;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void InitializePushNotificationReminder()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00ac: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62E9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2104;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
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
			object obj4 = (nint)0 + (nint)2104;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
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
		NotificationsManager notificationsManager = default(NotificationsManager);
		bool flag3 = (object)notificationsManager == null;
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
		object obj9 = (nint)0 + (nint)2288;
		List<Notification> activeForcedNotifications = notificationsManager.ActiveForcedNotifications;
		bool flag4 = Enumerable.Any((IEnumerable<object>)activeForcedNotifications);
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 == null && !NotificationPermissionUtils.IsGranted())
		{
			object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v2+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PrefabInitializer.InitializePrefab(notificationPopUp, CanvasLayer.SecondaryCanvas);
		}
	}

	private void <ApplyMiniGameButtonImage>b__21_0(bool b)
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		Image image = miniGameButtonImage;
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+408]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+410]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void <OnButtonPlayClick>b__26_0(bool confirmed)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_005d: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_0181: Expected F4, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_010c: Expected F4, but got I
		//IL_013a: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = 146685952;
		if (!confirmed)
		{
			object obj3 = typeof(RegisteredWaitHandle) + 1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4598]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				_ = 1;
			}
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+100]");
			ITrackEvent trackEvent = TrackerLibrary.MenuPoorConnectionBackClicked(0f);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v7+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		else
		{
			object obj9 = typeof(RegisteredWaitHandle) + 1880;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v12+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v13+100]");
			ITrackEvent trackEvent2 = TrackerLibrary.MenuPoorConnectionPlayAnywayClicked(0f);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
			PlayRanked();
		}
	}

	private void <PlayRanked>b__32_0(bool skipAd)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		LoadGame(isWaitingForAd: false, isDisableCancelButton: false, action);
	}

	private void <PlayRanked>b__32_1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		LoadGame(isWaitingForAd: true, isDisableCancelButton: true, action);
	}

	private void <PlayRanked>b__32_2(RankedPlayManager.PlayError error)
	{
		//IL_0016: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62ED]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (error != RankedPlayManager.PlayError.NotEnoughAces)
			{
				goto IL_0050;
			}
		}
		else
		{
			_ = 1;
			bool flag = error == RankedPlayManager.PlayError.NotEnoughAces;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0050;
			}
		}
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(notEnoughAcesToPlayRankedRef, CanvasLayer.SecondaryCanvas);
		RankedPlayManager rankedPlayManager = playButton;
		goto IL_0131;
		IL_0050:
		rankedPlayManager = playButton;
		bool flag3 = (object)playButton == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0131;
		IL_0131:
		rankedPlayManager.playButton.interactable = true;
		object obj7 = typeof(RegisteredWaitHandle) + 3136;
		HintsPopup.Close();
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			ScreenManager.AnimateTransitionIn();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AnimateTransitionIn();
	}
}
