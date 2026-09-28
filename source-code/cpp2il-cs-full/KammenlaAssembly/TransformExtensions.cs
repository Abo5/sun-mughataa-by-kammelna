using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public static class TransformExtensions
{
	public enum Direction
	{
		Front,
		Back,
		Left,
		Right,
		FrontRight,
		FrontLeft,
		BackRight,
		BackLeft
	}

	public static Direction CompareTransform(Transform thisTransform, Transform targetTransform, Vector3 forwardDirection, float angleDeterminant = 10f)
	{
		//IL_0028: Expected O, but got I4
		//IL_003e: Expected O, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_022b: Expected O, but got I
		//IL_0245: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_028b: Expected O, but got I4
		//IL_013b: Invalid comparison between F4 and I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I
		//IL_02f4: Expected F4, but got I
		//IL_0304: Expected F4, but got I
		//IL_030c: Expected F4, but got O
		//IL_033e: Expected O, but got I
		//IL_0358: Expected O, but got I4
		//IL_0370: Expected F4, but got O
		//IL_0380: Expected F4, but got I
		//IL_0390: Expected F4, but got I
		//IL_08ae: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_0402: Expected F4, but got I4
		//IL_08c4: Invalid comparison between F4 and O
		//IL_05b5: Invalid comparison between F4 and O
		//IL_0488: Invalid comparison between F4 and I4
		//IL_0497: Invalid comparison between F4 and I4
		//IL_04af: Expected O, but got F8
		//IL_04bc: Expected O, but got F4
		//IL_04f1: Expected O, but got I4
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_061c: Invalid comparison between F4 and O
		//IL_0694: Invalid comparison between F4 and I4
		//IL_06a5: Expected O, but got I4
		//IL_06be: Invalid comparison between F4 and I4
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_071f: Invalid comparison between F4 and I4
		//IL_063c: Invalid comparison between F4 and I4
		//IL_0929: Expected O, but got I4
		//IL_06f1: Invalid comparison between F4 and I4
		//IL_0777: Invalid comparison between F4 and I4
		//IL_07b9: Expected O, but got I4
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		//IL_084b: Expected O, but got I
		//IL_0868: Expected I4, but got O
		Vector3 position = thisTransform.position;
		Vector3 position2 = targetTransform.position;
		object obj = 146599936;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_00aa;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_00aa;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00df;
		}
		goto IL_02a1;
		IL_039e:
		_ = 1;
		object obj11;
		object obj10 = obj11;
		float num2;
		float num = num2;
		float num4;
		float num3 = num4;
		float num6;
		float num5 = num6;
		float num8;
		float num7 = num8;
		goto IL_0868;
		IL_0868:
		float num9 = num * num;
		object obj12 = obj10 * obj10;
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag5 = (nint)obj12 < 646978941;
		float num10 = 0f;
		if (!flag5)
		{
			float num11 = num * num3;
			float num12 = (float)obj10 * num5;
			float num13 = num12 + num11;
			float num14 = num7 * 0f;
			float num15 = num14 + num13;
			float num16 = num15 / (float)obj12;
			float num17 = num16 - 1f;
			bool flag6 = num17 < 0f;
			bool flag7 = num17 == 0f;
			object obj15 = (double)num16 ^ 1.0;
			object obj16 = num16 ^ num17;
			object obj17 = obj15 & obj16;
			bool flag8 = (nint)obj17 < 0;
			bool flag9 = flag6 == flag8;
			object obj18 = !flag7;
			object obj19 = flag9 & obj18;
			object obj20 = ~obj19;
			float num18 = ((obj20 != null) ? num16 : 1f);
			float num19 = ((!((double)num16 < -1.0)) ? num18 : (-1f));
			object obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v49+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0DB4");
			num10 = num19 * 1.1139274E+09f;
		}
		object obj23 = default(object);
		if ((object)num10 < obj23)
		{
			return Direction.Front;
		}
		float num20 = num10 + 3.274965E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		if ((object)num20 >= obj23)
		{
			float num21 = (float)obj10 * num3;
			float num22 = num * num5;
			float num23 = num21 - num22;
			float num24 = num10 + 3.2665764E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			if ((object)num24 < obj23)
			{
				if (num23 < 0f)
				{
					return Direction.Right;
				}
				if (num21 > num22)
				{
					return Direction.Left;
				}
			}
			bool flag11 = num10 < 1.1190927E+09f;
			object obj24 = !flag11;
			float num25 = num10 - 1.1190927E+09f;
			bool flag12 = num25 == 0f;
			object obj25 = ~obj24;
			object obj26 = obj25 | flag12;
			if (obj26 != null)
			{
				if (num23 < 0f)
				{
					return Direction.FrontRight;
				}
				if (num21 > num22)
				{
					return Direction.FrontLeft;
				}
			}
			if (num23 < 0f)
			{
				return Direction.BackRight;
			}
			if (num23 > 0f)
			{
				return Direction.BackLeft;
			}
			object obj27 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj28 = "Added Tournament Prizes And Features" + 1608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			string format = default(string);
			object arg = default(object);
			object arg2 = default(object);
			string message = string.Format(format, arg, arg2);
			object obj29 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArithmeticException ex = default(ArithmeticException);
			ex..ctor(message);
			object obj30 = (nint)0 + (nint)2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			return (Direction)ex2;
		}
		return Direction.Back;
		IL_00df:
		float num27 = default(float);
		float num26 = num27 * num27;
		object obj32 = default(object);
		object obj31 = obj32 * obj32;
		float num28 = num26 + (float)obj31;
		float num30 = default(float);
		float num29 = num30 * num30;
		float num31 = num29 + num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num31 > 925353400f)
		{
			num4 = num27 / num31;
			num6 = (float)obj32 / num31;
			num8 = num30 / num31;
			num2 = num27 - num27;
			obj11 = obj32 - obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D4]");
			object obj33 = (nint)0 & (nint)1;
			if (obj33 == null)
			{
				goto IL_039e;
			}
			obj10 = obj11;
			num = num2;
			num3 = num4;
			num5 = num6;
			num7 = num8;
		}
		else
		{
			object obj34 = typeof(UsageHint) + 816;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v28+B8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v29+4]");
			num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v29+8]");
			num8 = 0f;
			num4 = (float)obj36;
			num2 = num27 - num27;
			obj11 = obj32 - obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D4]");
			object obj37 = (nint)0 & (nint)1;
			bool flag13 = obj37 == null;
			object obj38 = !flag13;
			obj10 = obj11;
			num = num2;
			num3 = (float)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v29+4]");
			num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v29+8]");
			num7 = 0f;
			if (obj38 == null)
			{
				goto IL_039e;
			}
		}
		goto IL_0868;
		IL_00aa:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v24+E4]");
		bool flag14 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag14)
		{
			goto IL_00df;
		}
		goto IL_02a1;
		IL_02a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj5;
		goto IL_00df;
	}
}
