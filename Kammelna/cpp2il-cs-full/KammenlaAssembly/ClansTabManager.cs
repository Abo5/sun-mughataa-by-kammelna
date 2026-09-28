using System;
using Cpp2ILInjected;
using DataTracking;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClansTabManager : MonoBehaviour
{
	private Button openDiscoveryButton;

	private GameObject LandingTab;

	private GameObject DiscoveryTab;

	private ClansDiscoveryPage DiscoveryPage;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Button button = openDiscoveryButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object key = "October" + 1136;
		button.m_OnClick.AddListener(unityAction);
		bool flag = Prefs.GetBool((string)key);
		bool active = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		LandingTab.SetActive(active);
		DiscoveryTab.SetActive(flag);
		DiscoveryPage.LoadDiscoveryPage();
	}

	private void OnEnable()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		object obj = "October" + 1136;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool flag = PlayerPrefsX.GetBool((string)obj, defaultValue: false);
		bool firstOpen = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		ITrackEvent trackEvent = TrackerLibrary.ClanTabOpened(firstOpen);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			bool flag2 = !flag;
			object obj4 = 0;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			bool flag3 = !flag;
			object obj5 = !flag3;
			object obj4 = 0;
			if (obj5 != null)
			{
				return;
			}
		}
		ITrackEvent trackEvent2 = TrackerLibrary.ClanOnboardingViewed();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
	}

	public void OpenDiscovery()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object key = "October" + 1136;
		Prefs.SetBool((string)key, value: true);
		DiscoveryTab.SetActive(value: true);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		LandingTab.SetActive(value: false);
		ITrackEvent trackEvent = TrackerLibrary.ClanDiscoveryOpened();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}
}
