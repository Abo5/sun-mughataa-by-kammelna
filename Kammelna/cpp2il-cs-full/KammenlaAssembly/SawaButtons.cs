using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SawaButtons : MonoBehaviour
{
	private const string SawaAllowedDescription = "Sawa description. Click OK to continue.";

	private const string CardsCountError = "Sawa is not allowed. You must have no more than 4 cards.";

	private const string NoSubscribersError = "Sawa is not allowed. There is no subscriber in game.";

	private bool horizontal;

	private HorizontalOrVerticalLayoutGroup mainLayout;

	private SlideAnimationHelper slider;

	private Button submitButton;

	private Toggle dontShowAgainToggle;

	private Button cancelButton;

	private TextMeshProUGUI descriptionText;

	private GameEventsChannel gameEventsChannel;

	private StoreItem fireSawa;

	private CardGame game;

	private bool canAffordSpecialSawa
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			//IL_013a: Expected I4, but got O
			//IL_00ce: Expected O, but got I4
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected I4, but got Unknown
			if (fireSawa != null)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = (nint)0 + (nint)2200;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					int aces = SFSKammelnaUserExtensions.GetAces(localUser);
					int num = StorePricing.EffectivePrice(fireSawa);
					object obj5 = aces - num;
					bool flag2 = (nint)obj5 < 0;
					int num2 = aces ^ num;
					int num3 = aces ^ obj5;
					int num4 = num2 & num3;
					bool flag3 = num4 < 0;
					return flag2 == flag3;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_016b: Expected I, but got O
		//IL_017c: Expected O, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0259: Expected I, but got O
		//IL_026a: Expected O, but got I
		//IL_0294: Expected I, but got O
		//IL_02a5: Expected O, but got I
		//IL_02d1: Expected I, but got O
		//IL_0302: Expected I, but got O
		//IL_0313: Expected O, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0353: Expected I, but got O
		//IL_037d: Expected O, but got I4
		Button button = submitButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = cancelButton;
		object obj3 = (nint)0 + (nint)816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		button2.m_OnClick.AddListener(unityAction2);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool confirmSawa = Preferences.ConfirmSawa;
		bool isOn = (byte)((confirmSawa ? 1u : 0u) ^ 1u) != 0;
		dontShowAgainToggle.isOn = isOn;
		Toggle toggle = dontShowAgainToggle;
		object obj7 = typeof(TypeConverter<ushort, char>) + 360;
		object obj8 = (nint)0 + (nint)824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction3 = default(UnityAction<bool>);
		unityAction3..ctor((object)this, (IntPtr)obj8);
		object obj9 = (nint)0 + (nint)832;
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj11 = (nint)0 + (nint)24;
		object obj12 = typeof(SqlSingle[]) + 2376;
		object obj13 = (nint)0 + (nint)840;
		toggle.onValueChanged.AddListener(unityAction3);
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj16 = this + 104;
		object obj17 = default(object);
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj13);
		object obj18 = (nint)0 + (nint)832;
		((KGame)obj16).OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)856;
		game.OnRoundStart += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj19);
		gameEventsChannel.ToggleSawaPanel += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj18);
		object obj20 = (nint)0 + (nint)808;
		object obj21 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		gameEventsChannel.CloseSawaPanel += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj20);
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v38+E4]");
		bool flag3 = (nint)0 == 0;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action5);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)832;
		gameEventsChannel.ToggleSawaPanel -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		gameEventsChannel.CloseSawaPanel -= action2;
	}

	private void OnGameStateUpdated()
	{
		//IL_0040: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		Room room = game.Room;
		bool flag = SFSKammelnaRoomExtensions.IsOffline(room);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		bool isSpectator = game.IsSpectator;
		bool flag3 = !isSpectator;
		object obj2 = !flag3;
		if (obj2 == null)
		{
			CardGamePlayer myPlayer = game.MyPlayer;
			if (myPlayer.IsHumanSeated)
			{
				CardGamePlayer myPlayer2 = game.MyPlayer;
				if (myPlayer2.CanPlayCard)
				{
					List<Card> cardsOnFloor = game.CardsOnFloor;
					bool flag4 = Enumerable.Any((IEnumerable<object>)cardsOnFloor);
					bool flag5 = !flag4;
					object obj3 = !flag5;
					if (obj3 == null)
					{
						UpdateMessage();
					}
				}
			}
		}
		CardGameLastActionInfo lastAction = game.LastAction;
		CardGame cardGame = game;
		if (((LastActionInfo)lastAction).<ActionPlayer>k__BackingField == ((KGame)cardGame).<MySeatIndex>k__BackingField)
		{
			SlideAnimationHelper slideAnimationHelper = slider;
			if (slideAnimationHelper.<IsShown>k__BackingField)
			{
				float preferredHeight = mainLayout.preferredHeight;
				float slideDownDistance = default(float);
				slideAnimationHelper.slideDownDistance = slideDownDistance;
				slider.SlideOut();
			}
		}
	}

	private void DontShowAgainToggleChanged(bool active)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		ITrackEvent trackEvent = TrackerLibrary.GameDontShowSawaToggled(active);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			if (!flag)
			{
				goto IL_0058;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0058;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool confirmSawa = (byte)((active ? 1u : 0u) ^ 1u) != 0;
		Preferences.ConfirmSawa = confirmSawa;
		return;
		IL_0058:
		bool confirmSawa2 = (byte)((active ? 1u : 0u) ^ 1u) != 0;
		Preferences.ConfirmSawa = confirmSawa2;
	}

	private void Submit()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66A6]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.GameSendSawaButtonClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.GameSendSawaButtonClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		SendSawa();
		HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = mainLayout;
		goto IL_0153;
		IL_0153:
		SlideAnimationHelper slideAnimationHelper = slider;
		float preferredHeight = horizontalOrVerticalLayoutGroup.preferredHeight;
		float slideDownDistance = default(float);
		slideAnimationHelper.slideDownDistance = slideDownDistance;
		slider.SlideOut();
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		SendSawa();
		horizontalOrVerticalLayoutGroup = mainLayout;
		bool flag3 = (object)mainLayout == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0153;
	}

	public void Cancel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66A7]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.GameSawaCancelClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.GameSawaCancelClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = mainLayout;
		goto IL_0142;
		IL_0142:
		SlideAnimationHelper slideAnimationHelper = slider;
		float preferredHeight = horizontalOrVerticalLayoutGroup.preferredHeight;
		float slideDownDistance = default(float);
		slideAnimationHelper.slideDownDistance = slideDownDistance;
		slider.SlideOut();
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		horizontalOrVerticalLayoutGroup = mainLayout;
		bool flag3 = (object)mainLayout == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0142;
	}

	public void ToggleSawaPanel()
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_023b: Expected O, but got I4
		SlideAnimationHelper slideAnimationHelper = slider;
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			float preferredHeight = mainLayout.preferredHeight;
			float slideDownDistance = default(float);
			slideAnimationHelper.slideDownDistance = slideDownDistance;
			slider.SlideOut();
			return;
		}
		CardGame cardGame = game;
		if (!cardGame.<SawaAllowed>k__BackingField)
		{
			goto IL_0101;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			if (Preferences.ConfirmSawa)
			{
				goto IL_00f2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool confirmSawa = Preferences.ConfirmSawa;
			bool flag = !confirmSawa;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_00f2;
			}
		}
		SendSawa();
		ITrackEvent trackEvent = TrackerLibrary.GameSendFastSawaClicked();
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		ITrackEvent trackEvent2 = trackEvent;
		if (obj6 != null)
		{
			goto IL_019f;
		}
		goto IL_0251;
		IL_00f2:
		cardGame = game;
		goto IL_0101;
		IL_0101:
		submitButton.interactable = cardGame.<SawaAllowed>k__BackingField;
		CardGame cardGame2 = game;
		dontShowAgainToggle.interactable = cardGame2.<SawaAllowed>k__BackingField;
		slider.SlideIn();
		trackEvent = TrackerLibrary.GameSawaButtonClicked();
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		trackEvent2 = trackEvent;
		if (!flag3)
		{
			goto IL_019f;
		}
		goto IL_0251;
		IL_0251:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_019f:
		Tracker.DesignEvent(trackEvent);
	}

	private void SendSawa()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_012f: Expected F8, but got I4
		//IL_0257: Expected O, but got I4
		GameEventsChannel gameEventsChannel = this.gameEventsChannel;
		if (gameEventsChannel.isFireModeActive)
		{
			if (!canAffordSpecialSawa)
			{
				ITrackEvent trackEvent = TrackerLibrary.GameSawaSlapClicked(canBuy: false);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				object message = "not" + 88;
				this.gameEventsChannel.TriggerDisplayMessage((string)message);
				goto IL_01c2;
			}
			gameEventsChannel = this.gameEventsChannel;
		}
		if (gameEventsChannel.isFireModeActive && canAffordSpecialSawa)
		{
			ITrackEvent trackEvent2 = TrackerLibrary.GameSawaSlapClicked(canBuy: true);
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
			string itemId = Tracker.ItemId(ResourceItemId.SawaSlap);
			int num = StorePricing.EffectivePrice(fireSawa);
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Gameplay, itemId, num, ResourceCurrency.Aces);
		}
		goto IL_01c2;
		IL_01c2:
		GameEventsChannel gameEventsChannel2 = this.gameEventsChannel;
		int? gameActionItemId;
		if (gameEventsChannel2.isFireModeActive && canAffordSpecialSawa)
		{
			StoreItem storeItem = fireSawa;
			int? num2 = storeItem.<id>k__BackingField;
			bool flag3 = (object)game == null;
			object obj7 = !flag3;
			gameActionItemId = num2;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			gameActionItemId = (int?)(object)0;
		}
		game.SendSawa(gameActionItemId);
		this.gameEventsChannel.TriggerDeactivateFireMode();
	}

	private void ShowPanel()
	{
		slider.SlideIn();
	}

	private void HidePanel()
	{
		SlideAnimationHelper slideAnimationHelper = slider;
		float preferredHeight = mainLayout.preferredHeight;
		float slideDownDistance = default(float);
		slideAnimationHelper.slideDownDistance = slideDownDistance;
		slider.SlideOut();
	}

	private void UpdateMessage()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		CardGame cardGame = game;
		if (cardGame.<SawaAllowed>k__BackingField)
		{
			object text = "SERVICE_DISABLED" + 1680;
			TextMeshProExtensions.Localize(descriptionText, (string)text);
			return;
		}
		CardGamePlayer myPlayer = cardGame.MyPlayer;
		List<Card> <Cards>k__BackingField = myPlayer.<Cards>k__BackingField;
		object obj = "SERVICE_DISABLED" + 1696;
		object obj2 = "SERVICE_DISABLED" + 1688;
		object obj3 = <Cards>k__BackingField._size - 4;
		bool flag = (nint)obj3 < 0;
		bool flag2 = obj3 == null;
		int num = <Cards>k__BackingField._size ^ 4;
		int num2 = <Cards>k__BackingField._size ^ obj3;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		object text2 = ((obj6 != null) ? obj2 : obj);
		TextMeshProExtensions.Localize(descriptionText, (string)text2);
	}

	private void SetMessage(string message)
	{
		TextMeshProExtensions.Localize(descriptionText, message);
	}

	public void SetAllowed()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "SERVICE_DISABLED" + 1680;
		TextMeshProExtensions.Localize(descriptionText, (string)text);
	}

	public void SetCardsCountError()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "SERVICE_DISABLED" + 1696;
		TextMeshProExtensions.Localize(descriptionText, (string)text);
	}

	public void SetNoSubscribersError()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "SERVICE_DISABLED" + 1688;
		TextMeshProExtensions.Localize(descriptionText, (string)text);
	}

	private void <Start>b__15_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem(GameAction.Farsh);
		object obj4 = this + 96;
		obj4 = storeItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
