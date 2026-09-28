using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class MiniGameTester : MonoBehaviour
{
	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse += eventListenerDelegate;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse -= eventListenerDelegate;
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 1792;
		string command = SFSExtensions.GetCommand(evt);
		if (!(command == (string)obj))
		{
			return;
		}
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)responseParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ce;
		}
		object obj5 = obj4 + 6;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		object obj8 = 0;
		goto IL_01a4;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X8_v6] (should have been resolved before IL gen)");
		object obj9 = typeof(DataRelation) + 856;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v9+E4]");
		object message = default(object);
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
		return;
		IL_00ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 6;
		object obj11 = default(object);
		obj7 = obj11;
		goto IL_01a4;
	}

	public void SendPlayMiniGameRequest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "placementId" + 56;
		object command = "m_StencilDeferredPS" + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	public void SendClaimRequest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0271: Expected I, but got O
		//IL_0281: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3792;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Hashtable hashtable = default(Hashtable);
		List<object> list = default(List<object>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			hashtable..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			object obj3 = "setMimeType" + 2656;
			object obj4 = (nint)0 + (nint)3072;
			object obj5 = obj4;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			object obj6 = "1.2.840.113549.1.12.1.5" + 1368;
			bool flag = list._size < items.Length;
			object obj7 = !flag;
			if (obj7 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj8 = items + list._size;
				object obj9 = obj8 + 32;
				obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+20]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v17+C0]");
				object obj11 = 0;
				list.AddWithResize(obj3);
			}
			int version2 = list._version + 1;
			list._version = version2;
			object[] items2 = list._items;
			bool flag2 = list._size < items2.Length;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				int size2 = list._size + 1;
				list._size = size2;
				object obj13 = items2 + list._size;
				object obj14 = obj13 + 32;
				obj14 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize(obj6);
			}
			object key = "clear_mass_tournaments" + 264;
			object value = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3392;
			object obj15 = "placementId" + 1248;
			hashtable.Add(key, value);
			object obj16 = obj15;
			nint num = (nint)hashtable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13 (Il2CppClass<System.Collections.Hashtable>)+2A8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13 (Il2CppClass<System.Collections.Hashtable>)+2B0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v162 @ X4_v1 (should have been resolved before IL gen)");
		}
	}
}
