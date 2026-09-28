using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Server.Models;

public class MassStagesProgressWidget : MassWidget
{
	private MassStagesProgressIndicator indicator;

	protected override void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0094: Expected I, but got O
		//IL_005b: Expected I, but got O
		//IL_0071: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged += action;
		MassTournamentServerConnector connector = _connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged -= action;
	}

	private void Reload(MassTournamentPlayerState player)
	{
		MassEventModel tournamentData = TournamentData;
		List<MassEventStageViewModel> <Stages>k__BackingField = tournamentData.<Stages>k__BackingField;
		MassStagesProgressIndicator massStagesProgressIndicator = indicator;
		int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
		indicator.Clear();
		massStagesProgressIndicator._numberOfStages = <Stages>k__BackingField._size;
		MassEventStagesStatus massEventStagesStatus = massStagesProgressIndicator._massEventStagesStatus;
		massEventStagesStatus.CurrentStage = activeStageId;
		massEventStagesStatus.PlayerLastStageReached = player.<LastStageReached>k__BackingField;
		massEventStagesStatus.IsRegistered = player.<IsRegistered>k__BackingField;
		massEventStagesStatus.IsEligible = player.<NextStageEligibility>k__BackingField;
		if (<Stages>k__BackingField._size >= 1)
		{
			int num = 0;
			do
			{
				num++;
				indicator.CreateNewStageMark(num);
			}
			while (num < massStagesProgressIndicator._numberOfStages);
		}
		indicator.FillStageStatus();
		indicator.CreateStageConnectors(<Stages>k__BackingField._size, activeStageId);
	}
}
