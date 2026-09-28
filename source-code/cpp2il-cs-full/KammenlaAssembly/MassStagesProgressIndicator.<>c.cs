using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using Util.Extensions;

public class MassStagesProgressIndicator : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<StageMark> <>9__10_0;

		public static Action<StageMark> <>9__10_1;

		public static Action<StageMark> <>9__10_2;

		public static Action<StageMark> <>9__10_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <FillStageStatus>b__10_0(StageMark mark)
		{
			ComponentListsExtensions.SetActive(mark._statusObjects, active: false);
			mark.statusWon.SetActive(value: true);
		}

		internal void <FillStageStatus>b__10_1(StageMark mark)
		{
			ComponentListsExtensions.SetActive(mark._statusObjects, active: false);
			mark.statusWon.SetActive(value: true);
		}

		internal void <FillStageStatus>b__10_2(StageMark mark)
		{
			ComponentListsExtensions.SetActive(mark._statusObjects, active: false);
			mark.statusWon.SetActive(value: true);
		}

		internal void <FillStageStatus>b__10_3(StageMark mark)
		{
			ComponentListsExtensions.SetActive(mark._statusObjects, active: false);
			mark.statusWon.SetActive(value: true);
		}
	}

	private StageMark stageMarkPrefab;

	private Transform stageMarksArea;

	private RectTransform stageConnectorsLayout;

	private GameObject connectorPrefab;

	private List<StageMark> _marks;

	private List<GameObject> _connectors;

	private int _numberOfStages;

	private readonly MassEventStagesStatus _massEventStagesStatus;

	private Vector2 _sizeDelta;

	public void SetStage(int numberOfStages, int current, int playerLastStageReached, bool isRegister, MassEventNextStageEligibility isEligible)
	{
		Clear();
		_numberOfStages = numberOfStages;
		MassEventStagesStatus massEventStagesStatus = _massEventStagesStatus;
		massEventStagesStatus.CurrentStage = current;
		massEventStagesStatus.PlayerLastStageReached = playerLastStageReached;
		massEventStagesStatus.IsRegistered = isRegister;
		massEventStagesStatus.IsEligible = isEligible;
		if (numberOfStages >= 1)
		{
			int num = 0;
			do
			{
				num++;
				CreateNewStageMark(num);
			}
			while (num < _numberOfStages);
		}
		FillStageStatus();
		CreateStageConnectors(numberOfStages, current);
	}

	private void FillStageStatus()
	{
		//IL_0283: Expected O, but got I
		//IL_029e: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_05ad: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_0901: Expected O, but got I
		//IL_0911: Expected O, but got I
		//IL_0933: Expected O, but got I4
		//IL_0172: Expected O, but got I
		//IL_02fc: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_05f4: Expected O, but got I4
		//IL_0317: Expected O, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_096b: Expected O, but got I
		//IL_097c: Expected I, but got O
		//IL_099a: Expected O, but got I
		//IL_0672: Expected O, but got I
		//IL_0682: Expected O, but got I
		//IL_06a4: Expected O, but got I4
		//IL_06b4: Expected O, but got I
		//IL_047e: Expected O, but got I
		//IL_0624: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_022c: Expected O, but got I4
		//IL_0499: Expected O, but got I
		//IL_0374: Expected O, but got I
		//IL_06e4: Expected O, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_04f3: Expected O, but got I4
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03ce: Expected O, but got I4
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09e3: Expected O, but got I
		//IL_09eb: Expected I, but got O
		//IL_09fc: Expected I, but got O
		//IL_0a1a: Expected O, but got I
		//IL_0a33: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_0832: Expected O, but got I
		//IL_0842: Expected O, but got I
		//IL_0864: Expected O, but got I4
		//IL_074c: Expected O, but got I
		//IL_075c: Expected O, but got I
		//IL_077e: Expected O, but got I4
		//IL_0714: Expected O, but got I
		//IL_053a: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected O, but got Unknown
		//IL_089c: Expected O, but got I
		//IL_08a4: Expected I, but got O
		//IL_08b5: Expected I, but got O
		//IL_08d3: Expected O, but got I
		//IL_08ec: Expected O, but got I4
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_07b6: Expected O, but got I
		//IL_07be: Expected I, but got O
		//IL_07cf: Expected I, but got O
		//IL_07ed: Expected O, but got I
		//IL_0806: Expected O, but got I4
		//IL_056a: Expected O, but got I
		//IL_0445: Expected O, but got I
		MassEventStagesStatus massEventStagesStatus = _massEventStagesStatus;
		int end;
		Action<StageMark> action;
		Action<object> action3;
		object obj19;
		object obj21;
		nint num;
		object obj16;
		object obj17;
		if (massEventStagesStatus.IsRegistered)
		{
			if (massEventStagesStatus.IsEligible == MassEventNextStageEligibility.EligibleToReserve)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v58+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				Room currentRoom = sessionModel.CurrentRoom;
				TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
				bool flag2 = TournamentStatusExtensions.IsFinished(tournamentStatus);
				massEventStagesStatus = _massEventStagesStatus;
				if (!flag2)
				{
					object obj5 = ((List<object>)(object)_marks).get_Item(massEventStagesStatus.CurrentStage);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v66 (System.Object)+58]");
					ComponentListsExtensions.SetActive((IEnumerable<GameObject>)0, active: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v66 (System.Object)+50]");
					((GameObject)0).SetActive(value: true);
					MassEventStagesStatus massEventStagesStatus2 = _massEventStagesStatus;
					end = massEventStagesStatus2.CurrentStage;
					object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3032;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v70+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj7 = obj6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v70+B8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v59+8]");
					action = (Action<StageMark>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v59+8]");
					bool flag4 = (nint)0 == 0;
					object obj10 = !flag4;
					if (obj10 != null)
					{
						goto IL_0728;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v70+E4]");
					bool flag5 = (nint)0 == 0;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj12 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v65+B8]");
						obj9 = 0;
					}
					object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3512;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj14 = (nint)0 + (nint)824;
					num = (nint)obj14;
					Action<object> action2 = default(Action<object>);
					action2..ctor(obj9, (IntPtr)obj14);
					object obj15 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v64+B8]");
					obj16 = (nint)0 + (nint)8;
					obj16 = action2;
					action3 = action2;
					obj17 = 0;
					goto IL_080b;
				}
			}
			if (massEventStagesStatus.PlayerLastStageReached == massEventStagesStatus.CurrentStage)
			{
				object obj18 = ((List<object>)(object)_marks).get_Item(massEventStagesStatus.PlayerLastStageReached);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v45 (System.Object)+58]");
				ComponentListsExtensions.SetActive((IEnumerable<GameObject>)0, active: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v45 (System.Object)+30]");
				((GameObject)0).SetActive(value: true);
				MassEventStagesStatus massEventStagesStatus3 = _massEventStagesStatus;
				end = massEventStagesStatus3.CurrentStage;
				obj19 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3032;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v49+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v49+B8]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v38+10]");
					action = (Action<StageMark>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v38+10]");
					bool flag6 = (nint)0 == 0;
					object obj22 = !flag6;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v38+10]");
						Action<StageMark> action4 = (Action<StageMark>)0;
						goto IL_06c2;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v49+B8]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v38+10]");
					Action<StageMark> action4 = (Action<StageMark>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v38+10]");
					bool flag7 = (nint)0 == 0;
					object obj23 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v38+10]");
					action = (Action<StageMark>)0;
					if (obj23 == null)
					{
						goto IL_06c2;
					}
				}
			}
			else
			{
				if (massEventStagesStatus.PlayerLastStageReached >= massEventStagesStatus.CurrentStage)
				{
					object obj24 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3032;
					object obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v14+E4]");
					bool flag8 = (nint)0 == 0;
					object obj26 = !flag8;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj25 = obj24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v14+B8]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v13+18]");
					Action<StageMark> action5 = (Action<StageMark>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v13+18]");
					bool flag9 = (nint)0 == 0;
					object obj28 = !flag9;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v14+E4]");
						bool flag10 = (nint)0 == 0;
						object obj29 = !flag10;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj30 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v19+B8]");
							obj27 = 0;
						}
						object obj31 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3512;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj32 = (nint)0 + (nint)840;
						Action<object> action6 = default(Action<object>);
						action6..ctor(obj27, (IntPtr)obj32);
						object obj33 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v18+B8]");
						object obj34 = (nint)0 + (nint)24;
						obj34 = action6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						action5 = action6;
					}
					int end2 = massEventStagesStatus.CurrentStage + 1;
					SetRangeOfMarks(0, end2, action5);
					return;
				}
				object obj35 = ((List<object>)(object)_marks).get_Item(massEventStagesStatus.CurrentStage);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v27 (System.Object)+58]");
				ComponentListsExtensions.SetActive((IEnumerable<GameObject>)0, active: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v27 (System.Object)+28]");
				((GameObject)0).SetActive(value: true);
				MassEventStagesStatus massEventStagesStatus4 = _massEventStagesStatus;
				object obj36 = ((List<object>)(object)_marks).get_Item(massEventStagesStatus4.PlayerLastStageReached);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v31 (System.Object)+58]");
				ComponentListsExtensions.SetActive((IEnumerable<GameObject>)0, active: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v31 (System.Object)+48]");
				((GameObject)0).SetActive(value: true);
				MassEventStagesStatus massEventStagesStatus5 = _massEventStagesStatus;
				end = massEventStagesStatus5.PlayerLastStageReached;
				object obj37 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3032;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v35+E4]");
				bool flag11 = (nint)0 == 0;
				object obj39 = !flag11;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj38 = obj37;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v35+B8]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v25+20]");
				action = (Action<StageMark>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v25+20]");
				bool flag12 = (nint)0 == 0;
				object obj41 = !flag12;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v35+E4]");
					bool flag13 = (nint)0 == 0;
					object obj42 = !flag13;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj43 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v31+B8]");
						obj40 = 0;
					}
					object obj44 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3512;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj45 = (nint)0 + (nint)848;
					num = (nint)obj45;
					Action<object> action7 = default(Action<object>);
					action7..ctor(obj40, (IntPtr)obj45);
					object obj46 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v30+B8]");
					obj16 = (nint)0 + (nint)32;
					obj16 = action7;
					action3 = action7;
					obj17 = 0;
					goto IL_080b;
				}
			}
			goto IL_0728;
		}
		object obj47 = ((List<object>)(object)_marks).get_Item(massEventStagesStatus.CurrentStage);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v5 (System.Object)+58]");
		ComponentListsExtensions.SetActive((IEnumerable<GameObject>)0, active: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v5 (System.Object)+28]");
		((GameObject)0).SetActive(value: true);
		return;
		IL_080b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action3;
		goto IL_0728;
		IL_0728:
		SetRangeOfMarks(0, end, action);
		return;
		IL_06c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v49+E4]");
		bool flag14 = (nint)0 == 0;
		object obj48 = !flag14;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj49 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v44+B8]");
			obj21 = 0;
		}
		object obj50 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)832;
		num = (nint)obj51;
		Action<object> action8 = default(Action<object>);
		action8..ctor(obj21, (IntPtr)obj51);
		object obj52 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v43+B8]");
		obj16 = (nint)0 + (nint)16;
		obj16 = action8;
		action3 = action8;
		obj17 = 0;
		goto IL_080b;
	}

	private void CreateStageConnectors(int stageCount, int current)
	{
		//IL_02b9: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_02ef: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0039: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_0140: Expected I4, but got O
		//IL_01c7: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		object obj = stageCount - 1;
		if ((nint)obj >= 1)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = (nint)0 + (nint)544;
			object obj4 = (nint)0 + (nint)2544;
			object obj5 = stageCount;
			int num = current;
			object obj6 = 0;
			GameObject gameObject = (GameObject)152985600;
			GameObject gameObject2 = default(GameObject);
			while (true)
			{
				if ((nint)obj6 < current)
				{
					gameObject = connectorPrefab;
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v21+E4]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				}
				else
				{
					gameObject2 = CreateSpacer();
				}
				List<object> connectors = (List<object>)(object)_connectors;
				object obj9 = obj4;
				int version = connectors._version + 1;
				connectors._version = version;
				object[] items = connectors._items;
				bool flag2 = connectors._size < items.Length;
				object obj10 = !flag2;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v14+20]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v16+C0]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v17+70]");
					num = 0;
					connectors.AddWithResize((object)gameObject2);
					obj6++;
					bool flag3 = obj == obj6;
					obj5 = gameObject2;
					if (flag3)
					{
						break;
					}
				}
				else
				{
					int size = connectors._size + 1;
					connectors._size = size;
					object obj13 = items + connectors._size;
					object obj14 = obj13 + 32;
					obj14 = gameObject2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj6++;
					bool flag4 = obj != obj6;
					obj5 = gameObject2;
					if (!flag4)
					{
						break;
					}
				}
			}
		}
		object obj15 = typeof(UsageHint) + 744;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v7+B8]");
		object obj17 = 0;
		object obj18 = (object)_sizeDelta - obj17;
		Vector2 vector = (Vector2)(obj18 * obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		if ((nint)vector < 786163454)
		{
			Vector2 sizeDelta = stageConnectorsLayout.sizeDelta;
			_sizeDelta = vector;
			_ = 786163454;
		}
		stageConnectorsLayout.sizeDelta = (Vector2)0;
	}

	private GameObject CreateSpacer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
		object obj2 = "SetRoomVariables request error" + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameObject gameObject = default(GameObject);
		gameObject..ctor((string)obj2);
		if ((object)gameObject != null)
		{
			object obj3 = (nint)0 + (nint)840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				transform.SetParent(stageConnectorsLayout);
				return gameObject;
			}
		}
		return (GameObject)(object)new NullReferenceException();
	}

	private void CreateNewStageMark(int stageNumber)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6053]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)696;
			StageMark stageMark = stageMarkPrefab;
			Transform transform = stageMarksArea;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			Transform transform2 = stageMarksArea;
			object obj6 = obj4;
			StageMark stageMark2 = stageMarkPrefab;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)696;
			StageMark stageMark = stageMarkPrefab;
			Transform transform = stageMarksArea;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Transform transform2 = stageMarksArea;
			object obj6 = obj4;
			StageMark stageMark2 = stageMarkPrefab;
			if (obj7 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_0183;
		IL_0183:
		object obj8 = (nint)0 + (nint)96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj9 = stageNumber - _numberOfStages;
		bool isFinalStage = obj9 == null;
		StageMark stageMark3 = default(StageMark);
		stageMark3.Initialize(stageNumber, isFinalStage);
		List<object> marks = (List<object>)(object)_marks;
		int version = marks._version + 1;
		marks._version = version;
		object[] items = marks._items;
		bool flag3 = marks._size < items.Length;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			int size = marks._size + 1;
			marks._size = size;
			object obj11 = items + marks._size;
			object obj12 = obj11 + 32;
			obj12 = stageMark3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			marks.AddWithResize((object)stageMark3);
		}
		return;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj13 = default(object);
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0183;
	}

	private void Clear()
	{
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0053: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_012a: Expected I, but got O
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		//IL_0324: Expected I, but got O
		//IL_02b4: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_0194: Expected I, but got O
		//IL_0105: Expected O, but got I4
		//IL_021c: Expected I, but got O
		//IL_02d0: Expected O, but got I4
		object obj = this + 64;
		bool flag = obj == null;
		MassStagesProgressIndicator massStagesProgressIndicator = this;
		object obj6 = default(object);
		List<object>.Enumerator enumerator6 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		nint num = default(nint);
		List<object>.Enumerator enumerator3;
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1704;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = (nint)0 + (nint)1048;
			object obj5 = typeof(List<AdaptivePerformanceScaler>) + 3536;
			obj6 = (nint)0 + (nint)1040;
			object obj7 = (nint)0 + (nint)1696;
			List<object>.Enumerator enumerator = ((List<object>)obj).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			UnityEngine.Component component = default(UnityEngine.Component);
			while (true)
			{
				num = (nint)obj2;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				if ((object)component != null)
				{
					GameObject obj8 = component.gameObject;
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v49+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj8);
					continue;
				}
				goto IL_02a2;
			}
			num = (nint)obj7;
			enumerator2.Dispose();
			massStagesProgressIndicator = (MassStagesProgressIndicator)(this + 72);
			bool flag3 = (object)massStagesProgressIndicator == null;
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			if (!flag3)
			{
				List<object>.Enumerator enumerator5 = ((List<object>)(object)massStagesProgressIndicator).GetEnumerator();
				num = (nint)obj4;
				if (!enumerator6.MoveNext())
				{
					num = (nint)obj6;
					enumerator6.Dispose();
					enumerator3 = enumerator4;
					goto IL_0232;
				}
				NullReferenceException ex = new NullReferenceException();
				enumerator4 = (List<object>.Enumerator)0;
				goto IL_02d5;
			}
		}
		goto IL_03cd;
		IL_03cd:
		NullReferenceException ex2 = new NullReferenceException();
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj6;
			enumerator6.Dispose();
			object obj11 = default(object);
			if (obj11 == null)
			{
				goto IL_0232;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22371D4");
			NullReferenceException ex4 = (NullReferenceException)(object)ex3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237214");
			NullReferenceException ex4 = ex2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_02d5:
		enumerator3 = enumerator4;
		goto IL_03cd;
		IL_0232:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		massStagesProgressIndicator = (MassStagesProgressIndicator)(object)list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_02a2:
		NullReferenceException ex5 = new NullReferenceException();
		enumerator4 = (List<object>.Enumerator)0;
		massStagesProgressIndicator = this;
		goto IL_02d5;
	}

	private void CreateEmptyMarks()
	{
		if (_numberOfStages >= 1)
		{
			int num = 0;
			do
			{
				num++;
				CreateNewStageMark(num);
			}
			while (num < _numberOfStages);
		}
	}

	private void SetRangeOfMarks(int start, int end, Action<StageMark> action)
	{
		//IL_00a1: Expected O, but got I4
		if (start >= end)
		{
			return;
		}
		int num;
		List<object> list;
		int index;
		if (action != null)
		{
			num = start;
			while (_marks != null)
			{
				object obj = ((List<object>)(object)_marks).get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [action @ X3 (System.Action`1<StageMark>)+18] (should have been resolved before IL gen)");
				num++;
				if (end == num)
				{
					return;
				}
			}
		}
		else
		{
			list = (List<object>)(object)_marks;
			bool flag = _marks == null;
			object obj2 = !flag;
			num = start;
			index = start;
			if (obj2 != null)
			{
				goto IL_00dd;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		list = (List<object>)(object)ex;
		index = num;
		goto IL_00dd;
		IL_00dd:
		object obj3 = list.get_Item(index);
		throw new NullReferenceException();
	}

	public MassStagesProgressIndicator()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3536;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1168;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 64;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj5 = this + 72;
		obj5 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = this + 88;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
