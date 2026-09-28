using Cpp2ILInjected;
using DataTracking;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Purchasing.Telemetry;

public class ClickTracker : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private TrackingFeature feature;

	private TrackingPlacement placement;

	private TrackingOutcome outcome = TrackingOutcome.UiClicked;

	public void OnPointerClick(PointerEventData eventData)
	{
		//IL_0034: Expected O, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
		{
			return;
		}
		object obj = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ stack_-38_v3+D8]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		ITrackEvent trackEvent = TrackerLibrary.UiClicked(feature, placement, outcome);
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}
}
