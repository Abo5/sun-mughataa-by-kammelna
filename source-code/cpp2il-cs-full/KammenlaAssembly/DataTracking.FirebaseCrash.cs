using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Firebase;
using Firebase.Crashlytics;
using GoogleMobileAds.Api.AdManager;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

namespace DataTracking;

public static class FirebaseCrash
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Task<DependencyStatus>> <>9__0_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Initialize>b__0_0(Task<DependencyStatus> task)
		{
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_0124: Expected O, but got I
			//IL_0132: Expected I, but got O
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_0170: Expected O, but got I4
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_00be: Expected O, but got I4
			if (((Task<System.Int32Enum>)(object)task).Result != 0)
			{
				object obj = typeof(DataRelation) + 1968;
				object format = "Complete" + 2888;
				object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				System.Int32Enum result = ((Task<System.Int32Enum>)(object)task).Result;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object arg = default(object);
				string text = string.Format((string)format, arg);
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				object obj5 = text;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = text;
				}
				KLogger.Log(obj5);
			}
			else
			{
				Crashlytics.IsCrashlyticsCollectionEnabled = true;
				object obj6 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)64;
				Application.LogCallback logCallback = default(Application.LogCallback);
				logCallback..ctor(null, (IntPtr)obj7);
				object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Application.logMessageReceived += logCallback;
			}
		}
	}

	public static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_02a7: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_01dc: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0359: Expected O, but got I4
		//IL_0215: Expected O, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0443: Expected O, but got I
		//IL_0454: Expected I, but got O
		//IL_0472: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_03c4: Expected O, but got I4
		//IL_0389: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C03]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0119;
		IL_0337:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		object obj8;
		object obj9;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v15+B8]");
			obj9 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)256;
		Action<object> action = default(Action<object>);
		action..ctor(obj9, (IntPtr)obj11);
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = (nint)0 + (nint)3400;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		Action<object> action2 = action;
		Task<DependencyStatus> task2;
		Task<DependencyStatus> task = task2;
		object obj17 = obj14;
		Action<object> action3 = action;
		if (obj16 != null)
		{
			goto IL_025a;
		}
		goto IL_03f2;
		IL_01bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v5+B8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v8+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v8+8]");
		bool flag5 = (nint)0 == 0;
		task2 = task;
		if (!flag5)
		{
			goto IL_0209;
		}
		goto IL_0337;
		IL_025a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FD04");
		return;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_0119;
		IL_0119:
		object obj18 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 736;
		obj8 = typeof(DebugUI.BitField) + 2760;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v2+E4]");
		object obj20;
		if ((nint)0 != 0)
		{
			Task<DependencyStatus> task3 = FirebaseApp.CheckAndFixDependenciesAsync();
			obj20 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			task = task3;
			object obj21 = obj20;
			task2 = task3;
			if (!flag6)
			{
				goto IL_01bc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Task<DependencyStatus> task4 = FirebaseApp.CheckAndFixDependenciesAsync();
			obj20 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			task = task4;
			object obj21 = obj20;
			task2 = task4;
			if (obj22 != null)
			{
				goto IL_01bc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj20 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v5+B8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v8+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v8+8]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		task = task2;
		if (obj23 != null)
		{
			goto IL_0209;
		}
		goto IL_0337;
		IL_0209:
		obj14 = (nint)0 + (nint)3400;
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v3+E4]");
		bool flag9 = (nint)0 == 0;
		obj17 = obj14;
		action3 = action2;
		task2 = task;
		if (!flag9)
		{
			goto IL_025a;
		}
		goto IL_03f2;
		IL_03f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj14 = obj17;
		action2 = action3;
		task = task2;
		goto IL_025a;
	}

	public static void SetUserId(string userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D71]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_011d:
		if (!string.IsNullOrEmpty(userId))
		{
			Crashlytics.SetUserId(userId);
		}
		return;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
	}

	public static void SetKey(string key, string value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_01a7: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C04]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_011d:
		if (!string.IsNullOrEmpty(key))
		{
			bool flag3 = value == null;
			object obj6 = !flag3;
			string value2 = value;
			if (obj6 == null)
			{
				object obj7 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6+90]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+B8]");
				object obj9 = 0;
				value2 = (string)obj9;
			}
			Crashlytics.SetCustomKey(key, value2);
		}
		return;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
	}

	public static void Log(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C05]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_011d:
		if (!string.IsNullOrEmpty(message))
		{
			Crashlytics.Log(message);
		}
		return;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
	}

	public static void Record(Exception exception)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7C06]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		if (exception != null)
		{
			goto IL_011d;
		}
		return;
		IL_011d:
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Crashlytics.LogException(exception);
		}
		return;
		IL_0074:
		noPlayServices = KUtil.NoPlayServices;
		bool flag3 = exception == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			return;
		}
		goto IL_011d;
	}

	private static void OnLogMessageReceived(string condition, string stackTrace, LogType type)
	{
		//IL_0071: Expected O, but got I8
		//IL_008b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = (long)type & 0xFFFFFFFBL;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2912;
			object format = "WhiteSmoke" + 4088;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string message = string.Format((string)format, arg, condition, stackTrace);
			Crashlytics.Log(message);
		}
	}
}
