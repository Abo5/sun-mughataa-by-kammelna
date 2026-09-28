using System;
using System.Diagnostics;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class QuickPhotoReply : MonoBehaviour
{
	private Image previewImage;

	private TextMeshProUGUI priceText;

	private TextMeshProUGUI replyText;

	public Button button;

	private TopBarQuickReplies container;

	private StoreItem item;

	public StoreItem Item => item;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = this.button;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	private void Click()
	{
		container.BuyEmote(item);
	}

	public void UpdateDisplayedPrice(int price)
	{
		int num = default(int);
		string text = num.ToString();
		priceText.text = text;
	}

	public void Setup(StoreItem item, TopBarQuickReplies container)
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00bd: Expected I, but got O
		object obj = this + 72;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 64;
		obj2 = container;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X22_v3-18]");
		object obj3 = 0;
		int num = StorePricing.EffectivePrice(item);
		int num2 = default(int);
		string text = num2.ToString();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ X8_v4+558] (should have been resolved before IL gen)");
		TextMeshProExtensions.FixArabic(replyText, item.<description>k__BackingField);
		GameObject gameObject = previewImage.gameObject;
		gameObject.SetActive(value: false);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj6 = (nint)0 + (nint)1928;
		GameObject gameObject2 = previewImage.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)gameObject2, (IntPtr)obj6);
		UIExtensions.LoadItemImage(previewImage, item.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle, FilterMode.Bilinear, action);
	}
}
