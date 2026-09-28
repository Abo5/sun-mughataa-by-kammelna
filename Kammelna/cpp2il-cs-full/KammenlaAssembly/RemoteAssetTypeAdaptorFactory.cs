using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

public static class RemoteAssetTypeAdaptorFactory
{
	private static readonly Dictionary<Type, object> AssetTypeAdaptors;

	public static IRemoteAssetTypeAdaptor<T> GetAdaptor<T>() where T : class
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_01c0: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_01df: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 32;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v18+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		object obj4 = obj2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+B8]");
		object dict = 0;
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+E0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj8 = (nint)0 + (nint)3304;
		object obj9 = DictionaryExtensions.Get((IDictionary<object, object>)dict, typeFromHandle);
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		nint num = 0;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
		}
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			IRemoteAssetTypeAdaptor<T> remoteAssetTypeAdaptor = default(IRemoteAssetTypeAdaptor<T>);
			if (remoteAssetTypeAdaptor != null)
			{
				return remoteAssetTypeAdaptor;
			}
			return (IRemoteAssetTypeAdaptor<T>)new InvalidCastException();
		}
		return null;
	}

	static RemoteAssetTypeAdaptorFactory()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_01ee: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3320;
		object obj2 = (nint)0 + (nint)2984;
		object handle = 147423232 + 1408;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X22_v3+E0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = default(object);
		obj7..ctor();
		object obj8 = (nint)0 + (nint)2992;
		object handle2 = typeof(IAsyncEnumerable<>) + 4000;
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1200;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 192;
		object obj11 = typeof(RegisteredWaitHandle) + 32;
		dictionary.Add(typeFromHandle, obj7);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)handle2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = default(object);
		obj12..ctor();
		dictionary.Add(typeFromHandle2, obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X22_v3+90]");
		RuntimeTypeHandle handle3 = (RuntimeTypeHandle)((nint)0 + (nint)32);
		Type typeFromHandle3 = Type.GetTypeFromHandle(handle3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = default(object);
		obj13..ctor();
		dictionary.Add(typeFromHandle3, obj13);
		object obj14 = obj11;
		object obj15 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
