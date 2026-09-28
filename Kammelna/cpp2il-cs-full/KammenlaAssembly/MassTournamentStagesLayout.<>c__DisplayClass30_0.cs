using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class MassTournamentStagesLayout : MassWidget
{
	private sealed class <>c__DisplayClass30_0
	{
		public int tabindex;

		public MassTournamentStagesLayout <>4__this;

		internal void <CreateTabs>b__0()
		{
			<>4__this.OpenTab(tabindex);
		}
	}

	private ComponentReference<MassTournamentPrizesPanel> prizePanelReference;

	private Image smallAd;

	private Transform layout;

	private StageTab prefab;

	private TextMeshProUGUI titleText;

	private GameObject NotStartedStageStatus;

	private GameObject StartedStageStatus;

	private GameObject stageTabGameObjects;

	private TextMeshProUGUI participantCount;

	private NumberFormatter participantCountFormatter;

	private TextMeshProUGUI stageDurationText;

	private MassDynamicPlayPeriodsInfoUI playPeriodsInfoUI;

	private TextMeshProUGUI triesText;

	private TextMeshProUGUI eligibilityText;

	private TextMeshProUGUI tournamentSizeText;

	private TextMeshProUGUI tournamentPrizeText;

	private TextMeshProUGUI tournamentSecondPrizeText;

	private TextMeshProUGUI tournamentThirdPrizeText;

	private GameObject secondPlaceLayout;

	private GameObject thirdPlaceLayout;

	private GameObject finalStageTabGameObjects;

	private TextMeshProUGUI finalRegPeriodText;

	private TextMeshProUGUI finalStartTimeText;

	private TextMeshProUGUI finalTournamentSizeText;

	private TextMeshProUGUI finalTournamentSizeTileText;

	private List<StageTab> tabs;

	private List<MassRuntimeStageSummery> stagesSummaries;

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged -= action;
	}

	public void ShowPrizes()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2648;
		object obj2 = (nint)0 + (nint)3576;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2128;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void Reload(MassTournamentPlayerState _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00de: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2408;
		object obj2 = (nint)0 + (nint)3592;
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2384;
		object obj4 = (nint)0 + (nint)3600;
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentError tournamentError = default(SFS.TournamentError);
		tournamentError..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.MassStagesListSuccess massStagesListSuccess = default(SFS.MassStagesListSuccess);
		massStagesListSuccess..ctor(this, (IntPtr)obj4);
		SFS.GetMassTournamentStagesSummery(gameObject, tournamentError, massStagesListSuccess);
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)gameObject).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		UIExtensions.LoadMassTournamentImage(smallAd, cachedMassEvent, ImageCacher.MassTournamentImageType.SmallAd);
	}

	private void CreateTabs()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_00fa: Expected O, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		//IL_044f: Expected O, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0298: Expected O, but got I4
		//IL_046f: Expected O, but got I
		//IL_047a: Expected O, but got I4
		//IL_04ab: Expected I, but got O
		//IL_04bc: Expected I, but got O
		//IL_034d: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0159: Expected O, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		if (tabs != null)
		{
			return;
		}
		secondPlaceLayout.SetActive(value: false);
		thirdPlaceLayout.SetActive(value: false);
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)thirdPlaceLayout).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		List<MassEventStageViewModel> <Stages>k__BackingField = cachedMassEvent.<Stages>k__BackingField;
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		tabs = (List<StageTab>)(object)list;
		object obj2 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (<Stages>k__BackingField._size >= 1)
		{
			object obj3 = -<Stages>k__BackingField._size;
			object obj4 = (nint)0 + (nint)1032;
			object obj5 = typeof(SqlSingle[]) + 2376;
			object obj6 = (nint)0 + (nint)2616;
			nint num = 0;
			object obj7 = list;
			int num2 = 0;
			object obj9 = default(object);
			StageTab stageTab = default(StageTab);
			Action action = default(Action);
			while (true)
			{
				object obj8 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj9..ctor();
				object obj10 = obj9 + 24;
				obj10 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj13 = !flag;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj14 = (nint)0 + (nint)704;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				object obj15 = obj3 + num2;
				object obj16 = obj15 + 1;
				bool flag2 = obj16 == null;
				object obj17 = !flag2;
				object obj18 = ((obj17 != null) ? obj9 : this);
				object obj19 = (nint)0 + (nint)3608;
				object obj20 = !flag2;
				object obj21 = ((obj20 != null) ? obj4 : obj19);
				stageTab.SetText(num2, flag2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num = (nint)obj21;
				action..ctor(obj18, (IntPtr)obj21);
				stageTab.SetToggle(action);
				List<object> list2 = (List<object>)(object)tabs;
				object obj22 = obj6;
				int version = list2._version + 1;
				list2._version = version;
				object[] items = list2._items;
				bool flag3 = list2._size < items.Length;
				object obj23 = !flag3;
				if (obj23 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v23+20]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v25+C0]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v26+70]");
					num = 0;
					list2.AddWithResize((object)stageTab);
					num2++;
					object obj26 = obj3 + num2;
					bool flag4 = obj26 == null;
					object obj27 = 0;
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
					object obj28 = items + list2._size;
					object obj29 = obj28 + 32;
					obj29 = stageTab;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2++;
					object obj30 = obj3 + num2;
					bool flag5 = obj30 == null;
					object obj31 = !flag5;
					object obj27 = 0;
					obj7 = stageTab;
					if (obj31 == null)
					{
						break;
					}
				}
			}
		}
		GameObject gameObject = prefab.gameObject;
		gameObject.SetActive(value: false);
	}

	private unsafe void OpenTab(int stageId)
	{
		//IL_002b: Expected I, but got O
		//IL_0072: Expected I, but got O
		//IL_00a2: Expected I, but got O
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0133: Expected O, but got I4
		//IL_0143: Expected I4, but got O
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_027f: Expected O, but got I4
		//IL_0284: Expected I, but got O
		//IL_028c: Expected I4, but got O
		//IL_018b: Expected O, but got I
		//IL_0193: Expected I, but got O
		//IL_01be: Expected O, but got I4
		//IL_02ba: Expected O, but got I
		//IL_02c2: Expected I4, but got O
		//IL_02d3: Expected O, but got I
		//IL_01ee: Expected O, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0332: Expected O, but got I4
		//IL_021c: Expected I, but got O
		//IL_022c: Expected O, but got I
		//IL_0253: Expected I4, but got O
		//IL_0e74: Expected O, but got I
		//IL_0e74: Expected O, but got I
		//IL_0e9d: Expected I, but got O
		//IL_0ea5: Expected I4, but got O
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_03b4: Expected I, but got O
		//IL_0459: Expected I, but got O
		//IL_03f7: Expected I, but got O
		//IL_0425: Expected I, but got O
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_04f2: Expected O, but got I4
		//IL_0519: Expected O, but got I4
		//IL_051e: Expected I, but got O
		//IL_05d0: Expected O, but got I4
		//IL_05d5: Expected I, but got O
		//IL_0561: Expected I, but got O
		//IL_0593: Expected O, but got I4
		//IL_0598: Expected I, but got O
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_0716: Expected O, but got I4
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected O, but got Unknown
		//IL_0ed7: Expected I8, but got I
		//IL_0ee0: Expected I, but got O
		//IL_069d: Expected O, but got I4
		//IL_074b: Expected O, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06de: Expected I, but got O
		//IL_07f0: Expected O, but got I4
		//IL_0786: Expected I, but got O
		//IL_07b8: Expected O, but got I4
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0854: Expected O, but got I
		//IL_086c: Expected O, but got I4
		//IL_0874: Expected I, but got O
		//IL_087c: Expected I4, but got O
		//IL_0b5b: Expected O, but got I
		//IL_08a4: Expected O, but got I4
		//IL_08ac: Expected I, but got O
		//IL_08b4: Expected I4, but got O
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected O, but got Unknown
		//IL_099b: Expected O, but got I
		//IL_09d2: Expected O, but got I4
		//IL_0c70: Expected O, but got I
		//IL_0ca7: Expected O, but got I4
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected O, but got Unknown
		//IL_0a0b: Expected I8, but got I4
		//IL_0a14: Expected I, but got O
		//IL_0942: Expected O, but got I4
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected O, but got Unknown
		//IL_0ce0: Expected I8, but got I4
		//IL_0ce9: Expected I, but got O
		//IL_0c17: Expected O, but got I4
		//IL_0a39: Expected O, but got I4
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_0980: Expected I, but got O
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected O, but got Unknown
		//IL_0c55: Expected I, but got O
		//IL_0ade: Expected O, but got I4
		//IL_0a74: Expected I, but got O
		//IL_0aa6: Expected O, but got I4
		//IL_0d40: Expected I, but got O
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Expected O, but got Unknown
		//IL_0b30: Expected O, but got I4
		//IL_0b38: Expected I, but got O
		//IL_0b40: Expected I4, but got O
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		GameObjectHelpers.Disable(finalStageTabGameObjects);
		GameObjectHelpers.Enable(stageTabGameObjects);
		bool flag = (object)secondPlaceLayout == null;
		bool flag2 = false;
		object obj2;
		if (!flag)
		{
			secondPlaceLayout.SetActive(value: false);
			bool flag3 = (object)thirdPlaceLayout == null;
			nint num = unchecked((nint)null);
			flag2 = false;
			if (!flag3)
			{
				thirdPlaceLayout.SetActive(value: false);
				MassEventModel tournamentData = TournamentData;
				bool flag4 = TournamentData == null;
				num = unchecked((nint)null);
				flag2 = false;
				if (!flag4)
				{
					bool flag5 = tournamentData.<Stages>k__BackingField == null;
					num = unchecked((nint)null);
					flag2 = false;
					if (!flag5)
					{
						object obj = "Network Authentication Required" + 3304;
						obj2 = ((List<object>)(object)tournamentData.<Stages>k__BackingField).get_Item(stageId);
						SetActiveState((MassEventStageViewModel)obj2);
						int num2 = stageId + 1;
						TextMeshProExtensions.LocalizeOrdinal(titleText, (string)obj, num2);
						List<object> list = (List<object>)(object)stagesSummaries;
						bool flag6 = stagesSummaries == null;
						object obj3 = 0;
						num = num2;
						flag2 = (byte)(int)obj != 0;
						if (!flag6)
						{
							if (stageId >= list._size)
							{
								object obj4 = "Unsupported map type" + 3552;
								TextMeshProExtensions.Localize(participantCount, (string)obj4);
								obj3 = 0;
								num = unchecked((nint)null);
								flag2 = (byte)(int)obj4 != 0;
								goto IL_0291;
							}
							NumberFormatter numberFormatter = participantCountFormatter;
							object obj5 = (nint)0 + (nint)3808;
							num = (nint)obj5;
							object obj6 = ((List<object>)(object)stagesSummaries).get_Item(stageId);
							bool flag7 = obj6 == null;
							obj3 = 0;
							flag2 = (byte)stageId != 0;
							if (!flag7)
							{
								bool flag8 = (object)participantCountFormatter == null;
								obj3 = 0;
								flag2 = (byte)stageId != 0;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v122 (System.Object)+10]");
									num = 0;
									nint num3 = (nint)numberFormatter;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v72 (Il2CppClass<NumberFormatter>)+180]");
									obj3 = 0;
									NumberFormatter numberFormatter2 = participantCountFormatter;
									TextMeshProUGUI label = participantCount;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v122 (System.Object)+10]");
									numberFormatter2.AssignValue(label, 0);
									flag2 = (byte)(int)participantCount != 0;
									goto IL_0291;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0de7;
		IL_0df5:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0e03;
		IL_0e03:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0b45:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+68]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 == null)
		{
			return;
		}
		object obj9;
		int? num4 = default(int?);
		if ((object)thirdPlaceLayout != null)
		{
			thirdPlaceLayout.SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object text = "The operation is not allowed on non-connected sockets." + 3224;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+14]");
			string text2;
			if ((nint)0 == 3)
			{
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v76+E4]");
				bool flag9 = (nint)0 == 0;
				object obj10 = !flag9;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object input = "___# Content push apply failed [{0}]: {1}" + 3856;
				text2 = LocalizationUtil.Localize((string)input);
				nint num = unchecked((nint)null);
				flag2 = false;
			}
			else
			{
				object obj11 = (nint)0 + (nint)3176;
				int value = num4.Value;
				object obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v71+E4]");
				bool flag10 = (nint)0 == 0;
				object obj13 = !flag10;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object input2 = "Picking audio files is not supported on iOS" + 776;
				text2 = LocalizationUtil.Localize((string)input2, value);
				nint num = unchecked((nint)null);
				flag2 = (byte)value != 0;
			}
			object[] array = default(object[]);
			if (array != null)
			{
				bool flag11 = text2 == null;
				bool flag12 = flag2;
				if (!flag11)
				{
					nint num5 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
					flag12 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag13 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
					flag2 = false;
					if (flag13)
					{
						goto IL_0e03;
					}
				}
				bool flag14 = array.Length == 0;
				flag2 = flag12;
				if (!flag14)
				{
					object obj14 = array + 32;
					obj14 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TextMeshProExtensions.Localize(tournamentThirdPrizeText, (string)text, array);
					return;
				}
				goto IL_0df5;
			}
		}
		goto IL_0de7;
		IL_0de7:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0df5;
		IL_0291:
		if (obj2 != null)
		{
			object obj15 = (nint)0 + (nint)1704;
			flag2 = (byte)(int)obj15 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+50]");
			object obj16 = Enumerable.Last((IEnumerable<object>)0);
			if (obj16 != null)
			{
				obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj17 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v21+E4]");
				bool flag15 = (nint)0 == 0;
				object obj18 = !flag15;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+28]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v20 (System.Object)+18]");
				string text3 = LocalizationUtil.DateRangeMessage((DateTime)num6, (DateTime)0);
				TextMeshProExtensions.FixArabic(stageDurationText, text3);
				bool flag16 = (object)playPeriodsInfoUI == null;
				nint num = unchecked((nint)null);
				flag2 = (byte)(int)text3 != 0;
				if (!flag16)
				{
					object obj19 = typeof(TypeConverter<ushort, char>) + 3400;
					object obj20 = typeof(List<Tween>) + 2432;
					playPeriodsInfoUI.PopulatePlayWindows(stageId);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array2 = default(object[]);
					bool flag17 = array2 == null;
					num = unchecked((nint)null);
					object obj21 = default(object);
					flag2 = (byte)(&obj21) != 0;
					if (!flag17)
					{
						object obj22 = default(object);
						bool flag18 = obj22 == null;
						bool flag19 = (byte)(&obj21) != 0;
						if (!flag18)
						{
							nint num7 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v67 (Il2CppClass<System.Object[]>)+40]");
							flag19 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag20 = ex == null;
							num = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v67 (Il2CppClass<System.Object[]>)+40]");
							flag2 = false;
							if (flag20)
							{
								goto IL_0e03;
							}
						}
						bool flag21 = array2.Length == 0;
						num = unchecked((nint)null);
						flag2 = flag19;
						if (flag21)
						{
							goto IL_0df5;
						}
						object text4 = "destinationTimeZone" + 3128;
						object obj23 = array2 + 32;
						obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TextMeshProExtensions.Localize(triesText, (string)text4, array2);
						string massTournamentEligibilityFilterCriteria = GetMassTournamentEligibilityFilterCriteria((MassEventStageViewModel)obj2);
						TextMeshProExtensions.FixArabic(eligibilityText, massTournamentEligibilityFilterCriteria);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj24 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array3 = default(object[]);
						bool flag22 = array3 == null;
						object obj3 = 0;
						num = unchecked((nint)null);
						object obj25 = default(object);
						flag2 = (byte)(&obj25) != 0;
						if (!flag22)
						{
							object obj26 = default(object);
							bool flag23 = obj26 == null;
							bool flag24 = (byte)(&obj25) != 0;
							if (!flag23)
							{
								nint num8 = (nint)array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
								flag24 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag25 = ex == null;
								obj3 = 0;
								num = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
								flag2 = false;
								if (flag25)
								{
									goto IL_0e03;
								}
							}
							bool flag26 = array3.Length == 0;
							obj3 = 0;
							num = unchecked((nint)null);
							flag2 = flag24;
							if (flag26)
							{
								goto IL_0df5;
							}
							object text5 = "utf-32" + 4032;
							object obj27 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 400;
							object obj28 = array3 + 32;
							obj28 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							TextMeshProExtensions.Localize(tournamentSizeText, (string)text5, array3);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+14]");
							string text6;
							if ((nint)0 == 3)
							{
								object obj29 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v111+E4]");
								bool flag27 = (nint)0 == 0;
								object obj30 = !flag27;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object input3 = "___# Content push apply failed [{0}]: {1}" + 3856;
								text6 = LocalizationUtil.Localize((string)input3);
								num = (nint)array3;
								flag2 = false;
							}
							else
							{
								object obj31 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v106+E4]");
								bool flag28 = (nint)0 == 0;
								object obj32 = !flag28;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object input4 = "Picking audio files is not supported on iOS" + 776;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+5C]");
								text6 = LocalizationUtil.Localize((string)input4, 0L);
								num = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+5C]");
								flag2 = false;
							}
							object[] array4 = default(object[]);
							bool flag29 = array4 == null;
							obj3 = 0;
							if (!flag29)
							{
								bool flag30 = text6 == null;
								bool flag31 = flag2;
								if (!flag30)
								{
									nint num9 = (nint)array4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
									flag31 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag32 = ex == null;
									obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
									flag2 = false;
									if (flag32)
									{
										goto IL_0e03;
									}
								}
								bool flag33 = array4.Length == 0;
								obj3 = 0;
								flag2 = flag31;
								if (flag33)
								{
									goto IL_0df5;
								}
								object obj33 = array4 + 32;
								obj33 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								TextMeshProExtensions.Localize(tournamentPrizeText, (string)obj27, array4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+60]");
								object obj34 = (nint)0 & (nint)1;
								bool flag34 = obj34 == null;
								obj3 = 0;
								num = (nint)array4;
								flag2 = (byte)(int)obj27 != 0;
								if (flag34)
								{
									goto IL_0b45;
								}
								bool flag35 = (object)secondPlaceLayout == null;
								obj3 = 0;
								num = (nint)array4;
								flag2 = (byte)(int)obj27 != 0;
								if (!flag35)
								{
									secondPlaceLayout.SetActive(value: true);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									object obj35 = "SERVICE_DISABLED" + 2408;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v14 (System.Object)+14]");
									string text7;
									if ((nint)0 == 3)
									{
										object obj36 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v99+E4]");
										bool flag36 = (nint)0 == 0;
										object obj37 = !flag36;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object input5 = "___# Content push apply failed [{0}]: {1}" + 3856;
										text7 = LocalizationUtil.Localize((string)input5);
										num = unchecked((nint)null);
										flag2 = false;
									}
									else
									{
										object obj38 = (nint)0 + (nint)3176;
										int value2 = num4.Value;
										object obj39 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v94+E4]");
										bool flag37 = (nint)0 == 0;
										object obj40 = !flag37;
										if (obj40 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object input6 = "Picking audio files is not supported on iOS" + 776;
										text7 = LocalizationUtil.Localize((string)input6, value2);
										num = unchecked((nint)null);
										flag2 = (byte)value2 != 0;
									}
									object[] array5 = default(object[]);
									bool flag38 = array5 == null;
									obj3 = 0;
									if (!flag38)
									{
										bool flag39 = text7 == null;
										bool flag40 = flag2;
										if (!flag39)
										{
											nint num10 = (nint)array5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
											flag40 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag41 = ex == null;
											obj3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
											flag2 = false;
											if (flag41)
											{
												goto IL_0e03;
											}
										}
										bool flag42 = array5.Length == 0;
										obj3 = 0;
										flag2 = flag40;
										if (!flag42)
										{
											object obj41 = array5 + 32;
											obj41 = text7;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											TextMeshProExtensions.Localize(tournamentSecondPrizeText, (string)obj35, array5);
											obj3 = 0;
											num = (nint)array5;
											flag2 = (byte)(int)obj35 != 0;
											goto IL_0b45;
										}
										goto IL_0df5;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0de7;
	}

	private void SetActiveState(MassEventStageViewModel stage)
	{
		//IL_0027: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected I4, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I4, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected I4, but got Unknown
		//IL_00f7: Expected O, but got I4
		List<MassRuntimeStageSummery> list = stagesSummaries;
		object obj = list._size - 1;
		object obj2 = stage.<Id>k__BackingField - obj;
		bool flag = (nint)obj2 < 0;
		bool flag2 = obj2 == null;
		int num = stage.<Id>k__BackingField ^ obj;
		int num2 = stage.<Id>k__BackingField ^ obj2;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		bool active = (byte)((flag4 & obj3) ? 1 : 0) != 0;
		NotStartedStageStatus.SetActive(active);
		int activeStageId = ((MassTournamentServerConnector)(object)NotStartedStageStatus).GetActiveStageId();
		object obj4 = stage.<Id>k__BackingField - activeStageId;
		bool active2 = obj4 == null;
		StartedStageStatus.SetActive(active2);
	}

	private unsafe void OpenFinalsTab()
	{
		//IL_002f: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0141: Expected O, but got I4
		//IL_0149: Expected I4, but got O
		//IL_0163: Expected O, but got I
		//IL_016b: Expected I4, but got O
		//IL_017c: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01e4: Expected O, but got I4
		//IL_045d: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_0481: Expected O, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02b5: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0264: Expected I4, but got O
		//IL_0389: Expected O, but got I4
		//IL_031f: Expected I, but got O
		//IL_0351: Expected O, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		bool flag = (object)stageTabGameObjects == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			stageTabGameObjects.SetActive(value: false);
			bool flag3 = (object)finalStageTabGameObjects == null;
			object obj = 0;
			flag2 = false;
			if (!flag3)
			{
				finalStageTabGameObjects.SetActive(value: true);
				MassEventModel tournamentData = TournamentData;
				bool flag4 = TournamentData == null;
				obj = 0;
				flag2 = true;
				if (!flag4)
				{
					List<object> <Stages>k__BackingField = (List<object>)(object)tournamentData.<Stages>k__BackingField;
					bool flag5 = tournamentData.<Stages>k__BackingField == null;
					obj = 0;
					flag2 = true;
					if (!flag5)
					{
						object obj2 = "fetch_products" + 256;
						int index = <Stages>k__BackingField._size - 1;
						object obj3 = ((List<object>)(object)tournamentData.<Stages>k__BackingField).get_Item(index);
						SetActiveState((MassEventStageViewModel)obj3);
						TextMeshProExtensions.Localize(titleText, (string)obj2);
						bool flag6 = obj3 == null;
						obj = 0;
						flag2 = (byte)(int)obj2 != 0;
						if (!flag6)
						{
							object obj4 = (nint)0 + (nint)1704;
							flag2 = (byte)(int)obj4 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v12 (System.Object)+50]");
							object obj5 = Enumerable.Last((IEnumerable<object>)0);
							bool flag7 = obj5 == null;
							obj = 0;
							if (!flag7)
							{
								object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
								object obj7 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v17+E4]");
								bool flag8 = (nint)0 == 0;
								object obj8 = !flag8;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v12 (System.Object)+28]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v16 (System.Object)+18]");
								string text = LocalizationUtil.DateRangeMessage((DateTime)num, (DateTime)0);
								TextMeshProExtensions.FixArabic(finalRegPeriodText, text);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v12 (System.Object)+28]");
								string text2 = LocalizationUtil.FormatDateTime((DateTime)0);
								TextMeshProExtensions.FixArabic(finalStartTimeText, text2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v12 (System.Object)+14]");
								if ((nint)0 == 4)
								{
									MassEventModel tournamentData2 = TournamentData;
									bool flag9 = TournamentData == null;
									obj = 0;
									flag2 = (byte)(int)text2 != 0;
									if (!flag9)
									{
										TextMeshProExtensions.FixArabic(finalTournamentSizeText, tournamentData2.<PhysicalFinalDescription>k__BackingField);
										return;
									}
								}
								else
								{
									object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									object obj10 = 153100288 + 1024;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
									object[] array = default(object[]);
									bool flag10 = array == null;
									obj = 0;
									object obj11 = default(object);
									flag2 = (byte)(&obj11) != 0;
									if (!flag10)
									{
										object obj12 = default(object);
										bool flag11 = obj12 == null;
										bool flag12 = (byte)(&obj11) != 0;
										if (!flag11)
										{
											nint num2 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
											flag12 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag13 = ex == null;
											obj = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
											flag2 = false;
											if (flag13)
											{
												goto IL_0403;
											}
										}
										bool flag14 = array.Length == 0;
										obj = 0;
										flag2 = flag12;
										if (!flag14)
										{
											object obj13 = array + 32;
											obj13 = obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object text3 = "{0} color encoding is currently unsupported for outputting to HDR." + 256;
											TextMeshProExtensions.Localize(finalTournamentSizeText, (string)text3, array);
											return;
										}
										goto IL_03f5;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03f5;
		IL_0403:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_03f5:
		ex = new IndexOutOfRangeException();
		goto IL_0403;
	}

	private void UpdateCards(List<MassRuntimeStageSummery> summaries = null)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0059: Expected O, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
		List<MassRuntimeStageSummery> list = default(List<MassRuntimeStageSummery>);
		stagesSummaries = list;
		object obj = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		MassTournamentServerConnector massTournamentServerConnector = default(MassTournamentServerConnector);
		int activeStageId = massTournamentServerConnector.GetActiveStageId();
		CreateTabs();
		object obj2 = ((List<object>)(object)tabs).get_Item(activeStageId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v9 (System.Object)+38]");
		Toggle toggle = (Toggle)0;
		object obj3 = ~(toggle.m_IsOn ? 1 : 0);
		bool isOn = (byte)(1 & obj3) != 0;
		toggle.isOn = isOn;
	}

	private void OnError(string error)
	{
		UpdateCards();
	}

	private void OnSuccess(List<MassRuntimeStageSummery> stageSummaries)
	{
		UpdateCards(stageSummaries);
	}

	private unsafe string GetMassTournamentEligibilityFilterCriteria(MassEventStageViewModel stage)
	{
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected O, but got Unknown
		//IL_0461: Expected O, but got Ref
		//IL_0a81: Expected O, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0854: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01b9: Expected O, but got Ref
		//IL_0486: Expected O, but got Ref
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0699: Expected O, but got Ref
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_01de: Expected O, but got Ref
		//IL_049c: Expected I, but got O
		//IL_04ac: Expected O, but got I
		//IL_04d5: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_08ce: Expected O, but got Ref
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0568: Expected O, but got I4
		//IL_061c: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_06be: Expected O, but got Ref
		//IL_01f4: Expected I, but got O
		//IL_0204: Expected O, but got I
		//IL_022d: Expected O, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_08f3: Expected O, but got Ref
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I4
		//IL_06d4: Expected I, but got O
		//IL_06e4: Expected O, but got I
		//IL_070d: Expected O, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0311: Expected I, but got O
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_07a0: Expected O, but got I4
		//IL_0909: Expected I, but got O
		//IL_0919: Expected O, but got I
		//IL_0942: Expected O, but got I
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09d5: Expected O, but got I4
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected O, but got Unknown
		//IL_03b6: Expected I, but got O
		//IL_0354: Expected I, but got O
		//IL_0364: Expected O, but got I
		//IL_0382: Expected I, but got O
		//IL_0392: Expected O, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		MassEventStageViewModel massEventStageViewModel = default(MassEventStageViewModel);
		bool flag = massEventStageViewModel == null;
		object[] array = (object[])(object)massEventStageViewModel;
		int? num = default(int?);
		object input2;
		object[] formattedArguments;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			if (massEventStageViewModel.<Type>k__BackingField > MassEventStageType.ConstantPointsFilter)
			{
				if (massEventStageViewModel.<Type>k__BackingField != MassEventStageType.PlayersRatioFilter)
				{
					if (massEventStageViewModel.<Type>k__BackingField != MassEventStageType.Physical)
					{
						if (massEventStageViewModel.<Type>k__BackingField == MassEventStageType.TournamentWinnersFilter)
						{
							object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v84+E4]");
							bool flag2 = (nint)0 == 0;
							object obj3 = !flag2;
							if (obj3 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object input = "utf-32" + 1528;
							return LocalizationUtil.Localize((string)input);
						}
						goto IL_0a3f;
					}
					MassEventModel tournamentData = TournamentData;
					bool flag3 = TournamentData == null;
					array = (object[])(object)massEventStageViewModel;
					if (!flag3)
					{
						List<MassEventStageViewModel> <Stages>k__BackingField = tournamentData.<Stages>k__BackingField;
						bool flag4 = tournamentData.<Stages>k__BackingField == null;
						array = (object[])(object)massEventStageViewModel;
						if (!flag4)
						{
							object obj4 = massEventStageViewModel.<Id>k__BackingField + 1;
							if ((nint)obj4 == <Stages>k__BackingField._size)
							{
								goto IL_0640;
							}
							goto IL_0875;
						}
					}
				}
				else
				{
					object obj5 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj6 = typeof(List<Tween>) + 2432;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array2 = default(object[]);
					bool flag5 = array2 == null;
					array = (object[])(&num);
					if (!flag5)
					{
						object obj7 = default(object);
						bool flag6 = obj7 == null;
						object[] array3 = (object[])(&num);
						if (!flag6)
						{
							nint num2 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v68 (Il2CppClass<System.Object[]>)+40]");
							array3 = (object[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag7 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v68 (Il2CppClass<System.Object[]>)+40]");
							array = (object[])0;
							if (flag7)
							{
								goto IL_0a2a;
							}
						}
						bool flag8 = array2.Length == 0;
						array = array3;
						if (flag8)
						{
							goto IL_0a1c;
						}
						object obj8 = array2 + 32;
						obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v79+E4]");
						bool flag9 = (nint)0 == 0;
						object obj11 = !flag9;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						input2 = "utf-32" + 3688;
						formattedArguments = array2;
						goto IL_0ac3;
					}
				}
			}
			else if (massEventStageViewModel.<Type>k__BackingField != MassEventStageType.ConstantPlayersFilter)
			{
				if (massEventStageViewModel.<Type>k__BackingField != MassEventStageType.ConstantPointsFilter)
				{
					goto IL_0a3f;
				}
				object obj12 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj13 = typeof(List<Tween>) + 2432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array4 = default(object[]);
				bool flag10 = array4 == null;
				array = (object[])(&num);
				if (!flag10)
				{
					object obj14 = default(object);
					bool flag11 = obj14 == null;
					object[] array5 = (object[])(&num);
					if (!flag11)
					{
						nint num3 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
						array5 = (object[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
						array = (object[])0;
						if (flag12)
						{
							goto IL_0a2a;
						}
					}
					bool flag13 = array4.Length == 0;
					array = array5;
					if (!flag13)
					{
						object obj15 = array4 + 32;
						obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v58+E4]");
						bool flag14 = (nint)0 == 0;
						object obj18 = !flag14;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object input3 = "Picking audio files is not supported on iOS" + 776;
						string text = LocalizationUtil.Localize((string)input3, array4);
						object[] array6 = default(object[]);
						bool flag15 = array6 == null;
						nint num4 = unchecked((nint)null);
						array = array4;
						if (flag15)
						{
							goto IL_0a0e;
						}
						bool flag16 = text == null;
						object[] array7 = array4;
						if (!flag16)
						{
							nint num5 = (nint)array6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
							array7 = (object[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag17 = ex == null;
							num4 = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
							array = (object[])0;
							if (flag17)
							{
								goto IL_0a2a;
							}
						}
						bool flag18 = array6.Length == 0;
						num4 = unchecked((nint)null);
						array = array7;
						if (!flag18)
						{
							object obj19 = array6 + 32;
							obj19 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							input2 = "clear_mass_tournaments" + 448;
							formattedArguments = array6;
							goto IL_0ac3;
						}
					}
					goto IL_0a1c;
				}
			}
			else
			{
				MassEventModel tournamentData2 = TournamentData;
				bool flag19 = TournamentData == null;
				array = (object[])(object)massEventStageViewModel;
				if (!flag19)
				{
					List<MassEventStageViewModel> <Stages>k__BackingField2 = tournamentData2.<Stages>k__BackingField;
					bool flag20 = tournamentData2.<Stages>k__BackingField == null;
					array = (object[])(object)massEventStageViewModel;
					if (!flag20)
					{
						object obj20 = massEventStageViewModel.<Id>k__BackingField - 1;
						if ((nint)obj20 == <Stages>k__BackingField2._size)
						{
							goto IL_0640;
						}
						goto IL_0875;
					}
				}
			}
		}
		goto IL_0a0e;
		IL_0640:
		object obj21 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj22 = typeof(List<Tween>) + 2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array8 = default(object[]);
		bool flag21 = array8 == null;
		array = (object[])(&num);
		if (flag21)
		{
			goto IL_0a0e;
		}
		object obj23 = default(object);
		bool flag22 = obj23 == null;
		object[] array9 = (object[])(&num);
		if (!flag22)
		{
			nint num6 = (nint)array8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
			array9 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag23 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
			array = (object[])0;
			if (flag23)
			{
				goto IL_0a2a;
			}
		}
		bool flag24 = array8.Length == 0;
		array = array9;
		if (flag24)
		{
			goto IL_0a1c;
		}
		object obj24 = array8 + 32;
		obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v43+E4]");
		bool flag25 = (nint)0 == 0;
		object obj27 = !flag25;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		input2 = "AvailableVoices" + 1448;
		formattedArguments = array8;
		goto IL_0ac3;
		IL_0875:
		object obj28 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj29 = typeof(List<Tween>) + 2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array10 = default(object[]);
		bool flag26 = array10 == null;
		array = (object[])(&num);
		if (flag26)
		{
			goto IL_0a0e;
		}
		object obj30 = default(object);
		bool flag27 = obj30 == null;
		object[] array11 = (object[])(&num);
		if (!flag27)
		{
			nint num7 = (nint)array10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
			array11 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag28 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
			array = (object[])0;
			if (flag28)
			{
				goto IL_0a2a;
			}
		}
		bool flag29 = array10.Length == 0;
		array = array11;
		if (flag29)
		{
			goto IL_0a1c;
		}
		object obj31 = array10 + 32;
		obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj32 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v30+E4]");
		bool flag30 = (nint)0 == 0;
		object obj34 = !flag30;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		input2 = "AvailableVoices" + 1456;
		formattedArguments = array10;
		goto IL_0ac3;
		IL_0a0e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0a1c;
		IL_0ac3:
		return LocalizationUtil.Localize((string)input2, formattedArguments);
		IL_0a3f:
		object obj35 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex3 = default(ArgumentOutOfRangeException);
		ex3..ctor();
		object obj36 = (nint)0 + (nint)3584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
		IL_0a2a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0a1c:
		ex = new IndexOutOfRangeException();
		goto IL_0a2a;
	}

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged += action;
		_connector.ReloadPlayerState();
	}

	private void <ShowPrizes>b__28_0(MassTournamentPrizesPanel popup)
	{
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		popup.Populate(cachedMassEvent);
	}
}
