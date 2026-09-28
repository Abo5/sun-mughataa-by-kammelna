using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;

public abstract class MassWidget : MonoBehaviour
{
	protected MassTournamentEventChannel eventChannel;

	protected MassTournamentServerConnector _connector;

	protected MassEventModel TournamentData;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		MassTournamentEventChannel massTournamentEventChannel = eventChannel;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2664;
		object obj2 = (nint)0 + (nint)3712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void OnMassReadyCallback(MassTournamentServerConnector connector)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_007d: Expected O, but got I
		//IL_008d: Expected O, but got I
		object obj = this + 40;
		obj = connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		MassTournamentServerConnector massTournamentServerConnector = default(MassTournamentServerConnector);
		MassTournamentInfo tournamentLiveData = massTournamentServerConnector.GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		object obj2 = this + 48;
		obj2 = cachedMassEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v2 (Il2CppClass<MassWidget>)+178]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v2 (Il2CppClass<MassWidget>)+180]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected abstract void Initialize();
}
