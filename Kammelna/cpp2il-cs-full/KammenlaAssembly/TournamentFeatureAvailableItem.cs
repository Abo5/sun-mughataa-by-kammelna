using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentFeatureAvailableItem : MonoBehaviour
{
	private TournamentFeature <Feature>k__BackingField;

	public TournamentAddonType addonType;

	private CanvasGroup canvasGroup;

	private TextMeshProUGUI title;

	private TextMeshProUGUI description;

	private TextMeshProUGUI price;

	private Image icon;

	private Button selectFeatureButton;

	private Button editFeatureButton;

	private GameObject enabledBlocker;

	private GameObject featurePriceArea;

	private TournamentsCreationPopupEventsChannel eventsChannel;

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
			object obj = this + 32;
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
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = selectFeatureButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = editFeatureButton;
		object obj3 = (nint)0 + (nint)816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = selectFeatureButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = editFeatureButton;
		object obj3 = (nint)0 + (nint)816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.RemoveListener(unityAction2);
	}

	private void OnSelectFeatureButtonClicked()
	{
		eventsChannel.TriggerOpenAddFeature(<Feature>k__BackingField);
	}

	private void OnEditFeatureButtonClicked()
	{
		eventsChannel.TriggerOpenEditFeature(<Feature>k__BackingField);
	}

	public void Populate(TournamentFeature model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 32;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Refresh();
	}

	public void Refresh()
	{
		//IL_0098: Expected O, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_013c: Expected O, but got I4
		//IL_00ec: Expected I, but got O
		//IL_00fc: Expected O, but got I
		//IL_01f9: Expected O, but got I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected I4, but got Unknown
		TournamentFeature tournamentFeature = <Feature>k__BackingField;
		TextMeshProExtensions.Localize(title, tournamentFeature.Title);
		TournamentFeature tournamentFeature2 = <Feature>k__BackingField;
		TextMeshProExtensions.Localize(description, tournamentFeature2.Description);
		TournamentFeature tournamentFeature3 = <Feature>k__BackingField;
		Sprite sprite = tournamentFeature3.Icon;
		icon.sprite = tournamentFeature3.Icon;
		long cost = <Feature>k__BackingField.Cost;
		bool flag = cost < 1;
		object obj = 0;
		if (!flag)
		{
			object obj2 = "Material with texture name \"" + 3224;
			TextMeshProUGUI textMeshProUGUI = price;
			long cost2 = <Feature>k__BackingField.Cost;
			long num = default(long);
			string text = num.ToString((string)obj2);
			nint num2 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v11 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			obj = 0;
			textMeshProUGUI.text = text;
			sprite = (Sprite)(object)text;
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = featurePriceArea != null;
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(featurePriceArea != null))
			{
				return;
			}
		}
		long cost3 = <Feature>k__BackingField.Cost;
		bool flag4 = cost3 < 0;
		bool flag5 = cost3 == 0;
		long num3 = cost3 ^ cost3;
		long num4 = cost3 & num3;
		bool flag6 = num4 < 0;
		bool flag7 = flag4 == flag6;
		object obj6 = !flag5;
		bool active = (byte)((flag7 & obj6) ? 1 : 0) != 0;
		featurePriceArea.SetActive(active);
	}

	public void UnDim()
	{
		selectFeatureButton.interactable = true;
		canvasGroup.alpha = 1f;
		enabledBlocker.SetActive(value: false);
		GameObject gameObject = editFeatureButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = icon.gameObject;
		gameObject2.SetActive(value: true);
	}

	public void Dim()
	{
		selectFeatureButton.interactable = false;
		canvasGroup.alpha = 0.55f;
		enabledBlocker.SetActive(value: true);
		GameObject gameObject = editFeatureButton.gameObject;
		gameObject.SetActive(value: true);
	}
}
