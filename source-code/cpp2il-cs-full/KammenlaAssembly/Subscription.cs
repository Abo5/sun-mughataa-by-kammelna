using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models.Products;
using Spine;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class Subscription : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProductViewModel, int> <>9__11_0;

		public static Func<ProductViewModel, int> <>9__11_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <PopulateButtons>b__11_0(ProductViewModel product)
		{
			//IL_0035: Expected I4, but got O
			if (product != null)
			{
				return product.<days>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <PopulateButtons>b__11_1(ProductViewModel product)
		{
			//IL_0035: Expected I4, but got O
			if (product != null)
			{
				return product.<days>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public StoreProductUi productTier1;

	public StoreProductUi productTier2;

	public StoreProductUi productTier3;

	public ElegantLoadingIndicator loader;

	public GameObject buttonsParent;

	private StoreEventsChannel storeEventsChannel;

	private Store storeScript;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01ed: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ca: Expected O, but got I4
		//IL_010d: Expected I, but got O
		//IL_0166: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2896;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object action = "Unsupported map type" + 2880;
		object type = (nint)0 + (nint)2000;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 80;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnStoreApplied -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		ContentPushService.OnStoreApplied += action3;
		InitSubscriptionButtons();
		FirebaseTrack.Event((string)action, (string)type);
		ITrackEvent trackEvent = TrackerLibrary.ShopSubShopViewed();
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2896;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnStoreApplied -= action;
	}

	private void RepopulateProducts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0143: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A70]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
		goto IL_0133;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+20]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+18]");
		if ((nint)0 == 1)
		{
			PopulateButtons();
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void InitSubscriptionButtons()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00d3: Expected I, but got O
		//IL_00ed: Expected O, but got I
		buttonsParent.SetActive(value: false);
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		loader.StartLoading();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v9+20]");
		((OneShotEvent)0).CallWhenReady(action);
	}

	private void PopulateButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0384: Expected O, but got I4
		//IL_039f: Expected O, but got I
		//IL_03ac: Expected O, but got I
		//IL_03bc: Expected O, but got I
		//IL_03cc: Expected O, but got I
		//IL_03ee: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0426: Expected O, but got I
		//IL_0437: Expected I, but got O
		//IL_0455: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_0486: Expected O, but got I
		//IL_0496: Expected O, but got I
		//IL_04b8: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04f0: Expected O, but got I
		//IL_0501: Expected I, but got O
		//IL_051f: Expected O, but got I
		//IL_01a8: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1984;
		IEnumerable<ProductViewModel> recurringSubscriptions = IAPController.RecurringSubscriptions;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)880;
		object obj5 = (nint)0 + (nint)2336;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v21+8]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v21+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v27+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2280;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v26+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func;
		}
		IOrderedEnumerable<object> source = Enumerable.OrderBy(recurringSubscriptions, keySelector);
		IEnumerable<object> source2 = Enumerable.Take(source, 3);
		List<object> list = Enumerable.ToList(source2);
		bool flag4 = Enumerable.Any(list);
		bool flag5 = !flag4;
		object obj14 = !flag5;
		List<object> list2 = list;
		if (obj14 == null)
		{
			IEnumerable<ProductViewModel> consumableSubscriptions = IAPController.ConsumableSubscriptions;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v40+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v40+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13+10]");
			Func<object, int> keySelector2 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v13+10]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v40+E4]");
				bool flag8 = (nint)0 == 0;
				object obj19 = !flag8;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v19+B8]");
					obj17 = 0;
				}
				object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj22 = (nint)0 + (nint)2288;
				Func<object, int> func2 = default(Func<object, int>);
				func2..ctor(obj17, (IntPtr)obj22);
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v18+B8]");
				object obj24 = (nint)0 + (nint)16;
				obj24 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				keySelector2 = func2;
			}
			IOrderedEnumerable<object> source3 = Enumerable.OrderByDescending(consumableSubscriptions, keySelector2);
			IEnumerable<object> source4 = Enumerable.Take(source3, 3);
			IEnumerable<object> source5 = Enumerable.Reverse(source4);
			List<object> list3 = Enumerable.ToList(source5);
			list2 = list3;
		}
		if (list2._size >= 3)
		{
			object product = list2.get_Item(0);
			productTier1.PopulateProduct((ProductViewModel)product);
			object product2 = list2.get_Item(1);
			productTier2.PopulateProduct((ProductViewModel)product2);
			object product3 = list2.get_Item(2);
			productTier3.PopulateProduct((ProductViewModel)product3);
			object product4 = list2.get_Item(0);
			object thisProduct = list2.get_Item(1);
			productTier2.SetSavingAmount((ProductViewModel)product4, (ProductViewModel)thisProduct);
			object product5 = list2.get_Item(0);
			object thisProduct2 = list2.get_Item(2);
			productTier3.SetSavingAmount((ProductViewModel)product5, (ProductViewModel)thisProduct2);
			buttonsParent.SetActive(value: true);
			loader.FinishLoading();
		}
	}

	public static void ShowUpdatedSubscriptionPopup(int? days = null)
	{
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected I, but got Unknown
		//IL_01f9: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024e: Expected I, but got O
		//IL_025e: Expected O, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected I, but got Unknown
		//IL_00b8: Expected I8, but got I4
		//IL_00b8: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_0320: Expected O, but got I4
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03c9: Expected O, but got I
		//IL_0299: Expected O, but got I
		//IL_00f9: Expected I8, but got I4
		//IL_0467: Expected O, but got I
		//IL_0498: Expected O, but got I
		//IL_0404: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected I, but got Unknown
		//IL_036e: Expected O, but got I
		//IL_010f: Expected I, but got O
		//IL_011f: Expected I8, but got I
		//IL_0148: Expected I8, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04ca: Expected I, but got O
		//IL_04da: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_0569: Expected O, but got I4
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected I, but got Unknown
		//IL_05af: Expected O, but got I
		//IL_05d3: Expected O, but got I4
		//IL_05e3: Expected O, but got I
		//IL_0515: Expected O, but got I
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		object obj = (??)days & 1;
		nint num2;
		object obj7;
		if (obj != null)
		{
			object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj3 = (nint)0 + (nint)3176;
			int? num = default(int?);
			int value = num.Value;
			object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num2 = (nint)("SERVICE_DISABLED" + 1344);
			string text = LocalizationUtil.Localize((string)num2, value);
			object[] array = default(object[]);
			bool flag2 = array == null;
			obj7 = 0;
			if (flag2)
			{
				goto IL_05f1;
			}
			bool flag3 = text == null;
			long num3 = value;
			if (!flag3)
			{
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
				num3 = 0L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
				long num5 = 0L;
				if (flag4)
				{
					goto IL_0643;
				}
			}
			if (array.Length == 0)
			{
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				long num5 = num3;
				goto IL_0643;
			}
			object obj8 = array + 32;
			obj8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text2 = "SubscribeGroup request Error" + 168;
			LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text2, array);
		}
		else
		{
			object text3 = "SubscribeGroup request Error" + 56;
			LocalizableText localizableText = TextMeshProExtensions.Localize((string)text3);
		}
		num2 = (nint)("Network Authentication Required" + 3128);
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(null, (string)num2);
		bool flag5 = popupWindowBuilderNeedsTitle == null;
		obj7 = 0;
		object obj12;
		object obj13 = default(object);
		object obj15 = default(object);
		if (!flag5)
		{
			object obj9 = typeof(System.IOAsyncCallback) + 392;
			object obj10 = "SubscribeGroup request Error" + 48;
			nint num6 = (nint)popupWindowBuilderNeedsTitle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02e2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
			obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X10_v11-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj13 = obj12 + 16;
				obj11--;
				bool flag6 = (nint)obj11 != 1;
				obj12 = obj13;
				if (flag6)
				{
					continue;
				}
				goto IL_02e2;
			}
			object obj14 = num6 + obj12;
			num2 = (nint)(obj14 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag7 = obj15 == null;
			obj13 = obj12;
			if (!flag7)
			{
				goto IL_039d;
			}
		}
		goto IL_05f1;
		IL_04ae:
		object obj16 = typeof(System.IOAsyncCallback) + 368;
		NullReferenceException ex2 = default(NullReferenceException);
		num2 = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0556;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj13 = (nint)0 + (nint)8;
		object obj18;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v2-8]");
			bool flag8 = 0 == (nint)obj16;
			obj7 = obj18;
			if (flag8)
			{
				break;
			}
			obj13 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_0556;
		}
		goto IL_05ff;
		IL_039d:
		object obj19 = typeof(System.IOAsyncCallback) + 384;
		object obj20 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v17+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_044d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v17+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v2-8]");
			if (0 == (nint)obj19)
			{
				break;
			}
			obj12 = obj13 + 16;
			obj21--;
			bool flag9 = (nint)obj21 != 1;
			obj13 = obj12;
			if (flag9)
			{
				continue;
			}
			goto IL_044d;
		}
		object obj22 = obj13 + 1;
		object obj23 = obj20 + obj22;
		num2 = (nint)(obj23 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag10 = ex2 == null;
		object obj24 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		if (obj24 != null)
		{
			goto IL_04ae;
		}
		goto IL_05f1;
		IL_05ff:
		object obj25 = obj13 + 9;
		object obj26 = num2 + obj25;
		object obj27 = obj26 + 312;
		goto IL_06f8;
		IL_06f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v333 @ X8_v3] (should have been resolved before IL gen)");
		return;
		IL_044d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14 (Il2CppClass<System.NullReferenceException>)+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ X0_v14 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag11 = ex2 == null;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		IntPtr intPtr = default(IntPtr);
		num2 = intPtr;
		if (!flag11)
		{
			goto IL_04ae;
		}
		goto IL_05f1;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v18 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v18 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag12 = obj15 == null;
		object obj28 = !flag12;
		obj12 = obj13;
		if (obj28 != null)
		{
			goto IL_039d;
		}
		IntPtr intPtr2 = default(IntPtr);
		num2 = intPtr2;
		goto IL_05f1;
		IL_05f1:
		ex2 = new NullReferenceException();
		goto IL_05ff;
		IL_0556:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj7 = 9;
		object obj29 = default(object);
		obj27 = obj29;
		goto IL_06f8;
		IL_0643:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void ShowBuyForFriend()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69D9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.Show(1);
		return;
		IL_0074:
		BuyForFriendPopup.Show(1);
	}

	public void ActivateSubscriptionCode()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A74]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.IOS)
		{
			goto IL_00a6;
		}
		goto IL_0199;
		IL_00a6:
		object obj6 = typeof(Queue<string>) + 752;
		object obj7 = (nint)0 + (nint)2024;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		IAPController iAPController = default(IAPController);
		iAPController.PresentPlatformCodeRedeemSheet();
		return;
		IL_0199:
		storeEventsChannel.TriggerShowCodeActivation(ActivationCodeUI.ActivationType.Subscription);
		return;
		IL_007d:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.IOS)
		{
			goto IL_00a6;
		}
		goto IL_0199;
	}
}
