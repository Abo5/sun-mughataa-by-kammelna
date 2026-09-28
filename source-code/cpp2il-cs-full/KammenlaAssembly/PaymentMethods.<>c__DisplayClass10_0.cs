using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Features.GameReplay;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Server.Models.Products;
using UnityEngine;

public class PaymentMethods : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public ProductViewModel product;

		public GiftInfo giftInfo;

		internal void <ShowPaymentMethodsPopup>b__0(PaymentMethods instance)
		{
			instance.blocker.SetActive(value: true);
			instance.popup.PopFromCenter();
			instance.panel.Setup(product, giftInfo, usePopup: true);
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public ProductViewModel product;

		public GiftInfo giftInfo;

		internal void <ShowPaymentMethodsBottomSheet>b__0(PaymentMethods instance)
		{
			instance.blocker.SetActive(value: true);
			instance.slider.SlideIn();
			instance.panel.Setup(product, giftInfo, usePopup: false);
		}
	}

	private static readonly AddressReference<PaymentMethods> PopupAddress;

	private static readonly AddressReference<PaymentMethods> BottomSheetAddress;

	private PopupUI popup;

	private SlideAnimationHelper slider;

	private PaymentMethodsManager panel;

	private GameObject blocker;

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
		object obj4 = (nint)0 + (nint)3040;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPAction iAPAction = default(IAPController.IAPAction);
		iAPAction..ctor(this, (IntPtr)obj4);
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseComplete += iAPAction;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
		object obj4 = (nint)0 + (nint)3040;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPAction iAPAction = default(IAPController.IAPAction);
		iAPAction..ctor(this, (IntPtr)obj4);
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseComplete -= iAPAction;
	}

	public void CloseBottomSheet()
	{
		blocker.SetActive(value: false);
		slider.SlideOut();
	}

	public void ClosePopup()
	{
		blocker.SetActive(value: false);
		popup.ShrinkToParent();
	}

	public static void ShowPaymentMethodsPopup(ProductViewModel product, GiftInfo giftInfo)
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
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 200;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2944;
		object obj5 = (nint)0 + (nint)376;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = product;
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
		object obj11 = (nint)0 + (nint)2208;
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

	public static void ShowPaymentMethodsBottomSheet(ProductViewModel product, GiftInfo giftInfo)
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
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 200;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2944;
		object obj5 = (nint)0 + (nint)384;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = product;
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
		object obj11 = (nint)0 + (nint)2208;
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

	private void Popup(ProductViewModel product, GiftInfo giftInfo)
	{
		blocker.SetActive(value: true);
		popup.PopFromCenter();
		panel.Setup(product, giftInfo, usePopup: true);
	}

	private void ShowFor(ProductViewModel product, GiftInfo giftInfo)
	{
		blocker.SetActive(value: true);
		slider.SlideIn();
		panel.Setup(product, giftInfo, usePopup: false);
	}

	private void OnIAPPurchaseComplete(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01f9: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_034d: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_0300: Expected O, but got I4
		//IL_03a8: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79B8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = blocker;
			obj6 = blocker;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = blocker;
			obj6 = blocker;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_0259;
		IL_01bd:
		slider.SlideOut();
		return;
		IL_0197:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_01bd;
		}
		return;
		IL_0376:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_01bd;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_0259;
		IL_0259:
		blocker.SetActive(value: false);
		UnityEngine.Object obj12 = popup;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj14 = !flag10;
		GiftInfo giftInfo2 = null;
		GiftInfo giftInfo3 = null;
		flag5 = false;
		UnityEngine.Object obj15 = popup;
		if (obj14 != null)
		{
			goto IL_0114;
		}
		goto IL_02c8;
		IL_00cb:
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v11+E4]");
		bool flag11 = (nint)0 == 0;
		obj12 = popup;
		giftInfo3 = giftInfo2;
		obj15 = popup;
		if (!flag11)
		{
			goto IL_0114;
		}
		goto IL_02c8;
		IL_02c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = obj15;
		bool flag13 = !flag12;
		giftInfo2 = giftInfo3;
		object obj16 = 0;
		if (flag13)
		{
			goto IL_0156;
		}
		goto IL_030e;
		IL_0114:
		bool flag14 = obj12;
		bool flag15 = !flag14;
		object obj17 = !flag15;
		obj16 = 0;
		giftInfo3 = giftInfo2;
		if (obj17 == null)
		{
			goto IL_0156;
		}
		goto IL_030e;
		IL_030e:
		popup.ShrinkToParent();
		obj8 = slider;
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v4+E4]");
		bool flag16 = (nint)0 == 0;
		object obj19 = !flag16;
		giftInfo2 = giftInfo3;
		obj16 = 0;
		obj9 = slider;
		if (obj19 != null)
		{
			goto IL_0197;
		}
		goto IL_0376;
		IL_0156:
		obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v4+E4]");
		bool flag17 = (nint)0 == 0;
		obj8 = slider;
		obj9 = slider;
		if (!flag17)
		{
			goto IL_0197;
		}
		goto IL_0376;
	}

	static PaymentMethods()
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
		object obj = "October" + 3664;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3112;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 200;
		object obj4 = "October" + 3656;
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
