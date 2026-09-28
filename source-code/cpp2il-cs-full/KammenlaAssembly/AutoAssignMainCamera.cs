using Cpp2ILInjected;
using UnityEngine;

public class AutoAssignMainCamera : MonoBehaviour
{
	private void Awake()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Camera main = Camera.main;
			Canvas canvas = default(Canvas);
			canvas.worldCamera = main;
		}
	}
}
