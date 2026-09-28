using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BalootBiddingButtons : BiddingButtons
{
	private enum BiddingState
	{
		FirstRound,
		SecondRound,
		Finished
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Button> <>9__42_0;

		public static Action<Button> <>9__47_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShowBid>b__42_0(Button button)
		{
			GameObject gameObject = button.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <SubmitBid>b__47_0(Button b)
		{
			b.interactable = false;
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public Button button;

		public BalootBiddingButtons <>4__this;

		internal void <Awake>b__1()
		{
			<>4__this.onButtonClick(button);
		}
	}

	private sealed class <>c__DisplayClass51_0
	{
		public BalootBiddingButtons <>4__this;

		public Button[] newStateButtons;

		internal void <MitigateMissClicks>b__0()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0062: Expected O, but got I4
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_008b: Expected O, but got I
			BalootBiddingButtons balootBiddingButtons = <>4__this;
			balootBiddingButtons.isMitigatingMissClicks = false;
			Button[] array = newStateButtons;
			if (array.Length >= 1)
			{
				object obj = array + 32;
				object obj2 = 0;
				do
				{
					obj2++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X21_v4+v30 @ X20_v5*8]");
					((Selectable)0).interactable = true;
				}
				while ((nint)obj2 < array.Length);
			}
		}
	}

	private const int SUBSTATE_HOKOM_OPEN_CLOSE = 1001;

	public Button buttonPass;

	public Button buttonHokomClubs;

	public Button buttonHokomDiamonds;

	public Button buttonHokomSpades;

	public Button buttonHokomHearts;

	public Button buttonWala;

	public Button buttonSun;

	public Button buttonToSun;

	public Button buttonBeforeToSun;

	public Button buttonTriple;

	public Button buttonQahwa;

	public Button buttonHokom;

	public Button buttonHokomClose;

	public Button buttonHokom2;

	public Button buttonDouble;

	public Button buttonFour;

	public Button buttonAshkal;

	public Button buttonConfirmHokom;

	public Button buttonHokomOpen;

	private Button[] stateButtons;

	private Button[] round1DefaultState1;

	private Button[] round1DefaultState2;

	private Button[] round2DefaultState1;

	private Button[] round2DefaultState2;

	private BiddingState biddingState;

	private bool wasBiddingPredeterminationActive;

	private bool isMitigatingMissClicks;

	private int state;

	private int substate;

	private const string Awal = "awal";

	private const string Pass = "pass";

	private const string Thany = "thany";

	private const string Wala = "wala";

	private const string Waraq = "waraq";

	private Dictionary<BalootBidingButtonEnum, Button> _ballotBidingButtons;

	private bool isAshkalAvailable
	{
		get
		{
			//IL_022e: Expected I4, but got O
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_011e: Expected I, but got O
			//IL_0147: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_009b: Expected O, but got I4
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00c3: Expected O, but got I4
			//IL_017b: Expected O, but got I
			//IL_00f5: Expected O, but got I4
			//IL_01b2: Expected O, but got I
			//IL_01ed: Expected O, but got I
			CardGame cardGame = game;
			if ((object)game == null)
			{
				goto IL_0212;
			}
			if (((KGame)cardGame).<MySeatIndex>k__BackingField != cardGame.<Dealer>k__BackingField)
			{
				object obj = ((KGame)cardGame).<MySeatIndex>k__BackingField + 1;
				object obj2 = obj * 1717986919;
				object obj3 = obj2 >> 33;
				object obj4 = obj3 + obj3;
				object obj5 = obj4 + obj4;
				object obj6 = obj - obj5;
				bool flag = (nint)obj6 < 1;
				object obj7 = !flag;
				object obj8 = obj6 - 1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				object obj10 = obj7 & obj9;
				object obj11 = ~obj10;
				if (obj11 != null)
				{
					obj6 = 1;
				}
				if ((nint)obj6 != cardGame.<Dealer>k__BackingField)
				{
					return false;
				}
			}
			object obj12 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
			object obj13 = obj12;
			nint num = (nint)cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8 (Il2CppClass<CardGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v3+130]");
			bool flag3 = num2 < 0;
			object obj14 = !flag3;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8 (Il2CppClass<CardGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v3+130]");
				object obj16 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v10-8]");
				if (0 == (nint)obj13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (CardGame)+188]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (CardGame)+188]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v12+10]");
						object obj18 = -12;
						bool flag4 = obj18 == null;
						return !flag4;
					}
					goto IL_0212;
				}
			}
			goto IL_0220;
			IL_0212:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0220;
			IL_0220:
			InvalidCastException ex2 = new InvalidCastException();
			return (byte)(int)ex2 != 0;
		}
	}

	protected override void Awake()
	{
		//IL_2707: Unknown result type (might be due to invalid IL or missing references)
		//IL_270c: Expected O, but got Unknown
		//IL_2720: Unknown result type (might be due to invalid IL or missing references)
		//IL_2725: Expected O, but got Unknown
		//IL_2731: Expected O, but got I
		//IL_273d: Expected O, but got I
		//IL_2767: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_02c9: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_037e: Expected O, but got I4
		//IL_03fa: Expected O, but got I
		//IL_040a: Expected O, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_04af: Expected O, but got I4
		//IL_052b: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_05e0: Expected O, but got I4
		//IL_065c: Expected O, but got I
		//IL_066c: Expected O, but got I
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0711: Expected O, but got I4
		//IL_078d: Expected O, but got I
		//IL_079d: Expected O, but got I
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0842: Expected O, but got I4
		//IL_08be: Expected O, but got I
		//IL_08ce: Expected O, but got I
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_0973: Expected O, but got I4
		//IL_09ef: Expected O, but got I
		//IL_09ff: Expected O, but got I
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected O, but got Unknown
		//IL_0aa4: Expected O, but got I4
		//IL_0b20: Expected O, but got I
		//IL_0b30: Expected O, but got I
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected O, but got Unknown
		//IL_0bd5: Expected O, but got I4
		//IL_0c51: Expected O, but got I
		//IL_0c61: Expected O, but got I
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected O, but got Unknown
		//IL_0d06: Expected O, but got I4
		//IL_0d82: Expected O, but got I
		//IL_0d92: Expected O, but got I
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected O, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected O, but got Unknown
		//IL_0e37: Expected O, but got I4
		//IL_0eb3: Expected O, but got I
		//IL_0ec3: Expected O, but got I
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7c: Expected O, but got Unknown
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Expected O, but got Unknown
		//IL_0f68: Expected O, but got I4
		//IL_0fe4: Expected O, but got I
		//IL_0ff4: Expected O, but got I
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Expected O, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected O, but got Unknown
		//IL_1099: Expected O, but got I4
		//IL_1115: Expected O, but got I
		//IL_1125: Expected O, but got I
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10de: Expected O, but got Unknown
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Expected O, but got Unknown
		//IL_11ca: Expected O, but got I4
		//IL_1246: Expected O, but got I
		//IL_1256: Expected O, but got I
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Expected O, but got Unknown
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected O, but got Unknown
		//IL_12fb: Expected O, but got I4
		//IL_1377: Expected O, but got I
		//IL_1387: Expected O, but got I
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected O, but got Unknown
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected O, but got Unknown
		//IL_142c: Expected O, but got I4
		//IL_14a8: Expected O, but got I
		//IL_14b8: Expected O, but got I
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Expected O, but got Unknown
		//IL_147a: Unknown result type (might be due to invalid IL or missing references)
		//IL_147f: Expected O, but got Unknown
		//IL_155d: Expected O, but got I4
		//IL_15d9: Expected O, but got I
		//IL_15e9: Expected O, but got I
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Expected O, but got Unknown
		//IL_15ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b0: Expected O, but got Unknown
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected O, but got Unknown
		//IL_16a2: Expected O, but got I4
		//IL_171e: Expected O, but got I
		//IL_172e: Expected O, but got I
		//IL_1758: Unknown result type (might be due to invalid IL or missing references)
		//IL_175d: Expected O, but got Unknown
		//IL_16e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e7: Expected O, but got Unknown
		//IL_16f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f5: Expected O, but got Unknown
		//IL_1796: Expected O, but got I4
		//IL_17c4: Expected O, but got I4
		//IL_17ea: Expected O, but got I
		//IL_1813: Expected O, but got I
		//IL_1857: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Expected O, but got Unknown
		//IL_186c: Expected O, but got I
		//IL_1897: Expected O, but got I
		//IL_190e: Expected O, but got I8
		//IL_18bd: Expected O, but got I
		//IL_18e6: Expected O, but got I
		//IL_193c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1941: Expected O, but got Unknown
		//IL_19ef: Expected O, but got I4
		//IL_1a05: Expected O, but got I
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2a: Expected O, but got Unknown
		//IL_1996: Expected O, but got I
		//IL_19bf: Expected O, but got I
		//IL_1a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4e: Expected O, but got Unknown
		//IL_1a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6d: Expected O, but got Unknown
		//IL_1aa6: Expected O, but got I4
		//IL_1ad4: Expected O, but got I4
		//IL_1afa: Expected O, but got I
		//IL_1b23: Expected O, but got I
		//IL_1b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Expected O, but got Unknown
		//IL_1b7c: Expected O, but got I
		//IL_1ba7: Expected O, but got I
		//IL_1c1e: Expected O, but got I8
		//IL_1bcd: Expected O, but got I
		//IL_1bf6: Expected O, but got I
		//IL_1c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c51: Expected O, but got Unknown
		//IL_1cff: Expected O, but got I4
		//IL_1d15: Expected O, but got I
		//IL_1d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3a: Expected O, but got Unknown
		//IL_1ca6: Expected O, but got I
		//IL_1ccf: Expected O, but got I
		//IL_1d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5e: Expected O, but got Unknown
		//IL_1e04: Expected O, but got I8
		//IL_1db3: Expected O, but got I
		//IL_1ddc: Expected O, but got I
		//IL_1e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e37: Expected O, but got Unknown
		//IL_1e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e56: Expected O, but got Unknown
		//IL_1e8f: Expected O, but got I4
		//IL_1ebd: Expected O, but got I4
		//IL_1ed3: Expected I, but got O
		//IL_1ee3: Expected O, but got I
		//IL_1f0c: Expected O, but got I
		//IL_1f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4f: Expected O, but got Unknown
		//IL_1f5f: Expected O, but got I
		//IL_1f8a: Expected O, but got I
		//IL_1ffb: Expected O, but got I8
		//IL_1fa0: Expected I, but got O
		//IL_1fb0: Expected O, but got I
		//IL_1fd9: Expected O, but got I
		//IL_2029: Unknown result type (might be due to invalid IL or missing references)
		//IL_202e: Expected O, but got Unknown
		//IL_20d6: Expected O, but got I4
		//IL_20e6: Expected O, but got I4
		//IL_2106: Unknown result type (might be due to invalid IL or missing references)
		//IL_210b: Expected O, but got Unknown
		//IL_2073: Expected I, but got O
		//IL_2083: Expected O, but got I
		//IL_20ac: Expected O, but got I
		//IL_212a: Unknown result type (might be due to invalid IL or missing references)
		//IL_212f: Expected O, but got Unknown
		//IL_2153: Unknown result type (might be due to invalid IL or missing references)
		//IL_2158: Expected O, but got Unknown
		//IL_2189: Expected O, but got I4
		//IL_21b1: Expected O, but got I4
		//IL_21c7: Expected I, but got O
		//IL_21d7: Expected O, but got I
		//IL_2200: Expected O, but got I
		//IL_223e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2243: Expected O, but got Unknown
		//IL_22e3: Expected O, but got I8
		//IL_2288: Expected I, but got O
		//IL_2298: Expected O, but got I
		//IL_22c1: Expected O, but got I
		//IL_2311: Unknown result type (might be due to invalid IL or missing references)
		//IL_2316: Expected O, but got Unknown
		//IL_23be: Expected O, but got I4
		//IL_23ce: Expected O, but got I4
		//IL_23ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f3: Expected O, but got Unknown
		//IL_235b: Expected I, but got O
		//IL_236b: Expected O, but got I
		//IL_2394: Expected O, but got I
		//IL_2412: Unknown result type (might be due to invalid IL or missing references)
		//IL_2417: Expected O, but got Unknown
		//IL_24b7: Expected O, but got I8
		//IL_245c: Expected I, but got O
		//IL_246c: Expected O, but got I
		//IL_2495: Expected O, but got I
		//IL_24eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f0: Expected O, but got Unknown
		//IL_24fc: Expected O, but got I
		//IL_2505: Unknown result type (might be due to invalid IL or missing references)
		//IL_250a: Expected O, but got Unknown
		//IL_252e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2533: Expected O, but got Unknown
		//IL_2554: Expected I, but got O
		//IL_2562: Expected I, but got O
		//IL_2581: Expected O, but got I4
		//IL_25a0: Expected O, but got I
		//IL_25af: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b4: Expected O, but got Unknown
		//IL_25d3: Expected I, but got O
		//IL_25e8: Expected I, but got O
		//IL_262d: Expected O, but got I4
		//IL_2663: Expected I, but got O
		//IL_26a3: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 344;
		object obj3 = (nint)0 + (nint)2176;
		object obj4 = (nint)0 + (nint)24;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 32;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = obj3;
		List<object> list = default(List<object>);
		list..ctor();
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (list != null)
		{
			object obj10 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v4+30]");
			obj9 = 0;
			object obj11 = obj10;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag2 = list._size < items.Length;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj13 = list._items + list._size;
					object obj14 = obj13 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v4+30]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9+20]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v148+C0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v149+70]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v4+30]");
					list.AddWithResize((object)0);
				}
				obj9 = buttonWala;
				object obj17 = obj10;
				int version2 = list._version + 1;
				list._version = version2;
				object[] items2 = list._items;
				if (list._items != null)
				{
					bool flag3 = list._size < items2.Length;
					object obj18 = !flag3;
					if (obj18 == null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj19 = list._items + list._size;
						object obj20 = obj19 + 32;
						obj20 = buttonWala;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v11+20]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v145+C0]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v146+70]");
						nint num = 0;
						list.AddWithResize((object)buttonWala);
					}
					obj9 = buttonSun;
					object obj23 = obj10;
					int version3 = list._version + 1;
					list._version = version3;
					object[] items3 = list._items;
					if (list._items != null)
					{
						bool flag4 = list._size < items3.Length;
						object obj24 = !flag4;
						if (obj24 == null)
						{
							int size3 = list._size + 1;
							list._size = size3;
							object obj25 = list._items + list._size;
							object obj26 = obj25 + 32;
							obj26 = buttonSun;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v13+20]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v142+C0]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v143+70]");
							nint num = 0;
							list.AddWithResize((object)buttonSun);
						}
						obj9 = buttonToSun;
						object obj29 = obj10;
						int version4 = list._version + 1;
						list._version = version4;
						object[] items4 = list._items;
						if (list._items != null)
						{
							bool flag5 = list._size < items4.Length;
							object obj30 = !flag5;
							if (obj30 == null)
							{
								int size4 = list._size + 1;
								list._size = size4;
								object obj31 = list._items + list._size;
								object obj32 = obj31 + 32;
								obj32 = buttonToSun;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v15+20]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v139+C0]");
								object obj34 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v140+70]");
								nint num = 0;
								list.AddWithResize((object)buttonToSun);
							}
							obj9 = buttonBeforeToSun;
							object obj35 = obj10;
							int version5 = list._version + 1;
							list._version = version5;
							object[] items5 = list._items;
							if (list._items != null)
							{
								bool flag6 = list._size < items5.Length;
								object obj36 = !flag6;
								if (obj36 == null)
								{
									int size5 = list._size + 1;
									list._size = size5;
									object obj37 = list._items + list._size;
									object obj38 = obj37 + 32;
									obj38 = buttonBeforeToSun;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v17+20]");
									object obj39 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v136+C0]");
									object obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v137+70]");
									nint num = 0;
									list.AddWithResize((object)buttonBeforeToSun);
								}
								obj9 = buttonTriple;
								object obj41 = obj10;
								int version6 = list._version + 1;
								list._version = version6;
								object[] items6 = list._items;
								if (list._items != null)
								{
									bool flag7 = list._size < items6.Length;
									object obj42 = !flag7;
									if (obj42 == null)
									{
										int size6 = list._size + 1;
										list._size = size6;
										object obj43 = list._items + list._size;
										object obj44 = obj43 + 32;
										obj44 = buttonTriple;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v19+20]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v133+C0]");
										object obj46 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v134+70]");
										nint num = 0;
										list.AddWithResize((object)buttonTriple);
									}
									obj9 = buttonQahwa;
									object obj47 = obj10;
									int version7 = list._version + 1;
									list._version = version7;
									object[] items7 = list._items;
									if (list._items != null)
									{
										bool flag8 = list._size < items7.Length;
										object obj48 = !flag8;
										if (obj48 == null)
										{
											int size7 = list._size + 1;
											list._size = size7;
											object obj49 = list._items + list._size;
											object obj50 = obj49 + 32;
											obj50 = buttonQahwa;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v21+20]");
											object obj51 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v130+C0]");
											object obj52 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v131+70]");
											nint num = 0;
											list.AddWithResize((object)buttonQahwa);
										}
										obj9 = buttonHokom;
										object obj53 = obj10;
										int version8 = list._version + 1;
										list._version = version8;
										object[] items8 = list._items;
										if (list._items != null)
										{
											bool flag9 = list._size < items8.Length;
											object obj54 = !flag9;
											if (obj54 == null)
											{
												int size8 = list._size + 1;
												list._size = size8;
												object obj55 = list._items + list._size;
												object obj56 = obj55 + 32;
												obj56 = buttonHokom;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v23+20]");
												object obj57 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v127+C0]");
												object obj58 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v128+70]");
												nint num = 0;
												list.AddWithResize((object)buttonHokom);
											}
											obj9 = buttonHokomClose;
											object obj59 = obj10;
											int version9 = list._version + 1;
											list._version = version9;
											object[] items9 = list._items;
											if (list._items != null)
											{
												bool flag10 = list._size < items9.Length;
												object obj60 = !flag10;
												if (obj60 == null)
												{
													int size9 = list._size + 1;
													list._size = size9;
													object obj61 = list._items + list._size;
													object obj62 = obj61 + 32;
													obj62 = buttonHokomClose;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v25+20]");
													object obj63 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v124+C0]");
													object obj64 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v125+70]");
													nint num = 0;
													list.AddWithResize((object)buttonHokomClose);
												}
												obj9 = buttonHokom2;
												object obj65 = obj10;
												int version10 = list._version + 1;
												list._version = version10;
												object[] items10 = list._items;
												if (list._items != null)
												{
													bool flag11 = list._size < items10.Length;
													object obj66 = !flag11;
													if (obj66 == null)
													{
														int size10 = list._size + 1;
														list._size = size10;
														object obj67 = list._items + list._size;
														object obj68 = obj67 + 32;
														obj68 = buttonHokom2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v27+20]");
														object obj69 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v121+C0]");
														object obj70 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X8_v122+70]");
														nint num = 0;
														list.AddWithResize((object)buttonHokom2);
													}
													obj9 = buttonDouble;
													object obj71 = obj10;
													int version11 = list._version + 1;
													list._version = version11;
													object[] items11 = list._items;
													if (list._items != null)
													{
														bool flag12 = list._size < items11.Length;
														object obj72 = !flag12;
														if (obj72 == null)
														{
															int size11 = list._size + 1;
															list._size = size11;
															object obj73 = list._items + list._size;
															object obj74 = obj73 + 32;
															obj74 = buttonDouble;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v29+20]");
															object obj75 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v118+C0]");
															object obj76 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v119+70]");
															nint num = 0;
															list.AddWithResize((object)buttonDouble);
														}
														obj9 = buttonFour;
														object obj77 = obj10;
														int version12 = list._version + 1;
														list._version = version12;
														object[] items12 = list._items;
														if (list._items != null)
														{
															bool flag13 = list._size < items12.Length;
															object obj78 = !flag13;
															if (obj78 == null)
															{
																int size12 = list._size + 1;
																list._size = size12;
																object obj79 = list._items + list._size;
																object obj80 = obj79 + 32;
																obj80 = buttonFour;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v31+20]");
																object obj81 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v115+C0]");
																object obj82 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v116+70]");
																nint num = 0;
																list.AddWithResize((object)buttonFour);
															}
															obj9 = buttonAshkal;
															object obj83 = obj10;
															int version13 = list._version + 1;
															list._version = version13;
															object[] items13 = list._items;
															if (list._items != null)
															{
																bool flag14 = list._size < items13.Length;
																object obj84 = !flag14;
																if (obj84 == null)
																{
																	int size13 = list._size + 1;
																	list._size = size13;
																	object obj85 = list._items + list._size;
																	object obj86 = obj85 + 32;
																	obj86 = buttonAshkal;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v33+20]");
																	object obj87 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v112+C0]");
																	object obj88 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v113+70]");
																	nint num = 0;
																	list.AddWithResize((object)buttonAshkal);
																}
																obj9 = buttonConfirmHokom;
																object obj89 = obj10;
																int version14 = list._version + 1;
																list._version = version14;
																object[] items14 = list._items;
																if (list._items != null)
																{
																	bool flag15 = list._size < items14.Length;
																	object obj90 = !flag15;
																	if (obj90 == null)
																	{
																		int size14 = list._size + 1;
																		list._size = size14;
																		object obj91 = list._items + list._size;
																		object obj92 = obj91 + 32;
																		obj92 = buttonConfirmHokom;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v35+20]");
																		object obj93 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X8_v109+C0]");
																		object obj94 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v110+70]");
																		nint num = 0;
																		list.AddWithResize((object)buttonConfirmHokom);
																	}
																	obj9 = buttonHokomOpen;
																	object obj95 = obj10;
																	int version15 = list._version + 1;
																	list._version = version15;
																	object[] items15 = list._items;
																	if (list._items != null)
																	{
																		bool flag16 = list._size < items15.Length;
																		object obj96 = !flag16;
																		if (obj96 == null)
																		{
																			int size15 = list._size + 1;
																			list._size = size15;
																			object obj97 = list._items + list._size;
																			object obj98 = obj97 + 32;
																			obj98 = buttonHokomOpen;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v37+20]");
																			object obj99 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v106+C0]");
																			object obj100 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X8_v107+70]");
																			nint num = 0;
																			list.AddWithResize((object)buttonHokomOpen);
																		}
																		obj9 = buttonHokomClubs;
																		object obj101 = obj10;
																		int version16 = list._version + 1;
																		list._version = version16;
																		object[] items16 = list._items;
																		if (list._items != null)
																		{
																			bool flag17 = list._size < items16.Length;
																			object obj102 = !flag17;
																			if (obj102 == null)
																			{
																				int size16 = list._size + 1;
																				list._size = size16;
																				object obj103 = list._items + list._size;
																				object obj104 = obj103 + 32;
																				obj104 = buttonHokomClubs;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v39+20]");
																				object obj105 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v103+C0]");
																				object obj106 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v104+70]");
																				nint num = 0;
																				list.AddWithResize((object)buttonHokomClubs);
																			}
																			obj9 = buttonHokomDiamonds;
																			object obj107 = obj10;
																			int version17 = list._version + 1;
																			list._version = version17;
																			object[] items17 = list._items;
																			if (list._items != null)
																			{
																				bool flag18 = list._size < items17.Length;
																				object obj108 = !flag18;
																				if (obj108 == null)
																				{
																					int size17 = list._size + 1;
																					list._size = size17;
																					object obj109 = list._items + list._size;
																					object obj110 = obj109 + 32;
																					obj110 = buttonHokomDiamonds;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v41+20]");
																					object obj111 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v100+C0]");
																					object obj112 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X8_v101+70]");
																					nint num = 0;
																					list.AddWithResize((object)buttonHokomDiamonds);
																				}
																				obj9 = buttonHokomSpades;
																				object obj113 = obj10;
																				int version18 = list._version + 1;
																				list._version = version18;
																				object[] items18 = list._items;
																				if (list._items != null)
																				{
																					bool flag19 = list._size < items18.Length;
																					object obj114 = !flag19;
																					if (obj114 == null)
																					{
																						int size18 = list._size + 1;
																						list._size = size18;
																						object obj115 = list._items + list._size;
																						object obj116 = obj115 + 32;
																						obj116 = buttonHokomSpades;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v43+20]");
																						object obj117 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X8_v97+C0]");
																						object obj118 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v98+70]");
																						nint num = 0;
																						list.AddWithResize((object)buttonHokomSpades);
																					}
																					obj9 = buttonHokomHearts;
																					object obj119 = obj10;
																					int version19 = list._version + 1;
																					list._version = version19;
																					object[] items19 = list._items;
																					if (list._items != null)
																					{
																						object obj120 = typeof(TypeConverter<ushort, char>) + 1840;
																						bool flag20 = list._size < items19.Length;
																						object obj121 = !flag20;
																						if (obj121 == null)
																						{
																							int size19 = list._size + 1;
																							list._size = size19;
																							object obj122 = list._items + list._size;
																							object obj123 = obj122 + 32;
																							obj123 = buttonHokomHearts;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v45+20]");
																							object obj124 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v94+C0]");
																							object obj125 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v95+70]");
																							nint num = 0;
																							list.AddWithResize((object)buttonHokomHearts);
																						}
																						object obj126 = this + 56;
																						obj126 = list;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																						object obj127 = default(object);
																						bool flag21 = obj127 == null;
																						obj9 = 3;
																						if (!flag21)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X21_v9+48]");
																							bool flag22 = (nint)0 == 0;
																							object obj128 = 3;
																							if (!flag22)
																							{
																								object obj129 = obj127;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v93+40]");
																								obj128 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																								bool flag23 = ex == null;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v93+40]");
																								obj9 = 0;
																								if (flag23)
																								{
																									goto IL_26e2;
																								}
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v40+18]");
																							bool flag24 = (nint)0 == 0;
																							obj9 = obj128;
																							if (!flag24)
																							{
																								object obj130 = obj127 + 32;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X21_v9+48]");
																								obj130 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																								bool flag25 = (object)buttonHokom == null;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X21_v9+48]");
																								object obj131 = 0;
																								if (!flag25)
																								{
																									object obj132 = obj127;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v92+40]");
																									obj131 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																									bool flag26 = ex == null;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v92+40]");
																									obj9 = 0;
																									if (flag26)
																									{
																										goto IL_26e2;
																									}
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v40+18]");
																								object obj133 = 0 & 0xFFFFFFFEL;
																								bool flag27 = obj133 == null;
																								obj9 = obj131;
																								if (!flag27)
																								{
																									object obj134 = obj127 + 40;
																									obj134 = buttonHokom;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																									bool flag28 = (object)buttonPass == null;
																									object obj135 = buttonHokom;
																									if (!flag28)
																									{
																										object obj136 = obj127;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v91+40]");
																										obj135 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag29 = ex == null;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v91+40]");
																										obj9 = 0;
																										if (flag29)
																										{
																											goto IL_26e2;
																										}
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v40+18]");
																									bool flag30 = (nint)0 < (nint)2;
																									object obj137 = !flag30;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v40+18]");
																									object obj138 = -2;
																									bool flag31 = obj138 == null;
																									object obj139 = ~obj137;
																									object obj140 = obj139 | flag31;
																									obj9 = obj135;
																									if (obj140 == null)
																									{
																										object obj141 = obj127 + 48;
																										obj141 = buttonPass;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																										object obj142 = this + 240;
																										obj142 = obj127;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																										object obj143 = default(object);
																										bool flag32 = obj143 == null;
																										obj9 = 4;
																										if (flag32)
																										{
																											goto IL_26c6;
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X21_v14-70]");
																										bool flag33 = (nint)0 == 0;
																										object obj144 = 4;
																										if (!flag33)
																										{
																											object obj145 = obj143;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v90+40]");
																											obj144 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																											bool flag34 = ex == null;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v90+40]");
																											obj9 = 0;
																											if (flag34)
																											{
																												goto IL_26e2;
																											}
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v56+18]");
																										bool flag35 = (nint)0 == 0;
																										obj9 = obj144;
																										if (!flag35)
																										{
																											object obj146 = obj143 + 32;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X21_v14-70]");
																											obj146 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																											bool flag36 = (object)buttonHokom == null;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X21_v14-70]");
																											object obj147 = 0;
																											if (!flag36)
																											{
																												object obj148 = obj143;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v89+40]");
																												obj147 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																												bool flag37 = ex == null;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v89+40]");
																												obj9 = 0;
																												if (flag37)
																												{
																													goto IL_26e2;
																												}
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v56+18]");
																											object obj149 = 0 & 0xFFFFFFFEL;
																											bool flag38 = obj149 == null;
																											obj9 = obj147;
																											if (!flag38)
																											{
																												object obj150 = obj143 + 40;
																												obj150 = buttonHokom;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																												bool flag39 = (object)buttonAshkal == null;
																												object obj151 = buttonHokom;
																												if (!flag39)
																												{
																													object obj152 = obj143;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v88+40]");
																													obj151 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																													bool flag40 = ex == null;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v88+40]");
																													obj9 = 0;
																													if (flag40)
																													{
																														goto IL_26e2;
																													}
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v56+18]");
																												bool flag41 = (nint)0 < (nint)2;
																												object obj153 = !flag41;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v56+18]");
																												object obj154 = -2;
																												bool flag42 = obj154 == null;
																												object obj155 = ~obj153;
																												object obj156 = obj155 | flag42;
																												obj9 = obj151;
																												if (obj156 == null)
																												{
																													object obj157 = obj143 + 48;
																													obj157 = buttonAshkal;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																													bool flag43 = (object)buttonPass == null;
																													object obj158 = buttonAshkal;
																													if (!flag43)
																													{
																														object obj159 = obj143;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v87+40]");
																														obj158 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																														bool flag44 = ex == null;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v87+40]");
																														obj9 = 0;
																														if (flag44)
																														{
																															goto IL_26e2;
																														}
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v56+18]");
																													object obj160 = 0 & 0xFFFFFFFCL;
																													bool flag45 = obj160 == null;
																													obj9 = obj158;
																													if (!flag45)
																													{
																														object obj161 = obj143 + 56;
																														obj161 = buttonPass;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																														object obj162 = this + 248;
																														obj162 = obj143;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																														Button[] array = default(Button[]);
																														bool flag46 = array == null;
																														obj9 = 3;
																														if (flag46)
																														{
																															goto IL_26c6;
																														}
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X21_v20-78]");
																														bool flag47 = (nint)0 == 0;
																														object obj163 = 3;
																														if (!flag47)
																														{
																															nint num2 = (nint)array;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v86 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																															obj163 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																															bool flag48 = ex == null;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v86 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																															obj9 = 0;
																															if (flag48)
																															{
																																goto IL_26e2;
																															}
																														}
																														bool flag49 = array.Length == 0;
																														obj9 = obj163;
																														if (!flag49)
																														{
																															object obj164 = array + 32;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X21_v20-78]");
																															obj164 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																															bool flag50 = (object)buttonHokom2 == null;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X21_v20-78]");
																															object obj165 = 0;
																															if (!flag50)
																															{
																																nint num3 = (nint)array;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v85 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																obj165 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																bool flag51 = ex == null;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v85 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																obj9 = 0;
																																if (flag51)
																																{
																																	goto IL_26e2;
																																}
																															}
																															object obj166 = array.Length & 0xFFFFFFFEL;
																															bool flag52 = obj166 == null;
																															obj9 = obj165;
																															if (!flag52)
																															{
																																object obj167 = array + 40;
																																obj167 = buttonHokom2;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																bool flag53 = (object)buttonWala == null;
																																object obj168 = buttonHokom2;
																																if (!flag53)
																																{
																																	nint num4 = (nint)array;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v84 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																	obj168 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																	bool flag54 = ex == null;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v84 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																	obj9 = 0;
																																	if (flag54)
																																	{
																																		goto IL_26e2;
																																	}
																																}
																																bool flag55 = array.Length < 2;
																																object obj169 = !flag55;
																																object obj170 = array.Length - 2;
																																bool flag56 = obj170 == null;
																																object obj171 = ~obj169;
																																object obj172 = obj171 | flag56;
																																obj9 = obj168;
																																if (obj172 == null)
																																{
																																	object obj173 = array + 48;
																																	obj173 = buttonWala;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	round2DefaultState1 = array;
																																	object obj174 = this + 256;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																																	Button[] array2 = default(Button[]);
																																	bool flag57 = array2 == null;
																																	obj9 = 4;
																																	if (flag57)
																																	{
																																		goto IL_26c6;
																																	}
																																	bool flag58 = (object)buttonSun == null;
																																	object obj175 = 4;
																																	if (!flag58)
																																	{
																																		nint num5 = (nint)array2;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v83 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																		obj175 = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																		bool flag59 = ex == null;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v83 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																		obj9 = 0;
																																		if (flag59)
																																		{
																																			goto IL_26e2;
																																		}
																																	}
																																	bool flag60 = array2.Length == 0;
																																	obj9 = obj175;
																																	if (!flag60)
																																	{
																																		object obj176 = array2 + 32;
																																		obj176 = buttonSun;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																		bool flag61 = (object)buttonHokom2 == null;
																																		object obj177 = buttonSun;
																																		if (!flag61)
																																		{
																																			nint num6 = (nint)array2;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v82 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																			obj177 = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																			bool flag62 = ex == null;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v82 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																			obj9 = 0;
																																			if (flag62)
																																			{
																																				goto IL_26e2;
																																			}
																																		}
																																		object obj178 = array2.Length & 0xFFFFFFFEL;
																																		bool flag63 = obj178 == null;
																																		obj9 = obj177;
																																		if (!flag63)
																																		{
																																			object obj179 = array2 + 40;
																																			obj179 = buttonHokom2;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																			bool flag64 = (object)buttonAshkal == null;
																																			object obj180 = buttonHokom2;
																																			if (!flag64)
																																			{
																																				nint num7 = (nint)array2;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v81 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																				obj180 = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																				bool flag65 = ex == null;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v81 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																				obj9 = 0;
																																				if (flag65)
																																				{
																																					goto IL_26e2;
																																				}
																																			}
																																			bool flag66 = array2.Length < 2;
																																			object obj181 = !flag66;
																																			object obj182 = array2.Length - 2;
																																			bool flag67 = obj182 == null;
																																			object obj183 = ~obj181;
																																			object obj184 = obj183 | flag67;
																																			obj9 = obj180;
																																			if (obj184 == null)
																																			{
																																				object obj185 = array2 + 48;
																																				obj185 = buttonAshkal;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																				bool flag68 = (object)buttonWala == null;
																																				object obj186 = buttonAshkal;
																																				if (!flag68)
																																				{
																																					nint num8 = (nint)array2;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v80 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																					obj186 = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																					bool flag69 = ex == null;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v80 (Il2CppClass<UnityEngine.UI.Button[]>)+40]");
																																					obj9 = 0;
																																					if (flag69)
																																					{
																																						goto IL_26e2;
																																					}
																																				}
																																				object obj187 = array2.Length & 0xFFFFFFFCL;
																																				bool flag70 = obj187 == null;
																																				obj9 = obj186;
																																				if (!flag70)
																																				{
																																					object obj188 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
																																					object obj189 = (nint)0 + (nint)2224;
																																					object obj190 = array2 + 56;
																																					obj190 = buttonWala;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																					round2DefaultState2 = array2;
																																					object obj191 = this + 264;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																					nint num = (nint)obj189;
																																					Action<object> action = default(Action<object>);
																																					action..ctor((object)this, (IntPtr)obj189);
																																					bool flag71 = allButtons == null;
																																					object obj192 = 0;
																																					obj9 = this;
																																					if (!flag71)
																																					{
																																						object obj193 = (nint)0 + (nint)2216;
																																						object obj194 = typeof(SqlSingle[]) + 2376;
																																						((List<object>)(object)allButtons).ForEach(action);
																																						FillBiddingButtonsDictionary();
																																						nint num9 = (nint)this;
																																						ShowPredetermineBid();
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																						nint num10 = (nint)this;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v78 (Il2CppClass<BalootBiddingButtons>)+190]");
																																						num = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v78 (Il2CppClass<BalootBiddingButtons>)+190]");
																																						Action action2 = default(Action);
																																						action2..ctor(this, (IntPtr)0);
																																						bool flag72 = (object)game == null;
																																						obj192 = 0;
																																						obj9 = this;
																																						if (!flag72)
																																						{
																																							game.OnGameStateUpdated += action2;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																							nint num11 = (nint)this;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v79 (Il2CppClass<BalootBiddingButtons>)+1A0]");
																																							num = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v79 (Il2CppClass<BalootBiddingButtons>)+1A0]");
																																							Action action3 = default(Action);
																																							action3..ctor(this, (IntPtr)0);
																																							bool flag73 = (object)game == null;
																																							obj192 = 0;
																																							obj9 = this;
																																							if (!flag73)
																																							{
																																								game.OnRoundStart += action3;
																																								return;
																																							}
																																						}
																																					}
																																					goto IL_26c6;
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
																								}
																							}
																							goto IL_26d4;
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
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_26c6;
		IL_26c6:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_26d4;
		IL_26d4:
		ex = new IndexOutOfRangeException();
		goto IL_26e2;
		IL_26e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	protected override void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003b: Expected I, but got O
		//IL_007a: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)1952;
		nint num = (nint)this;
		HideContainer();
		isBidder = false;
		isNaturalFlowDisturbedThisRound = false;
		state = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		((List<object>)(object)allButtons).ForEach(action);
	}

	protected override void HideContainer()
	{
		//IL_000c: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		object obj = (nint)0 + (nint)2872;
		object obj2 = this + 64;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateStateButtons();
		int num = ShortcutExtensions.DOKill(biddingBar);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(biddingBar, 0f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		wasBiddingPredeterminationActive = false;
	}

	protected override Button[] getStateButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0277: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ff: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_0089: Expected O, but got I
		//IL_00b2: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0199: Expected O, but got I8
		//IL_0138: Expected I, but got O
		//IL_0148: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable2;
		IEnumerable<object> result;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		IEnumerable<object> enumerable3;
		if (substate == 1001)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			IEnumerable<object> enumerable = default(IEnumerable<object>);
			bool flag = enumerable == null;
			enumerable2 = (IEnumerable<object>)2;
			if (!flag)
			{
				bool flag2 = (object)buttonHokomOpen == null;
				enumerable2 = (IEnumerable<object>)2;
				if (!flag2)
				{
					nint num = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					enumerable2 = (IEnumerable<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					enumerable3 = (IEnumerable<object>)0;
					if (flag3)
					{
						goto IL_038b;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v22 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				if ((nint)0 != 0)
				{
					object obj2 = enumerable + 32;
					obj2 = buttonHokomOpen;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag4 = (object)buttonHokomClose == null;
					enumerable2 = (IEnumerable<object>)buttonHokomOpen;
					if (!flag4)
					{
						nint num2 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						enumerable2 = (IEnumerable<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						enumerable3 = (IEnumerable<object>)0;
						if (flag5)
						{
							goto IL_038b;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v22 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object obj3 = 0 & 0xFFFFFFFEL;
					if (obj3 != null)
					{
						object obj4 = enumerable + 40;
						obj4 = buttonHokomClose;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						result = enumerable;
						goto IL_0362;
					}
				}
				goto IL_0375;
			}
		}
		else
		{
			object obj5 = state - 1;
			bool flag6 = (nint)obj5 < 53;
			object obj6 = !flag6;
			object obj7 = obj5 - 53;
			bool flag7 = obj7 == null;
			object obj8 = !flag7;
			object obj9 = obj6 & obj8;
			if (obj9 == null)
			{
				object obj10 = 119873536 + 3056;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v2+v70 @ X8_v9*2]");
				object obj11 = (nint)83366848 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X10_v2 (should have been resolved before IL gen)");
			}
			bool flag8 = (object)game == null;
			enumerable2 = null;
			if (!flag8)
			{
				bool isFastTrackGame = game.IsFastTrackGame;
				bool flag9 = !isFastTrackGame;
				IEnumerable<object> enumerable4 = default(IEnumerable<object>);
				result = enumerable4;
				if (flag9)
				{
					goto IL_0362;
				}
				object obj12 = typeof(List<AdaptivePerformanceScaler>) + 344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)2184;
				List<object> list = default(List<object>);
				list..ctor(enumerable4);
				bool flag10 = list == null;
				enumerable2 = enumerable4;
				if (!flag10)
				{
					bool flag11 = list.Remove(buttonDouble);
					return (Button[])list.ToArray();
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0375;
		IL_0362:
		return (Button[])result;
		IL_0375:
		ex = new IndexOutOfRangeException();
		enumerable3 = enumerable2;
		goto IL_038b;
		IL_038b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (Button[])(object)new OutOfMemoryException();
	}

	protected override void ShowPredetermineBid()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_034d: Expected I, but got O
		//IL_035d: Expected O, but got I
		//IL_036d: Expected O, but got I
		//IL_0272: Expected O, but got I4
		//IL_0386: Expected I, but got O
		//IL_0396: Expected O, but got I
		//IL_03a6: Expected O, but got I
		//IL_02df: Expected O, but got I4
		//IL_02fc: Expected I, but got O
		//IL_030c: Expected O, but got I
		//IL_031c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6642]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v22+E4]");
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
			obj5 = game;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = game;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0156;
		IL_0377:
		bool flag5 = isAshkalAvailable;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v3 (Il2CppClass<BalootBiddingButtons>)+1D8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v3 (Il2CppClass<BalootBiddingButtons>)+1E0]");
		object obj10 = 0;
		if (flag5)
		{
			Button[] array = round2DefaultState2;
		}
		else
		{
			Button[] array = round2DefaultState1;
		}
		goto IL_03f0;
		IL_03f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v245 @ X8_v13 (should have been resolved before IL gen)");
		wasBiddingPredeterminationActive = true;
		return;
		IL_0156:
		if (!base.allowBiddingPredetermination)
		{
			return;
		}
		CardGame cardGame = game;
		if (!cardGame.<Stage>k__BackingField.IsBidding)
		{
			return;
		}
		CardGame cardGame2 = game;
		if (!Enumerable.Any(cardGame2.<Bidders>k__BackingField))
		{
			return;
		}
		bool isSpectator = game.IsSpectator;
		bool flag6 = !isSpectator;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		UpdateStateButtons();
		if (isNaturalFlowDisturbedThisRound)
		{
			wasBiddingPredeterminationActive = false;
			bool flag7 = !isBidder;
			object obj12 = !flag7;
			if (obj12 != null)
			{
				return;
			}
		}
		else if (biddingState != BiddingState.Finished)
		{
			if (biddingState == BiddingState.SecondRound)
			{
				goto IL_0377;
			}
			bool flag8 = biddingState == BiddingState.FirstRound;
			object obj13 = !flag8;
			if (obj13 != null)
			{
				return;
			}
			bool flag9 = isAshkalAvailable;
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X9_v4 (Il2CppClass<BalootBiddingButtons>)+1D8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X9_v4 (Il2CppClass<BalootBiddingButtons>)+1E0]");
			obj10 = 0;
			if (flag9)
			{
				Button[] array = round1DefaultState2;
			}
			else
			{
				Button[] array = round1DefaultState1;
			}
			goto IL_03f0;
		}
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11 (Il2CppClass<BalootBiddingButtons>)+1A8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11 (Il2CppClass<BalootBiddingButtons>)+1B0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v165 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_0377;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0156;
	}

	protected override void ShowBid(Button[] newStateButtons)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0413: Expected O, but got I
		//IL_0424: Expected I, but got O
		//IL_0442: Expected O, but got I
		//IL_036d: Expected I, but got O
		//IL_037d: Expected O, but got I
		//IL_038d: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0147: Expected O, but got I
		//IL_02c4: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		//IL_0236: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_024c: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0490: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2544;
		object obj2 = this + 232;
		Button[] array = default(Button[]);
		obj2 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v32+E4]");
		object obj4;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v32+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v24+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v24+8]");
			if ((nint)0 != 0)
			{
				goto IL_005e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v32+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v24+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v24+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_005e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v32+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v30+B8]");
			obj4 = 0;
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)632;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj9);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v29+B8]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = 0;
		action = action2;
		goto IL_0162;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v3-B0]");
		((List<object>)0).ForEach(action);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X21_v4+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X21_v4+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_02b8;
			}
			object obj14 = obj13 + 32;
			object obj15 = 0;
			while (true)
			{
				if (isMitigatingMissClicks)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X23_v7+v176 @ X22_v8*8]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X23_v7+v176 @ X22_v8*8]");
					((Selectable)0).interactable = true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X23_v7+v176 @ X22_v8*8]");
				Transform transform = ((Component)0).transform;
				transform.SetAsLastSibling();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X23_v7+v176 @ X22_v8*8]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: true);
				obj15++;
				object obj17 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X21_v4+18]");
				if ((nint)obj17 < 0)
				{
					continue;
				}
				goto IL_02b8;
			}
			goto IL_0398;
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9 (Il2CppClass<BalootBiddingButtons>)+1A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9 (Il2CppClass<BalootBiddingButtons>)+1B0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v239 @ X2_v4 (should have been resolved before IL gen)");
		return;
		IL_005e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X20_v3-B0]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 != null)
		{
			goto IL_0162;
		}
		goto IL_0398;
		IL_0398:
		throw new NullReferenceException();
		IL_02b8:
		object obj21 = (nint)0 + (nint)2872;
		UpdateStateButtons();
		int num2 = ShortcutExtensions.DOKill(biddingBar);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(biddingBar, 325f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		if (game.IsTutorial)
		{
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v16+B8]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+30]");
			HandleBiddingButtons((BalootBidingButtonEnum)0);
		}
	}

	protected override void UpdateShowBid()
	{
		//IL_019c: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00df: Expected O, but got I4
		//IL_0584: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03fe: Expected O, but got I4
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_037d: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02b0: Expected O, but got I4
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_0550: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		CardGamePlayer myPlayer = game.MyPlayer;
		CardGamePlayer myPlayer2 = game.MyPlayer;
		bool flag = myPlayer2.IsBidder;
		isBidder = flag;
		CardGameLastActionInfo lastAction = game.LastAction;
		int num;
		int num2;
		if (isDefaultBidString(lastAction.<BidType>k__BackingField))
		{
			object obj = myPlayer.<BiddingState>k__BackingField + 1;
			bool flag2 = (nint)obj < 14;
			object obj2 = !flag2;
			object obj3 = obj - 14;
			bool flag3 = obj3 == null;
			object obj4 = !flag3;
			object obj5 = obj2 & obj4;
			if (obj5 == null)
			{
				object obj6 = 1 << (int)obj;
				object obj7 = obj6 & 0x601F;
				if (obj7 != null)
				{
					num = state;
					if (!isBidder)
					{
						goto IL_01b4;
					}
					num2 = state;
					goto IL_01dd;
				}
			}
		}
		isNaturalFlowDisturbedThisRound = true;
		num = state;
		bool flag4 = !isBidder;
		object obj8 = !flag4;
		num2 = state;
		if (obj8 == null)
		{
			goto IL_01b4;
		}
		goto IL_01dd;
		IL_0483:
		if (state != 3)
		{
			string newStateButtons = (string)(object)getStateButtons();
			ShowBid((Button[])(object)newStateButtons);
		}
		goto IL_0568;
		IL_0453:
		if (!isBidder)
		{
			goto IL_0483;
		}
		SubmitPredetermineBid();
		goto IL_0568;
		IL_041b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		if (obj9 != null)
		{
			goto IL_0453;
		}
		goto IL_0483;
		IL_0568:
		bool flag5 = !isBidder;
		object obj10 = !flag5;
		if (obj10 == null && base.allowBiddingPredetermination)
		{
			ShowPredetermineBid();
		}
		CardGameLastActionInfo lastAction2 = game.LastAction;
		object obj11 = "utf-32" + 1160;
		if (lastAction2.<BidType>k__BackingField == (string)obj11)
		{
			object obj12 = this + 64;
			obj12 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		return;
		IL_01b4:
		bool flag6 = myPlayer.<BiddingState>k__BackingField == num;
		num2 = num;
		if (!flag6)
		{
			goto IL_01dd;
		}
		goto IL_0568;
		IL_0359:
		UnityEngine.Object obj13;
		bool flag7 = obj13 != null;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			goto IL_0453;
		}
		goto IL_0483;
		IL_01dd:
		if (myPlayer.<BiddingState>k__BackingField != num2)
		{
			substate = 0;
		}
		state = myPlayer.<BiddingState>k__BackingField;
		MitigateMissClicks();
		CardGameLastActionInfo lastAction3 = game.LastAction;
		string <BidType>k__BackingField = lastAction3.<BidType>k__BackingField;
		object obj23;
		if (isDefaultBidString(lastAction3.<BidType>k__BackingField))
		{
			object obj15 = myPlayer.<BiddingState>k__BackingField + 1;
			bool flag9 = (nint)obj15 < 14;
			object obj16 = !flag9;
			object obj17 = obj15 - 14;
			bool flag10 = obj17 == null;
			object obj18 = !flag10;
			object obj19 = obj16 & obj18;
			if (obj19 == null)
			{
				object obj20 = 1 << (int)obj15;
				object obj21 = obj20 & 0x601F;
				if (obj21 != null)
				{
					obj13 = preDeterminedChoice;
					object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
					obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v20+E4]");
					bool flag11 = (nint)0 == 0;
					obj9 = preDeterminedChoice;
					if (!flag11)
					{
						goto IL_0359;
					}
					goto IL_041b;
				}
			}
		}
		object obj24 = this + 64;
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		obj13 = preDeterminedChoice;
		object obj25 = typeof(MemberAchievementClanFeedData) + 2976;
		obj23 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj26 = !flag12;
		<BidType>k__BackingField = null;
		obj9 = preDeterminedChoice;
		if (obj26 != null)
		{
			goto IL_0359;
		}
		goto IL_041b;
	}

	protected override void UpdateHideBid()
	{
		HideContainer();
		biddingState = BiddingState.FirstRound;
		isNaturalFlowDisturbedThisRound = false;
	}

	protected override void SubmitPredetermineBid()
	{
		//IL_000c: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0060: Expected I, but got O
		//IL_0070: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_0020: Expected I, but got O
		//IL_0030: Expected O, but got I
		//IL_0040: Expected O, but got I
		object obj = (nint)0 + (nint)3176;
		while (true)
		{
			IEnumerable<object> source = getStateButtons();
			object value = this + 64;
			if (Enumerable.Contains(source, value))
			{
				Button button = preDeterminedChoice;
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<BalootBiddingButtons>)+228]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<BalootBiddingButtons>)+230]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X3_v1 (should have been resolved before IL gen)");
			}
			preDeterminedChoice = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4 (Il2CppClass<BalootBiddingButtons>)+238]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4 (Il2CppClass<BalootBiddingButtons>)+240]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v74 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	protected override void PredetermineBid(Button button)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_00c8: Expected I, but got O
		//IL_00d8: Expected O, but got I
		//IL_00e8: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 64;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Button button2 = default(Button);
		bool flag2 = button2 == (UnityEngine.Object)obj2;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
		}
		preDeterminedChoice = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<BalootBiddingButtons>)+238]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<BalootBiddingButtons>)+240]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v79 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void SubmitBid(Button button)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_117b: Expected O, but got I4
		//IL_11ae: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0136: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected O, but got Unknown
		//IL_1214: Expected O, but got I4
		//IL_1226: Expected O, but got I4
		//IL_122f: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0a26: Expected O, but got I
		//IL_0a36: Expected O, but got I
		//IL_0a46: Expected O, but got I
		//IL_0a68: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_020e: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_0ab8: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Expected O, but got Unknown
		//IL_12a3: Expected O, but got I
		//IL_12b4: Expected I, but got O
		//IL_12d2: Expected O, but got I
		//IL_12ed: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected I4, but got Unknown
		//IL_0ae8: Expected O, but got I
		//IL_03e6: Expected O, but got I4
		//IL_03ef: Expected O, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected I4, but got Unknown
		//IL_0345: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_0bf0: Expected O, but got I4
		//IL_0c03: Expected O, but got I4
		//IL_0b8b: Expected O, but got I4
		//IL_0b94: Expected O, but got I4
		//IL_04b9: Expected I, but got O
		//IL_04c9: Expected O, but got I
		//IL_04d9: Expected O, but got I
		//IL_134c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Expected O, but got Unknown
		//IL_135a: Expected O, but got I4
		//IL_137a: Expected I, but got O
		//IL_1394: Expected O, but got I4
		//IL_050d: Expected O, but got I4
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_0cab: Expected O, but got I4
		//IL_0bb5: Expected O, but got I4
		//IL_13b6: Expected O, but got I4
		//IL_0c9d: Expected O, but got I4
		//IL_0d14: Expected O, but got I4
		//IL_0d1d: Expected O, but got I4
		//IL_0c65: Expected O, but got I4
		//IL_0c6e: Expected O, but got I4
		//IL_05a8: Expected O, but got I4
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_0cc7: Expected O, but got I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_0cb9: Expected O, but got I4
		//IL_0d34: Expected O, but got I4
		//IL_062f: Expected O, but got I4
		//IL_0675: Expected O, but got I4
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_06ad: Expected O, but got I4
		//IL_06f3: Expected O, but got I4
		//IL_072b: Expected O, but got I4
		//IL_0771: Expected O, but got I4
		//IL_07a9: Expected O, but got I4
		//IL_0830: Expected O, but got I4
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_08e4: Expected O, but got I4
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_08a3: Expected O, but got I4
		//IL_08b5: Expected O, but got I4
		//IL_0d63: Expected O, but got I4
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_0957: Expected O, but got I4
		//IL_0969: Expected O, but got I4
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f0: Expected O, but got Unknown
		//IL_1411: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Expected O, but got Unknown
		//IL_0e17: Expected O, but got I4
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_09b6: Expected O, but got I4
		//IL_09bf: Expected O, but got I4
		//IL_09c7: Expected I4, but got O
		//IL_09d0: Expected O, but got I4
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected O, but got Unknown
		//IL_0dd6: Expected O, but got I4
		//IL_0ddf: Expected O, but got I4
		//IL_0ecb: Expected O, but got I4
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6f: Expected O, but got Unknown
		//IL_0e8a: Expected O, but got I4
		//IL_0e93: Expected O, but got I4
		//IL_0f52: Expected O, but got I4
		//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f23: Expected O, but got Unknown
		//IL_0fd9: Expected O, but got I4
		//IL_101f: Expected O, but got I4
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected O, but got Unknown
		//IL_1057: Expected O, but got I4
		//IL_109d: Expected O, but got I4
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Expected O, but got Unknown
		//IL_10de: Expected O, but got I4
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Expected O, but got Unknown
		//IL_1136: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		bool flag = state < 26;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = "startPosition" + 1360;
		if (button == buttonSun)
		{
			goto IL_0077;
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v66+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = button == buttonHokom;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			if (obj9 != null)
			{
				goto IL_014e;
			}
			object obj10 = 0;
			UnityEngine.Object obj11 = buttonHokom;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = button == buttonHokom;
			bool flag6 = !flag5;
			object obj10 = 0;
			UnityEngine.Object obj11 = buttonHokom;
			if (!flag6)
			{
				goto IL_014e;
			}
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v69+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = button == buttonAshkal;
			bool flag8 = !flag7;
			object obj13 = 0;
			UnityEngine.Object obj14 = buttonAshkal;
			if (!flag8)
			{
				goto IL_01ce;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = button == buttonAshkal;
			bool flag10 = !flag9;
			object obj15 = !flag10;
			object obj13 = 0;
			UnityEngine.Object obj14 = buttonAshkal;
			if (obj15 != null)
			{
				goto IL_01ce;
			}
		}
		int num = 34652672 >> state;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v71+E4]");
		int num2;
		int num3;
		if ((nint)0 != 0)
		{
			num2 = obj4 & num;
			bool flag11 = button == buttonDouble;
			bool flag12 = !flag11;
			object obj17 = 0;
			num3 = num2;
			UnityEngine.Object obj18 = buttonDouble;
			if (!flag12)
			{
				goto IL_0365;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = obj4 & num;
			bool flag13 = button == buttonDouble;
			bool flag14 = !flag13;
			object obj19 = !flag14;
			object obj17 = 0;
			num3 = num2;
			UnityEngine.Object obj18 = buttonDouble;
			if (obj19 != null)
			{
				goto IL_0365;
			}
		}
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v77+E4]");
		bool flag15 = (nint)0 == 0;
		object obj21 = !flag15;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(button == buttonFour))
		{
			goto IL_04e3;
		}
		if (num3 != 0)
		{
			goto IL_049f;
		}
		object obj22 = "fetch_products" + 1144;
		goto IL_125f;
		IL_04e3:
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v81+E4]");
		bool flag16 = (nint)0 == 0;
		object obj24 = !flag16;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (button == buttonTriple)
		{
			obj22 = "tournament_participate_warning_body_with_tickets_warning_daily" + 624;
		}
		else
		{
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v85+E4]");
			bool flag17 = (nint)0 == 0;
			object obj26 = !flag17;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(button == buttonQahwa))
			{
				object obj27 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v89+E4]");
				bool flag18 = (nint)0 == 0;
				object obj28 = !flag18;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag19 = button == buttonToSun;
				bool flag20 = !flag19;
				object obj29 = !flag20;
				if (obj29 == null)
				{
					object obj30 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v93+E4]");
					bool flag21 = (nint)0 == 0;
					object obj31 = !flag21;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag22 = button == buttonBeforeToSun;
					bool flag23 = !flag22;
					object obj32 = !flag23;
					if (obj32 == null)
					{
						object obj33 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v97+E4]");
						bool flag24 = (nint)0 == 0;
						object obj34 = !flag24;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag25 = button == buttonHokom2;
						bool flag26 = !flag25;
						object obj35 = !flag26;
						if (obj35 != null)
						{
							goto IL_014e;
						}
						object obj36 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v101+E4]");
						bool flag27 = (nint)0 == 0;
						object obj37 = !flag27;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (button == buttonConfirmHokom)
						{
							goto IL_07f2;
						}
						object obj38 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v105+E4]");
						bool flag28 = (nint)0 == 0;
						object obj39 = !flag28;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj41;
						object obj46;
						if (button == buttonHokomClubs)
						{
							object key = "getSecondRescanTask" + 3048;
							SFSExtensions.Put(sFSObject, (string)key, val: true);
							object obj40 = 0;
							bool flag29 = true;
							obj41 = 2;
						}
						else
						{
							object obj42 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v116+E4]");
							bool flag30 = (nint)0 == 0;
							object obj43 = !flag30;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj40;
							bool flag29;
							if (!(button == buttonHokomDiamonds))
							{
								object obj44 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v120+E4]");
								bool flag31 = (nint)0 == 0;
								object obj45 = !flag31;
								if (obj45 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (button == buttonHokomSpades)
								{
									object key2 = "getSecondRescanTask" + 3048;
									SFSExtensions.Put(sFSObject, (string)key2, val: true);
									obj46 = 0;
									obj40 = 0;
									flag29 = true;
								}
								else
								{
									object obj47 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v124+E4]");
									bool flag32 = (nint)0 == 0;
									object obj48 = !flag32;
									if (obj48 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if (!(button == buttonHokomHearts))
									{
										object obj49 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X0_v128+E4]");
										bool flag33 = (nint)0 == 0;
										object obj50 = !flag33;
										if (obj50 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (button == buttonHokomOpen)
										{
											obj22 = "getSecondRescanTask" + 2184;
										}
										else
										{
											object obj51 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v132+E4]");
											bool flag34 = (nint)0 == 0;
											object obj52 = !flag34;
											if (obj52 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											if (!(button == buttonHokomClose))
											{
												object obj53 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X0_v136+E4]");
												bool flag35 = (nint)0 == 0;
												object obj54 = !flag35;
												if (obj54 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag36 = button == buttonPass;
												bool flag37 = !flag36;
												object obj55 = !flag37;
												if (obj55 == null)
												{
													object obj56 = obj2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v140+E4]");
													bool flag38 = (nint)0 == 0;
													object obj57 = !flag38;
													if (obj57 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													bool flag39 = button == buttonWala;
													bool flag40 = !flag39;
													object obj58 = !flag40;
													if (obj58 == null)
													{
														object obj59 = "https://www.kammelna.com/Home/Terms" + 896;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
														bool flag41 = (object)button == null;
														object obj60 = !flag41;
														BalootBiddingButtons balootBiddingButtons = this;
														string text;
														if (obj60 == null)
														{
															text = null;
															BalootBiddingButtons balootBiddingButtons2 = default(BalootBiddingButtons);
															balootBiddingButtons = balootBiddingButtons2;
														}
														else
														{
															string text2 = button.ToString();
															text = text2;
														}
														string message = (string)(object)balootBiddingButtons + text;
														object obj61 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														ArgumentException ex = default(ArgumentException);
														ex..ctor(message);
														object obj62 = (nint)0 + (nint)2232;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
														throw new OutOfMemoryException();
													}
												}
												goto IL_07f2;
											}
											obj22 = "getSecondRescanTask" + 2176;
										}
										goto IL_125f;
									}
									object key3 = "getSecondRescanTask" + 3048;
									SFSExtensions.Put(sFSObject, (string)key3, val: true);
									obj46 = 1;
									obj40 = 0;
									flag29 = true;
								}
								goto IL_13dc;
							}
							object key4 = "getSecondRescanTask" + 3048;
							SFSExtensions.Put(sFSObject, (string)key4, val: true);
							obj40 = 0;
							flag29 = true;
							obj41 = 3;
						}
						obj46 = obj41;
						goto IL_13dc;
					}
				}
				goto IL_0077;
			}
			obj22 = "placementId" + 1864;
		}
		goto IL_125f;
		IL_049f:
		substate = 1001;
		Button[] array = getStateButtons();
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v43 (Il2CppClass<BalootBiddingButtons>)+1D8]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v43 (Il2CppClass<BalootBiddingButtons>)+1E0]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v517 @ X3_v9 (should have been resolved before IL gen)");
		goto IL_04e3;
		IL_13dc:
		object obj65 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj66 = "startPosition" + 1344;
		string text3 = (string)obj66;
		SFSExtensions.Put(sFSObject, (string)obj66, friendlyName);
		object obj67 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2544;
		Button[] array2 = stateButtons;
		object obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v54+E4]");
		bool flag42 = (nint)0 == 0;
		object obj69 = !flag42;
		object obj70 = 0;
		bool flag43 = (byte)(int)friendlyName != 0;
		object obj71 = 0;
		string text4 = friendlyName;
		object obj72 = obj67;
		string text5 = (string)obj66;
		object obj73 = obj68;
		Button[] array3 = stateButtons;
		if (obj69 != null)
		{
			goto IL_01e2;
		}
		goto IL_0a08;
		IL_0a96:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v54+E4]");
		bool flag44 = (nint)0 == 0;
		object obj74 = !flag44;
		object obj76;
		if (obj74 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj75 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v28+B8]");
			obj76 = 0;
		}
		object obj77 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj78 = (nint)0 + (nint)640;
		Action<object> action = default(Action<object>);
		action..ctor(obj76, (IntPtr)obj78);
		object obj79 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v27+B8]");
		object obj80 = (nint)0 + (nint)16;
		obj80 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj70 = 0;
		object obj82;
		object obj81 = obj82;
		Action<object> action2 = action;
		IEnumerable<object> enumerable;
		IEnumerable<object> enumeration2 = enumerable;
		goto IL_0aed;
		IL_0a08:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj68 = obj72;
		obj82 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v54+B8]");
		obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v22+10]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v22+10]");
		bool flag45 = (nint)0 == 0;
		object obj83 = !flag45;
		enumerable = array3;
		obj70 = obj71;
		obj81 = obj82;
		enumeration2 = array3;
		if (obj83 == null)
		{
			goto IL_0a96;
		}
		goto IL_0aed;
		IL_0077:
		text3 = (string)obj7;
		goto IL_11bc;
		IL_01ce:
		obj22 = "alignContent" + 2784;
		goto IL_125f;
		IL_0aed:
		ArraysExtensions.ForEach(enumeration2, action2);
		isBidder = false;
		BiddingState biddingState;
		if (this.biddingState != BiddingState.FirstRound)
		{
			if (this.biddingState != BiddingState.SecondRound)
			{
				goto IL_130a;
			}
			biddingState = BiddingState.Finished;
		}
		else
		{
			biddingState = BiddingState.SecondRound;
		}
		this.biddingState = biddingState;
		goto IL_130a;
		IL_125f:
		text3 = (string)obj22;
		goto IL_11bc;
		IL_1346:
		object obj84 = this + 64;
		obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateStateButtons();
		bool flag46 = base.allowBiddingPredetermination;
		nint num5 = (nint)this;
		bool flag47 = !flag46;
		object obj85 = !flag47;
		object obj86 = ~obj85;
		if (obj86 == null)
		{
			object obj87 = 456;
		}
		else
		{
			object obj87 = 424;
		}
		object obj88 = !flag47;
		object obj89 = ~obj88;
		if (obj89 == null)
		{
			object obj90 = 464;
		}
		else
		{
			object obj90 = 432;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v625 @ X8_v16 (Il2CppClass<BalootBiddingButtons>)+v654 @ X9_v7] (should have been resolved before IL gen)");
		game.SendBidding(sFSObject);
		return;
		IL_01e2:
		obj81 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v54+B8]");
		obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v22+10]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v22+10]");
		bool flag48 = (nint)0 == 0;
		object obj91 = !flag48;
		enumeration2 = array2;
		if (obj91 == null)
		{
			obj71 = obj70;
			obj82 = obj81;
			text4 = (string)flag43;
			obj72 = obj67;
			text5 = text3;
			enumerable = array2;
			goto IL_0a96;
		}
		goto IL_0aed;
		IL_0c7c:
		isNaturalFlowDisturbedThisRound = true;
		object obj93;
		object obj92 = obj93;
		goto IL_1346;
		IL_0c11:
		object obj94 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v42+E4]");
		if ((nint)0 != 0)
		{
			bool flag49 = button != buttonWala;
			bool flag50 = !flag49;
			obj93 = 0;
			obj92 = 0;
			if (!flag50)
			{
				goto IL_0c7c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag51 = button != buttonWala;
			bool flag52 = !flag51;
			object obj95 = !flag52;
			obj93 = 0;
			if (obj95 != null)
			{
				goto IL_0c7c;
			}
			obj92 = 0;
		}
		goto IL_1346;
		IL_07f2:
		obj22 = "not" + 3528;
		goto IL_125f;
		IL_130a:
		object obj96 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v28+E4]");
		if ((nint)0 != 0)
		{
			bool flag53 = button != buttonPass;
			bool flag54 = !flag53;
			object obj97 = !flag54;
			object obj98 = 0;
			UnityEngine.Object obj99 = buttonPass;
			if (obj97 != null)
			{
				goto IL_0c11;
			}
			obj92 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag55 = button != buttonPass;
			bool flag56 = !flag55;
			object obj98 = 0;
			UnityEngine.Object obj99 = buttonPass;
			obj92 = 0;
			if (!flag56)
			{
				goto IL_0c11;
			}
		}
		goto IL_1346;
		IL_11bc:
		SFSExtensions.Put(sFSObject, text3, val: true);
		obj67 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2544;
		array2 = stateButtons;
		obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v54+E4]");
		bool flag57 = (nint)0 == 0;
		obj70 = 0;
		flag43 = true;
		obj71 = 0;
		text4 = (string)1;
		obj72 = obj67;
		text5 = text3;
		obj73 = obj68;
		array3 = stateButtons;
		if (!flag57)
		{
			goto IL_01e2;
		}
		goto IL_0a08;
		IL_014e:
		obj22 = "getSecondRescanTask" + 3048;
		goto IL_125f;
		IL_0365:
		bool flag58 = num2 == 0;
		object obj100 = !flag58;
		if (obj100 != null)
		{
			goto IL_049f;
		}
		obj22 = "destinationTimeZone" + 632;
		goto IL_125f;
	}

	protected override void UpdateStateButtons()
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_02d2: Expected I, but got O
		//IL_0078: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_024c: Expected I, but got O
		//IL_0284: Expected O, but got I4
		//IL_0263: Expected O, but got I4
		//IL_026d: Expected I, but got O
		//IL_0106: Expected O, but got I4
		//IL_0226: Expected O, but got I4
		//IL_022b: Expected I, but got O
		//IL_0132: Expected F8, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0148: Expected O, but got F8
		//IL_01c3: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_0200: Expected O, but got F8
		object obj3 = default(object);
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		nint num4 = default(nint);
		if (allButtons != null)
		{
			object obj = (nint)0 + (nint)3640;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			obj3 = (nint)0 + (nint)3632;
			List<object>.Enumerator enumerator = ((List<object>)(object)allButtons).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator2 = enumerator3;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			UnityEngine.Object obj6 = default(UnityEngine.Object);
			while (true)
			{
				if (enumerator4.MoveNext())
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v22+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj7;
					if (obj6 == preDeterminedChoice)
					{
						if ((object)obj6 != null)
						{
							Image image = ((Selectable)obj6).image;
							TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(image, (Color)0, 1f);
							double num = 1.0;
							double num2 = 1.0;
							double num3 = 1058444951.0;
							obj7 = 0;
							enumerator2 = (List<object>.Enumerator)1.0;
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						obj7 = 0;
						num4 = (nint)preDeterminedChoice;
						break;
					}
					if ((object)obj6 != null)
					{
						Image image2 = ((Selectable)obj6).image;
						int num5 = ShortcutExtensions.DOKill(image2);
						Image image3 = ((Selectable)obj6).image;
						if ((object)image3 != null)
						{
							image3.color = (Color)0;
							double num = 1.0;
							double num2 = 1.0;
							double num3 = 1.0;
							obj7 = 0;
							enumerator2 = (List<object>.Enumerator)1.0;
							continue;
						}
						NullReferenceException ex2 = new NullReferenceException();
						obj7 = 0;
						num4 = unchecked((nint)null);
						break;
					}
					NullReferenceException ex3 = new NullReferenceException();
					obj7 = 0;
					num4 = (nint)preDeterminedChoice;
					break;
				}
				enumerator4.Dispose();
				return;
			}
			enumerator5 = enumerator3;
			enumerator3 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex4 = new NullReferenceException();
		bool flag2 = num4 != 1;
		OutOfMemoryException ex5 = (OutOfMemoryException)(object)ex4;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num4 = (nint)obj3;
			enumerator5.Dispose();
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			ex5 = new OutOfMemoryException();
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223828C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private static bool isDefaultState(int state)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_004c: Expected I4, but got O
		object obj = state + 1;
		bool flag = (nint)obj < 15;
		object obj2 = !flag;
		object obj3 = ~obj2;
		object obj4 = 24607 >> (int)obj;
		return (byte)(obj3 & obj4) != 0;
	}

	private bool isDefaultBidString(string bid)
	{
		//IL_0260: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		bool flag = biddingState == BiddingState.FirstRound;
		object obj = !flag;
		string text = bid;
		if (obj == null)
		{
			object obj2 = "utf-32" + 1152;
			text = (string)obj2;
			if (bid == (string)obj2)
			{
				return false;
			}
		}
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!StringsExtensions.IsNullOrEmpty(bid))
			{
				goto IL_0104;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(bid);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				goto IL_0104;
			}
		}
		goto IL_0219;
		IL_0219:
		return true;
		IL_0104:
		object obj6 = "alignContent" + 3464;
		bool flag4 = bid == (string)obj6;
		bool flag5 = !flag4;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			object obj8 = "not" + 3528;
			bool flag6 = bid == (string)obj8;
			bool flag7 = !flag6;
			object obj9 = !flag7;
			if (obj9 == null)
			{
				object obj10 = "startPosition" + 2936;
				bool flag8 = bid == (string)obj10;
				bool flag9 = !flag8;
				object obj11 = !flag9;
				if (obj11 == null)
				{
					object obj12 = "utf-32" + 1152;
					if (!(bid == (string)obj12))
					{
						object obj13 = "utf-32" + 1160;
						return bid == (string)obj13;
					}
				}
			}
		}
		goto IL_0219;
	}

	protected override void MitigateMissClicks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0178: Expected I, but got O
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_026b: Expected O, but got I
		//IL_027c: Expected I, but got O
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0200: Expected O, but got I
		//IL_021f: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag = preDeterminedChoice == null;
			bool flag2 = !flag;
			object obj6 = !flag2;
			object obj7 = 0;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = preDeterminedChoice == null;
			bool flag4 = !flag3;
			object obj7 = 0;
			if (flag4)
			{
				return;
			}
		}
		if (!isNaturalFlowDisturbedThisRound || !wasBiddingPredeterminationActive)
		{
			return;
		}
		wasBiddingPredeterminationActive = false;
		Button[] array = getStateButtons();
		object obj8 = obj2 + 24;
		obj8 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v9 (Il2CppClass<BalootBiddingButtons>)+240]");
		bool flag5 = false;
		UpdateStateButtons();
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X21_v8+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj10 = obj9 + 32;
			object obj11 = 0;
			bool flag6;
			do
			{
				obj11++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X23_v5+v114 @ X22_v8*8]");
				((Selectable)0).interactable = false;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X21_v8+18]");
				flag6 = (nint)obj12 < 0;
				object obj7 = 0;
				flag5 = false;
			}
			while (flag6);
		}
		isMitigatingMissClicks = true;
		object obj13 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)656;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj14);
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v21+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void FillBiddingButtonsDictionary()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj2 = (nint)0 + (nint)1624;
		dictionary.Add((System.Int32Enum)1, buttonSun);
		dictionary.Add((System.Int32Enum)2, buttonToSun);
		dictionary.Add((System.Int32Enum)4, buttonPass);
		dictionary.Add((System.Int32Enum)8, buttonHokom);
		dictionary.Add((System.Int32Enum)16, buttonAshkal);
		dictionary.Add((System.Int32Enum)32, buttonDouble);
		dictionary.Add((System.Int32Enum)64, buttonHokomOpen);
		_ballotBidingButtons = (Dictionary<BalootBidingButtonEnum, Button>)(object)dictionary;
		object obj3 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe void HandleBiddingButtons(BalootBidingButtonEnum balootBidingButtonEnum)
	{
		//IL_0178: Expected O, but got I4
		//IL_0013: Expected O, but got I
		//IL_001f: Expected O, but got I
		//IL_0119: Expected I4, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		bool flag = _ballotBidingButtons == null;
		Dictionary<System.Int32Enum, object>.Enumerator enumerator = (Dictionary<System.Int32Enum, object>.Enumerator)0;
		BalootBiddingButtons balootBiddingButtons = this;
		Dictionary<System.Int32Enum, object>.Enumerator enumerator3 = default(Dictionary<System.Int32Enum, object>.Enumerator);
		BalootBidingButtonEnum balootBidingButtonEnum2 = default(BalootBidingButtonEnum);
		if (!flag)
		{
			object obj = (nint)0 + (nint)1928;
			balootBiddingButtons = (BalootBiddingButtons)((nint)0 + (nint)960);
			Dictionary<System.Int32Enum, object>.Enumerator enumerator2 = ((Dictionary<System.Int32Enum, object>)(object)_ballotBidingButtons).GetEnumerator();
			KeyValuePair<System.Int32Enum, object> keyValuePair = default(KeyValuePair<System.Int32Enum, object>);
			System.Int32Enum key;
			while (true)
			{
				if (enumerator3.MoveNext())
				{
					keyValuePair.Deconstruct(out key, out var value);
					if (value == null)
					{
						break;
					}
					object obj2 = ~balootBidingButtonEnum2;
					object obj3 = key & obj2;
					bool interactable = obj3 == null;
					((Selectable)value).interactable = interactable;
					continue;
				}
				enumerator3.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			enumerator = (Dictionary<System.Int32Enum, object>.Enumerator)0;
			object obj4 = 0;
			balootBidingButtonEnum2 = (BalootBidingButtonEnum)(int)(&key);
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = balootBidingButtonEnum2 != BalootBidingButtonEnum.buttonSun;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			balootBidingButtonEnum2 = (BalootBidingButtonEnum)balootBiddingButtons;
			enumerator3.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22382CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void <Awake>b__37_0(Button button)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00a3: Expected I, but got O
		//IL_00bd: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 16;
		obj4 = button;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+100]");
		((UnityEvent)0).AddListener(unityAction);
	}
}
