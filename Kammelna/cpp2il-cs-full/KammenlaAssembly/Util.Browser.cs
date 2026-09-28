using System.Data.SqlTypes;
using Cpp2ILInjected;
using Libraries.SafariBrowser;
using Newtonsoft.Json.Linq.JsonPath;

namespace Util;

public static class Browser
{
	public static void LaunchUrl(string url)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E856D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_0115;
		}
		goto IL_015c;
		IL_015c:
		object obj5 = typeof(SqlSingle[]) + 3560;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			AndroidInterface.LaunchUrl(url);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AndroidInterface.LaunchUrl(url);
		return;
		IL_0115:
		switch (platform)
		{
		case Platform.IOS:
			SafariView.LaunchUrl(url);
			return;
		case Platform.Huawei:
			break;
		default:
			return;
		}
		goto IL_015c;
		IL_0074:
		platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_0115;
		}
		goto IL_015c;
	}

	public static void LaunchUrlWithCallback(string url, string callbackUrl)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_019e: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E856E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_0115;
		}
		goto IL_0160;
		IL_0160:
		object obj5 = typeof(SqlSingle[]) + 3560;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AndroidInterface.LaunchUrlWithCallback(url, callbackUrl);
		return;
		IL_0115:
		switch (platform)
		{
		case Platform.IOS:
			SafariView.LaunchUrlWithCallback(url, callbackUrl);
			return;
		case Platform.Huawei:
			break;
		default:
			return;
		}
		goto IL_0160;
		IL_0074:
		platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_0115;
		}
		goto IL_0160;
	}

	public static void Dismiss()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E856F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.IOS)
		{
			return;
		}
		goto IL_009d;
		IL_009d:
		SafariView.Dismiss();
		return;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.IOS)
		{
			goto IL_009d;
		}
	}
}
