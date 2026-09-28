using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Features.GameReplay;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class GestureController : UIBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ActiveGesture, bool> <>9__23_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ProcessPinchReleased>b__23_0(ActiveGesture gesture)
		{
			//IL_005d: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (gesture != null)
			{
				object obj = gesture.InputId + 1;
				bool flag = obj == null;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const int MouseId = -1;

	protected RectOffset padding;

	private float maxTapDuration;

	private float maxTapDrift;

	private float maxSwipeDuration;

	private float minSwipeDistance;

	private float swipeDirectionSamenessThreshold;

	private readonly Dictionary<int, ActiveGesture> activeGestures;

	public UnityEvent<SwipeGesture> Pressed;

	public UnityEvent<TapGesture> Tapped;

	public UnityEvent<SwipeGesture> PotentiallySwiped;

	public UnityEvent<SwipeGesture> Swiped;

	public UnityEvent<PinchGesture> PotentiallyPinched;

	public UnityEvent<PinchGesture> Pinched;

	protected override void OnEnable()
	{
		base.OnEnable();
		EnhancedTouchSupport.Enable();
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		EnhancedTouchSupport.Disable();
	}

	private unsafe void Update()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		//IL_0117: Expected O, but got Ref
		//IL_00cb: Expected O, but got Ref
		//IL_009b: Expected O, but got Ref
		//IL_00b2: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_ = 0;
		_ = 0;
		_ = 0;
		if (InputUtil.HasMouse)
		{
			ProcessMouse();
			return;
		}
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1376;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ReadOnlyArray<Touch> activeTouches = Touch.activeTouches;
		ReadOnlyArray<Touch> readOnlyArray = default(ReadOnlyArray<Touch>);
		ReadOnlyArray<Touch>.Enumerator enumerator = readOnlyArray.GetEnumerator();
		object obj6 = default(object);
		while (true)
		{
			ReadOnlyArray<Touch>.Enumerator enumerator2 = (ReadOnlyArray<Touch>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
			if (!((ReadOnlyArray<Touch>.Enumerator*)enumerator2)->MoveNext())
			{
				break;
			}
			ReadOnlyArray<Touch>.Enumerator enumerator3 = (ReadOnlyArray<Touch>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
			Touch current = ((ReadOnlyArray<Touch>.Enumerator*)enumerator3)->Current;
			ProcessTouch((Touch)(&obj6));
		}
		ReadOnlyArray<Touch>.Enumerator enumerator4 = (ReadOnlyArray<Touch>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		((ReadOnlyArray<Touch>.Enumerator*)enumerator4)->Dispose();
	}

	private unsafe void ProcessTouch(Touch touch)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_0381: Expected O, but got I
		//IL_03a3: Expected O, but got I4
		//IL_0199: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_03fa: Expected O, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0442: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_02fd: Expected O, but got I
		//IL_032d: Expected O, but got I4
		//IL_0276: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7541]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TouchPhase phase = ((Touch*)touch)->phase;
		bool flag2 = phase > TouchPhase.Moved;
		object obj6 = 0;
		object obj7 = 0;
		TouchPhase touchPhase = phase;
		if (flag2)
		{
			goto IL_00c4;
		}
		goto IL_01b8;
		IL_00c4:
		IntPtr intPtr = default(IntPtr);
		double time2 = default(double);
		switch (phase)
		{
		case TouchPhase.Ended:
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v41+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int touchId2 = ((Touch*)touch)->touchId;
			Vector2 screenPosition = ((Touch*)touch)->screenPosition;
			float time = Time.time;
			ProcessReleased(touchId2, (Vector2)(nint)intPtr, time2);
			return;
		}
		case TouchPhase.Canceled:
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v50+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int touchId = ((Touch*)touch)->touchId;
			bool flag4 = ((Dictionary<int, object>)(object)activeGestures).Remove(touchId);
			return;
		}
		}
		bool flag6 = phase != TouchPhase.Stationary;
		obj7 = obj6;
		if (!flag6)
		{
			return;
		}
		goto IL_0400;
		IL_0400:
		object obj12 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj13 = (nint)0 + (nint)3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_01b8:
		switch (touchPhase)
		{
		case TouchPhase.Moved:
		{
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int touchId4 = ((Touch*)touch)->touchId;
			Vector2 screenPosition3 = ((Touch*)touch)->screenPosition;
			float time4 = Time.time;
			ProcessDragged(touchId4, (Vector2)(nint)intPtr, time2);
			return;
		}
		case TouchPhase.Began:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int touchId3 = ((Touch*)touch)->touchId;
			Vector2 screenPosition2 = ((Touch*)touch)->screenPosition;
			float time3 = Time.time;
			ProcessPressed(touchId3, (Vector2)(nint)intPtr, time2);
			return;
		}
		}
		goto IL_0400;
		IL_007d:
		phase = ((Touch*)touch)->phase;
		bool flag9 = phase <= TouchPhase.Moved;
		obj6 = 0;
		obj7 = 0;
		touchPhase = phase;
		if (!flag9)
		{
			goto IL_00c4;
		}
		goto IL_01b8;
	}

	private void ProcessMouse()
	{
		//IL_0050: Expected I4, but got I8
		//IL_0098: Expected I4, but got I8
		//IL_00e0: Expected I4, but got I8
		Vector2 pointerPosition = InputUtil.PointerPosition;
		Vector2 position = default(Vector2);
		double time2 = default(double);
		if (InputUtil.PointerReleasedThisFrame)
		{
			float time = Time.time;
			ProcessReleased(-1, position, time2);
		}
		else if (InputUtil.PointerPressedThisFrame)
		{
			float time3 = Time.time;
			ProcessPressed(-1, position, time2);
		}
		else if (InputUtil.PointerHeld)
		{
			float time4 = Time.time;
			ProcessDragged(-1, position, time2);
		}
	}

	private unsafe void ProcessPressed(int id, Vector2 position, double time)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_0069: Expected O, but got Ref
		object obj = typeof(SqlSingle[]) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 4575657221408423937L;
		object obj3 = typeof(UsageHint) + 744;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+B8]");
		object obj5 = 0;
		_ = 0;
		if (IsValidPosition((ActiveGesture)obj2))
		{
			((Dictionary<int, object>)(object)activeGestures).set_Item(id, obj2);
			if (Pressed != null)
			{
				SwipeGesture swipeGesture = new SwipeGesture((ActiveGesture)obj2);
				SwipeGesture swipeGesture2 = default(SwipeGesture);
				Pressed.Invoke((SwipeGesture)(&swipeGesture2));
			}
		}
	}

	private unsafe void ProcessDragged(int id, Vector2 position, double time)
	{
		//IL_0047: Expected O, but got I4
		//IL_00a9: Expected O, but got I4
		//IL_00c3: Invalid comparison between F8 and I4
		//IL_00d4: Expected O, but got I4
		//IL_014e: Expected O, but got Ref
		int num = default(int);
		if (!((Dictionary<int, object>)(object)activeGestures).TryGetValue(num, out object value))
		{
			return;
		}
		((ActiveGesture)value).SubmitPoint((Vector2)num, time);
		ProcessPinchDragged();
		if (!(((ActiveGesture)value).TravelDistance < minSwipeDistance))
		{
			double num2 = ((ActiveGesture)value).EndTime - ((ActiveGesture)value).StartTime;
			bool flag = num2 < (double)maxSwipeDuration;
			object obj = !flag;
			double num3 = num2 - (double)maxSwipeDuration;
			bool flag2 = num3 == 0.0;
			object obj2 = !flag2;
			object obj3 = obj & obj2;
			if (obj3 == null && !(((ActiveGesture)value).SwipeDirectionSameness < swipeDirectionSamenessThreshold) && PotentiallySwiped != null)
			{
				SwipeGesture swipeGesture = new SwipeGesture((ActiveGesture)value);
				SwipeGesture swipeGesture2 = default(SwipeGesture);
				PotentiallySwiped.Invoke((SwipeGesture)(&swipeGesture2));
			}
		}
	}

	private unsafe void ProcessPinchDragged()
	{
		//IL_009b: Expected O, but got Ref
		Dictionary<int, object>.ValueCollection values = ((Dictionary<int, object>)(object)activeGestures).Values;
		object[] array = Enumerable.ToArray(values);
		if (array.Length >= 2 && PotentiallyPinched != null)
		{
			PinchGesture pinchGesture = new PinchGesture((ActiveGesture)array[0], (ActiveGesture)array[1]);
			PinchGesture pinchGesture2 = default(PinchGesture);
			PotentiallyPinched.Invoke((PinchGesture)(&pinchGesture2));
		}
	}

	private unsafe void ProcessReleased(int id, Vector2 position, double time)
	{
		//IL_0047: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_00fd: Invalid comparison between F8 and I4
		//IL_010e: Expected O, but got I4
		//IL_01c5: Invalid comparison between I and F4
		//IL_01d6: Expected O, but got I4
		//IL_01f8: Invalid comparison between F4 and I4
		//IL_0209: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_024b: Invalid comparison between O and F4
		//IL_025c: Expected O, but got I4
		//IL_0276: Invalid comparison between F4 and I4
		//IL_0287: Expected O, but got I4
		//IL_01a1: Expected O, but got Ref
		//IL_02d2: Expected O, but got Ref
		if (!((Dictionary<int, object>)(object)activeGestures).TryGetValue(id, out object value))
		{
			return;
		}
		((ActiveGesture)value).SubmitPoint((Vector2)id, time);
		ProcessPinchReleased();
		bool flag = ((Dictionary<int, object>)(object)activeGestures).Remove(id);
		bool flag2 = ((Dictionary<int, object>)(object)activeGestures).Remove(id);
		bool flag3 = ((ActiveGesture)value).TravelDistance < minSwipeDistance;
		ActiveGesture gesture = (ActiveGesture)value;
		SwipeGesture swipeGesture2 = default(SwipeGesture);
		if (!flag3)
		{
			double num = ((ActiveGesture)value).EndTime - ((ActiveGesture)value).StartTime;
			bool flag4 = num < (double)maxSwipeDuration;
			object obj = !flag4;
			double num2 = num - (double)maxSwipeDuration;
			bool flag5 = num2 == 0.0;
			object obj2 = !flag5;
			object obj3 = obj & obj2;
			gesture = (ActiveGesture)value;
			if (obj3 == null)
			{
				bool flag6 = ((ActiveGesture)value).SwipeDirectionSameness < swipeDirectionSamenessThreshold;
				gesture = (ActiveGesture)value;
				if (!flag6)
				{
					bool flag7 = Swiped == null;
					gesture = (ActiveGesture)value;
					if (!flag7)
					{
						SwipeGesture swipeGesture = new SwipeGesture((ActiveGesture)value);
						Swiped.Invoke((SwipeGesture)(&swipeGesture2));
						gesture = (ActiveGesture)value;
					}
				}
			}
		}
		if (!IsValidPosition(gesture))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-98_v3 (System.Object)+48]");
		bool flag8 = 0f < maxTapDrift;
		object obj4 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-98_v3 (System.Object)+48]");
		float num3 = 0f - maxTapDrift;
		bool flag9 = num3 == 0f;
		object obj5 = !flag9;
		object obj6 = obj4 & obj5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-98_v3 (System.Object)+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-98_v3 (System.Object)+18]");
			object obj7 = num4 - 0;
			bool flag10 = obj7 < (object)maxTapDuration;
			object obj8 = !flag10;
			float num5 = (float)obj7 - maxTapDuration;
			bool flag11 = num5 == 0f;
			object obj9 = !flag11;
			object obj10 = obj8 & obj9;
			if (obj10 == null && Tapped != null)
			{
				Tapped.Invoke((TapGesture)(&swipeGesture2));
			}
		}
	}

	private unsafe void ProcessPinchReleased()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_0188: Expected O, but got I
		//IL_0198: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I
		//IL_0203: Expected I, but got O
		//IL_0221: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_0170: Expected O, but got Ref
		object obj = (nint)0 + (nint)64;
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 272;
		Dictionary<int, object>.ValueCollection values = ((Dictionary<int, object>)(object)activeGestures).Values;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v7+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v19+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 4032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)2136;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v18+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		IEnumerable<object> source = Enumerable.Where(values, predicate);
		object[] array = Enumerable.ToArray(source);
		if (array.Length >= 2 && Pinched != null)
		{
			PinchGesture pinchGesture = new PinchGesture((ActiveGesture)array[0], (ActiveGesture)array[1]);
			PinchGesture pinchGesture2 = default(PinchGesture);
			Pinched.Invoke((PinchGesture)(&pinchGesture2));
		}
	}

	private void ProcessCanceled(int id)
	{
		int key = default(int);
		bool flag = ((Dictionary<int, object>)(object)activeGestures).Remove(key);
	}

	private bool IsValidPosition(ActiveGesture gesture)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0159: Expected I4, but got O
		int left = padding.left;
		int bottom = padding.bottom;
		int right = padding.right;
		int top = padding.top;
		Transform transform = base.transform;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (object)transform == null;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_00fd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((object)transform != null)
			{
				goto IL_00fd;
			}
		}
		goto IL_0130;
		IL_0130:
		Vector4 offset = default(Vector4);
		return RectTransformUtility.RectangleContainsScreenPoint((RectTransform)transform, (Vector2)main, null, offset);
		IL_00fd:
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
		if (transform == obj4)
		{
			goto IL_0130;
		}
		InvalidCastException ex = new InvalidCastException();
		return (byte)(int)ex != 0;
	}

	private bool IsValidSwipe(ref ActiveGesture gesture)
	{
		//IL_0159: Expected I4, but got O
		//IL_0087: Expected O, but got I4
		//IL_00a1: Invalid comparison between F4 and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00f0: Invalid comparison between F4 and I4
		//IL_010a: Expected O, but got F4
		//IL_011c: Expected O, but got F4
		ActiveGesture activeGesture = gesture;
		if (gesture != null)
		{
			if (activeGesture.TravelDistance < minSwipeDistance)
			{
				return false;
			}
			double num = activeGesture.EndTime - activeGesture.StartTime;
			bool flag = num < (double)maxSwipeDuration;
			object obj = !flag;
			float num2 = (float)num - maxSwipeDuration;
			bool flag2 = num2 == 0f;
			object obj2 = ~obj;
			object obj3 = obj2 | flag2;
			if (obj3 == null)
			{
				return false;
			}
			float num3 = activeGesture.SwipeDirectionSameness - swipeDirectionSamenessThreshold;
			bool flag3 = num3 < 0f;
			object obj4 = activeGesture.SwipeDirectionSameness ^ swipeDirectionSamenessThreshold;
			object obj5 = activeGesture.SwipeDirectionSameness ^ num3;
			object obj6 = obj4 & obj5;
			bool flag4 = (nint)obj6 < 0;
			return flag3 == flag4;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool IsValidTap(ref ActiveGesture gesture)
	{
		//IL_0143: Expected I4, but got O
		//IL_006f: Expected O, but got I4
		//IL_008e: Invalid comparison between F4 and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I4
		//IL_0114: Invalid comparison between F8 and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected I4, but got Unknown
		bool flag = IsValidPosition(gesture);
		if (flag)
		{
			ActiveGesture activeGesture = gesture;
			if (gesture == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			bool flag2 = activeGesture.TravelDistance < maxTapDrift;
			object obj = !flag2;
			float num = activeGesture.TravelDistance - maxTapDrift;
			bool flag3 = num == 0f;
			object obj2 = ~obj;
			object obj3 = obj2 | flag3;
			if (obj3 != null)
			{
				double num2 = activeGesture.EndTime - activeGesture.StartTime;
				bool flag4 = num2 < (double)maxTapDuration;
				object obj4 = !flag4;
				double num3 = num2 - (double)maxTapDuration;
				bool flag5 = num3 == 0.0;
				object obj5 = ~obj4;
				return (byte)((obj5 | flag5) ? 1 : 0) != 0;
			}
			flag = false;
		}
		return flag;
	}

	public void CancelSwipe()
	{
		((Dictionary<int, object>)(object)activeGestures).Clear();
	}

	public GestureController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0040: Expected F4, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3568;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RectOffset rectOffset = default(RectOffset);
		rectOffset..ctor();
		object obj3 = this + 32;
		obj3 = rectOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252ED0]");
		maxTapDuration = 0f;
		swipeDirectionSamenessThreshold = 0.6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		dictionary..ctor();
		object obj4 = this + 64;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
