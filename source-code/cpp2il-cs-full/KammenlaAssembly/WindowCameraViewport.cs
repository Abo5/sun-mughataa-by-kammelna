using System.Buffers.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Device;

public class WindowCameraViewport : MonoBehaviour
{
	private Camera _gameCamera;

	private const float widthRatio = 13f / 15f;

	private const float posRatio = 0.21302083f;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateCameraViewport();
	}

	private void UpdateCameraViewport()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		int width = UnityEngine.Device.Screen.width;
		int height = UnityEngine.Device.Screen.height;
		int width2 = UnityEngine.Device.Screen.width;
		int height2 = UnityEngine.Device.Screen.height;
		int width3 = UnityEngine.Device.Screen.width;
		int height3 = UnityEngine.Device.Screen.height;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = width / height;
		if (num < 1068149419)
		{
		}
		_gameCamera.pixelRect = (Rect)0;
	}

	private void Update()
	{
		UpdateCameraViewport();
	}
}
