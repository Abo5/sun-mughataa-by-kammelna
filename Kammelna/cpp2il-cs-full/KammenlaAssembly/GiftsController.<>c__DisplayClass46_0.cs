using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GiftsController : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Toggle> <>9__42_0;

		public static Action<Toggle> <>9__43_0;

		public static Action<Toggle> <>9__43_1;

		public static Func<KPlayer, bool> <>9__46_0;

		public static Func<KPlayer, int> <>9__46_1;

		public static Func<KPlayer, long> <>9__46_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Hide>b__42_0(Toggle t)
		{
			t.isOn = false;
		}

		internal void <SendForAll>b__43_0(Toggle t)
		{
			t.isOn = false;
		}

		internal void <SendForAll>b__43_1(Toggle t)
		{
			if (((Selectable)t).m_Interactable)
			{
				t.isOn = true;
			}
		}

		internal bool <Send>b__46_0(KPlayer player)
		{
			//IL_003d: Expected I4, but got O
			if (player != null)
			{
				return player.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Send>b__46_1(KPlayer player)
		{
			//IL_0123: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0050: Expected I, but got O
			//IL_0060: Expected O, but got I
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_009b: Expected O, but got I
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (player != null)
			{
				User <User>k__BackingField = player.<User>k__BackingField;
				if (player.<User>k__BackingField != null)
				{
					object obj = typeof(UsageHint) + 8;
					num = (nint)<User>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00dc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v4-8]");
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
					goto IL_00f0;
				}
			}
			goto IL_0115;
			IL_00f0:
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v150 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_0115;
			IL_0115:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v89 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00f0;
		}

		internal long <Send>b__46_2(KPlayer player)
		{
			//IL_004f: Expected I8, but got O
			if (player != null)
			{
				string dBId = player.DBId;
				return long.Parse(dBId);
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public GiftsController <>4__this;

		public ItemCategory itemCategory;

		public GiftUIElement gift;

		public int giftId;

		public long[] dbIds;

		internal void <Send>b__3(KammelnaResponseModel<BuyItemResponseModel> response)
		{
			//IL_0110: Expected O, but got I4
			//IL_0316: Expected O, but got I
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0196: Expected O, but got I4
			//IL_0090: Expected O, but got I
			//IL_00d3: Expected O, but got I4
			//IL_0343: Expected O, but got I
			//IL_01c8: Expected O, but got I
			//IL_01e3: Expected O, but got I
			//IL_0358: Expected O, but got I
			//IL_0221: Expected O, but got I
			//IL_0241: Expected F8, but got I4
			//IL_036d: Expected O, but got I
			//IL_026a: Expected O, but got I
			//IL_028e: Expected O, but got I
			//IL_02b9: Expected O, but got I
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_02e5: Expected I8, but got I4
			//IL_02e5: Expected O, but got I
			GiftsController giftsController = <>4__this;
			giftsController.isSending = false;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				GiftsController giftsController2 = <>4__this;
				if (itemCategory == ItemCategory.AnimatedGifts)
				{
					GiftUIElement giftUIElement = gift;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v5 (GiftUIElement)+40]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v34+28]");
					object obj2 = 0;
					BuyItemResponseModel <Model>k__BackingField = response.<Model>k__BackingField;
					KGame game = giftsController2.game;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v35+10]");
					game.NotifyAnimatedGiftSent(0, <Model>k__BackingField.<recipients>k__BackingField);
					object obj3 = 0;
				}
				else
				{
					BuyItemResponseModel <Model>k__BackingField2 = response.<Model>k__BackingField;
					giftsController2.game.NotifyGiftSent(giftId, <Model>k__BackingField2.<recipients>k__BackingField);
					object obj3 = 0;
				}
				GiftsController giftsController3 = <>4__this;
				bool isSpectator = giftsController3.game.IsSpectator;
				long[] array = dbIds;
				ITrackEvent trackEvent = TrackerLibrary.GameUserSentGift(isSpectator, array.Length);
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				GiftUIElement giftUIElement2 = gift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v6 (GiftUIElement)+40]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v17+28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v18+18]");
				string itemId = Tracker.BuildItemId(ResourceItemId.Gift, (string)0);
				GiftUIElement giftUIElement3 = gift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X21_v6 (GiftUIElement)+40]");
				object obj9 = 0;
				long[] array2 = dbIds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v21+28]");
				int num = StorePricing.TotalPrice((StoreItem)0, array2.Length);
				Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Social, itemId, num, ResourceCurrency.Aces);
				GiftUIElement giftUIElement4 = gift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X20_v8 (GiftUIElement)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v24+28]");
				object obj11 = 0;
				GiftUIElement giftUIElement5 = gift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v7 (GiftUIElement)+40]");
				object obj12 = 0;
				long[] array3 = dbIds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v8+28]");
				int num2 = StorePricing.TotalPrice((StoreItem)0, array3.Length);
				object action = "SERVICE_DISABLED" + 2848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v25+18]");
				FirebaseTrack.CurrencyEvent((string)action, (string)0, num2);
			}
			<>4__this.UpdateBuyingButtons();
		}
	}

	private const string GiftToMe = "Gift to me";

	private const float DoubleClickThreshHold = 0.3f;

	public GiftsListView giftsListView;

	public TextMeshProUGUI SendButtonText;

	public Button SendForAllButton;

	public TextMeshProUGUI playerCoins;

	public RectTransform broadcastMessageBox;

	public RectTransform broadcastGiftRect;

	public Image broadcastGift;

	public Image broadcastLogo;

	public TextMeshProUGUI broadcastMessage;

	private GameEventsChannel gameEventsChannel;

	private AvatarInitializer bottomPlayer;

	private AvatarInitializer rightPlayer;

	private AvatarInitializer topPlayer;

	private AvatarInitializer leftPlayer;

	private Toggle[] toggles;

	private GiftUIElement activeGift;

	private bool isSending;

	private KGame game;

	private float lastClickTime;

	private IEnumerable<KPlayer> activePlayers
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_0031: Expected O, but got I
			//IL_005d: Expected I, but got O
			if ((object)game != null)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 832;
				object obj2 = (nint)0 + (nint)3280;
				object obj3 = (nint)0 + (nint)3568;
				List<KPlayer> players = game.Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, int, bool> func = default(Func<object, int, bool>);
				func..ctor((object)this, (IntPtr)obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DECDA8");
				IEnumerable<KPlayer> result = default(IEnumerable<KPlayer>);
				return result;
			}
			return (IEnumerable<KPlayer>)new NullReferenceException();
		}
	}

	private KPlayer mainPlayer
	{
		get
		{
			if ((object)game != null)
			{
				if (game.IsSpectator)
				{
					if ((object)game != null)
					{
						return game.GetPlayerByIndex(1);
					}
				}
				else if ((object)game != null)
				{
					return game.MyPlayer;
				}
			}
			return (KPlayer)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_01d1: Expected I, but got O
		//IL_01fb: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00bf: Expected I, but got O
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0110: Expected I, but got O
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0135: Expected O, but got I
		//IL_0161: Expected I, but got O
		//IL_0172: Expected O, but got I
		//IL_019e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3304;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj4 = (nint)0 + (nint)3352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj8 = (nint)0 + (nint)3360;
		gameEventsChannel.ShowGiftPanel += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj8);
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2152;
		object obj10 = (nint)0 + (nint)3288;
		gameEventsChannel.ShowGiftPanelAndAcitvatePlayer += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj10);
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2496;
		object obj12 = (nint)0 + (nint)3344;
		gameEventsChannel.OnGiftClicked += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)3336;
		gameEventsChannel.OnPlayerGiftClicked += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj13);
		StorePricing.OnPricingChanged += action6;
	}

	private void OnPricingChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E658F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = game;
			obj6 = game;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = game;
			obj6 = game;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b9;
		IL_00b9:
		UpdateBuyingButtons();
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b9;
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_01ba: Expected I, but got O
		//IL_0049: Expected I, but got O
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_00eb: Expected I, but got O
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0110: Expected O, but got I
		//IL_013c: Expected I, but got O
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_018d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3336;
		object obj3 = (nint)0 + (nint)3352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj5 = (nint)0 + (nint)3360;
		gameEventsChannel.ShowGiftPanel -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj5);
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj7 = (nint)0 + (nint)3296;
		gameEventsChannel.ShowGiftPanelAndAcitvatePlayer -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj7);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2152;
		object obj9 = (nint)0 + (nint)3288;
		gameEventsChannel.OnDismissibleClicked -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj9);
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2496;
		object obj11 = (nint)0 + (nint)3344;
		gameEventsChannel.OnGiftClicked -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj11);
		gameEventsChannel.OnPlayerGiftClicked -= action6;
	}

	private void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_024f: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_014b: Expected O, but got I
		//IL_018c: Expected I, but got O
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I
		//IL_01dd: Expected I, but got O
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_022e: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 168;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		DisableSendGiftButtons();
		GameObject gameObject = giftsListView.gameObject;
		gameObject.SetActive(value: false);
		object obj7 = typeof(Queue<string>) + 848;
		object obj8 = (nint)0 + (nint)2200;
		giftsListView.Initialize(game);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName = "___# Content push apply failed [{0}]: {1}" + 2920;
		object defaultValue = "Material with texture name \"" + 3392;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2136;
		object obj12 = (nint)0 + (nint)3320;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		VariableBinderExtensions.Bind(playerCoins, localUser, (string)varName, (string)defaultValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj12);
		object obj13 = typeof(SqlSingle[]) + 2376;
		object obj14 = (nint)0 + (nint)3312;
		game.OnGiftSent += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj14);
		object obj15 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj16 = (nint)0 + (nint)3328;
		game.OnGameInitialized += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj16);
		game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
	}

	private void DisableSendGiftButtons()
	{
		//IL_0026: Expected O, but got I
		SendForAllButton.interactable = false;
		object obj = (nint)0 + (nint)160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Selectable selectable = default(Selectable);
		selectable.interactable = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Selectable selectable2 = default(Selectable);
		selectable2.interactable = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Selectable selectable3 = default(Selectable);
		selectable3.interactable = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Selectable selectable4 = default(Selectable);
		selectable4.interactable = false;
		gameEventsChannel.TriggerGiftSelected(canBuy: false);
	}

	private void OnGameInitialized()
	{
		UpdatePlayers();
	}

	private void OnPlayerSwitchSeat(int i, string s)
	{
		UpdatePlayers();
	}

	private void UpdatePlayers()
	{
		List<KPlayer> players = game.Players;
		object player = ((List<object>)(object)players).get_Item(0);
		bottomPlayer.Initialize((KPlayer)player);
		List<KPlayer> players2 = game.Players;
		object player2 = ((List<object>)(object)players2).get_Item(1);
		rightPlayer.Initialize((KPlayer)player2);
		List<KPlayer> players3 = game.Players;
		object player3 = ((List<object>)(object)players3).get_Item(2);
		topPlayer.Initialize((KPlayer)player3);
		List<KPlayer> players4 = game.Players;
		object player4 = ((List<object>)(object)players4).get_Item(3);
		leftPlayer.Initialize((KPlayer)player4);
		UpdateBuyingButtons();
	}

	public void GiftUIElementClicked(GiftUIElement giftUI)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04b0: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_02c2: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_0373: Invalid comparison between F4 and I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03c2: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_057f: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_05c3: Expected O, but got I4
		//IL_044f: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		//IL_0668: Expected O, but got I4
		//IL_05fe: Expected I, but got O
		//IL_060e: Expected O, but got I
		//IL_0630: Expected O, but got I4
		//IL_0640: Expected O, but got I
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6594]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 152;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 152;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = giftUI != obj7;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		UnityEngine.Object obj12 = obj7;
		obj4 = obj8;
		object obj13 = 0;
		UnityEngine.Object obj14 = obj7;
		if (obj10 != null)
		{
			goto IL_00ec;
		}
		goto IL_0236;
		IL_00ec:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v49+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = (UnityEngine.Object)obj4 != null;
			bool flag6 = !flag5;
			object obj16 = !flag6;
			obj13 = 0;
			obj14 = null;
			if (obj16 != null)
			{
				goto IL_04be;
			}
			object obj17 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = (UnityEngine.Object)obj4 != null;
			bool flag8 = !flag7;
			obj13 = 0;
			obj14 = null;
			object obj17 = 0;
			if (!flag8)
			{
				goto IL_04be;
			}
		}
		goto IL_04f1;
		IL_06ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_030d:
		KPlayer kPlayer;
		KPlayer kPlayer2;
		object obj19;
		if (kPlayer != null)
		{
			if (kPlayer.IsMe)
			{
				float timeSinceLevelLoad = Time.timeSinceLevelLoad;
				float num = timeSinceLevelLoad - lastClickTime;
				if (num < 1.0502537E+09f)
				{
					object obj18 = typeof(TypeConverter<ushort, char>) + 3184;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					bool flag9 = (object)game == null;
					obj19 = 1050253722;
					obj14 = (UnityEngine.Object)1;
					if (!flag9)
					{
						if (game.IsSpectator)
						{
							bool flag10 = (object)game == null;
							obj19 = 1050253722;
							obj14 = null;
							if (!flag10)
							{
								kPlayer2 = game.GetPlayerByIndex(1);
								obj13 = 0;
								obj14 = (UnityEngine.Object)1;
								goto IL_05ab;
							}
						}
						else
						{
							bool flag11 = (object)game == null;
							obj19 = 1050253722;
							obj14 = null;
							if (!flag11)
							{
								kPlayer2 = game.MyPlayer;
								obj14 = null;
								goto IL_05ab;
							}
						}
					}
					goto IL_06ae;
				}
			}
			float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
			lastClickTime = timeSinceLevelLoad2;
			return;
		}
		goto IL_06ae;
		IL_00a0:
		bool flag12 = giftUI != obj5;
		bool flag13 = !flag12;
		obj11 = 0;
		obj12 = obj5;
		obj13 = 0;
		obj14 = obj5;
		if (!flag13)
		{
			goto IL_00ec;
		}
		goto IL_0236;
		IL_0236:
		if ((object)game != null)
		{
			if (game.IsSpectator)
			{
				bool flag14 = (object)game == null;
				obj14 = null;
				if (!flag14)
				{
					kPlayer = game.GetPlayerByIndex(1);
					obj13 = 0;
					obj14 = (UnityEngine.Object)1;
					goto IL_030d;
				}
			}
			else
			{
				bool flag15 = (object)game == null;
				obj14 = null;
				if (!flag15)
				{
					kPlayer = game.MyPlayer;
					obj14 = null;
					goto IL_030d;
				}
			}
		}
		goto IL_06ae;
		IL_04be:
		if (obj4 != null)
		{
			((GiftUIElement)obj4).Dismiss();
			object obj17 = obj13;
			goto IL_04f1;
		}
		goto IL_06ae;
		IL_05ab:
		KPlayer[] array = default(KPlayer[]);
		bool flag16 = array == null;
		obj19 = 1050253722;
		if (flag16)
		{
			goto IL_06ae;
		}
		bool flag17 = kPlayer2 == null;
		UnityEngine.Object obj20 = obj14;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag17)
		{
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<KPlayer[]>)+40]");
			obj20 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag18 = ex == null;
			obj19 = 1050253722;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<KPlayer[]>)+40]");
			obj14 = (UnityEngine.Object)0;
			if (flag18)
			{
				goto IL_06ca;
			}
		}
		bool flag19 = array.Length == 0;
		obj19 = 1050253722;
		obj14 = obj20;
		if (!flag19)
		{
			object obj21 = array + 32;
			obj21 = kPlayer2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Send(array);
			return;
		}
		goto IL_06bc;
		IL_04f1:
		activeGift = giftUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		float timeSinceLevelLoad3 = Time.timeSinceLevelLoad;
		lastClickTime = timeSinceLevelLoad3;
		UpdateBuyingButtons();
		IEnumerable<KPlayer> list = activePlayers;
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)list))
		{
			TriggerGift();
		}
		return;
		IL_06bc:
		ex = new IndexOutOfRangeException();
		goto IL_06ca;
		IL_06ae:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06bc;
	}

	private void ActivatePlayer(int index)
	{
		//IL_0020: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_011f: Expected O, but got I4
		Toggle[] array = toggles;
		if (toggles != null)
		{
			bool flag = index < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_013d;
			}
			object obj2 = toggles + index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+20]");
				((Toggle)0).isOn = true;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+E4]");
				if ((nint)0 != 0)
				{
					if (!(activeGift != null))
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag2 = activeGift != null;
					bool flag3 = !flag2;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						return;
					}
				}
				TriggerGift();
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_013d;
		IL_013d:
		throw new IndexOutOfRangeException();
	}

	public void OnReceiverToggle(bool val)
	{
		if (val)
		{
			TriggerGift();
		}
	}

	private void TriggerGift()
	{
		//IL_000c: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		object obj = (nint)0 + (nint)2656;
		IEnumerable<KPlayer> list = activePlayers;
		bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)list);
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			if (activeGift == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = activeGift == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 != null)
			{
				return;
			}
		}
		IEnumerable<KPlayer> source = activePlayers;
		object[] players = Enumerable.ToArray((IEnumerable<object>)source);
		Send((KPlayer[])players);
	}

	private void UpdateBuyingButtons()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_06fe: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_0141: Expected O, but got I
		//IL_0557: Expected O, but got I
		//IL_0571: Expected O, but got I4
		//IL_0713: Expected O, but got I
		//IL_05ae: Expected O, but got I
		//IL_05e1: Expected O, but got I4
		//IL_0639: Expected O, but got I4
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected I4, but got Unknown
		//IL_06a6: Expected O, but got I4
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected I4, but got Unknown
		int humansCount = game.HumansCount;
		if (humansCount <= 0)
		{
			goto IL_018f;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = activeGift != null;
			bool flag2 = !flag;
			object obj3 = 0;
			if (!flag2)
			{
				goto IL_00a8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = activeGift != null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			object obj3 = 0;
			if (obj4 != null)
			{
				goto IL_00a8;
			}
		}
		SendForAllButton.interactable = true;
		goto IL_01f7;
		IL_00a8:
		GiftUIElement giftUIElement = activeGift;
		object obj5 = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X20_v13 (GiftUIElement)+40]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v11+28]");
		int num = StorePricing.EffectivePrice((StoreItem)0);
		object obj7 = typeof(Queue<string>) + 848;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v74+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		if (num > aces)
		{
			goto IL_018f;
		}
		gameEventsChannel.TriggerGiftSelected(canBuy: true);
		GiftUIElement giftUIElement2 = activeGift;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v9+62D]");
		object obj11 = (nint)0 & (nint)1;
		bool flag6 = obj11 == null;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X20_v15 (GiftUIElement)+40]");
		object obj13 = 0;
		int humansCount2 = game.HumansCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v15+28]");
		int num2 = StorePricing.TotalPrice((StoreItem)0, humansCount2);
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v86+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
		object obj16 = num2 - aces2;
		bool flag8 = (nint)obj16 < 0;
		bool flag9 = obj16 == null;
		int num3 = num2 ^ aces2;
		int num4 = num2 ^ obj16;
		int num5 = num3 & num4;
		bool flag10 = num5 < 0;
		bool flag11 = flag8 == flag10;
		object obj17 = !flag11;
		bool interactable = (byte)((obj17 | flag9) ? 1 : 0) != 0;
		SendForAllButton.interactable = interactable;
		if (num2 <= aces2)
		{
			ShakeButton(SendForAllButton);
		}
		goto IL_01f7;
		IL_01f7:
		object obj18 = (nint)0 + (nint)160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		List<KPlayer> players = game.Players;
		object obj19 = ((List<object>)(object)players).get_Item(0);
		bool isHuman = ((KPlayer)obj19).IsHuman;
		Selectable selectable = default(Selectable);
		selectable.interactable = isHuman;
		List<KPlayer> players2 = game.Players;
		object obj20 = ((List<object>)(object)players2).get_Item(0);
		if (((KPlayer)obj20).IsHuman)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Selectable button = default(Selectable);
			ShakeButton(button);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		List<KPlayer> players3 = game.Players;
		object obj21 = ((List<object>)(object)players3).get_Item(1);
		bool isHuman2 = ((KPlayer)obj21).IsHuman;
		Selectable selectable2 = default(Selectable);
		selectable2.interactable = isHuman2;
		List<KPlayer> players4 = game.Players;
		object obj22 = ((List<object>)(object)players4).get_Item(1);
		if (((KPlayer)obj22).IsHuman)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Selectable button2 = default(Selectable);
			ShakeButton(button2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		List<KPlayer> players5 = game.Players;
		object obj23 = ((List<object>)(object)players5).get_Item(2);
		bool isHuman3 = ((KPlayer)obj23).IsHuman;
		Selectable selectable3 = default(Selectable);
		selectable3.interactable = isHuman3;
		List<KPlayer> players6 = game.Players;
		object obj24 = ((List<object>)(object)players6).get_Item(2);
		if (((KPlayer)obj24).IsHuman)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Selectable button3 = default(Selectable);
			ShakeButton(button3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		List<KPlayer> players7 = game.Players;
		object obj25 = ((List<object>)(object)players7).get_Item(3);
		bool isHuman4 = ((KPlayer)obj25).IsHuman;
		Selectable selectable4 = default(Selectable);
		selectable4.interactable = isHuman4;
		List<KPlayer> players8 = game.Players;
		object obj26 = ((List<object>)(object)players8).get_Item(3);
		if (((KPlayer)obj26).IsHuman)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Selectable button4 = default(Selectable);
			ShakeButton(button4);
		}
		return;
		IL_018f:
		DisableSendGiftButtons();
	}

	private static void ShakeButton(Selectable button)
	{
		//IL_0087: Expected O, but got I
		//IL_009d: Expected O, but got I
		Transform target = button.transform;
		int num = ShortcutExtensions.DOKill(target, complete: true);
		if (button.m_Interactable)
		{
			Transform target2 = button.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target2, 0.8f, 0.5f);
			object obj = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
			object obj2 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
	}

	public void Show()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0177: Expected O, but got I
		//IL_019f: Expected I, but got O
		//IL_01d0: Expected I, but got O
		KPlayer kPlayer = ((!game.IsSpectator) ? game.MyPlayer : game.GetPlayerByIndex(1));
		if (kPlayer.IsMe)
		{
			object text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3096;
			TextMeshProExtensions.Localize(SendButtonText, (string)text);
		}
		else
		{
			KPlayer kPlayer2 = ((!game.IsSpectator) ? game.MyPlayer : game.GetPlayerByIndex(1));
			string nickName = kPlayer2.NickName;
			TextMeshProExtensions.SetUsername(SendButtonText, nickName, isSubscribed: false, isVerified: false);
		}
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, 0f, 0.3f);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj2 = (nint)0 + (nint)3296;
		gameEventsChannel.TriggerShowGiftSelection();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnDismissibleClicked += action2;
		gameEventsChannel.TriggerShowDismissibleBlocker();
		GameObject gameObject = giftsListView.gameObject;
		gameObject.SetActive(value: true);
		UpdateBuyingButtons();
	}

	public void ShowAndActivatePlayer(int player)
	{
		Show();
		ActivatePlayer(player);
	}

	private void Hide(GameCard _)
	{
		Hide();
	}

	public void Hide()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004d: Expected I, but got O
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0245: Expected O, but got I4
		//IL_0107: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0266: Expected O, but got I4
		//IL_030c: Expected O, but got I
		//IL_031c: Expected O, but got I
		//IL_032c: Expected O, but got I
		//IL_034e: Expected O, but got I4
		//IL_036e: Expected O, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02bd: Expected O, but got I4
		//IL_02ce: Expected O, but got I4
		//IL_0190: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_03a6: Expected O, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_045b: Expected O, but got I
		//IL_046c: Expected I, but got O
		//IL_048a: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_03d6: Expected O, but got I
		RectTransform target = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target, -1655f, 0.3f);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj2 = (nint)0 + (nint)3296;
		gameEventsChannel.TriggerHideGiftSelection();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnDismissibleClicked -= action;
		gameEventsChannel.TriggerHideDismissibleBlocker();
		GameObject gameObject = giftsListView.gameObject;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		gameObject.SetActive(value: false);
		object obj4 = this + 152;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v8+E4]");
		object obj7;
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj4;
			bool flag2 = !flag;
			object obj6 = !flag2;
			obj7 = 0;
			if (obj6 == null)
			{
				goto IL_011f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj4;
			bool flag4 = !flag3;
			obj7 = 0;
			if (flag4)
			{
				goto IL_011f;
			}
		}
		((GiftUIElement)obj4).Dismiss();
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 352;
		Toggle[] array = toggles;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		object obj11 = obj8;
		obj7 = 0;
		object obj12 = obj9;
		Toggle[] array2 = toggles;
		if (obj10 != null)
		{
			goto IL_0184;
		}
		goto IL_02ee;
		IL_0384:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		object obj15;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+B8]");
			obj15 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2224;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj15, (IntPtr)obj17);
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v16+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj21;
		object obj20 = obj21;
		Action<object> action3 = action2;
		IEnumerable<object> enumerable;
		IEnumerable<object> enumeration = enumerable;
		goto IL_0423;
		IL_0423:
		ArraysExtensions.ForEach(enumeration, action3);
		return;
		IL_0184:
		obj20 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+B8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v11+8]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v11+8]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		enumeration = array;
		Action<object> action4;
		if (obj22 == null)
		{
			obj21 = obj20;
			obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v11+8]");
			action4 = (Action<object>)0;
			enumerable = array;
			goto IL_0384;
		}
		goto IL_0423;
		IL_011f:
		obj8 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 352;
		array = toggles;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		obj11 = obj8;
		obj12 = obj9;
		array2 = toggles;
		if (!flag8)
		{
			goto IL_0184;
		}
		goto IL_02ee;
		IL_02ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj11;
		obj21 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+B8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v11+8]");
		action4 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v11+8]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		enumerable = array2;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v11+8]");
		action3 = (Action<object>)0;
		enumeration = array2;
		if (obj23 == null)
		{
			goto IL_0384;
		}
		goto IL_0423;
	}

	public void SendForAll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_0160: Expected O, but got I
		//IL_0170: Expected O, but got I
		//IL_0192: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_039b: Expected O, but got I
		//IL_03a3: Expected I, but got O
		//IL_03b4: Expected I, but got O
		//IL_03d2: Expected O, but got I
		//IL_03e3: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		//IL_026d: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_043b: Expected O, but got I
		//IL_0443: Expected I, but got O
		//IL_0454: Expected I, but got O
		//IL_0472: Expected O, but got I
		//IL_0483: Expected O, but got I4
		//IL_0326: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 352;
		IEnumerable<object> enumeration;
		object obj6;
		Action<object> action;
		object obj10;
		if (activeGift != null)
		{
			List<KPlayer> players = game.Players;
			object[] players2 = ((List<object>)(object)players).ToArray();
			Send((KPlayer[])players2);
			enumeration = toggles;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v27+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v22+10]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v22+10]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					goto IL_02d4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v27+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v22+10]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v22+10]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					goto IL_02d4;
				}
			}
		}
		else
		{
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v8+18]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v8+18]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				enumeration = toggles;
				if (obj11 == null)
				{
					goto IL_021b;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v8+18]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v8+18]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				enumeration = toggles;
				if (obj12 == null)
				{
					goto IL_021b;
				}
			}
		}
		goto IL_032b;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14+B8]");
			obj10 = 0;
		}
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2264;
		nint num = (nint)obj16;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj10, (IntPtr)obj16);
		object obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v13+B8]");
		object obj18 = (nint)0 + (nint)24;
		obj18 = action2;
		object obj19 = 0;
		Action<object> action3 = action2;
		enumeration = toggles;
		goto IL_03fa;
		IL_02d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v27+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v28+B8]");
			obj6 = 0;
		}
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)2256;
		num = (nint)obj23;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj6, (IntPtr)obj23);
		object obj24 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v27+B8]");
		obj18 = (nint)0 + (nint)16;
		obj18 = action4;
		obj19 = 0;
		action3 = action4;
		goto IL_03fa;
		IL_03fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action3;
		goto IL_032b;
		IL_032b:
		ArraysExtensions.ForEach(enumeration, action);
	}

	public void Send()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_011e: Expected I, but got O
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = (object)game == null;
		int num = 1;
		KPlayer kPlayer;
		if (!flag)
		{
			if (game.IsSpectator)
			{
				bool flag2 = (object)game == null;
				num = 0;
				if (!flag2)
				{
					kPlayer = game.GetPlayerByIndex(1);
					num = 1;
					goto IL_00d4;
				}
			}
			else
			{
				bool flag3 = (object)game == null;
				num = 0;
				if (!flag3)
				{
					kPlayer = game.MyPlayer;
					num = 0;
					goto IL_00d4;
				}
			}
		}
		goto IL_01bc;
		IL_01ca:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_01d8;
		IL_01bc:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01ca;
		IL_01d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_00d4:
		KPlayer[] array = default(KPlayer[]);
		if (array == null)
		{
			goto IL_01bc;
		}
		bool flag4 = kPlayer == null;
		int num2 = num;
		if (!flag4)
		{
			nint num3 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v9 (Il2CppClass<KPlayer[]>)+40]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v9 (Il2CppClass<KPlayer[]>)+40]");
			num = 0;
			if (flag5)
			{
				goto IL_01d8;
			}
		}
		bool flag6 = array.Length == 0;
		num = num2;
		if (!flag6)
		{
			object obj2 = array + 32;
			obj2 = kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Send(array);
			return;
		}
		goto IL_01ca;
	}

	public void SendToPlayer(KPlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_0047: Expected I, but got O
		//IL_0057: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		KPlayer[] array = default(KPlayer[]);
		object obj2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj3;
		if (array != null)
		{
			bool flag = player == null;
			obj2 = 1;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v7 (Il2CppClass<KPlayer[]>)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v7 (Il2CppClass<KPlayer[]>)+40]");
				obj3 = 0;
				if (flag2)
				{
					goto IL_010a;
				}
			}
			if (array.Length != 0)
			{
				object obj4 = array + 32;
				obj4 = player;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Send(array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj2 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj3 = obj2;
		goto IL_010a;
		IL_010a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void Send(KPlayer[] players)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_06e2: Expected O, but got I
		//IL_06ee: Expected O, but got I
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0712: Expected O, but got I
		//IL_0722: Expected O, but got I
		//IL_0744: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected O, but got Unknown
		//IL_077c: Expected O, but got I
		//IL_078d: Expected I, but got O
		//IL_07ab: Expected O, but got I
		//IL_07c6: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_07e3: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0226: Expected O, but got I4
		//IL_024f: Expected O, but got I
		//IL_02b5: Expected O, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0341: Expected O, but got I4
		//IL_07f8: Expected O, but got I
		//IL_0808: Expected O, but got I
		//IL_082a: Expected O, but got I4
		//IL_099e: Expected O, but got I
		//IL_09bb: Expected O, but got I
		//IL_09f2: Expected O, but got I4
		//IL_08b8: Expected O, but got I
		//IL_08c8: Expected O, but got I
		//IL_08ea: Expected O, but got I4
		//IL_0388: Expected O, but got I4
		//IL_0a0c: Expected O, but got I
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a39: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected O, but got Unknown
		//IL_0862: Expected O, but got I
		//IL_0873: Expected I, but got O
		//IL_0891: Expected O, but got I
		//IL_040c: Expected O, but got I4
		//IL_03c6: Expected O, but got I4
		//IL_03b8: Expected O, but got I
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_0922: Expected O, but got I
		//IL_0933: Expected I, but got O
		//IL_0951: Expected O, but got I
		//IL_044a: Expected O, but got I4
		//IL_043c: Expected O, but got I
		//IL_0978: Expected O, but got I
		//IL_04ab: Expected O, but got I
		//IL_04ca: Expected I, but got O
		//IL_04da: Expected O, but got I
		//IL_098d: Expected O, but got I
		//IL_0511: Expected O, but got I
		//IL_0533: Expected O, but got I
		//IL_0548: Expected O, but got I
		//IL_055e: Expected O, but got I
		//IL_05fe: Expected O, but got I
		//IL_0631: Expected O, but got I
		//IL_063a: Expected O, but got I4
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_0669: Expected O, but got I
		//IL_067a: Expected I, but got O
		//IL_06b8: Expected O, but got I
		//IL_06b8: Expected O, but got I4
		//IL_05e1: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 352;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		object obj7 = (nint)0 + (nint)3560;
		object obj8 = (nint)0 + (nint)1376;
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v10+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v71+20]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v71+20]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v77+B8]");
				obj10 = 0;
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)2232;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj10, (IntPtr)obj15);
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v76+B8]");
			object obj17 = (nint)0 + (nint)32;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = 0;
			predicate = func;
		}
		IEnumerable<object> source = Enumerable.Where(players, predicate);
		object[] array = Enumerable.ToArray(source);
		object obj19 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			if (activeGift == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = activeGift == null;
			bool flag5 = !flag4;
			object obj20 = !flag5;
			if (obj20 != null)
			{
				return;
			}
		}
		GiftUIElement giftUIElement = activeGift;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v8 (GiftUIElement)+40]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v11+28]");
		int num = StorePricing.TotalPrice((StoreItem)0, array.Length);
		object obj22 = typeof(Queue<string>) + 848;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		if (num > aces)
		{
			return;
		}
		bool flag7 = !isSending;
		object obj26 = !flag7;
		if (obj26 != null || !Enumerable.Any(array))
		{
			return;
		}
		isSending = true;
		object obj27 = obj2 + 32;
		obj27 = activeGift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v32+E4]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v32+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v62+28]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v62+28]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v32+E4]");
			bool flag10 = (nint)0 == 0;
			object obj32 = !flag10;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj33 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v68+B8]");
				obj30 = 0;
			}
			object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = (nint)0 + (nint)2240;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj30, (IntPtr)obj35);
			object obj36 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v67+B8]");
			object obj37 = (nint)0 + (nint)40;
			obj37 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = 0;
			selector = func2;
		}
		object obj38 = (nint)0 + (nint)3656;
		IEnumerable<int> source2 = Enumerable.Select(array, selector);
		object obj39 = (nint)0 + (nint)1320;
		int[] array2 = Enumerable.ToArray(source2);
		object obj40 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v38+E4]");
		bool flag11 = (nint)0 == 0;
		object obj41 = !flag11;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj40 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v38+B8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v54+30]");
		Func<object, long> selector2 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v54+30]");
		bool flag12 = (nint)0 == 0;
		object obj43 = !flag12;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v38+E4]");
			bool flag13 = (nint)0 == 0;
			object obj44 = !flag13;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj45 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v60+B8]");
				obj42 = 0;
			}
			object obj46 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj47 = (nint)0 + (nint)2248;
			Func<object, long> func3 = default(Func<object, long>);
			func3..ctor(obj42, (IntPtr)obj47);
			object obj48 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v59+B8]");
			object obj49 = (nint)0 + (nint)48;
			obj49 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = 0;
			selector2 = func3;
		}
		object obj50 = (nint)0 + (nint)3664;
		IEnumerable<long> source3 = Enumerable.Select(array, selector2);
		long[] array3 = Enumerable.ToArray(source3);
		object obj51 = obj2 + 48;
		obj51 = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TextMeshProUGUI textMeshProUGUI = playerCoins;
		string text = playerCoins.text;
		int num2 = int.Parse(text);
		object obj52 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X27_v6+40]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v38+28]");
		int num3 = StorePricing.TotalPrice((StoreItem)0, array.Length);
		int num4 = default(int);
		string text2 = num4.ToString();
		nint num5 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v40 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		long[] array4 = (long[])0;
		playerCoins.text = text2;
		Hide();
		object obj54 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X21_v6+40]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v43+28]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v44+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+20]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v46+40]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v47+28]");
		ItemCategory category = ((StoreItem)0).GetCategory();
		if (category != ItemCategory.AnimatedGifts)
		{
			bool flag14 = category != ItemCategory.Gifts;
			int num6 = 0;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+28]");
				num6 = 0;
				KGame kGame = game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+28]");
				kGame.FakeGiftSent(0, array2);
				object obj18 = 0;
				array4 = (long[])(object)array2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+30]");
			array4 = (long[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+28]");
			int num6 = 0;
			KGame kGame2 = game;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+30]");
			kGame2.FakeAnimatedGiftSent((int)num7, (long[])0);
			object obj18 = 0;
		}
		object obj59 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj60 = (nint)0 + (nint)2272;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj60);
		IClientContext clientContext = KGameExtensions.GetClientContext(game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+30]");
		KammelnaRequests.BuyItem((int)num8, action, clientContext, (int?)(object)0, (long[])0);
	}

	private void OnGiftReceived(GiftNotification gift)
	{
		//IL_0013: Expected O, but got I8
		object obj = gift.<SenderId>k__BackingField + 1;
		if (obj == null)
		{
			AdvertiseGifts(gift.<ItemId>k__BackingField);
		}
	}

	public void AdvertiseGifts(int giftItemId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_0278: Expected O, but got I
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E659D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		StoreItem storeItem = Store.GetStoreItem(giftItemId);
		object obj5 = 0;
		goto IL_011f;
		IL_011f:
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(storeItem.<description>k__BackingField))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(storeItem.<description>k__BackingField);
			bool flag3 = !flag2;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				return;
			}
		}
		TextMeshProExtensions.FixArabic(broadcastMessage, storeItem.<description>k__BackingField);
		UIExtensions.LoadItemImage(broadcastGift, storeItem.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle);
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		int roomAdCampaignID = SFSKammelnaRoomExtensions.GetRoomAdCampaignID(currentRoom);
		UIExtensions.LoadAdCampaignLogo(broadcastLogo, roomAdCampaignID);
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOAnchorPosX(broadcastMessageBox, -430f, 0.75f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Sequence s3 = TweenSettingsExtensions.AppendInterval(s2, 8f);
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOAnchorPosX(broadcastMessageBox, 0f, 0.75f);
		Sequence sequence = TweenSettingsExtensions.Append(s3, t2);
		return;
		IL_0074:
		storeItem = Store.GetStoreItem(giftItemId);
		bool flag6 = storeItem == null;
		object obj16 = !flag6;
		obj5 = 0;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011f;
	}

	private bool <get_activePlayers>b__19_0(KPlayer player, int index)
	{
		//IL_00bf: Expected I4, but got O
		//IL_0044: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0071: Expected O, but got I
		Toggle[] array = toggles;
		if (toggles != null)
		{
			bool flag = index < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_00b1;
			}
			object obj2 = toggles + index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+120]");
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00b1;
		IL_00b1:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}
}
