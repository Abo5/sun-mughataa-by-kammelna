using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class RectAnchoredPosBySizeTweenAnim : RectTweenAnim
{
	private Vector2 sizeMultiplier;

	private Vector2 flatOffset;

	public override Tween tween
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_0031: Expected O, but got I
			//IL_006a: Expected O, but got I4
			//IL_00f2: Expected O, but got I4
			if ((object)_rectTransform != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj2 = (nint)0 + (nint)3088;
				object obj3 = (nint)0 + (nint)2872;
				Rect rect = _rectTransform.rect;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj7 = default(object);
				object obj6 = obj7 * (object)sizeMultiplier;
				float duration = (float)obj6 + (float)flatOffset;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(_rectTransform, (Vector2)0, duration);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059474");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Tween result = default(Tween);
				return result;
			}
			return (Tween)(object)new NullReferenceException();
		}
	}
}
