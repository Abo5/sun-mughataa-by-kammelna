using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DataTracking.DeviceId;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class UserDeviceIDRecorder : Singleton<UserDeviceIDRecorder>
{
	private static IDeviceIdProvider _deviceIdProvider;

	public static string DeviceId
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0192: Expected O, but got I
			//IL_01b4: Expected O, but got I4
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00aa: Expected O, but got I
			//IL_020a: Expected O, but got I4
			//IL_00e5: Expected O, but got I
			//IL_0059: Expected O, but got I
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			object obj = typeof(UsageHint) + 48;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			bool flag = obj3 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				IDeviceIdProvider deviceIdProvider = GetDeviceIdProvider();
				object obj6 = obj;
				object obj7 = deviceIdProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v14+B8]");
				object obj9 = 0;
				obj4 = obj9;
				if (obj9 == null)
				{
					return (string)(object)new NullReferenceException();
				}
			}
			object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2200;
			object obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0126;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v5-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_0126;
			}
			object obj14 = obj11 + obj13;
			object obj15 = obj14 + 312;
			goto IL_01e6;
			IL_0126:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01e6;
			IL_01e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ X0_v3] (should have been resolved before IL gen)");
			object obj16 = default(object);
			bool flag2 = obj16 == null;
			object obj17 = !flag2;
			object obj18 = ~obj17;
			string result = default(string);
			if (obj18 == null)
			{
				return result;
			}
			return null;
		}
	}

	protected override void OnAwake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 48;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		IDeviceIdProvider deviceIdProvider = GetDeviceIdProvider();
		object obj3 = obj;
		object obj4 = deviceIdProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject target = base.gameObject;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(target);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	private static IDeviceIdProvider GetDeviceIdProvider()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F84]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.WebGLPlayer)
		{
			goto IL_00a3;
		}
		goto IL_016a;
		IL_00a3:
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			AppleDeviceIdProvider appleDeviceIdProvider = default(AppleDeviceIdProvider);
			appleDeviceIdProvider..ctor();
			return appleDeviceIdProvider;
		}
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityDeviceIdProvider unityDeviceIdProvider = default(UnityDeviceIdProvider);
		unityDeviceIdProvider..ctor();
		return unityDeviceIdProvider;
		IL_016a:
		object obj8 = typeof(UsageHint) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		WebDeviceIdProvider webDeviceIdProvider = default(WebDeviceIdProvider);
		webDeviceIdProvider..ctor();
		return webDeviceIdProvider;
		IL_007d:
		platform = Application.platform;
		if (platform != RuntimePlatform.WebGLPlayer)
		{
			goto IL_00a3;
		}
		goto IL_016a;
	}

	public UserDeviceIDRecorder()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F85]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2256;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)2256;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
