using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Formats.Asn1;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using Util;

namespace Server.Models;

public class CachedModel<T> : ICachedModel
{
	private readonly ClientFilterProjection<T> _clientFilter;

	private T _model;

	private string _modelKey;

	private int _generation;

	private readonly bool _gameSpecific;

	private readonly string _key;

	private static string ModelsPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "m_StencilDeferredPS" + 2264;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			return cachePath + (string)obj2;
		}
	}

	private static ETagStorage ETagStorage => ETagStorage.GetInstance();

	private string Path
	{
		get
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_00bd: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = ", stale={0}" + 2488;
			object obj3 = "m_StencilDeferredPS" + 2264;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string cachePath = Config.CachePath;
			string text = cachePath + (string)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string text2 = default(string);
			return text + text2 + (string)obj2;
		}
	}

	public unsafe string Key
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00fe: Expected O, but got I4
			//IL_0125: Expected O, but got Ref
			object obj = 152973312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E3338]");
			object obj2 = (nint)0 & (nint)1;
			string key;
			string key2;
			if (obj2 != null)
			{
				key = _key;
				bool flag = _gameSpecific;
				key2 = _key;
				if (!flag)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				key = _key;
				bool flag2 = !_gameSpecific;
				key2 = _key;
				if (flag2)
				{
					goto IL_006f;
				}
			}
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj4 = ", stale={0}" + 1352;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = default(object);
			string text = ((Enum)(&obj7)).ToString();
			return key2 + (string)obj4 + text;
			IL_006f:
			return key;
		}
	}

	public string ETag
	{
		get
		{
			ETagStorage instance = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string key = default(string);
			if (instance != null)
			{
				return instance.GetETag(key);
			}
			return (string)(object)new NullReferenceException();
		}
		set
		{
			ETagStorage instance = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string key = default(string);
			instance.SetETag(key, value);
		}
	}

	public DateTime LastUpdate
	{
		get
		{
			ETagStorage instance = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string key = default(string);
			return (DateTime)(((object?)instance?.GetLastUpdate(key)) ?? ((object)new NullReferenceException()));
		}
		set
		{
			ETagStorage instance = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string key = default(string);
			instance.SetLastUpdate(key, value);
		}
	}

	public long ServerCursor
	{
		get
		{
			//IL_0059: Expected I8, but got O
			ETagStorage instance = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string key = default(string);
			if (instance != null)
			{
				return instance.GetServerCursor(key);
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
		set
		{
			ETagStorage instance = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string key = default(string);
			instance.SetServerCursor(key, value);
		}
	}

	public T Model
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string text = default(string);
			if ((string)obj != text)
			{
				_model = (T)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
				string modelKey = default(string);
				_modelKey = modelKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				int generation = _generation + 1;
				_generation = generation;
			}
			if (_clientFilter != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @439C2E4");
				T result = default(T);
				return result;
			}
			return (T)new NullReferenceException();
		}
	}

	private T RawModel
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string text = default(string);
			if ((string)obj != text)
			{
				_model = (T)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
				string modelKey = default(string);
				_modelKey = modelKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				int generation = _generation + 1;
				_generation = generation;
			}
			return _model;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			object obj2 = this + 32;
			object obj3 = default(object);
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_model = value;
			int generation = _generation + 1;
			_generation = generation;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D470");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E041A0");
		}
	}

	public CachedModel(string key, bool gameSpecific)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v2 (Il2CppRgctx<Server.Models.CachedModel`1>)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v2 (Il2CppRgctx<Server.Models.CachedModel`1>)+38]");
		if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 4294967295L;
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = this + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj4 = this + 48;
		obj4 = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public bool IsValid()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0229: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_03f7: Expected I4, but got O
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0180: Expected O, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I4
		//IL_03d5: Expected O, but got I4
		//IL_0327: Expected O, but got I4
		object obj = 152973312;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E333A]");
		object obj3 = (nint)0 & (nint)1;
		string key;
		string key2;
		if (obj3 != null)
		{
			key = _key;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			key2 = _key;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			key = _key;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			key2 = _key;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime? serverLastUpdate = CachedModels.GetServerLastUpdate(key2);
		object obj6 = (??)serverLastUpdate & 1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		DateTime dateTime = (DateTime)0;
		if (obj7 != null)
		{
			goto IL_00d2;
		}
		goto IL_0240;
		IL_018e:
		bool flag4;
		return flag4;
		IL_03e9:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0335:
		ETagStorage instance = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		if (instance != null)
		{
			string key3 = default(string);
			long serverCursor = instance.GetServerCursor(key3);
			bool flag5 = serverCursor == 0;
			return !flag5;
		}
		goto IL_03e9;
		IL_0091:
		DateTime? serverLastUpdate2 = CachedModels.GetServerLastUpdate(key);
		object obj8 = (??)serverLastUpdate2 & 1;
		bool flag6 = obj8 == null;
		dateTime = (DateTime)0;
		if (!flag6)
		{
			goto IL_00d2;
		}
		goto IL_0240;
		IL_0240:
		return false;
		IL_00d2:
		ETagStorage instance2 = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		if (instance2 != null)
		{
			string key4 = default(string);
			DateTime lastUpdate = instance2.GetLastUpdate(key4);
			object obj9 = typeof(DataRelation) + 712;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v10+E4]");
			if ((nint)0 != 0)
			{
				flag4 = lastUpdate >= dateTime;
				bool flag7 = !flag4;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					goto IL_018e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag4 = lastUpdate >= dateTime;
				if (!flag4)
				{
					goto IL_018e;
				}
			}
			ETagStorage instance3 = ETagStorage.GetInstance();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			if (instance3 != null)
			{
				string key5 = default(string);
				string eTag = instance3.GetETag(key5);
				object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13+E4]");
				if ((nint)0 != 0)
				{
					bool flag8 = StringsExtensions.IsNullOrEmpty(eTag);
					bool flag9 = !flag8;
					object obj14 = 0;
					if (!flag9)
					{
						goto IL_0335;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag10 = StringsExtensions.IsNullOrEmpty(eTag);
					bool flag11 = !flag10;
					object obj15 = !flag11;
					object obj14 = 0;
					if (obj15 != null)
					{
						goto IL_0335;
					}
				}
				return true;
			}
		}
		goto IL_03e9;
	}

	public void Load()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string text = default(string);
		if ((string)obj != text)
		{
			_model = (T)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string modelKey = default(string);
			_modelKey = modelKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int generation = _generation + 1;
			_generation = generation;
		}
	}

	public void Update(T model)
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D900");
	}

	public void Update(T model, Dictionary<string, string> responseHeaders, string request = "")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0117: Expected O, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D900");
		object obj = "Drop Menu Toggle" + 1624;
		object obj2 = (nint)0 + (nint)768;
		object obj3 = obj;
		object value;
		bool flag = ((Dictionary<object, object>)(object)responseHeaders).TryGetValue(obj, out value);
		bool flag2 = !flag;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			object obj5 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3560;
			obj3 = obj5;
			bool flag3 = ((Dictionary<object, object>)(object)responseHeaders).TryGetValue(obj5, out value);
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				object obj7 = "___# Content push apply failed [{0}]: {1}" + 824;
				string text = (string)obj7 + request;
				object obj8 = typeof(DataRelation) + 856;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				object message = text;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					message = text;
				}
				Debug.LogError(message);
				obj3 = null;
			}
		}
		ETagStorage instance = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		object obj11 = typeof(DataRelation) + 712;
		string key = default(string);
		instance.SetETag(key, (string)value);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		ETagStorage instance2 = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string key2 = default(string);
		instance2.SetLastUpdate(key2, now);
	}

	public void Mutate(Func<T, T> mutation)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string text = default(string);
		if ((string)obj != text)
		{
			_model = (T)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
			string modelKey = default(string);
			_modelKey = modelKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int generation = _generation + 1;
			_generation = generation;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [mutation @ X1 (System.Func`2<T, T>)+18] (should have been resolved before IL gen)");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D900");
	}

	public void ClearLastUpdateDate(DateTime? epoch = null)
	{
		//IL_014b: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0173: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_0191: Expected O, but got I
		//IL_01a6: Expected O, but got I
		object obj = (nint)0 + (nint)2296;
		object obj2 = (??)epoch & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		DateTime? dateTime = default(DateTime?);
		if (obj3 == null)
		{
			object obj4 = typeof(DataRelation) + 712;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v25+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+20]");
			dateTime = (DateTime)0;
		}
		DateTime value = dateTime.Value;
		ETagStorage instance = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		object obj8 = typeof(DataRelation) + 824;
		string key = default(string);
		DateTime lastUpdate = instance.GetLastUpdate(key);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime lastUpdate2 = DateTimeUtil.Min(value, lastUpdate);
		ETagStorage instance2 = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string key2 = default(string);
		instance2.SetLastUpdate(key2, lastUpdate2);
	}

	public void Clear()
	{
		//IL_0076: Expected O, but got I4
		//IL_00a5: Expected I8, but got I4
		_model = (T)null;
		int generation = _generation + 1;
		_generation = generation;
		ETagStorage instance = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string key = default(string);
		instance.SetETag(key, null);
		ETagStorage instance2 = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string key2 = default(string);
		instance2.SetLastUpdate(key2, (DateTime)0);
		ETagStorage instance3 = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string key3 = default(string);
		instance3.SetServerCursor(key3, 0L);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D470");
		string path = default(string);
		if (File.Exists(path))
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D470");
			string path2 = default(string);
			File.Delete(path2);
		}
	}
}
