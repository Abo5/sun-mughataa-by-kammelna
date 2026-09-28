using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Unity.Services.Authentication.Shared;

namespace Libraries.AppCheck;

public static class AppCheckErrors
{
	private const int DC_ERROR_SERVER_UNAVAILABLE = 4;

	private static readonly HashSet<string> TRANSIENT_ERRORS;

	public static bool IsServerUnavailable(string error)
	{
		//IL_0112: Expected I4, but got O
		//IL_00ea: Expected O, but got I4
		bool flag;
		if (string.IsNullOrEmpty(error))
		{
			flag = false;
			goto IL_0112;
		}
		if (error != null)
		{
			string[] array = error.Split('|');
			if (array != null)
			{
				if (array.Length >= 3)
				{
					flag = int.TryParse(array[2], out var result);
					if (flag)
					{
						object obj = result - 4;
						return obj == null;
					}
					goto IL_0112;
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0112:
		return flag;
	}

	public static bool IsRetryable(string error)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_026a: Expected O, but got I
		//IL_0230: Expected I4, but got O
		//IL_0082: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_0208: Expected O, but got I4
		bool flag;
		if (string.IsNullOrEmpty(error))
		{
			flag = false;
			goto IL_0287;
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 56;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v6+B8]");
		object obj4 = 0;
		if (obj4 != null)
		{
			object obj5 = (nint)0 + (nint)1120;
			if (((HashSet<object>)obj4).Contains((object)error))
			{
				return true;
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				if (!string.IsNullOrEmpty(error))
				{
					goto IL_0156;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = string.IsNullOrEmpty(error);
				bool flag4 = !flag3;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					goto IL_0156;
				}
			}
			goto IL_021c;
		}
		goto IL_0222;
		IL_0287:
		return flag;
		IL_0156:
		if (error != null)
		{
			string[] array = error.Split('|');
			if (array != null)
			{
				if (array.Length < 3)
				{
					goto IL_021c;
				}
				flag = int.TryParse(array[2], out var result);
				if (flag)
				{
					object obj8 = result - 4;
					return obj8 == null;
				}
				goto IL_0287;
			}
		}
		goto IL_0222;
		IL_0222:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_021c:
		return false;
	}

	static AppCheckErrors()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<object> hashSet = default(HashSet<object>);
		hashSet..ctor();
		object item = "Index = {0} position = {1}" + 584;
		object obj2 = (nint)0 + (nint)1104;
		object item2 = "Network Authentication Required" + 40;
		object item3 = "Index = {0} position = {1}" + 1768;
		object item4 = "ThisIsFakeReceiptData" + 832;
		object item5 = "Cannot populate JSON object onto type '{0}'." + 3208;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 56;
		bool flag = hashSet.Add(item);
		bool flag2 = hashSet.Add(item2);
		bool flag3 = hashSet.Add(item3);
		bool flag4 = hashSet.Add(item4);
		bool flag5 = hashSet.Add(item5);
		object obj4 = obj3;
		object obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
