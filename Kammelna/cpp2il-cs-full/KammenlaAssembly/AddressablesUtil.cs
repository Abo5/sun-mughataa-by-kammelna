using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine.AdaptivePerformance;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

public static class AddressablesUtil
{
	public static class Label
	{
		public const string Preload = "preload";

		public const string Common = "common";

		public const string Tablet = "tablet";

		public const string Phone = "phone";

		public const string Subscribed = "sub";

		public const string NonSubscribed = "nonSub";

		public const string ProfilePopups = "Player Profile Popups";

		public const string EventChannels = "Events Channels";
	}

	private sealed class <>c__DisplayClass4_0<T>
	{
		public Action<T> callback;

		internal unsafe void <LoadAsset>b__0(AsyncOperationHandle<T> handle)
		{
			//IL_0075: Expected O, but got I
			//IL_0085: Expected O, but got I
			//IL_0095: Expected O, but got I
			AsyncOperationStatus status = ((AsyncOperationHandle<object>*)handle)->Status;
			if (status == AsyncOperationStatus.Succeeded)
			{
				Action<T> action = callback;
				if (callback != null)
				{
					object result = ((AsyncOperationHandle<object>*)handle)->Result;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X21_v4 (System.Action`1<T>)+18]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X21_v4 (System.Action`1<T>)+40]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X21_v4 (System.Action`1<T>)+28]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public static List<string> GetLabels(string[] extras)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_0144: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_02d7: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_033e: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03c3: Expected O, but got I4
		//IL_0604: Expected O, but got I4
		//IL_03ec: Expected O, but got I
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_046b: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_051a: Expected O, but got I4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_05ab: Expected O, but got I4
		//IL_0782: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj22;
		object obj12 = default(object);
		if (list != null)
		{
			object obj2 = "placementId" + 776;
			object obj3 = (nint)0 + (nint)3072;
			object obj4 = obj3;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				object obj5 = "startPosition" + 2248;
				object obj6 = "not" + 3912;
				bool flag = list._size < items.Length;
				object obj7 = !flag;
				if (obj7 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj8 = list._items + list._size;
					object obj9 = obj8 + 32;
					obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+20]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v32+C0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v33+70]");
					obj12 = 0;
					list.AddWithResize(obj2);
				}
				bool isTablet = ScreenUtility.IsTablet;
				bool flag2 = !isTablet;
				object obj13 = !flag2;
				object obj14 = ~obj13;
				object obj15 = ((obj14 != null) ? obj6 : obj5);
				object obj16 = obj3;
				int version2 = list._version + 1;
				list._version = version2;
				object[] items2 = list._items;
				if (list._items != null)
				{
					object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
					bool flag3 = list._size < items2.Length;
					object obj18 = !flag3;
					if (obj18 == null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj19 = list._items + list._size;
						object obj20 = obj19 + 32;
						obj20 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj21 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v38+E4]");
						bool flag4 = (nint)0 == 0;
						obj22 = obj12;
						if (!flag4)
						{
							goto IL_0298;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v9+20]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v24+C0]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v25+70]");
						obj12 = 0;
						list.AddWithResize(obj15);
						object obj21 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v38+E4]");
						bool flag5 = (nint)0 == 0;
						object obj25 = !flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v25+70]");
						obj22 = 0;
						if (obj25 != null)
						{
							goto IL_0298;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool isInitialized = Config.IsInitialized;
					bool flag6 = !isInitialized;
					obj12 = obj22;
					if (!flag6)
					{
						goto IL_0385;
					}
					goto IL_05cf;
				}
			}
		}
		goto IL_0694;
		IL_0298:
		if (Config.IsInitialized)
		{
			obj22 = obj12;
			goto IL_0385;
		}
		goto IL_05cf;
		IL_0385:
		object obj26 = typeof(Queue<string>) + 848;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj29 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		object obj32;
		if ((object)sessionModel != null)
		{
			bool isConnected = sessionModel.IsConnected;
			bool flag8 = !isConnected;
			obj12 = obj22;
			if (flag8)
			{
				goto IL_05cf;
			}
			object obj30 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v24+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				User localUser = sessionModel2.LocalUser;
				obj32 = "m_StencilDeferredPS" + 3920;
				bool flag10 = localUser == null;
				obj12 = obj22;
				if (!flag10)
				{
					object obj33 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v29+E4]");
					bool flag11 = (nint)0 == 0;
					object obj34 = !flag11;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel3 = default(SessionModel);
					if ((object)sessionModel3 == null)
					{
						goto IL_0694;
					}
					User localUser2 = sessionModel3.LocalUser;
					bool flag12 = SFSKammelnaUserExtensions.IsSubscribed(localUser2);
					object obj35 = "startPosition" + 1032;
					bool flag13 = !flag12;
					object obj36 = !flag13;
					object obj37 = ~obj36;
					if (obj37 == null)
					{
						obj32 = obj35;
					}
					obj12 = 0;
				}
				goto IL_0729;
			}
		}
		goto IL_0694;
		IL_05cf:
		obj32 = "m_StencilDeferredPS" + 3920;
		goto IL_0729;
		IL_0729:
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		if (list._items != null)
		{
			bool flag14 = list._size < items3.Length;
			object obj38 = !flag14;
			if (obj38 == null)
			{
				int size3 = list._size + 1;
				list._size = size3;
				object obj39 = list._items + list._size;
				object obj40 = obj39 + 32;
				obj40 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize(obj32);
			}
			list.AddRange(extras);
			return (List<string>)(object)list;
		}
		goto IL_0694;
		IL_0694:
		return (List<string>)(object)new NullReferenceException();
	}

	public static List<string> GetLabelsForCommonAssets()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = "com.unity.services.authentication.profile" + 184;
				object obj3 = array + 32;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return GetLabels(array);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (List<string>)(object)new IndexOutOfRangeException();
	}

	public unsafe static List<string> GetLabelsForScene(Scenes scene)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0199: Expected O, but got Ref
		//IL_00c5: Expected O, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		if (scene == Scenes.FastTrackMenu || scene == Scenes.Menu)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS == null)
			{
				goto IL_0137;
			}
			bool flag2 = !currentSFS.<IsFastTrack>k__BackingField;
			object obj4 = !flag2;
			object obj5 = ~obj4;
			if (obj5 != null)
			{
			}
		}
		object obj6 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj7 = default(object);
		string text = ((Enum)(&obj7)).ToString();
		string[] array = default(string[]);
		if (array == null)
		{
			goto IL_0137;
		}
		if (array.Length != 0)
		{
			object obj8 = array + 32;
			obj8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return GetLabels(array);
		}
		goto IL_0145;
		IL_0145:
		return (List<string>)(object)new IndexOutOfRangeException();
		IL_0137:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0145;
	}

	public static void PreloadAssets(List<string> keys)
	{
		//IL_000f: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0101: Expected O, but got I4
		//IL_0111: Expected O, but got I
		//IL_0133: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_007b: Expected O, but got I4
		//IL_00cb: Expected I, but got O
		object handle = 147423232 + 3720;
		object obj = typeof(SqlSingle[]) + 3048;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 184;
		object obj6 = (nint)0 + (nint)3392;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<IList<IResourceLocation>> asyncOperationHandle = Addressables.LoadResourceLocationsAsync(keys, Addressables.MergeMode.Intersection, typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<AsyncOperationHandle<object>> action = default(Action<AsyncOperationHandle<object>>);
		action..ctor((object)null, (IntPtr)obj6);
		AsyncOperationHandle<object> asyncOperationHandle2 = default(AsyncOperationHandle<object>);
		asyncOperationHandle2.Completed += action;
	}

	public unsafe static void LoadAsset<T>(string key, Action<T> callback)
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_0125: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		AsyncOperationHandle<object> asyncOperationHandle = (AsyncOperationHandle<object>)0;
		nint num = 0;
		asyncOperationHandle = (AsyncOperationHandle<object>)0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		((<>c__DisplayClass4_0<T>)obj4)..ctor();
		object obj5 = obj4 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = typeof(SqlSingle[]) + 3048;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<T> asyncOperationHandle2 = Addressables.LoadAssetAsync<T>(key);
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		nint num3 = 0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<AsyncOperationHandle<object>> action = default(Action<AsyncOperationHandle<object>>);
		action..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass4_0<T>.<LoadAsset>b__0));
		asyncOperationHandle.Completed += action;
	}

	internal unsafe static void <PreloadAssets>g__LocationsHandleOnCompleted|3_0(AsyncOperationHandle<IList<IResourceLocation>> handle)
	{
		//IL_0009: Expected O, but got I4
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0086: Expected O, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		//IL_0143: Expected I, but got O
		//IL_0172: Expected O, but got I4
		object obj = 152981504;
		object obj2 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D5A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object result = ((AsyncOperationHandle<object>*)handle)->Result;
			object obj4 = obj2;
			bool flag = Enumerable.Any((IEnumerable<object>)result);
			bool flag2 = !flag;
			object obj5 = !flag2;
			object obj6 = result;
			if (obj5 == null)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			object result2 = ((AsyncOperationHandle<object>*)handle)->Result;
			object obj4 = obj2;
			bool flag3 = Enumerable.Any((IEnumerable<object>)result2);
			bool flag4 = !flag3;
			object obj6 = result2;
			if (flag4)
			{
				return;
			}
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj8 = (nint)0 + (nint)1888;
		object obj9 = typeof(SqlSingle[]) + 3048;
		object obj10 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj8);
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F35E58");
	}
}
