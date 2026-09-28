using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class MassLeaderboardPopup : MassWidget, IInitializable
{
	private sealed class <>c__DisplayClass10_0
	{
		public MassLeaderboardPopup <>4__this;

		public MassEventModel tInfo;

		internal void <IInitializable.Initialize>b__0(List<MassEventWinner> a)
		{
			MassLeaderboardPopup massLeaderboardPopup = <>4__this;
			MassEventModel massEventModel = tInfo;
			massLeaderboardPopup.massWinnersPanel.Populate(a, massEventModel.<Prizes>k__BackingField, massEventModel.<Id>k__BackingField);
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public int tabindex;

		public MassLeaderboardPopup <>4__this;

		internal void <CreateTabs>b__0()
		{
			<>4__this.OpenTab(tabindex);
		}
	}

	private SlideAnimationHelper popup;

	private TopPlayersList topPlayers;

	private MassWinnersPanel massWinnersPanel;

	private StageTab tabPrefab;

	private Transform tabsParent;

	private TextMeshProUGUI titleText;

	private GameObject leaderboardsPanel;

	private GameObject winnersPanel;

	private GameObject StageNotReached;

	private List<StageTab> tabs;

	void IInitializable.Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0115: Expected I, but got O
		//IL_0135: Expected I, but got O
		//IL_0179: Expected O, but got I
		//IL_018c: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass10_0 <>c__DisplayClass10_ = default(<>c__DisplayClass10_0);
		<>c__DisplayClass10_..ctor();
		object obj2 = <>c__DisplayClass10_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		popup.SlideIn();
		int activeStageId = ((MassTournamentServerConnector)(object)popup).GetActiveStageId();
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)activeStageId).GetTournamentLiveData();
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2408;
		object obj4 = (nint)0 + (nint)272;
		object obj5 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2392;
		object obj6 = (nint)0 + (nint)696;
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		object obj7 = <>c__DisplayClass10_ + 24;
		obj7 = cachedMassEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CreateTabs();
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentError tournamentError = default(SFS.TournamentError);
		tournamentError..ctor(null, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.MassWinnersListSuccess massWinnersListSuccess = default(SFS.MassWinnersListSuccess);
		massWinnersListSuccess..ctor(<>c__DisplayClass10_, (IntPtr)obj6);
		SFS.GetMassWinnersList(lifecycle, tournamentError, massWinnersListSuccess);
		object obj8 = ((List<object>)(object)tabs).get_Item(activeStageId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v26 (System.Object)+38]");
		Toggle toggle = (Toggle)0;
		object obj9 = ~(toggle.m_IsOn ? 1 : 0);
		bool isOn = (byte)(1 & obj9) != 0;
		toggle.isOn = isOn;
	}

	private void CreateTabs()
	{
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_00be: Expected O, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_043b: Expected O, but got I
		//IL_0446: Expected O, but got I4
		//IL_0477: Expected I, but got O
		//IL_0488: Expected I, but got O
		//IL_0330: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I4
		//IL_03ce: Expected O, but got I4
		object obj = this + 128;
		if (obj != null)
		{
			return;
		}
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		List<MassEventStageViewModel> <Stages>k__BackingField = cachedMassEvent.<Stages>k__BackingField;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (<Stages>k__BackingField._size >= 1)
		{
			object obj3 = -<Stages>k__BackingField._size;
			object obj4 = (nint)0 + (nint)704;
			object obj5 = typeof(SqlSingle[]) + 2376;
			object obj6 = (nint)0 + (nint)2616;
			object obj7 = list;
			int num = 0;
			<>c__DisplayClass11_0 <>c__DisplayClass11_ = default(<>c__DisplayClass11_0);
			StageTab stageTab = default(StageTab);
			Action action = default(Action);
			while (true)
			{
				object obj8 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2936;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				<>c__DisplayClass11_..ctor();
				object obj9 = <>c__DisplayClass11_ + 24;
				obj9 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj12 = !flag;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj13 = (nint)0 + (nint)704;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				<>c__DisplayClass11_.tabindex = num;
				object obj14 = obj3 + num;
				object obj15 = obj14 + 1;
				bool flag2 = obj15 == null;
				object obj16 = !flag2;
				<>c__DisplayClass11_0 <>c__DisplayClass11_2 = (<>c__DisplayClass11_0)((obj16 != null) ? ((object)<>c__DisplayClass11_) : ((object)this));
				object obj17 = (nint)0 + (nint)3112;
				object obj18 = !flag2;
				object obj19 = ((obj18 != null) ? obj4 : obj17);
				stageTab.SetText(num, flag2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num2 = (nint)obj19;
				action..ctor(<>c__DisplayClass11_2, (IntPtr)obj19);
				stageTab.SetToggle(action);
				List<object> list2 = (List<object>)(object)tabs;
				object obj20 = obj6;
				int version = list2._version + 1;
				list2._version = version;
				object[] items = list2._items;
				bool flag3 = list2._size < items.Length;
				object obj21 = !flag3;
				if (obj21 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v23+20]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v25+C0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v26+70]");
					num2 = 0;
					list2.AddWithResize((object)stageTab);
					num++;
					object obj24 = obj3 + num;
					bool flag4 = obj24 == null;
					object obj25 = 0;
					obj7 = stageTab;
					if (flag4)
					{
						break;
					}
				}
				else
				{
					int size = list2._size + 1;
					list2._size = size;
					object obj26 = items + list2._size;
					object obj27 = obj26 + 32;
					obj27 = stageTab;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num++;
					object obj28 = obj3 + num;
					bool flag5 = obj28 == null;
					object obj29 = !flag5;
					object obj25 = 0;
					obj7 = stageTab;
					if (obj29 == null)
					{
						break;
					}
				}
			}
		}
		GameObject gameObject = tabPrefab.gameObject;
		gameObject.SetActive(value: false);
	}

	private void OpenTab(int stageId)
	{
		//IL_0021: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		//IL_008e: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected I4, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
		object obj = stageId - activeStageId;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = stageId ^ activeStageId;
		int num2 = stageId ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		bool active = (byte)((flag4 & obj2) ? 1 : 0) != 0;
		StageNotReached.SetActive(active);
		winnersPanel.SetActive(value: false);
		leaderboardsPanel.SetActive(value: true);
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MassTournamentStageLeaderboardSource massTournamentStageLeaderboardSource = default(MassTournamentStageLeaderboardSource);
		massTournamentStageLeaderboardSource..ctor(_connector, stageId);
		object text = "Network Authentication Required" + 3304;
		topPlayers.SetSource(massTournamentStageLeaderboardSource);
		int order = stageId + 1;
		TextMeshProExtensions.LocalizeOrdinal(titleText, (string)text, order);
	}

	private void OpenFinalsTab()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		leaderboardsPanel.SetActive(value: false);
		object text = "fetch_products" + 256;
		winnersPanel.SetActive(value: true);
		TextMeshProExtensions.Localize(titleText, (string)text);
	}

	protected override void Initialize()
	{
	}
}
