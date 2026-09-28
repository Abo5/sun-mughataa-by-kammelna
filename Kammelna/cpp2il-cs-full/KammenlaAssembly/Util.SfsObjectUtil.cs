using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

namespace Util;

public static class SfsObjectUtil
{
	public static ISFSObject FromOneValue(string key, int value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, key, value);
		return sFSObject;
	}

	public static ISFSObject FromOneValue<T>(string key, T value) where T : Enum
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value2 = default(object);
		int val = Convert.ToInt32(value2);
		SFSExtensions.Put(sFSObject, key, val);
		return sFSObject;
	}

	public static ISFSObject FromOneValue(string key, long value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, key, value);
		return sFSObject;
	}

	public static ISFSObject FromOneValue(string key, string value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, key, value);
		return sFSObject;
	}

	public static ISFSObject FromOneValue(string key, bool value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, key, value);
		return sFSObject;
	}
}
