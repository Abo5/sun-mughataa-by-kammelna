using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class AlignToMoveDirection : MonoBehaviour
{
	public float alignDuration = 0.2f;

	private Vector3 lastPosition;

	private float smoothVelocity;

	private float targetAngle;

	private void Start()
	{
		//IL_0078: Expected O, but got I4
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Quaternion quaternion = default(Quaternion);
		lastPosition = (Vector3)quaternion;
		Transform transform2 = base.transform;
		Quaternion rotation = transform2.rotation;
		Quaternion rotation2 = default(Quaternion);
		Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation2);
		object obj = default(object);
		float num = (float)obj * 1.1139274E+09f;
		Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
		targetAngle = num;
	}

	private unsafe void Update()
	{
		//IL_0025: Expected O, but got I4
		//IL_003b: Expected O, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_024b: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0349: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_0369: Expected O, but got I
		//IL_0387: Expected O, but got I
		//IL_03a1: Expected O, but got I4
		//IL_03b9: Expected O, but got I
		//IL_03c9: Expected O, but got I
		//IL_0601: Expected O, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0688: Invalid comparison between F4 and I4
		//IL_01e1: Expected O, but got I
		//IL_0481: Invalid comparison between F4 and I4
		//IL_0490: Invalid comparison between F4 and I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04b1: Expected O, but got F4
		//IL_04e6: Expected O, but got I4
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_06ad: Expected F4, but got I
		//IL_06be: Expected O, but got I
		//IL_06cf: Expected F4, but got I
		//IL_06dd: Invalid comparison between F4 and I4
		//IL_0513: Expected F4, but got I4
		//IL_0721: Invalid comparison between F4 and I4
		//IL_0730: Invalid comparison between F4 and I4
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_0751: Expected O, but got F4
		//IL_0786: Expected O, but got I4
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_052e: Expected F4, but got I4
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected Ref, but got Unknown
		//IL_0565: Expected O, but got I
		//IL_05b8: Expected O, but got I4
		//IL_05de: Expected O, but got F4
		Transform transform = base.transform;
		Vector3 position = transform.position;
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
				goto IL_00a7;
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
				goto IL_00a7;
			}
		}
		_ = 1;
		object obj9 = default(object);
		object obj8 = obj9 - (object)lastPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AlignToMoveDirection)+28]");
		object obj11 = default(object);
		object obj10 = obj11 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AlignToMoveDirection)+2C]");
		object obj13 = default(object);
		object obj12 = obj13 - 0;
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		object obj16 = obj12;
		object obj17 = obj10;
		object obj18 = obj8;
		if (obj15 != null)
		{
			goto IL_0125;
		}
		goto IL_030a;
		IL_03d7:
		_ = 1;
		object obj20;
		object obj19 = obj20;
		object obj22;
		object obj21 = obj22;
		object obj24;
		object obj23 = obj24;
		goto IL_05e9;
		IL_05e9:
		object obj26;
		object obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v13+B8]");
		object obj27 = 0;
		object obj28 = obj19 - obj27;
		object obj29 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v25+4]");
		object obj30 = obj29 - 0;
		float num = (float)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v25+8]");
		float num2 = num - 0f;
		object obj31 = obj28 * obj28;
		object obj32 = obj30 * obj30;
		object obj33 = obj31 + obj32;
		float num3 = num2 * num2;
		float num4 = num3 + (float)obj33;
		if (!(num4 < 786163460f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v25+18]");
			float num5 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v25+1C]");
			object obj34 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v25+20]");
			float num6 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @513A294");
			targetAngle = num5;
			num2 = num6;
		}
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 eulerAngles = transform3.eulerAngles;
		float deltaTime = Time.deltaTime;
		float num7 = targetAngle - num2;
		float num8 = num7 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num9 = num8 * 3.2833536E+09f;
		float num10 = num7 + num9;
		float num11 = num10 - 1.13587E+09f;
		bool flag4 = num11 < 0f;
		bool flag5 = num11 == 0f;
		object obj35 = num10 ^ 0x43B40000;
		object obj36 = num10 ^ num11;
		object obj37 = obj35 & obj36;
		bool flag6 = (nint)obj37 < 0;
		bool flag7 = flag4 == flag6;
		object obj38 = !flag5;
		object obj39 = flag7 & obj38;
		object obj40 = ~obj39;
		float num12 = ((obj40 != null) ? num10 : 1.13587E+09f);
		float num13 = ((!(num10 < 0f)) ? num12 : 0f);
		float num14 = num13 + 3.2833536E+09f;
		float num15 = num13 - 1.1274813E+09f;
		bool flag8 = num15 < 0f;
		bool flag9 = num15 == 0f;
		object obj41 = num13 ^ 0x43340000;
		object obj42 = num13 ^ num15;
		object obj43 = obj41 & obj42;
		bool flag10 = (nint)obj43 < 0;
		bool flag11 = flag8 == flag10;
		object obj44 = !flag9;
		object obj45 = flag11 & obj44;
		object obj46 = ~obj45;
		if (obj46 == null)
		{
			num13 = num14;
		}
		float target = num2 + num13;
		float num16 = Mathf.SmoothDamp(num2, target, ref *(float*)(this + 48), alignDuration, 1f / 0f, deltaTime);
		object obj47 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v22+B8]");
		object obj48 = 0;
		float num17 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v23+50]");
		float num18 = num17 * 0f;
		float num19 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v23+4C]");
		float num20 = num19 * 0f;
		float num21 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v23+48]");
		float num22 = num21 * 0f;
		transform2.eulerAngles = (Vector3)0;
		Transform transform4 = base.transform;
		Vector3 position2 = transform4.position;
		lastPosition = (Vector3)num22;
		return;
		IL_0125:
		obj26 = typeof(UsageHint) + 816;
		object obj49 = obj8 * obj8;
		object obj50 = obj10 * obj10;
		object obj51 = obj49 + obj50;
		object obj52 = obj12 * obj12;
		object obj53 = obj51 + obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if ((nint)obj53 > 925353388)
		{
			obj20 = obj8 / obj53;
			obj22 = obj10 / obj53;
			obj24 = obj12 / obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
			object obj54 = (nint)0 & (nint)1;
			if (obj54 == null)
			{
				goto IL_03d7;
			}
			obj19 = obj20;
			obj21 = obj22;
			obj23 = obj24;
		}
		else
		{
			object obj55 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v35+B8]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v36+4]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v36+8]");
			obj24 = 0;
			obj20 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
			object obj57 = (nint)0 & (nint)1;
			bool flag12 = obj57 == null;
			object obj58 = !flag12;
			obj19 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v36+4]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v36+8]");
			obj23 = 0;
			if (obj58 == null)
			{
				goto IL_03d7;
			}
		}
		goto IL_05e9;
		IL_00a7:
		obj8 = obj9 - (object)lastPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AlignToMoveDirection)+28]");
		obj10 = obj11 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AlignToMoveDirection)+2C]");
		obj12 = obj13 - 0;
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v5+E4]");
		bool flag13 = (nint)0 == 0;
		obj16 = obj12;
		obj17 = obj10;
		obj18 = obj8;
		if (!flag13)
		{
			goto IL_0125;
		}
		goto IL_030a;
		IL_030a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj16;
		obj10 = obj17;
		obj8 = obj18;
		goto IL_0125;
	}
}
