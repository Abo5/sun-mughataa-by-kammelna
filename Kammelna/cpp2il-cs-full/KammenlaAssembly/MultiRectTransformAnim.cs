using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class MultiRectTransformAnim : TweenAnimBase
{
	private RectTransform[] _transforms;

	private RectTweenAnim animation;

	public override GameObject target => null;

	public override Tween tween
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e6: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			//IL_016b: Expected O, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			//IL_01f8: Expected O, but got I
			//IL_0259: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_01ab: Expected O, but got I4
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Expected O, but got Unknown
			//IL_029f: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F82]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Sequence sequence = DOTween.Sequence();
			RectTransform[] transforms = _transforms;
			if (_transforms != null)
			{
				goto IL_0135;
			}
			goto IL_02b2;
			IL_02ad:
			return sequence;
			IL_02b2:
			return (Tween)(object)new NullReferenceException();
			IL_0135:
			if (transforms.Length < 1)
			{
				goto IL_02ad;
			}
			object obj5 = transforms + 32;
			object obj6 = 0;
			while (animation != null)
			{
				object obj7 = animation + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X23_v4+v98 @ X22_v5*8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				RectTweenAnim rectTweenAnim = animation;
				if (animation == null)
				{
					break;
				}
				Tween getTween = animation.GetTween;
				bool flag2 = rectTweenAnim.Insertion == InsertionType.Append;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					Sequence sequence2 = TweenSettingsExtensions.Join(sequence, getTween);
					obj6++;
					bool flag3 = (nint)obj6 >= transforms.Length;
					object obj9 = 0;
					if (!flag3)
					{
						continue;
					}
				}
				else
				{
					Sequence sequence3 = TweenSettingsExtensions.Append(sequence, getTween);
					obj6++;
					bool flag4 = (nint)obj6 < transforms.Length;
					object obj9 = 0;
					if (flag4)
					{
						continue;
					}
				}
				goto IL_02ad;
			}
			goto IL_02b2;
			IL_0074:
			sequence = DOTween.Sequence();
			transforms = _transforms;
			bool flag5 = _transforms == null;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_0135;
			}
			goto IL_02b2;
		}
	}
}
