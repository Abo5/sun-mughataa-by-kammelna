using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class WinPopupAnimations : MonoBehaviour
{
	private RectTransform stars;

	private RectTransform congrats;

	private void OnEnable()
	{
		ResetState();
	}

	public void Play()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2904;
		ResetState();
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(stars, 1f, 0.7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(congrats, 1f, 0.7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void ResetState()
	{
		//IL_0015: Expected O, but got I4
		//IL_002a: Expected O, but got I4
		congrats.localScale = (Vector3)0;
		stars.localScale = (Vector3)0;
	}
}
