using Cpp2ILInjected;
using UnityEngine;

public class AutoAssignUICamera : MonoBehaviour
{
	private const string UI_CAMERA_TAG = "UICamera";

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		object obj = (nint)0 + (nint)960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			object tag = "ThisIsFakeReceiptData" + 3744;
			GameObject gameObject = GameObject.FindGameObjectWithTag((string)tag);
			object obj3 = (nint)0 + (nint)1136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			Canvas canvas = default(Canvas);
			Camera worldCamera = default(Camera);
			canvas.worldCamera = worldCamera;
		}
	}
}
