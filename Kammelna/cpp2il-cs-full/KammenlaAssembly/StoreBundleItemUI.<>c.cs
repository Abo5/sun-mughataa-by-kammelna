using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using Server.Models.Products;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StoreBundleItemUI : ListViewItem<StoreDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProductListingModel, bool> <>9__21_0;

		public static Func<ProductListingModel, float> <>9__21_1;

		public static Func<ProductListingModel, float> <>9__21_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <PopulateProduct>b__21_0(ProductListingModel listings)
		{
			//IL_003d: Expected I4, but got O
			if (listings != null)
			{
				return listings.isPromotionActive;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal float <PopulateProduct>b__21_1(ProductListingModel p)
		{
			return p.<originalPrice>k__BackingField;
		}

		internal float <PopulateProduct>b__21_2(ProductListingModel p)
		{
			return p.<price>k__BackingField;
		}
	}

	private sealed class <DisableButtonAfter>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public float seconds;

		public StoreBundleItemUI <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <DisableButtonAfter>d__23(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ca: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_011d: Expected I4, but got O
			//IL_003e: Expected I4, but got I8
			//IL_0049: Invalid comparison between F4 and I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			StoreBundleItemUI storeBundleItemUI = <>4__this;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0109;
				}
				<>1__state = -1;
				if (seconds > 0f)
				{
					object obj2 = typeof(UsageHint) + 1640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitForSeconds waitForSeconds = default(WaitForSeconds);
					waitForSeconds..ctor(seconds);
					object obj3 = this + 24;
					obj3 = waitForSeconds;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
			}
			else
			{
				<>1__state = -1;
			}
			if ((object)<>4__this != null && (object)storeBundleItemUI.buyButton != null)
			{
				storeBundleItemUI.buyButton.interactable = false;
				goto IL_0109;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0109:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private GameObject cardTemplate;

	private Transform cardParent;

	private readonly List<GameObject> spawnedCards;

	private Image subscription;

	private Image currency;

	private TextMeshProUGUI price;

	private TextMeshProUGUI descriptionSub;

	private TextMeshProUGUI descriptionGoldcards;

	private DateTimeText time;

	private TextMeshProUGUI orginalPrice;

	private TextMeshProUGUI discountText;

	private GameObject itemParent;

	private GameObject discountTag;

	private ThemeProvider themeProvider;

	private Button buyButton;

	private TextMeshProUGUI Offerends;

	private ProductViewModel _bundleStoreItem;

	private ProductListingModel _listing;

	private Store _store;

	private Bundle _bundle;

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
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
		Store store = default(Store);
		_store = store;
		object obj5 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_bundle = datum.BundleStoreItem;
		object obj6 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		PopulateProduct();
	}

	private void PopulateProduct()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0c9c: Expected O, but got I
		//IL_0cc6: Expected O, but got I4
		//IL_0bcf: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00d4: Expected I, but got O
		//IL_0c35: Expected O, but got I
		//IL_0c3d: Expected I, but got O
		//IL_0110: Expected I, but got O
		//IL_0164: Expected I, but got O
		//IL_0194: Expected I, but got O
		//IL_01e7: Expected I, but got O
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_02bd: Expected O, but got I
		//IL_02cd: Expected O, but got I
		//IL_02dd: Expected O, but got I
		//IL_02ff: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_0242: Expected O, but got I
		//IL_0252: Expected O, but got I
		//IL_0262: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_0d6f: Expected O, but got I
		//IL_0d7f: Expected O, but got I
		//IL_0da1: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Expected O, but got Unknown
		//IL_0cfe: Expected O, but got I
		//IL_0d0f: Expected I, but got O
		//IL_0d2d: Expected O, but got I
		//IL_0d48: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_0367: Expected O, but got I
		//IL_0512: Expected O, but got I
		//IL_0522: Expected O, but got I
		//IL_0532: Expected O, but got I
		//IL_0554: Expected O, but got I4
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Expected O, but got Unknown
		//IL_0dd9: Expected O, but got I
		//IL_0dea: Expected I, but got O
		//IL_0e08: Expected O, but got I
		//IL_0e2b: Expected O, but got I4
		//IL_05c9: Expected I4, but got O
		//IL_0497: Expected O, but got I
		//IL_04a7: Expected O, but got I
		//IL_04b7: Expected O, but got I
		//IL_04d9: Expected O, but got I4
		//IL_0423: Expected O, but got I
		//IL_0614: Expected I, but got O
		//IL_058c: Expected O, but got I4
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e44: Expected O, but got Unknown
		//IL_0e5a: Expected O, but got I
		//IL_0e6b: Expected I, but got O
		//IL_0e89: Expected O, but got I
		//IL_0ea4: Expected O, but got I4
		//IL_062f: Expected O, but got I
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_064f: Expected O, but got I
		//IL_05bc: Expected O, but got I
		//IL_06ea: Expected I, but got O
		//IL_071f: Expected O, but got I4
		//IL_06c5: Expected O, but got I4
		//IL_07af: Expected O, but got I4
		//IL_07b4: Expected I, but got O
		//IL_0804: Expected O, but got I4
		//IL_0853: Expected O, but got I
		//IL_085f: Expected O, but got I
		//IL_086b: Expected O, but got I
		//IL_0877: Expected O, but got I
		//IL_0b43: Expected O, but got I
		//IL_0b4b: Expected I, but got O
		//IL_0914: Expected O, but got I4
		//IL_0939: Expected I4, but got O
		//IL_0bae: Expected O, but got I4
		//IL_0bb8: Expected I, but got O
		//IL_09a8: Expected I, but got O
		//IL_0b87: Expected O, but got I4
		//IL_09de: Expected O, but got I4
		//IL_09ec: Expected I, but got O
		//IL_0a0d: Expected I4, but got O
		//IL_0a16: Expected O, but got I4
		//IL_0a1e: Expected I4, but got O
		//IL_0a28: Expected I, but got O
		//IL_0acd: Expected O, but got I4
		//IL_088c: Expected O, but got I
		//IL_089c: Expected O, but got I
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Bundle bundle = _bundle;
		IAPController iAPController = default(IAPController);
		ProductViewModel bundleStoreItem;
		object obj6;
		object obj9;
		Func<object, bool> predicate;
		object obj11;
		object obj8;
		int num;
		nint num2 = default(nint);
		if (_bundle != null && (object)iAPController != null)
		{
			ProductViewModel productViewModel = (_bundleStoreItem = iAPController.GetProduct(bundle.<ProductId>k__BackingField));
			object obj5 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = _bundle == null;
			num = 0;
			num2 = (nint)productViewModel;
			if (!flag2)
			{
				IThemeColorProfile themeColorProfile = _bundle.GenerateTheme();
				bool flag3 = (object)themeProvider == null;
				num = 0;
				num2 = unchecked((nint)null);
				if (!flag3)
				{
					themeProvider.UpdateTheme(themeColorProfile);
					LoadImage();
					Bundle bundle2 = _bundle;
					bool flag4 = _bundle == null;
					num = 0;
					num2 = (nint)themeColorProfile;
					if (!flag4)
					{
						bool flag5 = (object)time == null;
						num = 0;
						num2 = (nint)themeColorProfile;
						if (!flag5)
						{
							time.SetDate(bundle2.<ExpirationDate>k__BackingField);
							bundleStoreItem = _bundleStoreItem;
							bool flag6 = _bundleStoreItem == null;
							num = 0;
							num2 = (nint)bundle2.<ExpirationDate>k__BackingField;
							if (!flag6)
							{
								obj6 = typeof(SkeletonBinary.SkeletonInput) + 1384;
								object obj7 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v107+E4]");
								if ((nint)0 != 0)
								{
									obj8 = (nint)0 + (nint)2752;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v107+B8]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v66+8]");
									predicate = (Func<object, bool>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v66+8]");
									bool flag7 = (nint)0 == 0;
									object obj10 = !flag7;
									if (obj10 == null)
									{
										obj11 = obj8;
										goto IL_0315;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj7 = obj6;
									obj11 = (nint)0 + (nint)2752;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v107+B8]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v66+8]");
									predicate = (Func<object, bool>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v66+8]");
									bool flag8 = (nint)0 == 0;
									object obj12 = !flag8;
									obj8 = obj11;
									if (obj12 == null)
									{
										goto IL_0315;
									}
								}
								goto IL_036c;
							}
						}
					}
				}
			}
		}
		goto IL_0bbd;
		IL_0b8c:
		NullReferenceException ex = new NullReferenceException();
		List<long>.Enumerator enumerator2 = default(List<long>.Enumerator);
		List<long>.Enumerator enumerator = enumerator2;
		List<object>.Enumerator enumerator3 = (List<object>.Enumerator)enumerator2;
		List<object>.Enumerator enumerator4 = (List<object>.Enumerator)0;
		num2 = (nint)cardParent;
		goto IL_0bf0;
		IL_0b59:
		SetupExpirationState();
		return;
		IL_0315:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v107+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v72+B8]");
			obj9 = 0;
		}
		object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1384;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj9, (IntPtr)obj16);
		object obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v71+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19 = 0;
		obj8 = obj11;
		predicate = func;
		goto IL_036c;
		IL_0bbd:
		NullReferenceException ex2 = new NullReferenceException();
		List<long>.Enumerator enumerator5 = (List<long>.Enumerator)0;
		goto IL_0bd4;
		IL_0b65:
		ex = new NullReferenceException();
		enumerator = enumerator2;
		enumerator3 = (List<object>.Enumerator)enumerator2;
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_0bf0;
		IL_036c:
		bool show = Enumerable.Any(bundleStoreItem.<listings>k__BackingField, predicate);
		object obj20 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v41+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v41+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v57+10]");
		Func<object, float> keySelector = (Func<object, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v57+10]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v41+E4]");
			bool flag12 = (nint)0 == 0;
			object obj24 = !flag12;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v63+B8]");
				obj22 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)1392;
			Func<object, float> func2 = default(Func<object, float>);
			func2..ctor(obj22, (IntPtr)obj27);
			object obj28 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v62+B8]");
			object obj29 = (nint)0 + (nint)16;
			obj29 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func2;
			obj19 = 0;
		}
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(bundleStoreItem.<listings>k__BackingField, keySelector);
		object listing = Enumerable.First(source);
		UpdateDiscountTag(show, (ProductListingModel)listing);
		object obj30 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v88+E4]");
		object obj31;
		object obj32;
		Func<object, float> keySelector2;
		object obj34;
		if ((nint)0 != 0)
		{
			obj31 = (nint)0 + (nint)2176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v88+B8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v47+18]");
			keySelector2 = (Func<object, float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v47+18]");
			bool flag13 = (nint)0 == 0;
			object obj33 = !flag13;
			if (obj33 == null)
			{
				obj34 = obj31;
				goto IL_056a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj6;
			obj34 = (nint)0 + (nint)2176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v88+B8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v47+18]");
			keySelector2 = (Func<object, float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v47+18]");
			bool flag14 = (nint)0 == 0;
			object obj35 = !flag14;
			obj31 = obj34;
			if (obj35 == null)
			{
				goto IL_056a;
			}
		}
		goto IL_05c1;
		IL_056a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v88+E4]");
		bool flag15 = (nint)0 == 0;
		object obj36 = !flag15;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v53+B8]");
			obj32 = 0;
		}
		object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)1400;
		Func<object, float> func3 = default(Func<object, float>);
		func3..ctor(obj32, (IntPtr)obj39);
		object obj40 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v52+B8]");
		object obj41 = (nint)0 + (nint)24;
		obj41 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = 0;
		obj31 = obj34;
		keySelector2 = func3;
		goto IL_05c1;
		IL_0bf0:
		if (num2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj42 = (nint)0 + (nint)2432;
			num2 = (nint)obj42;
			enumerator.Dispose();
			object obj43 = default(object);
			if (obj43 == null)
			{
				goto IL_0b59;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22389E8");
			NullReferenceException ex4 = (NullReferenceException)(object)ex3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238694");
			NullReferenceException ex4 = ex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0bd4:
		ex = new NullReferenceException();
		enumerator = enumerator5;
		goto IL_0bf0;
		IL_05c1:
		num = (int)obj31;
		IOrderedEnumerable<object> source2 = Enumerable.OrderBy(bundleStoreItem.<listings>k__BackingField, keySelector2);
		object obj44 = Enumerable.First(source2);
		SetConvertedPrice((ProductListingModel)obj44);
		bool flag16 = spawnedCards == null;
		num2 = (nint)obj44;
		if (!flag16)
		{
			object obj45 = (nint)0 + (nint)1048;
			object obj46 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj47 = (nint)0 + (nint)1040;
			List<object>.Enumerator enumerator6 = ((List<object>)(object)spawnedCards).GetEnumerator();
			List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
			UnityEngine.Object obj50 = default(UnityEngine.Object);
			while (enumerator7.MoveNext())
			{
				object obj48 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v84+E4]");
				bool flag17 = (nint)0 == 0;
				object obj49 = !flag17;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(obj50);
			}
			num2 = (nint)obj47;
			enumerator7.Dispose();
			List<GameObject> list = spawnedCards;
			bool flag18 = spawnedCards == null;
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			if (!flag18)
			{
				num = list._size;
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
					obj19 = 0;
					num2 = unchecked((nint)null);
				}
				if (_bundle == null)
				{
					return;
				}
				ProductViewModel bundleStoreItem2 = _bundleStoreItem;
				bool flag19 = _bundleStoreItem == null;
				enumerator3 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				if (!flag19)
				{
					if (bundleStoreItem2.<itemIds>k__BackingField == null)
					{
						return;
					}
					List<long>.Enumerator enumerator8 = bundleStoreItem2.<itemIds>k__BackingField.GetEnumerator();
					object obj51 = (nint)0 + (nint)2440;
					object obj52 = (nint)0 + (nint)544;
					object obj53 = (nint)0 + (nint)1416;
					object obj54 = (nint)0 + (nint)2544;
					GameObject gameObject = default(GameObject);
					UnityEngine.Object obj57 = default(UnityEngine.Object);
					while (enumerator5.MoveNext())
					{
						object obj55 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v66+E4]");
						bool flag20 = (nint)0 == 0;
						object obj56 = !flag20;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num = (int)obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
						if ((object)gameObject != null)
						{
							gameObject.SetActive(value: true);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
							bool flag21 = obj57 != null;
							bool flag22 = !flag21;
							num = 0;
							num2 = unchecked((nint)null);
							if (!flag22)
							{
								bool flag23 = (object)obj57 == null;
								enumerator5 = enumerator2;
								enumerator3 = (List<object>.Enumerator)enumerator2;
								enumerator4 = (List<object>.Enumerator)0;
								num = 0;
								num2 = unchecked((nint)null);
								if (flag23)
								{
									goto IL_0bd4;
								}
								((SingleBundleCard)obj57).SetupForItem(_bundle, (int)obj50);
								obj19 = 0;
								num = (int)obj50;
								num2 = (nint)_bundle;
							}
							List<object> list2 = (List<object>)(object)spawnedCards;
							if (spawnedCards != null)
							{
								object obj58 = obj54;
								int version2 = list2._version + 1;
								list2._version = version2;
								object[] items = list2._items;
								if (list2._items != null)
								{
									bool flag24 = list2._size < items.Length;
									object obj59 = !flag24;
									if (obj59 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v41+20]");
										object obj60 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v43+C0]");
										object obj61 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v44+70]");
										num = 0;
										((List<object>)(object)spawnedCards).AddWithResize((object)gameObject);
									}
									else
									{
										int size = list2._size + 1;
										list2._size = size;
										object obj62 = list2._items + list2._size;
										object obj63 = obj62 + 32;
										obj63 = gameObject;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									continue;
								}
							}
							goto IL_0b65;
						}
						goto IL_0b8c;
					}
					object obj64 = (nint)0 + (nint)2432;
					num2 = (nint)obj64;
					enumerator5.Dispose();
					goto IL_0b59;
				}
			}
		}
		goto IL_0bbd;
	}

	private void SetupExpirationState()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0115: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02f0: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		if (_bundle == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = buyButton == null;
			bool flag2 = !flag;
			object obj3 = 0;
			UnityEngine.Object obj4 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = buyButton == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			object obj3 = 0;
			UnityEngine.Object obj4 = null;
			if (obj5 != null)
			{
				return;
			}
		}
		object obj6 = typeof(DataRelation) + 712;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		Bundle bundle = _bundle;
		bool flag6 = bundle.<ExpirationDate>k__BackingField <= utcNow;
		bool interactable = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
		buyButton.interactable = interactable;
		GameObject gameObject = Offerends.gameObject;
		bool active = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		bool flag7 = !flag6;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Bundle bundle2 = _bundle;
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan = bundle2.<ExpirationDate>k__BackingField - utcNow;
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj14 = !flag9;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object obj15 = typeof(SkeletonBinary.SkeletonInput) + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = default(object);
			obj16..ctor();
			_ = 0;
			object obj17 = obj16 + 40;
			obj17 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj16);
		}
	}

	private IEnumerator DisableButtonAfter(float seconds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_001b: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		object obj = 152985600;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (spawnedCards != null)
		{
			object obj2 = (nint)0 + (nint)1048;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			List<object>.Enumerator enumerator = ((List<object>)(object)spawnedCards).GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(null);
			}
			enumerator2.Dispose();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		IntPtr intPtr = default(IntPtr);
		bool flag2 = intPtr != (IntPtr)1;
		NullReferenceException ex2 = ex;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj7 = obj6;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22389E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private unsafe void LoadImage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0274: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_02b8: Expected O, but got Ref
		//IL_02dd: Expected O, but got Ref
		//IL_0543: Expected O, but got I4
		//IL_02f3: Expected I, but got O
		//IL_0303: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_059e: Expected O, but got I4
		//IL_05bc: Expected O, but got I4
		//IL_05e2: Expected O, but got Ref
		//IL_0607: Expected O, but got Ref
		//IL_061d: Expected I, but got O
		//IL_062d: Expected O, but got I
		//IL_065b: Expected O, but got I
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69FF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v50+E4]");
			bool flag = (nint)0 == 0;
			obj5 = subscription;
			obj6 = subscription;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = subscription;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v50+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = subscription;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object[] array = null;
		UnityEngine.Object obj8 = null;
		object[] array2 = null;
		string text = null;
		if (!flag4)
		{
			goto IL_0178;
		}
		goto IL_03c2;
		IL_06eb:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_06f9;
		IL_06f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_06dd:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06eb;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		array = null;
		obj8 = null;
		if (obj9 != null)
		{
			goto IL_0178;
		}
		array2 = null;
		text = null;
		goto IL_03c2;
		IL_0178:
		ProductViewModel bundleStoreItem = _bundleStoreItem;
		if (_bundleStoreItem != null)
		{
			bool flag7 = bundleStoreItem.<days>k__BackingField < 1;
			array2 = array;
			text = (string)(object)obj8;
			if (flag7)
			{
				goto IL_03c2;
			}
			if ((object)subscription != null)
			{
				GameObject gameObject = subscription.gameObject;
				bool flag8 = (object)gameObject == null;
				obj8 = null;
				if (!flag8)
				{
					gameObject.SetActive(value: true);
					object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					bool flag9 = _bundleStoreItem == null;
					array = null;
					obj8 = (UnityEngine.Object)1;
					if (!flag9)
					{
						object obj11 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array3 = default(object[]);
						bool flag10 = array3 == null;
						array = null;
						int num = default(int);
						obj8 = (UnityEngine.Object)(&num);
						if (!flag10)
						{
							object obj12 = default(object);
							bool flag11 = obj12 == null;
							UnityEngine.Object obj13 = (UnityEngine.Object)(&num);
							if (!flag11)
							{
								nint num2 = (nint)array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
								obj13 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag12 = ex == null;
								array = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
								obj8 = (UnityEngine.Object)0;
								if (flag12)
								{
									goto IL_06f9;
								}
							}
							bool flag13 = array3.Length == 0;
							array = null;
							obj8 = obj13;
							if (!flag13)
							{
								object obj14 = array3 + 32;
								obj14 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj15 = "SERVICE_DISABLED" + 1344;
								text = (string)obj15;
								TextMeshProExtensions.Localize(descriptionSub, (string)obj15, array3);
								array2 = array3;
								goto IL_03c2;
							}
							goto IL_06eb;
						}
					}
				}
			}
		}
		goto IL_06dd;
		IL_03c2:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag14 = currency != null;
			bool flag15 = !flag14;
			object obj17 = !flag15;
			array = null;
			obj8 = null;
			if (obj17 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag16 = currency != null;
			bool flag17 = !flag16;
			array = null;
			obj8 = null;
			if (flag17)
			{
				return;
			}
		}
		ProductViewModel bundleStoreItem2 = _bundleStoreItem;
		if (_bundleStoreItem != null)
		{
			if (bundleStoreItem2.<coins>k__BackingField < 1)
			{
				return;
			}
			if ((object)currency != null)
			{
				GameObject gameObject2 = currency.gameObject;
				bool flag18 = (object)gameObject2 == null;
				obj8 = null;
				if (!flag18)
				{
					gameObject2.SetActive(value: true);
					object obj18 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v9+E4]");
					bool flag19 = (nint)0 == 0;
					object obj19 = !flag19;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(descriptionGoldcards != null))
					{
						return;
					}
					object obj20 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					bool flag20 = _bundleStoreItem == null;
					array = null;
					obj8 = (UnityEngine.Object)1;
					if (!flag20)
					{
						object obj21 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array4 = default(object[]);
						bool flag21 = array4 == null;
						array = null;
						int num3 = default(int);
						obj8 = (UnityEngine.Object)(&num3);
						if (!flag21)
						{
							object obj22 = default(object);
							bool flag22 = obj22 == null;
							UnityEngine.Object obj23 = (UnityEngine.Object)(&num3);
							if (!flag22)
							{
								nint num4 = (nint)array4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
								obj23 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag23 = ex == null;
								array = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
								obj8 = (UnityEngine.Object)0;
								if (flag23)
								{
									goto IL_06f9;
								}
							}
							bool flag24 = array4.Length == 0;
							array = null;
							obj8 = obj23;
							if (!flag24)
							{
								object obj24 = array4 + 32;
								obj24 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object text2 = "AvailableVoices" + 3920;
								TextMeshProExtensions.Localize(descriptionGoldcards, (string)text2, array4);
								return;
							}
							goto IL_06eb;
						}
					}
				}
			}
		}
		goto IL_06dd;
	}

	private void UpdateDiscountTag(bool show, ProductListingModel listing)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_03f0: Expected O, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I4
		//IL_0314: Expected O, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_043d: Expected O, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A00]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			obj5 = orginalPrice;
			obj6 = orginalPrice;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = orginalPrice;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v39+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = orginalPrice;
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
		return;
		IL_0160:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = discountTag;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			object obj11 = 0;
			if (obj10 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = discountTag;
			bool flag8 = !flag7;
			object obj11 = 0;
			if (flag8)
			{
				return;
			}
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!discountText)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = discountText;
			bool flag10 = !flag9;
			object obj13 = !flag10;
			if (obj13 == null)
			{
				return;
			}
		}
		discountTag.SetActive(show);
		discountText.enabled = show;
		GameObject gameObject = orginalPrice.gameObject;
		gameObject.SetActive(value: false);
		object obj14 = typeof(Queue<string>) + 752;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v16+E4]");
		bool flag11 = (nint)0 == 0;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = (nint)0 + (nint)2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		IAPController iAPController = default(IAPController);
		ProductMetadata unityProductMetadata = iAPController.GetUnityProductMetadata(listing.<listingId>k__BackingField);
		if (unityProductMetadata != null)
		{
			object obj18 = "Read object reference Id '{0}' for {1}." + 3808;
			if (unityProductMetadata.<isoCurrencyCode>k__BackingField == (string)obj18)
			{
				GameObject gameObject2 = orginalPrice.gameObject;
				gameObject2.SetActive(show);
			}
		}
		else
		{
			object obj19 = typeof(DataRelation) + 856;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v23+E4]");
			bool flag12 = (nint)0 == 0;
			object obj21 = !flag12;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "___# Content push apply failed [{0}]: {1}" + 768;
			Debug.LogError(message);
		}
		SetDiscount(listing);
		return;
		IL_0091:
		bool flag13 = obj5;
		bool flag14 = !flag13;
		object obj22 = !flag14;
		obj8 = 0;
		if (obj22 == null)
		{
			return;
		}
		goto IL_0160;
	}

	private unsafe void SetDiscount(ProductListingModel listing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_004a: Expected O, but got Ref
		//IL_006f: Expected O, but got Ref
		//IL_0085: Expected I, but got O
		//IL_0095: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_016d: Expected O, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_021b: Expected O, but got Ref
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = listing == null;
		string text = (string)1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array = default(object[]);
			bool flag2 = array == null;
			byte b = default(byte);
			text = (string)(&b);
			if (!flag2)
			{
				object obj3 = default(object);
				bool flag3 = obj3 == null;
				string text2 = (string)(&b);
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					if (flag4)
					{
						goto IL_027c;
					}
				}
				bool flag5 = array.Length == 0;
				text = text2;
				if (flag5)
				{
					goto IL_026e;
				}
				object obj4 = "DNQUALIFIER" + 3376;
				object obj5 = array + 32;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				text = (string)obj4;
				TextMeshProExtensions.Localize(discountText, (string)obj4, array);
				if ((object)price != null)
				{
					object value = (nint)0 + (nint)2112;
					object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
					object iconName = "Read object reference Id '{0}' for {1}." + 3808;
					object obj7 = "Error reading data from socket: " + 2248;
					object obj8 = (nint)0 + (nint)3072;
					Color color = price.color;
					Color? color2 = (Color)value;
					object obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v21+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Color? color3 = default(Color?);
					string text3 = StringUtil.Sprite((string)iconName, (Color?)(object)(&color3));
					float num2 = default(float);
					string text4 = num2.ToString((string)obj7);
					string text5 = text3 + (string)obj8 + text4;
					TextMeshProExtensions.FixArabic(orginalPrice, text5);
					return;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_026e;
		IL_026e:
		ex = new IndexOutOfRangeException();
		goto IL_027c;
		IL_027c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private unsafe void SetConvertedPrice(ProductListingModel listing)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0026: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0050: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01db: Expected O, but got I
		//IL_0205: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04f5: Expected O, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0531: Expected O, but got I
		//IL_054f: Expected I, but got O
		//IL_02bc: Expected I, but got O
		//IL_02e5: Expected O, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0330: Expected O, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0369: Expected O, but got Ref
		//IL_038e: Expected I, but got O
		//IL_0396: Expected O, but got Ref
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_0409: Expected O, but got I4
		//IL_043f: Expected O, but got I
		//IL_0478: Expected O, but got I
		//IL_0496: Expected I, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		object obj4 = 152985600;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A02]");
		object obj6 = (nint)0 & (nint)1;
		UnityEngine.Object obj8;
		UnityEngine.Object obj9;
		if (obj6 != null)
		{
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			obj8 = price;
			obj9 = price;
			if (!flag)
			{
				goto IL_00ae;
			}
		}
		else
		{
			_ = 1;
			obj8 = price;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj9 = price;
			if (obj10 != null)
			{
				goto IL_00ae;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9;
		bool flag4 = !flag3;
		string text = null;
		string text2 = null;
		if (flag4)
		{
			goto IL_00e9;
		}
		goto IL_01bb;
		IL_058d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		return;
		IL_00e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
		NullReferenceException ex;
		if (obj11 != null)
		{
			ex = (NullReferenceException)flag3;
			goto IL_058d;
		}
		return;
		IL_01bb:
		object obj12 = typeof(Queue<string>) + 752;
		object obj13 = (nint)0 + (nint)2024;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		IAPController iAPController = default(IAPController);
		if (listing != null && (object)iAPController != null)
		{
			text2 = listing.<listingId>k__BackingField;
			ProductMetadata unityProductMetadata = iAPController.GetUnityProductMetadata(listing.<listingId>k__BackingField);
			nint num;
			if (unityProductMetadata == null)
			{
				object obj16 = typeof(DataRelation) + 856;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v12+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj19 = "___# Content push apply failed [{0}]: {1}" + 608;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
				bool flag7 = obj20 != null;
				num = unchecked((nint)null);
				text = text2;
				ex = (NullReferenceException)obj19;
				if (!flag7)
				{
					Debug.LogError(obj19);
					return;
				}
				goto IL_058d;
			}
			bool flag8 = (object)price == null;
			num = unchecked((nint)null);
			if (!flag8)
			{
				Color color = price.color;
				object value = (nint)0 + (nint)2112;
				Color? color2 = (Color)value;
				object obj21 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v19+E4]");
				bool flag9 = (nint)0 == 0;
				object obj23 = !flag9;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj24 = "Read object reference Id '{0}' for {1}." + 3808;
				Color? color3 = default(Color?);
				string newValue = StringUtil.Sprite((string)obj24, (Color?)(object)(&color3));
				bool flag10 = unityProductMetadata.<isoCurrencyCode>k__BackingField == null;
				decimal num2 = (decimal)color2;
				num = unchecked((nint)null);
				text2 = (string)(&color3);
				if (!flag10)
				{
					string text3 = unityProductMetadata.<isoCurrencyCode>k__BackingField.Replace((string)obj24, newValue);
					num2 = unityProductMetadata.<localizedPrice>k__BackingField;
					object obj25 = typeof(DataRelation) + 1368;
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v25+E4]");
					bool flag11 = (nint)0 == 0;
					object obj27 = !flag11;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					decimal num3 = default(decimal);
					string text4 = num3.ToString();
					object obj28 = (nint)0 + (nint)3072;
					string text5 = text3 + (string)obj28 + text4;
					TextMeshProExtensions.FixArabic(price, text5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
					bool flag12 = obj29 != null;
					num = unchecked((nint)null);
					text = text5;
					ex = (NullReferenceException)(object)price;
					if (!flag12)
					{
						return;
					}
					goto IL_058d;
				}
			}
		}
		ex = new NullReferenceException();
		text = text2;
		goto IL_058d;
		IL_00ae:
		flag3 = obj8;
		bool flag13 = !flag3;
		object obj30 = !flag13;
		text = null;
		text2 = null;
		if (obj30 == null)
		{
			goto IL_00e9;
		}
		goto IL_01bb;
	}

	public void ShowInfoPanel()
	{
		_store.ShowBundlePopup(_bundle);
	}

	public void BuyItem()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_00a0: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = obj;
		if (_listing != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			IAPController iAPController = default(IAPController);
			iAPController.BuyProduct(_listing);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			IAPController iAPController2 = default(IAPController);
			iAPController2.InitiateBuyingProduct(_bundleStoreItem);
		}
	}

	public StoreBundleItemUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 144;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
