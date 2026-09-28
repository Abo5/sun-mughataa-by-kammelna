using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Managers.IAP;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Server.Models.Products;
using Server.Models.Store;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class IAPController : Singleton<IAPController>, IStoreKitListener
{
	public delegate void IAPAction(ProductListingModel product, GiftInfo giftInfo);

	public delegate void IAPFailure(ProductListingModel product, string error);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ProductDefinition, string> <>9__26_0;

		public static Func<ProductListingModel, bool> <>9__28_2;

		public static Func<ProductListingModel, bool> <>9__28_4;

		public static Func<ProductViewModel, IEnumerable<ProductListingModel>> <>9__29_0;

		public static Func<ProductListingModel, bool> <>9__29_1;

		public static Func<ProductListingModel, string> <>9__29_2;

		public static Func<ProductViewModel, IEnumerable<ProductListingModel>> <>9__35_0;

		public static Func<ProductListingModel, bool> <>9__35_1;

		public static Func<ProductListingModel, string> <>9__35_2;

		public static Func<ProductViewModel, IEnumerable<ProductListingModel>> <>9__40_0;

		public static Func<ProductListingModel, string> <>9__40_1;

		public static Action <>9__42_0;

		public static Func<ProductDefinition, string> <>9__51_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <InitializePurchasing>b__26_0(ProductDefinition definition)
		{
			if (definition != null)
			{
				return definition.<storeSpecificId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal bool <BuildProductDefinitions>b__28_2(ProductListingModel product)
		{
			//IL_0081: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_006e: Expected I4, but got O
			if (product != null)
			{
				object obj = product.<channelId>k__BackingField - 9;
				bool flag = (nint)obj < 13;
				object obj2 = !flag;
				object obj3 = ~obj2;
				object obj4 = 7449 >> (int)obj;
				return (byte)(obj3 & obj4) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <BuildProductDefinitions>b__28_4(ProductListingModel product)
		{
			//IL_0081: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_006e: Expected I4, but got O
			if (product != null)
			{
				object obj = product.<channelId>k__BackingField - 9;
				bool flag = (nint)obj < 13;
				object obj2 = !flag;
				object obj3 = ~obj2;
				object obj4 = 7449 >> (int)obj;
				return (byte)(obj3 & obj4) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal IEnumerable<ProductListingModel> <InitializeStoreKitManager>b__29_0(ProductViewModel product)
		{
			if (product != null)
			{
				return product.<listings>k__BackingField;
			}
			return (IEnumerable<ProductListingModel>)new NullReferenceException();
		}

		internal bool <InitializeStoreKitManager>b__29_1(ProductListingModel listing)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (listing != null)
			{
				object obj = listing.<channelId>k__BackingField - 17;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal string <InitializeStoreKitManager>b__29_2(ProductListingModel listing)
		{
			if (listing != null)
			{
				return listing.<listingId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal IEnumerable<ProductListingModel> <OnPlayBillingManagerConnected>b__35_0(ProductViewModel product)
		{
			if (product != null)
			{
				return product.<listings>k__BackingField;
			}
			return (IEnumerable<ProductListingModel>)new NullReferenceException();
		}

		internal bool <OnPlayBillingManagerConnected>b__35_1(ProductListingModel listing)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (listing != null)
			{
				object obj = listing.<channelId>k__BackingField - 13;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal string <OnPlayBillingManagerConnected>b__35_2(ProductListingModel listing)
		{
			if (listing != null)
			{
				return listing.<listingId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal IEnumerable<ProductListingModel> <FetchHuaweiProducts>b__40_0(ProductViewModel product)
		{
			if (product != null)
			{
				return product.<listings>k__BackingField;
			}
			return (IEnumerable<ProductListingModel>)new NullReferenceException();
		}

		internal string <FetchHuaweiProducts>b__40_1(ProductListingModel listing)
		{
			if (listing != null)
			{
				return listing.<listingId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal void <OnHuaweiPurchaseSucceeded>b__42_0()
		{
		}

		internal string <OnProductsFetchFailed>b__51_0(ProductDefinition product)
		{
			if (product != null)
			{
				return product.<storeSpecificId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public List<ProductDefinition> definitions;

		public Action<ProductListingModel> <>9__3;

		public Action<ProductListingModel> <>9__5;

		internal void <BuildProductDefinitions>b__0(ProductViewModel products)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I
			//IL_00dd: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_010f: Expected O, but got I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_01c0: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_0200: Expected O, but got I
			//IL_020e: Expected I, but got O
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected O, but got Unknown
			//IL_0266: Expected O, but got I
			//IL_0277: Expected I, but got O
			//IL_0295: Expected O, but got I
			//IL_0177: Expected O, but got I
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+E4]");
			object obj4;
			Func<object, bool> predicate;
			object obj6;
			object obj3;
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3688;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+10]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+10]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0125;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)3688;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+10]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+10]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0125;
				}
			}
			goto IL_017c;
			IL_0125:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v18+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3712;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v17+B8]");
			object obj13 = (nint)0 + (nint)16;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			predicate = func;
			goto IL_017c;
			IL_017c:
			IEnumerable<object> enumerable = Enumerable.Where(products.<listings>k__BackingField, predicate);
			object obj14 = this + 24;
			Action<object> action = (Action<object>)obj14;
			bool flag4 = obj14 == null;
			object obj15 = !flag4;
			IEnumerable<object> enumeration = enumerable;
			if (obj15 == null)
			{
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)3832;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj17);
				<>9__3 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				enumeration = enumerable;
				action = action2;
			}
			ArraysExtensions.ForEach(enumeration, action);
		}

		internal void <BuildProductDefinitions>b__3(ProductListingModel product)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_009d: Expected O, but got I4
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 2024;
			List<object> list = (List<object>)(object)definitions;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ProductDefinition productDefinition = default(ProductDefinition);
			productDefinition..ctor(product.<listingId>k__BackingField, ProductType.Subscription);
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag = list._size < items.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj3 = items + list._size;
				object obj4 = obj3 + 32;
				obj4 = productDefinition;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)productDefinition);
			}
		}

		internal void <BuildProductDefinitions>b__1(ProductViewModel products)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I
			//IL_00dd: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_010f: Expected O, but got I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_01c0: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_0200: Expected O, but got I
			//IL_020e: Expected I, but got O
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected O, but got Unknown
			//IL_0266: Expected O, but got I
			//IL_0277: Expected I, but got O
			//IL_0295: Expected O, but got I
			//IL_0177: Expected O, but got I
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+E4]");
			object obj4;
			Func<object, bool> predicate;
			object obj6;
			object obj3;
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3688;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+18]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+18]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0125;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)3688;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+18]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+18]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0125;
				}
			}
			goto IL_017c;
			IL_0125:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v18+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3720;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v17+B8]");
			object obj13 = (nint)0 + (nint)24;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			predicate = func;
			goto IL_017c;
			IL_017c:
			IEnumerable<object> enumerable = Enumerable.Where(products.<listings>k__BackingField, predicate);
			object obj14 = this + 32;
			Action<object> action = (Action<object>)obj14;
			bool flag4 = obj14 == null;
			object obj15 = !flag4;
			IEnumerable<object> enumeration = enumerable;
			if (obj15 == null)
			{
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)3840;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj17);
				<>9__5 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				enumeration = enumerable;
				action = action2;
			}
			ArraysExtensions.ForEach(enumeration, action);
		}

		internal void <BuildProductDefinitions>b__5(ProductListingModel product)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_009d: Expected O, but got I4
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 2024;
			List<object> list = (List<object>)(object)definitions;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ProductDefinition productDefinition = default(ProductDefinition);
			productDefinition..ctor(product.<listingId>k__BackingField, ProductType.Consumable);
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag = list._size < items.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj3 = items + list._size;
				object obj4 = obj3 + 32;
				obj4 = productDefinition;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)productDefinition);
			}
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public string purchaseToken;

		public IAPController <>4__this;

		public ProductListingModel listing;

		internal void <OnHuaweiPurchaseSucceeded>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0049: Expected O, but got I
			//IL_0030: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+18]");
			((HuaweiIapManager)0).Consume(purchaseToken);
		}

		internal void <OnHuaweiPurchaseSucceeded>b__2()
		{
			ProductListingModel productListingModel = listing;
			<>4__this.TrackPurchase(productListingModel.<listingId>k__BackingField);
		}
	}

	private sealed class <>c__DisplayClass54_0
	{
		public PendingOrder order;

		public IAPController <>4__this;

		public Action confirm;

		internal void <OnPurchasePending>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0041: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			((StoreController)obj3).ConfirmPurchase(order);
		}

		internal void <OnPurchasePending>b__1()
		{
			<>4__this.ValidateReceipt(order, confirm);
		}
	}

	private sealed class <>c__DisplayClass60_0
	{
		public int offerId;

		public Func<Offer, bool> <>9__2;

		internal bool <InitiateBuyingOffer>b__0(ProductListingModel l)
		{
			//IL_00c8: Expected I4, but got O
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0033: Expected O, but got I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_006b: Expected O, but got I
			//IL_0079: Expected I, but got O
			if (l != null)
			{
				object obj = this + 24;
				Func<object, bool> predicate = (Func<object, bool>)obj;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2624;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj4 = (nint)0 + (nint)3896;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj4);
					<>9__2 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				return Enumerable.Any(l.<Offers>k__BackingField, predicate);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <InitiateBuyingOffer>b__2(Offer o)
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

		internal bool <InitiateBuyingOffer>b__1(Offer o)
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

	private sealed class <>c__DisplayClass64_0
	{
		public ProductListingModel productListing;

		internal void <BuyProduct>b__0(KammelnaResponseModel<AppStorePromotionalOffer> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_01c3: Expected O, but got I4
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected O, but got Unknown
			//IL_0237: Expected O, but got I4
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0072: Expected O, but got I
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_00b0: Expected O, but got I4
			//IL_00d9: Expected O, but got I
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0145: Expected O, but got I4
			//IL_0184: Expected O, but got I
			object obj = (nint)0 + (nint)936;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				ProductListingModel productListingModel = productListing;
				object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v4+B8]");
				object obj4 = 0;
				object obj5 = typeof(Queue<string>) + 848;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj8 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
				object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v24+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string jsonDiscountInfo = JsonConvert.SerializeObject(response.<Model>k__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v5+8]");
				((StoreKitManager)0).BuyProduct(productListingModel.<listingId>k__BackingField, dbId, jsonDiscountInfo);
			}
			else
			{
				object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "Index = {0} position = {1}" + 1736;
				PopupWindow.ShowError((string)message);
				object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj18 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2592;
				KLogger.LogError(obj18);
			}
		}
	}

	private sealed class <>c__DisplayClass70_0
	{
		public IAPController <>4__this;

		public Product purchasedProduct;

		internal void <SubmitReceipt>b__0()
		{
			<>4__this.TrackPurchase(purchasedProduct);
		}
	}

	private sealed class <>c__DisplayClass71_0
	{
		public IAPController <>4__this;

		public ProductListingModel listingModel;

		public Action confirm;

		public Action trackPurchase;

		internal void <SubmitReceipt>b__0(long recipientId)
		{
			//IL_0021: Expected I4, but got I8
			<>4__this.OnServerSuccess(listingModel, confirm, trackPurchase, (int)recipientId);
		}

		internal void <SubmitReceipt>b__1(KammelnaError error)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object message = "Drop Menu Toggle" + 3616;
			<>4__this.OnServerError(listingModel, confirm, error, (string)message);
		}

		internal void <SubmitReceipt>b__2(bool success)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0084: Expected O, but got I
			//IL_00ae: Expected O, but got I4
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			<>4__this.OnServerSuccess(listingModel, confirm, trackPurchase, intDbId);
		}

		internal void <SubmitReceipt>b__3(KammelnaError error)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object message = "Drop Menu Toggle" + 3624;
			<>4__this.OnServerError(listingModel, confirm, error, (string)message);
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <InitializePurchasing>d__26 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public IAPController <>4__this;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f39: Expected O, but got Unknown
			//IL_028c: Expected O, but got I4
			//IL_029b: Expected I4, but got I8
			//IL_101e: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_00ac: Expected O, but got I4
			//IL_06b0: Expected I4, but got I8
			//IL_06bb: Expected O, but got Ref
			//IL_032c: Expected O, but got I4
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected O, but got Unknown
			//IL_0506: Expected O, but got I
			//IL_0516: Expected O, but got I
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Expected O, but got Unknown
			//IL_054f: Expected O, but got I4
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_03ac: Expected O, but got I
			//IL_03bc: Expected O, but got I
			//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Expected O, but got Unknown
			//IL_03f5: Expected O, but got I4
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected O, but got Unknown
			//IL_014d: Expected O, but got I
			//IL_061f: Expected O, but got I4
			//IL_0587: Expected O, but got I4
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected O, but got Unknown
			//IL_01a2: Expected O, but got I4
			//IL_0654: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Expected O, but got Unknown
			//IL_0671: Expected O, but got I
			//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f76: Expected O, but got Unknown
			//IL_0f8c: Expected O, but got I
			//IL_0f9d: Expected I, but got O
			//IL_0fbb: Expected O, but got I
			//IL_0fd6: Expected O, but got I4
			//IL_05b7: Expected O, but got I
			//IL_043a: Expected O, but got I4
			//IL_0212: Expected O, but got I4
			//IL_06ec: Expected O, but got I4
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Expected O, but got Unknown
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_0718: Expected O, but got Unknown
			//IL_04aa: Expected O, but got I4
			//IL_0754: Unknown result type (might be due to invalid IL or missing references)
			//IL_0759: Expected O, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected O, but got Unknown
			//IL_077f: Expected O, but got I
			//IL_078e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0793: Expected O, but got Unknown
			//IL_07a9: Expected O, but got I
			//IL_07b1: Expected I, but got O
			//IL_07c4: Expected I, but got O
			//IL_0dc0: Expected O, but got I4
			//IL_080b: Expected O, but got I
			//IL_081a: Unknown result type (might be due to invalid IL or missing references)
			//IL_081f: Expected O, but got Unknown
			//IL_083a: Expected O, but got I
			//IL_0842: Expected I, but got O
			//IL_0855: Expected I, but got O
			//IL_0de1: Expected O, but got I4
			//IL_0897: Expected O, but got I
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ab: Expected O, but got Unknown
			//IL_08c6: Expected O, but got I
			//IL_08ce: Expected I, but got O
			//IL_08e1: Expected I, but got O
			//IL_0e02: Expected O, but got I4
			//IL_0923: Expected O, but got I
			//IL_0932: Unknown result type (might be due to invalid IL or missing references)
			//IL_0937: Expected O, but got Unknown
			//IL_0952: Expected O, but got I
			//IL_095a: Expected I, but got O
			//IL_096d: Expected I, but got O
			//IL_0e23: Expected O, but got I4
			//IL_09af: Expected O, but got I
			//IL_09be: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c3: Expected O, but got Unknown
			//IL_09de: Expected O, but got I
			//IL_09e6: Expected I, but got O
			//IL_09f9: Expected I, but got O
			//IL_0e44: Expected O, but got I4
			//IL_0a3b: Expected O, but got I
			//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4f: Expected O, but got Unknown
			//IL_0a6a: Expected O, but got I
			//IL_0a72: Expected I, but got O
			//IL_0a85: Expected I, but got O
			//IL_0e65: Expected O, but got I4
			//IL_0ac7: Expected O, but got I
			//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adb: Expected O, but got Unknown
			//IL_0af6: Expected O, but got I
			//IL_0afe: Expected I, but got O
			//IL_0b11: Expected I, but got O
			//IL_0e86: Expected O, but got I4
			//IL_0b53: Expected O, but got I
			//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b67: Expected O, but got Unknown
			//IL_0b82: Expected O, but got I
			//IL_0b8a: Expected I, but got O
			//IL_0b9d: Expected I, but got O
			//IL_0ea7: Expected O, but got I4
			//IL_0bf1: Expected O, but got I4
			//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1d: Expected O, but got Unknown
			//IL_0c3e: Expected O, but got I
			//IL_0ec8: Expected O, but got I4
			//IL_0eed: Expected O, but got I4
			//IL_0cbe: Expected O, but got I4
			//IL_0cc7: Expected O, but got I4
			//IL_0cf4: Expected O, but got Ref
			//IL_0d12: Expected O, but got Ref
			object obj = typeof(DataRelation) + 856;
			IAPController iAPController = <>4__this;
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			nint num;
			object obj60;
			NullReferenceException ex;
			object obj15;
			if (<>1__state != 0)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v48+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "___# Content push apply failed [{0}]: {1}" + 256;
				Debug.Log(message);
				if ((object)<>4__this != null)
				{
					bool flag2 = <>4__this.IsInitialized();
					bool flag3 = !flag2;
					object obj4 = !flag3;
					if (obj4 != null)
					{
						goto IL_06a1;
					}
					if (iAPController.ReadyState != null)
					{
						iAPController.ReadyState.IsReady = false;
						object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj6 = default(object);
						obj6..ctor();
						object obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v44+B8]");
						object obj9 = (nint)0 + (nint)32;
						obj9 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v61+E4]");
						bool flag4 = (nint)0 == 0;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Platform platform = KUtil.GetPlatform();
						if (platform == Platform.Web)
						{
							object obj13 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v129+E4]");
							bool flag5 = (nint)0 == 0;
							object obj14 = !flag5;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object message2 = "___# Content push apply failed [{0}]: {1}" + 272;
							Debug.Log(message2);
							if (iAPController.ReadyState != null)
							{
								iAPController.ReadyState.IsReady = true;
								goto IL_06a1;
							}
							ex = new NullReferenceException();
							num = 0;
							obj15 = null;
						}
						else
						{
							object obj16 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v65+E4]");
							bool flag6 = (nint)0 == 0;
							object obj17 = !flag6;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Platform platform2 = KUtil.GetPlatform();
							object obj18 = obj;
							if (platform2 == Platform.Huawei)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v69+E4]");
								bool flag7 = (nint)0 == 0;
								object obj19 = !flag7;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object message3 = "___# Content push apply failed [{0}]: {1}" + 264;
								Debug.Log(message3);
								goto IL_06a1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v69+E4]");
							bool flag8 = (nint)0 == 0;
							object obj20 = !flag8;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object message4 = "___# Content push apply failed [{0}]: {1}" + 280;
							Debug.Log(message4);
							StoreController storeController = UnityIAPServices.StoreController();
							object obj21 = obj7;
							object obj22 = storeController;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object message5 = "___# Content push apply failed [{0}]: {1}" + 288;
							Debug.Log(message5);
							object obj23 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v53+B8]");
							object obj24 = 0;
							object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3536;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj26 = (nint)0 + (nint)3000;
							num = (nint)obj26;
							Action<object> action = default(Action<object>);
							action..ctor((object)<>4__this, (IntPtr)obj26);
							if (obj24 != null)
							{
								((StoreController)obj24).OnStoreDisconnected += action;
								object obj27 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v59+B8]");
								object obj28 = 0;
								object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 856;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj30 = (nint)0 + (nint)2944;
								num = (nint)obj30;
								Action<object> action2 = default(Action<object>);
								action2..ctor((object)<>4__this, (IntPtr)obj30);
								if (obj28 != null)
								{
									((StoreController)obj28).OnProductsFetched += action2;
									object obj31 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v65+B8]");
									object obj32 = 0;
									object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3120;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj34 = (nint)0 + (nint)2936;
									num = (nint)obj34;
									Action<object> action3 = default(Action<object>);
									action3..ctor((object)<>4__this, (IntPtr)obj34);
									if (obj32 != null)
									{
										((StoreController)obj32).OnProductsFetchFailed += action3;
										object obj35 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v71+B8]");
										object obj36 = 0;
										object obj37 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2920;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj38 = (nint)0 + (nint)2992;
										num = (nint)obj38;
										Action<object> action4 = default(Action<object>);
										action4..ctor((object)<>4__this, (IntPtr)obj38);
										if (obj36 != null)
										{
											((StoreController)obj36).OnPurchasesFetched += action4;
											object obj39 = obj7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v77+B8]");
											object obj40 = 0;
											object obj41 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3208;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj42 = (nint)0 + (nint)2984;
											num = (nint)obj42;
											Action<object> action5 = default(Action<object>);
											action5..ctor((object)<>4__this, (IntPtr)obj42);
											if (obj40 != null)
											{
												((StoreController)obj40).OnPurchasesFetchFailed += action5;
												object obj43 = obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v83+B8]");
												object obj44 = 0;
												object obj45 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2952;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj46 = (nint)0 + (nint)2976;
												num = (nint)obj46;
												Action<object> action6 = default(Action<object>);
												action6..ctor((object)<>4__this, (IntPtr)obj46);
												if (obj44 != null)
												{
													((StoreController)obj44).OnPurchasePending += action6;
													object obj47 = obj7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v89+B8]");
													object obj48 = 0;
													object obj49 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2912;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													object obj50 = (nint)0 + (nint)2952;
													num = (nint)obj50;
													Action<object> action7 = default(Action<object>);
													action7..ctor((object)<>4__this, (IntPtr)obj50);
													if (obj48 != null)
													{
														((StoreController)obj48).OnPurchaseConfirmed += action7;
														object obj51 = obj7;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v95+B8]");
														object obj52 = 0;
														object obj53 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1952;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														object obj54 = (nint)0 + (nint)2960;
														num = (nint)obj54;
														Action<object> action8 = default(Action<object>);
														action8..ctor((object)<>4__this, (IntPtr)obj54);
														if (obj52 != null)
														{
															((StoreController)obj52).OnPurchaseFailed += action8;
															object obj55 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v109+E4]");
															bool flag9 = (nint)0 == 0;
															object obj56 = !flag9;
															if (obj56 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															object message6 = "___# Content push apply failed [{0}]: {1}" + 312;
															Debug.Log(message6);
															object obj57 = obj7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v104+B8]");
															object obj58 = 0;
															if (obj58 != null)
															{
																Task task = ((StoreController)obj58).Connect();
																if (task != null)
																{
																	TaskAwaiter awaiter = task.GetAwaiter();
																	bool isCompleted = awaiter2.IsCompleted;
																	bool flag10 = !isCompleted;
																	object obj59 = !flag10;
																	obj60 = 0;
																	num = 0;
																	if (obj59 == null)
																	{
																		<>1__state = 0;
																		object obj61 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
																		obj61 = awaiter2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
																		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref this);
																		return;
																	}
																	goto IL_0feb;
																}
																ex = new NullReferenceException();
																obj60 = 0;
																num = 0;
																obj15 = null;
															}
															else
															{
																ex = new NullReferenceException();
																obj60 = 0;
																num = 0;
																obj15 = null;
															}
														}
														else
														{
															ex = new NullReferenceException();
															obj60 = 0;
															obj15 = <>4__this;
														}
													}
													else
													{
														ex = new NullReferenceException();
														obj60 = 0;
														obj15 = <>4__this;
													}
												}
												else
												{
													ex = new NullReferenceException();
													obj60 = 0;
													obj15 = <>4__this;
												}
											}
											else
											{
												ex = new NullReferenceException();
												obj60 = 0;
												obj15 = <>4__this;
											}
										}
										else
										{
											ex = new NullReferenceException();
											obj60 = 0;
											obj15 = <>4__this;
										}
									}
									else
									{
										ex = new NullReferenceException();
										obj60 = 0;
										obj15 = <>4__this;
									}
								}
								else
								{
									ex = new NullReferenceException();
									obj60 = 0;
									obj15 = <>4__this;
								}
							}
							else
							{
								ex = new NullReferenceException();
								obj60 = 0;
								obj15 = <>4__this;
							}
						}
					}
					else
					{
						ex = new NullReferenceException();
						obj15 = null;
					}
				}
				else
				{
					ex = new NullReferenceException();
					obj15 = null;
				}
				goto IL_0f00;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			awaiter2 = <>u__1;
			goto IL_0feb;
			IL_05bc:
			List<ProductDefinition> list;
			Func<object, object> selector;
			IEnumerable<object> values = Enumerable.Select(list, selector);
			string separator;
			string text = string.Join(separator, (IEnumerable<string>)values);
			string text2;
			string message7 = text2 + text;
			object obj62 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v23+E4]");
			bool flag11 = (nint)0 == 0;
			object obj63 = !flag11;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message7);
			object obj64 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj65 = obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v20+B8]");
			object obj66 = 0;
			if (obj66 != null)
			{
				((StoreController)obj66).FetchProducts(list, (IRetryPolicy)null);
				goto IL_06a1;
			}
			ex = new NullReferenceException();
			num = 0;
			obj15 = null;
			goto IL_0f00;
			IL_06a1:
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
			return;
			IL_0f00:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0565:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v29+E4]");
			bool flag12 = (nint)0 == 0;
			object obj67 = !flag12;
			object obj69;
			object obj70;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj68 = obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v29+B8]");
				obj70 = 0;
			}
			object obj71 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj72 = (nint)0 + (nint)3744;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj70, (IntPtr)obj72);
			object obj73 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v28+B8]");
			object obj74 = (nint)0 + (nint)8;
			obj74 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj60 = 0;
			string text3;
			separator = text3;
			selector = func;
			goto IL_05bc;
			IL_0feb:
			awaiter2.GetResult();
			object obj75 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v4+E4]");
			bool flag13 = (nint)0 == 0;
			object obj76 = !flag13;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message8 = "___# Content push apply failed [{0}]: {1}" + 320;
			Debug.Log(message8);
			if ((object)<>4__this != null)
			{
				list = <>4__this.BuildProductDefinitions();
				if (list != null)
				{
					object obj77 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object format = "___# Content push apply failed [{0}]: {1}" + 216;
					object arg = default(object);
					text2 = string.Format((string)format, arg);
					obj69 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
					object obj78 = obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v29+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v29+B8]");
						obj70 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v23+8]");
						selector = (Func<object, object>)0;
						object obj79 = "&action=sign-up" + 3424;
						separator = (string)obj79;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v23+8]");
						bool flag14 = (nint)0 == 0;
						object obj80 = !flag14;
						if (obj80 == null)
						{
							text3 = (string)obj79;
							goto IL_0565;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj78 = obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v29+B8]");
						obj70 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v23+8]");
						selector = (Func<object, object>)0;
						object obj81 = "&action=sign-up" + 3424;
						text3 = (string)obj81;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v23+8]");
						bool flag15 = (nint)0 == 0;
						object obj82 = !flag15;
						separator = (string)obj81;
						if (obj82 == null)
						{
							goto IL_0565;
						}
					}
					goto IL_05bc;
				}
				ex = new NullReferenceException();
				obj15 = null;
			}
			else
			{
				ex = new NullReferenceException();
				obj15 = null;
			}
			goto IL_0f00;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static StoreController m_StoreController;

	private static StoreKitManager m_StoreKitManager;

	private static GooglePlayBillingManager m_GooglePlayBillingManager;

	private static HuaweiIapManager m_HuaweiIapManager;

	private static ProductStore store;

	public readonly OneShotEvent ReadyState;

	private GiftInfo _giftInfo;

	private IAPAction m_OnIAPPurchaseComplete;

	private IAPFailure m_OnIAPPurchaseFailed;

	public static IEnumerable<ProductViewModel> RecurringSubscriptions
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0059: Expected O, but got I
			//IL_002a: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
				return ((ProductStore)0).RecurringSubscriptions;
			}
			return (IEnumerable<ProductViewModel>)new NullReferenceException();
		}
	}

	public static IEnumerable<ProductViewModel> ConsumableSubscriptions
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0059: Expected O, but got I
			//IL_002a: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
				return ((ProductStore)0).ConsumableSubscriptions;
			}
			return (IEnumerable<ProductViewModel>)new NullReferenceException();
		}
	}

	public static IEnumerable<ProductViewModel> GoldenCards
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0059: Expected O, but got I
			//IL_002a: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
				return ((ProductStore)0).GoldenCards;
			}
			return (IEnumerable<ProductViewModel>)new NullReferenceException();
		}
	}

	public static IEnumerable<ProductViewModel> SubscriptionsRecurringAndPromotion
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0059: Expected O, but got I
			//IL_002a: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
				return ((ProductStore)0).SubscriptionsInStoreHomePage;
			}
			return (IEnumerable<ProductViewModel>)new NullReferenceException();
		}
	}

	public static IEnumerable<ProductViewModel> GoldenCardsIncludingHidden
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0059: Expected O, but got I
			//IL_002a: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+20]");
				return ((ProductStore)0).GoldenCardsIncludingHidden;
			}
			return (IEnumerable<ProductViewModel>)new NullReferenceException();
		}
	}

	public event IAPAction OnIAPPurchaseComplete
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
			object obj2 = this + 48;
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
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
			object obj2 = this + 48;
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

	public event IAPFailure OnIAPPurchaseFailed
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
			object obj2 = this + 56;
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
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
			object obj2 = this + 56;
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

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0382: Expected O, but got I
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_03c9: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0345: Expected O, but got I4
		//IL_01e7: Expected I, but got O
		//IL_0211: Expected O, but got I4
		object obj = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 304;
		object obj2 = typeof(Queue<string>) + 752;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2024;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		Debug.Log(message);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		UnityEngine.Object obj9;
		UnityEngine.Object obj10 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			obj9 = obj10;
			if (!flag2)
			{
				goto IL_00bd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			obj9 = obj10;
			if (obj11 != null)
			{
				goto IL_00bd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj9;
		goto IL_00bd;
		IL_00bd:
		bool flag4 = obj10 != this;
		GameObject gameObject = base.gameObject;
		object obj12 = obj6;
		if (flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			UnityEngine.Object obj14 = gameObject;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = gameObject;
			}
			object message2 = "___# Content push apply failed [{0}]: {1}" + 248;
			UnityEngine.Object.Destroy(obj14);
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v32+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		UnityEngine.Object target = gameObject;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object message3 = "___# Content push apply failed [{0}]: {1}" + 296;
		object obj18 = typeof(SqlSingle[]) + 2376;
		object obj19 = (nint)0 + (nint)2848;
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3552;
		UnityEngine.Object.DontDestroyOnLoad(target);
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v18+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj19);
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityServicesInitializer.CallWhenReady(action);
	}

	private unsafe void InitializePurchasing()
	{
		//IL_0039: Expected O, but got I
		//IL_0051: Expected O, but got Ref
		//IL_0014: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<InitializePurchasing>d__26 stateMachine = default(<InitializePurchasing>d__26);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	private bool IsInitialized()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		bool flag = obj3 == null;
		return !flag;
	}

	private List<ProductDefinition> BuildProductDefinitions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0267: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_014c: Expected I, but got O
		//IL_0176: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_01dc: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1784;
		object obj2 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 240;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass28_0 <>c__DisplayClass28_ = default(<>c__DisplayClass28_0);
		<>c__DisplayClass28_..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (<>c__DisplayClass28_ != null)
		{
			object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj7 = <>c__DisplayClass28_ + 16;
			obj7 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v5+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3136;
				object obj11 = (nint)0 + (nint)3816;
				object obj12 = (nint)0 + (nint)2272;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v6+20]");
				IEnumerable<ProductViewModel> allRecurringSubscriptions = ((ProductStore)0).AllRecurringSubscriptions;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action<object> action = default(Action<object>);
				action..ctor((object)<>c__DisplayClass28_, (IntPtr)obj11);
				ArraysExtensions.ForEach(allRecurringSubscriptions, action);
				object obj13 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v7+B8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+20]");
				if ((nint)0 != 0)
				{
					object obj15 = (nint)0 + (nint)3824;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+20]");
					IEnumerable<ProductViewModel> allConsumables = ((ProductStore)0).AllConsumables;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action<object> action2 = default(Action<object>);
					action2..ctor((object)<>c__DisplayClass28_, (IntPtr)obj15);
					ArraysExtensions.ForEach(allConsumables, action2);
					return <>c__DisplayClass28_.definitions;
				}
			}
		}
		return (List<ProductDefinition>)(object)new NullReferenceException();
	}

	private void InitializeStoreKitManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0829: Expected O, but got I
		//IL_084b: Expected O, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_01cf: Expected O, but got I
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_0234: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_03e3: Expected O, but got I
		//IL_03f3: Expected O, but got I
		//IL_0415: Expected O, but got I4
		//IL_02ed: Expected O, but got I4
		//IL_0486: Expected O, but got I
		//IL_037c: Expected O, but got I
		//IL_038c: Expected O, but got I
		//IL_03ae: Expected O, but got I4
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_0883: Expected O, but got I
		//IL_0894: Expected I, but got O
		//IL_08b2: Expected O, but got I
		//IL_08cd: Expected O, but got I4
		//IL_053b: Expected O, but got I
		//IL_054b: Expected O, but got I
		//IL_056d: Expected O, but got I4
		//IL_0445: Expected O, but got I4
		//IL_031d: Expected O, but got I
		//IL_05de: Expected O, but got I
		//IL_04d4: Expected O, but got I
		//IL_04e4: Expected O, but got I
		//IL_0506: Expected O, but got I4
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected O, but got Unknown
		//IL_0904: Expected O, but got I
		//IL_0915: Expected I, but got O
		//IL_0933: Expected O, but got I
		//IL_094e: Expected O, but got I4
		//IL_0612: Expected O, but got I4
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_059d: Expected O, but got I4
		//IL_0475: Expected O, but got I
		//IL_066b: Expected O, but got I4
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected O, but got Unknown
		//IL_0985: Expected O, but got I
		//IL_0996: Expected I, but got O
		//IL_09b4: Expected O, but got I
		//IL_09cf: Expected O, but got I4
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected O, but got Unknown
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected O, but got Unknown
		//IL_05cd: Expected O, but got I
		//IL_06b9: Expected O, but got I
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_07ab: Expected O, but got I
		//IL_07e7: Expected O, but got I4
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_0740: Expected O, but got I
		//IL_075a: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7058]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v82+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v82+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.IOS)
		{
			goto IL_0115;
		}
		return;
		IL_0710:
		object message = "___# Content push apply failed [{0}]: {1}" + 784;
		Debug.Log(message);
		object obj6;
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v52+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v53+8]");
		object[] array;
		((StoreKitManager)0).FetchProducts((string[])array);
		return;
		IL_02cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v68+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object obj10;
		object obj11;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v84+B8]");
			obj11 = 0;
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3752;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj11, (IntPtr)obj13);
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v83+B8]");
		object obj15 = (nint)0 + (nint)32;
		obj15 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = 0;
		Func<object, IEnumerable<object>> selector = (Func<object, IEnumerable<object>>)func;
		goto IL_0322;
		IL_047a:
		object obj17 = (nint)0 + (nint)3688;
		IEnumerable<object> source2;
		Func<object, bool> predicate;
		IEnumerable<object> source = Enumerable.Where(source2, predicate);
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v48+E4]");
		object obj19;
		Func<object, object> selector2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v48+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v56+30]");
			selector2 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v56+30]");
			bool flag3 = (nint)0 == 0;
			object obj20 = !flag3;
			if (obj20 == null)
			{
				goto IL_057b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v48+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v56+30]");
			selector2 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v56+30]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			if (obj21 == null)
			{
				goto IL_057b;
			}
		}
		goto IL_05d2;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.IOS)
		{
			return;
		}
		goto IL_0115;
		IL_0115:
		obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj22 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v6+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+8]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 != null)
		{
			return;
		}
		object obj25 = typeof(DataRelation) + 856;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj27 = !flag6;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message2 = "___# Content push apply failed [{0}]: {1}" + 392;
		Debug.Log(message2);
		object obj28 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v12+B8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v13+20]");
		IEnumerable<ProductViewModel> allRecurringSubscriptions = ((ProductStore)0).AllRecurringSubscriptions;
		obj10 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
		object obj30 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v68+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v68+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v78+20]");
			selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v78+20]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			if (obj31 == null)
			{
				goto IL_02cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v68+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v78+20]");
			selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v78+20]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				goto IL_02cb;
			}
		}
		goto IL_0322;
		IL_057b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v48+E4]");
		bool flag9 = (nint)0 == 0;
		object obj33 = !flag9;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj34 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v62+B8]");
			obj19 = 0;
		}
		object obj35 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)3768;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj19, (IntPtr)obj36);
		object obj37 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v61+B8]");
		object obj38 = (nint)0 + (nint)48;
		obj38 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = 0;
		selector2 = func2;
		goto IL_05d2;
		IL_05d2:
		object obj39 = (nint)0 + (nint)3856;
		IEnumerable<object> source3 = Enumerable.Select(source, selector2);
		array = Enumerable.ToArray(source3);
		object obj40 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "___# Content push apply failed [{0}]: {1}" + 960;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj41 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v34+E4]");
		bool flag10 = (nint)0 == 0;
		object obj42 = !flag10;
		object message3 = text;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message3 = text;
		}
		Debug.Log(message3);
		object separator = "&action=sign-up" + 3424;
		string text2 = string.Join((string)separator, (string[])array);
		object obj43 = "___# Content push apply failed [{0}]: {1}" + 968;
		object obj44 = "&action=sign-up" + 144;
		string text3 = (string)obj44;
		string message4 = (string)obj43 + text2 + (string)obj44;
		Debug.Log(message4);
		object obj45 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v41+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v42+8]");
		if ((nint)0 != 0)
		{
			object obj47 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v33+E4]");
			bool flag11 = (nint)0 == 0;
			StoreKitManager storeKitManager = null;
			if (!flag11)
			{
				goto IL_0710;
			}
		}
		else
		{
			object obj48 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			StoreKitManager storeKitManager2 = default(StoreKitManager);
			storeKitManager2..ctor(this);
			object obj49 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v47+B8]");
			object obj50 = (nint)0 + (nint)8;
			obj50 = storeKitManager2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj47 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v33+E4]");
			bool flag12 = (nint)0 == 0;
			object obj51 = !flag12;
			text3 = null;
			StoreKitManager storeKitManager = storeKitManager2;
			if (obj51 != null)
			{
				goto IL_0710;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0710;
		IL_0322:
		object obj52 = (nint)0 + (nint)360;
		source2 = Enumerable.SelectMany(allRecurringSubscriptions, selector);
		object obj53 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v58+E4]");
		object obj54;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v58+B8]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v67+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v67+28]");
			bool flag13 = (nint)0 == 0;
			object obj55 = !flag13;
			if (obj55 == null)
			{
				goto IL_0423;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v58+B8]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v67+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v67+28]");
			bool flag14 = (nint)0 == 0;
			object obj56 = !flag14;
			if (obj56 == null)
			{
				goto IL_0423;
			}
		}
		goto IL_047a;
		IL_0423:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v58+E4]");
		bool flag15 = (nint)0 == 0;
		object obj57 = !flag15;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj58 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v73+B8]");
			obj54 = 0;
		}
		object obj59 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj60 = (nint)0 + (nint)3760;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj54, (IntPtr)obj60);
		object obj61 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v72+B8]");
		object obj62 = (nint)0 + (nint)40;
		obj62 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = 0;
		predicate = func3;
		goto IL_047a;
	}

	private void CheckAppStoreIntroductoryOfferEligibility()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05eb: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_0609: Expected O, but got I
		//IL_061e: Expected O, but got I
		//IL_063a: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0100: Expected O, but got I4
		//IL_01e2: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_054f: Expected O, but got I4
		//IL_0558: Expected O, but got I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0418: Expected O, but got I4
		//IL_0421: Expected O, but got I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_046d: Expected O, but got I4
		//IL_0590: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_0388: Expected O, but got I4
		//IL_0263: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_04c1: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_0672: Expected O, but got I
		//IL_0680: Expected I, but got O
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		DateTime lastIntroEligibilityCheck = UserInfo.LastIntroEligibilityCheck;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+10]");
		bool flag3 = lastIntroEligibilityCheck > (DateTime)0;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v8+8]");
		if (((StoreKitManager)0).CanUseStoreKit2())
		{
			object obj11 = typeof(DataRelation) + 856;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v54+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "_InputUv1BufferOffset" + 4088;
			Debug.Log(message);
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v43+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v44+8]");
			((StoreKitManager)0).IsEligibleForIntroOffer();
			return;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string appleHashedReceipt = UserInfo.AppleHashedReceipt;
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+8]");
		string text = ((StoreKitManager)0).FetchReceipt();
		bool flag6 = !flag3;
		StringComparison stringComparison = StringComparison.CurrentCulture;
		string text2 = null;
		if (!flag6)
		{
			bool flag7 = string.IsNullOrEmpty(appleHashedReceipt);
			bool flag8 = !flag7;
			object obj20 = 0;
			if (!flag8)
			{
				bool flag9 = string.IsNullOrEmpty(text);
				bool flag10 = !flag9;
				object obj21 = !flag10;
				obj20 = 0;
				if (obj21 != null)
				{
					return;
				}
			}
			if (text != null)
			{
				object obj22 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v45+E4]");
				bool flag11 = (nint)0 == 0;
				object obj24 = !flag11;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string a = StringsExtensions.ToSHA256Base64(text);
				bool flag12 = string.Equals(a, appleHashedReceipt, StringComparison.Ordinal);
				bool flag13 = !flag12;
				object obj25 = 0;
				stringComparison = StringComparison.Ordinal;
				text2 = appleHashedReceipt;
				if (!flag13)
				{
					return;
				}
			}
			else
			{
				bool flag14 = string.Equals(null, appleHashedReceipt, StringComparison.Ordinal);
				bool flag15 = !flag14;
				object obj26 = !flag15;
				object obj25 = 0;
				stringComparison = StringComparison.Ordinal;
				text2 = appleHashedReceipt;
				if (obj26 != null)
				{
					return;
				}
			}
		}
		object obj27 = typeof(DataRelation) + 856;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v19+E4]");
		object obj30;
		if ((nint)0 != 0)
		{
			object message2 = "___# Content push apply failed [{0}]: {1}" + 328;
			Debug.Log(message2);
			bool flag16 = text == null;
			object obj29 = 0;
			obj30 = 0;
			if (!flag16)
			{
				goto IL_042f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object message3 = "___# Content push apply failed [{0}]: {1}" + 328;
			Debug.Log(message3);
			bool flag17 = text == null;
			object obj31 = !flag17;
			object obj29 = 0;
			obj30 = 0;
			if (obj31 != null)
			{
				goto IL_042f;
			}
		}
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26+E4]");
		bool flag18 = (nint)0 == 0;
		object obj33 = !flag18;
		string appleHashedReceipt2 = null;
		string text3;
		if (obj33 == null)
		{
			text3 = null;
			goto IL_04e0;
		}
		goto IL_063f;
		IL_04e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		appleHashedReceipt2 = text3;
		goto IL_063f;
		IL_063f:
		UserInfo.AppleHashedReceipt = appleHashedReceipt2;
		object obj34 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2840;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj35);
		KammelnaRequests.CheckAppStoreIntroductoryOfferEligibility(text, action);
		return;
		IL_042f:
		object obj36 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v33+E4]");
		bool flag19 = (nint)0 == 0;
		object obj38 = !flag19;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		text3 = StringsExtensions.ToSHA256Base64(text);
		obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26+E4]");
		bool flag20 = (nint)0 == 0;
		object obj39 = !flag20;
		obj30 = 0;
		appleHashedReceipt2 = text3;
		if (obj39 == null)
		{
			goto IL_04e0;
		}
		goto IL_063f;
	}

	public void OnStoreKitProductsLoaded()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		object obj = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 352;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		CheckAppStoreIntroductoryOfferEligibility();
	}

	public void OnIntroOfferEligibilityChecked(bool isEligible)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 336;
		object obj = typeof(DataRelation) + 856;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object message = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		object obj6 = typeof(UsageHint) + 72;
		Debug.Log(message);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7+E4]");
		DateTime dateTime;
		DateTime dateTime2;
		if ((nint)0 != 0)
		{
			dateTime = DateTime.UtcNow;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			dateTime2 = dateTime;
			if (!flag2)
			{
				goto IL_007d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			dateTime = DateTime.UtcNow;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			dateTime2 = dateTime;
			if (obj9 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_007d;
		IL_007d:
		UserInfo.LastIntroEligibilityCheck = dateTime;
		UserInfo.IsEligibleForAppStoreIntroOffer = isEligible;
	}

	private bool IsStoreKitManagerInitialized()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+8]");
		bool flag = (nint)0 == 0;
		return !flag;
	}

	private void InitializeGooglePlayBillingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04be: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_024a: Expected O, but got I
		//IL_026c: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_047b: Expected O, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0491: Expected O, but got I
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I
		//IL_02e3: Expected I, but got O
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0337: Expected O, but got I
		//IL_0345: Expected I, but got O
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0394: Expected O, but got I
		//IL_03a2: Expected I, but got O
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03e5: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E705A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v46+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			goto IL_0115;
		}
		return;
		IL_0115:
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Platform platform2 = KUtil.GetPlatform();
			if (platform2 == Platform.Huawei)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform3 = KUtil.GetPlatform();
			if (platform3 == Platform.Huawei)
			{
				return;
			}
		}
		object obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v9+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v10+10]");
		if ((nint)0 == 0)
		{
			object obj10 = typeof(DataRelation) + 856;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "___# Content push apply failed [{0}]: {1}" + 376;
			Debug.Log(message);
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v15+B8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v16+10]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			GooglePlayBillingManager googlePlayBillingManager = null;
			if (obj15 == null)
			{
				object obj16 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				GooglePlayBillingManager googlePlayBillingManager2 = default(GooglePlayBillingManager);
				googlePlayBillingManager2..ctor();
				object obj17 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = (nint)0 + (nint)2920;
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj18);
				object obj19 = googlePlayBillingManager2 + 40;
				obj19 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj20 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21 = (nint)0 + (nint)2928;
				Action<bool, object> action2 = default(Action<bool, object>);
				action2..ctor((object)this, (IntPtr)obj21);
				object obj22 = googlePlayBillingManager2 + 56;
				obj22 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)2968;
				Action<int> action3 = default(Action<int>);
				action3..ctor((object)this, (IntPtr)obj24);
				object obj25 = googlePlayBillingManager2 + 64;
				obj25 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj26 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v39+B8]");
				object obj27 = (nint)0 + (nint)16;
				obj27 = googlePlayBillingManager2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				googlePlayBillingManager = googlePlayBillingManager2;
			}
			object obj28 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj29 = !flag4;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message2 = "___# Content push apply failed [{0}]: {1}" + 104;
			Debug.Log(message2);
			object obj30 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v23+B8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v24+10]");
			((GooglePlayBillingManager)0).StartConnection();
		}
		return;
		IL_0074:
		RuntimePlatform platform4 = Application.platform;
		if (platform4 != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_0115;
	}

	private void OnPlayBillingManagerConnected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_0521: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0073: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_029f: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_02e1: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		//IL_0389: Expected O, but got I4
		//IL_0224: Expected O, but got I
		//IL_0234: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_0266: Expected O, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_0559: Expected O, but got I
		//IL_056a: Expected I, but got O
		//IL_0588: Expected O, but got I
		//IL_05a3: Expected O, but got I4
		//IL_064d: Expected O, but got I
		//IL_065e: Expected O, but got I
		//IL_066e: Expected O, but got I
		//IL_0690: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05e2: Expected O, but got I
		//IL_05f3: Expected I, but got O
		//IL_0611: Expected O, but got I
		//IL_062c: Expected O, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0447: Expected O, but got I4
		//IL_03d0: Expected O, but got I4
		//IL_0349: Expected O, but got I
		//IL_0491: Expected O, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06c8: Expected O, but got I
		//IL_06d9: Expected I, but got O
		//IL_06f7: Expected O, but got I
		//IL_0712: Expected O, but got I4
		//IL_0740: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_04d3: Expected O, but got I
		object obj = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 96;
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+B8]");
		object obj6 = 0;
		object obj7 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+20]");
		IEnumerable<ProductViewModel> allRecurringSubscriptions = ((ProductStore)0).AllRecurringSubscriptions;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v51+E4]");
		object obj10;
		Func<object, IEnumerable<object>> selector;
		object obj12;
		object obj9;
		if ((nint)0 != 0)
		{
			obj9 = (nint)0 + (nint)360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v51+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v40+38]");
			selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v40+38]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				obj12 = obj9;
				goto IL_0183;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			obj12 = (nint)0 + (nint)360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v51+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v40+38]");
			selector = (Func<object, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v40+38]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			obj9 = obj12;
			if (obj13 == null)
			{
				goto IL_0183;
			}
		}
		goto IL_01da;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v51+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v46+B8]");
			obj10 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3784;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj10, (IntPtr)obj17);
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v45+B8]");
		object obj19 = (nint)0 + (nint)56;
		obj19 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj20 = 0;
		selector = (Func<object, IEnumerable<object>>)func;
		obj9 = obj12;
		goto IL_01da;
		IL_01da:
		IEnumerable<object> source = Enumerable.SelectMany(allRecurringSubscriptions, selector);
		object obj21 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v41+E4]");
		object obj23;
		Func<object, bool> predicate;
		object obj25;
		object obj22;
		if ((nint)0 != 0)
		{
			obj22 = (nint)0 + (nint)3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v41+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v29+40]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v29+40]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			if (obj24 == null)
			{
				obj25 = obj22;
				goto IL_02f7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj7;
			obj25 = (nint)0 + (nint)3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v41+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v29+40]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v29+40]");
			bool flag6 = (nint)0 == 0;
			object obj26 = !flag6;
			obj22 = obj25;
			if (obj26 == null)
			{
				goto IL_02f7;
			}
		}
		goto IL_034e;
		IL_02f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v41+E4]");
		bool flag7 = (nint)0 == 0;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v35+B8]");
			obj23 = 0;
		}
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)3792;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj23, (IntPtr)obj30);
		object obj31 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v34+B8]");
		object obj32 = (nint)0 + (nint)64;
		obj32 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj20 = 0;
		predicate = func2;
		obj22 = obj25;
		goto IL_034e;
		IL_034e:
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		object obj33 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v18+E4]");
		bool flag8 = (nint)0 == 0;
		object obj34 = !flag8;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj7;
		}
		object obj35 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v18+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v20+48]");
		Func<object, object> selector2 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v20+48]");
		bool flag9 = (nint)0 == 0;
		object obj37 = !flag9;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj38 = !flag10;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj39 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v26+B8]");
				obj36 = 0;
			}
			object obj40 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj41 = (nint)0 + (nint)3800;
			Func<object, object> func3 = default(Func<object, object>);
			func3..ctor(obj36, (IntPtr)obj41);
			object obj42 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v25+B8]");
			object obj43 = (nint)0 + (nint)72;
			obj43 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			selector2 = func3;
		}
		IEnumerable<object> source3 = Enumerable.Select(source2, selector2);
		object[] productIds = Enumerable.ToArray(source3);
		object format = "___# Content push apply failed [{0}]: {1}" + 616;
		object obj44 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v17+E4]");
		bool flag11 = (nint)0 == 0;
		object obj46 = !flag11;
		object message2 = text;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text;
		}
		Debug.Log(message2);
		object obj47 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v18+B8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v19+10]");
		((GooglePlayBillingManager)0).FetchProducts((string[])productIds);
	}

	private void OnPlayBillingManagerFetchProductFinished(bool success, string message)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FFF]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message2;
		if (obj3 != null)
		{
			obj4 = "___# Content push apply failed [{0}]: {1}" + 992;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message2 = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "___# Content push apply failed [{0}]: {1}" + 992;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message2 = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message2);
		return;
		IL_0094:
		Debug.Log(obj4);
	}

	private bool IsGooglePlayBillingManagerInitialized()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+10]");
		bool flag = (nint)0 == 0;
		return !flag;
	}

	private void InitializeHuaweiIapManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_06b4: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_06e9: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_074d: Expected O, but got I
		//IL_076f: Expected O, but got I4
		//IL_0250: Expected O, but got I4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_029d: Expected O, but got I
		//IL_02bf: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_02d0: Expected I, but got O
		//IL_060d: Expected O, but got I4
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_065a: Expected O, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0670: Expected O, but got I
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0339: Expected O, but got I
		//IL_0347: Expected I, but got O
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_039b: Expected O, but got I
		//IL_03a9: Expected I, but got O
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I
		//IL_0406: Expected I, but got O
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_045a: Expected O, but got I
		//IL_0468: Expected I, but got O
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_04a3: Expected O, but got I
		//IL_04b1: Expected I, but got O
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0505: Expected O, but got I
		//IL_0513: Expected I, but got O
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0562: Expected O, but got I
		//IL_056a: Expected I, but got O
		//IL_0578: Expected I, but got O
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_05bb: Expected O, but got I
		//IL_05d6: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 728;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object format = "___# Content push apply failed [{0}]: {1}" + 368;
		object obj6 = typeof(DataRelation) + 856;
		Platform platform = KUtil.GetPlatform();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object obj9 = default(object);
		string message = string.Format((string)format, arg, obj9);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v12+E4]");
		object obj13;
		object obj12;
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v78+E4]");
			bool flag2 = (nint)0 == 0;
			obj12 = 0;
			obj13 = 0;
			if (!flag2)
			{
				goto IL_00c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v78+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			obj12 = 0;
			obj13 = 0;
			if (obj14 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform2 = Application.platform;
		bool flag4 = platform2 != RuntimePlatform.Android;
		obj12 = obj13;
		if (!flag4)
		{
			goto IL_0191;
		}
		return;
		IL_00c4:
		RuntimePlatform platform3 = Application.platform;
		if (platform3 != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_0191;
		IL_0191:
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			Platform platform4 = KUtil.GetPlatform();
			if (platform4 != Platform.Huawei)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform5 = KUtil.GetPlatform();
			if (platform5 != Platform.Huawei)
			{
				return;
			}
		}
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v18+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v19+18]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			object obj19 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message2 = "___# Content push apply failed [{0}]: {1}" + 384;
			Debug.Log(message2);
			object obj21 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v24+B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v25+18]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			object obj24 = 0;
			nint num = (nint)obj9;
			HuaweiIapManager huaweiIapManager = null;
			if (obj23 == null)
			{
				object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				HuaweiIapManager huaweiIapManager2 = default(HuaweiIapManager);
				huaweiIapManager2..ctor();
				object obj26 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj27 = (nint)0 + (nint)2872;
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj27);
				object obj28 = huaweiIapManager2 + 40;
				obj28 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj30 = (nint)0 + (nint)2880;
				Action<int> action2 = default(Action<int>);
				action2..ctor((object)this, (IntPtr)obj30);
				object obj31 = huaweiIapManager2 + 48;
				obj31 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj32 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj33 = (nint)0 + (nint)2888;
				Action<bool, object> action3 = default(Action<bool, object>);
				action3..ctor((object)this, (IntPtr)obj33);
				object obj34 = huaweiIapManager2 + 56;
				obj34 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj35 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 760;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj36 = (nint)0 + (nint)2912;
				Action<object, object> action4 = default(Action<object, object>);
				action4..ctor((object)this, (IntPtr)obj36);
				object obj37 = huaweiIapManager2 + 64;
				obj37 = action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj38 = (nint)0 + (nint)2904;
				Action<int> action5 = default(Action<int>);
				action5..ctor((object)this, (IntPtr)obj38);
				object obj39 = huaweiIapManager2 + 72;
				obj39 = action5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj40 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj41 = (nint)0 + (nint)2896;
				Action<object> action6 = default(Action<object>);
				action6..ctor((object)this, (IntPtr)obj41);
				object obj42 = huaweiIapManager2 + 80;
				obj42 = action6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj43 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 952;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj44 = (nint)0 + (nint)2864;
				num = (nint)obj44;
				Action<object, bool, int> action7 = default(Action<object, bool, int>);
				action7..ctor((object)this, (IntPtr)obj44);
				object obj45 = huaweiIapManager2 + 96;
				obj45 = action7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj46 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v60+B8]");
				object obj47 = (nint)0 + (nint)24;
				obj47 = huaweiIapManager2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj24 = 0;
				huaweiIapManager = huaweiIapManager2;
			}
			object obj48 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v24+E4]");
			bool flag8 = (nint)0 == 0;
			object obj49 = !flag8;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message3 = "___# Content push apply failed [{0}]: {1}" + 184;
			Debug.Log(message3);
			object obj50 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v32+B8]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v33+18]");
			((HuaweiIapManager)0).StartConnection();
		}
	}

	private void OnHuaweiIapManagerConnected()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0144: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00f6: Expected O, but got I
		object obj = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 160;
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+20]");
		IEnumerable<ProductViewModel> allConsumables = ((ProductStore)0).AllConsumables;
		((IAPController)allConsumables).FetchHuaweiProducts(0, allConsumables);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8+20]");
		IEnumerable<ProductViewModel> allRecurringSubscriptions = ((ProductStore)0).AllRecurringSubscriptions;
		((IAPController)allRecurringSubscriptions).FetchHuaweiProducts(2, allRecurringSubscriptions);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v10+18]");
		((HuaweiIapManager)0).ObtainOwnedPurchases(0);
	}

	private void FetchHuaweiProducts(int priceType, IEnumerable<ProductViewModel> products)
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
		//IL_0464: Expected O, but got I
		//IL_0476: Expected O, but got I
		//IL_0486: Expected O, but got I
		//IL_04a8: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03fd: Expected O, but got I
		//IL_040e: Expected I, but got O
		//IL_042c: Expected O, but got I
		//IL_0443: Expected I, but got O
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04e0: Expected O, but got I
		//IL_04f1: Expected I, but got O
		//IL_050f: Expected O, but got I
		//IL_0526: Expected I, but got O
		//IL_01fc: Expected O, but got I
		//IL_038c: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_0554: Expected O, but got I
		//IL_03d2: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7001]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+E4]");
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
		object obj7 = (nint)0 + (nint)360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v21+50]");
		Func<object, IEnumerable<object>> selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v21+50]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v27+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3728;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v26+B8]");
		object obj16 = (nint)0 + (nint)80;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = unchecked((nint)null);
		obj10 = obj7;
		selector = (Func<object, IEnumerable<object>>)func;
		goto IL_0201;
		IL_0201:
		IEnumerable<object> source = Enumerable.SelectMany(products, selector);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj2;
		}
		object obj19 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+58]");
		Func<object, object> selector2 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+58]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v18+B8]");
				obj20 = 0;
			}
			object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)3736;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj20, (IntPtr)obj25);
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v17+B8]");
			object obj27 = (nint)0 + (nint)88;
			obj27 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = unchecked((nint)null);
			selector2 = func2;
		}
		IEnumerable<object> source2 = Enumerable.Select(source, selector2);
		IEnumerable<object> source3 = Enumerable.Distinct(source2);
		object[] productIds = Enumerable.ToArray(source3);
		object obj28 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "___# Content push apply failed [{0}]: {1}" + 120;
		object obj29 = typeof(DataRelation) + 856;
		object obj30 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj31 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj32 = !flag8;
		object message = text;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		object obj33 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v9+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v10+18]");
		((HuaweiIapManager)0).FetchProducts((string[])productIds, priceType);
		return;
		IL_0085:
		obj10 = (nint)0 + (nint)360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v21+50]");
		selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v21+50]");
		bool flag9 = (nint)0 == 0;
		object obj35 = !flag9;
		if (obj35 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}

	private void OnHuaweiIapManagerFetchProductsFinished(bool success, string message)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		if (success)
		{
			object obj = typeof(DataRelation) + 856;
			object message2 = "___# Content push apply failed [{0}]: {1}" + 1048;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message2);
			ReadyState.IsReady = true;
		}
		else
		{
			object obj4 = "___# Content push apply failed [{0}]: {1}" + 1136;
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			string obj6 = (string)obj4 + message;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+E4]");
			if ((nint)0 != 0)
			{
				KLogger.LogError(obj6);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.LogError(obj6);
		}
	}

	private void OnHuaweiPurchaseSucceeded(string receipt, string purchaseToken)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_01dc: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_017a: Expected I, but got O
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0236: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0339: Expected O, but got I
		//IL_037d: Expected O, but got I4
		//IL_03fc: Expected O, but got I
		//IL_0404: Expected I, but got O
		//IL_0415: Expected I, but got O
		//IL_0433: Expected O, but got I
		//IL_046e: Expected I, but got O
		//IL_02cb: Expected O, but got I
		//IL_02dc: Expected I, but got O
		//IL_0266: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass42_0 <>c__DisplayClass42_ = default(<>c__DisplayClass42_0);
		<>c__DisplayClass42_..ctor();
		object obj2 = <>c__DisplayClass42_ + 16;
		obj2 = purchaseToken;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <>c__DisplayClass42_ + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IAPController iAPController = default(IAPController);
		ProductListingModel productListingModel = iAPController.ListingFromHuaweiReceipt(receipt);
		object obj4 = <>c__DisplayClass42_ + 32;
		obj4 = productListingModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj4 == null)
		{
			return;
		}
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v29+E4]");
		object obj8;
		Action confirm;
		object obj9;
		object obj7;
		if ((nint)0 != 0)
		{
			obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v29+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v13+60]");
			confirm = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v13+60]");
			bool flag = (nint)0 == 0;
			obj9 = obj7;
			if (!flag)
			{
				goto IL_0150;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v29+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v13+60]");
			confirm = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v13+60]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj9 = obj7;
			if (obj10 != null)
			{
				goto IL_0150;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v18+B8]");
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3776;
		nint num = (nint)obj13;
		Action action = default(Action);
		action..ctor(obj8, (IntPtr)obj13);
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v16+B8]");
		object obj15 = (nint)0 + (nint)96;
		obj15 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ProductListingModel productListingModel2 = (ProductListingModel)obj4;
		obj7 = obj9;
		ProductListingModel productListingModel3 = (ProductListingModel)(object)action;
		confirm = action;
		goto IL_0290;
		IL_0290:
		if (productListingModel2.<isConsumable>k__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)3848;
			Action action2 = default(Action);
			action2..ctor(<>c__DisplayClass42_, (IntPtr)obj16);
			productListingModel2 = <>c__DisplayClass42_.listing;
			confirm = action2;
		}
		object obj17 = "___# Content push apply failed [{0}]: {1}" + 144;
		object obj18 = "&action=sign-up" + 1144;
		object obj19 = typeof(DataRelation) + 856;
		object obj20 = (nint)0 + (nint)3856;
		string text = (string)obj17 + productListingModel2.<listingId>k__BackingField + (string)obj18;
		object obj21 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		object message = text;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(<>c__DisplayClass42_, (IntPtr)obj20);
		SubmitReceipt(<>c__DisplayClass42_.listing, receipt, null, confirm, action3);
		return;
		IL_0150:
		productListingModel2 = (ProductListingModel)obj4;
		bool flag5 = obj4 == null;
		object obj23 = !flag5;
		num = (nint)purchaseToken;
		productListingModel3 = productListingModel;
		if (obj23 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0290;
	}

	private void OnHuaweiPurchaseFailed(int responseCode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0100: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object format = "___# Content push apply failed [{0}]: {1}" + 136;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = text;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = text;
		}
		KLogger.LogError(obj8);
	}

	private void OnHuaweiConsumeFinished(string purchaseToken, bool success, int responseCode)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_007a: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7005]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (success)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			bool flag = !success;
			object obj3 = !flag;
			if (obj3 != null)
			{
				return;
			}
		}
		object format = "___# Content push apply failed [{0}]: {1}" + 112;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg, purchaseToken);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		object obj8 = text;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = text;
		}
		KLogger.LogError(obj8);
	}

	private void OnHuaweiOwnedPurchasesFetched(string receipts)
	{
		//IL_0911: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_0958: Expected O, but got I
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_06b7: Expected I, but got O
		//IL_00c3: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_09f1: Expected O, but got I
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_0b39: Expected I, but got O
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_05dd: Expected I, but got O
		//IL_05ed: Expected O, but got I
		//IL_06ec: Expected I, but got O
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0678: Expected I, but got O
		//IL_01f4: Expected I, but got O
		//IL_0204: Expected O, but got I
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_0b13: Expected O, but got I
		//IL_0628: Expected O, but got I
		//IL_076d: Expected I, but got O
		//IL_0775: Expected O, but got I
		//IL_0a76: Expected O, but got I
		//IL_0a98: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_08a6: Expected O, but got I4
		//IL_08b5: Expected I, but got O
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_06a0: Expected I, but got O
		//IL_0380: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03a6: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03ce: Expected O, but got I4
		//IL_03de: Expected O, but got I
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_041d: Expected O, but got I4
		//IL_0310: Expected O, but got I
		//IL_0326: Expected O, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_044a: Expected O, but got I
		//IL_045a: Expected O, but got I
		//IL_0470: Expected O, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0498: Expected O, but got I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_07db: Expected I, but got O
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_0361: Expected O, but got I
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_0853: Expected O, but got I4
		//IL_0702: Expected I, but got O
		//IL_04e2: Expected O, but got I
		//IL_06ce: Expected O, but got I4
		//IL_06d6: Expected I, but got O
		//IL_052e: Expected I, but got O
		//IL_053e: Expected O, but got I
		//IL_0562: Expected O, but got I4
		//IL_05c8: Expected O, but got I4
		JArray jArray = JArray.Parse(receipts);
		bool flag = jArray == null;
		object obj = 0;
		IAPController iAPController = this;
		if (!flag)
		{
			object format = "___# Content push apply failed [{0}]: {1}" + 128;
			object obj2 = typeof(DataRelation) + 856;
			int count = jArray.Count;
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object message = text;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 808;
			object obj8 = (nint)0 + (nint)3192;
			object obj9 = "Picking audio files is not supported on iOS" + 2856;
			object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			Debug.Log(message);
			IEnumerator<JToken> enumerator = jArray.GetEnumerator();
			string text2 = null;
			string text3 = null;
			bool flag4 = default(bool);
			NullReferenceException ex = default(NullReferenceException);
			object obj29 = default(object);
			JToken jToken = default(JToken);
			IAPController iAPController2 = default(IAPController);
			object obj47 = default(object);
			while (true)
			{
				if (enumerator != null)
				{
					nint num = (nint)enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_018b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
					object obj12 = (nint)0 + (nint)8;
					bool flag3 = flag4;
					object obj14;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X10_v23-8]");
						object obj13 = 0 - obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X10_v23-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj14 = obj12 + 16;
						obj11--;
						obj13 = obj11 - 1;
						bool flag5 = obj13 == null;
						flag4 = (nint)obj11 != 1;
						flag3 = flag4;
						obj12 = obj14;
						if (flag4)
						{
							continue;
						}
						goto IL_018b;
					}
					object obj15 = num + obj12;
					object obj16 = obj15 + 312;
					flag4 = flag3;
					obj14 = obj12;
					goto IL_09e1;
				}
				ex = new NullReferenceException();
				nint num2 = (nint)text2;
				goto IL_08ba;
				IL_0a66:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v59+8]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ X0_v59] (should have been resolved before IL gen)");
				object obj17 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X21_v12+38]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X21_v12+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v27+10]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v27+10]");
					object obj20 = (nint)0 + (nint)309;
					object obj21 = obj20 & 1;
					if (obj21 == null)
					{
						goto IL_03ec;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v27+10]");
					object obj22 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X21_v12+38]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v39+10]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v39+10]");
					object obj24 = (nint)0 + (nint)309;
					object obj25 = obj24 & 1;
					bool flag6 = obj25 == null;
					object obj26 = !flag6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v39+10]");
					object obj22 = 0;
					if (obj26 == null)
					{
						goto IL_03ec;
					}
				}
				goto IL_03fb;
				IL_05b1:
				string text4;
				OnHuaweiPurchaseSucceeded(text4, text2);
				object obj27 = 0;
				text3 = text4;
				continue;
				IL_0669:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = unchecked((nint)null);
				goto IL_0b03;
				IL_03ec:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				goto IL_03fb;
				IL_018b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				text2 = null;
				goto IL_09e1;
				IL_09e1:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v27+8]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v489 @ X0_v27] (should have been resolved before IL gen)");
				object obj28 = obj29 & 1;
				if (obj28 != null)
				{
					if (enumerator != null)
					{
						nint num3 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02bc;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
						object obj31 = (nint)0 + (nint)8;
						bool flag7 = flag4;
						object obj14;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v18-8]");
							object obj13 = 0 - obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v18-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							obj14 = obj31 + 16;
							obj30--;
							obj13 = obj30 - 1;
							bool flag5 = obj13 == null;
							flag4 = (nint)obj30 != 1;
							flag7 = flag4;
							obj31 = obj14;
							if (flag4)
							{
								continue;
							}
							goto IL_02bc;
						}
						object obj32 = num3 + obj31;
						object obj33 = obj32 + 312;
						flag4 = flag7;
						obj14 = obj31;
						goto IL_0a66;
					}
					ex = new NullReferenceException();
					num2 = (nint)text2;
					goto IL_08ba;
				}
				bool flag8 = enumerator == null;
				num2 = (nint)text2;
				if (!flag8)
				{
					nint num4 = (nint)enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0669;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
					object obj35 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X10_v12-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj35 += 16;
						obj34--;
						if ((nint)obj34 != 1)
						{
							continue;
						}
						goto IL_0669;
					}
					object obj36 = num4 + obj35;
					object obj37 = obj36 + 312;
					num2 = (nint)text2;
					goto IL_0b03;
				}
				goto IL_0707;
				IL_03fb:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v62+E4]");
				bool flag9 = (nint)0 == 0;
				object obj38 = !flag9;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X21_v12+38]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v30+10]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v30+10]");
				object obj41 = (nint)0 + (nint)309;
				object obj42 = obj41 & 1;
				bool flag10 = obj42 == null;
				object obj43 = !flag10;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				if (jToken != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v65+B8]");
					object obj44 = 0;
					text4 = jToken.ToString(Formatting.None, (JsonConverter[])obj44);
					JToken jToken2 = jToken.get_Item(obj9);
					string text6;
					if (jToken2 != null)
					{
						nint num5 = (nint)jToken2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v37 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+170]");
						text3 = (string)0;
						string text5 = jToken2.ToString();
						bool flag11 = (object)this == null;
						object obj45 = !flag11;
						text2 = text5;
						if (obj45 != null)
						{
							goto IL_05b1;
						}
						text6 = text5;
					}
					else
					{
						bool flag12 = (object)this == null;
						text2 = null;
						text6 = null;
						text3 = (string)obj9;
						if (!flag12)
						{
							goto IL_05b1;
						}
					}
					ex = new NullReferenceException();
					obj27 = 0;
					num2 = (nint)text6;
				}
				else
				{
					ex = new NullReferenceException();
					num2 = (nint)text2;
				}
				goto IL_08ba;
				IL_08d2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
				IL_08ba:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				NullReferenceException ex2 = ex;
				goto IL_08d2;
				IL_0707:
				OutOfMemoryException ex3 = new OutOfMemoryException();
				bool flag13 = (nint)text3 != 1;
				ex2 = (NullReferenceException)(object)ex3;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					object obj46 = typeof(DataRelation) + 3808;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					nint num6 = (nint)iAPController2;
					obj = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
					bool flag14 = obj47 == null;
					iAPController = iAPController2;
					if (!flag14)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
					object obj48 = iAPController;
					text3 = (string)(139026432 + 4064);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
					num2 = unchecked((nint)null);
					goto IL_08ba;
				}
				goto IL_08d2;
				IL_0b03:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v52+8]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v647 @ X0_v52] (should have been resolved before IL gen)");
				goto IL_0707;
				IL_02bc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				text2 = null;
				goto IL_0a66;
			}
			iAPController = iAPController2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			if ((object)iAPController2 != null)
			{
				nint num7 = (nint)iAPController;
				iAPController2.OnStoreKitProductsLoaded();
				object obj49 = "___# Content push apply failed [{0}]: {1}" + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				string text7 = default(string);
				string text8 = default(string);
				string obj50 = text7 + text8;
				object obj51 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v48+E4]");
				bool flag15 = (nint)0 == 0;
				object obj52 = !flag15;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				KLogger.LogError(obj50);
				return;
			}
		}
		throw new NullReferenceException();
	}

	private ProductListingModel ListingFromHuaweiReceipt(string receipt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_029a: Expected O, but got I
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01de: Expected O, but got I4
		JObject jObject = JObject.Parse(receipt);
		string text;
		string text3;
		string text5;
		string text4;
		if (jObject != null)
		{
			object obj = "Picking audio files is not supported on iOS" + 2184;
			text = (string)obj;
			JToken jToken = jObject.get_Item((string)obj);
			if (jToken != null)
			{
				nint num = (nint)jToken;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v22 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+170]");
				text = (string)0;
				string text2 = jToken.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7065]");
				object obj2 = (nint)0 & (nint)1;
				bool flag = obj2 == null;
				text3 = text2;
				if (flag)
				{
					goto IL_0117;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v22 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+170]");
				text4 = (string)0;
				text5 = text2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7065]");
				object obj3 = (nint)0 & (nint)1;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				text3 = null;
				text4 = (string)obj;
				text5 = null;
				if (obj4 == null)
				{
					goto IL_0117;
				}
			}
			goto IL_026e;
		}
		NullReferenceException ex = new NullReferenceException();
		text4 = null;
		goto IL_02bf;
		IL_0117:
		_ = 1;
		text4 = text;
		text5 = text3;
		goto IL_026e;
		IL_02bf:
		NullReferenceException ex2 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		ProductListingModel result = default(ProductListingModel);
		return result;
		IL_026e:
		object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+20]");
			ProductListingModel productListingModel = ((ProductStore)0).GetListing(text5);
			if (productListingModel == null)
			{
				object obj8 = "___# Content push apply failed [{0}]: {1}" + 152;
				object obj9 = "&action=sign-up" + 144;
				string obj10 = (string)obj8 + text5 + (string)obj9;
				object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				KLogger.LogError(obj10);
				productListingModel = null;
			}
			return productListingModel;
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_02bf;
	}

	private bool IsHuaweiIapManagerInitialized()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+18]");
		bool flag = (nint)0 == 0;
		return !flag;
	}

	private void OnHuaweiIapManagerDisconnected(int code)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 176;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object obj5 = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = text;
		}
		KLogger.LogError(obj5);
	}

	private void OnProductsFetched(List<Product> products)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004c: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_0103: Expected O, but got I
		object format = "___# Content push apply failed [{0}]: {1}" + 200;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = text;
		}
		KLogger.Log(obj6);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+B8]");
		object obj8 = 0;
		((StoreController)obj8).FetchPurchases();
		ReadyState.IsReady = true;
	}

	private void OnStoreDisconnected(StoreConnectionFailureDescription description)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		object obj = "___# Content push apply failed [{0}]: {1}" + 232;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		string text = (string)obj + description.message;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object obj5 = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = text;
		}
		KLogger.LogError(obj5);
		ReadyState.IsReady = false;
	}

	private void OnProductsFetchFailed(ProductFetchFailed failure)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I
		//IL_0302: Expected I, but got O
		//IL_0320: Expected O, but got I
		//IL_029a: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1776;
		object obj2 = "&action=sign-up" + 3424;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+E4]");
		object obj5;
		Func<object, object> selector;
		string separator;
		object obj7;
		string text;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+68]");
			selector = (Func<object, object>)0;
			separator = (string)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+68]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				text = (string)obj2;
				goto IL_0154;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			obj7 = (nint)0 + (nint)3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+68]");
			selector = (Func<object, object>)0;
			text = (string)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+68]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj7;
			separator = (string)obj2;
			if (obj8 == null)
			{
				goto IL_0154;
			}
		}
		goto IL_01ab;
		IL_0154:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v18+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3808;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v17+B8]");
		object obj14 = (nint)0 + (nint)104;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		obj4 = obj7;
		separator = text;
		goto IL_01ab;
		IL_01ab:
		IEnumerable<object> values = Enumerable.Select(failure.<FailedFetchProducts>k__BackingField, selector);
		string arg = string.Join(separator, (IEnumerable<string>)values);
		object format = "tournament_participate_warning_body_with_tickets_warning_daily" + 3200;
		object obj15 = "___# Content push apply failed [{0}]: {1}" + 192;
		object obj16 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2400;
		object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string text2 = string.Format((string)format, arg2, arg);
		string text3 = (string)obj15 + failure.<FailureReason>k__BackingField + (string)obj16 + text2;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		object obj21 = text3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = text3;
		}
		KLogger.LogError(obj21);
	}

	private void OnPurchasesFetchFailed(PurchasesFetchFailureDescription description)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 2616;
		object format = "___# Content push apply failed [{0}]: {1}" + 208;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg, description.message);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object obj5 = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = text;
		}
		KLogger.LogError(obj5);
	}

	private void OnPurchasesFetched(Orders orders)
	{
		//IL_05b8: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_065e: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_051b: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_025d: Expected I, but got O
		//IL_06c0: Expected O, but got I
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		//IL_03ed: Expected O, but got I4
		//IL_03f6: Expected O, but got I4
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_078d: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0413: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_04ae: Expected I, but got O
		//IL_039e: Expected I, but got O
		//IL_07cf: Expected O, but got I
		//IL_044e: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0477: Expected O, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_033b: Expected O, but got I
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		Orders orders2 = default(Orders);
		bool flag = orders2 == null;
		object obj = 152989696;
		bool flag4 = default(bool);
		if (!flag)
		{
			IReadOnlyList<PendingOrder> <PendingOrders>k__BackingField = orders2.<PendingOrders>k__BackingField;
			bool flag2 = orders2.<PendingOrders>k__BackingField == null;
			obj = 152989696;
			if (!flag2)
			{
				object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3576;
				nint num = (nint)<PendingOrders>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<UnityEngine.Purchasing.PendingOrder>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<UnityEngine.Purchasing.PendingOrder>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<UnityEngine.Purchasing.PendingOrder>>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				object obj6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X10_v29-8]");
					object obj5 = 0 - obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X10_v29-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj6 = obj4 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<UnityEngine.Purchasing.PendingOrder>>)+12E]");
					obj3 = -1;
					obj5 = obj3 - 1;
					bool flag5 = obj5 == null;
					flag4 = (nint)obj3 != 1;
					flag3 = flag4;
					obj4 = obj6;
					if (flag4)
					{
						continue;
					}
					goto IL_012a;
				}
				obj3 = obj4;
				object obj7 = num + obj4;
				object obj8 = obj7 + 312;
				flag4 = flag3;
				obj6 = obj4;
				goto IL_0612;
			}
		}
		goto IL_05c6;
		IL_012a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num2 = unchecked((nint)null);
		goto IL_0612;
		IL_0612:
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1008;
		obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v22+8]");
		PendingOrder pendingOrder = (PendingOrder)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v22] (should have been resolved before IL gen)");
		object obj11 = default(object);
		object obj17 = default(object);
		object obj30 = default(object);
		PendingOrder pendingOrder2 = default(PendingOrder);
		object obj22;
		object obj23;
		while (true)
		{
			if (obj11 != null)
			{
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v19+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v19+12E]");
				if ((nint)0 == 0)
				{
					goto IL_024e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v19+B0]");
				object obj13 = (nint)0 + (nint)8;
				bool flag6 = flag4;
				object obj6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X10_v24-8]");
					object obj5 = 0 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X10_v24-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj6 = obj13 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v19+12E]");
					obj3 = -1;
					obj5 = obj3 - 1;
					bool flag5 = obj5 == null;
					flag4 = (nint)obj3 != 1;
					flag6 = flag4;
					obj13 = obj6;
					if (flag4)
					{
						continue;
					}
					goto IL_024e;
				}
				obj3 = obj13;
				object obj14 = obj12 + obj13;
				object obj15 = obj14 + 312;
				flag4 = flag6;
				obj6 = obj13;
				goto IL_06af;
			}
			NullReferenceException ex = new NullReferenceException();
			orders2 = (Orders)(object)pendingOrder;
			break;
			IL_024e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = unchecked((nint)null);
			goto IL_06af;
			IL_06af:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v28+8]");
			orders2 = (Orders)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v472 @ X0_v28] (should have been resolved before IL gen)");
			object obj16 = obj17 & 1;
			if (obj16 != null)
			{
				if (obj11 != null)
				{
					object obj18 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v22+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v22+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v22+B0]");
						object obj19 = (nint)0 + (nint)8;
						bool flag7 = flag4;
						object obj6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X10_v19-8]");
							object obj5 = 0 - obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X10_v19-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj6 = obj19 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v22+12E]");
							obj3 = -1;
							obj5 = obj3 - 1;
							bool flag5 = obj5 == null;
							flag4 = (nint)obj3 != 1;
							flag7 = flag4;
							obj19 = obj6;
							if (flag4)
							{
								continue;
							}
							goto IL_038f;
						}
						obj3 = obj19;
						object obj20 = obj18 + obj19;
						object obj21 = obj20 + 312;
						flag4 = flag7;
						obj6 = obj19;
						goto IL_0735;
					}
					goto IL_038f;
				}
				NullReferenceException ex2 = new NullReferenceException();
				break;
			}
			obj22 = obj11;
			obj23 = 0;
			object obj24 = 0;
			while (true)
			{
				if (obj22 == null)
				{
					goto IL_0773;
				}
				object obj25 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v5+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v5+12E]");
				if ((nint)0 == 0)
				{
					goto IL_049f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v5+B0]");
				object obj26 = (nint)0 + (nint)8;
				object obj6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj6 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v5+12E]");
					obj3 = -1;
					bool flag8 = (nint)obj3 != 1;
					obj26 = obj6;
					if (flag8)
					{
						continue;
					}
					goto IL_049f;
				}
				obj3 = obj26;
				object obj27 = obj25 + obj26;
				object obj28 = obj27 + 312;
				obj6 = obj26;
				goto IL_07bf;
				IL_0773:
				bool flag9 = obj24 == null;
				object obj29 = !flag9;
				if (obj29 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)orders2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj24 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj23 = obj30;
				continue;
				IL_049f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = unchecked((nint)null);
				goto IL_07bf;
				IL_07bf:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v4+8]");
				orders2 = (Orders)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ X0_v4] (should have been resolved before IL gen)");
				goto IL_0773;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_038f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = unchecked((nint)null);
			goto IL_0735;
			IL_0735:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v590 @ X0_v32] (should have been resolved before IL gen)");
			OnPurchasePending(pendingOrder2);
			pendingOrder = pendingOrder2;
		}
		obj22 = obj11;
		obj23 = 0;
		goto IL_05c6;
		IL_05c6:
		throw new NullReferenceException();
	}

	private void OnPurchasePending(PendingOrder order)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_0266: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_01f7: Expected O, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_02c8: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031f: Expected O, but got I
		//IL_032b: Expected O, but got I
		//IL_0344: Expected O, but got I
		//IL_0372: Expected O, but got I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_047f: Expected I, but got O
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03df: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass54_0 <>c__DisplayClass54_ = default(<>c__DisplayClass54_0);
		<>c__DisplayClass54_..ctor();
		object obj2 = <>c__DisplayClass54_ + 16;
		obj2 = order;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <>c__DisplayClass54_ + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v4+10]");
		object obj5 = 0;
		object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1408;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v7+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0125;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v7+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v14-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0125;
		}
		object obj10 = obj7 + obj9;
		object obj11 = obj10 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ X0_v35] (should have been resolved before IL gen)");
		goto IL_0190;
		IL_0190:
		object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2416;
		object obj14 = default(object);
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v11+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0238;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v11+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v9-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0238;
		}
		object obj17 = obj13 + obj16;
		object obj18 = obj17 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ X8_v18] (should have been resolved before IL gen)");
		goto IL_02a3;
		IL_0238:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v341 @ X0_v27] (should have been resolved before IL gen)");
		object obj19 = default(object);
		bool flag = obj19 == null;
		object obj20 = !flag;
		if (obj20 != null)
		{
			goto IL_02a3;
		}
		goto IL_03f4;
		IL_03f4:
		throw new NullReferenceException();
		IL_02a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v12+10]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13+10]");
		object obj22 = 0;
		object obj23 = "___# Content push apply failed [{0}]: {1}" + 560;
		object obj24 = "&action=sign-up" + 144;
		object obj25 = typeof(DataRelation) + 856;
		object obj26 = typeof(SqlSingle[]) + 2376;
		object obj27 = (nint)0 + (nint)3864;
		object obj28 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v14+18]");
		string text = (string)obj23 + (string)0 + (string)obj24;
		object obj29 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj30 = !flag2;
		object message = text;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(<>c__DisplayClass54_, (IntPtr)obj27);
		object obj31 = <>c__DisplayClass54_ + 32;
		obj31 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(<>c__DisplayClass54_, (IntPtr)obj28);
		ReadyState.CallWhenReady(action2);
		return;
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ X0_v32] (should have been resolved before IL gen)");
		bool flag3 = obj14 == null;
		object obj32 = !flag3;
		if (obj32 != null)
		{
			goto IL_0190;
		}
		goto IL_03f4;
	}

	private void OnPurchaseConfirmed(Order order)
	{
	}

	private unsafe void OnPurchaseFailed(FailedOrder order)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Expected I, but got O
		//IL_0043: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_026d: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0282: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_024e: Expected O, but got I
		//IL_031e: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_040f: Expected O, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_042c: Expected O, but got I
		//IL_0381: Expected O, but got I
		//IL_0381: Expected O, but got I
		//IL_038f: Expected O, but got Ref
		ICart <CartOrdered>k__BackingField = ((Order)order).<CartOrdered>k__BackingField;
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1408;
		nint num = (nint)<CartOrdered>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00bf;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ X0_v31] (should have been resolved before IL gen)");
		goto IL_012a;
		IL_012a:
		object obj6 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2416;
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v10+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v10+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v8-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_01d2;
		}
		object obj11 = obj7 + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v24+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X8_v24] (should have been resolved before IL gen)");
		goto IL_025d;
		IL_01d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v23+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X0_v23] (should have been resolved before IL gen)");
		object obj14 = default(object);
		bool flag = obj14 == null;
		object obj15 = !flag;
		if (obj15 != null)
		{
			goto IL_025d;
		}
		goto IL_03a7;
		IL_03a7:
		throw new NullReferenceException();
		IL_025d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v5+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X23_v2+10]");
		object obj17 = 0;
		object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 2544;
		object format = "October" + 616;
		object obj19 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v12+10]");
		object arg = default(object);
		string text = string.Format((string)format, 0, arg, order.m_Details);
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj21 = !flag2;
		object obj22 = text;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = text;
		}
		KLogger.LogAnalytics(obj22);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X23_v2+10]");
		object obj23 = 0;
		object obj24 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v18+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v19+20]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v15+10]");
		ProductListingModel listing = ((ProductStore)num2).GetListing((string)0);
		object obj27 = default(object);
		string error = ((Enum)(&obj27)).ToString();
		OnPurchaseFailed(listing, error);
		return;
		IL_00bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ X0_v28] (should have been resolved before IL gen)");
		bool flag3 = obj8 == null;
		object obj28 = !flag3;
		if (obj28 != null)
		{
			goto IL_012a;
		}
		goto IL_03a7;
	}

	public unsafe void OnPurchaseFailed(int responseCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_01ab: Expected O, but got Ref
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		object obj = "October" + 608;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		int num = default(int);
		string text = num.ToString();
		string obj3 = (string)obj + text;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
		int num2;
		if ((nint)0 != 0)
		{
			KLogger.LogAnalytics(obj3);
			bool flag = num == 4;
			num2 = num;
			if (!flag)
			{
				goto IL_0056;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.LogAnalytics(obj3);
			bool flag2 = num != 4;
			num2 = num;
			if (flag2)
			{
				goto IL_0056;
			}
		}
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2544;
		object obj6 = obj5;
		goto IL_01a2;
		IL_01a2:
		string error = ((Enum)(&obj6)).ToString();
		OnPurchaseFailed(null, error);
		return;
		IL_0056:
		switch (num2)
		{
		case 1:
		{
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 2544;
			obj6 = obj9;
			break;
		}
		case 3:
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 2544;
			obj6 = obj8;
			break;
		}
		default:
		{
			object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 2544;
			obj6 = obj7;
			break;
		}
		}
		goto IL_01a2;
	}

	public void InitiateBuyingProduct(int productId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_002e: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+20]");
		int id = default(int);
		ProductViewModel product = ((ProductStore)0).GetProduct(id);
		InitiateBuyingProduct(product);
	}

	public void InitiateBuyingProduct(ProductViewModel product, GiftInfo giftInfo = null, bool showPopup = false)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		IEnumerable<object> <listings>k__BackingField = product.<listings>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		if ((nint)0 < (nint)2)
		{
			object productListing = Enumerable.First(<listings>k__BackingField);
			BuyProduct((ProductListingModel)productListing, null, giftInfo, showPopup);
			return;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 200;
		object obj2 = obj;
		if (showPopup)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PaymentMethods.ShowPaymentMethodsPopup(product, giftInfo);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PaymentMethods.ShowPaymentMethodsBottomSheet(product, giftInfo);
		}
	}

	public void InitiateBuyingOffer(int offerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I
		//IL_0054: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00c5: Expected I, but got O
		//IL_026a: Expected O, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0140: Expected I, but got O
		//IL_015b: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass60_0 <>c__DisplayClass60_ = default(<>c__DisplayClass60_0);
		<>c__DisplayClass60_..ctor();
		int offerId2 = default(int);
		<>c__DisplayClass60_.offerId = offerId2;
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+20]");
		ProductViewModel productWithOffer = ((ProductStore)0).GetProductWithOffer(offerId2);
		bool flag = productWithOffer == null;
		object obj5 = 0;
		if (!flag)
		{
			object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2840;
			object obj7 = (nint)0 + (nint)3880;
			object obj8 = (nint)0 + (nint)1072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>c__DisplayClass60_, (IntPtr)obj7);
			obj5 = obj8;
			object obj9 = Enumerable.FirstOrDefault(productWithOffer.<listings>k__BackingField, func);
			if (obj9 != null)
			{
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2624;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)3888;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)<>c__DisplayClass60_, (IntPtr)obj11);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v25 (System.Object)+40]");
				object offer = Enumerable.First((IEnumerable<object>)0, func2);
				BuyProduct((ProductListingModel)obj9, (Offer)offer);
				return;
			}
		}
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object message = "Index = {0} position = {1}" + 1736;
		object format = "___# Content push apply failed [{0}]: {1}" + 408;
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)message);
		object obj16 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		object obj19 = text;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = text;
		}
		KLogger.LogError(obj19);
	}

	private void ShowPaymentMethods(ProductViewModel product, GiftInfo giftInfo, bool showPopup)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 200;
		object obj2 = obj;
		if (showPopup)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PaymentMethods.ShowPaymentMethodsPopup(product, giftInfo);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PaymentMethods.ShowPaymentMethodsBottomSheet(product, giftInfo);
		}
	}

	public unsafe void PresentPlatformCodeRedeemSheet()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0291: Expected O, but got I4
		//IL_02c1: Expected O, but got Ref
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0101: Expected I, but got O
		//IL_0111: Expected O, but got I
		//IL_03fa: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0061;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0061;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		bool flag3 = platform == Platform.IOS;
		obj5 = obj6;
		if (flag3)
		{
			goto IL_008a;
		}
		goto IL_0243;
		IL_018d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		object obj8 = obj9;
		goto IL_03e2;
		IL_03e2:
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v19+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v245 @ X2_v4 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_008a:
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14+B8]");
		object obj14 = 0;
		IAppleStoreExtendedPurchaseService appleStoreExtendedPurchaseService = ((StoreController)obj14).AppleStoreExtendedPurchaseService;
		if (appleStoreExtendedPurchaseService == null)
		{
			return;
		}
		object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 936;
		nint num = (nint)appleStoreExtendedPurchaseService;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v18 (Il2CppClass<UnityEngine.Purchasing.IAppleStoreExtendedPurchaseService>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v18 (Il2CppClass<UnityEngine.Purchasing.IAppleStoreExtendedPurchaseService>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_018d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v18 (Il2CppClass<UnityEngine.Purchasing.IAppleStoreExtendedPurchaseService>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X10_v5-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_018d;
		}
		object obj18 = obj17 + 2;
		object obj19 = num + obj18;
		obj8 = obj19 + 312;
		goto IL_03e2;
		IL_0061:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.IOS)
		{
			goto IL_008a;
		}
		goto IL_0243;
		IL_0243:
		object obj20 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
		object message2 = "ThisIsFakeReceiptData" + 2352;
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Platform platform3 = KUtil.GetPlatform();
		object obj23 = default(object);
		string paramName = ((Enum)(&obj23)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentException ex = default(ArgumentException);
		ex..ctor((string)message2, paramName);
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogException(ex);
	}

	public void BuyProduct(string listingId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_002e: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+20]");
		string listingId2 = default(string);
		ProductListingModel listing = ((ProductStore)0).GetListing(listingId2);
		BuyProduct(listing);
	}

	public void BuyProduct(ProductListingModel productListing, Offer offer = null, GiftInfo giftInfo = null, bool usePopup = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_00db: Expected I, but got O
		//IL_00eb: Expected O, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_037b: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_025b: Expected O, but got I
		//IL_01a5: Expected I, but got O
		//IL_01b5: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0318: Expected I, but got O
		//IL_0328: Expected O, but got I
		//IL_029e: Expected O, but got I4
		//IL_053a: Expected O, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_124e: Expected O, but got Unknown
		//IL_071c: Expected O, but got I4
		//IL_0442: Expected I, but got O
		//IL_0452: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_05a3: Expected O, but got I4
		//IL_05ac: Expected O, but got I4
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected O, but got Unknown
		//IL_0900: Expected O, but got I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_05e6: Expected O, but got I
		//IL_07b4: Expected O, but got I4
		//IL_0620: Expected O, but got I
		//IL_065d: Expected O, but got I4
		//IL_0666: Expected O, but got I4
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_08c1: Expected O, but got I4
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06d7: Expected O, but got I4
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected O, but got Unknown
		//IL_12cd: Expected O, but got I
		//IL_0b32: Expected O, but got I
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected O, but got Unknown
		//IL_09a3: Expected O, but got I4
		//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f4: Expected O, but got Unknown
		//IL_140c: Expected O, but got I
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_0a16: Expected O, but got I4
		//IL_10da: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Expected O, but got Unknown
		//IL_1109: Expected O, but got I4
		//IL_139e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a3: Expected O, but got Unknown
		//IL_13bb: Expected O, but got I
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Expected O, but got Unknown
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Expected O, but got Unknown
		//IL_136a: Expected O, but got I
		//IL_0d73: Expected O, but got I4
		//IL_0a8d: Expected O, but got I
		//IL_0ee4: Expected O, but got I
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected O, but got Unknown
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		//IL_0de6: Expected O, but got I4
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected O, but got Unknown
		//IL_0bc5: Expected O, but got I4
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected O, but got Unknown
		//IL_109a: Expected O, but got I4
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Expected O, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected O, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Expected O, but got Unknown
		//IL_0c38: Expected O, but got I4
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_1306: Expected O, but got Unknown
		//IL_1330: Expected O, but got I4
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected O, but got Unknown
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_115f: Expected O, but got I
		//IL_0e5d: Expected O, but got I
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected O, but got Unknown
		//IL_0f68: Expected O, but got I4
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected O, but got Unknown
		//IL_0cc1: Expected O, but got I
		//IL_0cd2: Expected I, but got O
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected O, but got Unknown
		//IL_0fb5: Expected O, but got I
		//IL_0ea0: Expected O, but got I
		//IL_0ea0: Expected O, but got I
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Expected O, but got Unknown
		//IL_101d: Expected O, but got I4
		//IL_11ef: Expected O, but got I
		//IL_11ef: Expected O, but got I
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass64_0 <>c__DisplayClass64_ = default(<>c__DisplayClass64_0);
		<>c__DisplayClass64_..ctor();
		object obj3;
		object[] array = default(object[]);
		string text;
		object obj6 = default(object);
		Offer offer2;
		object obj15;
		object obj16;
		object obj5;
		Offer offer3;
		if (<>c__DisplayClass64_ != null)
		{
			object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
			obj3 = <>c__DisplayClass64_ + 16;
			obj3 = productListing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj4 = obj3;
			if (obj3 != null && array != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v5+18]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v5+18]");
				if ((nint)0 != 0)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v148 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					offer2 = offer;
					if (flag)
					{
						goto IL_0494;
					}
				}
				object obj7 = "___# Content push apply failed [{0}]: {1}" + 872;
				object obj8 = array + 32;
				obj8 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				text = (string)obj7;
				string text2;
				if (offer != null)
				{
					text2 = offer.<StoreOfferId>k__BackingField;
					if (offer.<StoreOfferId>k__BackingField != null)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v147 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag2 = obj6 == null;
						object obj9 = !flag2;
						if (obj9 == null)
						{
							offer2 = offer;
							goto IL_0494;
						}
					}
				}
				else
				{
					text2 = null;
				}
				object obj10 = typeof(List<Tween>) + 2432;
				object obj11 = array + 40;
				obj11 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (giftInfo != null)
				{
					object obj12 = (nint)0 + (nint)3136;
					offer2 = (Offer)obj12;
					int? num3 = giftInfo.<RecipientId>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj13 = default(object);
					bool flag3 = obj13 == null;
					object obj14 = !flag3;
					obj15 = obj13;
					if (obj14 != null)
					{
						goto IL_0310;
					}
					offer3 = (Offer)obj12;
					obj16 = obj13;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj17 = default(object);
					bool flag4 = obj17 == null;
					offer2 = offer;
					obj15 = obj17;
					offer3 = offer;
					obj16 = obj17;
					if (!flag4)
					{
						goto IL_0310;
					}
				}
				goto IL_035f;
			}
		}
		goto IL_11f5;
		IL_0310:
		nint num4 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v142 (Il2CppClass<System.Object[]>)+40]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag5 = obj6 == null;
		offer3 = offer2;
		obj16 = obj15;
		if (!flag5)
		{
			goto IL_035f;
		}
		goto IL_0494;
		IL_1285:
		object obj18;
		KLogger.LogError(obj18);
		return;
		IL_035f:
		bool flag6 = array.Length < 2;
		object obj19 = !flag6;
		object obj20 = array.Length - 2;
		bool flag7 = obj20 == null;
		object obj21 = ~obj19;
		object obj22 = obj21 | flag7;
		string text3;
		string format;
		if (obj22 == null)
		{
			object obj23 = array + 48;
			obj23 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag8 = giftInfo == null;
			offer2 = offer3;
			if (flag8)
			{
				goto IL_04ac;
			}
			text3 = giftInfo.<Message>k__BackingField;
			bool flag9 = giftInfo.<Message>k__BackingField == null;
			format = text;
			if (!flag9)
			{
				nint num5 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v140 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag10 = obj6 == null;
				object obj24 = !flag10;
				offer2 = offer3;
				format = text;
				if (obj24 == null)
				{
					goto IL_0494;
				}
			}
			goto IL_04c6;
		}
		goto IL_1203;
		IL_11f5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1203;
		IL_0ae1:
		if (offer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v14+20]");
			if ((nint)0 == 17)
			{
				object obj25 = (nint)0 + (nint)3624;
				object obj26 = obj25;
				System.Int32Enum? int32Enum = (System.Int32Enum)offer.<Type>k__BackingField;
				object obj27 = (??)int32Enum & -4294967295L;
				if ((long)obj27 == 8589934593L)
				{
					object obj28 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v73+B8]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v74+8]");
					if ((nint)0 != 0)
					{
						object obj31 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
						object obj32 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v71+E4]");
						bool flag11 = (nint)0 == 0;
						object obj33 = !flag11;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj34 = "___# Content push apply failed [{0}]: {1}" + 424;
						KLogger.Log(obj34);
						object obj35 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
						object obj36 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X0_v74+E4]");
						bool flag12 = (nint)0 == 0;
						object obj37 = !flag12;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object msgBody = "LAK" + 2136;
						PopupWindow.ShowLoading((string)msgBody, dismissible: false);
						object obj38 = obj3;
						if (obj3 != null)
						{
							object obj39 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 472;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj40 = (nint)0 + (nint)3904;
							Action<object> action = default(Action<object>);
							action..ctor((object)<>c__DisplayClass64_, (IntPtr)obj40);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v86+10]");
							KammelnaRequests.GetAppStoreDiscount(0, action);
							return;
						}
						goto IL_11f5;
					}
				}
			}
		}
		object obj41 = obj3;
		object obj46;
		object obj60;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+20]");
			if (SalesChannelsExtension.IsHuawei(SalesChannel.Sms))
			{
				object obj42 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
				object obj43 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v51+B8]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v52+18]");
				if ((nint)0 != 0)
				{
					object obj45 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X0_v57+E4]");
					bool flag13 = (nint)0 == 0;
					object obj47 = !flag13;
					if (obj47 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message = "___# Content push apply failed [{0}]: {1}" + 416;
					Debug.Log(message);
					object obj48 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
					object obj49 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v60+E4]");
					bool flag14 = (nint)0 == 0;
					object obj50 = !flag14;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object msgBody2 = "LAK" + 2136;
					PopupWindow.ShowLoading((string)msgBody2, dismissible: false);
					object obj51 = obj3;
					if (obj3 != null)
					{
						object obj52 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X9_v8+B8]");
						object obj53 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v9+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v9+18]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v62+18]");
							((HuaweiIapManager)num6).Purchase((string)0);
							return;
						}
					}
					goto IL_11f5;
				}
			}
			object obj54 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v20+B8]");
			object obj56 = 0;
			if (obj56 == null)
			{
				object obj57 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj58 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X0_v37+E4]");
				bool flag15 = (nint)0 == 0;
				object obj59 = !flag15;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj60 = "AvailableVoices" + 3128;
				goto IL_1429;
			}
			object obj61 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v28+18]");
				Product productById = ((StoreController)obj56).GetProductById((string)0);
				if (productById == null || !productById.<availableToPurchase>k__BackingField)
				{
					object obj62 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
					object obj63 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X0_v41+E4]");
					bool flag16 = (nint)0 == 0;
					object obj64 = !flag16;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj60 = "AvailableVoices" + 3136;
					goto IL_1429;
				}
				object obj65 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X0_v44+E4]");
				bool flag17 = (nint)0 == 0;
				object obj67 = !flag17;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj68 = "___# Content push apply failed [{0}]: {1}" + 432;
				KLogger.Log(obj68);
				object obj69 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X8_v41+B8]");
				object obj70 = 0;
				if (obj70 != null)
				{
					((StoreController)obj70).PurchaseProduct(productById);
					object obj71 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
					object obj72 = obj71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X0_v48+E4]");
					bool flag18 = (nint)0 == 0;
					object obj73 = !flag18;
					if (obj73 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object msgBody3 = "LAK" + 2136;
					PopupWindow.ShowLoading((string)msgBody3, dismissible: false);
					return;
				}
			}
		}
		goto IL_11f5;
		IL_0494:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_04ac;
		IL_04c6:
		obj46 = typeof(DataRelation) + 856;
		object obj74 = array + 56;
		obj74 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text4 = string.Format(format, array);
		object obj75 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v8+E4]");
		bool flag19 = (nint)0 == 0;
		object obj76 = !flag19;
		object message2 = text4;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text4;
		}
		Debug.Log(message2);
		object obj77 = this + 40;
		obj77 = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ProductListingModel productListingModel = (ProductListingModel)obj3;
		if (obj77 != null)
		{
			if (obj3 != null)
			{
				bool flag20 = !productListingModel.<isConsumable>k__BackingField;
				object obj78 = !flag20;
				object obj26 = 0;
				if (obj78 == null)
				{
					object obj79 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
					object obj80 = obj79;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v125+B8]");
					object obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v126+20]");
					if ((nint)0 == 0)
					{
						goto IL_11f5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v126+20]");
					ProductListingModel consumableVersion = ((ProductStore)0).GetConsumableVersion((ProductListingModel)obj3);
					obj3 = consumableVersion;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					productListingModel = (ProductListingModel)obj3;
					bool flag21 = obj3 == null;
					object obj82 = !flag21;
					obj26 = 0;
					if (obj82 == null)
					{
						object obj83 = "AvailableVoices" + 3144;
						string text5 = (string)obj83 + productListingModel.<listingId>k__BackingField;
						object obj84 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
						object obj85 = obj84;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v131+E4]");
						bool flag22 = (nint)0 == 0;
						object obj86 = !flag22;
						obj18 = text5;
						if (obj86 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj18 = text5;
						}
						goto IL_1285;
					}
				}
				goto IL_072a;
			}
		}
		else
		{
			bool flag23 = obj3 == null;
			object obj26 = 0;
			if (!flag23)
			{
				goto IL_072a;
			}
		}
		goto IL_11f5;
		IL_04ac:
		offer3 = offer2;
		text3 = null;
		format = text;
		goto IL_04c6;
		IL_1429:
		obj18 = obj60;
		goto IL_1285;
		IL_1203:
		throw new IndexOutOfRangeException();
		IL_072a:
		bool flag24 = SalesChannelsExtension.IsStcPay(productListingModel.<channelId>k__BackingField);
		ProductListingModel productListingModel2 = (ProductListingModel)obj3;
		if (flag24)
		{
			object obj87 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1856;
			object obj88 = obj87;
			if (usePopup)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v113+E4]");
				bool flag25 = (nint)0 == 0;
				object obj89 = !flag25;
				if (obj89 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				StcPayStore.BuyItemPopup((ProductListingModel)obj3, (GiftInfo)obj77);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v113+E4]");
				bool flag26 = (nint)0 == 0;
				object obj90 = !flag26;
				if (obj90 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				StcPayStore.BuyItemBottomSheet((ProductListingModel)obj3, (GiftInfo)obj77);
			}
			return;
		}
		if (obj3 != null)
		{
			bool flag27 = SalesChannelsExtension.IsWebPurchasable(productListingModel2.<channelId>k__BackingField);
			object obj91 = obj3;
			if (flag27)
			{
				if (obj91 != null)
				{
					int num7 = default(int);
					string text6 = num7.ToString();
					object obj92 = "https://www.kammelna.com/Home/Terms" + 16;
					string url = (string)obj92 + text6;
					object obj93 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
					object obj94 = obj93;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v118+E4]");
					bool flag28 = (nint)0 == 0;
					object obj95 = !flag28;
					if (obj95 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					KUtil.OpenURL(url);
					return;
				}
			}
			else if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v14+20]");
				if ((nint)0 != 13)
				{
					goto IL_0ae1;
				}
				object obj96 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
				object obj97 = obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v94+B8]");
				object obj98 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v95+10]");
				if ((nint)0 != 0)
				{
					object obj99 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v86+E4]");
					bool flag29 = (nint)0 == 0;
					object obj100 = !flag29;
					if (obj100 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message3 = "___# Content push apply failed [{0}]: {1}" + 400;
					Debug.Log(message3);
					object obj101 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
					object obj102 = obj101;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v89+E4]");
					bool flag30 = (nint)0 == 0;
					object obj103 = !flag30;
					if (obj103 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object msgBody4 = "LAK" + 2136;
					PopupWindow.ShowLoading((string)msgBody4, dismissible: false);
					object obj104 = obj3;
					if (obj3 != null)
					{
						object obj105 = obj96;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X9_v12+B8]");
						object obj106 = 0;
						string offerId = offer?.<StoreOfferId>k__BackingField;
						object obj107 = typeof(Queue<string>) + 848;
						object obj108 = obj107;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X0_v92+E4]");
						bool flag31 = (nint)0 == 0;
						object obj109 = !flag31;
						if (obj109 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj110 = (nint)0 + (nint)2200;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel = default(SessionModel);
						if ((object)sessionModel != null)
						{
							User localUser = sessionModel.LocalUser;
							string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v13+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v13+10]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v106+18]");
								((GooglePlayBillingManager)num8).Purchase((string)0, offerId, dbId);
								return;
							}
						}
					}
				}
				else
				{
					obj91 = obj3;
					if (obj3 != null)
					{
						goto IL_0ae1;
					}
				}
			}
		}
		goto IL_11f5;
	}

	public ProductViewModel GetProduct(int productDbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_002e: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			int id = default(int);
			return ((ProductStore)0).GetProduct(id);
		}
		return (ProductViewModel)(object)new NullReferenceException();
	}

	public ProductViewModel GetProductWithOffer(int offerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_002e: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			int offerId2 = default(int);
			return ((ProductStore)0).GetProductWithOffer(offerId2);
		}
		return (ProductViewModel)(object)new NullReferenceException();
	}

	public ProductListingModel GetListing(string listingId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_002e: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			string listingId2 = default(string);
			return ((ProductStore)0).GetListing(listingId2);
		}
		return (ProductListingModel)(object)new NullReferenceException();
	}

	public ProductMetadata GetUnityProductMetadata(string listingId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_032c: Expected O, but got I4
		//IL_04be: Expected O, but got I
		//IL_0500: Expected O, but got I
		//IL_01db: Expected O, but got I
		//IL_035c: Expected O, but got I
		//IL_042b: Expected O, but got I
		//IL_021d: Expected O, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0271: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I
		//IL_03e7: Expected O, but got I
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_040a: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7066]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v44+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		Platform platform = KUtil.GetPlatform();
		bool flag2 = platform == Platform.Web;
		object obj7 = obj6;
		if (!flag2)
		{
			goto IL_0156;
		}
		goto IL_04a6;
		IL_04a6:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v7+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+20]");
		if ((nint)0 == 0)
		{
			goto IL_0498;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+20]");
		ProductListingModel listing = ((ProductStore)0).GetListing(listingId);
		bool flag3 = listing == null;
		ProductMetadata productMetadata = (ProductMetadata)(object)listing;
		if (!flag3)
		{
			float num = default(float);
			string text = num.ToString();
			object obj10 = (nint)0 + (nint)4088;
			string priceString = text + (string)obj10;
			object obj11 = typeof(DataRelation) + 1368;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			decimal localizedPrice = (decimal)listing.<price>k__BackingField;
			object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 2104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object currencyCode = "Read object reference Id '{0}' for {1}." + 3808;
			productMetadata..ctor(priceString, listing.<description>k__BackingField, listing.<description>k__BackingField, (string)currencyCode, localizedPrice);
		}
		goto IL_04e3;
		IL_04e3:
		return productMetadata;
		IL_0498:
		return (ProductMetadata)(object)new NullReferenceException();
		IL_007d:
		obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.Web)
		{
			goto IL_0156;
		}
		obj7 = obj6;
		goto IL_04a6;
		IL_0156:
		object obj15 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			bool isEditor = Application.isEditor;
			bool flag5 = !isEditor;
			obj7 = obj6;
			if (!flag5)
			{
				goto IL_04a6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isEditor2 = Application.isEditor;
			bool flag6 = !isEditor2;
			object obj17 = !flag6;
			obj7 = obj6;
			if (obj17 != null)
			{
				goto IL_04a6;
			}
		}
		object obj18 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v25+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v26+20]");
		if ((nint)0 == 0)
		{
			goto IL_0498;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v26+20]");
		ProductListingModel listing2 = ((ProductStore)0).GetListing(listingId);
		if (listing2 != null && SalesChannelsExtension.IsHuawei(listing2.<channelId>k__BackingField))
		{
			object obj20 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v29+B8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v30+18]");
			bool flag7 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v30+18]");
			productMetadata = (ProductMetadata)0;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v30+18]");
				return ((HuaweiIapManager)0).GetProductMetadata(listingId);
			}
		}
		else
		{
			object obj22 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v27+B8]");
			object obj23 = 0;
			bool flag8 = obj23 == null;
			productMetadata = (ProductMetadata)obj23;
			if (!flag8)
			{
				Product productById = ((StoreController)obj23).GetProductById(listingId);
				bool flag9 = productById == null;
				productMetadata = (ProductMetadata)(object)productById;
				if (!flag9)
				{
					productMetadata = productById.<metadata>k__BackingField;
				}
			}
		}
		goto IL_04e3;
	}

	private void ValidateReceipt(PendingOrder order, Action confirm)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Expected I, but got O
		//IL_0043: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_026d: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0282: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_024e: Expected O, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c8: Expected O, but got I
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e4: Expected I, but got O
		//IL_02f4: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_0383: Expected O, but got I4
		//IL_0467: Expected O, but got I
		//IL_0495: Expected O, but got I4
		//IL_032f: Expected O, but got I
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		ICart <CartOrdered>k__BackingField = ((Order)order).<CartOrdered>k__BackingField;
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1408;
		nint num = (nint)<CartOrdered>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X10_v18-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00bf;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ X0_v27] (should have been resolved before IL gen)");
		goto IL_012a;
		IL_025d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v5+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v12+10]");
		object obj7 = 0;
		IOrderInfo <Info>k__BackingField = ((Order)order).<Info>k__BackingField;
		object obj8 = typeof(System.IOAsyncCallback) + 104;
		object obj9 = "___# Content push apply failed [{0}]: {1}" + 632;
		object obj10 = (nint)0 + (nint)3208;
		object obj11 = typeof(DataRelation) + 856;
		nint num2 = (nint)<Info>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v14 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v14 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0370;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v14 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X10_v8-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0370;
		}
		object obj14 = obj13 + 5;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		goto IL_0440;
		IL_03cd:
		throw new NullReferenceException();
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj17 = 5;
		goto IL_0440;
		IL_0440:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v415 @ X0_v6] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+10]");
		string text2 = default(string);
		string text = (string)obj9 + (string)0 + (string)obj10 + text2;
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj19 = !flag;
		object message = text;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		SubmitReceipt(order, confirm);
		return;
		IL_00bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ X0_v24] (should have been resolved before IL gen)");
		object obj20 = default(object);
		bool flag2 = obj20 == null;
		object obj21 = !flag2;
		if (obj21 != null)
		{
			goto IL_012a;
		}
		goto IL_03cd;
		IL_012a:
		object obj22 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2416;
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v13-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_01d2;
		}
		object obj26 = obj23 + obj25;
		object obj27 = obj26 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v21+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X8_v21] (should have been resolved before IL gen)");
		goto IL_025d;
		IL_01d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v326 @ X0_v19] (should have been resolved before IL gen)");
		object obj28 = default(object);
		bool flag3 = obj28 == null;
		object obj29 = !flag3;
		if (obj29 != null)
		{
			goto IL_025d;
		}
		goto IL_03cd;
	}

	private void SubmitReceipt(PendingOrder order, Action confirm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0069: Expected I, but got O
		//IL_0079: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_0246: Expected O, but got I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02b1: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e9: Expected I, but got O
		//IL_02f9: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_03a3: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0284: Expected O, but got I
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_0334: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_04e8: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_0479: Expected O, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_0673: Expected O, but got I
		//IL_0507: Expected O, but got I4
		//IL_0591: Expected I, but got O
		//IL_05a1: Expected O, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0559: Expected O, but got I4
		//IL_0630: Expected O, but got I4
		//IL_08e8: Expected O, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_05dc: Expected O, but got I
		//IL_06ae: Expected O, but got I
		//IL_06ae: Expected O, but got I
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_06e4: Expected O, but got I
		//IL_06ec: Expected I, but got O
		//IL_06fc: Expected O, but got I
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_078b: Expected O, but got I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_0936: Expected I, but got O
		//IL_0737: Expected O, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07c2: Expected O, but got I4
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass70_0 <>c__DisplayClass70_ = default(<>c__DisplayClass70_0);
		<>c__DisplayClass70_..ctor();
		object obj2 = <>c__DisplayClass70_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ICart <CartOrdered>k__BackingField = ((Order)order).<CartOrdered>k__BackingField;
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1408;
		nint num = (nint)<CartOrdered>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v6 (Il2CppClass<UnityEngine.Purchasing.ICart>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X10_v37-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00f5;
		}
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v361 @ X0_v57] (should have been resolved before IL gen)");
		goto IL_0160;
		IL_04ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v569 @ X0_v38] (should have been resolved before IL gen)");
		string text = default(string);
		bool flag = text == null;
		object obj8 = !flag;
		string receipt = text;
		object obj9;
		if (obj8 == null)
		{
			obj9 = 9;
			goto IL_0577;
		}
		goto IL_0877;
		IL_07c8:
		throw new NullReferenceException();
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v457 @ X0_v43] (should have been resolved before IL gen)");
		object obj10 = default(object);
		bool flag2 = obj10 == null;
		object obj11 = !flag2;
		object obj12 = 0;
		if (obj11 != null)
		{
			goto IL_0412;
		}
		obj9 = 0;
		goto IL_0577;
		IL_0877:
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v14+10]");
		object obj15 = 0;
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v18+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v19+20]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v15+10]");
		ProductListingModel listing = ((ProductStore)num2).GetListing((string)0);
		IOrderInfo <Info>k__BackingField = ((Order)order).<Info>k__BackingField;
		object obj19 = typeof(SqlSingle[]) + 2376;
		object obj20 = (nint)0 + (nint)3912;
		nint num3 = (nint)<Info>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v20 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v20 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0778;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v20 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		object obj23;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v9-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_0778;
		}
		object obj24 = obj22 + 5;
		object obj25 = num3 + obj24;
		object obj26 = obj25 + 312;
		object obj27 = 0;
		goto IL_0911;
		IL_00f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v54] (should have been resolved before IL gen)");
		object obj28 = default(object);
		bool flag3 = obj28 == null;
		object obj29 = !flag3;
		if (obj29 != null)
		{
			goto IL_0160;
		}
		goto IL_07c8;
		IL_0160:
		object obj30 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2416;
		object obj31 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v10+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0208;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v10+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X10_v32-8]");
			if (0 == (nint)obj30)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_0208;
		}
		object obj34 = obj31 + obj33;
		object obj35 = obj34 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v42+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ X8_v42] (should have been resolved before IL gen)");
		goto IL_0293;
		IL_0412:
		object obj36 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 912;
		object obj37 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v33+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v33+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04ba;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v33+B0]");
		object obj39 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X10_v22-8]");
			if (0 == (nint)obj36)
			{
				break;
			}
			obj39 += 16;
			obj38--;
			if ((nint)obj38 != 1)
			{
				continue;
			}
			goto IL_04ba;
		}
		object obj40 = obj39 + 9;
		object obj41 = obj37 + obj40;
		object obj42 = obj41 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v552 @ X8_v36] (should have been resolved before IL gen)");
		string text2 = default(string);
		bool flag4 = text2 == null;
		object obj43 = !flag4;
		obj9 = obj12;
		receipt = text2;
		if (obj43 == null)
		{
			goto IL_0577;
		}
		goto IL_0877;
		IL_0911:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v747 @ X0_v17] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(<>c__DisplayClass70_, (IntPtr)obj20);
		string transactionId = default(string);
		SubmitReceipt(listing, receipt, transactionId, confirm, action);
		return;
		IL_0577:
		IOrderInfo <Info>k__BackingField2 = ((Order)order).<Info>k__BackingField;
		nint num4 = (nint)<Info>k__BackingField2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v26 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v26 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_061d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v26 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+B0]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X10_v16-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj45 += 16;
			obj44--;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_061d;
		}
		object obj46 = obj45 + 4;
		object obj47 = num4 + obj46;
		object obj48 = obj47 + 312;
		goto IL_08a8;
		IL_08a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v666 @ X0_v30] (should have been resolved before IL gen)");
		IAPController iAPController = default(IAPController);
		string text3 = iAPController.ExtractPayload((string)(object)iAPController);
		receipt = text3;
		goto IL_0877;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v49+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v401 @ X0_v49] (should have been resolved before IL gen)");
		object obj49 = default(object);
		bool flag5 = obj49 == null;
		object obj50 = !flag5;
		if (obj50 != null)
		{
			goto IL_0293;
		}
		goto IL_07c8;
		IL_0293:
		obj14 = <>c__DisplayClass70_ + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v10+10]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IOrderInfo <Info>k__BackingField3 = ((Order)order).<Info>k__BackingField;
		obj23 = typeof(System.IOAsyncCallback) + 104;
		nint num5 = (nint)<Info>k__BackingField3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v12 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v12 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0375;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v12 (Il2CppClass<UnityEngine.Purchasing.IOrderInfo>)+B0]");
		object obj52 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v27-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj52 += 16;
			obj51--;
			if ((nint)obj51 != 1)
			{
				continue;
			}
			goto IL_0375;
		}
		object obj53 = num5 + obj52;
		object obj54 = obj53 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v488 @ X0_v46] (should have been resolved before IL gen)");
		bool flag6 = obj10 == null;
		obj9 = obj12;
		if (!flag6)
		{
			goto IL_0412;
		}
		goto IL_0577;
		IL_061d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj9 = 4;
		goto IL_08a8;
		IL_0778:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj27 = 5;
		goto IL_0911;
	}

	private void SubmitReceipt(ProductListingModel listingModel, string receipt, string transactionId, Action confirm, Action trackPurchase)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0191: Expected O, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		//IL_01e3: Expected I, but got O
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0110: Expected I, but got O
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_0223: Expected I, but got O
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_013f: Expected O, but got I
		//IL_0150: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass71_0 <>c__DisplayClass71_ = default(<>c__DisplayClass71_0);
		<>c__DisplayClass71_..ctor();
		object obj2 = <>c__DisplayClass71_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = <>c__DisplayClass71_ + 24;
		obj3 = listingModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = <>c__DisplayClass71_ + 32;
		obj4 = confirm;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = <>c__DisplayClass71_ + 40;
		obj5 = trackPurchase;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+35]");
		if ((nint)0 == 1)
		{
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3920;
			Action<long> action = default(Action<long>);
			action..ctor((object)<>c__DisplayClass71_, (IntPtr)obj8);
			object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3928;
			Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
			action2..ctor((object)<>c__DisplayClass71_, (IntPtr)obj10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+20]");
			KammelnaRequests.BuyConsumable(SalesChannel.Sms, receipt, transactionId, _giftInfo, action, (Action<KammelnaError>)(object)action2);
		}
		else
		{
			object obj11 = this + 40;
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = obj3;
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3936;
			Action<bool> action3 = default(Action<bool>);
			action3..ctor((object)<>c__DisplayClass71_, (IntPtr)obj14);
			object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)3944;
			Action<System.Int32Enum> action4 = default(Action<System.Int32Enum>);
			action4..ctor((object)<>c__DisplayClass71_, (IntPtr)obj16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v5+20]");
			KammelnaRequests.BuySubscription(SalesChannel.Sms, receipt, transactionId, action3, (Action<KammelnaError>)(object)action4);
		}
	}

	private void OnServerSuccess(ProductListingModel listingModel, Action confirm, Action trackPurchase, int recipientId)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: confirm.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj = "Picking audio files is not supported on iOS" + 2864;
		object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1864;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		string text = (string)obj + listingModel.<listingId>k__BackingField + (string)obj2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = text;
		}
		KLogger.Log(obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: trackPurchase.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		GiftInfo giftInfo = _giftInfo;
		GiftInfo giftInfo2 = ((_giftInfo == null) ? null : ((giftInfo.<RecipientId>k__BackingField != recipientId) ? null : _giftInfo));
		OnPurchaseCompleted(listingModel, giftInfo2);
	}

	private unsafe void OnServerError(ProductListingModel listingModel, Action confirm, KammelnaError responseErrorCode, string message)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a9: Expected O, but got Ref
		//IL_00e4: Expected O, but got I4
		if (responseErrorCode == KammelnaError.AlreadyProcessed)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: confirm.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = default(object);
		string errorCode = ((Enum)(&obj3)).ToString();
		ITrackEvent trackEvent = TrackerLibrary.DevPurchaseServerError(errorCode);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		OnPurchaseFailed(listingModel, friendlyName);
	}

	private void OnPurchaseCompleted(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0112: Expected O, but got I4
		//IL_0342: Expected O, but got I4
		//IL_034b: Expected O, but got I4
		//IL_0354: Expected O, but got I4
		//IL_02c2: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_03e5: Expected O, but got I4
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7068]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v44+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		bool flag2 = giftInfo == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_0120;
		}
		goto IL_01db;
		IL_01db:
		IAPAction onIAPPurchaseComplete = this.OnIAPPurchaseComplete;
		if (this.OnIAPPurchaseComplete != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		object format = "___# Content push apply failed [{0}]: {1}" + 544;
		object obj6 = typeof(DataRelation) + 856;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		string message = string.Format((string)format, listing.<listingId>k__BackingField, giftInfo);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+E4]");
		object obj11;
		object obj10;
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			obj10 = 0;
			obj11 = 0;
			if (!flag3)
			{
				goto IL_02d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			obj10 = 0;
			obj11 = 0;
			if (obj12 != null)
			{
				goto IL_02d9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		bool flag5 = platform != Platform.IOS;
		obj10 = obj11;
		if (flag5)
		{
			return;
		}
		goto IL_03a2;
		IL_03a2:
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v11+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v12+8]");
		if ((nint)0 != 0)
		{
			object obj16 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v9+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message2 = "___# Content push apply failed [{0}]: {1}" + 344;
			Debug.Log(message2);
			CheckAppStoreIntroductoryOfferEligibility();
		}
		return;
		IL_02d9:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.IOS)
		{
			return;
		}
		goto IL_03a2;
		IL_0074:
		PopupWindow.DismissMessage();
		bool flag7 = giftInfo == null;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			goto IL_0120;
		}
		goto IL_01db;
		IL_0120:
		ProductViewModel product = listing.getProduct();
		bool isSubscription = product.IsSubscription;
		ProductViewModel product2 = listing.getProduct();
		if (isSubscription)
		{
			int? daysAdded = product2.<days>k__BackingField;
			ShowUpdatedSubscriptionPopup(daysAdded);
		}
		else if (product2.IsCoins)
		{
			ProductViewModel product3 = listing.getProduct();
			ShowUpdatedAcesPopup(product3.<coins>k__BackingField);
		}
		goto IL_01db;
	}

	private unsafe void OnPurchaseFailed(ProductListingModel listing, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Expected O, but got Ref
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 552;
		PopupWindow.DismissMessage();
		object obj5 = default(object);
		string text = ((Enum)(&obj5)).ToString();
		if (error != text)
		{
			IAPFailure onIAPPurchaseFailed = this.OnIAPPurchaseFailed;
			if (this.OnIAPPurchaseFailed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v87.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		object obj6 = "&action=sign-up" + 3808;
		object obj7 = typeof(DataRelation) + 856;
		string text2 = listing?.<listingId>k__BackingField;
		string text3 = (string)obj4 + text2 + (string)obj6 + error;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object message = text3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text3;
		}
		Debug.LogError(message);
	}

	private static void ShowUpdatedSubscriptionPopup(int? daysAdded)
	{
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
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
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected O, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
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
		//IL_048b: Expected O, but got I4
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0542: Expected O, but got I
		//IL_0404: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected I, but got Unknown
		//IL_036e: Expected O, but got I
		//IL_010f: Expected I, but got O
		//IL_011f: Expected I8, but got I
		//IL_0148: Expected I8, but got I
		//IL_05e0: Expected O, but got I
		//IL_0611: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_057d: Expected O, but got I
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected I, but got Unknown
		//IL_04e7: Expected O, but got I
		//IL_062f: Expected I, but got O
		//IL_063f: Expected O, but got I
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I4
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected I, but got Unknown
		//IL_0714: Expected O, but got I
		//IL_0738: Expected O, but got I4
		//IL_0748: Expected O, but got I
		//IL_067a: Expected O, but got I
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		object obj = (??)daysAdded & 1;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v33+E4]");
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
				goto IL_0756;
			}
			bool flag3 = text == null;
			long num3 = value;
			if (!flag3)
			{
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
				num3 = 0L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
				long num5 = 0L;
				if (flag4)
				{
					goto IL_07a8;
				}
			}
			if (array.Length == 0)
			{
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				long num5 = num3;
				goto IL_07a8;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v12-8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag7 = obj15 == null;
			obj13 = obj12;
			if (!flag7)
			{
				goto IL_039d;
			}
		}
		goto IL_0756;
		IL_0516:
		object obj16 = typeof(System.IOAsyncCallback) + 368;
		object obj18 = default(object);
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v19+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v19+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05c6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v19+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X10_v2-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj12 = obj13 + 16;
			obj19--;
			bool flag8 = (nint)obj19 != 1;
			obj13 = obj12;
			if (flag8)
			{
				continue;
			}
			goto IL_05c6;
		}
		object obj20 = obj13 + 6;
		object obj21 = obj17 + obj20;
		num2 = (nint)(obj21 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag9 = ex2 == null;
		object obj23 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		if (obj23 != null)
		{
			goto IL_0627;
		}
		goto IL_0756;
		IL_044d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v19 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v472 @ X0_v19 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag10 = obj18 == null;
		object obj24 = !flag10;
		if (obj24 != null)
		{
			goto IL_0516;
		}
		obj13 = obj12;
		IntPtr intPtr = default(IntPtr);
		num2 = intPtr;
		goto IL_0756;
		IL_0627:
		num2 = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X10_v2-8]");
			bool flag11 = 0 == (nint)obj16;
			obj7 = obj22;
			if (flag11)
			{
				break;
			}
			obj13 += 16;
			obj25--;
			if ((nint)obj25 != 1)
			{
				continue;
			}
			goto IL_06bb;
		}
		goto IL_0764;
		IL_06bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj7 = 9;
		object obj27 = default(object);
		object obj26 = obj27;
		goto IL_0881;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v23 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ X0_v23 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag12 = obj15 == null;
		object obj28 = !flag12;
		obj12 = obj13;
		if (obj28 != null)
		{
			goto IL_039d;
		}
		IntPtr intPtr2 = default(IntPtr);
		num2 = intPtr2;
		goto IL_0756;
		IL_0881:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ X8_v3] (should have been resolved before IL gen)");
		return;
		IL_039d:
		object obj29 = typeof(System.IOAsyncCallback) + 384;
		object obj30 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v17+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_044d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v17+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X10_v2-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			obj12 = obj13 + 16;
			obj31--;
			bool flag13 = (nint)obj31 != 1;
			obj13 = obj12;
			if (flag13)
			{
				continue;
			}
			goto IL_044d;
		}
		object obj32 = obj13 + 1;
		object obj33 = obj30 + obj32;
		num2 = (nint)(obj33 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag14 = obj18 == null;
		obj12 = obj13;
		if (!flag14)
		{
			goto IL_0516;
		}
		goto IL_0756;
		IL_05c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v15 (Il2CppClass<System.NullReferenceException>)+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v541 @ X0_v15 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag15 = ex2 == null;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v15 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		IntPtr intPtr3 = default(IntPtr);
		num2 = intPtr3;
		if (!flag15)
		{
			goto IL_0627;
		}
		goto IL_0756;
		IL_07a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0764:
		object obj34 = obj13 + 9;
		object obj35 = num2 + obj34;
		obj26 = obj35 + 312;
		goto IL_0881;
		IL_0756:
		ex2 = new NullReferenceException();
		goto IL_0764;
	}

	private static void ShowUpdatedAcesPopup(int coinsAdded)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06c5: Expected O, but got I4
		//IL_0035: Expected I8, but got I4
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_0637: Expected O, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a8: Expected I, but got O
		//IL_00b8: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected I, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_01a9: Expected I, but got O
		//IL_01b9: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I
		//IL_033d: Expected I, but got O
		//IL_0361: Expected O, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_0408: Expected O, but got I
		//IL_02e2: Expected O, but got I
		//IL_0443: Expected O, but got I
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03ad: Expected I, but got O
		//IL_04d5: Expected I, but got O
		//IL_04e5: Expected O, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0583: Expected O, but got I
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected I, but got Unknown
		//IL_05da: Expected O, but got I4
		//IL_0520: Expected O, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "AvailableVoices" + 3920;
		object buttonText = "DNQUALIFIER" + 3784;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize((string)input, coinsAdded);
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(null, (string)buttonText);
		if (popupWindowBuilderNeedsTitle == null)
		{
			goto IL_05e8;
		}
		object obj4 = typeof(System.IOAsyncCallback) + 392;
		object obj5 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3560;
		object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
		nint num2 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_013c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		object obj9 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X10_v24-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj9 = obj8 + 16;
			obj7--;
			bool flag2 = (nint)obj7 != 1;
			obj8 = obj9;
			if (flag2)
			{
				continue;
			}
			goto IL_013c;
		}
		object obj10 = num2 + obj8;
		num = (nint)(obj10 + 312);
		obj9 = obj8;
		goto IL_06f7;
		IL_0641:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		object obj12 = default(object);
		object obj11 = obj12;
		goto IL_0657;
		IL_0657:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_048c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v490 @ X0_v29 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag3 = ex2 == null;
		object obj13;
		obj9 = obj13;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag3)
		{
			goto IL_04cd;
		}
		goto IL_05e8;
		IL_04cd:
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0561;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj9 = (nint)0 + (nint)8;
		object obj15;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v16-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj9 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0561;
		}
		goto IL_05f6;
		IL_0561:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj17 = default(object);
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v27+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v357 @ X2_v12 (should have been resolved before IL gen)");
		goto IL_058d;
		IL_05f6:
		object obj19 = obj9 + 9;
		object obj20 = num + obj19;
		object obj21 = obj20 + 312;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v6+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v294 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_0641;
		IL_05e8:
		ex2 = new NullReferenceException();
		goto IL_05f6;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_06f7;
		IL_06f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj32 = default(object);
		if (array != null)
		{
			bool flag4 = text == null;
			obj12 = 1;
			if (!flag4)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
				obj11 = 0;
				if (flag5)
				{
					goto IL_0657;
				}
			}
			num = array.Length;
			if (array.Length == 0)
			{
				goto IL_0641;
			}
			object text2 = "SubscribeGroup request Error" + 168;
			object obj24 = array + 32;
			obj24 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text2, array);
			object obj25 = default(object);
			if (obj25 != null)
			{
				object obj26 = typeof(System.IOAsyncCallback) + 384;
				object obj27 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v17+12E]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v17+12E]");
				if ((nint)0 == 0)
				{
					goto IL_032b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v17+B0]");
				obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v11-8]");
					if (0 == (nint)obj26)
					{
						break;
					}
					obj9 = obj13 + 16;
					obj28--;
					bool flag6 = (nint)obj28 != 1;
					obj13 = obj9;
					if (flag6)
					{
						continue;
					}
					goto IL_032b;
				}
				object obj29 = obj13 + 1;
				object obj30 = obj27 + obj29;
				object obj31 = obj30 + 312;
				num = (nint)obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v451 @ X0_v37] (should have been resolved before IL gen)");
				bool flag7 = obj32 == null;
				obj9 = obj13;
				if (!flag7)
				{
					goto IL_03dc;
				}
			}
		}
		goto IL_05e8;
		IL_032b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj33 = default(object);
		num = (nint)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v434 @ X0_v34] (should have been resolved before IL gen)");
		bool flag8 = obj32 == null;
		object obj34 = !flag8;
		obj13 = obj9;
		if (obj34 != null)
		{
			goto IL_03dc;
		}
		goto IL_05e8;
		IL_058d:
		object obj35 = obj9 + 6;
		object obj37;
		object obj36 = obj37 + obj35;
		num = (nint)(obj36 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag9 = ex2 == null;
		object obj38 = !flag9;
		if (obj38 != null)
		{
			goto IL_04cd;
		}
		goto IL_05e8;
		IL_03dc:
		obj15 = typeof(System.IOAsyncCallback) + 368;
		obj37 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v19+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v19+12E]");
		if ((nint)0 == 0)
		{
			goto IL_048c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v19+B0]");
		obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v16-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj13 = obj9 + 16;
			obj39--;
			bool flag10 = (nint)obj39 != 1;
			obj9 = obj13;
			if (flag10)
			{
				continue;
			}
			goto IL_048c;
		}
		goto IL_058d;
	}

	private string ExtractPayload(string receipt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_016a: Expected I, but got O
		//IL_017a: Expected O, but got I
		//IL_018a: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7018]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		JsonData jsonData = JsonMapper.ToObject(receipt);
		if (jsonData != null)
		{
			goto IL_0125;
		}
		goto IL_0194;
		IL_0194:
		return (string)(object)new NullReferenceException();
		IL_0125:
		object prop_name = "October" + 3648;
		JsonData jsonData2 = jsonData.get_Item((string)prop_name);
		if (jsonData2 != null)
		{
			nint num = (nint)jsonData2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6 (Il2CppClass<SFSLitJson.JsonData>)+168]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6 (Il2CppClass<SFSLitJson.JsonData>)+170]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X2_v3 (should have been resolved before IL gen)");
		}
		goto IL_0194;
		IL_0074:
		jsonData = JsonMapper.ToObject(receipt);
		bool flag2 = jsonData == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_0125;
		}
		goto IL_0194;
	}

	private void TrackPurchase(Product purchasedProduct)
	{
		ProductDefinition <definition>k__BackingField = purchasedProduct.<definition>k__BackingField;
		TrackPurchase(<definition>k__BackingField.<id>k__BackingField, purchasedProduct.<metadata>k__BackingField);
	}

	private void TrackPurchase(string listingId)
	{
		ProductMetadata unityProductMetadata = GetUnityProductMetadata(listingId);
		((IAPController)(object)unityProductMetadata).TrackPurchase(listingId, unityProductMetadata);
	}

	private void TrackPurchase(string listingId, ProductMetadata metadata)
	{
		//IL_0016: Expected O, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_010f: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I4
		//IL_056d: Expected O, but got I4
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05cb: Expected O, but got I4
		//IL_05d0: Expected I, but got O
		//IL_05d9: Expected O, but got I4
		//IL_04b1: Expected O, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ef: Expected O, but got I4
		//IL_0514: Expected O, but got I
		//IL_040e: Expected O, but got I4
		//IL_045d: Expected O, but got I4
		//IL_0466: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_025a: Expected I, but got O
		//IL_02e8: Expected O, but got I4
		//IL_0342: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7069]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7065]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7065]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v22+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v23+20]");
		ProductStore productStore = (ProductStore)0;
		goto IL_0172;
		IL_024b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num = unchecked((nint)null);
		string text2;
		string text = text2;
		object obj10;
		object obj9 = obj10;
		decimal num3;
		decimal num2 = num3;
		object obj12;
		object obj11 = obj12;
		goto IL_05e7;
		IL_05e7:
		double price = (double)num2;
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v8+E4]");
		TrackerPurchase type;
		string text3 = default(string);
		bool isCoins;
		if ((nint)0 != 0)
		{
			Tracker.PurchaseEvent(type, text3, price, text);
			bool flag3 = !isCoins;
			object obj14 = 0;
			string text4 = text;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.PurchaseEvent(type, text3, price, text);
			bool flag4 = !isCoins;
			object obj15 = !flag4;
			object obj14 = 0;
			string text4 = text;
			if (obj15 == null)
			{
				return;
			}
		}
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string itemId = Tracker.BuildItemId(ResourceItemId.AcesPack, text3);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		ProductViewModel product;
		Tracker.ResourceEvent(ResourceFlowType.Source, ResourceItemType.IAP, itemId, product.<coins>k__BackingField, ResourceCurrency.Aces);
		return;
		IL_0172:
		ProductListingModel listing = productStore.GetListing(text3);
		product = listing.getProduct();
		object obj18 = "Read object reference Id '{0}' for {1}." + 3808;
		object obj19 = typeof(DataRelation) + 1368;
		isCoins = product.IsCoins;
		type = (isCoins ? TrackerPurchase.AcesPack : TrackerPurchase.Subscriptions);
		if (metadata != null)
		{
			num3 = metadata.<localizedPrice>k__BackingField;
			text2 = (string)((metadata.<isoCurrencyCode>k__BackingField != null) ? metadata.<isoCurrencyCode>k__BackingField : obj18);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [metadata @ X2 (UnityEngine.Purchasing.ProductMetadata)+38]");
			obj10 = 0;
			obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			string text5 = null;
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
			text = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [metadata @ X2 (UnityEngine.Purchasing.ProductMetadata)+38]");
			obj9 = 0;
			num2 = num3;
			obj11 = obj12;
			if (obj21 == null)
			{
				goto IL_024b;
			}
		}
		else
		{
			object obj22 = "___# Content push apply failed [{0}]: {1}" + 520;
			object obj23 = "&action=sign-up" + 1040;
			string text5 = (string)obj23;
			string text6 = (string)obj22 + text3 + (string)obj23;
			object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			object obj27 = text6;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj27 = text6;
			}
			KLogger.LogError(obj27);
			text = (string)obj18;
			object obj28 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num2 = (decimal)listing.<price>k__BackingField;
			obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			num = unchecked((nint)null);
			obj9 = 0;
			if (obj30 == null)
			{
				text2 = text;
				obj10 = 0;
				num3 = num2;
				obj12 = obj11;
				goto IL_024b;
			}
		}
		goto IL_05e7;
		IL_0082:
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v27+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v28+20]");
		productStore = (ProductStore)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v28+20]");
		bool flag10 = (nint)0 == 0;
		object obj33 = !flag10;
		if (obj33 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0172;
	}

	public IAPController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(Queue<string>) + 752;
		object obj3 = (nint)0 + (nint)2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj4 = this + 32;
		obj4 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	private void <Start>b__25_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2856;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
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
		Store.CallWhenLoaded(action);
	}

	private unsafe void <Start>b__25_1()
	{
		//IL_0055: Expected O, but got I
		//IL_006d: Expected O, but got Ref
		//IL_0014: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<InitializePurchasing>d__26 stateMachine = default(<InitializePurchasing>d__26);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
		InitializeStoreKitManager();
		InitializeGooglePlayBillingManager();
		InitializeHuaweiIapManager();
	}

	private void <CheckAppStoreIntroductoryOfferEligibility>b__30_0(KammelnaResponseModel<bool> response)
	{
		//IL_0011: Expected O, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			object obj2 = typeof(DataRelation) + 856;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = "_InputUv1BufferOffset" + 4080;
			Debug.Log(obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
			((IAPController)obj5).OnIntroOfferEligibilityChecked(isEligible: false);
			return;
		}
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "_InputUv1BufferOffset" + 4072;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = text;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = text;
		}
		KLogger.LogError(obj10);
		object obj11 = typeof(DataRelation) + 712;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		object obj14 = typeof(UsageHint) + 72;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v18+E4]");
		if ((nint)0 != 0)
		{
			UserInfo.LastIntroEligibilityCheck = utcNow;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserInfo.LastIntroEligibilityCheck = utcNow;
	}
}
