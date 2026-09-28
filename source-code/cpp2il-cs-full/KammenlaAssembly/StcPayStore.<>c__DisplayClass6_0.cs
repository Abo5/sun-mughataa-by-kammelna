using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Server.Models.Products;
using Spine;
using UnityEngine;

public class StcPayStore : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public ProductListingModel listing;

		public GiftInfo giftInfo;

		internal void <BuyItemBottomSheet>b__0(StcPayStore ui)
		{
			ui.ShowFor(listing, giftInfo);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public ProductListingModel listing;

		public GiftInfo giftInfo;

		internal void <BuyItemPopup>b__0(StcPayStore ui)
		{
			ui.Popup(listing, giftInfo);
		}
	}

	private static readonly AddressReference<StcPayStore> PopupAddress;

	private static readonly AddressReference<StcPayStore> BottomSheetAddress;

	private GameObject blocker;

	private PopupUI popup;

	private SlideAnimationHelper slider;

	private StcPurchaseControllerUi panel;

	public static void BuyItemBottomSheet(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_0188: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1856;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3528;
		object obj5 = (nint)0 + (nint)1192;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		object obj11 = (nint)0 + (nint)2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	public static void BuyItemPopup(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_0188: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1856;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3528;
		object obj5 = (nint)0 + (nint)1200;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		object obj11 = (nint)0 + (nint)2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Popup(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		blocker.SetActive(value: true);
		popup.PopFromCenter();
		StcPurchaseControllerUi stcPurchaseControllerUi = panel;
		object obj = panel + 112;
		obj = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = panel + 120;
		obj2 = listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		panel.ResetUi(withData: true);
		stcPurchaseControllerUi.productUi.PopulateListing((ProductListingModel)obj2, giftInfo);
	}

	private void ShowFor(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		blocker.SetActive(value: true);
		slider.SlideIn();
		StcPurchaseControllerUi stcPurchaseControllerUi = panel;
		object obj = panel + 112;
		obj = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = panel + 120;
		obj2 = listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		panel.ResetUi(withData: true);
		stcPurchaseControllerUi.productUi.PopulateListing((ProductListingModel)obj2, giftInfo);
	}

	public void CloseBottomSheet()
	{
		blocker.SetActive(value: false);
		slider.SlideOut();
	}

	static StcPayStore()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		object obj = "SERVICE_DISABLED" + 1104;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3184;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1856;
		object obj4 = "SERVICE_DISABLED" + 1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj5 = obj3;
		object obj7 = default(object);
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+B8]");
		object obj9 = (nint)0 + (nint)8;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
