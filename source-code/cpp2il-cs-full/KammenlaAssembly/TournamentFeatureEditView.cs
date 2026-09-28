using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentFeatureEditView : MonoBehaviour
{
	private PopupUI popup;

	private TextMeshProUGUI title;

	private TextMeshProUGUI description;

	private Image icon;

	private Button removeFeatureButton;

	private Button editFeatureButton;

	private Button confirmFeatureButton;

	private TournamentsCreationPopupEventsChannel eventsChannel;

	private TournamentFeature feature;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		Button button = confirmFeatureButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = removeFeatureButton;
		object obj3 = (nint)0 + (nint)848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = editFeatureButton;
		object obj4 = (nint)0 + (nint)840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		button3.m_OnClick.AddListener(unityAction3);
	}

	public void OpenAddMode(TournamentFeature model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 96;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Refresh();
		if (!model.Configurable)
		{
			GameObject gameObject = removeFeatureButton.gameObject;
			gameObject.SetActive(value: false);
			GameObject gameObject2 = editFeatureButton.gameObject;
			gameObject2.SetActive(value: false);
			GameObject gameObject3 = confirmFeatureButton.gameObject;
			gameObject3.SetActive(value: true);
			popup.PopFromCenter();
		}
	}

	public void OpenEditMode(TournamentFeature model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 96;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Refresh();
		popup.PopFromCenter();
		GameObject gameObject = removeFeatureButton.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = editFeatureButton.gameObject;
		gameObject2.SetActive(model.Configurable);
		GameObject gameObject3 = confirmFeatureButton.gameObject;
		gameObject3.SetActive(value: false);
	}

	private void Populate(TournamentFeature model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 96;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Refresh();
	}

	public void Refresh()
	{
		TournamentFeature tournamentFeature = feature;
		TextMeshProExtensions.Localize(title, tournamentFeature.Title);
		TournamentFeature tournamentFeature2 = feature;
		TextMeshProExtensions.Localize(description, tournamentFeature2.EditMessage);
		TournamentFeature tournamentFeature3 = feature;
		icon.sprite = tournamentFeature3.Icon;
	}

	private void OnRemove()
	{
		TournamentFeature tournamentFeature = feature;
		eventsChannel.TriggerRemoveAddon(tournamentFeature.FeatureType);
		popup.ShrinkToParent();
	}

	private void OnEdit()
	{
		TournamentFeature tournamentFeature = feature;
		eventsChannel.TriggerEditAddon(tournamentFeature.FeatureType);
		popup.ShrinkToParent();
	}

	private void OnConfirm()
	{
		//IL_0034: Expected O, but got I
		TournamentFeature tournamentFeature = feature;
		if (!tournamentFeature.Configurable)
		{
			object data = (nint)0 + (nint)2000;
			TournamentAddonModel modelByType = TournamentAddonTypeExtensions.GetModelByType(tournamentFeature.FeatureType, (string)data);
			eventsChannel.TriggerAddAddon(modelByType);
			popup.ShrinkToParent();
		}
	}
}
