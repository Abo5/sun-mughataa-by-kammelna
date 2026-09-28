using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Managers.IAP;

public class HuaweiIapManager : AndroidJavaProxy
{
	public const int PriceTypeConsumable = 0;

	public const int PriceTypeNonConsumable = 1;

	public const int PriceTypeSubscription = 2;

	private const string ListenerInterface = "com.kgg.huaweiiapplugin.IapListener";

	private const string HelperClass = "com.kgg.huaweiiapplugin.IapHelper";

	private readonly AndroidJavaObject _plugin;

	public Action OnConnected;

	public Action<int> OnDisconnected;

	public Action<bool, string> OnFetchProductsFinished;

	public Action<string, string> OnPurchaseSucceeded;

	public Action<int> OnPurchaseFailed;

	public Action<string> OnOwnedPurchasesFetched;

	public Action<int> OnOwnedPurchasesFetchFailed;

	public Action<string, bool, int> OnConsumeFinished;

	private readonly Dictionary<string, ProductMetadata> _productMetadata;

	public HuaweiIapManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_0275: Expected I, but got O
		//IL_0285: Expected O, but got I
		//IL_02ae: Expected O, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2696;
		object obj2 = typeof(SqlSingle[]) + 3608;
		object obj3 = "clear_mass_tournaments" + 3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = this + 104;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base..ctor((string)obj3);
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8594]");
		if ((object)((nint)0 & (nint)1) != null)
		{
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00f3;
			}
		}
		else
		{
			_ = 1;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v38+E4]");
			if ((object)((nint)0 != 0) != null)
			{
				goto IL_00f3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Application.platform == RuntimePlatform.Android)
		{
			goto IL_0194;
		}
		return;
		IL_00f3:
		if (Application.platform != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_0194;
		IL_0194:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			if (KUtil.GetPlatform() != Platform.Huawei)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (KUtil.GetPlatform() != Platform.Huawei)
			{
				return;
			}
		}
		object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		AndroidJavaObject activity = GetActivity();
		object[] array = default(object[]);
		object obj10;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj11;
		if (array != null)
		{
			bool flag = activity == null;
			obj10 = 1;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
				obj11 = 0;
				if (flag2)
				{
					goto IL_03c4;
				}
			}
			if (array.Length != 0)
			{
				object obj12 = array + 32;
				obj12 = activity;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj13 = typeof(SqlSingle[]) + 3592;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				AndroidJavaObject androidJavaObject = default(AndroidJavaObject);
				androidJavaObject..ctor("clear_mass_tournaments" + 3960, array);
				object obj14 = this + 32;
				obj14 = androidJavaObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj10 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj11 = obj10;
		goto IL_03c4;
		IL_03c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private static bool IsHuaweiRuntime()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8594]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
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
		goto IL_0196;
		IL_009d:
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Platform platform2 = KUtil.GetPlatform();
		object obj8 = platform2 - 4;
		return obj8 == null;
		IL_0196:
		return false;
		IL_0074:
		RuntimePlatform platform3 = Application.platform;
		if (platform3 == RuntimePlatform.Android)
		{
			goto IL_009d;
		}
		goto IL_0196;
	}

	private unsafe static AndroidJavaObject GetActivity()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_02f2: Expected O, but got Ref
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e2: Expected I, but got O
		//IL_00f2: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_0282: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3568;
		object obj2 = "com.unity.services.authentication.profile" + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AndroidJavaClass androidJavaClass = default(AndroidJavaClass);
		androidJavaClass..ctor((string)obj2);
		object fieldName = "com.unity.services.authentication.profile" + 2600;
		object obj3 = (nint)0 + (nint)1008;
		object obj4 = obj3;
		object obj5 = androidJavaClass.GetStatic<object>((string)fieldName);
		bool flag = androidJavaClass == null;
		object obj7 = default(object);
		object obj6 = obj7;
		object obj8 = 0;
		AndroidJavaClass androidJavaClass2 = androidJavaClass;
		object obj9 = 0;
		obj8 = 0;
		object obj10 = obj3;
		AndroidJavaObject result = (AndroidJavaObject)obj5;
		object obj11 = obj;
		object obj12 = 0;
		if (!flag)
		{
			goto IL_00c6;
		}
		goto IL_02be;
		IL_00c6:
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num = (nint)androidJavaClass2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v9 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v9 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_017e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v9 (Il2CppClass<UnityEngine.AndroidJavaClass>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v8-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj6 = obj14 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v9 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
			obj3 = -1;
			bool flag2 = (nint)obj3 != 1;
			obj14 = obj6;
			if (flag2)
			{
				continue;
			}
			goto IL_017e;
		}
		obj3 = obj14;
		object obj15 = num + obj14;
		object obj16 = obj15 + 312;
		obj6 = obj14;
		obj10 = obj4;
		obj11 = obj5;
		goto IL_0324;
		IL_02be:
		object obj18 = default(object);
		object obj19 = default(object);
		object obj21 = default(object);
		AndroidJavaObject result2 = default(AndroidJavaObject);
		while (true)
		{
			bool flag3 = obj12 == null;
			object obj17 = !flag3;
			obj8 = 0;
			obj4 = 0;
			fieldName = (object)(&obj18);
			if (obj17 == null)
			{
				return result;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)obj2 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj9 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag4 = androidJavaClass == null;
				object obj20 = !flag4;
				obj6 = obj7;
				obj8 = obj19;
				obj5 = null;
				androidJavaClass2 = androidJavaClass;
				if (obj20 != null)
				{
					break;
				}
				obj3 = obj21;
				obj8 = obj19;
				obj10 = 0;
				result = null;
				obj11 = obj;
				obj12 = obj19;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
		}
		goto IL_00c6;
		IL_017e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj10 = 0;
		obj11 = obj5;
		goto IL_0324;
		IL_0324:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ X0_v19] (should have been resolved before IL gen)");
		result = (AndroidJavaObject)obj11;
		obj12 = obj9;
		goto IL_02be;
	}

	public void StartConnection()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_0048: Expected I, but got O
		//IL_0058: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		if (_plugin == null)
		{
			return;
		}
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			NullReferenceException ex = default(NullReferenceException);
			if (ex != null)
			{
				object methodName = "setMimeType" + 4008;
				object obj3 = array + 32;
				obj3 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_plugin.Call((string)methodName, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			object obj2 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new IndexOutOfRangeException();
	}

	public void PromptSignIn()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_005e: Expected O, but got I4
		//IL_009c: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_0216: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0254: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0114: Expected O, but got I
		//IL_02c6: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0314: Expected O, but got I4
		//IL_0324: Expected O, but got I
		//IL_029e: Expected O, but got I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_0358: Expected O, but got I4
		if (_plugin == null)
		{
			return;
		}
		object obj = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 1056;
		object obj2 = (nint)0 + (nint)3232;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v5+38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v5+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+10]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag2 = obj9 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+10]");
			object obj10 = 0;
			if (!flag2)
			{
				goto IL_0122;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v5+38]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16+10]");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag3 = obj13 == null;
			object obj14 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16+10]");
			object obj10 = 0;
			if (obj14 != null)
			{
				goto IL_0122;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 != null)
		{
			goto IL_0147;
		}
		goto IL_02ac;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v5+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v24+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v24+10]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v24+10]");
		object obj20 = 0;
		if (!flag5)
		{
			goto IL_01b8;
		}
		goto IL_0332;
		IL_02ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v5+38]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v11+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v11+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag6 = obj23 == null;
		object obj24 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v11+10]");
		obj20 = 0;
		if (obj24 != null)
		{
			goto IL_01b8;
		}
		goto IL_0332;
		IL_0122:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0147;
		}
		goto IL_02ac;
		IL_01b8:
		object methodName = "placementId" + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v17+B8]");
		object args = 0;
		_plugin.Call((string)methodName, (object[])args);
		return;
		IL_0332:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag7 = _plugin == null;
		object obj25 = !flag7;
		if (obj25 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01b8;
	}

	public unsafe void FetchProducts(string[] productIds, int priceType)
	{
		//IL_004f: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_0731: Expected O, but got I
		//IL_0741: Expected O, but got I
		//IL_0757: Expected O, but got I
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_077f: Expected O, but got I4
		//IL_078f: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00b2: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_07f1: Expected O, but got I
		//IL_0801: Expected O, but got I
		//IL_0817: Expected O, but got I
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		//IL_07c9: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_0180: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_0852: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected I, but got Unknown
		//IL_0430: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_0278: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_0aef: Expected O, but got I4
		//IL_08a2: Expected O, but got I4
		//IL_097f: Expected O, but got I4
		//IL_0475: Expected I, but got O
		//IL_0485: Expected O, but got I
		//IL_02ae: Expected O, but got I4
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_0504: Expected O, but got I4
		//IL_0308: Expected I, but got O
		//IL_052a: Expected O, but got Ref
		//IL_0a0b: Expected O, but got I4
		//IL_08d9: Expected O, but got I4
		//IL_02c4: Expected I, but got O
		//IL_02d4: Expected O, but got I
		//IL_0595: Expected O, but got I8
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_0b17: Expected O, but got I4
		//IL_09a6: Expected O, but got I4
		//IL_0540: Expected I, but got O
		//IL_0550: Expected O, but got I
		//IL_091f: Expected O, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0667: Expected I, but got O
		//IL_0677: Expected O, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_0a39: Expected O, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_09cd: Expected O, but got I4
		//IL_0b59: Expected O, but got I
		//IL_06b2: Expected O, but got I
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected I, but got Unknown
		//IL_0608: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_0624: Expected O, but got I4
		//IL_062d: Expected O, but got I4
		//IL_063e: Expected O, but got I4
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06db: Expected O, but got I
		if (productIds == null || _plugin == null || productIds.Length == 0)
		{
			return;
		}
		object obj = (nint)0 + (nint)3232;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X22_v4+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X22_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v8+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v8+10]");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag = obj6 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v8+10]");
			object obj7 = 0;
			if (!flag)
			{
				goto IL_00ed;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X22_v4+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+10]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+10]");
			object obj7 = 0;
			if (obj11 != null)
			{
				goto IL_00ed;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 != null)
		{
			goto IL_0112;
		}
		goto IL_07d7;
		IL_0703:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object[] array = null;
		goto IL_0b49;
		IL_0a51:
		string text;
		object obj13;
		object[] array2;
		object[] array3;
		AndroidJavaObject androidJavaObject;
		object obj15;
		if ((nint)text == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj14 = default(object);
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj15 = obj14;
			array2 = array;
			array3 = (object[])(object)androidJavaObject;
			goto IL_0b8b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_08fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		obj15 = 0;
		object obj17;
		object obj16 = obj17;
		object[] array4;
		array = array4;
		text = null;
		AndroidJavaObject androidJavaObject2 = default(AndroidJavaObject);
		androidJavaObject = androidJavaObject2;
		goto IL_0a51;
		IL_0b49:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v18+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ X0_v18] (should have been resolved before IL gen)");
		goto IL_0afd;
		IL_08c7:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		obj15 = 0;
		obj16 = obj17;
		array = array4;
		ex = (OutOfMemoryException)(object)ex2;
		androidJavaObject = androidJavaObject2;
		goto IL_0a51;
		IL_094f:
		NullReferenceException ex3 = new NullReferenceException();
		ex = (OutOfMemoryException)(object)ex3;
		androidJavaObject = (AndroidJavaObject)(object)array3;
		goto IL_0a51;
		IL_00ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0112;
		}
		goto IL_07d7;
		IL_07d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X22_v4+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v10+10]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v10+10]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		if (obj21 == null)
		{
			goto IL_018e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v10+10]");
		object obj22 = 0;
		goto IL_019d;
		IL_0b8b:
		bool flag4 = androidJavaObject2 == null;
		array = array2;
		if (flag4)
		{
			goto IL_0afd;
		}
		object obj23 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num = (nint)androidJavaObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v30 (Il2CppClass<UnityEngine.AndroidJavaObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v30 (Il2CppClass<UnityEngine.AndroidJavaObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0703;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v30 (Il2CppClass<UnityEngine.AndroidJavaObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		object obj26;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X10_v8-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj26 = obj25 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v30 (Il2CppClass<UnityEngine.AndroidJavaObject>)+12E]");
			obj24 = -1;
			bool flag5 = (nint)obj24 != 1;
			obj25 = obj26;
			if (flag5)
			{
				continue;
			}
			goto IL_0703;
		}
		obj24 = obj25;
		object obj27 = num + obj25;
		object obj28 = obj27 + 312;
		obj26 = obj25;
		array = array2;
		goto IL_0b49;
		IL_0112:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X22_v4+38]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v58+10]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v58+10]");
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag6 = obj31 == null;
		object obj32 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v58+10]");
		obj22 = 0;
		if (obj32 == null)
		{
			goto IL_018e;
		}
		goto IL_019d;
		IL_018e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_019d;
		IL_019d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v11+B8]");
		object obj33 = 0;
		array3 = (object[])obj33;
		object obj34 = typeof(SqlSingle[]) + 3592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object className = "java.io.FileOutputStream" + 136;
		androidJavaObject2..ctor((string)className, (object[])obj33);
		nint num2 = productIds.Length;
		bool flag7 = productIds.Length < 1;
		obj16 = 0;
		array = (object[])obj33;
		if (flag7)
		{
			goto IL_03fa;
		}
		object obj35 = productIds + 32;
		object obj36 = typeof(TypeConverter<ushort, char>) + 3400;
		object methodName = "___# Content push apply failed [{0}]: {1}" + 3520;
		object obj37 = (nint)0 + (nint)840;
		object obj38 = 0;
		obj17 = 0;
		array4 = (object[])obj33;
		AndroidJavaObject androidJavaObject3 = default(AndroidJavaObject);
		object obj39 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag8 = androidJavaObject3 == null;
			text = (string)1;
			if (flag8)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X26_v3+v383 @ X25_v8*8]");
			bool flag9 = (nint)0 == 0;
			text = (string)1;
			if (!flag9)
			{
				nint num3 = (nint)androidJavaObject3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v55 (Il2CppClass<UnityEngine.AndroidJavaObject>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				if (obj39 == null)
				{
					goto IL_08fe;
				}
			}
			num2 = (nint)androidJavaObject3.m_jclass;
			if (androidJavaObject3.m_jclass != null)
			{
				object obj40 = androidJavaObject3 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X26_v3+v383 @ X25_v8*8]");
				obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag10 = androidJavaObject2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X26_v3+v383 @ X25_v8*8]");
				text = (string)0;
				if (flag10)
				{
					break;
				}
				obj16 = obj37;
				bool flag11 = androidJavaObject2.Call<bool>((string)methodName, (object[])(object)androidJavaObject3);
				object obj41 = obj38 + 1;
				num2 = productIds.Length;
				bool flag12 = (nint)obj41 < productIds.Length;
				array = (object[])(object)androidJavaObject3;
				array3 = (object[])(object)androidJavaObject2;
				obj38 = obj41;
				obj17 = obj37;
				array4 = (object[])(object)androidJavaObject3;
				if (flag12)
				{
					continue;
				}
				goto IL_03fa;
			}
			goto IL_08c7;
		}
		NullReferenceException ex4 = new NullReferenceException();
		obj15 = 0;
		obj16 = obj17;
		array = array4;
		ex = (OutOfMemoryException)(object)ex4;
		androidJavaObject = androidJavaObject2;
		goto IL_0a51;
		IL_0afd:
		bool flag13 = obj13 == null;
		object obj42 = !flag13;
		if (obj42 == null)
		{
			return;
		}
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_094f;
		IL_03fa:
		num2 = (nint)(typeof(TypeConverter<ushort, char>) + 3400);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array5 = default(string[]);
		bool flag14 = array5 == null;
		obj15 = 0;
		text = (string)2;
		if (flag14)
		{
			goto IL_094f;
		}
		bool flag15 = androidJavaObject2 == null;
		text = (string)2;
		if (!flag15)
		{
			nint num4 = (nint)array5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v49 (Il2CppClass<System.String[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj43 = default(object);
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
				ex = new OutOfMemoryException();
				obj15 = 0;
				text = null;
				androidJavaObject = androidJavaObject2;
				goto IL_0a51;
			}
		}
		num2 = array5.Length;
		if (array5.Length != 0)
		{
			object obj44 = array5 + 32;
			obj44 = androidJavaObject2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj45 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			string text2 = default(string);
			bool flag16 = text2 == null;
			int num5 = default(int);
			text = (string)(&num5);
			if (!flag16)
			{
				num2 = (nint)array5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v27 (Il2CppClass<System.String[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				object obj46 = default(object);
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
					ex = new OutOfMemoryException();
					obj15 = 0;
					text = null;
					androidJavaObject = androidJavaObject2;
					goto IL_0a51;
				}
			}
			num2 = array5.Length;
			object obj47 = array5.Length & 0xFFFFFFFEL;
			if (obj47 != null)
			{
				object obj48 = array5 + 40;
				obj48 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (_plugin != null)
				{
					num2 = (nint)("placementId" + 1944);
					text = (string)num2;
					_plugin.Call((string)num2, array5);
					obj15 = 0;
					obj16 = 0;
					array2 = array5;
					obj13 = 0;
					array3 = (object[])(object)androidJavaObject2;
					goto IL_0b8b;
				}
				NullReferenceException ex6 = new NullReferenceException();
				obj15 = 0;
				text = text2;
				ex = (OutOfMemoryException)(object)ex6;
				androidJavaObject = androidJavaObject2;
			}
			else
			{
				IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
				obj15 = 0;
				ex = (OutOfMemoryException)(object)ex7;
				androidJavaObject = androidJavaObject2;
			}
		}
		else
		{
			IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
			obj15 = 0;
			ex = (OutOfMemoryException)(object)ex8;
			androidJavaObject = androidJavaObject2;
		}
		goto IL_0a51;
	}

	public void Purchase(string productId, string developerPayload = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_00e5: Expected I, but got O
		//IL_00f5: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_01db: Expected O, but got I8
		//IL_01fa: Expected O, but got I
		//IL_0190: Expected I, but got O
		//IL_01b9: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		if (_plugin == null)
		{
			return;
		}
		object obj = "___# Content push apply failed [{0}]: {1}" + 1064;
		object obj2 = "&action=sign-up" + 2768;
		object obj3 = typeof(DataRelation) + 856;
		object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
		string text2 = default(string);
		string text = (string)obj + text2 + (string)obj2;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		object message = text;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag2 = array == null;
		string text3 = (string)2;
		if (flag2)
		{
			goto IL_0273;
		}
		bool flag3 = text2 == null;
		text3 = (string)2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text4;
		if (!flag3)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag4 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
			text4 = (string)0;
			if (flag4)
			{
				goto IL_0297;
			}
		}
		if (array.Length != 0)
		{
			object obj7 = array + 32;
			obj7 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (developerPayload != null)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				text4 = (string)0;
				if (flag5)
				{
					goto IL_0297;
				}
			}
			object obj8 = array.Length & 0xFFFFFFFEL;
			bool flag6 = obj8 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			if (!flag6)
			{
				object obj9 = array + 40;
				obj9 = developerPayload;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag7 = _plugin == null;
				text3 = developerPayload;
				if (!flag7)
				{
					object methodName = "placementId" + 1600;
					_plugin.Call((string)methodName, array);
					return;
				}
				goto IL_0273;
			}
		}
		goto IL_0281;
		IL_0297:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0281:
		ex = new IndexOutOfRangeException();
		text4 = text3;
		goto IL_0297;
		IL_0273:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0281;
	}

	public unsafe void ObtainOwnedPurchases(int priceType)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0032: Expected O, but got I4
		//IL_014a: Expected O, but got Ref
		//IL_0075: Expected O, but got Ref
		//IL_008b: Expected I, but got O
		//IL_009b: Expected O, but got I
		//IL_00c4: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		if (_plugin == null)
		{
			return;
		}
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		object obj4;
		int num = default(int);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj5;
		if (array != null)
		{
			object obj3 = default(object);
			bool flag = obj3 == null;
			obj4 = (object)(&num);
			if (!flag)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				if (flag2)
				{
					goto IL_0165;
				}
			}
			if (array.Length != 0)
			{
				object methodName = "not" + 888;
				object obj6 = array + 32;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_plugin.Call((string)methodName, array);
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj4 = (object)(&num);
		}
		ex = new IndexOutOfRangeException();
		obj5 = obj4;
		goto IL_0165;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void Consume(string purchaseToken)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_011a: Expected I, but got O
		//IL_012a: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		if (_plugin == null || string.IsNullOrEmpty(purchaseToken))
		{
			return;
		}
		object obj = typeof(DataRelation) + 856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "___# Content push apply failed [{0}]: {1}" + 1040;
		Debug.Log(message);
		object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag2 = array == null;
		string text = (string)1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text2;
		if (!flag2)
		{
			bool flag3 = purchaseToken == null;
			text = (string)1;
			if (!flag3)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag4)
				{
					goto IL_020e;
				}
			}
			if (array.Length == 0)
			{
				goto IL_01f8;
			}
			object obj5 = array + 32;
			obj5 = purchaseToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag5 = _plugin == null;
			text = purchaseToken;
			if (!flag5)
			{
				object methodName = "com.unity.services.authentication.profile" + 720;
				_plugin.Call((string)methodName, array);
				return;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01f8;
		IL_01f8:
		ex = new IndexOutOfRangeException();
		text2 = text;
		goto IL_020e;
		IL_020e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public ProductMetadata GetProductMetadata(string productId)
	{
		//IL_0082: Expected O, but got I4
		if (_plugin == null || string.IsNullOrEmpty(productId))
		{
			return null;
		}
		if (_productMetadata != null)
		{
			object value;
			bool flag = ((Dictionary<object, object>)(object)_productMetadata).TryGetValue((object)productId, out value);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				RefreshProductMetadata();
				if (_productMetadata == null)
				{
					goto IL_00d6;
				}
				bool flag3 = ((Dictionary<object, object>)(object)_productMetadata).TryGetValue((object)productId, out value);
			}
			return (ProductMetadata)value;
		}
		goto IL_00d6;
		IL_00d6:
		return (ProductMetadata)(object)new NullReferenceException();
	}

	private unsafe void RefreshProductMetadata()
	{
		//IL_0010: Expected O, but got I
		//IL_0d1a: Expected O, but got I4
		//IL_0021: Expected O, but got I
		//IL_002d: Expected O, but got I
		//IL_0035: Expected I, but got O
		//IL_0058: Expected O, but got I
		//IL_0c58: Expected I, but got O
		//IL_0c6f: Expected O, but got I4
		//IL_01bd: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01e3: Expected O, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_020b: Expected O, but got I4
		//IL_021b: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_028d: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I4
		//IL_02db: Expected O, but got I
		//IL_0255: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_032d: Expected O, but got I
		//IL_033d: Expected O, but got I
		//IL_0390: Expected O, but got I4
		//IL_039a: Expected I, but got O
		//IL_03a2: Expected O, but got I4
		//IL_0b2a: Expected O, but got I
		//IL_03d1: Expected I, but got O
		//IL_0fd2: Expected O, but got I4
		//IL_0fe2: Expected I, but got O
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected O, but got Unknown
		//IL_0a3a: Expected I, but got O
		//IL_0a4a: Expected O, but got I
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_1024: Expected O, but got I
		//IL_0a85: Expected O, but got I
		//IL_0b6d: Expected O, but got I4
		//IL_0422: Expected I, but got O
		//IL_0432: Expected O, but got I
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected O, but got Unknown
		//IL_0aae: Expected O, but got I
		//IL_0d71: Expected I, but got O
		//IL_0d81: Expected O, but got I
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected O, but got Unknown
		//IL_046d: Expected O, but got I
		//IL_0a10: Expected O, but got I4
		//IL_0a19: Expected O, but got I4
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_0b8d: Expected O, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_049e: Expected O, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0577: Expected I, but got O
		//IL_0587: Expected O, but got I
		//IL_0dfe: Expected I, but got O
		//IL_0e0e: Expected O, but got I
		//IL_05c2: Expected O, but got I
		//IL_0bad: Expected O, but got I4
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06aa: Expected I, but got O
		//IL_06ba: Expected O, but got I
		//IL_06ca: Expected O, but got I
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected O, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_05f3: Expected O, but got I
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_0e5c: Expected O, but got I4
		//IL_06f9: Expected I, but got O
		//IL_0709: Expected O, but got I
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got Unknown
		//IL_074c: Expected I, but got O
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0833: Expected O, but got I4
		//IL_083c: Expected I8, but got I4
		//IL_0845: Expected I8, but got I4
		//IL_077f: Expected O, but got I
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		//IL_07d2: Expected O, but got I4
		//IL_0898: Expected O, but got I4
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_08b3: Expected I, but got O
		//IL_0e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Expected O, but got Unknown
		//IL_0ea3: Expected I, but got O
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed9: Expected O, but got Unknown
		//IL_0ee1: Expected I, but got O
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected O, but got Unknown
		//IL_0f27: Expected I, but got O
		//IL_0f37: Expected O, but got I
		//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Expected I, but got Unknown
		//IL_096d: Expected O, but got I
		//IL_097d: Expected O, but got I
		//IL_0bc4: Expected O, but got I4
		//IL_0bcd: Expected O, but got I4
		//IL_0bf1: Expected O, but got I4
		//IL_09b2: Expected O, but got I
		//IL_09ce: Expected O, but got I4
		//IL_09d7: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj = 0;
		bool flag = _productMetadata == null;
		object obj2 = 152993792;
		nint num;
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)208;
			obj2 = (nint)0 + (nint)3232;
			num = (nint)obj3;
			((Dictionary<object, object>)(object)_productMetadata).Clear();
			ProductMetadata productMetadata = (ProductMetadata)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X21_v8 (UnityEngine.Purchasing.ProductMetadata)+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X21_v8 (UnityEngine.Purchasing.ProductMetadata)+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v22+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v22+10]");
				object obj6 = (nint)0 + (nint)309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v22+10]");
				object obj8 = 0;
				if (!flag2)
				{
					goto IL_00de;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X21_v8 (UnityEngine.Purchasing.ProductMetadata)+38]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v88+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v88+10]");
				object obj10 = (nint)0 + (nint)309;
				object obj11 = obj10 & 1;
				bool flag3 = obj11 == null;
				object obj12 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v88+10]");
				object obj8 = 0;
				if (obj12 != null)
				{
					goto IL_00de;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v94+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_0103;
			}
			goto IL_0263;
		}
		goto IL_0c24;
		IL_1014:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v7+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v715 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_0fb8;
		IL_09fe:
		IEnumerator<JToken> enumerator2;
		IEnumerator<JToken> enumerator = enumerator2;
		object obj14 = 0;
		obj2 = 0;
		goto IL_1042;
		IL_0fb8:
		bool flag5 = obj2 == null;
		object obj15 = !flag5;
		string text2;
		object[] array = (object[])(object)text2;
		num = (nint)text;
		NullReferenceException ex2 = default(NullReferenceException);
		if (obj15 != null)
		{
			OutOfMemoryException ex = new OutOfMemoryException();
			ex2 = (NullReferenceException)(object)ex;
			goto IL_0c83;
		}
		goto IL_0b1a;
		IL_0c37:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
		nint num2 = (nint)obj2;
		object obj16 = obj2;
		text = (string)(139026432 + 4064);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
		text2 = null;
		goto IL_0c83;
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v94+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0103;
		}
		goto IL_0263;
		IL_0263:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X21_v8 (UnityEngine.Purchasing.ProductMetadata)+38]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v83+10]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v83+10]");
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag6 = obj20 == null;
		object obj21 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v83+10]");
		object obj22 = 0;
		if (obj21 != null)
		{
			goto IL_0174;
		}
		goto IL_02e9;
		IL_0103:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X21_v8 (UnityEngine.Purchasing.ProductMetadata)+38]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v93+10]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v93+10]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag7 = obj25 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v93+10]");
		obj22 = 0;
		if (!flag7)
		{
			goto IL_0174;
		}
		goto IL_02e9;
		IL_02e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		if (_plugin != null)
		{
			goto IL_0312;
		}
		goto IL_0c24;
		IL_0174:
		bool flag8 = _plugin == null;
		object obj26 = !flag8;
		if (obj26 != null)
		{
			goto IL_0312;
		}
		goto IL_0c24;
		IL_0312:
		object methodName = "getCreator" + 3296;
		object obj27 = (nint)0 + (nint)912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v30+B8]");
		object obj28 = 0;
		array = (object[])obj28;
		string text3 = (string)obj27;
		object obj29 = _plugin.Call<object>((string)methodName, (object[])obj28);
		bool flag9 = string.IsNullOrEmpty((string)obj29);
		bool flag10 = !flag9;
		object obj30 = !flag10;
		enumerator = null;
		num = unchecked((nint)null);
		NullReferenceException ex3 = (NullReferenceException)flag9;
		if (obj30 != null)
		{
			goto IL_0b1a;
		}
		JArray jArray = JArray.Parse((string)obj29);
		bool flag11 = jArray == null;
		num = unchecked((nint)null);
		if (flag11)
		{
			goto IL_0c24;
		}
		enumerator2 = jArray.GetEnumerator();
		object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		text2 = (string)obj28;
		text = null;
		num2 = (nint)(&enumerator);
		bool flag13 = default(bool);
		object obj35 = default(object);
		decimal num7;
		ProductMetadata productMetadata2 = default(ProductMetadata);
		object obj37 = default(object);
		string text4;
		string text5 = default(string);
		object obj40 = default(object);
		string text6;
		string text7 = default(string);
		object obj43 = default(object);
		string text8;
		string text9 = default(string);
		object obj47 = default(object);
		string text10;
		string text11 = default(string);
		ProductMetadata productMetadata3 = default(ProductMetadata);
		object obj50 = default(object);
		ProductMetadata productMetadata4 = default(ProductMetadata);
		IEnumerable<JToken> enumerable = default(IEnumerable<JToken>);
		object obj49;
		decimal num12;
		decimal num13;
		string text13;
		while (enumerator2 != null)
		{
			nint num3 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04f2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
			object obj32 = (nint)0 + (nint)8;
			bool flag12 = flag13;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v25-8]");
				object obj33 = 0 - obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X10_v25-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				obj28 = obj32 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
				obj27 = -1;
				obj33 = obj27 - 1;
				bool flag14 = obj33 == null;
				flag13 = (nint)obj27 != 1;
				flag12 = flag13;
				obj32 = obj28;
				if (flag13)
				{
					continue;
				}
				goto IL_04f2;
			}
			obj27 = obj32;
			object obj34 = num3 + obj32;
			obj35 = obj34 + 312;
			flag13 = flag12;
			obj28 = obj32;
			goto IL_0d69;
			IL_086a:
			long num5;
			decimal num4 = num5;
			decimal num6 = 1000000m;
			num7 = num4 / 0m;
			object obj36 = "placementId" + 864;
			nint num8 = (nint)productMetadata2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v867 @ X8_v47 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248] (should have been resolved before IL gen)");
			if (obj37 != null)
			{
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v873 @ X8_v68+168] (should have been resolved before IL gen)");
				text4 = text5;
			}
			else
			{
				text4 = null;
			}
			object obj39 = "placementId" + 1128;
			nint num9 = (nint)productMetadata2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v886 @ X8_v51 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248] (should have been resolved before IL gen)");
			if (obj40 != null)
			{
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v892 @ X8_v67+168] (should have been resolved before IL gen)");
				text6 = text7;
			}
			else
			{
				text6 = null;
			}
			object obj42 = "com.unity.services.authentication.profile" + 4008;
			nint num10 = (nint)productMetadata2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v905 @ X8_v55 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248] (should have been resolved before IL gen)");
			if (obj43 != null)
			{
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v911 @ X8_v66+168] (should have been resolved before IL gen)");
				text8 = text9;
			}
			else
			{
				text8 = null;
			}
			object obj45 = "com.unity.services.authentication.profile" + 2576;
			object obj46 = obj45;
			nint num11 = (nint)productMetadata2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X8_v59 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v924 @ X8_v59 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248] (should have been resolved before IL gen)");
			if (obj47 != null)
			{
				object obj48 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v65+168]");
				obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v65+170]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v930 @ X8_v65+168] (should have been resolved before IL gen)");
				text10 = text11;
			}
			else
			{
				text10 = null;
			}
			num2 = (nint)(typeof(System.Buffers.Text.ParserHelpers) + 2104);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			productMetadata3..ctor(text4, text6, text8, text10, num7);
			string text12;
			if (_productMetadata != null)
			{
				num2 = (nint)0 + (nint)224;
				text3 = (string)num2;
				((Dictionary<object, object>)(object)_productMetadata).set_Item((object)text12, (object)productMetadata3);
				obj49 = 0;
				num12 = 0m;
				num13 = num7;
				text13 = text10;
				text2 = (string)(object)productMetadata3;
				text = text12;
				continue;
			}
			goto IL_0bb2;
			IL_0647:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text2 = null;
			goto IL_0df6;
			IL_0df6:
			num2 = (nint)obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v43+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v786 @ X0_v43] (should have been resolved before IL gen)");
			long num16;
			if (productMetadata2 != null)
			{
				object obj51 = "placementId" + 1120;
				num2 = (nint)productMetadata2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248]");
				obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+250]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v420 @ X8_v7 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248] (should have been resolved before IL gen)");
				if (productMetadata4 != null)
				{
					num2 = (nint)productMetadata4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+168]");
					obj27 = 0;
					string text14 = productMetadata4.ToString();
					text12 = text14;
				}
				else
				{
					text12 = null;
				}
				bool flag15 = string.IsNullOrEmpty(text12);
				bool flag16 = !flag15;
				object obj52 = !flag16;
				text = null;
				if (obj52 != null)
				{
					continue;
				}
				object obj53 = "m_StencilDeferredPS" + 1488;
				object obj54 = obj53;
				nint num14 = (nint)productMetadata2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X8_v42 (Il2CppClass<UnityEngine.Purchasing.ProductMetadata>)+248] (should have been resolved before IL gen)");
				if (enumerable != null)
				{
					object obj55 = (nint)0 + (nint)2280;
					obj54 = obj55;
					long num15 = Extensions.Value<long>(enumerable);
					object obj56 = typeof(DataRelation) + 1368;
					object obj57 = obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X0_v80+E4]");
					bool flag17 = (nint)0 == 0;
					object obj58 = !flag17;
					num5 = num15;
					if (obj58 == null)
					{
						num16 = num15;
						goto IL_0853;
					}
				}
				else
				{
					object obj59 = typeof(DataRelation) + 1368;
					object obj57 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X0_v80+E4]");
					bool flag18 = (nint)0 == 0;
					object obj60 = !flag18;
					num16 = 0L;
					num5 = 0L;
					if (obj60 == null)
					{
						goto IL_0853;
					}
				}
				goto IL_086a;
			}
			goto IL_0b92;
			IL_0853:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num5 = num16;
			goto IL_086a;
			IL_04f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text2 = null;
			goto IL_0d69;
			IL_0d69:
			num2 = (nint)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v39+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v722 @ X0_v39] (should have been resolved before IL gen)");
			object obj61 = ex3 & 1;
			if (obj61 == null)
			{
				goto IL_09fe;
			}
			if (enumerator2 == null)
			{
				goto IL_0b72;
			}
			object obj62 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 808;
			nint num17 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0647;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
			object obj63 = (nint)0 + (nint)8;
			bool flag19 = flag13;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X10_v20-8]");
				object obj33 = 0 - obj62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X10_v20-8]");
				if (0 == (nint)obj62)
				{
					break;
				}
				obj28 = obj63 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
				obj27 = -1;
				obj33 = obj27 - 1;
				bool flag14 = obj33 == null;
				flag13 = (nint)obj27 != 1;
				flag19 = flag13;
				obj63 = obj28;
				if (flag13)
				{
					continue;
				}
				goto IL_0647;
			}
			obj27 = obj63;
			object obj64 = num17 + obj63;
			obj50 = obj64 + 312;
			flag13 = flag19;
			obj28 = obj63;
			goto IL_0df6;
		}
		ex2 = new NullReferenceException();
		enumerator = enumerator2;
		obj14 = 0;
		goto IL_0c83;
		IL_1042:
		if (enumerator == null)
		{
			goto IL_0fb8;
		}
		object obj65 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num18 = (nint)enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ad6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
		object obj66 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X10_v7-8]");
			if (0 == (nint)obj65)
			{
				break;
			}
			obj28 = obj66 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			obj27 = -1;
			bool flag20 = (nint)obj27 != 1;
			obj66 = obj28;
			if (flag20)
			{
				continue;
			}
			goto IL_0ad6;
		}
		obj27 = obj66;
		object obj67 = num18 + obj66;
		object obj68 = obj67 + 312;
		obj28 = obj66;
		goto IL_1014;
		IL_0b72:
		ex2 = new NullReferenceException();
		enumerator = enumerator2;
		obj14 = 0;
		goto IL_0c83;
		IL_0c83:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		NullReferenceException ex4 = ex2;
		NullReferenceException ex5 = default(NullReferenceException);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			if ((nint)text == 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			ex4 = ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
		object obj69 = default(object);
		obj2 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		obj14 = obj69;
		goto IL_1042;
		IL_0bb2:
		ex2 = new NullReferenceException();
		obj49 = 0;
		num12 = 0m;
		num13 = num7;
		text13 = text10;
		enumerator = enumerator2;
		obj14 = 0;
		text3 = text8;
		text2 = text6;
		text = text4;
		goto IL_0c83;
		IL_0ad6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text2 = null;
		goto IL_1014;
		IL_0b1a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj70 = 0;
		obj27 = obj70;
		if (obj70 == obj)
		{
			return;
		}
		goto IL_0c37;
		IL_0b92:
		ex2 = new NullReferenceException();
		enumerator = enumerator2;
		obj14 = 0;
		goto IL_0c83;
		IL_0c24:
		ex3 = new NullReferenceException();
		enumerator = null;
		goto IL_0c37;
	}

	public void Dispose()
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I4
		//IL_0208: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_0290: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02b8: Expected O, but got I4
		//IL_02c8: Expected O, but got I
		//IL_0242: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_017b: Expected O, but got I
		//IL_00fb: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_014e: Expected O, but got I
		//IL_02fc: Expected O, but got I4
		if (_plugin == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)208;
		object obj2 = (nint)0 + (nint)3232;
		((Dictionary<object, object>)(object)_productMetadata).Clear();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v6+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v6+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+10]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+10]");
			object obj8 = 0;
			if (!flag)
			{
				goto IL_00c6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v6+38]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+10]");
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+10]");
			object obj8 = 0;
			if (obj12 != null)
			{
				goto IL_00c6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			goto IL_00eb;
		}
		goto IL_0250;
		IL_0250:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v6+38]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10+10]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10+10]");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag4 = obj17 == null;
		object obj18 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10+10]");
		object obj19 = 0;
		if (obj18 != null)
		{
			goto IL_015c;
		}
		goto IL_02d6;
		IL_015c:
		object methodName = "destinationTimeZone" + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v15+B8]");
		object args = 0;
		_plugin.Call((string)methodName, (object[])args);
		return;
		IL_02d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag5 = _plugin == null;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015c;
		IL_00eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v6+38]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v23+10]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v23+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag6 = obj23 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v23+10]");
		obj19 = 0;
		if (!flag6)
		{
			goto IL_015c;
		}
		goto IL_02d6;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00eb;
		}
		goto IL_0250;
	}

	private void onConnected()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0136: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8546]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f7;
		}
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 1072;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object message = obj4;
		if (!flag)
		{
			goto IL_0094;
		}
		goto IL_014c;
		IL_014c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
		Action action = OnConnected;
		bool flag2 = OnConnected == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_0094:
		Debug.Log(obj4);
		action = OnConnected;
		if (OnConnected != null)
		{
			goto IL_00c6;
		}
		return;
		IL_00c6:
		IntPtr invoke_impl = ((Delegate)action).invoke_impl;
		IntPtr method_code = ((Delegate)action).method_code;
		IntPtr method = ((Delegate)action).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_00f7;
		IL_00f7:
		_ = 1;
		obj4 = "___# Content push apply failed [{0}]: {1}" + 1072;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		message = obj4;
		if (obj7 != null)
		{
			goto IL_0094;
		}
		goto IL_014c;
	}

	private void onDisconnected(int responseCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1088;
		object obj = typeof(DataRelation) + 856;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object message = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		Action<int> action = OnDisconnected;
		if (OnDisconnected != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X8_v6 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
		}
	}

	private void onFetchProductsFinished(bool success, string message = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1096;
		object obj = typeof(DataRelation) + 856;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string message2 = string.Format((string)format, arg, message);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			Debug.Log(message2);
			bool flag = !success;
			object obj4 = !flag;
			if (obj4 == null)
			{
				goto IL_0056;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message2);
			if (!success)
			{
				goto IL_0056;
			}
		}
		RefreshProductMetadata();
		Action<bool, string> action = OnFetchProductsFinished;
		bool flag2 = OnFetchProductsFinished == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return;
		}
		goto IL_007f;
		IL_007f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X8_v8 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
		return;
		IL_0056:
		action = OnFetchProductsFinished;
		if (OnFetchProductsFinished != null)
		{
			goto IL_007f;
		}
	}

	private void onPurchaseSucceeded(string receipt, string purchaseToken)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0193: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8549]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0100;
		}
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 1128;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object message = obj4;
		if (!flag)
		{
			goto IL_0094;
		}
		goto IL_0155;
		IL_0155:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
		Action<string, string> action = OnPurchaseSucceeded;
		bool flag2 = OnPurchaseSucceeded == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_0094:
		Debug.Log(obj4);
		action = OnPurchaseSucceeded;
		if (OnPurchaseSucceeded != null)
		{
			goto IL_00c6;
		}
		return;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7 (System.Action`2<System.String, System.String>)+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7 (System.Action`2<System.String, System.String>)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7 (System.Action`2<System.String, System.String>)+28]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_0100;
		IL_0100:
		_ = 1;
		obj4 = "___# Content push apply failed [{0}]: {1}" + 1128;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		message = obj4;
		if (obj10 != null)
		{
			goto IL_0094;
		}
		goto IL_0155;
	}

	private void onPurchaseFailed(int responseCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1120;
		object obj = typeof(DataRelation) + 856;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object message = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		Action<int> action = OnPurchaseFailed;
		if (OnPurchaseFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X8_v6 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
		}
	}

	private void onOwnedPurchasesFetched(string receipts)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0193: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E854B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0100;
		}
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 1112;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object message = obj4;
		if (!flag)
		{
			goto IL_0094;
		}
		goto IL_0155;
		IL_0155:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
		Action<string> action = OnOwnedPurchasesFetched;
		bool flag2 = OnOwnedPurchasesFetched == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_0094:
		Debug.Log(obj4);
		action = OnOwnedPurchasesFetched;
		if (OnOwnedPurchasesFetched != null)
		{
			goto IL_00c6;
		}
		return;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7 (System.Action`1<System.String>)+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7 (System.Action`1<System.String>)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7 (System.Action`1<System.String>)+28]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0100;
		IL_0100:
		_ = 1;
		obj4 = "___# Content push apply failed [{0}]: {1}" + 1112;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		message = obj4;
		if (obj10 != null)
		{
			goto IL_0094;
		}
		goto IL_0155;
	}

	private void onOwnedPurchasesFetchFailed(int responseCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1104;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object obj5 = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = text;
		}
		KLogger.LogError(obj5);
		Action<int> action = OnOwnedPurchasesFetchFailed;
		if (OnOwnedPurchasesFetchFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X8_v6 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
		}
	}

	private void onConsumeFinished(string purchaseToken, bool success, int responseCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_009d: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1080;
		object obj = typeof(DataRelation) + 856;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object message = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		Action<string, bool, int> action = OnConsumeFinished;
		if (OnConsumeFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ X8_v4 (System.Action`3<System.String, System.Boolean, System.Int32>)+18] (should have been resolved before IL gen)");
		}
	}
}
