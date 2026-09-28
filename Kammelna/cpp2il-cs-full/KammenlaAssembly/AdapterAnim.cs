using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

public class AdapterAnim : TweenAnimBase
{
	private Tween _tween;

	public override GameObject target => null;

	public override Tween tween => _tween;

	public AdapterAnim(Tween t)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
