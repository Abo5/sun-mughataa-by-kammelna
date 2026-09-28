using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public struct SwipeGesture
{
	public readonly int InputId;

	public readonly Vector2 StartPosition;

	public readonly Vector2 PreviousPosition;

	public readonly Vector2 EndPosition;

	public readonly Vector2 SwipeDirection;

	public readonly float SwipeVelocity;

	public readonly float TravelDistance;

	public readonly double SwipeDuration;

	public readonly float SwipeSameness;

	public readonly GestureDirection CardinalDirection;

	public SwipeGesture(ActiveGesture gesture)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0105: Invalid comparison between F8 and I4
		//IL_01ef: Expected O, but got I4
		//IL_0412: Expected O, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0215: Expected O, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0305: Expected O, but got I
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I
		_ = 0;
		SwipeDuration = 0.0;
		InputId = 0;
		_ = 0;
		InputId = gesture.InputId;
		StartPosition = gesture.StartPosition;
		PreviousPosition = gesture.PreviousPosition;
		EndPosition = gesture.EndPosition;
		object obj = (object)gesture.EndPosition >> 32;
		object obj2 = typeof(UsageHint) + 928;
		object obj3 = (object)gesture.StartPosition >> 32;
		Vector2 vector = gesture.EndPosition - gesture.StartPosition;
		object obj4 = obj - obj3;
		Vector2 value = default(Vector2);
		Vector2 vector2 = Vector2.Normalize(ref value);
		SwipeDirection = vector;
		double num = (SwipeDuration = gesture.EndTime - gesture.StartTime);
		TravelDistance = gesture.TravelDistance;
		SwipeSameness = gesture.SwipeDirectionSameness;
		bool flag = !(num > 0.0);
		float num2 = (float)num;
		if (!flag)
		{
			num2 = gesture.TravelDistance / (float)num;
			SwipeVelocity = num2;
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector3 = VectorExtensions.ClosestDirection((Vector3)0);
		object obj7 = typeof(UsageHint) + 816;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+18]");
		object obj10 = vector - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+1C]");
		object obj11 = obj4 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+20]");
		object obj12 = -0;
		object obj13 = obj10 * obj10;
		object obj14 = obj11 * obj11;
		object obj15 = obj13 + obj14;
		object obj16 = obj12 * obj12;
		object obj17 = obj16 + obj15;
		GestureDirection cardinalDirection;
		if ((nint)obj17 < 786163454)
		{
			cardinalDirection = GestureDirection.Up;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+24]");
			object obj18 = vector - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+28]");
			object obj19 = obj4 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+2C]");
			object obj20 = -0;
			object obj21 = obj18 * obj18;
			object obj22 = obj19 * obj19;
			object obj23 = obj21 + obj22;
			object obj24 = obj20 * obj20;
			object obj25 = obj24 + obj23;
			if ((nint)obj25 < 786163454)
			{
				cardinalDirection = GestureDirection.Down;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+30]");
				object obj26 = vector - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+34]");
				object obj27 = obj4 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v13+38]");
				object obj28 = -0;
				object obj29 = obj26 * obj26;
				object obj30 = obj27 * obj27;
				object obj31 = obj29 + obj30;
				object obj32 = obj28 * obj28;
				object obj33 = obj32 + obj31;
				if ((nint)obj33 < 786163454)
				{
					CardinalDirection = GestureDirection.Left;
					return;
				}
				cardinalDirection = GestureDirection.Right;
			}
		}
		CardinalDirection = cardinalDirection;
	}
}
