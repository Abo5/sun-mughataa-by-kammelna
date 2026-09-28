using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public struct PinchGesture
{
	public readonly Rect StartPosition;

	public readonly Rect PreviousPosition;

	public readonly Rect EndPosition;

	public readonly float DeltaScale;

	public readonly double PinchDuration;

	public PinchGesture(ActiveGesture finger1, ActiveGesture finger2)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_0440: Expected O, but got I
		//IL_0450: Expected O, but got I
		//IL_0466: Expected O, but got I
		//IL_0480: Expected O, but got I4
		//IL_0490: Expected O, but got I
		//IL_04a0: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_01a5: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_04de: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_06be: Expected O, but got I
		//IL_06fa: Invalid comparison between F8 and I4
		//IL_0709: Invalid comparison between F8 and I4
		//IL_071c: Expected O, but got F8
		//IL_0729: Expected O, but got F8
		//IL_075e: Expected O, but got I4
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0795: Invalid comparison between I4 and F8
		//IL_0535: Expected O, but got I
		//IL_0545: Expected O, but got I
		//IL_055b: Expected O, but got I
		//IL_0575: Expected O, but got I4
		//IL_0585: Expected O, but got I
		//IL_0595: Expected O, but got I
		//IL_02b3: Expected O, but got I
		//IL_02c3: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_02f8: Expected O, but got I
		//IL_0308: Expected O, but got I
		//IL_0632: Expected O, but got I
		//IL_0648: Expected O, but got I
		//IL_05d3: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_07ea: Expected O, but got I4
		//IL_067d: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj3 = finger2.StartPosition - finger1.StartPosition;
		StartPosition = (Rect)finger1.StartPosition;
		object obj4 = finger2.PreviousPosition - finger1.PreviousPosition;
		PreviousPosition = (Rect)finger1.PreviousPosition;
		object obj5 = finger2.EndPosition - finger1.EndPosition;
		EndPosition = (Rect)finger1.EndPosition;
		double val = finger1.EndTime - finger1.StartTime;
		double val2 = finger2.EndTime - finger2.StartTime;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double pinchDuration = Math.Min(val, val2);
		PinchDuration = pinchDuration;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v6+E4]");
		object obj9;
		object obj10;
		object obj12;
		object obj13;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+1C]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
			object obj11 = (nint)0 & (nint)1;
			bool flag2 = obj11 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+1C]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
			obj13 = 0;
			if (!flag2)
			{
				goto IL_01e2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+1C]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
			object obj14 = (nint)0 & (nint)1;
			bool flag3 = obj14 == null;
			object obj15 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+1C]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
			obj13 = 0;
			if (obj15 != null)
			{
				goto IL_01e2;
			}
		}
		_ = 1;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		obj10 = obj12;
		obj9 = obj13;
		if (obj17 != null)
		{
			goto IL_021f;
		}
		goto IL_04fc;
		IL_07f8:
		double num;
		DeltaScale = (float)num;
		return;
		IL_0316:
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20;
		object obj19 = obj20;
		object obj22;
		object obj21 = obj22;
		if (!flag5)
		{
			goto IL_0353;
		}
		goto IL_05f1;
		IL_07b6:
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26;
		object obj25 = obj26 * obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj27;
		num = (double)obj27 / (double)obj25;
		goto IL_07f8;
		IL_0353:
		object obj28 = obj22 * obj22;
		object obj29 = obj20 * obj20;
		object obj30 = obj28 + obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
		object obj31 = 0;
		obj27 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
		obj26 = 0;
		object obj32 = obj29;
		object obj33 = obj28;
		goto IL_07b6;
		IL_05f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj28 = obj21 * obj21;
		obj29 = obj19 * obj19;
		obj30 = obj28 + obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
		object obj34 = (nint)0 & (nint)1;
		if (obj34 == null)
		{
			_ = 1;
			obj27 = obj30;
			obj26 = obj31;
			obj32 = obj29;
			obj33 = obj28;
		}
		else
		{
			obj27 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+18]");
			obj26 = 0;
			obj32 = obj29;
			obj33 = obj28;
		}
		goto IL_07b6;
		IL_01e2:
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		obj12 = obj10;
		obj13 = obj9;
		if (!flag7)
		{
			goto IL_021f;
		}
		goto IL_04fc;
		IL_04fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj12;
		obj9 = obj13;
		goto IL_021f;
		IL_021f:
		object obj35 = obj9 * obj9;
		object obj36 = obj10 * obj10;
		object obj37 = obj35 + obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj38 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13+B8]");
		object obj40 = 0;
		double num2 = (double)obj37 * 897988541.0;
		double num3 = (double)obj40 * 8.0;
		double num4 = num2 - num3;
		bool flag8 = num4 < 0.0;
		bool flag9 = num4 == 0.0;
		object obj41 = num2 ^ num3;
		object obj42 = num2 ^ num4;
		object obj43 = obj41 & obj42;
		bool flag10 = (nint)obj43 < 0;
		bool flag11 = flag8 == flag10;
		object obj44 = !flag9;
		object obj45 = flag11 & obj44;
		object obj46 = ~obj45;
		if (obj46 == null)
		{
			num3 = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag12 = 0.0 < num3;
		num = 1.0;
		if (!flag12)
		{
			object obj47 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+28]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+2C]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
				object obj48 = (nint)0 & (nint)1;
				bool flag13 = obj48 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+2C]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+28]");
				obj21 = 0;
				if (!flag13)
				{
					goto IL_0316;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+28]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+2C]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
				object obj49 = (nint)0 & (nint)1;
				bool flag14 = obj49 == null;
				object obj50 = !flag14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+2C]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PinchGesture)+28]");
				obj21 = 0;
				if (obj50 != null)
				{
					goto IL_0316;
				}
			}
			_ = 1;
			obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v23+E4]");
			bool flag15 = (nint)0 == 0;
			object obj51 = !flag15;
			obj20 = obj19;
			obj22 = obj21;
			if (obj51 != null)
			{
				goto IL_0353;
			}
			goto IL_05f1;
		}
		goto IL_07f8;
	}
}
