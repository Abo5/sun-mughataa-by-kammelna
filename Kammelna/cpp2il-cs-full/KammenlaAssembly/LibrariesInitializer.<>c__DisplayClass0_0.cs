using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using GameAnalyticsSDK;
using GoogleMobileAds.Api;
using Kammelna.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using Util;
using Util.JsonConvertors;

public class LibrariesInitializer : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<JsonSerializerSettings> <>9__0_0;

		public static Action<InitializationStatus> <>9__0_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal JsonSerializerSettings <Awake>b__0_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_013e: Expected O, but got I4
			//IL_01c1: Expected O, but got I
			//IL_01d1: Expected O, but got I
			//IL_01e1: Expected O, but got I
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01ac: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			JsonSerializerSettings jsonSerializerSettings = default(JsonSerializerSettings);
			jsonSerializerSettings..ctor();
			if (jsonSerializerSettings != null)
			{
				object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2000;
				object obj3 = (nint)0 + (nint)2560;
				object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1840;
				jsonSerializerSettings.Formatting = Formatting.None;
				jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ColorConverter colorConverter = default(ColorConverter);
				colorConverter..ctor();
				if (list != null)
				{
					object obj5 = (nint)0 + (nint)2568;
					object obj6 = obj5;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					if (list._items != null)
					{
						bool flag = list._size < items.Length;
						object obj7 = !flag;
						if (obj7 == null)
						{
							int size = list._size + 1;
							list._size = size;
							object obj8 = list._items + list._size;
							object obj9 = obj8 + 32;
							obj9 = colorConverter;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj10 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+20]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+C0]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v9+70]");
							object obj10 = 0;
							list.AddWithResize((object)colorConverter);
						}
						object obj13 = jsonSerializerSettings + 216;
						obj13 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return jsonSerializerSettings;
					}
				}
			}
			return (JsonSerializerSettings)(object)new NullReferenceException();
		}

		internal void <Awake>b__0_1(InitializationStatus status)
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
			//IL_0149: Expected O, but got I
			//IL_0163: Expected O, but got I4
			//IL_00d0: Expected O, but got I
			//IL_01a1: Expected O, but got I4
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)3760;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj6 = obj2 + 16;
			obj6 = status;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E08]");
				object obj8 = (nint)0 & (nint)1;
				if (obj8 != null)
				{
					goto IL_00ed;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E08]");
				object obj9 = (nint)0 & (nint)1;
				bool flag = obj9 == null;
				object obj10 = !flag;
				if (obj10 != null)
				{
					goto IL_00ed;
				}
			}
			_ = 1;
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 != null)
			{
				goto IL_011a;
			}
			goto IL_01af;
			IL_011a:
			CoroutineDummy.WaitForMainThread(0f, action);
			return;
			IL_01af:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_011a;
			IL_00ed:
			obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_011a;
			}
			goto IL_01af;
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public InitializationStatus status;

		internal void <Awake>b__2()
		{
			//IL_0026: Expected O, but got I
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_0041: Expected O, but got I
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			Dictionary<string, AdapterStatus> adapterStatusMap = status.getAdapterStatusMap();
			object obj = (nint)0 + (nint)3056;
			object obj2 = "_InputUv1BufferOffset" + 4040;
			object obj3 = (nint)0 + (nint)2336;
			object obj4 = typeof(DataRelation) + 856;
			Dictionary<object, object>.KeyCollection keys = ((Dictionary<object, object>)(object)adapterStatusMap).Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9B9A4");
			string text = default(string);
			string message = (string)obj2 + text + (string)obj3;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v5+E4]");
			if ((nint)0 != 0)
			{
				Debug.Log(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_0a7a: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_005f: Expected O, but got I4
		//IL_0091: Expected F4, but got I4
		//IL_0abb: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_0566: Expected O, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_060e: Expected O, but got I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_066c: Expected O, but got I
		//IL_067c: Expected O, but got I
		//IL_069e: Expected O, but got I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_06e6: Expected O, but got I4
		//IL_07bd: Expected O, but got I
		//IL_07d7: Expected O, but got I4
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_0af3: Expected O, but got I
		//IL_0afb: Expected I, but got O
		//IL_0b0c: Expected I, but got O
		//IL_0b2a: Expected O, but got I
		//IL_03ab: Expected O, but got I
		//IL_0745: Expected O, but got I4
		//IL_074e: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_077f: Expected I, but got O
		//IL_0716: Expected O, but got I
		//IL_0845: Expected O, but got I4
		//IL_099b: Expected O, but got I
		//IL_09ab: Expected O, but got I
		//IL_09cd: Expected O, but got I4
		//IL_0934: Expected O, but got I
		//IL_0944: Expected O, but got I
		//IL_0966: Expected O, but got I4
		//IL_09fd: Expected O, but got I4
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected O, but got Unknown
		//IL_0b6b: Expected O, but got I
		//IL_0b7c: Expected I, but got O
		//IL_0b9a: Expected O, but got I
		//IL_0a2d: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		bool gameSound = Preferences.GameSound;
		bool flag2 = !gameSound;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		float volume = ((obj7 != null) ? 0f : 1f);
		AudioListener.volume = volume;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		LeaderBoardManager.Initialize();
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		CultureInfo.CurrentCulture = invariantCulture;
		GameAnalytics.Initialize();
		IdfaPermission.RegisterIOSAppAttribution();
		FirebaseTrack.SetAnalyticsConsent();
		FirebaseCrash.Initialize();
		Coordinator.InitializeBinding();
		NotificationPermissionUtils.Initialize();
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.Initialize();
		Vibration.Init();
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WebGLPlayer)
			{
				goto IL_0209;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.WebGLPlayer)
			{
				goto IL_0209;
			}
		}
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v55+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.targetFrameRate = 60;
		object obj19 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v50+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		Func<object> func = null;
		Func<object> func2 = null;
		if (obj20 != null)
		{
			goto IL_0240;
		}
		goto IL_057e;
		IL_0240:
		object obj21 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1968;
		RuntimePlatform platform3 = Application.platform;
		bool flag8 = platform3 == RuntimePlatform.Android;
		object obj22 = obj21;
		if (!flag8)
		{
			goto IL_0282;
		}
		goto IL_05da;
		IL_057e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj21 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1968;
		RuntimePlatform platform4 = Application.platform;
		bool flag9 = platform4 != RuntimePlatform.Android;
		func = func2;
		obj22 = obj21;
		if (flag9)
		{
			goto IL_0282;
		}
		goto IL_05da;
		IL_0636:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj23 = obj22;
		object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v15+8]");
		Func<object> func3 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v15+8]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		obj21 = obj22;
		Func<object> func4;
		func = func4;
		object obj27 = obj24;
		if (obj26 != null)
		{
			goto IL_0338;
		}
		goto IL_06c4;
		IL_0282:
		obj23 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+E4]");
		bool flag11 = (nint)0 == 0;
		obj22 = obj21;
		func4 = func;
		object obj28 = obj23;
		if (!flag11)
		{
			goto IL_02c7;
		}
		goto IL_0636;
		IL_05da:
		TouchScreenKeyboard.Android.consumesOutsideTouches = false;
		obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+E4]");
		bool flag12 = (nint)0 == 0;
		object obj29 = !flag12;
		obj21 = obj22;
		func = null;
		func4 = null;
		obj28 = obj23;
		if (obj29 != null)
		{
			goto IL_02c7;
		}
		goto IL_0636;
		IL_06c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+E4]");
		bool flag13 = (nint)0 == 0;
		object obj30 = !flag13;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v22+B8]");
			obj25 = 0;
		}
		object obj32 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)3744;
		nint num = (nint)obj33;
		Func<object> func5 = default(Func<object>);
		func5..ctor(obj25, (IntPtr)obj33);
		object obj34 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v20+B8]");
		object obj35 = (nint)0 + (nint)8;
		obj35 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj36 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v33+E4]");
		bool flag14 = (nint)0 == 0;
		object obj37 = !flag14;
		object obj38 = 0;
		obj24 = obj27;
		obj21 = obj22;
		func = func5;
		func3 = func5;
		object obj39 = 0;
		nint num2 = (nint)obj33;
		Func<object> func6 = func5;
		Func<object> func7 = func5;
		if (obj37 != null)
		{
			goto IL_0395;
		}
		goto IL_079d;
		IL_02c7:
		obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+B8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v15+8]");
		func3 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v15+8]");
		bool flag15 = (nint)0 == 0;
		obj27 = obj24;
		obj22 = obj21;
		func4 = func;
		if (!flag15)
		{
			goto IL_0338;
		}
		goto IL_06c4;
		IL_09db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v71+E4]");
		bool flag16 = (nint)0 == 0;
		object obj40 = !flag16;
		object obj42;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj41 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v42+B8]");
			obj42 = 0;
		}
		object obj43 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj44 = (nint)0 + (nint)3752;
		Action<object> action = default(Action<object>);
		action..ctor(obj42, (IntPtr)obj44);
		object obj45 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v41+B8]");
		object obj46 = (nint)0 + (nint)16;
		obj46 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action<InitializationStatus> initCompleteAction = action;
		goto IL_0a32;
		IL_0a32:
		MobileAds.Initialize(initCompleteAction);
		return;
		IL_079d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4586]");
		object obj47 = (nint)0 & (nint)1;
		bool flag17 = obj47 == null;
		object obj48 = !flag17;
		obj38 = obj39;
		num = num2;
		obj24 = obj27;
		obj21 = obj22;
		func = func6;
		func3 = func7;
		if (obj48 != null)
		{
			goto IL_03f8;
		}
		goto IL_0815;
		IL_0338:
		obj36 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v33+E4]");
		bool flag18 = (nint)0 == 0;
		obj39 = obj38;
		num2 = num;
		obj27 = obj24;
		obj22 = obj21;
		func6 = func;
		func7 = func3;
		if (!flag18)
		{
			goto IL_0395;
		}
		goto IL_079d;
		IL_03f8:
		object obj49 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v63+E4]");
		bool flag19 = (nint)0 == 0;
		obj39 = obj38;
		num2 = num;
		obj22 = obj21;
		object obj50 = obj49;
		func7 = func3;
		if (!flag19)
		{
			goto IL_044d;
		}
		goto IL_088b;
		IL_0815:
		_ = 1;
		obj49 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v63+E4]");
		bool flag20 = (nint)0 == 0;
		object obj51 = !flag20;
		obj38 = obj39;
		num = num2;
		obj21 = obj22;
		func3 = func7;
		obj24 = obj27;
		func = func6;
		obj50 = obj49;
		if (obj51 != null)
		{
			goto IL_044d;
		}
		goto IL_088b;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4586]");
		object obj52 = (nint)0 & (nint)1;
		bool flag21 = obj52 == null;
		obj39 = obj38;
		num2 = num;
		obj27 = obj24;
		obj22 = obj21;
		func6 = func;
		func7 = func3;
		if (!flag21)
		{
			goto IL_03f8;
		}
		goto IL_0815;
		IL_044d:
		object obj53 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj54 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v66+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform5 = Application.platform;
			if (platform5 == RuntimePlatform.WebGLPlayer)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform6 = Application.platform;
			if (platform6 == RuntimePlatform.WebGLPlayer)
			{
				return;
			}
		}
		object obj55 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v71+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v71+B8]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X9_v8+10]");
			initCompleteAction = (Action<InitializationStatus>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X9_v8+10]");
			bool flag22 = (nint)0 == 0;
			object obj56 = !flag22;
			if (obj56 == null)
			{
				goto IL_09db;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v71+B8]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X9_v8+10]");
			initCompleteAction = (Action<InitializationStatus>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X9_v8+10]");
			bool flag23 = (nint)0 == 0;
			object obj57 = !flag23;
			if (obj57 == null)
			{
				goto IL_09db;
			}
		}
		goto IL_0a32;
		IL_088b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj49 = obj24;
		obj38 = obj39;
		num = num2;
		obj21 = obj22;
		func3 = func7;
		goto IL_044d;
		IL_0209:
		obj19 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v50+E4]");
		bool flag24 = (nint)0 == 0;
		func = null;
		func2 = null;
		if (!flag24)
		{
			goto IL_0240;
		}
		goto IL_057e;
	}
}
