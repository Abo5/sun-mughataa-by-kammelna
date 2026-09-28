using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ProgressMeter : ProgressMeterBase
{
	private List<ProgressBehaviour> behaviours;

	private ProgressAnimation animationMode;

	private float duration;

	private Ease ease;

	private bool replayOnEnable;

	private float maxValue;

	private float currentValue;

	private bool hasValue;

	public float Normalized
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_001d: Expected F4, but got I4
			//IL_005b: Invalid comparison between F4 and I4
			//IL_006a: Invalid comparison between F4 and I4
			//IL_0082: Expected O, but got F8
			//IL_008f: Expected O, but got F4
			//IL_00c4: Expected O, but got I4
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_0130: Invalid comparison between F4 and I4
			//IL_0110: Expected F4, but got I4
			bool flag = !(maxValue > 0f);
			float result = 0f;
			if (!flag)
			{
				float num = currentValue / maxValue;
				float num2 = num - 1f;
				bool flag2 = num2 < 0f;
				bool flag3 = num2 == 0f;
				object obj = (double)num ^ 1.0;
				object obj2 = num ^ num2;
				object obj3 = obj & obj2;
				bool flag4 = (nint)obj3 < 0;
				bool flag5 = flag2 == flag4;
				object obj4 = !flag3;
				object obj5 = flag5 & obj4;
				object obj6 = ~obj5;
				float num3 = ((obj6 != null) ? num : 1f);
				result = ((!(num < 0f)) ? num3 : 0f);
			}
			return result;
		}
	}

	public int CurrentValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_014d: Expected O, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_008e: Expected O, but got I4
			//IL_017a: Invalid comparison between F4 and I4
			//IL_018b: Expected O, but got I4
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01fe: Expected O, but got I4
			//IL_022b: Invalid comparison between F4 and I4
			//IL_023c: Expected O, but got I4
			//IL_025e: Invalid comparison between F4 and I4
			//IL_0275: Expected O, but got F4
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_02ac: Expected O, but got I4
			//IL_02d0: Invalid comparison between F8 and I8
			//IL_011e: Expected I4, but got F8
			//IL_0111: Expected I4, but got I8
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			float num = currentValue + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			double num3 = default(double);
			double num2 = num3 + -1.0;
			object obj4 = num3 & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				num2 = num3;
			}
			float num4 = currentValue - -0.5f;
			bool flag3 = num4 == 0f;
			object obj6 = !flag3;
			object obj7 = ~obj6;
			double num5 = ((obj7 != null) ? num2 : ((double)num));
			float num6 = currentValue + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num7 = num3 + 1.0;
			object obj8 = num3 & 1;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			double num8 = ((obj9 != null) ? num7 : num3);
			float num9 = currentValue - 0.5f;
			bool flag5 = num9 == 0f;
			object obj10 = !flag5;
			object obj11 = ~obj10;
			double num10 = ((obj11 != null) ? num8 : ((double)num6));
			bool flag6 = currentValue < 0f;
			object obj12 = currentValue ^ currentValue;
			object obj13 = currentValue & obj12;
			bool flag7 = (nint)obj13 < 0;
			bool flag8 = flag6 == flag7;
			object obj14 = !flag8;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				num10 = num5;
			}
			if (num10 == 9.218868437227405E+18)
			{
				return -2147483648;
			}
			return (int)num10;
		}
	}

	public int MaxValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_014d: Expected O, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_008e: Expected O, but got I4
			//IL_017a: Invalid comparison between F4 and I4
			//IL_018b: Expected O, but got I4
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01fe: Expected O, but got I4
			//IL_022b: Invalid comparison between F4 and I4
			//IL_023c: Expected O, but got I4
			//IL_025e: Invalid comparison between F4 and I4
			//IL_0275: Expected O, but got F4
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_02ac: Expected O, but got I4
			//IL_02d0: Invalid comparison between F8 and I8
			//IL_011e: Expected I4, but got F8
			//IL_0111: Expected I4, but got I8
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			float num = maxValue + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			double num3 = default(double);
			double num2 = num3 + -1.0;
			object obj4 = num3 & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				num2 = num3;
			}
			float num4 = maxValue - -0.5f;
			bool flag3 = num4 == 0f;
			object obj6 = !flag3;
			object obj7 = ~obj6;
			double num5 = ((obj7 != null) ? num2 : ((double)num));
			float num6 = maxValue + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num7 = num3 + 1.0;
			object obj8 = num3 & 1;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			double num8 = ((obj9 != null) ? num7 : num3);
			float num9 = maxValue - 0.5f;
			bool flag5 = num9 == 0f;
			object obj10 = !flag5;
			object obj11 = ~obj10;
			double num10 = ((obj11 != null) ? num8 : ((double)num6));
			bool flag6 = maxValue < 0f;
			object obj12 = maxValue ^ maxValue;
			object obj13 = maxValue & obj12;
			bool flag7 = (nint)obj13 < 0;
			bool flag8 = flag6 == flag7;
			object obj14 = !flag8;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				num10 = num5;
			}
			if (num10 == 9.218868437227405E+18)
			{
				return -2147483648;
			}
			return (int)num10;
		}
	}

	public bool IsComplete
	{
		get
		{
			//IL_001c: Invalid comparison between F4 and I4
			//IL_0033: Expected O, but got F4
			//IL_0042: Expected O, but got F4
			float num = currentValue - maxValue;
			bool flag = num < 0f;
			object obj = currentValue ^ maxValue;
			object obj2 = currentValue ^ num;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}
	}

	private void Awake()
	{
		//IL_0095: Expected I, but got O
		List<object> list = (List<object>)(object)behaviours;
		int num = 0;
		while (num < list._size)
		{
			object obj = list.get_Item(num);
			if (obj != null)
			{
				GameObject gameObject = base.gameObject;
				nint num2 = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X8_v6 (Il2CppClass<System.Object>)+188] (should have been resolved before IL gen)");
			}
			num++;
			list = (List<object>)(object)behaviours;
		}
	}

	private void OnEnable()
	{
		if (replayOnEnable && hasValue)
		{
			Dispatch(animationMode, duration);
		}
	}

	private void OnDisable()
	{
		//IL_0011: Expected O, but got I
		//IL_0096: Expected I, but got O
		List<object> list = (List<object>)(object)behaviours;
		object obj = (nint)0 + (nint)2696;
		int num = 0;
		while (num < list._size)
		{
			object obj2 = list.get_Item(num);
			if (obj2 != null)
			{
				nint num2 = (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X8_v6 (Il2CppClass<System.Object>)+1D8] (should have been resolved before IL gen)");
			}
			num++;
			list = (List<object>)(object)behaviours;
		}
	}

	private void OnDestroy()
	{
		//IL_0011: Expected O, but got I
		//IL_0096: Expected I, but got O
		List<object> list = (List<object>)(object)behaviours;
		object obj = (nint)0 + (nint)2696;
		int num = 0;
		while (num < list._size)
		{
			object obj2 = list.get_Item(num);
			if (obj2 != null)
			{
				nint num2 = (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X8_v6 (Il2CppClass<System.Object>)+198] (should have been resolved before IL gen)");
			}
			num++;
			list = (List<object>)(object)behaviours;
		}
	}

	public override void SetProgress(int current, int max)
	{
		//IL_000e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c5: Expected F4, but got I4
		//IL_00cf: Expected F4, but got I4
		object obj = max - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = max ^ 1;
		int num2 = max ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : max);
		maxValue = num4;
		currentValue = current;
		hasValue = true;
		Dispatch(animationMode, duration);
	}

	public void SetProgress(int current, int max, ProgressAnimation mode)
	{
		//IL_000e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c5: Expected F4, but got I4
		//IL_00cf: Expected F4, but got I4
		object obj = max - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = max ^ 1;
		int num2 = max ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : max);
		maxValue = num4;
		currentValue = current;
		hasValue = true;
		Dispatch(mode, duration);
	}

	public void SetProgress(int current, int max, ProgressAnimation mode, float duration)
	{
		//IL_000e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c5: Expected F4, but got I4
		//IL_00cf: Expected F4, but got I4
		object obj = max - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = max ^ 1;
		int num2 = max ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : max);
		maxValue = num4;
		currentValue = current;
		hasValue = true;
		Dispatch(mode, duration);
	}

	public override void SetProgressInstant(int current, int max)
	{
		//IL_000e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c5: Expected F4, but got I4
		//IL_00cf: Expected F4, but got I4
		object obj = max - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = max ^ 1;
		int num2 = max ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : max);
		maxValue = num4;
		currentValue = current;
		hasValue = true;
		Dispatch(ProgressAnimation.Immediate, 0f);
	}

	public override void SetText(string text)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_002e: Expected O, but got I4
		//IL_00e2: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		List<object> list = (List<object>)(object)behaviours;
		object obj = (nint)0 + (nint)2696;
		object obj2 = typeof(System.IOAsyncCallback) + 1688;
		object obj3 = 0;
		object obj10 = default(object);
		for (int i = 0; i < list._size; i++, list = (List<object>)(object)behaviours)
		{
			object obj4 = list.get_Item(i);
			if (obj4 == null)
			{
				continue;
			}
			object obj5 = ((List<object>)(object)behaviours).get_Item(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v10 (System.Object)+10]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				continue;
			}
			object obj8 = ((List<object>)(object)behaviours).get_Item(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj9 = ((obj10 != null) ? obj10 : obj3);
			if (obj10 == null)
			{
				continue;
			}
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v8+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_003c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v8+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v8-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_003c;
			}
			obj12 = obj13;
			object obj14 = obj11 + obj13;
			object obj15 = obj14 + 312;
			goto IL_004b;
			IL_003c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_004b;
			IL_004b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v15] (should have been resolved before IL gen)");
			obj3 = obj9;
		}
	}

	public void Kill()
	{
		//IL_0011: Expected O, but got I
		//IL_0096: Expected I, but got O
		List<object> list = (List<object>)(object)behaviours;
		object obj = (nint)0 + (nint)2696;
		int num = 0;
		while (num < list._size)
		{
			object obj2 = list.get_Item(num);
			if (obj2 != null)
			{
				nint num2 = (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X8_v6 (Il2CppClass<System.Object>)+1D8] (should have been resolved before IL gen)");
			}
			num++;
			list = (List<object>)(object)behaviours;
		}
	}

	private void Set(int current, int max, ProgressAnimation mode, float duration)
	{
		//IL_000e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00c5: Expected F4, but got I4
		//IL_00cf: Expected F4, but got I4
		object obj = max - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = max ^ 1;
		int num2 = max ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : max);
		maxValue = num4;
		currentValue = current;
		hasValue = true;
		Dispatch(mode, duration);
	}

	private string DrawBehaviourLabel(object element, int index)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00de: Expected O, but got I
		while (element != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 2232;
			object obj2 = obj;
			nint num = (nint)element;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v8 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X9_v2+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v8 (Il2CppClass<System.Object>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X9_v2+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v3-8]");
			if (0 != (nint)obj2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v8 (Il2CppClass<System.Object>)+178]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v8 (Il2CppClass<System.Object>)+180]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v105 @ X2_v1 (should have been resolved before IL gen)");
		}
		return "Network Authentication Required" + 2376;
	}

	private void Dispatch(ProgressAnimation mode, float duration)
	{
		//IL_041a: Invalid comparison between F8 and I4
		//IL_0429: Invalid comparison between F8 and I4
		//IL_0441: Expected O, but got F8
		//IL_044e: Expected O, but got F8
		//IL_0483: Expected O, but got I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04b0: Invalid comparison between F4 and I4
		//IL_04d2: Invalid comparison between F4 and I4
		//IL_04e3: Invalid comparison between F4 and I4
		//IL_04fa: Expected O, but got F4
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_0531: Expected O, but got I4
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_002d: Expected F8, but got I4
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_08f8: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		//IL_058d: Invalid comparison between F8 and I4
		//IL_059e: Expected O, but got I4
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_0611: Expected O, but got I4
		//IL_063e: Invalid comparison between F8 and I4
		//IL_064f: Expected O, but got I4
		//IL_0671: Invalid comparison between F4 and I4
		//IL_0688: Expected O, but got F4
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_06bf: Expected O, but got I4
		//IL_06e3: Invalid comparison between F8 and I8
		//IL_0930: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_071e: Invalid comparison between F8 and I4
		//IL_072f: Expected O, but got I4
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_07a2: Expected O, but got I4
		//IL_07cf: Invalid comparison between F8 and I4
		//IL_07e0: Expected O, but got I4
		//IL_0802: Invalid comparison between F4 and I4
		//IL_0819: Expected O, but got F4
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_0850: Expected O, but got I4
		//IL_0874: Invalid comparison between F8 and I8
		//IL_0231: Expected O, but got I
		//IL_023e: Expected O, but got I8
		//IL_02f1: Expected O, but got I
		//IL_030b: Expected O, but got I4
		//IL_0339: Expected I, but got O
		//IL_0368: Expected I, but got O
		//IL_025c: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_03da: Expected O, but got I
		//IL_03b5: Expected O, but got I
		//IL_03c5: Expected O, but got I
		float num = currentValue / maxValue;
		double num2 = (double)num - 1.0;
		bool flag = num2 < 0.0;
		bool flag2 = num2 == 0.0;
		object obj = (double)num ^ 1.0;
		object obj2 = (double)num ^ num2;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		double num3 = ((obj6 != null) ? ((double)num) : 1.0);
		if (num < 0f)
		{
			double num4 = 0.0;
		}
		else
		{
			double num4 = num3;
		}
		bool flag5 = maxValue < 0f;
		bool flag6 = maxValue == 0f;
		object obj7 = maxValue ^ maxValue;
		object obj8 = maxValue & obj7;
		bool flag7 = (nint)obj8 < 0;
		bool flag8 = flag5 == flag7;
		object obj9 = !flag8;
		object obj10 = obj9 | flag6;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
		}
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v3+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
		double num5 = (double)currentValue + -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num7 = default(double);
		double num6 = num7 + -1.0;
		object obj15 = num7 & 1;
		bool flag10 = obj15 == null;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			num6 = num7;
		}
		double num8 = (double)currentValue - -0.5;
		bool flag11 = num8 == 0.0;
		object obj17 = !flag11;
		object obj18 = ~obj17;
		double num9 = ((obj18 != null) ? num6 : num5);
		double num10 = (double)currentValue + 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num11 = num7 + 1.0;
		object obj19 = num7 & 1;
		bool flag12 = obj19 == null;
		object obj20 = !flag12;
		double num12 = ((obj20 != null) ? num11 : num7);
		double num13 = (double)currentValue - 0.5;
		bool flag13 = num13 == 0.0;
		object obj21 = !flag13;
		object obj22 = ~obj21;
		double num14 = ((obj22 != null) ? num12 : num10);
		bool flag14 = currentValue < 0f;
		object obj23 = currentValue ^ currentValue;
		object obj24 = currentValue & obj23;
		bool flag15 = (nint)obj24 < 0;
		bool flag16 = flag14 == flag15;
		object obj25 = !flag16;
		object obj26 = ~obj25;
		if (obj26 == null)
		{
			num14 = num9;
		}
		if (num14 == 9.218868437227405E+18)
		{
		}
		object obj27 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v8+E4]");
		bool flag17 = (nint)0 == 0;
		object obj28 = !flag17;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
		double num15 = (double)maxValue + -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num17 = default(double);
		double num16 = num17 + -1.0;
		object obj29 = num17 & 1;
		bool flag18 = obj29 == null;
		object obj30 = !flag18;
		if (obj30 == null)
		{
			num16 = num17;
		}
		double num18 = (double)maxValue - -0.5;
		bool flag19 = num18 == 0.0;
		object obj31 = !flag19;
		object obj32 = ~obj31;
		double num19 = ((obj32 != null) ? num16 : num15);
		double num20 = (double)maxValue + 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num21 = num17 + 1.0;
		object obj33 = num17 & 1;
		bool flag20 = obj33 == null;
		object obj34 = !flag20;
		double num22 = ((obj34 != null) ? num21 : num17);
		double num23 = (double)maxValue - 0.5;
		bool flag21 = num23 == 0.0;
		object obj35 = !flag21;
		object obj36 = ~obj35;
		double num24 = ((obj36 != null) ? num22 : num20);
		bool flag22 = maxValue < 0f;
		object obj37 = maxValue ^ maxValue;
		object obj38 = maxValue & obj37;
		bool flag23 = (nint)obj38 < 0;
		bool flag24 = flag22 == flag23;
		object obj39 = !flag24;
		object obj40 = ~obj39;
		if (obj40 == null)
		{
			num24 = num19;
		}
		if (num24 == 9.218868437227405E+18)
		{
		}
		List<object> list = (List<object>)(object)behaviours;
		object obj41 = (nint)0 + (nint)2696;
		object obj42 = 2147483648L;
		for (int i = 0; i < list._size; i++, list = (List<object>)(object)behaviours)
		{
			object obj43 = list.get_Item(i);
			if (obj43 == null)
			{
				continue;
			}
			object obj44 = ((List<object>)(object)behaviours).get_Item(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v20 (System.Object)+10]");
			object obj45 = (nint)0 & (nint)1;
			bool flag25 = obj45 == null;
			object obj46 = !flag25;
			if (obj46 == null)
			{
				object obj47 = ((List<object>)(object)behaviours).get_Item(i);
				nint num25 = (nint)obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v423 @ X8_v20 (Il2CppClass<System.Object>)+1D8] (should have been resolved before IL gen)");
				object obj48 = ((List<object>)(object)behaviours).get_Item(i);
				nint num26 = (nint)obj48;
				switch (mode)
				{
				case ProgressAnimation.FromCurrent:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<System.Object>)+1C8]");
					obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<System.Object>)+1D0]");
					object obj49 = 0;
					break;
				}
				case ProgressAnimation.FromZero:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<System.Object>)+1B8]");
					obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<System.Object>)+1C0]");
					object obj49 = 0;
					break;
				}
				default:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<System.Object>)+1A8]");
					obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v517 @ X8_v21 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v384 @ X9_v7 (should have been resolved before IL gen)");
				num24 = duration;
			}
		}
	}

	public ProgressMeter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0029: Expected I4, but got I8
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 32;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		animationMode = ProgressAnimation.FromCurrent;
		ease = Ease.OutQuad;
		maxValue = 1f;
		((MonoBehaviour)this)..ctor();
	}
}
