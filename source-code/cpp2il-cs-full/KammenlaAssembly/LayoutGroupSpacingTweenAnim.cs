using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine.UI;

[Serializable]
public class LayoutGroupSpacingTweenAnim : LayoutGroupTweenAnim
{
	private float finalValue;

	public override Tween tween
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0040: Expected O, but got I
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_00eb: Expected O, but got I
			//IL_0103: Expected I, but got O
			//IL_0067: Expected I, but got O
			//IL_0091: Expected O, but got I4
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
			object obj2 = (nint)0 + (nint)328;
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
			object obj4 = (nint)0 + (nint)336;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj6 = (nint)0 + (nint)3200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<float> dOGetter = default(DOGetter<float>);
			dOGetter..ctor((object)this, (IntPtr)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<float> dOSetter = default(DOSetter<float>);
			dOSetter..ctor((object)this, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, finalValue, Duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
	}

	private float <get_tween>b__2_0()
	{
		HorizontalOrVerticalLayoutGroup layoutGroup = _layoutGroup;
		return layoutGroup.m_Spacing;
	}

	private void <get_tween>b__2_1(float value)
	{
		_layoutGroup.spacing = value;
	}
}
