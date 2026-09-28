using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public static class VectorExtensions
{
	private static readonly Vector3[] Directions;

	public static Vector2 ClampY(Vector2 vector, float min, float max)
	{
		//IL_0018: Invalid comparison between F4 and I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0047: Expected O, but got F4
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00b2: Invalid comparison between F4 and O
		object obj = default(object);
		float num = max - (float)obj;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj2 = max ^ obj;
		object obj3 = max ^ num;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		object obj8 = default(object);
		if ((object)max < obj8)
		{
		}
		return vector;
	}

	public static Vector2 ClampX(Vector2 vector, float min, float max)
	{
		//IL_0018: Invalid comparison between F4 and I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0047: Expected O, but got F4
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00b2: Invalid comparison between F4 and O
		object obj = default(object);
		float num = min - (float)obj;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj2 = min ^ obj;
		object obj3 = min ^ num;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		object obj8 = default(object);
		if ((object)min < obj8)
		{
		}
		return vector;
	}

	public static Vector3 ClosestDirection(Vector3 targetVector)
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0057: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0072: Expected O, but got I8
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 928;
		Vector3 result = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			result = (Vector3)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector3)+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+18]");
				object obj5 = (nint)0 & (nint)0x7FFFFFFF;
				object obj6 = obj3 + 40;
				object obj7 = 4286578688L;
				object obj9 = default(object);
				object obj11 = default(object);
				object obj14 = default(object);
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v4-8]");
					object obj8 = obj9 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v4-4]");
					object obj10 = obj11 * 0;
					object obj12 = obj8 + obj10;
					object obj13 = obj14 * obj6;
					object obj15 = obj13 + obj12;
					if (obj15 > obj7)
					{
						obj7 = obj15;
					}
					obj6 += 12;
					obj5--;
				}
				while ((nint)obj5 != 1);
			}
			return result;
		}
		return (Vector3)new NullReferenceException();
	}

	public static void MirrorX(Vector3 vectorToMirror)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 928;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
	}

	public static void MirrorY(Vector3 vectorToMirror)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 928;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
	}

	public static void MirrorZ(Vector3 vectorToMirror)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 928;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
	}

	public static void SetX(Vector3 vectorToSet, float x)
	{
	}

	public static void SetY(Vector3 vectorToSet, float y)
	{
	}

	public static void SetZ(Vector3 vectorToSet, float z)
	{
	}

	static VectorExtensions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_0204: Expected O, but got I8
		//IL_00a1: Expected O, but got I
		//IL_0243: Expected O, but got I4
		//IL_0259: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_02a6: Expected O, but got I8
		//IL_010f: Expected O, but got I
		//IL_02e5: Expected O, but got I4
		//IL_02fb: Expected O, but got I
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0350: Expected O, but got I4
		//IL_0366: Expected O, but got I
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0191: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj2 = typeof(UsageHint) + 816;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v4+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v4+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X9_v6+B8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X9_v7+3C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X9_v7+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X9_v9+B8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X9_v10+48]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X9_v10+50]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						object obj15 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X9_v12+B8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X9_v13+54]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X9_v13+5C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							object obj21 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v15+B8]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v16+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v16+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
							bool flag5 = (nint)0 < (nint)5;
							object obj23 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
							object obj24 = -5;
							bool flag6 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag6;
							if (obj26 == null)
							{
								object obj27 = typeof(UsageHint) + 928;
								object obj28 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X9_v18+B8]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v19+24]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v19+2C]");
								_ = 0;
								object obj30 = obj27;
								object obj32 = default(object);
								object obj31 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
