using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.SceneManagement;
using Util;

public static class KUtil
{
	private sealed class <>c__DisplayClass10_0
	{
		public Action callbackNewThread;

		public Action callbackMainThread;

		internal void <SwitchToBackground>b__0()
		{
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00d0: Expected O, but got I
			//IL_00ea: Expected O, but got I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_003e: Expected O, but got I
			//IL_0130: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Action action = callbackNewThread;
			if (callbackNewThread != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			object obj3;
			object obj5;
			if ((nint)0 != 0)
			{
				obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD0]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_0063;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD0]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				if (obj7 != null)
				{
					goto IL_0063;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_0090;
			}
			goto IL_013e;
			IL_0063:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0090;
			}
			goto IL_013e;
			IL_013e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForMainThread(callbackMainThread);
			return;
			IL_0090:
			CoroutineDummy.WaitForMainThread(callbackMainThread);
		}
	}

	private sealed class <>c__DisplayClass11_0<T> where T : Task
	{
		public Action<T> callback;

		public T task;

		public Action <>9__1;

		internal void <ContinueWithOnMainThread>b__0(Task t)
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_0116: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_01b9: Expected O, but got I4
			object obj = 152961024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E0C9F]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			Action action;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj4 = this + 32;
				action = (Action)obj4;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj4 = this + 32;
				action = (Action)obj4;
				bool flag2 = obj4 == null;
				object obj6 = !flag2;
				obj5 = obj3;
				if (obj6 != null)
				{
					goto IL_0088;
				}
			}
			object obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v7 (Il2CppRgctx<KUtil+<>c__DisplayClass11_0`1>)+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v7 (Il2CppRgctx<KUtil+<>c__DisplayClass11_0`1>)+8]");
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)0);
			<>9__1 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			action = action2;
			Action action3 = action2;
			if (obj9 != null)
			{
				goto IL_00c5;
			}
			goto IL_01d7;
			IL_00c5:
			CoroutineDummy.WaitForMainThread(action);
			return;
			IL_01d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action3;
			goto IL_00c5;
			IL_0088:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v1+E4]");
			bool flag4 = (nint)0 == 0;
			IntPtr intPtr = default(IntPtr);
			num2 = intPtr;
			action3 = action;
			if (!flag4)
			{
				goto IL_00c5;
			}
			goto IL_01d7;
		}

		internal void <ContinueWithOnMainThread>b__1()
		{
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			Action<T> action = callback;
			T val = task;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<T>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<T>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<T>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public Action<bool> isSuccessful;

		public AppPermission permission;

		internal void <RequestPermission>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0077: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool arg = PermissionExtensions.IsGranted(permission);
			Actions.SafeInvoke(isSuccessful, arg);
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public Action callback;

		internal void <SafelyCallInNewThread>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a2: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			object obj = typeof(DataRelation) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "COORDINATE_TYPE_GCJ_02" + 920;
			Debug.Log(message);
			Action action = callback;
			if (callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public static readonly bool IsHuaweiAppGalleryBuild;

	private static Diffusion _diffusion;

	public static bool NoPlayServices
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0144: Expected O, but got I4
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00db: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F1B]");
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
			goto IL_0187;
			IL_009d:
			object obj5 = typeof(SqlSingle[]) + 3560;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = AndroidInterface.IsPlayServicesAvailable();
			return (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
			IL_0187:
			return false;
			IL_0074:
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.Android)
			{
				goto IL_009d;
			}
			goto IL_0187;
		}
	}

	private static Diffusion Diffusion
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01cd: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_00f0: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_020d: Expected O, but got I
			//IL_021d: Expected O, but got I
			//IL_0247: Expected O, but got I4
			//IL_0257: Expected O, but got I
			//IL_029b: Expected O, but got I4
			//IL_02a4: Expected O, but got I4
			//IL_02ad: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_012c: Expected O, but got I4
			//IL_0164: Expected O, but got I4
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Expected O, but got Unknown
			//IL_0387: Expected O, but got I
			//IL_0394: Expected O, but got I
			//IL_0310: Expected O, but got I
			//IL_0344: Expected O, but got I4
			//IL_03aa: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F1C]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v45+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v45+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v21+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+8]");
			UnityEngine.Object obj11 = (UnityEngine.Object)0;
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+8]");
			UnityEngine.Object obj14 = (UnityEngine.Object)0;
			if (obj13 != null)
			{
				goto IL_00fe;
			}
			goto IL_0265;
			IL_013a:
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v38+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v38+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v16+8]");
			return (Diffusion)0;
			IL_02bb:
			object obj18 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameObject gameObject = default(GameObject);
			gameObject..ctor();
			if ((object)gameObject != null)
			{
				object obj19 = (nint)0 + (nint)672;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v8+E4]");
				bool flag5 = (nint)0 == 0;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v8+B8]");
				object obj22 = (nint)0 + (nint)8;
				Diffusion diffusion = default(Diffusion);
				obj22 = diffusion;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return diffusion;
			}
			return (Diffusion)(object)new NullReferenceException();
			IL_00fe:
			bool flag6 = obj11;
			bool flag7 = !flag6;
			object obj23 = 0;
			object obj24 = 0;
			if (!flag7)
			{
				goto IL_013a;
			}
			goto IL_02bb;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v45+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v19+8]");
			obj11 = (UnityEngine.Object)0;
			obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v19+8]");
			obj14 = (UnityEngine.Object)0;
			if (!flag8)
			{
				goto IL_00fe;
			}
			goto IL_0265;
			IL_0265:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = obj14;
			bool flag10 = !flag9;
			object obj26 = !flag10;
			obj23 = 0;
			obj24 = 0;
			if (obj26 != null)
			{
				goto IL_013a;
			}
			goto IL_02bb;
		}
	}

	public static bool IsTouchingUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0232: Expected I4, but got O
		//IL_0199: Expected O, but got I4
		object obj = typeof(DataRelation) + 3776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F15]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		EventSystem current = EventSystem.current;
		if ((object)current != null)
		{
			goto IL_011d;
		}
		goto IL_0224;
		IL_0224:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_011d:
		if (current.IsPointerOverGameObject())
		{
			return true;
		}
		if (InputUtil.PointerHeld)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			EventSystem current2 = EventSystem.current;
			int primaryTouchId = InputUtil.PrimaryTouchId;
			if ((object)current2 == null)
			{
				goto IL_0224;
			}
			if (current2.IsPointerOverGameObject(primaryTouchId))
			{
				return true;
			}
		}
		return false;
		IL_0074:
		current = EventSystem.current;
		bool flag3 = (object)current == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_011d;
		}
		goto IL_0224;
	}

	public static Platform GetPlatform()
	{
		return Platform.IOS;
	}

	public static bool IsGenuine()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F16]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool genuineCheckAvailable = Application.genuineCheckAvailable;
		bool flag2 = !genuineCheckAvailable;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_009f;
		}
		goto IL_0154;
		IL_009f:
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			return Application.genuine;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Application.genuine;
		IL_0154:
		return true;
		IL_007d:
		if (Application.genuineCheckAvailable)
		{
			goto IL_009f;
		}
		goto IL_0154;
	}

	public static void OpenURL(string url)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F17]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Application.OpenURL(url);
		return;
		IL_007d:
		Application.OpenURL(url);
	}

	public static int GetSpeedIndexValue(int selectedIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		object obj = selectedIndex - 1;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		object obj3 = obj - 2;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119873536 + 2832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*4]");
			return 0;
		}
		return 0;
	}

	public static GameObject GetMainCanvas()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object tag = "Cannot populate JSON object onto type '{0}'." + 1440;
		return GameObject.FindWithTag((string)tag);
	}

	public static GameObject GetSecondaryCanvas(string caller = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_025c: Expected O, but got I4
		//IL_005b: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		object tag = "Cannot populate JSON object onto type '{0}'." + 1448;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		GameObject gameObject = GameObject.FindWithTag((string)tag);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = gameObject == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			return gameObject;
		}
		object obj5 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj6 = "Read object reference Id '{0}' for {1}." + 2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj7 = "&action=sign-up" + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		object obj8 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D040");
		Scene activeScene = SceneManager.GetActiveScene();
		Scene scene = default(Scene);
		string name = scene.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj9 = "&action=sign-up" + 2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
		string[] array = default(string[]);
		string message = string.Concat(array);
		object obj10 = typeof(System.IOAsyncCallback) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidOperationException ex = default(InvalidOperationException);
		ex..ctor(message);
		object obj11 = (nint)0 + (nint)3416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (GameObject)(object)new OutOfMemoryException();
	}

	public static void CallInNewThread(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				SafelyCallInNewThread(callback);
				return;
			}
		}
		SafelyCallInNewThread(callback);
	}

	private static void SafelyCallInNewThread(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_00b7: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3216;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Task task = Task.Run(action);
	}

	public static void CallInMainThread(Action callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForMainThread(callback);
		return;
		IL_007d:
		CoroutineDummy.WaitForMainThread(callback);
	}

	public static void SwitchToBackground(Action callbackNewThread, Action callbackMainThread)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_0169: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3200;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj6 = obj2 + 16;
		obj6 = callbackNewThread;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = callbackMainThread;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCF]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				goto IL_0112;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCF]");
			object obj10 = (nint)0 & (nint)1;
			bool flag = obj10 == null;
			object obj11 = !flag;
			if (obj11 != null)
			{
				goto IL_0112;
			}
		}
		_ = 1;
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 != null)
		{
			goto IL_013f;
		}
		goto IL_01cf;
		IL_013f:
		SafelyCallInNewThread(action);
		return;
		IL_01cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SafelyCallInNewThread(action);
			return;
		}
		goto IL_013f;
		IL_0112:
		obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			goto IL_013f;
		}
		goto IL_01cf;
	}

	public unsafe static void ContinueWithOnMainThread<T>(T task, Action<T> callback) where T : Task
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		((<>c__DisplayClass11_0<T>)obj4)..ctor();
		object obj5 = obj4 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj4 + 24;
		obj6 = task;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass11_0<T>.<ContinueWithOnMainThread>b__0));
		Task task2 = ((Task)obj6).ContinueWith((Action<Task>)action);
	}

	public static void Share(string message)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F1D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Diffusion diffusion = Diffusion;
		bool flag3 = (object)diffusion == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0093;
		IL_0085:
		diffusion = Diffusion;
		goto IL_0093;
		IL_0093:
		diffusion.Share(message, null);
	}

	public static void ShareImage(string message, string imagePath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FD2]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Diffusion diffusion = Diffusion;
		bool flag3 = (object)diffusion == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008a;
		IL_007c:
		diffusion = Diffusion;
		goto IL_008a;
		IL_008a:
		diffusion.Share(message, imagePath);
	}

	public static void RequestPermission(AppPermission permission, Action<bool> isSuccessful = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0180: Expected O, but got I
		//IL_0191: Expected I, but got O
		//IL_00e3: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj4 = obj2 + 16;
		obj4 = isSuccessful;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+E4]");
		if ((nint)0 == 0)
		{
			goto IL_010d;
		}
		bool flag = PermissionExtensions.IsGranted(permission);
		bool flag2 = !flag;
		object obj6 = 0;
		if (!flag2)
		{
			goto IL_00ae;
		}
		goto IL_0156;
		IL_010d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = PermissionExtensions.IsGranted(permission);
		bool flag4 = !flag3;
		object obj7 = !flag4;
		obj6 = 0;
		if (obj7 != null)
		{
			goto IL_00ae;
		}
		goto IL_0156;
		IL_00ae:
		object obj8 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+40]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X3_v2 (should have been resolved before IL gen)");
			goto IL_010d;
		}
		return;
		IL_0156:
		object obj12 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3208;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		PermissionExtensions.RequestPermission(AppPermission.Microphone, action);
	}

	private static bool HasPermission(AppPermission permission)
	{
		return PermissionExtensions.IsGranted(permission);
	}

	public static void Benchmark(int count, Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0100: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Stopwatch stopwatch = default(Stopwatch);
		stopwatch..ctor();
		stopwatch.Start();
		if (count >= 1)
		{
			int num = count;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: action.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				num--;
			}
			while (num != 1);
		}
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object format = "ThisIsFakeReceiptData" + 160;
		object obj3 = typeof(DataRelation) + 856;
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = default(TimeSpan);
		double totalMilliseconds = timeSpan.TotalMilliseconds;
		object obj6 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object message = text;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
	}

	public static void Repeat(int n, Action action)
	{
		if (n >= 1)
		{
			int num = n;
			int num2 = default(int);
			num = num2;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: action.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				num--;
			}
			while (num != 1);
		}
	}

	public static float AverageAngle(float angleA, float angleB)
	{
		//IL_00c3: Invalid comparison between F4 and I4
		//IL_00d2: Invalid comparison between F4 and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f3: Expected O, but got F4
		//IL_0128: Expected O, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_018b: Invalid comparison between F4 and I4
		//IL_0155: Expected F4, but got I4
		//IL_0170: Expected F4, but got I4
		float num = angleB * 1.01600314E+09f;
		float num2 = angleA * 1.01600314E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C88");
		float num3 = angleB + angleB;
		float num4 = num2 + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0E2C");
		float num5 = num4 * 1.1139274E+09f;
		float num6 = num5 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num7 = num6 * 1.13587E+09f;
		float num8 = num5 - num7;
		float num9 = num8 - 1.13587E+09f;
		bool flag = num9 < 0f;
		bool flag2 = num9 == 0f;
		object obj = num8 ^ 0x43B40000;
		object obj2 = num8 ^ num9;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		float result = ((obj6 != null) ? num8 : 1.13587E+09f);
		if (num8 < 0f)
		{
			return 0f;
		}
		return result;
	}

	static KUtil()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F20]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string identifier = Application.identifier;
		bool flag2 = identifier == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008b;
		IL_007d:
		identifier = Application.identifier;
		goto IL_008b;
		IL_008b:
		object value = "https://www.kammelna.com/Home/Terms" + 56;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		bool flag3 = identifier.Contains((string)value);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9+B8]");
		object obj9 = 0;
		obj9 = flag3;
	}
}
