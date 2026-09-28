using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class QuickPhotoReplySetup : MonoBehaviour
{
	private Image previewImage;

	public Button button;

	private Toggle toggle;

	private Image highlight;

	private GameObject closeIndicator;

	private TextMeshProUGUI priceText;

	private TextMeshProUGUI replyText;

	private StoreItem item;

	private SettingEmotesSection container;

	public void Setup(StoreItem item, SettingEmotesSection container)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_0016: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_013b: Expected I, but got O
		object obj = this + 88;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 96;
		obj2 = container;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X22_v3-38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3+100]");
		((UnityEventBase)0).RemoveAllListeners();
		Button button = this.button;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj5 = (nint)0 + (nint)920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj5);
		button.m_OnClick.AddListener(unityAction);
		int num = StorePricing.EffectivePrice(item);
		int num2 = default(int);
		string text = num2.ToString();
		priceText.text = text;
		TextMeshProExtensions.FixArabic(replyText, item.<description>k__BackingField);
		GameObject gameObject = previewImage.gameObject;
		gameObject.SetActive(value: false);
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj7 = (nint)0 + (nint)1928;
		GameObject gameObject2 = previewImage.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)gameObject2, (IntPtr)obj7);
		UIExtensions.LoadItemImage(previewImage, item.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle, FilterMode.Bilinear, action);
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged += action;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged -= action;
	}

	private void RefreshPrice()
	{
		if (item != null)
		{
			int num = StorePricing.EffectivePrice(item);
			int num2 = default(int);
			string text = num2.ToString();
			priceText.text = text;
		}
	}

	public void SetCloseIndicatorVisibility(bool visible)
	{
		GameObject gameObject = closeIndicator.gameObject;
		gameObject.SetActive(visible);
	}

	public void Select()
	{
		GameObject gameObject = highlight.gameObject;
		gameObject.SetActive(value: true);
	}

	public void Deselect()
	{
		GameObject gameObject = highlight.gameObject;
		gameObject.SetActive(value: false);
	}

	private void OnButtonClick()
	{
		SettingEmotesSection settingEmotesSection = container;
		if (settingEmotesSection.previewMode)
		{
			settingEmotesSection.OnPreviewClicked(item);
		}
		else
		{
			settingEmotesSection.OnEmoteClicked(this);
		}
	}

	public StoreItem GetItem()
	{
		return item;
	}
}
