using System;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.TextCore;

namespace Managers.IAP;

public class GooglePlayBillingManager : AndroidJavaProxy
{
	private AndroidJavaObject _plugin;

	public Action OnConnected;

	public Action OnDisconnected;

	public Action<bool, string> OnFetchProductsFinished;

	public Action<int> OnPurchaseFailed;

	public GooglePlayBillingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_02b8: Expected O, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_023a: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_0103: Expected I, but got O
		//IL_0113: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 3608;
		object obj2 = "clear_mass_tournaments" + 3952;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base..ctor((string)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.Android)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 != RuntimePlatform.Android)
			{
				return;
			}
		}
		object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		GooglePlayBillingManager googlePlayBillingManager = default(GooglePlayBillingManager);
		AndroidJavaObject activity = googlePlayBillingManager.GetActivity();
		object obj8;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj9;
		if (googlePlayBillingManager != null)
		{
			bool flag2 = activity == null;
			obj8 = 1;
			if (!flag2)
			{
				nint num = (nint)googlePlayBillingManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15 (Il2CppClass<Managers.IAP.GooglePlayBillingManager>)+40]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15 (Il2CppClass<Managers.IAP.GooglePlayBillingManager>)+40]");
				obj9 = 0;
				if (flag3)
				{
					goto IL_0255;
				}
			}
			if (((AndroidJavaProxy)googlePlayBillingManager).proxyObject != (IntPtr)0)
			{
				object obj10 = googlePlayBillingManager + 32;
				obj10 = activity;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = typeof(SqlSingle[]) + 3592;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object className = "clear_mass_tournaments" + 3944;
				AndroidJavaObject androidJavaObject = default(AndroidJavaObject);
				androidJavaObject..ctor((string)className, (object[])(object)googlePlayBillingManager);
				object obj12 = this + 32;
				obj12 = androidJavaObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj8 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj9 = obj8;
		goto IL_0255;
		IL_0255:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private unsafe AndroidJavaObject GetActivity()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_0403: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_0414: Expected O, but got Ref
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0220: Expected I, but got O
		//IL_0230: Expected O, but got I
		//IL_02d7: Expected O, but got I4
		//IL_026b: Expected O, but got I
		//IL_037c: Expected O, but got I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0294: Expected O, but got I
		//IL_03c8: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8533]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		bool flag2 = platform != RuntimePlatform.Android;
		AndroidJavaObject result = null;
		if (!flag2)
		{
			goto IL_011f;
		}
		goto IL_031c;
		IL_031c:
		return result;
		IL_02bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj6;
		object obj5 = obj6;
		object obj7 = 0;
		goto IL_0446;
		IL_03e0:
		object obj8;
		object obj11;
		object obj13 = default(object);
		object obj14;
		object obj15;
		object obj16 = default(object);
		AndroidJavaClass androidJavaClass = default(AndroidJavaClass);
		object obj19 = default(object);
		AndroidJavaClass androidJavaClass2;
		object obj20 = default(object);
		object obj22 = default(object);
		AndroidJavaObject result2 = default(AndroidJavaObject);
		object obj12;
		object obj10;
		object obj21;
		object obj18;
		while (true)
		{
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			obj10 = 0;
			obj11 = 0;
			obj12 = (object)(&obj13);
			if (obj9 == null)
			{
				break;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)obj14 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag4 = androidJavaClass == null;
				object obj17 = !flag4;
				obj18 = obj19;
				obj10 = obj16;
				obj6 = null;
				androidJavaClass2 = androidJavaClass;
				if (obj17 == null)
				{
					obj5 = obj20;
					obj21 = obj22;
					obj10 = obj16;
					obj7 = 0;
					result = null;
					obj8 = obj16;
					continue;
				}
				goto IL_0204;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
		}
		goto IL_031c;
		IL_0074:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.Android)
		{
			goto IL_011f;
		}
		result = null;
		goto IL_031c;
		IL_011f:
		object obj23 = typeof(SqlSingle[]) + 3568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj14 = "com.unity.services.authentication.profile" + 88;
		androidJavaClass..ctor((string)obj14);
		object fieldName = "com.unity.services.authentication.profile" + 2600;
		obj12 = (nint)0 + (nint)1008;
		obj11 = obj12;
		obj6 = androidJavaClass.GetStatic<object>((string)fieldName);
		bool flag5 = androidJavaClass == null;
		obj18 = obj19;
		obj10 = 0;
		androidJavaClass2 = androidJavaClass;
		obj15 = 0;
		obj5 = obj20;
		obj21 = obj22;
		obj10 = 0;
		obj7 = obj12;
		result = (AndroidJavaObject)obj6;
		obj8 = 0;
		if (!flag5)
		{
			goto IL_0204;
		}
		goto IL_03e0;
		IL_0204:
		object obj24 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num = (nint)androidJavaClass2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14 (Il2CppClass<UnityEngine.AndroidJavaClass>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X10_v9-8]");
			if (0 == (nint)obj24)
			{
				break;
			}
			obj18 = obj25 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
			obj21 = -1;
			bool flag6 = (nint)obj21 != 1;
			obj25 = obj18;
			if (flag6)
			{
				continue;
			}
			goto IL_02bc;
		}
		obj21 = obj25;
		object obj26 = num + obj25;
		object obj27 = obj26 + 312;
		obj5 = obj6;
		obj18 = obj25;
		obj7 = obj11;
		goto IL_0446;
		IL_0446:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X0_v20] (should have been resolved before IL gen)");
		result = (AndroidJavaObject)obj5;
		obj8 = obj15;
		goto IL_03e0;
	}

	public void StartConnection()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_00f2: Expected I, but got O
		//IL_0102: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8534]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_00a6;
		IL_020f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		throw new IndexOutOfRangeException();
		IL_00a6:
		object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag2 = array == null;
		GooglePlayBillingManager googlePlayBillingManager = (GooglePlayBillingManager)1;
		NullReferenceException ex2 = default(NullReferenceException);
		if (!flag2)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
			googlePlayBillingManager = (GooglePlayBillingManager)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			if (ex2 == null)
			{
				goto IL_020f;
			}
			object obj7 = array + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = _plugin == null;
			googlePlayBillingManager = this;
			if (!flag3)
			{
				object methodName = "setMimeType" + 4008;
				_plugin.Call((string)methodName, array);
				return;
			}
		}
		ex2 = new NullReferenceException();
		goto IL_020f;
		IL_007d:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.Android)
		{
			goto IL_00a6;
		}
	}

	public void FetchProducts(string[] productIds)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0487: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_04e5: Expected O, but got I
		//IL_04f5: Expected O, but got I
		//IL_050b: Expected O, but got I
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_0533: Expected O, but got I4
		//IL_0543: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_057d: Expected O, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		//IL_0223: Expected O, but got I
		//IL_025b: Expected O, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_08a2: Expected O, but got I4
		//IL_05b7: Expected O, but got I4
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_07e1: Expected I, but got O
		//IL_07f1: Expected O, but got I
		//IL_0815: Expected O, but got I4
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_0756: Expected O, but got I4
		//IL_075f: Expected O, but got I4
		//IL_0770: Expected O, but got I4
		//IL_02bb: Expected O, but got I4
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0300: Expected O, but got I
		//IL_0309: Expected O, but got I4
		//IL_0312: Expected O, but got I4
		//IL_0637: Expected I, but got O
		//IL_0647: Expected O, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_034c: Expected I, but got O
		//IL_035c: Expected O, but got I
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03ea: Expected O, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8535]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_00a6;
		IL_0883:
		NullReferenceException ex;
		bool flag2 = ((Exception)ex)._message == null;
		object obj6 = !flag2;
		object obj8;
		object obj7 = obj8;
		object[] array2;
		object[] array = array2;
		GooglePlayBillingManager googlePlayBillingManager2;
		GooglePlayBillingManager googlePlayBillingManager = googlePlayBillingManager2;
		NullReferenceException ex2 = ex;
		if (obj6 == null)
		{
			goto IL_08d0;
		}
		object obj9 = ex2 + 32;
		obj9 = googlePlayBillingManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		throw new NullReferenceException();
		IL_08d0:
		obj7 = obj8;
		array = array2;
		googlePlayBillingManager = googlePlayBillingManager2;
		ex2 = ex;
		throw new IndexOutOfRangeException();
		IL_05cd:
		GooglePlayBillingManager googlePlayBillingManager3 = (GooglePlayBillingManager)(object)_plugin;
		object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		NullReferenceException ex3 = default(NullReferenceException);
		AndroidJavaObject androidJavaObject = default(AndroidJavaObject);
		object obj12 = default(object);
		NullReferenceException ex4;
		object obj13;
		object[] array3;
		if (ex3 != null)
		{
			if (androidJavaObject != null)
			{
				nint num = (nint)ex3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v37 (Il2CppClass<System.NullReferenceException>)+40]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = obj12 == null;
				ex4 = ex3;
				if (flag3)
				{
					goto IL_084b;
				}
			}
			bool flag4 = ((Exception)ex3)._message == null;
			obj8 = obj13;
			array2 = array3;
			googlePlayBillingManager2 = googlePlayBillingManager3;
			ex = ex3;
			if (flag4)
			{
				goto IL_08d0;
			}
			object obj14 = ex3 + 32;
			obj14 = androidJavaObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (googlePlayBillingManager3 != null)
			{
				object methodName = "placementId" + 1944;
				((AndroidJavaObject)(object)googlePlayBillingManager3).Call((string)methodName, (object[])(object)ex3);
				return;
			}
		}
		goto IL_078e;
		IL_007d:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.Android)
		{
			goto IL_00a6;
		}
		return;
		IL_00a6:
		object obj15 = (nint)0 + (nint)3232;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X21_v3+38]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X21_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9+10]");
			object obj19 = (nint)0 + (nint)309;
			object obj20 = obj19 & 1;
			bool flag5 = obj20 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9+10]");
			object obj21 = 0;
			if (!flag5)
			{
				goto IL_0150;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X21_v3+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v13+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v13+10]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag6 = obj24 == null;
			object obj25 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v13+10]");
			object obj21 = 0;
			if (obj25 != null)
			{
				goto IL_0150;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v32+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 != null)
		{
			goto IL_0175;
		}
		goto IL_058b;
		IL_044a:
		object[] array4 = default(object[]);
		array3 = array4;
		goto IL_05cd;
		IL_084b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex5 = new OutOfMemoryException();
		obj8 = obj13;
		array2 = array3;
		googlePlayBillingManager2 = googlePlayBillingManager3;
		ex = ex4;
		goto IL_0883;
		IL_078e:
		NullReferenceException ex6 = new NullReferenceException();
		obj8 = obj13;
		array2 = array3;
		googlePlayBillingManager2 = googlePlayBillingManager3;
		goto IL_07b4;
		IL_0150:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0175;
		}
		goto IL_058b;
		IL_058b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0175;
		IL_0175:
		object obj27 = typeof(SqlSingle[]) + 3592;
		object className = "java.io.FileOutputStream" + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X21_v3+38]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v17+10]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v17+10]");
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag8 = obj31 == null;
		object obj32 = !flag8;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v41+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		androidJavaObject..ctor((string)className, (object[])obj33);
		bool flag9 = productIds == null;
		obj13 = 0;
		array3 = (object[])obj33;
		googlePlayBillingManager3 = this;
		if (!flag9)
		{
			object obj34 = productIds + 32;
			if (androidJavaObject != null)
			{
				bool flag10 = productIds.Length < 1;
				obj13 = 0;
				array3 = (object[])obj33;
				if (flag10)
				{
					goto IL_05cd;
				}
				object obj35 = typeof(TypeConverter<ushort, char>) + 3400;
				object methodName2 = "___# Content push apply failed [{0}]: {1}" + 3520;
				object obj36 = (nint)0 + (nint)840;
				object obj37 = 0;
				obj13 = 0;
				array3 = (object[])obj33;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					bool flag11 = array4 == null;
					googlePlayBillingManager3 = this;
					if (flag11)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X24_v10+v309 @ X25_v11*8]");
					if ((nint)0 != 0)
					{
						nint num2 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = obj12 == null;
						googlePlayBillingManager3 = this;
						ex4 = (NullReferenceException)(object)productIds;
						if (flag12)
						{
							goto IL_084b;
						}
					}
					bool flag13 = array4.Length == 0;
					obj8 = obj13;
					array2 = array3;
					googlePlayBillingManager2 = this;
					ex = (NullReferenceException)(object)productIds;
					if (!flag13)
					{
						object obj38 = array4 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X24_v10+v309 @ X25_v11*8]");
						obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj13 = obj36;
						bool flag14 = androidJavaObject.Call<bool>((string)methodName2, array4);
						obj37++;
						bool flag15 = (nint)obj37 < productIds.Length;
						array3 = array4;
						if (flag15)
						{
							continue;
						}
						goto IL_044a;
					}
					goto IL_08d0;
				}
			}
			else
			{
				bool flag16 = productIds.Length >= 1;
				obj13 = 0;
				array3 = (object[])obj33;
				if (!flag16)
				{
					goto IL_05cd;
				}
				googlePlayBillingManager3 = (GooglePlayBillingManager)obj34;
				object obj39 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag17 = ex6 == null;
				object obj40 = !flag17;
				obj13 = 0;
				array3 = (object[])obj33;
				obj8 = 0;
				array2 = (object[])obj33;
				googlePlayBillingManager2 = (GooglePlayBillingManager)obj34;
				if (obj40 != null)
				{
					goto IL_07b4;
				}
			}
		}
		goto IL_078e;
		IL_07b4:
		bool flag18 = googlePlayBillingManager2 == null;
		ex = ex6;
		if (!flag18)
		{
			nint num3 = (nint)ex6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag19 = obj12 == null;
			object obj41 = !flag19;
			obj13 = obj8;
			array3 = array2;
			googlePlayBillingManager3 = googlePlayBillingManager2;
			ex4 = ex6;
			ex = ex6;
			if (obj41 == null)
			{
				goto IL_084b;
			}
		}
		goto IL_0883;
	}

	public void Purchase(string productId, string offerId = null, string userId = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0440: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0190: Expected I, but got O
		//IL_01a0: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0286: Expected O, but got I8
		//IL_02a5: Expected O, but got I
		//IL_023b: Expected I, but got O
		//IL_0264: Expected O, but got I
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_0373: Expected O, but got I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_0300: Expected I, but got O
		//IL_0310: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8536]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_00a6;
		IL_049a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04a8;
		IL_04a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_00a6:
		object obj6 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 1000;
		object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v23+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag3 = array == null;
		string text = (string)3;
		if (!flag3)
		{
			string text2 = default(string);
			bool flag4 = text2 == null;
			string text3 = (string)3;
			if (!flag4)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				if (flag5)
				{
					goto IL_04a8;
				}
			}
			if (array.Length != 0)
			{
				object obj10 = array + 32;
				obj10 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (offerId != null)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					if (flag6)
					{
						goto IL_04a8;
					}
				}
				object obj11 = array.Length & 0xFFFFFFFEL;
				bool flag7 = obj11 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				if (!flag7)
				{
					object obj12 = array + 40;
					obj12 = offerId;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag8 = userId == null;
					text3 = offerId;
					if (!flag8)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						if (flag9)
						{
							goto IL_04a8;
						}
					}
					bool flag10 = array.Length < 2;
					object obj13 = !flag10;
					object obj14 = array.Length - 2;
					bool flag11 = obj14 == null;
					object obj15 = ~obj13;
					object obj16 = obj15 | flag11;
					if (obj16 == null)
					{
						object obj17 = array + 48;
						obj17 = userId;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag12 = _plugin == null;
						text = userId;
						if (!flag12)
						{
							object methodName = "placementId" + 1600;
							_plugin.Call((string)methodName, array);
							return;
						}
						goto IL_049a;
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			text = text3;
		}
		goto IL_049a;
		IL_007d:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.Android)
		{
			goto IL_00a6;
		}
	}

	public void Dispose()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_02a7: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_02cd: Expected O, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I4
		//IL_0305: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0367: Expected O, but got I
		//IL_0377: Expected O, but got I
		//IL_038d: Expected O, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03b5: Expected O, but got I4
		//IL_03c5: Expected O, but got I
		//IL_033f: Expected O, but got I4
		//IL_01f6: Expected O, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0185: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I
		//IL_03f9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8537]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_00a6;
		IL_034d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v3+38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v13+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v13+10]");
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v13+10]");
		object obj11 = 0;
		if (obj10 != null)
		{
			goto IL_01e6;
		}
		goto IL_03d3;
		IL_0150:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v21+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0175;
		}
		goto IL_034d;
		IL_0175:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v3+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v25+10]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v25+10]");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag3 = obj14 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v25+10]");
		obj11 = 0;
		if (!flag3)
		{
			goto IL_01e6;
		}
		goto IL_03d3;
		IL_007d:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.Android)
		{
			goto IL_00a6;
		}
		return;
		IL_00a6:
		object obj15 = (nint)0 + (nint)3232;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v3+38]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9+10]");
			object obj19 = (nint)0 + (nint)309;
			object obj20 = obj19 & 1;
			bool flag4 = obj20 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9+10]");
			object obj21 = 0;
			if (!flag4)
			{
				goto IL_0150;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v3+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v18+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v18+10]");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag5 = obj24 == null;
			object obj25 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v18+10]");
			object obj21 = 0;
			if (obj25 != null)
			{
				goto IL_0150;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 != null)
		{
			goto IL_0175;
		}
		goto IL_034d;
		IL_01e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v29+B8]");
		object args = 0;
		object methodName = "destinationTimeZone" + 488;
		_plugin.Call((string)methodName, (object[])args);
		return;
		IL_03d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag7 = _plugin == null;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01e6;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8538]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f7;
		}
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 1008;
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
		obj4 = "___# Content push apply failed [{0}]: {1}" + 1008;
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

	private void onDisconnected()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8539]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f7;
		}
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 1016;
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
		Action action = OnDisconnected;
		bool flag2 = OnDisconnected == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_0094:
		Debug.Log(obj4);
		action = OnDisconnected;
		if (OnDisconnected != null)
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
		obj4 = "___# Content push apply failed [{0}]: {1}" + 1016;
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

	private void onFetchProductsFinished(bool success, string message = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1024;
		object obj = typeof(DataRelation) + 856;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg, message);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object message2 = text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text;
		}
		Debug.Log(message2);
		Action<bool, string> action = OnFetchProductsFinished;
		if (OnFetchProductsFinished != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ X8_v6 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
		}
	}

	private void onPurchaseFailed(int responseCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		object obj = "___# Content push apply failed [{0}]: {1}" + 1032;
		object obj2 = typeof(DataRelation) + 856;
		int num = default(int);
		string text = num.ToString();
		string text2 = (string)obj + text;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		object message = text2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		Debug.Log(message);
		Action<int> action = OnPurchaseFailed;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X8_v4 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
	}
}
