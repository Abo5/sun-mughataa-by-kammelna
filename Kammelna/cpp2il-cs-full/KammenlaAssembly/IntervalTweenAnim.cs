using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

public class IntervalTweenAnim : TweenAnim
{
	public override GameObject target => null;

	public override Tween tween
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0078: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence s = DOTween.Sequence();
			return TweenSettingsExtensions.AppendInterval(s, Duration);
		}
	}
}
