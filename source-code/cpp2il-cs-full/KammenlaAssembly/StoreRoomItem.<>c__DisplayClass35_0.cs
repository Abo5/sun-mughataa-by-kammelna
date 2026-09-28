using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StoreRoomItem : ListViewItem<StoreDataHolder, int>
{
	private sealed class <>c__DisplayClass34_0
	{
		public StoreRoomItem <>4__this;

		public StoreItem item;

		internal void <PopulateStoreItem>b__0()
		{
			<>4__this.LoadOwnership(item);
			<>4__this.RefreshStatus();
		}
	}

	private sealed class <>c__DisplayClass35_0
	{
		public StoreItem item;

		internal bool <LoadOwnership>b__0(StoreOwnedItem c)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (c != null)
			{
				StoreItem storeItem = item;
				if (item != null)
				{
					object obj = c.<itemId>k__BackingField - storeItem.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public TextMeshProUGUI itemPrice;

	public RoomItem roomItem;

	private int? TemplateId;

	public Button buyButton;

	public Button activateButton;

	public GameObject itemPriceObject;

	public GameObject itemStatus;

	public DateTimeText timeLeft;

	public TextMeshProUGUI timeLeftText;

	public GameObject loadingIndicator;

	public TextMeshProUGUI rentPeriod;

	public GameObject store;

	private GameObject animatedStoreLabel;

	private int storeItemPrice;

	public StoreItem currentItem;

	private int OwnershipId;

	private bool <Activated>k__BackingField;

	private bool <Owned>k__BackingField;

	private bool <Expired>k__BackingField;

	private Store storeScript;

	public bool Activated
	{
		get
		{
			return <Activated>k__BackingField;
		}
		set
		{
			<Activated>k__BackingField = value;
		}
	}

	public bool Owned
	{
		get
		{
			return <Owned>k__BackingField;
		}
		set
		{
			<Owned>k__BackingField = value;
		}
	}

	private bool Expired
	{
		get
		{
			return <Expired>k__BackingField;
		}
		set
		{
			<Expired>k__BackingField = value;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_008d: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		Store store = default(Store);
		storeScript = store;
		object obj5 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
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
		object obj2 = (nint)0 + (nint)160;
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
		object obj2 = (nint)0 + (nint)160;
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
		StoreItem storeItem = currentItem;
		if (currentItem != null)
		{
			int num = StorePricing.DiscountAmount(currentItem);
			TextMeshProExtensions.SetPriceText(price: storeItemPrice = storeItem.<virtualPrice>k__BackingField - num, text: itemPrice);
		}
	}

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		PopulateStoreItem(datum.RoomItem, isPopup: false, isPurchasable: true, datum.<tempId>k__BackingField);
	}

	public unsafe void PopulateStoreItem(StoreItem item, bool isPopup, bool isPurchasable, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_01eb: Expected I4, but got O
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0286: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02ed: Expected O, but got I4
		//IL_031b: Expected F8, but got I
		//IL_033e: Invalid comparison between F8 and I8
		//IL_0762: Expected O, but got I4
		//IL_0788: Expected O, but got I8
		//IL_0791: Expected O, but got I4
		//IL_07ab: Expected O, but got Ref
		//IL_0372: Expected O, but got Ref
		//IL_0415: Expected O, but got I8
		//IL_041e: Expected O, but got I4
		//IL_0388: Expected I, but got O
		//IL_0398: Expected O, but got I
		//IL_03be: Expected O, but got I8
		//IL_03c7: Expected O, but got I4
		//IL_03e9: Expected O, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I8
		//IL_04b4: Expected O, but got I4
		//IL_04c5: Expected I4, but got O
		//IL_0508: Expected O, but got I8
		//IL_0511: Expected O, but got I4
		//IL_0522: Expected I4, but got O
		//IL_0560: Expected O, but got I8
		//IL_0569: Expected O, but got I4
		//IL_057a: Expected I4, but got O
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05ad: Expected O, but got I
		//IL_05f3: Expected O, but got I4
		//IL_0636: Expected O, but got I8
		//IL_063f: Expected O, but got I4
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0684: Expected O, but got I
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_06c0: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		int? num = tempId;
		bool flag2 = isPopup;
		StoreItem storeItem = null;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TemplateId = tempId;
			storeItem = (StoreItem)obj4;
			object obj5 = this + 240;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X25_v6-68]");
			bool flag3 = (nint)0 == 0;
			num = tempId;
			flag2 = isPopup;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X25_v6-68]");
				((RoomItem)0).ResetContent();
				OwnershipId = 0;
				<Activated>k__BackingField = false;
				DisableButtons();
				bool flag5 = default(bool);
				bool flag4 = !flag5;
				object obj6 = !flag4;
				flag2 = isPopup;
				storeItem = null;
				if (obj6 == null)
				{
					bool flag6 = (object)store == null;
					num = tempId;
					flag2 = isPopup;
					storeItem = null;
					if (flag6)
					{
						goto IL_06dc;
					}
					store.SetActive(value: false);
					flag2 = false;
					storeItem = null;
				}
				bool flag7 = (object)roomItem == null;
				num = tempId;
				if (!flag7)
				{
					storeItem = (StoreItem)obj4;
					roomItem.PopulateRoomItem((StoreItem)obj4, isPopup, tempId);
					StoreItem storeItem2 = (StoreItem)obj4;
					bool flag8 = obj4 == null;
					num = (int?)(object)0;
					flag5 = (byte)(int)tempId != 0;
					flag2 = isPopup;
					if (!flag8)
					{
						object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
						int num2 = StorePricing.DiscountAmount((StoreItem)obj4);
						TextMeshProExtensions.SetPriceText(price: storeItemPrice = storeItem2.<virtualPrice>k__BackingField - num2, text: itemPrice);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj8 = obj4;
						bool flag9 = obj4 == null;
						num = (int?)(object)0;
						flag5 = false;
						flag2 = false;
						storeItem = (StoreItem)1;
						if (!flag9)
						{
							object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v27+E4]");
							bool flag10 = (nint)0 == 0;
							object obj11 = !flag10;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+50]");
							TimeSpan timeSpan = TimeSpan.FromSeconds(0.0);
							TimeSpan timeSpan2 = default(TimeSpan);
							double totalDays = timeSpan2.TotalDays;
							if (totalDays == 9.218868437227405E+18)
							{
							}
							object obj12 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object[] array = default(object[]);
							bool flag11 = array == null;
							object obj13 = 9218868437227405312L;
							num = (int?)(object)0;
							flag5 = false;
							flag2 = false;
							double num3 = default(double);
							storeItem = (StoreItem)(&num3);
							if (!flag11)
							{
								object obj14 = default(object);
								bool flag12 = obj14 == null;
								StoreItem storeItem3 = (StoreItem)(&num3);
								if (!flag12)
								{
									nint num4 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
									storeItem3 = (StoreItem)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag13 = ex == null;
									obj13 = 9218868437227405312L;
									num = (int?)(object)0;
									flag5 = false;
									flag2 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
									storeItem = (StoreItem)0;
									if (flag13)
									{
										goto IL_06f8;
									}
								}
								bool flag14 = array.Length == 0;
								obj13 = 9218868437227405312L;
								num = (int?)(object)0;
								flag5 = false;
								flag2 = false;
								storeItem = storeItem3;
								if (flag14)
								{
									goto IL_06ea;
								}
								object obj15 = "Read object reference Id '{0}' for {1}." + 2224;
								object obj16 = array + 32;
								obj16 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								TextMeshProExtensions.Localize(rentPeriod, (string)obj15, array);
								bool flag15 = (object)animatedStoreLabel == null;
								obj13 = 9218868437227405312L;
								num = (int?)(object)0;
								flag5 = false;
								flag2 = (byte)(int)array != 0;
								storeItem = (StoreItem)obj15;
								if (!flag15)
								{
									GameObject gameObject = animatedStoreLabel.gameObject;
									bool flag16 = (object)roomItem == null;
									obj13 = 9218868437227405312L;
									num = (int?)(object)0;
									flag5 = false;
									flag2 = (byte)(int)array != 0;
									storeItem = null;
									if (!flag16)
									{
										bool isRoomAnimated = roomItem.IsRoomAnimated;
										bool flag17 = (object)gameObject == null;
										obj13 = 9218868437227405312L;
										num = (int?)(object)0;
										flag5 = false;
										flag2 = (byte)(int)array != 0;
										storeItem = null;
										if (!flag17)
										{
											object obj17 = typeof(Queue<string>) + 848;
											object obj18 = (nint)0 + (nint)2200;
											gameObject.SetActive(isRoomAnimated);
											GameObject go = base.gameObject;
											object obj19 = obj17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v46+E4]");
											bool flag18 = (nint)0 == 0;
											object obj20 = !flag18;
											if (obj20 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
											SessionModel sessionModel = default(SessionModel);
											bool flag19 = (object)sessionModel == null;
											obj13 = 9218868437227405312L;
											num = (int?)(object)0;
											flag5 = false;
											flag2 = false;
											storeItem = null;
											if (!flag19)
											{
												object obj21 = typeof(SqlSingle[]) + 2376;
												object obj22 = (nint)0 + (nint)1688;
												object varName = "placementId" + 2064;
												User localUser = sessionModel.LocalUser;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												Action action = default(Action);
												action..ctor(obj2, (IntPtr)obj22);
												VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_06dc;
		IL_06f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_06ea:
		ex = new IndexOutOfRangeException();
		goto IL_06f8;
		IL_06dc:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06ea;
	}

	public void LoadOwnership(StoreItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I
		//IL_010a: Expected I, but got O
		//IL_0164: Expected O, but got I4
		//IL_01d8: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
		object obj9 = (nint)0 + (nint)1696;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		List<StoreOwnedItem> ownedRoomThemes = SFSKammelnaUserExtensions.GetOwnedRoomThemes(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj9);
		object obj10 = Enumerable.FirstOrDefault(ownedRoomThemes, func);
		if (obj10 == null)
		{
			return;
		}
		bool isExpired = ((StoreOwnedItem)obj10).isExpired;
		bool flag2 = !isExpired;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v18 (System.Object)+10]");
			OwnershipId = 0;
			<Owned>k__BackingField = true;
			bool isExpired2 = ((StoreOwnedItem)obj10).isExpired;
			<Expired>k__BackingField = isExpired2;
			bool isActiveItem = ((StoreOwnedItem)obj10).IsActiveItem;
			<Activated>k__BackingField = isActiveItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v18 (System.Object)+18]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 != null)
			{
				DateTime? dateTime = default(DateTime?);
				DateTime value = dateTime.Value;
				timeLeft.SetDate(value);
				GameObject gameObject = timeLeft.gameObject;
				gameObject.SetActive(value: true);
			}
		}
	}

	public void RefreshStatus()
	{
		DisableButtons();
		if (!<Owned>k__BackingField || <Expired>k__BackingField)
		{
			itemPriceObject.SetActive(value: true);
			GameObject gameObject = buyButton.gameObject;
			gameObject.SetActive(value: true);
		}
		else if (<Activated>k__BackingField)
		{
			EnableStatus();
		}
		else
		{
			EnableActivation();
		}
	}

	private void DisableButtons()
	{
		itemPriceObject.SetActive(value: false);
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: false);
		DisableActivation();
		itemStatus.SetActive(value: false);
		GameObject gameObject2 = timeLeft.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = timeLeft.gameObject;
		gameObject3.SetActive(value: false);
	}

	private void EnablePurchasing()
	{
		itemPriceObject.SetActive(value: true);
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: true);
	}

	private void DisablePurchasing()
	{
		itemPriceObject.SetActive(value: false);
		GameObject gameObject = buyButton.gameObject;
		gameObject.SetActive(value: false);
	}

	private void EnableActivation()
	{
		//IL_0034: Expected O, but got I
		GameObject gameObject = activateButton.gameObject;
		gameObject.SetActive(value: true);
		timeLeftText.color = (Color)0;
		GameObject gameObject2 = timeLeft.gameObject;
		gameObject2.SetActive(value: true);
	}

	private void DisableActivation()
	{
		GameObject gameObject = activateButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = timeLeft.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void EnableStatus()
	{
		//IL_0022: Expected O, but got I
		itemStatus.SetActive(value: true);
		timeLeftText.color = (Color)0;
		GameObject gameObject = timeLeft.gameObject;
		gameObject.SetActive(value: true);
	}

	private void DisableStatus()
	{
		itemStatus.SetActive(value: false);
		GameObject gameObject = timeLeft.gameObject;
		gameObject.SetActive(value: false);
	}

	private void EnableTimeLeft()
	{
		GameObject gameObject = timeLeft.gameObject;
		gameObject.SetActive(value: true);
	}

	private void DisableTimeLeft()
	{
		GameObject gameObject = timeLeft.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ChangeActivated()
	{
		<Activated>k__BackingField = true;
		RefreshStatus();
	}

	public void StartLoading()
	{
		DisableButtons();
		loadingIndicator.SetActive(value: true);
	}

	public RectTransform GetRectTransform()
	{
		return UIExtensions.rectTransform(this);
	}

	private void ResetContent()
	{
		roomItem.ResetContent();
		OwnershipId = 0;
		<Activated>k__BackingField = false;
		DisableButtons();
	}

	public void ActivateItem()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0052: Expected I, but got O
		DisableButtons();
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)144;
		loadingIndicator.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.SetItemAsDefault(OwnershipId, action);
	}

	public void BuyItem()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I
		//IL_02c7: Expected I, but got O
		//IL_02d8: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_046e: Expected O, but got I
		//IL_047e: Expected O, but got I
		//IL_0494: Expected O, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I4
		//IL_04cc: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_0325: Expected O, but got I
		//IL_033b: Expected O, but got I
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0368: Expected O, but got I
		//IL_0256: Expected I8, but got I4
		//IL_052e: Expected O, but got I
		//IL_053e: Expected O, but got I
		//IL_0554: Expected O, but got I
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_0506: Expected O, but got I4
		//IL_03ab: Expected O, but got I
		//IL_03bb: Expected O, but got I
		//IL_03d1: Expected O, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03f9: Expected O, but got I4
		//IL_0409: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_058f: Expected O, but got I
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A65]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0376:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			goto IL_039b;
		}
		goto IL_0514;
		IL_0417:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0426;
		IL_0426:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v18+B8]");
		object recipients = 0;
		StoreItem storeItem;
		Action<object> action = default(Action<object>);
		KammelnaRequests.BuyItem(storeItem.<id>k__BackingField, action, null, TemplateId, (long[])recipients);
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
		IL_0137:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		if (aces < storeItemPrice)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v26+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
			object obj10 = typeof(MemberAchievementClanFeedData) + 2608;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long remaining = storeItemPrice - aces2;
			NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.ItemsStore);
			return;
		}
		DisableButtons();
		loadingIndicator.SetActive(value: true);
		storeItem = currentItem;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)152;
		action..ctor((object)this, (IntPtr)obj14);
		object obj15 = (nint)0 + (nint)3176;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X22_v3+38]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X22_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+10]");
			object obj19 = (nint)0 + (nint)309;
			object obj20 = obj19 & 1;
			bool flag6 = obj20 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+10]");
			object obj21 = 0;
			if (!flag6)
			{
				goto IL_0376;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X22_v3+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v18+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v18+10]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag7 = obj24 == null;
			object obj25 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v18+10]");
			object obj21 = 0;
			if (obj25 != null)
			{
				goto IL_0376;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		if (obj26 != null)
		{
			goto IL_039b;
		}
		goto IL_0514;
		IL_039b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X22_v3+38]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v25+10]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v25+10]");
		object obj29 = (nint)0 + (nint)309;
		object obj30 = obj29 & 1;
		bool flag9 = obj30 == null;
		object obj31 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v25+10]");
		object obj32 = 0;
		if (obj31 == null)
		{
			goto IL_0417;
		}
		goto IL_0426;
		IL_0514:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X22_v3+38]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+10]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+10]");
		object obj34 = (nint)0 + (nint)309;
		object obj35 = obj34 & 1;
		if (obj35 == null)
		{
			goto IL_0417;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+10]");
		obj32 = 0;
		goto IL_0426;
	}

	private void HandleError(string error)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0145: Expected O, but got I
		//IL_015f: Expected O, but got I4
		object obj = "rightCtrl" + 472;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		bool flag = error == (string)obj;
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0041;
			}
		}
		else
		{
			<Expired>k__BackingField = true;
			RefreshStatus();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				goto IL_0041;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
		object obj7 = (nint)0 & (nint)1;
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_0090;
		}
		goto IL_0175;
		IL_00bd:
		PopupWindow.ShowError(error);
		return;
		IL_01b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00bd;
		IL_0090:
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00bd;
		}
		goto IL_01b3;
		IL_0041:
		obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
		object obj11 = (nint)0 & (nint)1;
		bool flag5 = obj11 == null;
		obj9 = obj6;
		if (!flag5)
		{
			goto IL_0090;
		}
		goto IL_0175;
		IL_0175:
		_ = 1;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 != null)
		{
			goto IL_00bd;
		}
		goto IL_01b3;
	}

	public StoreRoomItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <ActivateItem>b__50_0(KammelnaResponseModel<bool> response)
	{
		//IL_004c: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		if (response.Succeeded)
		{
			Store store = storeScript;
			object obj = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			<Activated>k__BackingField = true;
			RefreshStatus();
			if (roomItem.IsRoomAnimated)
			{
				StoreItem storeItem = currentItem;
				ITrackEvent trackEvent = TrackerLibrary.StoreAnimatedRoomThemeActivated(storeItem.<id>k__BackingField, storeItem.<name>k__BackingField);
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v16+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent);
			}
		}
		else
		{
			RefreshStatus();
			string errorMessage = response.ErrorMessage;
			HandleError(errorMessage);
		}
	}

	private void <BuyItem>b__51_0(KammelnaResponseModel<BuyItemResponseModel> response)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0159: Expected O, but got I4
		//IL_01ea: Expected I8, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0290: Expected O, but got I4
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			<Owned>k__BackingField = true;
			BuyItemResponseModel <Model>k__BackingField = response.<Model>k__BackingField;
			StoreOwnedItem <ownedItem>k__BackingField = <Model>k__BackingField.<ownedItem>k__BackingField;
			OwnershipId = <ownedItem>k__BackingField.<id>k__BackingField;
			<Expired>k__BackingField = false;
			object obj = (??)<ownedItem>k__BackingField.<expirationDate>k__BackingField & 1;
			if (obj != null)
			{
				DateTime? dateTime = default(DateTime?);
				DateTime value = dateTime.Value;
				timeLeft.SetDate(value);
			}
			ActivateItem();
			Store store = storeScript;
			object obj2 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			StoreItem storeItem = currentItem;
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string itemId = Tracker.BuildItemId(ResourceItemId.Theme, storeItem.<name>k__BackingField);
			StoreItem storeItem2 = currentItem;
			int num = StorePricing.DiscountAmount(currentItem);
			double amount = (double)storeItem2.<virtualPrice>k__BackingField - (double)num;
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Cosmetic, itemId, amount, ResourceCurrency.Aces);
			StoreItem storeItem3 = currentItem;
			int num2 = StorePricing.DiscountAmount(currentItem);
			long value2 = storeItem3.<virtualPrice>k__BackingField - num2;
			object action = "Read object reference Id '{0}' for {1}." + 2232;
			FirebaseTrack.CurrencyEvent((string)action, storeItem3.<name>k__BackingField, value2);
			if (roomItem.IsRoomAnimated)
			{
				StoreItem storeItem4 = currentItem;
				ITrackEvent trackEvent = TrackerLibrary.StoreAnimatedRoomThemePreviewedAndBought(storeItem4.<id>k__BackingField, storeItem4.<name>k__BackingField);
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v23+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
			}
		}
		else
		{
			buyButton.interactable = true;
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			HandleError(errorMessage);
		}
	}
}
