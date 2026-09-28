using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class TeamsDetails : MonoBehaviour
{
	private sealed class <>c__DisplayClass8_0
	{
		public int index;

		public TeamsDetails <>4__this;

		internal void <Start>b__0()
		{
			TeamsDetails teamsDetails = <>4__this;
			List<KPlayer> players = teamsDetails.game.Players;
			object player = ((List<object>)(object)players).get_Item(index);
			teamsDetails.gameEventsChannel.TriggerPlayerClicked((KPlayer)player);
		}
	}

	private AvatarInitializer bottomPlayer;

	private AvatarInitializer rightPlayer;

	private AvatarInitializer topPlayer;

	private AvatarInitializer leftPlayer;

	private GameEventsChannel gameEventsChannel;

	private SlideAnimationHelper WatchersSlider;

	private KGame game;

	private List<AvatarInitializer> _players;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a18: Expected O, but got I
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected O, but got Unknown
		//IL_0a38: Expected O, but got I
		//IL_0a62: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_01af: Expected O, but got I
		//IL_01bf: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_026c: Expected O, but got I4
		//IL_02ef: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I4
		//IL_0429: Expected O, but got I
		//IL_0439: Expected O, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_04de: Expected O, but got I4
		//IL_0561: Expected O, but got I
		//IL_0571: Expected O, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_05eb: Expected O, but got I
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_060b: Expected O, but got I
		//IL_0a91: Expected O, but got I4
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_08c6: Expected O, but got I
		//IL_08ce: Expected I, but got O
		//IL_08dc: Expected I, but got O
		//IL_08fb: Expected O, but got I4
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		//IL_094c: Expected O, but got I
		//IL_0954: Expected I, but got O
		//IL_0962: Expected I, but got O
		//IL_097c: Expected O, but got I4
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_0703: Expected O, but got I
		//IL_070b: Expected I, but got O
		//IL_073e: Expected O, but got I4
		//IL_09b9: Expected O, but got I
		//IL_09c1: Expected I, but got O
		//IL_09cf: Expected I, but got O
		//IL_09e9: Expected O, but got I4
		//IL_079a: Expected O, but got I
		//IL_07ac: Expected I, but got O
		//IL_07bd: Expected I, but got O
		//IL_07e2: Expected O, but got I4
		//IL_080e: Expected O, but got I
		//IL_083e: Expected O, but got I4
		//IL_0847: Expected O, but got I4
		//IL_0862: Expected O, but got I4
		//IL_0872: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		UnityEvent unityEvent = (UnityEvent)(typeof(List<AdaptivePerformanceScaler>) + 208);
		object obj3 = (nint)0 + (nint)1440;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 80;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = (UnityAction)obj3;
		List<object> list = default(List<object>);
		list..ctor();
		if (list != null)
		{
			object obj8 = (nint)0 + (nint)1448;
			object obj9 = obj8;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag2 = list._items == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X21_v5-30]");
			unityAction = (UnityAction)0;
			if (!flag2)
			{
				bool flag3 = list._size < items.Length;
				object obj10 = !flag3;
				nint num = default(nint);
				if (obj10 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj11 = list._items + list._size;
					object obj12 = obj11 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X21_v5-30]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v14+20]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v39+C0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v40+70]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X21_v5-30]");
					list.AddWithResize((object)0);
				}
				object obj15 = obj8;
				int version2 = list._version + 1;
				list._version = version2;
				items = list._items;
				bool flag4 = list._items == null;
				unityAction = (UnityAction)(object)rightPlayer;
				if (!flag4)
				{
					bool flag5 = list._size < items.Length;
					obj10 = !flag5;
					if (obj10 == null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj16 = list._items + list._size;
						object obj17 = obj16 + 32;
						obj17 = rightPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v16+20]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v36+C0]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v37+70]");
						num = 0;
						list.AddWithResize((object)rightPlayer);
					}
					object obj20 = obj8;
					int version3 = list._version + 1;
					list._version = version3;
					items = list._items;
					bool flag6 = list._items == null;
					unityAction = (UnityAction)(object)topPlayer;
					if (!flag6)
					{
						bool flag7 = list._size < items.Length;
						obj10 = !flag7;
						if (obj10 == null)
						{
							int size3 = list._size + 1;
							list._size = size3;
							object obj21 = list._items + list._size;
							object obj22 = obj21 + 32;
							obj22 = topPlayer;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v18+20]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v33+C0]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v34+70]");
							num = 0;
							list.AddWithResize((object)topPlayer);
						}
						object obj25 = obj8;
						int version4 = list._version + 1;
						list._version = version4;
						items = list._items;
						bool flag8 = list._items == null;
						unityAction = (UnityAction)(object)leftPlayer;
						if (!flag8)
						{
							bool flag9 = list._size < items.Length;
							obj10 = !flag9;
							if (obj10 == null)
							{
								int size4 = list._size + 1;
								list._size = size4;
								object obj26 = list._items + list._size;
								object obj27 = obj26 + 32;
								obj27 = leftPlayer;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v20+20]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v30+C0]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v31+70]");
								num = 0;
								list.AddWithResize((object)leftPlayer);
							}
							object obj30 = this + 88;
							obj30 = list;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj31 = obj30;
							bool flag10 = obj30 == null;
							unityAction = (UnityAction)(object)list;
							if (!flag10)
							{
								object obj32 = (nint)0 + (nint)3640;
								object obj33 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
								object obj34 = (nint)0 + (nint)2792;
								object obj36 = default(object);
								object obj35 = obj36;
								UnityEvent unityEvent2 = unityEvent;
								nint num2 = num;
								UnityAction unityAction2 = (UnityAction)(object)list;
								int num3 = 0;
								object obj38 = default(object);
								object obj41 = default(object);
								UnityAction unityAction3 = default(UnityAction);
								object obj42;
								Action action = default(Action);
								KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
								Action action2 = default(Action);
								do
								{
									int num4 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v23+18]");
									bool flag11 = (nint)num4 < (nint)0;
									obj10 = !flag11;
									int num5 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v23+18]");
									bool flag12 = (nint)num5 >= (nint)0;
									obj36 = obj35;
									unityEvent = unityEvent2;
									num = num2;
									unityAction = unityAction2;
									if (!flag12)
									{
										object obj37 = typeof(SkeletonBinary.SkeletonInput) + 2560;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj38..ctor();
										bool flag13 = obj38 == null;
										obj36 = obj35;
										unityEvent = unityEvent2;
										num = num2;
										unityAction = null;
										if (flag13)
										{
											break;
										}
										unityEvent = (UnityEvent)(obj38 + 24);
										unityEvent = (UnityEvent)(object)this;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag14 = _players == null;
										obj36 = obj35;
										num = num2;
										unityAction = (UnityAction)(object)this;
										if (flag14)
										{
											break;
										}
										object obj39 = (nint)0 + (nint)1472;
										num = (nint)obj39;
										object obj40 = ((List<object>)(object)_players).get_Item(num3);
										bool flag15 = obj40 == null;
										obj36 = obj35;
										unityAction = (UnityAction)num3;
										if (flag15)
										{
											break;
										}
										_ = 34;
										unityAction = (UnityAction)obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
										bool flag16 = obj41 == null;
										obj36 = obj35;
										if (flag16)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v35+100]");
										unityEvent = (UnityEvent)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										num = (nint)obj34;
										unityAction3..ctor(obj38, (IntPtr)obj34);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v35+100]");
										bool flag17 = (nint)0 == 0;
										obj36 = 0;
										unityAction = (UnityAction)obj38;
										if (flag17)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v35+100]");
										((UnityEvent)0).AddListener(unityAction3);
										num3++;
										obj31 = obj30;
										bool flag18 = obj30 == null;
										obj42 = !flag18;
										obj36 = 0;
										num = 0;
										unityAction = unityAction3;
										obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v35+100]");
										unityEvent2 = (UnityEvent)0;
										num2 = 0;
										unityAction2 = unityAction3;
										continue;
									}
									object obj43 = typeof(SqlSingle[]) + 2376;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj44 = (nint)0 + (nint)1360;
									num = (nint)obj44;
									action..ctor(this, (IntPtr)obj44);
									bool flag19 = (object)game == null;
									obj36 = 0;
									unityAction = (UnityAction)(object)this;
									if (flag19)
									{
										break;
									}
									game.OnGameInitialized += action;
									object obj45 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj46 = (nint)0 + (nint)1376;
									num = (nint)obj46;
									playerSwitchSeatDelegate..ctor(this, (IntPtr)obj46);
									bool flag20 = (object)game == null;
									obj36 = 0;
									unityAction = (UnityAction)(object)this;
									if (flag20)
									{
										break;
									}
									game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj47 = (nint)0 + (nint)1384;
									num = (nint)obj47;
									action2..ctor(this, (IntPtr)obj47);
									bool flag21 = (object)gameEventsChannel == null;
									obj36 = 0;
									unityAction = (UnityAction)(object)this;
									if (flag21)
									{
										break;
									}
									gameEventsChannel.ToggleTeamsDetails += action2;
									return;
								}
								while (obj42 != null);
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00db: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)1384;
		gameEventsChannel.OnPanelShow -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj5 = (nint)0 + (nint)1352;
		gameEventsChannel.ToggleTeamsDetails -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj5);
		gameEventsChannel.OnDismissibleClicked -= action3;
	}

	private void OnDismissibleClicked(GameCard obj)
	{
		Close();
	}

	private void OnPanelShow()
	{
		Close();
	}

	private void OnToggleTeamsDetails()
	{
		Toggle();
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
		//IL_0096: Expected O, but got I4
		List<object> players = (List<object>)(object)_players;
		int num = 0;
		while (num < players._size)
		{
			object obj = players.get_Item(num);
			List<KPlayer> players2 = game.Players;
			object player = ((List<object>)(object)players2).get_Item(num);
			((AvatarInitializer)obj).Initialize((KPlayer)player);
			num++;
			players = (List<object>)(object)_players;
			bool flag = _players == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	public void Toggle()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		if (game.IsReplay)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = WatchersSlider;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_00e6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)WatchersSlider)
			{
				goto IL_00e6;
			}
		}
		goto IL_011b;
		IL_00e6:
		SlideAnimationHelper watchersSlider = WatchersSlider;
		if (watchersSlider.<IsShown>k__BackingField)
		{
			goto IL_011b;
		}
		Open();
		return;
		IL_011b:
		Close();
	}

	public void Open()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_008e: Expected I, but got O
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00df: Expected I, but got O
		//IL_0110: Expected I, but got O
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		gameEventsChannel.TriggerPanelShow();
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj2 = (nint)0 + (nint)1352;
		gameEventsChannel.TriggerShowDismissibleBlocker();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1368;
		gameEventsChannel.OnDismissibleClicked += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		gameEventsChannel.OnPanelShow -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj4);
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		gameEventsChannel.OnPanelShow += action4;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!WatchersSlider)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = WatchersSlider;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				return;
			}
		}
		WatchersSlider.SlideIn();
	}

	public void Close()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj2 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1368;
		gameEventsChannel.OnDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		gameEventsChannel.OnPanelShow -= action2;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		gameEventsChannel.TriggerHideDismissibleBlocker();
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			if (!WatchersSlider)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = WatchersSlider;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				return;
			}
		}
		WatchersSlider.SlideOut();
	}
}
