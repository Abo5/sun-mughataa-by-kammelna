using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class BuyCardPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Toggle, <>f__AnonymousType7<Toggle, TextMeshProUGUI>> <>9__39_0;

		public static Func<<>f__AnonymousType7<Toggle, TextMeshProUGUI>, string> <>9__39_1;

		public static Func<IGrouping<string, <>f__AnonymousType7<Toggle, TextMeshProUGUI>>, bool> <>9__39_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal <>f__AnonymousType7<Toggle, TextMeshProUGUI> <FixDuplicateLabels>b__39_0(Toggle toggle)
		{
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			if ((object)toggle != null)
			{
				object obj = (nint)0 + (nint)288;
				object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 120;
				object obj3 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2680;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FDB1BC");
				<>f__AnonymousType7<Toggle, TextMeshProUGUI> result = default(<>f__AnonymousType7<Toggle, TextMeshProUGUI>);
				return result;
			}
			return (<>f__AnonymousType7<Toggle, TextMeshProUGUI>)(object)new NullReferenceException();
		}

		internal string <FixDuplicateLabels>b__39_1(<>f__AnonymousType7<Toggle, TextMeshProUGUI> item)
		{
			//IL_003c: Expected I, but got O
			if (item != null)
			{
				TextMeshProUGUI <label>i__Field = item.<label>i__Field;
				if ((object)item.<label>i__Field != null)
				{
					nint num = (nint)<label>i__Field;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v44 @ X8_v3 (Il2CppClass<TMPro.TextMeshProUGUI>)+548] (should have been resolved before IL gen)");
				}
			}
			return (string)(object)new NullReferenceException();
		}

		internal bool <FixDuplicateLabels>b__39_2(IGrouping<string, <>f__AnonymousType7<Toggle, TextMeshProUGUI>> g)
		{
			//IL_0021: Expected O, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected I4, but got Unknown
			//IL_008f: Expected O, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected I4, but got Unknown
			int num = Enumerable.Count((IEnumerable<object>)g);
			object obj = num - 1;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = num ^ 1;
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public List<StoreOwnedItem> ownedItems;

		internal bool <SelectDefault>b__0(StoreItem item)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a5: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3592;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
				object obj4 = (nint)0 + (nint)2096;
				object obj5 = obj2 + 16;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return Enumerable.Any(ownedItems, func);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass25_1
	{
		public StoreItem item;

		internal bool <SelectDefault>b__1(StoreOwnedItem owned)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (owned != null)
			{
				StoreItem storeItem = item;
				if (item != null)
				{
					object obj = owned.<itemId>k__BackingField - storeItem.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass26_0
	{
		public int index;

		public BuyCardPopup <>4__this;

		internal void <AddTabs>b__0(bool active)
		{
			if (active)
			{
				<>4__this.SelectItem(index);
			}
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public int j;

		public BuyCardPopup <>4__this;

		internal void <InitializeCards>b__0(bool success)
		{
			//IL_0075: Expected O, but got I4
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I
			BuyCardPopup buyCardPopup = <>4__this;
			if ((object)<>4__this != null)
			{
				Image[] cardImages = buyCardPopup.cardImages;
				if (buyCardPopup.cardImages != null)
				{
					bool flag = j < cardImages.Length;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_0164;
					}
					object obj2 = buyCardPopup.cardImages + j;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+20]");
						RectTransform rectTransform = ((Graphic)0).rectTransform;
						if ((object)rectTransform != null)
						{
							Transform child = rectTransform.GetChild(0);
							if ((object)child != null)
							{
								GameObject gameObject = child.gameObject;
								if ((object)gameObject != null)
								{
									gameObject.SetActive(value: false);
									return;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0164;
			IL_0164:
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public BuyCardPopup <>4__this;

		public StoreItem bItem;

		internal void <BuySelected>b__0(KammelnaResponseModel<BuyItemResponseModel> response)
		{
			//IL_0114: Expected O, but got I
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_015f: Expected O, but got I4
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00df: Expected O, but got I4
			//IL_023c: Expected F8, but got I4
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				BuyCardPopup buyCardPopup = <>4__this;
				buyCardPopup.store.PlaySuccessfulPurchase();
				BuyItemResponseModel <Model>k__BackingField = response.<Model>k__BackingField;
				object obj = <>4__this + 144;
				obj = <Model>k__BackingField.<ownedItem>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>4__this.ActivateSelected();
				StoreItem storeItem = bItem;
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string itemId = Tracker.BuildItemId(ResourceItemId.Card, storeItem.<name>k__BackingField);
				int num = StorePricing.EffectivePrice(bItem);
				Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Cosmetic, itemId, num, ResourceCurrency.Aces);
				FirebaseTrack.BuyCard(bItem);
				return;
			}
			object obj5 = (nint)0 + (nint)1072;
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Store.ShowError(errorMessage);
			BuyCardPopup buyCardPopup2 = <>4__this;
			buyCardPopup2.actionLoading.SetActive(value: false);
			if (buyCardPopup2._ownedItem != null)
			{
				if (buyCardPopup2._ownedItem.IsActiveItem)
				{
					buyCardPopup2.ShowStatus();
				}
				else
				{
					buyCardPopup2.ShowActivate();
				}
			}
			else
			{
				buyCardPopup2.ShowBuy();
			}
		}
	}

	private string[] tierNames;

	private PopupUI popup;

	private Image titleImage;

	private GameObject tabHolder;

	private GameObject tabPrefab;

	private Image initialCard;

	private Button buyButton;

	private TextMeshProUGUI priceText;

	private Button activateButton;

	private GameObject itemStatus;

	private GameObject actionLoading;

	private Store store;

	private List<StoreItem> items;

	private int selectedIndex;

	private StoreOwnedItem _ownedItem;

	private Toggle[] cardTabs;

	private Image[] cardImages;

	private int? templateId;

	private bool Visible
	{
		get
		{
			//IL_0041: Expected I4, but got O
			PopupUI popupUI = popup;
			if ((object)popup != null)
			{
				return popupUI.<IsCurrentlyShown>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private StoreItem selectedItem
	{
		get
		{
			if (items != null)
			{
				return (StoreItem)((List<object>)(object)items).get_Item(selectedIndex);
			}
			return (StoreItem)(object)new NullReferenceException();
		}
	}

	public void Close()
	{
		popup.ShrinkToParent();
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0141: Expected O, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_017f: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0119: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 120;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)1688;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj12);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
	}

	public void Popup(List<StoreItem> packItems, int? tempId)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_0086: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_00e8: Expected I, but got O
		templateId = tempId;
		popup.PopFromCenter();
		object obj = this + 128;
		obj = packItems;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X21_v4-50]");
		Transform transform = ((Component)0).transform;
		object obj2 = typeof(UsageHint) + 816;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v8+B8]");
		object obj4 = 0;
		transform.localScale = (Vector3)0;
		object obj5 = (nint)0 + (nint)2944;
		object obj6 = ((List<object>)(object)items).get_Item(0);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj8 = (nint)0 + (nint)1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj8);
		Image img = titleImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v11 (System.Object)+10]");
		UIExtensions.LoadItemImage(img, 0, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action);
		SelectDefault();
		AddTabs();
		InitializeCards();
		SelectItem(selectedIndex);
	}

	private void SelectDefault()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_011a: Expected I, but got O
		//IL_0176: Expected O, but got I4
		//IL_0184: Expected I4, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		List<StoreItem> list = items;
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
		object obj8 = (nint)0 + (nint)2088;
		object obj9 = (nint)0 + (nint)1840;
		object obj10 = obj2 + 16;
		obj10 = ownedCards;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		object obj11 = default(object);
		int num;
		if (obj11 != null)
		{
			num = ((List<object>)(object)items).IndexOf(obj11);
		}
		else
		{
			object obj12 = list._size + list._size;
			num = obj12 >> 1;
		}
		selectedIndex = num;
	}

	private void AddTabs()
	{
		//IL_0010: Expected O, but got I
		//IL_0c20: Expected O, but got I4
		//IL_003b: Expected I, but got O
		//IL_004d: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00a1: Expected I, but got O
		//IL_00d6: Expected I, but got O
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0149: Expected I, but got O
		//IL_0151: Expected I4, but got O
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_01b7: Expected O, but got I
		//IL_01db: Expected I, but got O
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0211: Expected O, but got I
		//IL_021d: Expected O, but got I
		//IL_0253: Expected I, but got O
		//IL_026b: Expected O, but got I
		//IL_0cf5: Expected O, but got I4
		//IL_0d13: Expected O, but got I4
		//IL_0d25: Expected O, but got I4
		//IL_0d71: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02db: Expected O, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0358: Expected O, but got I4
		//IL_0365: Expected I4, but got O
		//IL_037d: Expected I4, but got O
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03ca: Expected O, but got I4
		//IL_03f3: Expected O, but got I
		//IL_03fb: Expected I, but got O
		//IL_0430: Expected O, but got I4
		//IL_0435: Expected I, but got O
		//IL_043d: Expected I4, but got O
		//IL_0457: Expected O, but got I
		//IL_045f: Expected I4, but got O
		//IL_04a2: Expected O, but got I4
		//IL_04a7: Expected I, but got O
		//IL_04cb: Expected O, but got I
		//IL_04d3: Expected I, but got O
		//IL_0507: Expected I, but got O
		//IL_051f: Expected O, but got I4
		//IL_0562: Expected I, but got O
		//IL_057a: Expected O, but got I4
		//IL_05bd: Expected I, but got O
		//IL_05d5: Expected O, but got I4
		//IL_060b: Expected O, but got I
		//IL_061b: Expected O, but got I4
		//IL_0686: Expected O, but got I4
		//IL_0c8a: Expected O, but got I4
		//IL_0ca2: Expected O, but got I4
		//IL_0cbd: Expected O, but got I4
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected O, but got Unknown
		//IL_06b3: Expected O, but got I4
		//IL_06dc: Expected O, but got I
		//IL_06e9: Expected I, but got O
		//IL_06f5: Expected O, but got I
		//IL_06fd: Expected I4, but got O
		//IL_072b: Expected O, but got I4
		//IL_0730: Expected I, but got O
		//IL_07cc: Expected O, but got I4
		//IL_07e1: Expected O, but got I
		//IL_07ec: Expected I, but got O
		//IL_075f: Expected O, but got I
		//IL_078d: Expected I, but got O
		//IL_080f: Expected O, but got I
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_0825: Expected O, but got I4
		//IL_0837: Expected I, but got O
		//IL_0856: Expected O, but got I4
		//IL_085b: Expected I, but got O
		//IL_0889: Expected O, but got I
		//IL_08aa: Expected O, but got I4
		//IL_08bf: Expected O, but got I
		//IL_08ca: Expected I, but got O
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected O, but got Unknown
		//IL_0911: Expected O, but got I4
		//IL_0916: Expected I, but got O
		//IL_0947: Expected O, but got I4
		//IL_0956: Expected O, but got I4
		//IL_09a7: Expected O, but got I4
		//IL_09ac: Expected I, but got O
		//IL_09d6: Expected O, but got I4
		//IL_09f1: Expected O, but got I4
		//IL_0a00: Expected O, but got I4
		//IL_0a0b: Expected I, but got O
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected O, but got Unknown
		//IL_0a40: Expected O, but got I
		//IL_0a67: Expected O, but got I4
		//IL_0a6c: Expected I, but got O
		//IL_0aa4: Expected I, but got O
		//IL_0ac9: Expected I, but got O
		//IL_0ad1: Expected O, but got I4
		//IL_0ad9: Expected I4, but got O
		//IL_0af5: Expected O, but got I4
		//IL_0afd: Expected I, but got O
		//IL_0b2d: Expected O, but got I4
		//IL_0b32: Expected I, but got O
		//IL_0b4f: Expected I, but got O
		//IL_0b69: Expected O, but got I4
		//IL_0b71: Expected I4, but got O
		//IL_0b79: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68EE]");
		List<StoreItem> list = (List<StoreItem>)0;
		bool flag = (object)tabPrefab == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		Transform transform = (Transform)152985600;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			tabPrefab.SetActive(value: true);
			bool flag3 = (object)tabHolder == null;
			nint num = unchecked((nint)null);
			flag2 = true;
			transform = (Transform)152985600;
			if (!flag3)
			{
				GameObject[] array = (GameObject[])(typeof(TypeConverter<ushort, char>) + 2568);
				Transform transform2 = tabHolder.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				GameObject[] array2 = default(GameObject[]);
				bool flag4 = array2 == null;
				num = unchecked((nint)null);
				flag2 = true;
				transform = transform2;
				if (!flag4)
				{
					bool flag5 = array2.Length == 0;
					num = unchecked((nint)null);
					bool flag6 = true;
					if (flag5)
					{
						goto IL_0bda;
					}
					object obj = array2 + 32;
					obj = tabPrefab;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					UIExtensions.DestroyAllChildren(transform2, array2);
					list = items;
					bool flag7 = items == null;
					array = array2;
					num = unchecked((nint)null);
					flag2 = (byte)(int)array2 != 0;
					transform = transform2;
					if (!flag7)
					{
						object obj2 = typeof(SqlSingle[]) + 296;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						transform = (Transform)(this + 152);
						bool flag8 = default(bool);
						transform = (Transform)flag8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X20_v2 (UnityEngine.Transform)-18]");
						list = (List<StoreItem>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X20_v2 (UnityEngine.Transform)-18]");
						bool flag9 = (nint)0 == 0;
						array = array2;
						num = unchecked((nint)null);
						flag2 = flag8;
						if (!flag9)
						{
							object obj3 = typeof(TypeConverter<ushort, char>) + 360;
							object obj4 = (nint)0 + (nint)2104;
							object obj5 = (nint)0 + (nint)832;
							object obj7 = default(object);
							object obj6 = obj7;
							nint num3 = default(nint);
							nint num2 = num3;
							nint num5 = default(nint);
							nint num4 = num5;
							bool flag11 = default(bool);
							bool flag10 = flag11;
							object obj8 = obj2;
							int num6 = 0;
							nint num7 = unchecked((nint)null);
							bool flag12 = flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X20_v2 (UnityEngine.Transform)-18]");
							List<StoreItem> list2 = (List<StoreItem>)0;
							object obj11 = default(object);
							bool flag19 = default(bool);
							TextMeshProUGUI textMesh = default(TextMeshProUGUI);
							bool flag32 = default(bool);
							bool flag45 = default(bool);
							while (true)
							{
								list = (List<StoreItem>)list2._size;
								bool flag13 = num6 < list2._size;
								object obj9 = !flag13;
								object obj10 = num6 - list2._size;
								bool flag14 = num6 >= list2._size;
								obj7 = obj6;
								num3 = num2;
								num5 = num4;
								flag11 = flag10;
								obj2 = obj8;
								array = (GameObject[])num6;
								num = num7;
								flag2 = flag12;
								if (!flag14)
								{
									list = (List<StoreItem>)(typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3600);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									obj11..ctor();
									bool flag15 = obj11 == null;
									obj7 = obj6;
									num3 = num2;
									num5 = num4;
									flag11 = flag10;
									obj2 = obj8;
									array = (GameObject[])num6;
									num = num7;
									flag2 = false;
									if (flag15)
									{
										break;
									}
									object obj12 = obj11 + 24;
									obj12 = this;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag16 = (object)tabHolder == null;
									obj7 = obj6;
									num3 = num2;
									num5 = num4;
									flag11 = flag10;
									obj2 = obj8;
									array = (GameObject[])num6;
									num = num7;
									flag2 = (byte)(int)this != 0;
									if (flag16)
									{
										break;
									}
									flag11 = (byte)(int)tabPrefab != 0;
									Transform transform3 = tabHolder.transform;
									object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
									object obj14 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v33+E4]");
									bool flag17 = (nint)0 == 0;
									object obj15 = !flag17;
									if (obj15 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									list = (List<StoreItem>)((nint)0 + (nint)920);
									num5 = (nint)list;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
									bool flag18 = !flag19;
									obj7 = obj6;
									num3 = num2;
									obj2 = obj8;
									array = (GameObject[])num6;
									num = unchecked((nint)null);
									flag2 = (byte)(int)transform3 != 0;
									if (flag18)
									{
										break;
									}
									list = (List<StoreItem>)((nint)0 + (nint)1560);
									flag2 = (byte)(int)list != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
									bool flag20 = items == null;
									obj7 = obj6;
									num3 = num2;
									flag11 = flag19;
									obj2 = obj8;
									array = (GameObject[])num6;
									num = unchecked((nint)null);
									if (flag20)
									{
										break;
									}
									string[] array3 = tierNames;
									list = (List<StoreItem>)((nint)0 + (nint)2944);
									num = (nint)list;
									object obj16 = ((List<object>)(object)items).get_Item(num6);
									bool flag21 = obj16 == null;
									obj7 = obj6;
									num3 = (nint)tierNames;
									flag11 = flag19;
									obj2 = obj8;
									array = (GameObject[])num6;
									flag2 = (byte)num6 != 0;
									if (flag21)
									{
										break;
									}
									string[] array4 = tierNames;
									bool flag22 = tierNames == null;
									obj7 = obj6;
									num3 = (nint)tierNames;
									flag11 = flag19;
									obj2 = obj8;
									array = (GameObject[])num6;
									flag2 = (byte)num6 != 0;
									list = (List<StoreItem>)(object)tierNames;
									if (flag22)
									{
										break;
									}
									bool flag23 = tierNames == null;
									obj7 = obj6;
									num3 = (nint)tierNames;
									flag11 = flag19;
									obj2 = obj8;
									array = (GameObject[])num6;
									flag2 = (byte)num6 != 0;
									list = (List<StoreItem>)(object)tierNames;
									if (flag23)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v39 (System.Object)+6C]");
									object obj17 = -1;
									object obj18 = array4.Length - 1;
									object obj19 = obj17 - obj18;
									bool flag24 = (nint)obj19 < 0;
									object obj20 = obj17 ^ obj18;
									object obj21 = obj17 ^ obj19;
									object obj22 = obj20 & obj21;
									bool flag25 = (nint)obj22 < 0;
									bool flag26 = flag24 == flag25;
									object obj23 = !flag26;
									object obj24 = ~obj23;
									if (obj24 == null)
									{
										obj18 = obj17;
									}
									bool flag27 = (nint)obj17 < 0;
									object obj25 = obj17 ^ obj17;
									object obj26 = obj17 & obj25;
									bool flag28 = (nint)obj26 < 0;
									bool flag29 = flag27 == flag28;
									flag14 = !flag29;
									obj7 = !flag14;
									if (obj7 == null)
									{
										obj18 = 0;
									}
									obj2 = array3.Length;
									bool flag30 = (nint)obj18 < array3.Length;
									obj9 = !flag30;
									obj10 = obj18 - array3.Length;
									flag6 = (byte)num6 != 0;
									if (obj9 == null)
									{
										object obj27 = (object)tierNames + obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v28+20]");
										TextMeshProExtensions.Localize(textMesh, (string)0);
										num3 = (nint)transform;
										list = (List<StoreItem>)((nint)0 + (nint)1480);
										flag2 = (byte)(int)list != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
										bool flag31 = (object)transform == null;
										flag11 = flag19;
										array = (GameObject[])num6;
										num = unchecked((nint)null);
										if (flag31)
										{
											break;
										}
										if (flag32)
										{
											object obj28 = num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v40+40]");
											flag2 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag33 = ex == null;
											num = unchecked((nint)null);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v40+40]");
											flag6 = false;
											if (flag33)
											{
												goto IL_0be8;
											}
										}
										int num8 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X26_v1 (Il2CppClass<UnityEngine.Transform>)+18]");
										bool flag34 = (nint)num8 < (nint)0;
										obj9 = !flag34;
										int num9 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X26_v1 (Il2CppClass<UnityEngine.Transform>)+18]");
										obj10 = (nint)num9 - (nint)0;
										num = unchecked((nint)null);
										flag6 = flag2;
										if (obj9 == null)
										{
											object obj29 = num3 + num6;
											object obj30 = obj29 + 32;
											obj30 = flag32;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											nint num10 = (nint)transform;
											bool flag35 = (object)transform == null;
											flag11 = flag32;
											array = (GameObject[])num6;
											num = unchecked((nint)null);
											flag2 = flag32;
											list = (List<StoreItem>)(object)transform;
											if (flag35)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+18]");
											obj2 = 0;
											int num11 = num6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+18]");
											bool flag36 = (nint)num11 < (nint)0;
											obj9 = !flag36;
											int num12 = num6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+18]");
											obj10 = (nint)num12 - (nint)0;
											num = unchecked((nint)null);
											flag6 = flag32;
											if (obj9 == null)
											{
												list = (List<StoreItem>)(transform + num6);
												bool flag37 = list._syncRoot == null;
												flag11 = flag32;
												array = (GameObject[])num6;
												num = unchecked((nint)null);
												flag2 = flag32;
												if (flag37)
												{
													break;
												}
												bool flag38 = num6 < selectedIndex;
												obj9 = !flag38;
												obj10 = num6 - selectedIndex;
												bool flag39 = obj10 == null;
												((Toggle)list._syncRoot).isOn = flag39;
												Toggle[] array5 = cardTabs;
												bool flag40 = cardTabs == null;
												flag11 = flag32;
												array = (GameObject[])num6;
												num = unchecked((nint)null);
												flag2 = flag39;
												list = (List<StoreItem>)(object)cardTabs;
												if (flag40)
												{
													break;
												}
												obj2 = array5.Length;
												bool flag41 = num6 < array5.Length;
												obj9 = !flag41;
												obj10 = num6 - array5.Length;
												num = unchecked((nint)null);
												flag6 = flag39;
												if (obj9 == null)
												{
													object obj31 = cardTabs + num6;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v37+20]");
													list = (List<StoreItem>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v37+20]");
													bool flag42 = (nint)0 == 0;
													flag11 = flag32;
													array = (GameObject[])num6;
													num = unchecked((nint)null);
													flag2 = flag39;
													if (flag42)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v3 (System.Collections.Generic.List`1<StoreItem>)+118]");
													flag11 = false;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													num = (nint)obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v3 (System.Collections.Generic.List`1<StoreItem>)+118]");
													bool flag43 = (byte)(~(nuint)0u) != 0;
													num5 = unchecked((nint)null);
													array = (GameObject[])num6;
													flag2 = (byte)(int)obj11 != 0;
													if (flag43)
													{
														break;
													}
													array = (GameObject[])(num6 + 1);
													num = (nint)obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
													list = items;
													bool flag44 = items == null;
													object obj32 = !flag44;
													num5 = unchecked((nint)null);
													flag2 = flag45;
													obj6 = obj7;
													num2 = num3;
													num4 = unchecked((nint)null);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v3 (System.Collections.Generic.List`1<StoreItem>)+118]");
													flag10 = false;
													obj8 = array5.Length;
													num6 = (int)array;
													num7 = (nint)obj5;
													flag12 = flag45;
													list2 = items;
													if (obj32 == null)
													{
														break;
													}
													continue;
												}
											}
										}
									}
									goto IL_0bda;
								}
								FixDuplicateLabels();
								if ((object)tabPrefab == null)
								{
									break;
								}
								tabPrefab.SetActive(value: false);
								return;
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_0bda:
		ex = new IndexOutOfRangeException();
		goto IL_0be8;
		IL_0be8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void InitializeCards()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_01bb: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0214: Expected O, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_037f: Expected O, but got I
		//IL_0387: Expected I4, but got O
		//IL_0450: Expected O, but got I4
		//IL_0459: Expected O, but got I4
		//IL_03e5: Expected I, but got O
		//IL_03f5: Expected O, but got I
		//IL_0417: Expected O, but got I4
		//IL_0427: Expected O, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_04ec: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0592: Expected I, but got O
		//IL_05c2: Expected O, but got I
		//IL_05f6: Expected O, but got I4
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if ((object)initialCard != null)
		{
			GameObject gameObject = initialCard.gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: true);
				if ((object)initialCard != null)
				{
					Transform transform = initialCard.transform;
					if ((object)transform != null)
					{
						object obj = typeof(TypeConverter<ushort, char>) + 2568;
						Transform parent = transform.parent;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						GameObject[] array = default(GameObject[]);
						if (array != null)
						{
							bool flag = array.Length == 0;
							object obj2 = 0;
							Transform transform2 = (Transform)1;
							if (flag)
							{
								goto IL_0648;
							}
							object obj3 = array + 32;
							obj3 = gameObject;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							UIExtensions.DestroyAllChildren(parent, array);
							List<StoreItem> list = items;
							bool flag2 = items == null;
							GameObject gameObject2 = gameObject;
							if (!flag2)
							{
								object obj4 = typeof(TypeConverter<ushort, char>) + 2936;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object obj5 = this + 160;
								int num = default(int);
								obj5 = num;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v8-20]");
								List<StoreItem> list2 = (List<StoreItem>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v8-20]");
								bool flag3 = (nint)0 == 0;
								gameObject2 = gameObject;
								if (!flag3)
								{
									object obj6 = (nint)0 + (nint)2944;
									object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
									object obj8 = (nint)0 + (nint)2112;
									int num2 = 0;
									ImageCacher.ItemImageType itemImageType = ImageCacher.ItemImageType.InGame;
									int num3 = num;
									object obj10 = default(object);
									Transform transform4 = default(Transform);
									Action<bool> action = default(Action<bool>);
									while (true)
									{
										bool flag4 = num2 >= list2._size;
										gameObject2 = gameObject;
										if (!flag4)
										{
											object obj9 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3608;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											obj10..ctor();
											bool flag5 = obj10 == null;
											gameObject2 = gameObject;
											if (flag5)
											{
												break;
											}
											object obj11 = obj10 + 24;
											obj11 = this;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											bool flag6 = (object)initialCard == null;
											gameObject2 = gameObject;
											if (flag6)
											{
												break;
											}
											Image[] array2 = cardImages;
											Transform transform3 = initialCard.transform;
											bool flag7 = (object)transform3 == null;
											gameObject2 = gameObject;
											if (flag7)
											{
												break;
											}
											Transform parent2 = transform3.parent;
											object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
											object obj13 = obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v34+E4]");
											bool flag8 = (nint)0 == 0;
											object obj14 = !flag8;
											if (obj14 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj15 = (nint)0 + (nint)936;
											FilterMode filterMode = (FilterMode)obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
											bool flag9 = cardImages == null;
											gameObject2 = gameObject;
											if (flag9)
											{
												break;
											}
											bool flag10 = (object)transform4 == null;
											Transform transform5 = parent2;
											if (!flag10)
											{
												nint num4 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v24 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
												transform5 = (Transform)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag11 = ex == null;
												obj2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v24 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
												transform2 = (Transform)0;
												if (flag11)
												{
													goto IL_0656;
												}
											}
											bool flag12 = num2 < array2.Length;
											object obj16 = !flag12;
											obj2 = 0;
											transform2 = transform5;
											if (obj16 == null)
											{
												object obj17 = cardImages + num2;
												object obj18 = obj17 + 32;
												obj18 = transform4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj19 = obj5;
												bool flag13 = obj5 == null;
												gameObject2 = gameObject;
												if (flag13)
												{
													break;
												}
												int num5 = num2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v21+18]");
												bool flag14 = (nint)num5 < (nint)0;
												object obj20 = !flag14;
												obj2 = 0;
												transform2 = transform4;
												if (obj20 == null)
												{
													bool flag15 = items == null;
													gameObject2 = gameObject;
													if (flag15)
													{
														break;
													}
													object obj21 = obj5 + num2;
													object obj22 = ((List<object>)(object)items).get_Item(num2);
													bool flag16 = obj22 == null;
													gameObject2 = gameObject;
													if (flag16)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													action..ctor(obj10, (IntPtr)obj8);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v22+20]");
													nint num6 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v43 (System.Object)+10]");
													UIExtensions.LoadItemImage((Image)num6, 0, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
													num2++;
													list2 = items;
													bool flag17 = items == null;
													object obj23 = !flag17;
													gameObject2 = gameObject;
													filterMode = FilterMode.Point;
													itemImageType = ImageCacher.ItemImageType.InGame;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v43 (System.Object)+10]");
													num3 = 0;
													if (obj23 == null)
													{
														break;
													}
													continue;
												}
											}
											goto IL_0648;
										}
										gameObject2.SetActive(value: false);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_0656:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0648:
		ex = new IndexOutOfRangeException();
		goto IL_0656;
	}

	private void SelectItem(int index)
	{
		//IL_025f: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_0015: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_0130: Expected I, but got O
		//IL_0286: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		object obj = selectedIndex + 1;
		int num;
		if ((nint)obj != index)
		{
			object obj2 = selectedIndex - 1;
			if ((nint)obj2 <= index)
			{
				object obj3 = index - 1;
				bool flag;
				if (selectedIndex >= (nint)obj3)
				{
					object obj4 = obj2 - index;
					flag = obj4 == null;
				}
				else
				{
					flag = true;
				}
				object obj5 = !flag;
				num = index;
				if (obj5 == null)
				{
					store.PlayCardBackSwitchToLeft();
					num = 0;
				}
				goto IL_004d;
			}
		}
		store.PlayCardBackSwitchToRight();
		num = 0;
		goto IL_004d;
		IL_004d:
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		selectedIndex = index;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
		object obj11 = (nint)0 + (nint)1712;
		object obj12 = (nint)0 + (nint)1264;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj11);
		object obj13 = Enumerable.FirstOrDefault(ownedCards, func);
		object obj14 = this + 144;
		obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RepositionCards();
		actionLoading.SetActive(value: false);
		if (obj14 != null)
		{
			if (((StoreOwnedItem)obj14).IsActiveItem)
			{
				ShowStatus();
			}
			else
			{
				ShowActivate();
			}
		}
		else
		{
			ShowBuy();
		}
	}

	private void RepositionCards()
	{
		//IL_005a: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_0274: Expected O, but got I
		//IL_02b4: Expected O, but got I
		//IL_01c2: Expected F8, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0223: Expected O, but got I4
		if (cardImages == null || !Enumerable.Any((IEnumerable<object>)cardImages))
		{
			return;
		}
		Image[] array = cardImages;
		bool flag = selectedIndex < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = array + selectedIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v9+20]");
			RectTransform rectTransform = ((Graphic)0).rectTransform;
			rectTransform.SetAsLastSibling();
			List<StoreItem> list = items;
			object obj3 = 1;
			while (true)
			{
				object obj4 = obj3 - 1;
				if ((nint)obj4 < list._size)
				{
					Image[] array2 = cardImages;
					object obj5 = list._size + list._size;
					object obj6 = obj5 >> 1;
					object obj7 = obj3 + selectedIndex;
					object obj8 = obj7 + obj6;
					object obj9 = obj8 / array2.Length;
					object obj10 = obj9 * array2.Length;
					object obj11 = obj8 - obj10;
					bool flag2 = (nint)obj11 < array2.Length;
					object obj12 = !flag2;
					if (obj12 != null)
					{
						break;
					}
					object obj13 = (object)array2 + obj11;
					object obj14 = obj6 - list._size;
					object obj15 = obj3 + obj14;
					bool flag3 = obj15 == null;
					object obj16 = !flag3;
					double num = ((obj16 != null) ? 1.0 : 1067030938.0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X10_v7+20]");
					RectTransform rectTransform2 = ((Graphic)0).rectTransform;
					float endValue = (float)obj15 * 150f;
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(rectTransform2, endValue, 0.2f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X10_v7+20]");
					RectTransform rectTransform3 = ((Graphic)0).rectTransform;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(rectTransform3, (float)num, 0.2f);
					list = items;
					obj3++;
					bool flag4 = items == null;
					object obj17 = !flag4;
					if (obj17 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	private void UpdateButtons()
	{
		actionLoading.SetActive(value: false);
		if (_ownedItem != null)
		{
			if (_ownedItem.IsActiveItem)
			{
				ShowStatus();
			}
			else
			{
				ShowActivate();
			}
		}
		else
		{
			ShowBuy();
		}
	}

	private void ShowBuy()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = activateButton.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = itemStatus.gameObject;
		gameObject3.SetActive(value: false);
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = (nint)0 + (nint)2944;
		object item = ((List<object>)(object)items).get_Item(selectedIndex);
		int endValue = StorePricing.EffectivePrice((StoreItem)item);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(priceText, endValue, 0.2f);
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1720;
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
		object obj2 = (nint)0 + (nint)1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged -= action;
	}

	private void RefreshPrice()
	{
		//IL_0050: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		if (items == null)
		{
			return;
		}
		GameObject gameObject = buyButton.gameObject;
		if (gameObject.activeSelf)
		{
			object obj = (nint)0 + (nint)2944;
			object item = ((List<object>)(object)items).get_Item(selectedIndex);
			int endValue = StorePricing.EffectivePrice((StoreItem)item);
			object obj2 = typeof(SqlSingle[]) + 3912;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(priceText, endValue, 0.2f);
		}
	}

	private void ShowActivate()
	{
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = activateButton.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = itemStatus.gameObject;
		gameObject3.SetActive(value: false);
	}

	private void ShowStatus()
	{
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = activateButton.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = itemStatus.gameObject;
		gameObject3.SetActive(value: true);
	}

	private void StartLoading()
	{
		actionLoading.SetActive(value: true);
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = activateButton.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = itemStatus.gameObject;
		gameObject3.SetActive(value: false);
	}

	private void StopLoading()
	{
		actionLoading.SetActive(value: false);
	}

	private void FixDuplicateLabels()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_0226: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_0246: Expected O, but got I
		//IL_0268: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_0bed: Expected O, but got I4
		//IL_019b: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected O, but got Unknown
		//IL_0b53: Expected O, but got I
		//IL_0b64: Expected I, but got O
		//IL_0b82: Expected O, but got I
		//IL_0b9d: Expected O, but got I4
		//IL_0c7f: Expected O, but got I
		//IL_0c8b: Expected O, but got I
		//IL_0c9b: Expected O, but got I
		//IL_0cab: Expected O, but got I
		//IL_0ccd: Expected O, but got I4
		//IL_02b0: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected O, but got Unknown
		//IL_0c2d: Expected O, but got I
		//IL_0c3e: Expected I, but got O
		//IL_0c5c: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_02e0: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0d05: Expected O, but got I
		//IL_0d16: Expected I, but got O
		//IL_0d34: Expected O, but got I
		//IL_038a: Expected O, but got I4
		//IL_037c: Expected O, but got I
		//IL_0aaf: Expected O, but got I
		//IL_0a85: Expected O, but got I4
		//IL_0433: Expected O, but got I
		//IL_04fe: Expected O, but got I4
		//IL_0daa: Expected O, but got I
		//IL_046e: Expected O, but got I
		//IL_087c: Expected O, but got I4
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_054b: Expected O, but got I
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0616: Expected O, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_0e3a: Expected O, but got I
		//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Expected O, but got Unknown
		//IL_0586: Expected O, but got I
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0a68: Expected O, but got I4
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		//IL_08da: Expected O, but got I
		//IL_0a2a: Expected O, but got I4
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_0981: Expected O, but got I4
		//IL_0680: Expected O, but got I
		//IL_0f20: Expected O, but got I
		//IL_0915: Expected O, but got I
		//IL_074b: Expected O, but got I4
		//IL_0ec0: Expected O, but got I
		//IL_06bb: Expected O, but got I
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected O, but got Unknown
		//IL_0a13: Expected O, but got I4
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e87: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0790: Expected O, but got I
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0a41: Expected O, but got I4
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected O, but got Unknown
		//IL_0806: Expected O, but got I
		//IL_082a: Expected O, but got I4
		//IL_0833: Expected O, but got I4
		//IL_0844: Expected O, but got I4
		//IL_085c: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3576;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v102+E4]");
		object obj4;
		Func<object, object> selector;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v102+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v71+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v71+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_00f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v102+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v71+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v71+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_00f8;
			}
		}
		goto IL_014f;
		IL_0a18:
		NullReferenceException ex = new NullReferenceException();
		object obj8 = 0;
		goto IL_0a7b;
		IL_0a01:
		NullReferenceException ex2 = new NullReferenceException();
		obj8 = 0;
		goto IL_0a7b;
		IL_0d9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v41+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v769 @ X0_v41] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = obj9;
		object obj12 = default(object);
		object obj11 = obj12;
		object obj14;
		object obj13 = obj14;
		if (flag3)
		{
			goto IL_086a;
		}
		object obj19;
		object obj24 = default(object);
		object obj28;
		object obj31 = default(object);
		int num = default(int);
		string text4 = default(string);
		object obj34;
		bool flag5 = default(bool);
		while (true)
		{
			object obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v30+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v30+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0603;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v30+B0]");
			object obj17 = (nint)0 + (nint)8;
			bool flag4 = flag5;
			object obj20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X10_v26-8]");
				object obj18 = 0 - obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X10_v26-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				obj20 = obj17 + 16;
				obj16--;
				obj18 = obj16 - 1;
				bool flag6 = obj18 == null;
				flag5 = (nint)obj16 != 1;
				flag4 = flag5;
				obj17 = obj20;
				if (flag5)
				{
					continue;
				}
				goto IL_0603;
			}
			object obj21 = obj15 + obj17;
			object obj22 = obj21 + 312;
			flag5 = flag4;
			obj20 = obj17;
			goto IL_0e2a;
			IL_0e2a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X0_v47+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v867 @ X0_v47] (should have been resolved before IL gen)");
			object obj23 = obj24 & 1;
			if (obj23 == null)
			{
				break;
			}
			if (obj9 == null)
			{
				goto IL_0a18;
			}
			object obj25 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v40+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v40+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0738;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v40+B0]");
			object obj27 = (nint)0 + (nint)8;
			bool flag7 = flag5;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X10_v21-8]");
				object obj18 = 0 - obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X10_v21-8]");
				if (0 == (nint)obj28)
				{
					break;
				}
				obj20 = obj27 + 16;
				obj26--;
				obj18 = obj26 - 1;
				bool flag6 = obj18 == null;
				flag5 = (nint)obj26 != 1;
				flag7 = flag5;
				obj27 = obj20;
				if (flag5)
				{
					continue;
				}
				goto IL_0738;
			}
			object obj29 = obj25 + obj27;
			object obj30 = obj29 + 312;
			flag5 = flag7;
			obj20 = obj27;
			goto IL_0eb0;
			IL_0eb0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v60+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1008 @ X0_v60] (should have been resolved before IL gen)");
			if (obj31 == null)
			{
				goto IL_0a01;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X0_v62+18]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X0_v62+18]");
			if ((nint)0 != 0)
			{
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1019 @ X8_v43+548] (should have been resolved before IL gen)");
				string text2 = num.ToString();
				string text3 = text4 + (string)obj34 + text2;
				object obj35 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v44+560]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1032 @ X8_v44+558] (should have been resolved before IL gen)");
				bool flag8 = obj9 == null;
				object obj36 = !flag8;
				obj12 = 0;
				obj10 = obj9;
				obj11 = 0;
				text = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v44+560]");
				obj13 = 0;
				if (obj36 != null)
				{
					continue;
				}
				goto IL_086a;
			}
			goto IL_0a2f;
			IL_0738:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj14 = 0;
			goto IL_0eb0;
			IL_0603:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj14 = 0;
			goto IL_0e2a;
		}
		if (obj9 != null)
		{
			object obj37 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj38 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v36+12E]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v36+12E]");
			if ((nint)0 == 0)
			{
				goto IL_096e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v36+B0]");
			object obj40 = (nint)0 + (nint)8;
			bool flag9 = flag5;
			object obj20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X10_v15-8]");
				if (0 == (nint)obj37)
				{
					break;
				}
				obj20 = obj40 + 16;
				obj39--;
				flag5 = (nint)obj39 != 1;
				flag9 = flag5;
				obj40 = obj20;
				if (flag5)
				{
					continue;
				}
				goto IL_096e;
			}
			object obj41 = obj38 + obj40;
			object obj42 = obj41 + 312;
			flag5 = flag9;
			obj20 = obj40;
			goto IL_0f10;
		}
		goto IL_0a56;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v102+E4]");
		bool flag10 = (nint)0 == 0;
		object obj43 = !flag10;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj44 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v77+B8]");
			obj4 = 0;
		}
		object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj46 = (nint)0 + (nint)2064;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj4, (IntPtr)obj46);
		object obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v76+B8]");
		object obj48 = (nint)0 + (nint)8;
		obj48 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = 0;
		obj3 = obj6;
		selector = func;
		goto IL_014f;
		IL_096e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj14 = 0;
		goto IL_0f10;
		IL_04eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj14 = 0;
		goto IL_0d9a;
		IL_014f:
		IEnumerable<object> enumerable = Enumerable.Select(cardTabs, selector);
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v92+E4]");
		object obj51;
		Func<object, object> keySelector;
		IEnumerable<object> source;
		object obj53;
		IEnumerable<object> enumerable2;
		object obj50;
		if ((nint)0 != 0)
		{
			obj50 = (nint)0 + (nint)1512;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v92+B8]");
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v60+10]");
			keySelector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v60+10]");
			bool flag11 = (nint)0 == 0;
			object obj52 = !flag11;
			source = enumerable;
			if (obj52 == null)
			{
				obj53 = obj50;
				enumerable2 = enumerable;
				goto IL_028e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj49 = obj;
			obj53 = (nint)0 + (nint)1512;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v92+B8]");
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v60+10]");
			keySelector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v60+10]");
			bool flag12 = (nint)0 == 0;
			object obj54 = !flag12;
			enumerable2 = enumerable;
			obj50 = obj53;
			source = enumerable;
			if (obj54 == null)
			{
				goto IL_028e;
			}
		}
		goto IL_0bb2;
		IL_0a7b:
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		goto IL_0d4b;
		IL_0f10:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v53+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1016 @ X0_v53] (should have been resolved before IL gen)");
		goto IL_0a56;
		IL_0d4b:
		NullReferenceException ex3 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		bool flag13 = (nint)text != 1;
		NullReferenceException ex4 = ex3;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj55 = (nint)0 + (nint)2416;
			text = (string)obj55;
			enumerator2.Dispose();
			object obj56 = default(object);
			if (obj56 == null)
			{
				return;
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			enumerator = (List<object>.Enumerator)obj56;
			ex4 = (NullReferenceException)(object)ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22386D4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_028e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v92+E4]");
		bool flag14 = (nint)0 == 0;
		object obj57 = !flag14;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj58 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v66+B8]");
			obj51 = 0;
		}
		object obj59 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj60 = (nint)0 + (nint)2072;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj51, (IntPtr)obj60);
		object obj61 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v65+B8]");
		object obj62 = (nint)0 + (nint)16;
		obj62 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj50 = obj53;
		obj12 = 0;
		source = enumerable2;
		keySelector = func2;
		goto IL_0bb2;
		IL_086a:
		NullReferenceException ex6 = new NullReferenceException();
		obj8 = 0;
		obj12 = obj11;
		obj14 = obj13;
		goto IL_0a7b;
		IL_0a56:
		OutOfMemoryException ex7 = new OutOfMemoryException();
		obj8 = 0;
		goto IL_0a7b;
		IL_0bb2:
		IEnumerable<IGrouping<object, object>> enumerable3 = Enumerable.GroupBy(source, keySelector);
		object obj63 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v11+E4]");
		bool flag15 = (nint)0 == 0;
		object obj64 = !flag15;
		IEnumerable<IGrouping<object, object>> source2 = enumerable3;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj63 = obj;
			source2 = enumerable3;
		}
		object obj65 = (nint)0 + (nint)3120;
		object obj66 = (nint)0 + (nint)1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v11+B8]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v51+18]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v51+18]");
		bool flag16 = (nint)0 == 0;
		object obj68 = !flag16;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v11+E4]");
			bool flag17 = (nint)0 == 0;
			object obj69 = !flag17;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj70 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v57+B8]");
				obj67 = 0;
			}
			object obj71 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj72 = (nint)0 + (nint)2080;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj67, (IntPtr)obj72);
			object obj73 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v56+B8]");
			object obj74 = (nint)0 + (nint)24;
			obj74 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = 0;
			predicate = func3;
		}
		obj14 = obj65;
		IEnumerable<object> source3 = Enumerable.Where(source2, predicate);
		text = (string)obj66;
		List<object> list = Enumerable.ToList(source3);
		if (list == null)
		{
			goto IL_0d4b;
		}
		object obj75 = (nint)0 + (nint)2424;
		object obj76 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2640;
		obj19 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj28 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4000;
		obj34 = (nint)0 + (nint)3072;
		List<object>.Enumerator enumerator3 = list.GetEnumerator();
		text = (string)obj75;
		if (enumerator2.MoveNext())
		{
			object obj77 = default(object);
			if (obj77 != null)
			{
				object obj78 = obj77;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v25+12E]");
				object obj79 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v25+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04eb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v25+B0]");
				object obj80 = (nint)0 + (nint)8;
				bool flag18 = flag5;
				object obj20;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v31-8]");
					object obj18 = 0 - obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v31-8]");
					if (0 == (nint)obj76)
					{
						break;
					}
					obj20 = obj80 + 16;
					obj79--;
					obj18 = obj79 - 1;
					bool flag6 = obj18 == null;
					flag5 = (nint)obj79 != 1;
					flag18 = flag5;
					obj80 = obj20;
					if (flag5)
					{
						continue;
					}
					goto IL_04eb;
				}
				object obj81 = obj78 + obj80;
				object obj82 = obj81 + 312;
				flag5 = flag18;
				obj20 = obj80;
				goto IL_0d9a;
			}
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0a7b;
		}
		enumerator2.Dispose();
		return;
		IL_0a2f:
		NullReferenceException ex9 = new NullReferenceException();
		obj8 = 0;
		goto IL_0a7b;
	}

	public void BuySelected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_025d: Expected O, but got I4
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02c6: Expected O, but got I
		//IL_02e0: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_033d: Expected O, but got I
		//IL_034e: Expected I, but got O
		//IL_035f: Expected O, but got I
		//IL_0377: Expected O, but got I
		//IL_04f8: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_051e: Expected O, but got I
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_0546: Expected O, but got I4
		//IL_0556: Expected O, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_020a: Expected O, but got I4
		//IL_03ac: Expected O, but got I
		//IL_03c2: Expected O, but got I
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_03ef: Expected O, but got I
		//IL_0643: Expected I8, but got I4
		//IL_05b8: Expected O, but got I
		//IL_05c8: Expected O, but got I
		//IL_05de: Expected O, but got I
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_0590: Expected O, but got I4
		//IL_0432: Expected O, but got I
		//IL_0442: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0480: Expected O, but got I4
		//IL_0490: Expected O, but got I
		//IL_04bd: Expected O, but got I
		//IL_0619: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj8 = 152985600;
		object obj9 = (nint)0 + (nint)2944;
		object item = ((List<object>)(object)items).get_Item(selectedIndex);
		int num = StorePricing.EffectivePrice((StoreItem)item);
		if (aces < num)
		{
			object item2 = ((List<object>)(object)items).get_Item(selectedIndex);
			int num2 = StorePricing.EffectivePrice((StoreItem)item2);
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v57+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
			object obj12 = typeof(MemberAchievementClanFeedData) + 2608;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long remaining = num2 - aces2;
			NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.ItemsStore);
			return;
		}
		StartLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X24_v2+980]");
		object obj15 = (nint)0 & (nint)1;
		bool flag4 = obj15 == null;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			_ = 1;
		}
		object obj17 = ((List<object>)(object)items).get_Item(selectedIndex);
		object obj18 = obj2 + 24;
		obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X24_v2+980]");
		object obj19 = (nint)0 & (nint)1;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			_ = 1;
		}
		object obj21 = ((List<object>)(object)items).get_Item(selectedIndex);
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)2120;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj23);
		object obj24 = (nint)0 + (nint)3176;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X20_v3+38]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X20_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v17+10]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v17+10]");
			object obj28 = (nint)0 + (nint)309;
			object obj29 = obj28 & 1;
			bool flag6 = obj29 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v17+10]");
			object obj30 = 0;
			if (!flag6)
			{
				goto IL_03fd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X20_v3+38]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v24+10]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v24+10]");
			object obj32 = (nint)0 + (nint)309;
			object obj33 = obj32 & 1;
			bool flag7 = obj33 == null;
			object obj34 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v24+10]");
			object obj30 = 0;
			if (obj34 != null)
			{
				goto IL_03fd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v31+E4]");
		bool flag8 = (nint)0 == 0;
		object obj35 = !flag8;
		if (obj35 != null)
		{
			goto IL_0422;
		}
		goto IL_059e;
		IL_04ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v39+B8]");
		object recipients = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v28 (System.Object)+10]");
		KammelnaRequests.BuyItem(0, action, null, templateId, (long[])recipients);
		return;
		IL_059e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X20_v3+38]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v19+10]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v19+10]");
		object obj38 = (nint)0 + (nint)309;
		object obj39 = obj38 & 1;
		if (obj39 == null)
		{
			goto IL_049e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v19+10]");
		object obj40 = 0;
		goto IL_04ad;
		IL_03fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v31+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0422;
		}
		goto IL_059e;
		IL_049e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_04ad;
		IL_0422:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X20_v3+38]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v31+10]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v31+10]");
		object obj42 = (nint)0 + (nint)309;
		object obj43 = obj42 & 1;
		bool flag9 = obj43 == null;
		object obj44 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v31+10]");
		obj40 = 0;
		if (obj44 == null)
		{
			goto IL_049e;
		}
		goto IL_04ad;
	}

	public void ActivateSelected()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		StartLoading();
		StoreOwnedItem ownedItem = _ownedItem;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.SetItemAsDefault(ownedItem.<id>k__BackingField, action);
	}

	public void OnSwipe(SwipeGesture swipeGesture)
	{
		//IL_00bb: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected I4, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_0158: Expected O, but got I
		PopupUI popupUI = popup;
		if ((object)popup != null)
		{
			if (!popupUI.<IsCurrentlyShown>k__BackingField || !DirectionExtensions.IsHorizontal(swipeGesture.CardinalDirection))
			{
				return;
			}
			List<StoreItem> list = items;
			if (items != null)
			{
				Toggle[] array = cardTabs;
				if (cardTabs != null)
				{
					object obj = list._size + selectedIndex;
					object obj2 = obj - 1;
					object obj3 = ((swipeGesture.CardinalDirection != GestureDirection.Right) ? ((object)(obj + 1)) : obj2);
					int num = obj3 / list._size;
					object obj4 = num * list._size;
					object obj5 = obj3 - obj4;
					bool flag = (nint)obj5 < array.Length;
					object obj6 = !flag;
					if (obj6 != null)
					{
						goto IL_0168;
					}
					object obj7 = (object)cardTabs + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v8+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v8+20]");
						((Toggle)0).isOn = true;
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0168;
		IL_0168:
		throw new IndexOutOfRangeException();
	}

	public BuyCardPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0087: Expected O, but got I8
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj2 = "AvailableVoices" + 1224;
			object obj4 = default(object);
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v6-8]");
			if ((object)(0 & 0xFFFFFFFEL) != null)
			{
				object obj5 = "Error reading data from socket: " + 3624;
				object obj6 = obj4 + 40;
				obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X21_v8-10]");
				object obj7 = (nint)0 >= (nint)2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X21_v8-10]");
				if ((object)(~obj7 | ((object)(-2) == null)) == null)
				{
					object obj8 = "SetRoomVariables request error" + 1448;
					object obj9 = obj4 + 48;
					obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj10 = this + 32;
					obj10 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					base..ctor();
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void <Awake>b__23_0()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_00f7: Expected I, but got O
		//IL_0108: Expected O, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0151: Expected O, but got I
		PopupUI popupUI = popup;
		if (!popupUI.<IsCurrentlyShown>k__BackingField)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
		object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)1696;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)1264;
		object obj8 = Enumerable.FirstOrDefault(ownedCards, func);
		object obj9 = this + 144;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v6-20]");
		((GameObject)0).SetActive(value: false);
		if (obj9 != null)
		{
			if (((StoreOwnedItem)obj9).IsActiveItem)
			{
				ShowStatus();
			}
			else
			{
				ShowActivate();
			}
		}
		else
		{
			ShowBuy();
		}
	}

	private bool <Awake>b__23_1(StoreOwnedItem c)
	{
		//IL_0091: Expected I4, but got O
		//IL_006f: Expected O, but got I
		if (c != null && items != null)
		{
			object obj = ((List<object>)(object)items).get_Item(selectedIndex);
			if (obj != null)
			{
				int <itemId>k__BackingField = c.<itemId>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v5 (System.Object)+10]");
				object obj2 = (nint)<itemId>k__BackingField - (nint)0;
				return obj2 == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <Popup>b__24_0(bool success)
	{
		Transform target = titleImage.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.3f);
	}

	private bool <SelectItem>b__28_0(StoreOwnedItem c)
	{
		//IL_0091: Expected I4, but got O
		//IL_006f: Expected O, but got I
		if (c != null && items != null)
		{
			object obj = ((List<object>)(object)items).get_Item(selectedIndex);
			if (obj != null)
			{
				int <itemId>k__BackingField = c.<itemId>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v5 (System.Object)+10]");
				object obj2 = (nint)<itemId>k__BackingField - (nint)0;
				return obj2 == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <ActivateSelected>b__41_0(KammelnaResponseModel<bool> response)
	{
		//IL_0058: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		if (response.Succeeded)
		{
			store.PlayItemActivate();
			popup.ShrinkToParent();
			return;
		}
		object obj = (nint)0 + (nint)1024;
		string errorMessage = response.ErrorMessage;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.ShowError(errorMessage);
		actionLoading.SetActive(value: false);
		if (_ownedItem != null)
		{
			if (_ownedItem.IsActiveItem)
			{
				ShowStatus();
			}
			else
			{
				ShowActivate();
			}
		}
		else
		{
			ShowBuy();
		}
	}
}
