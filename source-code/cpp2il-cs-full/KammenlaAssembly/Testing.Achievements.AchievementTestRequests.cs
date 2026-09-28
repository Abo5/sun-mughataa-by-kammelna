using System;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;
using UnityEngine.Purchasing.Telemetry;

namespace Testing.Achievements;

public static class AchievementTestRequests
{
	public static void TriggerAchievement(long userId, string achievementId, int increment, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_010b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B43]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
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
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2192;
		object obj7 = (nint)0 + (nint)3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TriggerAchievementRequest triggerAchievementRequest = default(TriggerAchievementRequest);
		triggerAchievementRequest..ctor(userId, achievementId, increment);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FDFC");
		return;
		IL_0074:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0119;
	}

	public static void SetProgress(long userId, string achievementId, int value, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_010b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B44]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
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
		object obj6 = typeof(RegisteredWaitHandle) + 4024;
		object obj7 = (nint)0 + (nint)3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SetAchievementProgressRequest setAchievementProgressRequest = default(SetAchievementProgressRequest);
		setAchievementProgressRequest..ctor(userId, achievementId, value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FDFC");
		return;
		IL_0074:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0119;
	}

	public static void ForceUnlock(long userId, string achievementId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0114: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B45]");
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
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1184;
		object obj8 = (nint)0 + (nint)3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ForceUnlockAchievementRequest forceUnlockAchievementRequest = default(ForceUnlockAchievementRequest);
		forceUnlockAchievementRequest..ctor(userId, achievementId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FDFC");
		return;
		IL_007d:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0122;
	}

	public static void ResetAchievement(long userId, string achievementId, Action<KammelnaResponseModel<bool>> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0114: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B46]");
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
		object obj7 = typeof(RegisteredWaitHandle) + 808;
		object obj8 = (nint)0 + (nint)3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ResetAchievementRequest resetAchievementRequest = default(ResetAchievementRequest);
		resetAchievementRequest..ctor(userId, achievementId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FDFC");
		return;
		IL_007d:
		if (Config.IsProduction)
		{
			return;
		}
		goto IL_0122;
	}
}
