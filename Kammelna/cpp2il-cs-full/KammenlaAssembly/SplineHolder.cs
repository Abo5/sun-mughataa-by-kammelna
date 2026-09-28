using System;
using Cpp2ILInjected;
using Dreamteck.Splines;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;

[Serializable]
public class SplineHolder
{
	private SplineComputer spline;

	public int splineSegementCount
	{
		get
		{
			//IL_0041: Expected I4, but got O
			if ((object)spline != null)
			{
				return spline.sampleCount;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int pointCount
	{
		get
		{
			//IL_0041: Expected I4, but got O
			if ((object)spline != null)
			{
				return spline.pointCount;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public float splineScaleFactor
	{
		get
		{
			Transform transform = spline.transform;
			Vector3 localScale = transform.localScale;
			float result = default(float);
			return result;
		}
	}

	public bool hasSpline
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return spline != null;
		}
	}

	public Vector3 GetPositionAt(float value)
	{
		if ((object)spline != null)
		{
			return spline.EvaluatePosition(value);
		}
		return (Vector3)new NullReferenceException();
	}

	public Vector3 GetDirectionAt(float t)
	{
		//IL_00c7: Expected O, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0272: Expected O, but got I
		//IL_028c: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_02fb: Expected O, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_0217: Invalid comparison between F8 and I4
		//IL_0370: Expected O, but got I
		//IL_0378: Expected F8, but got O
		//IL_03d8: Expected O, but got I
		//IL_052c: Expected O, but got I
		//IL_0546: Expected O, but got I4
		//IL_040b: Expected O, but got I
		//IL_05af: Expected O, but got I4
		//IL_04f4: Invalid comparison between F8 and I4
		//IL_060b: Expected O, but got I4
		//IL_064b: Invalid comparison between F4 and I4
		//IL_065a: Invalid comparison between F4 and I4
		//IL_0672: Expected O, but got F8
		//IL_067f: Expected O, but got F4
		//IL_06b4: Expected O, but got I4
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_0737: Invalid comparison between F4 and I4
		float splineSegmentPosition = GetSplineSegmentPosition(t, 0, 2);
		float splineSegmentPosition2 = GetSplineSegmentPosition(t, 1, 2);
		float splineSegmentPosition3 = GetSplineSegmentPosition(t, 2, 2);
		object obj2;
		object obj4;
		double num;
		object obj7;
		object obj8 = default(object);
		object obj9;
		object obj10 = default(object);
		object obj13;
		object obj14;
		double num2;
		object obj11;
		if ((object)spline != null)
		{
			Vector3 vector = spline.EvaluatePosition(splineSegmentPosition2);
			if ((object)spline != null)
			{
				Vector3 vector2 = spline.EvaluatePosition(splineSegmentPosition);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
				object obj = (nint)0 & (nint)1;
				if (obj != null)
				{
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj3 = (nint)0 & (nint)1;
					bool flag = obj3 == null;
					obj4 = obj2;
					if (!flag)
					{
						goto IL_0133;
					}
				}
				else
				{
					_ = 1;
					obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj5 = (nint)0 & (nint)1;
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					obj4 = obj2;
					if (obj6 != null)
					{
						goto IL_0133;
					}
				}
				_ = 1;
				num = (double)splineSegmentPosition2 - (double)splineSegmentPosition;
				obj7 = obj8 - obj8;
				obj9 = obj10 - obj10;
				obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				obj2 = obj4;
				obj13 = obj9;
				obj14 = obj7;
				num2 = num;
				if (obj12 != null)
				{
					goto IL_01a9;
				}
				goto IL_0329;
			}
		}
		goto IL_06e2;
		IL_01a9:
		object obj15 = typeof(UsageHint) + 816;
		double num3 = num * num;
		object obj16 = obj7 * obj7;
		double num4 = num3 + (double)obj16;
		object obj17 = obj9 * obj9;
		double num5 = (double)obj17 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num6;
		if (num5 > 925353388.0)
		{
			num6 = num / num5;
		}
		else
		{
			object obj18 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v29+B8]");
			object obj19 = 0;
			num6 = (double)obj19;
		}
		double num7;
		double num8;
		object obj24;
		double num9;
		object obj27;
		double num10;
		object obj25;
		if ((object)spline != null)
		{
			Vector3 vector3 = spline.EvaluatePosition(splineSegmentPosition3);
			if ((object)spline != null)
			{
				Vector3 vector4 = spline.EvaluatePosition(splineSegmentPosition2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CA]");
				object obj20 = (nint)0 & (nint)1;
				if (obj20 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj21 = (nint)0 & (nint)1;
					if (obj21 != null)
					{
						goto IL_0428;
					}
				}
				else
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
					object obj22 = (nint)0 & (nint)1;
					bool flag4 = obj22 == null;
					object obj23 = !flag4;
					if (obj23 != null)
					{
						goto IL_0428;
					}
				}
				_ = 1;
				num7 = (double)splineSegmentPosition3 - (double)splineSegmentPosition2;
				num8 = num6 - num6;
				obj24 = obj10 - obj10;
				obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v24+E4]");
				bool flag5 = (nint)0 == 0;
				object obj26 = !flag5;
				num9 = num8;
				obj27 = obj24;
				num10 = num7;
				if (obj26 != null)
				{
					goto IL_0498;
				}
				goto IL_05d5;
			}
		}
		goto IL_06e2;
		IL_0498:
		double num11 = num7 * num7;
		double num12 = num8 * num8;
		double num13 = num11 + num12;
		object obj28 = obj24 * obj24;
		double num14 = (double)obj28 + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num14 > 925353388.0)
		{
		}
		if ((object)spline != null)
		{
			Vector3 vector5 = (Vector3)spline.sampleCount;
			float num15 = t * (float)vector5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTZ not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
			float num16 = num15 - 1f;
			bool flag6 = num16 < 0f;
			bool flag7 = num16 == 0f;
			object obj29 = (double)num15 ^ 1.0;
			object obj30 = num15 ^ num16;
			object obj31 = obj29 & obj30;
			bool flag8 = (nint)obj31 < 0;
			bool flag9 = flag6 == flag8;
			object obj32 = !flag7;
			object obj33 = flag9 & obj32;
			object obj34 = ~obj33;
			if (obj34 == null)
			{
			}
			if (num15 < 0f)
			{
			}
			return vector5;
		}
		goto IL_06e2;
		IL_05d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num8 = num9;
		obj24 = obj27;
		num7 = num10;
		goto IL_0498;
		IL_0428:
		num7 = (double)splineSegmentPosition3 - (double)splineSegmentPosition2;
		num8 = num6 - num6;
		obj24 = obj10 - obj10;
		obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		num9 = num8;
		obj27 = obj24;
		num10 = num7;
		if (!flag10)
		{
			goto IL_0498;
		}
		goto IL_05d5;
		IL_06e2:
		return (Vector3)new NullReferenceException();
		IL_0133:
		num = (double)splineSegmentPosition2 - (double)splineSegmentPosition;
		obj7 = obj8 - obj8;
		obj9 = obj10 - obj10;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v9+E4]");
		bool flag11 = (nint)0 == 0;
		obj4 = obj2;
		obj13 = obj9;
		obj14 = obj7;
		num2 = num;
		if (!flag11)
		{
			goto IL_01a9;
		}
		goto IL_0329;
		IL_0329:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj2 = obj4;
		obj9 = obj13;
		obj7 = obj14;
		num = num2;
		goto IL_01a9;
	}

	private float GetSplineSegmentPosition(float current, int step, int limitStepBy = 0)
	{
		int sampleCount = spline.sampleCount;
		int sampleCount2 = spline.sampleCount;
		float num = current * (float)sampleCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		float num2 = (float)sampleCount2 - (float)limitStepBy;
		float num3 = ((!(num < num2)) ? num2 : num);
		int sampleCount3 = spline.sampleCount;
		float num4 = num3 + (float)step;
		return num4 / (float)sampleCount3;
	}

	public void SetSpline(SplineComputer spline)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 16;
		obj = spline;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Prepare(IAnimatedGift gift)
	{
		//IL_0013: Expected O, but got I
		IAnimatedGift gift2 = default(IAnimatedGift);
		IntPtr intPtr = default(IntPtr);
		Prepare(gift2, (Vector3)(nint)intPtr);
	}

	public Vector3 GetLastPointPosition(Space space)
	{
		if ((object)spline != null)
		{
			int num = spline.pointCount;
			int index = num - 1;
			return spline.GetPointPosition(index, (SplineComputer.Space)space);
		}
		return (Vector3)new NullReferenceException();
	}

	public void SetPointPosition(int index, Vector3 position, Space space)
	{
		spline.SetPointPosition(index, position);
	}

	public void Prepare(IAnimatedGift gift, Vector3 targetPosition)
	{
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected O, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected O, but got Unknown
		//IL_0e81: Expected O, but got I
		//IL_0f12: Invalid comparison between F8 and I4
		//IL_0118: Expected F8, but got I4
		//IL_0025: Expected F8, but got I4
		//IL_0147: Expected I, but got O
		//IL_0157: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_004c: Expected I, but got O
		//IL_005c: Expected O, but got I
		//IL_00f3: Expected O, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_028c: Expected O, but got I4
		//IL_0c75: Expected I, but got O
		//IL_0c85: Expected O, but got I
		//IL_0cad: Expected F8, but got I4
		//IL_0cce: Expected F8, but got I4
		//IL_0097: Expected O, but got I
		//IL_0d1a: Expected I, but got O
		//IL_0d2a: Expected O, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0351: Expected O, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0d85: Expected I, but got O
		//IL_0d95: Expected O, but got I
		//IL_02f5: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_03fd: Expected I, but got O
		//IL_042d: Expected O, but got I4
		//IL_0436: Expected O, but got I4
		//IL_04e6: Expected I, but got O
		//IL_04f6: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_058c: Expected I, but got O
		//IL_05b0: Expected O, but got I4
		//IL_05b9: Expected O, but got I4
		//IL_0455: Expected F8, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_06fe: Expected O, but got I4
		//IL_0531: Expected O, but got I
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_047d: Expected I, but got O
		//IL_04b3: Expected F8, but got I4
		//IL_05d0: Expected F8, but got I4
		//IL_05e0: Expected I, but got O
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_0608: Expected I, but got O
		//IL_063a: Expected F8, but got I4
		//IL_064a: Expected I, but got O
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_07bf: Expected O, but got I4
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_084c: Expected O, but got I
		//IL_0b1b: Expected O, but got I4
		//IL_08bc: Expected O, but got I
		//IL_0ba1: Expected O, but got I4
		//IL_0b59: Expected O, but got I
		//IL_0b73: Expected O, but got I4
		//IL_09d8: Expected O, but got I
		//IL_09ff: Expected F8, but got I
		//IL_0a3b: Expected O, but got I4
		//IL_0a43: Expected I, but got O
		//IL_0a53: Expected O, but got I
		//IL_0e4b: Expected O, but got I
		//IL_0a8e: Expected O, but got I
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected O, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected O, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Expected O, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected O, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 816;
		double num2 = default(double);
		double num4 = default(double);
		double num7 = default(double);
		object obj15 = default(object);
		object obj26 = default(object);
		object obj34 = default(object);
		object obj7 = default(object);
		while (true)
		{
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 768;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+B8]");
			object obj4 = 0;
			double num = num2 - (double)obj4;
			double num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+4]");
			double num5 = num3 - 0.0;
			double num6 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+8]");
			double num8 = num6 - 0.0;
			double num9 = num * num;
			double num10 = num5 * num5;
			double num11 = num9 + num10;
			double num12 = num8 * num8;
			double num13 = num12 + num11;
			double num14;
			double num15;
			double num16;
			nint num17;
			if (num13 < 786163454.0)
			{
				bool flag = gift == null;
				num14 = num13;
				num15 = 786163454.0;
				num16 = num8;
				num17 = 786163454;
				if (flag)
				{
					break;
				}
				nint num18 = (nint)gift;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v50 (Il2CppClass<IAnimatedGift>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v50 (Il2CppClass<IAnimatedGift>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00e0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v50 (Il2CppClass<IAnimatedGift>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X10_v38-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj7 = obj6 + 16;
					obj5--;
					bool flag2 = (nint)obj5 != 1;
					obj6 = obj7;
					if (flag2)
					{
						continue;
					}
					goto IL_00e0;
				}
				object obj8 = obj6 + 1;
				object obj9 = num18 + obj8;
				object obj10 = obj9 + 312;
				obj7 = obj6;
				goto IL_0c5b;
			}
			bool flag3 = gift == null;
			num14 = num13;
			num15 = 786163454.0;
			num16 = num8;
			num17 = 786163454;
			if (flag3)
			{
				break;
			}
			object obj11 = obj2;
			nint num19 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v47 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v47 (Il2CppClass<IAnimatedGift>)+12E]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			double num20 = num2;
			double num21 = num4;
			double num22 = num7;
			if (obj13 != null)
			{
				goto IL_01fa;
			}
			object obj14 = obj2;
			double num23 = num2;
			double num24 = num4;
			double num25 = num7;
			goto IL_0279;
			IL_057a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num26 = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v737 @ X0_v37] (should have been resolved before IL gen)");
			Transform transform;
			bool flag5 = (object)transform == null;
			object obj16 = !flag5;
			Vector3 vector = (Vector3)0;
			object obj17;
			if (obj16 == null)
			{
				num15 = 786163454.0;
				obj7 = obj17;
				num17 = (nint)obj15;
				break;
			}
			goto IL_0658;
			IL_0d73:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v657 @ X0_v8] (should have been resolved before IL gen)");
			nint num27 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v15 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v15 (Il2CppClass<IAnimatedGift>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03eb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v15 (Il2CppClass<IAnimatedGift>)+B0]");
			obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X10_v5-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj7 = obj17 + 16;
				obj18--;
				bool flag6 = (nint)obj18 != 1;
				obj17 = obj7;
				if (flag6)
				{
					continue;
				}
				goto IL_03eb;
			}
			object obj19 = num27 + obj17;
			object obj20 = obj19 + 312;
			num17 = (nint)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v698 @ X0_v48] (should have been resolved before IL gen)");
			Component component = spline;
			bool flag7 = (object)spline == null;
			num14 = num13;
			num15 = 786163454.0;
			num16 = num8;
			obj7 = obj17;
			if (flag7)
			{
				break;
			}
			goto IL_04d1;
			IL_0923:
			double num29;
			double num28 = num29 * num29;
			double num31;
			double num30 = num31 * num31;
			double num32 = num13 * 1139638272.0;
			double num33 = num13 * 1148190720.0;
			double num34 = num28 + num30;
			double num36;
			double num35 = num36 * num36;
			double num37 = num32 + num33;
			double num38 = num35 + num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			double num39 = num38 / num37;
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v29+B8]");
			object obj22 = 0;
			double num40 = num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v30+14]");
			num16 = num40 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v30+C]");
			double num41 = 0.0;
			double num42 = num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v30+10]");
			num15 = num42 * 0.0;
			double num43 = num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v30+C]");
			num14 = num43 * 0.0;
			Transform transform2;
			transform2.localScale = (Vector3)0;
			num17 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v43 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v43 (Il2CppClass<IAnimatedGift>)+12E]");
			double num44;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v43 (Il2CppClass<IAnimatedGift>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v16-8]");
					bool flag8 = 0 == (nint)obj2;
					num44 = 0.5;
					if (flag8)
					{
						break;
					}
					obj7 += 16;
					obj23--;
					if ((nint)obj23 != 1)
					{
						continue;
					}
					goto IL_0acf;
				}
				object obj24 = obj7 + 14;
				object obj25 = num17 + obj24;
				obj26 = obj25 + 312;
				goto IL_0e33;
			}
			goto IL_0acf;
			IL_0658:
			double num45 = num25 - num8;
			double num46 = num45 * 0.5;
			num16 = num8 + num46;
			double num47 = num24 - 786163454.0;
			double num48 = num47 * 0.5;
			num15 = 786163454.0 + num48;
			double num49 = num23 - num13;
			num41 = num49 * 0.5;
			num14 = num13 + num41;
			transform.position = (Vector3)0;
			bool flag9 = (object)spline == null;
			num44 = 0.5;
			obj7 = obj17;
			num17 = num26;
			if (flag9)
			{
				break;
			}
			Transform transform3 = spline.transform;
			bool flag10 = (object)transform3 == null;
			num44 = 0.5;
			obj7 = obj17;
			num17 = num26;
			if (flag10)
			{
				break;
			}
			num29 = num23 - num13;
			num31 = num24 - 786163454.0;
			num36 = num25 - num8;
			transform3.up = (Vector3)0;
			bool flag11 = (object)spline == null;
			num14 = num29;
			num15 = num31;
			num16 = num36;
			num44 = 0.5;
			obj7 = obj17;
			num17 = num26;
			if (flag11)
			{
				break;
			}
			transform2 = spline.transform;
			object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0C7]");
			object obj28 = (nint)0 & (nint)1;
			if (obj28 != null)
			{
				object obj29 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0896;
				}
			}
			else
			{
				_ = 1;
				object obj29 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v23+E4]");
				bool flag12 = (nint)0 == 0;
				object obj30 = !flag12;
				if (obj30 != null)
				{
					goto IL_0896;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			object obj31 = (nint)0 & (nint)1;
			bool flag13 = obj31 == null;
			object obj32 = !flag13;
			if (obj32 != null)
			{
				goto IL_08d9;
			}
			goto IL_0b81;
			IL_0896:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			object obj33 = (nint)0 & (nint)1;
			if (obj33 != null)
			{
				goto IL_08d9;
			}
			goto IL_0b81;
			IL_00e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			vector = (Vector3)1;
			goto IL_0c5b;
			IL_0c5b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X0_v64] (should have been resolved before IL gen)");
			obj11 = obj2;
			num19 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v47 (Il2CppClass<IAnimatedGift>)+12E]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v47 (Il2CppClass<IAnimatedGift>)+12E]");
			bool flag14 = (nint)0 == 0;
			num20 = num13;
			num21 = 786163454.0;
			num22 = num8;
			obj14 = obj2;
			num23 = num13;
			num24 = 786163454.0;
			num25 = num8;
			if (!flag14)
			{
				goto IL_01fa;
			}
			goto IL_0279;
			IL_033e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			vector = (Vector3)4;
			goto IL_0d73;
			IL_03eb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num17 = (nint)obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v681 @ X0_v44] (should have been resolved before IL gen)");
			component = spline;
			bool flag15 = (object)spline == null;
			object obj35 = !flag15;
			vector = (Vector3)0;
			obj17 = obj7;
			if (obj35 == null)
			{
				num15 = 786163454.0;
				break;
			}
			goto IL_04d1;
			IL_08d9:
			bool flag16 = (object)transform2 == null;
			num14 = num29;
			num15 = num31;
			num16 = num36;
			num44 = 0.5;
			obj7 = obj17;
			if (flag16)
			{
				break;
			}
			goto IL_0923;
			IL_01fa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v47 (Il2CppClass<IAnimatedGift>)+B0]");
			object obj36 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X10_v32-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj7 = obj36 + 16;
				obj12--;
				bool flag17 = (nint)obj12 != 1;
				obj14 = obj11;
				num23 = num20;
				num24 = num21;
				num25 = num22;
				obj36 = obj7;
				if (flag17)
				{
					continue;
				}
				goto IL_0279;
			}
			object obj37 = obj36 + 4;
			object obj38 = num19 + obj37;
			object obj39 = obj38 + 312;
			obj7 = obj36;
			num23 = num20;
			num24 = num21;
			num25 = num22;
			goto IL_0d08;
			IL_04d1:
			transform = component.transform;
			nint num50 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v17 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v17 (Il2CppClass<IAnimatedGift>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_057a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v17 (Il2CppClass<IAnimatedGift>)+B0]");
			obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X10_v16-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj17 = obj7 + 16;
				obj40--;
				bool flag18 = (nint)obj40 != 1;
				obj7 = obj17;
				if (flag18)
				{
					continue;
				}
				goto IL_057a;
			}
			object obj41 = num50 + obj7;
			object obj42 = obj41 + 312;
			num26 = (nint)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v753 @ X0_v40] (should have been resolved before IL gen)");
			bool flag19 = (object)transform == null;
			obj17 = obj7;
			num14 = num13;
			num15 = 786163454.0;
			num16 = num8;
			num17 = (nint)obj42;
			if (flag19)
			{
				break;
			}
			goto IL_0658;
			IL_0279:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			vector = (Vector3)4;
			goto IL_0d08;
			IL_0b81:
			_ = 1;
			bool flag20 = (object)transform2 == null;
			object obj43 = !flag20;
			num14 = num29;
			num15 = num31;
			num16 = num36;
			num44 = 0.5;
			obj7 = obj17;
			num17 = 1;
			if (obj43 == null)
			{
				break;
			}
			goto IL_0923;
			IL_0d08:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v5] (should have been resolved before IL gen)");
			nint num51 = (nint)gift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v12 (Il2CppClass<IAnimatedGift>)+12E]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v12 (Il2CppClass<IAnimatedGift>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_033e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v12 (Il2CppClass<IAnimatedGift>)+B0]");
			object obj45 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X10_v24-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj7 = obj45 + 16;
				obj44--;
				bool flag21 = (nint)obj44 != 1;
				obj45 = obj7;
				if (flag21)
				{
					continue;
				}
				goto IL_033e;
			}
			object obj46 = obj45 + 4;
			object obj47 = num51 + obj46;
			object obj48 = obj47 + 312;
			obj7 = obj45;
			goto IL_0d73;
			IL_0e33:
			object obj49 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v3+8]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v474 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_0acf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num44 = 0.5;
			goto IL_0e33;
		}
		throw new NullReferenceException();
	}

	public void SetScaleXSign(float sign)
	{
		//IL_004d: Invalid comparison between F4 and I4
		//IL_0060: Expected O, but got F4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		Transform transform = spline.transform;
		Vector3 localScale = transform.localScale;
		Transform transform2 = spline.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		bool flag = sign < 0f;
		object obj = sign ^ sign;
		object obj2 = sign & obj;
		bool flag2 = (nint)obj2 < 0;
		bool flag3 = flag == flag2;
		object obj3 = !flag3;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
		}
		transform2.localScale = (Vector3)0;
	}
}
