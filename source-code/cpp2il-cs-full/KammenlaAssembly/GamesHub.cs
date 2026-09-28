using System;
using System.Buffers.Text;
using System.ComponentModel;
using Cpp2ILInjected;
using DataTracking;
using UnityEngine.Purchasing.Telemetry;

public class GamesHub : GamesHubBase
{
	private PopupUI popup;

	protected override void OnShowHub()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		popup.SlideFromBottom();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			bool hasPreferredGame = Preferences.HasPreferredGame;
			bool flag = !hasPreferredGame;
			obj4 = obj3;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			bool hasPreferredGame2 = Preferences.HasPreferredGame;
			bool flag2 = !hasPreferredGame2;
			object obj5 = !flag2;
			obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_0093;
			}
		}
		ITrackEvent trackEvent = TrackerLibrary.SwitchGameOnboardingViewed();
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+E4]");
		bool flag3 = (nint)0 == 0;
		ITrackEvent trackEvent2 = trackEvent;
		if (!flag3)
		{
			goto IL_017b;
		}
		goto IL_0185;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_017b:
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0093:
		trackEvent = TrackerLibrary.SwitchGameViewed();
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_017b;
		}
		trackEvent2 = trackEvent;
		goto IL_0185;
	}

	protected override void OnHideHub()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.SlideToBottom();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		ITrackEvent trackEvent = TrackerLibrary.SwitchGameBackClicked(friendlyName);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	protected override void HidePopup()
	{
		popup.SlideToBottom();
	}
}
