using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StoreItemUIElement : MonoBehaviour
{
	private TextMeshProUGUI titleText;

	private TextMeshProUGUI priceText;

	private Image itemIcon;

	private Image itemStoreIcon;

	private Button buyButton;

	private GameEventsChannel gameEventsChannel;

	private StoreItem currentItem;

	private long[] _recipients;

	private Action m_OnBuySuccess;

	private Action m_OnBuyFail;

	public event Action OnBuySuccess
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 96;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 96;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnBuyFail
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 104;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
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
		object obj2 = (nint)0 + (nint)8;
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
		object obj2 = (nint)0 + (nint)8;
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		if (currentItem == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = priceText;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!priceText)
			{
				return;
			}
		}
		int num = StorePricing.DiscountAmount(currentItem);
		int num2 = default(int);
		string text = num2.ToString();
		priceText.text = text;
	}

	public void Populate(StoreItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_02f6: Expected I, but got O
		//IL_034c: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_03e9: Expected I, but got O
		//IL_043a: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_0519: Expected O, but got I4
		//IL_052c: Expected I, but got O
		//IL_0535: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_0622: Expected O, but got I4
		//IL_062b: Expected O, but got I4
		//IL_064b: Expected O, but got I4
		//IL_0279: Expected O, but got I4
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_0717: Expected O, but got I
		//IL_0725: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 80;
		obj2 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v3-30]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj4 = !flag2;
			text = null;
			if (obj4 == null)
			{
				goto IL_0057;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v3-30]");
			bool flag3 = (UnityEngine.Object)0;
			bool flag4 = !flag3;
			text = null;
			if (flag4)
			{
				goto IL_0057;
			}
		}
		TextMeshProUGUI textMeshProUGUI = titleText;
		text = item.<name>k__BackingField;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v24 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		nint num2 = 0;
		textMeshProUGUI.text = item.<name>k__BackingField;
		UnityEngine.Object obj5 = priceText;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v41+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v24 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		nint num3 = 0;
		UnityEngine.Object obj8 = priceText;
		if (obj7 != null)
		{
			goto IL_00a0;
		}
		goto IL_0374;
		IL_06c7:
		Button button = buyButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = buyButton;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = 0;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj10);
		button2.m_OnClick.AddListener(unityAction);
		return;
		IL_0256:
		UnityEngine.Object obj11;
		bool flag6 = obj11;
		bool flag7 = !flag6;
		object obj12 = !flag7;
		ImageCacher.ItemImageType itemImageType = (ImageCacher.ItemImageType)num2;
		if (obj12 == null)
		{
			return;
		}
		goto IL_06c7;
		IL_067a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj13;
		bool flag8 = obj13;
		bool flag9 = !flag8;
		object obj15;
		object obj14 = obj15;
		Action<bool> action2;
		Action<bool> action = action2;
		FilterMode filterMode2;
		FilterMode filterMode = filterMode2;
		if (flag9)
		{
			return;
		}
		goto IL_06c7;
		IL_0057:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v41+E4]");
		bool flag10 = (nint)0 == 0;
		obj5 = priceText;
		num3 = num2;
		obj8 = priceText;
		if (!flag10)
		{
			goto IL_00a0;
		}
		goto IL_0374;
		IL_0374:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj8;
		bool flag12 = !flag11;
		num2 = num3;
		string text2 = null;
		if (flag12)
		{
			goto IL_00d7;
		}
		goto IL_03b7;
		IL_00a0:
		bool flag13 = obj5;
		bool flag14 = !flag13;
		object obj16 = !flag14;
		text2 = null;
		if (obj16 == null)
		{
			goto IL_00d7;
		}
		goto IL_03b7;
		IL_03b7:
		TextMeshProUGUI textMeshProUGUI2 = priceText;
		int num4 = StorePricing.DiscountAmount(item);
		int num5 = default(int);
		string text3 = num5.ToString();
		nint num6 = (nint)textMeshProUGUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		num2 = 0;
		textMeshProUGUI2.text = text3;
		UnityEngine.Object obj17 = itemIcon;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v18+E4]");
		bool flag15 = (nint)0 == 0;
		object obj19 = !flag15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		nint num7 = 0;
		text2 = text3;
		UnityEngine.Object obj20 = itemIcon;
		if (obj19 != null)
		{
			goto IL_0120;
		}
		goto IL_046a;
		IL_00d7:
		obj17 = itemIcon;
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v18+E4]");
		bool flag16 = (nint)0 == 0;
		num7 = num2;
		obj20 = itemIcon;
		if (!flag16)
		{
			goto IL_0120;
		}
		goto IL_046a;
		IL_046a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj20;
		bool flag18 = !flag17;
		num2 = num7;
		int num8 = 0;
		if (flag18)
		{
			goto IL_015a;
		}
		goto IL_04b0;
		IL_0120:
		bool flag19 = obj17;
		bool flag20 = !flag19;
		object obj21 = !flag20;
		num8 = 0;
		if (obj21 == null)
		{
			goto IL_015a;
		}
		goto IL_04b0;
		IL_04b0:
		num8 = item.<id>k__BackingField;
		UIExtensions.LoadItemImage(itemIcon, item.<id>k__BackingField, ImageCacher.ItemImageType.InGame);
		UnityEngine.Object obj22 = itemStoreIcon;
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v15+E4]");
		bool flag21 = (nint)0 == 0;
		object obj24 = !flag21;
		obj14 = 0;
		action = null;
		filterMode = FilterMode.Point;
		num2 = unchecked((nint)null);
		object obj25 = 0;
		Action<bool> action3 = null;
		FilterMode filterMode3 = FilterMode.Point;
		ImageCacher.ItemImageType itemImageType2 = ImageCacher.ItemImageType.InGame;
		UnityEngine.Object obj26 = itemStoreIcon;
		if (obj24 != null)
		{
			goto IL_01bb;
		}
		goto IL_0564;
		IL_015a:
		obj22 = itemStoreIcon;
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v15+E4]");
		bool flag22 = (nint)0 == 0;
		obj25 = obj14;
		action3 = action;
		filterMode3 = filterMode;
		itemImageType2 = (ImageCacher.ItemImageType)num2;
		obj26 = itemStoreIcon;
		if (!flag22)
		{
			goto IL_01bb;
		}
		goto IL_0564;
		IL_0564:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag23 = obj26;
		bool flag24 = !flag23;
		obj14 = obj25;
		action = action3;
		filterMode = filterMode3;
		num2 = (nint)itemImageType2;
		int num9 = 0;
		if (flag24)
		{
			goto IL_01f5;
		}
		goto IL_05c2;
		IL_01bb:
		bool flag25 = obj22;
		bool flag26 = !flag25;
		object obj27 = !flag26;
		num9 = 0;
		if (obj27 == null)
		{
			goto IL_01f5;
		}
		goto IL_05c2;
		IL_05c2:
		num9 = item.<id>k__BackingField;
		UIExtensions.LoadItemImage(itemStoreIcon, item.<id>k__BackingField, ImageCacher.ItemImageType.StoreTitle);
		obj11 = buyButton;
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v12+E4]");
		bool flag27 = (nint)0 == 0;
		object obj29 = !flag27;
		obj14 = 0;
		action = null;
		filterMode = FilterMode.Point;
		num2 = 3;
		obj15 = 0;
		action2 = null;
		filterMode2 = FilterMode.Point;
		itemImageType = ImageCacher.ItemImageType.StoreTitle;
		obj13 = buyButton;
		if (obj29 != null)
		{
			goto IL_0256;
		}
		goto IL_067a;
		IL_01f5:
		obj11 = buyButton;
		obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v12+E4]");
		bool flag28 = (nint)0 == 0;
		obj15 = obj14;
		action2 = action;
		filterMode2 = filterMode;
		itemImageType = (ImageCacher.ItemImageType)num2;
		obj13 = buyButton;
		if (!flag28)
		{
			goto IL_0256;
		}
		goto IL_067a;
	}

	public void SetBuyingRecipients(long[] recipients)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 88;
		obj = recipients;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void BuyItem()
	{
		BuyItem(_recipients);
	}

	public void BuyItem(long[] recipients)
	{
		//IL_0011: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0249: Expected O, but got I
		//IL_0257: Expected I, but got O
		//IL_0278: Expected O, but got I4
		if (currentItem == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)2640;
		if (ArraysExtensions.IsNullOrEmpty(recipients))
		{
			return;
		}
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		StoreItem storeItem = currentItem;
		int num = StorePricing.DiscountAmount(currentItem);
		object obj6 = storeItem.<virtualPrice>k__BackingField - num;
		if (aces < (nint)obj6)
		{
			object message = "not" + 88;
			gameEventsChannel.TriggerDisplayMessage((string)message);
			ITrackEvent trackEvent = TrackerLibrary.GameAnimatedGiftClickedCanBuy(canBuy: false);
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v26+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
		}
		ITrackEvent trackEvent2 = TrackerLibrary.GameAnimatedGiftClickedCanBuy(canBuy: true);
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent2);
		gameEventsChannel.TriggerDeactivateFireMode();
		StoreItem storeItem2 = currentItem;
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)4088;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj13);
		KammelnaRequests.BuyItem(storeItem2.<id>k__BackingField, action, null, (int?)(object)0, recipients);
	}

	private void <BuyItem>b__20_0(KammelnaResponseModel<BuyItemResponseModel> callback)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		if (((KammelnaResponseModel<object>)(object)callback).Succeeded)
		{
			Actions.SafeInvoke(this.OnBuySuccess);
			StoreItem storeItem = currentItem;
			ITrackEvent trackEvent = TrackerLibrary.GameAnimatedGiftBought(storeItem.<id>k__BackingField);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v16+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Actions.SafeInvoke(this.OnBuyFail);
		string errorMessage = ((KammelnaResponseModel<object>)(object)callback).ErrorMessage;
		object obj3 = "destinationTimeZone" + 3816;
		string message = (string)obj3 + errorMessage;
		object obj4 = typeof(DataRelation) + 856;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v12+E4]");
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
	}
}
