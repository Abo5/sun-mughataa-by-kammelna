using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models.Products;
using UnityEngine;

public class ProductStore
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProductViewModel, bool> <>9__16_0;

		public static Func<ProductViewModel, bool> <>9__18_0;

		public static Func<ProductViewModel, int> <>9__18_1;

		public static Func<ProductViewModel, bool> <>9__22_0;

		public static Func<ProductListingModel, bool> <>9__23_2;

		public static Func<ProductViewModel, ProductViewModel> <>9__23_0;

		public static Func<ProductViewModel, bool> <>9__23_1;

		public static Func<ProductViewModel, bool> <>9__24_0;

		public static Func<ProductListingModel, bool> <>9__24_4;

		public static Func<ProductViewModel, ProductViewModel> <>9__24_1;

		public static Func<ProductViewModel, bool> <>9__24_2;

		public static Func<ProductViewModel, int> <>9__24_3;

		public static Func<ProductListingModel, bool> <>9__25_4;

		public static Func<ProductViewModel, ProductViewModel> <>9__25_0;

		public static Func<ProductViewModel, bool> <>9__25_1;

		public static Func<ProductViewModel, int> <>9__25_2;

		public static Func<ProductViewModel, int> <>9__25_3;

		public static Func<ProductViewModel, bool> <>9__26_0;

		public static Func<ProductListingModel, bool> <>9__26_4;

		public static Func<ProductViewModel, ProductViewModel> <>9__26_1;

		public static Func<ProductViewModel, bool> <>9__26_2;

		public static Func<ProductViewModel, int> <>9__26_3;

		public static Action<ProductViewModel> <>9__27_0;

		public static Func<ProductViewModel, IEnumerable<ProductListingModel>> <>9__28_0;

		public static Func<ProductListingModel, bool> <>9__31_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_ConsumableSubscriptions>b__16_0(ProductViewModel product)
		{
			//IL_003d: Expected I4, but got O
			if (product != null)
			{
				return product.IsSubscription;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_GoldenCards>b__18_0(ProductViewModel product)
		{
			//IL_003d: Expected I4, but got O
			if (product != null)
			{
				return product.IsCoins;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <get_GoldenCards>b__18_1(ProductViewModel product)
		{
			//IL_0035: Expected I4, but got O
			if (product != null)
			{
				return product.<coins>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <get_GoldenCardsIncludingHidden>b__22_0(ProductViewModel product)
		{
			//IL_003d: Expected I4, but got O
			if (product != null)
			{
				return product.IsCoins;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal ProductViewModel <FilterOutHidden>b__23_0(ProductViewModel p)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0131: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_0165: Expected O, but got I
			//IL_0187: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01bf: Expected O, but got I
			//IL_01d0: Expected I, but got O
			//IL_01ee: Expected O, but got I
			//IL_00ba: Expected O, but got I
			if (p != null)
			{
				object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				object obj4 = (nint)0 + (nint)3688;
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2168;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+28]");
				Func<object, bool> predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+28]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v12+B8]");
						obj6 = 0;
					}
					object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)2272;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj6, (IntPtr)obj11);
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+B8]");
					object obj13 = (nint)0 + (nint)40;
					obj13 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				IEnumerable<object> listings = Enumerable.Where(p.<listings>k__BackingField, predicate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ProductViewModel productViewModel = default(ProductViewModel);
				productViewModel..ctor(p, (IEnumerable<ProductListingModel>)listings);
				return productViewModel;
			}
			return (ProductViewModel)(object)new NullReferenceException();
		}

		internal bool <FilterOutHidden>b__23_2(ProductListingModel l)
		{
			//IL_004c: Expected I4, but got O
			//IL_002b: Expected O, but got I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			if (l != null)
			{
				object obj = ~(l.<isHidden>k__BackingField ? 1 : 0);
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FilterOutHidden>b__23_1(ProductViewModel p)
		{
			//IL_00cd: Expected I4, but got O
			//IL_00ad: Expected O, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected I4, but got Unknown
			if (p != null)
			{
				List<ProductListingModel> <listings>k__BackingField = p.<listings>k__BackingField;
				if (p.<listings>k__BackingField != null)
				{
					bool flag = <listings>k__BackingField._size < 0;
					bool flag2 = <listings>k__BackingField._size == 0;
					int num = <listings>k__BackingField._size ^ <listings>k__BackingField._size;
					int num2 = <listings>k__BackingField._size & num;
					bool flag3 = num2 < 0;
					bool flag4 = flag == flag3;
					object obj = !flag2;
					return (byte)((flag4 & obj) ? 1 : 0) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FilterRecurring>b__24_0(ProductViewModel p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsSubscription;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal ProductViewModel <FilterRecurring>b__24_1(ProductViewModel p)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0131: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_0165: Expected O, but got I
			//IL_0187: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01bf: Expected O, but got I
			//IL_01d0: Expected I, but got O
			//IL_01ee: Expected O, but got I
			//IL_00ba: Expected O, but got I
			if (p != null)
			{
				object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				object obj4 = (nint)0 + (nint)3688;
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2168;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+48]");
				Func<object, bool> predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+48]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v12+B8]");
						obj6 = 0;
					}
					object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)2312;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj6, (IntPtr)obj11);
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+B8]");
					object obj13 = (nint)0 + (nint)72;
					obj13 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				IEnumerable<object> listings = Enumerable.Where(p.<listings>k__BackingField, predicate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ProductViewModel productViewModel = default(ProductViewModel);
				productViewModel..ctor(p, (IEnumerable<ProductListingModel>)listings);
				return productViewModel;
			}
			return (ProductViewModel)(object)new NullReferenceException();
		}

		internal bool <FilterRecurring>b__24_4(ProductListingModel l)
		{
			//IL_0035: Expected I4, but got O
			if (l != null)
			{
				return l.<isRecurring>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FilterRecurring>b__24_2(ProductViewModel p)
		{
			//IL_00cd: Expected I4, but got O
			//IL_00ad: Expected O, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected I4, but got Unknown
			if (p != null)
			{
				List<ProductListingModel> <listings>k__BackingField = p.<listings>k__BackingField;
				if (p.<listings>k__BackingField != null)
				{
					bool flag = <listings>k__BackingField._size < 0;
					bool flag2 = <listings>k__BackingField._size == 0;
					int num = <listings>k__BackingField._size ^ <listings>k__BackingField._size;
					int num2 = <listings>k__BackingField._size & num;
					bool flag3 = num2 < 0;
					bool flag4 = flag == flag3;
					object obj = !flag2;
					return (byte)((flag4 & obj) ? 1 : 0) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <FilterRecurring>b__24_3(ProductViewModel p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.<days>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal ProductViewModel <FilterConsumable>b__25_0(ProductViewModel p)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0131: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_0165: Expected O, but got I
			//IL_0187: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01bf: Expected O, but got I
			//IL_01d0: Expected I, but got O
			//IL_01ee: Expected O, but got I
			//IL_00ba: Expected O, but got I
			if (p != null)
			{
				object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				object obj4 = (nint)0 + (nint)3688;
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2168;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+68]");
				Func<object, bool> predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+68]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v12+B8]");
						obj6 = 0;
					}
					object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)2248;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj6, (IntPtr)obj11);
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+B8]");
					object obj13 = (nint)0 + (nint)104;
					obj13 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				IEnumerable<object> listings = Enumerable.Where(p.<listings>k__BackingField, predicate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ProductViewModel productViewModel = default(ProductViewModel);
				productViewModel..ctor(p, (IEnumerable<ProductListingModel>)listings);
				return productViewModel;
			}
			return (ProductViewModel)(object)new NullReferenceException();
		}

		internal bool <FilterConsumable>b__25_4(ProductListingModel l)
		{
			//IL_0035: Expected I4, but got O
			if (l != null)
			{
				return l.<isConsumable>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FilterConsumable>b__25_1(ProductViewModel p)
		{
			//IL_00cd: Expected I4, but got O
			//IL_00ad: Expected O, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected I4, but got Unknown
			if (p != null)
			{
				List<ProductListingModel> <listings>k__BackingField = p.<listings>k__BackingField;
				if (p.<listings>k__BackingField != null)
				{
					bool flag = <listings>k__BackingField._size < 0;
					bool flag2 = <listings>k__BackingField._size == 0;
					int num = <listings>k__BackingField._size ^ <listings>k__BackingField._size;
					int num2 = <listings>k__BackingField._size & num;
					bool flag3 = num2 < 0;
					bool flag4 = flag == flag3;
					object obj = !flag2;
					return (byte)((flag4 & obj) ? 1 : 0) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <FilterConsumable>b__25_2(ProductViewModel p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.<days>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <FilterConsumable>b__25_3(ProductViewModel p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.<coins>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <FilterSubscriptionsInStoreHomePage>b__26_0(ProductViewModel p)
		{
			//IL_003d: Expected I4, but got O
			if (p != null)
			{
				return p.IsSubscription;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal ProductViewModel <FilterSubscriptionsInStoreHomePage>b__26_1(ProductViewModel p)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0131: Expected O, but got I
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_0165: Expected O, but got I
			//IL_0187: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected O, but got Unknown
			//IL_01bf: Expected O, but got I
			//IL_01d0: Expected I, but got O
			//IL_01ee: Expected O, but got I
			//IL_00ba: Expected O, but got I
			if (p != null)
			{
				object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				object obj4 = (nint)0 + (nint)3688;
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2168;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+98]");
				Func<object, bool> predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+98]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v12+B8]");
						obj6 = 0;
					}
					object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj11 = (nint)0 + (nint)2352;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj6, (IntPtr)obj11);
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+B8]");
					object obj13 = (nint)0 + (nint)152;
					obj13 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				IEnumerable<object> listings = Enumerable.Where(p.<listings>k__BackingField, predicate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ProductViewModel productViewModel = default(ProductViewModel);
				productViewModel..ctor(p, (IEnumerable<ProductListingModel>)listings);
				return productViewModel;
			}
			return (ProductViewModel)(object)new NullReferenceException();
		}

		internal bool <FilterSubscriptionsInStoreHomePage>b__26_4(ProductListingModel l)
		{
			//IL_008d: Expected I4, but got O
			if (l != null)
			{
				if (!l.<isRecurring>k__BackingField || l.<isHidden>k__BackingField)
				{
					return l.isPromotionActive;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <FilterSubscriptionsInStoreHomePage>b__26_2(ProductViewModel p)
		{
			//IL_00cd: Expected I4, but got O
			//IL_00ad: Expected O, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected I4, but got Unknown
			if (p != null)
			{
				List<ProductListingModel> <listings>k__BackingField = p.<listings>k__BackingField;
				if (p.<listings>k__BackingField != null)
				{
					bool flag = <listings>k__BackingField._size < 0;
					bool flag2 = <listings>k__BackingField._size == 0;
					int num = <listings>k__BackingField._size ^ <listings>k__BackingField._size;
					int num2 = <listings>k__BackingField._size & num;
					bool flag3 = num2 < 0;
					bool flag4 = flag == flag3;
					object obj = !flag2;
					return (byte)((flag4 & obj) ? 1 : 0) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <FilterSubscriptionsInStoreHomePage>b__26_3(ProductViewModel p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.<days>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <LoadProducts>b__27_0(ProductViewModel p)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_0081: Expected I, but got O
			//IL_009c: Expected O, but got I
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = p;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3128;
			object obj6 = (nint)0 + (nint)2416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+38]");
			((List<object>)0).ForEach(action);
		}

		internal IEnumerable<ProductListingModel> <GetListing>b__28_0(ProductViewModel p)
		{
			if (p != null)
			{
				return p.<listings>k__BackingField;
			}
			return (IEnumerable<ProductListingModel>)new NullReferenceException();
		}

		internal bool <GetConsumableVersion>b__31_1(ProductListingModel l)
		{
			//IL_0035: Expected I4, but got O
			if (l != null)
			{
				return l.<isConsumable>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public ProductViewModel p;

		internal void <LoadProducts>b__1(ProductListingModel l)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_011f: Expected O, but got I
			//IL_0141: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E708C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+B8]");
			object obj8 = 0;
			Dictionary<object, object> dictionary = (Dictionary<object, object>)obj8;
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a2;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v15+B8]");
			object obj10 = 0;
			dictionary = (Dictionary<object, object>)obj10;
			goto IL_00a2;
			IL_00a2:
			dictionary.set_Item((object)l, (object)p);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public string listingId;

		internal bool <GetListing>b__1(ProductListingModel l)
		{
			//IL_0048: Expected I4, but got O
			if (l != null)
			{
				return l.<listingId>k__BackingField == listingId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public int id;

		internal bool <GetProduct>b__0(ProductViewModel p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.<id>k__BackingField - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public int offerId;

		public Func<Offer, bool> <>9__2;

		public Func<ProductListingModel, bool> <>9__1;

		internal bool <GetProductWithOffer>b__0(ProductViewModel p)
		{
			//IL_00f0: Expected I4, but got O
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0055: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_008d: Expected O, but got I
			//IL_009b: Expected I, but got O
			if (p != null)
			{
				if (p.<listings>k__BackingField != null)
				{
					object obj = this + 32;
					Func<object, bool> predicate = (Func<object, bool>)obj;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj4 = (nint)0 + (nint)2448;
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor((object)this, (IntPtr)obj4);
						<>9__1 = func;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						predicate = func;
					}
					return Enumerable.Any(p.<listings>k__BackingField, predicate);
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetProductWithOffer>b__1(ProductListingModel l)
		{
			//IL_00f0: Expected I4, but got O
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0055: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_008d: Expected O, but got I
			//IL_009b: Expected I, but got O
			if (l != null)
			{
				if (l.<Offers>k__BackingField != null)
				{
					object obj = this + 24;
					Func<object, bool> predicate = (Func<object, bool>)obj;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2624;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj4 = (nint)0 + (nint)2456;
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor((object)this, (IntPtr)obj4);
						<>9__2 = func;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						predicate = func;
					}
					return Enumerable.Any(l.<Offers>k__BackingField, predicate);
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetProductWithOffer>b__2(Offer o)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (o != null)
			{
				object obj = o.<Id>k__BackingField - offerId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass31_0
	{
		public ProductListingModel originalListing;

		internal bool <GetConsumableVersion>b__0(ProductViewModel p)
		{
			//IL_0053: Expected I4, but got O
			if (p != null && p.<listings>k__BackingField != null)
			{
				return ((List<object>)(object)p.<listings>k__BackingField).Contains((object)originalListing);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static readonly Dictionary<ProductListingModel, ProductViewModel> ListingToProductMap;

	private static IEnumerable<ProductViewModel> <Products>k__BackingField;

	private static IEnumerable<ProductViewModel> Products
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7077]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (IEnumerable<ProductViewModel>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (IEnumerable<ProductViewModel>)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private IEnumerable<ProductViewModel> AllProducts
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0132: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01b8: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_017a: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0102: Expected O, but got I
			//IL_01f0: Expected O, but got I
			//IL_01fd: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0188;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+8]");
			return (IEnumerable<ProductViewModel>)0;
			IL_01ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+8]");
			return (IEnumerable<ProductViewModel>)0;
			IL_00b0:
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = obj11;
			if (!flag3)
			{
				goto IL_00e5;
			}
			goto IL_01ce;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00b0;
			}
			goto IL_0188;
			IL_0188:
			_ = 1;
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj12 = obj11;
			if (obj14 != null)
			{
				goto IL_00e5;
			}
			goto IL_01ce;
		}
	}

	private IEnumerable<ProductViewModel> PurchasableProducts
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0185: Expected O, but got I
			//IL_019f: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_021b: Expected O, but got I
			//IL_0235: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_00d6: Expected O, but got I
			//IL_02bb: Expected O, but got I
			//IL_02cb: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_027b: Expected O, but got I4
			//IL_0140: Expected O, but got I
			//IL_0150: Expected O, but got I
			//IL_0316: Expected O, but got I
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7202]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj3 = obj5;
			if (obj9 != null)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_0130:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+8]");
			IEnumerable<ProductViewModel> products = (IEnumerable<ProductViewModel>)0;
			goto IL_0324;
			IL_0324:
			return FilterOutHidden(products);
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
			products = (IEnumerable<ProductViewModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
				return FilterOutHidden((IEnumerable<ProductViewModel>)0);
			}
			goto IL_0324;
			IL_008b:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			obj5 = obj3;
			if (!flag5)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_01fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj14 = (nint)0 & (nint)1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			obj3 = obj5;
			if (obj15 != null)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_00c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj16 = (nint)0 & (nint)1;
			bool flag7 = obj16 == null;
			obj5 = obj3;
			if (!flag7)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_024b:
			_ = 1;
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			object obj19 = obj17;
			obj3 = obj5;
			if (obj18 != null)
			{
				goto IL_0130;
			}
			goto IL_0299;
			IL_00fb:
			obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag9 = (nint)0 == 0;
			obj19 = obj17;
			if (!flag9)
			{
				goto IL_0130;
			}
			goto IL_0299;
		}
	}

	public IEnumerable<ProductViewModel> AllRecurringSubscriptions
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0185: Expected O, but got I
			//IL_019f: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_021b: Expected O, but got I
			//IL_0235: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_00d6: Expected O, but got I
			//IL_02bb: Expected O, but got I
			//IL_02cb: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_027b: Expected O, but got I4
			//IL_0140: Expected O, but got I
			//IL_0150: Expected O, but got I
			//IL_0316: Expected O, but got I
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7203]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj3 = obj5;
			if (obj9 != null)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_0130:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+8]");
			IEnumerable<ProductViewModel> products = (IEnumerable<ProductViewModel>)0;
			goto IL_0324;
			IL_0324:
			return FilterRecurring(products);
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
			products = (IEnumerable<ProductViewModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
				return FilterRecurring((IEnumerable<ProductViewModel>)0);
			}
			goto IL_0324;
			IL_008b:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			obj5 = obj3;
			if (!flag5)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_01fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj14 = (nint)0 & (nint)1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			obj3 = obj5;
			if (obj15 != null)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_00c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj16 = (nint)0 & (nint)1;
			bool flag7 = obj16 == null;
			obj5 = obj3;
			if (!flag7)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_024b:
			_ = 1;
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			object obj19 = obj17;
			obj3 = obj5;
			if (obj18 != null)
			{
				goto IL_0130;
			}
			goto IL_0299;
			IL_00fb:
			obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag9 = (nint)0 == 0;
			obj19 = obj17;
			if (!flag9)
			{
				goto IL_0130;
			}
			goto IL_0299;
		}
	}

	public IEnumerable<ProductViewModel> AllConsumables
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0185: Expected O, but got I
			//IL_019f: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_021b: Expected O, but got I
			//IL_0235: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_00d6: Expected O, but got I
			//IL_02bb: Expected O, but got I
			//IL_02cb: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_027b: Expected O, but got I4
			//IL_0140: Expected O, but got I
			//IL_0150: Expected O, but got I
			//IL_0316: Expected O, but got I
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7204]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj3 = obj5;
			if (obj9 != null)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_0130:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+8]");
			IEnumerable<ProductViewModel> products = (IEnumerable<ProductViewModel>)0;
			goto IL_0324;
			IL_0324:
			return FilterConsumable(products);
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
			products = (IEnumerable<ProductViewModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
				return FilterConsumable((IEnumerable<ProductViewModel>)0);
			}
			goto IL_0324;
			IL_008b:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			obj5 = obj3;
			if (!flag5)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_01fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj14 = (nint)0 & (nint)1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			obj3 = obj5;
			if (obj15 != null)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_00c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj16 = (nint)0 & (nint)1;
			bool flag7 = obj16 == null;
			obj5 = obj3;
			if (!flag7)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_024b:
			_ = 1;
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			object obj19 = obj17;
			obj3 = obj5;
			if (obj18 != null)
			{
				goto IL_0130;
			}
			goto IL_0299;
			IL_00fb:
			obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag9 = (nint)0 == 0;
			obj19 = obj17;
			if (!flag9)
			{
				goto IL_0130;
			}
			goto IL_0299;
		}
	}

	public IEnumerable<ProductViewModel> RecurringSubscriptions
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00f7: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7079]");
			object obj3 = (nint)0 & (nint)1;
			IEnumerable<ProductViewModel> purchasableProducts;
			IEnumerable<ProductViewModel> products;
			if (obj3 != null)
			{
				purchasableProducts = PurchasableProducts;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2+E4]");
				bool flag = (nint)0 == 0;
				products = purchasableProducts;
				if (!flag)
				{
					goto IL_008f;
				}
			}
			else
			{
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				_ = 1;
				purchasableProducts = ((ProductStore)obj5).PurchasableProducts;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				products = purchasableProducts;
				if (obj6 != null)
				{
					goto IL_008f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FilterRecurring(products);
			IL_008f:
			return FilterRecurring(purchasableProducts);
		}
	}

	public IEnumerable<ProductViewModel> ConsumableSubscriptions
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_012c: Expected O, but got I4
			//IL_0146: Expected O, but got I
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_016a: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_019c: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_01d4: Expected O, but got I
			//IL_01e5: Expected I, but got O
			//IL_0203: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
			IEnumerable<ProductViewModel> purchasableProducts = PurchasableProducts;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = (nint)0 + (nint)3696;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v13+B8]");
					obj6 = 0;
				}
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)2384;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj6, (IntPtr)obj11);
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v12+B8]");
				object obj13 = (nint)0 + (nint)8;
				obj13 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> products = Enumerable.Where(purchasableProducts, predicate);
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				return FilterConsumable((IEnumerable<ProductViewModel>)products);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FilterConsumable((IEnumerable<ProductViewModel>)products);
		}
	}

	public IEnumerable<ProductViewModel> GoldenCards
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected O, but got Unknown
			//IL_0166: Expected O, but got I4
			//IL_00ab: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_00cb: Expected O, but got I
			//IL_00ed: Expected O, but got I4
			//IL_01aa: Expected O, but got I
			//IL_01ba: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01ec: Expected O, but got I4
			//IL_0326: Expected O, but got I
			//IL_0336: Expected O, but got I
			//IL_0346: Expected O, but got I
			//IL_0368: Expected O, but got I4
			//IL_022c: Expected O, but got I4
			//IL_02ab: Expected O, but got I
			//IL_02bb: Expected O, but got I
			//IL_02cb: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected O, but got Unknown
			//IL_0415: Expected O, but got I
			//IL_0426: Expected I, but got O
			//IL_0444: Expected O, but got I
			//IL_03a0: Expected O, but got I4
			//IL_025c: Expected O, but got I
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Expected O, but got Unknown
			//IL_049d: Expected O, but got I
			//IL_04ae: Expected I, but got O
			//IL_04cc: Expected O, but got I
			//IL_03d0: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E707B]");
			object obj3 = (nint)0 & (nint)1;
			IEnumerable<ProductViewModel> enumerable;
			IEnumerable<ProductViewModel> enumerable2;
			object obj4;
			if (obj3 != null)
			{
				IEnumerable<ProductViewModel> purchasableProducts = PurchasableProducts;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18+E4]");
				bool flag = (nint)0 == 0;
				enumerable = purchasableProducts;
				object obj5 = obj4;
				enumerable2 = purchasableProducts;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				object obj6 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
				_ = 1;
				IEnumerable<ProductViewModel> purchasableProducts2 = ((ProductStore)obj6).PurchasableProducts;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				enumerable = purchasableProducts2;
				object obj5 = obj4;
				enumerable2 = purchasableProducts2;
				if (obj7 != null)
				{
					goto IL_009f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj8 = (nint)0 + (nint)3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v17+10]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v17+10]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj11 = obj8;
			enumerable = enumerable2;
			if (obj10 == null)
			{
				goto IL_020a;
			}
			goto IL_0261;
			IL_037e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj14;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v12+B8]");
				obj14 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)2400;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj14, (IntPtr)obj16);
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v11+B8]");
			object obj18 = (nint)0 + (nint)24;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Func<object, int> keySelector = func;
			object obj20;
			object obj19 = obj20;
			goto IL_03d5;
			IL_03d5:
			IEnumerable<object> source;
			return (IEnumerable<ProductViewModel>)Enumerable.OrderBy(source, keySelector);
			IL_020a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v23+B8]");
				obj9 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)2392;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj9, (IntPtr)obj24);
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v22+B8]");
			object obj26 = (nint)0 + (nint)16;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func2;
			obj11 = obj8;
			enumerable = enumerable2;
			goto IL_0261;
			IL_009f:
			obj11 = (nint)0 + (nint)3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v17+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v17+10]");
			bool flag6 = (nint)0 == 0;
			object obj27 = !flag6;
			if (obj27 == null)
			{
				obj8 = obj11;
				enumerable2 = enumerable;
				goto IL_020a;
			}
			goto IL_0261;
			IL_0261:
			source = Enumerable.Where(enumerable, predicate);
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				obj19 = (nint)0 + (nint)2184;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v8+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6+18]");
				keySelector = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6+18]");
				bool flag7 = (nint)0 == 0;
				object obj29 = !flag7;
				if (obj29 == null)
				{
					obj20 = obj19;
					goto IL_037e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj28 = obj2;
				obj20 = (nint)0 + (nint)2184;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v8+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6+18]");
				keySelector = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6+18]");
				bool flag8 = (nint)0 == 0;
				object obj30 = !flag8;
				obj19 = obj20;
				if (obj30 == null)
				{
					goto IL_037e;
				}
			}
			goto IL_03d5;
		}
	}

	public IEnumerable<ProductViewModel> SubscriptionsInStoreHomePage
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0185: Expected O, but got I
			//IL_019f: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_021b: Expected O, but got I
			//IL_0235: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_00d6: Expected O, but got I
			//IL_02bb: Expected O, but got I
			//IL_02cb: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_027b: Expected O, but got I4
			//IL_0140: Expected O, but got I
			//IL_0150: Expected O, but got I
			//IL_0316: Expected O, but got I
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7205]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj3 = obj5;
			if (obj9 != null)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_0130:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+8]");
			IEnumerable<ProductViewModel> products = (IEnumerable<ProductViewModel>)0;
			goto IL_0324;
			IL_0324:
			return FilterSubscriptionsInStoreHomePage(products);
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
			products = (IEnumerable<ProductViewModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v2+8]");
				return FilterSubscriptionsInStoreHomePage((IEnumerable<ProductViewModel>)0);
			}
			goto IL_0324;
			IL_008b:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			obj5 = obj3;
			if (!flag5)
			{
				goto IL_00c0;
			}
			goto IL_01fb;
			IL_01fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj14 = (nint)0 & (nint)1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			obj3 = obj5;
			if (obj15 != null)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_00c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj16 = (nint)0 & (nint)1;
			bool flag7 = obj16 == null;
			obj5 = obj3;
			if (!flag7)
			{
				goto IL_00fb;
			}
			goto IL_024b;
			IL_024b:
			_ = 1;
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			object obj19 = obj17;
			obj3 = obj5;
			if (obj18 != null)
			{
				goto IL_0130;
			}
			goto IL_0299;
			IL_00fb:
			obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v25+E4]");
			bool flag9 = (nint)0 == 0;
			obj19 = obj17;
			if (!flag9)
			{
				goto IL_0130;
			}
			goto IL_0299;
		}
	}

	public IEnumerable<ProductViewModel> GoldenCardsIncludingHidden
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Expected O, but got Unknown
			//IL_027a: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0066: Expected O, but got I
			//IL_0310: Expected O, but got I
			//IL_032a: Expected O, but got I4
			//IL_02da: Expected O, but got I4
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected O, but got Unknown
			//IL_00d6: Expected O, but got I
			//IL_03cc: Expected O, but got I
			//IL_03dc: Expected O, but got I
			//IL_0406: Expected O, but got I4
			//IL_042e: Expected O, but got I
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected O, but got Unknown
			//IL_0384: Expected O, but got I4
			//IL_01d5: Expected O, but got I
			//IL_01e5: Expected O, but got I
			//IL_01f5: Expected O, but got I
			//IL_0217: Expected O, but got I4
			//IL_0164: Expected O, but got I
			//IL_0174: Expected O, but got I
			//IL_01bb: Expected O, but got I
			//IL_045a: Expected O, but got I
			//IL_046a: Expected O, but got I
			//IL_047a: Expected O, but got I
			//IL_049c: Expected O, but got I4
			//IL_04e4: Expected O, but got I4
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Expected O, but got Unknown
			//IL_05b4: Expected O, but got I
			//IL_05c5: Expected I, but got O
			//IL_05e3: Expected O, but got I
			//IL_0514: Expected O, but got I
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7206]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v30+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj3 = obj5;
			if (obj9 != null)
			{
				goto IL_00c0;
			}
			goto IL_02f0;
			IL_04c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			object obj12;
			object obj13;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11+B8]");
				obj13 = 0;
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)2408;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj13, (IntPtr)obj15);
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v10+B8]");
			object obj17 = (nint)0 + (nint)32;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Func<object, bool> predicate = func;
			object obj19;
			object obj18 = obj19;
			obj3 = obj5;
			IEnumerable<object> enumerable2;
			IEnumerable<object> enumerable = enumerable2;
			goto IL_0519;
			IL_0519:
			IEnumerable<object> products = Enumerable.Where(enumerable, predicate);
			object obj20 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				return FilterConsumable((IEnumerable<ProductViewModel>)products);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FilterConsumable((IEnumerable<ProductViewModel>)products);
			IL_01c9:
			obj18 = (nint)0 + (nint)3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v10+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v5+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v5+20]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			object obj22;
			if (obj21 == null)
			{
				obj19 = obj18;
				obj12 = obj22;
				obj5 = obj3;
				enumerable2 = enumerable;
				goto IL_04c2;
			}
			goto IL_0519;
			IL_008b:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v30+E4]");
			bool flag6 = (nint)0 == 0;
			obj5 = obj3;
			if (!flag6)
			{
				goto IL_00c0;
			}
			goto IL_02f0;
			IL_02f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj23 = (nint)0 & (nint)1;
			bool flag7 = obj23 == null;
			object obj24 = !flag7;
			obj3 = obj5;
			if (obj24 != null)
			{
				goto IL_00fb;
			}
			goto IL_0340;
			IL_00c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj25 = (nint)0 & (nint)1;
			bool flag8 = obj25 == null;
			obj5 = obj3;
			if (!flag8)
			{
				goto IL_00fb;
			}
			goto IL_0340;
			IL_0340:
			_ = 1;
			obj22 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
			object obj26 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v53+E4]");
			bool flag9 = (nint)0 == 0;
			object obj27 = !flag9;
			obj3 = obj5;
			obj12 = obj22;
			object obj28 = obj26;
			if (obj27 != null)
			{
				goto IL_0154;
			}
			goto IL_03aa;
			IL_00fb:
			obj22 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
			obj26 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v53+E4]");
			bool flag10 = (nint)0 == 0;
			obj12 = obj22;
			obj28 = obj26;
			obj5 = obj3;
			if (!flag10)
			{
				goto IL_0154;
			}
			goto IL_03aa;
			IL_03aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v23+B8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16+8]");
			enumerable = (IEnumerable<object>)0;
			object obj31 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v10+E4]");
			bool flag11 = (nint)0 == 0;
			object obj32 = !flag11;
			obj22 = obj12;
			obj3 = obj5;
			object obj33 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (obj32 != null)
			{
				goto IL_01c9;
			}
			goto IL_043c;
			IL_0154:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v53+B8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v31+8]");
			enumerable = (IEnumerable<object>)0;
			obj31 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v10+E4]");
			bool flag12 = (nint)0 == 0;
			obj12 = obj22;
			obj33 = obj31;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v31+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (!flag12)
			{
				goto IL_01c9;
			}
			goto IL_043c;
			IL_043c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj12;
			obj19 = (nint)0 + (nint)3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v10+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v5+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v5+20]");
			bool flag13 = (nint)0 == 0;
			object obj35 = !flag13;
			obj18 = obj19;
			obj3 = obj5;
			enumerable = enumerable2;
			if (obj35 == null)
			{
				goto IL_04c2;
			}
			goto IL_0519;
		}
	}

	private static IEnumerable<ProductViewModel> FilterOutHidden(IEnumerable<ProductViewModel> products)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_0372: Expected O, but got I
		//IL_0382: Expected O, but got I
		//IL_03a4: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_031b: Expected I, but got O
		//IL_0339: Expected O, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03dc: Expected O, but got I
		//IL_03ed: Expected I, but got O
		//IL_040b: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_02b3: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E707C]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v19+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+30]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+30]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v21+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2256;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v20+B8]");
		object obj16 = (nint)0 + (nint)48;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		selector = func;
		goto IL_0201;
		IL_0201:
		IEnumerable<object> source = Enumerable.Select(products, selector);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v6+38]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v6+38]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v12+B8]");
				obj19 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)2264;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj19, (IntPtr)obj24);
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11+B8]");
			object obj26 = (nint)0 + (nint)56;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func2;
		}
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		return (IEnumerable<ProductViewModel>)Enumerable.ToList(source2);
		IL_0085:
		obj10 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v19+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+30]");
		selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+30]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}

	private static IEnumerable<ProductViewModel> FilterRecurring(IEnumerable<ProductViewModel> products)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_02c6: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0308: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_042a: Expected O, but got I
		//IL_043a: Expected O, but got I
		//IL_045c: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05ca: Expected O, but got I
		//IL_05db: Expected I, but got O
		//IL_05f9: Expected O, but got I
		//IL_0614: Expected O, but got I4
		//IL_04fc: Expected O, but got I4
		//IL_03c3: Expected O, but got I
		//IL_03d3: Expected O, but got I
		//IL_03f5: Expected O, but got I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0653: Expected O, but got I
		//IL_0664: Expected I, but got O
		//IL_0682: Expected O, but got I
		//IL_06a5: Expected O, but got I4
		//IL_01fc: Expected O, but got I
		//IL_0745: Expected O, but got I
		//IL_0755: Expected O, but got I
		//IL_0777: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_06dc: Expected O, but got I
		//IL_06ed: Expected I, but got O
		//IL_070b: Expected O, but got I
		//IL_0726: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_04bc: Expected O, but got I
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected O, but got Unknown
		//IL_07af: Expected O, but got I
		//IL_07c0: Expected I, but got O
		//IL_07de: Expected O, but got I
		//IL_0573: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E707D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+40]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+40]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_04c1:
		IEnumerable<object> source2;
		Func<object, bool> predicate2;
		IEnumerable<object> source = Enumerable.Where(source2, predicate2);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v10+60]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v10+60]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v16+B8]");
				obj13 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)2304;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj13, (IntPtr)obj18);
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v15+B8]");
			object obj20 = (nint)0 + (nint)96;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func;
		}
		IOrderedEnumerable<object> source3 = Enumerable.OrderBy(source, keySelector);
		return (IEnumerable<ProductViewModel>)Enumerable.ToList(source3);
		IL_0201:
		IEnumerable<object> source4 = Enumerable.Where(products, predicate);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+E4]");
		object obj23;
		Func<object, object> selector;
		object obj25;
		object obj22;
		if ((nint)0 != 0)
		{
			obj22 = (nint)0 + (nint)3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+50]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+50]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				obj25 = obj22;
				goto IL_031e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
			obj25 = (nint)0 + (nint)3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+50]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+50]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			obj22 = obj25;
			if (obj26 == null)
			{
				goto IL_031e;
			}
		}
		goto IL_0375;
		IL_0375:
		source2 = Enumerable.Select(source4, selector);
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+E4]");
		object obj28;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+58]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+58]");
			bool flag9 = (nint)0 == 0;
			object obj29 = !flag9;
			if (obj29 == null)
			{
				goto IL_046a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+58]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+58]");
			bool flag10 = (nint)0 == 0;
			object obj30 = !flag10;
			if (obj30 == null)
			{
				goto IL_046a;
			}
		}
		goto IL_04c1;
		IL_0085:
		obj10 = (nint)0 + (nint)3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+40]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+40]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
		IL_046a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+E4]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v25+B8]");
			obj28 = 0;
		}
		object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2296;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj28, (IntPtr)obj35);
		object obj36 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v24+B8]");
		object obj37 = (nint)0 + (nint)88;
		obj37 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj38 = 0;
		predicate2 = func2;
		goto IL_04c1;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
		bool flag13 = (nint)0 == 0;
		object obj39 = !flag13;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj40 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v47+B8]");
			obj8 = 0;
		}
		object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)2280;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj8, (IntPtr)obj42);
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v46+B8]");
		object obj44 = (nint)0 + (nint)64;
		obj44 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj38 = 0;
		obj10 = obj7;
		predicate = func3;
		goto IL_0201;
		IL_031e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj46 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v36+B8]");
			obj23 = 0;
		}
		object obj47 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)2288;
		Func<object, object> func4 = default(Func<object, object>);
		func4..ctor(obj23, (IntPtr)obj48);
		object obj49 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v35+B8]");
		object obj50 = (nint)0 + (nint)80;
		obj50 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj22 = obj25;
		obj38 = 0;
		selector = func4;
		goto IL_0375;
	}

	private static IEnumerable<ProductViewModel> FilterConsumable(IEnumerable<ProductViewModel> products)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_02c6: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0308: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_043a: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_045a: Expected O, but got I
		//IL_047c: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05f2: Expected O, but got I
		//IL_0603: Expected I, but got O
		//IL_0621: Expected O, but got I
		//IL_063c: Expected O, but got I4
		//IL_0524: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03df: Expected O, but got I
		//IL_0401: Expected O, but got I4
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_067b: Expected O, but got I
		//IL_068c: Expected I, but got O
		//IL_06aa: Expected O, but got I
		//IL_06c5: Expected O, but got I4
		//IL_01fc: Expected O, but got I
		//IL_0775: Expected O, but got I
		//IL_0785: Expected O, but got I
		//IL_07a7: Expected O, but got I4
		//IL_04b4: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_0704: Expected O, but got I
		//IL_0715: Expected I, but got O
		//IL_0733: Expected O, but got I
		//IL_074e: Expected O, but got I4
		//IL_056b: Expected O, but got I4
		//IL_04e4: Expected O, but got I
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected O, but got Unknown
		//IL_07df: Expected O, but got I
		//IL_07f0: Expected I, but got O
		//IL_080e: Expected O, but got I
		//IL_059b: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E707E]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+70]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+70]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_0492:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v25+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2232;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v24+B8]");
		object obj17 = (nint)0 + (nint)128;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		object obj20;
		object obj19 = obj20;
		Func<object, int> keySelector = func;
		goto IL_04e9;
		IL_0201:
		IEnumerable<object> source = Enumerable.Select(products, selector);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+E4]");
		object obj23;
		Func<object, bool> predicate;
		object obj25;
		object obj22;
		if ((nint)0 != 0)
		{
			obj22 = (nint)0 + (nint)3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+78]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+78]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			if (obj24 == null)
			{
				obj25 = obj22;
				goto IL_031e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
			obj25 = (nint)0 + (nint)3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+78]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+78]");
			bool flag6 = (nint)0 == 0;
			object obj26 = !flag6;
			obj22 = obj25;
			if (obj26 == null)
			{
				goto IL_031e;
			}
		}
		goto IL_0375;
		IL_0375:
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			obj19 = (nint)0 + (nint)2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v27+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+80]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+80]");
			bool flag7 = (nint)0 == 0;
			object obj28 = !flag7;
			if (obj28 == null)
			{
				obj20 = obj19;
				goto IL_0492;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
			obj20 = (nint)0 + (nint)2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v27+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+80]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v19+80]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			obj19 = obj20;
			if (obj29 == null)
			{
				goto IL_0492;
			}
		}
		goto IL_04e9;
		IL_0085:
		obj10 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+70]");
		selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+70]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
		IL_04e9:
		IOrderedEnumerable<object> source3 = Enumerable.OrderBy(source2, keySelector);
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v13+E4]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v13+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v10+88]");
		Func<object, int> keySelector2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v10+88]");
		bool flag11 = (nint)0 == 0;
		object obj34 = !flag11;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v13+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = !flag12;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v16+B8]");
				obj33 = 0;
			}
			object obj37 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj38 = (nint)0 + (nint)2240;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj33, (IntPtr)obj38);
			object obj39 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+B8]");
			object obj40 = (nint)0 + (nint)136;
			obj40 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector2 = func2;
		}
		IOrderedEnumerable<object> source4 = Enumerable.ThenBy(source3, keySelector2);
		return (IEnumerable<ProductViewModel>)Enumerable.ToList(source4);
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
		bool flag13 = (nint)0 == 0;
		object obj41 = !flag13;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj42 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v47+B8]");
			obj8 = 0;
		}
		object obj43 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj44 = (nint)0 + (nint)2216;
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor(obj8, (IntPtr)obj44);
		object obj45 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v46+B8]");
		object obj46 = (nint)0 + (nint)112;
		obj46 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		obj10 = obj7;
		selector = func3;
		goto IL_0201;
		IL_031e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+E4]");
		bool flag14 = (nint)0 == 0;
		object obj47 = !flag14;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj48 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v36+B8]");
			obj23 = 0;
		}
		object obj49 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)2224;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj23, (IntPtr)obj50);
		object obj51 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v35+B8]");
		object obj52 = (nint)0 + (nint)120;
		obj52 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		obj22 = obj25;
		predicate = func4;
		goto IL_0375;
	}

	private static IEnumerable<ProductViewModel> FilterSubscriptionsInStoreHomePage(IEnumerable<ProductViewModel> products)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_02c6: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0308: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_042a: Expected O, but got I
		//IL_043a: Expected O, but got I
		//IL_045c: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05ca: Expected O, but got I
		//IL_05db: Expected I, but got O
		//IL_05f9: Expected O, but got I
		//IL_0614: Expected O, but got I4
		//IL_04fc: Expected O, but got I4
		//IL_03c3: Expected O, but got I
		//IL_03d3: Expected O, but got I
		//IL_03f5: Expected O, but got I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0653: Expected O, but got I
		//IL_0664: Expected I, but got O
		//IL_0682: Expected O, but got I
		//IL_06a5: Expected O, but got I4
		//IL_01fc: Expected O, but got I
		//IL_0745: Expected O, but got I
		//IL_0755: Expected O, but got I
		//IL_0777: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_06dc: Expected O, but got I
		//IL_06ed: Expected I, but got O
		//IL_070b: Expected O, but got I
		//IL_0726: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_04bc: Expected O, but got I
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected O, but got Unknown
		//IL_07af: Expected O, but got I
		//IL_07c0: Expected I, but got O
		//IL_07de: Expected O, but got I
		//IL_0573: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E707F]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+90]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+90]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_04c1:
		IEnumerable<object> source2;
		Func<object, bool> predicate2;
		IEnumerable<object> source = Enumerable.Where(source2, predicate2);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v10+B0]");
		Func<object, int> keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v10+B0]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v16+B8]");
				obj13 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)2344;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj13, (IntPtr)obj18);
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v15+B8]");
			object obj20 = (nint)0 + (nint)176;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func;
		}
		IOrderedEnumerable<object> source3 = Enumerable.OrderBy(source, keySelector);
		return (IEnumerable<ProductViewModel>)Enumerable.ToList(source3);
		IL_0201:
		IEnumerable<object> source4 = Enumerable.Where(products, predicate);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+E4]");
		object obj23;
		Func<object, object> selector;
		object obj25;
		object obj22;
		if ((nint)0 != 0)
		{
			obj22 = (nint)0 + (nint)3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+A0]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+A0]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				obj25 = obj22;
				goto IL_031e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
			obj25 = (nint)0 + (nint)3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+A0]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v30+A0]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			obj22 = obj25;
			if (obj26 == null)
			{
				goto IL_031e;
			}
		}
		goto IL_0375;
		IL_0375:
		source2 = Enumerable.Select(source4, selector);
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+E4]");
		object obj28;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+A8]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+A8]");
			bool flag9 = (nint)0 == 0;
			object obj29 = !flag9;
			if (obj29 == null)
			{
				goto IL_046a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+A8]");
			predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+A8]");
			bool flag10 = (nint)0 == 0;
			object obj30 = !flag10;
			if (obj30 == null)
			{
				goto IL_046a;
			}
		}
		goto IL_04c1;
		IL_0085:
		obj10 = (nint)0 + (nint)3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+90]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v41+90]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
		IL_046a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v27+E4]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v25+B8]");
			obj28 = 0;
		}
		object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2336;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj28, (IntPtr)obj35);
		object obj36 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v24+B8]");
		object obj37 = (nint)0 + (nint)168;
		obj37 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj38 = 0;
		predicate2 = func2;
		goto IL_04c1;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v47+E4]");
		bool flag13 = (nint)0 == 0;
		object obj39 = !flag13;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj40 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v47+B8]");
			obj8 = 0;
		}
		object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)2320;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj8, (IntPtr)obj42);
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v46+B8]");
		object obj44 = (nint)0 + (nint)144;
		obj44 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj38 = 0;
		obj10 = obj7;
		predicate = func3;
		goto IL_0201;
		IL_031e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v37+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj46 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v36+B8]");
			obj23 = 0;
		}
		object obj47 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)2328;
		Func<object, object> func4 = default(Func<object, object>);
		func4..ctor(obj23, (IntPtr)obj48);
		object obj49 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v35+B8]");
		object obj50 = (nint)0 + (nint)160;
		obj50 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj22 = obj25;
		obj38 = 0;
		selector = func4;
		goto IL_0375;
	}

	public static void LoadProducts(IEnumerable<ProductViewModel> products)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0221: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_0309: Expected O, but got I4
		//IL_0172: Expected O, but got I
		//IL_018c: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00d7: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_026a: Expected I, but got O
		//IL_0288: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_013f: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)2272;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+B8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+B8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v22+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2376;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v21+B8]");
			object obj13 = (nint)0 + (nint)184;
			obj13 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		ArraysExtensions.ForEach(products, action);
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C3]");
			object obj15 = (nint)0 & (nint)1;
			if (obj15 != null)
			{
				goto IL_00f4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C3]");
			object obj16 = (nint)0 & (nint)1;
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			if (obj17 != null)
			{
				goto IL_00f4;
			}
		}
		_ = 1;
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		object obj20 = obj18;
		if (obj19 != null)
		{
			goto IL_0129;
		}
		goto IL_01e0;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj18 = obj5;
		goto IL_0129;
		IL_00f4:
		obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		obj20 = obj18;
		if (!flag6)
		{
			goto IL_0129;
		}
		goto IL_01e0;
		IL_0129:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v16+B8]");
		object obj21 = (nint)0 + (nint)8;
		obj21 = products;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ProductListingModel GetListing(string listingId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Expected O, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_03ad: Expected O, but got I4
		//IL_00cc: Expected O, but got I
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_0447: Expected O, but got I4
		//IL_03db: Expected O, but got I
		//IL_03f5: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0487: Expected O, but got I
		//IL_0497: Expected O, but got I
		//IL_04c1: Expected O, but got I4
		//IL_04e1: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0216: Expected O, but got I4
		//IL_02ac: Expected I, but got O
		//IL_0246: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_057e: Expected O, but got I
		//IL_058f: Expected I, but got O
		//IL_05ad: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0350: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = obj2 + 16;
			obj3 = listingId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = 152989696;
			obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00b6;
				}
			}
			else
			{
				_ = 1;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 != null)
				{
					goto IL_00b6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj9 = (nint)0 & (nint)1;
			bool flag2 = obj9 == null;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				goto IL_00e9;
			}
			goto IL_0403;
		}
		return (ProductListingModel)(object)new NullReferenceException();
		IL_0465:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v6+8]");
		IEnumerable<object> source = (IEnumerable<object>)0;
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v25+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		object obj16 = obj14;
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v6+8]");
		IEnumerable<object> enumerable = (IEnumerable<object>)0;
		if (obj15 != null)
		{
			goto IL_01a7;
		}
		goto IL_04ef;
		IL_00e9:
		obj16 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v48+E4]");
		bool flag4 = (nint)0 == 0;
		obj14 = obj16;
		object obj19 = obj18;
		if (!flag4)
		{
			goto IL_013a;
		}
		goto IL_0465;
		IL_01a7:
		object obj20 = (nint)0 + (nint)360;
		object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
		object obj22 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v25+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v24+C0]");
		Func<object, IEnumerable<object>> selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v24+C0]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v25+E4]");
			bool flag6 = (nint)0 == 0;
			object obj25 = !flag6;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v30+B8]");
				obj23 = 0;
			}
			object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)2368;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj23, (IntPtr)obj28);
			object obj29 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v29+B8]");
			object obj30 = (nint)0 + (nint)192;
			obj30 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = (Func<object, IEnumerable<object>>)func;
		}
		IEnumerable<object> source2 = Enumerable.SelectMany(source, selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj2, (IntPtr)obj22);
		object obj31 = Enumerable.FirstOrDefault(source2, func2);
		bool flag7 = obj31 == null;
		object obj32 = !flag7;
		ProductListingModel result = (ProductListingModel)obj31;
		if (obj32 == null)
		{
			object obj33 = "Complete" + 2680;
			string text = (string)obj33 + (string)obj3;
			object obj34 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj36 = !flag8;
			object obj37 = text;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj37 = text;
			}
			KLogger.LogError(obj37);
			result = (ProductListingModel)obj31;
		}
		return result;
		IL_04ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj14;
		obj16 = obj14;
		source = enumerable;
		goto IL_01a7;
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v48+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v33+8]");
		source = (IEnumerable<object>)0;
		obj13 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v25+E4]");
		bool flag9 = (nint)0 == 0;
		obj14 = obj16;
		obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v33+8]");
		enumerable = (IEnumerable<object>)0;
		if (!flag9)
		{
			goto IL_01a7;
		}
		goto IL_04ef;
		IL_00b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
		object obj39 = (nint)0 & (nint)1;
		if (obj39 != null)
		{
			goto IL_00e9;
		}
		goto IL_0403;
		IL_0403:
		_ = 1;
		obj16 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v48+E4]");
		bool flag10 = (nint)0 == 0;
		object obj40 = !flag10;
		obj14 = obj16;
		obj19 = obj18;
		if (obj40 != null)
		{
			goto IL_013a;
		}
		goto IL_0465;
	}

	public ProductViewModel GetProduct(int id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Expected O, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I
		//IL_02b1: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_0307: Expected O, but got I
		//IL_0322: Expected I, but got O
		//IL_0337: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_021a: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj4;
		if (obj2 != null)
		{
			object obj3 = 152989696;
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					goto IL_009b;
				}
			}
			else
			{
				_ = 1;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v23+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 != null)
				{
					goto IL_009b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 == null)
			{
				goto IL_00d9;
			}
			goto IL_0285;
		}
		return (ProductViewModel)(object)new NullReferenceException();
		IL_009b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
		object obj9 = (nint)0 & (nint)1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			goto IL_00d9;
		}
		goto IL_0285;
		IL_00d9:
		_ = 1;
		goto IL_0285;
		IL_0285:
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		object obj12 = (nint)0 + (nint)2432;
		object obj13 = (nint)0 + (nint)1080;
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v7+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v6+8]");
		ProductViewModel productViewModel = (ProductViewModel)Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
		if (productViewModel != null)
		{
			return productViewModel;
		}
		object obj17 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "Complete" + 2688;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		object obj21 = text;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = text;
		}
		KLogger.LogError(obj21);
		return productViewModel;
	}

	public ProductViewModel GetProductWithOffer(int offerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Expected O, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I
		//IL_02b1: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_0307: Expected O, but got I
		//IL_0322: Expected I, but got O
		//IL_0337: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_021a: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj4;
		if (obj2 != null)
		{
			object obj3 = 152989696;
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					goto IL_009b;
				}
			}
			else
			{
				_ = 1;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v23+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 != null)
				{
					goto IL_009b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 == null)
			{
				goto IL_00d9;
			}
			goto IL_0285;
		}
		return (ProductViewModel)(object)new NullReferenceException();
		IL_009b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
		object obj9 = (nint)0 & (nint)1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			goto IL_00d9;
		}
		goto IL_0285;
		IL_00d9:
		_ = 1;
		goto IL_0285;
		IL_0285:
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		object obj12 = (nint)0 + (nint)2440;
		object obj13 = (nint)0 + (nint)1080;
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v7+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v6+8]");
		ProductViewModel productViewModel = (ProductViewModel)Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
		if (productViewModel != null)
		{
			return productViewModel;
		}
		object obj17 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "Complete" + 2448;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		object obj21 = text;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = text;
		}
		KLogger.LogError(obj21);
		return productViewModel;
	}

	public ProductListingModel GetConsumableVersion(ProductListingModel originalListing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_02d5: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_035b: Expected O, but got I4
		//IL_0303: Expected O, but got I
		//IL_031d: Expected O, but got I4
		//IL_0180: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_01bb: Expected I, but got O
		//IL_01cc: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I
		//IL_03ba: Expected O, but got I
		//IL_03dc: Expected O, but got I4
		//IL_0457: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04c8: Expected O, but got I
		//IL_04d9: Expected I, but got O
		//IL_04f7: Expected O, but got I
		//IL_043c: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		ProductListingModel productListingModel;
		object obj6;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = originalListing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			productListingModel = (ProductListingModel)obj3;
			if (obj3 != null)
			{
				bool flag = !productListingModel.<isConsumable>k__BackingField;
				object obj4 = !flag;
				if (obj4 == null)
				{
					object obj5 = 152989696;
					obj6 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7201]");
					object obj7 = (nint)0 & (nint)1;
					if (obj7 != null)
					{
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v17+E4]");
						if ((nint)0 != 0)
						{
							goto IL_0108;
						}
					}
					else
					{
						_ = 1;
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v17+E4]");
						bool flag2 = (nint)0 == 0;
						object obj9 = !flag2;
						if (obj9 != null)
						{
							goto IL_0108;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
					object obj10 = (nint)0 & (nint)1;
					bool flag3 = obj10 == null;
					object obj11 = !flag3;
					if (obj11 != null)
					{
						goto IL_013b;
					}
					goto IL_032b;
				}
			}
			goto IL_02a0;
		}
		return (ProductListingModel)(object)new NullReferenceException();
		IL_013b:
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj12;
		if (!flag4)
		{
			goto IL_0170;
		}
		goto IL_0371;
		IL_032b:
		_ = 1;
		obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		obj13 = obj12;
		if (obj14 != null)
		{
			goto IL_0170;
		}
		goto IL_0371;
		IL_0371:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj6;
		goto IL_0170;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v23+B8]");
		object obj15 = 0;
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2464;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj17);
		object obj18 = (nint)0 + (nint)1080;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v15+8]");
		object obj19 = Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
		bool flag6 = obj19 == null;
		productListingModel = (ProductListingModel)obj19;
		if (flag6)
		{
			goto IL_02a0;
		}
		object obj20 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3424;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v32+E4]");
		object obj22;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v32+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v27+C8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v27+C8]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				goto IL_03ea;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v32+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v27+C8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v27+C8]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				goto IL_03ea;
			}
		}
		goto IL_0441;
		IL_0441:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v27 (System.Object)+38]");
		return (ProductListingModel)Enumerable.FirstOrDefault((IEnumerable<object>)0, predicate);
		IL_03ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v32+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj26 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v33+B8]");
			obj22 = 0;
		}
		object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)2360;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj22, (IntPtr)obj28);
		object obj29 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v32+B8]");
		object obj30 = (nint)0 + (nint)200;
		obj30 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func2;
		goto IL_0441;
		IL_02a0:
		return productListingModel;
		IL_0108:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C2]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			goto IL_013b;
		}
		goto IL_032b;
	}

	static ProductStore()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1864;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
