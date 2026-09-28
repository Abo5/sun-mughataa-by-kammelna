using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentFeatureSelectedItem : MonoBehaviour
{
	private TextMeshProUGUI miniTitle;

	private Image icon;

	private Button editFeatureButton;

	private Button smallButton;

	private TournamentsCreationPopupEventsChannel eventsChannel;

	private TournamentFeature <Feature>k__BackingField;

	private TournamentAddonConfig tournamentAddonConfig;

	public TournamentFeature Feature
	{
		get
		{
			return <Feature>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		Button button = editFeatureButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = editFeatureButton;
		Button button3 = smallButton;
		button3.m_OnClick = button2.m_OnClick;
		object obj3 = button3 + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = editFeatureButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
	}

	private void OnSelectFeatureButtonClicked()
	{
		eventsChannel.TriggerOpenEditFeature(<Feature>k__BackingField);
	}

	public void Populate(TournamentFeature model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0041: Expected O, but got I
		object obj = this + 72;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		TextMeshProUGUI textMesh = miniTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v1+28]");
		TextMeshProExtensions.Localize(textMesh, (string)0);
		TournamentFeature tournamentFeature = <Feature>k__BackingField;
		icon.sprite = tournamentFeature.Icon;
	}

	private void Refresh()
	{
		TournamentFeature tournamentFeature = <Feature>k__BackingField;
		TextMeshProExtensions.Localize(miniTitle, tournamentFeature.MiniTitle);
		TournamentFeature tournamentFeature2 = <Feature>k__BackingField;
		icon.sprite = tournamentFeature2.Icon;
	}

	private void SetIcon()
	{
		TournamentFeature tournamentFeature = <Feature>k__BackingField;
		icon.sprite = tournamentFeature.Icon;
	}
}
