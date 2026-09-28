using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;

[Serializable]
public class ScaleNearestItemBehavior : ScrollSnapProximityBehavior
{
	public float minScale;

	public float maxScale;

	public override void OnProximityUpdated(IReadOnlyList<ScrollSnapItemProximity> items, RectTransform nearestItem)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		//IL_0061: Expected O, but got I
		//IL_0081: Expected F8, but got I4
		//IL_00b3: Expected F8, but got I4
		//IL_0175: Invalid comparison between F8 and O
		//IL_0213: Expected I, but got O
		//IL_0223: Expected O, but got I
		//IL_00d7: Expected O, but got I
		//IL_04c5: Invalid comparison between F8 and I4
		//IL_04d4: Invalid comparison between F8 and I4
		//IL_04ec: Expected O, but got F8
		//IL_04f9: Expected O, but got F8
		//IL_052e: Expected O, but got I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_025e: Expected O, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01bb: Invalid comparison between F8 and O
		//IL_01dc: Expected O, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_055b: Invalid comparison between F8 and I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0306: Expected F8, but got I4
		//IL_0363: Expected O, but got I
		//IL_03b6: Expected O, but got I4
		//IL_03d6: Expected I, but got O
		//IL_03e6: Expected O, but got I
		//IL_0408: Expected O, but got I4
		//IL_042e: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2288;
		object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2520;
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = obj;
		nint num = (nint)items;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+12E]");
		bool flag = (nint)0 == 0;
		double num2 = 0.0;
		double num4 = default(double);
		double num3 = num4;
		object obj7 = default(object);
		object obj6 = obj7;
		double num6 = default(double);
		double num5 = num6;
		double num8 = default(double);
		double num7 = num8;
		object obj8 = obj;
		double num9 = 0.0;
		if (!flag)
		{
			goto IL_00c1;
		}
		goto IL_0159;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		object obj10;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v14-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj10 = obj9 + 16;
			obj5--;
			bool flag2 = (nint)obj5 != 1;
			num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v12+C]");
			obj6 = 0;
			num5 = num6;
			num7 = num8;
			obj8 = obj4;
			num9 = num2;
			obj9 = obj10;
			if (flag2)
			{
				continue;
			}
			goto IL_0159;
		}
		object obj11 = num + obj9;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v367 @ X0_v22] (should have been resolved before IL gen)");
		object obj13 = default(object);
		bool flag3 = (object)num2 >= obj13;
		num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v12+C]");
		obj6 = 0;
		num5 = num6;
		num7 = num8;
		obj10 = obj9;
		num9 = num2;
		if (!flag3)
		{
			goto IL_020b;
		}
		return;
		IL_049e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v480 @ X0_v6] (should have been resolved before IL gen)");
		double num10 = num9 - 1.0;
		bool flag4 = num10 < 0.0;
		bool flag5 = num10 == 0.0;
		object obj14 = num9 ^ 1.0;
		object obj15 = num9 ^ num10;
		object obj16 = obj14 & obj15;
		bool flag6 = (nint)obj16 < 0;
		bool flag7 = flag4 == flag6;
		object obj17 = !flag5;
		object obj18 = flag7 & obj17;
		object obj19 = ~obj18;
		double num11 = ((obj19 != null) ? num9 : 1.0);
		double num12 = ((!(num9 < 0.0)) ? num11 : 0.0);
		float num13 = maxScale - minScale;
		double num14 = (double)num13 * num12;
		double num15 = (double)minScale + num14;
		object obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+B8]");
		object obj21 = 0;
		double num16 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v12+14]");
		num4 = num16 * 0.0;
		double num17 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v12+10]");
		num8 = num17 * 0.0;
		double num18 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v12+C]");
		num6 = num18 * 0.0;
		Transform transform = default(Transform);
		transform.localScale = (Vector3)0;
		num2 = num9 + 1.0;
		obj4 = obj;
		num = (nint)items;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+12E]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+12E]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 != null)
		{
			goto IL_00c1;
		}
		num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v12+C]");
		obj6 = 0;
		num5 = num6;
		num7 = num8;
		obj8 = obj;
		num9 = num2;
		goto IL_0159;
		IL_02a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_049e;
		IL_020b:
		nint num19 = (nint)items;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ScrollSnapItemProximity>>)+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v8-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj10 = obj24 + 16;
			obj23--;
			bool flag9 = (nint)obj23 != 1;
			obj24 = obj10;
			if (flag9)
			{
				continue;
			}
			goto IL_02a7;
		}
		object obj25 = num19 + obj24;
		object obj26 = obj25 + 312;
		obj10 = obj24;
		goto IL_049e;
		IL_0159:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X0_v18] (should have been resolved before IL gen)");
		object obj27 = default(object);
		if ((object)num9 >= obj27)
		{
			return;
		}
		goto IL_020b;
	}

	public ScaleNearestItemBehavior()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253128]");
		minScale = 0f;
		((object)this)..ctor();
	}
}
