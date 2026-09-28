using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Server.Models.Products;
using Spine;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class StoreHomePageGroup : UiGridView<StoreDataHolder, ListViewItem<StoreDataHolder, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreBannerViewModel, bool> <>9__0_0;

		public static Func<StoreItem, int> <>9__0_6;

		public static Func<StoreItem, int> <>9__0_10;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Populate>b__0_0(StoreBannerViewModel banner)
		{
			//IL_006c: Expected I4, but got O
			//IL_004a: Expected O, but got I
			if (banner != null)
			{
				ImageInfoModel<ImageCacher.BannerSize> <image>k__BackingField = banner.<image>k__BackingField;
				if (banner.<image>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v4 (ImageInfoModel`1<ImageCacher+BannerSize>)+20]");
					object obj = -1;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Populate>b__0_6(StoreItem item)
		{
			//IL_0035: Expected I4, but got O
			if (item != null)
			{
				return item.<pack>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <Populate>b__0_10(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<virtualPrice>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public int index;

		public StoreHomePageViewModel sections;

		public Func<ProductViewModel, StoreDataHolder> <>9__2;

		public Func<ProductViewModel, StoreDataHolder> <>9__4;

		public Func<IGrouping<int, StoreItem>, StoreDataHolder> <>9__7;

		public Func<StoreItem, StoreDataHolder> <>9__9;

		internal StoreDataHolder <Populate>b__2(ProductViewModel product)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			int num = index + 1;
			index = num;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = index;
			object obj3 = obj2 + 88;
			obj3 = product;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((StoreDataHolder)obj2).SetTemplate();
			return (StoreDataHolder)obj2;
		}

		internal StoreDataHolder <Populate>b__4(ProductViewModel product)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			int num = index + 1;
			index = num;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = index;
			object obj3 = obj2 + 80;
			obj3 = product;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((StoreDataHolder)obj2).SetTemplate();
			return (StoreDataHolder)obj2;
		}

		internal StoreDataHolder <Populate>b__7(IGrouping<int, StoreItem> item)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_014c: Expected O, but got I4
			//IL_0227: Expected O, but got I
			//IL_0233: Expected O, but got I
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0275: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0195: Expected I, but got O
			//IL_01b3: Expected O, but got I
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_0082: Expected O, but got I
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1448;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = (nint)0 + (nint)2512;
			object obj5 = (nint)0 + (nint)2720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+18]");
			Func<object, int> keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+18]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v18+B8]");
					obj6 = 0;
				}
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)1520;
				Func<object, int> func = default(Func<object, int>);
				func..ctor(obj6, (IntPtr)obj11);
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v17+B8]");
				object obj13 = (nint)0 + (nint)24;
				obj13 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				keySelector = func;
			}
			IOrderedEnumerable<object> source = Enumerable.OrderByDescending(item, keySelector);
			List<object> list = Enumerable.ToList(source);
			int num = index + 1;
			index = num;
			StoreHomePageViewModel storeHomePageViewModel = sections;
			if (sections != null)
			{
				object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj15 = default(object);
				obj15..ctor();
				_ = storeHomePageViewModel.<templateId>k__BackingField;
				_ = index;
				object obj16 = obj15 + 40;
				obj16 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				((StoreDataHolder)obj15).SetTemplate();
				return (StoreDataHolder)obj15;
			}
			return (StoreDataHolder)(object)new NullReferenceException();
		}

		internal StoreDataHolder <Populate>b__9(StoreItem item)
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			int num = index + 1;
			index = num;
			StoreHomePageViewModel storeHomePageViewModel = sections;
			if (sections != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = default(object);
				obj2..ctor();
				_ = storeHomePageViewModel.<templateId>k__BackingField;
				_ = 2;
				_ = index;
				object obj3 = obj2 + 64;
				obj3 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				((StoreDataHolder)obj2).SetTemplate();
				return (StoreDataHolder)obj2;
			}
			return (StoreDataHolder)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass0_1
	{
		public StoreHomeSection section;

		internal bool <Populate>b__1(ProductViewModel product)
		{
			//IL_0073: Expected I4, but got O
			StoreHomeSection storeHomeSection = section;
			if (section != null && product != null && storeHomeSection.<featuredSubscriptions>k__BackingField != null)
			{
				return storeHomeSection.<featuredSubscriptions>k__BackingField.Contains(product.<id>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <Populate>b__3(ProductViewModel product)
		{
			//IL_0073: Expected I4, but got O
			StoreHomeSection storeHomeSection = section;
			if (section != null && product != null && storeHomeSection.<featuredCurrency>k__BackingField != null)
			{
				return storeHomeSection.<featuredCurrency>k__BackingField.Contains(product.<id>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <Populate>b__5(StoreItem item)
		{
			//IL_00d8: Expected I4, but got O
			//IL_00b1: Expected O, but got I4
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected I4, but got Unknown
			StoreHomeSection storeHomeSection = section;
			if (section != null && item != null && storeHomeSection.<featuredCards>k__BackingField != null)
			{
				if (storeHomeSection.<featuredCards>k__BackingField.Contains(item.<id>k__BackingField) && item.<isActive>k__BackingField)
				{
					object obj = (item.<isAdvertisement>k__BackingField ? 1 : 0) ^ 1;
					return (byte)(obj & 1) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <Populate>b__8(StoreItem item)
		{
			//IL_00d8: Expected I4, but got O
			//IL_00b1: Expected O, but got I4
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected I4, but got Unknown
			StoreHomeSection storeHomeSection = section;
			if (section != null && item != null && storeHomeSection.<featuredRoomThemes>k__BackingField != null)
			{
				if (storeHomeSection.<featuredRoomThemes>k__BackingField.Contains(item.<id>k__BackingField) && item.<isActive>k__BackingField)
				{
					object obj = (item.<isAdvertisement>k__BackingField ? 1 : 0) ^ 1;
					return (byte)(obj & 1) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public unsafe void Populate(StoreHomePageViewModel sections)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_00ac: Expected O, but got I
		//IL_3635: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0157: Expected O, but got I4
		//IL_2f13: Expected O, but got I4
		//IL_2f4f: Expected O, but got I4
		//IL_3ae3: Expected O, but got I
		//IL_3b0a: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_2f80: Expected O, but got Ref
		//IL_2f89: Expected O, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_2fb1: Expected O, but got Ref
		//IL_2fba: Expected O, but got I4
		//IL_0cbd: Expected O, but got I
		//IL_0cd6: Expected O, but got I
		//IL_0cf4: Expected O, but got I4
		//IL_282d: Expected O, but got I
		//IL_283e: Expected O, but got I
		//IL_285c: Expected O, but got I4
		//IL_31cf: Expected O, but got Ref
		//IL_31d8: Expected O, but got I4
		//IL_0fc5: Expected O, but got I
		//IL_0fd6: Expected O, but got I
		//IL_0ff4: Expected O, but got I4
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Expected O, but got Unknown
		//IL_0d65: Expected O, but got I4
		//IL_2882: Unknown result type (might be due to invalid IL or missing references)
		//IL_2887: Expected O, but got Unknown
		//IL_301f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3024: Expected O, but got Unknown
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected O, but got Unknown
		//IL_11e8: Expected O, but got I4
		//IL_0d93: Expected O, but got I
		//IL_0db1: Expected O, but got I4
		//IL_28a2: Expected O, but got I
		//IL_28b3: Expected I, but got O
		//IL_28bf: Expected O, but got I
		//IL_28c7: Expected I, but got O
		//IL_3052: Expected O, but got I
		//IL_0772: Expected O, but got I
		//IL_0783: Expected O, but got I
		//IL_07a1: Expected O, but got I4
		//IL_1216: Expected O, but got I
		//IL_1234: Expected O, but got I4
		//IL_1011: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Expected O, but got Unknown
		//IL_1040: Expected O, but got I4
		//IL_28f7: Expected O, but got I
		//IL_3072: Expected O, but got Ref
		//IL_307b: Expected O, but got I4
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected O, but got Unknown
		//IL_0304: Expected O, but got I
		//IL_0315: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_315e: Expected O, but got Ref
		//IL_3167: Expected O, but got I4
		//IL_0de3: Expected O, but got I
		//IL_292b: Expected O, but got I4
		//IL_2934: Expected O, but got I4
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
		//IL_1261: Expected O, but got I
		//IL_0b8b: Expected O, but got I
		//IL_109a: Expected O, but got I
		//IL_10ab: Expected I, but got O
		//IL_10b7: Expected O, but got I
		//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb5: Expected O, but got Unknown
		//IL_3790: Expected O, but got Ref
		//IL_3799: Expected O, but got I4
		//IL_07e7: Expected O, but got I
		//IL_07f8: Expected I, but got O
		//IL_0804: Expected O, but got I
		//IL_080c: Expected I, but got O
		//IL_3748: Unknown result type (might be due to invalid IL or missing references)
		//IL_374d: Expected O, but got Unknown
		//IL_375d: Expected O, but got I
		//IL_10d9: Expected O, but got I
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_037f: Expected O, but got I4
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Expected O, but got Unknown
		//IL_1c6d: Expected O, but got I
		//IL_1c7d: Expected O, but got I
		//IL_1c9f: Expected O, but got I4
		//IL_083c: Expected O, but got I
		//IL_30ae: Expected O, but got Ref
		//IL_30b7: Expected O, but got I4
		//IL_159a: Unknown result type (might be due to invalid IL or missing references)
		//IL_159f: Expected O, but got Unknown
		//IL_15b7: Expected O, but got I
		//IL_15c7: Expected O, but got I
		//IL_15e9: Expected O, but got I4
		//IL_15f2: Expected O, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_1d34: Expected O, but got I
		//IL_1d3c: Expected I, but got O
		//IL_1d51: Expected O, but got I
		//IL_1d61: Expected O, but got I
		//IL_1bf2: Expected O, but got I
		//IL_1c02: Expected O, but got I
		//IL_1c24: Expected O, but got I4
		//IL_33e7: Expected O, but got I4
		//IL_33ef: Expected O, but got Ref
		//IL_33f8: Expected O, but got I4
		//IL_0870: Expected O, but got I4
		//IL_0879: Expected O, but got I4
		//IL_2fe5: Expected O, but got Ref
		//IL_2fee: Expected O, but got I4
		//IL_3003: Expected O, but got I
		//IL_1687: Expected O, but got I
		//IL_168f: Expected I, but got O
		//IL_16ac: Expected O, but got I
		//IL_1137: Expected O, but got I
		//IL_1147: Expected O, but got I
		//IL_1169: Expected O, but got I4
		//IL_1172: Expected O, but got I4
		//IL_03d9: Expected O, but got I
		//IL_03ea: Expected I, but got O
		//IL_03f6: Expected O, but got I
		//IL_03fe: Expected I, but got O
		//IL_1cbd: Expected O, but got I
		//IL_1cdf: Expected O, but got I4
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected O, but got Unknown
		//IL_0e23: Expected O, but got I
		//IL_2976: Unknown result type (might be due to invalid IL or missing references)
		//IL_297b: Expected O, but got Unknown
		//IL_29a5: Expected O, but got I4
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Expected O, but got Unknown
		//IL_12a1: Expected O, but got I
		//IL_0bc7: Expected O, but got I
		//IL_0be5: Expected O, but got I
		//IL_16e0: Expected O, but got I4
		//IL_1610: Expected O, but got I
		//IL_1632: Expected O, but got I4
		//IL_042e: Expected O, but got I
		//IL_3287: Expected O, but got Ref
		//IL_3290: Expected O, but got I4
		//IL_393d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3942: Expected O, but got Unknown
		//IL_3958: Expected O, but got I
		//IL_3969: Expected I, but got O
		//IL_3978: Unknown result type (might be due to invalid IL or missing references)
		//IL_397d: Expected O, but got Unknown
		//IL_399b: Expected O, but got I
		//IL_39b6: Expected O, but got I4
		//IL_0e5f: Expected O, but got Ref
		//IL_0e68: Expected O, but got I4
		//IL_0e7d: Expected O, but got I
		//IL_29d3: Expected O, but got I
		//IL_29f1: Expected O, but got I4
		//IL_12e5: Expected O, but got I
		//IL_3838: Unknown result type (might be due to invalid IL or missing references)
		//IL_383d: Expected O, but got Unknown
		//IL_3853: Expected O, but got I
		//IL_3864: Expected I, but got O
		//IL_3873: Unknown result type (might be due to invalid IL or missing references)
		//IL_3878: Expected O, but got Unknown
		//IL_3896: Expected O, but got I
		//IL_38b1: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_046b: Expected O, but got I4
		//IL_1d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0b: Expected O, but got Unknown
		//IL_1d23: Expected O, but got I
		//IL_2c17: Expected O, but got I
		//IL_2c39: Expected O, but got I4
		//IL_2c42: Expected O, but got I4
		//IL_3519: Expected O, but got I4
		//IL_3521: Expected O, but got Ref
		//IL_352a: Expected O, but got I4
		//IL_0c3f: Expected O, but got I4
		//IL_1659: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected O, but got Unknown
		//IL_1676: Expected O, but got I
		//IL_0e9f: Expected O, but got I
		//IL_0ebd: Expected O, but got I
		//IL_0eeb: Expected O, but got Ref
		//IL_0ef4: Expected O, but got I4
		//IL_0f09: Expected O, but got I
		//IL_2ccf: Expected O, but got I
		//IL_2cd7: Expected I, but got O
		//IL_2a23: Expected O, but got I
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_08ea: Expected O, but got I4
		//IL_12ff: Expected O, but got I
		//IL_131d: Expected O, but got I
		//IL_1353: Expected O, but got I
		//IL_1409: Expected O, but got I
		//IL_1419: Expected O, but got I
		//IL_3484: Expected O, but got Ref
		//IL_348d: Expected O, but got I4
		//IL_1dc9: Expected O, but got I
		//IL_1ded: Expected O, but got I
		//IL_341b: Expected O, but got Ref
		//IL_3424: Expected O, but got I4
		//IL_2c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c64: Expected O, but got Unknown
		//IL_2c7a: Expected O, but got I
		//IL_2c8b: Expected I, but got O
		//IL_0918: Expected O, but got I
		//IL_0936: Expected O, but got I4
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected O, but got Unknown
		//IL_1722: Unknown result type (might be due to invalid IL or missing references)
		//IL_1727: Expected O, but got Unknown
		//IL_1751: Expected O, but got I4
		//IL_3450: Expected O, but got I4
		//IL_3458: Expected O, but got Ref
		//IL_3461: Expected O, but got I4
		//IL_3227: Expected O, but got Ref
		//IL_3230: Expected O, but got I4
		//IL_1f54: Expected O, but got I
		//IL_39df: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e4: Expected O, but got Unknown
		//IL_0f47: Expected O, but got I4
		//IL_2d11: Expected O, but got I
		//IL_2d19: Expected I, but got O
		//IL_2c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca3: Expected O, but got Unknown
		//IL_2cb6: Expected O, but got I4
		//IL_32b4: Expected O, but got I4
		//IL_32bc: Expected O, but got Ref
		//IL_32c5: Expected O, but got I4
		//IL_2126: Expected O, but got I
		//IL_2148: Expected O, but got I4
		//IL_2151: Expected O, but got I4
		//IL_1387: Expected O, but got I4
		//IL_3132: Expected O, but got Ref
		//IL_313b: Expected O, but got I4
		//IL_177f: Expected O, but got I
		//IL_179d: Expected O, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04dc: Expected O, but got I4
		//IL_3a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a29: Expected O, but got Unknown
		//IL_1b42: Expected O, but got I
		//IL_1b52: Expected O, but got I
		//IL_21de: Expected O, but got I
		//IL_21e6: Expected I, but got O
		//IL_0968: Expected O, but got I
		//IL_1978: Expected O, but got I
		//IL_1988: Expected O, but got I
		//IL_147e: Expected O, but got I
		//IL_2d85: Expected O, but got I
		//IL_2da7: Expected O, but got I4
		//IL_050a: Expected O, but got I
		//IL_0528: Expected O, but got I4
		//IL_31fb: Expected O, but got Ref
		//IL_3204: Expected O, but got I4
		//IL_3253: Expected O, but got Ref
		//IL_325c: Expected O, but got I4
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Expected O, but got Unknown
		//IL_2a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a53: Expected O, but got Unknown
		//IL_2a63: Expected O, but got I
		//IL_34e4: Expected O, but got Ref
		//IL_34ed: Expected O, but got I4
		//IL_216e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2173: Expected O, but got Unknown
		//IL_2189: Expected O, but got I
		//IL_219a: Expected I, but got O
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Expected O, but got Unknown
		//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13da: Expected O, but got Unknown
		//IL_37f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_37fc: Expected O, but got Unknown
		//IL_380c: Expected O, but got I
		//IL_2e34: Expected O, but got I
		//IL_2e3c: Expected I, but got O
		//IL_17ce: Expected O, but got I
		//IL_2294: Expected O, but got I
		//IL_22b6: Expected O, but got I4
		//IL_22bf: Expected O, but got I4
		//IL_244e: Expected O, but got I
		//IL_246c: Expected O, but got I4
		//IL_3581: Expected O, but got Ref
		//IL_358a: Expected O, but got I4
		//IL_1e2f: Expected O, but got I
		//IL_1e4d: Expected O, but got I
		//IL_2aa7: Expected O, but got I
		//IL_2220: Expected O, but got I
		//IL_2228: Expected I, but got O
		//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Expected O, but got Unknown
		//IL_21c5: Expected O, but got I4
		//IL_334a: Expected O, but got I4
		//IL_3352: Expected O, but got Ref
		//IL_335b: Expected O, but got I4
		//IL_33ba: Expected O, but got Ref
		//IL_33c3: Expected O, but got I4
		//IL_149d: Expected O, but got I
		//IL_14bb: Expected O, but got I
		//IL_34b0: Expected O, but got Ref
		//IL_34b9: Expected O, but got I4
		//IL_2dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc9: Expected O, but got Unknown
		//IL_2ddf: Expected O, but got I
		//IL_2df0: Expected I, but got O
		//IL_234c: Expected O, but got I
		//IL_2354: Expected I, but got O
		//IL_055a: Expected O, but got I
		//IL_1f96: Expected O, but got I
		//IL_1fb4: Expected O, but got I
		//IL_19ed: Expected O, but got I
		//IL_30f6: Expected O, but got Ref
		//IL_30ff: Expected O, but got I4
		//IL_3114: Expected O, but got I
		//IL_2e76: Expected O, but got I
		//IL_2e7e: Expected I, but got O
		//IL_2e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e08: Expected O, but got Unknown
		//IL_2e1b: Expected O, but got I4
		//IL_32e8: Expected O, but got Ref
		//IL_32f1: Expected O, but got I4
		//IL_354d: Expected O, but got Ref
		//IL_3556: Expected O, but got I4
		//IL_22dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e1: Expected O, but got Unknown
		//IL_22f7: Expected O, but got I
		//IL_2308: Expected I, but got O
		//IL_3b3d: Expected O, but got I
		//IL_1ea9: Expected O, but got I4
		//IL_2ac1: Expected O, but got I
		//IL_2adf: Expected O, but got I
		//IL_2b15: Expected O, but got I
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_09a8: Expected O, but got I
		//IL_38fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3901: Expected O, but got Unknown
		//IL_3911: Expected O, but got I
		//IL_1517: Expected O, but got I4
		//IL_238e: Expected O, but got I
		//IL_2396: Expected I, but got O
		//IL_231b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2320: Expected O, but got Unknown
		//IL_2333: Expected O, but got I4
		//IL_3315: Expected O, but got I4
		//IL_331d: Expected O, but got Ref
		//IL_3326: Expected O, but got I4
		//IL_318a: Expected O, but got Ref
		//IL_3193: Expected O, but got I4
		//IL_31a4: Expected O, but got I4
		//IL_2010: Expected O, but got I4
		//IL_2092: Expected O, but got I
		//IL_20a2: Expected O, but got I
		//IL_09ec: Expected O, but got I
		//IL_1a0c: Expected O, but got I
		//IL_1a2a: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Expected O, but got Unknown
		//IL_180e: Expected O, but got I
		//IL_2ea1: Expected O, but got Ref
		//IL_2eaa: Expected O, but got I4
		//IL_2ebb: Expected O, but got I4
		//IL_23b8: Expected O, but got I
		//IL_23c8: Expected O, but got I
		//IL_1ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eca: Expected O, but got Unknown
		//IL_1ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efc: Expected O, but got Unknown
		//IL_2b4b: Expected O, but got I4
		//IL_337e: Expected O, but got Ref
		//IL_3387: Expected O, but got I4
		//IL_339c: Expected O, but got I
		//IL_1533: Unknown result type (might be due to invalid IL or missing references)
		//IL_1538: Expected O, but got Unknown
		//IL_1565: Unknown result type (might be due to invalid IL or missing references)
		//IL_156a: Expected O, but got Unknown
		//IL_1852: Expected O, but got I
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_059a: Expected O, but got I
		//IL_2644: Expected O, but got I
		//IL_202c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2031: Expected O, but got Unknown
		//IL_205e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2063: Expected O, but got Unknown
		//IL_2bcd: Expected O, but got I
		//IL_2bdd: Expected O, but got I
		//IL_0a06: Expected O, but got I
		//IL_0a24: Expected O, but got I
		//IL_0a5a: Expected O, but got I
		//IL_1a86: Expected O, but got I4
		//IL_05de: Expected O, but got I
		//IL_2ede: Expected O, but got Ref
		//IL_2ee7: Expected O, but got I4
		//IL_2ef8: Expected O, but got I4
		//IL_24d5: Expected O, but got I
		//IL_2b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6c: Expected O, but got Unknown
		//IL_2b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9e: Expected O, but got Unknown
		//IL_1b00: Expected O, but got I
		//IL_1b10: Expected O, but got I
		//IL_186c: Expected O, but got I
		//IL_188a: Expected O, but got I
		//IL_18c0: Expected O, but got I
		//IL_268b: Expected O, but got I4
		//IL_0a90: Expected O, but got I4
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Expected O, but got Unknown
		//IL_1ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Expected O, but got Unknown
		//IL_05f8: Expected O, but got I
		//IL_0616: Expected O, but got I
		//IL_064c: Expected O, but got I
		//IL_251c: Expected O, but got I4
		//IL_20dc: Expected O, but got I
		//IL_20ec: Expected O, but got I
		//IL_18f6: Expected O, but got I4
		//IL_26af: Expected O, but got I
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Expected O, but got Unknown
		//IL_2d3b: Expected O, but got I
		//IL_2d4b: Expected O, but got I
		//IL_0682: Expected O, but got I4
		//IL_3aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab3: Expected O, but got Unknown
		//IL_2540: Expected O, but got I
		//IL_1912: Unknown result type (might be due to invalid IL or missing references)
		//IL_1917: Expected O, but got Unknown
		//IL_1944: Unknown result type (might be due to invalid IL or missing references)
		//IL_1949: Expected O, but got Unknown
		//IL_224a: Expected O, but got I
		//IL_225a: Expected O, but got I
		//IL_26de: Expected O, but got I
		//IL_3a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a6e: Expected O, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_2577: Expected O, but got Ref
		//IL_2580: Expected O, but got I4
		//IL_2591: Expected O, but got I4
		//IL_2741: Expected O, but got I4
		//IL_25b3: Expected O, but got I
		//IL_25c3: Expected O, but got I
		//IL_275d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2762: Expected O, but got Unknown
		//IL_278f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2794: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		IEnumerable<object> enumerable = null;
		StoreHomePageViewModel storeHomePageViewModel = sections;
		List<object> list = default(List<object>);
		StoreHomePageGroup storeHomePageGroup = default(StoreHomePageGroup);
		object obj8;
		List<object>.Enumerator enumerator2;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		object obj12;
		IEnumerable<object> enumerable2 = default(IEnumerable<object>);
		IEnumerable<object> enumerable3;
		IEnumerable<object> enumerable4;
		IEnumerable<object> enumerable6;
		IEnumerable<object> enumerable7;
		nint num;
		List<object>.Enumerator enumerator3;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		int? <templateId>k__BackingField;
		object obj27;
		object obj215;
		if (!flag)
		{
			object obj3 = obj2 + 24;
			obj3 = sections;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 == null)
			{
				return;
			}
			object obj4 = typeof(List<AdaptivePerformanceScaler>) + 3576;
			object obj5 = (nint)0 + (nint)2800;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			enumerable = (IEnumerable<object>)obj5;
			list..ctor();
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
			bool flag2 = (nint)0 == 0;
			storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+20]");
				bool flag3 = (nint)0 == 0;
				storeHomePageGroup = this;
				storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
				if (!flag3)
				{
					object obj7 = (nint)0 + (nint)1776;
					obj8 = (nint)0 + (nint)1752;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+20]");
					List<object>.Enumerator enumerator = ((List<object>)0).GetEnumerator();
					object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
					enumerator2 = (List<object>.Enumerator)0;
					enumerator3 = enumerator4;
					object obj11 = default(object);
					Func<object, bool> func = default(Func<object, bool>);
					Func<object, bool> func2 = default(Func<object, bool>);
					object obj48 = default(object);
					object obj64 = default(object);
					object obj76 = default(object);
					object obj87 = default(object);
					object obj99 = default(object);
					Func<object, bool> func3 = default(Func<object, bool>);
					object obj126 = default(object);
					Func<object, bool> func4 = default(Func<object, bool>);
					object obj151 = default(object);
					Func<object, object> func5 = default(Func<object, object>);
					Func<object, object> func6 = default(Func<object, object>);
					object obj184 = default(object);
					Func<object, object> func7 = default(Func<object, object>);
					Func<object, object> func8 = default(Func<object, object>);
					Func<object, int> func9 = default(Func<object, int>);
					while (enumerator5.MoveNext())
					{
						object obj10 = typeof(SkeletonBinary.SkeletonInput) + 1464;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj11..ctor();
						if (obj11 == null)
						{
							goto IL_2f6f;
						}
						obj12 = obj11 + 16;
						obj12 = enumerable2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj13 = obj12;
						if (obj12 == null)
						{
							goto IL_2fa0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
						List<object> source2;
						object obj25;
						Func<object, int> keySelector;
						List<object> list2;
						List<object> list3;
						List<object> list4;
						if ((nint)0 > (nint)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
							if ((nint)0 <= (nint)4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
								if ((nint)0 == 3)
								{
									object obj14 = (nint)0 + (nint)2632;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+38]");
									bool flag4 = ArraysExtensions.IsNullOrEmpty((IEnumerable<int>)0);
									bool flag5 = !flag4;
									object obj15 = !flag5;
									if (obj15 != null)
									{
										continue;
									}
									object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
									object obj17 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v318+E4]");
									bool flag6 = (nint)0 == 0;
									object obj18 = !flag6;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(ItemCategory.Cards);
									object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj20 = (nint)0 + (nint)1584;
									func..ctor(obj11, (IntPtr)obj20);
									object obj21 = (nint)0 + (nint)3768;
									IEnumerable<object> source = Enumerable.Where(categoryItems, func);
									object obj22 = (nint)0 + (nint)2720;
									source2 = Enumerable.ToList(source);
									object obj23 = typeof(SkeletonBinary.SkeletonInput) + 1448;
									object obj24 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v363+E4]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v363+B8]");
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v317+10]");
										keySelector = (Func<object, int>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v317+10]");
										bool flag7 = (nint)0 == 0;
										object obj26 = !flag7;
										obj27 = 0;
										if (obj26 == null)
										{
											goto IL_1600;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj28 = typeof(SkeletonBinary.SkeletonInput) + 1448;
										obj24 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v363+B8]");
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v317+10]");
										keySelector = (Func<object, int>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v317+10]");
										bool flag8 = (nint)0 == 0;
										object obj29 = !flag8;
										obj27 = 0;
										if (obj29 == null)
										{
											goto IL_1600;
										}
									}
									goto IL_167b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
								if ((nint)0 == 4)
								{
									object obj30 = (nint)0 + (nint)2632;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+40]");
									bool flag9 = ArraysExtensions.IsNullOrEmpty((IEnumerable<int>)0);
									bool flag10 = !flag9;
									object obj31 = !flag10;
									if (obj31 != null)
									{
										continue;
									}
									object obj32 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
									object obj33 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ X0_v376+E4]");
									bool flag11 = (nint)0 == 0;
									object obj34 = !flag11;
									if (obj34 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									IEnumerable<StoreItem> categoryItems2 = Store.GetCategoryItems(ItemCategory.Rooms);
									object obj35 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj36 = (nint)0 + (nint)1592;
									func2..ctor(obj11, (IntPtr)obj36);
									object obj37 = (nint)0 + (nint)3768;
									num = (nint)obj37;
									IEnumerable<object> source3 = Enumerable.Where(categoryItems2, func2);
									list2 = Enumerable.ToList(source3);
									object obj38 = (nint)0 + (nint)2808;
									enumerable = (IEnumerable<object>)obj38;
									bool flag12 = ArraysExtensions.IsNullOrEmpty(list2);
									bool flag13 = !flag12;
									object obj39 = !flag13;
									obj27 = 0;
									if (obj39 != null)
									{
										continue;
									}
									object obj40 = obj12;
									if (obj12 != null)
									{
										object obj41 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
										object obj42 = obj41;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X0_v387+E4]");
										bool flag14 = (nint)0 == 0;
										object obj43 = !flag14;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v348+10]");
										bool flag15 = StringsExtensions.IsNullOrEmpty((string)0);
										bool flag16 = !flag15;
										object obj44 = !flag16;
										object obj45 = null;
										if (obj44 != null)
										{
											goto IL_2284;
										}
										object obj46 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
										object obj47 = (nint)0 + (nint)1;
										bool flag17 = obj12 == null;
										enumerable = null;
										if (!flag17)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											obj48..ctor();
											object obj49 = obj48 + 120;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1952 @ X23_v40+10]");
											obj49 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											((StoreDataHolder)obj48).SetTemplate();
											bool flag18 = list == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1952 @ X23_v40+10]");
											enumerable = (IEnumerable<object>)0;
											if (!flag18)
											{
												object obj50 = (nint)0 + (nint)2808;
												object obj51 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
												object obj52 = (nint)0 + (nint)1;
												<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
												bool flag19 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1952 @ X23_v40+10]");
												enumerable = (IEnumerable<object>)0;
												if (!flag19)
												{
													string <name>k__BackingField = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
													bool flag20 = (nint)<name>k__BackingField < 0;
													object obj53 = !flag20;
													if (obj53 == null)
													{
														string <name>k__BackingField2 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
														((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField2;
														object obj54 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
														object obj55 = obj54 + 32;
														obj55 = obj48;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														obj45 = obj48;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2119 @ X8_v369+20]");
														object obj56 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2416 @ X8_v370+C0]");
														object obj57 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1982 @ X8_v371+70]");
														num = 0;
														list.AddWithResize(obj48);
														obj45 = obj48;
													}
													goto IL_2284;
												}
											}
										}
										goto IL_3303;
									}
									goto IL_343e;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
								if ((nint)0 == 5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+48]");
									if ((nint)0 == 0)
									{
										continue;
									}
									object obj58 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
									object obj59 = obj58;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X0_v250+E4]");
									bool flag21 = (nint)0 == 0;
									object obj60 = !flag21;
									if (obj60 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+10]");
									bool flag22 = StringsExtensions.IsNullOrEmpty((string)0);
									bool flag23 = !flag22;
									object obj61 = !flag23;
									if (obj61 != null)
									{
										continue;
									}
									object obj62 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
									object obj63 = (nint)0 + (nint)1;
									bool flag24 = obj12 == null;
									enumerable = null;
									if (!flag24)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj64..ctor();
										object obj65 = obj64 + 120;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X24_v14+10]");
										obj65 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										((StoreDataHolder)obj64).SetTemplate();
										bool flag25 = list == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X24_v14+10]");
										enumerable = (IEnumerable<object>)0;
										if (!flag25)
										{
											object obj66 = (nint)0 + (nint)2808;
											object obj67 = obj66;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
											object obj68 = (nint)0 + (nint)1;
											int? <templateId>k__BackingField2 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
											bool flag26 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1357 @ X24_v14+10]");
											enumerable = (IEnumerable<object>)0;
											if (!flag26)
											{
												string <name>k__BackingField3 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X9_v62 (System.Nullable`1<System.Int32>)+18]");
												bool flag27 = (nint)<name>k__BackingField3 < 0;
												object obj69 = !flag27;
												if (obj69 == null)
												{
													string <name>k__BackingField4 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
													((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField4;
													object obj70 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
													object obj71 = obj70 + 32;
													obj71 = obj64;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													enumerable = (IEnumerable<object>)obj64;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1456 @ X8_v225+20]");
													object obj72 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1745 @ X8_v239+C0]");
													object obj73 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ X8_v240+70]");
													num = 0;
													list.AddWithResize(obj64);
													enumerable = (IEnumerable<object>)obj64;
												}
												object obj74 = obj12;
												if (obj12 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
													object obj75 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													obj76..ctor();
													object obj77 = obj76 + 96;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v227+48]");
													obj77 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													((StoreDataHolder)obj76).SetTemplate();
													object obj78 = (nint)0 + (nint)2808;
													object obj79 = obj78;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
													object obj80 = (nint)0 + (nint)1;
													<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
													if ((object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField != null)
													{
														string <name>k__BackingField5 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
														bool flag28 = (nint)<name>k__BackingField5 < 0;
														object obj81 = !flag28;
														if (obj81 == null)
														{
															string <name>k__BackingField6 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
															((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField6;
															object obj82 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
															object obj83 = obj82 + 32;
															obj83 = obj76;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v234+20]");
															object obj84 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2365 @ X8_v235+C0]");
															object obj85 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v236+70]");
															num = 0;
															list.AddWithResize(obj76);
														}
														continue;
													}
													goto IL_336d;
												}
												goto IL_33a9;
											}
										}
									}
									goto IL_309d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
								if ((nint)0 == 7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+50]");
									if ((nint)0 == 0)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
									object obj86 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									obj87..ctor();
									object obj88 = obj87 + 120;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+10]");
									obj88 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									((StoreDataHolder)obj87).SetTemplate();
									if (list != null)
									{
										object obj89 = (nint)0 + (nint)2808;
										object obj90 = obj89;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
										object obj91 = (nint)0 + (nint)1;
										int? <templateId>k__BackingField3 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
										if ((object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField != null)
										{
											string <name>k__BackingField7 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v73 (System.Nullable`1<System.Int32>)+18]");
											bool flag29 = (nint)<name>k__BackingField7 < 0;
											object obj92 = !flag29;
											if (obj92 == null)
											{
												string <name>k__BackingField8 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
												((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField8;
												object obj93 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
												object obj94 = obj93 + 32;
												obj94 = obj87;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												enumerable = (IEnumerable<object>)obj87;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X8_v251+20]");
												object obj95 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1612 @ X8_v265+C0]");
												object obj96 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ X8_v266+70]");
												num = 0;
												list.AddWithResize(obj87);
												enumerable = (IEnumerable<object>)obj87;
											}
											object obj97 = obj12;
											if (obj12 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
												object obj98 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												obj99..ctor();
												object obj100 = obj99 + 104;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v253+50]");
												obj100 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												((StoreDataHolder)obj99).SetTemplate();
												object obj101 = (nint)0 + (nint)2808;
												object obj102 = obj101;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
												object obj103 = (nint)0 + (nint)1;
												<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
												if ((object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField != null)
												{
													string <name>k__BackingField9 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
													bool flag30 = (nint)<name>k__BackingField9 < 0;
													object obj104 = !flag30;
													if (obj104 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v260+20]");
														object obj105 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2292 @ X8_v262+C0]");
														object obj106 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X8_v263+70]");
														num = 0;
														list.AddWithResize(obj99);
													}
													else
													{
														string <name>k__BackingField10 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
														((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField10;
														object obj107 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
														object obj108 = obj107 + 32;
														obj108 = obj99;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													}
													continue;
												}
												goto IL_30e5;
											}
											goto IL_3121;
										}
									}
									goto IL_2fd4;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
							if ((nint)0 == 0)
							{
								object obj109 = (nint)0 + (nint)2800;
								enumerable = (IEnumerable<object>)obj109;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+20]");
								bool flag31 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)0);
								bool flag32 = !flag31;
								object obj110 = !flag32;
								if (obj110 != null)
								{
									continue;
								}
								goto IL_0d02;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
							if ((nint)0 == 1)
							{
								object obj111 = (nint)0 + (nint)2632;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+28]");
								bool flag33 = ArraysExtensions.IsNullOrEmpty((IEnumerable<int>)0);
								bool flag34 = !flag33;
								object obj112 = !flag34;
								if (obj112 != null)
								{
									continue;
								}
								IEnumerable<ProductViewModel> subscriptionsRecurringAndPromotion = IAPController.SubscriptionsRecurringAndPromotion;
								object obj113 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj114 = (nint)0 + (nint)1568;
								func3..ctor(obj11, (IntPtr)obj114);
								object obj115 = (nint)0 + (nint)3696;
								num = (nint)obj115;
								IEnumerable<object> source4 = Enumerable.Where(subscriptionsRecurringAndPromotion, func3);
								list3 = Enumerable.ToList(source4);
								object obj116 = (nint)0 + (nint)2704;
								enumerable = (IEnumerable<object>)obj116;
								bool flag35 = ArraysExtensions.IsNullOrEmpty(list3);
								bool flag36 = !flag35;
								object obj117 = !flag36;
								obj27 = 0;
								if (obj117 != null)
								{
									continue;
								}
								object obj118 = obj12;
								if (obj12 != null)
								{
									object obj119 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
									object obj120 = obj119;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v66+E4]");
									bool flag37 = (nint)0 == 0;
									object obj121 = !flag37;
									if (obj121 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v42+10]");
									bool flag38 = StringsExtensions.IsNullOrEmpty((string)0);
									bool flag39 = !flag38;
									object obj122 = !flag39;
									object obj123 = null;
									if (obj122 != null)
									{
										goto IL_2c07;
									}
									object obj124 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
									object obj125 = (nint)0 + (nint)1;
									bool flag40 = obj12 == null;
									enumerable = null;
									if (!flag40)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj126..ctor();
										object obj127 = obj126 + 120;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ X23_v17+10]");
										obj127 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										((StoreDataHolder)obj126).SetTemplate();
										bool flag41 = list == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ X23_v17+10]");
										enumerable = (IEnumerable<object>)0;
										if (!flag41)
										{
											object obj128 = (nint)0 + (nint)2808;
											object obj129 = obj128;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
											object obj130 = (nint)0 + (nint)1;
											<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
											bool flag42 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ X23_v17+10]");
											enumerable = (IEnumerable<object>)0;
											if (!flag42)
											{
												string <name>k__BackingField11 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
												bool flag43 = (nint)<name>k__BackingField11 < 0;
												object obj131 = !flag43;
												if (obj131 == null)
												{
													string <name>k__BackingField12 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
													((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField12;
													object obj132 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
													object obj133 = obj132 + 32;
													obj133 = obj126;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													obj123 = obj126;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2035 @ X8_v63+20]");
													object obj134 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2369 @ X8_v64+C0]");
													object obj135 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1783 @ X8_v65+70]");
													num = 0;
													list.AddWithResize(obj126);
													obj123 = obj126;
												}
												goto IL_2c07;
											}
										}
									}
									goto IL_32a2;
								}
								goto IL_33d5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+18]");
							if ((nint)0 == 2)
							{
								object obj136 = (nint)0 + (nint)2632;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+30]");
								bool flag44 = ArraysExtensions.IsNullOrEmpty((IEnumerable<int>)0);
								bool flag45 = !flag44;
								object obj137 = !flag45;
								if (obj137 != null)
								{
									continue;
								}
								IEnumerable<ProductViewModel> goldenCardsIncludingHidden = IAPController.GoldenCardsIncludingHidden;
								object obj138 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj139 = (nint)0 + (nint)1576;
								func4..ctor(obj11, (IntPtr)obj139);
								object obj140 = (nint)0 + (nint)3696;
								num = (nint)obj140;
								IEnumerable<object> source5 = Enumerable.Where(goldenCardsIncludingHidden, func4);
								list4 = Enumerable.ToList(source5);
								object obj141 = (nint)0 + (nint)2704;
								enumerable = (IEnumerable<object>)obj141;
								bool flag46 = ArraysExtensions.IsNullOrEmpty(list4);
								bool flag47 = !flag46;
								object obj142 = !flag47;
								obj27 = 0;
								if (obj142 != null)
								{
									continue;
								}
								object obj143 = obj12;
								if (obj12 != null)
								{
									object obj144 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
									object obj145 = obj144;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X0_v220+E4]");
									bool flag48 = (nint)0 == 0;
									object obj146 = !flag48;
									if (obj146 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v188+10]");
									bool flag49 = StringsExtensions.IsNullOrEmpty((string)0);
									bool flag50 = !flag49;
									object obj147 = !flag50;
									object obj148 = null;
									if (obj147 != null)
									{
										goto IL_2116;
									}
									object obj149 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
									object obj150 = (nint)0 + (nint)1;
									bool flag51 = obj12 == null;
									enumerable = null;
									if (!flag51)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj151..ctor();
										object obj152 = obj151 + 120;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1864 @ X23_v24+10]");
										obj152 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										((StoreDataHolder)obj151).SetTemplate();
										bool flag52 = list == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1864 @ X23_v24+10]");
										enumerable = (IEnumerable<object>)0;
										if (!flag52)
										{
											object obj153 = (nint)0 + (nint)2808;
											object obj154 = obj153;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
											object obj155 = (nint)0 + (nint)1;
											<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
											bool flag53 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1864 @ X23_v24+10]");
											enumerable = (IEnumerable<object>)0;
											if (!flag53)
											{
												string <name>k__BackingField13 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
												bool flag54 = (nint)<name>k__BackingField13 < 0;
												object obj156 = !flag54;
												if (obj156 == null)
												{
													string <name>k__BackingField14 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
													((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField14;
													object obj157 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
													object obj158 = obj157 + 32;
													obj158 = obj151;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													obj148 = obj151;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X8_v209+20]");
													object obj159 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2391 @ X8_v210+C0]");
													object obj160 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X8_v211+70]");
													num = 0;
													list.AddWithResize(obj151);
													obj148 = obj151;
												}
												goto IL_2116;
											}
										}
									}
									goto IL_3338;
								}
								goto IL_3507;
							}
						}
						goto IL_3010;
						IL_2c07:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+20]");
						Func<object, object> selector = (Func<object, object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+20]");
						bool flag55 = (nint)0 == 0;
						object obj161 = !flag55;
						obj27 = 0;
						if (obj161 == null)
						{
							object obj162 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2896;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj163 = (nint)0 + (nint)1536;
							func5..ctor(obj2, (IntPtr)obj163);
							object obj164 = obj2 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj27 = 0;
							selector = func5;
						}
						object obj165 = (nint)0 + (nint)3872;
						num = (nint)obj165;
						enumerable3 = Enumerable.Select(list3, selector);
						if (list != null)
						{
							object obj166 = (nint)0 + (nint)2816;
							num = (nint)obj166;
							list.AddRange(enumerable3);
							continue;
						}
						goto IL_340a;
						IL_2116:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+28]");
						Func<object, object> selector2 = (Func<object, object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+28]");
						bool flag56 = (nint)0 == 0;
						object obj167 = !flag56;
						obj27 = 0;
						if (obj167 == null)
						{
							object obj168 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2896;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj169 = (nint)0 + (nint)1544;
							func6..ctor(obj2, (IntPtr)obj169);
							object obj170 = obj2 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj27 = 0;
							selector2 = func6;
						}
						object obj171 = (nint)0 + (nint)3872;
						num = (nint)obj171;
						enumerable4 = Enumerable.Select(list4, selector2);
						if (list != null)
						{
							object obj172 = (nint)0 + (nint)2816;
							num = (nint)obj172;
							list.AddRange(enumerable4);
							continue;
						}
						goto IL_34d3;
						IL_167b:
						object obj173 = (nint)0 + (nint)1552;
						num = (nint)obj173;
						IEnumerable<IGrouping<int, object>> enumerable5 = Enumerable.GroupBy(source2, keySelector);
						object obj174 = (nint)0 + (nint)2472;
						enumerable = (IEnumerable<object>)obj174;
						bool flag57 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)enumerable5);
						bool flag58 = !flag57;
						object obj175 = !flag58;
						if (obj175 != null)
						{
							continue;
						}
						object obj176 = obj12;
						if (obj12 != null)
						{
							object obj177 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
							object obj178 = obj177;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ X0_v333+E4]");
							bool flag59 = (nint)0 == 0;
							object obj179 = !flag59;
							if (obj179 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v290+10]");
							bool flag60 = StringsExtensions.IsNullOrEmpty((string)0);
							bool flag61 = !flag60;
							object obj180 = !flag61;
							object obj181 = null;
							if (obj180 != null)
							{
								goto IL_2d75;
							}
							object obj182 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
							object obj183 = (nint)0 + (nint)1;
							bool flag62 = obj12 == null;
							enumerable = null;
							if (!flag62)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj184..ctor();
								object obj185 = obj184 + 120;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X23_v33+10]");
								obj185 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								((StoreDataHolder)obj184).SetTemplate();
								bool flag63 = list == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X23_v33+10]");
								enumerable = (IEnumerable<object>)0;
								if (!flag63)
								{
									object obj186 = (nint)0 + (nint)2808;
									object obj187 = obj186;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
									object obj188 = (nint)0 + (nint)1;
									<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
									bool flag64 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X23_v33+10]");
									enumerable = (IEnumerable<object>)0;
									if (!flag64)
									{
										string <name>k__BackingField15 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
										bool flag65 = (nint)<name>k__BackingField15 < 0;
										object obj189 = !flag65;
										if (obj189 == null)
										{
											string <name>k__BackingField16 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
											((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField16;
											object obj190 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
											object obj191 = obj190 + 32;
											obj191 = obj184;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											obj181 = obj184;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2287 @ X8_v311+20]");
											object obj192 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X8_v312+C0]");
											object obj193 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2152 @ X8_v313+70]");
											num = 0;
											list.AddWithResize(obj184);
											obj181 = obj184;
										}
										goto IL_2d75;
									}
								}
							}
							goto IL_32d7;
						}
						goto IL_3473;
						IL_2d75:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+30]");
						Func<object, object> selector3 = (Func<object, object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+30]");
						bool flag66 = (nint)0 == 0;
						object obj194 = !flag66;
						if (obj194 == null)
						{
							object obj195 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3296;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj196 = (nint)0 + (nint)1552;
							func7..ctor(obj2, (IntPtr)obj196);
							object obj197 = obj2 + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj27 = 0;
							selector3 = func7;
						}
						object obj198 = (nint)0 + (nint)2704;
						num = (nint)obj198;
						enumerable6 = Enumerable.Select(enumerable5, selector3);
						if (list != null)
						{
							object obj199 = (nint)0 + (nint)2816;
							num = (nint)obj199;
							list.AddRange(enumerable6);
							continue;
						}
						goto IL_349f;
						IL_2284:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+38]");
						Func<object, object> selector4 = (Func<object, object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+38]");
						bool flag67 = (nint)0 == 0;
						object obj200 = !flag67;
						obj27 = 0;
						if (obj200 == null)
						{
							object obj201 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3464;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj202 = (nint)0 + (nint)1560;
							func8..ctor(obj2, (IntPtr)obj202);
							object obj203 = obj2 + 56;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj27 = 0;
							selector4 = func8;
						}
						object obj204 = (nint)0 + (nint)4080;
						num = (nint)obj204;
						enumerable7 = Enumerable.Select(list2, selector4);
						if (list != null)
						{
							object obj205 = (nint)0 + (nint)2816;
							num = (nint)obj205;
							list.AddRange(enumerable7);
							continue;
						}
						goto IL_353c;
						IL_1600:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v363+E4]");
						<templateId>k__BackingField = (int?)(object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v363+E4]");
						bool flag68 = (nint)0 == 0;
						object obj206 = !flag68;
						if (obj206 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj207 = typeof(SkeletonBinary.SkeletonInput) + 1448;
							object obj208 = obj207;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1727 @ X8_v327+B8]");
							obj25 = 0;
						}
						object obj209 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj210 = (nint)0 + (nint)1528;
						func9..ctor(obj25, (IntPtr)obj210);
						object obj211 = typeof(SkeletonBinary.SkeletonInput) + 1448;
						object obj212 = obj211;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1597 @ X8_v324+B8]");
						object obj213 = (nint)0 + (nint)16;
						obj213 = func9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj27 = 0;
						keySelector = func9;
						goto IL_167b;
					}
					Func<object, bool> func10 = (Func<object, bool>)31;
					object obj214 = (nint)0 + (nint)1768;
					enumerable = (IEnumerable<object>)obj214;
					enumerator5.Dispose();
					StoreHomePageGroup storeHomePageGroup2 = this;
					storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
					obj215 = 0;
					goto IL_3678;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_30d7;
		IL_3678:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_3686;
		IL_3686:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238A68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_340a:
		NullReferenceException ex3 = new NullReferenceException();
		List<object>.Enumerator enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		enumerable = enumerable3;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_1d28:
		object obj216 = (nint)0 + (nint)3760;
		num = (nint)obj216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v75+20]");
		Func<object, bool> predicate;
		IEnumerable<object> source6 = Enumerable.Where((IEnumerable<object>)0, predicate);
		object obj217 = (nint)0 + (nint)2712;
		enumerable = (IEnumerable<object>)obj217;
		List<object> list5 = Enumerable.ToList(source6);
		if (list5 != null)
		{
			if (list5._size == 1)
			{
				object obj218 = (nint)0 + (nint)8;
				object obj219 = Enumerable.First(list5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				object obj220 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj221 = default(object);
				obj221..ctor();
				object obj222 = obj221 + 56;
				obj222 = obj219;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				((StoreDataHolder)obj221).SetTemplate();
				if (list != null)
				{
					object obj223 = (nint)0 + (nint)2808;
					object obj224 = obj223;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
					object obj225 = (nint)0 + (nint)1;
					<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
					if ((object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField != null)
					{
						string <name>k__BackingField17 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
						bool flag69 = (nint)<name>k__BackingField17 < 0;
						object obj226 = !flag69;
						if (obj226 == null)
						{
							string <name>k__BackingField18 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
							((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField18;
							object obj227 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
							object obj228 = obj227 + 32;
							obj228 = obj221;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							enumerable = (IEnumerable<object>)obj221;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2296 @ X8_v143+20]");
							object obj229 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2348 @ X8_v144+C0]");
							object obj230 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X8_v145+70]");
							num = 0;
							list.AddWithResize(obj221);
							enumerable = (IEnumerable<object>)obj221;
						}
						goto IL_23f2;
					}
				}
				ex3 = new NullReferenceException();
				enumerator6 = (List<object>.Enumerator)(&enumerator5);
				obj215 = 0;
				storeHomePageGroup = this;
				enumerable = (IEnumerable<object>)obj219;
				storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
			}
			else
			{
				if (list5._size < 2)
				{
					goto IL_23f2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				object obj231 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj232 = default(object);
				obj232..ctor();
				object obj233 = obj232 + 48;
				obj233 = list5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				((StoreDataHolder)obj232).SetTemplate();
				if (list != null)
				{
					object obj234 = (nint)0 + (nint)2808;
					object obj235 = obj234;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
					object obj236 = (nint)0 + (nint)1;
					<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
					if ((object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField != null)
					{
						string <name>k__BackingField19 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
						bool flag70 = (nint)<name>k__BackingField19 < 0;
						object obj237 = !flag70;
						if (obj237 == null)
						{
							string <name>k__BackingField20 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
							((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField20;
							object obj238 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
							object obj239 = obj238 + 32;
							obj239 = obj232;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							enumerable = (IEnumerable<object>)obj232;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2301 @ X8_v128+20]");
							object obj240 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X8_v129+C0]");
							object obj241 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1840 @ X8_v130+70]");
							num = 0;
							list.AddWithResize(obj232);
							enumerable = (IEnumerable<object>)obj232;
						}
						goto IL_23f2;
					}
				}
				ex3 = new NullReferenceException();
				enumerator6 = (List<object>.Enumerator)(&enumerator5);
				obj215 = 0;
				storeHomePageGroup = this;
				enumerable = list5;
				storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
			}
		}
		else
		{
			ex3 = new NullReferenceException();
			enumerator6 = (List<object>.Enumerator)(&enumerator5);
			obj215 = 0;
			storeHomePageGroup = this;
			storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		}
		goto IL_3b58;
		IL_2e90:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		enumerator3 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_2ecd:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		enumerator3 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_353c:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		enumerable = enumerable7;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_349f:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		enumerable = enumerable6;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_2f6f:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		enumerable = null;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_343e:
		ex3 = new NullReferenceException();
		obj27 = 0;
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_2fa0:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		enumerable = enumerable2;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_3010:
		object obj242 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex4 = default(ArgumentOutOfRangeException);
		ex4..ctor();
		object obj243 = (nint)0 + (nint)4080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex5 = new OutOfMemoryException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		IEnumerable<object> enumerable8 = default(IEnumerable<object>);
		enumerable = enumerable8;
		ex3 = (NullReferenceException)(object)ex5;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_309d:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_32a2:
		ex3 = new NullReferenceException();
		obj27 = 0;
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_0d02:
		object obj244 = obj12;
		if (obj12 != null)
		{
			object obj245 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj246 = obj245;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X0_v99+E4]");
			bool flag71 = (nint)0 == 0;
			object obj247 = !flag71;
			if (obj247 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v70+10]");
			bool flag72 = StringsExtensions.IsNullOrEmpty((string)0);
			bool flag73 = !flag72;
			object obj248 = !flag73;
			enumerable = null;
			if (obj248 != null)
			{
				goto IL_1b7c;
			}
			object obj249 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
			object obj250 = (nint)0 + (nint)1;
			bool flag74 = obj12 == null;
			enumerator6 = (List<object>.Enumerator)(&enumerator5);
			obj215 = 0;
			storeHomePageGroup = this;
			enumerable = null;
			storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
			if (!flag74)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj251 = default(object);
				obj251..ctor();
				object obj252 = obj251 + 120;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X25_v33+10]");
				obj252 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				((StoreDataHolder)obj251).SetTemplate();
				bool flag75 = list == null;
				enumerator6 = (List<object>.Enumerator)(&enumerator5);
				obj215 = 0;
				storeHomePageGroup = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X25_v33+10]");
				enumerable = (IEnumerable<object>)0;
				storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
				if (!flag75)
				{
					object obj253 = (nint)0 + (nint)2808;
					object obj254 = obj253;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
					object obj255 = (nint)0 + (nint)1;
					<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
					bool flag76 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
					enumerator6 = (List<object>.Enumerator)(&enumerator5);
					obj215 = 0;
					storeHomePageGroup = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X25_v33+10]");
					enumerable = (IEnumerable<object>)0;
					storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
					if (!flag76)
					{
						string <name>k__BackingField21 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
						bool flag77 = (nint)<name>k__BackingField21 < 0;
						object obj256 = !flag77;
						if (obj256 == null)
						{
							string <name>k__BackingField22 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
							((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField22;
							object obj257 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
							object obj258 = obj257 + 32;
							obj258 = obj251;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							enumerable = (IEnumerable<object>)obj251;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v171+20]");
							object obj259 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X8_v172+C0]");
							object obj260 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1433 @ X8_v173+70]");
							num = 0;
							list.AddWithResize(obj251);
							enumerable = (IEnumerable<object>)obj251;
						}
						goto IL_1b7c;
					}
				}
			}
			goto IL_30d7;
		}
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_2566:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		enumerator3 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_32d7:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_33a9:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_252a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		object obj261 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj262 = default(object);
		obj262..ctor();
		object obj263 = obj262 + 56;
		obj263 = enumerable2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		((StoreDataHolder)obj262).SetTemplate();
		enumerable = enumerable2;
		goto IL_2566;
		IL_30e5:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v253+50]");
		enumerable = (IEnumerable<object>)0;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_2fd4:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X25_v11+10]");
		enumerable = (IEnumerable<object>)0;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_3507:
		ex3 = new NullReferenceException();
		obj27 = 0;
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_30d7:
		ex3 = new NullReferenceException();
		goto IL_3b58;
		IL_3b58:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238A28");
		bool flag78 = (nint)enumerable != 1;
		ex2 = (OutOfMemoryException)(object)ex3;
		if (!flag78)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj264 = (nint)0 + (nint)1768;
			enumerable = (IEnumerable<object>)obj264;
			((List<object>.Enumerator*)enumerator6)->Dispose();
			object obj265 = default(object);
			bool flag79 = obj265 == null;
			Func<object, bool> func10 = null;
			StoreHomePageGroup storeHomePageGroup2 = storeHomePageGroup;
			obj215 = obj265;
			if (flag79)
			{
				if ((nint)func10 != 31)
				{
					bool flag80 = func10 == null;
					object obj266 = !flag80;
					if (obj266 != null)
					{
						return;
					}
				}
				storeHomePageGroup2.data = (List<StoreDataHolder>)(object)storeHomePageViewModel;
				return;
			}
			goto IL_3678;
		}
		goto IL_3686;
		IL_23f2:
		object obj267 = obj12;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v86+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v86+20]");
				List<object>.Enumerator enumerator7 = ((List<object>)0).GetEnumerator();
				bool flag81 = list == null;
				object obj268 = !flag81;
				if (obj268 == null)
				{
					while (true)
					{
						enumerable = (IEnumerable<object>)obj8;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						if (enumerable2 == null)
						{
							goto IL_2e90;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ stack_-A8 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
						object obj269 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ stack_-A8 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2328 @ X8_v113+20]");
							bool flag82 = (nint)0 == 0;
							object obj270 = !flag82;
							if (obj270 != null)
							{
								continue;
							}
							goto IL_252a;
						}
						goto IL_2ecd;
					}
				}
				else
				{
					object obj274 = default(object);
					while (true)
					{
						enumerable = (IEnumerable<object>)obj8;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						if (enumerable2 == null)
						{
							goto IL_2e90;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ stack_-A8 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
						object obj271 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ stack_-A8 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2332 @ X8_v98+20]");
							bool flag83 = (nint)0 == 0;
							object obj272 = !flag83;
							if (obj272 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
							object obj273 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj274..ctor();
							object obj275 = obj274 + 56;
							obj275 = enumerable2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 0;
							((StoreDataHolder)obj274).SetTemplate();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v31 (System.Collections.Generic.List`1<System.Object>)+1C]");
							object obj276 = (nint)0 + (nint)1;
							<templateId>k__BackingField = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField;
							bool flag84 = (object)((StoreHomePageViewModel)(object)list).<templateId>k__BackingField == null;
							enumerable = enumerable2;
							if (!flag84)
							{
								string <name>k__BackingField23 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X9_v23 (System.Nullable`1<System.Int32>)+18]");
								bool flag85 = (nint)<name>k__BackingField23 < 0;
								object obj277 = !flag85;
								if (obj277 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6020]");
									object obj278 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X8_v108+C0]");
									object obj279 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2227 @ X8_v109+70]");
									num = 0;
									list.AddWithResize(obj274);
								}
								else
								{
									string <name>k__BackingField24 = ((StoreHomePageViewModel)(object)list).<name>k__BackingField + 1;
									((StoreHomePageViewModel)(object)list).<name>k__BackingField = <name>k__BackingField24;
									object obj280 = ((StoreHomePageViewModel)(object)list).<templateId>k__BackingField + ((StoreHomePageViewModel)(object)list).<name>k__BackingField;
									object obj281 = obj280 + 32;
									obj281 = obj274;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								continue;
							}
							goto IL_2566;
						}
						goto IL_2ecd;
					}
				}
				object obj282 = (nint)0 + (nint)1744;
				enumerable = (IEnumerable<object>)obj282;
				enumerator2.Dispose();
				OutOfMemoryException ex6 = new OutOfMemoryException();
				enumerator6 = (List<object>.Enumerator)(&enumerator5);
				obj215 = 0;
				enumerator3 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				storeHomePageGroup = this;
				ex3 = (NullReferenceException)(object)ex6;
				storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
			}
			else
			{
				ex3 = new NullReferenceException();
				enumerator6 = (List<object>.Enumerator)(&enumerator5);
				obj215 = 0;
				storeHomePageGroup = this;
				storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
			}
		}
		else
		{
			ex3 = new NullReferenceException();
			enumerator6 = (List<object>.Enumerator)(&enumerator5);
			obj215 = 0;
			storeHomePageGroup = this;
			storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		}
		goto IL_3b58;
		IL_33d5:
		ex3 = new NullReferenceException();
		obj27 = 0;
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_1b7c:
		object obj283 = obj12;
		object obj286;
		if (obj12 != null)
		{
			object obj284 = typeof(SkeletonBinary.SkeletonInput) + 1448;
			object obj285 = obj284;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X0_v185+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X0_v185+B8]");
				obj286 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ X8_v149+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ X8_v149+8]");
				bool flag86 = (nint)0 == 0;
				object obj287 = !flag86;
				if (obj287 == null)
				{
					goto IL_1cad;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj288 = typeof(SkeletonBinary.SkeletonInput) + 1448;
				obj285 = obj288;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X0_v185+B8]");
				obj286 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ X8_v149+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ X8_v149+8]");
				bool flag87 = (nint)0 == 0;
				object obj289 = !flag87;
				if (obj289 == null)
				{
					goto IL_1cad;
				}
			}
			goto IL_1d28;
		}
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_336d:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v227+48]");
		enumerable = (IEnumerable<object>)0;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_34d3:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		enumerable = enumerable4;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_3338:
		ex3 = new NullReferenceException();
		obj27 = 0;
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_3303:
		ex3 = new NullReferenceException();
		obj27 = 0;
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_1cad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X0_v185+E4]");
		<templateId>k__BackingField = (int?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X0_v185+E4]");
		bool flag88 = (nint)0 == 0;
		object obj290 = !flag88;
		if (obj290 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj291 = typeof(SkeletonBinary.SkeletonInput) + 1448;
			object obj292 = obj291;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X8_v159+B8]");
			obj286 = 0;
		}
		object obj293 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj294 = (nint)0 + (nint)1512;
		Func<object, bool> func11 = default(Func<object, bool>);
		func11..ctor(obj286, (IntPtr)obj294);
		object obj295 = typeof(SkeletonBinary.SkeletonInput) + 1448;
		object obj296 = obj295;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X8_v156+B8]");
		object obj297 = (nint)0 + (nint)8;
		obj297 = func11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj27 = 0;
		predicate = func11;
		goto IL_1d28;
		IL_3473:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
		IL_3121:
		ex3 = new NullReferenceException();
		enumerator6 = (List<object>.Enumerator)(&enumerator5);
		obj215 = 0;
		storeHomePageGroup = this;
		storeHomePageViewModel = (StoreHomePageViewModel)(object)list;
		goto IL_3b58;
	}

	public static StoreDataHolder InitTitle(StoreHomeSection section, int i)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (section != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 120;
			obj3 = section.<name>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((StoreDataHolder)obj2).SetTemplate();
			return (StoreDataHolder)obj2;
		}
		return (StoreDataHolder)(object)new NullReferenceException();
	}

	public static StoreDataHolder InitBannerItem(StoreBannerViewModel banner, ImageCacher.BannerSize type, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 56;
		obj3 = banner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitBannerList(List<StoreBannerViewModel> banners, ImageCacher.BannerSize type, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 48;
		obj3 = banners;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitCardItems(List<StoreItem> items, int i, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 40;
		obj3 = items;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitRoomItem(StoreItem item, int i, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 2;
		object obj3 = obj2 + 64;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitGoldenCards(ProductViewModel item, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 80;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitSubscription(ProductViewModel items, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 88;
		obj3 = items;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitUniqueItem(UniqueStoreItem item, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 96;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitBundle(Bundle item, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 104;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public static StoreDataHolder InitPatternItem(StoreItem item, int i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		_ = 4;
		object obj3 = obj2 + 72;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj2).SetTemplate();
		return (StoreDataHolder)obj2;
	}

	public StoreHomePageGroup()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
