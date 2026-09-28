using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MiniGameVisuals : MonoBehaviour
{
	private static class Messages
	{
		public const string NoRewards = "No projects, you can retry by replace {0} cards";

		public const string GotRewards = "You have a project! you can still retry by replace {0} cards";

		public const string ClaimPrize = "Claim your prize";

		public const string WinTitle = "Congratulations!";

		public const string GameOverLose = "Sorry, come back later";

		public const string GameOverLoseCanTryAgain = "Sorry, you still have a trial";

		public const string GameOverWin = "Congratuations, don't forget to come back";

		public const string GameOverWinCanTryAgain = "Congratuations, you still have a trial";

		public const string GotAces = "You got {0} golden cards";

		public const string NoSubReplaceCard = "To Replace cards, watch Ad";

		public const string ExitWarningTitle = "Warning";

		public const string ExitWarningBody = "When you choose exit you wont be able to play until 12 hours";

		public const string FailedToLoadTitle = "Error";

		public const string FailedToLoadBodyNoGooglePlay = "Couldn't load any Ads, this session has been terminated. Devices with no google play services may fail to load ads";
	}

	private MiniGamePlayground playground;

	private MiniGameStatusMessage statusUi;

	private MiniGameResultMessage resultUi;

	private MiniGameHand hand;

	private MiniGameControls controls;

	private MiniGameSoundAlbum soundAlbum;

	private MiniGameEventsChannel miniGameEventsChannel;

	private AdsController adsController;

	[NonSerialized]
	public OneShotEvent Playground;

	[NonSerialized]
	public OneShotEvent WatchedAd;

	private MiniGame miniGame;

	public bool ShouldWatchAd
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460374");
			bool result = default(bool);
			return result;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0067: Expected O, but got I
		//IL_0091: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)184;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 112;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RegisterEventListeners();
	}

	private void OnDestroy()
	{
		UnRegisterEventListeners();
	}

	private void OnInitialized()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_0069: Expected O, but got I
		WatchedAd.IsReady = false;
		statusUi.Hide();
		object obj = resultUi;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(resultUi, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X19_v3 (System.Object)+20]");
		((PopupUI)0).SlideToBottom(action);
	}

	private void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_03e3: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00bf: Expected O, but got I
		//IL_00eb: Expected I, but got O
		//IL_00fc: Expected O, but got I
		//IL_0128: Expected I, but got O
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_0179: Expected I, but got O
		//IL_03f4: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0229: Expected I, but got O
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_02eb: Expected I, but got O
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_033c: Expected I, but got O
		//IL_036b: Expected O, but got I
		//IL_0379: Expected I, but got O
		//IL_03a8: Expected O, but got I
		//IL_03b6: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
		object obj4 = (nint)0 + (nint)2896;
		miniGame.OnInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)2920;
		miniGame.OnGameStart += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)2912;
		miniGame.OnMoveSent += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)2880;
		miniGame.OnMove += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj7);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 840;
		object obj9 = (nint)0 + (nint)2872;
		miniGame.OnClaim += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)2840;
		object obj11 = (nint)0 + (nint)2888;
		object obj12 = hand + 48;
		Delegate obj13 = (Delegate)obj12;
		object obj16 = default(object);
		bool flag2;
		Delegate obj19 = default(Delegate);
		do
		{
			Delegate obj14 = Delegate.Combine(obj13, action6);
			Delegate obj18;
			if ((object)obj14 == null)
			{
				object obj15 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj16 == null;
				object obj17 = !flag;
				object obj15 = obj16;
				if (obj17 == null)
				{
					obj15 = obj8;
					obj18 = null;
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag2 = (object)obj19 == obj13;
			obj13 = obj19;
			obj18 = obj19;
		}
		while (!flag2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj10);
		object obj20 = hand + 56;
		Delegate obj21 = (Delegate)obj20;
		bool flag3;
		Delegate obj25 = default(Delegate);
		do
		{
			Delegate obj22 = Delegate.Combine(obj21, action7);
			Delegate obj23;
			Delegate obj24;
			if ((object)obj22 != null)
			{
				obj23 = (Delegate)obj;
				if (obj22 != obj)
				{
					obj24 = null;
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag3 = (object)obj25 == obj21;
			obj21 = obj25;
			obj23 = obj22;
			obj24 = obj25;
		}
		while (!flag3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)obj11);
		adsController.OnAdComplete += action8;
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2856;
		Action<object> action9 = default(Action<object>);
		action9..ctor((object)this, (IntPtr)obj27);
		adsController.OnAdFailedToLoad3Times += action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)2864;
		Action action10 = default(Action);
		action10..ctor(this, (IntPtr)obj28);
		adsController.OnAdLoaded += action10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)2848;
		Action action11 = default(Action);
		action11..ctor(this, (IntPtr)obj29);
		adsController.OnAdClosed += action11;
	}

	private void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0118: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00bf: Expected O, but got I
		//IL_00eb: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)2856;
		adsController.OnAdComplete -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)2864;
		adsController.OnAdFailedToLoad3Times -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)2848;
		adsController.OnAdLoaded -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj6);
		adsController.OnAdClosed -= action4;
	}

	private void OnGameStart(MiniGameState state)
	{
	}

	private void OnMoveSent()
	{
		WatchedAd.IsReady = false;
		statusUi.Hide();
	}

	private void OnMove(MiniGameState state)
	{
	}

	private void OnClaim(MiniGameState state)
	{
		//IL_0054: Expected O, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_014e: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (Enumerable.Any((IEnumerable<object>)<State>k__BackingField.<Rewards>k__BackingField))
		{
			object obj = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			object obj2 = typeof(MemberAchievementClanFeedData) + 784;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
			object message = "Complete" + 336;
			object obj5 = "Complete" + 328;
			bool flag2 = miniGameRemainingTrials < 0;
			bool flag3 = miniGameRemainingTrials == 0;
			int num = miniGameRemainingTrials ^ miniGameRemainingTrials;
			int num2 = miniGameRemainingTrials & num;
			bool flag4 = num2 < 0;
			bool flag5 = flag2 == flag4;
			object obj6 = !flag3;
			object obj7 = flag5 & obj6;
			object obj8 = ~obj7;
			if (obj8 != null)
			{
				message = obj5;
			}
			MiniGame miniGame2 = this.miniGame;
			int totalReward = miniGame2.<State>k__BackingField.TotalReward;
			object prizeText = "WhiteSmoke" + 1896;
			resultUi.ShowWinPopup((string)message, (string)prizeText, totalReward);
		}
	}

	private void OnCardSelected(List<MiniGameCard> cards)
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64C2]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64C8]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64C8]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		MiniGameSoundAlbum miniGameSoundAlbum = soundAlbum;
		goto IL_00f8;
		IL_00f8:
		object obj5 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		controls.OnCardSelected(cards);
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (cards._size == <State>k__BackingField.<CardsPerMove>k__BackingField && ShouldWatchAd)
		{
			MiniGameStatusMessage miniGameStatusMessage = statusUi;
			object text = "ThisIsFakeReceiptData" + 400;
			statusUi.SetTitle((string)null);
			TextMeshProExtensions.Localize(miniGameStatusMessage.messageText, (string)text);
			statusUi.Show();
		}
		else
		{
			statusUi.Hide();
		}
		return;
		IL_0066:
		miniGameSoundAlbum = soundAlbum;
		bool flag2 = (object)soundAlbum == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f8;
	}

	private void FinishDrawingCards()
	{
		//IL_003d: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_027f: Expected O, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		controls.FinishDrawingCards();
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		object obj = (nint)0 + (nint)2272;
		bool flag = Enumerable.Any((IEnumerable<object>)<State>k__BackingField.<Rewards>k__BackingField);
		MiniGame miniGame2 = this.miniGame;
		if (flag)
		{
			MiniGameState <State>k__BackingField2 = miniGame2.<State>k__BackingField;
			MiniGameStatusMessage miniGameStatusMessage = statusUi;
			if (<State>k__BackingField2.<RemainingMoves>k__BackingField >= 1)
			{
				object message = "WhiteSmoke" + 1904;
				object title = "Complete" + 352;
				statusUi.ShowMessage((string)message, <State>k__BackingField2.<CardsPerMove>k__BackingField, (string)title);
			}
			else
			{
				object text = "Cannot populate JSON object onto type '{0}'." + 2832;
				object title2 = "Complete" + 352;
				statusUi.SetTitle((string)title2);
				TextMeshProExtensions.Localize(miniGameStatusMessage.messageText, (string)text);
				statusUi.Show();
			}
			return;
		}
		MiniGameState <State>k__BackingField3 = miniGame2.<State>k__BackingField;
		if (<State>k__BackingField3.<RemainingMoves>k__BackingField >= 1)
		{
			object message2 = "Network Authentication Required" + 1040;
			statusUi.ShowMessage((string)message2, <State>k__BackingField3.<CardsPerMove>k__BackingField);
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 784;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int miniGameRemainingTrials = MiniGameInfo.MiniGameRemainingTrials;
		object message3 = "SetRoomVariables request error" + 1600;
		object obj5 = "SetRoomVariables request error" + 1592;
		bool flag3 = miniGameRemainingTrials < 0;
		bool flag4 = miniGameRemainingTrials == 0;
		int num = miniGameRemainingTrials ^ miniGameRemainingTrials;
		int num2 = miniGameRemainingTrials & num;
		bool flag5 = num2 < 0;
		bool flag6 = flag3 == flag5;
		object obj6 = !flag4;
		object obj7 = flag6 & obj6;
		object obj8 = ~obj7;
		if (obj8 != null)
		{
			message3 = obj5;
		}
		resultUi.ShowLosePopup((string)message3);
	}

	public void RequestAd(Action callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6429]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object msgBody;
		if (obj3 != null)
		{
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			msgBody = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			msgBody = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowLoading((string)msgBody, dismissible: false);
		AdsController adsController = this.adsController;
		goto IL_015c;
		IL_015c:
		adsController.ShowRewardedAd(AdPlace.MiniGame);
		statusUi.Hide();
		WatchedAd.CallWhenReady(callback);
		return;
		IL_0094:
		PopupWindow.ShowLoading((string)obj4, dismissible: false);
		adsController = this.adsController;
		bool flag3 = (object)this.adsController == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015c;
	}

	public Vector3 GetDrawPosition()
	{
		MiniGamePlayground miniGamePlayground = playground;
		if ((object)playground != null)
		{
			object obj = Enumerable.Last((IEnumerable<object>)miniGamePlayground.deckCards);
			if (obj != null)
			{
				RectTransform rectTransform = ((Graphic)obj).rectTransform;
				if ((object)rectTransform != null)
				{
					return rectTransform.position;
				}
			}
		}
		return (Vector3)new NullReferenceException();
	}

	public void DiscardCards(List<MiniGameCard> selectedCards)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		playground.DiscardCards(selectedCards);
	}

	public Tween AnimateReward(GameObject rewardUi, int rewardValue)
	{
		if ((object)controls != null)
		{
			return controls.AnimateReward(rewardUi, rewardValue);
		}
		return (Tween)(object)new NullReferenceException();
	}

	public void ReturnRewardCards()
	{
		hand.ReturnRewardCards();
		statusUi.Hide();
	}

	public void SendMove()
	{
		hand.SendMove();
	}

	public void Exit()
	{
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03be: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_0091: Expected I, but got O
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0160: Expected I, but got O
		//IL_0170: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0252: Expected I, but got O
		//IL_0262: Expected O, but got I
		//IL_0300: Expected O, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0350: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_029d: Expected O, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0434: Expected O, but got I4
		//IL_043c: Expected O, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		Action action = default(Action);
		object obj8 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj17 = default(object);
		MiniGame miniGame2 = default(MiniGame);
		while (true)
		{
			MiniGame miniGame = this.miniGame;
			object obj3;
			if ((object)this.miniGame != null)
			{
				miniGame = (MiniGame)(object)miniGame.<State>k__BackingField;
				if (miniGame.<State>k__BackingField != null)
				{
					if ((nint)miniGame.OnMoveSent != 1)
					{
						break;
					}
					object obj = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj2 = (nint)0 + (nint)2824;
					action..ctor(this, (IntPtr)obj2);
					object confirmText = "Error reading data from socket: " + 1016;
					miniGame = (MiniGame)(object)("COORDINATE_TYPE_GCJ_02" + 1864);
					PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, (string)confirmText, (string)(object)miniGame);
					bool flag = popupWindowBuilder == null;
					obj3 = 0;
					if (!flag)
					{
						miniGame = (MiniGame)(object)("Unsupported map type" + 3592);
						IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)(object)miniGame);
						bool flag2 = popupWindowBuilderNeedsBody == null;
						obj3 = 0;
						if (!flag2)
						{
							object obj4 = typeof(System.IOAsyncCallback) + 384;
							object obj5 = "Unsupported map type" + 4040;
							nint num = (nint)popupWindowBuilderNeedsBody;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_01f4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
							object obj7 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X10_v12-8]");
								if (0 == (nint)obj4)
								{
									break;
								}
								obj8 = obj7 + 16;
								obj6--;
								bool flag3 = (nint)obj6 != 1;
								obj7 = obj8;
								if (flag3)
								{
									continue;
								}
								goto IL_01f4;
							}
							object obj9 = num + obj7;
							miniGame = (MiniGame)(obj9 + 312);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X8_v4 (MiniGame)] (should have been resolved before IL gen)");
							bool flag4 = ex == null;
							object obj10 = !flag4;
							obj8 = obj7;
							obj3 = 0;
							if (obj10 != null)
							{
								goto IL_0236;
							}
						}
					}
				}
			}
			goto IL_036f;
			IL_036f:
			ex = new NullReferenceException();
			goto IL_037d;
			IL_037d:
			object obj11 = obj8 + 9;
			object obj12 = (object)miniGame + obj11;
			object obj13 = obj12 + 312;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v6+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v183 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_02de:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v12+8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v213 @ X2_v9 (should have been resolved before IL gen)");
			break;
			IL_01f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v287 @ X0_v14 (MiniGame)] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			obj3 = 0;
			miniGame = miniGame2;
			if (!flag5)
			{
				goto IL_0236;
			}
			goto IL_036f;
			IL_0236:
			object obj19 = typeof(System.IOAsyncCallback) + 368;
			nint num2 = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v28 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v28 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v28 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X10_v9-8]");
					bool flag6 = 0 == (nint)obj19;
					obj3 = 0;
					miniGame = (MiniGame)num2;
					if (flag6)
					{
						break;
					}
					obj8 += 16;
					obj20--;
					if ((nint)obj20 != 1)
					{
						continue;
					}
					goto IL_02de;
				}
				goto IL_037d;
			}
			goto IL_02de;
		}
		<Exit>g__ExitAction|31_0();
	}

	private void OnComplete()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		WatchedAd.IsReady = true;
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = "SERVICE_DISABLED" + 2384;
		object obj3 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 376;
		object obj4 = (nint)0 + (nint)2000;
		if (<State>k__BackingField.<RemainingMoves>k__BackingField != 2)
		{
			obj3 = obj4;
		}
		object rewardVideoOrder = ((<State>k__BackingField.<RemainingMoves>k__BackingField != 1) ? obj3 : obj2);
		ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsRewardVideoCompleted((string)rewardVideoOrder);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnAdFailedToLoad3(string errorMsg)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0162: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00d7: Expected I, but got O
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (!<State>k__BackingField.<GameOngoing>k__BackingField)
		{
			return;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!KUtil.NoPlayServices)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool noPlayServices = KUtil.NoPlayServices;
			bool flag = !noPlayServices;
			object obj3 = !flag;
			if (obj3 == null)
			{
				return;
			}
		}
		object obj4 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)2832;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void OnAdLoaded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E642A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
	}

	private void OnAdClosed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E642A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
	}

	private string RewardedVideoOrder()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		MiniGame miniGame = this.miniGame;
		if ((object)this.miniGame != null)
		{
			MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
			if (miniGame.<State>k__BackingField != null)
			{
				object result = "SERVICE_DISABLED" + 2384;
				object result2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 376;
				object obj = (nint)0 + (nint)2000;
				if (<State>k__BackingField.<RemainingMoves>k__BackingField != 2)
				{
					result2 = obj;
				}
				if (<State>k__BackingField.<RemainingMoves>k__BackingField == 1)
				{
					return (string)result;
				}
				return (string)result2;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private void ShowLoading()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6429]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object msgBody;
		if (obj3 != null)
		{
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			msgBody = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			msgBody = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowLoading((string)msgBody, dismissible: false);
		return;
		IL_0094:
		PopupWindow.ShowLoading((string)obj4, dismissible: false);
	}

	private void HideLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E642A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
	}

	private void PlayClaimSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayStartSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayCardShuffle()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void PlayCardSelectedSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayCardsDrawingSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayDrawingThreeCardsSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayCardsDiscardSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayNoRewardsSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayRewardSound(int miniGameReward)
	{
		//IL_0076: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_0051: Expected O, but got I
		if (miniGameReward < 400)
		{
			if (miniGameReward < 50)
			{
				if (miniGameReward < 15)
				{
					object obj = (nint)0 + (nint)2440;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
					SingleSound singleSound = default(SingleSound);
					SoundChannel.PlaySFXSound(singleSound);
				}
				else
				{
					object obj2 = (nint)0 + (nint)2440;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
					SingleSound singleSound2 = default(SingleSound);
					SoundChannel.PlaySFXSound(singleSound2);
				}
			}
			else
			{
				object obj3 = (nint)0 + (nint)2440;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
				SingleSound singleSound3 = default(SingleSound);
				SoundChannel.PlaySFXSound(singleSound3);
			}
		}
		else
		{
			object obj4 = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound4 = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound4);
		}
	}

	public void ShowHelp()
	{
		miniGameEventsChannel.TriggerShowHelp();
	}

	public MiniGameVisuals()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj2 = this + 96;
		obj2 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent2 = default(OneShotEvent);
		oneShotEvent2..ctor();
		object obj3 = this + 104;
		obj3 = oneShotEvent2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Exit>g__ExitAction|31_0()
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_006c: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_020f: Expected O, but got I4
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (<State>k__BackingField.<GameOngoing>k__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64C4]");
			object obj = (nint)0 & (nint)1;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				_ = 1;
				miniGame = this.miniGame;
			}
			MiniGameState <State>k__BackingField2 = miniGame.<State>k__BackingField;
			object obj3 = "SERVICE_DISABLED" + 2384;
			object obj4 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 376;
			object obj5 = (nint)0 + (nint)2000;
			if (<State>k__BackingField2.<RemainingMoves>k__BackingField != 2)
			{
				obj4 = obj5;
			}
			object rewardVideoOrder = ((<State>k__BackingField2.<RemainingMoves>k__BackingField != 1) ? obj4 : obj3);
			ITrackEvent trackEvent = TrackerLibrary.MiniGameProjectsExitBeforeCompleted((string)rewardVideoOrder);
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			miniGame = this.miniGame;
		}
		object obj9 = typeof(RegisteredWaitHandle) + 3136;
		miniGame.SendCleanup();
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			ScreenManager.LoadPreviousScene();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.LoadPreviousScene();
	}

	private void <OnAdFailedToLoad3>b__33_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0250: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_02e6: Expected O, but got I
		//IL_030a: Expected O, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_036f: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_0473: Expected O, but got I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
		object obj = typeof(System.IOAsyncCallback) + 392;
		object obj2 = "Drop Menu Toggle" + 3600;
		nint num = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v24-8]");
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
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X8_v27] (should have been resolved before IL gen)");
		goto IL_0127;
		IL_03eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v473 @ X0_v13] (should have been resolved before IL gen)");
		MiniGameControls miniGameControls = controls;
		goto IL_040f;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = default(object);
		object obj7 = obj8;
		goto IL_04e3;
		IL_04e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ X8_v11] (should have been resolved before IL gen)");
		object label;
		PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
		object obj9 = typeof(System.IOAsyncCallback) + 368;
		object obj11 = default(object);
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v12+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v12+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v14-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_02cc;
		}
		object obj14 = obj10 + obj13;
		object obj15 = obj14 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v23+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X0_v23] (should have been resolved before IL gen)");
		goto IL_0357;
		IL_0481:
		throw new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X0_v28] (should have been resolved before IL gen)");
		object obj17 = default(object);
		bool flag = obj17 == null;
		object obj18 = !flag;
		if (obj18 != null)
		{
			goto IL_0127;
		}
		goto IL_0481;
		IL_0127:
		object obj19 = typeof(System.IOAsyncCallback) + 384;
		object obj20 = "Complete" + 2736;
		label = "Network Authentication Required" + 3128;
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v10+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v10+B0]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v19-8]");
			if (0 == (nint)obj19)
			{
				break;
			}
			obj23 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_01ed;
		}
		object obj24 = obj21 + obj23;
		obj7 = obj24 + 312;
		goto IL_04e3;
		IL_040f:
		miniGameControls.FinishGameNow();
		return;
		IL_02cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v20+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v421 @ X0_v20] (should have been resolved before IL gen)");
		object obj25 = default(object);
		bool flag2 = obj25 == null;
		object obj26 = !flag2;
		if (obj26 != null)
		{
			goto IL_0357;
		}
		goto IL_0481;
		IL_0357:
		object obj27 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v14+12E]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03eb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v14+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v9-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj29 += 16;
			obj28--;
			if ((nint)obj28 != 1)
			{
				continue;
			}
			goto IL_03eb;
		}
		object obj30 = obj29 + 9;
		object obj31 = obj27 + obj30;
		object obj32 = obj31 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ X8_v18] (should have been resolved before IL gen)");
		miniGameControls = controls;
		bool flag3 = (object)controls == null;
		object obj33 = !flag3;
		if (obj33 != null)
		{
			goto IL_040f;
		}
		goto IL_0481;
	}
}
