using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;

namespace Server.Models;

public class ETagStorage
{
	private static ETagStorage _instance;

	private bool _isDirty;

	private Dictionary<string, string> _eTags;

	private Dictionary<string, DateTime> _lastUpdates;

	private Dictionary<string, long> _serverCursors;

	private readonly string _eTagsPath;

	private readonly string _lastUpdatesPath;

	private readonly string _serverCursorsPath;

	public ETagStorage(string path)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00ef: Expected I, but got O
		//IL_0119: Expected O, but got I4
		object obj = "destinationTimeZone" + 1080;
		object obj2 = "java.io.FileOutputStream" + 1176;
		object obj3 = "rightCtrl" + 2056;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)136;
		object obj6 = typeof(RegisteredWaitHandle) + 2776;
		base..ctor();
		string text = path + (string)obj;
		object obj7 = this + 48;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text2 = path + (string)obj2;
		object obj8 = this + 56;
		obj8 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text3 = path + (string)obj3;
		object obj9 = this + 64;
		obj9 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Load();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v21+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SaveManager.OnSaving += action;
	}

	public static ETagStorage GetInstance()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_022c: Expected O, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		object obj = typeof(DataRelation) + 2840;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj4 = 0;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				bool isInitialized = Config.IsInitialized;
				bool flag = !isInitialized;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00a9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (Config.IsInitialized)
				{
					goto IL_00a9;
				}
			}
		}
		goto IL_01c8;
		IL_00a9:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v14+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		if (obj8 != null)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v16+30]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v16+30]");
				bool flag3 = ((string)0).StartsWith(cachePath);
				bool flag4 = !flag3;
				object obj12 = !flag4;
				object obj13 = 0;
				string text = cachePath;
				if (obj12 == null)
				{
					Clear();
					obj13 = 0;
					text = cachePath;
				}
				goto IL_01c8;
			}
		}
		return (ETagStorage)(object)new NullReferenceException();
		IL_01c8:
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+B8]");
		object obj15 = 0;
		if (obj15 != null)
		{
			return (ETagStorage)obj15;
		}
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath2 = Config.CachePath;
		object obj18 = "m_StencilDeferredPS" + 2264;
		string path = cachePath2 + (string)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ETagStorage eTagStorage = default(ETagStorage);
		eTagStorage..ctor(path);
		object obj19 = obj;
		object obj20 = eTagStorage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return eTagStorage;
	}

	public static void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0139: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_008e: Expected I, but got O
		//IL_00b8: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		object obj = typeof(DataRelation) + 2840;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+B8]");
		object obj3 = 0;
		if (obj3 != null)
		{
			object obj4 = typeof(SqlSingle[]) + 2376;
			object obj5 = (nint)0 + (nint)136;
			object obj6 = typeof(RegisteredWaitHandle) + 2776;
			((ETagStorage)obj3).Save();
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj8, (IntPtr)obj5);
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SaveManager.OnSaving -= action;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v9+B8]");
			obj3 = 0;
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public string GetETag(string key)
	{
		//IL_0037: Expected O, but got I4
		if (_eTags != null)
		{
			object value;
			bool flag = ((Dictionary<object, object>)(object)_eTags).TryGetValue((object)key, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (string)value;
			}
			return null;
		}
		return (string)(object)new NullReferenceException();
	}

	public void SetETag(string key, string eTag)
	{
		if (eTag != null)
		{
			((Dictionary<object, object>)(object)_eTags).set_Item((object)key, (object)eTag);
			_isDirty = true;
		}
		else
		{
			bool flag = ((Dictionary<object, object>)(object)_eTags).Remove((object)key);
			_isDirty = true;
		}
	}

	public DateTime GetLastUpdate(string key)
	{
		//IL_0037: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		if (_lastUpdates != null)
		{
			DateTime value;
			bool flag = ((Dictionary<object, DateTime>)(object)_lastUpdates).TryGetValue((object)key, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return value;
			}
			return (DateTime)0;
		}
		return (DateTime)new NullReferenceException();
	}

	public void SetLastUpdate(string key, DateTime lastUpdate)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)1992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3037BC8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			bool flag = ((Dictionary<object, DateTime>)(object)_lastUpdates).Remove((object)key);
		}
		else
		{
			((Dictionary<object, DateTime>)(object)_lastUpdates).set_Item((object)key, lastUpdate);
		}
		_isDirty = true;
	}

	public long GetServerCursor(string key)
	{
		//IL_0077: Expected I8, but got O
		//IL_0037: Expected O, but got I4
		//IL_0064: Expected I8, but got I4
		if (_serverCursors != null)
		{
			long value;
			bool flag = ((Dictionary<object, long>)(object)_serverCursors).TryGetValue((object)key, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return value;
			}
			return 0L;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}

	public void SetServerCursor(string key, long cursor)
	{
		long num = default(long);
		if (num != 0)
		{
			((Dictionary<object, long>)(object)_serverCursors).set_Item((object)key, num);
			_isDirty = true;
		}
		else
		{
			bool flag = ((Dictionary<object, long>)(object)_serverCursors).Remove((object)key);
			_isDirty = true;
		}
	}

	public unsafe void Load()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0250: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Ref, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Ref, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0367: Expected O, but got I
		//IL_039b: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_02f1: Expected O, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Ref, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Ref, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0418: Expected O, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_048e: Expected O, but got I
		//IL_04c2: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Ref, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Ref, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_053f: Expected O, but got I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B68]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		string eTagsPath;
		object obj6;
		string eTagsPath2;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3352;
			eTagsPath = _eTagsPath;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			eTagsPath2 = _eTagsPath;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3352;
			eTagsPath = _eTagsPath;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			eTagsPath2 = _eTagsPath;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		ref object reference = ref *(object*)(this + 24);
		bool flag3 = FileUtils.TryLoadObject<object>(eTagsPath2, out reference);
		bool flag4 = !flag3;
		object obj9 = !flag4;
		ref object reference2 = ref reference;
		object obj10 = obj6;
		if (obj9 != null)
		{
			goto IL_00f6;
		}
		goto IL_030f;
		IL_0232:
		_isDirty = false;
		return;
		IL_054d:
		object obj11 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, long> dictionary = default(Dictionary<object, long>);
		dictionary..ctor();
		_serverCursors = (Dictionary<string, long>)(object)dictionary;
		object obj12 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_isDirty = false;
		return;
		IL_01f1:
		object obj14;
		object obj13 = obj14;
		string serverCursorsPath;
		if (FileUtils.TryLoadObject<object>(serverCursorsPath, out *(object*)(this + 40)))
		{
			goto IL_0232;
		}
		goto IL_054d;
		IL_00a5:
		obj8 = obj4;
		reference = ref *(object*)(this + 24);
		bool flag5 = FileUtils.TryLoadObject<object>(eTagsPath, out reference);
		bool flag6 = !flag5;
		reference2 = ref reference;
		obj10 = obj4;
		if (!flag6)
		{
			goto IL_00f6;
		}
		goto IL_030f;
		IL_030f:
		object obj15 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		dictionary2..ctor();
		_eTags = (Dictionary<string, string>)(object)dictionary2;
		object obj16 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = (nint)0 + (nint)3336;
		string lastUpdatesPath = _lastUpdatesPath;
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		reference = ref *(object*)dictionary2;
		obj8 = obj10;
		object obj20 = obj17;
		string lastUpdatesPath2 = _lastUpdatesPath;
		if (obj19 != null)
		{
			goto IL_014b;
		}
		goto IL_03cb;
		IL_00f6:
		obj17 = (nint)0 + (nint)3336;
		lastUpdatesPath = _lastUpdatesPath;
		obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v16+E4]");
		bool flag8 = (nint)0 == 0;
		obj20 = obj17;
		lastUpdatesPath2 = _lastUpdatesPath;
		if (!flag8)
		{
			goto IL_014b;
		}
		goto IL_03cb;
		IL_03cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj21 = obj20;
		ref object reference3 = ref *(object*)(this + 32);
		bool flag9 = FileUtils.TryLoadObject<object>(lastUpdatesPath2, out reference3);
		bool flag10 = !flag9;
		object obj22 = !flag10;
		ref object reference4 = ref reference3;
		object obj23 = obj20;
		if (obj22 != null)
		{
			goto IL_019c;
		}
		goto IL_0436;
		IL_014b:
		obj21 = obj17;
		reference3 = ref *(object*)(this + 32);
		bool flag11 = FileUtils.TryLoadObject<object>(lastUpdatesPath, out reference3);
		bool flag12 = !flag11;
		reference4 = ref reference3;
		obj23 = obj17;
		if (!flag12)
		{
			goto IL_019c;
		}
		goto IL_0436;
		IL_0436:
		object obj24 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, DateTime> dictionary3 = default(Dictionary<object, DateTime>);
		dictionary3..ctor();
		_lastUpdates = (Dictionary<string, DateTime>)(object)dictionary3;
		object obj25 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj14 = (nint)0 + (nint)3344;
		serverCursorsPath = _serverCursorsPath;
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v6+E4]");
		bool flag13 = (nint)0 == 0;
		object obj27 = !flag13;
		reference3 = ref *(object*)dictionary3;
		obj21 = obj23;
		object obj28 = obj14;
		string serverCursorsPath2 = _serverCursorsPath;
		if (obj27 != null)
		{
			goto IL_01f1;
		}
		goto IL_04f2;
		IL_019c:
		obj14 = (nint)0 + (nint)3344;
		serverCursorsPath = _serverCursorsPath;
		obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v6+E4]");
		bool flag14 = (nint)0 == 0;
		obj28 = obj14;
		serverCursorsPath2 = _serverCursorsPath;
		if (!flag14)
		{
			goto IL_01f1;
		}
		goto IL_04f2;
		IL_04f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj28;
		bool flag15 = FileUtils.TryLoadObject<object>(serverCursorsPath2, out *(object*)(this + 40));
		bool flag16 = !flag15;
		object obj29 = !flag16;
		if (obj29 != null)
		{
			goto IL_0232;
		}
		goto IL_054d;
	}

	public void Save()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B69]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			if (!_isDirty)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			if (!_isDirty)
			{
				return;
			}
		}
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FileUtils.SaveObject(_eTagsPath, (object)_eTags);
		FileUtils.SaveObject(_lastUpdatesPath, (object)_lastUpdates);
		FileUtils.SaveObject(_serverCursorsPath, (object)_serverCursors);
		_isDirty = false;
	}
}
