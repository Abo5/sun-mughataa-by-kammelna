using System;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

[Serializable]
public abstract class TweenAnim : TweenAnimBase
{
	public float Duration;

	public Ease ease;

	public AnimationCurve curve;

	public bool InheritTiming;

	private bool UseCurve
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = ease - 37;
			return obj == null;
		}
	}

	private bool ShowOwnTiming
	{
		get
		{
			if (Insertion == InsertionType.Join)
			{
				return !InheritTiming;
			}
			return true;
		}
	}

	private bool ShowOwnCurve
	{
		get
		{
			if (ease == Ease.INTERNAL_Custom)
			{
				if (Insertion == InsertionType.Join)
				{
					return !InheritTiming;
				}
				return true;
			}
			return false;
		}
	}

	public override Tween GetTween
	{
		get
		{
			//IL_002c: Expected O, but got I
			//IL_0011: Expected O, but got I
			Tween tween = base.tween;
			if (ease == Ease.INTERNAL_Custom)
			{
				object obj = (nint)0 + (nint)2920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				Tween result = default(Tween);
				return result;
			}
			object obj2 = (nint)0 + (nint)2928;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween result2 = default(Tween);
			return result2;
		}
	}
}
