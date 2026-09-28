using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class LeaderBoardPerformance : MonoBehaviour
{
	private enum TabName
	{
		WeeklyTab,
		MonthlyTab,
		OverAllTab
	}

	private CircularProgress circularProgress;

	private TrianglarProgress triangularProgress;

	private GameObject emptyStateTrianglar;

	private GameObject emptyStateCircular;

	private TextMeshProUGUI highestPointsText;

	private TabsUI tabs;

	private const string WeeklyHighest = "Weekly Leadership";

	private const string MonthlyHighest = "Monthly Leadership";

	private const string OverallHighest = "Overall Leadership";

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00a2: Expected I, but got O
		//IL_00d1: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		SetTitle();
		HideProgress();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj6 = (nint)0 + (nint)528;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile(dbId, action);
	}

	private void InitializeAllProgresses(PlayerProfileModel model, TabName tabName)
	{
		//IL_0083: Expected O, but got I4
		//IL_013a: Expected F4, but got I4
		//IL_0147: Expected F4, but got I4
		//IL_00dc: Expected F4, but got I4
		//IL_00e9: Expected F4, but got I4
		//IL_01d0: Expected O, but got I4
		PlayerRankingModel <ranking>k__BackingField = model.<ranking>k__BackingField;
		if (model.<ranking>k__BackingField == null)
		{
			return;
		}
		GameObject gameObject3;
		if (tabName != TabName.OverAllTab)
		{
			CircularProgress circularProgress;
			float currentProgress;
			float maxProgress;
			if (tabName != TabName.MonthlyTab)
			{
				bool flag = tabName == TabName.WeeklyTab;
				object obj = !flag;
				if (obj != null)
				{
					return;
				}
				triangularProgress.Initialize(<ranking>k__BackingField.<lastWeekPercentile>k__BackingField, <ranking>k__BackingField.<lastWeekRank>k__BackingField);
				PlayerRankingModel <ranking>k__BackingField2 = model.<ranking>k__BackingField;
				circularProgress = this.circularProgress;
				currentProgress = <ranking>k__BackingField2.<currentWeekPoints>k__BackingField;
				maxProgress = <ranking>k__BackingField2.<lastWeekPoints>k__BackingField;
			}
			else
			{
				triangularProgress.Initialize(<ranking>k__BackingField.<lastMonthPercentile>k__BackingField, <ranking>k__BackingField.<lastMonthRank>k__BackingField);
				PlayerRankingModel <ranking>k__BackingField3 = model.<ranking>k__BackingField;
				circularProgress = this.circularProgress;
				currentProgress = <ranking>k__BackingField3.<currentMonthPoints>k__BackingField;
				maxProgress = <ranking>k__BackingField3.<lastMonthPoints>k__BackingField;
			}
			circularProgress.Initialize(maxProgress, currentProgress);
			GameObject gameObject = this.circularProgress.gameObject;
			gameObject.SetActive(value: true);
			GameObject gameObject2 = triangularProgress.gameObject;
			gameObject2.SetActive(value: true);
			emptyStateCircular.SetActive(value: false);
			gameObject3 = emptyStateTrianglar;
			bool flag2 = (object)emptyStateTrianglar == null;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			triangularProgress.Initialize(<ranking>k__BackingField.<overallPercentile>k__BackingField, <ranking>k__BackingField.<overallRank>k__BackingField);
			GameObject gameObject4 = this.circularProgress.gameObject;
			gameObject4.SetActive(value: false);
			GameObject gameObject5 = triangularProgress.gameObject;
			gameObject5.SetActive(value: true);
			emptyStateCircular.SetActive(value: true);
			gameObject3 = emptyStateTrianglar;
		}
		gameObject3.SetActive(value: false);
	}

	private void HideProgress()
	{
		GameObject gameObject = circularProgress.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = triangularProgress.gameObject;
		gameObject2.SetActive(value: false);
		emptyStateCircular.SetActive(value: true);
		emptyStateTrianglar.SetActive(value: true);
	}

	private void SetTitle()
	{
		//IL_002e: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_0090: Expected O, but got I
		int activeTabIndex = tabs.ActiveTabIndex;
		bool flag = activeTabIndex < 2;
		object obj = !flag;
		object obj2 = activeTabIndex - 2;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 139821056 + 2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+v45 @ X0_v4 (System.Int32)*8]");
			object text = 0;
			TextMeshProExtensions.Localize(highestPointsText, (string)text);
		}
	}

	private void <Start>b__10_0(PlayerProfileModel playerProfile)
	{
		int activeTabIndex = tabs.ActiveTabIndex;
		InitializeAllProgresses(playerProfile, (TabName)activeTabIndex);
	}
}
