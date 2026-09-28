using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public abstract class GamesHubBase : MonoBehaviour, IInitializable
{
	private GamesHubItem[] items;

	private ServerFetcherEventsChannel serverFetcherEventsChannel;

	private MainMenuEventsChannel mainMenuEventsChannel;

	private bool isShown;

	protected IReadOnlyList<GamesHubItem> Items => items;

	protected virtual void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0116: Expected I, but got O
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		object obj = (nint)0 + (nint)800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		object obj2 = this + 32;
		Action<Games> action = default(Action<Games>);
		obj2 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v1+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2104;
			object obj5 = (nint)0 + (nint)2536;
			object obj6 = obj3 + 32;
			object obj7 = 0;
			Action<Games> action2 = action;
			Action<System.Int32Enum> action3 = default(Action<System.Int32Enum>);
			bool flag;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action3..ctor((object)this, (IntPtr)obj5);
				obj7++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v4+v92 @ X23_v5*8]");
				((GamesHubItem)0).Populate((Action<Games>)(object)action3);
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v1+18]");
				flag = (nint)obj8 < 0;
				action2 = (Action<Games>)(object)action3;
			}
			while (flag);
		}
	}

	public void ShowHub()
	{
		isShown = true;
		OnShowHub();
		if ((object)mainMenuEventsChannel != null)
		{
			mainMenuEventsChannel.TriggerGameHubShown();
		}
	}

	public void HideHub()
	{
		isShown = false;
		OnHideHub();
		if ((object)mainMenuEventsChannel != null)
		{
			mainMenuEventsChannel.TriggerGameHubHidden();
		}
	}

	public void ToggleHub()
	{
		if (isShown)
		{
			isShown = false;
			OnHideHub();
			if ((object)mainMenuEventsChannel != null)
			{
				mainMenuEventsChannel.TriggerGameHubHidden();
			}
		}
		else
		{
			isShown = true;
			OnShowHub();
			if ((object)mainMenuEventsChannel != null)
			{
				mainMenuEventsChannel.TriggerGameHubShown();
			}
		}
	}

	private void SetGame(Games game)
	{
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e3: Expected I, but got O
		//IL_01f3: Expected O, but got I
		//IL_0048: Expected O, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0019: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_0106: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		isShown = false;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (Il2CppClass<GamesHubBase>)+1C0]");
		object obj2 = 0;
		HidePopup();
		if ((object)mainMenuEventsChannel != null)
		{
			mainMenuEventsChannel.TriggerGameHubHidden();
			obj2 = 0;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (Preferences.HasPreferredGame)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			trackEvent = TrackerLibrary.SwitchGameClicked(friendlyName);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				object obj9 = 0;
				trackEvent2 = trackEvent;
				goto IL_019c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration2 = default(Enum);
			string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
			trackEvent2 = TrackerLibrary.SwitchGameOnboardingClicked(friendlyName2);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj9 = 0;
			trackEvent = trackEvent2;
			if (obj10 == null)
			{
				goto IL_019c;
			}
		}
		goto IL_0218;
		IL_019c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		trackEvent = trackEvent2;
		goto IL_0218;
		IL_0218:
		Tracker.DesignEvent(trackEvent);
		SFS.SwitchGame(game);
		serverFetcherEventsChannel.TriggerGameSelected();
	}

	public void Initialize()
	{
		isShown = true;
		OnShowHub();
		if ((object)mainMenuEventsChannel != null)
		{
			mainMenuEventsChannel.TriggerGameHubShown();
		}
	}

	protected abstract void OnShowHub();

	protected abstract void OnHideHub();

	protected abstract void HidePopup();
}
