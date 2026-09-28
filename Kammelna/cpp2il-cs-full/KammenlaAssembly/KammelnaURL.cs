using System.Formats.Asn1;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public static class KammelnaURL
{
	public const string PaymentPage = "https://www.kammelna.com/Home/Plans";

	public const string DigitalOrdersPage = "https://www.kammelna.com/Store/BuyProductListing?id=";

	public const string StcStorePage = "https://www.kammelna.com/Home/Plans#stc-details";

	public const string StcSubCancellation = "https://www.kammelna.com/Home/Plans#stc-details";

	public const string TermsPage = "https://www.kammelna.com/Home/Terms";

	public const string FaqsPage = "https://www.kammelna.com/Home/FAQ";

	public const string CodeActivationPage = "https://www.kammelna.com/Home/code";

	public const string BankPaymentPage = "http://blog.kammelna.com/?p=1280";

	public const string AppDownloadLink = "https://kammelna.app.link/download";

	public const string UnsubscribeApple = "https://support.apple.com/ar-ae/HT202039";

	public const string RateApple = "https://itunes.apple.com/app/id537025426";

	public const string UpdateApple = "itms-apps://itunes.apple.com/app/id537025426?mt=8";

	public const string LinkVisaToITunes = "https://support.apple.com/ar-sa/HT201266";

	public const string HowToUseITunesCard = "https://support.apple.com/ar-sa/HT201209";

	public const string MobileCarrierPaymentITunes = "https://support.apple.com/ar-sa/HT205102";

	public const string UnsubscribeAndroid = "https://support.google.com/googleplay/answer/7018481?co=GENIE.Platform%3DAndroid&hl=ar";

	public const string RateAndroid = "market://details?id=com.remalit.kammelna";

	public const string UpdateAndroid = "market://details?id=com.remalit.kammelna";

	public const string UnsubscribeHuawei = "https://consumer.huawei.com/sa/support/content/ar-eg00791633";

	public const string RateHuawei = "appmarket://details?id=com.remalit.kammelna.huawei";

	public const string UpdateHuawei = "appmarket://details?id=com.remalit.kammelna.huawei";

	public static void OpenSubscriptionInfoPage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_0128: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		//IL_00cf: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_01d8: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Platform platform = KUtil.GetPlatform();
		object obj5 = platform - 1;
		bool flag2 = (nint)obj5 < 3;
		object obj6 = !flag2;
		object obj7 = obj5 - 3;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		object obj9 = obj6 & obj8;
		string text;
		string text2;
		if (obj9 == null)
		{
			object obj10 = 139821056 + 2928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v6+v60 @ X8_v4*8]");
			object obj11 = 0;
			text = (string)obj11;
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_0165;
			}
			text2 = (string)obj11;
		}
		else
		{
			object obj14 = (nint)0 + (nint)2000;
			text = (string)obj14;
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			text2 = (string)obj14;
			if (!flag5)
			{
				goto IL_0165;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = StringsExtensions.IsNullOrEmpty(text2);
		bool flag7 = !flag6;
		object obj15 = !flag7;
		object obj16 = 0;
		text = text2;
		if (obj15 != null)
		{
			return;
		}
		goto IL_01ee;
		IL_01ee:
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			KUtil.OpenURL(text);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL(text);
		return;
		IL_0165:
		bool flag8 = StringsExtensions.IsNullOrEmpty(text);
		bool flag9 = !flag8;
		obj16 = 0;
		if (!flag9)
		{
			return;
		}
		goto IL_01ee;
	}

	public static void OpenUpdatePage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_038e: Expected O, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0335: Expected O, but got I4
		//IL_02a7: Expected O, but got I
		//IL_02d9: Expected O, but got I4
		//IL_0416: Expected O, but got I4
		//IL_045b: Expected O, but got I4
		//IL_0464: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0280: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0145: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7196]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Platform platform = KUtil.GetPlatform();
		bool flag2 = platform <= Platform.IOS;
		object obj7 = obj6;
		Platform platform2 = platform;
		if (flag2)
		{
			goto IL_00c7;
		}
		goto IL_01fa;
		IL_00c7:
		string text;
		string text2;
		object obj9;
		if (platform != Platform.Android)
		{
			if (platform != Platform.IOS)
			{
				goto IL_029b;
			}
			object obj8 = "https://www.kammelna.com/Home/Terms" + 3960;
			text = (string)obj8;
			obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_03f1;
			}
			text2 = (string)obj8;
		}
		else
		{
			object obj11 = "m_StencilDeferredPS" + 496;
			text = (string)obj11;
			obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				goto IL_03f1;
			}
			text2 = (string)obj11;
		}
		goto IL_0425;
		IL_029b:
		object obj13 = (nint)0 + (nint)2000;
		text = (string)obj13;
		obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_03f1;
		}
		text2 = (string)obj13;
		goto IL_0425;
		IL_03f1:
		bool flag6 = StringsExtensions.IsNullOrEmpty(text);
		bool flag7 = !flag6;
		object obj15 = 0;
		if (!flag7)
		{
			return;
		}
		goto IL_047a;
		IL_007d:
		obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		platform = KUtil.GetPlatform();
		bool flag8 = platform > Platform.IOS;
		obj7 = obj6;
		platform2 = platform;
		if (!flag8)
		{
			goto IL_00c7;
		}
		goto IL_01fa;
		IL_01fa:
		if (platform2 != Platform.Web)
		{
			bool flag9 = platform2 != Platform.Huawei;
			obj6 = obj7;
			if (flag9)
			{
				goto IL_029b;
			}
			object obj16 = "alignContent" + 2320;
			text = (string)obj16;
			obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 != null)
			{
				goto IL_03f1;
			}
			text2 = (string)obj16;
		}
		else
		{
			object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v17+E4]");
			bool flag11 = (nint)0 == 0;
			object obj20 = !flag11;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string absoluteURL = Application.absoluteURL;
			obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v6+E4]");
			bool flag12 = (nint)0 == 0;
			text = absoluteURL;
			text2 = absoluteURL;
			if (!flag12)
			{
				goto IL_03f1;
			}
		}
		goto IL_0425;
		IL_047a:
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			KUtil.OpenURL(text);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL(text);
		return;
		IL_0425:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = StringsExtensions.IsNullOrEmpty(text2);
		bool flag14 = !flag13;
		object obj22 = !flag14;
		obj15 = 0;
		text = text2;
		if (obj22 != null)
		{
			return;
		}
		goto IL_047a;
	}
}
