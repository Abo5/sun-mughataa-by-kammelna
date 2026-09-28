using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class SlideShowRoomPage : SlideShowCommonsPage
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Transform> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <HideElements>b__6_0(Transform t)
		{
			//IL_0013: Expected O, but got I4
			t.localEulerAngles = (Vector3)0;
		}
	}

	private Transform chair;

	private RectTransform crown;

	private Vector2 _crownPosition;

	protected override Tween AnimateShowElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0134: Expected F4, but got O
		//IL_0134: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_017f: Expected F4, but got O
		//IL_017f: Expected O, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_0085: Expected O, but got I4
		//IL_00a2: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		HideElements();
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+B8]");
		object obj6 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(chair, (Vector3)0, (float)obj6);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v12+B8]");
		object obj8 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(crown, (Vector3)0, (float)obj8);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
		if ((object)crown != null)
		{
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj10 = (nint)0 + (nint)896;
			crown.anchoredPosition = (Vector2)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj10);
			DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
			return sequence;
		}
		return (Tween)(object)new NullReferenceException();
	}

	protected override Tween AnimateHideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_0111: Expected O, but got I
		//IL_0142: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		int num = ShortcutExtensions.DOKill(crown, complete: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence sequence = DOTween.Sequence();
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+48]");
		float duration = 0f * 0f;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(chair, (Vector3)0, duration);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Join(sequence, t);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+48]");
		float duration2 = 0f * 0f;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(crown, (Vector3)0, duration2);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
		return sequence;
	}

	public override void SetHidden()
	{
		base.SetHidden();
		Vector2 anchoredPosition = crown.anchoredPosition;
		Vector2 crownPosition = default(Vector2);
		_crownPosition = crownPosition;
		HideElements();
	}

	private void HideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0169: Expected O, but got I8
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_0280: Expected O, but got I
		//IL_0290: Expected O, but got I
		//IL_02a0: Expected O, but got I
		//IL_02c2: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03d0: Expected O, but got I
		//IL_03e1: Expected I, but got O
		//IL_03ff: Expected O, but got I
		//IL_025d: Expected O, but got I
		//IL_033a: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = (object)chair == null;
		Transform transform = (Transform)2;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Transform transform2;
		if (!flag)
		{
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			transform = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			transform2 = (Transform)0;
			if (flag2)
			{
				goto IL_036a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj4;
		object obj8;
		Action<object> action;
		object obj10;
		object obj7;
		if ((nint)0 != 0)
		{
			object obj2 = enumerable + 32;
			obj2 = chair;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = (object)crown == null;
			transform = chair;
			if (!flag3)
			{
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				transform = (Transform)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				transform2 = (Transform)0;
				if (flag4)
				{
					goto IL_036a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				obj4 = typeof(SkeletonBinary.SkeletonInput) + 304;
				object obj5 = enumerable + 40;
				obj5 = crown;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v22+E4]");
				if ((nint)0 != 0)
				{
					obj7 = (nint)0 + (nint)2400;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v22+B8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+8]");
					action = (Action<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+8]");
					bool flag5 = (nint)0 == 0;
					object obj9 = !flag5;
					if (obj9 == null)
					{
						obj10 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+8]");
						Action<object> action2 = (Action<object>)0;
						goto IL_02e8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj4;
					obj10 = (nint)0 + (nint)2400;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v22+B8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+8]");
					Action<object> action2 = (Action<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+8]");
					bool flag6 = (nint)0 == 0;
					object obj11 = !flag6;
					obj7 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+8]");
					action = (Action<object>)0;
					if (obj11 == null)
					{
						goto IL_02e8;
					}
				}
				goto IL_0398;
			}
		}
		ex = new IndexOutOfRangeException();
		transform2 = transform;
		goto IL_036a;
		IL_0398:
		ArraysExtensions.ForEach(enumerable, action);
		return;
		IL_02e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3976;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v18+B8]");
		object obj17 = (nint)0 + (nint)8;
		obj17 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj7 = obj10;
		action = action3;
		goto IL_0398;
		IL_036a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
	}

	private void <AnimateShowElements>b__3_0()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0080: Expected O, but got I4
		object obj = (nint)0 + (nint)3088;
		object obj2 = (nint)0 + (nint)3048;
		object obj3 = typeof(UsageHint) + 744;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+10]");
		float duration = 0f * 0f;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(crown, (Vector2)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059474");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
	}
}
