using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BuyUniqueItemPopup : MonoBehaviour
{
	private TextMeshProUGUI amountRemaining;

	private DateTimeText offerEnds;

	private Image productImage;

	private Image storeImage;

	private Button buyButton;

	private TextMeshProUGUI price;

	private RotatingLoadingIndicator loading;

	private ColorController colorController;

	private TextMeshProUGUI purchaseButtonText;

	private UniqueStoreItem _currentlyShowing;

	private StoreItem _currentStoreItemToSell;

	private StoreOwnedItem _ownedItem;

	private int? _templateId;

	private PopupUI Popup
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI result = default(PopupUI);
			return result;
		}
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c9: Expected I, but got O
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2144;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+B8]");
		object obj5 = 0;
		Delegate obj6 = (Delegate)obj5;
		bool flag;
		Delegate obj9 = default(Delegate);
		do
		{
			Delegate obj7 = Delegate.Combine(obj6, action);
			if ((object)obj7 == null || obj7 == obj)
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj9 == obj6;
				obj6 = obj9;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag);
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c9: Expected I, but got O
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2144;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+B8]");
		object obj5 = 0;
		Delegate obj6 = (Delegate)obj5;
		bool flag;
		Delegate obj9 = default(Delegate);
		do
		{
			Delegate obj7 = Delegate.Remove(obj6, action);
			if ((object)obj7 == null || obj7 == obj)
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj9 == obj6;
				obj6 = obj9;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag);
	}

	private void RefreshPrice()
	{
		StoreItem currentStoreItemToSell = _currentStoreItemToSell;
		if (_currentStoreItemToSell != null)
		{
			int num = StorePricing.DiscountAmount(_currentStoreItemToSell);
			int num2 = currentStoreItemToSell.<virtualPrice>k__BackingField - num;
			TextMeshProExtensions.SetPriceText(price, num2, useCommas: true);
		}
	}

	public void Close()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		PopupUI popupUI = default(PopupUI);
		popupUI.ShrinkToParent();
	}

	public void StartBuyDialogue(UniqueStoreItem item, StoreItem storeItem, int? templateId)
	{
		//IL_000c: Expected O, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_008d: Expected I, but got O
		//IL_00cd: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0205: Expected O, but got I
		//IL_0223: Expected O, but got I4
		object obj = (nint)0 + (nint)4008;
		object obj2 = this + 104;
		obj2 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 112;
		obj3 = storeItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_templateId = templateId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		PopupUI popupUI = default(PopupUI);
		popupUI.PopFromCenter();
		SetVisuals(item);
		Button button = buyButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = buyButton;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj5 = (nint)0 + (nint)1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj5);
		button2.m_OnClick.AddListener(unityAction);
		bool flag = UserHaveTheItem();
		bool flag2 = !flag;
		object obj6 = !flag2;
		DateTime now;
		object obj11;
		if (obj6 == null)
		{
			object obj7 = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ABC]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 != null)
			{
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					goto IL_014f;
				}
			}
			else
			{
				_ = 1;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v24+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 != null)
				{
					goto IL_014f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			now = DateTime.Now;
			obj11 = obj2;
			goto IL_01f0;
		}
		goto IL_0257;
		IL_014f:
		now = DateTime.Now;
		obj11 = obj2;
		bool flag4 = obj2 == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01f0;
		IL_0257:
		buyButton.interactable = false;
		goto IL_026d;
		IL_026d:
		colorController.SetColor((Color)0);
		return;
		IL_01f0:
		DateTime dateTime = now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+10]");
		bool flag5 = dateTime > (DateTime)0;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 != null || item.<IsSoldOut>k__BackingField)
		{
			goto IL_0257;
		}
		goto IL_026d;
	}

	private void SetVisuals(UniqueStoreItem item)
	{
		//IL_0057: Expected O, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		UniqueStoreItem currentlyShowing = _currentlyShowing;
		TextMeshProExtensions.SetNumber(amountRemaining, currentlyShowing.<Count>k__BackingField);
		UniqueStoreItem currentlyShowing2 = _currentlyShowing;
		offerEnds.SetDate(currentlyShowing2.<ExpirationDate>k__BackingField);
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		PopupUI popupUI = default(PopupUI);
		popupUI.PopFromCenter();
		StoreItem currentStoreItemToSell = _currentStoreItemToSell;
		int num = StorePricing.DiscountAmount(_currentStoreItemToSell);
		int num2 = currentStoreItemToSell.<virtualPrice>k__BackingField - num;
		TextMeshProExtensions.SetPriceText(price, num2, useCommas: true);
		object text = "SetRoomVariables request error" + 1520;
		object obj2 = "AvailableVoices" + 3104;
		bool flag = !item.<IsSoldOut>k__BackingField;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			text = obj2;
		}
		TextMeshProExtensions.Localize(purchaseButtonText, (string)text);
		LoadImage();
	}

	private bool UserHaveTheItem()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013d: Expected O, but got I
		//IL_0167: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01cc: Expected I4, but got O
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		//IL_0110: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A76]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01be;
		IL_00b8:
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
		object obj10 = (nint)0 + (nint)1800;
		User localUser = sessionModel.LocalUser;
		List<StoreOwnedItem> ownedCards = SFSKammelnaUserExtensions.GetOwnedCards(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj10);
		return Enumerable.Any(ownedCards, func);
		IL_01be:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_01be;
	}

	private bool OfferHasEnded()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_0162: Expected I4, but got O
		//IL_0146: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ABC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		UniqueStoreItem currentlyShowing = _currentlyShowing;
		bool flag2 = _currentlyShowing == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00af;
		}
		goto IL_0154;
		IL_00af:
		return now > currentlyShowing.<ExpirationDate>k__BackingField;
		IL_0154:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_007d:
		now = DateTime.Now;
		currentlyShowing = _currentlyShowing;
		if (_currentlyShowing != null)
		{
			goto IL_00af;
		}
		goto IL_0154;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A77]");
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
		StoreItem currentStoreItemToSell = _currentStoreItemToSell;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj10 = (nint)0 + (nint)1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj10);
		UIExtensions.LoadItemImage(productImage, currentStoreItemToSell.<id>k__BackingField, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
		StoreItem currentStoreItemToSell2 = _currentStoreItemToSell;
		UIExtensions.LoadItemImage(storeImage, currentStoreItemToSell2.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle);
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

	private void Buy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_005f: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_02a1: Expected O, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I
		//IL_02f6: Expected I, but got O
		//IL_0141: Expected O, but got I4
		//IL_0307: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_049d: Expected O, but got I
		//IL_04ad: Expected O, but got I
		//IL_04c3: Expected O, but got I
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04eb: Expected O, but got I4
		//IL_04fb: Expected O, but got I
		//IL_0354: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0397: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		//IL_055d: Expected O, but got I
		//IL_056d: Expected O, but got I
		//IL_0583: Expected O, but got I
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_0535: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected I8, but got Unknown
		//IL_03da: Expected O, but got I
		//IL_03ea: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0428: Expected O, but got I4
		//IL_0438: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_05be: Expected O, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		buyButton.interactable = false;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		StoreItem currentStoreItemToSell = _currentStoreItemToSell;
		int num = StorePricing.DiscountAmount(_currentStoreItemToSell);
		object obj5 = currentStoreItemToSell.<virtualPrice>k__BackingField - num;
		if (aces < (nint)obj5)
		{
			StoreItem currentStoreItemToSell2 = _currentStoreItemToSell;
			int num2 = StorePricing.DiscountAmount(_currentStoreItemToSell);
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v39+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
			object obj8 = typeof(MemberAchievementClanFeedData) + 2608;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v40+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = currentStoreItemToSell2.<virtualPrice>k__BackingField - num2;
			long remaining = obj11 - aces2;
			NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.UniqueItems);
			buyButton.interactable = true;
			ITrackEvent trackEvent = TrackerLibrary.ShopUniqueItemAttemptBuy(hasEnoughCurrency: false);
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v45+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
		}
		ITrackEvent trackEvent2 = TrackerLibrary.ShopUniqueItemAttemptBuy(hasEnoughCurrency: true);
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent2);
		StoreItem currentStoreItemToSell3 = _currentStoreItemToSell;
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1784;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)3176;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X22_v4+38]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X22_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v16+10]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v16+10]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag5 = obj24 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v16+10]");
			object obj25 = 0;
			if (!flag5)
			{
				goto IL_03a5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X22_v4+38]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v23+10]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v23+10]");
			object obj27 = (nint)0 + (nint)309;
			object obj28 = obj27 & 1;
			bool flag6 = obj28 == null;
			object obj29 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v23+10]");
			object obj25 = 0;
			if (obj29 != null)
			{
				goto IL_03a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj30 = !flag7;
		if (obj30 != null)
		{
			goto IL_03ca;
		}
		goto IL_0543;
		IL_03ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X22_v4+38]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v30+10]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v30+10]");
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		bool flag8 = obj34 == null;
		object obj35 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v30+10]");
		object obj36 = 0;
		if (obj35 == null)
		{
			goto IL_0446;
		}
		goto IL_0455;
		IL_0446:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0455;
		IL_03a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			goto IL_03ca;
		}
		goto IL_0543;
		IL_0543:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X22_v4+38]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+10]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+10]");
		object obj38 = (nint)0 + (nint)309;
		object obj39 = obj38 & 1;
		if (obj39 == null)
		{
			goto IL_0446;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+10]");
		obj36 = 0;
		goto IL_0455;
		IL_0455:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v26+B8]");
		object recipients = 0;
		KammelnaRequests.BuyItem(currentStoreItemToSell3.<id>k__BackingField, action, null, _templateId, (long[])recipients);
	}

	public void ActivateSelected()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		StoreOwnedItem ownedItem = _ownedItem;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.SetItemAsDefault(ownedItem.<id>k__BackingField, action);
	}

	private bool <UserHaveTheItem>b__21_0(StoreOwnedItem c)
	{
		//IL_007f: Expected I4, but got O
		//IL_005d: Expected O, but got I4
		if (c != null)
		{
			StoreItem currentStoreItemToSell = _currentStoreItemToSell;
			if (_currentStoreItemToSell != null)
			{
				object obj = c.<itemId>k__BackingField - currentStoreItemToSell.<id>k__BackingField;
				return obj == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <LoadImage>b__23_0(bool _)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		productImage.enabled = true;
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

	private void <Buy>b__24_0(KammelnaResponseModel<BuyItemResponseModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03fd: Expected O, but got I
		//IL_0417: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_029f: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_045d: Expected O, but got I4
		//IL_04aa: Expected O, but got I4
		//IL_00be: Expected O, but got I
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_03ac: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0147: Expected I, but got O
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I4
		object obj = (nint)0 + (nint)1088;
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj6 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			BuyItemResponseModel <Model>k__BackingField = response.<Model>k__BackingField;
			object obj7 = this + 120;
			obj7 = <Model>k__BackingField.<ownedItem>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj7;
			object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj10 = (nint)0 + (nint)1776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v41+10]");
			KammelnaRequests.SetItemAsDefault(0, action);
			StoreItem currentStoreItemToSell = _currentStoreItemToSell;
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string itemId = Tracker.BuildItemId(ResourceItemId.Unique, currentStoreItemToSell.<name>k__BackingField);
			StoreItem currentStoreItemToSell2 = _currentStoreItemToSell;
			int num = StorePricing.DiscountAmount(_currentStoreItemToSell);
			double amount = (double)currentStoreItemToSell2.<virtualPrice>k__BackingField - (double)num;
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Cosmetic, itemId, amount, ResourceCurrency.Aces);
			FirebaseTrack.BuyCard(_currentStoreItemToSell);
			return;
		}
		object obj14 = (nint)0 + (nint)1072;
		string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v8+E4]");
		object obj17;
		object obj19;
		if ((nint)0 != 0)
		{
			obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
			object obj18 = (nint)0 & (nint)1;
			bool flag3 = obj18 == null;
			obj19 = obj17;
			if (!flag3)
			{
				goto IL_02c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
			object obj20 = (nint)0 & (nint)1;
			bool flag4 = obj20 == null;
			object obj21 = !flag4;
			obj19 = obj17;
			if (obj21 != null)
			{
				goto IL_02c4;
			}
		}
		_ = 1;
		object obj22 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj23 = !flag5;
		if (obj23 != null)
		{
			goto IL_02f1;
		}
		goto IL_046b;
		IL_046b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowError(errorMessage);
		Selectable selectable = buyButton;
		bool flag6 = (object)buyButton == null;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_030a;
		IL_02f1:
		PopupWindow.ShowError(errorMessage);
		selectable = buyButton;
		goto IL_030a;
		IL_02c4:
		obj22 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			goto IL_02f1;
		}
		goto IL_046b;
		IL_030a:
		selectable.interactable = true;
		object obj25 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "Error reading data from socket: " + 504;
		object arg = default(object);
		string error = string.Format((string)format, arg);
		ITrackEvent trackEvent = TrackerLibrary.ShopUniqueItemAttemptBuy(error);
		object obj26 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void <ActivateSelected>b__25_0(KammelnaResponseModel<bool> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_020a: Expected O, but got I
		//IL_0224: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_00c2: Expected O, but got I
		//IL_00e6: Expected O, but got I
		object obj = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj6 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			object obj7 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.ShrinkToParent();
			return;
		}
		object obj8 = (nint)0 + (nint)1024;
		string errorMessage = response.ErrorMessage;
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v8+E4]");
		object obj11;
		object obj13;
		if ((nint)0 != 0)
		{
			obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
			object obj12 = (nint)0 & (nint)1;
			bool flag2 = obj12 == null;
			obj13 = obj11;
			if (!flag2)
			{
				goto IL_019e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
			object obj14 = (nint)0 & (nint)1;
			bool flag3 = obj14 == null;
			object obj15 = !flag3;
			obj13 = obj11;
			if (obj15 != null)
			{
				goto IL_019e;
			}
		}
		_ = 1;
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 != null)
		{
			goto IL_01cb;
		}
		goto IL_0278;
		IL_019e:
		obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			goto IL_01cb;
		}
		goto IL_0278;
		IL_0278:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_01cb;
		IL_01cb:
		PopupWindow.ShowError(errorMessage);
	}
}
