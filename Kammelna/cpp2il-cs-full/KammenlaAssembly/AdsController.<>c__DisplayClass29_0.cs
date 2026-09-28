using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class AdsController : ScriptableObject
{
	private sealed class <>c__DisplayClass29_0
	{
		public AdsController <>4__this;

		public string errorMsg;

		internal void <OnAdErrorEvent>b__0()
		{
			//IL_0058: Expected O, but got I
			//IL_0068: Expected O, but got I
			//IL_0078: Expected O, but got I
			AdsController adsController = <>4__this;
			Action<string> onAdError = adsController.OnAdError;
			if (adsController.OnAdError != null)
			{
				string text = errorMsg;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2 (System.Action`1<System.String>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2 (System.Action`1<System.String>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2 (System.Action`1<System.String>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v27 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public AdsController <>4__this;

		public AdType type;

		public AdPlace place;

		public string errorMsg;

		public Action <>9__2;

		public Action <>9__1;

		internal void <OnAdFailedToLoad3TimesEvent>b__0()
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0068: Expected O, but got I4
			//IL_00fa: Expected O, but got I4
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_035b: Expected O, but got I4
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_01e9: Expected O, but got I4
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected O, but got Unknown
			//IL_02b5: Expected O, but got I4
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_015b: Expected O, but got I4
			//IL_02df: Expected F4, but got I4
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_0233: Expected O, but got I
			//IL_023b: Expected I, but got O
			//IL_0249: Expected I, but got O
			//IL_019b: Expected O, but got I4
			//IL_026a: Expected I4, but got O
			Action action = default(Action);
			while (true)
			{
				AdsController adsController = <>4__this;
				if (adsController.<IsTestingMode>k__BackingField)
				{
					object obj = typeof(DataRelation) + 856;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v30+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message = "___# Content push apply failed [{0}]: {1}" + 800;
					Debug.Log(message);
					AdsController adsController2 = <>4__this;
					adsController2.<IsTestingMode>k__BackingField = false;
					break;
				}
				if (type != AdType.Banner)
				{
					bool flag2 = type == AdType.Rewarded;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						adsController.ShowVidAds(place);
						break;
					}
					bool flag3 = place == AdPlace.MiniGame;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v22+E4]");
						bool flag4 = (nint)0 == 0;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool noPlayServices = KUtil.NoPlayServices;
						bool flag5 = !noPlayServices;
						object obj9 = !flag5;
						if (obj9 != null)
						{
							goto IL_02e8;
						}
					}
					int num = UnityEngine.Random.Range(3, 10);
					object obj10 = this + 48;
					Action callback = (Action)obj10;
					bool flag6 = obj10 == null;
					object obj11 = !flag6;
					nint num2 = 0;
					int num3 = 10;
					if (obj11 == null)
					{
						object obj12 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj13 = (nint)0 + (nint)3096;
						num2 = (nint)obj13;
						action..ctor(this, (IntPtr)obj13);
						<>9__1 = action;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						num3 = (int)action;
						callback = action;
					}
					object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v13+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Coroutine coroutine = CoroutineDummy.WaitForSeconds(num, callback);
				}
				goto IL_02e8;
				IL_02e8:
				AdsController adsController3 = <>4__this;
				Action<string> onAdFailedToLoad3Times = adsController3.OnAdFailedToLoad3Times;
				if (adsController3.OnAdFailedToLoad3Times != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v211 @ X8_v9 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
					continue;
				}
				break;
			}
		}

		internal void <OnAdFailedToLoad3TimesEvent>b__1()
		{
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_010e: Expected O, but got I
			//IL_011c: Expected I, but got O
			//IL_015f: Expected O, but got I4
			//IL_016f: Expected I, but got O
			AdsController adsController = <>4__this;
			Action onAdLoaded = adsController.OnAdLoaded;
			if (adsController.OnAdLoaded != null)
			{
				nint method = ((Delegate)onAdLoaded).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				adsController = <>4__this;
			}
			Action onAdStart = adsController.OnAdStart;
			if (adsController.OnAdStart != null)
			{
				nint method = ((Delegate)onAdStart).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2296;
			object obj2 = this + 40;
			Action action = (Action)obj2;
			Action exitCallBack;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				exitCallBack = action;
				if (!flag)
				{
					goto IL_00da;
				}
			}
			else
			{
				object obj4 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)3104;
				Action action2 = default(Action);
				action2..ctor(this, (IntPtr)obj5);
				<>9__2 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				action = action2;
				nint method = (nint)action2;
				exitCallBack = action2;
				if (obj6 != null)
				{
					goto IL_00da;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			GenericAdUi.LoadGenericAd(exitCallBack);
			return;
			IL_00da:
			GenericAdUi.LoadGenericAd(action);
		}

		internal void <OnAdFailedToLoad3TimesEvent>b__2()
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_006e: Expected O, but got I4
			IntPtr intPtr = default(IntPtr);
			AdPlace adPlace = default(AdPlace);
			<>4__this.OnAdCompleteEvent((AdType)(nint)intPtr, adPlace);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			<>4__this.OnAdClosedEvent((AdType)(nint)intPtr, adPlace);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.AdEvent(AdSDK.Generic, AdAction.Complete, type, place);
		}
	}

	private Action m_OnAdStart;

	private Action m_OnAdComplete;

	private Action<string> m_OnAdError;

	private Action m_OnAdLoaded;

	private Action m_OnAdClosed;

	private Action<string> m_OnAdFailedToLoad3Times;

	private bool <IsTestingMode>k__BackingField;

	private GoogleAdsManager adsManager;

	public bool IsTestingMode
	{
		get
		{
			return <IsTestingMode>k__BackingField;
		}
		set
		{
			<IsTestingMode>k__BackingField = value;
		}
	}

	public event Action OnAdStart
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 24;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 24;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnAdComplete
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action<string> OnAdError
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action OnAdLoaded
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnAdClosed
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action<string> OnAdFailedToLoad3Times
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void Awake()
	{
		RegisterEventListeners();
	}

	private void OnDestroy()
	{
		UnregisterEventListeners();
	}

	private void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		//IL_014e: Expected I, but got O
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0161: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01ff: Expected O, but got I
		//IL_020d: Expected I, but got O
		//IL_01df: Expected O, but got I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0220: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I
		//IL_02e0: Expected I, but got O
		//IL_029e: Expected O, but got I4
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_03a5: Expected O, but got I
		//IL_03b3: Expected I, but got O
		//IL_0371: Expected O, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_03c6: Expected O, but got I4
		//IL_0425: Expected O, but got I4
		//IL_0464: Expected O, but got I
		//IL_0472: Expected I, but got O
		//IL_0444: Expected O, but got I4
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_0752: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_0535: Expected O, but got I
		//IL_0543: Expected I, but got O
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_0556: Expected O, but got I4
		//IL_05ad: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7031]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v89+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v89+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.WebGLPlayer)
		{
			return;
		}
		goto IL_0116;
		IL_0116:
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
		object obj6 = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, System.Int32Enum> action = default(Action<System.Int32Enum, System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj7 = adsManager + 24;
		Delegate obj8 = (Delegate)obj7;
		object obj12 = default(object);
		Delegate obj16 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum> action2 = default(Action<System.Int32Enum, System.Int32Enum>);
		object obj21 = default(object);
		Delegate obj23 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum, object> action3 = default(Action<System.Int32Enum, System.Int32Enum, object>);
		object obj29 = default(object);
		Delegate obj31 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum, bool> action4 = default(Action<System.Int32Enum, System.Int32Enum, bool>);
		object obj37 = default(object);
		Delegate obj39 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum> action5 = default(Action<System.Int32Enum, System.Int32Enum>);
		Delegate obj46 = default(Delegate);
		Delegate obj48 = default(Delegate);
		Delegate obj11 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum, object> action6 = default(Action<System.Int32Enum, System.Int32Enum, object>);
		object obj54 = default(object);
		Delegate obj56 = default(Delegate);
		Delegate obj45;
		while (true)
		{
			Delegate obj9 = Delegate.Combine(obj8, action);
			if ((object)obj9 == null)
			{
				object obj10 = 0;
			}
			else
			{
				obj11 = (Delegate)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = obj12 == null;
				object obj13 = !flag2;
				object obj10 = obj12;
				if (obj13 == null)
				{
					object obj14 = 0;
					Delegate obj15 = null;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag3 = (object)obj16 == obj8;
			obj8 = obj16;
			if (!flag3)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)3616;
			action2..ctor((object)this, (IntPtr)obj17);
			object obj18 = adsManager + 32;
			obj8 = (Delegate)obj18;
			while (true)
			{
				Delegate obj19 = Delegate.Combine(obj8, action2);
				if ((object)obj19 == null)
				{
					object obj20 = 0;
				}
				else
				{
					obj11 = (Delegate)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = obj21 == null;
					object obj22 = !flag4;
					object obj20 = obj21;
					if (obj22 == null)
					{
						object obj14 = 0;
						Delegate obj15 = null;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag5 = (object)obj23 == obj8;
				obj8 = obj23;
				if (!flag5)
				{
					continue;
				}
				object obj24 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 912;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj25 = (nint)0 + (nint)3624;
				action3..ctor((object)this, (IntPtr)obj25);
				object obj26 = adsManager + 40;
				obj8 = (Delegate)obj26;
				while (true)
				{
					Delegate obj27 = Delegate.Combine(obj8, action3);
					if ((object)obj27 == null)
					{
						object obj28 = 0;
					}
					else
					{
						obj11 = (Delegate)obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = obj29 == null;
						object obj30 = !flag6;
						object obj28 = obj29;
						if (obj30 == null)
						{
							object obj14 = 0;
							Delegate obj15 = null;
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag7 = (object)obj31 == obj8;
					obj8 = obj31;
					if (!flag7)
					{
						continue;
					}
					object obj32 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 904;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj33 = (nint)0 + (nint)3640;
					action4..ctor((object)this, (IntPtr)obj33);
					object obj34 = adsManager + 48;
					obj8 = (Delegate)obj34;
					while (true)
					{
						Delegate obj35 = Delegate.Combine(obj8, action4);
						if ((object)obj35 == null)
						{
							object obj36 = 0;
						}
						else
						{
							obj11 = (Delegate)obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag8 = obj37 == null;
							object obj38 = !flag8;
							object obj36 = obj37;
							if (obj38 == null)
							{
								object obj14 = 0;
								Delegate obj15 = null;
								break;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag9 = (object)obj39 == obj8;
						obj8 = obj39;
						if (!flag9)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj40 = (nint)0 + (nint)3608;
						action5..ctor((object)this, (IntPtr)obj40);
						object obj41 = adsManager + 56;
						Delegate obj42 = (Delegate)obj41;
						Delegate obj43 = obj11;
						while (true)
						{
							Delegate obj44 = Delegate.Combine(obj42, action5);
							object obj14;
							Delegate obj15;
							if ((object)obj44 == null)
							{
								obj45 = null;
							}
							else
							{
								obj11 = (Delegate)obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag10 = (object)obj46 == null;
								object obj47 = !flag10;
								obj14 = 0;
								obj15 = null;
								obj45 = obj46;
								obj43 = (Delegate)obj5;
								if (obj47 == null)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							bool flag11 = (object)obj48 == obj42;
							obj42 = obj48;
							obj14 = 0;
							obj15 = obj48;
							obj11 = obj43;
							if (!flag11)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj49 = (nint)0 + (nint)3632;
							action6..ctor((object)this, (IntPtr)obj49);
							object obj50 = adsManager + 64;
							Delegate obj51 = (Delegate)obj50;
							while (true)
							{
								Delegate obj52 = Delegate.Combine(obj51, action6);
								if ((object)obj52 == null)
								{
									object obj53 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag12 = obj54 == null;
									object obj55 = !flag12;
									object obj53 = obj54;
									if (obj55 == null)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag13 = (object)obj56 == obj51;
								obj51 = obj56;
								if (flag13)
								{
									return;
								}
							}
							InvalidCastException ex = new InvalidCastException();
							throw new NullReferenceException();
						}
						break;
					}
					break;
				}
				break;
			}
			break;
		}
		obj45 = obj11;
		throw new InvalidCastException();
		IL_0074:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 != RuntimePlatform.WebGLPlayer)
		{
			goto IL_0116;
		}
	}

	private void UnregisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0485: Expected I, but got O
		//IL_0496: Expected O, but got I
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_00d3: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_0184: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_0164: Expected O, but got I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_0243: Expected O, but got I
		//IL_0251: Expected I, but got O
		//IL_0223: Expected O, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_0264: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		//IL_0302: Expected O, but got I
		//IL_0310: Expected I, but got O
		//IL_02e2: Expected O, but got I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_0640: Expected O, but got I4
		//IL_037e: Expected O, but got I4
		//IL_0387: Expected O, but got I4
		//IL_03d3: Expected O, but got I
		//IL_03e1: Expected I, but got O
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_03f4: Expected O, but got I4
		//IL_044b: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 200;
		object obj2 = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, System.Int32Enum> action = default(Action<System.Int32Enum, System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)3616;
		object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 912;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 904;
		object obj6 = adsManager + 24;
		Delegate obj7 = (Delegate)obj6;
		object obj11 = default(object);
		Delegate obj15 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum> action2 = default(Action<System.Int32Enum, System.Int32Enum>);
		object obj19 = default(object);
		Delegate obj21 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum, object> action3 = default(Action<System.Int32Enum, System.Int32Enum, object>);
		object obj26 = default(object);
		Delegate obj28 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum, bool> action4 = default(Action<System.Int32Enum, System.Int32Enum, bool>);
		object obj33 = default(object);
		Delegate obj35 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum> action5 = default(Action<System.Int32Enum, System.Int32Enum>);
		Delegate obj42 = default(Delegate);
		Delegate obj44 = default(Delegate);
		Delegate obj10 = default(Delegate);
		Action<System.Int32Enum, System.Int32Enum, object> action6 = default(Action<System.Int32Enum, System.Int32Enum, object>);
		object obj50 = default(object);
		Delegate obj52 = default(Delegate);
		while (true)
		{
			Delegate obj8 = Delegate.Remove(obj7, action);
			if ((object)obj8 == null)
			{
				object obj9 = 0;
			}
			else
			{
				obj10 = (Delegate)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj11 == null;
				object obj12 = !flag;
				object obj9 = obj11;
				if (obj12 == null)
				{
					object obj13 = 0;
					Delegate obj14 = null;
					goto IL_03aa;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj15 == obj7;
			obj7 = obj15;
			if (!flag2)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj3);
			object obj16 = adsManager + 32;
			obj7 = (Delegate)obj16;
			Delegate obj41;
			while (true)
			{
				Delegate obj17 = Delegate.Remove(obj7, action2);
				if ((object)obj17 == null)
				{
					object obj18 = 0;
				}
				else
				{
					obj10 = (Delegate)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj19 == null;
					object obj20 = !flag3;
					object obj18 = obj19;
					if (obj20 == null)
					{
						object obj13 = 0;
						Delegate obj14 = null;
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj7;
				obj7 = obj21;
				if (!flag4)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj22 = (nint)0 + (nint)3624;
				action3..ctor((object)this, (IntPtr)obj22);
				object obj23 = adsManager + 40;
				obj7 = (Delegate)obj23;
				while (true)
				{
					Delegate obj24 = Delegate.Remove(obj7, action3);
					if ((object)obj24 == null)
					{
						object obj25 = 0;
					}
					else
					{
						obj10 = (Delegate)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = obj26 == null;
						object obj27 = !flag5;
						object obj25 = obj26;
						if (obj27 == null)
						{
							object obj13 = 0;
							Delegate obj14 = null;
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag6 = (object)obj28 == obj7;
					obj7 = obj28;
					if (!flag6)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj29 = (nint)0 + (nint)3640;
					action4..ctor((object)this, (IntPtr)obj29);
					object obj30 = adsManager + 48;
					obj7 = (Delegate)obj30;
					while (true)
					{
						Delegate obj31 = Delegate.Remove(obj7, action4);
						if ((object)obj31 == null)
						{
							object obj32 = 0;
						}
						else
						{
							obj10 = (Delegate)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag7 = obj33 == null;
							object obj34 = !flag7;
							object obj32 = obj33;
							if (obj34 == null)
							{
								object obj13 = 0;
								Delegate obj14 = null;
								break;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag8 = (object)obj35 == obj7;
						obj7 = obj35;
						if (!flag8)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj36 = (nint)0 + (nint)3608;
						action5..ctor((object)this, (IntPtr)obj36);
						object obj37 = adsManager + 56;
						Delegate obj38 = (Delegate)obj37;
						Delegate obj39 = obj10;
						while (true)
						{
							Delegate obj40 = Delegate.Remove(obj38, action5);
							object obj13;
							Delegate obj14;
							if ((object)obj40 == null)
							{
								obj41 = null;
							}
							else
							{
								obj10 = (Delegate)obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag9 = (object)obj42 == null;
								object obj43 = !flag9;
								obj13 = 0;
								obj14 = null;
								obj39 = (Delegate)obj;
								obj41 = obj42;
								if (obj43 == null)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
							bool flag10 = (object)obj44 == obj38;
							obj38 = obj44;
							obj10 = obj39;
							obj13 = 0;
							obj14 = obj44;
							if (!flag10)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj45 = (nint)0 + (nint)3632;
							action6..ctor((object)this, (IntPtr)obj45);
							object obj46 = adsManager + 64;
							Delegate obj47 = (Delegate)obj46;
							bool flag12;
							do
							{
								Delegate obj48 = Delegate.Remove(obj47, action6);
								if ((object)obj48 == null)
								{
									object obj49 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag11 = obj50 == null;
									object obj51 = !flag11;
									object obj49 = obj50;
									if (obj51 == null)
									{
										throw new InvalidCastException();
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								flag12 = (object)obj52 == obj47;
								obj47 = obj52;
							}
							while (!flag12);
							return;
						}
						break;
					}
					break;
				}
				break;
			}
			goto IL_03aa;
			IL_03aa:
			obj41 = obj10;
			throw new InvalidCastException();
		}
	}

	private void OnAdStartEvent(AdType type, AdPlace place)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3600;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForMainThread(action);
	}

	private void OnAdCompleteEvent(AdType type, AdPlace place)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3584;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForMainThread(action);
	}

	private void OnAdErrorEvent(AdType type, AdPlace place, string errorMsg)
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
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		//IL_00d9: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3080;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = errorMsg;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForMainThread(action);
	}

	private void OnAdLoadedEvent(AdType type, AdPlace place, bool isShowWhenReady)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3592;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForMainThread(action);
	}

	private void OnAdClosedEvent(AdType type, AdPlace place)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3576;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForMainThread(action);
	}

	private void OnAdFailedToLoad3TimesEvent(AdType type, AdPlace place, string errorMsg)
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
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00b4: Expected I, but got O
		//IL_00e3: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3088;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = errorMsg;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForMainThread(action);
	}

	public float GetBannerHeight()
	{
		//IL_005d: Expected F4, but got I4
		GoogleAdsManager.AdUnitHolder adUnit = adsManager.GetAdUnit(AdPlace.Offline, AdType.Banner);
		if (adUnit.banner != null)
		{
			return adUnit.banner.GetHeightInPixels();
		}
		return 0f;
	}

	public void ShowRewardedAd(AdPlace adPlace)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_00ca: Expected O, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.AdEvent(AdSDK.Admob, AdAction.Request, AdType.Rewarded, adPlace);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!Application.isEditor)
			{
				goto IL_00d8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isEditor = Application.isEditor;
			bool flag2 = !isEditor;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_00d8;
			}
		}
		goto IL_012e;
		IL_00d8:
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WebGLPlayer)
			{
				goto IL_012e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.WebGLPlayer)
			{
				goto IL_012e;
			}
		}
		adsManager.ShowRewardedAd(adPlace);
		return;
		IL_012e:
		object obj8 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 592;
		object errorMsg = "Network Authentication Required" + 2264;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		OnAdFailedToLoad3TimesEvent(AdType.Rewarded, adPlace, (string)errorMsg);
	}

	public void ShowVidAds(AdPlace adPlace)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F4C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isEditor = Application.isEditor;
		bool flag2 = !isEditor;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		goto IL_0173;
		IL_0173:
		object obj6 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 592;
		object errorMsg = "Network Authentication Required" + 2264;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		OnAdFailedToLoad3TimesEvent(AdType.Interstitial, adPlace, (string)errorMsg);
		return;
		IL_011d:
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WebGLPlayer)
			{
				goto IL_0173;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.WebGLPlayer)
			{
				goto IL_0173;
			}
		}
		adsManager.ShowInterstitialAd(adPlace);
		return;
		IL_0074:
		if (!Application.isEditor)
		{
			goto IL_011d;
		}
		goto IL_0173;
	}

	public void ShowBannerAd(Rect rect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.AdEvent(AdSDK.Admob, AdAction.Request, AdType.Banner, AdPlace.Offline);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!Application.isEditor)
			{
				goto IL_00d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isEditor = Application.isEditor;
			bool flag2 = !isEditor;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_00d9;
			}
		}
		goto IL_012f;
		IL_00d9:
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WebGLPlayer)
			{
				goto IL_012f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.WebGLPlayer)
			{
				goto IL_012f;
			}
		}
		adsManager.ShowBannerAd((Rect)6);
		return;
		IL_012f:
		object obj8 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 592;
		object errorMsg = "Network Authentication Required" + 2264;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		OnAdFailedToLoad3TimesEvent(AdType.Banner, AdPlace.Offline, (string)errorMsg);
	}

	public void ShowBannerAdOnTop()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0264: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_028f: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.AdEvent(AdSDK.Admob, AdAction.Request, AdType.Banner, AdPlace.Offline);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!Application.isEditor)
			{
				goto IL_00d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isEditor = Application.isEditor;
			bool flag2 = !isEditor;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_00d9;
			}
		}
		goto IL_012f;
		IL_00d9:
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WebGLPlayer)
			{
				goto IL_012f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.WebGLPlayer)
			{
				goto IL_012f;
			}
		}
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(adsManager, (IntPtr)obj9);
		IdfaPermission.Check(action);
		return;
		IL_012f:
		object obj10 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 592;
		object errorMsg = "Network Authentication Required" + 2264;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		OnAdFailedToLoad3TimesEvent(AdType.Banner, AdPlace.Offline, (string)errorMsg);
	}

	private bool ShouldRewardBeGranted(AdPlace place)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (place != AdPlace.MiniGame)
		{
			return true;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool noPlayServices = KUtil.NoPlayServices;
			return (byte)((noPlayServices ? 1u : 0u) ^ 1u) != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices2 = KUtil.NoPlayServices;
		return (byte)((noPlayServices2 ? 1u : 0u) ^ 1u) != 0;
	}

	private void <OnAdStartEvent>b__27_0()
	{
		Action onAdStart = this.OnAdStart;
		if (this.OnAdStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (<IsTestingMode>k__BackingField)
		{
			<IsTestingMode>k__BackingField = false;
		}
	}

	private void <OnAdCompleteEvent>b__28_0()
	{
		Action onAdComplete = this.OnAdComplete;
		if (this.OnAdComplete != null)
		{
			IntPtr invoke_impl = ((Delegate)onAdComplete).invoke_impl;
			IntPtr method_code = ((Delegate)onAdComplete).method_code;
			IntPtr method = ((Delegate)onAdComplete).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void <OnAdLoadedEvent>b__30_0()
	{
		Action onAdLoaded = this.OnAdLoaded;
		if (this.OnAdLoaded != null)
		{
			IntPtr invoke_impl = ((Delegate)onAdLoaded).invoke_impl;
			IntPtr method_code = ((Delegate)onAdLoaded).method_code;
			IntPtr method = ((Delegate)onAdLoaded).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void <OnAdClosedEvent>b__31_0()
	{
		Action onAdClosed = this.OnAdClosed;
		if (this.OnAdClosed != null)
		{
			IntPtr invoke_impl = ((Delegate)onAdClosed).invoke_impl;
			IntPtr method_code = ((Delegate)onAdClosed).method_code;
			IntPtr method = ((Delegate)onAdClosed).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
