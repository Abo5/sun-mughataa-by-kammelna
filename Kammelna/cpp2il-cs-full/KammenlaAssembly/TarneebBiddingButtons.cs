using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using Spine;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TarneebBiddingButtons : BiddingButtons
{
	private sealed class <>c__DisplayClass20_0
	{
		public Button button;

		public TarneebBiddingButtons <>4__this;

		internal void <Awake>b__1()
		{
			<>4__this.onButtonClick(button);
		}
	}

	public Button buttonPass;

	public Button buttonClubs;

	public Button buttonDiamonds;

	public Button buttonSpades;

	public Button buttonHearts;

	public GameObject biddingButtonsParent;

	public Button button7;

	public Button button8;

	public Button button9;

	public Button button10;

	public Button button11;

	public Button button12;

	public Button button13;

	private Button[] stateButtons;

	private Button[] round1DefaultState1;

	private Button[] allBidButtons;

	private Button[] allSuitButtons;

	private const string Waraq = "waraq";

	private TarneebGame tGame
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			TarneebGame tarneebGame = (TarneebGame)game;
			if ((object)game != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				object obj2 = obj;
				nint num = (nint)tarneebGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<TarneebGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<TarneebGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (TarneebGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (TarneebGame)game;
		}
	}

	protected override void Awake()
	{
		//IL_2405: Unknown result type (might be due to invalid IL or missing references)
		//IL_240a: Expected O, but got Unknown
		//IL_241e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2423: Expected O, but got Unknown
		//IL_242f: Expected O, but got I
		//IL_243b: Expected O, but got I
		//IL_2465: Expected O, but got I4
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
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Expected O, but got Unknown
		//IL_0e4b: Expected O, but got I4
		//IL_0ec7: Expected O, but got I
		//IL_0ed7: Expected O, but got I
		//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f06: Expected O, but got Unknown
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected O, but got Unknown
		//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Expected O, but got Unknown
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f32: Expected O, but got Unknown
		//IL_0f6b: Expected O, but got I4
		//IL_0f99: Expected O, but got I4
		//IL_0fbf: Expected O, but got I
		//IL_0fe8: Expected O, but got I
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected O, but got Unknown
		//IL_1041: Expected O, but got I
		//IL_106c: Expected O, but got I
		//IL_10e3: Expected O, but got I8
		//IL_1092: Expected O, but got I
		//IL_10bb: Expected O, but got I
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected O, but got Unknown
		//IL_11c4: Expected O, but got I4
		//IL_11da: Expected O, but got I
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ff: Expected O, but got Unknown
		//IL_116b: Expected O, but got I
		//IL_1194: Expected O, but got I
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected O, but got Unknown
		//IL_12c9: Expected O, but got I8
		//IL_1278: Expected O, but got I
		//IL_12a1: Expected O, but got I
		//IL_12f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Expected O, but got Unknown
		//IL_13aa: Expected O, but got I4
		//IL_13c0: Expected O, but got I
		//IL_13e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e5: Expected O, but got Unknown
		//IL_1351: Expected O, but got I
		//IL_137a: Expected O, but got I
		//IL_1404: Unknown result type (might be due to invalid IL or missing references)
		//IL_1409: Expected O, but got Unknown
		//IL_14b7: Expected O, but got I4
		//IL_14cd: Expected O, but got I
		//IL_14ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f2: Expected O, but got Unknown
		//IL_145e: Expected O, but got I
		//IL_1487: Expected O, but got I
		//IL_1511: Unknown result type (might be due to invalid IL or missing references)
		//IL_1516: Expected O, but got Unknown
		//IL_15c4: Expected O, but got I4
		//IL_15da: Expected O, but got I
		//IL_15fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ff: Expected O, but got Unknown
		//IL_156b: Expected O, but got I
		//IL_1594: Expected O, but got I
		//IL_161e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1623: Expected O, but got Unknown
		//IL_16c9: Expected O, but got I8
		//IL_1678: Expected O, but got I
		//IL_16a1: Expected O, but got I
		//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_171b: Expected O, but got Unknown
		//IL_1754: Expected O, but got I4
		//IL_1782: Expected O, but got I4
		//IL_17a8: Expected O, but got I
		//IL_17d1: Expected O, but got I
		//IL_1815: Unknown result type (might be due to invalid IL or missing references)
		//IL_181a: Expected O, but got Unknown
		//IL_182a: Expected O, but got I
		//IL_1855: Expected O, but got I
		//IL_18cc: Expected O, but got I8
		//IL_187b: Expected O, but got I
		//IL_18a4: Expected O, but got I
		//IL_18fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ff: Expected O, but got Unknown
		//IL_19ad: Expected O, but got I4
		//IL_19c3: Expected O, but got I
		//IL_19e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e8: Expected O, but got Unknown
		//IL_1954: Expected O, but got I
		//IL_197d: Expected O, but got I
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0c: Expected O, but got Unknown
		//IL_1ab2: Expected O, but got I8
		//IL_1a61: Expected O, but got I
		//IL_1a8a: Expected O, but got I
		//IL_1ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae5: Expected O, but got Unknown
		//IL_1b93: Expected O, but got I4
		//IL_1ba9: Expected O, but got I
		//IL_1bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bce: Expected O, but got Unknown
		//IL_1b3a: Expected O, but got I
		//IL_1b63: Expected O, but got I
		//IL_1bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf2: Expected O, but got Unknown
		//IL_1ca0: Expected O, but got I4
		//IL_1cb6: Expected O, but got I
		//IL_1cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdb: Expected O, but got Unknown
		//IL_1c47: Expected O, but got I
		//IL_1c70: Expected O, but got I
		//IL_1cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cff: Expected O, but got Unknown
		//IL_1dad: Expected O, but got I4
		//IL_1dc3: Expected O, but got I
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de8: Expected O, but got Unknown
		//IL_1d54: Expected O, but got I
		//IL_1d7d: Expected O, but got I
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Expected O, but got Unknown
		//IL_1e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2b: Expected O, but got Unknown
		//IL_1e64: Expected O, but got I4
		//IL_1e92: Expected O, but got I4
		//IL_1eb8: Expected O, but got I
		//IL_1ee1: Expected O, but got I
		//IL_1f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2a: Expected O, but got Unknown
		//IL_1f3a: Expected O, but got I
		//IL_1f65: Expected O, but got I
		//IL_1fdc: Expected O, but got I8
		//IL_1f8b: Expected O, but got I
		//IL_1fb4: Expected O, but got I
		//IL_200a: Unknown result type (might be due to invalid IL or missing references)
		//IL_200f: Expected O, but got Unknown
		//IL_20bd: Expected O, but got I4
		//IL_20d3: Expected O, but got I
		//IL_20f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f8: Expected O, but got Unknown
		//IL_2064: Expected O, but got I
		//IL_208d: Expected O, but got I
		//IL_2117: Unknown result type (might be due to invalid IL or missing references)
		//IL_211c: Expected O, but got Unknown
		//IL_21c2: Expected O, but got I8
		//IL_2171: Expected O, but got I
		//IL_219a: Expected O, but got I
		//IL_21f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fb: Expected O, but got Unknown
		//IL_2207: Expected O, but got I
		//IL_2210: Unknown result type (might be due to invalid IL or missing references)
		//IL_2215: Expected O, but got Unknown
		//IL_222f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2234: Expected O, but got Unknown
		//IL_225d: Expected I, but got O
		//IL_226b: Expected I, but got O
		//IL_228a: Expected O, but got I4
		//IL_22a9: Expected O, but got I
		//IL_22b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22bd: Expected O, but got Unknown
		//IL_22d1: Expected I, but got O
		//IL_22eb: Expected I, but got O
		//IL_232b: Expected O, but got I4
		//IL_2361: Expected I, but got O
		//IL_23a1: Expected O, but got I4
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v128+C0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v129+70]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v4+30]");
					list.AddWithResize((object)0);
				}
				obj9 = button7;
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
						obj20 = button7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v11+20]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v125+C0]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v126+70]");
						nint num = 0;
						list.AddWithResize((object)button7);
					}
					obj9 = button8;
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
							obj26 = button8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v13+20]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v122+C0]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v123+70]");
							nint num = 0;
							list.AddWithResize((object)button8);
						}
						obj9 = button9;
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
								obj32 = button9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v15+20]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v119+C0]");
								object obj34 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v120+70]");
								nint num = 0;
								list.AddWithResize((object)button9);
							}
							obj9 = button10;
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
									obj38 = button10;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v17+20]");
									object obj39 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v116+C0]");
									object obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v117+70]");
									nint num = 0;
									list.AddWithResize((object)button10);
								}
								obj9 = button11;
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
										obj44 = button11;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v19+20]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v113+C0]");
										object obj46 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X8_v114+70]");
										nint num = 0;
										list.AddWithResize((object)button11);
									}
									obj9 = button12;
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
											obj50 = button12;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v21+20]");
											object obj51 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v110+C0]");
											object obj52 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v111+70]");
											nint num = 0;
											list.AddWithResize((object)button12);
										}
										obj9 = button13;
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
												obj56 = button13;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+20]");
												object obj57 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v107+C0]");
												object obj58 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v108+70]");
												nint num = 0;
												list.AddWithResize((object)button13);
											}
											obj9 = buttonClubs;
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
													obj62 = buttonClubs;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v25+20]");
													object obj63 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v104+C0]");
													object obj64 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v105+70]");
													nint num = 0;
													list.AddWithResize((object)buttonClubs);
												}
												obj9 = buttonDiamonds;
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
														obj68 = buttonDiamonds;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v27+20]");
														object obj69 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v101+C0]");
														object obj70 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v102+70]");
														nint num = 0;
														list.AddWithResize((object)buttonDiamonds);
													}
													obj9 = buttonSpades;
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
															obj74 = buttonSpades;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v29+20]");
															object obj75 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ X8_v98+C0]");
															object obj76 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v99+70]");
															nint num = 0;
															list.AddWithResize((object)buttonSpades);
														}
														obj9 = buttonHearts;
														object obj77 = obj10;
														int version12 = list._version + 1;
														list._version = version12;
														object[] items12 = list._items;
														if (list._items != null)
														{
															object obj78 = typeof(TypeConverter<ushort, char>) + 1840;
															bool flag13 = list._size < items12.Length;
															object obj79 = !flag13;
															if (obj79 == null)
															{
																int size12 = list._size + 1;
																list._size = size12;
																object obj80 = list._items + list._size;
																object obj81 = obj80 + 32;
																obj81 = buttonHearts;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v31+20]");
																object obj82 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v95+C0]");
																object obj83 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X8_v96+70]");
																nint num = 0;
																list.AddWithResize((object)buttonHearts);
															}
															object obj84 = this + 56;
															obj84 = list;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
															object obj85 = this + 184;
															object obj86 = default(object);
															obj85 = obj86;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
															object obj87 = default(object);
															bool flag14 = obj87 == null;
															obj9 = 8;
															if (!flag14)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X21_v9-68]");
																bool flag15 = (nint)0 == 0;
																object obj88 = 8;
																if (!flag15)
																{
																	object obj89 = obj87;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v94+40]");
																	obj88 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																	bool flag16 = ex == null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v94+40]");
																	obj9 = 0;
																	if (flag16)
																	{
																		goto IL_23e0;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																bool flag17 = (nint)0 == 0;
																obj9 = obj88;
																if (!flag17)
																{
																	object obj90 = obj87 + 32;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X21_v9-68]");
																	obj90 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	bool flag18 = (object)button7 == null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X21_v9-68]");
																	object obj91 = 0;
																	if (!flag18)
																	{
																		object obj92 = obj87;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v93+40]");
																		obj91 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																		bool flag19 = ex == null;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v93+40]");
																		obj9 = 0;
																		if (flag19)
																		{
																			goto IL_23e0;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																	object obj93 = 0 & 0xFFFFFFFEL;
																	bool flag20 = obj93 == null;
																	obj9 = obj91;
																	if (!flag20)
																	{
																		object obj94 = obj87 + 40;
																		obj94 = button7;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		bool flag21 = (object)button8 == null;
																		object obj95 = button7;
																		if (!flag21)
																		{
																			object obj96 = obj87;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v92+40]");
																			obj95 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																			bool flag22 = ex == null;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v92+40]");
																			obj9 = 0;
																			if (flag22)
																			{
																				goto IL_23e0;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																		bool flag23 = (nint)0 < (nint)2;
																		object obj97 = !flag23;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																		object obj98 = -2;
																		bool flag24 = obj98 == null;
																		object obj99 = ~obj97;
																		object obj100 = obj99 | flag24;
																		obj9 = obj95;
																		if (obj100 == null)
																		{
																			object obj101 = obj87 + 48;
																			obj101 = button8;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			bool flag25 = (object)button9 == null;
																			object obj102 = button8;
																			if (!flag25)
																			{
																				object obj103 = obj87;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v91+40]");
																				obj102 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																				bool flag26 = ex == null;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v91+40]");
																				obj9 = 0;
																				if (flag26)
																				{
																					goto IL_23e0;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																			object obj104 = 0 & 0xFFFFFFFCL;
																			bool flag27 = obj104 == null;
																			obj9 = obj102;
																			if (!flag27)
																			{
																				object obj105 = obj87 + 56;
																				obj105 = button9;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				bool flag28 = (object)button10 == null;
																				object obj106 = button9;
																				if (!flag28)
																				{
																					object obj107 = obj87;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v90+40]");
																					obj106 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																					bool flag29 = ex == null;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v90+40]");
																					obj9 = 0;
																					if (flag29)
																					{
																						goto IL_23e0;
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																				bool flag30 = (nint)0 < (nint)4;
																				object obj108 = !flag30;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																				object obj109 = -4;
																				bool flag31 = obj109 == null;
																				object obj110 = ~obj108;
																				object obj111 = obj110 | flag31;
																				obj9 = obj106;
																				if (obj111 == null)
																				{
																					object obj112 = obj87 + 64;
																					obj112 = button10;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																					bool flag32 = (object)button11 == null;
																					object obj113 = button10;
																					if (!flag32)
																					{
																						object obj114 = obj87;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v89+40]");
																						obj113 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																						bool flag33 = ex == null;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v89+40]");
																						obj9 = 0;
																						if (flag33)
																						{
																							goto IL_23e0;
																						}
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																					bool flag34 = (nint)0 < (nint)5;
																					object obj115 = !flag34;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																					object obj116 = -5;
																					bool flag35 = obj116 == null;
																					object obj117 = ~obj115;
																					object obj118 = obj117 | flag35;
																					obj9 = obj113;
																					if (obj118 == null)
																					{
																						object obj119 = obj87 + 72;
																						obj119 = button11;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																						bool flag36 = (object)button12 == null;
																						object obj120 = button11;
																						if (!flag36)
																						{
																							object obj121 = obj87;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v88+40]");
																							obj120 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																							bool flag37 = ex == null;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v88+40]");
																							obj9 = 0;
																							if (flag37)
																							{
																								goto IL_23e0;
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																						bool flag38 = (nint)0 < (nint)6;
																						object obj122 = !flag38;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																						object obj123 = -6;
																						bool flag39 = obj123 == null;
																						object obj124 = ~obj122;
																						object obj125 = obj124 | flag39;
																						obj9 = obj120;
																						if (obj125 == null)
																						{
																							object obj126 = obj87 + 80;
																							obj126 = button12;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																							bool flag40 = (object)button13 == null;
																							object obj127 = button12;
																							if (!flag40)
																							{
																								object obj128 = obj87;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v87+40]");
																								obj127 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																								bool flag41 = ex == null;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v87+40]");
																								obj9 = 0;
																								if (flag41)
																								{
																									goto IL_23e0;
																								}
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v38+18]");
																							object obj129 = 0 & 0xFFFFFFF8L;
																							bool flag42 = obj129 == null;
																							obj9 = obj127;
																							if (!flag42)
																							{
																								object obj130 = obj87 + 88;
																								obj130 = button13;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																								object obj131 = this + 192;
																								obj131 = obj87;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																								object obj132 = default(object);
																								bool flag43 = obj132 == null;
																								obj9 = 7;
																								if (flag43)
																								{
																									goto IL_23c4;
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X21_v19-40]");
																								bool flag44 = (nint)0 == 0;
																								object obj133 = 7;
																								if (!flag44)
																								{
																									object obj134 = obj132;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v86+40]");
																									obj133 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																									bool flag45 = ex == null;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v86+40]");
																									obj9 = 0;
																									if (flag45)
																									{
																										goto IL_23e0;
																									}
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																								bool flag46 = (nint)0 == 0;
																								obj9 = obj133;
																								if (!flag46)
																								{
																									object obj135 = obj132 + 32;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X21_v19-40]");
																									obj135 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																									bool flag47 = (object)button8 == null;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X21_v19-40]");
																									object obj136 = 0;
																									if (!flag47)
																									{
																										object obj137 = obj132;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v85+40]");
																										obj136 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																										bool flag48 = ex == null;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v85+40]");
																										obj9 = 0;
																										if (flag48)
																										{
																											goto IL_23e0;
																										}
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																									object obj138 = 0 & 0xFFFFFFFEL;
																									bool flag49 = obj138 == null;
																									obj9 = obj136;
																									if (!flag49)
																									{
																										object obj139 = obj132 + 40;
																										obj139 = button8;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																										bool flag50 = (object)button9 == null;
																										object obj140 = button8;
																										if (!flag50)
																										{
																											object obj141 = obj132;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v84+40]");
																											obj140 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																											bool flag51 = ex == null;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v84+40]");
																											obj9 = 0;
																											if (flag51)
																											{
																												goto IL_23e0;
																											}
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																										bool flag52 = (nint)0 < (nint)2;
																										object obj142 = !flag52;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																										object obj143 = -2;
																										bool flag53 = obj143 == null;
																										object obj144 = ~obj142;
																										object obj145 = obj144 | flag53;
																										obj9 = obj140;
																										if (obj145 == null)
																										{
																											object obj146 = obj132 + 48;
																											obj146 = button9;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																											bool flag54 = (object)button10 == null;
																											object obj147 = button9;
																											if (!flag54)
																											{
																												object obj148 = obj132;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v83+40]");
																												obj147 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																												bool flag55 = ex == null;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v83+40]");
																												obj9 = 0;
																												if (flag55)
																												{
																													goto IL_23e0;
																												}
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																											object obj149 = 0 & 0xFFFFFFFCL;
																											bool flag56 = obj149 == null;
																											obj9 = obj147;
																											if (!flag56)
																											{
																												object obj150 = obj132 + 56;
																												obj150 = button10;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																												bool flag57 = (object)button11 == null;
																												object obj151 = button10;
																												if (!flag57)
																												{
																													object obj152 = obj132;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v82+40]");
																													obj151 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																													bool flag58 = ex == null;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v82+40]");
																													obj9 = 0;
																													if (flag58)
																													{
																														goto IL_23e0;
																													}
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																												bool flag59 = (nint)0 < (nint)4;
																												object obj153 = !flag59;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																												object obj154 = -4;
																												bool flag60 = obj154 == null;
																												object obj155 = ~obj153;
																												object obj156 = obj155 | flag60;
																												obj9 = obj151;
																												if (obj156 == null)
																												{
																													object obj157 = obj132 + 64;
																													obj157 = button11;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																													bool flag61 = (object)button12 == null;
																													object obj158 = button11;
																													if (!flag61)
																													{
																														object obj159 = obj132;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v81+40]");
																														obj158 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																														bool flag62 = ex == null;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v81+40]");
																														obj9 = 0;
																														if (flag62)
																														{
																															goto IL_23e0;
																														}
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																													bool flag63 = (nint)0 < (nint)5;
																													object obj160 = !flag63;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																													object obj161 = -5;
																													bool flag64 = obj161 == null;
																													object obj162 = ~obj160;
																													object obj163 = obj162 | flag64;
																													obj9 = obj158;
																													if (obj163 == null)
																													{
																														object obj164 = obj132 + 72;
																														obj164 = button12;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																														bool flag65 = (object)button13 == null;
																														object obj165 = button12;
																														if (!flag65)
																														{
																															object obj166 = obj132;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v80+40]");
																															obj165 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																															bool flag66 = ex == null;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v80+40]");
																															obj9 = 0;
																															if (flag66)
																															{
																																goto IL_23e0;
																															}
																														}
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																														bool flag67 = (nint)0 < (nint)6;
																														object obj167 = !flag67;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v74+18]");
																														object obj168 = -6;
																														bool flag68 = obj168 == null;
																														object obj169 = ~obj167;
																														object obj170 = obj169 | flag68;
																														obj9 = obj165;
																														if (obj170 == null)
																														{
																															object obj171 = obj132 + 80;
																															obj171 = button13;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																															object obj172 = this + 200;
																															obj172 = obj132;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																															object obj173 = default(object);
																															bool flag69 = obj173 == null;
																															obj9 = 4;
																															if (flag69)
																															{
																																goto IL_23c4;
																															}
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X21_v28-70]");
																															bool flag70 = (nint)0 == 0;
																															object obj174 = 4;
																															if (!flag70)
																															{
																																object obj175 = obj173;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v79+40]");
																																obj174 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																bool flag71 = ex == null;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v79+40]");
																																obj9 = 0;
																																if (flag71)
																																{
																																	goto IL_23e0;
																																}
																															}
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v106+18]");
																															bool flag72 = (nint)0 == 0;
																															obj9 = obj174;
																															if (!flag72)
																															{
																																object obj176 = obj173 + 32;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X21_v28-70]");
																																obj176 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																bool flag73 = (object)buttonDiamonds == null;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X21_v28-70]");
																																object obj177 = 0;
																																if (!flag73)
																																{
																																	object obj178 = obj173;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v78+40]");
																																	obj177 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																	bool flag74 = ex == null;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v78+40]");
																																	obj9 = 0;
																																	if (flag74)
																																	{
																																		goto IL_23e0;
																																	}
																																}
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v106+18]");
																																object obj179 = 0 & 0xFFFFFFFEL;
																																bool flag75 = obj179 == null;
																																obj9 = obj177;
																																if (!flag75)
																																{
																																	object obj180 = obj173 + 40;
																																	obj180 = buttonDiamonds;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	bool flag76 = (object)buttonSpades == null;
																																	object obj181 = buttonDiamonds;
																																	if (!flag76)
																																	{
																																		object obj182 = obj173;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v77+40]");
																																		obj181 = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																		bool flag77 = ex == null;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v77+40]");
																																		obj9 = 0;
																																		if (flag77)
																																		{
																																			goto IL_23e0;
																																		}
																																	}
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v106+18]");
																																	bool flag78 = (nint)0 < (nint)2;
																																	object obj183 = !flag78;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v106+18]");
																																	object obj184 = -2;
																																	bool flag79 = obj184 == null;
																																	object obj185 = ~obj183;
																																	object obj186 = obj185 | flag79;
																																	obj9 = obj181;
																																	if (obj186 == null)
																																	{
																																		object obj187 = obj173 + 48;
																																		obj187 = buttonSpades;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																		bool flag80 = (object)buttonHearts == null;
																																		object obj188 = buttonSpades;
																																		if (!flag80)
																																		{
																																			object obj189 = obj173;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v76+40]");
																																			obj188 = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																			bool flag81 = ex == null;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v76+40]");
																																			obj9 = 0;
																																			if (flag81)
																																			{
																																				goto IL_23e0;
																																			}
																																		}
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v106+18]");
																																		object obj190 = 0 & 0xFFFFFFFCL;
																																		bool flag82 = obj190 == null;
																																		obj9 = obj188;
																																		if (!flag82)
																																		{
																																			object obj191 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
																																			object obj192 = (nint)0 + (nint)328;
																																			object obj193 = obj173 + 56;
																																			obj193 = buttonHearts;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																			object obj194 = this + 208;
																																			obj194 = obj173;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																			nint num = (nint)obj192;
																																			Action<object> action = default(Action<object>);
																																			action..ctor((object)this, (IntPtr)obj192);
																																			bool flag83 = allButtons == null;
																																			object obj195 = 0;
																																			obj9 = this;
																																			if (!flag83)
																																			{
																																				object obj196 = (nint)0 + (nint)2216;
																																				object obj197 = typeof(SqlSingle[]) + 2376;
																																				((List<object>)(object)allButtons).ForEach(action);
																																				nint num2 = (nint)this;
																																				ShowPredetermineBid();
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																				nint num3 = (nint)this;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v74 (Il2CppClass<TarneebBiddingButtons>)+190]");
																																				num = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v74 (Il2CppClass<TarneebBiddingButtons>)+190]");
																																				Action action2 = default(Action);
																																				action2..ctor(this, (IntPtr)0);
																																				bool flag84 = (object)game == null;
																																				obj195 = 0;
																																				obj9 = this;
																																				if (!flag84)
																																				{
																																					game.OnGameStateUpdated += action2;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																					nint num4 = (nint)this;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v75 (Il2CppClass<TarneebBiddingButtons>)+1A0]");
																																					num = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v75 (Il2CppClass<TarneebBiddingButtons>)+1A0]");
																																					Action action3 = default(Action);
																																					action3..ctor(this, (IntPtr)0);
																																					bool flag85 = (object)game == null;
																																					obj195 = 0;
																																					obj9 = this;
																																					if (!flag85)
																																					{
																																						game.OnRoundStart += action3;
																																						return;
																																					}
																																				}
																																			}
																																			goto IL_23c4;
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
																goto IL_23d2;
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
		goto IL_23c4;
		IL_23e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_23c4:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_23d2;
		IL_23d2:
		ex = new IndexOutOfRangeException();
		goto IL_23e0;
	}

	protected override Button[] getStateButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009a: Expected I, but got O
		//IL_00a2: Expected I, but got O
		//IL_00cb: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_0213: Expected I, but got O
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66EF]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66ED]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_006f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66ED]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_006f;
			}
		}
		_ = 1;
		CardGame cardGame = game;
		bool flag2 = (object)game == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_007e;
		IL_006f:
		cardGame = game;
		goto IL_007e;
		IL_007e:
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		nint num = (nint)obj7;
		nint num2 = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v19 (Il2CppClass<CardGame>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X1_v1 (Il2CppMethodInfo)+130]");
		bool flag3 = num3 < 0;
		object obj8 = !flag3;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v19 (Il2CppClass<CardGame>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X1_v1 (Il2CppMethodInfo)+130]");
			object obj10 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v22-8]");
			if (0 == num)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v26 (CardGame)+174]");
				if ((nint)0 != 0)
				{
					return allSuitButtons;
				}
				object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = (nint)0 + (nint)344;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor((object)this, (IntPtr)obj12);
				IEnumerable<object> source = Enumerable.Where(round1DefaultState1, func);
				return (Button[])Enumerable.ToArray(source);
			}
		}
		return (Button[])(object)new InvalidCastException();
	}

	protected override void ShowPredetermineBid()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_0240: Expected I, but got O
		//IL_0262: Expected O, but got I4
		//IL_02c6: Expected I, but got O
		//IL_02d6: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_031a: Expected O, but got I
		//IL_0328: Expected I, but got O
		//IL_0359: Expected I, but got O
		//IL_0369: Expected O, but got I
		//IL_0379: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6658]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v25+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v25+E4]");
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
		object obj9 = 0;
		if (obj8 == null)
		{
			goto IL_016c;
		}
		return;
		IL_02f0:
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)336;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj11);
		IEnumerable<object> source = Enumerable.Where(round1DefaultState1, func);
		object[] array = Enumerable.ToArray(source);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v23 (Il2CppClass<TarneebBiddingButtons>)+1D8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v23 (Il2CppClass<TarneebBiddingButtons>)+1E0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v122 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_016c:
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
		bool flag5 = !isSpectator;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			return;
		}
		nint num2 = (nint)this;
		UpdateStateButtons();
		bool flag6 = !isNaturalFlowDisturbedThisRound;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			TarneebGame tarneebGame = tGame;
			if (tarneebGame.<BiddingStage>k__BackingField == TarneebBiddingStage.EatingBid)
			{
				goto IL_02f0;
			}
		}
		if (isBidder)
		{
			return;
		}
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v13 (Il2CppClass<TarneebBiddingButtons>)+1A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v13 (Il2CppClass<TarneebBiddingButtons>)+1B0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v132 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_02f0;
		IL_0091:
		bool flag7 = obj5 == null;
		bool flag8 = !flag7;
		obj9 = 0;
		if (!flag8)
		{
			return;
		}
		goto IL_016c;
	}

	protected override void ShowBid(Button[] newStateButtons)
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2872;
		object obj2 = this + 184;
		Button[] array = default(Button[]);
		obj2 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateStateButtons();
		int num = ShortcutExtensions.DOKill(biddingBar);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(biddingBar, 419f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	protected override void UpdateShowBid()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0197: Expected I, but got O
		//IL_01a7: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_00b1: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		CardGamePlayer myPlayer = game.MyPlayer;
		if (isBidder = myPlayer.IsBidder)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				bool flag = preDeterminedChoice != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_00fc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (preDeterminedChoice != null)
				{
					goto IL_00fc;
				}
			}
			goto IL_0130;
		}
		goto IL_01c2;
		IL_016f:
		if (base.allowBiddingPredetermination)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7 (Il2CppClass<TarneebBiddingButtons>)+1C8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7 (Il2CppClass<TarneebBiddingButtons>)+1D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X2_v4 (should have been resolved before IL gen)");
		}
		return;
		IL_0130:
		Button[] newStateButtons = getStateButtons();
		ShowBid(newStateButtons);
		bool flag3 = !isBidder;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			goto IL_016f;
		}
		return;
		IL_01c2:
		if (isBidder)
		{
			return;
		}
		goto IL_016f;
		IL_00fc:
		if (!isBidder)
		{
			goto IL_0130;
		}
		SubmitPredetermineBid();
		goto IL_01c2;
	}

	protected override void UpdateHideBid()
	{
		base.HideContainer();
		isNaturalFlowDisturbedThisRound = false;
	}

	protected override void SubmitPredetermineBid()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0041: Expected I, but got O
		//IL_0051: Expected O, but got I
		//IL_0061: Expected O, but got I
		object button = this + 64;
		if (isValidBid((Button)button))
		{
			Button button2 = preDeterminedChoice;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v3 (Il2CppClass<TarneebBiddingButtons>)+228]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v3 (Il2CppClass<TarneebBiddingButtons>)+230]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v20 @ X3_v1 (should have been resolved before IL gen)");
		}
		preDeterminedChoice = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Button[] array = getStateButtons();
		object obj3 = this + 184;
		obj3 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v2 (Il2CppClass<TarneebBiddingButtons>)+238]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v2 (Il2CppClass<TarneebBiddingButtons>)+240]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<TarneebBiddingButtons>)+238]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<TarneebBiddingButtons>)+240]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v79 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void SubmitBid(Button button)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I4
		//IL_05fc: Expected I, but got O
		//IL_060c: Expected O, but got I
		//IL_01f6: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_095c: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_02d6: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_0318: Expected O, but got I4
		//IL_039b: Expected O, but got I4
		//IL_041e: Expected O, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_0524: Expected O, but got I4
		//IL_0656: Expected O, but got I4
		//IL_06e0: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_076a: Expected O, but got I4
		//IL_073b: Expected O, but got I4
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_07f4: Expected O, but got I4
		//IL_085d: Expected O, but got I4
		//IL_0865: Expected I4, but got O
		//IL_07bc: Expected O, but got I4
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_089d: Expected O, but got I4
		//IL_084f: Expected O, but got I4
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected O, but got Unknown
		//IL_08e8: Expected O, but got I
		if (!isValidBid(button))
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag = button == buttonPass;
			bool flag2 = !flag;
			object obj4 = 0;
			UnityEngine.Object obj5 = buttonPass;
			if (!flag2)
			{
				goto IL_00b1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = button == buttonPass;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj4 = 0;
			UnityEngine.Object obj5 = buttonPass;
			if (obj6 != null)
			{
				goto IL_00b1;
			}
		}
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v42+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = button == button7;
			bool flag6 = !flag5;
			object obj8 = 0;
			UnityEngine.Object obj9 = button7;
			if (!flag6)
			{
				goto IL_01af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = button == button7;
			bool flag8 = !flag7;
			object obj10 = !flag8;
			object obj8 = 0;
			UnityEngine.Object obj9 = button7;
			if (obj10 != null)
			{
				goto IL_01af;
			}
		}
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v48+E4]");
		if ((nint)0 != 0)
		{
			bool flag9 = button == button8;
			bool flag10 = !flag9;
			object obj12 = 0;
			UnityEngine.Object obj13 = button8;
			if (!flag10)
			{
				goto IL_0285;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = button == button8;
			bool flag12 = !flag11;
			object obj14 = !flag12;
			object obj12 = 0;
			UnityEngine.Object obj13 = button8;
			if (obj14 != null)
			{
				goto IL_0285;
			}
		}
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v50+E4]");
		bool flag13 = (nint)0 == 0;
		object obj16 = !flag13;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Button button2;
		if (button == button9)
		{
			button2 = button9;
		}
		else
		{
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v54+E4]");
			bool flag14 = (nint)0 == 0;
			object obj18 = !flag14;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (button == button10)
			{
				button2 = button10;
			}
			else
			{
				object obj19 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v58+E4]");
				bool flag15 = (nint)0 == 0;
				object obj20 = !flag15;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (button == button11)
				{
					button2 = button11;
				}
				else
				{
					object obj21 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v62+E4]");
					bool flag16 = (nint)0 == 0;
					object obj22 = !flag16;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (button == button12)
					{
						button2 = button12;
					}
					else
					{
						object obj23 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v66+E4]");
						bool flag17 = (nint)0 == 0;
						object obj24 = !flag17;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(button == button13))
						{
							object obj25 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v70+E4]");
							bool flag18 = (nint)0 == 0;
							object obj26 = !flag18;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj27;
							object obj32;
							if (button == buttonClubs)
							{
								int num = 0;
								obj27 = 2;
							}
							else
							{
								object obj28 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v80+E4]");
								bool flag19 = (nint)0 == 0;
								object obj29 = !flag19;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (button == buttonDiamonds)
								{
									int num = 0;
									obj27 = 3;
								}
								else
								{
									object obj30 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v84+E4]");
									bool flag20 = (nint)0 == 0;
									object obj31 = !flag20;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int num;
									if (button == buttonSpades)
									{
										obj32 = 0;
										num = 0;
										goto IL_0976;
									}
									object obj33 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v88+E4]");
									bool flag21 = (nint)0 == 0;
									object obj34 = !flag21;
									if (obj34 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if (!(button == buttonHearts))
									{
										object obj35 = "https://www.kammelna.com/Home/Terms" + 896;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
										bool flag22 = (object)button == null;
										object obj36 = !flag22;
										string text;
										if (obj36 == null)
										{
											text = null;
										}
										else
										{
											string text2 = button.ToString();
											text = text2;
										}
										string text3 = default(string);
										string message = text3 + text;
										object obj37 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										ArgumentException ex = default(ArgumentException);
										ex..ctor(message);
										object obj38 = (nint)0 + (nint)352;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
										throw new OutOfMemoryException();
									}
									num = 0;
									obj27 = 1;
								}
							}
							obj32 = obj27;
							goto IL_0976;
						}
						button2 = button13;
					}
				}
			}
		}
		goto IL_0925;
		IL_01af:
		button2 = button7;
		goto IL_0925;
		IL_0285:
		button2 = button8;
		goto IL_0925;
		IL_0925:
		int num2 = BidValue(button2);
		object key = "alignContent" + 3552;
		SFSExtensions.Put(sFSObject, (string)key, num2);
		object obj39 = 0;
		int num3 = num2;
		goto IL_057d;
		IL_0976:
		object obj40 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object key2 = "rightCtrl" + 768;
		SFSExtensions.Put(sFSObject, (string)key2, friendlyName);
		obj39 = 0;
		num3 = (int)friendlyName;
		goto IL_057d;
		IL_00b1:
		object key3 = "not" + 3528;
		SFSExtensions.Put(sFSObject, (string)key3, val: true);
		obj39 = 0;
		num3 = 1;
		goto IL_057d;
		IL_057d:
		object obj41 = typeof(TypeConverter<ushort, char>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj42 = this + 184;
		object obj43 = default(object);
		obj42 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		isBidder = false;
		isNaturalFlowDisturbedThisRound = true;
		object obj44 = this + 64;
		obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateStateButtons();
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v15 (Il2CppClass<TarneebBiddingButtons>)+1B0]");
		UnityEngine.Object obj45 = (UnityEngine.Object)0;
		base.HideContainer();
		game.SendBidding(sFSObject);
	}

	protected override void UpdateStateButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018b: Expected I, but got O
		//IL_0193: Expected I, but got O
		//IL_01bc: Expected O, but got I4
		//IL_01f8: Expected O, but got I
		//IL_0a7c: Expected I, but got O
		//IL_0282: Expected O, but got I4
		//IL_0b21: Expected O, but got I4
		//IL_0b26: Expected I, but got O
		//IL_02b4: Expected I, but got O
		//IL_02bc: Expected I, but got O
		//IL_02e5: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_032a: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_039e: Expected O, but got I
		//IL_03d4: Expected O, but got I4
		//IL_0b58: Expected O, but got I4
		//IL_0b5d: Expected I, but got O
		//IL_0406: Expected I, but got O
		//IL_040e: Expected I, but got O
		//IL_0437: Expected O, but got I4
		//IL_0449: Expected O, but got I4
		//IL_047c: Expected O, but got I
		//IL_049e: Expected O, but got I4
		//IL_04cc: Expected O, but got I4
		//IL_04f0: Expected O, but got I
		//IL_0526: Expected O, but got I4
		//IL_0b8f: Expected O, but got I4
		//IL_0b94: Expected I, but got O
		//IL_0558: Expected I, but got O
		//IL_0560: Expected I, but got O
		//IL_0589: Expected O, but got I4
		//IL_059b: Expected O, but got I4
		//IL_05ce: Expected O, but got I
		//IL_05f0: Expected O, but got I4
		//IL_061e: Expected O, but got I4
		//IL_0642: Expected O, but got I
		//IL_0678: Expected O, but got I4
		//IL_0bc6: Expected O, but got I4
		//IL_0bcb: Expected I, but got O
		//IL_06aa: Expected I, but got O
		//IL_06b2: Expected I, but got O
		//IL_06db: Expected O, but got I4
		//IL_06ed: Expected O, but got I4
		//IL_0720: Expected O, but got I
		//IL_0742: Expected O, but got I4
		//IL_0770: Expected O, but got I4
		//IL_0794: Expected O, but got I
		//IL_07ca: Expected O, but got I4
		//IL_07ee: Expected O, but got I
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_080e: Expected O, but got I
		//IL_0a25: Expected O, but got I4
		//IL_0a2e: Expected O, but got I4
		//IL_0899: Expected O, but got I4
		//IL_090a: Expected O, but got I4
		//IL_0a11: Expected O, but got I4
		//IL_0a16: Expected I, but got O
		//IL_0936: Expected F8, but got I4
		//IL_0943: Expected O, but got F8
		//IL_09a1: Expected O, but got I
		//IL_09d5: Expected O, but got F8
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F0]");
		object obj2 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject gameObject2;
		List<object>.Enumerator enumerator;
		if (obj2 != null)
		{
			gameObject = biddingButtonsParent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66ED]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			enumerator = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			gameObject2 = biddingButtonsParent;
			if (!flag)
			{
				goto IL_0095;
			}
		}
		else
		{
			_ = 1;
			gameObject = biddingButtonsParent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66ED]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			enumerator = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			gameObject2 = biddingButtonsParent;
			if (obj5 != null)
			{
				goto IL_0095;
			}
		}
		_ = 1;
		CardGame cardGame = game;
		bool flag3 = (object)game == null;
		gameObject = gameObject2;
		if (!flag3)
		{
			goto IL_016f;
		}
		goto IL_0adc;
		IL_0aef:
		InvalidCastException ex = new InvalidCastException();
		nint num;
		bool flag4 = num != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		List<object>.Enumerator enumerator2;
		object obj6;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj6;
			enumerator2.Dispose();
			object obj7 = default(object);
			if (obj7 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223828C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0adc:
		enumerator2 = enumerator;
		throw new NullReferenceException();
		IL_016f:
		obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		num = (nint)obj6;
		nint num2 = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7 (Il2CppClass<CardGame>)+130]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
		bool flag5 = num3 < 0;
		object obj8 = !flag5;
		object obj9 = ~obj8;
		enumerator2 = enumerator;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7 (Il2CppClass<CardGame>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
			object obj10 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v9-8]");
			bool flag6 = 0 != num;
			enumerator2 = enumerator;
			if (!flag6)
			{
				if ((object)gameObject != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v19 (CardGame)+174]");
					bool flag7 = (nint)0 == 0;
					gameObject.SetActive(flag7);
					bool flag8 = (object)buttonDiamonds == null;
					object obj11 = 0;
					num = (flag7 ? 1 : 0);
					if (!flag8)
					{
						GameObject gameObject3 = buttonDiamonds.gameObject;
						CardGame cardGame2 = game;
						bool flag9 = (object)game == null;
						obj11 = 0;
						num = unchecked((nint)null);
						if (!flag9)
						{
							num = (nint)obj6;
							nint num5 = (nint)cardGame2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v6 (Il2CppClass<CardGame>)+130]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
							bool flag10 = num6 < 0;
							object obj12 = !flag10;
							object obj13 = ~obj12;
							obj11 = 0;
							enumerator2 = enumerator;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v6 (Il2CppClass<CardGame>)+C8]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
								object obj14 = num7 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X9_v8-8]");
								bool flag11 = 0 != num;
								obj11 = 0;
								enumerator2 = enumerator;
								if (!flag11)
								{
									bool flag12 = (object)gameObject3 == null;
									obj11 = 0;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v14 (CardGame)+174]");
										object obj15 = -1;
										bool flag13 = obj15 == null;
										gameObject3.SetActive(flag13);
										bool flag14 = (object)buttonClubs == null;
										obj11 = 0;
										num = (flag13 ? 1 : 0);
										if (!flag14)
										{
											GameObject gameObject4 = buttonClubs.gameObject;
											CardGame cardGame3 = game;
											bool flag15 = (object)game == null;
											obj11 = 0;
											num = unchecked((nint)null);
											if (!flag15)
											{
												num = (nint)obj6;
												nint num8 = (nint)cardGame3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X9_v10 (Il2CppClass<CardGame>)+130]");
												nint num9 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
												bool flag16 = num9 < 0;
												object obj16 = !flag16;
												object obj17 = ~obj16;
												obj11 = 0;
												enumerator2 = enumerator;
												if (obj17 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X9_v10 (Il2CppClass<CardGame>)+C8]");
													nint num10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
													object obj18 = num10 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X9_v12-8]");
													bool flag17 = 0 != num;
													obj11 = 0;
													enumerator2 = enumerator;
													if (!flag17)
													{
														bool flag18 = (object)gameObject4 == null;
														obj11 = 0;
														if (!flag18)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v18 (CardGame)+174]");
															object obj19 = -1;
															bool flag19 = obj19 == null;
															gameObject4.SetActive(flag19);
															bool flag20 = (object)buttonSpades == null;
															obj11 = 0;
															num = (flag19 ? 1 : 0);
															if (!flag20)
															{
																GameObject gameObject5 = buttonSpades.gameObject;
																CardGame cardGame4 = game;
																bool flag21 = (object)game == null;
																obj11 = 0;
																num = unchecked((nint)null);
																if (!flag21)
																{
																	num = (nint)obj6;
																	nint num11 = (nint)cardGame4;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X9_v14 (Il2CppClass<CardGame>)+130]");
																	nint num12 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
																	bool flag22 = num12 < 0;
																	object obj20 = !flag22;
																	object obj21 = ~obj20;
																	obj11 = 0;
																	enumerator2 = enumerator;
																	if (obj21 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X9_v14 (Il2CppClass<CardGame>)+C8]");
																		nint num13 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
																		object obj22 = num13 + 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X9_v16-8]");
																		bool flag23 = 0 != num;
																		obj11 = 0;
																		enumerator2 = enumerator;
																		if (!flag23)
																		{
																			bool flag24 = (object)gameObject5 == null;
																			obj11 = 0;
																			if (!flag24)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22 (CardGame)+174]");
																				object obj23 = -1;
																				bool flag25 = obj23 == null;
																				gameObject5.SetActive(flag25);
																				bool flag26 = (object)buttonHearts == null;
																				obj11 = 0;
																				num = (flag25 ? 1 : 0);
																				if (!flag26)
																				{
																					GameObject gameObject6 = buttonHearts.gameObject;
																					CardGame cardGame5 = game;
																					bool flag27 = (object)game == null;
																					obj11 = 0;
																					num = unchecked((nint)null);
																					if (!flag27)
																					{
																						num = (nint)obj6;
																						nint num14 = (nint)cardGame5;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X9_v18 (Il2CppClass<CardGame>)+130]");
																						nint num15 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
																						bool flag28 = num15 < 0;
																						object obj24 = !flag28;
																						object obj25 = ~obj24;
																						obj11 = 0;
																						enumerator2 = enumerator;
																						if (obj25 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X9_v18 (Il2CppClass<CardGame>)+C8]");
																							nint num16 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X1_v2 (Il2CppMethodInfo)+130]");
																							object obj26 = num16 + 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X9_v20-8]");
																							bool flag29 = 0 != num;
																							obj11 = 0;
																							enumerator2 = enumerator;
																							if (!flag29)
																							{
																								bool flag30 = (object)gameObject6 == null;
																								obj11 = 0;
																								if (!flag30)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v26 (CardGame)+174]");
																									object obj27 = -1;
																									bool flag31 = obj27 == null;
																									gameObject6.SetActive(flag31);
																									bool flag32 = allButtons == null;
																									obj11 = 0;
																									num = (flag31 ? 1 : 0);
																									if (!flag32)
																									{
																										object obj28 = (nint)0 + (nint)3176;
																										object obj29 = typeof(MemberAchievementClanFeedData) + 2976;
																										obj6 = (nint)0 + (nint)3632;
																										List<object>.Enumerator enumerator4 = ((List<object>)(object)allButtons).GetEnumerator();
																										List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
																										List<object>.Enumerator enumerator5 = enumerator3;
																										object obj30 = default(object);
																										while (true)
																										{
																											if (enumerator.MoveNext())
																											{
																												obj11 = obj28;
																												bool flag33 = Enumerable.Contains(stateButtons, obj30);
																												if (obj30 != null)
																												{
																													((Selectable)obj30).interactable = flag33;
																													object obj31 = obj29;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v44+E4]");
																													bool flag34 = (nint)0 == 0;
																													object obj32 = !flag34;
																													if (obj32 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													if ((UnityEngine.Object)obj30 == preDeterminedChoice)
																													{
																														Image image = ((Selectable)obj30).image;
																														TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(image, (Color)0, 1f);
																														double num17 = 1.0;
																														double num18 = 1.0;
																														double num19 = 1058444951.0;
																														enumerator5 = (List<object>.Enumerator)1.0;
																														continue;
																													}
																													Image image2 = ((Selectable)obj30).image;
																													int num20 = ShortcutExtensions.DOKill(image2);
																													Image image3 = ((Selectable)obj30).image;
																													if ((object)image3 != null)
																													{
																														image3.color = (Color)0;
																														double num17 = 1.0;
																														double num18 = 1.0;
																														double num19 = 1.0;
																														enumerator5 = (List<object>.Enumerator)1.0;
																														continue;
																													}
																													NullReferenceException ex3 = new NullReferenceException();
																													obj11 = 0;
																													num = unchecked((nint)null);
																													break;
																												}
																												NullReferenceException ex4 = new NullReferenceException();
																												num = (flag33 ? 1 : 0);
																												break;
																											}
																											enumerator.Dispose();
																											return;
																										}
																										enumerator3 = (List<object>.Enumerator)0;
																										enumerator = (List<object>.Enumerator)0;
																									}
																								}
																								goto IL_0adc;
																							}
																						}
																						goto IL_0aef;
																					}
																				}
																			}
																			goto IL_0adc;
																		}
																	}
																	goto IL_0aef;
																}
															}
														}
														goto IL_0adc;
													}
												}
												goto IL_0aef;
											}
										}
									}
									goto IL_0adc;
								}
							}
							goto IL_0aef;
						}
					}
				}
				goto IL_0adc;
			}
		}
		goto IL_0aef;
		IL_0095:
		cardGame = game;
		bool flag35 = (object)game == null;
		object obj33 = !flag35;
		if (obj33 != null)
		{
			goto IL_016f;
		}
		goto IL_0adc;
	}

	private int BidValue(Button button)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_0306: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		//IL_03e2: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_0424: Expected O, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E665D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v49+E4]");
			bool flag = (nint)0 == 0;
			obj5 = button7;
			obj6 = button7;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = button7;
			obj6 = button7;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = button == obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = obj6;
		if (obj8 != null)
		{
			goto IL_00d0;
		}
		goto IL_0181;
		IL_02c4:
		return 9;
		IL_00d0:
		return 7;
		IL_0397:
		return 10;
		IL_0091:
		bool flag5 = button == obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = obj5;
		if (!flag6)
		{
			goto IL_00d0;
		}
		goto IL_0181;
		IL_0181:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = button == button8;
			bool flag8 = !flag7;
			object obj12 = 0;
			UnityEngine.Object obj13 = button8;
			if (!flag8)
			{
				goto IL_01f1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = button == button8;
			bool flag10 = !flag9;
			object obj14 = !flag10;
			object obj12 = 0;
			UnityEngine.Object obj13 = button8;
			if (obj14 != null)
			{
				goto IL_01f1;
			}
		}
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = button == button9;
			bool flag12 = !flag11;
			object obj16 = 0;
			UnityEngine.Object obj17 = button9;
			if (!flag12)
			{
				goto IL_02c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = button == button9;
			bool flag14 = !flag13;
			object obj18 = !flag14;
			object obj16 = 0;
			UnityEngine.Object obj17 = button9;
			if (obj18 != null)
			{
				goto IL_02c4;
			}
		}
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag15 = button == button10;
			bool flag16 = !flag15;
			object obj20 = 0;
			UnityEngine.Object obj21 = button10;
			if (!flag16)
			{
				goto IL_0397;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag17 = button == button10;
			bool flag18 = !flag17;
			object obj22 = !flag18;
			object obj20 = 0;
			UnityEngine.Object obj21 = button10;
			if (obj22 != null)
			{
				goto IL_0397;
			}
		}
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v8+E4]");
		bool flag19 = (nint)0 == 0;
		object obj24 = !flag19;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (button == button11)
		{
			return 11;
		}
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v12+E4]");
		bool flag20 = (nint)0 == 0;
		object obj26 = !flag20;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (button == button12)
		{
			return 12;
		}
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v16+E4]");
		bool flag21 = (nint)0 == 0;
		object obj28 = !flag21;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag22 = button == button13;
		bool flag23 = !flag22;
		object obj29 = !flag23;
		object obj30 = ~obj29;
		if (obj30 == null)
		{
			return 13;
		}
		return 0;
		IL_01f1:
		return 8;
	}

	private unsafe bool isValidBid(Button button)
	{
		//IL_0016: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0061: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0162: Expected I, but got O
		//IL_018b: Expected O, but got I4
		//IL_07fa: Expected I4, but got O
		//IL_01c8: Expected O, but got I
		//IL_06b9: Expected O, but got I4
		//IL_06c2: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		//IL_077d: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_072d: Expected O, but got I4
		//IL_03f5: Expected O, but got I4
		//IL_03fa: Expected I, but got O
		//IL_03a5: Expected I, but got O
		//IL_07c3: Expected O, but got I4
		//IL_042c: Expected O, but got I
		//IL_0446: Expected O, but got I4
		//IL_0805: Expected O, but got I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_046f: Expected I, but got O
		//IL_0498: Expected O, but got I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected I4, but got Unknown
		//IL_04d4: Expected O, but got I
		//IL_056c: Expected O, but got I4
		//IL_0571: Expected I, but got O
		//IL_0329: Expected I, but got O
		//IL_0596: Expected O, but got I4
		//IL_0623: Expected O, but got I4
		//IL_05e6: Expected O, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F1]");
		object obj = (nint)0 & (nint)1;
		object obj4;
		object obj3;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66ED]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			obj3 = 152985600;
			obj4 = 152985600;
			if (!flag)
			{
				goto IL_0078;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66ED]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj3 = 152985600;
			obj4 = 152985600;
			if (obj6 != null)
			{
				goto IL_0078;
			}
		}
		_ = 1;
		CardGame cardGame = game;
		bool flag3 = (object)game == null;
		obj3 = obj4;
		if (!flag3)
		{
			goto IL_013e;
		}
		goto IL_07ec;
		IL_0294:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v47 (CardGame)+174]");
		int num;
		UnityEngine.Object obj8;
		object obj9;
		InvalidCastException ex;
		if ((nint)0 == 1)
		{
			num = typeof(MemberAchievementClanFeedData) + 2976;
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v48 (System.Int32)+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = button == buttonClubs;
				bool flag5 = !flag4;
				nint num2 = unchecked((nint)null);
				if (!flag5)
				{
					goto IL_0337;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = button == buttonClubs;
				bool flag7 = !flag6;
				object obj7 = !flag7;
				nint num2 = unchecked((nint)null);
				if (obj7 != null)
				{
					goto IL_0337;
				}
			}
			obj8 = buttonDiamonds;
			ex = (InvalidCastException)((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v22 (System.InvalidCastException)+E4]");
			if ((nint)0 == 0)
			{
				goto IL_067f;
			}
			bool flag8 = button == buttonDiamonds;
			bool flag9 = !flag8;
			obj9 = 0;
			if (!flag9)
			{
				goto IL_05f4;
			}
			goto IL_06d0;
		}
		goto IL_07e6;
		IL_067f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = button == obj8;
		bool flag11 = !flag10;
		object obj10 = !flag11;
		obj9 = 0;
		if (obj10 != null)
		{
			goto IL_05f4;
		}
		goto IL_06d0;
		IL_073b:
		return true;
		IL_0078:
		cardGame = game;
		bool flag12 = (object)game == null;
		object obj11 = !flag12;
		if (obj11 != null)
		{
			goto IL_013e;
		}
		goto IL_07ec;
		IL_013e:
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		obj8 = (UnityEngine.Object)obj12;
		nint num3 = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v2 (Il2CppClass<CardGame>)+130]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v12 (UnityEngine.Object)+130]");
		bool flag13 = num4 < 0;
		object obj13 = !flag13;
		object obj14 = ~obj13;
		num = 152985600;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v2 (Il2CppClass<CardGame>)+C8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v12 (UnityEngine.Object)+130]");
			object obj15 = num5 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v9-8]");
			bool flag14 = 0 != (nint)obj8;
			num = 152985600;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v47 (CardGame)+174]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v2 (Il2CppClass<CardGame>)+130]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v12 (UnityEngine.Object)+130]");
					bool flag15 = num6 < 0;
					object obj16 = !flag15;
					object obj17 = ~obj16;
					bool flag16;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v9-8]");
						object obj18 = 0 - obj8;
						flag16 = obj18 == null;
					}
					else
					{
						flag16 = false;
					}
					object obj19 = !flag16;
					nint num2 = default(nint);
					IntPtr intPtr = num2;
					num = 152985600;
					if (obj19 == null)
					{
						goto IL_0294;
					}
				}
				else
				{
					object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v30+E4]");
					nint num2;
					if ((nint)0 != 0)
					{
						bool flag17 = button == buttonPass;
						bool flag18 = !flag17;
						num2 = unchecked((nint)null);
						if (!flag18)
						{
							goto IL_03b3;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag19 = button == buttonPass;
						bool flag20 = !flag19;
						object obj22 = !flag20;
						num2 = unchecked((nint)null);
						if (obj22 != null)
						{
							goto IL_03b3;
						}
					}
					int num7 = BidValue(button);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X22_v2+6ED]");
					object obj23 = (nint)0 & (nint)1;
					bool flag21 = obj23 == null;
					object obj24 = !flag21;
					if (obj24 == null)
					{
						_ = 1;
					}
					cardGame = game;
					if ((object)game == null)
					{
						goto IL_07ec;
					}
					obj8 = (UnityEngine.Object)obj12;
					nint num8 = (nint)cardGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v11 (Il2CppClass<CardGame>)+130]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v12 (UnityEngine.Object)+130]");
					bool flag22 = num9 < 0;
					object obj25 = !flag22;
					object obj26 = ~obj25;
					num = num7;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v11 (Il2CppClass<CardGame>)+C8]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v12 (UnityEngine.Object)+130]");
						object obj27 = num10 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X9_v13-8]");
						bool flag23 = 0 != (nint)obj8;
						num = num7;
						if (!flag23)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v47 (CardGame)+170]");
							if ((nint)num7 > (nint)0)
							{
								return true;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v11 (Il2CppClass<CardGame>)+130]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v12 (UnityEngine.Object)+130]");
							bool flag24 = num11 < 0;
							object obj28 = !flag24;
							object obj29 = ~obj28;
							bool flag25;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X9_v13-8]");
								object obj30 = 0 - obj8;
								flag25 = obj30 == null;
							}
							else
							{
								flag25 = false;
							}
							IntPtr intPtr = num2;
							num = num7;
							if (flag25)
							{
								goto IL_0294;
							}
						}
					}
				}
			}
		}
		ex = new InvalidCastException();
		goto IL_067f;
		IL_0337:
		return true;
		IL_07ec:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_05f4:
		return true;
		IL_07e6:
		return false;
		IL_03b3:
		return true;
		IL_06d0:
		int value2 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v7 (System.Int32)+E4]");
		if ((nint)0 != 0)
		{
			bool flag26 = button == buttonSpades;
			bool flag27 = !flag26;
			object obj31 = 0;
			if (!flag27)
			{
				goto IL_073b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag28 = button == buttonSpades;
			bool flag29 = !flag28;
			object obj32 = !flag29;
			object obj31 = 0;
			if (obj32 != null)
			{
				goto IL_073b;
			}
		}
		int value3 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v9 (System.Int32)+E4]");
		bool flag30 = (nint)0 == 0;
		object obj33 = !flag30;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (button == buttonHearts)
		{
			return true;
		}
		goto IL_07e6;
	}

	private void <Awake>b__20_0(Button button)
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
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2376;
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
		object obj7 = (nint)0 + (nint)2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	private bool <getStateButtons>b__21_0(Button b)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_02d4: Expected I4, but got O
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0198: Expected I, but got O
		//IL_01c1: Expected O, but got I4
		//IL_01f5: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected I4, but got Unknown
		//IL_02a6: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected I4, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = buttonPass;
			obj6 = buttonPass;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = buttonPass;
			obj6 = buttonPass;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = b == obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00c0;
		}
		goto IL_0161;
		IL_00c0:
		return true;
		IL_0161:
		int num = BidValue(b);
		CardGame cardGame = game;
		if ((object)game != null)
		{
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
			object obj10 = obj9;
			nint num2 = (nint)cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8 (Il2CppClass<CardGame>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X1_v4+130]");
			bool flag5 = num3 < 0;
			object obj11 = !flag5;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8 (Il2CppClass<CardGame>)+C8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X1_v4+130]");
				object obj13 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v11-8]");
				if (0 == (nint)obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v5 (CardGame)+170]");
					object obj14 = (nint)num - (nint)0;
					bool flag6 = (nint)obj14 < 0;
					bool flag7 = obj14 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v5 (CardGame)+170]");
					int num5 = (int)((nint)num ^ (nint)0);
					int num6 = num ^ obj14;
					int num7 = num5 & num6;
					bool flag8 = num7 < 0;
					bool flag9 = flag6 == flag8;
					object obj15 = !flag7;
					return (byte)((flag9 & obj15) ? 1 : 0) != 0;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_0091:
		if (b == obj5)
		{
			goto IL_00c0;
		}
		goto IL_0161;
	}

	private bool <ShowPredetermineBid>b__22_0(Button b)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_02d4: Expected I4, but got O
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0198: Expected I, but got O
		//IL_01c1: Expected O, but got I4
		//IL_01f5: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected I4, but got Unknown
		//IL_02a6: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected I4, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F3]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = buttonPass;
			obj6 = buttonPass;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = buttonPass;
			obj6 = buttonPass;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = b == obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00c0;
		}
		goto IL_0161;
		IL_00c0:
		return true;
		IL_0161:
		int num = BidValue(b);
		CardGame cardGame = game;
		if ((object)game != null)
		{
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
			object obj10 = obj9;
			nint num2 = (nint)cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8 (Il2CppClass<CardGame>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X1_v4+130]");
			bool flag5 = num3 < 0;
			object obj11 = !flag5;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8 (Il2CppClass<CardGame>)+C8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X1_v4+130]");
				object obj13 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v11-8]");
				if (0 == (nint)obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v5 (CardGame)+170]");
					object obj14 = (nint)num - (nint)0;
					bool flag6 = (nint)obj14 < 0;
					bool flag7 = obj14 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v5 (CardGame)+170]");
					int num5 = (int)((nint)num ^ (nint)0);
					int num6 = num ^ obj14;
					int num7 = num5 & num6;
					bool flag8 = num7 < 0;
					bool flag9 = flag6 == flag8;
					object obj15 = !flag7;
					return (byte)((flag9 & obj15) ? 1 : 0) != 0;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_0091:
		if (b == obj5)
		{
			goto IL_00c0;
		}
		goto IL_0161;
	}
}
