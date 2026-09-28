using Cpp2ILInjected;
using UnityEngine;

public class ScrollFromDownShowEffect : MonoBehaviour
{
	private void OnEnable()
	{
		//IL_0006: Expected O, but got I
		//IL_001c: Expected O, but got I
		//IL_0040: Expected O, but got I4
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+20]");
		Transform transform = ((Component)0).transform;
		Vector3 position = transform.position;
		transform.position = (Vector3)0;
	}
}
