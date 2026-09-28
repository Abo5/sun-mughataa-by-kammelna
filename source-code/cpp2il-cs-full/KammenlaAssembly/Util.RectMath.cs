using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

namespace Util;

public static class RectMath
{
	private static readonly Vector3[] s_Corners;

	public static float CalculateRectTransformUpDistance(RectTransform rectTransform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3560;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Bounds bounds = CalculateRectTransformBounds(rectTransform);
		RectTransform rectTransform2 = UIExtensions.parentRt(rectTransform);
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = rectTransform2.rect;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default(object);
		double num = (double)obj7 * 0.5;
		object obj9 = default(object);
		object obj10 = default(object);
		object obj8 = obj9 - obj10;
		double num2 = num - (double)obj8;
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		return (float)num2 + (float)obj8;
	}

	public static float CalculateRectTransformDownDistance(RectTransform rectTransform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3560;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Bounds bounds = CalculateRectTransformBounds(rectTransform);
		RectTransform rectTransform2 = UIExtensions.parentRt(rectTransform);
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = rectTransform2.rect;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default(object);
		double num = (double)obj7 * 0.5;
		object obj9 = default(object);
		object obj10 = default(object);
		object obj8 = obj9 + obj10;
		double num2 = (double)obj8 + num;
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		return (float)num2 + (float)obj8;
	}

	public unsafe static Bounds CalculateRectTransformBounds(RectTransform child, Transform parent = null)
	{
		//IL_083c: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_0323: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_017a: Expected O, but got I8
		//IL_038f: Expected O, but got I4
		//IL_03fe: Expected O, but got I8
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_028e: Invalid comparison between F8 and I4
		//IL_03bf: Expected O, but got I
		//IL_02bb: Expected F8, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_0508: Invalid comparison between F8 and I4
		//IL_086a: Invalid comparison between F8 and I4
		//IL_0879: Invalid comparison between F8 and I4
		//IL_088c: Expected O, but got F8
		//IL_0899: Expected O, but got F8
		//IL_08ce: Expected O, but got I4
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_0535: Expected F8, but got I4
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0aba: Invalid comparison between F8 and I4
		//IL_0ac9: Invalid comparison between F8 and I4
		//IL_0adc: Expected O, but got F8
		//IL_0ae9: Expected O, but got F8
		//IL_0b1e: Expected O, but got I4
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected O, but got Unknown
		//IL_09f5: Invalid comparison between F8 and I4
		//IL_0a04: Invalid comparison between F8 and I4
		//IL_0a17: Expected O, but got F8
		//IL_0a24: Expected O, but got F8
		//IL_0a59: Expected O, but got I4
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0b64: Expected O, but got I4
		//IL_0b74: Expected O, but got I
		//IL_0b84: Expected O, but got I
		//IL_0b94: Expected O, but got I
		//IL_05ed: Expected O, but got I4
		//IL_0576: Expected O, but got I
		//IL_059d: Expected O, but got I
		//IL_05ad: Expected O, but got I
		//IL_05bd: Expected O, but got I
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Expected O, but got Unknown
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0cf2: Invalid comparison between F8 and I4
		//IL_0d01: Invalid comparison between F8 and I4
		//IL_0d14: Expected O, but got F8
		//IL_0d21: Expected O, but got F8
		//IL_0d56: Expected O, but got I4
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected O, but got Unknown
		//IL_0bba: Invalid comparison between F8 and I4
		//IL_0bc9: Invalid comparison between F8 and I4
		//IL_0bdc: Expected O, but got F8
		//IL_0be9: Expected O, but got F8
		//IL_0c1e: Expected O, but got I4
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0c64: Expected O, but got I4
		//IL_0706: Expected O, but got I8
		//IL_06c7: Expected O, but got I
		//IL_0dd8: Expected O, but got I
		//IL_0e49: Invalid comparison between F8 and I4
		//IL_0e58: Invalid comparison between F8 and I4
		//IL_0e6b: Expected O, but got F8
		//IL_0e78: Expected O, but got F8
		//IL_0ead: Expected O, but got I4
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected O, but got Unknown
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected O, but got Unknown
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected O, but got Unknown
		//IL_0fc3: Expected native int or pointer, but got O
		//IL_0fe4: Expected native int or pointer, but got O
		bool flag = (object)parent == null;
		object obj = !flag;
		Transform transform = parent;
		if (obj != null)
		{
			goto IL_0054;
		}
		if ((object)child != null)
		{
			Transform parent2 = child.parent;
			bool flag2 = (object)parent2 == null;
			transform = parent2;
			if (!flag2)
			{
				goto IL_0054;
			}
		}
		goto IL_0806;
		IL_0806:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0814;
		IL_0ff3:
		object obj2 = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+44]");
		object obj4 = default(object);
		object obj3 = obj4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+48]");
		object obj6 = default(object);
		object obj5 = obj6 * 0;
		object obj7 = obj3 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+4C]");
		object obj9 = default(object);
		object obj8 = obj9 * 0;
		object obj10 = obj7 + obj8;
		object obj11 = default(object);
		double num = (double)obj11 + (double)obj10;
		double num3;
		double num2 = num - num3;
		bool flag3 = num2 < 0.0;
		bool flag4 = num2 == 0.0;
		object obj12 = num ^ num3;
		object obj13 = num ^ num2;
		object obj14 = obj12 & obj13;
		bool flag5 = (nint)obj14 < 0;
		bool flag6 = flag3 == flag5;
		object obj15 = !flag4;
		object obj16 = flag6 & obj15;
		object obj17 = ~obj16;
		double num4 = ((obj17 != null) ? num3 : num);
		object obj19;
		object obj20 = default(object);
		object obj18 = obj19 * obj20;
		object obj22;
		object obj23 = default(object);
		object obj21 = obj22 * obj23;
		object obj25;
		object obj26 = default(object);
		object obj24 = obj25 * obj26;
		double num5;
		if (!(num < num5))
		{
			num = num5;
		}
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v13+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v14+8]");
		double num6 = 0.0 * 0.5;
		double num7 = num - num6;
		if (!(num7 < num4))
		{
			num7 = num4;
		}
		double num8 = num + num6;
		double num9 = num8 - num4;
		bool flag7 = num9 < 0.0;
		bool flag8 = num9 == 0.0;
		object obj29 = num8 ^ num4;
		object obj30 = num8 ^ num9;
		object obj31 = obj29 & obj30;
		bool flag9 = (nint)obj31 < 0;
		bool flag10 = flag7 == flag9;
		object obj32 = !flag8;
		object obj33 = flag10 & obj32;
		object obj34 = ~obj33;
		if (obj34 != null)
		{
			num8 = num4;
		}
		double num10 = num8 - num7;
		double num11 = num10 * 0.5;
		object obj35 = obj18 + obj21;
		object obj36 = obj35 + obj24;
		object obj38;
		object obj37 = obj38 + obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
		object obj39 = obj28 * 63;
		object obj40 = obj37 - obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
		object obj41 = obj37 + obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
		object obj42 = obj41 - obj40;
		Vector3 vector = (Vector3)(obj42 * 63);
		Vector3 center = (Vector3)(obj40 + (object)vector);
		Bounds bounds = default(Bounds);
		((Bounds*)(nint)bounds)->m_Center = center;
		double num12 = num7 + num11;
		((Bounds*)(nint)bounds)->m_Extents = vector;
		Bounds result;
		return result;
		IL_0054:
		object obj43 = typeof(System.Buffers.Text.ParserHelpers) + 3560;
		Matrix4x4 worldToLocalMatrix = transform.worldToLocalMatrix;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v9+E4]");
		bool flag11 = (nint)0 == 0;
		object obj45 = !flag11;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((object)child == null)
		{
			goto IL_0806;
		}
		object obj46 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v7+B8]");
		object fourCornersArray = 0;
		child.GetWorldCorners((Vector3[])fourCornersArray);
		result = (Bounds)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+E4]");
		object obj77 = default(object);
		object obj78 = default(object);
		object obj79 = default(object);
		object obj80 = default(object);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+B8]");
			object obj47 = 0;
			object obj48 = obj47;
			if (obj47 == null)
			{
				goto IL_0806;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+18]");
			object obj49 = 0 & 0xFFFFFFFCL;
			if (obj49 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+20]");
				object obj50 = obj4 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+24]");
				object obj51 = obj6 * 0;
				object obj52 = obj50 + obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+28]");
				object obj53 = obj9 * 0;
				object obj54 = obj52 + obj53;
				double num13 = (double)obj11 + (double)obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+2C]");
				object obj55 = obj4 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+30]");
				object obj56 = obj6 * 0;
				object obj57 = obj55 + obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+34]");
				object obj58 = obj9 * 0;
				object obj59 = obj57 + obj58;
				double num14 = (double)obj11 + (double)obj59;
				double num15 = ((!(num14 < 2139095039.0)) ? 2139095039.0 : num14);
				double num16 = num14 - num13;
				bool flag12 = num16 < 0.0;
				bool flag13 = num16 == 0.0;
				object obj60 = num14 ^ num13;
				object obj61 = num14 ^ num16;
				object obj62 = obj60 & obj61;
				bool flag14 = (nint)obj62 < 0;
				bool flag15 = flag12 == flag14;
				object obj63 = !flag13;
				object obj64 = flag15 & obj63;
				object obj65 = ~obj64;
				if (obj65 == null)
				{
					num13 = num14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+38]");
				object obj66 = obj4 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+3C]");
				object obj67 = obj6 * 0;
				object obj68 = obj66 + obj67;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+40]");
				object obj69 = obj9 * 0;
				object obj70 = obj68 + obj69;
				double num17 = (double)obj11 + (double)obj70;
				num5 = ((!(num17 < num15)) ? num15 : num17);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
				double num18 = num17 - num13;
				bool flag16 = num18 < 0.0;
				bool flag17 = num18 == 0.0;
				object obj71 = num17 ^ num13;
				object obj72 = num17 ^ num18;
				object obj73 = obj71 & obj72;
				bool flag18 = (nint)obj73 < 0;
				bool flag19 = flag16 == flag18;
				object obj74 = !flag17;
				object obj75 = flag19 & obj74;
				object obj76 = ~obj75;
				num3 = ((obj76 != null) ? num13 : num17);
				obj38 = obj77;
				obj25 = obj78;
				obj22 = obj79;
				obj19 = obj80;
				goto IL_0ff3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			result = (Bounds)obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+B8]");
			object obj81 = 0;
			object obj48 = obj81;
			if (obj81 == null)
			{
				goto IL_0806;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+E4]");
				bool flag20 = (nint)0 == 0;
				object obj82 = !flag20;
				if (obj82 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					result = (Bounds)obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+B8]");
					object obj83 = 0;
					obj48 = obj83;
					if (obj83 == null)
					{
						goto IL_0806;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+18]");
				object obj84 = 0 & 0xFFFFFFFEL;
				if (obj84 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+20]");
					object obj85 = obj4 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+24]");
					object obj86 = obj6 * 0;
					object obj87 = obj85 + obj86;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+28]");
					object obj88 = obj9 * 0;
					object obj89 = obj87 + obj88;
					double num19 = (double)obj11 + (double)obj89;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+2C]");
					object obj90 = obj4 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+30]");
					object obj91 = obj6 * 0;
					object obj92 = obj90 + obj91;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+34]");
					object obj93 = obj9 * 0;
					object obj94 = obj92 + obj93;
					double num20 = (double)obj11 + (double)obj94;
					num5 = ((!(num20 < 2139095039.0)) ? 2139095039.0 : num20);
					double num21 = num20 - num19;
					bool flag21 = num21 < 0.0;
					bool flag22 = num21 == 0.0;
					object obj95 = num20 ^ num19;
					object obj96 = num20 ^ num21;
					object obj97 = obj95 & obj96;
					bool flag23 = (nint)obj97 < 0;
					bool flag24 = flag21 == flag23;
					object obj98 = !flag22;
					object obj99 = flag24 & obj98;
					object obj100 = ~obj99;
					num3 = ((obj100 != null) ? num19 : num20);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+E4]");
					bool flag25 = (nint)0 == 0;
					object obj101 = !flag25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+20]");
					object obj102 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+24]");
					object obj103 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+28]");
					object obj104 = 0;
					if (obj101 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						result = (Bounds)obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+B8]");
						object obj105 = 0;
						obj48 = obj105;
						bool flag26 = obj105 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+20]");
						obj102 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+24]");
						obj103 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+28]");
						obj104 = 0;
						if (flag26)
						{
							goto IL_0806;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+18]");
					bool flag27 = (nint)0 < (nint)3;
					object obj106 = !flag27;
					object obj107 = ~obj106;
					if (obj107 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+38]");
						object obj108 = obj4 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+3C]");
						object obj109 = obj6 * 0;
						object obj110 = obj108 + obj109;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+40]");
						object obj111 = obj9 * 0;
						object obj112 = obj110 + obj111;
						double num22 = (double)obj11 + (double)obj112;
						if (num22 < num5)
						{
							num5 = num22;
						}
						double num23 = num22 - num3;
						bool flag28 = num23 < 0.0;
						bool flag29 = num23 == 0.0;
						object obj113 = num22 ^ num3;
						object obj114 = num22 ^ num23;
						object obj115 = obj113 & obj114;
						bool flag30 = (nint)obj115 < 0;
						bool flag31 = flag28 == flag30;
						object obj116 = !flag29;
						object obj117 = flag31 & obj116;
						object obj118 = ~obj117;
						if (obj118 == null)
						{
							num3 = num22;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v14 (UnityEngine.Bounds)+E4]");
						bool flag32 = (nint)0 == 0;
						object obj119 = !flag32;
						if (obj119 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj120 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v21+B8]");
							object obj121 = 0;
							obj48 = obj121;
							if (obj121 == null)
							{
								goto IL_0806;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v10+18]");
						object obj122 = 0 & 0xFFFFFFFCL;
						if (obj122 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
							obj38 = obj77;
							obj25 = obj78;
							obj22 = obj79;
							obj19 = obj80;
							goto IL_0ff3;
						}
					}
				}
			}
		}
		goto IL_0814;
		IL_0814:
		return (Bounds)new IndexOutOfRangeException();
	}

	static RectMath()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 528;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj3 = obj2;
		object obj5 = default(object);
		object obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
