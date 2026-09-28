using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.WebRequests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models.Products;
using Server.Models.StcPay;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class StcPurchaseControllerUi : MonoBehaviour
{
	public delegate void StcPurchaseSuccessCallback(ProductListingModel listing);

	private sealed class <>c__DisplayClass30_0
	{
		public CanvasGroup nextStep;

		internal void <MoveNext>b__0()
		{
			nextStep.blocksRaycasts = true;
		}
	}

	private GameObject loadingIndicator;

	private CanvasGroup step1;

	private CanvasGroup step2;

	private CanvasGroup step3;

	private RectTransform contentPanel;

	private float stepHeight1;

	private float stepHeight2;

	private float stepHeight3;

	private StoreProductUi productUi;

	private InputFieldTMProUGUI phoneNumber;

	private InputFieldTMProUGUI otpCode;

	private GiftInfo _giftInfo;

	private ProductListingModel productListing;

	private StcPaymentAuthorizeResponse authorizeResponse;

	public static bool IsSupported
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Platform platform = KUtil.GetPlatform();
			object obj4 = platform - 3;
			return obj4 == null;
		}
	}

	public static event StcPurchaseSuccessCallback OnPurchaseSuccess
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1880;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1272;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1880;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1272;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void Setup(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = this + 112;
		obj = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 120;
		obj2 = listing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ResetUi();
		productUi.PopulateListing((ProductListingModel)obj2, giftInfo);
	}

	private void ResetUi(bool withData = true)
	{
		//IL_00dd: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_0198: Expected O, but got I
		int num = ShortcutExtensions.DOKill(step1);
		step1.alpha = 1f;
		step1.blocksRaycasts = true;
		int num2 = ShortcutExtensions.DOKill(step2);
		step2.alpha = 0f;
		step2.blocksRaycasts = false;
		int num3 = ShortcutExtensions.DOKill(step3);
		step3.alpha = 0f;
		step3.blocksRaycasts = false;
		Vector2 sizeDelta = contentPanel.sizeDelta;
		contentPanel.sizeDelta = (Vector2)0;
		Transform transform = productUi.transform;
		Transform parent = step1.transform;
		transform.SetParent(parent, worldPositionStays: false);
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v8+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v2+B8]");
		object text = 0;
		otpCode.Text = (string)text;
		if (withData)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X21_v8+90]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v4+B8]");
			object text2 = 0;
			phoneNumber.Text = (string)text2;
		}
	}

	private static void DisableStep(CanvasGroup canvasGroup)
	{
		int num = ShortcutExtensions.DOKill(canvasGroup);
		canvasGroup.alpha = 0f;
		canvasGroup.blocksRaycasts = false;
	}

	private static void EnableStep(CanvasGroup canvasGroup)
	{
		int num = ShortcutExtensions.DOKill(canvasGroup);
		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;
	}

	public void InitializePayment()
	{
		InitializePaymentHelper();
	}

	private void InitializePaymentHelper()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_0141: Expected I, but got O
		//IL_015b: Expected I8, but got I4
		//IL_00a2: Expected O, but got I
		int num = ShortcutExtensions.DOKill(step1);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(step1, 0.6f, 0.3f);
		step1.blocksRaycasts = false;
		loadingIndicator.SetActive(value: true);
		string text = phoneNumber.Text;
		ProductListingModel productListingModel = productListing;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 632;
		object obj2 = (nint)0 + (nint)3904;
		GiftInfo giftInfo = _giftInfo;
		int? recipientId;
		if (_giftInfo != null)
		{
			object obj3 = (nint)0 + (nint)3136;
			int <RecipientId>k__BackingField = giftInfo.<RecipientId>k__BackingField;
			object obj4 = obj3;
			int? num2 = giftInfo.<RecipientId>k__BackingField;
			recipientId = num2;
		}
		else
		{
			recipientId = (int?)(object)0;
			object obj4 = 0;
			int <RecipientId>k__BackingField = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.BuyStcItem(text, productListingModel.<id>k__BackingField, recipientId, action);
	}

	public void ConfirmPayment()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_0197: Expected I, but got O
		//IL_01b4: Expected I, but got O
		int num = ShortcutExtensions.DOKill(step2);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(step2, 0.6f, 0.3f);
		step2.blocksRaycasts = false;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1872;
		loadingIndicator.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StcPaymentConfirmModel stcPaymentConfirmModel = default(StcPaymentConfirmModel);
		stcPaymentConfirmModel..ctor();
		string text = otpCode.Text;
		object obj2 = stcPaymentConfirmModel + 24;
		obj2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StcPaymentAuthorizeResponse stcPaymentAuthorizeResponse = authorizeResponse;
		object obj3 = stcPaymentConfirmModel + 16;
		obj3 = stcPaymentAuthorizeResponse.<BillReference>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ProductListingModel productListingModel = productListing;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
		object obj6 = (nint)0 + (nint)3920;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
		object obj8 = (nint)0 + (nint)3912;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v20+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string receipt = JsonConvert.SerializeObject(stcPaymentConfirmModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<long> action = default(Action<long>);
		action..ctor((object)this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)obj8);
		KammelnaRequests.BuyConsumable(productListingModel.<channelId>k__BackingField, receipt, null, _giftInfo, action, (Action<KammelnaError>)(object)action2);
	}

	private void SuccessCallback(long recipientId)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		loadingIndicator.SetActive(value: false);
		Transform transform = productUi.transform;
		Transform parent = step3.transform;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1880;
		transform.SetParent(parent, worldPositionStays: false);
		MoveNext(step2, step3, stepHeight3);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v88 @ X8_v5+18] (should have been resolved before IL gen)");
		}
	}

	private void ErrorCallback(KammelnaError error)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		loadingIndicator.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName);
		ResetUi(withData: false);
	}

	private static void DisableControls(CanvasGroup step)
	{
		int num = ShortcutExtensions.DOKill(step);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(step, 0.6f, 0.3f);
		step.blocksRaycasts = false;
	}

	private void MoveNext(CanvasGroup currentStep, CanvasGroup nextStep, float nextStepHeight)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_01b4: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj4 = obj2 + 16;
		obj4 = nextStep;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill(currentStep);
		int num2 = ShortcutExtensions.DOKill((Component)obj4);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence s = DOTween.Sequence();
		TweenerCore<float, float, FloatOptions> t = DOTweenModuleUI.DOFade(currentStep, 0f, 0.3f);
		DG.Tweening.Sequence s2 = TweenSettingsExtensions.Append(s, t);
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj8 = (nint)0 + (nint)1208;
		Vector2 sizeDelta = contentPanel.sizeDelta;
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOSizeDelta(contentPanel, (Vector2)0, 0f);
		DG.Tweening.Sequence s3 = TweenSettingsExtensions.Append(s2, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+10]");
		TweenerCore<float, float, FloatOptions> t3 = DOTweenModuleUI.DOFade((CanvasGroup)0, 1f, 0.3f);
		DG.Tweening.Sequence s4 = TweenSettingsExtensions.Append(s3, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj8);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.AppendCallback(s4, tweenCallback);
	}

	private void <InitializePaymentHelper>b__25_0(KammelnaResponseModel<StcPaymentAuthorizeResponse> response)
	{
		//IL_008d: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		loadingIndicator.SetActive(value: false);
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			MoveNext(step1, step2, stepHeight2);
			object obj = this + 128;
			obj = response.<Model>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		object obj2 = (nint)0 + (nint)1472;
		string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(errorMessage);
		ResetUi(withData: false);
	}
}
