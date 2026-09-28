using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;

public class PinchZoomable : MonoBehaviour
{
	private float minScale;

	private float maxScale;

	private Transform targetTransform;

	private ScrollHandler scrollHandler;

	private void Start()
	{
		//IL_0010: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_005b: Expected I, but got O
		//IL_0089: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_017f: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01a5: Expected I, but got O
		//IL_01d3: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0124: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AC8]");
		Delegate obj = (Delegate)0;
		ScrollHandler scrollHandler = this.scrollHandler;
		ScrollHandler scrollHandler2;
		object obj10;
		object obj11;
		if ((object)this.scrollHandler != null)
		{
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3016;
			object obj3 = (nint)0 + (nint)3488;
			scrollHandler = (ScrollHandler)(scrollHandler + 40);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			Delegate obj4 = Delegate.Combine((Delegate)(object)scrollHandler, action);
			bool flag = (object)obj4 == null;
			object obj5 = 0;
			object obj6 = 0;
			object obj9;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				object obj7 = default(object);
				if (obj7 != null)
				{
					scrollHandler = (ScrollHandler)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					object obj8 = default(object);
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						scrollHandler2 = this.scrollHandler;
						bool flag2 = (object)this.scrollHandler == null;
						obj5 = 0;
						obj9 = obj8;
						obj6 = 0;
						obj10 = 0;
						obj11 = 0;
						scrollHandler = this.scrollHandler;
						if (!flag2)
						{
							goto IL_015f;
						}
						goto IL_02de;
					}
				}
				throw new InvalidCastException();
			}
			scrollHandler = (ScrollHandler)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			scrollHandler2 = this.scrollHandler;
			bool flag3 = (object)this.scrollHandler == null;
			object obj12 = !flag3;
			obj9 = 0;
			obj10 = obj5;
			obj11 = obj6;
			scrollHandler = this.scrollHandler;
			if (obj12 != null)
			{
				goto IL_015f;
			}
		}
		goto IL_02de;
		IL_015f:
		object obj13 = typeof(SqlSingle[]) + 2376;
		object obj14 = (nint)0 + (nint)3480;
		scrollHandler = (ScrollHandler)(scrollHandler2 + 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj14);
		Delegate obj15 = Delegate.Combine((Delegate)(object)scrollHandler, action2);
		bool flag4 = (object)obj15 == null;
		obj10 = 0;
		obj11 = 0;
		obj = obj15;
		if (!flag4)
		{
			if (obj15 == obj13)
			{
				scrollHandler = (ScrollHandler)(object)obj15;
				bool flag5 = obj15 == obj13;
				obj10 = 0;
				obj11 = 0;
				obj = obj15;
				if (flag5)
				{
					goto IL_0327;
				}
			}
			object obj5 = 0;
			object obj6 = 0;
			obj = obj15;
			throw new InvalidCastException();
		}
		scrollHandler = (ScrollHandler)0;
		goto IL_0327;
		IL_0327:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_02de:
		throw new NullReferenceException();
	}

	public void OnPinch(PinchGesture pinchGesture)
	{
		//IL_0069: Invalid comparison between F4 and I4
		//IL_0078: Invalid comparison between F4 and I4
		//IL_008b: Expected O, but got F4
		//IL_0098: Expected O, but got F4
		//IL_00cd: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		Vector3 localScale = targetTransform.localScale;
		object obj = default(object);
		float num = (float)obj * pinchGesture.DeltaScale;
		double num2 = (double)minScale * 0.5;
		float num3 = maxScale + maxScale;
		float num4 = num - num3;
		bool flag = num4 < 0f;
		bool flag2 = num4 == 0f;
		object obj2 = num ^ num3;
		object obj3 = num ^ num4;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		if ((double)num < num2)
		{
		}
		targetTransform.localScale = (Vector3)0;
	}

	public void OnPinchEnd(PinchGesture pinchGesture)
	{
		//IL_0033: Invalid comparison between F4 and I4
		//IL_0042: Invalid comparison between F4 and I4
		//IL_0057: Expected O, but got F4
		//IL_0064: Expected O, but got F4
		//IL_0099: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		Vector3 localScale = targetTransform.localScale;
		float num = maxScale;
		float num3 = default(float);
		float num2 = num3 - maxScale;
		bool flag = num2 < 0f;
		bool flag2 = num2 == 0f;
		object obj = num3 ^ maxScale;
		object obj2 = num3 ^ num2;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num = num3;
		}
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(endValue: (!(num3 < minScale)) ? num : minScale, target: targetTransform, duration: 0.2f);
	}

	private void OnScrollWheel(PointerEventData ped)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ped @ X1 (UnityEngine.EventSystems.PointerEventData)+180]");
		double num = 0.0 * 0.125;
		Vector3 localScale = targetTransform.localScale;
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v4+B8]");
		object obj3 = 0;
		double num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+C]");
		double num3 = num2 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ped @ X1 (UnityEngine.EventSystems.PointerEventData)+180]");
		double num4 = 0.0 + num3;
		targetTransform.localScale = (Vector3)0;
		Vector3 localScale2 = targetTransform.localScale;
		double num5 = (double)minScale * 0.5;
		if (num4 < num5)
		{
			targetTransform.localScale = (Vector3)0;
		}
	}

	private void OnScrollEnd()
	{
		//IL_0033: Invalid comparison between F4 and I4
		//IL_0042: Invalid comparison between F4 and I4
		//IL_0057: Expected O, but got F4
		//IL_0064: Expected O, but got F4
		//IL_0099: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		Vector3 localScale = targetTransform.localScale;
		float num = maxScale;
		float num3 = default(float);
		float num2 = num3 - maxScale;
		bool flag = num2 < 0f;
		bool flag2 = num2 == 0f;
		object obj = num3 ^ maxScale;
		object obj2 = num3 ^ num2;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num = num3;
		}
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(endValue: (!(num3 < minScale)) ? num : minScale, target: targetTransform, duration: 0.2f);
	}
}
