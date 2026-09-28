using System;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CanvasFollowMainCamera : MonoBehaviour
{
	private const string UICameraTag = "UICamera";

	private Canvas _canvas;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		//IL_00c3: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		object obj = (nint)0 + (nint)3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = 152989696;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F8]");
		object obj6 = (nint)0 & (nint)1;
		Camera camera2;
		Camera camera3;
		if (obj6 != null)
		{
			Camera camera = FindCameraRenderingCanvasLayer();
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			camera2 = camera;
			camera3 = camera;
			if (!flag)
			{
				goto IL_0058;
			}
		}
		else
		{
			_ = 1;
			Camera camera4 = FindCameraRenderingCanvasLayer();
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			camera2 = camera4;
			camera3 = camera4;
			if (obj8 != null)
			{
				goto IL_0058;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = camera3 == null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		camera2 = camera3;
		if (obj9 != null)
		{
			return;
		}
		goto IL_012e;
		IL_012e:
		((Canvas)obj2).worldCamera = camera2;
		return;
		IL_0058:
		if (camera2 == null)
		{
			return;
		}
		goto IL_012e;
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
		object obj2 = (nint)0 + (nint)3056;
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
		object obj2 = (nint)0 + (nint)3056;
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

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F8]");
		object obj3 = (nint)0 & (nint)1;
		Camera camera2;
		Camera camera3;
		if (obj3 != null)
		{
			Camera camera = FindCameraRenderingCanvasLayer();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			camera2 = camera;
			camera3 = camera;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			Camera camera4 = FindCameraRenderingCanvasLayer();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			camera2 = camera4;
			camera3 = camera4;
			if (obj5 != null)
			{
				goto IL_0097;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = camera3 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		camera2 = camera3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_016d;
		IL_016d:
		_canvas.worldCamera = camera2;
		return;
		IL_0097:
		if (camera2 == null)
		{
			return;
		}
		goto IL_016d;
	}

	private void AssignRenderCamera()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F8]");
		object obj3 = (nint)0 & (nint)1;
		Camera camera2;
		Camera camera3;
		if (obj3 != null)
		{
			Camera camera = FindCameraRenderingCanvasLayer();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			camera2 = camera;
			camera3 = camera;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			Camera camera4 = FindCameraRenderingCanvasLayer();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			camera2 = camera4;
			camera3 = camera4;
			if (obj5 != null)
			{
				goto IL_0097;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = camera3 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		camera2 = camera3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_016d;
		IL_016d:
		_canvas.worldCamera = camera2;
		return;
		IL_0097:
		if (camera2 == null)
		{
			return;
		}
		goto IL_016d;
	}

	private Camera FindCameraRenderingCanvasLayer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_024e: Expected O, but got I
		GameObject gameObject = base.gameObject;
		object obj;
		int layer;
		Camera main;
		object obj4;
		if ((object)gameObject != null)
		{
			obj = typeof(MemberAchievementClanFeedData) + 2976;
			layer = gameObject.layer;
			main = Camera.main;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				bool flag = main != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				obj4 = 0;
				if (obj3 != null)
				{
					goto IL_00f2;
				}
				object obj5 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = main != null;
				bool flag4 = !flag3;
				obj4 = 0;
				object obj5 = 0;
				if (!flag4)
				{
					goto IL_00f2;
				}
			}
			goto IL_0167;
		}
		goto IL_025d;
		IL_025d:
		return (Camera)(object)new NullReferenceException();
		IL_0167:
		object tag = "ThisIsFakeReceiptData" + 3744;
		GameObject gameObject2 = GameObject.FindGameObjectWithTag((string)tag);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			if (gameObject2 == null)
			{
				goto IL_01db;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = gameObject2 == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 != null)
			{
				goto IL_01db;
			}
		}
		if ((object)gameObject2 != null)
		{
			object obj8 = (nint)0 + (nint)1136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			Camera result = default(Camera);
			return result;
		}
		goto IL_025d;
		IL_01db:
		return main;
		IL_00f2:
		if ((object)main != null)
		{
			int num = 1 << layer;
			int cullingMask = main.cullingMask;
			int num2 = cullingMask & num;
			bool flag7 = num2 == 0;
			object obj9 = !flag7;
			object obj5 = obj4;
			if (obj9 == null)
			{
				goto IL_0167;
			}
			goto IL_01db;
		}
		goto IL_025d;
	}
}
