using System;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StoreUniqueItemUiElement : ListViewItem<StoreDataHolder, int>
{
	private Image image;

	private Image storeImage;

	private Button activateButton;

	private ElegantLoadingIndicator loading;

	private TextMeshProUGUI countTxt;

	private DateTimeText dateTimeText;

	private ColorController colorController;

	private UniqueStoreItem _uniqueItem;

	private StoreItem _uniqueStoreItem;

	private int? _templateId;

	private Store _store;

	private static bool _didRecordTracking;

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00bd: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 208;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_templateId = datum.<tempId>k__BackingField;
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		PopulateBanner(datum.UniqueItem);
	}

	public void PopulateBanner(UniqueStoreItem storeItem)
	{
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006e: Expected I4, but got I8
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_016c: Expected I, but got O
		//IL_0198: Expected O, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_025a: Expected O, but got I4
		//IL_02d3: Expected O, but got I
		//IL_02dc: Expected O, but got I4
		object obj = this + 184;
		obj = storeItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj == null)
		{
			return;
		}
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem2 = Store.GetStoreItem((int)storeItem.<ItemId>k__BackingField);
		object obj5 = this + 192;
		obj5 = storeItem2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj5 == null)
		{
			return;
		}
		object obj6 = obj;
		TextMeshProUGUI textMesh = countTxt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+20]");
		TextMeshProExtensions.SetNumber(textMesh, 0);
		dateTimeText.SetDate(storeItem.<ExpirationDate>k__BackingField);
		LoadImage();
		Button button = activateButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = activateButton;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)208;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button2.m_OnClick.AddListener(unityAction);
		colorController.SetColor((Color)0);
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2208;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v17+B8]");
		object obj11 = 0;
		object obj12 = obj11 & 1;
		bool flag2 = obj12 == null;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v20+10]");
			ITrackEvent trackEvent = TrackerLibrary.ShopUniqueItemLoaded(0);
			object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v23+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v24+B8]");
			object obj19 = 0;
			obj19 = 1;
		}
	}

	private void LoadImage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I
		//IL_01c0: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A23]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = loading;
			obj6 = loading;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = loading;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = loading;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_0179;
		IL_0179:
		StoreItem uniqueStoreItem = _uniqueStoreItem;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj10 = (nint)0 + (nint)200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj10);
		UIExtensions.LoadItemImage(image, uniqueStoreItem.<id>k__BackingField, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
		StoreItem uniqueStoreItem2 = _uniqueStoreItem;
		UIExtensions.LoadItemImage(storeImage, uniqueStoreItem2.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle);
		return;
		IL_0160:
		loading.StartLoading();
		obj8 = 0;
		goto IL_0179;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_0160;
		}
		obj8 = 0;
		goto IL_0179;
	}

	private void PerformAction()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		_store.ShowBuyUniqueCardPopup(_uniqueItem, _uniqueStoreItem, _templateId);
		StoreItem uniqueStoreItem = _uniqueStoreItem;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.ShopUniqueItemClicked(uniqueStoreItem.<id>k__BackingField);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OpenBuyPopup()
	{
		_store.ShowBuyUniqueCardPopup(_uniqueItem, _uniqueStoreItem, _templateId);
	}

	public StoreUniqueItemUiElement()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <LoadImage>b__14_0(bool _)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		image.enabled = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!loading)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = loading;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		GameObject gameObject = loading.gameObject;
		gameObject.SetActive(value: false);
	}
}
