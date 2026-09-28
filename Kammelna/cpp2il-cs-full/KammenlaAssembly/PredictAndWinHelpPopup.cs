using System;
using Cpp2ILInjected;
using DataTracking;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class PredictAndWinHelpPopup : MonoBehaviour, IInitializable
{
	private PopupUI popup;

	private BoolPlayerPref firstTime;

	private PredictAndWinEventsChannel predictAndWinEventsChannel;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_00a5: Expected I, but got O
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_0161: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E647C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00cf;
		}
		ITrackEvent trackEvent = TrackerLibrary.PredictAndWinFirstTime();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		ITrackEvent trackEvent2 = trackEvent;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_0123;
		IL_0123:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		BoolPlayerPref boolPlayerPref = firstTime;
		bool flag2 = (object)firstTime == null;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_009d;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		boolPlayerPref = firstTime;
		goto IL_009d;
		IL_009d:
		nint num = (nint)boolPlayerPref;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7 (Il2CppClass<BoolPlayerPref>)+178]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7 (Il2CppClass<BoolPlayerPref>)+180]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00cf;
		IL_00cf:
		_ = 1;
		trackEvent = TrackerLibrary.PredictAndWinFirstTime();
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		trackEvent2 = trackEvent;
		if (obj7 != null)
		{
			goto IL_0085;
		}
		goto IL_0123;
	}

	public void Initialize()
	{
		popup.PopFromCenter();
	}

	public void ShowHowToPlay()
	{
		predictAndWinEventsChannel.TriggerShowHowToPlay();
	}
}
