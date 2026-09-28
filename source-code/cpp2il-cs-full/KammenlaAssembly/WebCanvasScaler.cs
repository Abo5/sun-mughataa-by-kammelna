using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UI;

public class WebCanvasScaler : MonoBehaviour
{
	private void Awake()
	{
		//IL_0011: Expected O, but got I
		//IL_002e: Expected O, but got I4
		RuntimePlatform platform = UnityEngine.Device.Application.platform;
		if (platform == RuntimePlatform.WebGLPlayer)
		{
			object obj = (nint)0 + (nint)3680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			CanvasScaler canvasScaler = default(CanvasScaler);
			canvasScaler.referenceResolution = (Vector2)0;
		}
	}
}
