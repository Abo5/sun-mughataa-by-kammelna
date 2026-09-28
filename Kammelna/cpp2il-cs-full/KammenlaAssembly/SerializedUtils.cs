using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class SerializedUtils : ScriptableObject
{
	public void BackAction()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_012f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AE9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2184;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		bool flag3 = (object)screenManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		screenManager.Back();
	}

	public void SwitchToOffline()
	{
		SFS.SwitchToOffline();
	}

	public void OpenSubscriptionInfoPage()
	{
		KammelnaURL.OpenSubscriptionInfoPage();
	}

	public void OpenTermsOfUsePage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AEA]");
		object obj3 = (nint)0 & (nint)1;
		object url;
		object url2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = "https://www.kammelna.com/Home/Terms";
			url2 = "https://www.kammelna.com/Home/Terms";
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			url = "https://www.kammelna.com/Home/Terms";
			url2 = "https://www.kammelna.com/Home/Terms";
			if (obj5 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url2);
		return;
		IL_008f:
		KUtil.OpenURL((string)url);
	}

	public void OpenSubscribePaymentPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AEB]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 4080;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 4080;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenStcStorePage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AEC]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 4088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 4088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenFaqsPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AED]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 4072;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 4072;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenStcSubCancellationPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AEE]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 4088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 4088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenLinkToVisaITunesPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AEF]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 3992;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 3992;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenHowToUseITunesCardPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF0]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 3984;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 3984;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenMobileCarrierPaymentITunes()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF1]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 4000;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 4000;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenUnsubscribeAndroid()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF2]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 4008;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 4008;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenUnsubscribeApple()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF3]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 3976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 3976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenUnsubscribeHuawei()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF4]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 3840;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 3840;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenCodeActivationPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF5]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "https://www.kammelna.com/Home/Terms" + 8;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "https://www.kammelna.com/Home/Terms" + 8;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}

	public void OpenBankPaymentPage()
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
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6AF6]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object url;
		if (obj3 != null)
		{
			obj4 = "getSecondRescanTask" + 3384;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			url = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "getSecondRescanTask" + 3384;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			url = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL((string)url);
		return;
		IL_0094:
		KUtil.OpenURL((string)obj4);
	}
}
