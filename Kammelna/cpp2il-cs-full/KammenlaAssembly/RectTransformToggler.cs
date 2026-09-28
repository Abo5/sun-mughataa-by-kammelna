using Cpp2ILInjected;
using UnityEngine;

public class RectTransformToggler : BaseToggler
{
	private RectTransform _rectTransform;

	private bool togglePosition;

	private Vector3 newPosition;

	private bool toggleSize;

	private Vector2 newSize;

	private bool togglePivot;

	private Vector2 newPivot;

	private bool toggleRotation;

	private Vector3 newRotation;

	private bool toggleScale;

	private Vector3 newScale;

	private Vector3 originalPosition;

	private Vector2 originalSize;

	private Vector2 originalPivot;

	private Vector3 originalRotation;

	private Vector3 originalScale;

	private void Awake()
	{
		Vector2 anchoredPosition = _rectTransform.anchoredPosition;
		Vector3 vector = default(Vector3);
		originalPosition = vector;
		_ = 0;
		Vector3 localEulerAngles = _rectTransform.localEulerAngles;
		originalRotation = vector;
		Vector2 sizeDelta = _rectTransform.sizeDelta;
		originalSize = vector;
		Vector3 localScale = _rectTransform.localScale;
		originalScale = vector;
		Vector2 pivot = _rectTransform.pivot;
		originalPivot = vector;
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 48;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void ToggleOn()
	{
		//IL_0032: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		if (togglePosition)
		{
			_rectTransform.anchoredPosition = (Vector2)0;
		}
		if (toggleRotation)
		{
			_rectTransform.localEulerAngles = (Vector3)0;
		}
		if (toggleScale)
		{
			_rectTransform.localScale = (Vector3)0;
		}
		if (toggleSize)
		{
			_rectTransform.sizeDelta = (Vector2)0;
		}
		if (togglePivot)
		{
			_rectTransform.pivot = (Vector2)0;
		}
	}

	protected override void ToggleOff()
	{
		//IL_0032: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		if (togglePosition)
		{
			_rectTransform.anchoredPosition = (Vector2)0;
		}
		if (toggleRotation)
		{
			_rectTransform.localEulerAngles = (Vector3)0;
		}
		if (toggleScale)
		{
			_rectTransform.localScale = (Vector3)0;
		}
		if (toggleSize)
		{
			_rectTransform.sizeDelta = (Vector2)0;
		}
		if (togglePivot)
		{
			_rectTransform.pivot = (Vector2)0;
		}
	}
}
