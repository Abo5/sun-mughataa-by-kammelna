using System;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Libraries.AppCheck;

internal class EmptyAppCheck : IAppChecker
{
	public AppCheckerStrategy AppChecker => AppCheckerStrategy.NotApplicable;

	public bool IsSupported => false;

	public bool RequireSignature => false;

	public void Initialize()
	{
	}

	public void GetToken(string userKey, string requestHash, AppCheckResult callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 136;
		object obj2 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			string operatingSystem = SystemInfo.operatingSystem;
			object obj3 = "Network Authentication Required" + 2264;
			object obj4 = obj2 + 40;
			obj4 = operatingSystem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 56;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IntPtr invoke_impl = ((Delegate)callback).invoke_impl;
			IntPtr method_code = ((Delegate)callback).method_code;
			IntPtr method = ((Delegate)callback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Clear()
	{
	}

	private string GetVersion()
	{
		return SystemInfo.operatingSystem;
	}
}
