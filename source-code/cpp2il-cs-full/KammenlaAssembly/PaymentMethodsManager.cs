using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models.Products;
using UnityEngine;

public class PaymentMethodsManager : MonoBehaviour
{
	private StoreProductUi productUi;

	private GameObject listingParent;

	private StoreProductUi AndroidListingTemplate;

	private StoreProductUi IosListingTemplate;

	private StoreProductUi HuaweiListingTemplate;

	private StoreProductUi StcPayListingTemplate;

	private StoreProductUi TwoCoListingTemplate;

	public void Setup(ProductViewModel product, GiftInfo giftInfo, bool usePopup)
	{
		//IL_0030: Expected I, but got O
		//IL_0077: Expected I, but got O
		//IL_00b5: Expected I, but got O
		//IL_00ef: Expected I, but got O
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_0155: Expected I, but got O
		//IL_01a0: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_02ab: Expected I, but got O
		bool flag = (object)productUi == null;
		bool flag2 = usePopup;
		GiftInfo giftInfo2 = giftInfo;
		ProductViewModel productViewModel = product;
		object obj3 = default(object);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			productUi.PopulateProduct(product);
			bool flag3 = (object)listingParent == null;
			nint num = unchecked((nint)null);
			flag2 = false;
			giftInfo2 = null;
			productViewModel = product;
			if (!flag3)
			{
				Transform transform = listingParent.transform;
				bool flag4 = (object)transform == null;
				num = unchecked((nint)null);
				flag2 = false;
				giftInfo2 = null;
				productViewModel = null;
				if (!flag4)
				{
					transform.DetachChildren();
					bool flag5 = product == null;
					num = unchecked((nint)null);
					flag2 = false;
					giftInfo2 = null;
					productViewModel = null;
					if (!flag5)
					{
						bool flag6 = product.<listings>k__BackingField == null;
						num = unchecked((nint)null);
						flag2 = false;
						giftInfo2 = null;
						productViewModel = null;
						if (!flag6)
						{
							object obj = typeof(MemberAchievementClanFeedData) + 2976;
							object obj2 = (nint)0 + (nint)728;
							obj3 = (nint)0 + (nint)256;
							List<object>.Enumerator enumerator = ((List<object>)(object)product.<listings>k__BackingField).GetEnumerator();
							num = unchecked((nint)null);
							flag2 = false;
							GiftInfo giftInfo3 = null;
							List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
							ProductListingModel productListingModel = default(ProductListingModel);
							StoreProductUi storeProductUi = default(StoreProductUi);
							while (true)
							{
								if (enumerator2.MoveNext())
								{
									StoreProductUi template = GetTemplate(productListingModel);
									object obj4 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v27+E4]");
									bool flag7 = (nint)0 == 0;
									object obj5 = !flag7;
									if (obj5 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag8 = template != null;
									bool flag9 = !flag8;
									giftInfo3 = null;
									if (!flag9)
									{
										if ((object)listingParent == null)
										{
											NullReferenceException ex = new NullReferenceException();
											giftInfo2 = null;
											productViewModel = null;
											break;
										}
										Transform transform2 = listingParent.transform;
										object obj6 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v35+E4]");
										bool flag10 = (nint)0 == 0;
										object obj7 = !flag10;
										if (obj7 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										giftInfo2 = (GiftInfo)obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
										if ((object)storeProductUi == null)
										{
											NullReferenceException ex2 = new NullReferenceException();
											productViewModel = (ProductViewModel)(object)transform2;
											break;
										}
										storeProductUi.PopulateListing(productListingModel, giftInfo, usePopup);
										num = unchecked((nint)null);
										flag2 = usePopup;
										giftInfo3 = giftInfo;
									}
									continue;
								}
								enumerator2.Dispose();
								return;
							}
							List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
							enumerator3 = enumerator4;
							enumerator4 = (List<object>.Enumerator)0;
						}
					}
				}
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		bool flag11 = (nint)productViewModel != 1;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			productViewModel = (ProductViewModel)obj3;
			enumerator3.Dispose();
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			ex4 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223AC38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private StoreProductUi GetTemplate(ProductListingModel listingModel)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		if (listingModel != null)
		{
			if (SalesChannelsExtension.IsGooglePlay(listingModel.<channelId>k__BackingField))
			{
				return AndroidListingTemplate;
			}
			if (SalesChannelsExtension.IsIOS(listingModel.<channelId>k__BackingField))
			{
				return IosListingTemplate;
			}
			if (SalesChannelsExtension.IsHuawei(listingModel.<channelId>k__BackingField))
			{
				return HuaweiListingTemplate;
			}
			if (SalesChannelsExtension.IsStcPay(listingModel.<channelId>k__BackingField))
			{
				return StcPayListingTemplate;
			}
			if (SalesChannelsExtension.IsWebPurchasable(listingModel.<channelId>k__BackingField))
			{
				return TwoCoListingTemplate;
			}
			object obj = typeof(RegisteredWaitHandle) + 2736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "___# Content push apply failed [{0}]: {1}" + 584;
			object arg = default(object);
			string text = string.Format((string)format, arg);
			object obj2 = typeof(DataRelation) + 856;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object message = text;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.LogError(message);
			return null;
		}
		return (StoreProductUi)(object)new NullReferenceException();
	}
}
