using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Mono.Btls;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Android;

namespace Util;

public static class PermissionExtensions
{
	private sealed class <>c__DisplayClass1_0
	{
		public Action callback;

		internal void <RequestPermission>b__0(bool isSuccessfullyGranted)
		{
			Actions.SafeInvoke(callback);
		}
	}

	public static bool IsGranted(AppPermission permission)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E856A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			goto IL_009d;
		}
		goto IL_0134;
		IL_018a:
		UserAuthorization ios = GetIos(permission);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			return Application.HasUserAuthorization(ios);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Application.HasUserAuthorization(ios);
		IL_009d:
		string android = GetAndroid(permission);
		return Permission.HasUserAuthorizedPermission(android);
		IL_0134:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.IPhonePlayer)
			{
				goto IL_018a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform3 = Application.platform;
			if (platform3 == RuntimePlatform.IPhonePlayer)
			{
				goto IL_018a;
			}
		}
		return true;
		IL_0074:
		RuntimePlatform platform4 = Application.platform;
		if (platform4 == RuntimePlatform.Android)
		{
			goto IL_009d;
		}
		goto IL_0134;
	}

	public static void RequestPermission(AppPermission permission, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_01bb: Expected I, but got O
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0119: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		RuntimePlatform platform;
		if ((nint)0 != 0)
		{
			platform = Application.platform;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				goto IL_00a0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			platform = Application.platform;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				goto IL_00a0;
			}
		}
		UserAuthorization ios = GetIos(permission);
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)392;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj7);
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForPermission(ios, action);
		return;
		IL_00a0:
		if (platform == RuntimePlatform.Android)
		{
			string android = GetAndroid(permission);
			Permission.RequestUserPermission(android);
			object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(1f, (Action)obj4);
		}
		else
		{
			Actions.SafeInvoke((Action)obj4);
		}
	}

	public static string GetAndroid(AppPermission permission)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		switch (permission)
		{
		case AppPermission.Camera:
			return "alignContent" + 384;
		case AppPermission.Microphone:
			return "alignContent" + 392;
		default:
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "not" + 3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)3104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (string)(object)new OutOfMemoryException();
		}
		}
	}

	public static UserAuthorization GetIos(AppPermission permission)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00de: Expected O, but got I
		//IL_00fb: Expected I4, but got O
		switch (permission)
		{
		case AppPermission.Camera:
			return (UserAuthorization)permission;
		case AppPermission.Microphone:
			return UserAuthorization.Microphone;
		default:
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "not" + 3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)3112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			return (UserAuthorization)ex2;
		}
		}
	}
}
