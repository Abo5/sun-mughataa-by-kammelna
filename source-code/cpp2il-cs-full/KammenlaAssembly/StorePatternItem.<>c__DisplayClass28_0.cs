using System;
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
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StorePatternItem : ListViewItem<StoreDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__34_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <RefreshStatus>b__34_0(GameObject b)
		{
			b.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public StorePatternItem <>4__this;

		public StoreItem item;

		internal void <Populate>b__0()
		{
			<>4__this.LoadOwnership(item);
			<>4__this.RefreshStatus();
		}
	}

	private sealed class <>c__DisplayClass30_0
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

	private PatternSetter patternSetter;

	private RankSetter rankSetter;

	private Button purchaseButton;

	private Button activateButton;

	private GameObject activeIndicator;

	private TextMeshProUGUI priceText;

	private StoreSoundAlbum soundAlbum;

	private StoreItem currentItem;

	private int? TemplateId;

	private int OwnershipId;

	private bool <Activated>k__BackingField;

	private bool <Owned>k__BackingField;

	private int itemPrice
	{
		get
		{
			//IL_0025: Expected I4, but got O
			StoreItem storeItem = currentItem;
			bool flag = currentItem == null;
			int result = (int)currentItem;
			if (!flag)
			{
				int num = StorePricing.DiscountAmount(currentItem);
				result = storeItem.<virtualPrice>k__BackingField - num;
			}
			return result;
		}
	}

	private bool Activated
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

	private bool Owned
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

	private bool isDefault => currentItem == null;

	private GameObject[] Butts
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_00c6: Expected O, but got I8
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_0125: Expected O, but got I4
			//IL_013b: Expected O, but got I
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected O, but got Unknown
			object obj = typeof(TypeConverter<ushort, char>) + 2568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if ((object)purchaseButton != null)
			{
				GameObject gameObject = purchaseButton.gameObject;
				GameObject[] array = default(GameObject[]);
				if (array != null)
				{
					if (array.Length != 0)
					{
						object obj2 = array + 32;
						obj2 = gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if ((object)activateButton == null)
						{
							goto IL_0195;
						}
						GameObject gameObject2 = activateButton.gameObject;
						object obj3 = array.Length & 0xFFFFFFFEL;
						if (obj3 != null)
						{
							object obj4 = array + 40;
							obj4 = gameObject2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v5-10]");
							bool flag = (nint)0 < (nint)2;
							object obj5 = !flag;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v5-10]");
							object obj6 = -2;
							bool flag2 = obj6 == null;
							object obj7 = ~obj5;
							object obj8 = obj7 | flag2;
							if (obj8 == null)
							{
								object obj9 = array + 48;
								obj9 = activeIndicator;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return array;
							}
						}
					}
					goto IL_01a3;
				}
			}
			goto IL_0195;
			IL_01a3:
			return (GameObject[])(object)new IndexOutOfRangeException();
			IL_0195:
			NullReferenceException ex = new NullReferenceException();
			goto IL_01a3;
		}
	}

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0031: Expected I4, but got O
		object obj = (nint)0 + (nint)2016;
		bool flag = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, flag);
		Populate(datum.PatternItem, flag, (byte)(int)obj != 0, datum.<tempId>k__BackingField);
		AssignButtons();
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
		object obj2 = (nint)0 + (nint)112;
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
		object obj2 = (nint)0 + (nint)112;
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
		int price;
		if (currentItem != null)
		{
			int num = StorePricing.DiscountAmount(currentItem);
			price = storeItem.<virtualPrice>k__BackingField - num;
		}
		else
		{
			price = 0;
		}
		TextMeshProExtensions.SetPriceText(priceText, price);
	}

	private void Populate(StoreItem item, bool isPopup, bool isPurchasable, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0274: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02b0: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj7 = this + 184;
		obj7 = obj6;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X23_v4-30]");
		object obj8 = 0;
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X8_v5+1A8] (should have been resolved before IL gen)");
		object obj12 = obj6;
		int pattern;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+10]");
			pattern = 0;
			bool flag2 = (object)patternSetter == null;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			pattern = 0;
		}
		patternSetter.SetPattern(pattern);
		StoreItem storeItem = currentItem;
		int price;
		if (currentItem != null)
		{
			int num = StorePricing.DiscountAmount(currentItem);
			price = storeItem.<virtualPrice>k__BackingField - num;
		}
		else
		{
			price = 0;
		}
		TextMeshProExtensions.SetPriceText(priceText, price);
		GameObject go2 = base.gameObject;
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj16 = typeof(SqlSingle[]) + 2376;
		object obj17 = (nint)0 + (nint)1616;
		object varName = "placementId" + 1536;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj17);
		VariableBinderExtensions.Bind(go2, localUser2, (string)varName, action);
	}

	private void AssignButtons()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a9: Expected O, but got I
		//IL_00c1: Expected I, but got O
		Button button = activateButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = purchaseButton;
		button2.m_OnClick.RemoveAllListeners();
		Button button3 = activateButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button3.m_OnClick.AddListener(unityAction);
		Button button4 = purchaseButton;
		object obj3 = (nint)0 + (nint)104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button4.m_OnClick.AddListener(unityAction2);
	}

	private void LoadOwnership(StoreItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I
		//IL_0127: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag2;
		if (obj5 != null)
		{
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
			object obj9 = (nint)0 + (nint)1624;
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			List<StoreOwnedItem> ownedPatterns = SFSKammelnaUserExtensions.GetOwnedPatterns(localUser);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj9);
			object obj10 = Enumerable.FirstOrDefault(ownedPatterns, func);
			if (obj10 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v27 (System.Object)+10]");
			OwnershipId = 0;
			<Owned>k__BackingField = true;
			flag2 = ((StoreOwnedItem)obj10).IsActiveItem;
		}
		else
		{
			<Owned>k__BackingField = true;
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int activePatternID = SFSKammelnaUserExtensions.GetActivePatternID(localUser2);
			bool flag4 = activePatternID == 0;
			flag2 = flag4;
		}
		<Activated>k__BackingField = flag2;
	}

	private void ResetContent()
	{
		OwnershipId = 0;
		<Activated>k__BackingField = false;
	}

	public void ActivateItem()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_00ba: Expected O, but got I
		//IL_0061: Expected I, but got O
		//IL_001b: Expected O, but got I
		//IL_0029: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)80;
		bool flag = currentItem == null;
		object obj3 = !flag;
		IntPtr intPtr = default(IntPtr);
		Action<KammelnaResponseModel<bool>> action = (Action<KammelnaResponseModel<bool>>)(nint)intPtr;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)72;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj4);
			KammelnaRequests.ResetDefaultItem(ItemCategory.Patterns, action2);
			action = action2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.SetItemAsDefault(OwnershipId, action3);
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
		//IL_01a0: Expected O, but got I4
		//IL_052b: Expected O, but got I4
		//IL_0534: Expected O, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0366: Expected O, but got I
		//IL_0374: Expected I, but got O
		//IL_020f: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		//IL_0385: Expected O, but got I
		//IL_039d: Expected O, but got I
		//IL_054b: Expected O, but got I4
		//IL_056a: Expected O, but got I
		//IL_057a: Expected O, but got I
		//IL_0590: Expected O, but got I
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05b8: Expected O, but got I4
		//IL_05c8: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I4
		//IL_03d2: Expected O, but got I
		//IL_03e8: Expected O, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0415: Expected O, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected I8, but got Unknown
		//IL_062a: Expected O, but got I
		//IL_063a: Expected O, but got I
		//IL_0650: Expected O, but got I
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_0602: Expected O, but got I4
		//IL_0458: Expected O, but got I
		//IL_0468: Expected O, but got I
		//IL_047e: Expected O, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_04a6: Expected O, but got I4
		//IL_04b6: Expected O, but got I
		//IL_04e3: Expected O, but got I
		//IL_068b: Expected O, but got I
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A4B]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v44+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v44+E4]");
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
		IL_0610:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X22_v3+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v13+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v13+10]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		if (obj10 == null)
		{
			goto IL_04c4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v13+10]");
		object obj11 = 0;
		goto IL_04d3;
		IL_0423:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0448;
		}
		goto IL_0610;
		IL_01d3:
		StoreItem storeItem;
		object obj12;
		object obj15;
		if (storeItem != null)
		{
			int num = StorePricing.DiscountAmount(storeItem);
			obj12 = storeItem.<virtualPrice>k__BackingField - num;
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v38+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			obj15 = obj12;
			if (obj14 == null)
			{
				goto IL_024f;
			}
		}
		else
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v38+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			obj15 = 0;
			if (obj16 == null)
			{
				obj12 = 0;
				goto IL_024f;
			}
		}
		goto IL_0266;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag5 = (object)sessionModel == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
		IL_0137:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		StoreItem storeItem2 = currentItem;
		StoreItem storeItem3;
		if (currentItem != null)
		{
			int num2 = StorePricing.DiscountAmount(currentItem);
			object obj18 = storeItem2.<virtualPrice>k__BackingField - num2;
			storeItem = currentItem;
			bool flag6 = aces >= (nint)obj18;
			storeItem3 = currentItem;
			if (!flag6)
			{
				goto IL_01d3;
			}
		}
		else
		{
			storeItem = currentItem;
			bool flag7 = aces < 0;
			storeItem3 = currentItem;
			if (flag7)
			{
				goto IL_01d3;
			}
		}
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)88;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj20);
		object obj21 = (nint)0 + (nint)3176;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X22_v3+38]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X22_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v11+10]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v11+10]");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag8 = obj26 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v11+10]");
			object obj27 = 0;
			if (!flag8)
			{
				goto IL_0423;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X22_v3+38]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v18+10]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v18+10]");
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			bool flag9 = obj30 == null;
			object obj31 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v18+10]");
			object obj27 = 0;
			if (obj31 != null)
			{
				goto IL_0423;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v10+E4]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		if (obj32 != null)
		{
			goto IL_0448;
		}
		goto IL_0610;
		IL_04d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v18+B8]");
		object recipients = 0;
		KammelnaRequests.BuyItem(storeItem3.<id>k__BackingField, action, null, TemplateId, (long[])recipients);
		return;
		IL_04c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_04d3;
		IL_0448:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X22_v3+38]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v25+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v25+10]");
		object obj34 = (nint)0 + (nint)309;
		object obj35 = obj34 & 1;
		bool flag11 = obj35 == null;
		object obj36 = !flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v25+10]");
		obj11 = 0;
		if (obj36 == null)
		{
			goto IL_04c4;
		}
		goto IL_04d3;
		IL_024f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj15 = obj12;
		goto IL_0266;
		IL_0266:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
		object obj37 = typeof(MemberAchievementClanFeedData) + 2608;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v34+E4]");
		bool flag12 = (nint)0 == 0;
		object obj39 = !flag12;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long remaining = obj15 - aces2;
		NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.ItemsStore);
	}

	private void RefreshStatus()
	{
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_002f: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		//IL_022b: Expected O, but got I
		//IL_023b: Expected O, but got I
		//IL_025d: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_0157: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_040b: Expected O, but got I
		//IL_041c: Expected I, but got O
		//IL_043a: Expected O, but got I
		//IL_0302: Expected O, but got I4
		//IL_02d6: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1504;
		object obj2;
		object obj6;
		GameObject[] array;
		object obj7;
		object obj8;
		GameObject[] array2;
		object obj9;
		object obj4;
		if (<Owned>k__BackingField)
		{
			obj2 = 0;
		}
		else
		{
			bool flag = currentItem == null;
			object obj3 = !flag;
			bool flag2 = currentItem == null;
			obj2 = obj3;
			if (!flag2)
			{
				GameObject[] butts = Butts;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				obj6 = 1;
				obj2 = obj3;
				array = butts;
				if (obj5 != null)
				{
					goto IL_0146;
				}
				obj7 = 1;
				obj8 = obj3;
				obj9 = obj4;
				array2 = butts;
				goto IL_0208;
			}
		}
		obj6 = (<Activated>k__BackingField ? 1 : 0) ^ 1;
		GameObject[] butts2 = Butts;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		array = butts2;
		obj7 = obj6;
		obj8 = obj2;
		obj9 = obj4;
		array2 = butts2;
		if (!flag4)
		{
			goto IL_0146;
		}
		goto IL_0208;
		IL_0318:
		object obj10 = obj6 & 1;
		Component component;
		if (obj10 != null)
		{
			component = activateButton;
			goto IL_0352;
		}
		GameObject gameObject = activeIndicator;
		bool flag5 = (object)activeIndicator == null;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_0364;
		}
		goto IL_03a7;
		IL_03a7:
		throw new NullReferenceException();
		IL_0364:
		gameObject.SetActive(value: true);
		return;
		IL_01a5:
		Action<object> action;
		ArraysExtensions.ForEach(array, action);
		if (obj2 != null)
		{
			goto IL_01cf;
		}
		goto IL_0318;
		IL_01cf:
		component = purchaseButton;
		bool flag6 = (object)purchaseButton == null;
		object obj12 = !flag6;
		if (obj12 != null)
		{
			goto IL_0352;
		}
		goto IL_03a7;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v9+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v9+8]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		obj6 = obj7;
		obj2 = obj8;
		array = array2;
		if (obj14 != null)
		{
			goto IL_01a5;
		}
		goto IL_0284;
		IL_0146:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+B8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v9+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v9+8]");
		bool flag8 = (nint)0 == 0;
		obj7 = obj6;
		obj8 = obj2;
		array2 = array;
		if (!flag8)
		{
			goto IL_01a5;
		}
		goto IL_0284;
		IL_0284:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v15+B8]");
			obj13 = 0;
		}
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1608;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj13, (IntPtr)obj18);
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v14+B8]");
		object obj20 = (nint)0 + (nint)8;
		obj20 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ArraysExtensions.ForEach(array2, action2);
		bool flag10 = obj8 == null;
		object obj21 = !flag10;
		obj6 = obj7;
		if (obj21 != null)
		{
			goto IL_01cf;
		}
		goto IL_0318;
		IL_0352:
		gameObject = component.gameObject;
		goto IL_0364;
	}

	public StorePatternItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <ActivateItem>b__32_0(KammelnaResponseModel<bool> b)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2BC");
		RefreshStatus();
	}

	private void <ActivateItem>b__32_1(KammelnaResponseModel<bool> response)
	{
		//IL_0043: Expected O, but got I
		bool succeeded = response.Succeeded;
		RefreshStatus();
		if (succeeded)
		{
			object obj = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2BC");
		}
	}

	private void <BuyItem>b__33_0(KammelnaResponseModel<BuyItemResponseModel> response)
	{
		//IL_007b: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_01d2: Expected F8, but got I4
		if (!((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			return;
		}
		<Owned>k__BackingField = true;
		BuyItemResponseModel <Model>k__BackingField = response.<Model>k__BackingField;
		StoreOwnedItem <ownedItem>k__BackingField = <Model>k__BackingField.<ownedItem>k__BackingField;
		OwnershipId = <ownedItem>k__BackingField.<id>k__BackingField;
		object obj = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2BC");
		ActivateItem();
		StoreItem storeItem = currentItem;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v8+E4]");
		StoreItem storeItem2;
		string itemId;
		string text2;
		if ((nint)0 != 0)
		{
			string text = Tracker.BuildItemId(ResourceItemId.Pattern, storeItem.<name>k__BackingField);
			storeItem2 = currentItem;
			bool flag = currentItem == null;
			itemId = text;
			text2 = text;
			if (!flag)
			{
				goto IL_0130;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			string text3 = Tracker.BuildItemId(ResourceItemId.Pattern, storeItem.<name>k__BackingField);
			storeItem2 = currentItem;
			bool flag2 = currentItem == null;
			object obj4 = !flag2;
			itemId = text3;
			text2 = text3;
			if (obj4 != null)
			{
				goto IL_0130;
			}
		}
		double amount = 0.0;
		itemId = text2;
		goto IL_01df;
		IL_0130:
		int num = StorePricing.DiscountAmount(storeItem2);
		double num2 = (double)storeItem2.<virtualPrice>k__BackingField - (double)num;
		amount = num2;
		goto IL_01df;
		IL_01df:
		Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Cosmetic, itemId, amount, ResourceCurrency.Aces);
	}
}
