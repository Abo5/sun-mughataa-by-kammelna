using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Spine;
using UnityEngine;

public class SlideShowFriendPage : SlideShowCommonsPage
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Transform> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SetHidden>b__3_0(Transform t)
		{
			//IL_0013: Expected O, but got I4
			t.localScale = (Vector3)0;
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public DG.Tweening.Sequence seq;

		internal void <AnimateShowElements>b__0(Transform b)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2904;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(b, 1f, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t = default(Tween);
			DG.Tweening.Sequence sequence = TweenSettingsExtensions.Append(seq, t);
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public DG.Tweening.Sequence seq;

		internal void <AnimateHideElements>b__0(Transform b)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2904;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(b, 0f, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t = default(Tween);
			DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(seq, t);
		}
	}

	private Transform[] bubbles;

	protected override Tween AnimateShowElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00c3: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 264;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		if (obj3 != null)
		{
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
			object obj7 = (nint)0 + (nint)3936;
			object obj8 = obj3 + 16;
			obj8 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj3, (IntPtr)obj7);
			ArraysExtensions.ForEach(bubbles, action);
			return (Tween)obj8;
		}
		return (Tween)(object)new NullReferenceException();
	}

	protected override Tween AnimateHideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00c3: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 272;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		if (obj3 != null)
		{
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
			object obj7 = (nint)0 + (nint)3944;
			object obj8 = obj3 + 16;
			obj8 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj3, (IntPtr)obj7);
			ArraysExtensions.ForEach(bubbles, action);
			return (Tween)obj8;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public override void SetHidden()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0196: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_028d: Expected O, but got I
		//IL_029e: Expected I, but got O
		//IL_02bc: Expected O, but got I
		//IL_0250: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69A6]");
		object obj3 = (nint)0 & (nint)1;
		Transform[] array;
		Transform[] array2;
		object obj4;
		if (obj3 != null)
		{
			base.SetHidden();
			array = bubbles;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			array2 = bubbles;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			base.SetHidden();
			array = bubbles;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			array2 = bubbles;
			if (obj6 != null)
			{
				goto IL_009f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = array2;
		object obj10 = obj7;
		IEnumerable<object> enumeration = array2;
		if (obj9 == null)
		{
			goto IL_01fe;
		}
		goto IL_0255;
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3928;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		action = action2;
		enumeration = enumerable;
		goto IL_0255;
		IL_0255:
		ArraysExtensions.ForEach(enumeration, action);
		return;
		IL_009f:
		obj10 = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		enumeration = array;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable = array;
			goto IL_01fe;
		}
		goto IL_0255;
	}
}
