using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class AlphaButton : MonoBehaviour
{
	private float threshold = 0.5f;

	private Image image;

	private void OnEnable()
	{
		//IL_000c: Expected O, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 40;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Image)obj2).alphaHitTestMinimumThreshold = threshold;
	}

	private void OnDisable()
	{
		//IL_000c: Expected O, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 40;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Image)obj2).alphaHitTestMinimumThreshold = 0f;
	}
}
