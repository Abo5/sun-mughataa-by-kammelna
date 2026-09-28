using System;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class PunchRotationAnim : PunchTransformAnim
{
	public override Tween tween
	{
		get
		{
			//IL_0028: Expected F4, but got I
			//IL_0028: Expected F4, but got O
			//IL_0028: Expected O, but got I4
			Transform transform = _transform;
			int vibrato = Vibrato;
			Vector3 changeValue = _changeValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PunchRotationAnim)+3C]");
			return ShortcutExtensions.DOPunchRotation(transform, (Vector3)vibrato, (float)changeValue, 0, 0f);
		}
	}

	public PunchRotationAnim()
	{
		//IL_000f: Expected I4, but got I8
		Vibrato = 10;
		((object)this)..ctor();
	}
}
