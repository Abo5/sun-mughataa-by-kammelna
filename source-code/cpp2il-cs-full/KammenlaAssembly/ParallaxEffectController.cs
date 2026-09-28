using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class ParallaxEffectController : MonoBehaviour
{
	private Vector2 shift;

	private float layerDistance;

	private Transform[] layers;

	private float maxShift;

	private AnimationCurve shiftCurve;

	private Vector2 processedShift
	{
		get
		{
			if (shiftCurve != null)
			{
				float time = (float)shift / maxShift;
				float num = shiftCurve.Evaluate(time);
				if (shiftCurve != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ParallaxEffectController)+24]");
					float time2 = 0f / maxShift;
					float num2 = shiftCurve.Evaluate(time2);
					return (Vector2)shiftCurve;
				}
			}
			return (Vector2)new NullReferenceException();
		}
	}

	public Vector2 Shift
	{
		get
		{
			return (Vector2)this;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
			Vector2 vector = default(Vector2);
			shift = vector;
			UpdatePositions();
		}
	}

	private void UpdatePositions()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_0146: Expected I, but got O
		//IL_014f: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_00dd: Expected I, but got O
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_01d3: Expected O, but got F4
		//IL_020d: Expected O, but got F4
		//IL_0232: Expected O, but got I4
		//IL_0232: Expected O, but got I
		//IL_023f: Expected I, but got O
		Transform[] array = layers;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		for (object obj2 = 0; (nint)obj2 < array.Length; obj2++, array = layers)
		{
			object obj3 = (object)array + obj2;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v5+E4]");
			object obj7;
			object obj6;
			nint num;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+20]");
				bool flag = (UnityEngine.Object)0 == null;
				bool flag2 = !flag;
				object obj5 = !flag2;
				obj6 = 0;
				num = unchecked((nint)null);
				if (obj5 != null)
				{
					continue;
				}
				obj7 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+20]");
				bool flag3 = (UnityEngine.Object)0 == null;
				bool flag4 = !flag3;
				object obj8 = !flag4;
				obj6 = 0;
				num = unchecked((nint)null);
				obj7 = 0;
				if (obj8 != null)
				{
					continue;
				}
			}
			float time = (float)shift / maxShift;
			float num2 = shiftCurve.Evaluate(time);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ParallaxEffectController)+24]");
			float time2 = 0f / maxShift;
			float num3 = shiftCurve.Evaluate(time2);
			float num4 = maxShift * num3;
			object obj9 = 0f - num4;
			float num5 = layerDistance * (float)obj2;
			float num6 = (float)obj9 * num5;
			float num7 = maxShift * num2;
			object obj10 = 0f - num7;
			float num8 = (float)obj10 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+20]");
			((Transform)0).localPosition = (Vector3)0;
			obj6 = obj7;
			num = unchecked((nint)null);
		}
	}

	public void ShiftTo(Vector3 value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		Vector2 vector = default(Vector2);
		shift = vector;
		UpdatePositions();
	}

	public void ShiftBy(Vector3 shiftByAmount)
	{
		object obj = default(object);
		Vector2 vector = (Vector2)(obj + (object)shift);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		shift = vector;
		UpdatePositions();
	}
}
