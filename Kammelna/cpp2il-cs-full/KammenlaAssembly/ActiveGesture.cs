using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class ActiveGesture
{
	public int InputId;

	public readonly double StartTime;

	public double EndTime;

	public readonly Vector2 StartPosition;

	public Vector2 PreviousPosition;

	public Vector2 EndPosition;

	public int Samples;

	public float SwipeDirectionSameness;

	public float TravelDistance;

	private Vector2 accumulatedNormalized;

	public double Duration => EndTime - StartTime;

	public ActiveGesture(int inputId, Vector2 startPosition, double startTime)
	{
		//IL_002e: Expected O, but got F8
		//IL_003d: Expected O, but got F8
		//IL_004c: Expected O, but got F8
		//IL_0060: Expected I4, but got I8
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		InputId = inputId;
		double num = default(double);
		StartTime = num;
		EndTime = num;
		StartPosition = (Vector2)startTime;
		EndPosition = (Vector2)startTime;
		PreviousPosition = (Vector2)startTime;
		Samples = 1;
		object obj = typeof(UsageHint) + 744;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+B8]");
		object obj3 = 0;
		accumulatedNormalized = (Vector2)obj3;
		TravelDistance = 0f;
	}

	public void SubmitPoint(Vector2 position, double time)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_020f: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0249: Expected O, but got I
		//IL_0285: Invalid comparison between F8 and I4
		//IL_0294: Invalid comparison between F8 and I4
		//IL_02a7: Expected O, but got F8
		//IL_02b4: Expected O, but got F8
		//IL_02e9: Expected O, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_0320: Invalid comparison between I4 and F8
		//IL_0100: Expected O, but got F8
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0135: Expected O, but got F8
		//IL_014a: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		double num = time - (double)EndPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ActiveGesture)+3C]");
		object obj3 = default(object);
		object obj2 = obj3 - 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num2 = num * num;
		object obj6 = obj2 * obj2;
		double num3 = num2 + (double)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double endTime = default(double);
		EndTime = endTime;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+B8]");
		object obj9 = 0;
		double num4 = num3 * 897988541.0;
		double num5 = (double)obj9 * 8.0;
		double num6 = num4 - num5;
		bool flag2 = num6 < 0.0;
		bool flag3 = num6 == 0.0;
		object obj10 = num4 ^ num5;
		object obj11 = num4 ^ num6;
		object obj12 = obj10 & obj11;
		bool flag4 = (nint)obj12 < 0;
		bool flag5 = flag2 == flag4;
		object obj13 = !flag3;
		object obj14 = flag5 & obj13;
		object obj15 = ~obj14;
		if (obj15 != null)
		{
			num4 = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (!(0.0 < num4))
		{
			double num7 = num / (double)EndPosition;
			int samples = Samples + 1;
			Samples = samples;
			double num8 = time - (double)StartPosition;
			object obj16 = obj2 / (object)EndPosition;
			Vector2 value = default(Vector2);
			Vector2 vector = Vector2.Normalize(ref value);
			PreviousPosition = EndPosition;
			EndPosition = (Vector2)time;
			double num9 = num7 + (double)accumulatedNormalized;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ActiveGesture)+50]");
			object obj17 = obj16 + 0;
			accumulatedNormalized = (Vector2)num9;
			object obj18 = Samples - 1;
			double num10 = num9 / (double)obj18;
			object obj19 = obj17 / obj18;
			double num11 = num8 * num10;
			double num12 = time * (double)obj19;
			double num13 = num11 + num12;
			float travelDistance = (float)EndPosition + TravelDistance;
			SwipeDirectionSameness = (float)num13;
			TravelDistance = travelDistance;
		}
	}
}
