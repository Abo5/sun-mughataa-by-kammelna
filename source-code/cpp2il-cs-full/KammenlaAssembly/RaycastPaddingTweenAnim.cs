using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class RaycastPaddingTweenAnim : GraphicTweenAnim
{
	private Vector4 finalValue;

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
			//IL_00ea: Expected O, but got I
			//IL_0102: Expected I, but got O
			//IL_0067: Expected I, but got O
			//IL_0091: Expected O, but got I4
			//IL_00c6: Expected F4, but got O
			//IL_00c6: Expected O, but got I4
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 88;
			object obj2 = (nint)0 + (nint)1552;
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 168;
			object obj4 = (nint)0 + (nint)1560;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj6 = (nint)0 + (nint)3248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector4> dOGetter = default(DOGetter<Vector4>);
			dOGetter..ctor((object)this, (IntPtr)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector4> dOSetter = default(DOSetter<Vector4>);
			dOSetter..ctor((object)this, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TweenerCore<Vector4, Vector4, VectorOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, (Vector4)0, (float)finalValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
	}

	private Vector4 <get_tween>b__2_0()
	{
		if ((object)_graphic != null)
		{
			return (Vector4)this;
		}
		return (Vector4)new NullReferenceException();
	}

	private void <get_tween>b__2_1(Vector4 value)
	{
		Graphic graphic = _graphic;
		Vector4 raycastPadding = default(Vector4);
		graphic.m_RaycastPadding = raycastPadding;
	}
}
