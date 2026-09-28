using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore;
using UnityStandardAssets.ImageEffects;

namespace UI.Popups;

public class BlurLayersManager : Singleton<BlurLayersManager>
{
	private class PopupPlacement
	{
		public readonly Canvas Layer;

		public bool BlurSuppressed;

		public PopupPlacement(Canvas layer)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 16;
			obj = layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Transform, bool> <>9__18_0;

		public static Func<Canvas, float> <>9__26_0;

		public static Predicate<Camera> <>9__28_0;

		public static Func<Camera, float> <>9__29_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <PruneDestroyedPopups>b__18_0(Transform popup)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return popup == null;
		}

		internal float <NormalizeLayerDepths>b__26_0(Canvas canvas)
		{
			Camera worldCamera = canvas.worldCamera;
			return worldCamera.depth;
		}

		internal bool <RegisterAsUrpOverlay>b__28_0(Camera cam)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return cam == null;
		}

		internal float <SyncUrpStackOrder>b__29_1(Camera cam)
		{
			return cam.depth;
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public List<Camera> stack;

		internal Camera <SyncUrpStackOrder>b__0(int slot)
		{
			int index = default(int);
			if (stack != null)
			{
				return (Camera)((List<object>)(object)stack).get_Item(index);
			}
			return (Camera)(object)new NullReferenceException();
		}
	}

	private const string UntaggedTag = "Untagged";

	private Dictionary<Transform, PopupPlacement> _popupPlacements;

	private List<Canvas> _blurLayers;

	private HashSet<BlurOptimized> _activeBlurs;

	private Transform _blurLayersParent;

	public static bool IsBlurActive
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_020b: Expected I4, but got O
			//IL_0187: Expected O, but got I
			//IL_01eb: Expected O, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected I4, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E3C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)1944;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)1944;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_01fd;
			IL_01fd:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+20]");
				int count = ((Dictionary<object, object>)0).Count;
				bool flag3 = count < 0;
				bool flag4 = count == 0;
				int num = count ^ count;
				int num2 = count & num;
				bool flag5 = num2 < 0;
				bool flag6 = flag3 == flag5;
				object obj9 = !flag4;
				return (byte)((flag6 & obj9) ? 1 : 0) != 0;
			}
			goto IL_01fd;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = obj8 == null;
			object obj10 = !flag7;
			if (obj10 != null)
			{
				goto IL_0150;
			}
			goto IL_01fd;
		}
	}

	public static event Action<bool> OnPopupVisibilityChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3128;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			object obj8 = default(object);
			bool flag2;
			Delegate obj11 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj11 == obj5;
				obj5 = obj11;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3128;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			object obj8 = default(object);
			bool flag2;
			Delegate obj11 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj11 == obj5;
				obj5 = obj11;
			}
			while (!flag2);
		}
	}

	protected override void OnAwake()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_007d: Expected O, but got I4
		object obj = (nint)0 + (nint)1936;
		object obj2 = typeof(TypeConverter<ushort, char>) + 528;
		object obj3 = (nint)0 + (nint)496;
		object obj4 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC31C");
		Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)496;
		object obj3 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	public void AppendToLayer(Transform popup, bool worldPositionStays = false)
	{
		Canvas canvas = TopOccupiedLayer();
		Transform newParent = canvas.transform;
		UIExtensions.AttachToCanvas(popup, newParent, worldPositionStays);
	}

	public void AddBlurLayer(Transform popup, float duration = 0.4f, bool worldPositionStays = false)
	{
		//IL_0042: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		PruneDestroyedPopups();
		NormalizeLayerDepths();
		bool flag = ((Dictionary<object, object>)(object)_popupPlacements).Remove((object)popup);
		Canvas canvas = FirstFreeLayer();
		bool flag2 = (object)canvas == null;
		object obj = !flag2;
		if (obj == null)
		{
			canvas = CreateBlurLayer();
		}
		Camera worldCamera = canvas.worldCamera;
		float num = HighestLayerDepth();
		float depth = num + 10f;
		worldCamera.depth = depth;
		Camera worldCamera2 = canvas.worldCamera;
		GameObject gameObject = worldCamera2.gameObject;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3248;
		bool activeSelf = gameObject.activeSelf;
		bool flag3 = !activeSelf;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			gameObject.SetActive(value: true);
			Canvas.ForceUpdateCanvases();
		}
		Transform newParent = canvas.transform;
		UIExtensions.AttachToCanvas(popup, newParent, worldPositionStays);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj4 + 16;
		obj5 = canvas;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3128;
		((Dictionary<object, object>)(object)_popupPlacements).set_Item((object)popup, obj4);
		SyncUrpStackOrder();
		SyncBlurs(duration);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v8+B8]");
		object action = 0;
		bool isBlurActive = IsBlurActive;
		Actions.SafeInvoke((Action<bool>)action, isBlurActive);
	}

	public void RemoveBlurLayer(Transform popup, float duration = 0.4f)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		if (((Dictionary<object, object>)(object)_popupPlacements).Remove((object)popup))
		{
			SyncBlurs(duration);
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3128;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+B8]");
			object action = 0;
			bool isBlurActive = IsBlurActive;
			Actions.SafeInvoke((Action<bool>)action, isBlurActive);
		}
	}

	public void ShowBlur(Transform popup, float duration = 0.4f)
	{
		if (((Dictionary<object, object>)(object)_popupPlacements).TryGetValue((object)popup, out object _))
		{
			_ = 0;
			SyncBlurs(duration);
		}
	}

	public void HideBlur(Transform popup, float duration = 0.4f)
	{
		if (((Dictionary<object, object>)(object)_popupPlacements).TryGetValue((object)popup, out object _))
		{
			_ = 1;
			SyncBlurs(duration);
		}
	}

	public bool IsOnTopLayer(Transform popup)
	{
		//IL_0075: Expected I4, but got O
		Canvas canvas = TopOccupiedLayer();
		if ((object)canvas != null)
		{
			Transform parent = canvas.transform;
			if ((object)popup != null)
			{
				return popup.IsChildOf(parent);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void PruneDestroyedPopups()
	{
		//IL_0274: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_028e: Expected O, but got I
		//IL_029a: Expected O, but got I
		//IL_02aa: Expected O, but got I
		//IL_02ba: Expected O, but got I
		//IL_02dc: Expected O, but got I4
		//IL_00fb: Expected I, but got O
		//IL_0215: Expected I, but got O
		//IL_00a5: Expected O, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0314: Expected O, but got I
		//IL_0325: Expected I, but got O
		//IL_0343: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_0378: Expected I, but got O
		//IL_01c7: Expected O, but got I4
		bool flag = _popupPlacements == null;
		Dictionary<object, object>.KeyCollection keyCollection = (Dictionary<object, object>.KeyCollection)152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2512;
			object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3232;
			Dictionary<object, object>.KeyCollection keys = ((Dictionary<object, object>)(object)_popupPlacements).Keys;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			object obj5 = (nint)0 + (nint)3824;
			object obj6 = (nint)0 + (nint)2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v20+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+8]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v20+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj10 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+B8]");
					obj7 = 0;
				}
				object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 4000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj12 = (nint)0 + (nint)1752;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj7, (IntPtr)obj12);
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v18+B8]");
				object obj14 = (nint)0 + (nint)8;
				obj14 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			object obj15 = obj5;
			IEnumerable<object> source = Enumerable.Where(keys, predicate);
			num = (nint)obj6;
			List<object> list = Enumerable.ToList(source);
			bool flag5 = list == null;
			keyCollection = keys;
			if (!flag5)
			{
				object obj16 = (nint)0 + (nint)2664;
				object obj17 = (nint)0 + (nint)2488;
				keyCollection = (Dictionary<object, object>.KeyCollection)((nint)0 + (nint)2656);
				List<object>.Enumerator enumerator = list.GetEnumerator();
				while (true)
				{
					num = (nint)obj16;
					if (enumerator2.MoveNext())
					{
						if (_popupPlacements == null)
						{
							break;
						}
						obj15 = obj17;
						bool flag6 = ((Dictionary<object, object>)(object)_popupPlacements).Remove((object)null);
						continue;
					}
					enumerator2.Dispose();
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				object obj18 = 0;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag7 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)keyCollection;
			enumerator2.Dispose();
			object obj19 = default(object);
			if (obj19 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj18 = obj19;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBEBE0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private unsafe void SyncBlurs(float duration)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0d24: Expected O, but got I4
		//IL_0d2e: Expected O, but got I4
		//IL_0d37: Expected O, but got I4
		//IL_0d40: Expected O, but got I4
		//IL_0d49: Expected O, but got I4
		//IL_0037: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_007d: Expected O, but got Ref
		//IL_05b8: Expected O, but got I4
		//IL_0384: Expected O, but got I
		//IL_03a6: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_009f: Expected O, but got Ref
		//IL_03cd: Expected O, but got F4
		//IL_03eb: Expected O, but got I4
		//IL_05d9: Expected O, but got I4
		//IL_05e2: Expected O, but got F4
		//IL_0603: Expected O, but got I4
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0413: Invalid comparison between F4 and I4
		//IL_00bc: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_0a1a: Expected O, but got I4
		//IL_0a2b: Expected O, but got F4
		//IL_0a4c: Expected O, but got I4
		//IL_0654: Expected O, but got I
		//IL_0660: Expected O, but got I
		//IL_066c: Expected O, but got I
		//IL_0678: Expected O, but got I
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_06b8: Expected O, but got Ref
		//IL_06c0: Expected O, but got Ref
		//IL_0105: Expected O, but got F4
		//IL_0123: Expected O, but got I4
		//IL_0446: Expected O, but got F4
		//IL_088d: Expected O, but got I4
		//IL_0a71: Expected O, but got I4
		//IL_0a82: Expected O, but got F4
		//IL_0aa3: Expected O, but got I4
		//IL_07f6: Expected O, but got I
		//IL_0818: Expected O, but got I4
		//IL_014b: Invalid comparison between F4 and I4
		//IL_083e: Expected O, but got F4
		//IL_085c: Expected O, but got I4
		//IL_08dd: Expected O, but got I4
		//IL_0af0: Expected O, but got I4
		//IL_0710: Expected O, but got I
		//IL_0732: Expected O, but got I4
		//IL_017e: Expected O, but got F4
		//IL_0758: Expected O, but got F4
		//IL_0b15: Expected O, but got I4
		//IL_0b26: Expected O, but got F4
		//IL_0b47: Expected O, but got I4
		//IL_04f7: Expected O, but got I
		//IL_050d: Expected O, but got I
		//IL_0537: Expected O, but got I4
		//IL_0551: Expected O, but got F4
		//IL_0572: Expected O, but got I4
		//IL_0582: Expected O, but got I
		//IL_0781: Expected I4, but got O
		//IL_078e: Expected O, but got F4
		//IL_07ac: Expected O, but got I4
		//IL_0b8c: Expected O, but got I
		//IL_0ba1: Expected O, but got I
		//IL_0bbf: Expected O, but got I4
		//IL_09fa: Expected O, but got I4
		//IL_0a02: Expected O, but got Ref
		//IL_07c8: Expected O, but got F4
		//IL_07d9: Expected O, but got F4
		//IL_092a: Expected I4, but got O
		//IL_0937: Expected O, but got F4
		//IL_0955: Expected O, but got I4
		//IL_0233: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_0263: Expected O, but got I4
		//IL_0983: Expected O, but got F4
		//IL_09a1: Expected O, but got F8
		//IL_0292: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02c1: Expected O, but got I4
		//IL_02e3: Expected O, but got F4
		//IL_0304: Expected O, but got I4
		//IL_0314: Expected O, but got I
		//IL_034e: Expected I4, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E46]");
		object obj = 0;
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<object> hashSet = default(HashSet<object>);
		hashSet..ctor();
		bool flag = _popupPlacements == null;
		HashSet<object>.Enumerator enumerator = (HashSet<object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator2 = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator3 = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator4 = (Dictionary<object, object>.Enumerator)0;
		object obj3 = 152989696;
		BlurLayersManager blurLayersManager = this;
		object obj6;
		object obj7 = default(object);
		float num = default(float);
		int num2 = default(int);
		Canvas canvas;
		int num3;
		object obj15;
		UnityEngine.Object obj16;
		float num4;
		Dictionary<object, object>.Enumerator enumerator6 = default(Dictionary<object, object>.Enumerator);
		if (!flag)
		{
			obj3 = (nint)0 + (nint)3544;
			Dictionary<object, object>.Enumerator enumerator5 = ((Dictionary<object, object>)(object)_popupPlacements).GetEnumerator();
			object obj4 = (nint)0 + (nint)3552;
			object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			bool flag2 = hashSet == null;
			obj6 = (object)(&enumerator3);
			object obj12 = default(object);
			if (!flag2)
			{
				obj7 = (nint)0 + (nint)104;
				obj6 = (object)(&enumerator3);
				while (enumerator3.MoveNext())
				{
					object obj8 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v89+E4]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v89+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)num == null;
					bool flag5 = !flag4;
					object obj10 = !flag5;
					num2 = 0;
					object obj11 = obj12;
					if (obj10 != null)
					{
						continue;
					}
					bool flag6 = num == 0f;
					num3 = 0;
					obj11 = obj12;
					canvas = null;
					if (flag6)
					{
						goto IL_0a07;
					}
					GameObject gameObject = ((UnityEngine.Component)num).gameObject;
					bool flag7 = (object)gameObject == null;
					num3 = 0;
					obj11 = obj12;
					canvas = null;
					if (flag7)
					{
						goto IL_0a5e;
					}
					bool activeSelf = gameObject.activeSelf;
					bool flag8 = !activeSelf;
					num2 = 0;
					obj11 = obj12;
					if (flag8)
					{
						continue;
					}
					bool flag9 = obj12 == null;
					num3 = 0;
					obj11 = obj12;
					canvas = null;
					if (flag9)
					{
						goto IL_0b02;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+18]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+18]");
					object obj13 = (nint)0 & (nint)1;
					bool flag10 = obj13 == null;
					object obj14 = !flag10;
					num2 = 0;
					obj11 = obj12;
					if (obj14 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+10]");
					canvas = (Canvas)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+10]");
					Canvas canvas2 = LayerBelow((Canvas)0);
					bool flag11 = (object)canvas2 == null;
					enumerator = (HashSet<object>.Enumerator)0;
					num3 = 0;
					obj11 = obj12;
					obj15 = obj7;
					obj16 = (UnityEngine.Object)num;
					enumerator3 = enumerator6;
					num4 = num;
					enumerator4 = enumerator6;
					enumerator6 = (Dictionary<object, object>.Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+18]");
					obj = 0;
					blurLayersManager = this;
					if (!flag11)
					{
						Camera worldCamera = canvas2.worldCamera;
						BlurOptimized cameraBlur = GetCameraBlur(worldCamera);
						num2 = (int)obj7;
						bool flag12 = hashSet.Add(cameraBlur);
						obj11 = obj12;
						continue;
					}
					goto IL_0bcd;
				}
			}
			else
			{
				while (true)
				{
					bool flag13 = enumerator3.MoveNext();
					bool flag14 = !flag13;
					object obj17 = !flag14;
					if (obj17 != null)
					{
						object obj18 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v78+E4]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v78+E4]");
						bool flag15 = (nint)0 == 0;
						object obj19 = !flag15;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag16 = (UnityEngine.Object)num == null;
						bool flag17 = !flag16;
						object obj20 = !flag17;
						num2 = 0;
						obj7 = obj12;
						if (obj20 != null)
						{
							continue;
						}
						bool flag18 = num == 0f;
						num3 = 0;
						obj7 = obj12;
						canvas = null;
						if (flag18)
						{
							goto IL_0a07;
						}
						GameObject gameObject2 = ((UnityEngine.Component)num).gameObject;
						bool flag19 = (object)gameObject2 == null;
						num3 = 0;
						obj7 = obj12;
						canvas = null;
						if (flag19)
						{
							goto IL_0a5e;
						}
						bool activeSelf2 = gameObject2.activeSelf;
						bool flag20 = !activeSelf2;
						num2 = 0;
						obj7 = obj12;
						if (flag20)
						{
							continue;
						}
						bool flag21 = obj12 == null;
						num3 = 0;
						obj7 = obj12;
						canvas = null;
						if (flag21)
						{
							goto IL_0b02;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+18]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+18]");
						object obj21 = (nint)0 & (nint)1;
						bool flag22 = obj21 == null;
						num2 = 0;
						obj7 = obj12;
						enumerator = (HashSet<object>.Enumerator)0;
						num3 = 0;
						obj15 = obj12;
						obj16 = (UnityEngine.Object)num;
						enumerator3 = enumerator6;
						num4 = num;
						enumerator4 = enumerator6;
						enumerator6 = (Dictionary<object, object>.Enumerator)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ stack_-78+18]");
						obj = 0;
						blurLayersManager = this;
						if (!flag22)
						{
							continue;
						}
						goto IL_0b7c;
					}
					break;
				}
			}
			enumerator3.Dispose();
			enumerator = (HashSet<object>.Enumerator)0;
			obj16 = (UnityEngine.Object)num;
			enumerator3 = enumerator6;
			num4 = num;
			enumerator4 = enumerator6;
			enumerator6 = (Dictionary<object, object>.Enumerator)0;
			blurLayersManager = this;
			goto IL_060d;
		}
		goto IL_0b59;
		IL_0a07:
		NullReferenceException ex = new NullReferenceException();
		enumerator = (HashSet<object>.Enumerator)0;
		obj15 = obj7;
		obj16 = (UnityEngine.Object)num;
		Dictionary<object, object>.Enumerator enumerator7 = enumerator6;
		num4 = num;
		enumerator4 = enumerator6;
		enumerator6 = (Dictionary<object, object>.Enumerator)0;
		obj = obj6;
		blurLayersManager = this;
		goto IL_0c23;
		IL_0b7c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X25_v1+10]");
		canvas = (Canvas)0;
		BlurLayersManager blurLayersManager2 = blurLayersManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X25_v1+10]");
		Canvas canvas3 = blurLayersManager2.LayerBelow((Canvas)0);
		bool flag23 = (object)canvas3 == null;
		object obj22 = !flag23;
		if (obj22 == null)
		{
			goto IL_0bcd;
		}
		Camera worldCamera2 = canvas3.worldCamera;
		BlurOptimized cameraBlur2 = GetCameraBlur(worldCamera2);
		ex = new NullReferenceException();
		enumerator7 = enumerator3;
		canvas = null;
		goto IL_0c23;
		IL_0bcd:
		ex = new NullReferenceException();
		enumerator7 = enumerator3;
		goto IL_0c23;
		IL_0b02:
		ex = new NullReferenceException();
		enumerator = (HashSet<object>.Enumerator)0;
		obj15 = obj7;
		obj16 = (UnityEngine.Object)num;
		enumerator7 = enumerator6;
		num4 = num;
		enumerator4 = enumerator6;
		enumerator6 = (Dictionary<object, object>.Enumerator)0;
		obj = obj6;
		blurLayersManager = this;
		goto IL_0c23;
		IL_0c23:
		if ((nint)canvas == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			canvas = (Canvas)obj3;
			enumerator7.Dispose();
			object obj23 = default(object);
			bool flag24 = obj23 == null;
			num2 = num3;
			obj7 = obj15;
			enumerator3 = enumerator7;
			enumerator6 = (Dictionary<object, object>.Enumerator)obj23;
			obj6 = obj;
			if (flag24)
			{
				goto IL_060d;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B370");
			NullReferenceException ex3 = (NullReferenceException)(object)ex2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B330");
			NullReferenceException ex3 = ex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0b59:
		num3 = num2;
		obj15 = obj7;
		obj16 = (UnityEngine.Object)enumerator2;
		throw new NullReferenceException();
		IL_060d:
		blurLayersManager = (BlurLayersManager)(blurLayersManager + 48);
		bool flag25 = (object)blurLayersManager == null;
		enumerator2 = (Dictionary<object, object>.Enumerator)obj16;
		obj = obj6;
		object obj24;
		if (!flag25)
		{
			obj7 = (nint)0 + (nint)120;
			obj3 = (nint)0 + (nint)3488;
			object obj4 = (nint)0 + (nint)3496;
			object obj5 = (nint)0 + (nint)112;
			HashSet<object>.Enumerator enumerator8 = ((HashSet<object>)(object)blurLayersManager).GetEnumerator();
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			bool flag26 = hashSet == null;
			enumerator4 = enumerator6;
			obj = (object)(&enumerator);
			obj24 = (object)(&enumerator);
			if (!flag26)
			{
				while (enumerator.MoveNext())
				{
					object obj25 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v58+E4]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v58+E4]");
					bool flag27 = (nint)0 == 0;
					object obj26 = !flag27;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((bool)(UnityEngine.Object)num)
					{
						num2 = (int)obj5;
						bool flag28 = hashSet.Contains(num);
						bool flag29 = !flag28;
						object obj27 = !flag29;
						if (obj27 == null)
						{
							UIExtensions.TweenHideBlur((BlurOptimized)num, duration);
							num2 = 0;
							enumerator4 = (Dictionary<object, object>.Enumerator)duration;
						}
					}
				}
			}
			else
			{
				while (true)
				{
					bool flag30 = enumerator.MoveNext();
					bool flag31 = !flag30;
					object obj28 = !flag31;
					enumerator4 = enumerator6;
					obj = obj24;
					if (obj28 != null)
					{
						object obj29 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v49+E4]");
						obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v49+E4]");
						bool flag32 = (nint)0 == 0;
						object obj30 = !flag32;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag33 = (UnityEngine.Object)num;
						bool flag34 = !flag33;
						object obj31 = !flag34;
						if (obj31 == null)
						{
							continue;
						}
						goto IL_0ab5;
					}
					break;
				}
			}
			enumerator.Dispose();
			bool flag35 = hashSet == null;
			enumerator = (HashSet<object>.Enumerator)enumerator6;
			enumerator2 = (Dictionary<object, object>.Enumerator)obj16;
			enumerator6 = (Dictionary<object, object>.Enumerator)0;
			if (!flag35)
			{
				HashSet<object>.Enumerator enumerator9 = hashSet.GetEnumerator();
				HashSet<object>.Enumerator enumerator10 = default(HashSet<object>.Enumerator);
				enumerator4 = (Dictionary<object, object>.Enumerator)enumerator10;
				while (true)
				{
					canvas = (Canvas)obj4;
					if (enumerator.MoveNext())
					{
						if ((object)blurLayersManager == null)
						{
							break;
						}
						num2 = (int)obj5;
						bool flag36 = ((HashSet<object>)(object)blurLayersManager).Contains((object)num);
						bool flag37 = !flag36;
						object obj32 = !flag37;
						if (obj32 == null)
						{
							UIExtensions.TweenShowBlur((BlurOptimized)num, 2, 9f, 2, duration);
							num2 = 2;
							num4 = duration;
							enumerator4 = (Dictionary<object, object>.Enumerator)9.0;
						}
						continue;
					}
					enumerator.Dispose();
					blurLayersManager = (BlurLayersManager)(object)hashSet;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
				ex = new NullReferenceException();
				enumerator = enumerator10;
				num3 = num2;
				obj15 = obj7;
				enumerator7 = enumerator3;
				enumerator6 = (Dictionary<object, object>.Enumerator)0;
				obj = (object)(&enumerator);
				goto IL_0c23;
			}
		}
		goto IL_0b59;
		IL_0a5e:
		ex = new NullReferenceException();
		enumerator = (HashSet<object>.Enumerator)0;
		obj15 = obj7;
		obj16 = (UnityEngine.Object)num;
		enumerator7 = enumerator6;
		num4 = num;
		enumerator4 = enumerator6;
		enumerator6 = (Dictionary<object, object>.Enumerator)0;
		obj = obj6;
		blurLayersManager = this;
		goto IL_0c23;
		IL_0ab5:
		ex = new NullReferenceException();
		enumerator = (HashSet<object>.Enumerator)enumerator6;
		num3 = num2;
		obj15 = obj7;
		enumerator7 = enumerator3;
		enumerator4 = enumerator6;
		enumerator6 = (Dictionary<object, object>.Enumerator)0;
		canvas = null;
		obj = obj24;
		goto IL_0c23;
	}

	private Canvas TopOccupiedLayer()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		//IL_00a8: Expected I, but got O
		//IL_016c: Expected O, but got I4
		//IL_0171: Expected I, but got O
		//IL_017a: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_0110: Expected I, but got O
		//IL_0119: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_024f: Expected I, but got O
		//IL_026a: Expected I, but got O
		List<object> blurLayers = (List<object>)(object)_blurLayers;
		if (_blurLayers != null)
		{
			object obj = (nint)0 + (nint)2552;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			int num = 1;
			UnityEngine.Object obj3 = null;
			do
			{
				object obj5;
				if (num < blurLayers._size)
				{
					object obj4 = obj;
					obj5 = blurLayers.get_Item(num);
					bool flag = IsOccupied((Canvas)obj5);
					bool flag2 = !flag;
					nint num2 = (nint)obj5;
					if (!flag2)
					{
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22+E4]");
						object obj8;
						if ((nint)0 != 0)
						{
							bool flag3 = obj3 == null;
							bool flag4 = !flag3;
							object obj7 = !flag4;
							num2 = unchecked((nint)null);
							obj4 = 0;
							if (obj7 != null)
							{
								goto IL_0038;
							}
							obj8 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag5 = obj3 == null;
							bool flag6 = !flag5;
							object obj9 = !flag6;
							num2 = unchecked((nint)null);
							obj4 = 0;
							obj8 = 0;
							if (obj9 != null)
							{
								goto IL_0038;
							}
						}
						if (obj5 == null)
						{
							break;
						}
						Camera worldCamera = ((Canvas)obj5).worldCamera;
						if ((object)worldCamera == null)
						{
							break;
						}
						float depth = worldCamera.depth;
						if ((object)obj3 == null)
						{
							break;
						}
						Camera worldCamera2 = ((Canvas)obj3).worldCamera;
						if ((object)worldCamera2 == null)
						{
							break;
						}
						float depth2 = worldCamera2.depth;
						bool flag7 = depth > depth2;
						num2 = unchecked((nint)null);
						obj4 = obj8;
						if (flag7)
						{
							goto IL_0038;
						}
						num2 = unchecked((nint)null);
						obj4 = obj8;
					}
					goto IL_0386;
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					if ((bool)obj3)
					{
						goto IL_02ce;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag8 = obj3;
					bool flag9 = !flag8;
					object obj11 = !flag9;
					if (obj11 != null)
					{
						goto IL_02ce;
					}
				}
				if (_blurLayers == null)
				{
					break;
				}
				return (Canvas)((List<object>)(object)_blurLayers).get_Item(0);
				IL_0386:
				num++;
				blurLayers = (List<object>)(object)_blurLayers;
				continue;
				IL_02ce:
				return (Canvas)obj3;
				IL_0038:
				obj3 = (UnityEngine.Object)obj5;
				goto IL_0386;
			}
			while (_blurLayers != null);
		}
		return (Canvas)(object)new NullReferenceException();
	}

	private Canvas LayerBelow(Canvas layer)
	{
		//IL_0597: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_04b5: Expected O, but got I4
		//IL_046a: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		bool flag = _blurLayers == null;
		object obj = 152989696;
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)2552;
			object obj3 = ((List<object>)(object)_blurLayers).get_Item(0);
			List<object> blurLayers = (List<object>)(object)_blurLayers;
			bool flag2 = _blurLayers == null;
			obj = obj3;
			if (!flag2)
			{
				object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				if ((object)layer != null)
				{
					int num = 1;
					object obj5 = obj3;
					while (true)
					{
						bool flag3 = num >= blurLayers._size;
						obj = obj5;
						if (flag3)
						{
							break;
						}
						object obj6 = blurLayers.get_Item(num);
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v27+E4]");
						if ((nint)0 != 0)
						{
							bool flag4 = (UnityEngine.Object)obj6 == layer;
							bool flag5 = !flag4;
							object obj8 = !flag5;
							if (obj8 != null)
							{
								goto IL_009d;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag6 = (UnityEngine.Object)obj6 == layer;
							bool flag7 = !flag6;
							object obj9 = !flag7;
							if (obj9 != null)
							{
								goto IL_009d;
							}
						}
						if (!IsOccupied((Canvas)obj6))
						{
							goto IL_009d;
						}
						bool flag8 = obj6 == null;
						obj = obj5;
						if (!flag8)
						{
							Camera worldCamera = ((Canvas)obj6).worldCamera;
							bool flag9 = (object)worldCamera == null;
							obj = obj5;
							if (!flag9)
							{
								float depth = worldCamera.depth;
								Camera worldCamera2 = layer.worldCamera;
								bool flag10 = (object)worldCamera2 == null;
								obj = obj5;
								if (!flag10)
								{
									float depth2 = worldCamera2.depth;
									if (!(depth < depth2))
									{
										goto IL_009d;
									}
									Camera worldCamera3 = ((Canvas)obj6).worldCamera;
									bool flag11 = (object)worldCamera3 == null;
									obj = obj5;
									if (!flag11)
									{
										float depth3 = worldCamera3.depth;
										bool flag12 = obj5 == null;
										obj = obj5;
										if (!flag12)
										{
											Camera worldCamera4 = ((Canvas)obj5).worldCamera;
											bool flag13 = (object)worldCamera4 == null;
											obj = obj5;
											if (!flag13)
											{
												depth2 = worldCamera4.depth;
												if (depth3 > depth2)
												{
													obj5 = obj6;
												}
												goto IL_009d;
											}
										}
									}
								}
							}
						}
						goto IL_054d;
						IL_009d:
						num++;
						blurLayers = (List<object>)(object)_blurLayers;
						bool flag14 = _blurLayers == null;
						obj = obj5;
						if (!flag14)
						{
							continue;
						}
						goto IL_054d;
					}
				}
				else
				{
					int num2 = 1;
					while (true)
					{
						bool flag15 = num2 >= blurLayers._size;
						obj = obj3;
						if (flag15)
						{
							break;
						}
						object obj10 = blurLayers.get_Item(num2);
						object obj11 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v11+E4]");
						if ((nint)0 != 0)
						{
							bool flag16 = (UnityEngine.Object)obj10 == null;
							bool flag17 = !flag16;
							object obj12 = !flag17;
							if (obj12 != null)
							{
								goto IL_0399;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag18 = (UnityEngine.Object)obj10 == null;
							bool flag19 = !flag18;
							object obj13 = !flag19;
							if (obj13 != null)
							{
								goto IL_0399;
							}
						}
						if (!IsOccupied((Canvas)obj10))
						{
							goto IL_0399;
						}
						bool flag20 = obj10 == null;
						obj = obj3;
						if (!flag20)
						{
							Camera worldCamera5 = ((Canvas)obj10).worldCamera;
							bool flag21 = (object)worldCamera5 == null;
							object obj14 = !flag21;
							obj = obj3;
							if (obj14 != null)
							{
								float depth4 = worldCamera5.depth;
								return (Canvas)(object)new NullReferenceException();
							}
						}
						goto IL_054d;
						IL_0399:
						num2++;
						blurLayers = (List<object>)(object)_blurLayers;
						bool flag22 = _blurLayers == null;
						obj = obj3;
						if (!flag22)
						{
							continue;
						}
						goto IL_054d;
					}
				}
				return (Canvas)obj;
			}
		}
		goto IL_054d;
		IL_054d:
		throw new NullReferenceException();
	}

	private Canvas FirstFreeLayer()
	{
		//IL_0089: Expected O, but got I4
		List<object> blurLayers = (List<object>)(object)_blurLayers;
		int num = 1;
		while (true)
		{
			if (num < blurLayers._size)
			{
				object layer = blurLayers.get_Item(num);
				if (!IsOccupied((Canvas)layer))
				{
					break;
				}
				num++;
				blurLayers = (List<object>)(object)_blurLayers;
				bool flag = _blurLayers == null;
				object obj = !flag;
				if (obj == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return null;
		}
		return (Canvas)((List<object>)(object)_blurLayers).get_Item(num);
	}

	private bool IsOccupied(Canvas layer)
	{
		//IL_0386: Expected O, but got I4
		//IL_038f: Expected O, but got I4
		//IL_03a0: Expected O, but got I4
		//IL_0013: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_004c: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_007e: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_00eb: Expected I, but got O
		//IL_0123: Expected O, but got I4
		//IL_0162: Expected I, but got O
		//IL_0286: Expected I, but got O
		//IL_029e: Expected I, but got O
		//IL_01d4: Expected I, but got O
		bool flag = _popupPlacements == null;
		Dictionary<object, object>.Enumerator enumerator = (Dictionary<object, object>.Enumerator)0;
		Dictionary<object, object>.Enumerator enumerator2 = (Dictionary<object, object>.Enumerator)0;
		Canvas canvas = layer;
		UnityEngine.Object obj = (UnityEngine.Object)152989696;
		object obj4 = default(object);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)3552;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			obj4 = (nint)0 + (nint)3544;
			Dictionary<object, object>.Enumerator enumerator3 = ((Dictionary<object, object>)(object)_popupPlacements).GetEnumerator();
			obj = (UnityEngine.Object)152989696;
			Dictionary<object, object>.Enumerator enumerator4 = default(Dictionary<object, object>.Enumerator);
			object obj5 = default(object);
			Dictionary<object, object>.Enumerator enumerator5 = default(Dictionary<object, object>.Enumerator);
			Dictionary<object, object>.Enumerator enumerator7;
			Dictionary<object, object>.Enumerator enumerator6 = default(Dictionary<object, object>.Enumerator);
			while (true)
			{
				canvas = (Canvas)obj2;
				if (!enumerator4.MoveNext())
				{
					break;
				}
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ stack_-58+10]");
					obj = (UnityEngine.Object)0;
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v28+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = obj == layer;
					bool flag4 = !flag3;
					nint num = unchecked((nint)null);
					if (flag4)
					{
						continue;
					}
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v32+E4]");
					bool flag5 = (nint)0 == 0;
					object obj9 = !flag5;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = (UnityEngine.Object)enumerator5 != null;
					bool flag7 = !flag6;
					num = unchecked((nint)null);
					if (flag7)
					{
						continue;
					}
					if ((object)enumerator5 != null)
					{
						GameObject gameObject = ((UnityEngine.Component)enumerator5).gameObject;
						if ((object)gameObject != null)
						{
							bool activeSelf = gameObject.activeSelf;
							bool flag8 = !activeSelf;
							num = unchecked((nint)null);
							if (!flag8)
							{
								enumerator4.Dispose();
								return true;
							}
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						num = unchecked((nint)null);
						canvas = null;
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
						num = unchecked((nint)null);
						canvas = null;
					}
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
				}
				enumerator = enumerator6;
				enumerator7 = enumerator5;
				enumerator2 = enumerator6;
				enumerator6 = (Dictionary<object, object>.Enumerator)0;
				goto IL_03e0;
			}
			canvas = (Canvas)obj4;
			enumerator4.Dispose();
			enumerator = enumerator6;
			enumerator7 = enumerator5;
			enumerator2 = enumerator6;
			enumerator6 = (Dictionary<object, object>.Enumerator)0;
			goto IL_0229;
		}
		goto IL_03e0;
		IL_03e0:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag9 = (nint)canvas != 1;
		NullReferenceException ex5 = ex4;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			canvas = (Canvas)obj4;
			enumerator.Dispose();
			object obj10 = default(object);
			bool flag10 = obj10 == null;
			Dictionary<object, object>.Enumerator enumerator6 = (Dictionary<object, object>.Enumerator)obj10;
			if (flag10)
			{
				goto IL_0229;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			enumerator6 = (Dictionary<object, object>.Enumerator)obj10;
			ex5 = (NullReferenceException)(object)ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B330");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result = default(bool);
		return result;
		IL_0229:
		if ((object)layer != null)
		{
			Transform layer2 = layer.transform;
			return HasShownOccupant(layer2);
		}
		goto IL_03e0;
	}

	private unsafe static bool HasShownOccupant(Transform layer)
	{
		//IL_085b: Expected I, but got O
		//IL_0860: Expected I, but got O
		//IL_0036: Expected I, but got O
		//IL_003b: Expected I, but got O
		//IL_0040: Expected I, but got O
		//IL_07b5: Expected O, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_009c: Expected I, but got O
		//IL_00a1: Expected I, but got O
		//IL_0103: Expected I, but got O
		//IL_0113: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_089b: Expected I, but got O
		//IL_014e: Expected O, but got I
		//IL_05eb: Expected O, but got I4
		//IL_05f4: Expected O, but got I4
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_09bd: Expected I, but got O
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0950: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0177: Expected O, but got I
		//IL_0619: Expected O, but got I
		//IL_020c: Expected I, but got O
		//IL_021c: Expected O, but got I
		//IL_06b0: Expected O, but got I4
		//IL_02bb: Expected O, but got I4
		//IL_0654: Expected O, but got I
		//IL_08ff: Expected I, but got O
		//IL_0257: Expected O, but got I
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected I, but got Unknown
		//IL_02fe: Expected I, but got O
		//IL_0306: Expected I, but got O
		//IL_0316: Expected O, but got I
		//IL_0326: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0280: Expected O, but got I
		//IL_0383: Expected O, but got I
		//IL_0724: Expected I, but got O
		//IL_040d: Expected I, but got O
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_04bb: Expected O, but got I
		//IL_04d5: Expected O, but got I4
		//IL_04e5: Expected O, but got I
		//IL_058b: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E4B]");
		nint num = 0;
		Transform transform = default(Transform);
		bool flag = (object)transform == null;
		nint num2 = unchecked((nint)null);
		nint num3 = unchecked((nint)null);
		object obj4;
		object obj6;
		object obj8;
		nint num4;
		object obj27;
		object obj9 = default(object);
		object obj7 = default(object);
		if (!flag)
		{
			IEnumerator enumerator = transform.GetEnumerator();
			bool flag2 = enumerator == null;
			num2 = unchecked((nint)null);
			num3 = unchecked((nint)null);
			num4 = unchecked((nint)null);
			object obj = default(object);
			num = (nint)(&obj);
			if (!flag2)
			{
				object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
				obj4 = (nint)0 + (nint)1072;
				object obj5 = (nint)0 + (nint)1144;
				num2 = unchecked((nint)null);
				num3 = unchecked((nint)null);
				obj6 = obj7;
				obj8 = obj9;
				IEnumerator enumerator2 = enumerator;
				object obj13 = default(object);
				bool flag4 = default(bool);
				IEnumerator enumerator3 = default(IEnumerator);
				object obj16 = default(object);
				UnityEngine.Component component = default(UnityEngine.Component);
				object obj21 = default(object);
				object obj25 = default(object);
				while (true)
				{
					nint num5 = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_019f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj11 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v26-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj8 = obj11 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v17 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						obj10 = -1;
						bool flag3 = (nint)obj10 != 1;
						obj11 = obj8;
						if (flag3)
						{
							continue;
						}
						goto IL_019f;
					}
					obj10 = obj11;
					object obj12 = num5 + obj11;
					obj13 = obj12 + 312;
					obj8 = obj11;
					goto IL_0893;
					IL_0893:
					num = (nint)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v28+8]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v425 @ X0_v28] (should have been resolved before IL gen)");
					if (!flag4)
					{
						break;
					}
					if (enumerator3 == null)
					{
						goto IL_0747;
					}
					nint num6 = (nint)enumerator3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v21 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v21 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02a8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v21 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj14 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X10_v21-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj8 = obj14 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v21 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						obj10 = -1;
						bool flag5 = (nint)obj10 != 1;
						obj14 = obj8;
						if (flag5)
						{
							continue;
						}
						goto IL_02a8;
					}
					obj10 = obj14 + 1;
					object obj15 = num6 + obj10;
					obj16 = obj15 + 312;
					obj8 = obj14;
					goto IL_08f7;
					IL_08f7:
					num = (nint)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v33+8]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v637 @ X0_v33] (should have been resolved before IL gen)");
					if ((object)component != null)
					{
						num4 = (nint)obj3;
						num = (nint)component;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5 (Il2CppClass<UnityEngine.Component>)+130]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X1_v7 (Il2CppMethodInfo)+130]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5 (Il2CppClass<UnityEngine.Component>)+130]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X1_v7 (Il2CppMethodInfo)+130]");
						bool flag6 = num7 < 0;
						object obj17 = !flag6;
						object obj18 = ~obj17;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5 (Il2CppClass<UnityEngine.Component>)+C8]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X1_v7 (Il2CppMethodInfo)+130]");
							object obj19 = num8 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27-8]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27-8]");
							if (0 == num4)
							{
								GameObject gameObject = component.gameObject;
								if ((object)gameObject != null)
								{
									bool activeSelf = gameObject.activeSelf;
									bool flag7 = !activeSelf;
									obj7 = obj6;
									num4 = unchecked((nint)null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27-8]");
									nint num9 = 0;
									if (!flag7)
									{
										obj6 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
										object obj20 = obj21 & 1;
										bool flag8 = obj20 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27-8]");
										num9 = 0;
										if (!flag8)
										{
											if (num3 == 0)
											{
												goto IL_0765;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ stack_-50_v2 (Il2CppClass<UnityEngine.Component>)+58]");
											num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ stack_-50_v2 (Il2CppClass<UnityEngine.Component>)+58]");
											object obj22 = (nint)0 & (nint)1;
											bool flag9 = obj22 == null;
											object obj23 = !flag9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5 (Il2CppClass<UnityEngine.Component>)+130]");
											obj8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ stack_-50_v2 (Il2CppClass<UnityEngine.Component>)+58]");
											num = 0;
											if (obj23 != null)
											{
												break;
											}
										}
										obj7 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
										object obj24 = obj25 & 1;
										bool flag10 = obj24 == null;
										num4 = (nint)(&num2);
										if (!flag10)
										{
											if (num2 == 0)
											{
												goto IL_078b;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ stack_-58_v2 (Il2CppClass<UnityEngine.Component>)+50]");
											num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ stack_-58_v2 (Il2CppClass<UnityEngine.Component>)+50]");
											object obj26 = (nint)0 & (nint)1;
											bool flag11 = obj26 == null;
											num4 = (nint)(&num2);
											obj6 = obj5;
											obj8 = obj9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ stack_-58_v2 (Il2CppClass<UnityEngine.Component>)+50]");
											num = 0;
											if (!flag11)
											{
												break;
											}
										}
									}
									bool flag12 = enumerator3 == null;
									obj6 = obj7;
									obj8 = obj9;
									enumerator2 = enumerator3;
									num = num9;
									if (!flag12)
									{
										continue;
									}
									goto IL_0700;
								}
								goto IL_070e;
							}
						}
						goto IL_06ea;
					}
					goto IL_0729;
					IL_02a8:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj6 = 1;
					goto IL_08f7;
					IL_019f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj6 = 0;
					goto IL_0893;
				}
				obj7 = obj6;
				obj9 = obj8;
				obj27 = 0;
				object obj28 = 0;
				bool result = flag4;
				object obj30 = default(object);
				object obj36 = default(object);
				IntPtr intPtr = default(IntPtr);
				while (true)
				{
					object obj29 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					num4 = (nint)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj30 == null)
					{
						goto IL_0936;
					}
					object obj31 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v6+12E]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v6+12E]");
					if ((nint)0 == 0)
					{
						goto IL_069d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v6+B0]");
					object obj33 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X10_v8-8]");
						if (0 == (nint)obj29)
						{
							break;
						}
						obj9 = obj33 + 16;
						obj32--;
						bool flag13 = (nint)obj32 != 1;
						obj33 = obj9;
						if (flag13)
						{
							continue;
						}
						goto IL_069d;
					}
					object obj34 = obj31 + obj33;
					num = (nint)(obj34 + 312);
					obj9 = obj33;
					goto IL_0982;
					IL_0936:
					bool flag14 = obj28 == null;
					object obj35 = !flag14;
					if (obj35 == null)
					{
						return result;
					}
					OutOfMemoryException ex = new OutOfMemoryException();
					if (num4 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj28 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj27 = obj36;
					result = false;
					continue;
					IL_069d:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj7 = 0;
					num = intPtr;
					goto IL_0982;
					IL_0982:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v5 (Il2CppClass<UnityEngine.Component>)+8]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X8_v5 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
					goto IL_0936;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				bool result2 = default(bool);
				return result2;
			}
			goto IL_0700;
		}
		goto IL_09e4;
		IL_0765:
		NullReferenceException ex2 = new NullReferenceException();
		obj7 = obj4;
		num4 = (nint)(&num3);
		num = num3;
		goto IL_07a9;
		IL_0747:
		NullReferenceException ex3 = new NullReferenceException();
		obj7 = obj6;
		obj9 = obj8;
		goto IL_07a9;
		IL_078b:
		NullReferenceException ex4 = new NullReferenceException();
		num4 = (nint)(&num2);
		num = num2;
		goto IL_07a9;
		IL_070e:
		NullReferenceException ex5 = new NullReferenceException();
		obj7 = obj6;
		num4 = unchecked((nint)null);
		goto IL_07a9;
		IL_09e4:
		throw new NullReferenceException();
		IL_07a9:
		obj27 = 0;
		goto IL_09e4;
		IL_0729:
		NullReferenceException ex6 = new NullReferenceException();
		obj7 = obj6;
		obj9 = obj8;
		goto IL_07a9;
		IL_0700:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_07a9;
		IL_06ea:
		InvalidCastException ex8 = new InvalidCastException();
		obj7 = obj6;
		goto IL_07a9;
	}

	private float HighestLayerDepth()
	{
		//IL_013a: Invalid comparison between F4 and I4
		//IL_0149: Invalid comparison between F4 and I4
		//IL_015c: Expected O, but got F4
		//IL_0169: Expected O, but got F4
		//IL_019e: Expected O, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		if (_blurLayers != null)
		{
			object obj = ((List<object>)(object)_blurLayers).get_Item(0);
			if (obj != null)
			{
				Camera worldCamera = ((Canvas)obj).worldCamera;
				if ((object)worldCamera != null)
				{
					float depth = worldCamera.depth;
					List<object> blurLayers = (List<object>)(object)_blurLayers;
					if (_blurLayers != null)
					{
						float num = depth;
						int num2 = 1;
						object obj9;
						do
						{
							bool flag = num2 >= blurLayers._size;
							float result = num;
							if (!flag)
							{
								object obj2 = blurLayers.get_Item(num2);
								bool flag2 = obj2 == null;
								result = num;
								if (flag2)
								{
									break;
								}
								Camera worldCamera2 = ((Canvas)obj2).worldCamera;
								bool flag3 = (object)worldCamera2 == null;
								result = num;
								if (flag3)
								{
									break;
								}
								float depth2 = worldCamera2.depth;
								float num3 = num - depth2;
								bool flag4 = num3 < 0f;
								bool flag5 = num3 == 0f;
								object obj3 = num ^ depth2;
								object obj4 = num ^ num3;
								object obj5 = obj3 & obj4;
								bool flag6 = (nint)obj5 < 0;
								bool flag7 = flag4 == flag6;
								object obj6 = !flag5;
								object obj7 = flag7 & obj6;
								object obj8 = ~obj7;
								if (obj8 != null)
								{
									num = depth2;
								}
								num2++;
								blurLayers = (List<object>)(object)_blurLayers;
								bool flag8 = _blurLayers == null;
								obj9 = !flag8;
								result = num;
								continue;
							}
							return result;
						}
						while (obj9 != null);
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void NormalizeLayerDepths()
	{
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0029: Expected O, but got I
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected O, but got Unknown
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected O, but got Unknown
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected O, but got Unknown
		//IL_0a70: Expected O, but got I
		//IL_0a82: Expected O, but got Ref
		//IL_0468: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_054b: Expected O, but got I4
		//IL_0b5f: Expected O, but got I
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got Unknown
		//IL_04b3: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0310: Expected O, but got I
		//IL_0332: Expected O, but got I4
		//IL_0787: Expected O, but got I4
		//IL_0790: Expected O, but got I4
		//IL_0b07: Expected O, but got I
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_0382: Expected O, but got I4
		//IL_0c42: Expected O, but got I4
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04e4: Expected O, but got I
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01da: Expected I, but got O
		//IL_01ea: Expected O, but got I
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		//IL_0ab1: Expected O, but got I
		//IL_0ac2: Expected I, but got O
		//IL_0ac2: Expected O, but got I
		//IL_0aca: Expected I, but got O
		//IL_0ae0: Expected O, but got I
		//IL_07ad: Expected O, but got I
		//IL_05c5: Expected O, but got I
		//IL_02c5: Expected O, but got I4
		//IL_03ea: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_084c: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_0cc4: Expected O, but got I
		//IL_07e8: Expected O, but got I
		//IL_0bfc: Expected O, but got I
		//IL_0600: Expected O, but got I
		//IL_09b4: Expected O, but got I
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_0c88: Expected O, but got I
		//IL_0ba4: Expected O, but got I
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06e0: Expected O, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_0811: Expected O, but got I
		//IL_0769: Expected O, but got I4
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0631: Expected O, but got I
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E4D]");
		nint num = 0;
		object obj = default(object);
		object obj6;
		Func<object, float> keySelector;
		IEnumerable<object> source;
		object obj14;
		object obj16;
		float num3 = default(float);
		float depth;
		object obj17 = default(object);
		NullReferenceException ex;
		if (_blurLayers != null)
		{
			num = (nint)0 + (nint)2552;
			obj = num;
			object obj2 = ((List<object>)(object)_blurLayers).get_Item(0);
			if (obj2 != null)
			{
				Camera worldCamera = ((Canvas)obj2).worldCamera;
				if ((object)worldCamera != null)
				{
					object obj3 = (nint)0 + (nint)608;
					object obj4 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3232;
					depth = worldCamera.depth;
					IEnumerable<object> enumerable = Enumerable.Skip((IEnumerable<object>)_blurLayers, 1);
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v51+E4]");
					object obj7;
					IEnumerable<object> source2;
					nint num2;
					if ((nint)0 != 0)
					{
						obj6 = (nint)0 + (nint)2048;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v51+B8]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+10]");
						keySelector = (Func<object, float>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+10]");
						bool flag = (nint)0 == 0;
						source = enumerable;
						obj7 = obj6;
						source2 = enumerable;
						num2 = num;
						if (!flag)
						{
							goto IL_0168;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj5 = obj4;
						obj6 = (nint)0 + (nint)2048;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v51+B8]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+10]");
						keySelector = (Func<object, float>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+10]");
						bool flag2 = (nint)0 == 0;
						object obj8 = !flag2;
						source = enumerable;
						obj7 = obj6;
						source2 = enumerable;
						num2 = num;
						if (obj8 != null)
						{
							goto IL_0168;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v51+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj10 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v37+B8]");
						num2 = 0;
					}
					object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 416;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = (nint)0 + (nint)1744;
					Func<object, float> func = default(Func<object, float>);
					func..ctor((object)num2, (IntPtr)obj12);
					num = (nint)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+B8]");
					object obj13 = (nint)0 + (nint)16;
					obj13 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj14 = obj7;
					IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderBy(source2, func);
					bool flag4 = orderedEnumerable == null;
					object obj15 = !flag4;
					obj16 = 0;
					ex = (NullReferenceException)orderedEnumerable;
					obj17 = 0;
					num3 = depth;
					obj = obj7;
					if (obj15 != null)
					{
						goto IL_01be;
					}
				}
			}
		}
		goto IL_0422;
		IL_0430:
		object obj19 = default(object);
		object obj18 = num + obj19;
		object obj20 = obj18 + 312;
		goto IL_0a1c;
		IL_02a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj17 = obj16;
		num3 = depth;
		obj = 0;
		object obj21 = default(object);
		obj20 = obj21;
		goto IL_0a1c;
		IL_0168:
		obj14 = obj6;
		IOrderedEnumerable<object> orderedEnumerable2 = Enumerable.OrderBy(source, keySelector);
		bool flag5 = orderedEnumerable2 == null;
		obj16 = obj17;
		ex = (NullReferenceException)orderedEnumerable2;
		num3 = depth;
		obj = obj6;
		if (!flag5)
		{
			goto IL_01be;
		}
		goto IL_0422;
		IL_0a1c:
		object obj22 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj23 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 344;
		object obj24 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj25 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v3+8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ X8_v3] (should have been resolved before IL gen)");
		object obj28 = default(object);
		object obj27 = (object)(&obj28);
		object obj29 = default(object);
		object obj31;
		object obj32;
		object obj33 = default(object);
		object obj34;
		bool flag8 = default(bool);
		object obj38 = default(object);
		object obj39;
		object obj40;
		object obj43 = default(object);
		object obj48 = default(object);
		object obj52;
		object obj41;
		Canvas canvas = default(Canvas);
		while (true)
		{
			if (obj29 != null)
			{
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14+12E]");
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14+12E]");
				bool flag6 = (nint)0 == 0;
				obj32 = obj33;
				obj34 = obj19;
				if (flag6)
				{
					goto IL_0538;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14+B0]");
				object obj35 = (nint)0 + (nint)8;
				bool flag7 = flag8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v23-8]");
					obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v23-8]");
					object obj36 = 0 - obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v23-8]");
					if (0 == (nint)obj22)
					{
						break;
					}
					obj34 = obj35 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14+12E]");
					obj31 = -1;
					obj36 = obj31 - 1;
					bool flag9 = obj36 == null;
					flag8 = (nint)obj31 != 1;
					flag7 = flag8;
					obj35 = obj34;
					if (flag8)
					{
						continue;
					}
					goto IL_0538;
				}
				obj31 = obj35;
				object obj37 = obj30 + obj35;
				obj38 = obj37 + 312;
				flag8 = flag7;
				obj34 = obj35;
				obj39 = obj;
				goto IL_0b47;
			}
			throw new NullReferenceException();
			IL_0538:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj39 = 0;
			goto IL_0b47;
			IL_0b47:
			obj40 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v26+8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X0_v26] (should have been resolved before IL gen)");
			object obj42 = obj43 & 1;
			object obj45;
			object obj46;
			object obj49;
			object obj50;
			if (obj42 != null)
			{
				if (obj29 != null)
				{
					object obj44 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v17+12E]");
					obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v17+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0685;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v17+B0]");
					obj46 = (nint)0 + (nint)8;
					bool flag10 = flag8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v3-8]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v3-8]");
						object obj36 = 0 - obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v3-8]");
						if (0 == (nint)obj23)
						{
							break;
						}
						obj34 = obj46 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v17+12E]");
						obj45 = -1;
						obj36 = obj45 - 1;
						bool flag9 = obj36 == null;
						flag8 = (nint)obj45 != 1;
						flag10 = flag8;
						obj46 = obj34;
						if (flag8)
						{
							continue;
						}
						goto IL_0685;
					}
					obj45 = obj46;
					object obj47 = obj44 + obj46;
					obj48 = obj47 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X10_v3-8]");
					obj49 = 0;
					flag8 = flag10;
					obj50 = obj39;
					goto IL_0be4;
				}
				throw new NullReferenceException();
			}
			object obj51 = 0;
			obj52 = 0;
			break;
			IL_0685:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj49 = obj32;
			obj46 = obj34;
			obj50 = 0;
			goto IL_0be4;
			IL_0be4:
			object obj53 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v30+8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v677 @ X0_v30] (should have been resolved before IL gen)");
			Camera worldCamera2 = canvas.worldCamera;
			if ((object)worldCamera2 == null)
			{
				throw new NullReferenceException();
			}
			num3 = (worldCamera2.depth = num3 + 10f);
			obj33 = obj49;
			obj19 = obj46;
			obj25 = obj45;
			depth = num3;
			obj26 = 0;
			obj = obj50;
			obj27 = obj53;
		}
		object obj57 = default(object);
		object obj59 = default(object);
		while (true)
		{
			if (obj29 == null)
			{
				goto IL_0c28;
			}
			object obj54 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v9+12E]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v9+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0839;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v9+B0]");
			object obj55 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v10-8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v10-8]");
				if (0 == (nint)obj24)
				{
					break;
				}
				obj34 = obj55 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v9+12E]");
				obj31 = -1;
				bool flag11 = (nint)obj31 != 1;
				obj55 = obj34;
				if (flag11)
				{
					continue;
				}
				goto IL_0839;
			}
			obj31 = obj55;
			object obj56 = obj54 + obj55;
			obj57 = obj56 + 312;
			obj34 = obj55;
			goto IL_0cac;
			IL_0c28:
			bool flag12 = obj52 == null;
			object obj58 = !flag12;
			object obj49 = obj32;
			object obj46 = obj34;
			object obj45 = obj31;
			object obj50 = obj39;
			object obj53 = obj40;
			if (obj58 == null)
			{
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)obj41 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj52 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj32 = obj49;
			object obj51 = obj59;
			obj34 = obj46;
			obj31 = obj45;
			obj39 = obj50;
			obj40 = obj53;
			continue;
			IL_0839:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj39 = 0;
			goto IL_0cac;
			IL_0cac:
			obj40 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v18+8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v737 @ X0_v18] (should have been resolved before IL gen)");
			goto IL_0c28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_01be:
		object obj60 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2984;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02a2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23 (Il2CppClass<System.NullReferenceException>)+B0]");
		object obj62 = (nint)0 + (nint)8;
		bool flag13 = flag8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v30-8]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v30-8]");
			object obj36 = 0 - obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v30-8]");
			bool flag9 = 0 == (nint)obj60;
			obj17 = obj16;
			flag8 = flag13;
			obj19 = obj62;
			num3 = depth;
			obj = obj14;
			if (flag9)
			{
				break;
			}
			obj19 = obj62 + 16;
			obj61--;
			obj36 = obj61 - 1;
			flag9 = obj36 == null;
			flag8 = (nint)obj61 != 1;
			flag13 = flag8;
			obj62 = obj19;
			if (flag8)
			{
				continue;
			}
			goto IL_02a2;
		}
		goto IL_0430;
		IL_0422:
		ex = new NullReferenceException();
		goto IL_0430;
	}

	private Canvas CreateBlurLayer()
	{
		//IL_000d: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0069: Expected O, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		object obj = (nint)0 + (nint)568;
		object obj2 = Enumerable.Last((IEnumerable<object>)_blurLayers);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30E3A08");
		Canvas canvas = default(Canvas);
		if (obj2 != null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = (nint)0 + (nint)896;
			Camera worldCamera = ((Canvas)obj2).worldCamera;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			if ((object)canvas != null)
			{
				Camera worldCamera2 = default(Camera);
				canvas.worldCamera = worldCamera2;
				Camera worldCamera3 = canvas.worldCamera;
				if ((object)worldCamera3 != null)
				{
					GameObject gameObject = worldCamera3.gameObject;
					if ((object)gameObject != null)
					{
						object tag = "Unsupported map type" + 64;
						gameObject.tag = (string)tag;
						Camera worldCamera4 = canvas.worldCamera;
						if ((object)worldCamera4 != null)
						{
							object obj7 = (nint)0 + (nint)936;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
							object obj8 = default(object);
							if (obj8 == null)
							{
								goto IL_04b8;
							}
							Behaviour behaviour = default(Behaviour);
							if ((object)behaviour != null)
							{
								behaviour.enabled = false;
								if ((object)behaviour != null)
								{
									_ = 0;
									goto IL_04b8;
								}
							}
						}
					}
				}
			}
		}
		goto IL_044d;
		IL_044d:
		return (Canvas)(object)new NullReferenceException();
		IL_04b8:
		if (_blurLayers != null)
		{
			object obj9 = "WhiteSmoke" + 2832;
			int num = default(int);
			string text = num.ToString();
			string text2 = (string)obj9 + text;
			canvas.name = text2;
			Camera worldCamera5 = canvas.worldCamera;
			if (_blurLayers != null)
			{
				object obj10 = "WhiteSmoke" + 2824;
				string text3 = num.ToString();
				string text4 = (string)obj10 + text3;
				if ((object)worldCamera5 != null)
				{
					worldCamera5.name = text4;
					Camera worldCamera6 = canvas.worldCamera;
					Camera worldCamera7 = ((Canvas)obj2).worldCamera;
					if ((object)worldCamera7 != null)
					{
						float depth = worldCamera7.depth;
						if ((object)worldCamera6 != null)
						{
							float depth2 = depth + 10f;
							worldCamera6.depth = depth2;
							Camera worldCamera8 = canvas.worldCamera;
							RegisterAsUrpOverlay(worldCamera8);
							List<object> blurLayers = (List<object>)(object)_blurLayers;
							if (_blurLayers != null)
							{
								int version = blurLayers._version + 1;
								blurLayers._version = version;
								object[] items = blurLayers._items;
								if (blurLayers._items != null)
								{
									bool flag2 = blurLayers._size < items.Length;
									object obj11 = !flag2;
									if (obj11 == null)
									{
										int size = blurLayers._size + 1;
										blurLayers._size = size;
										object obj12 = blurLayers._items + blurLayers._size;
										object obj13 = obj12 + 32;
										obj13 = canvas;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										((List<object>)(object)_blurLayers).AddWithResize((object)canvas);
									}
									return canvas;
								}
							}
						}
					}
				}
			}
		}
		goto IL_044d;
	}

	private static void RegisterAsUrpOverlay(Camera overlayCamera)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_032c: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_035e: Expected O, but got I4
		//IL_02de: Expected O, but got I4
		//IL_028f: Expected O, but got I
		//IL_029f: Expected O, but got I
		//IL_03ee: Expected O, but got I
		//IL_038e: Expected O, but got I4
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0518: Expected O, but got I
		//IL_0529: Expected I, but got O
		//IL_0547: Expected O, but got I
		//IL_03be: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E4F]");
		object obj3 = (nint)0 & (nint)1;
		Camera camera2;
		Camera camera3;
		if (obj3 != null)
		{
			Camera camera = OnScreenBaseCamera.Resolve();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			camera2 = camera;
			camera3 = camera;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			Camera camera4 = OnScreenBaseCamera.Resolve();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			camera2 = camera4;
			camera3 = camera4;
			if (obj5 != null)
			{
				goto IL_0096;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = camera3 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		camera2 = camera3;
		if (obj6 != null)
		{
			goto IL_00c6;
		}
		goto IL_01ff;
		IL_02c4:
		List<Camera> cameraStack;
		bool flag5 = cameraStack == null;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_03d0;
		IL_03d0:
		Predicate<object> match;
		int num = ((List<object>)(object)cameraStack).RemoveAll(match);
		object obj9 = (nint)0 + (nint)2448;
		if (!((List<object>)(object)cameraStack).Contains((object)overlayCamera))
		{
			int version = cameraStack._version + 1;
			cameraStack._version = version;
			Camera[] items = cameraStack._items;
			bool flag6 = cameraStack._size < items.Length;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				int size = cameraStack._size + 1;
				cameraStack._size = size;
				object obj11 = items + cameraStack._size;
				object obj12 = obj11 + 32;
				obj12 = overlayCamera;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				((List<object>)(object)cameraStack).AddWithResize((object)overlayCamera);
			}
		}
		return;
		IL_00c6:
		string text = overlayCamera.name;
		object obj13 = "WhiteSmoke" + 2760;
		object obj14 = "&action=sign-up" + 1064;
		string obj15 = (string)obj13 + text + (string)obj14;
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v39+E4]");
		if ((nint)0 != 0)
		{
			KLogger.LogError(obj15);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogError(obj15);
		return;
		IL_0096:
		bool flag7 = camera2 == null;
		bool flag8 = !flag7;
		obj7 = 0;
		if (!flag8)
		{
			goto IL_00c6;
		}
		goto IL_01ff;
		IL_01ff:
		UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData(overlayCamera);
		universalAdditionalCameraData.m_CameraType = CameraRenderType.Overlay;
		UniversalAdditionalCameraData universalAdditionalCameraData2 = CameraExtensions.GetUniversalAdditionalCameraData(camera2);
		cameraStack = universalAdditionalCameraData2.cameraStack;
		object obj18 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3232;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v19+E4]");
		object obj20;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v19+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v18+18]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v18+18]");
			if ((nint)0 != 0)
			{
				goto IL_02c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v19+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v18+18]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v18+18]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 != null)
			{
				goto IL_02c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v24+B8]");
			obj20 = 0;
		}
		object obj24 = typeof(List<Tween>) + 3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)1760;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj20, (IntPtr)obj25);
		object obj26 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v23+B8]");
		object obj27 = (nint)0 + (nint)24;
		obj27 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		match = predicate;
		goto IL_03d0;
	}

	private void SyncUrpStackOrder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_00ca: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_0200: Expected O, but got I
		//IL_0254: Expected O, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I
		//IL_0309: Expected I, but got O
		//IL_031a: Expected O, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_05ba: Expected O, but got I
		//IL_05ca: Expected O, but got I
		//IL_05ec: Expected O, but got I4
		//IL_037c: Expected O, but got I
		//IL_038c: Expected O, but got I
		//IL_03ae: Expected O, but got I4
		//IL_061c: Expected O, but got I4
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_07e4: Expected O, but got I
		//IL_07f5: Expected I, but got O
		//IL_0813: Expected O, but got I
		//IL_04d5: Expected O, but got I
		//IL_04ea: Expected O, but got I
		//IL_064c: Expected O, but got I
		//IL_0540: Expected O, but got I4
		//IL_03d1: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_03f1: Expected O, but got I
		//IL_0406: Expected O, but got I4
		//IL_0564: Expected O, but got I
		//IL_0586: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3240;
		List<int> list = (List<int>)(typeof(MemberAchievementClanFeedData) + 2976);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Camera camera = OnScreenBaseCamera.Resolve();
		nint num = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6 (Il2CppClass<System.Collections.Generic.List`1<System.Int32>>)+E4]");
		if ((nint)0 != 0)
		{
			bool flag = camera == null;
			bool flag2 = !flag;
			object obj3 = 0;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = camera == null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			object obj3 = 0;
			if (obj4 != null)
			{
				return;
			}
		}
		UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData(camera);
		object obj5;
		List<int> list2 = default(List<int>);
		IEnumerable<object> source;
		object obj24;
		object obj26;
		Func<object, float> keySelector;
		if ((object)universalAdditionalCameraData != null)
		{
			List<Camera> cameraStack = universalAdditionalCameraData.cameraStack;
			if (obj2 != null)
			{
				obj5 = obj2 + 16;
				obj5 = cameraStack;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = typeof(List<AdaptivePerformanceScaler>) + 1800;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)1312;
				Camera camera2 = (Camera)obj7;
				list2..ctor();
				List<object> list3 = (List<object>)obj5;
				bool flag5 = obj5 == null;
				list = list2;
				if (!flag5)
				{
					object obj8 = (nint)0 + (nint)2512;
					bool flag6 = list2 == null;
					int num2 = 0;
					if (!flag6)
					{
						object obj9 = (nint)0 + (nint)1336;
						int num3 = 0;
						while (num3 < list3._size)
						{
							object obj3 = obj8;
							object obj10 = list3.get_Item(num3);
							bool flag7 = IsBlurLayerCamera((Camera)obj10);
							bool flag8 = !flag7;
							camera2 = (Camera)obj10;
							if (!flag8)
							{
								object obj11 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj12 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+10]");
								bool flag9 = (nint)0 == 0;
								list = list2;
								if (flag9)
								{
									goto IL_0767;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X9_v11+18]");
								bool flag10 = num4 < 0;
								object obj14 = !flag10;
								if (obj14 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v44+20]");
									object obj15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v47+C0]");
									object obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v48+70]");
									obj3 = 0;
									list2.AddWithResize(num3);
									camera2 = (Camera)num3;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj17 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj18 = num5 + 0;
									camera2 = (Camera)obj10;
								}
							}
							num3++;
							list3 = (List<object>)obj5;
							bool flag11 = obj5 == null;
							list = list2;
							if (!flag11)
							{
								continue;
							}
							goto IL_0767;
						}
					}
					else
					{
						while (num2 < list3._size)
						{
							object obj3 = obj8;
							object obj19 = list3.get_Item(num2);
							bool flag12 = IsBlurLayerCamera((Camera)obj19);
							bool flag13 = !flag12;
							object obj20 = !flag13;
							list = list2;
							if (obj20 == null)
							{
								num2++;
								list3 = (List<object>)obj5;
								bool flag14 = obj5 == null;
								camera2 = (Camera)obj19;
								list = list2;
								if (!flag14)
								{
									continue;
								}
							}
							goto IL_0767;
						}
					}
					object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1840;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj22 = (nint)0 + (nint)1776;
					Func<int, object> func = default(Func<int, object>);
					func..ctor(obj2, (IntPtr)obj22);
					object obj23 = (nint)0 + (nint)3440;
					source = Enumerable.Select(list2, func);
					obj24 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3232;
					object obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v39+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v39+B8]");
						obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v30+20]");
						keySelector = (Func<object, float>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v30+20]");
						bool flag15 = (nint)0 == 0;
						object obj27 = !flag15;
						if (obj27 == null)
						{
							goto IL_05fa;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v39+B8]");
						obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v30+20]");
						keySelector = (Func<object, float>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v30+20]");
						bool flag16 = (nint)0 == 0;
						object obj28 = !flag16;
						if (obj28 == null)
						{
							goto IL_05fa;
						}
					}
					goto IL_0651;
				}
			}
		}
		goto IL_0767;
		IL_0767:
		List<int> list4 = list;
		throw new NullReferenceException();
		IL_0651:
		IOrderedEnumerable<object> source2 = Enumerable.OrderBy(source, keySelector);
		List<object> list5 = Enumerable.ToList(source2);
		bool flag17 = list2 == null;
		list = list2;
		if (!flag17)
		{
			if (list5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag18 = (nint)0 >= (nint)1;
				list4 = list2;
				if (!flag18)
				{
					return;
				}
				int num6 = list4.get_Item(0);
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			int num7 = 0;
			while (true)
			{
				int index = list2.get_Item(num7);
				object value = list5.get_Item(num7);
				bool flag19 = obj5 == null;
				list = list2;
				if (flag19)
				{
					break;
				}
				((List<object>)obj5).set_Item(index, value);
				num7++;
				int num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v21 (System.Collections.Generic.List`1<System.Int32>)+18]");
				if ((nint)num8 >= (nint)0)
				{
					return;
				}
			}
		}
		goto IL_0767;
		IL_05fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v39+E4]");
		bool flag20 = (nint)0 == 0;
		object obj29 = !flag20;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj30 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v36+B8]");
			obj26 = 0;
		}
		object obj31 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)1768;
		Func<object, float> func2 = default(Func<object, float>);
		func2..ctor(obj26, (IntPtr)obj32);
		object obj33 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v35+B8]");
		object obj34 = (nint)0 + (nint)32;
		obj34 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func2;
		goto IL_0651;
	}

	private bool IsBlurLayerCamera(Camera camera)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0255: Expected I4, but got O
		//IL_0122: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_02ad: Expected O, but got I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected I4, but got Unknown
		//IL_01d8: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E51]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = camera == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_009f;
		}
		goto IL_0130;
		IL_0255:
		bool result;
		return result;
		IL_0247:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_009f:
		result = false;
		goto IL_0255;
		IL_0074:
		if (camera == null)
		{
			goto IL_009f;
		}
		goto IL_0130;
		IL_0130:
		List<object> blurLayers = (List<object>)(object)_blurLayers;
		if (_blurLayers == null)
		{
			goto IL_0247;
		}
		object obj6 = (nint)0 + (nint)2552;
		int num = 1;
		while (true)
		{
			object obj7 = num - blurLayers._size;
			bool flag4 = (nint)obj7 < 0;
			int num2 = num ^ blurLayers._size;
			int num3 = num ^ obj7;
			int num4 = num2 & num3;
			bool flag5 = num4 < 0;
			bool flag6 = flag4 == flag5;
			bool flag7 = !flag6;
			bool flag8 = num >= blurLayers._size;
			result = flag7;
			if (flag8)
			{
				break;
			}
			object obj8 = blurLayers.get_Item(num);
			if (obj8 != null)
			{
				Camera worldCamera = ((Canvas)obj8).worldCamera;
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v7+E4]");
				bool flag9 = (nint)0 == 0;
				object obj10 = !flag9;
				UnityEngine.Object obj11 = worldCamera;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = worldCamera;
				}
				bool flag10 = obj11 == camera;
				bool flag11 = !flag10;
				object obj12 = !flag11;
				result = flag7;
				if (obj12 != null)
				{
					break;
				}
				num++;
				blurLayers = (List<object>)(object)_blurLayers;
				bool flag12 = _blurLayers == null;
				object obj13 = !flag12;
				if (obj13 != null)
				{
					continue;
				}
			}
			goto IL_0247;
		}
		goto IL_0255;
	}

	private static BlurOptimized GetCameraBlur(Camera camera)
	{
		//IL_0011: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		Behaviour behaviour = default(Behaviour);
		if ((object)camera != null)
		{
			object obj = (nint)0 + (nint)936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
			object obj3 = default(object);
			object obj2 = obj3 & 1;
			bool flag = obj2 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0104;
			}
			GameObject gameObject = camera.gameObject;
			if ((object)gameObject != null)
			{
				object obj5 = (nint)0 + (nint)576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				if ((object)behaviour != null)
				{
					behaviour.enabled = false;
					if ((object)behaviour != null)
					{
						object obj6 = behaviour + 48;
						if (obj6 != null)
						{
							goto IL_0104;
						}
						object obj7 = "HH:mm:ss.ffZ" + 1144;
						Shader shader = Shader.Find((string)obj7);
						obj6 = shader;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return (BlurOptimized)behaviour;
					}
				}
			}
		}
		return (BlurOptimized)(object)new NullReferenceException();
		IL_0104:
		return (BlurOptimized)behaviour;
	}

	private void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_01bd: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3144;
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1456;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = this + 32;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<object> hashSet = default(HashSet<object>);
		hashSet..ctor();
		object obj5 = this + 48;
		obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Transform canvas = CanvasLayerExtensions.GetCanvas(CanvasLayer.SecondaryCanvas);
		object obj6 = (nint)0 + (nint)3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj7 = (nint)0 + (nint)2536;
		object obj8 = obj7;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
		object obj10 = "AvailableVoices" + 2312;
		bool flag = list._size < items.Length;
		object obj11 = !flag;
		object obj14 = default(object);
		if (obj11 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj12 = items + list._size;
			object obj13 = obj12 + 32;
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v8+20]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v10+C0]");
			object obj16 = 0;
			list.AddWithResize(obj14);
		}
		object obj17 = this + 40;
		obj17 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameObject gameObject = default(GameObject);
		gameObject..ctor((string)obj10);
		Transform transform = gameObject.transform;
		object obj18 = this + 56;
		obj18 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Canvas canvas2 = CreateBlurLayer();
		Camera worldCamera = canvas2.worldCamera;
		GameObject gameObject2 = worldCamera.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Clear();
	}

	public BlurLayersManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E54]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1928;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)1928;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
