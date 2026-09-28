using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class CameraOverlayAddToStack : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<Camera> <>9__7_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <AddToMainCameraStack>b__7_0(Camera cam)
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
	}

	private bool _insertAtStackStart;

	private Camera _camera;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 40;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AddToMainCameraStack();
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)2896;
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
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)2896;
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

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73F0]");
		object obj2 = (nint)0 & (nint)1;
		Camera main;
		UnityEngine.Object obj4;
		if (obj2 != null)
		{
			main = Camera.main;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			obj4 = main;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			main = Camera.main;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj4 = main;
			if (obj5 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = main == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0145;
		IL_0145:
		Camera main2 = Camera.main;
		UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData(main2);
		List<Camera> cameraStack = universalAdditionalCameraData.cameraStack;
		bool flag5 = ((List<object>)(object)cameraStack).Remove((object)_camera);
		return;
		IL_0085:
		if (obj4 == null)
		{
			return;
		}
		goto IL_0145;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		AddToMainCameraStack();
	}

	private void AddToMainCameraStack()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0170: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		//IL_02db: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_030d: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_0257: Expected O, but got I
		//IL_0267: Expected O, but got I
		//IL_033d: Expected O, but got I4
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I
		//IL_050b: Expected I, but got O
		//IL_0529: Expected O, but got I
		//IL_036d: Expected O, but got I
		//IL_0454: Expected O, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73F1]");
		object obj2 = (nint)0 & (nint)1;
		Camera main;
		UnityEngine.Object obj4;
		if (obj2 != null)
		{
			main = Camera.main;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v32+E4]");
			bool flag = (nint)0 == 0;
			obj4 = main;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			main = Camera.main;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj4 = main;
			if (obj5 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = main == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		object obj9 = 0;
		if (obj6 != null)
		{
			goto IL_00c3;
		}
		goto IL_01de;
		IL_028c:
		List<Camera> cameraStack;
		bool flag5 = cameraStack == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_037f;
		IL_037f:
		Predicate<object> match;
		int num = ((List<object>)(object)cameraStack).RemoveAll(match);
		if (((List<object>)(object)cameraStack).Contains((object)_camera))
		{
			return;
		}
		if (_insertAtStackStart)
		{
			((List<object>)(object)cameraStack).Insert(0, (object)_camera);
			return;
		}
		int version = cameraStack._version + 1;
		cameraStack._version = version;
		Camera[] items = cameraStack._items;
		bool flag6 = cameraStack._size < items.Length;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			int size = cameraStack._size + 1;
			cameraStack._size = size;
			object obj12 = items + cameraStack._size;
			object obj13 = obj12 + 32;
			obj13 = _camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			((List<object>)(object)cameraStack).AddWithResize((object)_camera);
		}
		return;
		IL_00c3:
		object obj14 = typeof(DataRelation) + 856;
		object message = "WhiteSmoke" + 2816;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v68+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogError(message);
		return;
		IL_0085:
		bool flag8 = obj4 == null;
		bool flag9 = !flag8;
		obj7 = 0;
		obj8 = null;
		obj9 = 0;
		if (!flag9)
		{
			goto IL_00c3;
		}
		goto IL_01de;
		IL_01de:
		Camera main2 = Camera.main;
		UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData(main2);
		cameraStack = universalAdditionalCameraData.cameraStack;
		object obj17 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3744;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v19+E4]");
		object obj19;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v19+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v21+8]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v21+8]");
			if ((nint)0 != 0)
			{
				goto IL_028c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v19+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v21+8]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v21+8]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 != null)
			{
				goto IL_028c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v19+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v27+B8]");
			obj19 = 0;
		}
		object obj23 = typeof(List<Tween>) + 3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)2224;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj19, (IntPtr)obj24);
		object obj25 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v26+B8]");
		object obj26 = (nint)0 + (nint)8;
		obj26 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		match = predicate;
		goto IL_037f;
	}
}
