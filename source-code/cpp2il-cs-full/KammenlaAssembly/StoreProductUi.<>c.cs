using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models.Products;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class StoreProductUi : ListViewItem<StoreDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProductListingModel, float> <>9__16_0;

		public static Predicate<ProductListingModel> <>9__16_1;

		public static Predicate<ProductListingModel> <>9__16_2;

		public static Func<ProductListingModel, bool> <>9__16_3;

		public static Func<ProductListingModel, float> <>9__16_4;

		public static Func<ProductListingModel, float> <>9__25_0;

		public static Func<ProductListingModel, float> <>9__25_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal float <PopulateProduct>b__16_0(ProductListingModel p)
		{
			return p.<price>k__BackingField;
		}

		internal bool <PopulateProduct>b__16_1(ProductListingModel listings)
		{
			//IL_0042: Expected I4, but got O
			if (listings != null)
			{
				return SalesChannelsExtension.IsStcPay(listings.<channelId>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <PopulateProduct>b__16_2(ProductListingModel listings)
		{
			//IL_0035: Expected I4, but got O
			if (listings != null)
			{
				return listings.<isRecurring>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <PopulateProduct>b__16_3(ProductListingModel listings)
		{
			//IL_003d: Expected I4, but got O
			if (listings != null)
			{
				return listings.isPromotionActive;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal float <PopulateProduct>b__16_4(ProductListingModel p)
		{
			return p.<originalPrice>k__BackingField;
		}

		internal float <SetSavingAmount>b__25_0(ProductListingModel prd)
		{
			return prd.<price>k__BackingField;
		}

		internal float <SetSavingAmount>b__25_1(ProductListingModel prd)
		{
			return prd.<price>k__BackingField;
		}
	}

	private Image icon;

	private TextMeshProUGUI description;

	private TextMeshProUGUI shortName;

	private TextMeshProUGUI price;

	private TextMeshProUGUI originalPrice;

	private GameObject stcPayExclusiveTag;

	private GameObject promotionTagNew;

	private TextMeshProUGUI promotionDescriptionNew;

	private GameObject discountTag;

	private TextMeshProUGUI discountText;

	private GameObject recurringTag;

	private ProductViewModel _product;

	private ProductListingModel _listing;

	private bool isPopup;

	private GiftInfo _giftInfo;

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		//IL_0032: Expected O, but got I4
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		ProductViewModel product = datum.GoldenCards;
		bool flag = datum.GoldenCards == null;
		object obj = !flag;
		if (obj == null)
		{
			product = datum.Subscription;
		}
		PopulateProduct(product);
	}

	public void PopulateProduct(ProductViewModel product, GiftInfo giftInfo = null, bool usePopup = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected O, but got Unknown
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0025: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_0050: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_104a: Expected O, but got I
		//IL_105a: Expected O, but got I
		//IL_106a: Expected O, but got I
		//IL_108c: Expected O, but got I4
		//IL_1143: Expected I4, but got O
		//IL_10dd: Expected O, but got I4
		//IL_01ec: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c4: Expected O, but got Unknown
		//IL_13da: Expected O, but got I
		//IL_13eb: Expected I, but got O
		//IL_1409: Expected O, but got I
		//IL_0480: Expected O, but got I
		//IL_0490: Expected O, but got I
		//IL_04a0: Expected O, but got I
		//IL_04c2: Expected O, but got I4
		//IL_04da: Expected O, but got I
		//IL_110d: Expected O, but got I
		//IL_03f5: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_0437: Expected O, but got I4
		//IL_050a: Expected O, but got I4
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1204: Expected O, but got Unknown
		//IL_121a: Expected O, but got I
		//IL_122b: Expected I, but got O
		//IL_1249: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_053a: Expected O, but got I
		//IL_066c: Expected O, but got I
		//IL_067c: Expected O, but got I
		//IL_069e: Expected O, but got I4
		//IL_0627: Expected O, but got I4
		//IL_05d8: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_0756: Expected O, but got I
		//IL_0785: Expected O, but got I
		//IL_06ce: Expected O, but got I4
		//IL_085d: Expected O, but got I4
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected O, but got Unknown
		//IL_128a: Expected O, but got I
		//IL_129b: Expected I, but got O
		//IL_12b9: Expected O, but got I
		//IL_0806: Expected O, but got I4
		//IL_06fe: Expected O, but got I
		//IL_08d5: Expected O, but got I4
		//IL_08ff: Expected O, but got I4
		//IL_090c: Expected I, but got O
		//IL_0933: Expected O, but got I4
		//IL_0951: Expected O, but got I
		//IL_0a22: Expected O, but got I
		//IL_0a32: Expected O, but got I
		//IL_0a54: Expected O, but got I4
		//IL_09dd: Expected O, but got I4
		//IL_098e: Expected O, but got I
		//IL_099e: Expected O, but got I
		//IL_0b2f: Expected O, but got I
		//IL_0a84: Expected O, but got I4
		//IL_0c07: Expected O, but got I4
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Expected O, but got Unknown
		//IL_12fa: Expected O, but got I
		//IL_130b: Expected I, but got O
		//IL_1329: Expected O, but got I
		//IL_0bb0: Expected O, but got I4
		//IL_0ab4: Expected O, but got I
		//IL_0c7f: Expected O, but got I4
		//IL_0ca9: Expected O, but got I4
		//IL_0cb6: Expected I, but got O
		//IL_0cdd: Expected O, but got I4
		//IL_0cfb: Expected O, but got I
		//IL_0efc: Expected O, but got I
		//IL_0f0c: Expected O, but got I
		//IL_0f1c: Expected O, but got I
		//IL_0f3e: Expected O, but got I4
		//IL_0da2: Expected I, but got O
		//IL_0d34: Expected O, but got I
		//IL_0d44: Expected O, but got I
		//IL_0d54: Expected O, but got I
		//IL_0f76: Expected O, but got I4
		//IL_0def: Expected O, but got I
		//IL_0e2e: Expected O, but got I4
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Expected O, but got Unknown
		//IL_136a: Expected O, but got I
		//IL_137b: Expected I, but got O
		//IL_1399: Expected O, but got I
		//IL_0fcc: Expected I, but got O
		//IL_0fe6: Expected O, but got I4
		//IL_0fa6: Expected O, but got I
		//IL_0e48: Expected O, but got I
		//IL_0e58: Expected O, but got I
		//IL_0e68: Expected O, but got I
		//IL_0e8a: Expected O, but got I4
		//IL_0e9b: Expected O, but got I
		//IL_0ea3: Expected O, but got I4
		//IL_0ed9: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		IEnumerable<object> enumerable = (IEnumerable<object>)(this + 216);
		enumerable = (IEnumerable<object>)product;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 240;
		GiftInfo giftInfo2 = default(GiftInfo);
		obj2 = giftInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		object obj4;
		object obj6;
		Func<object, bool> func;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)4064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v2-68]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj5 = !flag2;
			string text = null;
			func = null;
			obj6 = obj4;
			if (obj5 == null)
			{
				goto IL_0070;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = (nint)0 + (nint)4064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v2-68]");
			bool flag3 = (UnityEngine.Object)0;
			bool flag4 = !flag3;
			string text = null;
			func = null;
			obj6 = obj4;
			if (flag4)
			{
				goto IL_0070;
			}
		}
		ProductViewModel product2 = _product;
		bool flag5 = _product == null;
		ProductViewModel productViewModel = product;
		UnityEngine.Object obj8;
		GiftInfo giftInfo3;
		UnityEngine.Object obj11;
		object obj9;
		if (!flag5)
		{
			func = (Func<object, bool>)obj6;
			object obj7 = Enumerable.First((IEnumerable<object>)product2.<listings>k__BackingField);
			bool flag6 = obj7 == null;
			productViewModel = product;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v132 (System.Object)+28]");
				string text = (string)0;
				TextMeshProUGUI textMesh = description;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v132 (System.Object)+28]");
				TextMeshProExtensions.FixArabic(textMesh, (string)0);
				obj8 = shortName;
				obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v126+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				giftInfo2 = null;
				obj4 = obj6;
				giftInfo3 = null;
				obj11 = shortName;
				if (obj10 != null)
				{
					goto IL_00c1;
				}
				goto IL_0261;
			}
		}
		goto IL_101e;
		IL_10bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v13 (System.NullReferenceException)+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		object obj14 = default(object);
		object obj15;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v12+B8]");
			obj15 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1664;
		Func<object, float> func2 = default(Func<object, float>);
		func2..ctor(obj15, (IntPtr)obj17);
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v11+B8]");
		object obj19 = (nint)0 + (nint)40;
		obj19 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag9 = false;
		object obj21;
		object obj20 = obj21;
		IEnumerable<object> source = enumerable;
		ProductViewModel productViewModel2 = productViewModel;
		Func<object, float> keySelector = func2;
		goto IL_1112;
		IL_0cae:
		nint num = (nint)enumerable;
		bool flag10 = enumerable == null;
		bool flag11 = flag9;
		Func<object, bool> func3;
		func = func3;
		bool flag12;
		productViewModel = (ProductViewModel)flag12;
		object obj23;
		Func<object, bool> func4;
		GiftInfo giftInfo4;
		bool flag16;
		Func<object, bool> func6;
		nint num2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
			productViewModel = (ProductViewModel)0;
			object obj22 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v44+E4]");
			object obj24;
			object obj25;
			if ((nint)0 != 0)
			{
				obj23 = (nint)0 + (nint)2752;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v44+B8]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v33+20]");
				func4 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v33+20]");
				bool flag13 = (nint)0 == 0;
				obj25 = obj23;
				if (!flag13)
				{
					goto IL_0d81;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj14;
				obj23 = (nint)0 + (nint)2752;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v44+B8]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v33+20]");
				func4 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v33+20]");
				bool flag14 = (nint)0 == 0;
				object obj26 = !flag14;
				obj25 = obj23;
				if (obj26 != null)
				{
					goto IL_0d81;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v44+E4]");
			bool flag15 = (nint)0 == 0;
			object obj27 = !flag15;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj28 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v40+B8]");
				obj24 = 0;
			}
			object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = (nint)0 + (nint)1656;
			Func<object, bool> func5 = default(Func<object, bool>);
			func5..ctor(obj24, (IntPtr)obj30);
			object obj31 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v38+B8]");
			object obj32 = (nint)0 + (nint)32;
			obj32 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			giftInfo4 = (GiftInfo)obj25;
			flag16 = Enumerable.Any((IEnumerable<object>)productViewModel, func5);
			num2 = (nint)enumerable;
			bool flag17 = enumerable == null;
			object obj33 = !flag17;
			flag9 = false;
			func6 = func5;
			flag11 = false;
			giftInfo2 = (GiftInfo)obj25;
			func = func5;
			if (obj33 != null)
			{
				goto IL_0ddf;
			}
		}
		goto IL_101e;
		IL_0d81:
		giftInfo4 = (GiftInfo)obj23;
		flag16 = Enumerable.Any((IEnumerable<object>)productViewModel, func4);
		num2 = (nint)enumerable;
		bool flag18 = enumerable == null;
		func6 = func4;
		flag11 = flag9;
		giftInfo2 = (GiftInfo)obj23;
		func = func4;
		if (!flag18)
		{
			goto IL_0ddf;
		}
		goto IL_101e;
		IL_09c3:
		bool flag19 = productViewModel == null;
		object obj34 = !flag19;
		if (obj34 != null)
		{
			goto IL_0b00;
		}
		flag11 = flag9;
		Func<object, bool> func7;
		func = func7;
		goto IL_101e;
		IL_060d:
		bool flag20 = productViewModel == null;
		object obj35 = !flag20;
		flag9 = flag11;
		if (obj35 != null)
		{
			goto IL_074a;
		}
		object obj36;
		func = (Func<object, bool>)obj36;
		goto IL_101e;
		IL_0070:
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v126+E4]");
		bool flag21 = (nint)0 == 0;
		obj8 = shortName;
		giftInfo3 = giftInfo2;
		obj6 = obj4;
		obj11 = shortName;
		if (!flag21)
		{
			goto IL_00c1;
		}
		goto IL_0261;
		IL_0261:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = obj11;
		bool flag23 = !flag22;
		giftInfo2 = giftInfo3;
		func = null;
		obj4 = obj6;
		Func<object, bool> func8 = null;
		if (!flag23)
		{
			goto IL_02b0;
		}
		goto IL_0366;
		IL_00c1:
		bool flag24 = obj8;
		bool flag25 = !flag24;
		object obj37 = !flag25;
		func = null;
		if (obj37 != null)
		{
			goto IL_02b0;
		}
		giftInfo3 = giftInfo2;
		func8 = null;
		obj6 = obj4;
		goto IL_0366;
		IL_02b0:
		ProductViewModel product3 = _product;
		bool flag26 = _product == null;
		obj6 = obj4;
		productViewModel = product;
		if (!flag26)
		{
			func = (Func<object, bool>)obj4;
			object obj38 = Enumerable.First((IEnumerable<object>)product3.<listings>k__BackingField);
			bool flag27 = obj38 == null;
			obj6 = obj4;
			productViewModel = product;
			if (!flag27)
			{
				string localizedShortName = ((ProductListingModel)obj38).GetLocalizedShortName();
				TextMeshProExtensions.FixArabic(shortName, localizedShortName);
				giftInfo3 = null;
				func8 = (Func<object, bool>)(object)localizedShortName;
				obj6 = obj4;
				goto IL_0366;
			}
		}
		goto IL_101e;
		IL_102c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException ex = (NullReferenceException)obj14;
		obj21 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v13 (System.NullReferenceException)+B8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v6+28]");
		keySelector = (Func<object, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v6+28]");
		bool flag28 = (nint)0 == 0;
		object obj39 = !flag28;
		flag9 = flag11;
		obj20 = obj21;
		source = enumerable;
		productViewModel2 = productViewModel;
		if (obj39 == null)
		{
			goto IL_10bb;
		}
		goto IL_1112;
		IL_101e:
		ex = new NullReferenceException();
		goto IL_102c;
		IL_074a:
		object obj40 = (nint)0 + (nint)2504;
		giftInfo2 = (GiftInfo)obj40;
		Predicate<object> match;
		bool flag29 = ((List<object>)(object)productViewModel).TrueForAll(match);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AB0]");
		object obj41 = (nint)0 & (nint)1;
		UnityEngine.Object obj42;
		UnityEngine.Object obj44;
		if (obj41 != null)
		{
			obj42 = stcPayExclusiveTag;
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v68+E4]");
			bool flag30 = (nint)0 == 0;
			obj44 = stcPayExclusiveTag;
			if (!flag30)
			{
				goto IL_07e3;
			}
		}
		else
		{
			_ = 1;
			obj42 = stcPayExclusiveTag;
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v68+E4]");
			bool flag31 = (nint)0 == 0;
			object obj45 = !flag31;
			obj44 = stcPayExclusiveTag;
			if (obj45 != null)
			{
				goto IL_07e3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag32 = obj44;
		bool flag33 = !flag32;
		func = null;
		func7 = null;
		if (!flag33)
		{
			goto IL_08b4;
		}
		goto IL_0904;
		IL_0366:
		bool flag34 = product == null;
		giftInfo2 = giftInfo3;
		func = func8;
		productViewModel = product;
		if (flag34)
		{
			goto IL_101e;
		}
		obj14 = typeof(SkeletonBinary.SkeletonInput) + 1528;
		productViewModel = (ProductViewModel)(object)product.<listings>k__BackingField;
		object obj46 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v111+E4]");
		object obj47;
		object obj48;
		Func<object, float> keySelector2;
		object obj50;
		if ((nint)0 != 0)
		{
			obj47 = (nint)0 + (nint)2176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v111+B8]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v86+8]");
			keySelector2 = (Func<object, float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v86+8]");
			bool flag35 = (nint)0 == 0;
			object obj49 = !flag35;
			if (obj49 == null)
			{
				obj50 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v86+8]");
				Func<object, float> func9 = (Func<object, float>)0;
				goto IL_04e8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj46 = obj14;
			obj50 = (nint)0 + (nint)2176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v111+B8]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v86+8]");
			Func<object, float> func9 = (Func<object, float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v86+8]");
			bool flag36 = (nint)0 == 0;
			object obj51 = !flag36;
			obj47 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v86+8]");
			keySelector2 = (Func<object, float>)0;
			if (obj51 == null)
			{
				goto IL_04e8;
			}
		}
		goto IL_11bb;
		IL_0b00:
		giftInfo2 = (GiftInfo)obj40;
		Predicate<object> match2;
		flag12 = ((List<object>)(object)productViewModel).TrueForAll(match2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AAF]");
		object obj52 = (nint)0 & (nint)1;
		UnityEngine.Object obj53;
		UnityEngine.Object obj55;
		if (obj52 != null)
		{
			obj53 = recurringTag;
			object obj54 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v50+E4]");
			bool flag37 = (nint)0 == 0;
			obj55 = recurringTag;
			if (!flag37)
			{
				goto IL_0b8d;
			}
		}
		else
		{
			_ = 1;
			obj53 = recurringTag;
			object obj54 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v50+E4]");
			bool flag38 = (nint)0 == 0;
			object obj56 = !flag38;
			obj55 = recurringTag;
			if (obj56 != null)
			{
				goto IL_0b8d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag39 = obj55;
		bool flag40 = !flag39;
		func = null;
		func3 = null;
		if (!flag40)
		{
			goto IL_0c5e;
		}
		goto IL_0cae;
		IL_08b4:
		bool flag41 = (object)stcPayExclusiveTag == null;
		flag11 = flag9;
		productViewModel = (ProductViewModel)flag29;
		if (!flag41)
		{
			stcPayExclusiveTag.SetActive(flag29);
			giftInfo2 = null;
			func7 = (Func<object, bool>)flag29;
			goto IL_0904;
		}
		goto IL_101e;
		IL_07e3:
		bool flag42 = obj42;
		bool flag43 = !flag42;
		object obj57 = !flag43;
		func = null;
		if (obj57 != null)
		{
			goto IL_08b4;
		}
		func7 = null;
		goto IL_0904;
		IL_0b8d:
		bool flag44 = obj53;
		bool flag45 = !flag44;
		object obj58 = !flag45;
		func = null;
		if (obj58 != null)
		{
			goto IL_0c5e;
		}
		func3 = null;
		goto IL_0cae;
		IL_04e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v111+E4]");
		bool flag46 = (nint)0 == 0;
		object obj59 = !flag46;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj60 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v92+B8]");
			obj48 = 0;
		}
		object obj61 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj62 = (nint)0 + (nint)1632;
		Func<object, float> func10 = default(Func<object, float>);
		func10..ctor(obj48, (IntPtr)obj62);
		object obj63 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v91+B8]");
		object obj64 = (nint)0 + (nint)8;
		obj64 = func10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		flag11 = false;
		obj47 = obj50;
		keySelector2 = func10;
		goto IL_11bb;
		IL_0904:
		nint num3 = (nint)enumerable;
		bool flag47 = enumerable == null;
		flag11 = flag9;
		func = func7;
		productViewModel = (ProductViewModel)flag29;
		if (!flag47)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
			productViewModel = (ProductViewModel)0;
			object obj65 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v75+E4]");
			object obj66;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v75+B8]");
				obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v56+18]");
				match2 = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v56+18]");
				if ((nint)0 != 0)
				{
					goto IL_09c3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj65 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v75+B8]");
				obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v56+18]");
				match2 = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v56+18]");
				bool flag48 = (nint)0 == 0;
				object obj67 = !flag48;
				if (obj67 != null)
				{
					goto IL_09c3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v75+E4]");
			bool flag49 = (nint)0 == 0;
			object obj68 = !flag49;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj69 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v62+B8]");
				obj66 = 0;
			}
			object obj70 = typeof(List<Tween>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj71 = (nint)0 + (nint)1648;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj66, (IntPtr)obj71);
			object obj72 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v61+B8]");
			object obj73 = (nint)0 + (nint)24;
			obj73 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag50 = productViewModel == null;
			flag9 = false;
			match2 = predicate;
			flag11 = false;
			giftInfo2 = (GiftInfo)obj71;
			func = (Func<object, bool>)(object)predicate;
			if (!flag50)
			{
				goto IL_0b00;
			}
		}
		goto IL_101e;
		IL_1112:
		IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(source, keySelector);
		object listing = Enumerable.First(source2);
		UpdateDiscountTag((byte)(int)productViewModel2 != 0, (ProductListingModel)listing);
		PopulateIcon();
		return;
		IL_11bb:
		giftInfo2 = (GiftInfo)obj47;
		IOrderedEnumerable<object> source3 = Enumerable.OrderBy((IEnumerable<object>)productViewModel, keySelector2);
		obj36 = Enumerable.First(source3);
		SetConvertedPrice((ProductListingModel)obj36);
		ProductViewModel product4 = _product;
		bool flag51 = _product == null;
		func = (Func<object, bool>)obj36;
		if (!flag51)
		{
			productViewModel = (ProductViewModel)(object)product4.<listings>k__BackingField;
			object obj74 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v100+E4]");
			object obj75;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v100+B8]");
				obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v74+10]");
				match = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v74+10]");
				if ((nint)0 != 0)
				{
					goto IL_060d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj74 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v100+B8]");
				obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v74+10]");
				match = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v74+10]");
				bool flag52 = (nint)0 == 0;
				object obj76 = !flag52;
				if (obj76 != null)
				{
					goto IL_060d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v100+E4]");
			bool flag53 = (nint)0 == 0;
			object obj77 = !flag53;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj78 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v80+B8]");
				obj75 = 0;
			}
			object obj79 = typeof(List<Tween>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj80 = (nint)0 + (nint)1640;
			Predicate<object> predicate2 = default(Predicate<object>);
			predicate2..ctor(obj75, (IntPtr)obj80);
			object obj81 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v79+B8]");
			object obj82 = (nint)0 + (nint)16;
			obj82 = predicate2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag54 = productViewModel == null;
			flag9 = false;
			match = predicate2;
			flag11 = false;
			giftInfo2 = (GiftInfo)obj80;
			func = (Func<object, bool>)(object)predicate2;
			if (!flag54)
			{
				goto IL_074a;
			}
		}
		goto IL_101e;
		IL_0c5e:
		bool flag55 = (object)recurringTag == null;
		flag11 = flag9;
		productViewModel = (ProductViewModel)flag12;
		if (!flag55)
		{
			recurringTag.SetActive(flag12);
			giftInfo2 = null;
			func3 = (Func<object, bool>)flag12;
			goto IL_0cae;
		}
		goto IL_101e;
		IL_0ddf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		enumerable = (IEnumerable<object>)0;
		ex = (NullReferenceException)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v13 (System.NullReferenceException)+E4]");
		bool flag56 = (nint)0 == 0;
		flag11 = flag9;
		giftInfo2 = giftInfo4;
		func = func6;
		productViewModel = (ProductViewModel)flag16;
		if (flag56)
		{
			goto IL_102c;
		}
		obj20 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v13 (System.NullReferenceException)+B8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v6+28]");
		keySelector = (Func<object, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v6+28]");
		bool flag57 = (nint)0 == 0;
		object obj83 = !flag57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v43 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		source = (IEnumerable<object>)0;
		productViewModel2 = (ProductViewModel)flag16;
		if (obj83 == null)
		{
			flag11 = flag9;
			giftInfo2 = giftInfo4;
			func = func6;
			obj21 = obj20;
			productViewModel = (ProductViewModel)flag16;
			goto IL_10bb;
		}
		goto IL_1112;
	}

	public void PopulateListing(ProductListingModel listing, GiftInfo giftInfo = null, bool usePopup = false)
	{
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00c2: Expected O, but got I4
		//IL_01b3: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_02e1: Expected O, but got I
		//IL_03b4: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		object obj = this + 224;
		obj = listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		ProductViewModel product = listing.getProduct();
		object obj3 = this + 216;
		obj3 = product;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 240;
		GiftInfo giftInfo2 = default(GiftInfo);
		obj4 = giftInfo2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v13+E4]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v3-68]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj6 = !flag2;
			text = null;
			if (obj6 == null)
			{
				goto IL_00d5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v3-68]");
			bool flag3 = (UnityEngine.Object)0;
			bool flag4 = !flag3;
			text = null;
			if (flag4)
			{
				goto IL_00d5;
			}
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v17+28]");
		text = (string)0;
		TextMeshProUGUI textMesh = description;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v17+28]");
		TextMeshProExtensions.FixArabic(textMesh, (string)0);
		UnityEngine.Object obj8 = shortName;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v39+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		giftInfo2 = null;
		GiftInfo giftInfo3 = null;
		UnityEngine.Object obj11 = shortName;
		if (obj10 != null)
		{
			goto IL_011e;
		}
		goto IL_0220;
		IL_033f:
		UnityEngine.Object obj12;
		if ((bool)obj12)
		{
			goto IL_0365;
		}
		return;
		IL_0365:
		ProductListingModel listing2;
		recurringTag.SetActive(listing2.<isRecurring>k__BackingField);
		return;
		IL_0283:
		SetConvertedPrice(_listing);
		bool isPromotionActive = listing.isPromotionActive;
		UpdateDiscountTag(isPromotionActive, _listing);
		PopulateIcon();
		listing2 = _listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AAF]");
		object obj13 = (nint)0 & (nint)1;
		UnityEngine.Object obj15;
		if (obj13 != null)
		{
			obj12 = recurringTag;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v9+E4]");
			bool flag6 = (nint)0 == 0;
			obj15 = recurringTag;
			if (!flag6)
			{
				goto IL_033f;
			}
		}
		else
		{
			_ = 1;
			obj12 = recurringTag;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			obj15 = recurringTag;
			if (obj16 != null)
			{
				goto IL_033f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = obj15;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			return;
		}
		goto IL_0365;
		IL_00d5:
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v39+E4]");
		bool flag10 = (nint)0 == 0;
		obj8 = shortName;
		giftInfo3 = giftInfo2;
		obj11 = shortName;
		if (!flag10)
		{
			goto IL_011e;
		}
		goto IL_0220;
		IL_0220:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj11;
		bool flag12 = !flag11;
		giftInfo2 = giftInfo3;
		if (!flag12)
		{
			goto IL_025d;
		}
		goto IL_0283;
		IL_011e:
		bool flag13 = obj8;
		bool flag14 = !flag13;
		object obj18 = !flag14;
		if (obj18 != null)
		{
			goto IL_025d;
		}
		goto IL_0283;
		IL_025d:
		string localizedShortName = ((ProductListingModel)obj).GetLocalizedShortName();
		TextMeshProExtensions.FixArabic(shortName, localizedShortName);
		giftInfo2 = null;
		goto IL_0283;
	}

	public void AssignGiftInfo(GiftInfo giftInfo)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 240;
		obj = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void PopulateIcon()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0104: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A58]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = icon;
			obj6 = icon;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = icon;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = icon;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		icon.enabled = false;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)136;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj10);
		UIExtensions.LoadProductImage(icon, _product, setNative: false, action);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A59]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			obj5 = originalPrice;
			obj6 = originalPrice;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = originalPrice;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v39+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = originalPrice;
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
		GameObject gameObject = originalPrice.gameObject;
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
				GameObject gameObject2 = originalPrice.gameObject;
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

	private void UpdateRecurringTag(bool show)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AAF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = recurringTag;
			obj6 = recurringTag;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = recurringTag;
			obj6 = recurringTag;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		recurringTag.SetActive(show);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void UpdateSTCPayTag(bool show)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AB0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = stcPayExclusiveTag;
			obj6 = stcPayExclusiveTag;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = stcPayExclusiveTag;
			obj6 = stcPayExclusiveTag;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		stcPayExclusiveTag.SetActive(show);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
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
					TextMeshProExtensions.FixArabic(originalPrice, text5);
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A5B]");
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

	public unsafe void SetSavingAmount(ProductViewModel product, ProductViewModel thisProduct)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_006f: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_00b1: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02a5: Expected O, but got I
		//IL_02c7: Expected O, but got I4
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05d5: Expected O, but got I
		//IL_05e6: Expected I, but got O
		//IL_0604: Expected O, but got I
		//IL_061b: Expected I, but got O
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_0244: Expected O, but got I4
		//IL_0194: Expected O, but got I
		//IL_038e: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_065a: Expected O, but got I
		//IL_066b: Expected I, but got O
		//IL_0689: Expected O, but got I
		//IL_06a8: Expected I, but got O
		//IL_032f: Expected O, but got I
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_06e2: Expected O, but got I4
		//IL_041f: Expected O, but got I8
		//IL_0428: Expected F4, but got I4
		//IL_0430: Expected O, but got Ref
		//IL_045a: Expected O, but got Ref
		//IL_04f0: Expected O, but got I8
		//IL_04f9: Expected F4, but got I4
		//IL_0470: Expected I, but got O
		//IL_0480: Expected O, but got I
		//IL_04a6: Expected O, but got I8
		//IL_04af: Expected F4, but got I4
		//IL_04bf: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		object obj;
		object obj3;
		object obj4;
		Func<object, float> selector;
		object obj6;
		ProductViewModel productViewModel2 = default(ProductViewModel);
		ProductViewModel productViewModel = default(ProductViewModel);
		if (productViewModel != null && productViewModel2 != null)
		{
			obj = typeof(SkeletonBinary.SkeletonInput) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v42+E4]");
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v42+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v37+30]");
				selector = (Func<object, float>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v37+30]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0142;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)3848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v42+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v37+30]");
				selector = (Func<object, float>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v37+30]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0142;
				}
			}
			goto IL_0199;
		}
		goto IL_055c;
		IL_02dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v32+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj10;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v32+B8]");
			obj10 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1680;
		Func<object, float> func = default(Func<object, float>);
		func..ctor(obj10, (IntPtr)obj12);
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31+B8]");
		object obj14 = (nint)0 + (nint)56;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16;
		object obj15 = obj16;
		nint num = unchecked((nint)null);
		Func<object, float> selector2 = func;
		goto IL_0334;
		IL_0199:
		IEnumerable<float> source = Enumerable.Select(productViewModel.<listings>k__BackingField, selector);
		float num2 = Enumerable.Max(source);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v32+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v26+38]");
			selector2 = (Func<object, float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v26+38]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				obj16 = obj15;
				goto IL_02dd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
			obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v32+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v26+38]");
			selector2 = (Func<object, float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v26+38]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			obj15 = obj16;
			if (obj19 == null)
			{
				goto IL_02dd;
			}
		}
		goto IL_0334;
		IL_055c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_056a;
		IL_0334:
		productViewModel = (ProductViewModel)obj3;
		IEnumerable<float> source2 = Enumerable.Select(productViewModel2.<listings>k__BackingField, selector2);
		float num3 = Enumerable.Max(source2);
		object obj20 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (object)promotionTagNew == null;
		productViewModel2 = null;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		if (!flag7)
		{
			object obj22 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			promotionTagNew.SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj23 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array = default(object[]);
			bool flag8 = array == null;
			object obj24 = 3267887104L;
			num3 = 2.139095E+09f;
			object obj25 = default(object);
			productViewModel2 = (ProductViewModel)(&obj25);
			productViewModel = null;
			if (!flag8)
			{
				object obj26 = default(object);
				bool flag9 = obj26 == null;
				ProductViewModel productViewModel3 = (ProductViewModel)(&obj25);
				if (!flag9)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
					productViewModel3 = (ProductViewModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag10 = ex2 == null;
					obj24 = 3267887104L;
					num3 = 2.139095E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
					productViewModel2 = (ProductViewModel)0;
					productViewModel = null;
					if (flag10)
					{
						goto IL_0578;
					}
				}
				bool flag11 = array.Length == 0;
				obj24 = 3267887104L;
				num3 = 2.139095E+09f;
				productViewModel2 = productViewModel3;
				productViewModel = null;
				if (!flag11)
				{
					object text = "SERVICE_DISABLED" + 1640;
					object obj27 = array + 32;
					obj27 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TextMeshProExtensions.Localize(promotionDescriptionNew, (string)text, array);
					return;
				}
				goto IL_056a;
			}
		}
		goto IL_055c;
		IL_056a:
		ex2 = new IndexOutOfRangeException();
		goto IL_0578;
		IL_0142:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v42+E4]");
		bool flag12 = (nint)0 == 0;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v43+B8]");
			obj4 = 0;
		}
		object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)1672;
		Func<object, float> func2 = default(Func<object, float>);
		func2..ctor(obj4, (IntPtr)obj31);
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v42+B8]");
		object obj33 = (nint)0 + (nint)48;
		obj33 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num = unchecked((nint)null);
		obj3 = obj6;
		selector = func2;
		goto IL_0199;
		IL_0578:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void BuyItem()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		//IL_00a6: Expected O, but got I4
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
			iAPController.BuyProduct(_listing, null, _giftInfo, isPopup);
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
			iAPController2.InitiateBuyingProduct(_product, _giftInfo, isPopup);
		}
	}

	public StoreProductUi()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <PopulateIcon>b__19_0(bool success)
	{
		icon.enabled = success;
	}
}
