using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class LayoutGroupPaddingTweenAnim : LayoutGroupTweenAnim
{
	private sealed class <>c__DisplayClass2_0
	{
		public RectOffset p;

		public LayoutGroupPaddingTweenAnim <>4__this;

		internal Vector4 <get_tween>b__0()
		{
			//IL_00b8: Expected O, but got I4
			if (p != null)
			{
				int left = p.left;
				if (p != null)
				{
					int right = p.right;
					if (p != null)
					{
						int top = p.top;
						if (p != null)
						{
							return (Vector4)p.bottom;
						}
					}
				}
			}
			return (Vector4)new NullReferenceException();
		}

		internal void <get_tween>b__1(Vector4 value)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0050: Expected I4, but got I8
			//IL_006f: Expected I4, but got I8
			//IL_008e: Expected I4, but got I8
			//IL_00ad: Expected I4, but got I8
			LayoutGroupPaddingTweenAnim layoutGroupPaddingTweenAnim = <>4__this;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			int num = default(int);
			int left = (int)((num != 2139095040) ? num : 2147483648L);
			int num2 = default(int);
			int right = (int)((num2 != 2139095040) ? num2 : 2147483648L);
			int num3 = default(int);
			int top = (int)((num3 != 2139095040) ? num3 : 2147483648L);
			int num4 = default(int);
			int bottom = (int)((num4 != 2139095040) ? num4 : 2147483648L);
			RectOffset rectOffset = default(RectOffset);
			rectOffset..ctor(left, right, top, bottom);
			layoutGroupPaddingTweenAnim._layoutGroup.padding = rectOffset;
		}
	}

	private RectOffset finalValue;

	public override Tween tween
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_007f: Expected O, but got I
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009f: Expected O, but got I
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00e4: Expected I, but got O
			//IL_0104: Expected I, but got O
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01cd: Expected O, but got I
			//IL_0206: Expected O, but got I4
			//IL_0277: Expected F4, but got I4
			//IL_0277: Expected O, but got I4
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = obj2 + 24;
				obj3 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				HorizontalOrVerticalLayoutGroup layoutGroup = _layoutGroup;
				if ((object)_layoutGroup != null)
				{
					object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 88;
					object obj5 = (nint)0 + (nint)3552;
					object obj6 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 168;
					object obj7 = (nint)0 + (nint)3560;
					object obj8 = obj2 + 16;
					obj8 = ((LayoutGroup)layoutGroup).m_Padding;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					DOGetter<Vector4> dOGetter = default(DOGetter<Vector4>);
					dOGetter..ctor(obj2, (IntPtr)obj5);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					DOSetter<Vector4> dOSetter = default(DOSetter<Vector4>);
					dOSetter..ctor(obj2, (IntPtr)obj7);
					if (finalValue != null)
					{
						int left = finalValue.left;
						if (finalValue != null)
						{
							int right = finalValue.right;
							if (finalValue != null)
							{
								int top = finalValue.top;
								if (finalValue != null)
								{
									object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
									object obj10 = (nint)0 + (nint)3248;
									int bottom = finalValue.bottom;
									object obj11 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v5+E4]");
									bool flag = (nint)0 == 0;
									object obj12 = !flag;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									TweenerCore<Vector4, Vector4, VectorOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, (Vector4)0, left);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
									Tween result = default(Tween);
									return result;
								}
							}
						}
					}
				}
			}
			return (Tween)(object)new NullReferenceException();
		}
	}
}
