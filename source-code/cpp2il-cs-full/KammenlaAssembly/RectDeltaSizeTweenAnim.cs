using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class RectDeltaSizeTweenAnim : RectTweenAnim
{
	private Vector2 finalValue;

	public override Tween tween
	{
		get
		{
			//IL_000c: Expected O, but got I
			//IL_002c: Expected F4, but got O
			//IL_002c: Expected O, but got I4
			object obj = (nint)0 + (nint)2872;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(_rectTransform, (Vector2)0, (float)finalValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween result = default(Tween);
			return result;
		}
	}
}
