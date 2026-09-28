using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Xml.Schema;
using Cpp2ILInjected;
using DataTracking;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ActivationCodeUI : MonoBehaviour
{
	public enum ActivationType
	{
		Subscription,
		GoldenCards
	}

	private StoreEventsChannel storeEventsChannel;

	private Sprite fieldIcon;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4064;
		object obj2 = (nint)0 + (nint)2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		storeEventsChannel.ShowCodeActivation += (Action<ActivationType>)(object)action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4064;
		object obj2 = (nint)0 + (nint)2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		storeEventsChannel.ShowCodeActivation -= (Action<ActivationType>)(object)action;
	}

	private void ShowError(string errorMessage)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		object obj = (nint)0 + (nint)2000;
		if (errorMessage != (string)obj)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.SetError(errorMessage);
		}
	}

	private void ShowPopup(ActivationType activationType)
	{
		ShowCodeActivation(activationType);
	}

	private void ShowCodeActivation(ActivationType activationType)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0226: Expected I, but got O
		//IL_00cf: Expected O, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		object msgTitle;
		object msgBody;
		object text;
		switch (activationType)
		{
		case ActivationType.GoldenCards:
			msgTitle = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3520;
			msgBody = "Drop Menu Toggle" + 3232;
			text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3248;
			break;
		case ActivationType.Subscription:
			msgTitle = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3528;
			msgBody = "Drop Menu Toggle" + 3248;
			text = "SubscribeGroup request Error" + 40;
			break;
		default:
		{
			object obj = typeof(XmlSchemaInclude) + 3872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "___# Content push apply failed [{0}]: {1}" + 3200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)2520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
		}
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj6 = (nint)0 + (nint)2536;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object primaryText = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		LocalizableText placeholder = TextMeshProExtensions.Localize((string)text);
		IPopupWindowBuilderInput inputData = PopupInput.From(InputField.ContentType.IntegerNumber, action, placeholder, fieldIcon);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E697C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
	}

	private void SubmitActivationCode(string code)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_0127: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 536;
		object obj6 = (nint)0 + (nint)2512;
		PopupWindow.SetLoading(loading: true);
		PopupWindow.ClearError();
		ITrackEvent trackEvent = TrackerLibrary.ShopCodeActivateClicked();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		KammelnaRequests.ActivateCode(code, action);
	}

	private void <SubmitActivationCode>b__9_0(KammelnaResponseModel<CodeActivationViewModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_0054: Expected O, but got I4
		//IL_006a: Expected O, but got I
		//IL_027f: Expected O, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0232: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_0443: Expected O, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_030a: Expected F8, but got I4
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04fe: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0373: Expected I4, but got O
		//IL_0152: Expected F8, but got I4
		//IL_03ab: Expected O, but got I4
		object obj2;
		CodeActivationViewModel <Model>k__BackingField;
		string text;
		ResourceItemType resourceItemType;
		if (response != null)
		{
			object obj = (nint)0 + (nint)1192;
			obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			if (!((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				object obj3 = (nint)0 + (nint)2000;
				bool flag = errorMessage != (string)obj3;
				bool flag2 = !flag;
				text = null;
				if (!flag2)
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v37+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PopupWindow.SetError(errorMessage);
					text = null;
				}
				string errorMessage2 = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				ITrackEvent trackEvent = TrackerLibrary.ShopCodeActivateError(errorMessage2);
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v21+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				resourceItemType = (ResourceItemType)0;
				goto IL_0419;
			}
			object obj9 = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E697C]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v47+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00b4;
				}
			}
			else
			{
				_ = 1;
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v47+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				if (obj12 != null)
				{
					goto IL_00b4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
			<Model>k__BackingField = response.<Model>k__BackingField;
			bool flag6 = response.<Model>k__BackingField == null;
			object obj13 = !flag6;
			if (obj13 != null)
			{
				goto IL_00e8;
			}
		}
		goto IL_02db;
		IL_00b4:
		PopupWindow.DismissMessage();
		<Model>k__BackingField = response.<Model>k__BackingField;
		if (response.<Model>k__BackingField != null)
		{
			goto IL_00e8;
		}
		goto IL_02db;
		IL_0419:
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.SetLoading(loading: false);
		return;
		IL_02db:
		throw new NullReferenceException();
		IL_00e8:
		string text2;
		double num;
		if (<Model>k__BackingField.<SubscriptionDays>k__BackingField > 0)
		{
			object obj16 = "SubscribeGroup request Error" + 32;
			text2 = (string)obj16;
			int? days = <Model>k__BackingField.<SubscriptionDays>k__BackingField;
			Subscription.ShowUpdatedSubscriptionPopup(days);
			num = <Model>k__BackingField.<SubscriptionDays>k__BackingField;
		}
		else
		{
			object obj17 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3288;
			text2 = (string)obj17;
			num = <Model>k__BackingField.<Currency>k__BackingField;
		}
		object obj18 = "Cannot populate JSON object onto type '{0}'." + 3472;
		object obj19 = "Read object reference Id '{0}' for {1}." + 3808;
		FirebaseTrack.Purchase((string)obj18, text2, (string)obj19, <Model>k__BackingField.<Revenue>k__BackingField);
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v4+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		text = (string)obj19;
		Tracker.PurchaseEvent(TrackerPurchase.CodeActivation, text2, <Model>k__BackingField.<Revenue>k__BackingField, (string)obj19);
		bool flag9 = <Model>k__BackingField.<Currency>k__BackingField < 1;
		ResourceCurrency resourceCurrency = ResourceCurrency.None;
		double <Revenue>k__BackingField = <Model>k__BackingField.<Revenue>k__BackingField;
		resourceItemType = (ResourceItemType)text2;
		if (!flag9)
		{
			object obj23 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v7+E4]");
			bool flag10 = (nint)0 == 0;
			object obj24 = !flag10;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = Tracker.ItemId(ResourceItemId.Code);
			Tracker.ResourceEvent(ResourceFlowType.Source, ResourceItemType.IAP, text3, num, ResourceCurrency.Aces);
			resourceCurrency = ResourceCurrency.Aces;
			<Revenue>k__BackingField = num;
			text = text3;
			resourceItemType = ResourceItemType.IAP;
		}
		goto IL_0419;
	}
}
