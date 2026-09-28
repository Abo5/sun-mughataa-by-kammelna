using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;
using UnityEngine.Purchasing.Telemetry;

namespace Testing.TestSupport;

public static class TestSupportRequests
{
	public static void ProvisionAccounts(string testKey, string passwordOverride, Action<KammelnaResponseModel<TestAccountProvisionResultModel>> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_015c: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B3F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0122;
		IL_0122:
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ProvisionTestAccountsRequest provisionTestAccountsRequest = default(ProvisionTestAccountsRequest);
		provisionTestAccountsRequest..ctor(testKey, passwordOverride, retirePreviousRuns: true, (int?)(object)0);
		KammelnaRequests.Send((IWebRequest<object>)(object)provisionTestAccountsRequest, (Action<KammelnaResponseModel<object>>)callback);
		return;
		IL_007d:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0122;
	}

	public static void ResetAccounts(string testKey, List<string> roles, Action<KammelnaResponseModel<List<TestAccountResetResultModel>>> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0166: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B40]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0122;
		IL_0122:
		object obj7 = typeof(RegisteredWaitHandle) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ResetTestAccountsRequest resetTestAccountsRequest = default(ResetTestAccountsRequest);
		resetTestAccountsRequest..ctor(testKey, roles, (int?)(object)0);
		KammelnaRequests.Send((IWebRequest<object>)(object)resetTestAccountsRequest, (Action<KammelnaResponseModel<object>>)callback);
		return;
		IL_007d:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0122;
	}

	public static void CleanupTestData(string testKey, Action<KammelnaResponseModel<TestDataCleanupResultModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B41]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0119;
		IL_0119:
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CleanupTestDataRequest cleanupTestDataRequest = default(CleanupTestDataRequest);
		cleanupTestDataRequest..ctor(testKey);
		KammelnaRequests.Send((IWebRequest<object>)(object)cleanupTestDataRequest, (Action<KammelnaResponseModel<object>>)callback);
		return;
		IL_0074:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0119;
	}

	public static void GetStatus(string testKey, Action<KammelnaResponseModel<TestSupportStatusModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B42]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0119;
		IL_0119:
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TestSupportStatusRequest testSupportStatusRequest = default(TestSupportStatusRequest);
		testSupportStatusRequest..ctor(testKey);
		KammelnaRequests.Send((IWebRequest<object>)(object)testSupportStatusRequest, (Action<KammelnaResponseModel<object>>)callback);
		return;
		IL_0074:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0119;
	}
}
